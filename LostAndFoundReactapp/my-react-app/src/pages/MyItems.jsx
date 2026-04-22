// ========================================== //
// SECTION 1: IMPORTS
// We import React and icons used for the list of items.
// ========================================== //
import React, { useState, useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import api from '../api/axios';
import {
    ChevronLeft, Search, Calendar, MapPin,
    AlertCircle, Folder, Wallet, Laptop, Smartphone,
    MoreVertical, Trash2, Box, ArrowRight, ExternalLink,
    ShieldCheck, CheckCircle
} from 'lucide-react';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';

// ========================================== //
// SECTION 2: MAIN 'MY ITEMS' COMPONENT
// This screen allows a user to track the items they have lost
// or the items they have found.
// Logic:
// 1. Fetches all items reported by the logged-in user on mount.
// 2. Filters items into two lists (Lost Reports vs Found Items).
// 3. Renders cards with dynamic status badges (Returned, Potential Match, etc.).
// ========================================== //
const MyItems = ({ isAdmin = false }) => {
    const navigate = useNavigate();
    // Persist active tab in localStorage so it doesn't reset on refresh
    const [activeTab, setActiveTab] = useState(() => localStorage.getItem('myItemsActiveTab') || 'lost');
    
    useEffect(() => {
        localStorage.setItem('myItemsActiveTab', activeTab);
    }, [activeTab]); // 'lost' or 'found'
    const [loading, setLoading] = useState(true);
    const [myItems, setMyItems] = useState([]);

    const API_BASE_URL = import.meta.env.VITE_API_BASE_URL;

    const fetchMyItems = async () => {
        setLoading(true);
        try {
            const endpoint = isAdmin ? 'Item/all' : 'Item/my-items';
            const response = await api.get(endpoint);
            console.log("My Items API Response:", response.data);
            const data = response.data.data || response.data.Data || [];
            if (data) setMyItems(data);
        } catch (err) { 
            console.error("Failed to fetch my items:", err); 
        }
        finally { setLoading(false); }
    };

    const handleDeleteItem = async (id) => {
        if (!window.confirm("Delete this report?")) return;
        try {
            await api.delete(`Item/${id}`);
            fetchMyItems();
        } catch (err) { alert("Delete failed"); }
    };

    useEffect(() => {
        const load = async () => {
            await fetchMyItems();
        };
        load();
    }, []);

    // Intelligent tab selection logic
    const [initialTabSet, setInitialTabSet] = useState(false);
    useEffect(() => {
        if (!loading && myItems.length > 0 && !initialTabSet) {
            const hasSavedTab = localStorage.getItem('myItemsActiveTab');
            
            // Only auto-switch if user hasn't manually preferred a tab yet
            if (!hasSavedTab) {
                const lostCount = myItems.filter(i => isLostReport(i.reportType ?? i.ReportType)).length;
                const foundCount = myItems.filter(i => isFoundReport(i.reportType ?? i.ReportType)).length;
                
                if (lostCount === 0 && foundCount > 0) {
                    setActiveTab('found');
                } else if (foundCount === 0 && lostCount > 0) {
                    setActiveTab('lost');
                }
            }
            setInitialTabSet(true);
        }
    }, [loading, myItems, initialTabSet]);



    // Filter by the reportType property
    // Backend uses JsonStringEnumConverter so it sends 'Lost' / 'Found' (strings), NOT 0 / 1
    // We handle both string names AND numeric values just to be safe
    const isLostReport = (v) => v === 0 || String(v).toLowerCase() === 'lost' || String(v) === '0';
    const isFoundReport = (v) => v === 1 || String(v).toLowerCase() === 'found' || String(v) === '1';

    const lostReports = myItems.filter(item => isLostReport(item.reportType ?? item.ReportType));
    const foundItems = myItems.filter(item => isFoundReport(item.reportType ?? item.ReportType));

    const getIconForType = (type) => {
        if (!type) return <Folder size={24} />;
        const t = type.toLowerCase();
        if (t.includes('wallet')) return <Wallet size={24} />;
        if (t.includes('hardware') || t.includes('laptop') || t.includes('computing')) return <Laptop size={24} />;
        if (t.includes('device') || t.includes('phone') || t.includes('mobile')) return <Smartphone size={24} />;
        if (t.includes('jewelry') || t.includes('valuables')) return <Gem size={24} />;
        if (t.includes('audio') || t.includes('earphone') || t.includes('headphone')) return <Headphones size={24} />;
        return <Folder size={24} />;
    };

    const getStatusTheme = (apiItem) => {
        const status = apiItem.status ?? apiItem.Status;
        const reportType = apiItem.reportType ?? apiItem.ReportType;
        const hasPotentialMatch = apiItem.hasPotentialMatch ?? apiItem.HasPotentialMatch;
        const isVerifiedByAdmin = apiItem.isVerifiedByAdmin ?? apiItem.IsVerifiedByAdmin;

        const isHandover = status === 4 || status === 'Handover' || status === 'Returned';
        const isFoundSt = status === 1 || status === 'Found';
        const isLostSt = status === 0 || status === 'Lost';
        const isLostRep = isLostReport(reportType);

        const isReplacementSt = status === 2 || status === 'Replacement';
        const isAuctionSt = status === 3 || status === 'Auction';

        const cStat = apiItem.latestClaimStatus ?? apiItem.LatestClaimStatus;
        if (cStat === 2 || cStat === 'VerificationFailed') return { text: 'Claim Rejected', color: '#ef4444', bg: '#fef2f2' };

        // PRIORITY: Handover/Returned (Status 4)
        if (isHandover) return { text: 'Returned', color: '#10b981', bg: '#ecfdf5' };
        
        // Match: Only show match if NOT already handed over
        if (hasPotentialMatch) return { text: 'Match Found!', color: '#0ea5e9', bg: '#e0f2fe' };
        
        if (isReplacementSt) return { text: 'Replacement Requested', color: '#6366f1', bg: '#e0e7ff' };
        if (isAuctionSt) return { text: 'In Auction', color: '#f59e0b', bg: '#fffbeb' };

        if (isLostRep && isLostSt) return { text: 'Searching...', color: '#718096', bg: '#f7fafc' };
        if (isLostRep && isFoundSt) return { text: 'Found (Verified)', color: '#319795', bg: '#e6fffa' };
        
        // Found items: Check if they are actually in the office yet
        if (!isLostRep && isFoundSt) {
            if (!isVerifiedByAdmin) return { text: 'Handover Required', color: '#b45309', bg: '#fffbeb' };
            return { text: 'In Office', color: '#319795', bg: '#e6fffa' };
        }

        return { text: 'Processing', color: '#4a5568', bg: '#edf2f7' };
    };

    const getTimelineState = (apiItem) => {
        const isLost = isLostReport(apiItem.reportType ?? apiItem.ReportType);
        const status = apiItem.status ?? apiItem.Status;
        const hasPotentialMatch = apiItem.hasPotentialMatch ?? apiItem.HasPotentialMatch;
        const isVerifiedByAdmin = apiItem.isVerifiedByAdmin ?? apiItem.IsVerifiedByAdmin;

        if (isLost) {
            // Priority 1: Handover
            if (status === 4 || status === 'Handover') return 4;

            // Priority 2: Replacement (Step 3 or 4)
            if (status === 2 || status === 'Replacement') return 3;

            // Priority 3: Verified Match (Step 3)
            if (hasPotentialMatch) return 3;

            // Standard: Searching (Step 2)
            return 2;
        } else {
            // Priority 1: Handover
            if (status === 4 || status === 'Handover') return 4;

            // Priority 2: Auction (Step 3)
            if (status === 3 || status === 'Auction') return 3;

            // Priority 3: Verified Match (Step 3)
            if (hasPotentialMatch) return 3;

            // For found items: Received(1) -> Stored(2) -> Processed(3) -> Handover(4)
            return (status === 1 || status === 'Found' || status === 0) ? 2 : 3;
        }
    };

    const renderTimeline = (apiItem) => {
        const isLost = isLostReport(apiItem.reportType ?? apiItem.ReportType);
        const isVerifiedByAdmin = apiItem.isVerifiedByAdmin ?? apiItem.IsVerifiedByAdmin;
        const state = getTimelineState(apiItem);
        
        return (
            <div className="item-timeline">
                <div className={`timeline-step ${state >= 1 ? 'completed' : ''} ${state === 1 ? 'active' : ''}`}>
                    <div className="step-circle"></div>
                    <span className="step-label">{isLost ? 'Reported' : 'Received'}</span>
                </div>
                <div className={`timeline-line ${state >= 2 ? 'completed' : ''}`}></div>
                
                <div className={`timeline-step ${state >= 2 ? 'completed' : ''} ${state === 2 ? 'active' : ''}`}>
                    <div className="step-circle"></div>
                    <span className="step-label">{isLost ? 'Searching' : (isVerifiedByAdmin ? 'In Office' : 'Handover')}</span>
                </div>
                <div className={`timeline-line ${state >= 3 ? 'completed' : ''}`}></div>
                
                <div className={`timeline-step ${state >= 3 ? 'completed' : ''} ${state === 3 ? 'active' : ''}`}>
                    <div className="step-circle"></div>
                    <span className="step-label">{isLost ? 'Match Found' : 'Stored Safe'}</span>
                </div>
                <div className={`timeline-line ${state >= 4 ? 'completed' : ''}`}></div>
                
                <div className={`timeline-step ${state >= 4 ? 'completed' : ''}`}>
                    <div className="step-circle"></div>
                    <span className="step-label">Handover</span>
                </div>
            </div>
        );
    };

    // ========================================== //
    // SECTION 3: RENDER CARD
    // ========================================== //
    const renderCard = (apiItem) => {
        // Normalize camelCase vs PascalCase from the JSON response
        const eventTime = apiItem.eventTime ?? apiItem.EventTime;
        const status = apiItem.status ?? apiItem.Status;
        const reportType = apiItem.reportType ?? apiItem.ReportType;

        const itemDate = new Date(eventTime).toLocaleDateString('en-US', {
            month: 'short', day: 'numeric', year: 'numeric'
        });

        const statusTheme = getStatusTheme(apiItem);

        // Find important attributes to display on card
        const attrs = apiItem.attributes || apiItem.Attributes || [];
        const getKeyAttribute = (name) => attrs.find(a => (a.fieldName || a.FieldName).toLowerCase().includes(name))?.fieldValue || "";
        const brand = getKeyAttribute('brand');
        const color = getKeyAttribute('color');

        return (
            <div className="premium-item-card" key={apiItem.id}>
                <div className="card-top">
                    <div className="image-preview-container">
                        {apiItem.imageUrl ? (
                            <img
                                src={`${API_BASE_URL}${apiItem.imageUrl}`}
                                alt={apiItem.type}
                                className="item-thumb"
                                onError={(e) => {
                                    e.target.onerror = null;
                                    e.target.src = 'https://via.placeholder.com/80?text=No+Photo';
                                }}
                            />
                        ) : (
                            <div className="item-thumb-placeholder">
                                {getIconForType(apiItem.type)}
                            </div>
                        )}
                    </div>

                    <div className="card-info">
                        <div className="title-row">
                            <h3 className="item-title">{brand ? `${brand} ` : ''}{apiItem.type || apiItem.Type}</h3>
                            <span className="status-badge" style={{ backgroundColor: statusTheme.bg, color: statusTheme.color }}>
                                {statusTheme.text}
                            </span>
                        </div>

                        <div className="details-row">
                            <span className="meta-info"><Calendar size={14} /> {itemDate}</span>
                            <span className="meta-info"><MapPin size={14} /> {apiItem.locationName || apiItem.LocationName}</span>
                        </div>

                        {attrs.length > 0 && (
                            <div className="attribute-chips">
                                {attrs.slice(0, 3).map((attr, idx) => (
                                    <span key={idx} className="attr-chip">
                                        {attr.fieldName || attr.FieldName}: {attr.fieldValue || attr.FieldValue}
                                    </span>
                                ))}
                            </div>
                        )}

                        {(apiItem.claimRejectionReason || apiItem.ClaimRejectionReason) && (
                            <div style={{ marginTop: '0.75rem', padding: '0.6rem 1rem', background: '#fef2f2', border: '1px solid #fee2e2', borderRadius: '12px', color: '#ef4444', fontSize: '0.75rem', fontWeight: '700', display: 'flex', alignItems: 'flex-start', gap: '8px' }}>
                                <AlertCircle size={14} style={{ marginTop: '2px', flexShrink: 0 }} />
                                <div>
                                    <span style={{ fontWeight: '900', textTransform: 'uppercase', marginRight: '4px' }}>Previous Claim Rejected:</span> 
                                    {apiItem.claimRejectionReason || apiItem.ClaimRejectionReason}
                                </div>
                            </div>
                        )}
                    </div>
                </div>

                {renderTimeline(apiItem)}

                    <div className="card-actions">
                        {(apiItem.latestClaimStatus === 1 || apiItem.LatestClaimStatus === 1) ? (
                            <button className="action-btn match-btn" onClick={() => navigate(`/match-details/${isLostReport(apiItem.reportType ?? apiItem.ReportType) ? apiItem.id : (apiItem.matchFoundItemId || apiItem.MatchFoundItemId)}/${isLostReport(apiItem.reportType ?? apiItem.ReportType) ? (apiItem.matchFoundItemId || apiItem.MatchFoundItemId) : apiItem.id}`)}>
                                <ShieldCheck size={16} /> Review Claim
                            </button>
                        ) : (apiItem.latestClaimStatus === 3 || apiItem.LatestClaimStatus === 3 || apiItem.latestClaimStatus === 4 || apiItem.LatestClaimStatus === 4) ? (
                             <button className="action-btn secondary" style={{ background: '#ecfdf5', color: '#059669', border: '1px solid #10b981' }} onClick={() => navigate(`/report-details/${apiItem.id}`)}>
                                <CheckCircle size={16} /> Review Successfully
                            </button>
                        ) : (apiItem.latestClaimStatus === 0 || apiItem.LatestClaimStatus === 0) ? (
                            // Claim already submitted and pending admin review — block re-submission
                            <button className="action-btn secondary" disabled style={{ background: '#fef9c3', color: '#92400e', border: '1px solid #fde68a', cursor: 'not-allowed', opacity: 0.9 }}>
                                <ShieldCheck size={16} /> Claim Submitted — Pending Review
                            </button>
                        ) : ((apiItem.hasPotentialMatch || apiItem.HasPotentialMatch) && isLostReport(apiItem.reportType ?? apiItem.ReportType)) ? (
                            // Only Lost item owners can view & claim a match — Found item reporters have no action here
                            <button className="action-btn match-btn" onClick={() => {
                                const foundId = apiItem.matchFoundItemId || apiItem.MatchFoundItemId;
                                navigate(`/match-details/${apiItem.id}/${foundId}`);
                            }}>
                                View Potential Match
                            </button>
                        ) : (
                            <button className="action-btn secondary" onClick={() => navigate(`/report-details/${apiItem.id}`)}>
                                <ExternalLink size={16} /> Details
                            </button>
                        )}
                        {/* 
                          * Smart Delete Guard: Block deletion once timeline has progressed.
                          * - Lost item: blocked if match found OR any claim submitted
                          * - Found item: blocked if Admin has verified (item is now in the system)
                          */}
                        {(() => {
                            const isLost = isLostReport(apiItem.reportType ?? apiItem.ReportType);
                            const hasMatch = apiItem.hasPotentialMatch || apiItem.HasPotentialMatch;
                            const hasClaim = apiItem.latestClaimStatus !== null && apiItem.latestClaimStatus !== undefined;
                            const isVerified = apiItem.isVerifiedByAdmin || apiItem.IsVerifiedByAdmin;

                            const canDelete = isLost
                                ? (!hasMatch && !hasClaim)   // Lost: only deletable if no match and no claim
                                : !isVerified;               // Found: only deletable if not yet verified by Admin

                            return canDelete ? (
                                <button
                                    className="delete-btn-minimal"
                                    onClick={() => handleDeleteItem(apiItem.id)}
                                    title="Delete this report"
                                >
                                    <Trash2 size={16} />
                                </button>
                            ) : (
                                <button
                                    className="delete-btn-minimal"
                                    disabled
                                    title={isLost
                                        ? "Cannot delete — this item is currently being processed (match found or claim submitted)"
                                        : "Cannot delete — this item has been received by the Admin"}
                                    style={{ opacity: 0.3, cursor: 'not-allowed' }}
                                >
                                    <Trash2 size={16} />
                                </button>
                            );
                        })()}
                    </div>
            </div>
        );
    };

    return (
        <div className="dashboard-container">
            <Sidebar isAdmin={isAdmin} />

            <main className="main-content premium-bg">
                <div className="page-max-width">
                    <Header
                        title={isAdmin ? "Campus Inventory" : "My Lost & Found"}
                        subtitle={isAdmin ? "Manage and view all reported items across the university" : "Track and manage all your reported campus items"}
                        showBack={true}
                        onBack={() => navigate(isAdmin ? '/admin-dashboard' : '/dashboard')}
                    />

                    {/* Premium Sliding Tabs */}
                    <div className="premium-tabs-container">
                        <div className="tabs-wrapper">
                            <button
                                className={`premium-tab ${activeTab === 'lost' ? 'active' : ''}`}
                                onClick={() => setActiveTab('lost')}
                            >
                                Lost Reports
                                {lostReports.length > 0 && <span className="tab-count">{lostReports.length}</span>}
                            </button>
                            <button
                                className={`premium-tab ${activeTab === 'found' ? 'active' : ''}`}
                                onClick={() => setActiveTab('found')}
                            >
                                Found Items
                                {foundItems.length > 0 && <span className="tab-count">{foundItems.length}</span>}
                            </button>
                            <div className={`tab-slider ${activeTab === 'found' ? 'slide-right' : ''}`} />
                        </div>
                    </div>

                    <div className="items-grid-section">
                        {loading ? (
                            <div className="skeleton-container">
                                {[1, 2, 3].map(i => <div key={i} className="skeleton-card" />)}
                            </div>
                        ) : (
                            <>
                                {activeTab === 'lost' ? (
                                    lostReports.length > 0 ? (
                                        <div className="cards-list">
                                            {lostReports.map(item => renderCard(item))}
                                        </div>
                                    ) : (
                                        <div className="premium-empty-state">
                                            <div className="empty-icon-circle">
                                                <Box size={40} color="#cbd5e0" />
                                            </div>
                                            <h3>No Lost Reports Yet</h3>
                                            <p>You haven't reported any lost belongings. If you've lost something, let the community help!</p>
                                            <button className="report-now-btn" onClick={() => navigate('/report-lost')}>
                                                Report Lost Item <ArrowRight size={18} />
                                            </button>
                                        </div>
                                    )
                                ) : (
                                    foundItems.length > 0 ? (
                                        <div className="cards-list">
                                            {foundItems.map(item => renderCard(item))}
                                        </div>
                                    ) : (
                                        <div className="premium-empty-state">
                                            <div className="empty-icon-circle">
                                                <AlertCircle size={40} color="#cbd5e0" />
                                            </div>
                                            <h3>No Found Items Reported</h3>
                                            <p>All items you find and report on campus will appear here for tracking.</p>
                                            <button className="report-now-btn" onClick={() => navigate('/report-found')}>
                                                Report Found Item <ArrowRight size={18} />
                                            </button>
                                        </div>
                                    )
                                )}
                            </>
                        )}
                    </div>
                </div>

                <style>{`
                    .premium-bg {
                        background: linear-gradient(135deg, #f8fafc 0%, #f1f5f9 100%);
                        min-height: 100vh;
                        padding: 3rem;
                    }
                    .page-max-width {
                        max-width: 900px;
                        margin: 0 auto;
                    }
                    
                    /* Tabs Styling */
                    .premium-tabs-container {
                        margin: 2rem 0;
                        display: flex;
                        justify-content: center;
                    }
                    .tabs-wrapper {
                        background: #fff;
                        padding: 6px;
                        border-radius: 16px;
                        display: flex;
                        position: relative;
                        box-shadow: 0 4px 12px rgba(0,0,0,0.03);
                        border: 1px solid #e2e8f0;
                    }
                    .premium-tab {
                        padding: 0.75rem 2rem;
                        border: none;
                        background: none;
                        font-weight: 700;
                        color: #64748b;
                        cursor: pointer;
                        z-index: 2;
                        transition: all 0.3s;
                        display: flex;
                        align-items: center;
                        gap: 8px;
                        font-family: inherit;
                    }
                    .premium-tab.active {
                        color: #0d9488;
                    }
                    .tab-count {
                        background: #f1f5f9;
                        padding: 2px 8px;
                        border-radius: 8px;
                        font-size: 0.75rem;
                        color: #475569;
                    }
                    .tab-slider {
                        position: absolute;
                        top: 6px;
                        left: 6px;
                        width: calc(50% - 6px);
                        height: calc(100% - 12px);
                        background: #f0fdfa;
                        border-radius: 12px;
                        transition: all 0.3s cubic-bezier(0.4, 0, 0.2, 1);
                        z-index: 1;
                        border: 1px solid #ccfbf1;
                    }
                    .slide-right {
                        transform: translateX(100%);
                    }

                    /* Card Styling */
                    .cards-list {
                        display: flex;
                        flex-direction: column;
                        gap: 1.25rem;
                        animation: fadeInUp 0.6s ease-out;
                    }
                    .premium-item-card {
                        background: #fff;
                        border-radius: 20px;
                        padding: 1.25rem;
                        border: 1px solid #e2e8f0;
                        display: flex;
                        flex-direction: column;
                        gap: 1rem;
                        transition: all 0.3s;
                        box-shadow: 0 2px 4px rgba(0,0,0,0.02);
                    }
                    .premium-item-card:hover {
                        transform: translateY(-4px);
                        box-shadow: 0 12px 20px -8px rgba(0,0,0,0.08);
                        border-color: #99f6e4;
                    }
                    
                    /* Timeline Styling */
                    .item-timeline {
                        display: flex;
                        align-items: center;
                        justify-content: space-between;
                        margin: 1rem 0;
                        padding: 1rem;
                        background: #f8fafc;
                        border-radius: 12px;
                        border: 1px solid #f1f5f9;
                    }
                    .timeline-step {
                        display: flex;
                        flex-direction: column;
                        align-items: center;
                        gap: 8px;
                        position: relative;
                        z-index: 2;
                        width: 70px;
                    }
                    .step-circle {
                        width: 16px;
                        height: 16px;
                        border-radius: 50%;
                        background: #e2e8f0;
                        border: 3px solid #fff;
                        box-shadow: 0 0 0 2px #e2e8f0;
                        transition: all 0.3s;
                    }
                    .step-label {
                        font-size: 0.7rem;
                        font-weight: 700;
                        color: #94a3b8;
                        text-align: center;
                        text-transform: uppercase;
                    }
                    .timeline-step.completed .step-circle {
                        background: #319795;
                        box-shadow: 0 0 0 2px #319795;
                    }
                    .timeline-step.completed .step-label {
                        color: #319795;
                    }
                    .timeline-step.active .step-circle {
                        background: #0ea5e9;
                        box-shadow: 0 0 0 3px #bae6fd;
                        animation: pulse 2s infinite;
                    }
                    .timeline-step.active .step-label {
                        color: #0ea5e9;
                    }
                    .timeline-line {
                        flex: 1;
                        height: 3px;
                        background: #e2e8f0;
                        margin-top: -18px;
                        z-index: 1;
                        transition: all 0.3s;
                    }
                    .timeline-line.completed {
                        background: #319795;
                    }

                    .card-top {
                        display: flex;
                        gap: 1.25rem;
                    }
                    .image-preview-container {
                        width: 90px;
                        height: 90px;
                        flex-shrink: 0;
                    }
                    .item-thumb, .item-thumb-placeholder {
                        width: 100%;
                        height: 100%;
                        border-radius: 16px;
                        object-fit: cover;
                        background: #f8fafc;
                        display: flex;
                        align-items: center;
                        justify-content: center;
                        color: #94a3b8;
                        border: 1px solid #f1f5f9;
                    }
                    .card-info {
                        flex: 1;
                    }
                    .title-row {
                        display: flex;
                        justify-content: space-between;
                        align-items: flex-start;
                        margin-bottom: 0.5rem;
                    }
                    .item-title {
                        font-size: 1.15rem;
                        font-weight: 800;
                        color: #1e293b;
                        margin: 0;
                    }
                    .status-badge {
                        padding: 4px 12px;
                        border-radius: 10px;
                        font-size: 0.75rem;
                        font-weight: 800;
                        text-transform: uppercase;
                        letter-spacing: 0.5px;
                    }
                    .details-row {
                        display: flex;
                        gap: 1.5rem;
                        margin-bottom: 0.75rem;
                    }
                    .meta-info {
                        display: flex;
                        align-items: center;
                        gap: 6px;
                        font-size: 0.85rem;
                        color: #64748b;
                    }
                    .attribute-chips {
                        display: flex;
                        flex-wrap: wrap;
                        gap: 8px;
                    }
                    .attr-chip {
                        background: #f1f5f9;
                        padding: 4px 10px;
                        border-radius: 8px;
                        font-size: 0.75rem;
                        color: #64748b;
                        border: 1px solid #e2e8f0;
                    }
                    .card-actions {
                        display: flex;
                        justify-content: flex-end;
                        gap: 1rem;
                        padding-top: 1rem;
                        border-top: 1px solid #f1f5f9;
                    }
                    .action-btn {
                        display: flex;
                        align-items: center;
                        gap: 8px;
                        padding: 8px 16px;
                        border-radius: 10px;
                        font-size: 0.85rem;
                        font-weight: 700;
                        cursor: pointer;
                        transition: all 0.2s;
                    }
                    .action-btn.secondary {
                        background: #fff;
                        border: 1px solid #e2e8f0;
                        color: #475569;
                    }
                    .action-btn.secondary:hover {
                        background: #f8fafc;
                        border-color: #cbd5e0;
                    }
                    .action-btn.match-btn {
                        background: #0ea5e9;
                        color: #ffffff;
                        border: none;
                        padding: 8px 24px;
                    }
                    .action-btn.match-btn:hover {
                        background: #0284c7;
                        transform: translateY(-2px);
                        box-shadow: 0 4px 12px rgba(14, 165, 233, 0.3);
                    }
                    .delete-btn-minimal {
                        padding: 8px;
                        color: #cbd5e0;
                        background: none;
                        border: none;
                        cursor: pointer;
                        transition: color 0.2s;
                    }
                    .delete-btn-minimal:hover {
                        color: #ef4444;
                    }

                    /* Empty State */
                    .premium-empty-state {
                        background: #fff;
                        border-radius: 30px;
                        padding: 4rem 2rem;
                        text-align: center;
                        border: 2px dashed #e2e8f0;
                        display: flex;
                        flex-direction: column;
                        align-items: center;
                        gap: 1rem;
                    }
                    .empty-icon-circle {
                        width: 80px;
                        height: 80px;
                        background: #f8fafc;
                        border-radius: 50%;
                        display: flex;
                        align-items: center;
                        justify-content: center;
                        margin-bottom: 0.5rem;
                    }
                    .premium-empty-state h3 {
                        font-size: 1.5rem;
                        font-weight: 800;
                        color: #1a202c;
                        margin: 0;
                    }
                    .premium-empty-state p {
                        color: #718096;
                        max-width: 400px;
                        line-height: 1.6;
                    }
                    .report-now-btn {
                        margin-top: 1rem;
                        background: #0d9488;
                        color: #fff;
                        padding: 0.85rem 2rem;
                        border-radius: 16px;
                        font-weight: 700;
                        border: none;
                        cursor: pointer;
                        display: flex;
                        align-items: center;
                        gap: 10px;
                        transition: all 0.3s;
                        box-shadow: 0 4px 12px rgba(13, 148, 136, 0.2);
                    }
                    .report-now-btn:hover {
                        background: #0f766e;
                        transform: translateY(-2px);
                        box-shadow: 0 6px 20px rgba(13, 148, 136, 0.3);
                    }

                    @keyframes fadeInUp {
                        from { opacity: 0; transform: translateY(20px); }
                        to { opacity: 1; transform: translateY(0); }
                    }
                `}</style>
            </main>
        </div>
    );
};

export default MyItems;
