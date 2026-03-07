import React from 'react';
import { useNavigate } from 'react-router-dom';
import {
    ChevronLeft, Wallet, ShieldCheck,
    ArrowRight, HelpCircle, ChevronRight
} from 'lucide-react';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';

const ClaimItem = () => {
    const navigate = useNavigate();

    const matchData = {
        title: "Wallet Match",
        date: "Nov 5, 2023",
        lostImageUrl: "https://images.unsplash.com/photo-1627123424574-724758594e93?auto=format&fit=crop&q=80&w=400", // Placeholder for lost item
        foundImageUrl: "https://images.unsplash.com/photo-1627123424574-724758594e93?auto=format&fit=crop&q=80&w=400"  // Same wallet image as found item
    };

    return (
        <div className="dashboard-container">
            <Sidebar />
            <main className="main-content" style={{
                background: 'linear-gradient(135deg, #f0fdfa 0%, #f1f5f9 100%)',
                minHeight: '100vh',
                padding: '3rem'
            }}>
                <div style={{ maxWidth: '600px', margin: '0 auto' }}>

                    {/* Header */}
                    <Header
                        title="Claim Your Lost Item"
                        subtitle="Verify ownership details for your matched item"
                        showBack={true}
                        onBack={() => navigate('/match-details')}
                    />

                    <div style={{ display: 'flex', flexDirection: 'column', gap: '2rem' }}>

                        {/* Matched Items Comparison Card */}
                        <div style={{
                            backgroundColor: 'rgba(255, 255, 255, 0.7)',
                            backdropFilter: 'blur(10px)',
                            borderRadius: '24px',
                            padding: '1.5rem',
                            border: '1px solid rgba(255, 255, 255, 0.8)',
                            boxShadow: '0 10px 30px -10px rgba(0,0,0,0.05)',
                            animation: 'fadeInUp 0.6s ease-out'
                        }}>
                            <div style={{ display: 'flex', alignItems: 'center', gap: '0.75rem', marginBottom: '1.25rem' }}>
                                <div style={{ color: '#0d9488' }}><Wallet size={20} /></div>
                                <h2 style={{ fontSize: '1.1rem', fontWeight: '800', color: '#2d3748', margin: 0 }}>
                                    {matchData.title}
                                </h2>
                                <span style={{ fontSize: '0.85rem', color: '#718096', marginLeft: 'auto' }}>
                                    Match Date: {matchData.date}
                                </span>
                            </div>

                            <div style={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '1rem' }}>
                                <div style={{ textAlign: 'center' }}>
                                    <div style={{
                                        width: '100%',
                                        aspectRatio: '1.5',
                                        borderRadius: '12px',
                                        overflow: 'hidden',
                                        border: '1px solid #edf2f7',
                                        marginBottom: '0.5rem'
                                    }}>
                                        <img src={matchData.lostImageUrl} alt="Your lost item" style={{ width: '100%', height: '100%', objectFit: 'cover' }} />
                                    </div>
                                    <span style={{ fontSize: '0.8rem', fontWeight: '600', color: '#718096' }}>Your Lost Item</span>
                                </div>
                                <div style={{ textAlign: 'center' }}>
                                    <div style={{
                                        width: '100%',
                                        aspectRatio: '1.5',
                                        borderRadius: '12px',
                                        overflow: 'hidden',
                                        border: '1px solid #edf2f7',
                                        marginBottom: '0.5rem'
                                    }}>
                                        <img src={matchData.foundImageUrl} alt="Found item" style={{ width: '100%', height: '100%', objectFit: 'cover' }} />
                                    </div>
                                    <span style={{ fontSize: '0.8rem', fontWeight: '600', color: '#718096' }}>Found Item</span>
                                </div>
                            </div>
                        </div>

                        {/* Next Steps Section */}
                        <div>
                            <h2 style={{ fontSize: '1.25rem', fontWeight: '800', color: '#1a202c', marginBottom: '1rem' }}>
                                Next Steps to Claim
                            </h2>

                            <button style={{
                                width: '100%',
                                display: 'flex',
                                alignItems: 'center',
                                gap: '1rem',
                                padding: '1.25rem',
                                backgroundColor: 'white',
                                borderRadius: '18px',
                                border: '1px solid #edf2f7',
                                cursor: 'pointer',
                                textAlign: 'left',
                                transition: 'all 0.2s',
                                animation: 'fadeInUp 0.7s ease-out'
                            }}
                                onMouseOver={(e) => e.currentTarget.style.borderColor = '#319795'}
                                onMouseOut={(e) => e.currentTarget.style.borderColor = '#edf2f7'}
                            >
                                <div style={{
                                    width: '44px',
                                    height: '44px',
                                    borderRadius: '12px',
                                    backgroundColor: '#f8fafc',
                                    display: 'flex',
                                    alignItems: 'center',
                                    justifyContent: 'center',
                                    color: '#94a3b8'
                                }}>
                                    <HelpCircle size={24} />
                                </div>
                                <div style={{ flex: 1 }}>
                                    <h3 style={{ margin: 0, fontSize: '1rem', fontWeight: '700', color: '#2d3748' }}>
                                        Security Question for Verification
                                    </h3>
                                    <p style={{ margin: '2px 0 0 0', fontSize: '0.85rem', color: '#718096' }}>
                                        Answer a question to verify ownership
                                    </p>
                                </div>
                                <ChevronRight size={20} color="#cbd5e0" />
                            </button>
                        </div>

                        {/* Submit Button */}
                        <div style={{ marginTop: 'auto', paddingBottom: '2rem' }}>
                            <button
                                className="submit-action-btn"
                                style={{
                                    width: '100%',
                                    padding: '1.1rem',
                                    borderRadius: '16px',
                                    backgroundColor: '#2dd4bf',
                                    color: 'white',
                                    fontWeight: '800',
                                    fontSize: '1.1rem',
                                    border: 'none',
                                    cursor: 'pointer',
                                    boxShadow: '0 8px 16px rgba(45, 212, 191, 0.2)',
                                    display: 'flex',
                                    alignItems: 'center',
                                    justifyContent: 'center',
                                    gap: '10px',
                                    animation: 'fadeInUp 0.8s ease-out'
                                }}
                                onClick={() => navigate('/claim-status')}
                            >
                                Submit Claim Request
                            </button>
                        </div>

                    </div>
                </div>

                <style>{`
                    @keyframes fadeInUp {
                        from { opacity: 0; transform: translateY(20px); }
                        to { opacity: 1; transform: translateY(0); }
                    }
                    @keyframes fadeInDown {
                        from { opacity: 0; transform: translateY(-20px); }
                        to { opacity: 1; transform: translateY(0); }
                    }
                    .submit-action-btn:hover {
                        transform: translateY(-2px);
                        background-color: #14b8a6;
                        box-shadow: 0 10px 20px rgba(45, 212, 191, 0.3);
                    }
                `}</style>
            </main>
        </div>
    );
};

export default ClaimItem;
