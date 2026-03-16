import React, { useState, useEffect } from 'react';
import {
    CheckCircle, XCircle, Info, RefreshCw, Package, ArrowRight, 
    ShieldCheck, Smartphone, Wallet, Laptop, Briefcase, Watch, FileText, Gem, Headphones
} from 'lucide-react';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';
import api from '../api/axios';

const AdminReplacements = () => {
    const [requests, setRequests] = useState([]);
    const [loading, setLoading] = useState(true);
    const [selectedRequest, setSelectedRequest] = useState(null);
    const [suggestions, setSuggestions] = useState([]);
    const [adminNotes, setAdminNotes] = useState('');
    const [processing, setProcessing] = useState(false);

    useEffect(() => {
        fetchRequests();
    }, []);

    const fetchRequests = async () => {
        setLoading(true);
        try {
            const res = await api.get('Replacement/admin/all-pending');
            setRequests(res.data.data || []);
        } catch (error) {
            console.error("Error fetching admin requests:", error);
        } finally {
            setLoading(false);
        }
    };

    const handleSelectRequest = async (req) => {
        setSelectedRequest(req);
        try {
            const res = await api.get(`Replacement/admin/suggestions/${req.id}`);
            setSuggestions(res.data.data || []);
        } catch (error) {
            console.error("Error fetching suggestions:", error);
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
            await fetchRequests();
            setSelectedRequest(null);
            setAdminNotes('');
        } catch (error) {
            console.error("Error processing request:", error);
            alert("Failed to process request.");
        } finally {
            setProcessing(false);
        }
    };

    const getIcon = (title) => {
        const lower = title.toLowerCase();
        if (lower.includes('phone')) return <Smartphone size={24} />;
        if (lower.includes('wallet')) return <Wallet size={24} />;
        if (lower.includes('laptop')) return <Laptop size={24} />;
        return <Package size={24} />;
    };

    return (
        <div className="dashboard-container">
            <Sidebar isAdmin={true} />
            <main className="main-content" style={{ padding: '3rem', background: '#f8fafc' }}>
                <Header 
                    title="Manage Replacements" 
                    subtitle="Review user applications and assign unmatched inventory." 
                />

                {loading ? (
                    <div style={{ display: 'flex', justifyContent: 'center', padding: '100px' }}>
                        <RefreshCw className="animate-spin" size={40} color="#319795" />
                    </div>
                ) : (
                    <div style={{ display: 'grid', gridTemplateColumns: selectedRequest ? '1fr 1fr' : '1fr', gap: '2rem' }}>
                        {/* List of Pending Requests */}
                        <div style={{ display: 'flex', flexDirection: 'column', gap: '1.5rem' }}>
                            <h2 style={{ fontSize: '1.25rem', fontWeight: '800', marginBottom: '1rem' }}>Pending Applications</h2>
                            {requests.length > 0 ? requests.map(req => (
                                <div 
                                    key={req.id} 
                                    onClick={() => handleSelectRequest(req)}
                                    style={{
                                        backgroundColor: 'white', borderRadius: '20px', padding: '1.5rem',
                                        border: selectedRequest?.id === req.id ? '2px solid #319795' : '1px solid #e2e8f0',
                                        cursor: 'pointer', transition: 'all 0.2s',
                                        boxShadow: selectedRequest?.id === req.id ? '0 10px 20px rgba(49,151,149,0.1)' : 'none'
                                    }}
                                >
                                    <div style={{ display: 'flex', justifyContent: 'space-between', marginBottom: '1rem' }}>
                                        <div style={{ display: 'flex', gap: '1rem', alignItems: 'center' }}>
                                            <div style={{ width: '45px', height: '45px', borderRadius: '12px', background: '#f0fdfa', display: 'flex', alignItems: 'center', justifyContent: 'center', color: '#319795' }}>
                                                {getIcon(req.lostItemTitle)}
                                            </div>
                                            <div>
                                                <h4 style={{ margin: 0, fontWeight: '800' }}>{req.lostItemTitle}</h4>
                                                <p style={{ margin: 0, fontSize: '0.8rem', color: '#718096' }}>Request #{req.id}</p>
                                            </div>
                                        </div>
                                        <div style={{ background: '#ebf8ff', color: '#3182ce', padding: '4px 12px', borderRadius: '100px', fontSize: '0.75rem', fontWeight: '800' }}>
                                            {req.statusName}
                                        </div>
                                    </div>
                                    <p style={{ fontSize: '0.9rem', color: '#4a5568', fontStyle: 'italic', margin: 0 }}>"{req.requestReason}"</p>
                                </div>
                            )) : (
                                <div style={{ padding: '40px', background: 'white', borderRadius: '24px', textAlign: 'center' }}>
                                    <p color="#718096">No pending replacement requests found.</p>
                                </div>
                            )}
                        </div>

                        {/* Review Section */}
                        {selectedRequest && (
                            <div style={{ animation: 'fadeInRight 0.4s ease-out' }}>
                                <div style={{ backgroundColor: 'white', borderRadius: '24px', padding: '2rem', border: '1px solid #edf2f7', position: 'sticky', top: '2rem' }}>
                                    <h2 style={{ fontSize: '1.5rem', fontWeight: '900', marginBottom: '1.5rem' }}>Review Request</h2>
                                    
                                    <div style={{ marginBottom: '2rem' }}>
                                        <p style={{ fontSize: '0.8rem', fontWeight: '800', color: '#a0aec0', textTransform: 'uppercase' }}>Desired Specifications</p>
                                        <div style={{ padding: '1rem', backgroundColor: '#f8fafc', borderRadius: '12px', border: '1px solid #e2e8f0', marginTop: '0.5rem' }}>
                                            {selectedRequest.desiredSpecifications}
                                        </div>
                                    </div>

                                    <h3 style={{ fontSize: '1.1rem', fontWeight: '800', marginBottom: '1rem' }}>Smart Match Suggestions</h3>
                                    <div style={{ display: 'flex', flexDirection: 'column', gap: '1rem', marginBottom: '2rem' }}>
                                        {suggestions.length > 0 ? suggestions.map(itemId => (
                                            <div key={itemId} style={{
                                                padding: '1rem', border: '1px solid #e2e8f0', borderRadius: '16px',
                                                display: 'flex', justifyContent: 'space-between', alignItems: 'center'
                                            }}>
                                                <div style={{ display: 'flex', gap: '0.75rem', alignItems: 'center' }}>
                                                    <Package size={20} color="#718096" />
                                                    <span style={{ fontWeight: '700' }}>Found Item #{itemId}</span>
                                                </div>
                                                <button 
                                                    onClick={() => handleProcess(true, itemId)}
                                                    disabled={processing}
                                                    style={{ padding: '6px 16px', background: '#319795', color: 'white', borderRadius: '8px', fontSize: '0.85rem', fontWeight: '700', border: 'none', cursor: 'pointer' }}
                                                >
                                                    Assign & Approve
                                                </button>
                                            </div>
                                        )) : (
                                            <p style={{ fontSize: '0.9rem', color: '#e53e3e' }}>No unclaimed items of this type found in inventory.</p>
                                        )}
                                    </div>

                                    <div style={{ borderTop: '1px solid #edf2f7', paddingTop: '2rem' }}>
                                        <textarea 
                                            placeholder="Admin notes (visible to user)..."
                                            value={adminNotes}
                                            onChange={(e) => setAdminNotes(e.target.value)}
                                            style={{ width: '100%', padding: '1rem', borderRadius: '12px', border: '1px solid #e2e8f0', marginBottom: '1.5rem', minHeight: '100px' }}
                                        />
                                        <button 
                                            onClick={() => handleProcess(false)}
                                            disabled={processing}
                                            style={{ width: '100%', padding: '1rem', background: '#fff5f5', color: '#e53e3e', border: '1px solid #feb2b2', borderRadius: '12px', fontWeight: '800', cursor: 'pointer' }}
                                        >
                                            {processing ? "Processing..." : "Reject Application"}
                                        </button>
                                    </div>
                                </div>
                            </div>
                        )}
                    </div>
                )}
                <style>{`
                    @keyframes fadeInRight { from { opacity: 0; transform: translateX(30px); } to { opacity: 1; transform: translateX(0); } }
                    .animate-spin { animation: spin 2s linear infinite; }
                    @keyframes spin { from { transform: rotate(0deg); } to { transform: rotate(360deg); } }
                `}</style>
            </main>
        </div>
    );
};

export default AdminReplacements;
