import React, { useState, useEffect } from 'react';
import {
    CheckCircle, Info, RefreshCw, Package, ArrowRight, 
    Smartphone, Wallet, Laptop, Briefcase, User
} from 'lucide-react';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';
import api from '../api/axios';
import { useNavigate } from 'react-router-dom';

const AdminReplacements = () => {
    const navigate = useNavigate();
    const [requests, setRequests] = useState([]);
    const [poolItems, setPoolItems] = useState([]);
    const [loading, setLoading] = useState(true);
    const [activeTab, setActiveTab] = useState('requests'); // 'requests' or 'pool'
    const [selectedRequest, setSelectedRequest] = useState(null);
    const [suggestions, setSuggestions] = useState([]);
    const [adminNotes, setAdminNotes] = useState('');
    const [processing, setProcessing] = useState(false);
    const [searchTerm, setSearchTerm] = useState('');
    const [thresholds, setThresholds] = useState({
        ReplacementEligibilityThreshold: 90,
        FoundToReplacementThreshold: 20,
        ReplacementToAuctionThreshold: 40
    });

    useEffect(() => {
        if (selectedRequest) {
            fetchSuggestions(selectedRequest.id);
        }
    }, [selectedRequest]);

    const fetchSuggestions = async (id) => {
        try {
            const res = await api.get(`Replacement/admin/suggestions/${id}`);
            // Map suggestion IDs to actual pool items
            const matches = poolItems.filter(p => res.data.data.includes(p.id));
            setSuggestions(matches);
        } catch (error) {
            console.error("Error fetching suggestions:", error);
        }
    };
    const [pendingHandovers, setPendingHandovers] = useState([]);

    useEffect(() => {
        fetchData();
    }, []);

    const fetchData = async () => {
        setLoading(true);
        try {
            const [reqRes, poolRes, settingsRes, handoverRes] = await Promise.all([
                api.get('Replacement/admin/all-pending'),
                api.get('Replacement/admin/pool'),
                api.get('Replacement/admin/settings/thresholds'),
                api.get('Handover/pending')
            ]);
            setRequests(reqRes.data.data || []);
            setPoolItems(poolRes.data.data || []);
            if (settingsRes.data.data) {
                const raw = settingsRes.data.data;
                const normalized = {
                    ReplacementEligibilityThreshold: raw.replacementEligibilityThreshold ?? raw.ReplacementEligibilityThreshold ?? 90,
                    FoundToReplacementThreshold: raw.foundToReplacementThreshold ?? raw.FoundToReplacementThreshold ?? 20,
                    ReplacementToAuctionThreshold: raw.replacementToAuctionThreshold ?? raw.ReplacementToAuctionThreshold ?? 40,
                };
                setThresholds(normalized);
            }
            setPendingHandovers(handoverRes.data.data || []);
        } catch (error) {
            console.error("Error fetching data:", error);
        } finally {
            setLoading(false);
        }
    };

    const handleProcess = async (isApproved, itemId = null) => {
        if (isApproved && !itemId) {
            alert("Please select a replacement item first.");
            return;
        }

        setProcessing(true);
        try {
            await api.post('Replacement/admin/process', {
                requestId: selectedRequest.id,
                foundItemId: itemId,
                adminNotes: adminNotes,
                isApproved: isApproved
            });
            await fetchData();
            setSelectedRequest(null);
            setAdminNotes('');
            alert("Match finalized! It's now ready in the Handover module.");
            if (isApproved && window.confirm("Go to Handover for Physical Pickup?")) {
                navigate('/admin-handover');
            }
        } catch (error) {
            alert("Error processing request.");
        } finally {
            setProcessing(false);
        }
    };

    const getIcon = (title) => {
        const lower = (title || "").toLowerCase();
        if (lower.includes('phone')) return <Smartphone size={18} />;
        if (lower.includes('wallet')) return <Wallet size={18} />;
        if (lower.includes('laptop')) return <Laptop size={18} />;
        if (lower.includes('backpack')) return <Briefcase size={18} />;
        return <Package size={18} />;
    };

    const filteredPool = poolItems.filter(i => 
        i.title.toLowerCase().includes(searchTerm.toLowerCase())
    );

    return (
        <div className="dashboard-container">
            <Sidebar isAdmin={true} />
            <main className="main-content" style={{ padding: '2.5rem', background: '#f8fafc', minHeight: '100vh' }}>
                
                <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center', marginBottom: '2.5rem' }}>
                    <Header 
                        title="Master Replacement Module" 
                        subtitle="Administer the unclaimed asset pool and student applications." 
                    />
                </div>

                {/* PRO METRIC CARDS */}
                <div style={{ display: 'grid', gridTemplateColumns: 'repeat(4, 1fr)', gap: '1.5rem', marginBottom: '2.5rem' }}>
                    <div style={{ background: '#fff', padding: '1.5rem', borderRadius: '24px', border: '1px solid #e2e8f0' }}>
                        <div style={{ color: '#64748b', fontSize: '0.8rem', fontWeight: '800', marginBottom: '12px' }}>POOL SIZE</div>
                        <div style={{ display: 'flex', alignItems: 'center', gap: '15px' }}>
                            <div style={{ background: '#f0fdf4', color: '#10b981', padding: '12px', borderRadius: '14px' }}><Package size={24} /></div>
                            <div style={{ fontSize: '1.8rem', fontWeight: '900' }}>{poolItems.length}</div>
                        </div>
                    </div>
                    <div style={{ background: '#fff', padding: '1.5rem', borderRadius: '24px', border: '1px solid #e2e8f0' }}>
                        <div style={{ color: '#64748b', fontSize: '0.8rem', fontWeight: '800', marginBottom: '12px' }}>STUDENT APPS</div>
                        <div style={{ display: 'flex', alignItems: 'center', gap: '15px' }}>
                            <div style={{ background: '#eff6ff', color: '#3b82f6', padding: '12px', borderRadius: '14px' }}><User size={24} /></div>
                            <div style={{ fontSize: '1.8rem', fontWeight: '900' }}>{requests.length}</div>
                        </div>
                    </div>
                    <div style={{ background: '#fff', padding: '1.5rem', borderRadius: '24px', border: '1px solid #e2e8f0' }}>
                        <div style={{ color: '#64748b', fontSize: '0.8rem', fontWeight: '800', marginBottom: '12px' }}>ELIGIBILITY</div>
                        <div style={{ display: 'flex', alignItems: 'center', gap: '15px' }}>
                            <div style={{ background: '#faf5ff', color: '#a855f7', padding: '12px', borderRadius: '14px' }}><RefreshCw size={24} /></div>
                            <div style={{ fontSize: '1.8rem', fontWeight: '900' }}>{thresholds.ReplacementEligibilityThreshold} <span style={{ fontSize: '0.9rem' }}>Days</span></div>
                        </div>
                    </div>
                    <div style={{ background: '#fff', padding: '1.5rem', borderRadius: '24px', border: '1px solid #e2e8f0' }}>
                        <div style={{ color: '#64748b', fontSize: '0.8rem', fontWeight: '800', marginBottom: '12px' }}>POOL CAPACITY</div>
                        <div style={{ marginTop: '5px' }}>
                            <div style={{ height: '8px', background: '#f1f5f9', borderRadius: '10px', overflow: 'hidden' }}>
                                <div style={{ width: '65%', height: '100%', background: 'linear-gradient(90deg, #3b82f6, #6366f1)' }}></div>
                            </div>
                            <p style={{ margin: '8px 0 0 0', fontSize: '0.75rem', fontWeight: '700', color: '#94a3b8' }}>OPTIMAL</p>
                        </div>
                    </div>
                </div>

                <div style={{ display: 'flex', gap: '8px', marginBottom: '2rem', background: '#f1f5f9', padding: '6px', borderRadius: '16px', width: 'fit-content' }}>
                    <button onClick={() => setActiveTab('requests')} style={{ padding: '0.75rem 1.5rem', borderRadius: '12px', border: 'none', background: activeTab === 'requests' ? '#fff' : 'transparent', fontWeight: '800', cursor: 'pointer' }}>Student Requests</button>
                    <button onClick={() => setActiveTab('pool')} style={{ padding: '0.75rem 1.5rem', borderRadius: '12px', border: 'none', background: activeTab === 'pool' ? '#fff' : 'transparent', fontWeight: '800', cursor: 'pointer' }}>Replacement Pool</button>
                </div>

                {loading ? (
                    <div style={{ textAlign: 'center', padding: '100px' }}><RefreshCw className="animate-spin" color="#3b82f6" /></div>
                ) : activeTab === 'requests' ? (
                    <div style={{ display: 'grid', gridTemplateColumns: selectedRequest ? '1fr 1fr' : '1fr', gap: '2rem' }}>
                        <div>
                            {requests.length > 0 ? requests.map(req => (
                                <div key={req.id} onClick={() => setSelectedRequest(req)} style={{ background: 'white', border: selectedRequest?.id === req.id ? '2px solid #3b82f6' : '1px solid #e2e8f0', padding: '1.5rem', borderRadius: '24px', cursor: 'pointer', marginBottom: '1rem' }}>
                                    <div style={{ display: 'flex', justifyContent: 'space-between' }}>
                                        <div style={{ display: 'flex', gap: '12px' }}>
                                            <div style={{ background: '#f8fafc', padding: '10px', borderRadius: '12px' }}>{getIcon(req.lostItemTitle)}</div>
                                            <div><h4 style={{ margin: 0 }}>{req.lostItemTitle}</h4><p style={{ margin: 0, fontSize: '0.8rem', color: '#94a3b8' }}>{req.reporterName}</p></div>
                                        </div>
                                        <ArrowRight size={18} />
                                    </div>
                                </div>
                            )) : <p>No pending applications.</p>}
                        </div>

                        {selectedRequest && (
                            <div style={{ background: 'white', borderRadius: '24px', border: '1px solid #e2e8f0', padding: '2rem', position: 'sticky', top: '2rem' }}>
                                <h3 style={{ margin: '0 0 1.5rem 0' }}>Process for {selectedRequest.reporterName}</h3>
                                <div style={{ background: '#f8fafc', padding: '1rem', borderRadius: '12px', marginBottom: '1.5rem', borderLeft: '4px solid #3b82f6' }}>
                                    <span style={{ fontSize: '0.7rem', fontWeight: '800', color: '#3b82f6' }}>USER REQUIREMENTS:</span>
                                    <p style={{ margin: '5px 0', fontSize: '0.9rem', color: '#4a5568' }}>"{selectedRequest.requestReason}"</p>
                                    <p style={{ margin: '5px 0', fontSize: '0.85rem', color: '#2d3748', fontWeight: '600' }}>Desired: {selectedRequest.desiredSpecifications}</p>
                                </div>
                                <div style={{ fontSize: '0.85rem', fontWeight: '800', marginBottom: '10px', display: 'flex', alignItems: 'center', gap: '5px' }}><CheckCircle size={16} color="#10b981" /> System Smart Suggestions:</div>
                                <div style={{ display: 'flex', flexDirection: 'column', gap: '0.75rem', marginBottom: '2rem' }}>
                                    {suggestions.length > 0 ? suggestions.map(p => (
                                        <div key={p.id} style={{ display: 'flex', justifyContent: 'space-between', padding: '12px', border: '1.5px solid #10b981', background: '#f0fdf4', borderRadius: '16px', boxShadow: '0 4px 6px -1px rgba(16, 185, 129, 0.1)' }}>
                                            <div style={{ display: 'flex', alignItems: 'center', gap: '10px' }}>
                                                {getIcon(p.title)}
                                                <div>
                                                    <div style={{ fontWeight: '800', fontSize: '0.9rem' }}>{p.title}</div>
                                                    <div style={{ fontSize: '0.75rem', color: '#64748b' }}>{p.location}</div>
                                                </div>
                                            </div>
                                            <button onClick={() => handleProcess(true, p.id)} style={{ background: '#10b981', color: '#fff', border: 'none', borderRadius: '8px', fontSize: '0.75rem', padding: '6px 14px', cursor: 'pointer', fontWeight: '800' }}>SELECT MATCH</button>
                                        </div>
                                    )) : (
                                        <div style={{ padding: '20px', textAlign: 'center', background: '#f8fafc', borderRadius: '16px', border: '1px dashed #cbd5e1' }}>
                                            <p style={{ fontSize: '0.8rem', color: '#64748b', margin: 0 }}>No direct smart matches found. Check the full pool.</p>
                                        </div>
                                    )}
                                </div>
                                <textarea placeholder="Final Admin Notes (Student will see this)..." value={adminNotes} onChange={(e) => setAdminNotes(e.target.value)} style={{ width: '100%', padding: '10px', borderRadius: '12px', border: '1px solid #e2e8f0', marginBottom: '1.5rem', height: '80px' }} />
                                <button onClick={() => handleProcess(false)} style={{ width: '100%', padding: '10px', background: '#fff5f5', color: '#ef4444', border: '1px solid #feb2b2', borderRadius: '12px', fontWeight: '800' }}>Reject Application</button>
                            </div>
                        )}
                    </div>
                ) : (
                    <div style={{ background: 'white', borderRadius: '20px', border: '1px solid #e2e8f0', overflow: 'hidden' }}>
                         <table style={{ width: '100%', borderCollapse: 'collapse' }}>
                            <thead style={{ background: '#f8fafc' }}>
                                <tr style={{ textAlign: 'left' }}>
                                    <th style={{ padding: '1rem' }}>ITEM</th>
                                    <th style={{ padding: '1rem' }}>FOUND DATE</th>
                                    <th style={{ padding: '1rem' }}>LOCATION</th>
                                    <th style={{ padding: '1rem' }}>POOL DAYS</th>
                                    <th style={{ padding: '1rem' }}>ACTIONS</th>
                                </tr>
                            </thead>
                            <tbody>
                                {filteredPool.map(item => (
                                    <tr key={item.id} style={{ borderBottom: '1px solid #f1f5f9' }}>
                                        <td style={{ padding: '1rem', fontWeight: '800' }}>{item.title}</td>
                                        <td style={{ padding: '1rem' }}>{new Date(item.foundDate).toLocaleDateString()}</td>
                                        <td style={{ padding: '1rem' }}>{item.location}</td>
                                        <td style={{ padding: '1rem' }}>
                                            <div style={{ display: 'flex', flexDirection: 'column', gap: '4px', width: '120px' }}>
                                                <div style={{ display: 'flex', justifyContent: 'space-between', fontSize: '0.7rem', fontWeight: '800', color: '#64748b' }}>
                                                    <span>{item.daysInPool} / {thresholds.ReplacementToAuctionThreshold} Days</span>
                                                </div>
                                                <div style={{ height: '6px', background: '#f1f5f9', borderRadius: '10px', overflow: 'hidden' }}>
                                                    <div style={{ 
                                                        width: `${Math.min((item.daysInPool / thresholds.ReplacementToAuctionThreshold) * 100, 100)}%`, 
                                                        height: '100%', 
                                                        background: (item.daysInPool / thresholds.ReplacementToAuctionThreshold) > 0.8 ? '#ef4444' : 
                                                                   (item.daysInPool / thresholds.ReplacementToAuctionThreshold) > 0.5 ? '#f59e0b' : '#10b981',
                                                        transition: 'width 0.5s ease-in-out'
                                                    }}></div>
                                                </div>
                                                <span style={{ fontSize: '0.65rem', color: (item.daysInPool / thresholds.ReplacementToAuctionThreshold) > 0.8 ? '#ef4444' : '#94a3b8', fontWeight: '700' }}>
                                                    {(item.daysInPool / thresholds.ReplacementToAuctionThreshold) > 0.8 ? 'ALMOST AUCTION!' : 'SAFE'}
                                                </span>
                                            </div>
                                        </td>
                                        <td style={{ padding: '1rem' }}>
                                            {pendingHandovers.some(h => h.itemId === item.id && h.handoverType === 2) ? (
                                                <button 
                                                    onClick={() => navigate('/admin-handover')}
                                                    style={{ 
                                                        padding: '6px 14px', background: '#805ad5', color: '#fff', border: 'none', borderRadius: '8px', 
                                                        cursor: 'pointer', fontWeight: '800', boxShadow: '0 4px 10px -2px rgba(128, 90, 213, 0.4)',
                                                        display: 'flex', alignItems: 'center', gap: '6px'
                                                    }}
                                                >
                                                    <Smartphone size={14} /> GO TO HANDOVER
                                                </button>
                                            ) : (
                                                <button 
                                                    onClick={() => { setActiveTab('requests'); alert("Now select the student application you want to link this item to."); }} 
                                                    style={{ padding: '6px 12px', background: '#3b82f6', color: '#fff', border: 'none', borderRadius: '8px', cursor: 'pointer', fontWeight: '700' }}
                                                >
                                                    Link to Application
                                                </button>
                                            )}
                                        </td>
                                    </tr>
                                ))}
                            </tbody>
                         </table>
                    </div>
                )}
                
                <style>{` .animate-spin { animation: spin 2s linear infinite; } @keyframes spin { from { transform: rotate(0deg); } to { transform: rotate(360deg); } } `}</style>
            </main>
        </div>
    );
};

export default AdminReplacements;
