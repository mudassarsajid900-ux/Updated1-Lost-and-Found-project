// ========================================== //
// SECTION 1: IMPORTS
// We import React and icons used in the Sidebar
// ========================================== //
import React from 'react';
import { Home, Folder, PlusCircle, Gavel, Settings, LogOut, User } from 'lucide-react';
import { useNavigate, useLocation } from 'react-router-dom';

// ========================================== //
// SECTION 2: MAIN SIDEBAR COMPONENT
// This is the left-side navigation menu seen on almost every page.
// It changes its layout depending on if an Admin is logged in or a regular student.
// ========================================== //
const Sidebar = ({ isAdmin = false }) => {
    // Allows us to navigate between pages when a link is clicked
    const navigate = useNavigate();

    // Gives us the current URL (e.g. '/dashboard') so we can highlight the active link
    const location = useLocation();

    // ========================================== //
    // HELPER FUNCTIONS
    // ========================================== //

    // Checks if the button's path matches the current URL. If yes, it highlights it.
    const isActive = (path) => location.pathname === path;

    // Sets the home route based on whether the user is an admin or not
    const homePath = isAdmin ? '/admin-dashboard' : '/dashboard';

    // ========================================== //
    // COMPONENT HTML / UI RENDER
    // ========================================== //
    return (
        <aside className="sidebar">

            {/* ------------------------------------------- */}
            {/* SECTION 3: SIDEBAR TOP LOGO */}
            {/* Contains the teal logo gradient box and "L&F Hub" text */}
            {/* ------------------------------------------- */}
            <div className="sidebar-header" style={{ display: 'flex', alignItems: 'center', gap: '12px' }}>
                <div style={{
                    width: '32px',
                    height: '32px',
                    background: 'linear-gradient(135deg, #e6fffa 0%, #b2f5ea 100%)',
                    borderRadius: '10px',
                    display: 'flex',
                    alignItems: 'center',
                    justifyContent: 'center',
                    boxShadow: '0 4px 8px rgba(49, 151, 149, 0.15)',
                    border: '1px solid rgba(49, 151, 149, 0.1)'
                }}>
                    <User size={18} color="#319795" />
                </div>
                <span className="brand-text">Lost & Found </span>
            </div>

            {/* ------------------------------------------- */}
            {/* SECTION 4: NAVIGATION LINKS */}
            {/* Splits into two different menus based on Admin status */}
            {/* ------------------------------------------- */}
            <nav className="sidebar-nav">
                {isAdmin ? (
                    // ====================================
                    // MENU A: ADMIN MENU
                    // Shows Admin settings, User Management, etc.
                    // ====================================
                    <>
                        <button
                            className={`nav-item ${isActive(homePath) ? 'active' : ''}`}
                            onClick={() => navigate(homePath)}
                        >
                            <Home size={20} />
                            <span>Admin Home</span>
                        </button>
                        <button
                            className={`nav-item ${isActive('/admin-users') ? 'active' : ''}`}
                            onClick={() => navigate('/admin-users')}
                        >
                            <User size={20} />
                            <span>Manage Users</span>
                        </button>
                        <button
                            className={`nav-item ${isActive('/admin-reports') ? 'active' : ''}`}
                            onClick={() => navigate('/admin-reports')}
                        >
                            <Folder size={20} />
                            <span>All Reports</span>
                        </button>
                        <button
                            className={`nav-item ${isActive('/admin-auctions') ? 'active' : ''}`}
                            onClick={() => navigate('/admin-auctions')}
                        >
                            <Gavel size={20} />
                            <span>Manage Auctions</span>
                        </button>
                        <button
                            className={`nav-item ${isActive('/admin-settings') ? 'active' : ''}`}
                            onClick={() => navigate('/admin-settings')}
                        >
                            <Settings size={20} />
                            <span>System Settings</span>
                        </button>
                    </>
                ) : (
                    // ====================================
                    // MENU B: REGULAR USER MENU
                    // Shows Dashboard, Lost Items, Found Items, etc.
                    // ====================================
                    <>
                        <button
                            className={`nav-item ${isActive(homePath) ? 'active' : ''}`}
                            onClick={() => navigate(homePath)}
                        >
                            <Home size={20} />
                            <span>Home</span>
                        </button>
                        <button
                            className={`nav-item ${isActive('/my-items') || isActive('/match-details') ? 'active' : ''}`}
                            onClick={() => navigate('/my-items')}
                        >
                            <Folder size={20} />
                            <span>My Items</span>
                        </button>
                        <button
                            className={`nav-item ${isActive('/report-lost') ? 'active' : ''}`}
                            onClick={() => navigate('/report-lost')}
                        >
                            <PlusCircle size={20} />
                            <span>Add New</span>
                        </button>
                        <button
                            className={`nav-item ${isActive('/auction') ? 'active' : ''}`}
                            onClick={() => navigate('/auction')}
                        >
                            <Gavel size={20} />
                            <span>Auction</span>
                        </button>
                        <button
                            className={`nav-item ${isActive('/settings') ? 'active' : ''}`}
                            onClick={() => navigate('/settings')}
                        >
                            <Settings size={20} />
                            <span>Settings</span>
                        </button>
                    </>
                )}
            </nav>

            {/* ------------------------------------------- */}
            {/* SECTION 5: LOWER LOGOUT BUTTON */}
            {/* Returns user to the login screen */}
            {/* ------------------------------------------- */}
            <div className="sidebar-footer">
                <button className="nav-item logout" onClick={() => {
                    localStorage.removeItem('token');
                    localStorage.removeItem('username');
                    localStorage.removeItem('userEmail');
                    navigate('/login');
                }}>
                    <LogOut size={20} />
                    <span>Logout</span>
                </button>
            </div>
        </aside>
    );
};

export default Sidebar;
