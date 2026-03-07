// ========================================== //
// SECTION 1: IMPORTS
// We import React and icons
// ========================================== //
import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import {
    ChevronLeft, Smartphone, Wallet, RefreshCw, ChevronRight,
    Search, CheckCircle, Clock, XCircle, Info, Package, DollarSign,
    Box, ShieldCheck, ArrowRight
} from 'lucide-react';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';

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
    // Controls which screen is shown: 'list' (all items), 'form' (request), or 'status' (tracking)
    const [view, setView] = useState('list');

    // Stores the specific item the user clicked on
    const [selectedItem, setSelectedItem] = useState(null);

    // ========================================== //
    // FAKE DATA SECTION
    // These are test items to show what the list looks like.
    // ========================================== //
    const lostItems = [
        {
            id: 1,
            title: "Black Smartphone",
            reportedDate: "Aug 10, 2018",
            incidentDate: "Aug 5, 2025",
            icon: <Smartphone size={28} />,
            color: "#319795",
            category: "Electronics"
        },
        {
            id: 2,
            title: "Luxury Leather Wallet",
            reportedDate: "Aug 5, 2023",
            incidentDate: "Sep 5, 2025",
            icon: <Wallet size={28} />,
            color: "#6366f1",
            category: "Accessories",
            statusView: true // This item already has a request submitted
        }
    ];

    // ========================================== //
    // HANDLERS
    // Functions that run when buttons are clicked
    // ========================================== //

    // User clicks "Request Replacement"
    const handleRequestReplacement = (item) => {
        setSelectedItem(item);
        setView('form');
    };

    // User clicks "Check Status"
    const handleViewStatus = (item) => {
        setSelectedItem(item);
        setView('status');
    };

    // User submits the replacement form
    const handleSubmitRequest = (e) => {
        e.preventDefault();
        setView('status');
    };

    // ========================================== //
    // SECTION 3: VIEW RENDERERS
    // ========================================== //

    // -------------------------------------------
    // VIEW A: LIST ALL ITEMS
    // Shows the main screen with all lost items
    // -------------------------------------------
    const renderListView = () => (
        <div style={{ maxWidth: '1000px', margin: '0 auto' }}>
            <Header
                title="Item Replacement"
                subtitle="Premium support for your lost valuables."
                showBack={true}
                onBack={() => navigate(-1)}
            />

            {/* Title Row */}
            <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center', marginBottom: '2rem' }}>
                <h2 style={{ fontSize: '1.5rem', fontWeight: '800', color: '#1a202c', margin: 0 }}>Active Claims</h2>
                <div style={{ background: '#e6fffa', color: '#319795', padding: '6px 16px', borderRadius: '100px', fontSize: '0.9rem', fontWeight: '700' }}>
                    {lostItems.length} Items Found
                </div>
            </div>

            {/* Grid of Item Cards */}
            <div style={{
                display: 'grid', gridTemplateColumns: 'repeat(auto-fill, minmax(450px, 1fr))',
                gap: '2rem', marginBottom: '4rem'
            }}>
                {lostItems.map((item, index) => (
                    <div key={item.id} style={{
                        backgroundColor: 'rgba(255, 255, 255, 0.7)',
                        backdropFilter: 'blur(12px)',
                        borderRadius: '28px',
                        padding: '2rem',
                        border: '1px solid rgba(255, 255, 255, 0.8)',
                        boxShadow: '0 20px 40px -15px rgba(0, 0, 0, 0.05)',
                        transition: 'all 0.4s cubic-bezier(0.175, 0.885, 0.32, 1.275)',
                        position: 'relative',
                        overflow: 'hidden',
                        animation: `fadeInUp 0.6s ease-out ${index * 0.1}s both`
                    }}
                        className="premium-card"
                        onMouseOver={(e) => {
                            e.currentTarget.style.transform = 'translateY(-10px)';
                            e.currentTarget.style.boxShadow = '0 30px 60px -12px rgba(49, 151, 149, 0.15)';
                        }}
                        onMouseOut={(e) => {
                            e.currentTarget.style.transform = 'translateY(0)';
                            e.currentTarget.style.boxShadow = '0 20px 40px -15px rgba(0, 0, 0, 0.05)';
                        }}
                    >
                        {/* Internal Card Details */}
                        <div style={{ display: 'flex', gap: '1.5rem', marginBottom: '2rem' }}>
                            {/* Icon Box */}
                            <div style={{
                                width: '70px', height: '70px', backgroundColor: 'white',
                                borderRadius: '22px', display: 'flex', alignItems: 'center',
                                justifyContent: 'center', color: '#319795',
                                boxShadow: '0 10px 20px rgba(0,0,0,0.02)', border: '1px solid #f0f4f8'
                            }}>
                                {item.icon}
                            </div>
                            {/* Text Info */}
                            <div style={{ flex: 1 }}>
                                <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center', marginBottom: '4px' }}>
                                    <span style={{ fontSize: '0.75rem', fontWeight: '800', color: '#a0aec0', textTransform: 'uppercase', letterSpacing: '1px' }}>{item.category}</span>
                                    <ShieldCheck size={18} color="#38b2ac" />
                                </div>
                                <h3 style={{ fontSize: '1.4rem', fontWeight: '900', color: '#2d3748', marginBottom: '8px' }}>
                                    {item.title}
                                </h3>
                                <div style={{ display: 'flex', gap: '1rem', fontSize: '0.85rem', color: '#718096' }}>
                                    <span><Clock size={14} style={{ marginRight: '4px', verticalAlign: 'text-bottom' }} /> {item.reportedDate}</span>
                                </div>
                            </div>
                        </div>

                        {/* Card Buttons based on Status */}
                        <div style={{ display: 'flex', gap: '1rem' }}>
                            {item.statusView ? (
                                <button
                                    onClick={() => handleViewStatus(item)}
                                    className="submit-btn"
                                    style={{
                                        margin: 0, flex: 1, padding: '1rem', background: 'white',
                                        color: '#319795', border: '2px solid #319795', borderRadius: '16px', fontWeight: '800'
                                    }}
                                    onMouseOver={(e) => e.currentTarget.style.backgroundColor = 'rgba(49, 151, 149, 0.04)'}
                                    onMouseOut={(e) => e.currentTarget.style.backgroundColor = 'white'}
                                >
                                    Check Status
                                </button>
                            ) : (
                                <button
                                    onClick={() => handleRequestReplacement(item)}
                                    className="submit-btn"
                                    style={{
                                        margin: 0, flex: 1, padding: '1rem',
                                        background: 'linear-gradient(135deg, #319795 0%, #2c7a7b 100%)',
                                        borderRadius: '16px', fontWeight: '800', boxShadow: '0 10px 20px rgba(49, 151, 149, 0.2)'
                                    }}
                                >
                                    Request Replacement
                                    <ArrowRight size={18} style={{ marginLeft: '8px' }} />
                                </button>
                            )}
                        </div>
                    </div>
                ))}
            </div>
        </div>
    );

    // -------------------------------------------
    // VIEW B: REQUEST FORM
    // Shows the form to type details about the replacement you want
    // -------------------------------------------
    const renderFormView = () => (
        <div style={{ maxWidth: '600px', margin: '0 auto' }}>
            <Header
                title="Application"
                subtitle="Configure your replacement criteria."
                showBack={true}
                onBack={() => setView('list')}
            />

            <form onSubmit={handleSubmitRequest} style={{ display: 'flex', flexDirection: 'column', gap: '1.5rem', animation: 'fadeInUp 0.6s ease-out' }}>

                {/* Source Item Display Box */}
                <div style={{
                    backgroundColor: 'white', borderRadius: '24px', padding: '1.75rem',
                    border: '1px solid #e2e8f0', display: 'flex', alignItems: 'center',
                    gap: '1.5rem', boxShadow: '0 4px 12px rgba(0,0,0,0.02)'
                }}>
                    <div style={{ width: '56px', height: '56px', background: '#f7fafc', borderRadius: '16px', display: 'flex', alignItems: 'center', justifyContent: 'center', color: '#319795' }}>
                        {selectedItem?.icon || <Smartphone size={24} />}
                    </div>
                    <div>
                        <p style={{ margin: 0, fontSize: '0.8rem', fontWeight: '800', color: '#a0aec0', textTransform: 'uppercase' }}>Source Item</p>
                        <p style={{ margin: 0, fontSize: '1.2rem', fontWeight: '900', color: '#2d3748' }}>{selectedItem?.title}</p>
                    </div>
                </div>

                {/* Form Input Box */}
                <div style={{
                    backgroundColor: 'white', borderRadius: '28px', padding: '2.5rem',
                    border: '1px solid #e2e8f0', boxShadow: '0 20px 40px -10px rgba(0, 0, 0, 0.05)'
                }}>
                    {/* Text Box for Specs */}
                    <div className="floating-group" style={{ marginBottom: '2rem' }}>
                        <textarea
                            className="floating-input"
                            placeholder=" "
                            style={{ height: '140px', paddingTop: '1.75rem', borderRadius: '18px' }}
                            required
                        />
                        <label className="floating-label" style={{ top: '1rem' }}>Desired Item Specifications</label>
                        <p style={{ fontSize: '0.85rem', color: '#718096', marginTop: '10px', fontWeight: '500' }}>Specify brand, model year, and any custom features required for your replacement.</p>
                    </div>

                    {/* Radio Options for Compensation */}
                    <div style={{ marginBottom: '2.5rem' }}>
                        <label style={{ fontSize: '0.9rem', fontWeight: '800', color: '#4a5568', textTransform: 'uppercase', marginBottom: '1rem', display: 'block', letterSpacing: '0.5px' }}>Preferred Compensation</label>
                        <div style={{ display: 'flex', flexDirection: 'column', gap: '0.75rem' }}>
                            {['Exact Match Replacement', 'Monetary Value (USD)', 'Store Credit Voucher'].map((opt, i) => (
                                <div key={opt} style={{
                                    padding: '1.1rem 1.5rem', borderRadius: '16px',
                                    border: i === 1 ? '2px solid #319795' : '1px solid #e2e8f0',
                                    background: i === 1 ? '#f0fdfa' : 'white', display: 'flex',
                                    justifyContent: 'space-between', alignItems: 'center', cursor: 'pointer',
                                    fontWeight: i === 1 ? '700' : '500', color: i === 1 ? '#0d9488' : '#4a5568'
                                }}>
                                    <span>{opt}</span>
                                    {i === 1 && <div style={{ width: '20px', height: '20px', backgroundColor: '#319795', borderRadius: '50%', display: 'flex', alignItems: 'center', justifyContent: 'center' }}><CheckCircle size={12} color="white" /></div>}
                                </div>
                            ))}
                        </div>
                    </div>

                    {/* Submit Button */}
                    <button
                        type="submit"
                        className="submit-btn"
                        style={{
                            width: '100%', padding: '1.25rem', borderRadius: '18px',
                            background: 'linear-gradient(135deg, #319795 0%, #2c7a7b 100%)',
                            fontWeight: '800', fontSize: '1.1rem', boxShadow: '0 15px 30px rgba(49, 151, 149, 0.3)'
                        }}
                    >
                        Submit Official Request
                    </button>
                </div>
            </form>
        </div>
    );

    // -------------------------------------------
    // VIEW C: STATUS CHECKER
    // Shows the progress of a replacement request
    // -------------------------------------------
    const renderStatusView = () => (
        <div style={{ maxWidth: '700px', margin: '0 auto' }}>
            <Header
                title="Claim Status"
                showBack={true}
                onBack={() => setView('list')}
            />

            <div style={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '2rem' }}>

                {/* Left Side: Main Status Box */}
                <div style={{ animation: 'fadeInLeft 0.6s ease-out' }}>
                    <div style={{
                        backgroundColor: 'white', borderRadius: '28px', padding: '2rem',
                        border: '1px solid #e2e8f0', marginBottom: '2rem',
                        boxShadow: '0 20px 40px -15px rgba(0, 0, 0, 0.05)', textAlign: 'center'
                    }}>
                        <div style={{
                            width: '90px', height: '90px', backgroundColor: 'white',
                            borderRadius: '28px', display: 'flex', alignItems: 'center', justifyContent: 'center',
                            color: '#319795', margin: '0 auto 1.5rem', boxShadow: '0 15px 30px rgba(0,0,0,0.05)',
                            border: '1px solid #f0f4f8', animation: 'float 4s ease-in-out infinite'
                        }}>
                            {selectedItem?.icon || <Smartphone size={40} />}
                        </div>
                        <h3 style={{ fontSize: '1.5rem', fontWeight: '900', color: '#2d3748', marginBottom: '8px' }}>
                            {selectedItem?.title || "Black Phone"}
                        </h3>
                        {/* Status Label */}
                        <div style={{ display: 'inline-block', background: '#ebf8ff', color: '#3182ce', padding: '6px 16px', borderRadius: '100px', fontSize: '0.85rem', fontWeight: '800' }}>
                            ONGOING CASE
                        </div>

                        {/* ID Details */}
                        <div style={{ marginTop: '2.5rem', borderTop: '1px solid #edf2f7', paddingTop: '2rem', textAlign: 'left' }}>
                            <div style={{ marginBottom: '1rem' }}>
                                <p style={{ margin: 0, fontSize: '0.8rem', fontWeight: '800', color: '#a0aec0' }}>CASE ID</p>
                                <p style={{ margin: 0, fontSize: '1rem', fontWeight: '700', color: '#4a5568' }}>#LF-2948-2026</p>
                            </div>
                            <div>
                                <p style={{ margin: 0, fontSize: '0.8rem', fontWeight: '800', color: '#a0aec0' }}>SUBMITTED ON</p>
                                <p style={{ margin: 0, fontSize: '1rem', fontWeight: '700', color: '#4a5568' }}>Oct 25, 2026</p>
                            </div>
                        </div>
                    </div>

                    {/* Withdraw Claim Button */}
                    <button
                        className="submit-btn"
                        style={{
                            width: '100%', padding: '1.25rem', borderRadius: '18px', background: 'white',
                            border: '2px solid #fed7d7', color: '#e53e3e', fontWeight: '800', transition: 'all 0.2s'
                        }}
                        onMouseOver={(e) => {
                            e.currentTarget.style.backgroundColor = '#fff5f5';
                            e.currentTarget.style.borderColor = '#fc8181';
                        }}
                        onMouseOut={(e) => {
                            e.currentTarget.style.backgroundColor = 'white';
                            e.currentTarget.style.borderColor = '#fed7d7';
                        }}
                    >
                        <XCircle size={18} style={{ marginRight: '8px', verticalAlign: 'text-bottom' }} />
                        Withdraw Claim
                    </button>
                </div>

                {/* Right Side: Timeline Timeline */}
                <div style={{ animation: 'fadeInRight 0.6s ease-out' }}>
                    <h2 style={{ fontSize: '1.4rem', fontWeight: '800', marginBottom: '2rem', color: '#1a202c' }}>Process Timeline</h2>

                    <div style={{ display: 'flex', flexDirection: 'column', gap: '0' }}>
                        {[
                            { title: "Review Complete", desc: "Our specialists verified ownership.", time: "Today, 10:15 AM", status: 'done' },
                            { title: "Sourcing Replacement", desc: "Finding the best match for your item.", time: "In Progress", status: 'active' },
                            { title: "Final Approval", desc: "Review by regional management.", time: "Pending", status: 'waiting' },
                            { title: "Fulfillment", desc: "Delivery or payment processing.", time: "Pending", status: 'waiting' }
                        ].map((step, i, arr) => (
                            <div key={step.title} style={{ display: 'flex', gap: '1.5rem', minHeight: '100px' }}>
                                {/* Timeline Dots and Lines connecting them */}
                                <div style={{ display: 'flex', flexDirection: 'column', alignItems: 'center' }}>
                                    <div style={{
                                        width: '32px', height: '32px',
                                        backgroundColor: step.status === 'done' ? '#38b2ac' : (step.status === 'active' ? 'white' : 'white'),
                                        border: step.status === 'waiting' ? '2px solid #e2e8f0' : (step.status === 'active' ? '2px solid #38b2ac' : 'none'),
                                        borderRadius: '50%', display: 'flex', alignItems: 'center', justifyContent: 'center',
                                        boxShadow: step.status === 'active' ? '0 0 15px rgba(56, 178, 172, 0.4)' : 'none', zIndex: 1
                                    }}>
                                        {step.status === 'done' ? <CheckCircle size={18} color="white" /> : (step.status === 'active' ? <RefreshCw size={14} color="#38b2ac" className="animate-spin" /> : null)}
                                    </div>
                                    {i < arr.length - 1 && <div style={{
                                        width: '3px', flex: 1, backgroundColor: step.status === 'done' ? '#38b2ac' : '#e2e8f0', margin: '5px 0'
                                    }} />}
                                </div>
                                {/* Timeline Text */}
                                <div style={{ paddingBottom: '2.5rem' }}>
                                    <h4 style={{ margin: 0, fontSize: '1.1rem', fontWeight: '800', color: step.status === 'waiting' ? '#a0aec0' : '#2d3748' }}>{step.title}</h4>
                                    <p style={{ margin: '4px 0', fontSize: '0.9rem', color: '#718096', lineHeight: '1.4' }}>{step.desc}</p>
                                    <span style={{ fontSize: '0.75rem', fontWeight: '700', color: step.status === 'active' ? '#38b2ac' : '#cbd5e0', textTransform: 'uppercase' }}>{step.time}</span>
                                </div>
                            </div>
                        ))}
                    </div>
                </div>
            </div>
        </div>
    );

    // ========================================== //
    // MAIN PAGE LAYOUT
    // Assembles Sidebar and the chosen View above
    // ========================================== //
    return (
        <div className="dashboard-container">
            <Sidebar />
            <main className="main-content" style={{ background: 'linear-gradient(135deg, #f0fdfa 0%, #f1f5f9 100%)', minHeight: '100vh', padding: '3rem' }}>
                <div style={{ position: 'relative', zIndex: 1 }}>
                    {/* Render the correct screen based on 'view' state */}
                    {view === 'list' && renderListView()}
                    {view === 'form' && renderFormView()}
                    {view === 'status' && renderStatusView()}
                </div>

                {/* CSS Styling specific to this page */}
                <style>
                    {`
                        @keyframes fadeInUp {
                            from { opacity: 0; transform: translateY(30px); }
                            to { opacity: 1; transform: translateY(0); }
                        }
                        @keyframes fadeInDown {
                            from { opacity: 0; transform: translateY(-20px); }
                            to { opacity: 1; transform: translateY(0); }
                        }
                        @keyframes fadeInLeft {
                            from { opacity: 0; transform: translateX(-30px); }
                            to { opacity: 1; transform: translateX(0); }
                        }
                        @keyframes fadeInRight {
                            from { opacity: 0; transform: translateX(30px); }
                            to { opacity: 1; transform: translateX(0); }
                        }
                        @keyframes float {
                            0%, 100% { transform: translateY(0); }
                            50% { transform: translateY(-10px); }
                        }
                        .animate-spin {
                            animation: spin 3s linear infinite;
                        }
                        @keyframes spin {
                            from { transform: rotate(0deg); }
                            to { transform: rotate(360deg); }
                        }
                        .premium-card:hover h3 {
                            color: #319795 !important;
                        }
                    `}
                </style>
            </main>
        </div>
    );
};

export default ItemReplacement;
