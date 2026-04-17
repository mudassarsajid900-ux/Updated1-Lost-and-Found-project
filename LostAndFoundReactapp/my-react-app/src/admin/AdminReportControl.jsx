/**
 * @file AdminReportControl.jsx
 * @description Administrative Command & Control Center for individual case files.
 * Orchestrates high-stakes workflows including:
 * 1. Forensic Comparison: Split-screen analysis between found physical evidence and student claims.
 * 2. Claim Adjudication: Automated approval/rejection logic with user notification triggers.
 * 3. Asset Release (Handover): Multi-factor authentication & evidence capture (CNIC/Photo).
 * 4. Staging: Moving unclaimed assets to the Auction Lifecycle.
 */
import React, { useState, useEffect } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import { 
    ChevronLeft, Calendar, MapPin, Clock, Tag, User, Mail, Phone,
    Shield, CheckCircle2, AlertCircle, History, Package, Edit3, 
    Trash2, Save, X, ExternalLink, ArrowRight, Gavel, RefreshCw, Info, ShieldCheck,
    Smartphone, Wallet, Laptop, Briefcase, Watch, FileText, Gem, Headphones
} from 'lucide-react';
import api from '../api/axios';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';

const API_BASE_URL = import.meta.env.VITE_API_BASE_URL || 'http://localhost:5197';

