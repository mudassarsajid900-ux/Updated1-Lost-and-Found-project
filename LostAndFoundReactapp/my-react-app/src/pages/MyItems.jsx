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
    MoreVertical, Trash2, Box, ArrowRight, ExternalLink
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
const MyItems = () => {
    const navigate = useNavigate();
    const [activeTab, setActiveTab] = useState('lost'); // 'lost' or 'found'
    const [loading, setLoading] = useState(true);
    const [myItems, setMyItems] = useState([]);

    const API_BASE_URL = import.meta.env.VITE_API_BASE_URL;

    useEffect(() => {
        const fetchMyItems = async () => {
            try {
                const response = await api.get('Item/my-items');

                // Support both camelCase and PascalCase from backend (JSON serializer differences)
                const isOk = response.data.isSucceeded || response.data.IsSucceeded;
                const data = response.data.data || response.data.Data;

                if (isOk && data) {
                    setMyItems(data);
                }
            } catch (err) {
                // If 401 occurs, the axios interceptor will handle redirection to login
                console.error('Failed to fetch my items:', err?.response?.status, err?.response?.data || err.message);
            } finally {
                setLoading(false);
            }
        };
        fetchMyItems();
    }, []);

    // Filter by the reportType property
    // Backend uses JsonStringEnumConverter so it sends 'Lost' / 'Found' (strings), NOT 0 / 1
    // We handle both string names AND numeric values just to be safe
    const isLostReport = (v) => v === 0 || v === 'Lost' || v === 'lost';
    const isFoundReport = (v) => v === 1 || v === 'Found' || v === 'found';

    const lostReports = myItems.filter(item => isLostReport(item.reportType ?? item.ReportType));
    const foundItems = myItems.filter(item => isFoundReport(item.reportType ?? item.ReportType));

    const getIconForType = (type) => {
        if (!type) return <Folder size={24} />;
        const t = type.toLowerCase();
        if (t.includes('wallet')) return <Wallet size={24} />;
        if (t.includes('laptop')) return <Laptop size={24} />;
        if (t.includes('phone') || t.includes('mobile')) return <Smartphone size={24} />;
        return <Folder size={24} />;
    };

    const getStatusTheme = (apiItem) => {
        const status = apiItem.status ?? apiItem.Status;
        const reportType = apiItem.reportType ?? apiItem.ReportType;
        const hasPotentialMatch = apiItem.hasPotentialMatch ?? apiItem.HasPotentialMatch;

        const isHandover = status === 4 || status === 'Handover' || status === 'Returned';
        const isFoundSt = status === 1 || status === 'Found';
        const isLostSt = status === 0 || status === 'Lost';
        const isLostRep = isLostReport(reportType);

        if (hasPotentialMatch) return { text: 'Potential Match Found!', color: '#0ea5e9', bg: '#e0f2fe' };
        if (isHandover) return { text: 'Returned', color: '#10b981', bg: '#ecfdf5' };
        if (isLostRep && isLostSt) return { text: 'Not Found Yet', color: '#718096', bg: '#f7fafc' };
        if (isLostRep && isFoundSt) return { text: 'Potential Match', color: '#319795', bg: '#e6fffa' };
        if (!isLostRep && isFoundSt) return { text: 'On Hand', color: '#319795', bg: '#e6fffa' };

        return { text: 'Processing', color: '#f59e0b', bg: '#fffbeb' };
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
                    </div>
                </div>

                <div className="card-actions">
                    {(apiItem.hasPotentialMatch || apiItem.HasPotentialMatch) ? (
                        <button className="action-btn match-btn" onClick={() => {
                            const foundId = apiItem.matchFoundItemId || apiItem.MatchFoundItemId;
                            navigate(`/match-details/${apiItem.id}/${foundId}`);
                        }}>
                            View Match
                        </button>
                    ) : (
                        <button className="action-btn secondary" onClick={() => navigate(`/report-details/${apiItem.id}`)}>
                            <ExternalLink size={16} /> Details
                        </button>
                    )}
                    <button className="delete-btn-minimal">
                        <Trash2 size={16} />
                    </button>
                </div>
            </div>
        );
    };

    return (
        <div className="dashboard-container">
            <Sidebar />

            <main className="main-content premium-bg">
                <div className="page-max-width">
                    <Header
                        title="My Lost & Found"
                        subtitle="Track and manage all your reported campus items"
                        showBack={true}
                        onBack={() => navigate('/dashboard')}
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
