import React, { useState, useEffect } from 'react';
import { useNavigate, useParams } from 'react-router-dom';
import {
    Folder, Wallet, Laptop, Smartphone, Calendar,
    MapPin, CheckCircle, XCircle, Tag, ArrowRight, Sparkles, ShieldAlert, ShieldCheck
} from 'lucide-react';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';
import api from '../api/axios';

const API_BASE_URL = import.meta.env.VITE_API_BASE_URL;

// ============================================================================
// HELPER FUNCTIONS
// Here we define small utilities used to keep the main component clean.
// ============================================================================

/**
 * Gets a Lucide React icon based on the string category/type name.
 * If the type name includes keywords like "wallet", it returns the Wallet icon.
 */
const getCategoryIcon = (itemType, size = 36) => {
    if (!itemType) return <Folder size={size} />;

    // Convert to lowercase to make checking easier
    const typeLabel = itemType.toLowerCase();

    // Check for specific keywords and return the corresponding icon
    if (typeLabel.includes('wallet')) return <Wallet size={size} />;
    if (typeLabel.includes('laptop')) return <Laptop size={size} />;
    if (typeLabel.includes('phone') || typeLabel.includes('mobile') ||
        typeLabel.includes('earphone') || typeLabel.includes('headphone')) {
        return <Smartphone size={size} />;
    }

    // Default folder icon if no matches found
    return <Folder size={size} />;
};

/**
 * Formats a given date string into a highly readable format (e.g., "Mar 10, 2026").
 * Returns "—" if the date string is null or undefined.
 */
const formatReadableDate = (dateString) => {
    if (!dateString) return '—';
    return new Date(dateString).toLocaleDateString('en-US', {
        month: 'short',
        day: 'numeric',
        year: 'numeric'
    });
};

/**
 * Extracts a value from an object using a list of possible property names.
 * This is incredibly useful for connecting to a C# API where JSON property names 
 * might be PascalCase (e.g., 'ImageUrl') or camelCase (e.g., 'imageUrl').
 * It checks 'keys' one by one and returns the first matching value.
 */
const extractValue = (itemObject, ...possibleKeys) => {
    for (const key of possibleKeys) {
        // Ensure the value exists and is not null or an empty string
        if (itemObject?.[key] !== undefined && itemObject?.[key] !== null && itemObject?.[key] !== '') {
            return itemObject[key];
        }
    }

    // Return null if none of the possible keys had a valid value
    return null;
};

