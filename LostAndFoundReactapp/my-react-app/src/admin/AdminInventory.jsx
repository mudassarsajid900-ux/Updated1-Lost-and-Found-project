import React, { useState, useEffect } from 'react';
import { 
    Calendar, MapPin, Box, ArrowRight, Clock, User, 
    ChevronRight, ExternalLink, Trash2, Edit3, Shield, Info, Filter, Search,
    MoreVertical, AlertCircle, CheckCircle2, ListFilter, Eye, Hash, Mail
} from 'lucide-react';
import { useNavigate } from 'react-router-dom';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';
import api from '../api/axios';

const API_BASE_URL = import.meta.env.VITE_API_BASE_URL || 'http://localhost:5197';

const AdminInventory = () => {
    const navigate = useNavigate();
    const [reports, setReports] = useState([]);
    const [loading, setLoading] = useState(true);
    const [activeTab, setActiveTab] = useState('lost');
    const [searchTerm, setSearchTerm] = useState('');

    const fetchItems = async () => {
        setLoading(true);
        try {
            const res = await api.get('Item/get-all');
            setReports(res.data.data || []);
        } catch (err) {
            console.error("Failed to load global inventory", err);
        } finally {
            setLoading(false);
        }
    };

    useEffect(() => {
        fetchItems();
    }, []);

    const isLostReport = (v) => v === 0 || String(v).toLowerCase() === 'lost' || String(v) === '0';
    const isFoundReport = (v) => v === 1 || String(v).toLowerCase() === 'found' || String(v) === '1';

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
        
        console.log("Delete button clicked for ID:", id);
        
        const confirmed = window.confirm("Are you sure you want to PERMANENTLY delete this report? This cannot be undone.");
        if (!confirmed) {
            console.log("Delete cancelled by user.");
            return;
        }

        try {
            console.log("Proceeding with API delete request for ID:", id);
            const response = await api.delete(`Item/${id}`);
            console.log("API Response:", response.data);
            
            setReports(prev => prev.filter(r => r.id !== id));
            alert("Report deleted successfully.");
        } catch (err) {
            console.error("Delete failed for ID " + id + ":", err);
            const errorMsg = err.response?.data?.message || err.message || "Unknown error";
            alert("Failed to delete report: " + errorMsg);
        }
    };

    const filteredReports = reports.filter(item => {
        // Exclude items that are already handed over (Status 4), Replacement pool (Status 2), or Auction (Status 3)
        const iStatus = item.status ?? item.Status;
        if (iStatus === 2 || iStatus === 3 || iStatus === 4 || iStatus === 'Handover') return false;

        const matchesTab = activeTab === 'lost' ? isLostReport(item.reportType ?? item.ReportType) : isFoundReport(item.reportType ?? item.ReportType);
        const matchesSearch = (item.type || item.Type || "").toLowerCase().includes(searchTerm.toLowerCase()) || 
                              (item.reporterName || item.ReporterName || "").toLowerCase().includes(searchTerm.toLowerCase()) ||
                              (item.locationName || item.LocationName || "").toLowerCase().includes(searchTerm.toLowerCase());
        return matchesTab && matchesSearch;
    });

    const lostCount = reports.filter(item => {
        const iStatus = item.status ?? item.Status;
        return (iStatus !== 4 && iStatus !== 'Handover') && isLostReport(item.reportType ?? item.ReportType);
    }).length;
    
    const foundCount = reports.filter(item => {
        const iStatus = item.status ?? item.Status;
        return (iStatus !== 4 && iStatus !== 'Handover') && isFoundReport(item.reportType ?? item.ReportType);
    }).length;

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
                            onClick={() => setActiveTab('lost')}
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
                                <div style={{ fontSize: '1.2rem', fontWeight: '900' }}>{lostCount} Records</div>
                            </div>
                        </button>
                        <button 
                            onClick={() => setActiveTab('found')}
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
                                <div style={{ fontSize: '1.2rem', fontWeight: '900' }}>{foundCount} Items</div>
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
                                        const eventDate = new Date(item.eventTime || item.EventTime).toLocaleDateString();
                                        const reportDate = new Date(item.createdOn || item.CreatedOn || Date.now()).toLocaleDateString();
                                        const itemId = item.id || item.Id;

                                        return (
                                            <tr key={itemId} style={{ borderBottom: '1px solid #f1f5f9', transition: 'all 0.2s' }} className="table-row-hover">
                                                <td style={{ padding: '1.25rem 1.5rem' }}>
                                                    <div style={{ display: 'flex', alignItems: 'center', gap: '1rem' }}>
                                                        <div style={{ width: '40px', height: '40px', borderRadius: '10px', background: '#f1f5f9', display: 'flex', alignItems: 'center', justifyContent: 'center', color: '#64748b' }}>
                                                            <Hash size={18} />
                                                        </div>
                                                        <div>
                                                            <div style={{ fontWeight: '800', color: '#1e293b' }}>{item.type || item.Type}</div>
                                                            <div style={{ fontSize: '0.7rem', color: '#94a3b8', fontWeight: '700' }}>RECORD #{itemId}</div>
                                                        </div>
                                                    </div>
                                                </td>
                                                <td style={{ padding: '1.25rem 1.5rem' }}>
                                                    <div style={{ display: 'flex', alignItems: 'center', gap: '0.5rem', color: '#475569', fontWeight: '700', fontSize: '0.9rem' }}>
                                                        <User size={14} /> {item.reporterName || item.ReporterName || "Campus User"}
                                                    </div>
                                                    <div style={{ fontSize: '0.75rem', color: '#94a3b8', marginTop: '2px', display: 'flex', alignItems: 'center', gap: '4px' }}>
                                                        <Clock size={12} /> {reportDate}
                                                    </div>
                                                    <div style={{ fontSize: '0.7rem', color: '#6366f1', marginTop: '2px', display: 'flex', alignItems: 'center', gap: '4px', fontWeight: '800' }}>
                                                        <Mail size={12} /> {item.reporterEmail || "admin@gac.edu"}
                                                    </div>
                                                </td>
                                                <td style={{ padding: '1.25rem 1.5rem' }}>
                                                    <div style={{ fontSize: '0.9rem', color: '#475569', fontWeight: '600' }}>{item.locationName || item.LocationName}</div>
                                                    <div style={{ fontSize: '0.8rem', color: '#94a3b8', display: 'flex', alignItems: 'center', gap: '4px' }}>
                                                        <Calendar size={12} /> Event: {eventDate}
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
