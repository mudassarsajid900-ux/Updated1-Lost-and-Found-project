// ========================================== //
// SECTION 1: IMPORTS
// React and icons used on this page
// ========================================== //
import React, { useState } from 'react';
import { User, Home, Folder, PlusCircle, Settings as SettingsIcon, LogOut, ChevronLeft, ChevronRight, Bell, BellRing, Volume2, Sun, Languages, Lock, Shield, Info, Gavel, X, CheckCircle, AlertCircle } from 'lucide-react';
import { useNavigate } from 'react-router-dom';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';
import api from '../api/axios';

// ========================================== //
// SECTION 2: MAIN SETTINGS COMPONENT
// This page lets the user change their app preferences
// (e.g. notifications, dark mode, language)
// ========================================== //
const Settings = () => {
    // Allows us to navigate between pages
    const navigate = useNavigate();

    // Fetch user data from local storage (saved during login)
    const storedUsername = localStorage.getItem('username') || "User";
    const storedEmail = localStorage.getItem('userEmail') || "user@university.edu";

    // Generate initials for the avatar (e.g. Mudassar -> MU)
    const initials = storedUsername.split(' ').map(n => n[0]).join('').toUpperCase().substring(0, 2);
    const avatarUrl = `https://ui-avatars.com/api/?name=${encodeURIComponent(storedUsername)}&background=2dd4bf&color=fff&size=128`;
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

    // Password Change State
    const [isPasswordModalOpen, setIsPasswordModalOpen] = useState(false);
    const [passwordData, setPasswordData] = useState({
        currentPassword: '',
        newPassword: '',
        confirmPassword: ''
    });
    const [pwdStatus, setPwdStatus] = useState({ type: '', message: '' });
    const [isSubmitting, setIsSubmitting] = useState(false);

    // ========================================== //
    // HANDLERS
    // ========================================== //

    // This function flips a specific notification toggle on or off
    const toggleNotification = (key) => {
        setNotifications(prev => ({ ...prev, [key]: !prev[key] }));
    };

    const handlePasswordChange = async (e) => {
        e.preventDefault();
        setPwdStatus({ type: '', message: '' });

        if (passwordData.newPassword !== passwordData.confirmPassword) {
            setPwdStatus({ type: 'error', message: "New passwords do not match." });
            return;
        }

        if (passwordData.newPassword.length < 6) {
            setPwdStatus({ type: 'error', message: "Password must be at least 6 characters." });
            return;
        }

        setIsSubmitting(true);
        try {
            await api.post('Auth/change-password', {
                email: storedEmail,
                currentPassword: passwordData.currentPassword,
                newPassword: passwordData.newPassword
            });

            setPwdStatus({ type: 'success', message: "Password updated successfully!" });
            setTimeout(() => {
                setIsPasswordModalOpen(false);
                setPasswordData({ currentPassword: '', newPassword: '', confirmPassword: '' });
                setPwdStatus({ type: '', message: '' });
            }, 2000);
        } catch (err) {
            setPwdStatus({
                type: 'error',
                message: err.response?.data?.message || err.response?.data?.Message || "Failed to update password."
            });
        } finally {
            setIsSubmitting(false);
        }
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
                                        <img src={avatarUrl} alt="Profile" />
                                    </div>
                                    <h3 className="profile-name">{storedUsername}</h3>
                                    <p className="profile-email">{storedEmail}</p>
                                </div>

                                {/* 4B. Profile action buttons list */}
                                <div className="card-actions-list">
                                    <button className="card-action-item" onClick={() => setIsPasswordModalOpen(true)}>
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
                        {/* SECTION 8: PASSWORD MODAL */}
                        {/* ------------------------------------------- */}
                        {isPasswordModalOpen && (
                            <div className="modal-overlay">
                                <div className="modal-card animate-scale-in">
                                    <div className="modal-header">
                                        <div className="modal-title-group">
                                            <div className="modal-icon-box">
                                                <Lock size={20} className="text-teal" />
                                            </div>
                                            <h3>Change Password</h3>
                                        </div>
                                        <button className="close-modal-btn" onClick={() => setIsPasswordModalOpen(false)}>
                                            <X size={20} />
                                        </button>
                                    </div>

                                    <form onSubmit={handlePasswordChange} className="modal-form">
                                        <div className="input-field-group">
                                            <label>Current Password</label>
                                            <input
                                                type="password"
                                                placeholder="Enter current password"
                                                required
                                                value={passwordData.currentPassword}
                                                onChange={(e) => setPasswordData({ ...passwordData, currentPassword: e.target.value })}
                                            />
                                        </div>

                                        <div className="input-field-group">
                                            <label>New Password</label>
                                            <input
                                                type="password"
                                                placeholder="Minimum 6 characters"
                                                required
                                                value={passwordData.newPassword}
                                                onChange={(e) => setPasswordData({ ...passwordData, newPassword: e.target.value })}
                                            />
                                        </div>

                                        <div className="input-field-group">
                                            <label>Confirm New Password</label>
                                            <input
                                                type="password"
                                                placeholder="Repeat new password"
                                                required
                                                value={passwordData.confirmPassword}
                                                onChange={(e) => setPasswordData({ ...passwordData, confirmPassword: e.target.value })}
                                            />
                                        </div>

                                        {pwdStatus.message && (
                                            <div className={`status-alert ${pwdStatus.type}`}>
                                                {pwdStatus.type === 'success' ? <CheckCircle size={16} /> : <AlertCircle size={16} />}
                                                <span>{pwdStatus.message}</span>
                                            </div>
                                        )}

                                        <div className="modal-footer">
                                            <button type="button" className="cancel-btn" onClick={() => setIsPasswordModalOpen(false)}>
                                                Cancel
                                            </button>
                                            <button type="submit" className="save-btn" disabled={isSubmitting}>
                                                {isSubmitting ? "Updating..." : "Update Password"}
                                            </button>
                                        </div>
                                    </form>
                                </div>
                            </div>
                        )}

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

                                {/* Log Out Button */}
                                <button className="card-action-item" onClick={() => {
                                    localStorage.removeItem('token');
                                    localStorage.removeItem('username');
                                    localStorage.removeItem('userEmail');
                                    navigate('/login');
                                }}>
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

                /* Modal Styles */
                .modal-overlay {
                    position: fixed;
                    top: 0;
                    left: 0;
                    right: 0;
                    bottom: 0;
                    background: rgba(15, 23, 42, 0.4);
                    backdrop-filter: blur(4px);
                    display: flex;
                    align-items: center;
                    justify-content: center;
                    z-index: 2000;
                    padding: 1.5rem;
                }
                .modal-card {
                    background: white;
                    width: 100%;
                    max-width: 440px;
                    border-radius: 28px;
                    box-shadow: 0 25px 50px -12px rgba(0, 0, 0, 0.25);
                    overflow: hidden;
                }
                .modal-header {
                    padding: 1.5rem 2rem;
                    border-bottom: 1px solid #f1f5f9;
                    display: flex;
                    align-items: center;
                    justify-content: space-between;
                }
                .modal-title-group { display: flex; align-items: center; gap: 1rem; }
                .modal-title-group h3 { margin: 0; font-size: 1.25rem; font-weight: 800; color: #1e293b; }
                .modal-icon-box {
                    width: 40px;
                    height: 40px;
                    background: #f0fdfa;
                    border-radius: 12px;
                    display: flex;
                    align-items: center;
                    justify-content: center;
                }
                .close-modal-btn {
                    border: none;
                    background: transparent;
                    color: #94a3b8;
                    cursor: pointer;
                    padding: 0.5rem;
                    border-radius: 50%;
                    transition: all 0.2s;
                }
                .close-modal-btn:hover { background: #f1f5f9; color: #1e293b; }

                .modal-form { padding: 1.5rem 2rem; display: flex; flex-direction: column; gap: 1rem; }
                .input-field-group { display: flex; flex-direction: column; gap: 0.5rem; }
                .input-field-group label { font-size: 0.85rem; font-weight: 700; color: #64748b; text-transform: uppercase; letter-spacing: 0.05em; }
                .input-field-group input {
                    height: 52px;
                    padding: 0 1rem;
                    border-radius: 14px;
                    border: 1.5px solid #e2e8f0;
                    font-size: 1rem;
                    transition: all 0.2s;
                }
                .input-field-group input:focus {
                    outline: none;
                    border-color: #2dd4bf;
                    box-shadow: 0 0 0 4px rgba(45, 212, 191, 0.15);
                }

                .status-alert {
                    padding: 1rem;
                    border-radius: 14px;
                    display: flex;
                    align-items: center;
                    gap: 0.75rem;
                    font-size: 0.9rem;
                    font-weight: 600;
                }
                .status-alert.error { background: #fef2f2; color: #ef4444; }
                .status-alert.success { background: #f0fdfa; color: #0d9488; }

                .modal-footer {
                    margin-top: 1rem;
                    display: flex;
                    gap: 1rem;
                }
                .modal-footer button {
                    flex: 1;
                    height: 52px;
                    border-radius: 14px;
                    font-weight: 700;
                    font-size: 1rem;
                    cursor: pointer;
                    transition: all 0.2s;
                }
                .cancel-btn { background: #f8fafc; color: #64748b; border: 1.5px solid #e2e8f0; }
                .cancel-btn:hover { background: #f1f5f9; }
                .save-btn { background: #1e293b; color: white; border: none; }
                .save-btn:hover { background: #0f172a; transform: translateY(-1px); }
                .save-btn:disabled { opacity: 0.5; cursor: not-allowed; }

                @keyframes scaleIn {
                    from { opacity: 0; transform: scale(0.95); }
                    to { opacity: 1; transform: scale(1); }
                }
                .animate-scale-in { animation: scaleIn 0.2s ease-out; }
                `
            }} />
        </div>
    );
};

export default Settings;
