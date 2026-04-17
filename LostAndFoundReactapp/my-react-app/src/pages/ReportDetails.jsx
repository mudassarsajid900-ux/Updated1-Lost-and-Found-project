import React, { useState, useEffect } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import {
    ChevronLeft, Calendar, MapPin, Clock, Tag,
    Info, Smartphone, Laptop, Wallet, Folder,
    CheckCircle2, AlertCircle, History, Package,
    Briefcase, Watch, FileText, Gem, Headphones
} from 'lucide-react';
import api from '../api/axios';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';

const ReportDetails = () => {
    const { id } = useParams();
    const navigate = useNavigate();
    const [item, setItem] = useState(null);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);

    const API_BASE_URL = import.meta.env.VITE_API_BASE_URL;

    useEffect(() => {
        const fetchItemDetails = async () => {
            try {
                const response = await api.get(`Item/get-by-id/${id}`);
                const isOk = response.data.isSucceeded || response.data.IsSucceeded;
                const data = response.data.data || response.data.Data;

                if (isOk && data) {
                    setItem(data);
                } else {
                    setError("Could not find the details for this item.");
                }
            } catch (err) {
                console.error('Error fetching item details:', err);
                setError("Failed to load item details. Please check your connection.");
            } finally {
                setLoading(false);
            }
        };

        if (id) fetchItemDetails();
    }, [id]);

    const getIconForType = (type) => {
        if (!type) return <Package size={40} />;
        const t = type.toLowerCase();
        if (t.includes('wallet')) return <Wallet size={40} />;
        if (t.includes('hardware') || t.includes('laptop') || t.includes('computing')) return <Laptop size={40} />;
        if (t.includes('device') || t.includes('phone') || t.includes('mobile')) return <Smartphone size={40} />;
        if (t.includes('jewelry') || t.includes('valuables')) return <Gem size={40} />;
        if (t.includes('audio') || t.includes('earphone') || t.includes('headphone')) return <Headphones size={40} />;
        return <Package size={40} />;
    };

    const getStatusInfo = (status, reportType) => {
        const isLost = reportType === 0 || reportType === 'Lost' || reportType === 'lost';

        // Status Enums: 0=Lost, 1=Found, 2=Claimed, 3=Auctioned, 4=Handover
        if (status === 4 || status === 'Handover' || status === 'Returned') {
            return { label: 'Returned to Owner', color: '#10b981', bg: '#ecfdf5', icon: <CheckCircle2 size={18} /> };
        }
        if (status === 1 || status === 'Found') {
            return isLost
                ? { label: 'Potential Match Found', color: '#0d9488', bg: '#f0fdfa', icon: <CheckCircle2 size={18} /> }
                : { label: 'Item On Hand', color: '#0d9488', bg: '#f0fdfa', icon: <Package size={18} /> };
        }
        if (status === 0 || status === 'Lost') {
            return { label: 'Not Found Yet', color: '#64748b', bg: '#f8fafc', icon: <AlertCircle size={18} /> };
        }

        return { label: 'Processing', color: '#f59e0b', bg: '#fffbeb', icon: <History size={18} /> };
    };

    if (loading) {
        return (
            <div className="dashboard-container">
                <Sidebar />
                <main className="main-content premium-bg">
                    <div className="loading-state">
                        <div className="spinner"></div>
                        <p>Loading Item Details...</p>
                    </div>
                </main>
            </div>
        );
    }

    if (error || !item) {
        return (
            <div className="dashboard-container">
                <Sidebar />
                <main className="main-content premium-bg">
                    <div className="error-state">
                        <AlertCircle size={48} color="#ef4444" />
                        <h2>Oops!</h2>
                        <p>{error}</p>
                        <button onClick={() => navigate('/my-items')} className="back-btn-error">
                            Back to My Items
                        </button>
                    </div>
                </main>
            </div>
        );
    }

    const statusTheme = getStatusInfo(item.status, item.reportType);
    const attrs = item.attributes || [];

    return (
        <div className="dashboard-container">
            <Sidebar />

            <main className="main-content premium-bg">
                <div className="page-max-width">
                    <Header
                        title="Report Details"
                        subtitle="Full history and information of your reported item"
                        showBack={true}
                        onBack={() => navigate('/my-items')}
                    />

                    <div className="details-grid">
                        {/* LEFT COLUMN: Main Info & Image */}
                        <div className="details-main-card glass-card">
                            <div className="item-hero">
                                <div className="hero-image-container">
                                    {item.imageUrl ? (
                                        <img
                                            src={`${API_BASE_URL}${item.imageUrl}`}
                                            alt={item.type}
                                            className="hero-image"
                                            onError={(e) => {
                                                e.target.onerror = null;
                                                e.target.src = 'https://via.placeholder.com/400?text=No+Photo+Available';
                                            }}
                                        />
                                    ) : (
                                        <div className="hero-placeholder">
                                            {getIconForType(item.type)}
                                            <span>No Photo Uploaded</span>
                                        </div>
                                    )}
                                </div>
                                <div className="hero-overlay">
                                    <div className="status-pill" style={{ backgroundColor: statusTheme.bg, color: statusTheme.color }}>
                                        {statusTheme.icon}
                                        <span>{statusTheme.label}</span>
                                    </div>
                                </div>
                            </div>

                            <div className="content-padding">
                                <div className="header-flex">
                                    <div>
                                        <span className="category-tag">{item.type}</span>
                                        <h1 className="item-main-title">{item.type} Report</h1>
                                    </div>
                                </div>

                                <div className="info-strip">
                                    <div className="info-item">
                                        <Calendar size={18} className="info-icon" />
                                        <div>
                                            <span className="info-label">Date Reported</span>
                                            <span className="info-value">{new Date(item.eventTime).toLocaleDateString()}</span>
                                        </div>
                                    </div>
                                    <div className="info-item">
                                        <MapPin size={18} className="info-icon" />
                                        <div>
                                            <span className="info-label">Reported Location</span>
                                            <span className="info-value">{item.locationName}</span>
                                        </div>
                                    </div>
                                    <div className="info-item">
                                        <Clock size={18} className="info-icon" />
                                        <div>
                                            <span className="info-label">Reported Time</span>
                                            <span className="info-value">{new Date(item.eventTime).toLocaleTimeString([], { hour: '2-digit', minute: '2-digit' })}</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        {/* RIGHT COLUMN: Specific Attributes */}
                        <div className="attributes-card glass-card">
                            <div className="card-header">
                                <Tag size={20} className="header-icon" />
                                <h2>Item Specification</h2>
                            </div>

                            <div className="attributes-list">
                                {attrs.length > 0 ? (
                                    attrs.map((attr, idx) => (
                                        <div key={idx} className="attribute-row">
                                            <span className="attr-name">{attr.fieldName}</span>
                                            <span className="attr-dots"></span>
                                            <span className="attr-value">{attr.fieldValue}</span>
                                        </div>
                                    ))
                                ) : (
                                    <p className="no-attributes">No specific details provided for this item.</p>
                                )}
                            </div>

                            <div className="bottom-guidance">
                                <Info size={16} />
                                <p>This information helps campus security verify your ownership when the item is found.</p>
                            </div>
                        </div>
                    </div>
                </div>

                <style>{`
                    .premium-bg {
                        background: radial-gradient(circle at top right, #f8fafc, #f1f5f9);
                        min-height: 100vh;
                        padding: 3rem;
                    }
                    .page-max-width {
                        max-width: 1000px;
                        margin: 0 auto;
                    }
                    .glass-card {
                        background: rgba(255, 255, 255, 0.8);
                        backdrop-filter: blur(10px);
                        border-radius: 24px;
                        border: 1px solid rgba(226, 232, 240, 0.6);
                        box-shadow: 0 10px 25px -5px rgba(0, 0, 0, 0.05);
                        overflow: hidden;
                    }
                    
                    .details-grid {
                        display: grid;
                        grid-template-columns: 1.5fr 1fr;
                        gap: 2rem;
                        margin-top: 2rem;
                    }

                    /* Hero Section */
                    .item-hero {
                        position: relative;
                        height: 350px;
                        background: #f8fafc;
                    }
                    .hero-image-container {
                        width: 100%;
                        height: 100%;
                    }
                    .hero-image {
                        width: 100%;
                        height: 100%;
                        object-fit: cover;
                    }
                    .hero-placeholder {
                        display: flex;
                        flex-direction: column;
                        align-items: center;
                        justify-content: center;
                        height: 100%;
                        color: #94a3b8;
                        gap: 1rem;
                    }
                    .hero-placeholder span {
                        font-weight: 600;
                        font-size: 0.9rem;
                    }
                    .hero-overlay {
                        position: absolute;
                        top: 20px;
                        left: 20px;
                    }
                    .status-pill {
                        display: flex;
                        align-items: center;
                        gap: 8px;
                        padding: 8px 16px;
                        border-radius: 100px;
                        font-weight: 800;
                        font-size: 0.8rem;
                        text-transform: uppercase;
                        letter-spacing: 0.5px;
                        box-shadow: 0 4px 10px rgba(0,0,0,0.1);
                    }

                    .content-padding {
                        padding: 2rem;
                    }
                    .category-tag {
                        display: inline-block;
                        background: #f0fdfa;
                        color: #0d9488;
                        padding: 4px 12px;
                        border-radius: 8px;
                        font-size: 0.75rem;
                        font-weight: 700;
                        margin-bottom: 0.5rem;
                        border: 1px solid #ccfbf1;
                    }
                    .item-main-title {
                        font-size: 1.75rem;
                        font-weight: 900;
                        color: #0f172a;
                        margin-bottom: 2rem;
                    }

                    .info-strip {
                        display: grid;
                        grid-template-columns: repeat(3, 1fr);
                        gap: 1.5rem;
                        background: #f8fafc;
                        padding: 1.5rem;
                        border-radius: 20px;
                        border: 1px solid #e2e8f0;
                    }
                    .info-item {
                        display: flex;
                        align-items: center;
                        gap: 12px;
                    }
                    .info-icon {
                        color: #0d9488;
                    }
                    .info-label {
                        display: block;
                        font-size: 0.7rem;
                        color: #64748b;
                        text-transform: uppercase;
                        font-weight: 700;
                        letter-spacing: 0.5px;
                    }
                    .info-value {
                        display: block;
                        font-size: 0.95rem;
                        font-weight: 700;
                        color: #1e293b;
                    }

                    /* Attributes Panel */
                    .attributes-card {
                        height: fit-content;
                        padding: 2rem;
                    }
                    .card-header {
                        display: flex;
                        align-items: center;
                        gap: 12px;
                        margin-bottom: 2rem;
                    }
                    .header-icon {
                        color: #0d9488;
                    }
                    .card-header h2 {
                        font-size: 1.25rem;
                        font-weight: 800;
                        color: #0f172a;
                        margin: 0;
                    }
                    
                    .attributes-list {
                        display: flex;
                        flex-direction: column;
                        gap: 1.25rem;
                    }
                    .attribute-row {
                        display: flex;
                        align-items: center;
                        justify-content: space-between;
                    }
                    .attr-name {
                        color: #64748b;
                        font-size: 0.9rem;
                        font-weight: 600;
                        background: #fff;
                        padding-right: 8px;
                        z-index: 1;
                    }
                    .attr-value {
                        color: #1e293b;
                        font-size: 0.95rem;
                        font-weight: 700;
                        background: #fff;
                        padding-left: 8px;
                        z-index: 1;
                        text-align: right;
                    }
                    .attr-dots {
                        flex: 1;
                        border-bottom: 1px dashed #e2e8f0;
                        margin-bottom: 4px;
                    }
                    .no-attributes {
                        color: #94a3b8;
                        text-align: center;
                        padding: 2rem 0;
                        font-style: italic;
                    }

                    .bottom-guidance {
                        margin-top: 2.5rem;
                        background: rgba(13, 148, 136, 0.04);
                        padding: 1.25rem;
                        border-radius: 16px;
                        display: flex;
                        gap: 12px;
                        border: 1px solid rgba(13, 148, 136, 0.1);
                    }
                    .bottom-guidance p {
                        font-size: 0.8rem;
                        color: #0f766e;
                        line-height: 1.5;
                        margin: 0;
                    }

                    /* State Handling */
                    .loading-state, .error-state {
                        height: 60vh;
                        display: flex;
                        flex-direction: column;
                        align-items: center;
                        justify-content: center;
                        gap: 1.5rem;
                    }
                    .spinner {
                        width: 40px;
                        height: 40px;
                        border: 3px solid #f3f3f3;
                        border-top: 3px solid #0d9488;
                        border-radius: 50%;
                        animation: spin 1s linear infinite;
                    }
                    .back-btn-error {
                        background: #0d9488;
                        color: #fff;
                        padding: 10px 24px;
                        border-radius: 12px;
                        border: none;
                        font-weight: 700;
                        cursor: pointer;
                    }

                    @keyframes spin {
                        0% { transform: rotate(0deg); }
                        100% { transform: rotate(360deg); }
                    }

                    @media (max-width: 850px) {
                        .details-grid {
                            grid-template-columns: 1fr;
                        }
                        .info-strip {
                            grid-template-columns: 1fr;
                        }
                    }
                `}</style>
            </main>
        </div>
    );
};

export default ReportDetails;
