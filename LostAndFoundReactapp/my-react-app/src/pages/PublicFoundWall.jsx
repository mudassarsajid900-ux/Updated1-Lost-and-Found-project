import React, { useState, useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import api from '../api/axios';
import { 
    Search, Calendar, MapPin, EyeOff, LayoutGrid, Package, ArrowRight
} from 'lucide-react';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';

const PublicFoundWall = () => {
    const navigate = useNavigate();
    const [loading, setLoading] = useState(true);
    const [foundItems, setFoundItems] = useState([]);
    const [searchTerm, setSearchTerm] = useState('');

    const API_BASE_URL = import.meta.env.VITE_API_BASE_URL;

    useEffect(() => {
        const fetchPublicItems = async () => {
            try {
                // Anonymous fetch
                const response = await api.get('Item/public-found');
                const data = response.data.data || response.data.Data || [];
                setFoundItems(data);
            } catch (err) {
                console.error('Failed to fetch public items:', err);
            } finally {
                setLoading(false);
            }
        };
        fetchPublicItems();
    }, []);

    const filteredItems = foundItems.filter(item => {
        const title = (item.type || item.Type || '').toLowerCase();
        const loc = (item.locationName || item.LocationName || '').toLowerCase();
        const s = searchTerm.toLowerCase();
        return title.includes(s) || loc.includes(s);
    });

    return (
        <div className="dashboard-container">
            <Sidebar />

            <main className="main-content" style={{ padding: '3rem', background: '#f8fafc', minHeight: '100vh' }}>
                <Header 
                    title="Public Found Items" 
                    subtitle="Browse items found across campus. For security, specific details are hidden." 
                />

                <div style={{
                    display: 'flex', gap: '1rem', alignItems: 'center', marginBottom: '2rem',
                    background: 'white', padding: '1rem', borderRadius: '16px', border: '1px solid #e2e8f0',
                    boxShadow: '0 4px 6px -1px rgba(0,0,0,0.05)'
                }}>
                    <Search color="#94a3b8" />
                    <input 
                        type="text" 
                        placeholder="Search by item type or location..."
                        value={searchTerm}
                        onChange={(e) => setSearchTerm(e.target.value)}
                        style={{ border: 'none', outline: 'none', width: '100%', fontSize: '1rem' }}
                    />
                </div>

                {loading ? (
                    <div style={{ display: 'grid', gridTemplateColumns: 'repeat(auto-fill, minmax(280px, 1fr))', gap: '1.5rem' }}>
                        {[1,2,3,4].map(i => <div key={i} style={{ height: '300px', background: '#e2e8f0', borderRadius: '20px', animation: 'pulse 2s infinite' }} />)}
                    </div>
                ) : filteredItems.length > 0 ? (
                    <div style={{ display: 'grid', gridTemplateColumns: 'repeat(auto-fill, minmax(280px, 1fr))', gap: '1.5rem' }}>
                        {filteredItems.map(item => {
                            const date = new Date(item.eventTime || item.EventTime).toLocaleDateString('en-US', { month: 'short', day: 'numeric' });
                            return (
                                <div key={item.id} style={{
                                    background: 'white', border: '1px solid #e2e8f0', borderRadius: '20px',
                                    overflow: 'hidden', transition: 'transform 0.2s', cursor: 'pointer',
                                    display: 'flex', flexDirection: 'column', boxShadow: '0 4px 6px -1px rgba(0,0,0,0.02)'
                                }}
                                onClick={() => navigate('/report-lost')}
                                onMouseOver={(e) => e.currentTarget.style.transform = 'translateY(-5px)'}
                                onMouseOut={(e) => e.currentTarget.style.transform = 'translateY(0)'}
                                >
                                    <div style={{ height: '180px', background: '#f1f5f9', display: 'flex', alignItems: 'center', justifyContent: 'center', position: 'relative' }}>
                                        {item.imageUrl ? (
                                            <img src={`${API_BASE_URL}${item.imageUrl}`} alt="" style={{ width: '100%', height: '100%', objectFit: 'cover' }} />
                                        ) : (
                                            <Package size={40} color="#cbd5e0" />
                                        )}
                                        {/* Privacy Blur Overlay */}
                                        <div style={{
                                            position: 'absolute', top: 0, left: 0, right: 0, bottom: 0,
                                            background: 'rgba(255,255,255,0.1)', backdropFilter: 'blur(8px)',
                                            display: 'flex', alignItems: 'center', justifyContent: 'center', flexDirection: 'column', gap: '0.5rem'
                                        }}>
                                            <div style={{ background: 'rgba(0,0,0,0.6)', color: 'white', padding: '8px 16px', borderRadius: '20px', display: 'flex', alignItems: 'center', gap: '8px', fontSize: '0.85rem', fontWeight: 'bold' }}>
                                                <EyeOff size={16} /> Details Hidden
                                            </div>
                                        </div>
                                    </div>
                                    <div style={{ padding: '1.25rem', display: 'flex', flexDirection: 'column', gap: '0.75rem', flex: 1 }}>
                                        <div style={{ display: 'flex', alignItems: 'center', justifyContent: 'space-between' }}>
                                            <h3 style={{ margin: 0, fontSize: '1.1rem', fontWeight: '800', color: '#1e293b', display: 'flex', alignItems: 'center', gap: '8px' }}>
                                                {item.type || item.Type}
                                                {(item.isVerifiedByAdmin || item.IsVerifiedByAdmin) && (
                                                    <div style={{ width: '8px', height: '8px', borderRadius: '50%', background: '#10b981', flexShrink: 0, boxShadow: '0 0 4px #10b981' }} title="Physically Verified & Secured by Admin" />
                                                )}
                                            </h3>
                                        </div>
                                        <div style={{ display: 'flex', alignItems: 'center', gap: '6px', color: '#64748b', fontSize: '0.85rem' }}>
                                            <MapPin size={14} /> {item.locationName || item.LocationName}
                                        </div>
                                        <div style={{ display: 'flex', alignItems: 'center', gap: '6px', color: '#64748b', fontSize: '0.85rem' }}>
                                            <Calendar size={14} /> Reported on {date}
                                        </div>
                                        <div style={{ marginTop: 'auto', paddingTop: '1rem' }}>
                                            <button style={{
                                                width: '100%', background: '#fff', border: '1px solid #319795', color: '#319795',
                                                padding: '10px', borderRadius: '12px', fontWeight: '700', cursor: 'pointer', display: 'flex', justifyContent: 'center', gap: '8px'
                                            }}>
                                                Is this yours? <ArrowRight size={18} />
                                            </button>
                                        </div>
                                    </div>
                                </div>
                            );
                        })}
                    </div>
                ) : (
                    <div style={{ padding: '4rem', textAlign: 'center', background: 'white', borderRadius: '24px', border: '2px dashed #e2e8f0' }}>
                        <LayoutGrid size={48} color="#cbd5e0" style={{ marginBottom: '1rem' }} />
                        <h3 style={{ fontSize: '1.5rem', fontWeight: '800', marginBottom: '0.5rem' }}>No Items Found</h3>
                        <p style={{ color: '#718096', maxWidth: '400px', margin: '0 auto' }}>There are currently no public found items matching your search criteria.</p>
                    </div>
                )}
            </main>
        </div>
    );
};

export default PublicFoundWall;
