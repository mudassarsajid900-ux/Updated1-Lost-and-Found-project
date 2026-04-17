import React, { useState, useEffect } from 'react';
import { 
    Shield, Search, Eye, Trash2, Hash, MapPin, CheckCircle2, AlertCircle, RefreshCw, User, 
    Smartphone, Wallet, Laptop, Briefcase, Watch, FileText, Gem, Headphones, Box 
} from 'lucide-react';
import { useNavigate } from 'react-router-dom';
import Sidebar from '../components/Sidebar';
import api from '../api/axios';

const API_BASE_URL = import.meta.env.VITE_API_BASE_URL || 'http://localhost:5197';

const AdminInventory = () => {
    const navigate = useNavigate();
    const [reports, setReports] = useState([]);
    const [loading, setLoading] = useState(true);
    const [activeTab, setActiveTab] = useState('lost');
    const [searchTerm, setSearchTerm] = useState('');
    
    const [page, setPage] = useState(0);
    const pageSize = 10;
    const [totalRecords, setTotalRecords] = useState(0);
    const [counts, setCounts] = useState({ lost: 0, found: 0, match: 0 });

    const fetchItems = async () => {
        setLoading(true);
        try {
            const start = page * pageSize;
            const searchParam = searchTerm ? `&search=${encodeURIComponent(searchTerm)}` : '';
            const res = await api.get(`Item/get-all?start=${start}&length=${pageSize}&tab=${activeTab}${searchParam}`);
            const d = res.data.data || res.data.Data || {};
            
            setReports(d.items || d.Items || []);
            setTotalRecords(d.total || d.Total || 0);

            setCounts({
                lost: d.lostCount || d.LostCount || 0,
                found: d.foundCount || d.FoundCount || 0,
                match: d.matchCount || d.MatchCount || d.matchingCount || d.MatchingCount || 0
            });
        } catch (err) {
            console.error("Failed to load global inventory", err);
        } finally {
            setLoading(false);
        }
    };

    useEffect(() => {
        const timer = setTimeout(() => {
            fetchItems();
        }, 300); // Debounce search
        return () => clearTimeout(timer);
    }, [page, activeTab, searchTerm]);

    const isLostReport = (v) => v === 0 || String(v).toLowerCase() === 'lost' || String(v) === '0';
    const isFoundReport = (v) => v === 1 || String(v).toLowerCase() === 'found' || String(v) === '1';

    const getIcon = (type) => {
        const t = (type || "").toLowerCase();
        if (t.includes('device') || t.includes('phone') || t.includes('mobile')) return <Smartphone size={20} />;
        if (t.includes('wallet')) return <Wallet size={20} />;
        if (t.includes('hardware') || t.includes('laptop') || t.includes('computing')) return <Laptop size={20} />;
        if (t.includes('luggage') || t.includes('bag')) return <Briefcase size={20} />;
        if (t.includes('timepiece') || t.includes('watch')) return <Watch size={20} />;
        if (t.includes('documentation') || t.includes('passport') || t.includes('id')) return <FileText size={20} />;
        if (t.includes('jewelry') || t.includes('valuables')) return <Gem size={20} />;
        if (t.includes('audio') || t.includes('earphone') || t.includes('headphone')) return <Headphones size={20} />;
        return <Box size={20} />;
    };

    const getStatusTheme = (item) => {
        const s = item.status ?? item.Status;
        if (s === 4 || s === 'Handover') return { text: 'Delivered', color: '#0d9488', bg: '#f0fdfa' };
        if (s === 3 || s === 'Auction') return { text: 'Auction Pool', color: '#ea580c', bg: '#fff7ed' };
        if (s === 2 || s === 'Replacement') return { text: 'Replacement', color: '#6366f1', bg: '#eef2ff' };
        
        if (isLostReport(item.reportType ?? item.ReportType)) {
            return { text: 'Lost Report', color: '#ef4444', bg: '#fef2f2' };
        }
        return { text: 'Found Item', color: '#3b82f6', bg: '#eff6ff' };
    };

    const handleDeleteItem = async (e, id) => {
        if (e) {
            e.preventDefault();
            e.stopPropagation();
        }
        
        const confirmed = window.confirm("Are you sure you want to PERMANENTLY delete this report? This cannot be undone.");
        if (!confirmed) return;

        try {
            await api.delete(`Item/${id}`);
            setReports(prev => prev.filter(r => (r.id || r.Id) !== id));
            alert("Report deleted successfully.");
        } catch (err) {
            console.error("Delete failed for ID " + id + ":", err);
            const errorMsg = err.response?.data?.message || err.message || "Unknown error";
            alert("Failed to delete report: " + errorMsg);
        }
    };

    const filteredReports = reports.filter(item => {
        const matchesSearch = (item.type || item.Type || "").toLowerCase().includes(searchTerm.toLowerCase()) || 
                              (item.reporterName || item.ReporterName || "").toLowerCase().includes(searchTerm.toLowerCase()) ||
                              (item.locationName || item.LocationName || "").toLowerCase().includes(searchTerm.toLowerCase());
        return matchesSearch;
    });

    return (
        <div className="dashboard-container">
            <Sidebar isAdmin={true} />

            <main className="main-content" style={{ background: '#f8fafc', padding: '2.5rem' }}>
                <div style={{ maxWidth: '1300px', margin: '0 auto' }}>
                    
                    {/* Header Section */}
                    <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'flex-start', marginBottom: '2.5rem' }}>
                        <div>
                            <div style={{ display: 'flex', alignItems: 'center', gap: '8px', color: '#3b82f6', fontWeight: '800', fontSize: '0.85rem', textTransform: 'uppercase', letterSpacing: '0.05em', marginBottom: '4px' }}>
                                <Shield size={14} /> Master Inventory Module
                            </div>
                            <h1 style={{ margin: 0, fontSize: '2.2rem', fontWeight: '900', color: '#1e293b', letterSpacing: '-0.02em' }}>Audit reports</h1>
                            <p style={{ margin: '4px 0 0 0', color: '#64748b', fontSize: '1rem' }}>Global administrative view of all reports and system assets.</p>
                        </div>
                        
                        <div style={{ display: 'flex', gap: '1rem' }}>
                            <div style={{ position: 'relative' }}>
                                <Search style={{ position: 'absolute', left: '12px', top: '50%', transform: 'translateY(-50%)', color: '#94a3b8' }} size={18} />
                                <input 
                                    type="text" 
                                    placeholder="Search global records..." 
                                    value={searchTerm}
                                    onChange={(e) => setSearchTerm(e.target.value)}
                                    style={{ padding: '0.75rem 1rem 0.75rem 2.5rem', borderRadius: '12px', border: '1px solid #e2e8f0', width: '300px', outline: 'none', transition: 'all 0.2s', fontSize: '0.9rem', boxShadow: '0 2px 4px rgba(0,0,0,0.02)' }}
                                />
                            </div>
                        </div>
                    </div>

                    {/* Tab Selection */}
                    <div style={{ display: 'flex', gap: '1.5rem', marginBottom: '2rem' }}>
                        <button 
                            onClick={() => { setActiveTab('lost'); setPage(0); }}
                            style={{ 
                                flex: 1, padding: '1rem 1.5rem', borderRadius: '16px', border: 'none', cursor: 'pointer',
                                background: activeTab === 'lost' ? '#3b82f6' : '#fff',
                                color: activeTab === 'lost' ? '#fff' : '#64748b',
                                transition: 'all 0.2s', boxShadow: '0 4px 12px rgba(59, 130, 246, 0.1)',
                                display: 'flex', alignItems: 'center', justifyContent: 'center', gap: '12px'
                            }}
                        >
                            <AlertCircle size={20} />
                            <div style={{ textAlign: 'left' }}>
                                <div style={{ fontSize: '0.75rem', fontWeight: '800', opacity: 0.8 }}>LOST REPORTS</div>
                                <div style={{ fontSize: '1.2rem', fontWeight: '900' }}>{counts.lost} Records</div>
                            </div>
                        </button>
                        <button 
                            onClick={() => { setActiveTab('found'); setPage(0); }}
                            style={{ 
                                flex: 1, padding: '1rem 1.5rem', borderRadius: '16px', border: 'none', cursor: 'pointer',
                                background: activeTab === 'found' ? '#0d9488' : '#fff',
                                color: activeTab === 'found' ? '#fff' : '#64748b',
                                transition: 'all 0.2s', boxShadow: '0 4px 12px rgba(13, 148, 136, 0.1)',
                                display: 'flex', alignItems: 'center', justifyContent: 'center', gap: '12px'
                            }}
                        >
                            <CheckCircle2 size={20} />
                            <div style={{ textAlign: 'left' }}>
                                <div style={{ fontSize: '0.75rem', fontWeight: '800', opacity: 0.8 }}>FOUND RECORDS</div>
                                <div style={{ fontSize: '1.2rem', fontWeight: '900' }}>{counts.found} Items</div>
                            </div>
                        </button>
                        <button 
                            onClick={() => { setActiveTab('matching'); setPage(0); }}
                            style={{ 
                                flex: 1, padding: '1rem 1.5rem', borderRadius: '16px', border: 'none', cursor: 'pointer',
                                background: activeTab === 'matching' ? '#8b5cf6' : '#fff',
                                color: activeTab === 'matching' ? '#fff' : '#64748b',
                                transition: 'all 0.2s', boxShadow: '0 4px 12px rgba(139, 92, 246, 0.1)',
                                display: 'flex', alignItems: 'center', justifyContent: 'center', gap: '12px'
                            }}
                        >
                            <RefreshCw size={20} />
                            <div style={{ textAlign: 'left' }}>
                                <div style={{ fontSize: '0.75rem', fontWeight: '800', opacity: 0.8 }}>MATCHING ITEMS</div>
                                <div style={{ fontSize: '1.2rem', fontWeight: '900' }}>{counts.match} Detected</div>
                            </div>
                        </button>
                    </div>

                    {/* LIST VIEW (Table) */}
                    <div style={{ background: '#fff', borderRadius: '24px', border: '1px solid #e2e8f0', overflow: 'hidden', boxShadow: '0 10px 25px -5px rgba(0,0,0,0.03)' }}>
                        {loading ? (
                            <div style={{ textAlign: 'center', padding: '5rem' }}>
                                <div className="spinner"></div>
                                <p style={{ color: '#64748b', fontWeight: '700', marginTop: '1rem' }}>Fetching Records...</p>
                            </div>
                        ) : filteredReports.length === 0 ? (
                            <div style={{ padding: '5rem', textAlign: 'center' }}>
                                <Box size={48} color="#cbd5e0" style={{ marginBottom: '1rem' }} />
                                <h3 style={{ margin: 0, color: '#475569' }}>No reports matching criteria</h3>
                                <p style={{ color: '#94a3b8' }}>Update your search or check another tab.</p>
                            </div>
                        ) : (
                            <table style={{ width: '100%', borderCollapse: 'collapse', textAlign: 'left' }}>
                                <thead>
                                    <tr style={{ background: '#f8fafc', borderBottom: '1px solid #e2e8f0' }}>
                                        <th style={{ padding: '1.25rem 1.5rem', color: '#64748b', fontSize: '0.75rem', fontWeight: '800', textTransform: 'uppercase' }}>ID / Type</th>
                                        <th style={{ padding: '1.25rem 1.5rem', color: '#64748b', fontSize: '0.75rem', fontWeight: '800', textTransform: 'uppercase' }}>Reporter</th>
                                        <th style={{ padding: '1.25rem 1.5rem', color: '#64748b', fontSize: '0.75rem', fontWeight: '800', textTransform: 'uppercase' }}>Location & Time</th>
                                        <th style={{ padding: '1.25rem 1.5rem', color: '#64748b', fontSize: '0.75rem', fontWeight: '800', textTransform: 'uppercase' }}>Status</th>
                                        <th style={{ padding: '1.25rem 1.5rem', color: '#64748b', fontSize: '0.75rem', fontWeight: '800', textTransform: 'uppercase', textAlign: 'right' }}>Actions</th>
                                    </tr>
                                </thead>
                                <tbody>
                                    {filteredReports.map((item, index) => {
                                        const theme = getStatusTheme(item);
                                        const itemId = item.id || item.Id;
                                        
                                        // SPECIAL RENDER FOR MATCHING TAB: Side-by-Side Pair View
                                        if (activeTab === 'matching') {
                                            const matchedWithId = item.matchFoundItemId || item.MatchFoundItemId;
                                            
                                            // Fallback fetching is an exercise for the frontend if the full object isn't in 'reports' 
                                            // We will gently bypass the Searching bug by not crashing.
                                            let claimantName = item.matchReporterName || item.MatchReporterName || item.claimantName || "Student";
                                            let lostTypeText = item.matchItemType || item.MatchItemType || "Lost Item";
                                            
                                            return (
                                                <tr key={itemId} style={{ borderBottom: '1px solid #f1f5f9', transition: 'all 0.2s' }} className="table-row-hover">
                                                    <td colSpan={5} style={{ padding: '1.25rem 1.5rem' }}>
                                                        <div style={{ display: 'flex', alignItems: 'center', justifyContent: 'space-between', gap: '2rem' }}>
                                                            {/* FOUND ITEM (OFFICE SIDE) */}
                                                            <div style={{ flex: 1, display: 'flex', gap: '1rem', alignItems: 'center', background: '#f8fafc', padding: '1rem', borderRadius: '16px', border: '1px solid #e2e8f0' }}>
                                                                <div style={{ width: '50px', height: '50px', borderRadius: '12px', overflow: 'hidden', background: '#fff', border: '1px solid #cbd5e0' }}>
                                                                    {item.imageUrl ? (
                                                                        <img src={`${API_BASE_URL}${item.imageUrl}`} alt="" style={{ width: '100%', height: '100%', objectFit: 'cover' }} />
                                                                    ) : (
                                                                        <div style={{ height: '100%', display: 'flex', alignItems: 'center', justifyContent: 'center', color: '#319795' }}>{getIcon(item.type)}</div>
                                                                    )}
                                                                </div>
                                                                <div>
                                                                    <div style={{ fontSize: '0.75rem', fontWeight: '800', color: '#0d9488' }}>FOUND ITEM #{itemId}</div>
                                                                    <div style={{ fontWeight: '900', color: '#1e293b' }}>{item.type || item.Type}</div>
                                                                    <div style={{ fontSize: '0.75rem', color: '#64748b' }}><MapPin size={10} /> {item.locationName || "Campus Office"}</div>
                                                                </div>
                                                            </div>

                                                            {/* MATCH STATUS BRIDGE */}
                                                            <div style={{ display: 'flex', flexDirection: 'column', alignItems: 'center', gap: '4px', minWidth: '150px', position: 'relative' }}>
                                                                <div style={{ padding: '4px 12px', background: (item.activeClaimCount > 1 || item.ActiveClaimCount > 1) ? '#f59e0b' : '#8b5cf6', color: '#fff', borderRadius: '100px', fontSize: '0.65rem', fontWeight: '900' }}>
                                                                    {(item.activeClaimCount > 1 || item.ActiveClaimCount > 1) ? 'VULNERABLE (MULTI-CLAIM)' : 'POTENTIAL MATCH'}
                                                                </div>
                                                                {(item.activeClaimCount > 1 || item.ActiveClaimCount > 1) && (
                                                                    <div style={{ position: 'absolute', top: '-10px', right: '-10px', background: '#f59e0b', color: '#fff', width: '20px', height: '20px', borderRadius: '50%', display: 'flex', alignItems: 'center', justifyContent: 'center' }}>
                                                                        <AlertCircle size={10} />
                                                                    </div>
                                                                )}
                                                                <div style={{ width: '100%', height: '2px', background: 'linear-gradient(to right, #0d9488, #8b5cf6, #ef4444)', margin: '4px 0' }} />
                                                                <div style={{ display: 'flex', alignItems: 'center', gap: '4px', color: '#64748b', fontSize: '0.7rem', fontWeight: '700' }}>
                                                                    <RefreshCw size={12} className="animate-spin" style={{ animationDuration: '3s' }} /> Verified by Admin
                                                                </div>
                                                            </div>

                                                            {/* LOST ITEM (CLAIMANT SIDE) */}
                                                            <div style={{ flex: 1, display: 'flex', gap: '1rem', alignItems: 'center', background: '#fef2f2', padding: '1rem', borderRadius: '16px', border: '1px solid #fee2e2' }}>
                                                                <div style={{ flex: 1 }}>
                                                                    <div style={{ fontSize: '0.75rem', fontWeight: '800', color: '#ef4444', textAlign: 'right' }}>LOST REPORT #{matchedWithId}</div>
                                                                    <div style={{ fontWeight: '900', color: '#1e293b', textAlign: 'right' }}>{lostTypeText}</div>
                                                                    <div style={{ fontSize: '0.75rem', color: '#64748b', textAlign: 'right' }}>Owner: <b>{claimantName}</b></div>
                                                                </div>
                                                                <div style={{ width: '50px', height: '50px', borderRadius: '12px', background: '#fff', border: '1px solid #fee2e2', display: 'flex', alignItems: 'center', justifyContent: 'center', color: '#ef4444' }}>
                                                                    <User size={24} />
                                                                </div>
                                                            </div>

                                                            {/* ACTION BUTTONS */}
                                                            <div style={{ display: 'flex', gap: '0.5rem' }}>
                                                                <button 
                                                                    onClick={() => navigate(`/admin-report-control/${itemId}`)}
                                                                    style={{ padding: '0.75rem 1.25rem', borderRadius: '12px', background: '#1e293b', color: 'white', border: 'none', fontWeight: '800', fontSize: '0.8rem', cursor: 'pointer', display: 'flex', alignItems: 'center', gap: '8px', boxShadow: '0 4px 6px rgba(0,0,0,0.1)' }}
                                                                >
                                                                    <Eye size={16} /> Review Claim
                                                                </button>
                                                                <button 
                                                                    onClick={(e) => handleDeleteItem(e, itemId)}
                                                                    style={{ width: '42px', height: '42px', borderRadius: '12px', background: '#fff', border: '1px solid #fee2e2', color: '#ef4444', cursor: 'pointer', display: 'flex', alignItems: 'center', justifyContent: 'center' }}
                                                                >
                                                                    <Trash2 size={18} />
                                                                </button>
                                                            </div>
                                                        </div>
                                                    </td>
                                                </tr>
                                            );
                                        }

                                        // STANDARD RENDER FOR LOST/FOUND TABS
                                        const eventDate = new Date(item.eventTime || item.EventTime).toLocaleDateString();
                                        const reportDate = new Date(item.createdOn || item.CreatedOn || Date.now()).toLocaleDateString();

                                        return (
                                            <tr key={itemId} style={{ borderBottom: '1px solid #f1f5f9', transition: 'all 0.2s' }} className="table-row-hover">
                                                <td style={{ padding: '1.25rem 1.5rem' }}>
                                                    <div style={{ display: 'flex', alignItems: 'center', gap: '1rem' }}>
                                                        <div style={{ width: '40px', height: '40px', borderRadius: '10px', background: '#f0fdfa', display: 'flex', alignItems: 'center', justifyContent: 'center', color: '#319795' }}>
                                                            {getIcon(item.type)}
                                                        </div>
                                                        <div>
                                                            <div style={{ fontWeight: '800', color: '#1e293b' }}>{item.type || item.Type}</div>
                                                            <div style={{ fontSize: '0.7rem', color: '#94a3b8', fontWeight: '700' }}>RECORD #{itemId}</div>
                                                            {item.hasPotentialMatch && (
                                                                <div style={{ fontSize: '0.65rem', color: '#8b5cf6', fontWeight: '800', display: 'flex', alignItems: 'center', gap: '4px', marginTop: '2px' }}>
                                                                    <RefreshCw size={10} /> MATCHED WITH #{item.matchFoundItemId || item.MatchFoundItemId}
                                                                </div>
                                                            )}
                                                            {(item.activeClaimCount > 1 || item.ActiveClaimCount > 1) && (
                                                                <div style={{ fontSize: '0.65rem', color: '#ef4444', background: '#fef2f2', padding: '2px 6px', borderRadius: '4px', display: 'inline-flex', alignItems: 'center', gap: '4px', marginTop: '4px', fontWeight: '900', border: '1px solid #fee2e2' }}>
                                                                    <AlertCircle size={10} /> CONFLICT: {item.activeClaimCount || item.ActiveClaimCount} CLAIMS
                                                                </div>
                                                            )}
                                                        </div>
                                                    </div>
                                                </td>
                                                <td style={{ padding: '1.25rem 1.5rem' }}>
                                                    <div style={{ display: 'flex', alignItems: 'center', gap: '8px' }}>
                                                        <div style={{ width: '32px', height: '32px', borderRadius: '50%', background: '#e2e8f0', display: 'flex', alignItems: 'center', justifyContent: 'center', color: '#64748b', fontSize: '0.8rem', fontWeight: '800' }}>
                                                            {(item.reporterName || item.ReporterName || "U")[0]}
                                                        </div>
                                                        <div>
                                                            <div style={{ fontWeight: '700', color: '#1e293b', fontSize: '0.85rem' }}>{item.reporterName || item.ReporterName}</div>
                                                            <div style={{ fontSize: '0.7rem', color: '#94a3b8' }}>{reportDate}</div>
                                                        </div>
                                                    </div>
                                                </td>
                                                <td style={{ padding: '1.25rem 1.5rem' }}>
                                                    <div style={{ fontWeight: '700', color: '#1e293b', fontSize: '0.85rem' }}>{item.locationName || item.LocationName || "Campus Location"}</div>
                                                    <div style={{ fontSize: '0.7rem', color: '#94a3b8', display: 'flex', alignItems: 'center', gap: '4px' }}>
                                                        <MapPin size={10} /> Event: {eventDate}
                                                    </div>
                                                </td>
                                                <td style={{ padding: '1.25rem 1.5rem' }}>
                                                    <span style={{ 
                                                        display: 'inline-flex', alignItems: 'center', gap: '6px', padding: '4px 12px', borderRadius: '100px', fontSize: '0.75rem', fontWeight: '800', 
                                                        background: theme.bg, color: theme.color, border: `1px solid ${theme.color}20`
                                                    }}>
                                                        {(item.isVerifiedByAdmin || item.IsVerifiedByAdmin) && (
                                                            <div style={{ width: '8px', height: '8px', borderRadius: '50%', background: '#10b981', flexShrink: 0 }} title="Physically Verified" />
                                                        )}
                                                        {theme.text}
                                                    </span>
                                                </td>
                                                <td style={{ padding: '1.25rem 1.5rem', textAlign: 'right' }}>
                                                    <div style={{ display: 'flex', gap: '0.5rem', justifyContent: 'flex-end' }}>
                                                        <button 
                                                            onClick={() => navigate(`/admin-report-control/${itemId}`)}
                                                            style={{ width: '36px', height: '36px', borderRadius: '10px', background: '#fff', border: '1px solid #e2e8f0', color: '#64748b', cursor: 'pointer', display: 'flex', alignItems: 'center', justifyContent: 'center' }}
                                                            title="Admin Control"
                                                        >
                                                            <Eye size={16} />
                                                        </button>
                                                        <button 
                                                            onClick={(e) => handleDeleteItem(e, itemId)}
                                                            style={{ width: '36px', height: '36px', borderRadius: '10px', background: '#fef2f2', border: '1px solid #fee2e2', color: '#ef4444', cursor: 'pointer', display: 'flex', alignItems: 'center', justifyContent: 'center' }}
                                                            title="Delete Record"
                                                        >
                                                            <Trash2 size={16} />
                                                        </button>
                                                    </div>
                                                </td>
                                            </tr>
                                        );
                                    })}
                                </tbody>
                            </table>
                        )}
                        
                        {/* PAGINATION CONTROLS */}
                        <div style={{ padding: '1.5rem', borderTop: '1px solid #e2e8f0', display: 'flex', justifyContent: 'space-between', alignItems: 'center', background: '#f8fafc' }}>
                            <div style={{ fontSize: '0.85rem', color: '#64748b', fontWeight: '600' }}>
                                Showing <span style={{ color: '#1e293b' }}>{filteredReports.length}</span> of <span style={{ color: '#1e293b' }}>{totalRecords}</span> Cases
                            </div>
                            <div style={{ display: 'flex', gap: '0.5rem' }}>
                                <button 
                                    disabled={page === 0}
                                    onClick={() => setPage(page - 1)}
                                    style={{ padding: '0.6rem 1.25rem', borderRadius: '10px', border: '1px solid #e2e8f0', background: page === 0 ? '#f1f5f9' : '#fff', color: page === 0 ? '#94a3b8' : '#1e293b', fontWeight: '700', cursor: page === 0 ? 'not-allowed' : 'pointer', fontSize: '0.85rem' }}
                                >
                                    Previous
                                </button>
                                <button 
                                    disabled={((page + 1) * pageSize) >= totalRecords}
                                    onClick={() => setPage(page + 1)}
                                    style={{ padding: '0.6rem 1.25rem', borderRadius: '10px', border: '1px solid #e2e8f0', background: ((page + 1) * pageSize) >= totalRecords ? '#f1f5f9' : '#fff', color: ((page + 1) * pageSize) >= totalRecords ? '#94a3b8' : '#1e293b', fontWeight: '700', cursor: ((page + 1) * pageSize) >= totalRecords ? 'not-allowed' : 'pointer', fontSize: '0.85rem' }}
                                >
                                    Next
                                </button>
                            </div>
                        </div>
                    </div>
                </div>

                <style dangerouslySetInnerHTML={{
                    __html: `
                    .table-row-hover:hover { background: #fdfdfd; }
                    .table-row-hover:hover td { background: rgba(59, 130, 246, 0.01); }
                    .spinner { border: 3px solid #f3f3f3; border-top: 3px solid #3b82f6; border-radius: 50%; width: 24px; height: 24px; animation: spin 1s linear infinite; margin: 0 auto; }
                    @keyframes spin { 0% { transform: rotate(0deg); } 100% { transform: rotate(360deg); } }
                    `
                }} />
            </main>
        </div>
    );
};

export default AdminInventory;
