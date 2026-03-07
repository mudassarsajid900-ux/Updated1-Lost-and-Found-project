import React from 'react';
import { useNavigate } from 'react-router-dom';
import {
    CheckCircle, Clock, MapPin,
    MessageSquare, XCircle, ChevronDown,
    Loader2
} from 'lucide-react';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';

const ClaimStatus = () => {
    const navigate = useNavigate();

    const claimDetails = {
        title: "Brown Leather Wallet",
        type: "Lost",
        claimedDate: "Today, 1:01 PM",
        imageUrl: "https://images.unsplash.com/photo-1627123424574-724758594e93?auto=format&fit=crop&q=80&w=200"
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
                        title="Claim Status"
                        subtitle="Your claim is being reviewed"
                    />

                    <div style={{ display: 'flex', flexDirection: 'column', gap: '1.5rem' }}>

                        {/* Summary Card */}
                        <div style={{
                            backgroundColor: 'white',
                            borderRadius: '24px',
                            padding: '1.25rem',
                            border: '1px solid #edf2f7',
                            display: 'flex',
                            gap: '1.25rem',
                            alignItems: 'center',
                            boxShadow: '0 4px 12px rgba(0,0,0,0.02)',
                            animation: 'fadeInUp 0.6s ease-out'
                        }}>
                            <div style={{
                                width: '80px',
                                height: '80px',
                                borderRadius: '16px',
                                overflow: 'hidden',
                                border: '1px solid #f1f5f9'
                            }}>
                                <img src={claimDetails.imageUrl} alt="Item" style={{ width: '100%', height: '100%', objectFit: 'cover' }} />
                            </div>
                            <div>
                                <h3 style={{ margin: 0, fontSize: '1.2rem', fontWeight: '800', color: '#2d3748' }}>
                                    {claimDetails.type}: {claimDetails.title}
                                </h3>
                                <p style={{ margin: '4px 0 0 0', fontSize: '0.9rem', color: '#718096' }}>
                                    Claimed: {claimDetails.claimedDate}
                                </p>
                            </div>
                        </div>

                        {/* Status Tracker Card */}
                        <div style={{
                            backgroundColor: 'white',
                            borderRadius: '28px',
                            padding: '1.75rem',
                            border: '1px solid #edf2f7',
                            boxShadow: '0 10px 30px rgba(0,0,0,0.04)',
                            animation: 'fadeInUp 0.7s ease-out'
                        }}>
                            <h2 style={{ fontSize: '1.3rem', fontWeight: '800', color: '#1a202c', marginBottom: '1.5rem' }}>
                                Found Item Details
                            </h2>

                            <div style={{
                                backgroundColor: '#2dd4bf',
                                borderRadius: '14px',
                                padding: '1rem',
                                color: 'white',
                                display: 'flex',
                                alignItems: 'center',
                                justifyContent: 'center',
                                gap: '10px',
                                fontWeight: '700',
                                marginBottom: '2rem'
                            }}>
                                <CheckCircle size={20} />
                                Claim Submitted!
                            </div>

                            {/* Timeline */}
                            <div style={{ display: 'flex', flexDirection: 'column', gap: '1.5rem' }}>

                                {/* Step 1 */}
                                <div style={{ display: 'flex', gap: '1.25rem', alignItems: 'center' }}>
                                    <div style={{ color: '#0d9488' }}><CheckCircle size={24} /></div>
                                    <div style={{ flex: 1 }}>
                                        <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
                                            <h4 style={{ margin: 0, fontSize: '1rem', fontWeight: '700', color: '#2d3748' }}>Claim Submitted</h4>
                                            <ChevronDown size={18} color="#cbd5e0" />
                                        </div>
                                        <span style={{ fontSize: '0.85rem', color: '#718096' }}>Today, 1:01 PM</span>
                                    </div>
                                </div>

                                <div style={{ height: '1px', backgroundColor: '#f1f5f9', marginLeft: '3rem' }}></div>

                                {/* Step 2 */}
                                <div style={{ display: 'flex', gap: '1.25rem', alignItems: 'center' }}>
                                    <div style={{ color: '#319795' }}><Loader2 size={24} className="spin-slow" /></div>
                                    <div style={{ flex: 1 }}>
                                        <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
                                            <h4 style={{ margin: 0, fontSize: '1rem', fontWeight: '700', color: '#2d3748' }}>Details Verification</h4>
                                            <ChevronDown size={18} color="#cbd5e0" />
                                        </div>
                                        <span style={{ fontSize: '0.85rem', color: '#718096' }}>Details, Verification In Progress</span>
                                    </div>
                                </div>

                                <div style={{ height: '1px', backgroundColor: '#f1f5f9', marginLeft: '3rem' }}></div>

                                {/* Step 3 */}
                                <div style={{ display: 'flex', gap: '1.25rem', alignItems: 'center', opacity: 0.6 }}>
                                    <div style={{ color: '#94a3b8' }}><Clock size={24} /></div>
                                    <div style={{ flex: 1 }}>
                                        <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
                                            <h4 style={{ margin: 0, fontSize: '1rem', fontWeight: '700', color: '#4b5563' }}>Contact Finder & Arrange Pickup</h4>
                                            <ChevronDown size={18} color="#cbd5e0" />
                                        </div>
                                        <span style={{ fontSize: '0.85rem', color: '#94a3b8' }}>Pending</span>
                                    </div>
                                </div>
                            </div>
                        </div>

                        {/* Footer Buttons */}
                        <div style={{ marginTop: '1rem', paddingBottom: '3rem' }}>
                            <button style={{
                                width: '100%',
                                padding: '1.1rem',
                                borderRadius: '16px',
                                backgroundColor: 'transparent',
                                color: '#64748b',
                                fontWeight: '700',
                                fontSize: '1rem',
                                border: '1px solid #e2e8f0',
                                cursor: 'pointer',
                                transition: 'all 0.2s'
                            }}
                                onClick={() => navigate('/my-items')}
                                onMouseOver={(e) => {
                                    e.currentTarget.style.color = '#ef4444';
                                    e.currentTarget.style.borderColor = '#ef4444';
                                    e.currentTarget.style.backgroundColor = '#fef2f2';
                                }}
                                onMouseOut={(e) => {
                                    e.currentTarget.style.color = '#64748b';
                                    e.currentTarget.style.borderColor = '#e2e8f0';
                                    e.currentTarget.style.backgroundColor = 'transparent';
                                }}
                            >
                                <XCircle size={18} style={{ marginRight: '8px', verticalAlign: 'middle' }} />
                                Cancel Claim
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
                    @keyframes spin {
                        from { transform: rotate(0deg); }
                        to { transform: rotate(360deg); }
                    }
                    .spin-slow {
                        animation: spin 3s linear infinite;
                    }
                    .btn-hover:hover {
                        background-color: #14b8a6;
                        transform: translateY(-2px);
                    }
                `}</style>
            </main>
        </div>
    );
};

export default ClaimStatus;
