import React, { useState, useEffect } from 'react';
import { User, Home, Folder, PlusCircle, Settings, LogOut, ChevronLeft, Gavel, Search, Clock, DollarSign, TrendingUp, Award, Zap, Shield, Loader, AlertCircle, Flame, ArrowUpCircle } from 'lucide-react';
import { useNavigate, useLocation } from 'react-router-dom';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';
import api from '../api/axios';

// ========================================== //
// SECTION 2: MAIN AUCTION COMPONENT
// This page manages items that remained unclaimed for a specific period.
// Per university policy, these items move to auction to clear inventory.
// Users can browse active auctions and place competitive bids.
// ========================================== //
const Auction = () => {
    // Navigate between pages
    const navigate = useNavigate();

    // Helper: Calculate remaining time in human-readable format
    const getTimeRemaining = (endDateStr) => {
        if (!endDateStr) return 'Active';
        const total = Date.parse(endDateStr) - Date.parse(new Date());
        if (total <= 0) return 'Ended';
        
        const seconds = Math.floor((total / 1000) % 60);
        const minutes = Math.floor((total / 1000 / 60) % 60);
        const hours = Math.floor((total / (1000 * 60 * 60)) % 24);
        const days = Math.floor(total / (1000 * 60 * 60 * 24));

        if (days > 0) return <span style={{ color: '#475569' }}>{days}d {hours}h left</span>;
        if (hours > 0) return <span style={{ color: '#ea580c', fontWeight: '800' }}>{hours}h {minutes}m left</span>;
        if (minutes > 0) return <span style={{ color: '#ef4444', fontWeight: '900', animation: 'pulse-fast 1.5s infinite' }}>{minutes}m {seconds}s left</span>;
        return <span style={{ color: '#dc2626', fontWeight: '900', animation: 'pulse-fast 0.8s infinite' }}>{seconds}s left</span>;
    };
    };

    // Helper: Dynamic Bid Increment based on current price
    const getMinIncrement = (currentPrice) => {
        if (currentPrice < 1000) return 100;
        if (currentPrice < 5000) return 250;
        if (currentPrice < 10000) return 500;
        if (currentPrice < 50000) return 1000;
        return 5000;
    };

    // ========================================== //
    // STATE VARIABLES
    // ========================================== //

    // Controls which top tab is active: 'browse' (all items) or 'my-bids'
    const [activeTab, setActiveTab] = useState('browse');

    // Controls if we show the full list or a single item's detail page
    const [viewMode, setViewMode] = useState('list'); // 'list' or 'detail'

    // Tracks which specific item the user clicked "Place Bid" on
    const [selectedItem, setSelectedItem] = useState(null);

    // Tracks the dollar amount the user types into the bid box
    const [bidAmount, setBidAmount] = useState('');

    // Controls the Bidding Modal visibility
    const [isModalOpen, setIsModalOpen] = useState(false);

    // API Data states
    const [auctions, setAuctions] = useState([]);
    const [loading, setLoading] = useState(true);
    const [submitStatus, setSubmitStatus] = useState({ type: '', message: '' });
    const [bidHistory, setBidHistory] = useState([]);
    const [loadingHistory, setLoadingHistory] = useState(false);

    const [myBids, setMyBids] = useState([]);
    const [myWins, setMyWins] = useState([]);
    const [loadingUserAuctions, setLoadingUserAuctions] = useState(false);
    const [selectedWinningAuction, setSelectedWinningAuction] = useState(null);

    const API_BASE_URL = import.meta.env.VITE_API_BASE_URL;

    // Get username from localStorage for display in the form
    const currentUserName = localStorage.getItem('username') || 'Guest User';

    // ========================================== //
    // API CALLS
    // ========================================== //
    const fetchAuctions = async () => {
        setLoading(true);
        try {
            const res = await api.get('Auction/active');
            if (res.data.isSucceeded || res.data.IsSucceeded) {
                setAuctions(res.data.data);
            }
        } catch (err) {
            console.error("Failed to fetch auctions", err);
        } finally {
            setLoading(false);
        }
    };

    const fetchHistory = async (auctionId) => {
        setLoadingHistory(true);
        try {
            const res = await api.get(`Auction/${auctionId}/history`);
            if (res.data.isSucceeded || res.data.IsSucceeded) {
                setBidHistory(res.data.data);
            }
        } catch (err) {
            console.error("Failed to fetch bid history", err);
        } finally {
            setLoadingHistory(false);
        }
    };

    const fetchUserAuctions = async () => {
        setLoadingUserAuctions(true);
        try {
            const [bidsRes, winsRes] = await Promise.all([
                api.get('Auction/my-bids'),
                api.get('Auction/my-wins')
            ]);

            if (bidsRes.data.isSucceeded || bidsRes.data.IsSucceeded) {
                setMyBids(bidsRes.data.data);
            }
            if (winsRes.data.isSucceeded || winsRes.data.IsSucceeded) {
                setMyWins(winsRes.data.data);
            }
        } catch (err) {
            console.error("Failed to fetch user auctions", err);
        } finally {
            setLoadingUserAuctions(false);
        }
    };

    useEffect(() => {
        fetchAuctions();
    }, []);

    useEffect(() => {
        if (activeTab === 'my-bids') {
            fetchUserAuctions();
        }
    }, [activeTab]);

    useEffect(() => {
        if (selectedItem && isModalOpen) {
            fetchHistory(selectedItem.id);
        }
    }, [selectedItem, isModalOpen]);

    // Handle deep-linking from Admin (e.g. ?activeId=123)
    const location = useLocation();
    useEffect(() => {
        if (!loading && auctions.length > 0) {
            const params = new URLSearchParams(location.search);
            const activeId = params.get('activeId');
            if (activeId) {
                const item = auctions.find(a => a.id === parseInt(activeId));
                if (item) {
                    setSelectedItem(item);
                    // Instead of just 'detail' view, let's open the Modal directly
                    // so the admin sees exactly what the student sees.
                    const currentPrice = Number(item.highestBid || item.HighestBid || 0);
                    const increment = getMinIncrement(currentPrice);
                    setBidAmount(currentPrice + increment);
                    setIsModalOpen(true);
                    
                    // Small delay to ensure render then scroll
                    setTimeout(() => {
                        const element = document.getElementById(`auction-card-${activeId}`);
                        if (element) {
                            element.scrollIntoView({ behavior: 'smooth', block: 'center' });
                        }
                    }, 100);
                }
            }
        }
    }, [loading, auctions, location.search]);

    // ========================================== //
    // HANDLERS
    // ========================================== //

    // User clicks the "Place Bid" button on an item card
    const handlePlaceBidClick = (item) => {
        setSelectedItem(item);
        const currentPrice = Number(item.highestBid || item.HighestBid || 0);
        const increment = getMinIncrement(currentPrice);
        setBidAmount(currentPrice + increment);
        setSubmitStatus({ type: '', message: '' });
        setIsModalOpen(true);
    };

    // Submitting the bid
    const handleSubmitBid = async () => {
        if (!selectedItem || !bidAmount) return;

        const newBidVal = parseInt(bidAmount);
        const currentPrice = Number(selectedItem.highestBid || selectedItem.HighestBid || 0);
        const minRequired = currentPrice + getMinIncrement(currentPrice);

        if (newBidVal < minRequired) {
            setSubmitStatus({
                type: 'error',
                message: `Minimum required bid is Rs. ${minRequired.toLocaleString()}`
            });
            return;
        }

        try {
            const data = {
                auctionId: selectedItem.id,
                bidAmount: newBidVal
            };

            const res = await api.post('Auction/place-bid', data);

            if (res.data.isSucceeded || res.data.IsSucceeded) {
                setSubmitStatus({ type: 'success', message: 'Bid placed successfully!' });

                // Refresh data
                fetchAuctions();
                fetchHistory(selectedItem.id);

                // Update selected item highest bid locally for instant feedback in modal
                setSelectedItem(prev => ({ ...prev, highestBid: newBidVal }));

                // Clear input after a short delay
                setTimeout(() => {
                    setSubmitStatus({ type: '', message: '' });
                }, 3000);
            } else {
                setSubmitStatus({ type: 'error', message: res.data.message || 'Failed to place bid' });
            }
        } catch (err) {
            const msg = err.response?.data?.message || 'Error connecting to server';
            setSubmitStatus({ type: 'error', message: msg });
        }
    };

    // User clicks the back arrow button to return to the list
    const handleBackToList = () => {
        setViewMode('list');
        setSelectedItem(null);
    };

    const handleViewReceipt = (win) => {
        setSelectedWinningAuction(win);
    };

    // Handler to open detail view from card title/image
    const handleItemClick = (item) => {
        setSelectedItem(item);
        setViewMode('detail');
    };

    // ========================================== //
    // SECTION 3: PREMIUM BIDDING MODAL
    // This matches the vertical two-card design in the user's screenshot.
    // ========================================== //
    const renderBidModal = () => {
        if (!isModalOpen || !selectedItem) return null;

        return (
            <div className="modal-overlay">
                <div className="bid-modal-container web-format animate-slide-up">

                    {/* MODAL NAVIGATION / HEADER */}
                    <div className="modal-top-header">
                        <div className="header-text">
                            <h3>Auction: {selectedItem.itemTitle || selectedItem.title}</h3>
                            <p>Status: Live Bidding</p>
                        </div>
                        <button className="close-btn-round" onClick={() => setIsModalOpen(false)}>×</button>
                    </div>

                    <div className="modal-web-grid">

                        {/* LEFT COLUMN: ITEM SUMMARY & MAIN STATS */}
                        <div className="modal-column-left">
                            <div className="modal-card-sleek item-summary-card full-height">
                                <div className="card-item-visual large">
                                    <img src={selectedItem.itemImageUrl ? `${API_BASE_URL}/${selectedItem.itemImageUrl}` : "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=500"} alt={selectedItem.itemTitle} />
                                </div>
                                <div className="card-item-details-center">
                                    <span className="label-dim">Current Highest Bid</span>
                                    <h1 className="bid-big-value"><span>Rs.</span> {Number(selectedItem.highestBid || selectedItem.HighestBid || 0).toLocaleString()}</h1>

                                    {submitStatus.message && (
                                        <div className={`status-banner ${submitStatus.type}`}>
                                            {submitStatus.type === 'success' ? <Zap size={16} /> : <AlertCircle size={16} />}
                                            {submitStatus.message}
                                        </div>
                                    )}

                                    <div className="bid-stats-row">
                                        <div className="stat-sm">
                                            <span className="l">Condition</span>
                                            <span className="v">Unclaimed</span>
                                        </div>
                                    </div>

                                    {/* TECHNICAL SPECIFICATIONS SECTION */}
                                    {selectedItem.attributes && selectedItem.attributes.length > 0 && (
                                        <div className="tech-specs-modal-zone" style={{ marginTop: '2rem', textAlign: 'left', background: '#f8fafc', padding: '1.5rem', borderRadius: '20px', border: '1px solid #e2e8f0' }}>
                                            <h5 style={{ margin: '0 0 1rem 0', fontSize: '0.8rem', fontWeight: '900', color: '#64748b', textTransform: 'uppercase' }}>Technical Specifications</h5>
                                            <div style={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '1rem' }}>
                                                {selectedItem.attributes.map((attr, idx) => (
                                                    <div key={idx} style={{ display: 'flex', flexDirection: 'column' }}>
                                                        <span style={{ fontSize: '0.7rem', fontWeight: '700', color: '#94a3b8', textTransform: 'uppercase' }}>{attr.fieldName}</span>
                                                        <span style={{ fontSize: '0.95rem', fontWeight: '800', color: '#1e293b' }}>{attr.fieldValue}</span>
                                                    </div>
                                                ))}
                                            </div>
                                        </div>
                                    )}
                                </div>
                            </div>
                        </div>

                        {/* RIGHT COLUMN: BIDDING & HISTORY */}
                        <div className="modal-column-right">
                            <div className="modal-card-sleek action-card-web">
                                <div className="card-inner-header">
                                    <h4>Take Action</h4>
                                </div>
                                    <div className="bid-interaction-zone">
                                        <div className="light-input-wrapper">
                                            <span className="rs-tag">Rs.</span>
                                            <input
                                                type="number"
                                                className="light-input-field"
                                                placeholder={`Min Rs. ${Number(Number(selectedItem.highestBid || selectedItem.HighestBid || 0) + getMinIncrement(Number(selectedItem.highestBid || selectedItem.HighestBid || 0))).toLocaleString()}`}
                                                value={bidAmount}
                                                onChange={(e) => setBidAmount(e.target.value)}
                                            />
                                        </div>
                                        <button className="place-bid-btn-primary" onClick={handleSubmitBid}>
                                            Place Your Bid
                                        </button>
                                    </div>
                                    <p style={{ marginTop: '10px', fontSize: '0.75rem', color: '#94a3b8', textAlign: 'center' }}>
                                        Required Minimum Increment: Rs. {getMinIncrement(Number(selectedItem.highestBid || selectedItem.HighestBid || 0)).toLocaleString()}
                                    </p>
                            </div>

                            <div className="modal-card-sleek history-card-web">
                                <div className="card-inner-header">
                                    <h4>Bidding History</h4>
                                </div>
                                <div className="bid-history-mini-list scrollable">
                                    {loadingHistory ? (
                                        <div className="loading-spinner-sm">Fetching bids...</div>
                                    ) : bidHistory.length > 0 ? (
                                        bidHistory.map((bid, idx) => (
                                            <div key={bid.id} className="mini-bid-row">
                                                <div className="bidder-vitals-box">
                                                    <div className="avatar-initials" style={{
                                                        background: idx === 0 ? '#0d9488' : idx % 2 === 0 ? '#6366f1' : '#2dd4bf'
                                                    }}>
                                                        {bid.bidderName?.split(' ').map(n => n[0]).join('').toUpperCase().substring(0, 2) || 'U'}
                                                    </div>
                                                    <span className="b-name">{bid.bidderName}</span>
                                                </div>
                                                <span className="b-amount">Rs. {bid.bidAmount.toLocaleString()}</span>
                                            </div>
                                        ))
                                    ) : (
                                        <div className="no-bids-text">No bids placed yet. Be the first!</div>
                                    )}
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );
    };

    const renderReceiptModal = () => {
        if (!selectedWinningAuction) return null;

        return (
            <div className="modal-overlay receipt-overlay">
                <div className="bid-modal-container receipt-container animate-slide-up" style={{ maxWidth: '450px', background: '#fff' }}>
                    <div className="receipt-paper">
                        <div className="receipt-top-header" style={{ background: '#0d9488', color: '#fff', padding: '2rem', textAlign: 'center', position: 'relative' }}>
                            <button className="close-btn-round" onClick={() => setSelectedWinningAuction(null)} style={{ position: 'absolute', top: '1rem', right: '1rem', background: 'rgba(255,255,255,0.2)', color: '#fff' }}>×</button>
                            <div style={{ background: '#fff', width: '60px', height: '60px', borderRadius: '50%', display: 'flex', alignItems: 'center', justifyContent: 'center', margin: '0 auto 1rem auto' }}>
                                <Award size={32} color="#0d9488" />
                            </div>
                            <h2 style={{ margin: 0, fontSize: '1.25rem', fontWeight: '900' }}>AUCTION WINNER</h2>
                            <p style={{ margin: '4px 0 0 0', fontSize: '0.8rem', opacity: 0.9 }}>Digital Acquisition Receipt</p>
                        </div>

                        <div style={{ padding: '2rem' }}>
                            <div style={{ textAlign: 'center', marginBottom: '1.5rem', borderBottom: '2px dashed #f1f5f9', paddingBottom: '1.5rem' }}>
                                <h3 style={{ margin: 0, fontSize: '1.1rem', color: '#1e293b', fontWeight: '800' }}>{selectedWinningAuction.itemTitle}</h3>
                                <p style={{ margin: '4px 0 0 0', fontSize: '0.8rem', color: '#94a3b8' }}>Order ID: {selectedWinningAuction.orderNumber || `AUC-${selectedWinningAuction.auctionId}`}</p>
                            </div>

                            <div style={{ display: 'flex', flexDirection: 'column', gap: '1rem' }}>
                                <div style={{ display: 'flex', justifyContent: 'space-between' }}>
                                    <span style={{ color: '#64748b', fontSize: '0.85rem', fontWeight: '600' }}>Winning Bid</span>
                                    <span style={{ color: '#1e293b', fontSize: '1rem', fontWeight: '800' }}>Rs. {selectedWinningAuction.winningBid.toLocaleString()}</span>
                                </div>
                                <div style={{ display: 'flex', justifyContent: 'space-between' }}>
                                    <span style={{ color: '#64748b', fontSize: '0.85rem', fontWeight: '600' }}>Winner Name</span>
                                    <span style={{ color: '#1e293b', fontSize: '0.9rem', fontWeight: '700' }}>{currentUserName}</span>
                                </div>
                                <div style={{ display: 'flex', justifyContent: 'space-between' }}>
                                    <span style={{ color: '#64748b', fontSize: '0.85rem', fontWeight: '600' }}>Date Won</span>
                                    <span style={{ color: '#1e293b', fontSize: '0.9rem', fontWeight: '700' }}>{new Date(selectedWinningAuction.endDate).toLocaleDateString()}</span>
                                </div>
                            </div>

                            <div style={{ marginTop: '2rem', padding: '1.5rem', background: '#f8fafc', borderRadius: '16px', border: '1px solid #e2e8f0', textAlign: 'center' }}>
                                <div style={{ width: '120px', height: '120px', background: '#fff', border: '1px solid #e2e8f0', margin: '0 auto 1rem auto', padding: '10px', display: 'flex', alignItems: 'center', justifyContent: 'center' }}>
                                    <div style={{ width: '100%', height: '100%', background: 'repeating-conic-gradient(#0f172a 0% 25%, #fff 0% 50%) 50% / 20px 20px' }}></div>
                                </div>
                                <p style={{ fontSize: '0.7rem', color: '#94a3b8', margin: 0 }}>PRESENT THIS QR CODE AT THE OFFICE FOR COLLECTION</p>
                            </div>

                            <div style={{ marginTop: '2rem', textAlign: 'center' }}>
                                <button 
                                    onClick={() => window.print()}
                                    style={{ width: '100%', padding: '1rem', borderRadius: '14px', background: '#1e293b', color: '#fff', fontWeight: '800', border: 'none', cursor: 'pointer', display: 'flex', alignItems: 'center', justifyContent: 'center', gap: '8px' }}
                                >
                                    Print Receipt
                                </button>
                                <p style={{ marginTop: '1rem', fontSize: '0.75rem', color: '#64748b', lineHeight: '1.4' }}>
                                    Note: Items must be collected within 48 hours. Please bring your University Identity Card.
                                </p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );
    };

    // ========================================== //
    // SECTION 4: DETAIL VIEW SCREEN
    // ========================================== //
    const renderBidDetail = () => {
        if (!selectedItem) return null;

        return (
            <div className="bid-detail-view animate-fade-in">
                <div className="detail-top-nav">
                    <button className="back-glass-btn" onClick={handleBackToList}>
                        <ChevronLeft size={20} />
                        <span>Back to Auctions</span>
                    </button>
                    <div className="live-status pulse">
                        <div className="red-dot"></div>
                        LIVE AUCTION
                    </div>
                </div>

                <div className="detail-grid-main">
                    <div className="detail-visual-column">
                        <div className="p-relative">
                            <div className="main-item-frame active-glow">
                                <img src={selectedItem.itemImageUrl ? `${API_BASE_URL}/${selectedItem.itemImageUrl}` : "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=800"} alt={selectedItem.itemTitle} />
                                <div className="condition-pill">Unclaimed Item</div>
                            </div>
                            <div className="item-meta-tiles">
                                <div className="meta-tile">
                                    <Clock size={16} />
                                    <span>{selectedItem.holdingTime}</span>
                                </div>
                                <div className="meta-tile">
                                    <Search size={16} />
                                    <span>{selectedItem.locationFound}</span>
                                </div>
                            </div>
                        </div>

                        <div className="premium-card history-container mt-6">
                            <div className="history-header">
                                <TrendingUp size={18} className="text-teal" />
                                <h4>Recent Bidding Activity</h4>
                            </div>
                            <div className="history-scroll-box">
                                {loadingHistory ? (
                                    <div className="loading-spinner-sm">Loading activity...</div>
                                ) : bidHistory.length > 0 ? (
                                    bidHistory.map((bid, idx) => (
                                        <div key={bid.id} className={`history-row ${idx === 0 ? 'top-bid' : ''}`}>
                                            <div className="bidder-vitals">
                                                <div className="mini-avatar">
                                                    <img src={`https://ui-avatars.com/api/?name=${encodeURIComponent(bid.bidderName)}&background=random`} alt="" />
                                                </div>
                                                <div className="bidder-text">
                                                    <p className="name">{bid.bidderName}</p>
                                                    <p className="time">{new Date(bid.createdOn).toLocaleTimeString()}</p>
                                                </div>
                                            </div>
                                            <div className="bid-value">
                                                Rs. {bid.bidAmount.toLocaleString()}
                                                {idx === 0 && <span className="highest-tag">Highest</span>}
                                            </div>
                                        </div>
                                    ))
                                ) : (
                                    <div className="no-bids-text">No bids yet.</div>
                                )}
                            </div>
                        </div>
                    </div>

                    <div className="detail-control-column">
                        <div className="bidding-dashboard-card shadow-ultra">
                            <div className="current-status-box">
                                <div className="price-label">Current Bid</div>
                                <div className="price-display">
                                    <span className="currency">Rs.</span>
                                    {Number(selectedItem.highestBid || selectedItem.HighestBid || 0).toLocaleString()}
                                </div>
                                <div className="timer-box">
                                    <Clock size={16} />
                                    <span>Time Left: {getTimeRemaining(selectedItem.endDate || selectedItem.EndDate)}</span>
                                </div>
                            </div>

                            {/* ITEM ATTRIBUTES IN DETAIL VIEW */}
                            {selectedItem.attributes && selectedItem.attributes.length > 0 && (
                                <div className="detail-specs-card" style={{ marginTop: '1.5rem', padding: '1.5rem', background: 'white', borderRadius: '20px', border: '1px solid #e2e8f0' }}>
                                    <h5 style={{ margin: '0 0 1rem 0', fontSize: '0.8rem', fontWeight: '800', color: '#64748b', textTransform: 'uppercase' }}>Item Details</h5>
                                    <div style={{ display: 'flex', flexDirection: 'column', gap: '0.75rem' }}>
                                        {selectedItem.attributes.map((attr, idx) => (
                                            <div key={idx} style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center', paddingBottom: '0.5rem', borderBottom: '1px solid #f1f5f9' }}>
                                                <span style={{ fontSize: '0.85rem', color: '#64748b', fontWeight: '600' }}>{attr.fieldName}</span>
                                                <span style={{ fontSize: '0.85rem', color: '#0f172a', fontWeight: '800' }}>{attr.fieldValue}</span>
                                            </div>
                                        ))}
                                    </div>
                                </div>
                            )}

                            <div className="bid-entry-zone mt-8">
                                <p className="bid-hint-top text-center mb-4">Click below to place your bid</p>
                                <button className="submit-bid-btn" onClick={() => handlePlaceBidClick(selectedItem)}>
                                    Place Bid
                                </button>
                            </div>

                            <div className="policy-note mt-6">
                                <Shield size={16} />
                                <span>Bids are binding. Won items must be collected within 48 hours of auction end.</span>
                            </div>
                        </div>

                        <div className="stats-grid-mini mt-6">
                            <div className="stat-pill">
                                <div className="v">{selectedItem.bids}</div>
                                <div className="l">Total Bids</div>
                            </div>
                            <div className="stat-pill">
                                <div className="v">550+</div>
                                <div className="l">Views</div>
                            </div>
                            <div className="stat-pill">
                                <div className="v"><Zap size={14} className="text-orange" /></div>
                                <div className="l">Hot Item</div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );
    };

    return (
        <div className="dashboard-container">
            <Sidebar />
            <main className="main-content">
                {viewMode === 'list' ? (
                    <>
                        <Header
                            title="Found Item Auction"
                            subtitle="Bid on unclaimed items"
                            showBack={true}
                            onBack={() => navigate('/dashboard')}
                        />
                        <div className="content-wrapper">
                            <div className="auction-tabs">
                                <button
                                    className={`tab-btn ${activeTab === 'browse' ? 'active' : ''}`}
                                    onClick={() => setActiveTab('browse')}
                                >
                                    <Search size={18} />
                                    Browse Items
                                </button>
                                <button
                                    className={`tab-btn ${activeTab === 'my-bids' ? 'active' : ''}`}
                                    onClick={() => setActiveTab('my-bids')}
                                >
                                    <TrendingUp size={18} />
                                    My Bids
                                </button>
                            </div>

                            {activeTab === 'browse' ? (
                                // ... (already integrated previously)
                                <div className="auction-grid animate-fade-in">
                                    <div className="grid-header-row">
                                        <h2 className="section-title-sm">Available Items</h2>
                                        <button className="refresh-btn" onClick={fetchAuctions} disabled={loading}>
                                            <TrendingUp size={16} /> Refresh List
                                        </button>
                                    </div>

                                    {loading ? (
                                        <div className="full-loading-state">
                                            <Loader className="spin" size={40} />
                                            <p>Loading live auctions...</p>
                                        </div>
                                    ) : auctions.length > 0 ? (
                                        auctions.map(item => (
                                            <div key={item.id} id={`auction-card-${item.id}`} className="auction-card premium-hover">
                                                <div className="card-image-box" onClick={() => handleItemClick(item)} style={{ cursor: 'pointer', position: 'relative', overflow: 'hidden' }}>
                                                    <img src={item.itemImageUrl ? `${API_BASE_URL}/${item.itemImageUrl}` : "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=500"} alt={item.itemTitle} />
                                                    <div className="holding-tag">Unclaimed</div>
                                                    <div className="glass-overlay"></div>
                                                </div>
                                                <div className="card-content">
                                                    <div className="item-info">
                                                        <h3 onClick={() => handleItemClick(item)} style={{ cursor: 'pointer', fontSize: '1.2rem', fontWeight: '900', color: '#1e293b' }}>{item.itemTitle}</h3>
                                                        <div className="bid-info-highlight" style={{ background: 'linear-gradient(135deg, #f8fafc 0%, #f1f5f9 100%)', borderRadius: '12px', padding: '10px' }}>
                                                            <span className="label" style={{ fontSize: '0.65rem', letterSpacing: '1px' }}>CURRENT BID:</span>
                                                            <span className="value" style={{ color: '#0d9488', fontSize: '1.25rem' }}>Rs. {Number(item.highestBid || 0).toLocaleString()}</span>
                                                        </div>
                                                        <div className="time-info" style={{ display: 'flex', gap: '10px', marginTop: '8px' }}>
                                                            <div style={{ display: 'flex', alignItems: 'center', gap: '6px', background: '#f0fdfa', padding: '4px 10px', borderRadius: '8px' }}>
                                                                <Clock size={14} className="icon-teal" />
                                                                <span style={{ fontSize: '0.85rem' }}>{getTimeRemaining(item.endDate || item.EndDate)}</span>
                                                            </div>
                                                            {Number(item.highestBid || 0) > 0 && (
                                                                <div style={{ display: 'flex', alignItems: 'center', gap: '4px', color: '#ea580c', background: '#ffedd5', padding: '4px 10px', borderRadius: '8px', fontSize: '0.8rem', fontWeight: 'bold' }}>
                                                                    <Flame size={12} fill="#ea580c" className="animate-bounce-slow" /> HOT
                                                                </div>
                                                            )}
                                                        </div>
                                                    </div>
                                                    <button className="bid-btn-premium" onClick={() => handlePlaceBidClick(item)}>
                                                        <Gavel size={16} /> Place Bid
                                                    </button>
                                                </div>
                                            </div>
                                        ))
                                    ) : (
                                        <div className="empty-auctions">
                                            <AlertCircle size={48} />
                                            <h3>No Active Auctions</h3>
                                            <p>Currently there are no unclaimed items in auction.</p>
                                        </div>
                                    )}
                                </div>
                            ) : (
                                <div className="my-bids-web-container animate-fade-in">
                                    <div className="my-bids-header">
                                        <h2 className="tracking-main-title">My Bids & Auctions</h2>
                                        <p className="tracking-sub-title">Track your active bids and won items</p>
                                    </div>

                                    {loadingUserAuctions ? (
                                        <div className="full-loading-state">
                                            <Loader className="spin" size={40} />
                                            <p>Syncing your bidding activity...</p>
                                        </div>
                                    ) : (
                                        <>
                                            {/* ACTIVE BIDS SECTION */}
                                            <div className="bids-section">
                                                <h3 className="section-label-web">Active Bids</h3>
                                                <div className="bids-list-web">
                                                    {myBids.length > 0 ? myBids.map(bid => (
                                                        <div key={bid.auctionId} className={`web-tracking-card ${bid.isHighestBidder ? 'active' : 'outbid'}`}>
                                                            <div className="tracking-visual">
                                                                <img src={bid.itemImageUrl ? `${API_BASE_URL}/${bid.itemImageUrl}` : "https://images.unsplash.com/photo-1523275335684-37898b6baf30?w=400"} alt={bid.itemTitle} />
                                                            </div>
                                                            <div className="tracking-info-wide">
                                                                <div className="info-main">
                                                                    <h4>{bid.itemTitle}</h4>
                                                                    <div className="stats-row-web">
                                                                        <p>Your Bid: <span className="v">Rs. {bid.myHighestBid.toLocaleString()}</span></p>
                                                                        <p>Current Highest: <span className="v">Rs. {bid.currentHighestBid.toLocaleString()}</span></p>
                                                                    </div>
                                                                    {bid.isHighestBidder ? (
                                                                        <div className="status-badge-blue"><Award size={16} /> You are the highest bidder!</div>
                                                                    ) : (
                                                                        <div className="status-badge-red" style={{ animation: 'pulse-fast 1s infinite' }}><AlertCircle size={16} /> ALERT: You've been outbid!</div>
                                                                    )}
                                                                </div>
                                                                    <div className="info-actions">
                                                                        <div className="time-left-pill" style={{ background: bid.isHighestBidder ? '#f1f5f9' : '#fee2e2', color: bid.isHighestBidder ? '#64748b' : '#ef4444' }}>
                                                                            {getTimeRemaining(bid.endDate || bid.EndDate)}
                                                                        </div>
                                                                        <button className="increase-bid-btn" style={{ display: 'flex', alignItems: 'center', gap: '6px' }} onClick={() => handlePlaceBidClick({ id: bid.auctionId, itemTitle: bid.itemTitle, highestBid: bid.currentHighestBid, itemImageUrl: bid.itemImageUrl, endDate: (bid.endDate || bid.EndDate) })}>
                                                                            <ArrowUpCircle size={18} /> Increase Bid
                                                                        </button>
                                                                    </div>
                                                            </div>
                                                        </div>
                                                    )) : (
                                                        <div className="empty-mini-state">You haven't placed any bids yet.</div>
                                                    )}
                                                </div>
                                            </div>

                                            {/* WON AUCTIONS SECTION */}
                                            <div className="bids-section mt-12">
                                                <h3 className="section-label-web">Won Auctions</h3>
                                                <div className="bids-list-web">
                                                    {myWins.length > 0 ? myWins.map(win => (
                                                        <div key={win.auctionId} className="web-tracking-card won">
                                                            <div className="tracking-visual">
                                                                <img src={win.itemImageUrl ? `${API_BASE_URL}/${win.itemImageUrl}` : "https://images.unsplash.com/photo-1590658268037-6bf12165a8df?w=400"} alt={win.itemTitle} />
                                                            </div>
                                                            <div className="tracking-info-wide">
                                                                <div className="info-main">
                                                                    <h4>{win.itemTitle}</h4>
                                                                    <div className="stats-row-web">
                                                                        <p>Winning Bid: <span className="v">Rs. {win.winningBid.toLocaleString()}</span></p>
                                                                        <p>End Date: <span className="v dim">{new Date(win.endDate).toLocaleDateString()}</span></p>
                                                                    </div>
                                                                    <div className="status-badge-green">Status: Ready for Pickup</div>
                                                                </div>
                                                                <div className="info-actions">
                                                                    <div className="receipt-pill">Order {win.orderNumber || `AUC-${win.auctionId}`}</div>
                                                                    <button className="view-details-btn" onClick={() => handleViewReceipt(win)}>View Receipt</button>
                                                                </div>
                                                            </div>
                                                        </div>
                                                    )) : (
                                                        <div className="empty-mini-state">No won auctions yet. Keep bidding!</div>
                                                    )}
                                                </div>
                                            </div>
                                        </>
                                    )}
                                </div>
                            )}
                        </div>
                    </>
                ) : (
                    renderBidDetail()
                )}
                {renderBidModal()}
                {renderReceiptModal()}
            </main>

            <style dangerouslySetInnerHTML={{
                __html: `
                .animate-fade-in { animation: fadeIn 0.4s ease-out; }
                .animate-slide-up { animation: slideUp 0.4s cubic-bezier(0.16, 1, 0.3, 1); }
                .animate-bounce-slow { animation: bounceSlow 3s infinite; }
                @keyframes fadeIn { from { opacity: 0; transform: translateY(10px); } to { opacity: 1; transform: translateY(0); } }
                @keyframes slideUp { from { opacity: 0; transform: translateY(40px); } to { opacity: 1; transform: translateY(0); } }
                @keyframes bounceSlow { 0%, 100% { transform: translateY(0); } 50% { transform: translateY(-5px); } }
                @keyframes pulse-fast { 0% { opacity: 1; transform: scale(1); } 50% { opacity: 0.7; transform: scale(0.98); } 100% { opacity: 1; transform: scale(1); } }
                
                .pulse { animation: pulse-shadow 2s infinite; }
                @keyframes pulse-shadow {
                    0% { box-shadow: 0 0 0 0 rgba(239, 68, 68, 0.4); }
                    70% { box-shadow: 0 0 0 10px rgba(239, 68, 68, 0); }
                    100% { box-shadow: 0 0 0 0 rgba(239, 68, 68, 0); }
                }

                .premium-hover {
                    transition: all 0.4s cubic-bezier(0.4, 0, 0.2, 1);
                }
                .premium-hover:hover {
                    transform: translateY(-8px);
                    box-shadow: 0 20px 40px -12px rgba(0,0,0,0.15);
                    border-color: #0d9488;
                }
                .premium-hover:hover img {
                    transform: scale(1.05);
                }
                .premium-hover img { transition: transform 0.6s cubic-bezier(0.4, 0, 0.2, 1); }

                .glass-overlay {
                    position: absolute; inset: 0;
                    background: linear-gradient(135deg, rgba(255,255,255,0.1) 0%, rgba(255,255,255,0) 100%);
                    opacity: 0; transition: opacity 0.4s;
                }
                .premium-hover:hover .glass-overlay { opacity: 1; }

                .bid-btn-premium {
                    width: 100%; padding: 12px; border-radius: 12px;
                    background: #1e293b; color: white; border: none;
                    font-weight: 800; display: flex; align-items: center; justify-content: center; gap: 8px;
                    cursor: pointer; transition: all 0.3s;
                }
                .bid-btn-premium:hover { background: #0d9488; transform: scale(1.02); box-shadow: 0 10px 15px -3px rgba(13, 148, 136, 0.3); }

                .modal-overlay {
                    position: fixed; top: 0; left: 0; right: 0; bottom: 0;
                    background: rgba(15, 23, 42, 0.4); backdrop-filter: blur(8px);
                    display: flex; align-items: center; justify-content: center; z-index: 1000; padding: 1rem;
                }

                .bid-modal-container.web-format {
                    background: #f8fafc; width: 100%; max-width: 1000px; border-radius: 32px;
                    overflow: hidden; box-shadow: 0 40px 100px -20px rgba(0,0,0,0.2);
                    display: flex; flex-direction: column; max-height: 85vh;
                    border: 1px solid #e2e8f0;
                }

                .modal-top-header { padding: 1.5rem 2.5rem; background: #ffffff; display: flex; align-items: center; justify-content: space-between; border-bottom: 1px solid #f1f5f9; }
                .header-text h3 { margin: 0; color: #1e293b; font-size: 1.5rem; font-weight: 900; }
                .header-text p { margin: 4px 0 0 0; color: #64748b; font-size: 0.95rem; font-weight: 600; }
                .close-btn-round { width: 40px; height: 40px; border-radius: 50%; border: none; background: #f1f5f9; color: #64748b; display: flex; align-items: center; justify-content: center; font-size: 1.5rem; cursor: pointer; transition: all 0.2s; }
                .close-btn-round:hover { background: #ef4444; color: white; }

                .modal-web-grid { display: grid; grid-template-columns: 400px 1fr; gap: 2rem; padding: 2rem; overflow-y: auto; background: #f8fafc; }
                .modal-column-left, .modal-column-right { display: flex; flex-direction: column; gap: 1.5rem; }

                .modal-card-sleek { background: #ffffff; border-radius: 24px; padding: 2rem; border: 1px solid #e2e8f0; box-shadow: 0 4px 12px rgba(0,0,0,0.03); }
                .modal-card-sleek.full-height { height: 100%; display: flex; flex-direction: column; }

                /* Item Summary Web */
                .card-item-visual.large { width: 100%; height: 300px; border-radius: 20px; overflow: hidden; border: 1px solid #f1f5f9; margin-bottom: 2rem; }
                .card-item-visual.large img { width: 100%; height: 100%; object-fit: cover; }
                .card-item-details-center { text-align: center; flex: 1; display: flex; flex-direction: column; justify-content: center; }
                .bid-big-value { font-size: 3.5rem; font-weight: 900; color: #1e293b; margin: 0.5rem 0; display: flex; align-items: baseline; justify-content: center; gap: 12px; }
                .bid-big-value span { font-size: 1.5rem; color: #0d9488; font-weight: 800; }
                .active-badge { display: inline-flex; align-items: center; gap: 8px; background: #f0fdf4; color: #15803d; padding: 10px 20px; border-radius: 100px; font-weight: 800; font-size: 0.9rem; margin: 1rem auto; box-shadow: 0 4px 10px rgba(21, 128, 61, 0.1); }
                .outbid-badge { display: inline-flex; align-items: center; gap: 8px; background: #fff1f2; color: #be123c; padding: 10px 20px; border-radius: 100px; font-weight: 800; font-size: 0.9rem; margin: 1rem auto; box-shadow: 0 4px 10px rgba(190, 18, 60, 0.1); }

                .bid-stats-row { display: flex; gap: 1.5rem; margin-top: 2rem; border-top: 1px solid #f1f5f9; padding-top: 1.5rem; }
                .stat-sm { flex: 1; display: flex; flex-direction: column; gap: 6px; }
                .stat-sm .l { font-size: 0.75rem; font-weight: 800; color: #94a3b8; text-transform: uppercase; letter-spacing: 0.5px; }
                .stat-sm .v { font-size: 1.1rem; font-weight: 800; color: #1e293b; }

                /* Action Card Web */
                .action-card-web { padding: 2.5rem; background: #ffffff; }
                .card-inner-header h4 { margin: 0 0 1.5rem 0; color: #1e293b; font-size: 1.25rem; font-weight: 900; }
                .bid-interaction-zone { display: flex; gap: 1.25rem; align-items: center; }
                .light-input-wrapper { 
                    flex: 1.5; margin-bottom: 0; background: #f8fafc; border-radius: 18px; border: 2px solid #e2e8f0; 
                    padding: 0 1.5rem; display: flex; align-items: center; height: 68px; transition: all 0.2s;
                }
                .light-input-wrapper:focus-within { border-color: #2dd4bf; background: white; box-shadow: 0 10px 20px -10px rgba(45, 212, 191, 0.3); }
                .rs-tag { color: #0d9488; font-weight: 900; margin-right: 0.75rem; font-size: 1.3rem; white-space: nowrap; }
                .light-input-field { 
                    flex: 1; height: 100%; background: transparent; border: none; font-size: 1.6rem; 
                    color: #1e293b; font-weight: 800; width: 100%; min-width: 0;
                }
                .light-input-field:focus { outline: none; }
                /* Hide spin buttons */
                input::-webkit-outer-spin-button, input::-webkit-inner-spin-button { -webkit-appearance: none; margin: 0; }
                input[type=number] { -moz-appearance: textfield; }

                .place-bid-btn-primary { 
                    flex: 1; padding: 0 1.5rem; height: 68px; margin-bottom: 0; flex-shrink: 0; 
                    background: linear-gradient(135deg, #2dd4bf 0%, #0d9488 100%); color: white;
                    border: none; border-radius: 18px; font-size: 1.1rem; font-weight: 900;
                    cursor: pointer; transition: all 0.3s cubic-bezier(0.4, 0, 0.2, 1);
                    box-shadow: 0 10px 20px -5px rgba(13, 148, 136, 0.4);
                    white-space: nowrap;
                }
                .place-bid-btn-primary:hover { transform: translateY(-3px) scale(1.02); box-shadow: 0 15px 30px -10px rgba(13, 148, 136, 0.6); }
                .place-bid-btn-primary:active { transform: translateY(-1px); }

                /* History Card Web */
                .history-card-web { flex: 1; display: flex; flex-direction: column; min-height: 400px; }
                .bid-history-mini-list.scrollable { max-height: 400px; overflow-y: auto; padding-right: 1rem; }
                
                /* Mini List Rows Web */
                .mini-bid-row { 
                    display: flex; align-items: center; justify-content: space-between; padding: 1.25rem 1.75rem; 
                    background: #ffffff; border-radius: 20px; border: 1px solid #f1f5f9; transition: all 0.3s;
                    margin-bottom: 0.85rem;
                }
                .mini-bid-row:hover { border-color: #2dd4bf; transform: translateX(8px); box-shadow: 0 10px 20px rgba(0,0,0,0.03); }
                .avatar-initials { width: 52px; height: 52px; font-size: 1.1rem; border: 3px solid white; box-shadow: 0 4px 10px rgba(0,0,0,0.1); }
                .b-name { font-size: 1.1rem; font-weight: 800; color: #1e293b; }
                .b-amount { font-size: 1.2rem; color: #0d9488; font-weight: 900; }

                .status-banner {
                    display: flex; align-items: center; gap: 8px; padding: 12px 18px; border-radius: 12px;
                    font-size: 0.9rem; font-weight: 700; margin-bottom: 1.5rem;
                }
                .status-banner.success { background: #f0fdf4; color: #15803d; border: 1px solid #dcfce7; }
                .status-banner.error { background: #fff1f2; color: #be123c; border: 1px solid #ffe4e6; }
                
                .refresh-btn {
                    display: flex; align-items: center; gap: 6px; background: white; border: 1px solid #e2e8f0;
                    padding: 8px 16px; border-radius: 10px; font-weight: 700; color: #64748b; cursor: pointer;
                    transition: all 0.2s;
                }
                .refresh-btn:hover { background: #f8fafc; color: #0d9488; border-color: #2dd4bf; }

                .full-loading-state {
                    display: flex; flex-direction: column; align-items: center; justify-content: center;
                    padding: 4rem; color: #94a3b8; gap: 1rem;
                }
                .spin { animation: spin 1s linear infinite; }
                @keyframes spin { from { transform: rotate(0deg); } to { transform: rotate(360deg); } }

                .grid-header-row { display: flex; align-items: center; justify-content: space-between; margin-bottom: 2rem; }
                .loading-spinner-sm { padding: 2rem; text-align: center; color: #94a3b8; font-weight: 600; }
                .no-bids-text { padding: 2rem; text-align: center; color: #94a3b8; font-style: italic; }
                
                .empty-auctions {
                    display: flex; flex-direction: column; align-items: center; justify-content: center;
                    padding: 5rem; text-align: center; color: #94a3b8; background: white; border-radius: 32px;
                    border: 2px dashed #e2e8f0; width: 100%;
                }
                .empty-auctions h3 { color: #1e293b; margin: 1.5rem 0 0.5rem 0; font-size: 1.5rem; font-weight: 900; }
                .empty-auctions p { font-size: 1.1rem; }



                .animate-fade-in { animation: fadeIn 0.4s ease-out; }
                .animate-slide-up { animation: slideUp 0.4s cubic-bezier(0.16, 1, 0.3, 1); }
                @keyframes fadeIn { from { opacity: 0; transform: translateY(10px); } to { opacity: 1; transform: translateY(0); } }
                @keyframes slideUp { from { opacity: 0; transform: translateY(40px); } to { opacity: 1; transform: translateY(0); } }

                .modal-overlay {
                    position: fixed; top: 0; left: 0; right: 0; bottom: 0;
                    background: rgba(15, 23, 42, 0.4); backdrop-filter: blur(8px);
                    display: flex; align-items: center; justify-content: center; z-index: 1000; padding: 1rem;
                }

                .bid-modal-container.web-format {
                    background: #f8fafc; width: 100%; max-width: 1000px; border-radius: 32px;
                    overflow: hidden; box-shadow: 0 40px 100px -20px rgba(0,0,0,0.2);
                    display: flex; flex-direction: column; max-height: 85vh;
                    border: 1px solid #e2e8f0;
                }

                .modal-top-header { padding: 1.5rem 2.5rem; background: #ffffff; display: flex; align-items: center; justify-content: space-between; border-bottom: 1px solid #f1f5f9; }
                .header-text h3 { margin: 0; color: #1e293b; font-size: 1.5rem; font-weight: 900; }
                .header-text p { margin: 4px 0 0 0; color: #64748b; font-size: 0.95rem; font-weight: 600; }
                .close-btn-round { width: 40px; height: 40px; border-radius: 50%; border: none; background: #f1f5f9; color: #64748b; display: flex; align-items: center; justify-content: center; font-size: 1.5rem; cursor: pointer; transition: all 0.2s; }
                .close-btn-round:hover { background: #ef4444; color: white; }

                .modal-web-grid { display: grid; grid-template-columns: 400px 1fr; gap: 2rem; padding: 2rem; overflow-y: auto; background: #f8fafc; }
                .modal-column-left, .modal-column-right { display: flex; flex-direction: column; gap: 1.5rem; }

                .modal-card-sleek { background: #ffffff; border-radius: 24px; padding: 2rem; border: 1px solid #e2e8f0; box-shadow: 0 4px 12px rgba(0,0,0,0.03); }
                
                .bid-big-value { font-size: 3.5rem; font-weight: 900; color: #1e293b; margin: 0.5rem 0; display: flex; align-items: baseline; justify-content: center; gap: 12px; }
                .bid-big-value span { font-size: 1.5rem; color: #0d9488; font-weight: 800; }
                .active-badge { display: inline-flex; align-items: center; gap: 8px; background: #f0fdf4; color: #15803d; padding: 10px 20px; border-radius: 100px; font-weight: 800; font-size: 0.9rem; margin: 1rem auto; box-shadow: 0 4px 10px rgba(21, 128, 61, 0.1); }
                .outbid-badge { display: inline-flex; align-items: center; gap: 8px; background: #fff1f2; color: #be123c; padding: 10px 20px; border-radius: 100px; font-weight: 800; font-size: 0.9rem; margin: 1rem auto; box-shadow: 0 4px 10px rgba(190, 18, 60, 0.1); }

                .light-input-wrapper { flex: 1.5; background: #f8fafc; border-radius: 18px; border: 2px solid #e2e8f0; padding: 0 1.5rem; display: flex; align-items: center; height: 68px; }
                .light-input-wrapper:focus-within { border-color: #2dd4bf; background: white; }
                .rs-tag { color: #0d9488; font-weight: 900; margin-right: 0.75rem; font-size: 1.3rem; }
                .light-input-field { flex: 1; height: 100%; background: transparent; border: none; font-size: 1.6rem; color: #1e293b; font-weight: 800; }
                .place-bid-btn-primary { flex: 1; height: 68px; background: linear-gradient(135deg, #2dd4bf 0%, #0d9488 100%); color: white; border: none; border-radius: 18px; font-weight: 900; cursor: pointer; transition: all 0.3s; box-shadow: 0 10px 20px -5px rgba(13, 148, 136, 0.4); }

                /* BROWSE ITEMS LIST STYLES */
                .auction-tabs { display: flex; gap: 1rem; margin-bottom: 2rem; background: #f1f5f9; padding: 0.5rem; border-radius: 14px; width: fit-content; }
                .tab-btn { display: flex; align-items: center; gap: 0.5rem; padding: 0.6rem 1.2rem; border-radius: 10px; border: none; background: transparent; color: #64748b; font-weight: 600; cursor: pointer; transition: all 0.2s; }
                .tab-btn.active { background: #2dd4bf; color: white; box-shadow: 0 4px 12px rgba(45, 212, 191, 0.3); }

                .auction-grid { display: grid; grid-template-columns: 1fr; gap: 1.5rem; margin-top: 1rem; }
                .auction-card { background: white; border-radius: 24px; overflow: hidden; display: flex; border: 1px solid #e2e8f0; transition: all 0.2s; box-shadow: 0 4px 12px rgba(0,0,0,0.03); }
                .auction-card:hover { transform: translateY(-4px); box-shadow: 0 12px 24px -10px rgba(0,0,0,0.1); border-color: #2dd4bf; }
                
                .card-image-box { width: 180px; height: 180px; position: relative; flex-shrink: 0; }
                .card-image-box img { width: 100%; height: 100%; object-fit: cover; }
                .holding-tag { position: absolute; bottom: 12px; left: 12px; background: rgba(15, 23, 42, 0.85); color: white; padding: 6px 14px; font-size: 0.75rem; border-radius: 100px; font-weight: 700; backdrop-filter: blur(4px); }
                
                .card-content { flex: 1; padding: 1.5rem 2.5rem; display: flex; align-items: center; justify-content: space-between; }
                .item-info h3 { font-size: 1.4rem; font-weight: 900; color: #1e293b; margin-bottom: 0.75rem; cursor: pointer; }
                .item-info h3:hover { color: #0d9488; }
                .bid-info-highlight { margin-bottom: 0.6rem; display: flex; align-items: center; gap: 8px; }
                .bid-info-highlight .label { color: #64748b; font-weight: 800; font-size: 0.85rem; text-transform: uppercase; letter-spacing: 0.5px; }
                .bid-info-highlight .value { color: #0d9488; font-weight: 900; font-size: 1.35rem; }
                .time-info { display: flex; align-items: center; gap: 6px; color: #64748b; font-weight: 600; font-size: 0.9rem; }
                
                .bid-btn { background: #1e293b; color: white; padding: 1rem 2rem; border-radius: 16px; font-weight: 800; border: none; cursor: pointer; transition: all 0.2s; }
                .bid-btn:hover { background: #0f172a; transform: scale(1.05); box-shadow: 0 10px 20px rgba(0,0,0,0.1); }

                /* MY BIDS DASHBOARD STYLES */
                .my-bids-web-container { padding: 1rem 0; }
                .tracking-main-title { font-size: 2.25rem; font-weight: 900; color: #1e293b; margin-bottom: 0.5rem; }
                .tracking-sub-title { color: #64748b; font-size: 1.1rem; font-weight: 500; margin-bottom: 2rem; }

                .section-label-web { font-size: 1.25rem; font-weight: 800; color: #1e293b; margin-bottom: 1.5rem; border-left: 5px solid #2dd4bf; padding-left: 1rem; }
                .bids-list-web { display: flex; flex-direction: column; gap: 1.25rem; }

                .web-tracking-card { background: white; border-radius: 24px; padding: 1.25rem; border: 1px solid #e2e8f0; display: flex; gap: 2rem; align-items: center; transition: all 0.2s; box-shadow: 0 4px 12px rgba(0,0,0,0.03); }
                .web-tracking-card:hover { transform: translateY(-3px); box-shadow: 0 10px 20px rgba(0,0,0,0.05); border-color: #2dd4bf; }

                .tracking-visual { width: 140px; height: 140px; border-radius: 20px; overflow: hidden; background: #f8fafc; flex-shrink: 0; border: 1px solid #f1f5f9; }
                .tracking-visual img { width: 100%; height: 100%; object-fit: cover; }

                .tracking-info-wide { flex: 1; display: flex; justify-content: space-between; align-items: center; }
                .info-main h4 { font-size: 1.3rem; font-weight: 900; color: #1e293b; margin-bottom: 0.75rem; }
                
                .status-badge-blue { display: inline-flex; align-items: center; background: #f0fdf4; color: #0d9488; padding: 6px 16px; border-radius: 100px; font-weight: 800; font-size: 0.85rem; border: 1px solid #dcfce7; }
                .status-badge-red { display: inline-flex; align-items: center; background: #fff1f2; color: #e11d48; padding: 6px 16px; border-radius: 100px; font-weight: 800; font-size: 0.85rem; border: 1px solid #ffe4e6; }
                .status-badge-green { display: inline-flex; align-items: center; background: #f0f9ff; color: #0284c7; padding: 6px 16px; border-radius: 100px; font-weight: 800; font-size: 0.85rem; border: 1px solid #e0f2fe; }

                .increase-bid-btn { background: #2dd4bf; color: white; border: none; padding: 1rem 1.5rem; border-radius: 16px; font-weight: 800; cursor: pointer; transition: all 0.2s; }
                .increase-bid-btn:hover { background: #0d9488; transform: translateY(-2px); box-shadow: 0 10px 20px rgba(13, 148, 136, 0.3); }
                .time-left-pill { background: #1e293b; color: white; padding: 6px 14px; border-radius: 100px; font-size: 0.8rem; font-weight: 800; margin-bottom: 8px; text-transform: uppercase; }
                .time-left-pill.red { background: #ef4444; }

                .mt-12 { margin-top: 3rem; }
                @keyframes pulse-fast { 0% { opacity: 1; transform: scale(1); } 50% { opacity: 0.8; transform: scale(1.02); } 100% { opacity: 1; transform: scale(1); } }
                .empty-mini-state { 
                    padding: 3rem; text-align: center; background: white; border-radius: 20px; 
                    border: 1px dashed #e2e8f0; color: #94a3b8; font-weight: 600; 
                }
                .web-tracking-card.outbid { border-left: 8px solid #f43f5e; }
                .web-tracking-card.active { border-left: 8px solid #0d9488; }
                .receipt-pill { background: #f1f5f9; color: #475569; padding: 4px 12px; border-radius: 100px; font-size: 0.75rem; font-weight: 700; margin-bottom: 8px; text-align: center; }
                .view-details-btn { padding: 0.8rem 1.2rem; border-radius: 12px; border: 1px solid #e2e8f0; background: white; color: #1e293b; font-weight: 700; cursor: pointer; transition: all 0.2s; }
                .view-details-btn:hover { background: #f8fafc; border-color: #cbd5e1; }
                `
            }} />
        </div>
    );
};

export default Auction;
