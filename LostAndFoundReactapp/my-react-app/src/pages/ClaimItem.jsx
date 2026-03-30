import React, { useState, useEffect } from 'react';
import { useNavigate, useParams } from 'react-router-dom';
import {
    Folder, Wallet, Laptop, Smartphone,
    CheckCircle, AlertCircle, ArrowRight,
    ShieldCheck, UserCheck, PackageCheck, Tag, Calendar, MapPin, Info
} from 'lucide-react';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';
import api from '../api/axios';

const API_BASE_URL = import.meta.env.VITE_API_BASE_URL;

// ============================================================================
// HELPER FUNCTIONS
// Small utility methods extracted to keep the component body clean.
// ============================================================================

/**
 * Returns a specific icon based on the category name of the item.
 */
const getCategoryIcon = (itemType, size = 36) => {
    if (!itemType) return <Folder size={size} />;

    // Convert to lowercase to check keywords easily
    const typeLabel = itemType.toLowerCase();

    if (typeLabel.includes('wallet')) return <Wallet size={size} />;
    if (typeLabel.includes('laptop')) return <Laptop size={size} />;
    if (typeLabel.includes('phone') || typeLabel.includes('mobile') ||
        typeLabel.includes('earphone') || typeLabel.includes('headphone')) {
        return <Smartphone size={size} />;
    }

    // Default fallback icon
    return <Folder size={size} />;
};

/**
 * Formats a valid date string into "Mar 10, 2026".
 * Returns '—' if no date string exists.
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
 * Iterates through a given list of strings (possible property names)
 * and returns the first value successfully found in the object.
 * Fixes casing inconsistencies between the backend (PascalCase) and frontend (camelCase).
 */
const extractValue = (itemObject, ...possibleKeys) => {
    for (const key of possibleKeys) {
        if (itemObject?.[key] !== undefined && itemObject?.[key] !== null && itemObject?.[key] !== '') {
            return itemObject[key];
        }
    }
    return null;
};

/**
 * Safely extracts the Attributes array from an item regardless of casing.
 */
const extractAttributesList = (itemData) => {
    return itemData?.attributes || itemData?.Attributes || [];
};

/**
 * Searches the attributes array specifically for the "Brand" field.
 */
const extractBrandName = (itemData) => {
    const allAttributes = extractAttributesList(itemData);
    const brandAttribute = allAttributes.find(attr =>
        (attr.fieldName || attr.FieldName || '').toLowerCase().includes('brand')
    );
    return brandAttribute?.fieldValue || '';
};

