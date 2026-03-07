// ========================================== //
// SECTION 1: IMPORTS
// React and UI layout components (Sidebar, Header)
// Lucide-react supplies all the icons used in the dashboard.
// ========================================== //
import React from 'react';
import {
    Camera, Search, Gavel, RefreshCw, Settings,
    Handshake, Users, ClipboardList, Clock,
    Activity, CheckCircle, Bell, User,
    ArrowLeft, ChevronRight, CheckSquare, Square
} from 'lucide-react';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';
import { useNavigate } from 'react-router-dom';

// ========================================== //
// SECTION 2: MAIN ADMIN DASHBOARD COMPONENT
// This page is restricted to administrators and shows a high-level overview.
// ========================================== //
const AdminDashboard = () => {
    // Allows us to redirect or go back to previous pages
    const navigate = useNavigate();

    // ========================================== //
    // DATA CONFIGURATIONS (Dummy Data)
    // These arrays store the data for buttons, activities, and tasks.
    // In a real application, this data would come from a database.
    // ========================================== //

    // Quick Action Buttons Data
    const quickActions = [
        { title: 'Manage Lost Item', icon: <Camera size={28} />, color: '#0ea5e9', sub: 'camera' },
        { title: 'Manage Found Item', icon: <Search size={28} />, color: '#38bdf8', sub: 'search' },
        { title: 'Found Item Auction', icon: <Gavel size={28} />, color: '#f43f5e', sub: 'gavel' },
        { title: 'Item Replacement', icon: <RefreshCw size={28} />, color: '#8b5cf6', sub: 'refresh' },
        { title: 'Item Handover', icon: <Handshake size={28} />, color: '#10b981', sub: 'handshake' },
        { title: 'System Settings', icon: <Settings size={28} />, color: '#64748b', sub: 'settings' },
    ];

    // Recent Activity Feed Data
    const activities = [
        { user: 'Mudasir', action: 'submitted a new Lost Reports', time: '5 mins ago', icon: <User size={16} color="#3b82f6" />, bg: '#eff6ff' },
        { user: 'ALi Haider', action: 'reported Lost: Keys', time: '15 mins ago', icon: <User size={16} color="#3b82f6" />, bg: '#eff6ff' },
        { user: 'Sarah K.', action: 'approved Claim Silver Watch', role: 'Admin', time: '30 mins ago', icon: <CheckCircle size={16} color="#10b981" />, bg: '#f0fdf4' },
        { action: 'New bid placed on Unclaimed Laptop', time: '1 hour ago', icon: <Bell size={16} color="#3b82f6" />, bg: '#eff6ff' },
        { user: 'Zafar', action: 'updated profile information', time: '2 hours ago', icon: <User size={16} color="#3b82f6" />, bg: '#eff6ff' },
    ];

    // Admin Tasks Todo List Data
    const tasks = [
        { label: 'Review Lost Report: Wallet', completed: true },
        { label: 'Verify User: ALI', completed: false },
        { label: 'Verify User: Qasim', completed: false },
        { label: 'Approve Auction: Bag', completed: false },
    ];

    // ========================================== //
    // PAGE LAYOUT BEGINS
    // ========================================== //
    return (
        <div className="dashboard-container">
            {/* Display the Sidebar. 'isAdmin={true}' forces it to show Admin links */}
            <Sidebar isAdmin={true} />

            {/* Main right-side content area */}
            <main className="main-content" style={{ background: '#f8fafc', padding: '2.5rem' }}>
                <Header
                    title="Administrator Control Panel"
                    subtitle="Monitor system activities, review reports, and manage settings."
                />

                <div className="content-wrapper" style={{ marginTop: '2rem' }}>

                    {/* ------------------------------------------- */}
                    {/* SECTION 3: TOP NAVIGATION BAR */}
                    {/* Back button and page title */}
                    {/* ------------------------------------------- */}
                    <div style={{ display: 'flex', alignItems: 'center', gap: '1rem', marginBottom: '2.5rem' }}>
                        {/* Go Back to the previous page button */}
                        <button onClick={() => navigate(-1)} style={{
                            background: 'white', border: '1px solid #e2e8f0', borderRadius: '12px',
                            width: '44px', height: '44px', display: 'flex', alignItems: 'center', justifyContent: 'center',
                            cursor: 'pointer', boxShadow: '0 2px 4px rgba(0,0,0,0.02)', transition: 'all 0.2s'
                        }} onMouseOver={(e) => e.currentTarget.style.backgroundColor = '#f1f5f9'} onMouseOut={(e) => e.currentTarget.style.backgroundColor = 'white'}>
                            <ArrowLeft size={20} color="#64748b" />
                        </button>
                        <div>
                            <h2 style={{ margin: 0, fontSize: '1.75rem', fontWeight: '800', color: '#1e293b', letterSpacing: '-0.5px' }}>Admin Overview</h2>
                            <p style={{ margin: '4px 0 0 0', color: '#64748b', fontSize: '0.95rem' }}>Manage your Lost & Found ecosystem efficiently.</p>
                        </div>
                    </div>

                    {/* ------------------------------------------- */}
                    {/* SECTION 4: QUICK ACTIONS GRID */}
                    {/* These are the clickable colored cards (Manage items, Auction, etc) */}
                    {/* ------------------------------------------- */}
                    <div style={{ marginBottom: '3.5rem' }}>
                        <h3 style={{ fontSize: '1.25rem', fontWeight: '700', color: '#334155', marginBottom: '1.5rem', display: 'flex', alignItems: 'center', gap: '8px' }}>
                            <Activity size={20} color="#3b82f6" />
                            Quick Actions
                        </h3>

                        <div style={{
                            display: 'grid',
                            gridTemplateColumns: 'repeat(auto-fit, minmax(220px, 1fr))',
                            gap: '1.5rem'
                        }}>
                            {/* Loop through the 'quickActions' array and generate a card for each */}
                            {quickActions.map((action, idx) => (
                                <button
                                    key={idx}
                                    style={{
                                        background: `linear-gradient(135deg, ${action.color} 0%, ${action.color}dd 100%)`,
                                        height: '160px',
                                        padding: '1.5rem',
                                        borderRadius: '20px',
                                        border: 'none',
                                        display: 'flex',
                                        flexDirection: 'column',
                                        justifyContent: 'space-between',
                                        alignItems: 'flex-start',
                                        cursor: 'pointer',
                                        transition: 'transform 0.2s, box-shadow 0.2s',
                                        boxShadow: `0 10px 15px -3px ${action.color}33`,
                                        position: 'relative',
                                        overflow: 'hidden'
                                    }}
                                    onMouseOver={(e) => { e.currentTarget.style.transform = 'translateY(-4px)'; e.currentTarget.style.boxShadow = `0 15px 25px -5px ${action.color}44`; }}
                                    onMouseOut={(e) => { e.currentTarget.style.transform = 'none'; e.currentTarget.style.boxShadow = `0 10px 15px -3px ${action.color}33`; }}
                                >
                                    {/* Giant faint icon in the background of the card */}
                                    <div style={{
                                        position: 'absolute', right: '-20px', bottom: '-20px', opacity: 0.1, transform: 'scale(2.5)'
                                    }}>
                                        {action.icon}
                                    </div>

                                    {/* Glassy icon box in the top corner of the card */}
                                    <div style={{
                                        background: 'rgba(255,255,255,0.25)',
                                        backdropFilter: 'blur(4px)',
                                        padding: '12px',
                                        borderRadius: '14px',
                                        display: 'flex',
                                        alignItems: 'center',
                                        justifyContent: 'center'
                                    }}>
                                        {React.cloneElement(action.icon, { color: 'white' })}
                                    </div>

                                    {/* Card Text Title */}
                                    <h4 style={{ margin: 0, fontSize: '1.05rem', fontWeight: '700', color: 'white', textAlign: 'left', lineHeight: '1.3', zIndex: 1 }}>
                                        {action.title}
                                    </h4>
                                </button>
                            ))}
                        </div>
                    </div>

                    {/* ------------------------------------------- */}
                    {/* SECTION 5: LOWER DASHBOARD LAYOUT (2 Columns) */}
                    {/* The left column contains Health & Feed, the right contains Tasks. */}
                    {/* ------------------------------------------- */}
                    <div style={{ display: 'grid', gridTemplateColumns: 'repeat(auto-fit, minmax(400px, 1fr))', gap: '2.5rem' }}>

                        {/* LEFT COLUMN */}
                        <section>

                            {/* 5A. System Health Number Cards */}
                            <h3 style={{ fontSize: '1.25rem', fontWeight: '700', color: '#334155', marginBottom: '1.5rem', display: 'flex', alignItems: 'center', gap: '8px' }}>
                                <Activity size={20} color="#10b981" />
                                System Health
                            </h3>
                            <div style={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '1.5rem' }}>

                                {/* Card 1: Total Users */}
                                <div style={{ background: 'white', padding: '1.75rem', borderRadius: '20px', border: '1px solid #e2e8f0', boxShadow: '0 4px 6px rgba(0,0,0,0.02)' }}>
                                    <div style={{ color: '#64748b', fontSize: '0.9rem', marginBottom: '0.5rem', fontWeight: '600', textTransform: 'uppercase', letterSpacing: '0.5px' }}>Total Users</div>
                                    <div style={{ display: 'flex', alignItems: 'flex-end', gap: '8px' }}>
                                        <div style={{ fontSize: '2.5rem', fontWeight: '800', color: '#1e293b', lineHeight: '1' }}>1,250</div>
                                        <div style={{ color: '#10b981', fontSize: '0.9rem', fontWeight: '600', marginBottom: '4px' }}>+12%</div>
                                    </div>
                                </div>

                                {/* Card 2: Pending Reports */}
                                <div style={{ background: 'white', padding: '1.75rem', borderRadius: '20px', border: '1px solid #e2e8f0', boxShadow: '0 4px 6px rgba(0,0,0,0.02)' }}>
                                    <div style={{ color: '#64748b', fontSize: '0.9rem', marginBottom: '0.5rem', fontWeight: '600', textTransform: 'uppercase', letterSpacing: '0.5px' }}>Pending Reports</div>
                                    <div style={{ display: 'flex', alignItems: 'flex-end', gap: '8px' }}>
                                        <div style={{ fontSize: '2.5rem', fontWeight: '800', color: '#1e293b', lineHeight: '1' }}>12</div>
                                        <div style={{ color: '#f59e0b', fontSize: '0.9rem', fontWeight: '600', marginBottom: '4px' }}>Attention Needed</div>
                                    </div>
                                </div>
                            </div>

                            {/* 5B. Recent Activity Feed Feed */}
                            <h3 style={{ fontSize: '1.25rem', fontWeight: '700', color: '#334155', marginTop: '3rem', marginBottom: '1.5rem', display: 'flex', alignItems: 'center', gap: '8px' }}>
                                <Clock size={20} color="#8b5cf6" />
                                Recent Activity Feed
                            </h3>
                            <div style={{ background: 'white', borderRadius: '20px', border: '1px solid #e2e8f0', overflow: 'hidden', boxShadow: '0 4px 6px rgba(0,0,0,0.02)' }}>

                                {/* Loop through 'activities' array and create rows */}
                                {activities.map((item, idx) => (
                                    <div key={idx} style={{
                                        padding: '1.25rem 1.5rem',
                                        display: 'flex',
                                        gap: '1rem',
                                        borderBottom: idx === activities.length - 1 ? 'none' : '1px solid #f1f5f9', // Remove border on last item
                                        alignItems: 'flex-start',
                                        transition: 'background-color 0.2s',
                                    }} onMouseOver={(e) => e.currentTarget.style.backgroundColor = '#f8fafc'} onMouseOut={(e) => e.currentTarget.style.backgroundColor = 'transparent'}>

                                        {/* Activity Icon Box */}
                                        <div style={{
                                            width: '40px', height: '40px', borderRadius: '12px', background: item.bg,
                                            display: 'flex', alignItems: 'center', justifyContent: 'center', flexShrink: 0
                                        }}>
                                            {item.icon}
                                        </div>

                                        {/* Activity Text Details */}
                                        <div style={{ flex: 1 }}>
                                            <p style={{ margin: 0, fontSize: '0.95rem', color: '#334155', fontWeight: '400', lineHeight: '1.5' }}>
                                                {/* If Admin, show ADMIN badge */}
                                                {item.role === 'Admin' ? <span style={{ color: '#8b5cf6', fontWeight: '700', fontSize: '0.8rem', background: '#ede9fe', padding: '2px 6px', borderRadius: '4px', marginRight: '6px' }}>ADMIN</span> : null}
                                                <span style={{ fontWeight: '700', color: '#0f172a' }}>{item.user}</span> {item.action}
                                            </p>
                                            <span style={{ fontSize: '0.8rem', color: '#94a3b8', marginTop: '6px', display: 'flex', alignItems: 'center', gap: '4px' }}>
                                                <Clock size={12} /> {item.time}
                                            </span>
                                        </div>
                                    </div>
                                ))}
                            </div>
                        </section>

                        {/* RIGHT COLUMN */}
                        {/* ------------------------------------------- */}
                        {/* SECTION 6: PENDING TASKS LIST */}
                        {/* A simple checkbox list of items to review */}
                        {/* ------------------------------------------- */}
                        <section>
                            <h3 style={{ fontSize: '1.25rem', fontWeight: '700', color: '#334155', marginBottom: '1.5rem', display: 'flex', alignItems: 'center', gap: '8px' }}>
                                <ClipboardList size={20} color="#f43f5e" />
                                Pending Admin Tasks
                            </h3>
                            <div style={{ background: 'white', borderRadius: '20px', border: '1px solid #e2e8f0', padding: '0.5rem', boxShadow: '0 4px 6px rgba(0,0,0,0.02)' }}>

                                {/* Loop through 'tasks' array to generate task list items */}
                                {tasks.map((task, idx) => (
                                    <div key={idx} style={{
                                        padding: '1.25rem 1rem',
                                        display: 'flex',
                                        alignItems: 'center',
                                        justifyContent: 'space-between',
                                        borderBottom: idx === tasks.length - 1 ? 'none' : '1px solid #f1f5f9',
                                        transition: 'background-color 0.2s',
                                        borderRadius: '12px'
                                    }} onMouseOver={(e) => e.currentTarget.style.backgroundColor = '#f8fafc'} onMouseOut={(e) => e.currentTarget.style.backgroundColor = 'transparent'}>

                                        {/* Checkbox and Label Area */}
                                        <div style={{ display: 'flex', alignItems: 'center', gap: '1rem' }}>
                                            {/* Show green tick if marked as completed, else grey square box */}
                                            {task.completed ?
                                                <CheckCircle size={24} color="#10b981" /> :
                                                <div style={{ width: '24px', height: '24px', borderRadius: '6px', border: '2px solid #cbd5e0', background: '#f8fafc' }} />
                                            }

                                            {/* Put a line through the text if it is completed */}
                                            <span style={{
                                                fontSize: '1rem',
                                                color: task.completed ? '#94a3b8' : '#334155',
                                                textDecoration: task.completed ? 'line-through' : 'none',
                                                fontWeight: task.completed ? '500' : '600'
                                            }}>
                                                {task.label}
                                            </span>
                                        </div>

                                        {/* Action Review Button */}
                                        <button style={{
                                            padding: '0.5rem 1.25rem',
                                            borderRadius: '8px',

                                            // Dynamic coloring: grey color if completed, blue color if pending
                                            background: task.completed ? '#f1f5f9' : '#eff6ff',
                                            border: task.completed ? '1px solid #e2e8f0' : '1px solid #bfdbfe',
                                            color: task.completed ? '#64748b' : '#3b82f6',

                                            fontWeight: '600',
                                            fontSize: '0.85rem',
                                            cursor: 'pointer',
                                            transition: 'all 0.2s'
                                        }} onMouseOver={(e) => {
                                            if (!task.completed) {
                                                e.currentTarget.style.background = '#dbeafe';
                                                e.currentTarget.style.borderColor = '#93c5fd';
                                            }
                                        }} onMouseOut={(e) => {
                                            if (!task.completed) {
                                                e.currentTarget.style.background = '#eff6ff';
                                                e.currentTarget.style.borderColor = '#bfdbfe';
                                            }
                                        }}>
                                            Review
                                        </button>
                                    </div>
                                ))}
                            </div>
                        </section>
                    </div>
                </div>
            </main>
        </div>
    );
};

export default AdminDashboard;
