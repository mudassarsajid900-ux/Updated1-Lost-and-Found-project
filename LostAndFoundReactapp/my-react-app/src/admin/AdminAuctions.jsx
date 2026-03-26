import React, { useState, useEffect } from 'react';
import { 
    Gavel, Box, Calendar, MapPin, 
    ChevronRight, PlusCircle, AlertCircle,
    CheckCircle2, TrendingUp, Info, Award
} from 'lucide-react';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';
import { useNavigate } from 'react-router-dom';
import api from '../api/axios';

const AdminAuctions = () => {
    const navigate = useNavigate();
    const [unclaimedItems, setUnclaimedItems] = useState([]);
    const [activeAuctions, setActiveAuctions] = useState([]);
    const [completedAuctions, setCompletedAuctions] = useState([]);
    const [loading, setLoading] = useState(true);
    const [processingId, setProcessingId] = useState(null);
    const [startingAuctionItem, setStartingAuctionItem] = useState(null);
    const [startingPrice, setStartingPrice] = useState('500');
    const [durationHours, setDurationHours] = useState('24');

    const fetchData = async () => {
        setLoading(true);
        try {
            // Unclaimed Found items (Status 1 and no potential match)
            const allItemsRes = await api.get('Item/all');
            const foundItems = (allItemsRes.data.data || []).filter(i => 
                (i.status === 1 || i.Status === 1) && 
                !(i.hasPotentialMatch || i.HasPotentialMatch)
            );
            setUnclaimedItems(foundItems);

            // Active auctions
            const auctionsRes = await api.get('Auction/active');
            setActiveAuctions(auctionsRes.data.data || []);

            // Completed auctions
            const completedRes = await api.get('Auction/completed');
            setCompletedAuctions(completedRes.data.data || []);
        } catch (err) {
            console.error("Failed to fetch auction data", err);
        } finally {
            setLoading(false);
        }
    };

    useEffect(() => {
        fetchData();
    }, []);

    const handleOpenStartAuctionModal = (item) => {
        setStartingAuctionItem(item);
        setStartingPrice('500'); 
        setDurationHours('24');
    };

    const handleConfirmStartAuction = async (e) => {
        e.preventDefault();
        if (!startingAuctionItem || !startingPrice) return;
        
        setProcessingId(`start-${startingAuctionItem.id}`);
        try {
            await api.post('Auction/create', { 
                foundItemId: startingAuctionItem.id,
                startingPrice: parseInt(startingPrice),
                durationHours: parseInt(durationHours)
            });
            alert("Auction started successfully!");
            setStartingAuctionItem(null);
            fetchData();
        } catch (err) {
            alert("Failed to start auction. Ensure this item is eligible.");
        } finally {
            setProcessingId(null);
        }
    };

    const handleEndAuction = async (auctionId) => {
        if (!window.confirm("Are you sure you want to END this auction NOW? The highest bidder will win the item. This cannot be undone.")) return;
        
        setProcessingId(`end-${auctionId}`);
        try {
            await api.post(`Auction/${auctionId}/end`);
            alert("Auction ended successfully! Highest bidder secured.");
            fetchData();
        } catch (err) {
            alert("Failed to end auction.");
        } finally {
            setProcessingId(null);
        }
    };

    return (
        <div className="dashboard-container">
            <Sidebar isAdmin={true} />

            <main className="main-content premium-bg" style={{ background: '#f8fafc', padding: '2.5rem' }}>
                <Header 
                    title="Auction Management" 
                    subtitle="Monitor active bidding or convert unclaimed inventory into public auctions."
                />

                {/* MODAL: START AUCTION W/ PRICING */}
                {startingAuctionItem && (
                    <div style={{ position: 'fixed', inset: 0, background: 'rgba(15, 23, 42, 0.8)', backdropFilter: 'blur(8px)', zIndex: 1000, display: 'flex', alignItems: 'center', justifyContent: 'center', padding: '2rem' }}>
                        <div style={{ background: '#fff', borderRadius: '32px', width: '100%', maxWidth: '500px', overflow: 'hidden', boxShadow: '0 25px 50px -12px rgba(0,0,0,0.5)' }}>
                            <div style={{ background: '#0ea5e9', color: '#fff', padding: '2rem', display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
                                <div>
                                    <h2 style={{ margin: 0, fontSize: '1.5rem', fontWeight: '900' }}>Starting Price</h2>
                                    <p style={{ margin: '4px 0 0 0', opacity: 0.8, fontSize: '0.85rem' }}>Set base value for {startingAuctionItem.type}.</p>
                                </div>
                                <button onClick={() => setStartingAuctionItem(null)} style={{ background: 'rgba(255,255,255,0.2)', border: 'none', color: '#fff', width: '40px', height: '40px', borderRadius: '50%', cursor: 'pointer', fontSize: '1.2rem', fontWeight: 'bold' }}>✕</button>
                            </div>
                            <form onSubmit={handleConfirmStartAuction} style={{ padding: '2.5rem' }}>
                                <div style={{ marginBottom: '1.5rem' }}>
                                    <label style={{ display: 'block', textTransform: 'uppercase', fontSize: '0.75rem', fontWeight: '800', color: '#64748b', marginBottom: '8px' }}>Base Starting Price (Rs)</label>
                                    <input 
                                        type="number"
                                        min="0"
                                        required
                                        value={startingPrice}
                                        onChange={(e) => setStartingPrice(e.target.value)}
                                        style={{ width: '100%', padding: '1rem', borderRadius: '16px', border: '1px solid #e2e8f0', fontSize: '1.5rem', fontWeight: '800', outline: 'none', color: '#0f172a' }}
                                    />
                                    <p style={{ margin: '8px 0 0 0', fontSize: '0.75rem', color: '#94a3b8' }}>Bidders won't be able to bid lower than this amount.</p>
                                </div>

                                <div style={{ marginBottom: '2.5rem' }}>
                                    <label style={{ display: 'block', textTransform: 'uppercase', fontSize: '0.75rem', fontWeight: '800', color: '#64748b', marginBottom: '8px' }}>Auction Duration (Hours)</label>
                                    <select 
                                        value={durationHours}
                                        onChange={(e) => setDurationHours(e.target.value)}
                                        style={{ width: '100%', padding: '1rem', borderRadius: '16px', border: '1px solid #e2e8f0', fontSize: '1.1rem', fontWeight: '700', outline: 'none', color: '#0f172a', background: 'white' }}
                                    >
                                        <option value="1">1 Hour (Flash Auction)</option>
                                        <option value="6">6 Hours</option>
                                        <option value="12">12 Hours</option>
                                        <option value="24">24 Hours (Standard)</option>
                                        <option value="48">48 Hours</option>
                                        <option value="72">72 Hours (3 Days)</option>
                                        <option value="168">168 Hours (1 Week)</option>
                                    </select>
                                    <p style={{ margin: '8px 0 0 0', fontSize: '0.75rem', color: '#94a3b8' }}>Auction will close automatically via background service.</p>
                                </div>

                                <button 
                                    type="submit"
                                    disabled={processingId === `start-${startingAuctionItem.id}`}
                                    style={{ width: '100%', padding: '1.25rem', borderRadius: '16px', border: 'none', background: '#0ea5e9', color: '#fff', fontWeight: '800', fontSize: '1.1rem', cursor: 'pointer', display: 'flex', alignItems: 'center', justifyContent: 'center', gap: '8px' }}
                                >
                                    {processingId === `start-${startingAuctionItem.id}` ? 'Launching...' : <><TrendingUp size={20}/> Launch Auction</>}
                                </button>
                            </form>
                        </div>
                    </div>
                )}

                <div className="auction-manager-content" style={{ marginTop: '2rem' }}>
                    
                    {/* TOP STATS */}
                    <div style={{ display: 'grid', gridTemplateColumns: 'repeat(auto-fit, minmax(200px, 1fr))', gap: '1.5rem', marginBottom: '3rem' }}>
                        <div className="stat-card" style={{ background: '#fff', padding: '1.5rem', borderRadius: '20px', border: '1px solid #e2e8f0', boxShadow: '0 4px 6px rgba(0,0,0,0.02)' }}>
                            <div style={{ color: '#64748b', fontSize: '0.85rem', fontWeight: '700', marginBottom: '0.5rem' }}>ACTIVE AUCTIONS</div>
                            <div style={{ fontSize: '2rem', fontWeight: '800', color: '#f43f5e' }}>{activeAuctions.length}</div>
                        </div>
                        <div className="stat-card" style={{ background: '#fff', padding: '1.5rem', borderRadius: '20px', border: '1px solid #e2e8f0', boxShadow: '0 4px 6px rgba(0,0,0,0.02)' }}>
                            <div style={{ color: '#64748b', fontSize: '0.85rem', fontWeight: '700', marginBottom: '0.5rem' }}>INVENTORY READY</div>
                            <div style={{ fontSize: '2rem', fontWeight: '800', color: '#0ea5e9' }}>{unclaimedItems.length}</div>
                        </div>
                    </div>

                    <div style={{ display: 'grid', gridTemplateColumns: '1.5fr 1fr', gap: '2.5rem' }}>
                        
                        {/* LEFT COLUMN: UNCLAIMED INVENTORY */}
                        <section>
                            <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center', marginBottom: '1.5rem' }}>
                                <h3 style={{ margin: 0, fontSize: '1.3rem', fontWeight: '800', color: '#1e293b' }}>Eligible Inventory</h3>
                                <span style={{ background: '#e0f2fe', color: '#0369a1', padding: '4px 12px', borderRadius: '10px', fontSize: '0.75rem', fontWeight: '800' }}>
                                    FOUND & UNCLAIMED
                                </span>
                            </div>

                            {loading ? (
                                <p>Loading inventory...</p>
                            ) : unclaimedItems.length === 0 ? (
                                <div style={{ background: '#fff', padding: '3rem', borderRadius: '24px', textAlign: 'center', border: '2px dashed #e2e8f0' }}>
                                    <Box size={40} color="#cbd5e0" style={{ marginBottom: '1rem' }} />
                                    <h4 style={{ margin: 0, color: '#475569' }}>No items ready for auction</h4>
                                    <p style={{ color: '#94a3b8', fontSize: '0.9rem' }}>All found items are either claimed or already in auction.</p>
                                </div>
                            ) : (
                                <div style={{ display: 'flex', flexDirection: 'column', gap: '1rem' }}>
                                    {unclaimedItems.map((item) => (
                                        <div key={item.id} className="inventory-card" style={{ 
                                            background: '#fff', 
                                            borderRadius: '20px', 
                                            padding: '1.25rem', 
                                            border: '1px solid #e2e8f0',
                                            display: 'flex',
                                            alignItems: 'center',
                                            gap: '1.25rem'
                                        }}>
                                            <div style={{ width: '60px', height: '60px', borderRadius: '12px', background: '#f8fafc', display: 'flex', alignItems: 'center', justifyContent: 'center' }}>
                                                <Box size={24} color="#94a3b8" />
                                            </div>
                                            <div style={{ flex: 1 }}>
                                                <h4 style={{ margin: 0, fontSize: '1.1rem', fontWeight: '800', color: '#1e293b' }}>{item.type}</h4>
                                                <div style={{ display: 'flex', gap: '1rem', marginTop: '4px', fontSize: '0.85rem', color: '#64748b' }}>
                                                    <span style={{ display: 'flex', alignItems: 'center', gap: '4px' }}><MapPin size={14}/> {item.locationName}</span>
                                                    <span style={{ display: 'flex', alignItems: 'center', gap: '4px' }}><Calendar size={14}/> {new Date(item.eventTime).toLocaleDateString()}</span>
                                                </div>
                                            </div>
                                            <button 
                                                onClick={() => handleOpenStartAuctionModal(item)}
                                                disabled={processingId === `start-${item.id}`}
                                                style={{
                                                    background: '#0ea5e9',
                                                    color: 'white',
                                                    border: 'none',
                                                    padding: '0.75rem 1.5rem',
                                                    borderRadius: '12px',
                                                    fontWeight: '700',
                                                    fontSize: '0.85rem',
                                                    cursor: 'pointer',
                                                    display: 'flex',
                                                    alignItems: 'center',
                                                    gap: '8px',
                                                    transition: 'all 0.2s'
                                                }}
                                            >
                                                {processingId === `start-${item.id}` ? "Moving..." : <><TrendingUp size={16} /> Start Auction</>}
                                            </button>
                                        </div>
                                    ))}
                                </div>
                            )}
                        </section>

                        {/* RIGHT COLUMN: ACTIVE AUCTIONS MONITOR */}
                        <section>
                            <h3 style={{ marginBottom: '1.5rem', fontSize: '1.3rem', fontWeight: '800', color: '#1e293b' }}>Active Bidding</h3>
                            
                            <div style={{ background: '#fff', borderRadius: '24px', border: '1px solid #e2e8f0', padding: '1.5rem', boxShadow: '0 4px 6px rgba(0,0,0,0.02)' }}>
                                {activeAuctions.length === 0 ? (
                                    <p style={{ color: '#94a3b8', textAlign: 'center', margin: '2rem 0' }}>No active auctions at the moment.</p>
                                ) : (
                                    <div style={{ display: 'flex', flexDirection: 'column', gap: '1.5rem' }}>
                                        {activeAuctions.map((auction) => (
                                            <div key={auction.id} style={{ paddingBottom: '1.5rem', borderBottom: '1px solid #f1f5f9' }}>
                                                <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'flex-start' }}>
                                                    <div>
                                                        <h5 style={{ margin: 0, fontSize: '1rem', fontWeight: '800', color: '#0f172a' }}>{auction.itemTitle}</h5>
                                                        <span style={{ fontSize: '0.8rem', color: '#64748b' }}>Auction ID: #{auction.id}</span>
                                                    </div>
                                                    <div style={{ textAlign: 'right' }}>
                                                        <div style={{ fontSize: '1.1rem', fontWeight: '800', color: '#10b981' }}>Rs. {auction.highestBid.toLocaleString()}</div>
                                                        <span style={{ fontSize: '0.7rem', color: '#94a3b8', fontWeight: '700' }}>CURRENT HIGH</span>
                                                    </div>
                                                </div>
                                                <div style={{ display: 'flex', gap: '8px', marginTop: '1rem' }}>
                                                    <button 
                                                        onClick={() => navigate('/auction')}
                                                        style={{ 
                                                            flex: 1, padding: '0.6rem', borderRadius: '10px', 
                                                            background: '#f8fafc', border: '1px solid #e2e8f0', color: '#475569', 
                                                            fontSize: '0.8rem', fontWeight: '700', cursor: 'pointer' 
                                                        }}
                                                    >
                                                        View Public Listing
                                                    </button>
                                                    <button 
                                                        disabled={processingId === `end-${auction.id}`}
                                                        onClick={() => handleEndAuction(auction.id)}
                                                        style={{ 
                                                            flex: 1, padding: '0.6rem', borderRadius: '10px', 
                                                            background: '#fef2f2', border: '1px solid #fee2e2', color: '#ef4444', 
                                                            fontSize: '0.8rem', fontWeight: '800', cursor: 'pointer',
                                                            opacity: processingId === `end-${auction.id}` ? 0.5 : 1
                                                        }}
                                                    >
                                                        {processingId === `end-${auction.id}` ? "Closing..." : "Stop & Close Bidding"}
                                                    </button>
                                                </div>
                                            </div>
                                        ))}
                                    </div>
                                )}
                            </div>

                            {/* COMPLETED AUCTIONS SECTION */}
                            <div style={{ marginTop: '4rem' }}>
                                <div style={{ display: 'flex', alignItems: 'center', gap: '12px', marginBottom: '1.5rem' }}>
                                    <div style={{ background: '#f0fdf4', color: '#15803d', padding: '10px', borderRadius: '12px' }}><Award size={24} /></div>
                                    <div>
                                        <h2 style={{ margin: 0, fontSize: '1.5rem', fontWeight: '900', color: '#1e293b' }}>Recently Completed Auctions</h2>
                                        <p style={{ margin: 0, color: '#64748b', fontSize: '0.9rem' }}>Review winners and final sale prices</p>
                                    </div>
                                </div>

                                <div style={{ background: '#fff', borderRadius: '24px', border: '1px solid #e2e8f0', overflow: 'hidden' }}>
                                    <table style={{ width: '100%', borderCollapse: 'collapse', textAlign: 'left' }}>
                                        <thead style={{ background: '#f8fafc', borderBottom: '1px solid #e2e8f0' }}>
                                            <tr>
                                                <th style={{ padding: '1.25rem 1.5rem', fontSize: '0.75rem', textTransform: 'uppercase', color: '#64748b', fontWeight: '800' }}>Item Name</th>
                                                <th style={{ padding: '1.25rem 1.5rem', fontSize: '0.75rem', textTransform: 'uppercase', color: '#64748b', fontWeight: '800' }}>Highest Bidder (Winner)</th>
                                                <th style={{ padding: '1.25rem 1.5rem', fontSize: '0.75rem', textTransform: 'uppercase', color: '#64748b', fontWeight: '800' }}>Final Price</th>
                                                <th style={{ padding: '1.25rem 1.5rem', fontSize: '0.75rem', textTransform: 'uppercase', color: '#64748b', fontWeight: '800' }}>Closed Date</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                            {completedAuctions.length > 0 ? completedAuctions.map(auc => (
                                                <tr key={auc.id} style={{ borderBottom: '1px solid #f1f5f9' }}>
                                                    <td style={{ padding: '1.25rem 1.5rem' }}>
                                                        <div style={{ display: 'flex', alignItems: 'center', gap: '12px' }}>
                                                            {auc.itemImageUrl && <img src={`${API_BASE_URL}/${auc.itemImageUrl}`} style={{ width: '40px', height: '40px', borderRadius: '8px', objectFit: 'cover' }} alt="" />}
                                                            <span style={{ fontWeight: '700', color: '#1e293b' }}>{auc.itemTitle}</span>
                                                        </div>
                                                    </td>
                                                    <td style={{ padding: '1.25rem 1.5rem' }}>
                                                        <div style={{ display: 'flex', alignItems: 'center', gap: '8px' }}>
                                                            <div style={{ background: '#f0fdf4', color: '#15803d', padding: '6px 14px', borderRadius: '20px', fontSize: '0.85rem', fontWeight: '800', border: '1px solid #dcfce7' }}>
                                                                <Award size={14} style={{ marginRight: '4px' }} /> {auc.highestBidderName}
                                                            </div>
                                                        </div>
                                                    </td>
                                                    <td style={{ padding: '1.25rem 1.5rem' }}>
                                                        <span style={{ fontWeight: '900', color: '#0f172a', fontSize: '1.1rem' }}>Rs. {auc.highestBid?.toLocaleString()}</span>
                                                    </td>
                                                    <td style={{ padding: '1.25rem 1.5rem', color: '#64748b', fontSize: '0.9rem' }}>
                                                        <div style={{ display: 'flex', alignItems: 'center', justifyContent: 'space-between', gap: '1rem' }}>
                                                            <span>{new Date(auc.endDate).toLocaleDateString(undefined, { month: 'short', day: 'numeric', year: 'numeric' })}</span>
                                                            <button 
                                                                onClick={() => navigate('/admin-handover')}
                                                                style={{ 
                                                                    padding: '8px 14px', background: '#dd6b20', color: '#fff', border: 'none', borderRadius: '10px', 
                                                                    cursor: 'pointer', fontWeight: '800', fontSize: '0.75rem', display: 'flex', alignItems: 'center', gap: '6px',
                                                                    boxShadow: '0 4px 10px -2px rgba(221, 107, 32, 0.4)'
                                                                }}
                                                            >
                                                                <ShieldCheck size={14} /> Process Release
                                                            </button>
                                                        </div>
                                                    </td>
                                                </tr>
                                            )) : (
                                                <tr>
                                                    <td colSpan="4" style={{ padding: '4rem', textAlign: 'center' }}>
                                                        <p style={{ margin: 0, color: '#94a3b8', fontSize: '0.9rem' }}>No recently completed auctions to display.</p>
                                                    </td>
                                                </tr>
                                            )}
                                        </tbody>
                                    </table>
                                </div>
                            </div>

                            <div style={{ marginTop: '2rem', padding: '1.5rem', background: '#eff6ff', borderRadius: '20px', border: '1px solid #bfdbfe' }}>
                                <div style={{ display: 'flex', gap: '12px' }}>
                                    <Info color="#3b82f6" size={20} />
                                    <div>
                                        <h5 style={{ margin: 0, color: '#1e40af', fontWeight: '800' }}>Admin Note</h5>
                                        <p style={{ margin: '4px 0 0 0', fontSize: '0.85rem', color: '#3b82f6', lineHeight: '1.4' }}>
                                            Items moved to auction are visible to all students. The highest bidder collects the item after physically paying.
                                        </p>
                                    </div>
                                </div>
                            </div>
                        </section>
                    </div>
                </div>
            </main>
        </div>
    );
};

export default AdminAuctions;
