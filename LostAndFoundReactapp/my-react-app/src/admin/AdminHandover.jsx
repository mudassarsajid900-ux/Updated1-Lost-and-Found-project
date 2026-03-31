import React, { useState, useEffect } from 'react';
import { 
    CheckCircle, Camera, User, FileText, RefreshCw, 
    ArrowRight, ShieldCheck, Smartphone, Wallet, MapPin,
    Laptop, Package, Info, Clock, AlertTriangle, Phone, Search, ExternalLink, Calendar, Tag, Box
} from 'lucide-react';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';
import api from '../api/axios';

const AdminHandover = () => {
    const [pending, setPending] = useState([]);
    const [history, setHistory] = useState([]);
    const [loading, setLoading] = useState(true);
    const API_BASE_URL = import.meta.env.VITE_API_BASE_URL || 'http://localhost:5197';
    const [activeTab, setActiveTab] = useState('pending');
    const [selectedItem, setSelectedItem] = useState(null);
    const [selectedHistoryItem, setSelectedHistoryItem] = useState(null);
    const [submitting, setSubmitting] = useState(false);
    
    // Handover Form State
    const [handoverData, setHandoverData] = useState({
        receiverName: '',
        receiverCnic: '',
        receiverPhone: '',
        adminNotes: '',
        cnicPhoto: null,
        personPhoto: null
    });

    // AUTO-FILL LOGIC: Pre-populate known recipient data
    useEffect(() => {
        if (selectedItem) {
            setHandoverData(prev => ({
                ...prev,
                receiverName: selectedItem.targetPersonName || '',
                receiverPhone: selectedItem.targetPersonPhone || ''
            }));
        } else {
            setHandoverData({
                receiverName: '',
                receiverCnic: '',
                receiverPhone: '',
                adminNotes: '',
                cnicPhoto: null,
                personPhoto: null
            });
        }
    }, [selectedItem]);

    useEffect(() => {
        if (activeTab === 'pending') fetchPending();
        else fetchHistory();
    }, [activeTab]);

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

    const fetchHistory = async () => {
        setLoading(true);
        try {
            const res = await api.get('Handover/all');
            setHistory(res.data.data || []);
        } catch (error) {
            console.error("Error fetching history:", error);
        } finally {
            setLoading(false);
        }
    };

    const handleFileChange = (e, field) => {
        setHandoverData({ ...handoverData, [field]: e.target.files[0] });
    };

    const handleSubmit = async (e) => {
        e.preventDefault();
        if (!handoverData.receiverName || !handoverData.receiverCnic || !handoverData.receiverPhone) {
            alert("Please fill in receiver name, CNIC, and phone number.");
            return;
        }

        // PERFECTION GUARD: Force photo evidence for ALL handovers (Replacements/Claims)
        if (!handoverData.cnicPhoto || !handoverData.personPhoto) {
            alert("Security Protocol Violation: You MUST upload both a Photo of the CNIC and a Photo of the Receiver to finalize this release.");
            return;
        }

        setSubmitting(true);
        const formData = new FormData();
        formData.append('itemId', selectedItem.itemId);
        formData.append('handoverType', selectedItem.handoverType);
        formData.append('receiverName', handoverData.receiverName);
        formData.append('receiverCnic', handoverData.receiverCnic);
        formData.append('receiverPhone', handoverData.receiverPhone);
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
                receiverPhone: '',
                adminNotes: '',
                cnicPhoto: null,
                personPhoto: null
            });
            fetchPending();
        } finally {
            setSubmitting(false);
        }
    };

    const getHandoverLabel = (type) => {
        const t = typeof type === 'string' ? type.toLowerCase() : type;
        if (t === 0 || t === 'founditemtoadmin')   return { text: "Student to Office", color: "#319795", bg: "#e6fffa", process: "FOUND ITEM HANDOVER" };
        if (t === 1 || t === 'admintoclaimant')     return { text: "Return to Owner",   color: "#3182ce", bg: "#ebf8ff", process: "RETURNED TO ORIGINAL OWNER" };
        if (t === 2 || t === 'admintoreplacementuser') return { text: "Replacement Issue", color: "#805ad5", bg: "#faf5ff", process: "REPLACEMENT SENT TO OWNER" };
        if (t === 3 || t === 'admintoauctionwinner') return { text: "Auction Delivery", color: "#dd6b20", bg: "#fffaf0", process: "AUCTION HANDOVER TO WINNER" };
        return { text: "Standard", color: "#718096", bg: "#f7fafc", process: "STANDARD DISPOSAL" };
    };

    return (
        <div className="dashboard-container">
            <Sidebar isAdmin={true} />
            <main className="main-content" style={{ padding: '3rem', background: '#f8fafc' }}>
                <Header 
                    title="Handover Control Center" 
                    subtitle="Officially log the physical transfer of items and verify identities." 
                />

                {/* Tab Switcher */}
                <div style={{ display: 'flex', gap: '1rem', marginBottom: '2.5rem' }}>
                    <button 
                        onClick={() => { setActiveTab('pending'); setSelectedItem(null); }}
                        style={{
                            padding: '0.8rem 1.5rem', borderRadius: '12px', border: 'none', cursor: 'pointer',
                            background: activeTab === 'pending' ? '#319795' : '#fff',
                            color: activeTab === 'pending' ? '#fff' : '#64748b',
                            fontWeight: '800', display: 'flex', alignItems: 'center', gap: '8px',
                            boxShadow: '0 4px 6px -1px rgba(0,0,0,0.05)', transition: 'all 0.2s'
                        }}
                    >
                        <Clock size={18} /> Pending Transfers ({pending.length})
                    </button>
                    <button 
                        onClick={() => { setActiveTab('history'); setSelectedItem(null); }}
                        style={{
                            padding: '0.8rem 1.5rem', borderRadius: '12px', border: 'none', cursor: 'pointer',
                            background: activeTab === 'history' ? '#319795' : '#fff',
                            color: activeTab === 'history' ? '#fff' : '#64748b',
                            fontWeight: '800', display: 'flex', alignItems: 'center', gap: '8px',
                            boxShadow: '0 4px 6px -1px rgba(0,0,0,0.05)', transition: 'all 0.2s'
                        }}
                    >
                        <ShieldCheck size={18} /> Handover Vault ({history.length})
                    </button>
                </div>

                <div style={{ display: 'grid', gridTemplateColumns: '1fr', gap: '2.5rem' }}>
                    
                    {activeTab === 'pending' ? (
                        <div style={{ display: 'grid', gridTemplateColumns: selectedItem ? '1fr 1fr' : '1fr', gap: '2rem', animation: 'fadeIn 0.4s ease-out' }}>
                            {/* List Section */}
                            <div style={{ display: 'flex', flexDirection: 'column', gap: '1.5rem' }}>
                                <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
                                    <h2 style={{ fontSize: '1.25rem', fontWeight: '800' }}>Waiting for Pickup</h2>
                                    <button onClick={fetchPending} style={{ border: 'none', background: 'none', color: '#319795', cursor: 'pointer' }}>
                                        <RefreshCw size={18} className={loading ? "animate-spin" : ""} />
                                    </button>
                                </div>

                                {loading ? (
                                    <div style={{ padding: '4rem', textAlign: 'center' }}><RefreshCw className="animate-spin" size={32} color="#319795" /></div>
                                ) : pending.length > 0 ? (
                                    pending.map(item => {
                                        const label = getHandoverLabel(item.handoverType);
                                        const isReplacement = item.handoverType === 2 || item.handoverType?.toString().toLowerCase().includes('replacement');
                                        const isAuction = item.handoverType === 3 || item.handoverType?.toString().toLowerCase().includes('auction');
                                        const isClaim = item.handoverType === 1 || item.handoverType?.toString().toLowerCase().includes('claim');

                                        return (
                                            <div 
                                                key={`${item.itemId}-${item.handoverType}-${item.claimRequestId || item.replacementRecordId || item.auctionRecordId}`}
                                                onClick={() => setSelectedItem(item)}
                                                style={{
                                                    backgroundColor: 'white', borderRadius: '24px', padding: '1.5rem',
                                                    border: selectedItem?.itemId === item.itemId ? '2.5px solid #319795' : '1px solid #e2e8f0',
                                                    cursor: 'pointer', transition: 'all 0.3s cubic-bezier(0.4, 0, 0.2, 1)',
                                                    display: 'flex', justifyContent: 'space-between', alignItems: 'center',
                                                    boxShadow: selectedItem?.itemId === item.itemId ? '0 10px 15px -3px rgba(49, 151, 149, 0.1)' : '0 2px 4px rgba(0,0,0,0.02)',
                                                    marginBottom: '0.5rem'
                                                }}
                                            >
                                                <div style={{ display: 'flex', gap: '1.5rem', alignItems: 'center' }}>
                                                    <div style={{ position: 'relative' }}>
                                                        <div style={{ width: '64px', height: '64px', borderRadius: '18px', overflow: 'hidden', background: '#f8fafc', border: '1px solid #e2e8f0' }}>
                                                            {item.itemImageUrl ? (
                                                                <img src={`${API_BASE_URL}${item.itemImageUrl}`} alt="" style={{ width: '100%', height: '100%', objectFit: 'cover' }} />
                                                            ) : (
                                                                <div style={{ height: '100%', display: 'flex', alignItems: 'center', justifyContent: 'center', color: label.color }}>
                                                                    {isReplacement ? <RefreshCw size={24} /> : isAuction ? <Wallet size={24} /> : isClaim ? <CheckCircle size={24} /> : <Package size={24} />}
                                                                </div>
                                                            )}
                                                        </div>
                                                        <div style={{ 
                                                            position: 'absolute', bottom: '-5px', right: '-5px', 
                                                            background: label.color, color: '#fff', borderRadius: '50%', 
                                                            width: '24px', height: '24px', display: 'flex', alignItems: 'center', 
                                                            justifyContent: 'center', border: '2px solid #fff', boxShadow: '0 2px 4px rgba(0,0,0,0.1)'
                                                        }}>
                                                            {isReplacement ? <RefreshCw size={12} /> : isAuction ? <Wallet size={12} /> : isClaim ? <User size={12} /> : <ArrowRight size={12} />}
                                                        </div>
                                                    </div>
                                                    
                                                    <div>
                                                        <div style={{ display: 'flex', alignItems: 'center', gap: '8px', marginBottom: '4px' }}>
                                                            <h4 style={{ margin: 0, fontWeight: '900', fontSize: '1.1rem', color: '#1a202c' }}>{item.itemTitle}</h4>
                                                            <span style={{ backgroundColor: label.bg, color: label.color, padding: '3px 10px', borderRadius: '8px', fontSize: '0.65rem', fontWeight: '900', textTransform: 'uppercase', letterSpacing: '0.5px' }}>
                                                                {label.text}
                                                            </span>
                                                        </div>
                                                        <div style={{ display: 'flex', flexDirection: 'column', gap: '2px' }}>
                                                            <div style={{ display: 'flex', alignItems: 'center', gap: '6px', fontSize: '0.85rem', color: '#4a5568', fontWeight: '700' }}>
                                                                <User size={14} color="#718096" /> {item.targetPersonName || "Admin Verification"}
                                                            </div>
                                                            <div style={{ display: 'flex', alignItems: 'center', gap: '6px', fontSize: '0.75rem', color: '#718096' }}>
                                                                <ShieldCheck size={12} /> {item.targetPersonEmail || "system@gac.edu"}
                                                            </div>
                                                        </div>
                                                    </div>
                                                </div>

                                                <div style={{ textAlign: 'right', display: 'flex', flexDirection: 'column', alignItems: 'flex-end', gap: '8px' }}>
                                                    <div style={{ display: 'flex', gap: '4px' }}>
                                                        <div style={{ background: '#f1f5f9', padding: '6px 12px', borderRadius: '10px', fontSize: '0.7rem', fontWeight: '800', color: '#64748b' }}>
                                                            ID: #{item.itemId}
                                                        </div>
                                                        {item.claimRequestId && <div style={{ background: '#ebf8ff', padding: '6px 12px', borderRadius: '10px', fontSize: '0.7rem', fontWeight: '800', color: '#3182ce' }}>CLAIM: #{item.claimRequestId}</div>}
                                                        {item.replacementRecordId && <div style={{ background: '#faf5ff', padding: '6px 12px', borderRadius: '10px', fontSize: '0.7rem', fontWeight: '800', color: '#805ad5' }}>REP: #{item.replacementRecordId}</div>}
                                                    </div>
                                                    <div style={{ color: label.color, fontWeight: '900', fontSize: '0.85rem', display: 'flex', alignItems: 'center', gap: '5px' }}>
                                                        {label.process} <ArrowRight size={16} />
                                                    </div>
                                                </div>
                                            </div>
                                        );
                                    })
                                ) : (
                                    <div style={{ textAlign: 'center', padding: '3rem', background: '#fff', borderRadius: '24px', border: '1px dashed #cbd5e0', color: '#718096' }}>
                                        <Package size={48} style={{ marginBottom: '1rem', opacity: 0.3 }} />
                                        <p style={{ fontWeight: '700' }}>No pending handovers at the moment.</p>
                                    </div>
                                )}
                            </div>

                            {/* Form Section */}
                            {selectedItem && (
                                <div style={{ animation: 'fadeInRight 0.4s ease-out' }}>
                                    <form onSubmit={handleSubmit} style={{ backgroundColor: 'white', borderRadius: '24px', padding: '2.5rem', border: '1px solid #e2e8f0', boxShadow: '0 10px 25px -5px rgba(0,0,0,0.05)' }}>
                                        <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center', marginBottom: '1.5rem' }}>
                                            <div>
                                                <span style={{ 
                                                    background: getHandoverLabel(selectedItem.handoverType).bg, 
                                                    color: getHandoverLabel(selectedItem.handoverType).color, 
                                                    padding: '4px 12px', borderRadius: '8px', fontSize: '0.7rem', fontWeight: '900', 
                                                    textTransform: 'uppercase', marginBottom: '8px', display: 'inline-block'
                                                }}>
                                                    {getHandoverLabel(selectedItem.handoverType).text.toUpperCase()} PROCESS
                                                </span>
                                                <h2 style={{ fontSize: '1.6rem', fontWeight: '900', margin: 0 }}>Physical Release</h2>
                                            </div>
                                            <button type="button" onClick={() => setSelectedItem(null)} style={{ border: 'none', background: 'none', cursor: 'pointer', padding: '10px' }}>
                                                <AlertTriangle size={24} color="#cbd5e0" />
                                            </button>
                                        </div>

                                        <div style={{ background: '#f8fafc', borderRadius: '16px', padding: '1.5rem', marginBottom: '2rem', border: '1px solid #f1f5f9' }}>
                                            {/* Product Summary */}
                                            <div style={{ display: 'flex', gap: '1.25rem', marginBottom: '1.5rem', paddingBottom: '1.5rem', borderBottom: '1px dashed #cbd5e0' }}>
                                                <div style={{ width: '80px', height: '80px', borderRadius: '16px', overflow: 'hidden', border: '2px solid #fff', boxShadow: '0 4px 6px rgba(0,0,0,0.05)' }}>
                                                    {selectedItem.itemImageUrl ? (
                                                        <img src={`${API_BASE_URL}${selectedItem.itemImageUrl}`} alt="" style={{ width: '100%', height: '100%', objectFit: 'cover' }} />
                                                    ) : (
                                                        <div style={{ height: '100%', background: '#edf2f7', display: 'flex', alignItems: 'center', justifyContent: 'center' }}><Package size={32} color="#a0aec0" /></div>
                                                    )}
                                                </div>
                                                <div style={{ flex: 1 }}>
                                                    <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'flex-start' }}>
                                                        <h4 style={{ margin: 0, fontWeight: '900', fontSize: '1.15rem' }}>{selectedItem.itemTitle}</h4>
                                                        <span style={{ color: '#94a3b8', fontSize: '0.75rem', fontWeight: '800' }}>ITEM # {selectedItem.itemId}</span>
                                                    </div>
                                                    <div style={{ fontSize: '0.8rem', color: '#718096', marginTop: '4px', display: 'flex', alignItems: 'center', gap: '5px' }}>
                                                        <MapPin size={12} /> Found at: <b>{selectedItem.itemLocation || "Admin Office"}</b>
                                                    </div>
                                                    <p style={{ margin: '8px 0 0 0', fontSize: '0.8rem', color: '#4a5568', lineHeight: '1.4', background: '#fff', padding: '8px', borderRadius: '8px', border: '1px solid #edf2f7' }}>
                                                        {selectedItem.itemDescription || "Verify item description with recipient."}
                                                    </p>
                                                </div>
                                            </div>

                                            {/* Security Quiz Section - Handling casing for Attributes */}
                                            {(() => {
                                                const rawAttrs = selectedItem.attributes || selectedItem.Attributes || [];
                                                const attrs = Array.isArray(rawAttrs) ? rawAttrs : [];
                                                
                                                if (attrs.length === 0) {
                                                    return (
                                                        <div style={{ marginTop: '0', marginBottom: '1.5rem', padding: '1.25rem', background: '#f8fafc', borderRadius: '16px', border: '1px dashed #cbd5e0' }}>
                                                            <div style={{ display: 'flex', alignItems: 'center', gap: '8px', color: '#64748b', fontSize: '0.75rem', fontWeight: '900', textTransform: 'uppercase', marginBottom: '6px' }}>
                                                                <Info size={14} /> SECURITY QUIZ
                                                            </div>
                                                            <p style={{ margin: 0, fontSize: '0.85rem', color: '#4a5568', fontWeight: '500', lineHeight: '1.5' }}>
                                                                No specific attributes stored for this item. Verify its identity manually before release.
                                                            </p>
                                                        </div>
                                                    );
                                                }

                                                return (
                                                    <div style={{ background: '#fff', padding: '1.25rem', borderRadius: '12px', marginBottom: '1.5rem', border: `1.5px solid ${getHandoverLabel(selectedItem.handoverType).color}` }}>
                                                        <div style={{ display: 'flex', alignItems: 'center', gap: '8px', color: getHandoverLabel(selectedItem.handoverType).color, marginBottom: '10px' }}>
                                                            <ShieldCheck size={18} />
                                                            <h6 style={{ margin: 0, fontSize: '0.75rem', fontWeight: '900', textTransform: 'uppercase' }}>Security Quiz: Verify Physical Identification</h6>
                                                        </div>
                                                        <div style={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '10px' }}>
                                                            {attrs.map((attr, idx) => (
                                                                <div key={idx} style={{ background: `${getHandoverLabel(selectedItem.handoverType).bg}80`, padding: '8px 12px', borderRadius: '8px', border: `1px solid ${getHandoverLabel(selectedItem.handoverType).color}20` }}>
                                                                    <span style={{ display: 'block', fontSize: '0.65rem', color: '#868e96', fontWeight: '800', textTransform: 'uppercase' }}>{attr.fieldName || attr.FieldName}</span>
                                                                    <span style={{ fontSize: '0.9rem', fontWeight: '900', color: '#2d3748' }}>{attr.fieldValue || attr.FieldValue}</span>
                                                                </div>
                                                            ))}
                                                        </div>
                                                    </div>
                                                );
                                            })()}

                                            <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
                                                <div>
                                                    <h5 style={{ margin: '0 0 0.25rem 0', color: '#64748b', fontSize: '0.75rem', textTransform: 'uppercase', fontWeight: '800' }}>Transfer Recipient</h5>
                                                    <p style={{ margin: 0, fontWeight: '800', fontSize: '1.15rem', color: '#2d3748' }}>{selectedItem.targetPersonName || "GAC Verification Desk"}</p>
                                                    <div style={{ display: 'flex', alignItems: 'center', gap: '5px', color: '#718096', fontSize: '0.8rem' }}>
                                                        <User size={14} /> {selectedItem.targetPersonEmail}
                                                    </div>
                                                </div>
                                                <div style={{ textAlign: 'right' }}>
                                                    <div style={{ fontSize: '0.7rem', fontWeight: '900', color: '#cbd5e0', marginBottom: '4px' }}>VERIFICATION REFERENCE</div>
                                                    <div style={{ background: getHandoverLabel(selectedItem.handoverType).color, color: '#fff', padding: '4px 10px', borderRadius: '8px', fontSize: '0.75rem', fontWeight: '900' }}>
                                                        {selectedItem.claimRequestId ? `CLAIM #${selectedItem.claimRequestId}` : 
                                                         selectedItem.replacementRecordId ? `REP #${selectedItem.replacementRecordId}` : 
                                                         selectedItem.auctionRecordId ? `AUC #${selectedItem.auctionRecordId}` : 'FOUND LOG'}
                                                    </div>
                                                </div>
                                            </div>
                                        </div>

                                        <div style={{ display: 'grid', gridTemplateColumns: '1fr', gap: '1.25rem', marginBottom: '1.5rem' }}>
                                            <div>
                                                <label style={{ display: 'block', fontSize: '0.85rem', fontWeight: '800', marginBottom: '0.5rem', color: '#475569' }}>Receiver Full Name</label>
                                                <input 
                                                    type="text" 
                                                    placeholder="As shown on CNIC"
                                                    value={handoverData.receiverName}
                                                    onChange={(e) => setHandoverData({...handoverData, receiverName: e.target.value})}
                                                    style={{ padding: '14px 16px', border: '1.5px solid #e2e8f0', borderRadius: '12px', width: '100%', outline: 'none' }}
                                                />
                                            </div>
                                            <div style={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '1rem' }}>
                                                <div>
                                                    <label style={{ display: 'block', fontSize: '0.85rem', fontWeight: '800', marginBottom: '0.5rem', color: '#475569' }}>Receiver CNIC</label>
                                                    <input 
                                                        type="text" 
                                                        placeholder="XXXXX-XXXXXXX-X"
                                                        value={handoverData.receiverCnic}
                                                        onChange={(e) => setHandoverData({...handoverData, receiverCnic: e.target.value})}
                                                        style={{ padding: '14px 16px', border: '1.5px solid #e2e8f0', borderRadius: '12px', width: '100%', outline: 'none' }}
                                                    />
                                                </div>
                                                <div>
                                                    <label style={{ display: 'block', fontSize: '0.85rem', fontWeight: '800', marginBottom: '0.5rem', color: '#475569' }}>Phone Number</label>
                                                    <input 
                                                        type="text" 
                                                        placeholder="03XX-XXXXXXX"
                                                        value={handoverData.receiverPhone}
                                                        onChange={(e) => setHandoverData({...handoverData, receiverPhone: e.target.value})}
                                                        style={{ padding: '14px 16px', border: '1.5px solid #e2e8f0', borderRadius: '12px', width: '100%', outline: 'none' }}
                                                    />
                                                </div>
                                            </div>
                                        </div>

                                        <div style={{ marginBottom: '1.5rem' }}>
                                            <label style={{ display: 'block', fontSize: '0.85rem', fontWeight: '800', marginBottom: '0.75rem', color: '#475569' }}>Photos & Evidence</label>
                                            <div style={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '1rem' }}>
                                                <label style={{ 
                                                    border: '2px dashed #e2e8f0', borderRadius: '14px', padding: '1.5rem', 
                                                    textAlign: 'center', cursor: 'pointer', display: 'flex', flexDirection: 'column', alignItems: 'center', gap: '0.5rem',
                                                    transition: 'all 0.2s', backgroundColor: handoverData.cnicPhoto ? '#f0fdfa' : 'transparent'
                                                }}>
                                                    <input type="file" hidden onChange={(e) => handleFileChange(e, 'cnicPhoto')} />
                                                    <Camera size={24} color={handoverData.cnicPhoto ? "#319795" : "#94a3b8"} />
                                                    <span style={{ fontSize: '0.75rem', fontWeight: '800', color: handoverData.cnicPhoto ? "#319795" : "#64748b" }}>{handoverData.cnicPhoto ? "CNIC ATTACHED" : "PHOTO OF CNIC"}</span>
                                                </label>
                                                <label style={{ 
                                                    border: '2px dashed #e2e8f0', borderRadius: '14px', padding: '1.5rem', 
                                                    textAlign: 'center', cursor: 'pointer', display: 'flex', flexDirection: 'column', alignItems: 'center', gap: '0.5rem',
                                                    transition: 'all 0.2s', backgroundColor: handoverData.personPhoto ? '#f0fdfa' : 'transparent'
                                                }}>
                                                    <input type="file" hidden onChange={(e) => handleFileChange(e, 'personPhoto')} />
                                                    <User size={24} color={handoverData.personPhoto ? "#319795" : "#94a3b8"} />
                                                    <span style={{ fontSize: '0.75rem', fontWeight: '800', color: handoverData.personPhoto ? "#319795" : "#64748b" }}>{handoverData.personPhoto ? "PHOTO TAKEN" : "PHOTO OF RECEIVER"}</span>
                                                </label>
                                            </div>
                                        </div>

                                        <textarea 
                                            placeholder="Internal admin notes about this handover..."
                                            value={handoverData.adminNotes}
                                            onChange={(e) => setHandoverData({...handoverData, adminNotes: e.target.value})}
                                            style={{ width: '100%', padding: '1rem', border: '1.5px solid #e2e8f0', borderRadius: '12px', minHeight: '100px', marginBottom: '2rem', outline: 'none' }}
                                        />

                                        <button 
                                            type="submit" 
                                            disabled={submitting}
                                            style={{
                                                width: '100%', padding: '1.25rem', backgroundColor: '#319795', color: 'white',
                                                borderRadius: '16px', border: 'none', fontWeight: '900', fontSize: '1rem',
                                                display: 'flex', alignItems: 'center', justifyContent: 'center', gap: '0.75rem', cursor: 'pointer',
                                                boxShadow: '0 10px 15px -3px rgba(49, 151, 149, 0.4)', transition: 'all 0.2s'
                                            }}
                                        >
                                            {submitting ? <RefreshCw className="animate-spin" /> : <>Confirm Physical Release <ArrowRight size={20} /></>}
                                        </button>
                                    </form>
                                </div>
                            )}
                        </div>
                    ) : (
                        /* HISTORY VAULT SECTION */
                        <div style={{ animation: 'fadeIn 0.5s ease-out' }}>
                            <div style={{ background: 'white', borderRadius: '24px', border: '1px solid #e2e8f0', overflow: 'hidden', boxShadow: '0 4px 20px -5px rgba(0,0,0,0.05)' }}>
                                <div style={{ padding: '1.5rem 2rem', borderBottom: '1px solid #f1f5f9', display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
                                    <h3 style={{ fontWeight: '900', color: '#1e293b', margin: 0 }}>Archived Release Records</h3>
                                    <div style={{ display: 'flex', gap: '0.5rem', color: '#64748b', fontSize: '0.85rem', fontWeight: '700' }}>
                                        <ShieldCheck size={16} /> Secure Audit Logs
                                    </div>
                                </div>

                                {loading ? (
                                    <div style={{ padding: '5rem', textAlign: 'center' }}><RefreshCw className="animate-spin" size={40} color="#319795" /></div>
                                ) : history.length > 0 ? (
                                    <div style={{ overflowX: 'auto' }}>
                                        <table style={{ width: '100%', borderCollapse: 'collapse' }}>
                                            <thead>
                                                <tr style={{ background: '#f8fafc', textAlign: 'left' }}>
                                                    <th style={{ padding: '1rem 2rem', fontSize: '0.75rem', fontWeight: '800', color: '#64748b', borderBottom: '1px solid #f1f5f9' }}>ITEM & CATEGORY</th>
                                                    <th style={{ padding: '1rem 2rem', fontSize: '0.75rem', fontWeight: '800', color: '#64748b', borderBottom: '1px solid #f1f5f9' }}>TYPE</th>
                                                    <th style={{ padding: '1rem 2rem', fontSize: '0.75rem', fontWeight: '800', color: '#64748b', borderBottom: '1px solid #f1f5f9' }}>RELEASED TO (NAME)</th>
                                                    <th style={{ padding: '1rem 2rem', fontSize: '0.75rem', fontWeight: '800', color: '#64748b', borderBottom: '1px solid #f1f5f9' }}>CNIC & CONTACT</th>
                                                    <th style={{ padding: '1rem 2rem', fontSize: '0.75rem', fontWeight: '800', color: '#64748b', borderBottom: '1px solid #f1f5f9' }}>DATE</th>
                                                    <th style={{ padding: '1rem 2rem', fontSize: '0.75rem', fontWeight: '800', color: '#64748b', borderBottom: '1px solid #f1f5f9' }}>EVIDENCE</th>
                                                </tr>
                                            </thead>
                                            <tbody>
                                                {history.map(record => (
                                                    <tr key={record.id} style={{ borderBottom: '1px solid #f1f5f9' }}>
                                                        <td style={{ padding: '1.25rem 2rem' }}>
                                                            <div style={{ fontWeight: '700', color: '#1e293b' }}>{record.itemTitle}</div>
                                                            <div style={{ fontSize: '0.75rem', color: '#94a3b8' }}>ID: #{record.itemId}</div>
                                                        </td>
                                                        <td style={{ padding: '1.25rem 2rem' }}>
                                                            {(() => {
                                                                const label = getHandoverLabel(record.handoverType);
                                                                return (
                                                                    <span style={{ backgroundColor: label.bg, color: label.color, padding: '4px 10px', borderRadius: '100px', fontSize: '0.7rem', fontWeight: '800' }}>
                                                                        {label.text}
                                                                    </span>
                                                                );
                                                            })()}
                                                        </td>
                                                        <td style={{ padding: '1.25rem 2rem' }}>
                                                            <div style={{ display: 'flex', alignItems: 'center', gap: '8px', fontWeight: '700' }}>
                                                                <User size={14} color="#319795" /> {record.receiverName}
                                                            </div>
                                                        </td>
                                                        <td style={{ padding: '1.25rem 2rem' }}>
                                                            <div style={{ fontSize: '0.85rem', color: '#475569' }}>{record.receiverCnic}</div>
                                                            <div style={{ fontSize: '0.8rem', color: '#319795', fontWeight: '600' }}>{record.receiverPhone}</div>
                                                        </td>
                                                        <td style={{ padding: '1.25rem 2rem' }}>
                                                            <div style={{ fontSize: '0.85rem', color: '#64748b' }}>
                                                                {new Date(record.createdOn).toLocaleDateString()}
                                                            </div>
                                                        </td>
                                                        <td style={{ padding: '1.25rem 2rem' }}>
                                                            <div style={{ display: 'flex', gap: '8px' }}>
                                                                {record.cnicImagePath ? (
                                                                    <div 
                                                                        onClick={() => setSelectedHistoryItem(record)}
                                                                        style={{ width: '30px', height: '30px', borderRadius: '6px', overflow: 'hidden', border: '1px solid #e2e8f0', cursor: 'pointer', background: '#f8fafc', display: 'flex', alignItems: 'center', justifyContent: 'center' }}
                                                                    >
                                                                        <img src={`${API_BASE_URL}${record.cnicImagePath}`} alt="" style={{ width: '100%', height: '100%', objectFit: 'cover' }} />
                                                                    </div>
                                                                ) : <div style={{ width: '30px', height: '30px', borderRadius: '6px', background: '#f1f5f9', display: 'flex', alignItems: 'center', justifyContent: 'center' }}><Camera size={14} color="#cbd5e0" /></div>}
                                                                
                                                                {record.personImagePath ? (
                                                                    <div 
                                                                        onClick={() => setSelectedHistoryItem(record)}
                                                                        style={{ width: '30px', height: '30px', borderRadius: '6px', overflow: 'hidden', border: '1px solid #e2e8f0', cursor: 'pointer', background: '#f8fafc', display: 'flex', alignItems: 'center', justifyContent: 'center' }}
                                                                    >
                                                                        <img src={`${import.meta.env.VITE_API_BASE_URL}${record.personImagePath}`} alt="" style={{ width: '100%', height: '100%', objectFit: 'cover' }} />
                                                                    </div>
                                                                ) : <div style={{ width: '30px', height: '30px', borderRadius: '6px', background: '#f1f5f9', display: 'flex', alignItems: 'center', justifyContent: 'center' }}><User size={14} color="#cbd5e0" /></div>}
                                                                
                                                                <button 
                                                                    onClick={() => setSelectedHistoryItem(record)}
                                                                    title="View Audit Detail" 
                                                                    style={{ border: 'none', background: '#f1f5f9', borderRadius: '6px', width: '30px', height: '30px', display: 'flex', alignItems: 'center', justifyContent: 'center', cursor: 'pointer' }}
                                                                >
                                                                    <ExternalLink size={14} color="#64748b" />
                                                                </button>
                                                            </div>
                                                        </td>
                                                    </tr>
                                                ))}
                                            </tbody>
                                        </table>
                                    </div>
                                ) : (
                                    <div style={{ padding: '5rem', textAlign: 'center' }}>
                                        <Package size={48} color="#e2e8f0" style={{ marginBottom: '1rem' }} />
                                        <p style={{ color: '#94a3b8', fontWeight: '600' }}>The Handover Vault is currently empty.</p>
                                    </div>
                                )}
                            </div>
                        </div>
                    )}
                {/* HISTORY AUDIT DETAIL MODAL - Identification Perfection */}
                {selectedHistoryItem && (
                    <div style={{ position: 'fixed', top: 0, left: 0, width: '100%', height: '100%', backgroundColor: 'rgba(15, 23, 42, 0.7)', backdropFilter: 'blur(8px)', display: 'flex', alignItems: 'center', justifyContent: 'center', zIndex: 1100, padding: '20px' }}>
                        <div style={{ background: '#f8fafc', width: '100%', maxWidth: '700px', borderRadius: '28px', overflow: 'hidden', boxShadow: '0 25px 50px -12px rgba(0, 0, 0, 0.5)', animation: 'fadeIn 0.3s ease-out' }}>
                            <div style={{ background: getHandoverLabel(selectedHistoryItem.handoverType).color, padding: '1.5rem 2rem', color: 'white', display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
                                <div>
                                    <div style={{ fontSize: '0.7rem', fontWeight: '900', textTransform: 'uppercase', opacity: 0.8 }}>Handover Audit Record</div>
                                    <h3 style={{ margin: 0, fontWeight: '900', fontSize: '1.25rem' }}>{selectedHistoryItem.itemTitle}</h3>
                                </div>
                                <button onClick={() => setSelectedHistoryItem(null)} style={{ background: 'rgba(255,255,255,0.2)', border: 'none', color: 'white', padding: '10px', borderRadius: '14px', cursor: 'pointer', fontWeight: '900' }}>CLOSE</button>
                            </div>

                            <div style={{ padding: '2rem', maxHeight: '80vh', overflowY: 'auto' }}>
                                <div style={{ display: 'grid', gridTemplateColumns: '1.2fr 1fr', gap: '1.5rem' }}>
                                    {/* Left Partition: Process & Evidence */}
                                    <div>
                                        {/* GIANT Identification Banner */}
                                        <div style={{ 
                                            background: getHandoverLabel(selectedHistoryItem.handoverType).bg, 
                                            border: `2px solid ${getHandoverLabel(selectedHistoryItem.handoverType).color}`,
                                            padding: '1rem', borderRadius: '16px', marginBottom: '1.5rem', textAlign: 'center'
                                        }}>
                                            <div style={{ fontSize: '0.65rem', fontWeight: '900', color: getHandoverLabel(selectedHistoryItem.handoverType).color, textTransform: 'uppercase', letterSpacing: '1px' }}>Process Finalized As:</div>
                                            <div style={{ fontSize: '1.25rem', fontWeight: '900', color: getHandoverLabel(selectedHistoryItem.handoverType).color }}>
                                                {selectedHistoryItem.handoverType === 1 || (typeof selectedHistoryItem.handoverType === 'string' && selectedHistoryItem.handoverType.toLowerCase() === 'admintoclaimant') ? 'LOST & FOUND RETURN' :
                                                 selectedHistoryItem.handoverType === 2 || (typeof selectedHistoryItem.handoverType === 'string' && selectedHistoryItem.handoverType.toLowerCase() === 'admintoreplacementuser') ? 'REPLACEMENT DELIVERY' :
                                                 selectedHistoryItem.handoverType === 3 || (typeof selectedHistoryItem.handoverType === 'string' && selectedHistoryItem.handoverType.toLowerCase().includes('auction')) ? 'AUCTION WINNER RELEASE' : 'STUDENT TO OFFICE HANDOVER'}
                                            </div>
                                        </div>

                                        <div style={{ background: '#fff', padding: '1.25rem', borderRadius: '20px', border: '1px solid #e2e8f0', marginBottom: '1.5rem' }}>
                                            <div style={{ fontSize: '0.7rem', color: '#64748b', fontWeight: '900', textTransform: 'uppercase', marginBottom: '10px' }}>Asset Classification</div>
                                            <div style={{ display: 'flex', alignItems: 'center', gap: '10px' }}>
                                                <div style={{ background: getHandoverLabel(selectedHistoryItem.handoverType).bg, color: getHandoverLabel(selectedHistoryItem.handoverType).color, padding: '4px 12px', borderRadius: '10px', fontSize: '0.75rem', fontWeight: '900', display: 'flex', alignItems: 'center', gap: '6px' }}>
                                                    <Info size={14}/> {getHandoverLabel(selectedHistoryItem.handoverType).process}
                                                </div>
                                                <span style={{ fontSize: '0.8rem', color: '#94a3b8', fontWeight: '800' }}>ASSET ID: #{selectedHistoryItem.itemId}</span>
                                            </div>
                                            <div style={{ marginTop: '12px', padding: '12px', background: '#f8fafc', borderRadius: '12px', border: '1px solid #edf2f7' }}>
                                                <div style={{ fontSize: '0.65rem', fontWeight: '900', color: '#64748b', textTransform: 'uppercase', marginBottom: '4px' }}>Original Report Narrative</div>
                                                <div style={{ fontSize: '0.85rem', color: '#1e293b', fontWeight: '700', marginBottom: '4px', display: 'flex', alignItems: 'center', gap: '6px' }}>
                                                    <Tag size={12} color="#3182ce" /> {selectedHistoryItem.itemCategory || 'Uncategorized Asset'}
                                                </div>
                                                <p style={{ margin: 0, fontSize: '0.85rem', color: '#475569', lineHeight: '1.5' }}>
                                                    {selectedHistoryItem.itemDescription || "No detailed narrative was recorded during the initial discovery."}
                                                </p>
                                            </div>
                                        </div>

                                        {/* Physical Attributes Section for HISTORY */}
                                        <div style={{ background: '#fff', padding: '1.25rem', borderRadius: '20px', border: '1px solid #e2e8f0', marginBottom: '1.5rem' }}>
                                            <div style={{ fontSize: '0.7rem', color: '#64748b', fontWeight: '900', textTransform: 'uppercase', marginBottom: '10px' }}>Detailed Identification (Attributes)</div>
                                            <div style={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '8px' }}>
                                                {(() => {
                                                    const historyAttrs = selectedHistoryItem.attributes || selectedHistoryItem.Attributes || [];
                                                    if (historyAttrs && historyAttrs.length > 0) {
                                                        return historyAttrs.map((attr, idx) => (
                                                            <div key={idx} style={{ padding: '8px 12px', background: '#f8fafc', borderRadius: '10px', border: '1px solid #edf2f7' }}>
                                                                <div style={{ fontSize: '0.6rem', color: '#94a3b8', fontWeight: '800', textTransform: 'uppercase' }}>{attr.fieldName || attr.FieldName}</div>
                                                                <div style={{ fontSize: '0.85rem', color: '#2d3748', fontWeight: '800' }}>{attr.fieldValue || attr.FieldValue}</div>
                                                            </div>
                                                        ));
                                                    }
                                                    return (
                                                        <div style={{ gridColumn: 'span 2', fontSize: '0.8rem', color: '#94a3b8', fontStyle: 'italic', padding: '10px', textAlign: 'center' }}>
                                                            No granular physical attributes were recorded for this {selectedHistoryItem.itemTitle}.
                                                        </div>
                                                    );
                                                })()}
                                            </div>
                                        </div>

                                        <div style={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '12px' }}>
                                            {selectedHistoryItem.cnicImagePath && (
                                                <div style={{ background: '#fff', padding: '8px', borderRadius: '16px', border: '1px solid #e2e8f0' }}>
                                                     <div style={{ fontSize: '0.6rem', fontWeight: '900', color: '#94a3b8', marginBottom: '4px', textAlign: 'center' }}>CNIC PROOF</div>
                                                     <img src={`${API_BASE_URL}${selectedHistoryItem.cnicImagePath}`} style={{ width: '100%', borderRadius: '10px', height: '120px', objectFit: 'cover' }} alt="CNIC" />
                                                </div>
                                            )}
                                            {selectedHistoryItem.personImagePath && (
                                                <div style={{ background: '#fff', padding: '8px', borderRadius: '16px', border: '1px solid #e2e8f0' }}>
                                                     <div style={{ fontSize: '0.6rem', fontWeight: '900', color: '#94a3b8', marginBottom: '4px', textAlign: 'center' }}>RECEIVER PHOTO</div>
                                                     <img src={`${API_BASE_URL}${selectedHistoryItem.personImagePath}`} style={{ width: '100%', borderRadius: '10px', height: '120px', objectFit: 'cover' }} alt="Person" />
                                                </div>
                                            )}
                                        </div>
                                    </div>

                                    {/* Right Partition: Receiver & Security Details */}
                                    <div>
                                        <div style={{ background: '#fff', padding: '1.25rem', borderRadius: '20px', border: '1px solid #e2e8f0', marginBottom: '1.5rem' }}>
                                            <div style={{ fontSize: '0.7rem', color: '#64748b', fontWeight: '900', textTransform: 'uppercase', marginBottom: '10px' }}>RECIPIENT IDENTITY</div>
                                            <div style={{ display: 'flex', alignItems: 'center', gap: '8px', fontWeight: '900', color: '#1a202c', marginBottom: '4px' }}>
                                                <User size={16} color="#319795" /> {selectedHistoryItem.receiverName}
                                            </div>
                                            <div style={{ fontSize: '0.85rem', color: '#4a5568', display: 'flex', flexDirection: 'column', gap: '2px' }}>
                                                <span>CNIC: <b>{selectedHistoryItem.receiverCnic}</b></span>
                                                <span>Phone: <b>{selectedHistoryItem.receiverPhone}</b></span>
                                            </div>
                                        </div>

                                        <div style={{ background: '#eff6ff', padding: '1.25rem', borderRadius: '20px', border: '1px solid #bfdbfe' }}>
                                            <div style={{ fontSize: '0.7rem', color: '#3b82f6', fontWeight: '900', textTransform: 'uppercase', marginBottom: '12px', display: 'flex', alignItems: 'center', gap: '6px' }}>
                                                <ShieldCheck size={14} /> SECURITY AUDIT LOG
                                            </div>
                                            <div style={{ fontSize: '0.75rem', color: '#1e3a8a', display: 'flex', flexDirection: 'column', gap: '8px' }}>
                                                <div style={{ display: 'flex', justifyContent: 'space-between' }}><span>Release Date:</span> <b>{new Date(selectedHistoryItem.createdOn).toLocaleString()}</b></div>
                                                <div style={{ display: 'flex', justifyContent: 'space-between' }}><span>Process ID:</span> <b>LOG-{selectedHistoryItem.id}</b></div>
                                                <div style={{ display: 'flex', justifyContent: 'space-between' }}><span>Sign-off:</span> <b>DIGITAL APPROVED</b></div>
                                            </div>
                                        </div>

                                        {/* Physical Evidence Photos in Modal */}
                                        <div style={{ marginTop: '1.5rem', display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '10px' }}>
                                            {selectedHistoryItem.cnicImagePath && (
                                                <div style={{ background: '#fff', padding: '10px', borderRadius: '16px', border: '1px solid #e2e8f0' }}>
                                                    <div style={{ fontSize: '0.6rem', color: '#94a3b8', fontWeight: '900', textTransform: 'uppercase', marginBottom: '6px' }}>CNIC PROOF</div>
                                                    <img src={`${import.meta.env.VITE_API_BASE_URL}${selectedHistoryItem.cnicImagePath}`} alt="" style={{ width: '100%', height: '80px', objectFit: 'cover', borderRadius: '8px' }} />
                                                </div>
                                            )}
                                            {selectedHistoryItem.personImagePath && (
                                                <div style={{ background: '#fff', padding: '10px', borderRadius: '16px', border: '1px solid #e2e8f0' }}>
                                                    <div style={{ fontSize: '0.6rem', color: '#94a3b8', fontWeight: '900', textTransform: 'uppercase', marginBottom: '6px' }}>RECIPENT PHOTO</div>
                                                    <img src={`${import.meta.env.VITE_API_BASE_URL}${selectedHistoryItem.personImagePath}`} alt="" style={{ width: '100%', height: '80px', objectFit: 'cover', borderRadius: '8px' }} />
                                                </div>
                                            )}
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                )}
                </div>

                <style>{`
                    @keyframes fadeIn { from { opacity: 0; transform: translateY(10px); } to { opacity: 1; transform: translateY(0); } }
                    @keyframes fadeInRight { from { opacity: 0; transform: translateX(30px); } to { opacity: 1; transform: translateX(0); } }
                    .animate-spin { animation: spin 2s linear infinite; }
                    @keyframes spin { from { transform: rotate(0deg); } to { transform: rotate(360deg); } }
                `}</style>
            </main>
        </div>
    );
};

export default AdminHandover;
