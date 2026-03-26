import React, { useState, useEffect } from 'react';
import { useParams, useNavigate } from 'react-router-dom';
import { 
    ChevronLeft, Calendar, MapPin, Clock, Tag, User, Mail, Phone,
    Shield, CheckCircle2, AlertCircle, History, Package, Edit3, 
    Trash2, Save, X, ExternalLink, ArrowRight, Gavel, RefreshCw, Info
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
                setItem(res.data.data);
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

    const handleUpdateStatus = async (newStatus) => {
        setIsUpdating(true);
        try {
            // This is a generic status update
            await api.put(`Item/${id}`, { ...item, status: newStatus });
            alert(`Status updated to ${newStatus}`);
            fetchDetails();
        } catch (err) {
            alert("Failed to update status.");
        } finally {
            setIsUpdating(false);
        }
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
                                        <h2 style={{ margin: 0, fontSize: '1.5rem', fontWeight: '900' }}>Official Handover protocol</h2>
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
                            <button 
                                onClick={handleDelete}
                                style={{ padding: '0.75rem 1.5rem', borderRadius: '12px', border: 'none', background: '#fee2e2', color: '#ef4444', fontWeight: '700', cursor: 'pointer', display: 'flex', alignItems: 'center', gap: '8px' }}
                            >
                                <Trash2 size={18} /> Delete Case
                            </button>
                        </div>
                    </div>

                    <div style={{ display: 'grid', gridTemplateColumns: '1fr 350px', gap: '2rem' }}>
                        
                        {/* LEFT COLUMN: Item Evidence & Data */}
                        <div style={{ display: 'flex', flexDirection: 'column', gap: '2rem' }}>
                            
                            {/* Evidence Card */}
                            <div style={{ background: '#fff', borderRadius: '24px', border: '1px solid #e2e8f0', overflow: 'hidden' }}>
                                <div style={{ display: 'grid', gridTemplateColumns: '1fr 1fr', minHeight: '400px' }}>
                                    <div style={{ background: '#f1f5f9', display: 'flex', alignItems: 'center', justifyContent: 'center' }}>
                                        {item.imageUrl ? (
                                            <img src={`${API_BASE_URL}${item.imageUrl}`} style={{ width: '100%', height: '100%', objectFit: 'contain', padding: '1rem' }} alt="Evidence" />
                                        ) : (
                                            <div style={{ textAlign: 'center', color: '#94a3b8' }}>
                                                <Package size={64} style={{ marginBottom: '1rem' }} />
                                                <div style={{ fontWeight: '700' }}>No Visual Evidence</div>
                                            </div>
                                        )}
                                    </div>
                                    <div style={{ padding: '2.5rem' }}>
                                        <h2 style={{ fontSize: '1.25rem', fontWeight: '800', marginBottom: '1.5rem', color: '#1e293b', borderBottom: '2px solid #f1f5f9', paddingBottom: '0.75rem' }}>Case Details</h2>
                                        
                                        <div style={{ display: 'flex', flexDirection: 'column', gap: '1.25rem' }}>
                                            <div style={{ display: 'flex', justifyContent: 'space-between' }}>
                                                <span style={{ color: '#64748b', fontWeight: '600' }}>Category</span>
                                                <span style={{ fontWeight: '800', color: '#1e293b' }}>{item.type}</span>
                                            </div>
                                            <div style={{ display: 'flex', justifyContent: 'space-between' }}>
                                                <span style={{ color: '#64748b', fontWeight: '600' }}>Location</span>
                                                <span style={{ fontWeight: '800', color: '#1e293b' }}>{item.locationName}</span>
                                            </div>
                                            <div style={{ display: 'flex', justifyContent: 'space-between' }}>
                                                <span style={{ color: '#64748b', fontWeight: '600' }}>Event Date</span>
                                                <span style={{ fontWeight: '800', color: '#1e293b' }}>{new Date(item.eventTime).toLocaleDateString()}</span>
                                            </div>
                                            <div style={{ display: 'flex', justifyContent: 'space-between' }}>
                                                <span style={{ color: '#64748b', fontWeight: '600' }}>Status</span>
                                                <span style={{ padding: '4px 12px', borderRadius: '100px', background: (item.isVerifiedByAdmin || item.IsVerifiedByAdmin) ? '#d1fae5' : '#eff6ff', color: (item.isVerifiedByAdmin || item.IsVerifiedByAdmin) ? '#059669' : '#3b82f6', fontSize: '0.75rem', fontWeight: '900', textTransform: 'uppercase' }}>
                                                    {(item.isVerifiedByAdmin || item.IsVerifiedByAdmin) ? 'PHYSICALLY VERIFIED' : (item.status || item.Status || 'Reported Capture')}
                                                </span>
                                            </div>
                                        </div>

                                        <div style={{ marginTop: '2.5rem' }}>
                                            <h3 style={{ fontSize: '0.9rem', color: '#94a3b8', textTransform: 'uppercase', marginBottom: '1rem' }}>Additional Attributes</h3>
                                            <div style={{ display: 'grid', gap: '0.75rem' }}>
                                                {(item.attributes || item.Attributes || []).map((attr, idx) => {
                                                    const keyName = attr.fieldName || attr.FieldName;
                                                    const valName = attr.fieldValue || attr.FieldValue;
                                                    return (
                                                    <div key={idx} style={{ background: '#f8fafc', padding: '0.75rem 1rem', borderRadius: '12px', display: 'flex', justifyContent: 'space-between', alignItems: 'center', gap: '8px' }}>
                                                        <span style={{ fontSize: '0.85rem', color: '#64748b', minWidth: '100px' }}>{keyName}</span>
                                                        <span style={{ fontSize: '0.85rem', fontWeight: '700', color: '#1e293b' }}>{valName}</span>
                                                    </div>
                                                )})}
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                        {/* RIGHT COLUMN: Reporter Info & Status Control */}
                        <div style={{ display: 'flex', flexDirection: 'column', gap: '1.5rem' }}>
                            
                            {/* Reporter Identification */}
                            <div style={{ background: '#fff', borderRadius: '24px', border: '1px solid #e2e8f0', padding: '1.5rem' }}>
                                <div style={{ display: 'flex', alignItems: 'center', gap: '10px', marginBottom: '1.5rem' }}>
                                    <div style={{ background: '#eff6ff', color: '#3b82f6', width: '36px', height: '36px', borderRadius: '10px', display: 'flex', alignItems: 'center', justifyContent: 'center' }}>
                                        <User size={20} />
                                    </div>
                                    <h3 style={{ margin: 0, fontSize: '1.1rem', fontWeight: '800' }}>Reporter</h3>
                                </div>
                                
                                <div style={{ display: 'flex', flexDirection: 'column', gap: '1rem' }}>
                                    <div>
                                        <div style={{ fontSize: '0.75rem', color: '#94a3b8', fontWeight: '700', textTransform: 'uppercase' }}>Full Name</div>
                                        <div style={{ fontSize: '1rem', fontWeight: '700', color: '#1e293b' }}>{item.reporterName}</div>
                                    </div>
                                    <div>
                                        <div style={{ fontSize: '0.75rem', color: '#94a3b8', fontWeight: '700', textTransform: 'uppercase' }}>Email Address</div>
                                        <div style={{ fontSize: '0.9rem', color: '#475569', display: 'flex', alignItems: 'center', gap: '6px' }}><Mail size={14}/> {item.reporterEmail}</div>
                                    </div>
                                    <div>
                                        <div style={{ fontSize: '0.75rem', color: '#94a3b8', fontWeight: '700', textTransform: 'uppercase' }}>Contact Number</div>
                                        <div style={{ fontSize: '0.9rem', color: '#475569', display: 'flex', alignItems: 'center', gap: '6px' }}><Phone size={14}/> {item.reporterPhone}</div>
                                    </div>
                                    <div style={{ marginTop: '0.5rem', padding: '0.75rem', background: '#f8fafc', borderRadius: '12px', display: 'flex', alignItems: 'center', gap: '10px' }}>
                                        <Clock size={16} color="#94a3b8" />
                                        <div style={{ fontSize: '0.75rem', color: '#64748b' }}>
                                            Record Filed: <br/>
                                            <span style={{ fontWeight: '700' }}>{new Date(item.createdOn).toLocaleString()}</span>
                                        </div>
                                    </div>
                                </div>
                            </div>

                            {/* Status Workflow Control */}
                            <div style={{ background: '#fff', borderRadius: '24px', border: '1px solid #e2e8f0', padding: '1.5rem' }}>
                                <h3 style={{ margin: '0 0 1.5rem 0', fontSize: '1.1rem', fontWeight: '800', display: 'flex', alignItems: 'center', gap: '10px' }}>
                                    <RefreshCw size={20} color="#3b82f6" /> Status Control
                                </h3>
                                
                                <div style={{ display: 'grid', gap: '0.75rem' }}>
                                    {isFoundItem && !(item.isVerifiedByAdmin || item.IsVerifiedByAdmin) && (
                                        <button 
                                            onClick={handleVerifyReceipt}
                                            style={{ width: '100%', padding: '1rem', borderRadius: '12px', border: 'none', background: '#0d9488', color: '#fff', textAlign: 'left', fontWeight: '800', cursor: 'pointer', display: 'flex', justifyContent: 'space-between', alignItems: 'center', boxShadow: '0 4px 12px rgba(13, 148, 136, 0.2)' }}
                                        >
                                            Verify Physical Arrival <CheckCircle2 size={16} />
                                        </button>
                                    )}

                                    <button 
                                        disabled={isFoundItem && !(item.isVerifiedByAdmin || item.IsVerifiedByAdmin)}
                                        onClick={() => setShowHandoverModal(true)}
                                        style={{ width: '100%', padding: '0.75rem', borderRadius: '12px', border: 'none', background: '#3b82f6', color: '#fff', textAlign: 'left', fontWeight: '700', cursor: 'pointer', display: 'flex', justifyContent: 'space-between', alignItems: 'center', opacity: (isFoundItem && !(item.isVerifiedByAdmin || item.IsVerifiedByAdmin)) ? 0.5 : 1 }}
                                    >
                                        Initiate Handover <ArrowRight size={14} />
                                    </button>

                                </div>
                                {isFoundItem && !(item.isVerifiedByAdmin || item.IsVerifiedByAdmin) && (
                                    <p style={{ margin: '12px 0 0 0', fontSize: '0.75rem', color: '#64748b', fontStyle: 'italic', display: 'flex', gap: '6px' }}>
                                        <Info size={12}/> Matches remain invisible to users until you verify arrival.
                                    </p>
                                )}
                            </div>
                        </div>
                    </div>
                </div>
            </main>
        </div>
    );
};

export default AdminReportControl;
