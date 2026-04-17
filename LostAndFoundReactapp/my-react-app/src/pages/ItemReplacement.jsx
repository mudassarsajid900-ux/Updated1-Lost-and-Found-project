// ========================================== //
// SECTION 1: IMPORTS
// We import React, icons, and API services
// ========================================== //
import React, { useState, useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import {
    ChevronLeft, Smartphone, Wallet, RefreshCw, ChevronRight,
    Search, CheckCircle, Clock, XCircle, Info, Package, DollarSign,
    Box, ShieldCheck, ArrowRight, Laptop, Briefcase, Watch, FileText, Gem, Headphones
} from 'lucide-react';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';
import api from '../api/axios';

// ========================================== //
// SECTION 2: MAIN ITEM REPLACEMENT COMPONENT
// This page allows users to request a replacement for an item they lost,
// or check the status of an ongoing request.
// ========================================== //
const ItemReplacement = () => {
    // Allows us to navigate between pages
    const navigate = useNavigate();

    // ========================================== //
    // STATE VARIABLES
    // ========================================== //
    const [view, setView] = useState('list');
    const [selectedItem, setSelectedItem] = useState(null);
    const [eligibleItems, setEligibleItems] = useState([]);
    const [myRequests, setMyRequests] = useState([]);
    const [loading, setLoading] = useState(true);
    const [formSubmitting, setFormSubmitting] = useState(false);

    // Form states
    const [requestReason, setRequestReason] = useState('');
    const [desiredSpecs, setDesiredSpecs] = useState('');

    // ========================================== //
    // DATA FETCHING
    // ========================================== //
    useEffect(() => {
        fetchData();
    }, []);

    const fetchData = async () => {
        setLoading(true);
        try {
            const [eligibleRes, requestsRes] = await Promise.all([
                api.get('Replacement/eligible-items'),
                api.get('Replacement/my-replacements')
            ]);
            setEligibleItems(eligibleRes.data.data || []);
            setMyRequests(requestsRes.data.data || []);
        } catch (error) {
            console.error("Error fetching replacement data:", error);
        } finally {
            setLoading(false);
        }
    };

    // Helper to get icon based on item title/category
    const getIcon = (title) => {
        const lower = (title || "").toLowerCase();
        if (lower.includes('device') || lower.includes('phone') || lower.includes('mobile')) return <Smartphone size={28} />;
        if (lower.includes('wallet')) return <Wallet size={28} />;
        if (lower.includes('hardware') || lower.includes('laptop') || lower.includes('computing')) return <Laptop size={28} />;
        if (lower.includes('luggage') || lower.includes('bag')) return <Briefcase size={28} />;
        if (lower.includes('timepiece') || lower.includes('watch')) return <Watch size={28} />;
        if (lower.includes('documentation') || lower.includes('passport') || lower.includes('id')) return <FileText size={28} />;
        if (lower.includes('jewelry') || lower.includes('valuables')) return <Gem size={28} />;
        if (lower.includes('audio') || lower.includes('earphone') || lower.includes('headphone')) return <Headphones size={28} />;
        return <Package size={28} />;
    };

    // ========================================== //
    // HANDLERS
    // ========================================== //

    const handleRequestReplacement = (item) => {
        setSelectedItem(item);
        setView('form');
    };

    const handleViewStatus = (request) => {
        setSelectedItem(request);
        setView('status');
    };

    const handleSubmitRequest = async (e) => {
        e.preventDefault();
        setFormSubmitting(true);
        try {
            await api.post('Replacement/create', {
                lostItemId: selectedItem.id,
                requestReason: requestReason,
                desiredSpecifications: desiredSpecs
            });
            await fetchData();
            setView('list');
            // Reset form
            setRequestReason('');
            setDesiredSpecs('');
        } catch (error) {
            console.error("Error submitting request:", error);
            alert("Failed to submit request. Please try again.");
        } finally {
            setFormSubmitting(false);
        }
    };

    // ========================================== //
    // VIEW RENDERERS
    // ========================================== //

    const renderListView = () => (
        <div style={{ maxWidth: '1000px', margin: '0 auto' }}>
            <Header
                title="Item Replacement"
                subtitle="Premium support for your lost valuables."
                showBack={true}
                onBack={() => navigate(-1)}
            />

            {loading ? (
                <div style={{ display: 'flex', justifyContent: 'center', padding: '100px' }}>
                    <RefreshCw className="animate-spin" size={40} color="#319795" />
                </div>
            ) : (
                <>
                    {/* Eligible Items Section */}
                    <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center', marginBottom: '1.5rem', marginTop: '1rem' }}>
                        <h2 style={{ fontSize: '1.5rem', fontWeight: '800', color: '#1a202c', margin: 0 }}>Eligible for Replacement</h2>
                        <div style={{ background: '#e6fffa', color: '#319795', padding: '6px 16px', borderRadius: '100px', fontSize: '0.9rem', fontWeight: '700' }}>
                            {eligibleItems.length} Waiting
                        </div>
                    </div>

                    <div style={{
                        display: 'grid', gridTemplateColumns: 'repeat(auto-fill, minmax(450px, 1fr))',
                        gap: '2rem', marginBottom: '3rem'
                    }}>
                        {eligibleItems.length > 0 ? eligibleItems.map((item, index) => (
                            <div key={item.id} style={{
                                backgroundColor: 'rgba(255, 255, 255, 0.7)',
                                backdropFilter: 'blur(12px)',
                                borderRadius: '28px',
                                padding: '2rem',
                                border: '1px solid rgba(255, 255, 255, 0.8)',
                                boxShadow: '0 20px 40px -15px rgba(0, 0, 0, 0.05)',
                                animation: `fadeInUp 0.6s ease-out ${index * 0.1}s both`
                            }} className="premium-card">
                                <div style={{ display: 'flex', gap: '1.5rem', marginBottom: '2rem' }}>
                                    <div style={{
                                        width: '70px', height: '70px', backgroundColor: 'white',
                                        borderRadius: '22px', display: 'flex', alignItems: 'center',
                                        justifyContent: 'center', color: '#319795',
                                        boxShadow: '0 10px 20px rgba(0,0,0,0.02)', border: '1px solid #f0f4f8'
                                    }}>
                                        {getIcon(item.title)}
                                    </div>
                                    <div style={{ flex: 1 }}>
                                        <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center', marginBottom: '4px' }}>
                                            <span style={{ fontSize: '0.75rem', fontWeight: '800', color: '#a0aec0', textTransform: 'uppercase', letterSpacing: '1px' }}>ID: #{item.id}</span>
                                            <ShieldCheck size={18} color="#38b2ac" />
                                        </div>
                                        <h3 style={{ fontSize: '1.4rem', fontWeight: '900', color: '#2d3748', marginBottom: '8px' }}>{item.title}</h3>
                                        <div style={{ display: 'flex', gap: '1rem', fontSize: '0.85rem', color: '#718096' }}>
                                            <span><Clock size={14} style={{ marginRight: '4px', verticalAlign: 'text-bottom' }} /> Lost on {new Date(item.reportedDate).toLocaleDateString()}</span>
                                        </div>
                                    </div>
                                </div>
                                <button
                                    onClick={() => handleRequestReplacement(item)}
                                    className="submit-btn"
                                    style={{
                                        width: '100%', padding: '1rem',
                                        background: 'linear-gradient(135deg, #319795 0%, #2c7a7b 100%)',
                                        borderRadius: '16px', fontWeight: '800', boxShadow: '0 10px 20px rgba(49, 151, 149, 0.2)'
                                    }}
                                >
                                    Request Replacement
                                    <ArrowRight size={18} style={{ marginLeft: '8px' }} />
                                </button>
                            </div>
                        )) : (
                            <div style={{ gridColumn: '1/-1', textAlign: 'center', padding: '40px', background: 'white', borderRadius: '24px', border: '1px solid #edf2f7' }}>
                                <p style={{ color: '#718096', fontWeight: '600' }}>No items currently eligible for replacement. Items become eligible after the required waiting period.</p>
                            </div>
                        )}
                    </div>

                    {/* Active Requests Section */}
                    {myRequests.length > 0 && (
                        <>
                            <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center', marginBottom: '1.5rem' }}>
                                <h2 style={{ fontSize: '1.5rem', fontWeight: '800', color: '#1a202c', margin: 0 }}>Active Replacement Requests</h2>
                            </div>
                            <div style={{
                                display: 'grid', gridTemplateColumns: 'repeat(auto-fill, minmax(450px, 1fr))',
                                gap: '2rem', marginBottom: '4rem'
                            }}>
                                {myRequests.map((req, index) => (
                                    <div key={req.id} style={{
                                        backgroundColor: 'rgba(255, 255, 255, 0.7)',
                                        backdropFilter: 'blur(12px)',
                                        borderRadius: '28px', padding: '2rem',
                                        border: '1px solid rgba(255, 255, 255, 0.8)',
                                        boxShadow: '0 20px 40px -15px rgba(0, 0, 0, 0.05)',
                                        animation: `fadeInUp 0.6s ease-out ${index * 0.1}s both`
                                    }}>
                                        <div style={{ display: 'flex', gap: '1.5rem', marginBottom: '2rem' }}>
                                            <div style={{
                                                width: '70px', height: '70px', backgroundColor: 'white',
                                                borderRadius: '22px', display: 'flex', alignItems: 'center',
                                                justifyContent: 'center', color: '#6366f1',
                                                boxShadow: '0 10px 20px rgba(0,0,0,0.02)', border: '1px solid #f0f4f8'
                                            }}>
                                                {getIcon(req.lostItemTitle)}
                                            </div>
                                            <div style={{ flex: 1 }}>
                                                <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center', marginBottom: '4px' }}>
                                                    <span style={{ fontSize: '0.75rem', fontWeight: '800', color: '#a0aec0', textTransform: 'uppercase' }}>Status: {req.statusName}</span>
                                                    <Info size={18} color="#6366f1" />
                                                </div>
                                                <h3 style={{ fontSize: '1.4rem', fontWeight: '900', color: '#2d3748', marginBottom: '8px' }}>{req.lostItemTitle}</h3>
                                                <p style={{ fontSize: '0.85rem', color: '#718096' }}>Request #{req.id} submitted on {new Date(req.createdAt).toLocaleDateString()}</p>
                                            </div>
                                        </div>
                                        <button
                                            onClick={() => handleViewStatus(req)}
                                            style={{
                                                width: '100%', padding: '1rem', background: 'white',
                                                color: '#6366f1', border: '2px solid #6366f1', borderRadius: '16px', fontWeight: '800'
                                            }}
                                        >
                                            View Progress
                                        </button>
                                    </div>
                                ))}
                            </div>
                        </>
                    )}
                </>
            )}
        </div>
    );

    const renderFormView = () => (
        <div style={{ maxWidth: '600px', margin: '0 auto' }}>
            <Header
                title="Application"
                subtitle="Configure your replacement criteria."
                showBack={true}
                onBack={() => setView('list')}
            />

            <form onSubmit={handleSubmitRequest} style={{ display: 'flex', flexDirection: 'column', gap: '1.5rem', animation: 'fadeInUp 0.6s ease-out' }}>
                <div style={{
                    backgroundColor: 'white', borderRadius: '24px', padding: '1.75rem',
                    border: '1px solid #e2e8f0', display: 'flex', alignItems: 'center',
                    gap: '1.5rem', boxShadow: '0 4px 12px rgba(0,0,0,0.02)'
                }}>
                    <div style={{ width: '56px', height: '56px', background: '#f7fafc', borderRadius: '16px', display: 'flex', alignItems: 'center', justifyContent: 'center', color: '#319795' }}>
                        {getIcon(selectedItem?.title)}
                    </div>
                    <div>
                        <p style={{ margin: 0, fontSize: '0.8rem', fontWeight: '800', color: '#a0aec0', textTransform: 'uppercase' }}>Replacing Item</p>
                        <p style={{ margin: 0, fontSize: '1.2rem', fontWeight: '900', color: '#2d3748' }}>{selectedItem?.title}</p>
                    </div>
                </div>

                <div style={{
                    backgroundColor: 'white', borderRadius: '28px', padding: '2.5rem',
                    border: '1px solid #e2e8f0', boxShadow: '0 20px 40px -10px rgba(0, 0, 0, 0.05)'
                }}>
                    <div className="floating-group" style={{ marginBottom: '2rem' }}>
                         <textarea
                            className="floating-input"
                            value={requestReason}
                            onChange={(e) => setRequestReason(e.target.value)}
                            placeholder="Why do you need a replacement?"
                            style={{ height: '100px', padding: '1rem', borderRadius: '18px', width: '100%', border: '1px solid #e2e8f0' }}
                            required
                        />
                    </div>

                    <div className="floating-group" style={{ marginBottom: '2rem' }}>
                        <textarea
                            className="floating-input"
                            value={desiredSpecs}
                            onChange={(e) => setDesiredSpecs(e.target.value)}
                            placeholder="Desired Item Specifications (Brand, Model, Color, etc.)"
                            style={{ height: '140px', padding: '1rem', borderRadius: '18px', width: '100%', border: '1px solid #e2e8f0' }}
                            required
                        />
                    </div>

                    <button
                        type="submit"
                        disabled={formSubmitting}
                        className="submit-btn"
                        style={{
                            width: '100%', padding: '1.25rem', borderRadius: '18px',
                            background: 'linear-gradient(135deg, #319795 0%, #2c7a7b 100%)',
                            fontWeight: '800', fontSize: '1.1rem', boxShadow: '0 15px 30px rgba(49, 151, 149, 0.3)',
                            opacity: formSubmitting ? 0.7 : 1
                        }}
                    >
                        {formSubmitting ? "Submitting..." : "Submit Official Request"}
                    </button>
                </div>
            </form>
        </div>
    );

    const renderStatusView = () => {
        const req = selectedItem;
        
        // Ensure robust status mapping whether backend sends int or string
        const statusMap = { 'Pending': 0, 'UnderReview': 1, 'Approved': 2, 'Rejected': 3, 'Completed': 4 };
        const currentLevel = typeof req.status === 'number' ? req.status : (statusMap[req.status] ?? statusMap[req.statusName] ?? 0);
        
        const statusSteps = [
            { title: "Request Submitted", desc: "Your application is in the queue.", status: 'done' },
            { title: "Details Review", desc: "Admin is checking item availability.", status: currentLevel >= 1 ? 'done' : 'active' },
            { title: "Approval Decision", desc: "Final verification and assignment.", status: currentLevel >= 2 ? (currentLevel === 3 ? 'rejected' : 'done') : (currentLevel === 1 ? 'active' : 'waiting') },
            { title: "Fulfillment", desc: currentLevel === 3 ? "Request was declined." : "Ready for collection.", status: currentLevel === 4 ? 'done' : (currentLevel === 2 ? 'active' : 'waiting') }
        ];

        return (
            <div style={{ maxWidth: '800px', margin: '0 auto' }}>
                <Header title="Replacement Progress" showBack={true} onBack={() => setView('list')} />
                <div style={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '3rem' }}>
                    <div style={{ animation: 'fadeInLeft 0.6s ease-out' }}>
                        <div style={{
                            backgroundColor: 'white', borderRadius: '28px', padding: '2.5rem',
                            border: '1px solid #e2e8f0', textAlign: 'center', boxShadow: '0 20px 40px -15px rgba(0, 0, 0, 0.05)'
                        }}>
                            <div style={{
                                width: '90px', height: '90px', backgroundColor: 'white', borderRadius: '28px',
                                display: 'flex', alignItems: 'center', justifyContent: 'center',
                                color: '#319795', margin: '0 auto 1.5rem', boxShadow: '0 15px 30px rgba(0,0,0,0.05)',
                                border: '1px solid #f0f4f8'
                            }}>
                                {getIcon(req.lostItemTitle)}
                            </div>
                            <h3 style={{ fontSize: '1.5rem', fontWeight: '900', color: '#2d3748', marginBottom: '8px' }}>{req.lostItemTitle}</h3>
                            <div style={{ display: 'inline-block', background: currentLevel === 3 ? '#fff5f5' : '#ebf8ff', color: currentLevel === 3 ? '#e53e3e' : '#3182ce', padding: '6px 16px', borderRadius: '100px', fontSize: '0.85rem', fontWeight: '800' }}>
                                {req.statusName.toUpperCase()}
                            </div>

                            <div style={{ marginTop: '2.5rem', borderTop: '1px solid #edf2f7', paddingTop: '2rem', textAlign: 'left' }}>
                                <div style={{ marginBottom: '1.5rem' }}>
                                    <p style={{ margin: 0, fontSize: '0.8rem', fontWeight: '800', color: '#a0aec0', textTransform: 'uppercase' }}>Your Specifications</p>
                                    <p style={{ margin: '4px 0', fontSize: '0.95rem', color: '#4a5568', fontStyle: 'italic' }}>"{req.desiredSpecifications}"</p>
                                </div>
                                {req.adminNotes && (
                                    <div>
                                        <p style={{ margin: 0, fontSize: '0.8rem', fontWeight: '800', color: '#319795', textTransform: 'uppercase' }}>Admin Message</p>
                                        <p style={{ margin: '4px 0', fontSize: '0.95rem', color: '#2d3748', fontWeight: '600' }}>{req.adminNotes}</p>
                                    </div>
                                )}
                            </div>
                        </div>
                    </div>

                    <div style={{ animation: 'fadeInRight 0.6s ease-out' }}>
                        <h2 style={{ fontSize: '1.4rem', fontWeight: '800', marginBottom: '2rem', color: '#1a202c' }}>Tracking Timeline</h2>
                        <div style={{ display: 'flex', flexDirection: 'column' }}>
                            {statusSteps.map((step, i, arr) => (
                                <div key={step.title} style={{ display: 'flex', gap: '1.5rem', minHeight: '100px' }}>
                                    <div style={{ display: 'flex', flexDirection: 'column', alignItems: 'center' }}>
                                        <div style={{
                                            width: '32px', height: '32px',
                                            backgroundColor: step.status === 'done' ? '#38b2ac' : (step.status === 'rejected' ? '#e53e3e' : 'white'),
                                            border: step.status === 'waiting' ? '2px solid #e2e8f0' : (step.status === 'active' ? '2px solid #38b2ac' : 'none'),
                                            borderRadius: '50%', display: 'flex', alignItems: 'center', justifyContent: 'center'
                                        }}>
                                            {step.status === 'done' ? <CheckCircle size={18} color="white" /> : (step.status === 'rejected' ? <XCircle size={18} color="white" /> : (step.status === 'active' ? <RefreshCw size={14} color="#38b2ac" className="animate-spin" /> : null))}
                                        </div>
                                        {i < arr.length - 1 && <div style={{ width: '3px', flex: 1, backgroundColor: step.status === 'done' ? '#38b2ac' : '#e2e8f0', margin: '5px 0' }} />}
                                    </div>
                                    <div style={{ paddingBottom: '2.5rem' }}>
                                        <h4 style={{ margin: 0, fontSize: '1.1rem', fontWeight: '800', color: step.status === 'waiting' ? '#a0aec0' : '#2d3748' }}>{step.title}</h4>
                                        <p style={{ margin: '4px 0', fontSize: '0.9rem', color: '#718096', lineHeight: '1.4' }}>{step.desc}</p>
                                    </div>
                                </div>
                            ))}
                        </div>
                    </div>
                </div>
            </div>
        );
    };

    return (
        <div className="dashboard-container">
            <Sidebar />
            <main className="main-content" style={{ background: 'linear-gradient(135deg, #f0fdfa 0%, #f1f5f9 100%)', minHeight: '100vh', padding: '3rem' }}>
                <div style={{ position: 'relative', zIndex: 1 }}>
                    {view === 'list' && renderListView()}
                    {view === 'form' && renderFormView()}
                    {view === 'status' && renderStatusView()}
                </div>
                <style>{`
                    @keyframes fadeInUp { from { opacity: 0; transform: translateY(30px); } to { opacity: 1; transform: translateY(0); } }
                    @keyframes fadeInLeft { from { opacity: 0; transform: translateX(-30px); } to { opacity: 1; transform: translateX(0); } }
                    @keyframes fadeInRight { from { opacity: 0; transform: translateX(30px); } to { opacity: 1; transform: translateX(0); } }
                    .animate-spin { animation: spin 3s linear infinite; }
                    @keyframes spin { from { transform: rotate(0deg); } to { transform: rotate(360deg); } }
                `}</style>
            </main>
        </div>
    );
};

export default ItemReplacement;
