// ========================================== //
// SECTION 1: IMPORTS
// We import React and icons
// ========================================== //
import React from 'react';
import { useNavigate } from 'react-router-dom';
import {
    ChevronLeft, Wallet, CheckCircle,
    XCircle, ChevronRight, User
} from 'lucide-react';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';

// ========================================== //
// SECTION 2: MAIN REVIEW CLAIM COMPONENT
// This page is shown when someone tries to claim an item you found.
// You review their answers to security questions here.
// ========================================== //
const ReviewClaim = () => {
    // Allows us to navigate between pages when buttons are clicked
    const navigate = useNavigate();

    // ========================================== //
    // FAKE DATA SECTION
    // This info would normally come from a database.
    // It shows the item, the person claiming it, and their given answer.
    // ========================================== //
    const claimInfo = {
        foundItem: {
            title: "Brown Leather Wallet",
            date: "Nov 5, 2023",
            imageUrl: "https://images.unsplash.com/photo-1627123424574-724758594e93?auto=format&fit=crop&q=80&w=200"
        },
        claimant: {
            name: "ALi .",
            avatarUrl: "https://ui-avatars.com/api/?name=Ali&background=319795&color=fff"
        },
        verification: {
            question: "What color is the wallet?",
            answer: "Brown"
        }
    };

    // ========================================== //
    // PAGE RENDER AND LAYOUT
    // ========================================== //
    return (
        <div className="dashboard-container">
            {/* Show left Sidebar menu */}
            <Sidebar />

            <main className="main-content" style={{
                background: 'linear-gradient(135deg, #f0fdfa 0%, #f1f5f9 100%)',
                minHeight: '100vh',
                padding: '3rem'
            }}>
                <div style={{ maxWidth: '600px', margin: '0 auto' }}>

                    {/* ------------------------------------------- */}
                    {/* SECTION 3: TOP HEADER */}
                    {/* ------------------------------------------- */}
                    <Header
                        title="Review Item Claim"
                        subtitle="Verify the claimant's details."
                        showBack={true}
                        onBack={() => navigate('/my-items')}
                    />

                    <div style={{ display: 'flex', flexDirection: 'column', gap: '1.5rem' }}>

                        {/* ------------------------------------------- */}
                        {/* SECTION 4: 'YOUR FOUND ITEM' CARD */}
                        {/* Shows the image and name of the item you found */}
                        {/* ------------------------------------------- */}
                        <div style={{ animation: 'fadeInUp 0.6s ease-out' }}>
                            <h2 style={{ fontSize: '1.25rem', fontWeight: '800', color: '#1a202c', marginBottom: '1rem' }}>
                                Your Found Item
                            </h2>
                            <div style={{
                                backgroundColor: 'white',
                                borderRadius: '24px',
                                padding: '1.25rem',
                                border: '1px solid #edf2f7',
                                display: 'flex',
                                gap: '1.25rem',
                                alignItems: 'center',
                                boxShadow: '0 4px 12px rgba(0,0,0,0.02)'
                            }}>
                                {/* Item Image Box */}
                                <div style={{
                                    width: '80px', height: '80px', borderRadius: '16px',
                                    overflow: 'hidden', border: '1px solid #f1f5f9'
                                }}>
                                    <img src={claimInfo.foundItem.imageUrl} alt="Item" style={{ width: '100%', height: '100%', objectFit: 'cover' }} />
                                </div>
                                {/* Item Titles */}
                                <div>
                                    <h3 style={{ margin: 0, fontSize: '1.1rem', fontWeight: '800', color: '#2d3748' }}>
                                        Found: {claimInfo.foundItem.title}
                                    </h3>
                                    <p style={{ margin: '4px 0 0 0', fontSize: '0.9rem', color: '#718096' }}>
                                        Reported: {claimInfo.foundItem.date}
                                    </p>
                                </div>
                            </div>
                        </div>

                        {/* ------------------------------------------- */}
                        {/* SECTION 5: CLAIMANT CARD */}
                        {/* Shows who is trying to claim the item */}
                        {/* ------------------------------------------- */}
                        <div style={{
                            backgroundColor: 'white',
                            borderRadius: '20px',
                            padding: '1.25rem',
                            border: '1px solid #edf2f7',
                            display: 'flex',
                            gap: '1rem',
                            alignItems: 'center',
                            animation: 'fadeInUp 0.7s ease-out'
                        }}>
                            <div style={{ flex: 1 }}>
                                <span style={{ fontSize: '1.1rem', fontWeight: '700', color: '#2d3748' }}>
                                    Claimed by: {claimInfo.claimant.name}
                                </span>
                            </div>
                            {/* Claimant Avatar */}
                            <div style={{
                                width: '44px', height: '44px', borderRadius: '50%',
                                overflow: 'hidden', border: '2px solid white',
                                boxShadow: '0 2px 8px rgba(0,0,0,0.1)'
                            }}>
                                <img src={claimInfo.claimant.avatarUrl} alt="Claimant" style={{ width: '100%', height: '100%' }} />
                            </div>
                        </div>

                        {/* ------------------------------------------- */}
                        {/* SECTION 6: VERIFICATION QUESTIONS CARD */}
                        {/* Shows question and answer to verify ownership */}
                        {/* ------------------------------------------- */}
                        <div style={{ animation: 'fadeInUp 0.8s ease-out' }}>
                            <h2 style={{ fontSize: '1.25rem', fontWeight: '800', color: '#1a202c', marginBottom: '1rem' }}>
                                Claim Verification
                            </h2>
                            <div style={{
                                backgroundColor: 'rgba(255, 255, 255, 0.7)',
                                backdropFilter: 'blur(10px)',
                                borderRadius: '24px',
                                padding: '1.75rem',
                                border: '1px solid rgba(255, 255, 255, 0.8)',
                                display: 'flex',
                                alignItems: 'center',
                                gap: '1rem'
                            }}>
                                <div style={{ flex: 1 }}>
                                    <h3 style={{ margin: 0, fontSize: '1.1rem', fontWeight: '700', color: '#2d3748', lineHeight: '1.5' }}>
                                        Security Question: {claimInfo.verification.question}
                                    </h3>
                                    <p style={{ margin: '8px 0 0 0', fontSize: '1rem', color: '#4a5568', fontWeight: '500' }}>
                                        Answer provided: <span style={{ color: '#0d9488', fontWeight: '700' }}>{claimInfo.verification.answer}</span>
                                    </p>
                                </div>
                                <ChevronRight size={20} color="#cbd5e0" />
                            </div>
                        </div>

                        {/* ------------------------------------------- */}
                        {/* SECTION 7: ACTION BUTTONS */}
                        {/* Accept or Reject Claim */}
                        {/* ------------------------------------------- */}
                        <div style={{ display: 'flex', flexDirection: 'column', gap: '1rem', marginTop: '1.5rem', paddingBottom: '3rem' }}>

                            {/* Accept/Verify Button (Green) */}
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
                                    animation: 'fadeInUp 0.9s ease-out'
                                }}
                                onClick={() => {
                                    alert('Ownership verified! Pickup arranged.');
                                    navigate('/my-items');
                                }}
                            >
                                Verify Ownership & Arrange Pickup
                                <CheckCircle size={20} />
                            </button>

                            {/* Reject Button (White/Red on hover) */}
                            <button
                                style={{
                                    width: '100%',
                                    padding: '1.1rem',
                                    borderRadius: '16px',
                                    backgroundColor: 'transparent',
                                    color: '#64748b',
                                    fontWeight: '700',
                                    fontSize: '1.1rem',
                                    border: '1px solid #e2e8f0',
                                    cursor: 'pointer',
                                    display: 'flex',
                                    alignItems: 'center',
                                    justifyContent: 'center',
                                    gap: '10px',
                                    transition: 'all 0.2s',
                                    animation: 'fadeInUp 1s ease-out'
                                }}
                                onClick={() => {
                                    if (window.confirm('Are you sure you want to reject this claim?')) {
                                        navigate('/my-items');
                                    }
                                }}
                                // Make it turn red when hovered
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
                                Reject Claim
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

export default ReviewClaim;
