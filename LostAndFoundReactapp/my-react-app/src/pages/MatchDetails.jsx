// ========================================== //
// SECTION 1: IMPORTS
// React and UI layout icons
// ========================================== //
import React from 'react';
import { useNavigate } from 'react-router-dom';
import {
    ChevronLeft, Wallet, Calendar, MapPin,
    CheckCircle, XCircle, Clock, Info
} from 'lucide-react';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';

// ========================================== //
// SECTION 2: MAIN MATCH DETAILS COMPONENT
// This page shows a side-by-side comparison of an item you lost 
// and a similar item that someone else found.
// Used to verify if the found item is actually yours.
// ========================================== //
const MatchDetails = () => {
    // Allows us to navigate between pages
    const navigate = useNavigate();

    // ========================================== //
    // FAKE DATA
    // Contains info on what was lost vs what was found.
    // ========================================== //
    const matchData = {
        lostItem: {
            title: "Brown Leather Wallet",
            date: "Nov 5, 2023",
            icon: <Wallet size={24} />,
            color: "#319795"
        },
        foundItem: {
            title: "Brown Wallet",
            dateFound: "Nov 5, 2023",
            location: "Central Park Cafe",
            imageUrl: "https://images.unsplash.com/photo-1627123424574-724758594e93?auto=format&fit=crop&q=80&w=800", // High quality brown wallet image
            description: "Genuine brown leather bifold wallet with some cards inside. Found near the corner table."
        }
    };

    // ========================================== //
    // LAYOUT RENDERING
    // ========================================== //
    return (
        <div className="dashboard-container">
            {/* Left Sidebar Menu */}
            <Sidebar />

            <main className="main-content" style={{
                background: 'linear-gradient(135deg, #f0fdfa 0%, #f1f5f9 100%)',
                minHeight: '100vh', padding: '3rem'
            }}>
                <div style={{ maxWidth: '800px', margin: '0 auto' }}>

                    {/* ------------------------------------------- */}
                    {/* SECTION 3: TOP HEADER */}
                    {/* Shows the back button and title */}
                    {/* ------------------------------------------- */}
                    <Header
                        title="Potential Match Details"
                        subtitle="Review the found item's information"
                        showBack={true}
                        onBack={() => navigate('/my-items')}
                    />

                    <div style={{ display: 'flex', flexDirection: 'column', gap: '2rem' }}>

                        {/* ------------------------------------------- */}
                        {/* SECTION 4: YOUR LOST ITEM CARD */}
                        {/* Highlights the item the user is looking for */}
                        {/* ------------------------------------------- */}
                        <div style={{
                            backgroundColor: 'rgba(255, 255, 255, 0.7)',
                            backdropFilter: 'blur(10px)', borderRadius: '24px', padding: '1.75rem',
                            border: '1px solid rgba(255, 255, 255, 0.8)',
                            boxShadow: '0 10px 30px -10px rgba(0,0,0,0.05)',
                            animation: 'fadeInUp 0.6s ease-out'
                        }}>
                            <div style={{ display: 'flex', gap: '1.25rem', alignItems: 'center' }}>
                                <div style={{
                                    width: '56px', height: '56px', backgroundColor: '#f0fdfa',
                                    borderRadius: '16px', display: 'flex', alignItems: 'center', justifyContent: 'center',
                                    color: matchData.lostItem.color, border: '1px solid #ccfbf1'
                                }}>
                                    {matchData.lostItem.icon}
                                </div>
                                <div>
                                    <h2 style={{ fontSize: '1.1rem', fontWeight: '800', color: '#0d9488', margin: '0 0 2px 0', textTransform: 'uppercase', letterSpacing: '0.05em' }}>
                                        Your Lost Item
                                    </h2>
                                    <h3 style={{ fontSize: '1.4rem', fontWeight: '800', color: '#2d3748', margin: '0 0 6px 0' }}>
                                        Lost: {matchData.lostItem.title}
                                    </h3>
                                    <div style={{ display: 'flex', gap: '1rem', color: '#718096', fontSize: '0.9rem' }}>
                                        <span style={{ display: 'flex', alignItems: 'center', gap: '6px' }}>
                                            <Calendar size={14} /> Reported: {matchData.lostItem.date}
                                        </span>
                                    </div>
                                </div>
                            </div>
                        </div>

                        {/* ------------------------------------------- */}
                        {/* SECTION 5: THE FOUND ITEM CARD */}
                        {/* Displays picture and details of what was found */}
                        {/* ------------------------------------------- */}
                        <div style={{
                            backgroundColor: 'white', borderRadius: '28px', padding: '2rem',
                            boxShadow: '0 20px 40px -20px rgba(0,0,0,0.1)', border: '1px solid #edf2f7',
                            animation: 'fadeInUp 0.7s ease-out'
                        }}>
                            <h2 style={{ fontSize: '1.5rem', fontWeight: '900', color: '#1a202c', marginBottom: '1.5rem' }}>
                                Found Item Details
                            </h2>

                            {/* Big Image Frame */}
                            <div style={{
                                width: '100%', height: '280px', borderRadius: '20px', overflow: 'hidden',
                                marginBottom: '1.5rem', border: '1px solid #f1f5f9'
                            }}>
                                <img
                                    src={matchData.foundItem.imageUrl}
                                    alt="Found Item"
                                    style={{ width: '100%', height: '100%', objectFit: 'cover' }}
                                />
                            </div>

                            <div style={{ display: 'flex', flexDirection: 'column', gap: '1.25rem' }}>

                                {/* Info text */}
                                <div>
                                    <h3 style={{ fontSize: '1.3rem', fontWeight: '800', color: '#2d3748', margin: '0 0 8px 0' }}>
                                        Found: {matchData.foundItem.title}
                                    </h3>
                                    <div style={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '1rem' }}>
                                        <div style={{ display: 'flex', alignItems: 'center', gap: '8px', color: '#718096', fontSize: '1rem' }}>
                                            <Calendar size={18} color="#319795" />
                                            <span>Date Found: {matchData.foundItem.dateFound}</span>
                                        </div>
                                        <div style={{ display: 'flex', alignItems: 'center', gap: '8px', color: '#718096', fontSize: '1rem' }}>
                                            <MapPin size={18} color="#319795" />
                                            <span>Location: {matchData.foundItem.location}</span>
                                        </div>
                                    </div>
                                </div>

                                {/* Description Box */}
                                <div style={{
                                    backgroundColor: '#f8fafc', padding: '1.25rem',
                                    borderRadius: '16px', border: '1px solid #f1f5f9'
                                }}>
                                    <p style={{ margin: 0, color: '#4a5568', lineHeight: '1.6', fontSize: '1rem' }}>
                                        {matchData.foundItem.description}
                                    </p>
                                </div>

                                {/* ------------------------------------------- */}
                                {/* SECTION 6: ACTION BUTTONS (CLAIM / REJECT) */}
                                {/* ------------------------------------------- */}
                                <div style={{ display: 'flex', gap: '1.25rem', marginTop: '1rem' }}>

                                    {/* Claim Item Button (Green) */}
                                    <button
                                        className="submit-action-btn"
                                        style={{
                                            flex: 2, display: 'flex', alignItems: 'center',
                                            justifyContent: 'center', gap: '10px'
                                        }}
                                        onClick={() => navigate('/claim-item')}
                                    >
                                        <CheckCircle size={20} />
                                        Claim This Item
                                    </button>

                                    {/* Not a Match Button (Grey, changes to Red) */}
                                    <button
                                        style={{
                                            flex: 1, padding: '1rem', borderRadius: '12px',
                                            border: '2px solid #e2e8f0', backgroundColor: 'white', color: '#64748b',
                                            fontWeight: '700', fontSize: '1rem', cursor: 'pointer',
                                            display: 'flex', alignItems: 'center', justifyContent: 'center', gap: '10px',
                                            transition: 'all 0.2s'
                                        }}
                                        onClick={() => navigate('/my-items')}
                                        onMouseOver={(e) => {
                                            e.currentTarget.style.borderColor = '#ef4444';
                                            e.currentTarget.style.color = '#ef4444';
                                            e.currentTarget.style.backgroundColor = '#fef2f2';
                                        }}
                                        onMouseOut={(e) => {
                                            e.currentTarget.style.borderColor = '#e2e8f0';
                                            e.currentTarget.style.color = '#64748b';
                                            e.currentTarget.style.backgroundColor = 'white';
                                        }}
                                    >
                                        <XCircle size={20} />
                                        Not a Match
                                    </button>
                                </div>
                            </div>
                        </div>

                        {/* ------------------------------------------- */}
                        {/* SECTION 7: AI CONFIDENCE REPORT */}
                        {/* Automated message explaining why it matched */}
                        {/* ------------------------------------------- */}
                        <div style={{
                            display: 'flex', alignItems: 'start', gap: '1rem', padding: '1.25rem',
                            backgroundColor: 'rgba(49, 151, 149, 0.05)', borderRadius: '20px',
                            border: '1px solid rgba(49, 151, 149, 0.1)', animation: 'fadeInUp 0.8s ease-out'
                        }}>
                            <Info size={20} color="#319795" style={{ marginTop: '2px' }} />
                            <p style={{ margin: 0, fontSize: '0.9rem', color: '#134e4a', fontWeight: '500', lineHeight: '1.5' }}>
                                Based on our AI analysis, this item has a 95% match confidence with your report. Our system identified the color "Brown" and category "Wallet" as exact matches.
                            </p>
                        </div>

                    </div>
                </div>

                {/* Inline CSS only for this page */}
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
                        filter: brightness(1.05);
                    }
                `}</style>
            </main>
        </div>
    );
};

export default MatchDetails;
