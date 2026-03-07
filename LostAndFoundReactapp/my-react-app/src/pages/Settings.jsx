// ========================================== //
// SECTION 1: IMPORTS
// React and icons used on this page
// ========================================== //
import React, { useState } from 'react';
import { User, Home, Folder, PlusCircle, Settings as SettingsIcon, LogOut, ChevronLeft, ChevronRight, Bell, BellRing, Volume2, Sun, Languages, Lock, Shield, Info, Gavel } from 'lucide-react';
import { useNavigate } from 'react-router-dom';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';

// ========================================== //
// SECTION 2: MAIN SETTINGS COMPONENT
// This page lets the user change their app preferences
// (e.g. notifications, dark mode, language)
// ========================================== //
const Settings = () => {
    // Allows us to navigate between pages
    const navigate = useNavigate();

    // ========================================== //
    // STATE VARIABLES
    // These hold the current "on/off" status of the settings toggles
    // ========================================== //

    // Notification toggles
    const [notifications, setNotifications] = useState({
        push: true,
        inApp: false,
        sounds: true,
    });

    // Dark mode toggle
    const [darkMode, setDarkMode] = useState(false);

    // ========================================== //
    // HANDLERS
    // ========================================== //

    // This function flips a specific notification toggle on or off
    const toggleNotification = (key) => {
        setNotifications(prev => ({ ...prev, [key]: !prev[key] }));
    };

    // ========================================== //
    // PAGE LAYOUT RENDER
    // ========================================== //
    return (
        <div className="dashboard-container">
            {/* Display Sidebar Menu */}
            <Sidebar />

            {/* Main Content Area */}
            <main className="main-content">

                {/* 3A. Header with Title */}
                <Header
                    title="Settings"
                    subtitle="Manage your account and preferences"
                    showBack={true}
                    onBack={() => navigate(-1)}
                />

                <div className="settings-scroll-area">
                    <div className="settings-content">

                        {/* ------------------------------------------- */}
                        {/* SECTION 4: PROFILE SETTINGS */}
                        {/* Shows avatar, name, and profile action buttons */}
                        {/* ------------------------------------------- */}
                        <section className="settings-group">
                            <h2 className="group-title">Profile Information</h2>
                            <div className="settings-card profile-card">

                                {/* 4A. Avatar and Text */}
                                <div className="profile-header-main">
                                    <div className="profile-avatar-large">
                                        <img src="https://ui-avatars.com/api/?name=Ali+Haider&background=2dd4bf&color=fff&size=128" alt="Profile" />
                                    </div>
                                    <h3 className="profile-name">Mudassar</h3>
                                    <p className="profile-email">Mudassar@example.com</p>
                                </div>

                                {/* 4B. Profile action buttons list */}
                                <div className="card-actions-list">
                                    <button className="card-action-item">
                                        <div className="action-icon-box bg-teal-soft">
                                            <User size={18} className="text-teal" />
                                        </div>
                                        <span className="action-label">Edit Profile</span>
                                        <ChevronRight size={18} className="text-slate-light" />
                                    </button>
                                    <button className="card-action-item">
                                        <div className="action-icon-box bg-teal-soft">
                                            <Lock size={18} className="text-teal" />
                                        </div>
                                        <span className="action-label">Change Password</span>
                                        <ChevronRight size={18} className="text-slate-light" />
                                    </button>
                                </div>
                            </div>
                        </section>

                        {/* ------------------------------------------- */}
                        {/* SECTION 5: NOTIFICATIONS SETTINGS */}
                        {/* Contains all green/grey toggle switches */}
                        {/* ------------------------------------------- */}
                        <section className="settings-group mt-8">
                            <h2 className="group-title">Notification Preferences</h2>
                            <div className="settings-card">

                                {/* Toggle 1: Push Notifications */}
                                <div className="setting-row">
                                    <div className="setting-info">
                                        <div className="action-icon-box bg-teal-soft">
                                            <BellRing size={18} className="text-teal" />
                                        </div>
                                        <div className="setting-text">
                                            <h4>Push Notifications</h4>
                                            <p>Receive alerts for important updates.</p>
                                        </div>
                                    </div>
                                    {/* The visual toggle switch div */}
                                    <div
                                        className={`toggle-switch ${notifications.push ? 'active' : ''}`}
                                        onClick={() => toggleNotification('push')}
                                    >
                                        <div className="toggle-handle"></div>
                                    </div>
                                </div>

                                {/* Toggle 2: In-App Alerts */}
                                <div className="setting-row">
                                    <div className="setting-info">
                                        <div className="action-icon-box bg-teal-soft">
                                            <Info size={18} className="text-teal" />
                                        </div>
                                        <div className="setting-text">
                                            <h4>In-App Alerts</h4>
                                            <p>See immediate notifications while using the app.</p>
                                        </div>
                                    </div>
                                    {/* The visual toggle switch div */}
                                    <div
                                        className={`toggle-switch ${notifications.inApp ? 'active' : ''}`}
                                        onClick={() => toggleNotification('inApp')}
                                    >
                                        <div className="toggle-handle"></div>
                                    </div>
                                </div>

                                {/* Toggle 3: Sound Effects */}
                                <div className="setting-row">
                                    <div className="setting-info">
                                        <div className="action-icon-box bg-teal-soft">
                                            <Volume2 size={18} className="text-teal" />
                                        </div>
                                        <div className="setting-text">
                                            <h4>Sound Effects</h4>
                                            <p>Play sounds for various app interactions.</p>
                                        </div>
                                    </div>
                                    {/* The visual toggle switch div */}
                                    <div
                                        className={`toggle-switch ${notifications.sounds ? 'active' : ''}`}
                                        onClick={() => toggleNotification('sounds')}
                                    >
                                        <div className="toggle-handle"></div>
                                    </div>
                                </div>
                            </div>
                        </section>

                        {/* ------------------------------------------- */}
                        {/* SECTION 6: APPEARANCE SETTINGS */}
                        {/* ------------------------------------------- */}
                        <section className="settings-group mt-8">
                            <h2 className="group-title">Appearance</h2>
                            <div className="settings-card">

                                {/* Toggle: Dark Mode */}
                                <div className="setting-row">
                                    <div className="setting-info">
                                        <div className="action-icon-box bg-teal-soft">
                                            <Sun size={18} className="text-teal" />
                                        </div>
                                        <div className="setting-text">
                                            <h4>Dark Mode</h4>
                                            <p>Toggle between light and dark themes.</p>
                                        </div>
                                    </div>
                                    <div
                                        className={`toggle-switch ${darkMode ? 'active' : ''}`}
                                        onClick={() => setDarkMode(!darkMode)}
                                    >
                                        <div className="toggle-handle"></div>
                                    </div>
                                </div>
                            </div>
                        </section>

                        {/* ------------------------------------------- */}
                        {/* SECTION 7: GENERAL SETTINGS */}
                        {/* Includes log out button */}
                        {/* ------------------------------------------- */}
                        <section className="settings-group mt-8">
                            <h2 className="group-title">General</h2>
                            <div className="settings-card">

                                {/* Language Button */}
                                <button className="card-action-item">
                                    <div className="setting-info">
                                        <div className="action-icon-box bg-teal-soft">
                                            <Languages size={18} className="text-teal" />
                                        </div>
                                        <div className="setting-text">
                                            <h4>Language</h4>
                                            <p>Set your preferred language.</p>
                                        </div>
                                    </div>
                                    <ChevronRight size={18} className="text-slate-light" />
                                </button>

                                {/* Grey Divider Line */}
                                <div className="divider-line"></div>

                                {/* Log Out Button */}
                                <button className="card-action-item" onClick={() => navigate('/login')}>
                                    <div className="setting-info">
                                        <div className="action-icon-box bg-red-soft">
                                            <LogOut size={18} className="text-red" />
                                        </div>
                                        <div className="setting-text">
                                            <h4>Log Out</h4>
                                        </div>
                                    </div>
                                    <ChevronRight size={18} className="text-slate-light" />
                                </button>

                            </div>
                        </section>

                    </div>
                </div>
            </main>

            {/* ------------------------------------------- */}
            {/* INLINE CSS STYLES ONLY FOR THIS PAGE */}
            {/* ------------------------------------------- */}
            <style dangerouslySetInnerHTML={{
                __html: `
                .settings-scroll-area {
                    flex: 1;
                    overflow-y: auto;
                    padding-bottom: 2rem;
                }
                .settings-content {
                    max-width: 600px;
                    margin: 0 auto;
                }
                .settings-group {
                    margin-bottom: 1.5rem;
                }
                .group-title {
                    font-size: 1.1rem;
                    font-weight: 800;
                    color: #1e293b;
                    margin-bottom: 1rem;
                    padding-left: 0.5rem;
                }
                .settings-card {
                    background: white;
                    border-radius: 24px;
                    padding: 1.5rem;
                    border: 1px solid #e2e8f0;
                    box-shadow: 0 4px 6px -1px rgba(0,0,0,0.02);
                }
                
                /* Profile Section Specifics */
                .profile-header-main {
                    text-align: center;
                    padding-bottom: 1.5rem;
                    border-bottom: 1px solid #f1f5f9;
                    margin-bottom: 1rem;
                }
                .profile-avatar-large {
                    width: 100px;
                    height: 100px;
                    border-radius: 50%;
                    margin: 0 auto 1rem;
                    overflow: hidden;
                    border: 4px solid #f0fdfa;
                    box-shadow: 0 8px 16px rgba(45, 212, 191, 0.2);
                }
                .profile-avatar-large img { width: 100%; height: 100%; object-fit: cover; }
                .profile-name { font-size: 1.25rem; font-weight: 800; color: #1e293b; margin: 0; }
                .profile-email { font-size: 0.95rem; color: #64748b; margin: 4px 0 0 0; }
                
                .card-actions-list { display: flex; flex-direction: column; gap: 0.5rem; }
                .card-action-item {
                    display: flex;
                    align-items: center;
                    width: 100%;
                    padding: 0.75rem 0.5rem;
                    background: transparent;
                    border: none;
                    border-radius: 12px;
                    cursor: pointer;
                    transition: all 0.2s;
                }
                .card-action-item:hover { background: #f8fafc; }
                .action-icon-box {
                    width: 38px;
                    height: 38px;
                    border-radius: 10px;
                    display: flex;
                    align-items: center;
                    justify-content: center;
                    margin-right: 1rem;
                }
                .bg-teal-soft { background: #f0fdfa; }
                .bg-red-soft { background: #fef2f2; }
                .text-teal { color: #0d9488; }
                .text-red { color: #ef4444; }
                .text-slate-light { color: #94a3b8; }
                
                .action-label { flex: 1; text-align: left; font-weight: 600; color: #334155; font-size: 0.95rem; }
                
                /* Setting Rows with Toggles */
                .setting-row {
                    display: flex;
                    align-items: center;
                    justify-content: space-between;
                    padding: 1rem 0.5rem;
                }
                .setting-row:not(:last-child) { border-bottom: 1px solid #f1f5f9; }
                .setting-info { display: flex; align-items: center; gap: 1rem; }
                .setting-text h4 { margin: 0; font-size: 1rem; font-weight: 700; color: #1e293b; }
                .setting-text p { margin: 2px 0 0 0; font-size: 0.85rem; color: #64748b; }
                
                /* Toggle Switch */
                .toggle-switch {
                    width: 48px;
                    height: 26px;
                    background: #e2e8f0;
                    border-radius: 100px;
                    position: relative;
                    cursor: pointer;
                    transition: all 0.3s;
                }
                .toggle-switch.active { background: #2dd4bf; }
                .toggle-handle {
                    width: 18px;
                    height: 18px;
                    background: white;
                    border-radius: 50%;
                    position: absolute;
                    top: 4px;
                    left: 4px;
                    transition: all 0.3s;
                    box-shadow: 0 2px 4px rgba(0,0,0,0.1);
                }
                .toggle-switch.active .toggle-handle { left: 26px; }
                
                .divider-line { height: 1px; background: #f1f5f9; margin: 0 0.5rem; }
                .mt-8 { margin-top: 2rem; }
                `
            }} />
        </div>
    );
};

export default Settings;