// ============================================================================
// MAIN COMPONENT: MatchDetails
// This page acts as a secure "Comparison Screen" for users holding a 
// potential match notification. It fetches both the Lost and Found item
// reports and displays them side-by-side. 
// ============================================================================
const MatchDetails = () => {
    const navigate = useNavigate();

    // Extracts item IDs from the URL Route (e.g., /match-details/2/5)
    const { lostItemId, foundItemId } = useParams();

    // -- Component State variables --
    const [lostItemData, setLostItemData] = useState(null);
    const [foundItemData, setFoundItemData] = useState(null);
    const [isLoading, setIsLoading] = useState(true);
    const [errorMessage, setErrorMessage] = useState(null);

    // Fetch the detailed data of both items from the backend API on initial load.
    useEffect(() => {
        const fetchMatchInformation = async () => {
            try {
                // If both parameters are accessible from the URL
                if (lostItemId && foundItemId) {

                    // Fetch both items simultaneously using Promise.all to save time
                    const [lostResponse, foundResponse] = await Promise.all([
                        api.get(`Item/get-by-id/${lostItemId}`),
                        api.get(`Item/get-by-id/${foundItemId}`)
                    ]);

                    // Store results securely into state, checking for casing differences
                    setLostItemData(lostResponse.data?.data || lostResponse.data?.Data);
                    setFoundItemData(foundResponse.data?.data || foundResponse.data?.Data);

                } else {
                    // Fallback Routine: If specific URL params missing, find the 
                    // first item this user has that possesses a "match flag".
                    const myItemsResponse = await api.get('Item/my-items');

                    const userItems = myItemsResponse.data?.data || myItemsResponse.data?.Data || [];
                    const matchedItem = userItems.find(item => item.hasPotentialMatch || item.HasPotentialMatch);

                    // If the user has zero matched items, stop immediately.
                    if (!matchedItem) {
                        setErrorMessage('No potential match found.');
                        setIsLoading(false);
                        return;
                    }

                    // Proceed: grab the match ID and explicitly fetch the found item
                    const targetFoundItemId = matchedItem.matchFoundItemId || matchedItem.MatchFoundItemId;
                    const foundSpecificResponse = await api.get(`Item/get-by-id/${targetFoundItemId}`);

                    setLostItemData(matchedItem);
                    setFoundItemData(foundSpecificResponse.data?.data || foundSpecificResponse.data?.Data);
                }
            } catch (backendError) {
                console.error('MatchDetails fetch error:', backendError);
                setErrorMessage('Could not load match information. Please try again.');
            } finally {
                // Always hide loading spinner regardless of success or failure.
                setIsLoading(false);
            }
        };

        // Trigger the asynchronous fetch task
        fetchMatchInformation();
    }, [lostItemId, foundItemId]);

    // ========================================================================
    // Conditional Rendering - If Loading
    // ========================================================================
    if (isLoading) return (
        <div className="dashboard-container">
            <Sidebar />
            <main className="main-content md-main">
                <div className="md-fullcenter">
                    <div className="md-spinner" />
                    <p>Loading match details…</p>
                </div>
            </main>
        </div>
    );

    // ========================================================================
    // Conditional Rendering - If Backend Returns an Error
    // ========================================================================
    if (errorMessage) return (
        <div className="dashboard-container">
            <Sidebar />
            <main className="main-content md-main">
                <div className="md-fullcenter">
                    <ShieldAlert size={44} color="#ef4444" />
                    <p style={{ color: '#ef4444', fontWeight: 700 }}>{errorMessage}</p>
                    <button className="md-pill-btn" onClick={() => navigate('/my-items')}>
                        Back to My Items
                    </button>
                </div>
            </main>
        </div>
    );

    // ========================================================================
    // Data Preparation
    // At this stage, data exists. 
    // We utilize `extractValue()` to confidently grab correct data keys.
    // ========================================================================
    const typeLost = extractValue(lostItemData, 'type', 'Type') || 'Item';
    const typeFound = extractValue(foundItemData, 'type', 'Type') || 'Item';

    const imgLost = extractValue(lostItemData, 'imageUrl', 'ImageUrl');
    const imgFound = extractValue(foundItemData, 'imageUrl', 'ImageUrl');

    const locLost = extractValue(lostItemData, 'locationName', 'LocationName');
    const locFound = extractValue(foundItemData, 'locationName', 'LocationName');

    const dateLost = formatReadableDate(extractValue(lostItemData, 'eventTime', 'EventTime'));
    const dateFound = formatReadableDate(extractValue(foundItemData, 'eventTime', 'EventTime'));

    // Dynamic Attribute Arrays (Brand, Color, Memory Size, etc.)
    const attributesLost = lostItemData?.attributes || lostItemData?.Attributes || [];
    const attributesFound = foundItemData?.attributes || foundItemData?.Attributes || [];

    // Finds the brand specifically to append to the lost item title (e.g. "Apple Laptop")
    const brandNameLost = attributesLost.find(attr =>
        (attr.fieldName || attr.FieldName || '').toLowerCase().includes('brand')
    )?.fieldValue || '';

    // ------------------------------------------------------------------------
    // ** SECURITY FEATURE **
    // The found item limits exposure of detailed descriptors to prevent users 
    // from initiating fraudulent claims based on visible data.
    // ------------------------------------------------------------------------
    const securedAttributesFound = attributesFound.filter(attr => {
        const attributeName = (attr.fieldName || attr.FieldName || '').toLowerCase();
        // Allow color and type explicitly, exclude highly specific markers 
        // like Brand, Serial Number, Marks, etc.
        return attributeName.includes('color') || attributeName.includes('colour') || attributeName.includes('type');
    });

    // ========================================================================
    // Reusable UI Component -> "Item Card"
    // Displays exactly one item logic (handles either Lost OR Found display)
    // ========================================================================
    const ItemCard = ({ labelText, cardAccent, itemCategoryString, imageFileUrl, attributeDate, attributeLocation, attributeList, specificBrand, hideSensitiveInfo }) => (
        <div className={`md-card md-card-${cardAccent}`}>

            {/* Top Label Banner (Red for lost, Green/Teal for found) */}
            <div className="md-card-label">
                <span className={`md-dot md-dot-${cardAccent}`} />
                <span className={`md-label-text md-label-${cardAccent}`}>{labelText}</span>
            </div>

            {/* Image Preview Box */}
            <div className="md-img-area">
                {imageFileUrl && !hideSensitiveInfo ? (
                    <img
                        src={`${API_BASE_URL}${imageFileUrl}`}
                        alt={itemCategoryString}
                        className="md-img"
                        // Fallback hiding behavior if image file fails to load
                        onError={(e) => { e.target.style.display = 'none'; e.target.nextSibling.style.display = 'flex'; }}
                    />
                ) : null}

                {/* Fallback View if no image exists or if security hides it */}
                <div className="md-img-fallback" style={{ display: (imageFileUrl && !hideSensitiveInfo) ? 'none' : 'flex', color: cardAccent === 'lost' ? '#dc2626' : '#0d9488' }}>

                    {/* Shows a shield if hidden, or a folder/device icon if genuinely missing */}
                    {hideSensitiveInfo ? <ShieldCheck size={48} /> : getCategoryIcon(itemCategoryString, 48)}
                    <span>{hideSensitiveInfo ? 'Image hidden for security' : 'No photo uploaded'}</span>
                </div>
            </div>

            {/* Item Details Box */}
            <div className="md-card-info">

                {/* Title */}
                <h3 className="md-card-title">
                    {hideSensitiveInfo ? itemCategoryString : `${specificBrand ? specificBrand + ' ' : ''}${itemCategoryString}`}
                </h3>

                {/* Date & Location (Only display if not hidden by security rules) */}
                {!hideSensitiveInfo && (
                    <div className="md-meta-row">
                        <Calendar size={14} />
                        <span>{cardAccent === 'lost' ? 'Reported' : 'Found'}: <strong>{attributeDate}</strong></span>
                    </div>
                )}
                {!hideSensitiveInfo && attributeLocation && (
                    <div className="md-meta-row">
                        <MapPin size={14} />
                        <span>Location: <strong>{attributeLocation}</strong></span>
                    </div>
                )}

                {/* Chips for dynamically rendering array of attributes (Size, RAM, Color, etc) */}
                {attributeList.length > 0 && (
                    <div className="md-chips">
                        {attributeList.map((attr, index) => (
                            <span key={index} className="md-chip">
                                <Tag size={10} />
                                {attr.fieldName || attr.FieldName}: <strong>{attr.fieldValue || attr.FieldValue}</strong>
                            </span>
                        ))}
                    </div>
                )}
            </div>
        </div>
    );

    // ========================================================================
    // Master Rendering Return (The Actual Interface Structure)
    // ========================================================================
    return (
        <div className="dashboard-container">
            <Sidebar />

            <main className="main-content md-main">
                <Header
                    title="Potential Match Found"
                    subtitle="Compare your lost item with the found report — if it's yours, click Claim below."
                    showBack
                    onBack={() => navigate('/my-items')}
                />

                {/* ── Match Status Banner ── */}
                <div className="md-banner">
                    <div className="md-banner-inner">
                        <div className="md-banner-icon"><Sparkles size={20} color="#0d9488" /></div>
                        <div>
                            <h2>System Match Detected</h2>
                            <p>Our algorithm matched your lost item with a found report. Full details are hidden for security until Admin verification.</p>
                        </div>
                    </div>
                    <span className="md-matched-pill">✓ MATCHED</span>
                </div>

                {/* ── Side-by-Side Cards Area ── */}
                <div className="md-cards-grid">

                    {/* Left Card => Users Original Lost Item */}
                    <ItemCard
                        labelText="Your Lost Item"
                        cardAccent="lost"
                        itemCategoryString={typeLost}
                        imageFileUrl={imgLost}
                        attributeDate={dateLost}
                        attributeLocation={locLost}
                        attributeList={attributesLost}
                        specificBrand={brandNameLost}
                        hideSensitiveInfo={false}      // NEVER hide user's own details
                    />

                    {/* Center Column => Stylish "Approximately Equal" Visualizer */}
                    <div className="md-vs-col">
                        <div className="md-vs-line" />
                        <div className="md-vs-circle">≈</div>
                        <div className="md-vs-line" />
                    </div>

                    {/* Right Card => The specific Found Item (Filtered for security) */}
                    <ItemCard
                        labelText="Found Item Report"
                        cardAccent="found"
                        itemCategoryString={typeFound}
                        imageFileUrl={imgFound}
                        attributeDate={dateFound}
                        attributeLocation={locFound}
                        attributeList={securedAttributesFound}
                        specificBrand={null}
                        hideSensitiveInfo={true}       // ALWAYS restrict found properties
                    />
                </div>

                {/* ── Bottom Action Strip ── */}
                <div className="md-action-bar">
                    <p className="md-action-note">
                        Is this your item? Click <strong>Claim This Item</strong> — your request goes directly to the Admin for manual verification and handover.
                    </p>
                    <div className="md-btn-row">

                        {/* Cancel Button */}
                        <button className="md-btn-outline" onClick={() => navigate('/my-items')}>
                            <XCircle size={16} /> Not a Match
                        </button>

                        {/* Proceed Button */}
                        <button className="md-btn-primary" onClick={() =>
                            navigate(`/claim-item/${extractValue(lostItemData, 'id', 'Id')}/${extractValue(foundItemData, 'id', 'Id')}`)
                        }>
                            Claim This Item <ArrowRight size={16} />
                        </button>
                    </div>
                </div>

                {/* ── Embedded CSS Stylesheet ── */}
                <style>{`
                    .md-main {
                        background: #f1f5f9;
                        min-height: 100vh;
                        padding: 2rem 2.5rem;
                        display: flex;
                        flex-direction: column;
                        gap: 1.5rem;
                    }
                    .md-fullcenter {
                        flex:1; display:flex; flex-direction:column;
                        align-items:center; justify-content:center;
                        gap:1rem; height:60vh;
                        font-size:1rem; font-weight:600; color:#64748b;
                    }
                    .md-spinner {
                        width:40px; height:40px;
                        border:4px solid #e2e8f0;
                        border-top-color:#0d9488;
                        border-radius:50%;
                        animation:mdspin .8s linear infinite;
                    }
                    @keyframes mdspin { to{transform:rotate(360deg);} }
                    .md-pill-btn {
                        padding:.65rem 1.75rem; border-radius:10px;
                        background:#0d9488; color:#fff; border:none;
                        font-weight:700; cursor:pointer;
                    }

                    /* Banner Design */
                    .md-banner {
                        display:flex; align-items:center;
                        justify-content:space-between;
                        background:#fff; border-radius:16px;
                        padding:1.25rem 1.75rem;
                        border:1px solid #e2e8f0;
                        box-shadow:0 2px 10px -4px rgba(0,0,0,.06);
                        animation:mdup .4s ease-out;
                    }
                    .md-banner-inner { display:flex; align-items:center; gap:1rem; }
                    .md-banner-icon {
                        width:46px; height:46px; background:#f0fdfa;
                        border-radius:13px;
                        display:flex; align-items:center; justify-content:center;
                        border:1px solid #ccfbf1; flex-shrink:0;
                    }
                    .md-banner h2 { margin:0 0 3px; font-size:1.05rem; font-weight:800; color:#1e293b; }
                    .md-banner p  { margin:0; font-size:.85rem; color:#64748b; max-width:560px; line-height:1.5; }
                    .md-matched-pill {
                        background:linear-gradient(135deg,#0d9488,#0ea5e9);
                        color:#fff; font-size:.75rem; font-weight:900;
                        letter-spacing:.08em; padding:.4rem 1.1rem;
                        border-radius:30px; white-space:nowrap;
                        box-shadow:0 4px 12px rgba(13,148,136,.3);
                    }

                    /* Cards Layout Frame */
                    .md-cards-grid {
                        display:grid;
                        grid-template-columns:1fr 56px 1fr;
                        gap:0;
                        flex:1;
                        animation:mdup .5s ease-out;
                    }
                    .md-card {
                        background:#fff;
                        border-radius:18px;
                        border:1px solid #e2e8f0;
                        box-shadow:0 3px 14px -6px rgba(0,0,0,.08);
                        display:flex;
                        flex-direction:column;
                        overflow:hidden;
                    }
                    .md-card-label {
                        display:flex; align-items:center; gap:.6rem;
                        padding:.85rem 1.5rem;
                        font-size:.82rem; font-weight:800;
                    }
                    .md-card-lost  .md-card-label { background:#fef2f2; border-bottom:1px solid #fecaca; }
                    .md-card-found .md-card-label { background:#f0fdfa; border-bottom:1px solid #ccfbf1; }
                    .md-dot { width:9px; height:9px; border-radius:50%; flex-shrink:0; }
                    .md-dot-lost  { background:#dc2626; }
                    .md-dot-found { background:#0d9488; }
                    .md-label-lost  { color:#dc2626; }
                    .md-label-found { color:#0d9488; }

                    .md-img-area {
                        height:260px; overflow:hidden;
                        border-bottom:1px solid #f1f5f9;
                        background:#f8fafc;
                        position:relative;
                        display:flex; align-items:center; justify-content:center;
                    }
                    .md-img {
                        width:100%; height:100%;
                        object-fit:cover; display:block;
                    }
                    .md-img-fallback {
                        position:absolute; inset:0;
                        flex-direction:column;
                        align-items:center; justify-content:center;
                        gap:.5rem; opacity:.55;
                        font-size:.82rem; font-weight:600;
                    }

                    .md-card-info {
                        padding:1.4rem 1.5rem;
                        display:flex; flex-direction:column; gap:.7rem;
                        flex:1;
                    }
                    .md-card-title {
                        font-size:1.25rem; font-weight:800; color:#1e293b; margin:0;
                    }
                    .md-meta-row {
                        display:flex; align-items:center; gap:.45rem;
                        font-size:.875rem; color:#64748b;
                    }
                    .md-meta-row strong { color:#1e293b; }
                    .md-chips { display:flex; flex-wrap:wrap; gap:.4rem; }
                    .md-chip {
                        display:flex; align-items:center; gap:4px;
                        background:#f8fafc; border:1px solid #e2e8f0;
                        color:#475569; font-size:.77rem; font-weight:600;
                        padding:3px 9px; border-radius:20px;
                    }
                    .md-chip strong { color:#1e293b; font-weight:700; }

                    /* Central Indicator styling */
                    .md-vs-col {
                        display:flex; flex-direction:column;
                        align-items:center; justify-content:center; gap:0;
                    }
                    .md-vs-line {
                        width:2px; flex:1;
                        background:linear-gradient(to bottom,transparent,#e2e8f0,transparent);
                    }
                    .md-vs-circle {
                        width:40px; height:40px; border-radius:50%;
                        background:#fff; border:2px solid #0d9488;
                        display:flex; align-items:center; justify-content:center;
                        font-size:1.25rem; font-weight:900; color:#0d9488;
                        box-shadow:0 0 0 6px rgba(13,148,136,.08);
                        flex-shrink:0;
                    }

                    /* Bottom Action bar */
                    .md-action-bar {
                        display:flex; align-items:center;
                        justify-content:space-between; gap:2rem;
                        background:#fff; border-radius:16px;
                        padding:1.25rem 1.75rem;
                        border:1px solid #e2e8f0;
                        box-shadow:0 2px 10px -4px rgba(0,0,0,.06);
                        animation:mdup .6s ease-out;
                    }
                    .md-action-note { margin:0; font-size:.875rem; color:#64748b; line-height:1.6; max-width:540px; }
                    .md-btn-row { display:flex; gap:.85rem; flex-shrink:0; }
                    .md-btn-outline {
                        display:flex; align-items:center; gap:7px;
                        padding:.7rem 1.4rem; border-radius:11px;
                        border:2px solid #e2e8f0; background:#fff;
                        color:#64748b; font-weight:700; font-size:.875rem;
                        cursor:pointer; transition:all .2s; white-space:nowrap;
                    }
                    .md-btn-outline:hover { border-color:#ef4444; color:#ef4444; background:#fef2f2; }
                    .md-btn-primary {
                        display:flex; align-items:center; gap:8px;
                        padding:.7rem 1.6rem; border-radius:11px;
                        border:none;
                        background:linear-gradient(135deg,#0d9488,#0ea5e9);
                        color:#fff; font-weight:800; font-size:.875rem;
                        cursor:pointer; transition:all .3s;
                        box-shadow:0 4px 14px rgba(13,148,136,.28);
                        white-space:nowrap;
                    }
                    .md-btn-primary:hover { transform:translateY(-2px); box-shadow:0 8px 20px rgba(13,148,136,.38); }

                    @keyframes mdup {
                        from{opacity:0;transform:translateY(12px);}
                        to{opacity:1;transform:translateY(0);}
                    }
                `}</style>
            </main>
        </div>
    );
};

export default MatchDetails;
