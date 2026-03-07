// ========================================== //
// SECTION 1: IMPORTS
// We import React and icons
// ========================================== //
import React, { useState } from 'react';
import { User, Home, Folder, PlusCircle, Settings, LogOut, ChevronLeft, Gavel, Search, Clock, DollarSign, TrendingUp, Award, Zap } from 'lucide-react';
import { useNavigate } from 'react-router-dom';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';

// ========================================== //
// SECTION 2: MAIN AUCTION COMPONENT
// This page shows items unclaimed for 3+ years that administrators
// have put up for auction. Users can bid on them here.
// ========================================== //
const Auction = () => {
    // Navigate between pages
    const navigate = useNavigate();

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

    // ========================================== //
    // FAKE DATA SECTION
    // These are test items to show what the auction looks like.
    // ========================================== //
    const auctionItems = [
        {
            id: 1,
            title: "Unclaimed Mobile Phone",
            currentBid: 35000,
            timeLeft: "1h 34m 5s",
            holdingTime: "3 years",
            image: "https://images.unsplash.com/photo-1511707171634-5f897ff02aa9?w=400&auto=format&fit=crop",
            bids: 15,
            history: [
                { id: 101, name: "Saif", amount: 35700, time: "2 mins ago", isHighest: true },
                { id: 102, name: "Qasim", amount: 36000, time: "5 mins ago", isHighest: false },
                { id: 103, name: "Sara", amount: 35500, time: "12 mins ago", isHighest: false },
            ]
        },
        {
            id: 2,
            title: "Blue Hiking Backpack",
            currentBid: 1500,
            timeLeft: "1d 12h",
            holdingTime: "3 years",
            image: "https://images.unsplash.com/photo-1553062407-98eeb64c6a62?w=400&auto=format&fit=crop",
            bids: 8,
            history: [
                { id: 201, name: "Ali", amount: 1200, time: "1 hour ago", isHighest: true },
                { id: 202, name: "Zain", amount: 1100, time: "3 hours ago", isHighest: false },
            ]
        },
    ];

    // ========================================== //
    // HANDLERS
    // ========================================== //

    // User clicks the "Place Bid" button on an item card
    const handlePlaceBidClick = (item) => {
        setSelectedItem(item);
        // Pre-fill the bid box with a number slightly higher than current bid
        setBidAmount(item.currentBid + 100);
        setViewMode('detail');
    };

    // User clicks the back arrow button to return to the list
    const handleBackToList = () => {
        setViewMode('list');
        setSelectedItem(null);
    };

    // ========================================== //
    // SECTION 3: RENDER THE DETAIL VIEW SCREEN
    // Shows the big screen when you click a single item
    // ========================================== //
    const renderBidDetail = () => {
        if (!selectedItem) return null;

        return (
            <div className="bid-detail-view animate-fade-in">
                {/* Top header with back button */}
                <header className="detail-header">
                    <button className="back-circle-btn" onClick={handleBackToList}>
                        <ChevronLeft size={24} />
                    </button>
                    <div className="header-text-group">
                        <h2 className="detail-title">Auction: {selectedItem.title}</h2>
                        <p className="detail-time">Time Left: <span className="highlight">{selectedItem.timeLeft}</span></p>
                    </div>
                </header>

                <div className="detail-layout">
                    {/* 3A. Top Image & Price Summary Card */}
                    <div className="summary-card-teal">
                        <div className="image-frame">
                            <img src={selectedItem.image} alt={selectedItem.title} />
                        </div>
                        <div className="status-overlay">
                            <label className="label-xs">Current Highest Bid:</label>
                            <h1 className="highest-value">{selectedItem.currentBid}</h1>
                            {/* "You are winning" Badge */}
                            <div className="badge-winning">
                                <Award size={14} />
                                <span>You are the highest bidder!</span>
                            </div>
                            <p className="bid-count">Number of Bids: {selectedItem.bids}</p>
                        </div>
                    </div>

                    {/* 3B. Input Box to type new bid */}
                    <div className="bid-tool-card shadow-premium">
                        <h3 className="sub-title-teal">Place Your Bid</h3>
                        <div className="bid-input-wrapper">
                            <div className="currency-sim">PKR</div>
                            <input
                                type="number"
                                className="premium-input"
                                placeholder="Enter your bid"
                                value={bidAmount}
                                onChange={(e) => setBidAmount(e.target.value)}
                            />
                        </div>
                        <button className="place-bid-btn-wide" onClick={() => alert("Bid Placed successfully!")}>
                            Place Your Bid
                        </button>

                        {/* 3C. List showing other people who bid */}
                        <div className="history-section mt-6">
                            <h4 className="history-title">Bid History</h4>
                            <div className="history-list">
                                {selectedItem.history?.map((bid, idx) => (
                                    <div key={bid.id} className={`history-item ${idx === 0 ? 'active' : ''}`}>
                                        <div className="bidder-info">
                                            <div className="bidder-avatar">
                                                <img src={`https://ui-avatars.com/api/?name=${bid.name}&background=random`} alt={bid.name} />
                                            </div>
                                            <span className="bidder-name">{bid.name.toLowerCase()}</span>
                                        </div>
                                        <span className="bid-amount-text">{bid.amount}</span>
                                    </div>
                                ))}
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        );
    };

    // ========================================== //
    // SECTION 4: MAIN PAGE RENDER / LAYOUT
    // ========================================== //
    return (
        <div className="dashboard-container">
            {/* Show left Sidebar menu */}
            <Sidebar />

            {/* Main Content Area */}
            <main className="main-content">

                {/* Shows the main list view unless the user clicked a specific item */}
                {viewMode === 'list' ? (
                    <>
                        <Header
                            title="Found Item Auction"
                            subtitle="Bid on unclaimed items"
                            showBack={true}
                            onBack={() => navigate('/dashboard')}
                        />

                        <div className="content-wrapper">

                            {/* ------------------------------------------- */}
                            {/* SECTION 5: TOP MENU TABS */}
                            {/* Browse or My Bids */}
                            {/* ------------------------------------------- */}
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

                            {/* ------------------------------------------- */}
                            {/* SECTION 6: TABS CONTENT ROUTER */}
                            {/* Shows appropriate view based on activated tab */}
                            {/* ------------------------------------------- */}

                            {/* SCENARIO A: BROWSE ALL ITEMS */}
                            {activeTab === 'browse' ? (
                                <div className="auction-grid">
                                    <h2 className="section-title-sm">Item Options</h2>
                                    {auctionItems.map(item => (
                                        <div key={item.id} className="auction-card">

                                            {/* Left Image Section */}
                                            <div className="card-image-box">
                                                <img src={item.image} alt={item.title} />
                                                <div className="holding-tag">{item.holdingTime}</div>
                                            </div>

                                            {/* Right Text Section */}
                                            <div className="card-content">
                                                <div className="item-info">
                                                    <h3>{item.title}</h3>
                                                    <div className="bid-info">
                                                        <span className="label">Current Bid:</span>
                                                        <span className="value">Rs. {item.currentBid.toLocaleString()}</span>
                                                    </div>
                                                    <div className="time-info">
                                                        <Clock size={14} className="icon-teal" />
                                                        <span>{item.timeLeft} remaining</span>
                                                    </div>
                                                </div>

                                                {/* Action Button */}
                                                <button className="bid-btn" onClick={() => handlePlaceBidClick(item)}>
                                                    Place Bid
                                                </button>
                                            </div>
                                        </div>
                                    ))}
                                </div>
                            ) : (

                                /* SCENARIO B: VIEWING 'MY BIDS' */
                                <div className="bids-tracking-container">
                                    <div className="bids-tracking">
                                        <h2 className="tracking-main-title">My Bids & Auctions</h2>
                                        <p className="tracking-sub-title">Track your active bids and won items</p>

                                        {/* Box 1: In-Progress Bids */}
                                        <h2 className="section-title-sm mt-8">Active Bids</h2>
                                        <div className="active-bids-list">

                                            {/* Sample Active Bid Item 1 */}
                                            <div className="tracking-card-detailed">
                                                <div className="tracking-img-box">
                                                    <img src="https://images.unsplash.com/photo-1523275335684-37898b6baf30?w=200" alt="Smartwatch" />
                                                </div>
                                                <div className="tracking-body">
                                                    <h4>Unclaimed Smartwatch</h4>
                                                    <div className="tracking-stats">
                                                        <p>Your Bid: <span className="v">2000</span></p>
                                                        <p>Current Highest Bid: <span className="v">2000</span></p>
                                                    </div>
                                                    <div className="status-blue-text">You are the highest bidder!</div>
                                                </div>
                                            </div>

                                            {/* Sample Active Bid Item 2 */}
                                            <div className="tracking-card-detailed column">
                                                <div className="tracking-card-top-row">
                                                    <div className="tracking-img-box">
                                                        <img src="https://images.unsplash.com/photo-1511707171634-5f897ff02aa9?w=200" alt="Phone" />
                                                    </div>
                                                    <div className="tracking-body">
                                                        <h4>Unclaimed Mobile Phone</h4>
                                                        <p className="bid-val-only">Your Bid: <span className="v">20000</span></p>
                                                    </div>
                                                </div>
                                                <div className="card-footer-flex">
                                                    <div className="time-left-badge">Time Left: 45m 30s</div>
                                                    <button className="increase-bid-btn">Increase Bid</button>
                                                </div>
                                            </div>
                                        </div>

                                        {/* Box 2: Won Items History */}
                                        <h2 className="section-title-sm mt-10">Won Auctions</h2>
                                        <div className="won-auctions-list">
                                            <div className="tracking-card-detailed">
                                                <div className="tracking-img-box bg-white-frame">
                                                    <img src="https://images.unsplash.com/photo-1590658268037-6bf12165a8df?w=200" alt="Earbuds" />
                                                </div>
                                                <div className="tracking-body">
                                                    <h4>Found Wireless Earbuds</h4>
                                                    <p>Winning Bid: <span className="v-teal">1000</span></p>
                                                    <div className="status-label">Status: <span className="v-bold">Ready for Pickup</span></div>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            )}
                        </div>
                    </>
                ) : (
                    // Show Detail Screen if a specific item was clicked
                    renderBidDetail()
                )}
            </main>

            {/* ------------------------------------------- */}
            {/* INLINE CSS ONLY FOR THIS PAGE */}
            {/* ------------------------------------------- */}
            <style dangerouslySetInnerHTML={{
                __html: `
                .animate-fade-in { animation: fadeIn 0.4s ease-out; }
                @keyframes fadeIn { from { opacity: 0; transform: translateY(10px); } to { opacity: 1; transform: translateY(0); } }

                .auction-tabs {
                    display: flex;
                    gap: 1rem;
                    margin-bottom: 2rem;
                    background: #f1f5f9;
                    padding: 0.5rem;
                    border-radius: 14px;
                    width: fit-content;
                }
                .tab-btn {
                    display: flex;
                    align-items: center;
                    gap: 0.5rem;
                    padding: 0.6rem 1.2rem;
                    border-radius: 10px;
                    border: none;
                    background: transparent;
                    color: #64748b;
                    font-weight: 600;
                    cursor: pointer;
                    transition: all 0.2s;
                }
                .tab-btn.active {
                    background: #2dd4bf;
                    color: white;
                    box-shadow: 0 4px 6px -1px rgba(45, 212, 191, 0.2);
                }
                
                .section-title-sm {
                    font-size: 1.25rem;
                    font-weight: 700;
                    color: #2d3748;
                    margin-bottom: 1.25rem;
                }
                
                .auction-card {
                    background: white;
                    border-radius: 20px;
                    overflow: hidden;
                    display: flex;
                    align-items: center;
                    margin-bottom: 1.5rem;
                    border: 1px solid #e2e8f0;
                    box-shadow: 0 4px 6px -1px rgba(0, 0, 0, 0.05);
                    transition: all 0.2s;
                }
                .auction-card:hover {
                    transform: translateY(-4px);
                    box-shadow: 0 10px 15px -3px rgba(0, 0, 0, 0.1);
                    border-color: #2dd4bf;
                }
                .card-image-box {
                    width: 140px;
                    height: 140px;
                    position: relative;
                }
                .card-image-box img {
                    width: 100%;
                    height: 100%;
                    object-fit: cover;
                }
                .holding-tag {
                    position: absolute;
                    top: 10px;
                    right: -10px;
                    background: #2dd4bf;
                    color: white;
                    padding: 2px 10px;
                    font-size: 0.7rem;
                    font-weight: 800;
                    border-radius: 4px;
                    transform: rotate(5deg);
                }
                .card-content {
                    flex: 1;
                    padding: 1.25rem 1.5rem;
                    display: flex;
                    align-items: center;
                    justify-content: space-between;
                }
                .item-info h3 { margin: 0 0 0.5rem 0; font-size: 1.1rem; color: #2d3748; }
                .bid-info .label { color: #718096; font-size: 0.85rem; margin-right: 0.5rem; }
                .bid-info .value { color: #0d9488; font-weight: 700; font-size: 1rem; }
                .time-info { display: flex; align-items: center; gap: 0.4rem; color: #94a3b8; font-size: 0.8rem; }
                .icon-teal { color: #2dd4bf; }
                
                .bid-btn {
                    background: #2dd4bf;
                    color: white;
                    padding: 0.75rem 1.5rem;
                    border-radius: 12px;
                    font-weight: 700;
                    border: none;
                    cursor: pointer;
                    transition: all 0.2s;
                }
                .bid-btn:hover { background: #14b8a6; box-shadow: 0 4px 12px rgba(45, 212, 191, 0.3); }
                
                /* Detail View Styling */
                .bid-detail-view { padding: 1rem; }
                .detail-header {
                    display: flex;
                    align-items: center;
                    gap: 1.5rem;
                    margin-bottom: 2rem;
                }
                .back-circle-btn {
                    width: 44px;
                    height: 44px;
                    border-radius: 50%;
                    background: white;
                    border: 1px solid #e2e8f0;
                    display: flex;
                    align-items: center;
                    justify-content: center;
                    color: #64748b;
                    cursor: pointer;
                    transition: all 0.2s;
                }
                .back-circle-btn:hover { background: #f8fafc; color: #2dd4bf; transform: scale(1.1); }
                .detail-title { margin: 0; font-size: 1.5rem; color: #1e293b; font-weight: 800; }
                .detail-time { margin: 4px 0 0 0; color: #64748b; font-size: 0.95rem; }
                .detail-time .highlight { color: #2dd4bf; font-weight: 700; }

                .detail-layout {
                    max-width: 600px;
                    margin: 0 auto;
                }
                
                .summary-card-teal {
                    background: linear-gradient(135deg, #f0fdfa 0%, #e0f2f1 100%);
                    border: 1px solid #ccfbf1;
                    border-radius: 24px;
                    padding: 2.5rem;
                    display: flex;
                    align-items: center;
                    gap: 2.5rem;
                    margin-bottom: 2rem;
                    position: relative;
                    overflow: hidden;
                    box-shadow: 0 10px 25px -5px rgba(45, 212, 191, 0.1);
                }
                .image-frame {
                    width: 200px;
                    height: 240px;
                    border-radius: 20px;
                    overflow: hidden;
                    background: white;
                    box-shadow: 0 8px 16px rgba(0,0,0,0.06);
                    border: 1px solid white;
                }
                .image-frame img { width: 100%; height: 100%; object-fit: cover; }
                
                .status-overlay { flex: 1; }
                .label-xs { font-size: 0.85rem; font-weight: 700; color: #0f766e; text-transform: uppercase; letter-spacing: 0.5px; opacity: 0.8; }
                .highest-value { margin: 0.5rem 0; font-size: 3rem; font-weight: 900; color: #134e4a; line-height: 1; }
                .highest-value::before { content: 'PKR '; font-size: 1.25rem; vertical-align: middle; margin-right: 4px; opacity: 0.6; }
                
                .badge-winning {
                    display: inline-flex;
                    align-items: center;
                    gap: 0.5rem;
                    background: #dcfce7;
                    color: #166534;
                    padding: 0.5rem 1rem;
                    border-radius: 100px;
                    font-size: 0.85rem;
                    font-weight: 700;
                    margin: 1rem 0;
                }
                .bid-count { margin: 0; font-size: 0.95rem; color: #0d9488; font-weight: 600; }

                .bid-tool-card {
                    background: white;
                    border-radius: 24px;
                    padding: 2rem;
                    border: 1px solid #e2e8f0;
                }
                .sub-title-teal { color: #2d3748; font-size: 1.25rem; font-weight: 700; margin: 0 0 1.5rem 0; }
                
                .bid-input-wrapper {
                    position: relative;
                    margin-bottom: 1rem;
                }
                .currency-sim {
                    position: absolute;
                    left: 1rem;
                    top: 50%;
                    transform: translateY(-50%);
                    font-size: 1.25rem;
                    font-weight: 700;
                    color: #0d9488;
                }
                .premium-input {
                    width: 100%;
                    padding: 1.25rem 1.25rem 1.25rem 3.5rem;
                    border-radius: 16px;
                    border: 2px solid #f1f5f9;
                    background: #f8fafc;
                    font-size: 1.1rem;
                    font-weight: 700;
                    transition: border-color 0.2s;
                }
                .premium-input:focus { outline: none; border-color: #2dd4bf; }
                
                .place-bid-btn-wide {
                    width: 100%;
                    padding: 1.25rem;
                    border-radius: 16px;
                    background: #2dd4bf;
                    color: white;
                    font-weight: 800;
                    font-size: 1.1rem;
                    border: none;
                    cursor: pointer;
                    transition: all 0.2s;
                }
                .place-bid-btn-wide:hover { background: #14b8a6; transform: translateY(-2px); box-shadow: 0 10px 20px -5px rgba(45, 212, 191, 0.4); }

                /* History Styling */
                .history-list { margin-top: 1rem; }
                .history-item {
                    display: flex;
                    align-items: center;
                    justify-content: space-between;
                    padding: 0.75rem 1rem;
                    border-radius: 12px;
                    margin-bottom: 0.5rem;
                }
                .history-item.active { background: #f0fdf4; color: #166534; border: 1px solid #bbf7d0; }
                .bidder-info { display: flex; align-items: center; gap: 0.75rem; }
                .bidder-avatar { width: 32px; height: 32px; border-radius: 50%; overflow: hidden; background: #e2e8f0; }
                .bidder-avatar img { width: 100%; height: 100%; object-fit: cover; }
                .bidder-name { font-weight: 600; font-size: 0.95rem; }
                .bid-amount-text { font-weight: 800; font-size: 1rem; }
                .history-title { font-size: 0.9rem; font-weight: 700; color: #64748b; margin-bottom: 1rem; }

                /* Tracking Styles Update */
                .tracking-main-title { font-size: 1.5rem; font-weight: 800; color: #0f172a; margin-bottom: 0.25rem; }
                .tracking-sub-title { font-size: 0.95rem; color: #64748b; margin-bottom: 2rem; }

                .active-bids-list, .won-auctions-list { display: flex; flex-direction: column; gap: 1.25rem; }
                
                .bids-tracking-container { display: flex; justify-content: flex-start; }
                .bids-tracking { width: 100%; max-width: 800px; }
                
                .tracking-card-detailed {
                    background: white;
                    border-radius: 20px;
                    padding: 1.25rem;
                    border: 1px solid #e2e8f0;
                    display: flex;
                    gap: 1.25rem;
                    box-shadow: 0 4px 6px -1px rgba(0,0,0,0.05);
                }
                .tracking-card-detailed.column { flex-direction: column; gap: 1rem; }
                .tracking-card-top-row { display: flex; gap: 1.25rem; align-items: flex-start; }
                
                .tracking-img-box {
                    width: 70px;
                    height: 70px;
                    border-radius: 12px;
                    overflow: hidden;
                    background: #f8fafc;
                }
                .tracking-img-box img { width: 100%; height: 100%; object-fit: cover; }
                .bg-white-frame { background: white; border: 1px solid #e2e8f0; padding: 4px; }
                
                .tracking-body h4 { margin: 0 0 0.5rem 0; color: #1e293b; font-size: 1rem; }
                .tracking-stats p, .bid-val-only { margin: 0; font-size: 0.9rem; color: #64748b; }
                .tracking-stats .v, .bid-val-only .v { color: #1e293b; font-weight: 700; margin-left: 4px; }
                
                .status-blue-text { color: #3b82f6; font-size: 0.85rem; font-weight: 600; margin-top: 0.5rem; }
                
                .card-footer-flex {
                    display: flex;
                    justify-content: space-between;
                    align-items: center;
                    margin-top: 0.5rem;
                    padding-top: 1rem;
                    border-top: 1px solid #f1f5f9;
                }
                .time-left-badge { color: #64748b; font-size: 0.85rem; font-weight: 500; }
                .increase-bid-btn {
                    background: #2dd4bf;
                    color: white;
                    border: none;
                    padding: 0.6rem 1.2rem;
                    border-radius: 8px;
                    font-weight: 700;
                    cursor: pointer;
                    transition: all 0.2s;
                }
                .increase-bid-btn:hover { background: #14b8a6; box-shadow: 0 4px 10px rgba(45, 212, 191, 0.3); }
                
                .v-teal { color: #2dd4bf; font-weight: 800; margin-left: 4px; }
                .status-label { font-size: 0.9rem; color: #64748b; margin-top: 0.4rem; }
                .v-bold { color: #1e293b; font-weight: 700; }

                .mt-10 { margin-top: 2.5rem; }
                .mt-8 { margin-top: 2rem; }
                .mt-6 { margin-top: 1.5rem; }
                `
            }} />
        </div>
    );
};

export default Auction;