// ============================================================================
// MAIN COMPONENT: ClaimItem
// The final screen where the user submits their formal claim request
// connecting a Lost ID to a Found ID to the backend.
// ============================================================================
const ClaimItem = () => {
    // Hooks specific to React Router
    const navigate = useNavigate();
    const { lostItemId, foundItemId } = useParams();

    // -- State Variables --
    const [lostItemData, setLostItemData] = useState(null);
    const [foundItemData, setFoundItemData] = useState(null);

    // UI Status States
    const [isLoading, setIsLoading] = useState(true);
    const [isSubmitting, setIsSubmitting] = useState(false);
    const [isSuccessfullySubmitted, setIsSuccessfullySubmitted] = useState(false);
    const [errorMessage, setErrorMessage] = useState(null);
    const [claimDescription, setClaimDescription] = useState('');

    // Initial Data Fetch
    useEffect(() => {
        const fetchItemsFromApi = async () => {
            try {
                // Halt immediately if route params are somehow missing
                if (!lostItemId || !foundItemId) {
                    setErrorMessage('Missing item IDs.');
                    setIsLoading(false);
                    return;
                }

                // Fire both requests together for performance
                const [lostResponse, foundResponse] = await Promise.all([
                    api.get(`Item/get-by-id/${lostItemId}`),
                    api.get(`Item/get-by-id/${foundItemId}`)
                ]);

                // Store results safely checking casing variations
                setLostItemData(lostResponse.data?.data || lostResponse.data?.Data);
                setFoundItemData(foundResponse.data?.data || foundResponse.data?.Data);

            } catch (backendError) {
                console.error('ClaimItem fetch error:', backendError);
                setErrorMessage('Could not load item details.');
            } finally {
                setIsLoading(false);
            }
        };
        fetchItemsFromApi();
    }, [lostItemId, foundItemId]);

    /**
     * Executes the actual Submit Request to the Backend.
     */
    const submitClaimRequestToBackend = async () => {
        setIsSubmitting(true);
        try {
            // Sends the explicit connection over to the Claim controller
            await api.post('Claim/submit', {
                lostItemId: Number(lostItemId),
                foundItemId: Number(foundItemId),
                description: claimDescription
            });

            // If the post succeeds without throwing errors, trigger success screen
            setIsSuccessfullySubmitted(true);

        } catch (submitError) {
            console.error('Claim submission error:', submitError);
            const serverMessage = submitError.response?.data?.message || submitError.response?.data?.Message || 'Failed to submit claim. Please try again.';
            setErrorMessage(serverMessage);
        } finally {
            setIsSubmitting(false);
        }
    };

    // ========================================================================
    // Conditional Rendering: Loading State
    // ========================================================================
    if (isLoading) return (
        <div className="dashboard-container">
            <Sidebar />
            <main className="main-content ci-main">
                <div className="ci-center"><div className="ci-spinner" /><p>Loading claim details…</p></div>
            </main>
        </div>
    );

    // ========================================================================
    // Conditional Rendering: Error State
    // ========================================================================
    if (errorMessage) return (
        <div className="dashboard-container">
            <Sidebar />
            <main className="main-content ci-main">
                <div className="ci-center">
                    <AlertCircle size={42} color="#ef4444" />
                    <p style={{ color: '#ef4444', fontWeight: 700 }}>{errorMessage}</p>
                    <button className="ci-pill-btn" onClick={() => navigate('/my-items')}>
                        Back to My Items
                    </button>
                </div>
            </main>
        </div>
    );

    // ========================================================================
    // Variables Preparation
    // Data is loaded safely, so extract exact fields for UI mapping.
    // ========================================================================
    const typeLost = extractValue(lostItemData, 'type', 'Type') || 'Item';
    const typeFound = extractValue(foundItemData, 'type', 'Type') || 'Item';

    const imgLost = extractValue(lostItemData, 'imageUrl', 'ImageUrl');
    const imgFound = extractValue(foundItemData, 'imageUrl', 'ImageUrl');

    const locLost = extractValue(lostItemData, 'locationName', 'LocationName');
    const locFound = extractValue(foundItemData, 'locationName', 'LocationName');

    const brandLost = extractBrandName(lostItemData);
    const brandFound = extractBrandName(foundItemData);

    // ========================================================================
    // Sub-Component: Item Row Card 
    // Acts as a display wrapper for the items shown on the left hand side.
    // Contains "hideSensitiveInfo" flag specifically for Found Items.
    // ========================================================================
    const DisplayItemRow = ({ payloadData, stringLabel, styleAccent, stringType, fileUrlImage, stringLocation, stringBrand, hideSensitiveInfo }) => {

        // Ensure sensitive attributes (like Brand, Marks, Storage) do not render if hidden
        // Only keep generic values (Color, Type)
        const visibleAttributes = hideSensitiveInfo
            ? extractAttributesList(payloadData).filter(attr => {
                const attributeName = (attr.fieldName || attr.FieldName || '').toLowerCase();
                return attributeName.includes('color') || attributeName.includes('colour') || attributeName.includes('type');
            })
            : extractAttributesList(payloadData);

        return (
            <div className="ci-item-card">

                {/* Header Flag */}
                <div className="ci-card-hdr" style={{ background: styleAccent === 'lost' ? '#fef2f2' : '#f0fdfa', borderBottom: `1px solid ${styleAccent === 'lost' ? '#fecaca' : '#ccfbf1'}` }}>
                    <span className="ci-dot" style={{ background: styleAccent === 'lost' ? '#dc2626' : '#0d9488' }} />
                    <span style={{ color: styleAccent === 'lost' ? '#dc2626' : '#0d9488', fontWeight: 800, fontSize: '.85rem' }}>{stringLabel}</span>
                </div>

                {/* Body Content */}
                <div className="ci-card-body">

                    {/* Thumbnail Logic: Disables images completely if hidden for security */}
                    <div className="ci-thumb-wrap" style={{ borderColor: styleAccent === 'lost' ? '#fecaca' : '#ccfbf1' }}>
                        {fileUrlImage && !hideSensitiveInfo ? (
                            <img
                                src={`${API_BASE_URL}${fileUrlImage}`}
                                alt={stringType}
                                className="ci-thumb-img"
                                onError={e => { e.target.style.display = 'none'; e.target.nextSibling.style.display = 'flex'; }}
                            />
                        ) : null}

                        <div className="ci-thumb-fallback" style={{ display: (fileUrlImage && !hideSensitiveInfo) ? 'none' : 'flex', color: styleAccent === 'lost' ? '#dc2626' : '#0d9488', flexDirection: 'column' }}>
                            {hideSensitiveInfo ? <ShieldCheck size={28} /> : getCategoryIcon(stringType, 30)}
                            {hideSensitiveInfo && <span style={{ fontSize: '0.65rem', marginTop: '6px', textAlign: 'center', lineHeight: 1.2 }}>Hidden for<br />Security</span>}
                        </div>
                    </div>

                    {/* Information Text Block */}
                    <div className="ci-card-info">

                        <h3 className="ci-item-name">
                            {hideSensitiveInfo ? stringType : `${stringBrand ? stringBrand + ' ' : ''}${stringType}`}
                        </h3>

                        {/* Only show Date and Location if not secure-restricted */}
                        {!hideSensitiveInfo && (
                            <div className="ci-meta">
                                <Calendar size={13} /> {formatReadableDate(extractValue(payloadData, 'eventTime', 'EventTime'))}
                            </div>
                        )}
                        {!hideSensitiveInfo && stringLocation && (
                            <div className="ci-meta">
                                <MapPin size={13} /> {stringLocation}
                            </div>
                        )}

                        {/* Render allowed Attribute Chips */}
                        <div className="ci-attr-wrap">
                            {visibleAttributes.map((attr, index) => (
                                <span key={index} className="ci-chip">
                                    <Tag size={10} />{attr.fieldName || attr.FieldName}: <strong>{attr.fieldValue || attr.FieldValue}</strong>
                                </span>
                            ))}
                        </div>
                    </div>
                </div>
            </div>
        );
    };

    // ========================================================================
    // Conditional Rendering: SUCCESSFUL SUBMISSION STATE
    // Replaces the whole form layout with a full-width congratulations page.
    // ========================================================================
    if (isSuccessfullySubmitted) return (
        <div className="dashboard-container">
            <Sidebar />
            <main className="main-content ci-main">
                <Header title="Claim Submitted" subtitle="Your request has been sent to the Admin for review." />
                <div className="ci-success-grid">

                    {/* Left Column -> Success Badge */}
                    <div className="ci-succ-left">
                        <div className="ci-succ-ring"><CheckCircle size={52} color="#0d9488" /></div>
                        <h1>Claim Submitted!</h1>
                        <p>Your claim request has been received. The <strong>Admin</strong> will manually verify your ownership and arrange item handover once confirmed.</p>
                        <button className="ci-pill-btn" style={{ marginTop: '1.75rem' }} onClick={() => navigate('/my-items')}>
                            Back to My Items <ArrowRight size={16} />
                        </button>
                    </div>

                    {/* Right Column -> Explain Verification Steps */}
                    <div className="ci-succ-right">
                        <h3>What happens next?</h3>
                        {[
                            {
                                IconElement: <ShieldCheck size={22} color="#3b82f6" />,
                                bgColor: '#eff6ff',
                                borderColor: '#bfdbfe',
                                titleText: 'Admin Review',
                                description: 'Admin checks your claim and may ask verification questions.'
                            },
                            {
                                IconElement: <UserCheck size={22} color="#d97706" />,
                                bgColor: '#fef3c7',
                                borderColor: '#fde68a',
                                titleText: 'Ownership Verification',
                                description: 'Provide special marks, lock code, or details about where it was lost.'
                            },
                            {
                                IconElement: <PackageCheck size={22} color="#16a34a" />,
                                bgColor: '#f0fdf4',
                                borderColor: '#bbf7d0',
                                titleText: 'Item Returned',
                                description: 'Once verified, the admin arranges handover and updates item status.'
                            },
                        ].map((step, index) => (
                            <div key={index} className="ci-succ-step">
                                <div className="ci-succ-icon" style={{ background: step.bgColor, border: `1px solid ${step.borderColor}` }}>
                                    {step.IconElement}
                                </div>
                                <div>
                                    <h4>{step.titleText}</h4>
                                    <p>{step.description}</p>
                                </div>
                            </div>
                        ))}
                    </div>

                </div>
                <ComponentStyles />
            </main>
        </div>
    );

    // ========================================================================
    // Conditional Rendering: DEFAULT MAIN PAGE
    // Uses CSS Grid for left-side Content and right-side Sticky Action bar.
    // ========================================================================
    return (
        <div className="dashboard-container">
            <Sidebar />
            <main className="main-content ci-main">
                <Header
                    title="Claim Your Lost Item"
                    subtitle="Review the matched items below, then submit your claim to the Admin for verification."
                    showBack
                    onBack={() => navigate(-1)}
                />

                <div className="ci-layout">

                    {/* LEFT COLUMN: Contains stacked display component cards ── */}
                    <div className="ci-items-col">
                        <DisplayItemRow
                            payloadData={lostItemData}
                            stringLabel="Your Lost Item"
                            styleAccent="lost"
                            stringType={typeLost}
                            fileUrlImage={imgLost}
                            stringLocation={locLost}
                            stringBrand={brandLost}
                            hideSensitiveInfo={false}
                        />
                        <DisplayItemRow
                            payloadData={foundItemData}
                            stringLabel="Found Item Report"
                            styleAccent="found"
                            stringType={typeFound}
                            fileUrlImage={imgFound}
                            stringLocation={locFound}
                            stringBrand={brandFound}
                            hideSensitiveInfo={true} // Strict flag implementation 
                        />
                    </div>

                    {/* RIGHT COLUMN: Sticky Panel that controls Submission ── */}
                    <div className="ci-sticky-col">
                        <div className="ci-action-card">

                            <div className="ci-action-icon"><CheckCircle size={26} color="#0d9488" /></div>

                            <h2 className="ci-action-title">Ready to Claim?</h2>

                            <p className="ci-action-sub">
                                Clicking submit sends a claim request directly to the Admin. No automatic questions — the admin will review manually.
                            </p>

                            <div className="ci-steps">
                                <div style={{ borderTop: '1px solid #f1f5f9', marginTop: '1rem', paddingTop: '1.5rem', marginBottom: '1.5rem' }}>
                                    <label style={{ display: 'block', fontSize: '0.75rem', fontWeight: '900', color: '#64748b', textTransform: 'uppercase', marginBottom: '10px', display: 'flex', alignItems: 'center', gap: '6px' }}>
                                        <Info size={14} color="#3b82f6" /> Provide Proof of Ownership
                                    </label>
                                    <textarea 
                                        placeholder="Explain how you know this belongs to you (e.g. 'The laptop has a sticker of a cat on the bottom' or 'The wallet contains my library card')"
                                        value={claimDescription}
                                        onChange={(e) => setClaimDescription(e.target.value)}
                                        style={{ width: '100%', padding: '1rem', borderRadius: '12px', border: '1.5px solid #e2e8f0', background: '#f8fafc', fontSize: '0.85rem', color: '#334155', minHeight: '120px', resize: 'vertical', outline: 'none', transition: 'all 0.2s', fontFamily: 'inherit' }}
                                    />
                                    <p style={{ marginTop: '8px', fontSize: '0.7rem', color: '#94a3b8', fontStyle: 'italic', lineHeight: 1.4 }}>
                                        Providing specific details helps the administrator verify your claim much faster.
                                    </p>
                                </div>
                                {[
                                    { stepNum: 1, textTitle: 'Submit Claim', textDesc: 'Sent instantly to Admin panel' },
                                    { stepNum: 2, textTitle: 'Admin Verifies', textDesc: 'Manual review of your ownership' },
                                    { stepNum: 3, textTitle: 'Item Returned', textDesc: 'Handover arranged if approved' },
                                ].map(stepData => (
                                    <div key={stepData.stepNum} className="ci-step">
                                        <div className="ci-step-n">{stepData.stepNum}</div>
                                        <div>
                                            <div className="ci-step-title">{stepData.textTitle}</div>
                                            <div className="ci-step-desc">{stepData.textDesc}</div>
                                        </div>
                                    </div>
                                ))}
                            </div>

                            {/* Main CTA Submission Button */}
                            <button
                                className="ci-submit-btn"
                                onClick={submitClaimRequestToBackend}
                                disabled={isSubmitting}
                            >
                                {isSubmitting
                                    ? <><span className="ci-spin" /> Submitting…</>
                                    : <><CheckCircle size={17} /> Submit Claim Request</>
                                }
                            </button>

                            <button className="ci-cancel-btn" onClick={() => navigate(-1)}>Cancel</button>

                        </div>
                    </div>
                </div>

                <ComponentStyles />
            </main>
        </div>
    );
};

