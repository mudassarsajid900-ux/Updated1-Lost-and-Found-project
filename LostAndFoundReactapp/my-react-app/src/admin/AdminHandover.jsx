import React, { useState, useEffect } from 'react';
import { 
    CheckCircle, Camera, User, FileText, RefreshCw, 
    ArrowRight, ShieldCheck, Smartphone, Wallet, 
    Laptop, Package, Info, Clock, AlertTriangle 
} from 'lucide-react';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';
import api from '../api/axios';

const AdminHandover = () => {
    const [pending, setPending] = useState([]);
    const [loading, setLoading] = useState(true);
    const [selectedItem, setSelectedItem] = useState(null);
    const [submitting, setSubmitting] = useState(false);
    
    // Handover Form State
    const [handoverData, setHandoverData] = useState({
        receiverName: '',
        receiverCnic: '',
        adminNotes: '',
        cnicPhoto: null,
        personPhoto: null
    });

    useEffect(() => {
        fetchPending();
    }, []);

    const fetchPending = async () => {
        setLoading(true);
        try {
            const res = await api.get('Handover/pending');
            setPending(res.data.data || []);
        } catch (error) {
            console.error("Error fetching pending handovers:", error);
        } finally {
            setLoading(false);
        }
    };

    const handleFileChange = (e, field) => {
        setHandoverData({ ...handoverData, [field]: e.target.files[0] });
    };

    const handleSubmit = async (e) => {
        e.preventDefault();
        if (!handoverData.receiverName || !handoverData.receiverCnic) {
            alert("Please fill in receiver details.");
            return;
        }

        setSubmitting(true);
        const formData = new FormData();
        formData.append('itemId', selectedItem.itemId);
        formData.append('handoverType', selectedItem.handoverType);
        formData.append('receiverName', handoverData.receiverName);
        formData.append('receiverCnic', handoverData.receiverCnic);
        formData.append('adminNotes', handoverData.adminNotes);
        
        if (selectedItem.claimRequestId) formData.append('claimRequestId', selectedItem.claimRequestId);
        if (selectedItem.replacementRecordId) formData.append('replacementRecordId', selectedItem.replacementRecordId);
        if (selectedItem.auctionRecordId) formData.append('auctionRecordId', selectedItem.auctionRecordId);
        
        if (handoverData.cnicPhoto) formData.append('cnicPhoto', handoverData.cnicPhoto);
        if (handoverData.personPhoto) formData.append('personPhoto', handoverData.personPhoto);

        try {
            await api.post('Handover/create', formData, {
                headers: { 'Content-Type': 'multipart/form-data' }
            });
            alert("Handover record created and item status updated successfully!");
            setSelectedItem(null);
            setHandoverData({
                receiverName: '',
                receiverCnic: '',
                adminNotes: '',
                cnicPhoto: null,
                personPhoto: null
            });
            fetchPending();
        } catch (error) {
            console.error("Error creating handover:", error);
            alert("Failed to create handover record.");
        } finally {
            setSubmitting(false);
        }
    };

    const getHandoverLabel = (type) => {
        switch (type) {
            case 0: return { text: "Student to Office", color: "#319795", bg: "#e6fffa" };
            case 1: return { text: "Return to Owner", color: "#3182ce", bg: "#ebf8ff" };
            case 2: return { text: "Replacement Issue", color: "#805ad5", bg: "#faf5ff" };
            case 3: return { text: "Auction Delivery", color: "#dd6b20", bg: "#fffaf0" };
            default: return { text: "Standard", color: "#718096", bg: "#f7fafc" };
        }
    };

    return (
        <div className="dashboard-container">
            <Sidebar isAdmin={true} />
            <main className="main-content" style={{ padding: '3rem', background: '#f8fafc' }}>
                <Header 
                    title="Manage Handovers" 
                    subtitle="Officially log the physical transfer of items and verify identities." 
                />

                <div style={{ display: 'grid', gridTemplateColumns: selectedItem ? '1fr 1fr' : '1fr', gap: '2.5rem' }}>
                    
                    {/* List Section */}
                    <div style={{ display: 'flex', flexDirection: 'column', gap: '1.5rem' }}>
                        <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
                            <h2 style={{ fontSize: '1.25rem', fontWeight: '800' }}>Pending Transfers</h2>
                            <button onClick={fetchPending} style={{ border: 'none', background: 'none', color: '#319795', cursor: 'pointer' }}>
                                <RefreshCw size={18} className={loading ? "animate-spin" : ""} />
                            </button>
                        </div>

                        {loading ? (
                            <div style={{ padding: '4rem', textAlign: 'center' }}>
                                <RefreshCw className="animate-spin" size={32} color="#319795" />
                            </div>
                        ) : pending.length > 0 ? (
                            pending.map(item => {
                                const label = getHandoverLabel(item.handoverType);
                                return (
                                    <div 
                                        key={`${item.itemId}-${item.handoverType}`}
                                        onClick={() => setSelectedItem(item)}
                                        style={{
                                            backgroundColor: 'white', borderRadius: '20px', padding: '1.25rem',
                                            border: selectedItem?.itemId === item.itemId ? '2px solid #319795' : '1px solid #e2e8f0',
                                            cursor: 'pointer', transition: 'all 0.2s',
                                            display: 'flex', justifyContent: 'space-between', alignItems: 'center'
                                        }}
                                    >
                                        <div style={{ display: 'flex', gap: '1rem', alignItems: 'center' }}>
                                            <div style={{ width: '50px', height: '50px', borderRadius: '12px', overflow: 'hidden', background: '#f1f5f9' }}>
                                                {item.itemImageUrl ? (
                                                    <img src={`http://localhost:5197${item.itemImageUrl}`} alt="" style={{ width: '100%', height: '100%', objectFit: 'cover' }} />
                                                ) : (
                                                    <div style={{ height: '100%', display: 'flex', alignItems: 'center', justifyContent: 'center' }}><Package size={20} /></div>
                                                )}
                                            </div>
                                            <div>
                                                <h4 style={{ margin: 0, fontWeight: '700' }}>{item.itemTitle}</h4>
                                                <p style={{ margin: 0, fontSize: '0.8rem', color: '#718096' }}>To: {item.targetPersonName || "L&F Office"}</p>
                                            </div>
                                        </div>
                                        <div style={{ textAlign: 'right' }}>
                                            <span style={{ 
                                                backgroundColor: label.bg, color: label.color, 
                                                padding: '4px 12px', borderRadius: '100px', fontSize: '0.75rem', fontWeight: '800' 
                                            }}>
                                                {label.text}
                                            </span>
                                        </div>
                                    </div>
                                );
                            })
                        ) : (
                            <div style={{ padding: '3rem', background: 'white', borderRadius: '24px', textAlign: 'center', border: '1px dashed #cbd5e0' }}>
                                <p color="#718096">No pending physical handovers.</p>
                            </div>
                        )}
                    </div>

                    {/* Form Section */}
                    {selectedItem && (
                        <div style={{ animation: 'fadeInRight 0.4s ease-out' }}>
                            <form onSubmit={handleSubmit} style={{ backgroundColor: 'white', borderRadius: '24px', padding: '2.5rem', border: '1px solid #e2e8f0' }}>
                                <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center', marginBottom: '2rem' }}>
                                    <h2 style={{ fontSize: '1.5rem', fontWeight: '900' }}>Finalize Handover</h2>
                                    <button onClick={() => setSelectedItem(null)} style={{ border: 'none', background: 'none' }}><AlertTriangle size={20} color="#cbd5e0" /></button>
                                </div>

                                <div style={{ background: '#f8fafc', borderRadius: '16px', padding: '1.25rem', marginBottom: '2rem', border: '1px solid #f1f5f9' }}>
                                    <h5 style={{ margin: '0 0 0.5rem 0', color: '#64748b', fontSize: '0.75rem', textTransform: 'uppercase' }}>Target Recipient</h5>
                                    <p style={{ margin: 0, fontWeight: '700' }}>{selectedItem.targetPersonName || "Administration Office"}</p>
                                    <p style={{ margin: 0, fontSize: '0.85rem', color: '#94a3b8' }}>{selectedItem.targetPersonEmail}</p>
                                </div>

                                <div style={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '1.5rem', marginBottom: '1.5rem' }}>
                                    <div className="input-field">
                                        <label style={{ display: 'block', fontSize: '0.85rem', fontWeight: '700', marginBottom: '0.5rem' }}>Receiver Name</label>
                                        <input 
                                            type="text" 
                                            className="search-input" 
                                            placeholder="Full name on ID"
                                            value={handoverData.receiverName}
                                            onChange={(e) => setHandoverData({...handoverData, receiverName: e.target.value})}
                                            style={{ padding: '12px 16px', border: '1px solid #e2e8f0', borderRadius: '10px', width: '100%' }}
                                        />
                                    </div>
                                    <div className="input-field">
                                        <label style={{ display: 'block', fontSize: '0.85rem', fontWeight: '700', marginBottom: '0.5rem' }}>Receiver CNIC / ID</label>
                                        <input 
                                            type="text" 
                                            className="search-input" 
                                            placeholder="XXXXX-XXXXXXX-X"
                                            value={handoverData.receiverCnic}
                                            onChange={(e) => setHandoverData({...handoverData, receiverCnic: e.target.value})}
                                            style={{ padding: '12px 16px', border: '1px solid #e2e8f0', borderRadius: '10px', width: '100%' }}
                                        />
                                    </div>
                                </div>

                                <div style={{ marginBottom: '1.5rem' }}>
                                    <label style={{ display: 'block', fontSize: '0.85rem', fontWeight: '700', marginBottom: '0.5rem' }}>Photos & Evidence</label>
                                    <div style={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '1rem' }}>
                                        <label style={{ 
                                            border: '2px dashed #e2e8f0', borderRadius: '12px', padding: '1.5rem', 
                                            textAlign: 'center', cursor: 'pointer', display: 'flex', flexDirection: 'column', alignItems: 'center', gap: '0.5rem'
                                        }}>
                                            <input type="file" hidden onChange={(e) => handleFileChange(e, 'cnicPhoto')} />
                                            <Camera size={20} color={handoverData.cnicPhoto ? "#319795" : "#a0aec0"} />
                                            <span style={{ fontSize: '0.75rem', fontWeight: '700' }}>{handoverData.cnicPhoto ? "CNIC Attached" : "CNIC Card"}</span>
                                        </label>
                                        <label style={{ 
                                            border: '2px dashed #e2e8f0', borderRadius: '12px', padding: '1.5rem', 
                                            textAlign: 'center', cursor: 'pointer', display: 'flex', flexDirection: 'column', alignItems: 'center', gap: '0.5rem'
                                        }}>
                                            <input type="file" hidden onChange={(e) => handleFileChange(e, 'personPhoto')} />
                                            <User size={20} color={handoverData.personPhoto ? "#319795" : "#a0aec0"} />
                                            <span style={{ fontSize: '0.75rem', fontWeight: '700' }}>{handoverData.personPhoto ? "Photo Taken" : "Person Photo"}</span>
                                        </label>
                                    </div>
                                </div>

                                <textarea 
                                    className="search-input" 
                                    placeholder="Additional handover notes..."
                                    value={handoverData.adminNotes}
                                    onChange={(e) => setHandoverData({...handoverData, adminNotes: e.target.value})}
                                    style={{ width: '100%', padding: '1rem', border: '1px solid #e2e8f0', borderRadius: '12px', minHeight: '80px', marginBottom: '2rem' }}
                                />

                                <button 
                                    type="submit" 
                                    disabled={submitting}
                                    style={{
                                        width: '100%', padding: '1.25rem', backgroundColor: '#319795', color: 'white',
                                        borderRadius: '16px', border: 'none', fontWeight: '900', fontSize: '1rem',
                                        display: 'flex', alignItems: 'center', justifyContent: 'center', gap: '0.75rem', cursor: 'pointer',
                                        boxShadow: '0 10px 15px -3px rgba(49, 151, 149, 0.4)'
                                    }}
                                >
                                    {submitting ? <RefreshCw className="animate-spin" /> : <>Confirm Physical Transfer <ArrowRight size={20} /></>}
                                </button>
                            </form>
                        </div>
                    )}
                </div>

                <style>{`
                    @keyframes fadeInRight { from { opacity: 0; transform: translateX(30px); } to { opacity: 1; transform: translateX(0); } }
                    .animate-spin { animation: spin 2s linear infinite; }
                    @keyframes spin { from { transform: rotate(0deg); } to { transform: rotate(360deg); } }
                `}</style>
            </main>
        </div>
    );
};

export default AdminHandover;
