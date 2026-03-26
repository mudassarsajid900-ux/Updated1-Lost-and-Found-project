import React, { useState } from 'react';
import { LogOut, ChevronRight, Settings as SettingsIcon, Shield, Server, Mail, Lock, CheckCircle, AlertCircle, X, RefreshCw, Gavel } from 'lucide-react';
import { useNavigate } from 'react-router-dom';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';
import api from '../api/axios';

const AdminSettings = () => {
    const navigate = useNavigate();

    const storedUsername = localStorage.getItem('username') || "Admin User";
    const storedEmail = localStorage.getItem('userEmail') || "admin@system.com";

    const avatarUrl = `https://ui-avatars.com/api/?name=${encodeURIComponent(storedUsername)}&background=1e293b&color=fff&size=128`;

    // State for temporary toggles
    const [systemSettings, setSystemSettings] = useState({
        maintenanceMode: false,
        emailNotifications: true,
        eligibilityThreshold: 90,
        unclaimedThreshold: 20,
        auctionThreshold: 40,
    });
    const [loadingSettings, setLoadingSettings] = useState(false);
    const [isUpdating, setIsUpdating] = useState({ eligibility: false, unclaimed: false, auction: false });

    const [isPasswordModalOpen, setIsPasswordModalOpen] = useState(false);
    const [passwordData, setPasswordData] = useState({ currentPassword: '', newPassword: '', confirmPassword: '' });
    const [pwdStatus, setPwdStatus] = useState({ type: '', message: '' });
    const [isSubmitting, setIsSubmitting] = useState(false);

    React.useEffect(() => {
        fetchThresholds();
    }, []);

    const fetchThresholds = async () => {
        setLoadingSettings(true);
        try {
            const res = await api.get('Replacement/admin/settings/thresholds');
            const data = res.data.data;
            setSystemSettings(prev => ({
                ...prev,
                eligibilityThreshold: data.ReplacementEligibilityThreshold || 90,
                unclaimedThreshold: data.FoundToReplacementThreshold || 20,
                auctionThreshold: data.ReplacementToAuctionThreshold || 40,
            }));
        } catch (err) {
            console.error("Error fetching thresholds:", err);
        } finally {
            setLoadingSettings(false);
        }
    };

    const toggleSetting = (key) => setSystemSettings(prev => ({ ...prev, [key]: !prev[key] }));

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

            setPwdStatus({ type: 'success', message: "Admin password updated successfully!" });
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

    const handleThresholdUpdate = async (type) => {
        setIsUpdating(prev => ({ ...prev, [type]: true }));
        try {
            let endpoint = '';
            let val = 0;
            if (type === 'eligibility') {
                endpoint = 'eligibility-threshold';
                val = systemSettings.eligibilityThreshold;
            } else if (type === 'unclaimed') {
                endpoint = 'found-to-replacement-threshold';
                val = systemSettings.unclaimedThreshold;
            } else if (type === 'auction') {
                endpoint = 'replacement-to-auction-threshold';
                val = systemSettings.auctionThreshold;
            }

            await api.put(`Replacement/admin/settings/${endpoint}/${val}`);
            alert("Threshold updated successfully!");
            fetchThresholds();
        } catch (err) {
            console.error(err);
            alert("Failed to update threshold.");
        } finally {
            setIsUpdating(prev => ({ ...prev, [type]: false }));
        }
    };

    return (
        <div className="dashboard-container">
            <Sidebar isAdmin={true} />

            <main className="main-content">
                <Header title="System Settings" subtitle="Platform configuration and security" />

                <div className="settings-scroll-area">
                    <div className="settings-content">

                        {/* PROFILE & SECURITY */}
                        <section className="settings-group">
                            <h2 className="group-title">Admin Account</h2>
                            <div className="settings-card profile-card">
                                <div className="profile-header-main admin-profile">
                                    <div className="profile-avatar-large">
                                        <img src={avatarUrl} alt="Admin" />
                                    </div>
                                    <h3 className="profile-name">{storedUsername}</h3>
                                    <p className="profile-email">{storedEmail}</p>
                                    <span className="admin-badge">System Administrator</span>
                                </div>

                                <div className="card-actions-list">
                                    <button className="card-action-item" onClick={() => setIsPasswordModalOpen(true)}>
                                        <div className="action-icon-box bg-slate-soft">
                                            <Lock size={18} className="text-slate" />
                                        </div>
                                        <span className="action-label">Change Admin Password</span>
                                        <ChevronRight size={18} className="text-slate-light" />
                                    </button>
                                </div>
                            </div>
                        </section>

                        {/* SYSTEM CONFIGURATION */}
                        <section className="settings-group mt-8">
                            <h2 className="group-title">System Configuration</h2>
                            <div className="settings-card">
                                <div className="setting-row">
                                    <div className="setting-info">
                                        <div className="action-icon-box bg-orange-soft">
                                            <Server size={18} className="text-orange" />
                                        </div>
                                        <div className="setting-text">
                                            <h4>Maintenance Mode</h4>
                                            <p>Temporarily disable access for non-admin users.</p>
                                        </div>
                                    </div>
                                    <div className={`toggle-switch ${systemSettings.maintenanceMode ? 'active' : ''}`} onClick={() => toggleSetting('maintenanceMode')}>
                                        <div className="toggle-handle"></div>
                                    </div>
                                </div>

                                <div className="setting-row">
                                    <div className="setting-info">
                                        <div className="action-icon-box bg-teal-soft">
                                            <Shield size={18} className="text-teal" />
                                        </div>
                                        <div className="setting-text">
                                            <h4>Allow New Registrations</h4>
                                            <p>Open the platform for new user sign-ups.</p>
                                        </div>
                                    </div>
                                    <div className={`toggle-switch ${systemSettings.allowNewRegistrations ? 'active' : ''}`} onClick={() => toggleSetting('allowNewRegistrations')}>
                                        <div className="toggle-handle"></div>
                                    </div>
                                </div>

                                <div className="setting-row">
                                    <div className="setting-info">
                                        <div className="action-icon-box bg-blue-soft">
                                            <Mail size={18} className="text-blue" />
                                        </div>
                                        <div className="setting-text">
                                            <h4>System Email Notifications</h4>
                                            <p>Send automated emails for lost/found matches.</p>
                                        </div>
                                    </div>
                                    <div className={`toggle-switch ${systemSettings.emailNotifications ? 'active' : ''}`} onClick={() => toggleSetting('emailNotifications')}>
                                        <div className="toggle-handle"></div>
                                    </div>
                                </div>

                                <div className="setting-row">
                                    <div className="setting-info">
                                        <div className="action-icon-box bg-purple-soft">
                                            <RefreshCw size={18} className="text-purple" />
                                        </div>
                                        <div className="setting-text">
                                            <h4>Replacement Eligibility (Days)</h4>
                                            <p>Wait time before a user can request a replacement.</p>
                                        </div>
                                    </div>
                                    <div style={{ display: 'flex', alignItems: 'center', gap: '10px' }}>
                                        <input 
                                            type="number" 
                                            value={systemSettings.eligibilityThreshold} 
                                            onChange={(e) => setSystemSettings(prev => ({...prev, eligibilityThreshold: e.target.value}))}
                                            style={{ width: '60px', padding: '5px', borderRadius: '8px', border: '1px solid #e2e8f0', textAlign: 'center' }}
                                        />
                                        <button 
                                            onClick={() => handleThresholdUpdate('eligibility')}
                                            disabled={isUpdating.eligibility}
                                            style={{ padding: '6px 12px', background: '#1e293b', color: 'white', border: 'none', borderRadius: '8px', fontSize: '0.8rem', cursor: 'pointer' }}
                                        >
                                            {isUpdating.eligibility ? "..." : "Save"}
                                        </button>
                                    </div>
                                </div>

                                <div className="setting-row">
                                    <div className="setting-info">
                                        <div className="action-icon-box bg-teal-soft">
                                            <CheckCircle size={18} className="text-teal" />
                                        </div>
                                        <div className="setting-text">
                                            <h4>Found → Replacement (Days)</h4>
                                            <p>Time an unclaimed item stays as 'Found'.</p>
                                        </div>
                                    </div>
                                    <div style={{ display: 'flex', alignItems: 'center', gap: '10px' }}>
                                        <input 
                                            type="number" 
                                            value={systemSettings.unclaimedThreshold} 
                                            onChange={(e) => setSystemSettings(prev => ({...prev, unclaimedThreshold: e.target.value}))}
                                            style={{ width: '60px', padding: '5px', borderRadius: '8px', border: '1px solid #e2e8f0', textAlign: 'center' }}
                                        />
                                        <button 
                                            onClick={() => handleThresholdUpdate('unclaimed')}
                                            disabled={isUpdating.unclaimed}
                                            style={{ padding: '6px 12px', background: '#1e293b', color: 'white', border: 'none', borderRadius: '8px', fontSize: '0.8rem', cursor: 'pointer' }}
                                        >
                                            {isUpdating.unclaimed ? "..." : "Save"}
                                        </button>
                                    </div>
                                </div>

                                <div className="setting-row">
                                    <div className="setting-info">
                                        <div className="action-icon-box bg-orange-soft">
                                            <Gavel size={18} className="text-orange" />
                                        </div>
                                        <div className="setting-text">
                                            <h4>Replacement → Auction (Days)</h4>
                                            <p>Time an item stays in the Replacement pool.</p>
                                        </div>
                                    </div>
                                    <div style={{ display: 'flex', alignItems: 'center', gap: '10px' }}>
                                        <input 
                                            type="number" 
                                            value={systemSettings.auctionThreshold} 
                                            onChange={(e) => setSystemSettings(prev => ({...prev, auctionThreshold: e.target.value}))}
                                            style={{ width: '60px', padding: '5px', borderRadius: '8px', border: '1px solid #e2e8f0', textAlign: 'center' }}
                                        />
                                        <button 
                                            onClick={() => handleThresholdUpdate('auction')}
                                            disabled={isUpdating.auction}
                                            style={{ padding: '6px 12px', background: '#1e293b', color: 'white', border: 'none', borderRadius: '8px', fontSize: '0.8rem', cursor: 'pointer' }}
                                        >
                                            {isUpdating.auction ? "..." : "Save"}
                                        </button>
                                    </div>
                                </div>
                            </div>
                        </section>

                        {/* DANGER ZONE / LOGOUT */}
                        <section className="settings-group mt-8">
                            <h2 className="group-title text-red">Danger Zone</h2>
                            <div className="settings-card border-red">
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
                                            <h4 className="text-red">End Admin Session</h4>
                                        </div>
                                    </div>
                                    <ChevronRight size={18} className="text-slate-light" />
                                </button>
                            </div>
                        </section>

                    </div>
                </div>

                {/* PASSWORD MODAL */}
                {isPasswordModalOpen && (
                    <div className="modal-overlay">
                        <div className="modal-card animate-scale-in">
                            <div className="modal-header">
                                <div className="modal-title-group">
                                    <div className="modal-icon-box bg-slate-soft">
                                        <Lock size={20} className="text-slate" />
                                    </div>
                                    <h3>Change Admin Password</h3>
                                </div>
                                <button className="close-modal-btn" onClick={() => setIsPasswordModalOpen(false)}>
                                    <X size={20} />
                                </button>
                            </div>

                            <form onSubmit={handlePasswordChange} className="modal-form">
                                <div className="input-field-group">
                                    <label>Current Password</label>
                                    <input type="password" required value={passwordData.currentPassword} onChange={(e) => setPasswordData({ ...passwordData, currentPassword: e.target.value })} />
                                </div>
                                <div className="input-field-group">
                                    <label>New Password</label>
                                    <input type="password" placeholder="Min length: 6" required value={passwordData.newPassword} onChange={(e) => setPasswordData({ ...passwordData, newPassword: e.target.value })} />
                                </div>
                                <div className="input-field-group">
                                    <label>Confirm New Password</label>
                                    <input type="password" required value={passwordData.confirmPassword} onChange={(e) => setPasswordData({ ...passwordData, confirmPassword: e.target.value })} />
                                </div>

                                {pwdStatus.message && (
                                    <div className={`status-alert ${pwdStatus.type}`}>
                                        {pwdStatus.type === 'success' ? <CheckCircle size={16} /> : <AlertCircle size={16} />}
                                        <span>{pwdStatus.message}</span>
                                    </div>
                                )}

                                <div className="modal-footer">
                                    <button type="button" className="cancel-btn" onClick={() => setIsPasswordModalOpen(false)}>Cancel</button>
                                    <button type="submit" className="save-btn" disabled={isSubmitting}>{isSubmitting ? "Updating..." : "Update Password"}</button>
                                </div>
                            </form>
                        </div>
                    </div>
                )}
            </main>

            <style dangerouslySetInnerHTML={{
                __html: `
                .settings-scroll-area { flex: 1; overflow-y: auto; padding-bottom: 2rem; }
                .settings-content { max-width: 600px; margin: 0 auto; }
                .settings-group { margin-bottom: 1.5rem; }
                .group-title { font-size: 1.1rem; font-weight: 800; color: #1e293b; margin-bottom: 1rem; padding-left: 0.5rem; }
                .group-title.text-red { color: #ef4444; }
                
                .settings-card { background: white; border-radius: 24px; padding: 1.5rem; border: 1px solid #e2e8f0; box-shadow: 0 4px 6px -1px rgba(0,0,0,0.02); }
                .settings-card.border-red { border-color: #fecaca; background: #fff5f5; }
                
                .profile-header-main { text-align: center; padding-bottom: 1.5rem; border-bottom: 1px solid #f1f5f9; margin-bottom: 1rem; }
                .profile-avatar-large { width: 100px; height: 100px; border-radius: 50%; margin: 0 auto 1rem; overflow: hidden; border: 4px solid #f8fafc; box-shadow: 0 8px 16px rgba(15, 23, 42, 0.1); }
                .profile-avatar-large img { width: 100%; height: 100%; object-fit: cover; }
                .profile-name { font-size: 1.25rem; font-weight: 800; color: #1e293b; margin: 0; }
                .profile-email { font-size: 0.95rem; color: #64748b; margin: 4px 0 0 0; }
                
                .admin-badge { display: inline-block; background: #1e293b; color: #f8fafc; font-size: 0.75rem; font-weight: 700; padding: 4px 12px; border-radius: 100px; margin-top: 10px; letter-spacing: 0.5px; text-transform: uppercase; }
                
                .card-actions-list { display: flex; flex-direction: column; gap: 0.5rem; }
                .card-action-item { display: flex; align-items: center; width: 100%; padding: 0.75rem 0.5rem; background: transparent; border: none; border-radius: 12px; cursor: pointer; transition: all 0.2s; }
                .card-action-item:hover { background: #f8fafc; }
                
                .action-icon-box { width: 38px; height: 38px; border-radius: 10px; display: flex; align-items: center; justify-content: center; margin-right: 1rem; }
                .bg-slate-soft { background: #f1f5f9; } .text-slate { color: #475569; }
                .bg-teal-soft { background: #f0fdfa; } .text-teal { color: #0d9488; }
                .bg-orange-soft { background: #fff7ed; } .text-orange { color: #ea580c; }
                .bg-blue-soft { background: #eff6ff; } .text-blue { color: #3b82f6; }
                .bg-purple-soft { background: #f5f3ff; } .text-purple { color: #7c3aed; }
                .bg-red-soft { background: #fef2f2; } .text-red { color: #ef4444; }
                .text-slate-light { color: #94a3b8; }
                
                .action-label { flex: 1; text-align: left; font-weight: 600; color: #334155; font-size: 0.95rem; }
                
                .setting-row { display: flex; align-items: center; justify-content: space-between; padding: 1rem 0.5rem; }
                .setting-row:not(:last-child) { border-bottom: 1px solid #f1f5f9; }
                .setting-info { display: flex; align-items: center; gap: 1rem; }
                .setting-text h4 { margin: 0; font-size: 1rem; font-weight: 700; color: #1e293b; }
                .setting-text p { margin: 2px 0 0 0; font-size: 0.85rem; color: #64748b; }
                
                .toggle-switch { width: 48px; height: 26px; background: #e2e8f0; border-radius: 100px; position: relative; cursor: pointer; transition: all 0.3s; }
                .toggle-switch.active { background: #1e293b; }
                .toggle-handle { width: 18px; height: 18px; background: white; border-radius: 50%; position: absolute; top: 4px; left: 4px; transition: all 0.3s; box-shadow: 0 2px 4px rgba(0,0,0,0.1); }
                .toggle-switch.active .toggle-handle { left: 26px; }
                
                .mt-8 { margin-top: 2rem; }

                /* MODAL OVERRIDES */
                .modal-overlay { position: fixed; top: 0; left: 0; right: 0; bottom: 0; background: rgba(15, 23, 42, 0.4); backdrop-filter: blur(4px); display: flex; align-items: center; justify-content: center; z-index: 2000; padding: 1.5rem; }
                .modal-card { background: white; width: 100%; max-width: 440px; border-radius: 28px; box-shadow: 0 25px 50px -12px rgba(0, 0, 0, 0.25); overflow: hidden; }
                .modal-header { padding: 1.5rem 2rem; border-bottom: 1px solid #f1f5f9; display: flex; align-items: center; justify-content: space-between; }
                .modal-title-group { display: flex; align-items: center; gap: 1rem; }
                .modal-title-group h3 { margin: 0; font-size: 1.25rem; font-weight: 800; color: #1e293b; }
                .close-modal-btn { border: none; background: transparent; color: #94a3b8; cursor: pointer; padding: 0.5rem; border-radius: 50%; transition: all 0.2s; }
                .close-modal-btn:hover { background: #f1f5f9; color: #1e293b; }
                .modal-form { padding: 1.5rem 2rem; display: flex; flex-direction: column; gap: 1rem; }
                .input-field-group { display: flex; flex-direction: column; gap: 0.5rem; }
                .input-field-group label { font-size: 0.85rem; font-weight: 700; color: #64748b; text-transform: uppercase; letter-spacing: 0.05em; }
                .input-field-group input { height: 52px; padding: 0 1rem; border-radius: 14px; border: 1.5px solid #e2e8f0; font-size: 1rem; transition: all 0.2s; }
                .input-field-group input:focus { outline: none; border-color: #1e293b; box-shadow: 0 0 0 4px rgba(30, 41, 59, 0.1); }
                .status-alert { padding: 1rem; border-radius: 14px; display: flex; align-items: center; gap: 0.75rem; font-size: 0.9rem; font-weight: 600; }
                .status-alert.error { background: #fef2f2; color: #ef4444; }
                .status-alert.success { background: #f0fdfa; color: #0d9488; }
                .modal-footer { margin-top: 1rem; display: flex; gap: 1rem; }
                .modal-footer button { flex: 1; height: 52px; border-radius: 14px; font-weight: 700; font-size: 1rem; cursor: pointer; transition: all 0.2s; }
                .cancel-btn { background: #f8fafc; color: #64748b; border: 1.5px solid #e2e8f0; }
                .cancel-btn:hover { background: #f1f5f9; }
                .save-btn { background: #1e293b; color: white; border: none; }
                .save-btn:hover { background: #0f172a; transform: translateY(-1px); }
                .save-btn:disabled { opacity: 0.5; cursor: not-allowed; }
                @keyframes scaleIn { from { opacity: 0; transform: scale(0.95); } to { opacity: 1; transform: scale(1); } }
                .animate-scale-in { animation: scaleIn 0.2s ease-out; }
                `
            }} />
        </div>
    );
};

export default AdminSettings;