const AdminReportControl = () => {
    const { id } = useParams();
    const navigate = useNavigate();
    
    // Core State: Case Record
    const [item, setItem] = useState(null);
    const [loading, setLoading] = useState(true);
    const [error, setError] = useState(null);
    const [isUpdating, setIsUpdating] = useState(false);
    
    // Auxiliary State: Matching context for side-by-side verification
    const [matchedItem, setMatchedItem] = useState(null);
    const [matchLoading, setMatchLoading] = useState(false);

    // Handover Protocol State: Capture legally required proof
    const [showHandoverModal, setShowHandoverModal] = useState(false);
    const [handoverData, setHandoverData] = useState({
        receiverName: '',
        receiverCnic: '',
        receiverPhone: '',
        adminNotes: '',
        cnicPhoto: null,
        personPhoto: null
    });
    
    // Icon Resolution Engine for professional nomenclature
    const getIcon = (type) => {
        const t = (type || "").toLowerCase();
        if (t.includes('device') || t.includes('phone') || t.includes('mobile')) return <Smartphone size={64} />;
        if (t.includes('wallet')) return <Wallet size={64} />;
        if (t.includes('hardware') || t.includes('laptop') || t.includes('computing')) return <Laptop size={64} />;
        if (t.includes('luggage') || t.includes('bag')) return <Briefcase size={64} />;
        if (t.includes('timepiece') || t.includes('watch')) return <Watch size={64} />;
        if (t.includes('documentation') || t.includes('passport') || t.includes('id')) return <FileText size={64} />;
        if (t.includes('jewelry') || t.includes('valuables')) return <Gem size={64} />;
        if (t.includes('audio') || t.includes('earphone') || t.includes('headphone')) return <Headphones size={64} />;
        return <Package size={64} />;
    };

    const isFound = (v) => v === 1 || String(v).toLowerCase() === 'found' || String(v) === '1';

    /**
     * Data Orchestration: Fetches the primary case file and recursively 
     * resolves any matched 'Lost' counterparts for comparative analysis.
     */
    const fetchDetails = async () => {
        setLoading(true);
        try {
            const res = await api.get(`Item/get-by-id/${id}`);
            if (res.data.isSucceeded || res.data.IsSucceeded) {
                const mainItem = res.data.data;
                setItem(mainItem);
                
                // Trigger Comparison Engine if a match exists
                const matchedId = mainItem.matchFoundItemId || mainItem.MatchFoundItemId;
                if (matchedId) {
                    setMatchLoading(true);
                    try {
                        const mRes = await api.get(`Item/get-by-id/${matchedId}`);
                        if (mRes.data.isSucceeded || mRes.data.IsSucceeded) {
                            setMatchedItem(mRes.data.data);
                        }
                    } catch (mErr) { console.error("Forensic match fetch failed", mErr); }
                    finally { setMatchLoading(false); }
                }
            } else {
                setError("Case record not found in the persistent store.");
            }
        } catch (err) {
            console.error(err);
            setError("Critical database connection error.");
        } finally {
            setLoading(false);
        }
    };

    useEffect(() => {
        fetchDetails();
    }, [id]);

    /**
     * Verification Gate: Confirms physical custody of the item.
     * Unlocks the visibility of the match for the claiming student.
     */
    const handleVerifyReceipt = async () => {
        setIsUpdating(true);
        try {
            await api.put(`Item/verify/${id}`);
            alert("Physical receipt verified. Owner can now see this match.");
            fetchDetails();
        } catch (err) {
            alert("Verification protocol failure.");
        } finally {
            setIsUpdating(false);
        }
    };

    /**
     * Staging Protocol: Transitions an unclaimed item from 'Active Inventory' to 'Auction Staging'.
     */
    const handleMoveToAuction = async () => {
        if (!window.confirm("Move this item to the Auction list? This will make it eligible for public bidding.")) return;
        setIsUpdating(true);
        try {
            await api.put(`Item/move-to-auction/${id}`);
            alert("Item successfully moved to auction staging.");
            navigate('/admin-auctions');
        } catch (err) {
            alert("Lifecycle transition to Auction failed.");
        } finally {
            setIsUpdating(false);
        }
    };

    /**
     * Asset Release Protocol: Finalizes the item lifecycle by capturing 
     * receiver identity and physical proof (photo evidence).
     */
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
            
            alert("Digital asset release completed. Audit trail secured.");
            setShowHandoverModal(false);
            navigate('/admin-reports');
        } catch (err) {
            alert("Handover processing failed. Evidence capture mismatch.");
        } finally {
            setIsUpdating(false);
        }
    };

    /**
     * Adjudication: Approve forensic claim. Resolves item and triggers match cleanup.
     */
    const handleApproveClaim = async () => {
        if (!item.claimId) return;
        setIsUpdating(true);
        try {
            await api.put('Claim/update-status', { claimId: item.claimId, status: 3 }); // VerificationSucceeded
            alert("Legitimate claim APPROVED. Proceed to official handover.");
            fetchDetails();
        } catch (err) { alert("Approval adjudication failed."); }
        finally { setIsUpdating(false); }
    };

    /**
     * Adjudication: Reject fraudulent or insufficient claims.
     */
    const handleRejectClaim = async () => {
        if (!item.claimId) return;
        
        const reason = window.prompt("REJECTION REASON (Visible to User):", "Provided proof does not match physical item attributes.");
        if (reason === null) return;

        setIsUpdating(true);
        try {
            await api.put('Claim/update-status', { 
                claimId: item.claimId, 
                status: 2, 
                rejectionReason: reason || "Your claim was not approved by the administrator."
            });
            alert("Claim REJECTED. Match record decoupled.");
            fetchDetails();
        } catch (err) { alert("Rejection protocol failed."); }
        finally { setIsUpdating(false); }
    };

    const handleDelete = async () => {
        if (window.confirm("PERMANENTLY expunge this case file? This cannot be undone.")) {
            try {
                await api.delete(`Item/${id}`);
                navigate('/admin-reports');
            } catch (err) { alert("Case deletion failed."); }
        }
    };

    if (loading) return <div style={{ padding: '5rem', textAlign: 'center', fontWeight: '800', color: '#64748b' }}>Decrypting Forensic Case File...</div>;
    if (error) return <div style={{ padding: '5rem', textAlign: 'center', color: '#ef4444', fontWeight: '700' }}>{error}</div>;

    const isFoundItem = isFound(item.reportType);

    return (
        <div className="dashboard-container">
            <Sidebar isAdmin={true} />

            <main className="main-content" style={{ background: '#f8fafc', padding: '2.5rem' }}>
                <div style={{ maxWidth: '1200px', margin: '0 auto' }}>
                    
                    {/* MODAL: OFFICIAL ASSET RELEASE FORM (AUDIT GATE) */}
                    {showHandoverModal && (
                        <div style={{ position: 'fixed', inset: 0, background: 'rgba(15, 23, 42, 0.8)', backdropFilter: 'blur(8px)', zIndex: 1000, display: 'flex', alignItems: 'center', justifyContent: 'center', padding: '2rem' }}>
                            <div className="animate-fade-in" style={{ background: '#fff', borderRadius: '32px', width: '100%', maxWidth: '700px', overflow: 'hidden', boxShadow: '0 25px 50px -12px rgba(0,0,0,0.5)' }}>
                                <div style={{ background: '#0d9488', color: '#fff', padding: '2rem', display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
                                    <div>
                                        <h2 style={{ margin: 0, fontSize: '1.5rem', fontWeight: '900' }}>Official Handover Protocol</h2>
                                        <p style={{ margin: '4px 0 0 0', opacity: 0.8, fontSize: '0.85rem' }}>Synchronize physical release with administrative audit.</p>
                                    </div>
                                    <button onClick={() => setShowHandoverModal(false)} style={{ background: 'rgba(255,255,255,0.2)', border: 'none', color: '#fff', width: '40px', height: '40px', borderRadius: '50%', cursor: 'pointer' }}><X size={20}/></button>
                                </div>
                                <form onSubmit={handleHandoverSubmit} style={{ padding: '2.5rem' }}>
                                    <div style={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '1.5rem', marginBottom: '1.5rem' }}>
                                        <div>
                                            <label className="field-label">Receiver Full Name</label>
                                            <input required type="text" value={handoverData.receiverName} onChange={e => setHandoverData({...handoverData, receiverName: e.target.value})} className="custom-input" placeholder="e.g. Mudassar Sajid" />
                                        </div>
                                        <div>
                                            <label className="field-label">CNIC / Identity Number</label>
                                            <input required type="text" value={handoverData.receiverCnic} onChange={e => setHandoverData({...handoverData, receiverCnic: e.target.value})} className="custom-input" placeholder="35201-XXXXXXX-X" />
                                        </div>
                                    </div>

                                    <div style={{ marginBottom: '1.5rem' }}>
                                        <label className="field-label">Administrative Evidence Notes</label>
                                        <textarea value={handoverData.adminNotes} onChange={e => setHandoverData({...handoverData, adminNotes: e.target.value})} className="custom-input" style={{ minHeight: '80px', resize: 'vertical' }} placeholder="Items verified against original system description..." />
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
                                        {isUpdating ? 'Securing Evidence...' : <><Shield size={20}/> Complete Asset Release</>}
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
                                <Edit3 size={18} /> Modify Attributes
                            </button>
                        </div>
                    </div>

                    {/* COMPARISON ENGINE: ASSET VS CLAIM */}
                    <div style={{ display: 'grid', gridTemplateColumns: matchedItem ? '1fr 1fr' : '1fr', gap: '2rem', marginBottom: '2.5rem' }}>
                        
                        {/* THE PHYSICAL ASSET RECORD */}
                        <div style={{ background: '#fff', borderRadius: '32px', border: '1px solid #e2e8f0', overflow: 'hidden', boxShadow: '0 10px 25px -5px rgba(0,0,0,0.03)' }}>
                            <div style={{ height: '300px', background: '#f8fafc', position: 'relative', overflow: 'hidden', display: 'flex', alignItems: 'center', justifyContent: 'center' }}>
                                {item.imageUrl ? (
                                    <img src={`${API_BASE_URL}${item.imageUrl}`} alt="Original Evidence" style={{ width: '100%', height: '100%', objectFit: 'contain', background: '#000' }} />
                                ) : (
                                    <div style={{ textAlign: 'center', color: '#0d9488' }}>
                                        <div style={{ background: '#f0fdfa', width: '120px', height: '120px', borderRadius: '30px', display: 'flex', alignItems: 'center', justifyContent: 'center', margin: '0 auto 1.5rem' }}>
                                            {getIcon(item.type)}
                                        </div>
                                        <p style={{ fontWeight: '800', textTransform: 'uppercase', letterSpacing: '1px', fontSize: '0.75rem' }}>No Photo Attachment</p>
                                    </div>
                                )}
                                <div style={{ position: 'absolute', top: '20px', left: '20px', padding: '6px 16px', background: '#0d9488', color: '#fff', borderRadius: '100px', fontSize: '0.75rem', fontWeight: '900' }}>
                                    PHYSICAL ASSET IN OFFICE
                                </div>
                            </div>
                            
                            <div style={{ padding: '2rem' }}>
                                <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'flex-start', marginBottom: '1.5rem' }}>
                                    <div>
                                        <h3 style={{ margin: 0, fontSize: '1.25rem', fontWeight: '900', color: '#1e293b' }}>Verified Attributes</h3>
                                        <p style={{ margin: '4px 0 0 0', fontSize: '0.85rem', color: '#64748b' }}>Technical specifications for matching.</p>
                                    </div>
                                    <span style={{ padding: '4px 12px', background: '#f0fdf4', color: '#10b981', borderRadius: '100px', fontSize: '0.7rem', fontWeight: '900' }}>VERIFIED</span>
                                </div>

                                <div style={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '1rem' }}>
                                    {(item.attributes || item.Attributes || []).map((attr, idx) => (
                                        <div key={idx} style={{ padding: '0.75rem', background: '#f8fafc', borderRadius: '12px', border: '1px solid #f1f5f9' }}>
                                            <div style={{ fontSize: '0.65rem', fontWeight: '800', color: '#94a3b8', textTransform: 'uppercase', marginBottom: '2px' }}>{attr.fieldName || attr.FieldName}</div>
                                            <div style={{ fontWeight: '700', color: '#334155', fontSize: '0.9rem' }}>{attr.fieldValue || attr.FieldValue}</div>
                                        </div>
                                    ))}
                                </div>
                            </div>
                        </div>

                        {/* COUNTERPART: STUDENT'S CLAIM */}
                        {matchedItem ? (
                            <div style={{ background: '#fff', borderRadius: '32px', border: '1px solid #fee2e2', overflow: 'hidden', boxShadow: '0 10px 25px -5px rgba(239, 68, 68, 0.05)' }}>
                                <div style={{ height: '300px', background: '#fef2f2', display: 'flex', flexDirection: 'column', alignItems: 'center', justifyContent: 'center', color: '#ef4444', padding: '2rem', textAlign: 'center' }}>
                                    <ShieldCheck size={80} style={{ opacity: 0.2, marginBottom: '1rem' }} />
                                    <div style={{ padding: '6px 16px', background: '#ef4444', color: '#fff', borderRadius: '100px', fontSize: '0.75rem', fontWeight: '900' }}>
                                        ACTIVE OWNERSHIP CLAIM
                                    </div>
                                    <h2 style={{ color: '#1e293b', fontWeight: '900', marginTop: '1.5rem', marginBottom: '4px' }}>{item.claimantName || "Requester"}</h2>
                                    <p style={{ color: '#64748b', fontSize: '0.85rem' }}><Mail size={12} /> {item.claimantEmail}</p>
                                </div>

                                <div style={{ padding: '2rem' }}>
                                    <div style={{ marginBottom: '1.25rem' }}>
                                        <h3 style={{ margin: 0, fontSize: '1.25rem', fontWeight: '900', color: '#1e293b' }}>Proof Narrative</h3>
                                    </div>

                                    {item.claimDescription ? (
                                        <div style={{ padding: '1.5rem', background: '#fff5f5', border: '1px solid #fee2e2', borderRadius: '20px', color: '#475569', fontSize: '0.95rem', lineHeight: '1.6', fontStyle: 'italic', position: 'relative', marginBottom: '2rem' }}>
                                            <div style={{ position: 'absolute', top: '-12px', left: '20px', background: '#ef4444', color: 'white', padding: '2px 10px', borderRadius: '4px', fontSize: '0.6rem', fontWeight: '900' }}>LEGACY PROOF</div>
                                            "{item.claimDescription}"
                                        </div>
                                    ) : (
                                        <div style={{ padding: '1.5rem', background: '#f8fafc', borderRadius: '20px', textAlign: 'center', color: '#94a3b8', marginBottom: '2rem' }}>
                                            <AlertCircle size={32} style={{ marginBottom: '0.5rem' }} />
                                            <p style={{ fontWeight: '700' }}>Missing ownership narrative.</p>
                                        </div>
                                    )}

                                    <h4 style={{ fontSize: '0.75rem', fontWeight: '800', color: '#64748b', textTransform: 'uppercase', marginBottom: '1rem' }}>Lost Case Comparison</h4>
                                    <div style={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '1rem' }}>
                                        {(matchedItem.attributes || matchedItem.Attributes || []).map((attr, idx) => (
                                            <div key={idx} style={{ padding: '0.75rem', background: '#fff', borderRadius: '12px', border: '1px solid #fee2e2' }}>
                                                <div style={{ fontSize: '0.65rem', fontWeight: '800', color: '#ef4444', textTransform: 'uppercase', marginBottom: '2px' }}>{attr.fieldName || attr.FieldName}</div>
                                                <div style={{ fontWeight: '700', color: '#334155', fontSize: '0.9rem' }}>{attr.fieldValue || attr.FieldValue}</div>
                                            </div>
                                        ))}
                                    </div>
                                    
                                    <div style={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '1rem', marginTop: '2.5rem' }}>
                                        <button onClick={handleApproveClaim} style={{ padding: '1rem', borderRadius: '16px', background: '#3b82f6', color: '#fff', border: 'none', fontWeight: '900', cursor: 'pointer', display: 'flex', alignItems: 'center', justifyContent: 'center', gap: '8px', boxShadow: '0 4px 12px rgba(59, 130, 246, 0.3)' }}>
                                            <CheckCircle2 size={20} /> Verify & Approve
                                        </button>
                                        <button onClick={handleRejectClaim} style={{ padding: '1rem', borderRadius: '16px', background: '#fff', color: '#ef4444', border: '2px solid #fee2e2', fontWeight: '900', cursor: 'pointer', display: 'flex', alignItems: 'center', justifyContent: 'center', gap: '8px' }}>
                                            <X size={20} /> Deny Claim
                                        </button>
                                    </div>
                                </div>
                            </div>
                        ) : (
                            <div style={{ background: '#fff', borderRadius: '32px', border: '1px solid #e2e8f0', padding: '3rem', textAlign: 'center', display: 'flex', flexDirection: 'column', alignItems: 'center', justifyContent: 'center' }}>
                                <RefreshCw size={48} className="animate-spin" color="#cbd5e0" style={{ marginBottom: '1.5rem', animationDuration: '3s' }} />
                                <h3 style={{ margin: 0, color: '#475569', fontWeight: '800' }}>Listening for Claims...</h3>
                                <p style={{ color: '#94a3b8', maxWidth: '300px', marginTop: '8px' }}>The comparison engine will activate automatically once a student submits identity proof for this match.</p>
                                
                                {isFoundItem && !(item.isVerifiedByAdmin || item.IsVerifiedByAdmin) && (
                                    <button 
                                        onClick={handleVerifyReceipt}
                                        style={{ marginTop: '2.5rem', padding: '1.25rem 2.5rem', borderRadius: '16px', border: 'none', background: '#0d9488', color: '#fff', fontWeight: '900', cursor: 'pointer', display: 'flex', alignItems: 'center', gap: '8px', boxShadow: '0 10px 20px -5px rgba(13, 148, 136, 0.4)' }}
                                    >
                                        <Shield size={20} /> Verify Custody
                                    </button>
                                )}
                            </div>
                        )}
                    </div>

                    {/* ACTION DOCK */}
                    <div style={{ background: '#1e293b', borderRadius: '24px', padding: '1.5rem', display: 'flex', justifyContent: 'space-between', alignItems: 'center', boxShadow: '0 20px 25px -5px rgba(0,0,0,0.1)' }}>
                         <div style={{ display: 'flex', gap: '2rem' }}>
                            <div>
                                <div style={{ fontSize: '0.65rem', fontWeight: '800', color: '#94a3b8', textTransform: 'uppercase' }}>Reporter Identity</div>
                                <div style={{ fontWeight: '700', color: '#fff' }}>{item.reporterName}</div>
                            </div>
                            <div style={{ width: '1px', background: 'rgba(255,255,255,0.1)' }} />
                            <div>
                                <div style={{ fontSize: '0.65rem', fontWeight: '800', color: '#94a3b8', textTransform: 'uppercase' }}>Submission Audit Date</div>
                                <div style={{ fontWeight: '700', color: '#fff' }}>{new Date(item.createdOn).toLocaleDateString(undefined, { dateStyle: 'long' })}</div>
                            </div>
                         </div>

                         <div style={{ display: 'flex', gap: '1rem' }}>
                              {isFoundItem && (item.isVerifiedByAdmin || item.IsVerifiedByAdmin) && (item.status === 1 || item.Status === 1) && (
                                 <button onClick={handleMoveToAuction} className="action-button-orange" style={{ padding: '0.75rem 1.5rem', borderRadius: '12px', background: '#ea580c', color: '#fff', border: 'none', fontWeight: '800', cursor: 'pointer', display: 'flex', alignItems: 'center', gap: '8px' }}>
                                    <Gavel size={18} /> Move to Auction
                                 </button>
                             )}
                             {isFoundItem && (item.isVerifiedByAdmin || item.IsVerifiedByAdmin) && (
                                 <button onClick={() => setShowHandoverModal(true)} style={{ padding: '0.75rem 1.5rem', borderRadius: '12px', background: '#3b82f6', color: '#fff', border: 'none', fontWeight: '800', cursor: 'pointer', display: 'flex', alignItems: 'center', gap: '8px' }}>
                                    <Package size={18} /> Official Handover
                                 </button>
                             )}
                             <button onClick={handleDelete} style={{ width: '42px', height: '42px', borderRadius: '12px', background: 'rgba(239, 68, 68, 0.1)', border: '1px solid rgba(239, 68, 68, 0.2)', color: '#ef4444', cursor: 'pointer', display: 'flex', alignItems: 'center', justifyContent: 'center' }}>
                                 <Trash2 size={18} />
                             </button>
                         </div>
                    </div>
                </div>
            </main>
        </div>
    );
};

export default AdminReportControl;
