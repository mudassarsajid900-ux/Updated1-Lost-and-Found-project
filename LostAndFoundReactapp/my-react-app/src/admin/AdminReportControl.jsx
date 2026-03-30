import React, { useState, useEffect } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import { 
    ChevronLeft, Calendar, MapPin, Clock, Tag, User, Mail, Phone,
    Shield, CheckCircle2, AlertCircle, History, Package, Edit3, 
    Trash2, Save, X, ExternalLink, ArrowRight, Gavel, RefreshCw, Info, ShieldCheck
} from 'lucide-react';
import api from '../api/axios';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';

const API_BASE_URL = import.meta.env.VITE_API_BASE_URL || 'http://localhost:5197';

const AdminReportControl = () => {
    const { id } = useParams();
    const navigate = useNavigate();
    
    const [item, setItem] = useState(null);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);
    const [isUpdating, setIsUpdating] = useState(false);
    
    const [matchedItem, setMatchedItem] = useState(null);
    const [matchLoading, setMatchLoading] = useState(false);

    // Handover Modal State
    const [showHandoverModal, setShowHandoverModal] = useState(false);
    const [handoverData, setHandoverData] = useState({
        receiverName: '',
        receiverCnic: '',
        receiverPhone: '',
        adminNotes: '',
        cnicPhoto: null,
        personPhoto: null
    });

    const isFound = (v) => v === 1 || String(v).toLowerCase() === 'found' || String(v) === '1';

    const fetchDetails = async () => {
        setLoading(true);
        try {
            const res = await api.get(`Item/get-by-id/${id}`);
            if (res.data.isSucceeded || res.data.IsSucceeded) {
                const mainItem = res.data.data;
                setItem(mainItem);
                
                // Fetch the matched item details for SPLIT-SCREEN COMPARISON
                const matchedId = mainItem.matchFoundItemId || mainItem.MatchFoundItemId;
                if (matchedId) {
                    setMatchLoading(true);
                    try {
                        const mRes = await api.get(`Item/get-by-id/${matchedId}`);
                        if (mRes.data.isSucceeded || mRes.data.IsSucceeded) {
                            setMatchedItem(mRes.data.data);
                        }
                    } catch (mErr) { console.error("Match fetch failed", mErr); }
                    finally { setMatchLoading(false); }
                }
            } else {
                setError("Case record not found.");
            }
        } catch (err) {
            console.error(err);
            setError("Database connection error.");
        } finally {
            setLoading(false);
        }
    };

    useEffect(() => {
        fetchDetails();
    }, [id]);

    const handleVerifyReceipt = async () => {
        setIsUpdating(true);
        try {
            await api.put(`Item/verify/${id}`);
            alert("Physical receipt verified. Owner can now see this match.");
            fetchDetails();
        } catch (err) {
            alert("Verification failed.");
        } finally {
            setIsUpdating(false);
        }
    };

    const handleHandoverSubmit = async (e) => {
        e.preventDefault();
        setIsUpdating(true);
        
        try {
            const formData = new FormData();
            formData.append('ItemId', id);
            formData.append('ReceiverName', handoverData.receiverName);
            formData.append('ReceiverCnic', handoverData.receiverCnic);
            formData.append('ReceiverPhone', handoverData.receiverPhone);
            formData.append('AdminNotes', handoverData.adminNotes);
            formData.append('HandoverType', 0); // User collect
            if (handoverData.cnicPhoto) formData.append('CnicPhoto', handoverData.cnicPhoto);
            if (handoverData.personPhoto) formData.append('PersonPhoto', handoverData.personPhoto);

            await api.post('Handover/create', formData, {
                headers: { 'Content-Type': 'multipart/form-data' }
            });
            
            alert("Handover completed successfully. All proof stored in audit logs.");
            setShowHandoverModal(false);
            navigate('/admin-reports');
        } catch (err) {
            alert("Handover processing failed. Please check files and server.");
        } finally {
            setIsUpdating(false);
        }
    };

    const handleApproveClaim = async () => {
        if (!item.claimId) return;
        setIsUpdating(true);
        try {
            await api.put('Claim/update-status', { claimId: item.claimId, status: 3 }); // VerificationSucceeded
            alert("Claim APPROVED. Case moved to Handover Screen.");
            fetchDetails();
        } catch (err) { alert("Approval failed."); }
        finally { setIsUpdating(false); }
    };

    const handleRejectClaim = async () => {
        if (!item.claimId) return;
        
        const reason = window.prompt("REJECTION REASON (Sent to user):", "Photos provide insufficient proof of ownership.");
        if (reason === null) return;

        setIsUpdating(true);
        try {
            await api.put('Claim/update-status', { 
                claimId: item.claimId, 
                status: 2, 
                rejectionReason: reason || "Your claim was not approved by the administrator."
            });
            alert("Claim REJECTED and Match Resolved.");
            fetchDetails();
        } catch (err) { alert("Rejection failed."); }
        finally { setIsUpdating(false); }
    };

    const handleDelete = async () => {
        if (window.confirm("PERMANENTLY delete this case file?")) {
            try {
                await api.delete(`Item/${id}`);
                navigate('/admin-reports');
            } catch (err) { alert("Delete failed."); }
        }
    };

    if (loading) return <div style={{ padding: '5rem', textAlign: 'center' }}>Decrypting Case File...</div>;
    if (error) return <div style={{ padding: '5rem', textAlign: 'center', color: 'red' }}>{error}</div>;

    const isFoundItem = isFound(item.reportType);

    return (
        <div className="dashboard-container">
            <Sidebar isAdmin={true} />

            <main className="main-content" style={{ background: '#f8fafc', padding: '2.5rem' }}>
                <div style={{ maxWidth: '1200px', margin: '0 auto' }}>
                    
                    {/* MODAL: OFFICIAL HANDOVER FORM */}
                    {showHandoverModal && (
                        <div style={{ position: 'fixed', inset: 0, background: 'rgba(15, 23, 42, 0.8)', backdropFilter: 'blur(8px)', zIndex: 1000, display: 'flex', alignItems: 'center', justifyContent: 'center', padding: '2rem' }}>
                            <div style={{ background: '#fff', borderRadius: '32px', width: '100%', maxWidth: '700px', overflow: 'hidden', boxShadow: '0 25px 50px -12px rgba(0,0,0,0.5)' }}>
                                <div style={{ background: '#0d9488', color: '#fff', padding: '2rem', display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
                                    <div>
                                        <h2 style={{ margin: 0, fontSize: '1.5rem', fontWeight: '900' }}>Official Handover Protocol</h2>
                                        <p style={{ margin: '4px 0 0 0', opacity: 0.8, fontSize: '0.85rem' }}>Capture identity proof before releasing assets.</p>
                                    </div>
                                    <button onClick={() => setShowHandoverModal(false)} style={{ background: 'rgba(255,255,255,0.2)', border: 'none', color: '#fff', width: '40px', height: '40px', borderRadius: '50%', cursor: 'pointer' }}><X size={20}/></button>
                                </div>
                                <form onSubmit={handleHandoverSubmit} style={{ padding: '2.5rem' }}>
                                    <div style={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '1.5rem', marginBottom: '1.5rem' }}>
                                        <div>
                                            <label style={{ display: 'block', fontSize: '0.75rem', fontWeight: '800', color: '#64748b', textTransform: 'uppercase', marginBottom: '8px' }}>Receiver Full Name</label>
                                            <input required type="text" value={handoverData.receiverName} onChange={e => setHandoverData({...handoverData, receiverName: e.target.value})} style={{ width: '100%', padding: '0.75rem 1rem', borderRadius: '12px', border: '1px solid #e2e8f0', outline: 'none' }} placeholder="e.g. Mudassar Sajid" />
                                        </div>
                                        <div>
                                            <label style={{ display: 'block', fontSize: '0.75rem', fontWeight: '800', color: '#64748b', textTransform: 'uppercase', marginBottom: '8px' }}>CNIC / Identity Number</label>
                                            <input required type="text" value={handoverData.receiverCnic} onChange={e => setHandoverData({...handoverData, receiverCnic: e.target.value})} style={{ width: '100%', padding: '0.75rem 1rem', borderRadius: '12px', border: '1px solid #e2e8f0', outline: 'none' }} placeholder="35201-XXXXXXX-X" />
                                        </div>
                                    </div>

                                    <div style={{ marginBottom: '1.5rem' }}>
                                        <label style={{ display: 'block', fontSize: '0.75rem', fontWeight: '800', color: '#64748b', textTransform: 'uppercase', marginBottom: '8px' }}>Admin Notes (Physical Condition, etc.)</label>
                                        <textarea value={handoverData.adminNotes} onChange={e => setHandoverData({...handoverData, adminNotes: e.target.value})} style={{ width: '100%', padding: '0.75rem 1rem', borderRadius: '12px', border: '1px solid #e2e8f0', outline: 'none', minHeight: '80px', resize: 'vertical' }} placeholder="Items verified against original description..." />
                                    </div>

                                    <div style={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '1.5rem', marginBottom: '2.5rem' }}>
                                        <div style={{ border: '2px dashed #e2e8f0', padding: '1rem', borderRadius: '16px', textAlign: 'center' }}>
                                            <div style={{ fontSize: '0.7rem', fontWeight: '800', color: '#64748b', marginBottom: '10px' }}>SNAP OF ID CARD</div>
                                            <input type="file" required onChange={e => setHandoverData({...handoverData, cnicPhoto: e.target.files[0]})} style={{ fontSize: '0.75rem' }} />
                                        </div>
                                        <div style={{ border: '2px dashed #e2e8f0', padding: '1rem', borderRadius: '16px', textAlign: 'center' }}>
                                            <div style={{ fontSize: '0.7rem', fontWeight: '800', color: '#64748b', marginBottom: '10px' }}>SNAP OF RECEIVER</div>
                                            <input type="file" required onChange={e => setHandoverData({...handoverData, personPhoto: e.target.files[0]})} style={{ fontSize: '0.75rem' }} />
                                        </div>
                                    </div>

                                    <button 
                                        type="submit" 
                                        disabled={isUpdating}
                                        style={{ width: '100%', padding: '1.25rem', borderRadius: '16px', border: 'none', background: '#0d9488', color: '#fff', fontWeight: '800', fontSize: '1.1rem', cursor: 'pointer', display: 'flex', alignItems: 'center', justifyContent: 'center', gap: '10px' }}
                                    >
                                        {isUpdating ? 'Securing Evidence...' : <><Shield size={20}/> Complete Official Handover</>}
                                    </button>
                                </form>
                            </div>
                        </div>
                    )}

                    <button 
                        onClick={() => navigate('/admin-reports')}
                        style={{ display: 'flex', alignItems: 'center', gap: '8px', background: 'none', border: 'none', color: '#64748b', fontWeight: '700', cursor: 'pointer', marginBottom: '1.5rem' }}
                    >
                        <ChevronLeft size={20} /> Back to Master Inventory
                    </button>

                    <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center', marginBottom: '2rem' }}>
                        <div>
                            <div style={{ display: 'flex', alignItems: 'center', gap: '8px', color: '#3b82f6', fontWeight: '800', fontSize: '0.8rem', textTransform: 'uppercase', marginBottom: '4px' }}>
                                <Shield size={14} /> Official Case Record
                            </div>
                            <h1 style={{ margin: 0, fontSize: '2rem', fontWeight: '900', color: '#1e293b' }}>
                                {item.type} <span style={{ color: '#94a3b8', fontWeight: '400' }}>#{item.id}</span>
                            </h1>
                        </div>

                        <div style={{ display: 'flex', gap: '1rem' }}>
                            <button 
                                onClick={() => {
                                    const rType = item.reportType ?? item.ReportType;
                                    navigate(rType === 0 ? '/report-lost' : '/report-found', { state: { itemData: item } });
                                }}
                                style={{ padding: '0.75rem 1.5rem', borderRadius: '12px', border: '1px solid #e2e8f0', background: '#fff', color: '#1e293b', fontWeight: '700', cursor: 'pointer', display: 'flex', alignItems: 'center', gap: '8px' }}
                            >
                                <Edit3 size={18} /> Edit Attributes
                            </button>
                        </div>
                    </div>

                    {/* SPLIT-SCREEN COMPARISON ENGINE */}
                    <div style={{ display: 'grid', gridTemplateColumns: matchedItem ? '1fr 1fr' : '1fr', gap: '2rem', marginBottom: '2.5rem' }}>
                        
                        {/* LEFT COLUMN: THE PHYSICAL ASSET (FOUND ITEM) */}
                        <div style={{ background: '#fff', borderRadius: '32px', border: '1px solid #e2e8f0', overflow: 'hidden', boxShadow: '0 10px 25px -5px rgba(0,0,0,0.03)' }}>
                            <div style={{ height: '300px', background: '#f8fafc', position: 'relative', overflow: 'hidden', display: 'flex', alignItems: 'center', justifyContent: 'center' }}>
                                {item.imageUrl ? (
                                    <img src={`${API_BASE_URL}${item.imageUrl}`} alt="Original Evidence" style={{ width: '100%', height: '100%', objectFit: 'contain', background: '#000' }} />
                                ) : (
                                    <div style={{ textAlign: 'center', color: '#94a3b8' }}>
                                        <Package size={64} style={{ marginBottom: '1rem' }} />
                                        <p style={{ fontWeight: '700' }}>No Image Captured</p>
                                    </div>
                                )}
                                <div style={{ position: 'absolute', top: '20px', left: '20px', padding: '6px 16px', background: '#0d9488', color: '#fff', borderRadius: '100px', fontSize: '0.75rem', fontWeight: '900', boxShadow: '0 4px 12px rgba(13, 148, 136, 0.4)' }}>
                                    PHYSICAL EVIDENCE IN OFFICE
                                </div>
                            </div>
                            
                            <div style={{ padding: '2rem' }}>
                                <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'flex-start', marginBottom: '1.5rem' }}>
                                    <div>
                                        <h3 style={{ margin: 0, fontSize: '1.25rem', fontWeight: '900', color: '#1e293b' }}>Item Attributes</h3>
                                        <p style={{ margin: '4px 0 0 0', fontSize: '0.85rem', color: '#64748b' }}>Verified by Admin upon arrival.</p>
                                    </div>
                                    <span style={{ padding: '4px 12px', background: '#f0fdf4', color: '#10b981', borderRadius: '100px', fontSize: '0.7rem', fontWeight: '900', border: '1px solid #10b98120' }}>
                                        VERIFIED
                                    </span>
                                </div>

                                <div style={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '1rem' }}>
                                    {(item.attributes || item.Attributes || []).map((attr, idx) => (
                                        <div key={idx} style={{ padding: '0.75rem', background: '#f8fafc', borderRadius: '12px', border: '1px solid #f1f5f9' }}>
                                            <div style={{ fontSize: '0.65rem', fontWeight: '800', color: '#94a3b8', textTransform: 'uppercase', marginBottom: '2px' }}>{attr.fieldName || attr.FieldName}</div>
                                            <div style={{ fontWeight: '700', color: '#334155', fontSize: '0.9rem' }}>{attr.fieldValue || attr.FieldValue}</div>
                                        </div>
                                    ))}
                                </div>

                                <div style={{ marginTop: '1.5rem', padding: '1rem', background: '#f1f5f9', borderRadius: '12px', display: 'flex', gap: '1rem', alignItems: 'center' }}>
                                    <MapPin size={24} color="#64748b" />
                                    <div>
                                        <div style={{ fontSize: '0.7rem', fontWeight: '800', color: '#64748b', textTransform: 'uppercase' }}>Found Location</div>
                                        <div style={{ fontWeight: '700', color: '#1e293b' }}>{item.locationName}</div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        {/* RIGHT COLUMN: THE STUDENT'S CLAIM (LOST ITEM) */}
                        {matchedItem ? (
                            <div style={{ background: '#fff', borderRadius: '32px', border: '1px solid #fee2e2', overflow: 'hidden', boxShadow: '0 10px 25px -5px rgba(239, 68, 68, 0.05)' }}>
                                <div style={{ height: '300px', background: '#fef2f2', display: 'flex', flexDirection: 'column', alignItems: 'center', justifyContent: 'center', color: '#ef4444', padding: '2rem', textAlign: 'center' }}>
                                    <ShieldCheck size={80} style={{ opacity: 0.2, marginBottom: '1rem' }} />
                                    <div style={{ padding: '6px 16px', background: '#ef4444', color: '#fff', borderRadius: '100px', fontSize: '0.75rem', fontWeight: '900', boxShadow: '0 4px 12px rgba(239, 68, 68, 0.4)' }}>
                                        STUDENT OWNERSHIP CLAIM
                                    </div>
                                    <h2 style={{ color: '#1e293b', fontWeight: '900', marginTop: '1.5rem', marginBottom: '4px' }}>{item.claimantName || "Student"}</h2>
                                    <p style={{ color: '#64748b', fontSize: '0.85rem' }}><Mail size={12} /> {item.claimantEmail}</p>
                                </div>

                                <div style={{ padding: '2rem' }}>
                                    <div style={{ marginBottom: '1.5rem' }}>
                                        <h3 style={{ margin: 0, fontSize: '1.25rem', fontWeight: '900', color: '#1e293b' }}>Proof of Ownership</h3>
                                        <p style={{ margin: '4px 0 0 0', fontSize: '0.85rem', color: '#64748b' }}>Student proof narrative for verification.</p>
                                    </div>

                                    {item.claimDescription ? (
                                        <div style={{ padding: '1.5rem', background: '#fff5f5', border: '1px solid #fee2e2', borderRadius: '20px', color: '#475569', fontSize: '1rem', lineHeight: '1.6', fontStyle: 'italic', position: 'relative', marginBottom: '2rem' }}>
                                            <div style={{ position: 'absolute', top: '-12px', left: '20px', background: '#ef4444', color: 'white', padding: '2px 10px', borderRadius: '4px', fontSize: '0.6rem', fontWeight: '900' }}>THEIR NARRATIVE</div>
                                            "{item.claimDescription}"
                                        </div>
                                    ) : (
                                        <div style={{ padding: '1.5rem', background: '#f8fafc', borderRadius: '20px', textAlign: 'center', color: '#94a3b8', marginBottom: '2rem' }}>
                                            <AlertCircle size={32} style={{ marginBottom: '0.5rem' }} />
                                            <p style={{ fontWeight: '700' }}>No ownership proof provided.</p>
                                        </div>
                                    )}

                                    <h4 style={{ fontSize: '0.75rem', fontWeight: '800', color: '#64748b', textTransform: 'uppercase', marginBottom: '1rem' }}>Original Lost Report Comparison</h4>
                                    <div style={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '1rem' }}>
                                        {(matchedItem.attributes || matchedItem.Attributes || []).map((attr, idx) => (
                                            <div key={idx} style={{ padding: '0.75rem', background: '#fff', borderRadius: '12px', border: '1px solid #fee2e2' }}>
                                                <div style={{ fontSize: '0.65rem', fontWeight: '800', color: '#ef4444', textTransform: 'uppercase', marginBottom: '2px' }}>{attr.fieldName || attr.FieldName}</div>
                                                <div style={{ fontWeight: '700', color: '#334155', fontSize: '0.9rem' }}>{attr.fieldValue || attr.FieldValue}</div>
                                            </div>
                                        ))}
                                    </div>
                                    
                                    <div style={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '1rem', marginTop: '2rem' }}>
                                        <button onClick={handleApproveClaim} style={{ padding: '1rem', borderRadius: '16px', background: '#3b82f6', color: '#fff', border: 'none', fontWeight: '900', cursor: 'pointer', display: 'flex', alignItems: 'center', justifyContent: 'center', gap: '8px', boxShadow: '0 4px 12px rgba(59, 130, 246, 0.3)' }}>
                                            <CheckCircle2 size={20} /> Approve Claim
                                        </button>
                                        <button onClick={handleRejectClaim} style={{ padding: '1rem', borderRadius: '16px', background: '#fff', color: '#ef4444', border: '2px solid #fee2e2', fontWeight: '900', cursor: 'pointer', display: 'flex', alignItems: 'center', justifyContent: 'center', gap: '8px' }}>
                                            <X size={20} /> Reject Claim
                                        </button>
                                    </div>
                                </div>
                            </div>
                        ) : (
                            <div style={{ background: '#fff', borderRadius: '32px', border: '1px solid #e2e8f0', padding: '3rem', textAlign: 'center', display: 'flex', flexDirection: 'column', alignItems: 'center', justifyContent: 'center' }}>
                                <RefreshCw size={48} color="#cbd5e0" style={{ marginBottom: '1rem' }} />
                                <h3 style={{ margin: 0, color: '#475569' }}>Awaiting User Claim</h3>
                                <p style={{ color: '#94a3b8', maxWidth: '300px' }}>Once a student finds this match and submits their proof of ownership, their details will appear here side-by-side.</p>
                                
                                {isFoundItem && !(item.isVerifiedByAdmin || item.IsVerifiedByAdmin) && (
                                    <button 
                                        onClick={handleVerifyReceipt}
                                        style={{ marginTop: '2rem', padding: '1rem 2rem', borderRadius: '16px', border: 'none', background: '#0d9488', color: '#fff', fontWeight: '800', cursor: 'pointer', display: 'flex', alignItems: 'center', gap: '8px' }}
                                    >
                                        <Shield size={20} /> Verify Physical Arrival Now
                                    </button>
                                )}
                            </div>
                        )}
                    </div>

                    {/* SIDEBAR CONTROLS (Floating Status Update) */}
                    <div style={{ background: '#fff', borderRadius: '24px', padding: '1.5rem', border: '1px solid #e2e8f0', display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
                         <div style={{ display: 'flex', gap: '1.5rem' }}>
                            <div>
                                <div style={{ fontSize: '0.7rem', fontWeight: '800', color: '#94a3b8', textTransform: 'uppercase' }}>Reporter Identity</div>
                                <div style={{ fontWeight: '700', color: '#1e293b' }}>{item.reporterName}</div>
                            </div>
                            <div style={{ width: '1px', background: '#e2e8f0' }} />
                            <div>
                                <div style={{ fontSize: '0.7rem', fontWeight: '800', color: '#94a3b8', textTransform: 'uppercase' }}>Submission Date</div>
                                <div style={{ fontWeight: '700', color: '#1e293b' }}>{new Date(item.createdOn).toLocaleDateString()}</div>
                            </div>
                         </div>

                         <div style={{ display: 'flex', gap: '1rem' }}>
                             {isFoundItem && (item.isVerifiedByAdmin || item.IsVerifiedByAdmin) && (
                                 <button 
                                     onClick={() => setShowHandoverModal(true)}
                                     style={{ padding: '0.75rem 1.5rem', borderRadius: '12px', background: '#1e293b', color: '#fff', border: 'none', fontWeight: '800', cursor: 'pointer', display: 'flex', alignItems: 'center', gap: '8px' }}
                                 >
                                    <Package size={18} /> Official Release Form
                                 </button>
                             )}
                             <button 
                                 onClick={handleDelete}
                                 style={{ width: '42px', height: '42px', borderRadius: '12px', background: '#fef2f2', border: '1px solid #fee2e2', color: '#ef4444', cursor: 'pointer', display: 'flex', alignItems: 'center', justifyContent: 'center' }}
                             >
                                 <Trash2 size={18} />
                             </button>
                         </div>
                    </div>
                </div>
                <style dangerouslySetInnerHTML={{
                    __html: `
                    @keyframes matchPulse {
                        0% { box-shadow: 0 0 0 0 rgba(79, 70, 229, 0.4); }
                        70% { box-shadow: 0 0 0 10px rgba(79, 70, 229, 0); }
                        100% { box-shadow: 0 0 0 0 rgba(79, 70, 229, 0); }
                    }
                    .match-pulse {
                        animation: matchPulse 2s infinite;
                        border: 2px solid #4f46e5 !important;
                    }
                    `
                }} />
            </main>
        </div>
    );
};

export default AdminReportControl;
