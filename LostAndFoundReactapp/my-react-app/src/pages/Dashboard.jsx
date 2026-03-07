// ========================================== //
// SECTION 1: IMPORTS
// React and UI layout components (Sidebar, Header)
// Lucide-react supplies the icons used on the dashboard buttons.
// 'useNavigate' allows us to move between pages when buttons are clicked.
// ========================================== //
import React from 'react';
import { Search, Gavel, RefreshCw } from 'lucide-react';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';
import { useNavigate } from 'react-router-dom';

// ========================================== //
// SECTION 2: MAIN DASHBOARD COMPONENT
// This is the main "Home" screen for normal students/users.
// It shows 4 quick action buttons to let them pick what they want to do.
// ========================================== //
const Dashboard = () => {
    // We use this to travel to other pages when a button is clicked
    const navigate = useNavigate();

    // ========================================== //
    // PAGE LAYOUT BEGINS
    // ========================================== //
    return (
        <div className="dashboard-container">

            {/* ------------------------------------------- */}
            {/* SECTION 3: SIDEBAR MENU */}
            {/* This is the left-side navigation menu. */}
            {/* Notice 'isAdmin' is not true here, so it shows User links! */}
            {/* ------------------------------------------- */}
            <Sidebar />

            {/* ------------------------------------------- */}
            {/* SECTION 4: MAIN CONTENT AREA (RIGHT SIDE) */}
            {/* ------------------------------------------- */}
            <main className="main-content">

                {/* 4A. Top Header showing User Name and Subtitle */}
                <Header
                    title="Welcome, Mudassar!"
                    subtitle="Access your quick actions below."
                />

                <div className="content-wrapper">

                    {/* Page Title inside the content area */}
                    <h2 className="section-title">Quick Actions</h2>

                    {/* ------------------------------------------- */}
                    {/* SECTION 5: ACTION BUTTONS GRID */}
                    {/* This grid holds the 4 main buttons on the dashboard */}
                    {/* ------------------------------------------- */}
                    <div className="dashboard-grid">

                        {/* Button 1: Report Lost Item (Teal Color) */}
                        <button className="dashboard-card card-teal" onClick={() => navigate('/report-lost')}>
                            <div className="card-icon">
                                <Search size={28} />
                            </div>
                            <div className="card-text">
                                <h3>Report Lost</h3>
                                <p>Register a lost item</p>
                            </div>
                        </button>

                        {/* Button 2: Report Found Item (Blue Color) */}
                        <button className="dashboard-card card-blue" onClick={() => navigate('/report-found')}>
                            <div className="card-icon">
                                <Search size={28} />
                            </div>
                            <div className="card-text">
                                <h3>Report Found</h3>
                                <p>Register a found item</p>
                            </div>
                        </button>

                        {/* Button 3: Found Item Auction (Orange Color) */}
                        <button className="dashboard-card card-orange" onClick={() => navigate('/auction')}>
                            <div className="card-icon">
                                <Gavel size={28} />
                            </div>
                            <div className="card-text">
                                <h3>Auctions</h3>
                                <p>Bid on unclaimed items</p>
                            </div>
                        </button>

                        {/* Button 4: Item Replacement (Purple Color) */}
                        <button className="dashboard-card card-purple" onClick={() => navigate('/item-replacement')}>
                            <div className="card-icon">
                                <RefreshCw size={28} />
                            </div>
                            <div className="card-text">
                                <h3>Replacement</h3>
                                <p>Request item replacement</p>
                            </div>
                        </button>

                    </div> {/* End of Action Buttons Grid */}

                </div>
            </main>
        </div>
    );
};

export default Dashboard;