// ============================================================================
// COMPONENT STYLES
// Embedded string styles ensure no external CSS dependencies break the design.
// ============================================================================
const ComponentStyles = () => (
    <style>{`
        .ci-main {
            background:#f1f5f9; min-height:100vh;
            padding:2rem 2.5rem;
            display:flex; flex-direction:column; gap:1.5rem;
        }
        .ci-center {
            flex:1; display:flex; flex-direction:column;
            align-items:center; justify-content:center;
            gap:1rem; height:60vh; font-size:1rem; font-weight:600; color:#64748b;
        }
        .ci-spinner {
            width:40px;height:40px;
            border:4px solid #e2e8f0;border-top-color:#0d9488;
            border-radius:50%;animation:cispin .8s linear infinite;
        }
        @keyframes cispin{to{transform:rotate(360deg);}}
        @keyframes ciup{from{opacity:0;transform:translateY(12px);}to{opacity:1;transform:translateY(0);}}

        .ci-pill-btn {
            display:inline-flex;align-items:center;gap:7px;
            padding:.65rem 1.6rem;border-radius:11px;
            background:linear-gradient(135deg,#0d9488,#0ea5e9);
            color:#fff;border:none;font-weight:700;cursor:pointer;
            box-shadow:0 4px 12px rgba(13,148,136,.25);transition:all .3s;
        }
        .ci-pill-btn:hover{transform:translateY(-2px);box-shadow:0 8px 20px rgba(13,148,136,.35);}

        /* Core Layout Grid System */
        .ci-layout {
            display:grid;grid-template-columns:1fr 300px;
            gap:1.5rem;flex:1;animation:ciup .5s ease-out;
        }
        .ci-items-col{display:flex;flex-direction:column;gap:1.25rem;}

        /* Unified Item Card Formatting */
        .ci-item-card{background:#fff;border-radius:16px;border:1px solid #e2e8f0;box-shadow:0 2px 10px -4px rgba(0,0,0,.06);overflow:hidden;}
        .ci-card-hdr{display:flex;align-items:center;gap:.6rem;padding:.8rem 1.4rem;}
        .ci-dot{width:9px;height:9px;border-radius:50%;flex-shrink:0;}
        .ci-card-body{display:grid;grid-template-columns:120px 1fr;gap:1.25rem;padding:1.25rem 1.4rem;align-items:flex-start;}
        .ci-thumb-wrap{
            width:116px;height:116px;border-radius:13px;overflow:hidden;
            border:2px solid;background:#f8fafc;
            display:flex;align-items:center;justify-content:center;
            position:relative;flex-shrink:0;
        }
        .ci-thumb-img{width:100%;height:100%;object-fit:cover;display:block;}
        .ci-thumb-fallback{position:absolute;inset:0;display:flex;align-items:center;justify-content:center;opacity:.5;}
        .ci-card-info{display:flex;flex-direction:column;gap:.5rem;}
        .ci-item-name{font-size:1.1rem;font-weight:800;color:#1e293b;margin:0;}
        .ci-meta{display:flex;align-items:center;gap:.4rem;font-size:.82rem;color:#64748b;}
        
        .ci-attr-wrap{display:flex;flex-wrap:wrap;gap:.35rem;margin-top:.1rem;}
        .ci-chip{
            display:flex;align-items:center;gap:4px;
            background:#f8fafc;border:1px solid #e2e8f0;
            color:#475569;font-size:.75rem;font-weight:600;
            padding:3px 8px;border-radius:18px;
        }
        .ci-chip strong{color:#1e293b;font-weight:700;}

        /* Sticky Action Target specificities */
        .ci-sticky-col{position:sticky;top:2rem;align-self:start;}
        .ci-action-card{
            background:#fff;border-radius:18px;
            border:1px solid #e2e8f0;
            box-shadow:0 4px 18px -8px rgba(0,0,0,.1);
            padding:1.75rem 1.5rem;
            display:flex;flex-direction:column;gap:1.2rem;
        }
        .ci-action-icon{
            width:52px;height:52px;background:#f0fdfa;
            border-radius:15px;display:flex;align-items:center;justify-content:center;
            border:1px solid #ccfbf1;
        }
        .ci-action-title{font-size:1.2rem;font-weight:900;color:#1e293b;margin:0;}
        .ci-action-sub{font-size:.84rem;color:#64748b;line-height:1.6;margin:0;}
        .ci-steps{display:flex;flex-direction:column;gap:.8rem;border-top:1px solid #f1f5f9;padding-top:1rem;}
        .ci-step{display:flex;align-items:flex-start;gap:.8rem;}
        .ci-step-n{
            width:26px;height:26px;border-radius:50%;
            background:linear-gradient(135deg,#0d9488,#0ea5e9);
            color:#fff;font-size:.75rem;font-weight:800;
            display:flex;align-items:center;justify-content:center;flex-shrink:0;
        }
        .ci-step-title{font-size:.85rem;font-weight:700;color:#1e293b;}
        .ci-step-desc{font-size:.77rem;color:#64748b;margin-top:2px;}

        /* Submission Button States */
        .ci-submit-btn{
            display:flex;align-items:center;justify-content:center;gap:8px;
            width:100%;padding:.95rem;border-radius:13px;border:none;
            background:linear-gradient(135deg,#0d9488,#0ea5e9);
            color:#fff;font-weight:800;font-size:.9rem;cursor:pointer;
            box-shadow:0 4px 14px rgba(13,148,136,.3);transition:all .3s;
        }
        .ci-submit-btn:hover:not(:disabled){transform:translateY(-2px);box-shadow:0 8px 22px rgba(13,148,136,.4);}
        .ci-submit-btn:disabled{opacity:.7;cursor:not-allowed;}
        .ci-spin{
            display:inline-block;width:16px;height:16px;
            border:3px solid rgba(255,255,255,.35);
            border-top-color:#fff;border-radius:50%;
            animation:cispin .8s linear infinite;
        }
        
        .ci-cancel-btn{
            width:100%;padding:.7rem;border-radius:11px;
            border:1.5px solid #e2e8f0;background:#fff;
            color:#64748b;font-weight:600;font-size:.85rem;cursor:pointer;transition:all .2s;
        }
        .ci-cancel-btn:hover{border-color:#cbd5e0;color:#475569;background:#f8fafc;}

        /* SUCCESS View Overrides */
        .ci-success-grid{
            display:grid;grid-template-columns:1fr 1fr;
            gap:0;background:#fff;border-radius:22px;
            border:1px solid #e2e8f0;
            box-shadow:0 8px 24px -12px rgba(0,0,0,.08);
            overflow:hidden;flex:1;animation:ciup .5s ease-out;
        }
        .ci-succ-left{
            padding:3rem;background:linear-gradient(155deg,#f0fdfa,#e0f2fe);
            display:flex;flex-direction:column;justify-content:center;gap:.85rem;
        }
        .ci-succ-ring{
            width:80px;height:80px;background:#fff;border-radius:22px;
            border:2px solid #ccfbf1;
            box-shadow:0 8px 22px rgba(13,148,136,.18);
            display:flex;align-items:center;justify-content:center;margin-bottom:.5rem;
        }
        .ci-succ-left h1{font-size:1.9rem;font-weight:900;color:#1e293b;margin:0;}
        .ci-succ-left p{font-size:.95rem;color:#64748b;line-height:1.7;margin:0;}
        .ci-succ-right{
            padding:2.5rem 2.25rem;
            display:flex;flex-direction:column;justify-content:center;gap:1.4rem;
        }
        .ci-succ-right h3{font-size:1.1rem;font-weight:800;color:#1e293b;margin:0;}
        .ci-succ-step{display:flex;gap:1rem;align-items:flex-start;}
        .ci-succ-icon{width:46px;height:46px;border-radius:13px;display:flex;align-items:center;justify-content:center;flex-shrink:0;}
        .ci-succ-step h4{font-size:.875rem;font-weight:800;color:#1e293b;margin:0 0 3px;}
        .ci-succ-step p{font-size:.8rem;color:#64748b;margin:0;line-height:1.5;}
    `}</style>
);

export default ClaimItem;
