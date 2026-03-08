// ========================================== //
// SECTION 1: IMPORTS
// React and necessary icons for the header
// ========================================== //
import React, { useState, useRef, useEffect } from 'react';
import { useNavigate } from 'react-router-dom';
import { Search, Clock, ChevronLeft, LogOut, User, Settings } from 'lucide-react';

// ========================================== //
// SECTION 2: MAIN HEADER COMPONENT
// This component displays the page title, current date, 
// and a clickable user profile icon with a dropdown menu.
// ========================================== //
const Header = ({ title, subtitle, showBack = false, onBack, showSearch = true }) => {
    // Navigate between pages
    const navigate = useNavigate();

    // ========================================== //
    // STATE VARIABLES
    // ========================================== //
    // Controls whether the user profile dropdown is visible
    const [isDropdownOpen, setIsDropdownOpen] = useState(false);

    // A reference to the dropdown menu so we know if the user clicked outside of it
    const dropdownRef = useRef(null);

    // ========================================== //
    // REAL USER DATA FROM LOCAL STORAGE
    // ========================================== //
    const user = {
        name: localStorage.getItem('username') || "User",
        email: localStorage.getItem('userEmail') || "user@university.edu",
        get initials() {
            return this.name.split(' ').map(n => n[0]).join('').toUpperCase().substring(0, 2);
        }
    };

    // ========================================== //
    // EVENT LISTENERS
    // Close the profile dropdown when clicking anywhere else on the page
    // ========================================== //
    useEffect(() => {
        const handleClickOutside = (event) => {
            if (dropdownRef.current && !dropdownRef.current.contains(event.target)) {
                setIsDropdownOpen(false);
            }
        };
        document.addEventListener('mousedown', handleClickOutside);
        return () => document.removeEventListener('mousedown', handleClickOutside);
    }, []);

    // ========================================== //
    // HANDLERS
    // ========================================== //
    const handleLogout = () => {
        if (window.confirm("Are you sure you want to log out?")) {
            localStorage.removeItem('token');
            localStorage.removeItem('username');
            localStorage.removeItem('userEmail');
            navigate('/login');
        }
    };

    // Formatting todays date to show in the header
    const currentDate = new Date().toLocaleDateString('en-US', {
        month: 'short',
        day: 'numeric',
        year: 'numeric'
    });

    // ========================================== //
    // COMPONENT RENDER (LAYOUT)
    // ========================================== //
    return (
        <header className="top-header" style={{ position: 'relative' }}>

            {/* ------------------------------------------- */}
            {/* LEFT SIDE: Back Button (Optional) & Title */}
            {/* ------------------------------------------- */}
            <div className="welcome-text">
                {showBack && (
                    <button className="back-btn" onClick={onBack || (() => navigate(-1))}>
                        <ChevronLeft size={24} />
                    </button>
                )}
                <div>
                    <h1>{title}</h1>
                    {subtitle && <p className="sub-text">{subtitle}</p>}
                </div>
            </div>

            {/* ------------------------------------------- */}
            {/* RIGHT SIDE: Date, Search, and Profile */}
            {/* ------------------------------------------- */}
            <div className="header-actions">

                {/* Current Date Badge */}
                <div className="date-badge">
                    <Clock size={18} />
                    <span> {currentDate}</span>
                </div>

                {/* Optional Search Button */}
                {showSearch && (
                    <button className="icon-btn">
                        <Search size={20} />
                    </button>
                )}

                {/* User Profile Circle and Dropdown */}
                <div className="user-profile-relative" ref={dropdownRef} style={{ position: 'relative' }}>

                    {/* The small circle with user initials */}
                    <div
                        className="user-profile-sm"
                        onClick={() => setIsDropdownOpen(!isDropdownOpen)}
                        style={{ cursor: 'pointer', transition: 'transform 0.2s' }}
                    >
                        <div style={{
                            width: '40px', height: '40px', borderRadius: '50%', backgroundColor: '#ef4444',
                            display: 'flex', alignItems: 'center', justifyContent: 'center', color: 'white',
                            fontWeight: 'bold', fontSize: '0.9rem', border: '2px solid white',
                            boxShadow: '0 2px 8px rgba(0,0,0,0.1)'
                        }}>
                            {user.initials}
                        </div>
                    </div>

                    {/* The menu that drops down when you click the profile circle */}
                    {isDropdownOpen && (
                        <div className="profile-dropdown shadow-premium animate-fade-in" style={{
                            position: 'absolute', top: '120%', right: 0, width: '260px',
                            backgroundColor: 'white', borderRadius: '20px', padding: '1.25rem',
                            border: '1px solid #e2e8f0', zIndex: 1000,
                            boxShadow: '0 20px 25px -5px rgba(0, 0, 0, 0.1), 0 10px 10px -5px rgba(0, 0, 0, 0.04)'
                        }}>

                            {/* Dropdown Header (Name & Email) */}
                            <div className="dropdown-header" style={{
                                paddingBottom: '1rem', borderBottom: '1px solid #f1f5f9', marginBottom: '0.75rem'
                            }}>
                                <p style={{ margin: 0, fontSize: '0.8rem', color: '#94a3b8', fontWeight: 'bold', textTransform: 'uppercase', letterSpacing: '0.5px' }}>
                                    Logged in as
                                </p>
                                <h4 style={{ margin: '4px 0 0 0', color: '#1e293b', fontSize: '1.1rem', fontWeight: '800' }}>
                                    {user.name}
                                </h4>
                                <p style={{ margin: '2px 0 0 0', color: '#64748b', fontSize: '0.85rem' }}>
                                    {user.email}
                                </p>
                            </div>

                            {/* Dropdown Menu Links (Profile, Settings, Logout) */}
                            <div className="dropdown-menu" style={{ display: 'flex', flexDirection: 'column', gap: '4px' }}>

                                <button
                                    onClick={() => { navigate('/settings'); setIsDropdownOpen(false); }}
                                    style={{
                                        display: 'flex', alignItems: 'center', gap: '12px', padding: '0.75rem',
                                        border: 'none', background: 'transparent', borderRadius: '12px',
                                        color: '#475569', fontWeight: '600', cursor: 'pointer', textAlign: 'left', transition: 'all 0.2s'
                                    }}
                                    onMouseOver={(e) => { e.currentTarget.style.backgroundColor = '#f8fafc'; e.currentTarget.style.color = '#0d9488'; }}
                                    onMouseOut={(e) => { e.currentTarget.style.backgroundColor = 'transparent'; e.currentTarget.style.color = '#475569'; }}
                                >
                                    <User size={18} />
                                    Profile Details
                                </button>

                                <button
                                    onClick={() => { navigate('/settings'); setIsDropdownOpen(false); }}
                                    style={{
                                        display: 'flex', alignItems: 'center', gap: '12px', padding: '0.75rem',
                                        border: 'none', background: 'transparent', borderRadius: '12px',
                                        color: '#475569', fontWeight: '600', cursor: 'pointer', textAlign: 'left', transition: 'all 0.2s'
                                    }}
                                    onMouseOver={(e) => { e.currentTarget.style.backgroundColor = '#f8fafc'; e.currentTarget.style.color = '#0d9488'; }}
                                    onMouseOut={(e) => { e.currentTarget.style.backgroundColor = 'transparent'; e.currentTarget.style.color = '#475569'; }}
                                >
                                    <Settings size={18} />
                                    Account Settings
                                </button>

                                <div style={{ height: '1px', background: '#f1f5f9', margin: '4px 0' }}></div>

                                <button
                                    onClick={handleLogout}
                                    style={{
                                        display: 'flex', alignItems: 'center', gap: '12px', padding: '0.75rem',
                                        border: 'none', background: 'transparent', borderRadius: '12px',
                                        color: '#ef4444', fontWeight: '700', cursor: 'pointer', textAlign: 'left', transition: 'all 0.2s'
                                    }}
                                    onMouseOver={(e) => { e.currentTarget.style.backgroundColor = '#fef2f2'; }}
                                    onMouseOut={(e) => { e.currentTarget.style.backgroundColor = 'transparent'; }}
                                >
                                    <LogOut size={18} />
                                    Sign Out
                                </button>

                            </div>
                        </div>
                    )}
                </div>
            </div>

            {/* Inline CSS just for this component */}
            <style>{`
                @keyframes fadeIn {
                    from { opacity: 0; transform: translateY(10px); }
                    to { opacity: 1; transform: translateY(0); }
                }
                .animate-fade-in {
                    animation: fadeIn 0.3s ease-out;
                }
            `}</style>
        </header>
    );
};

export default Header;
