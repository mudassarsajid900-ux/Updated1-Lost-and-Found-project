// ========================================== //
// SECTION 1: IMPORTS
// ========================================== //
import React, { useState, useEffect, useCallback } from 'react';
import {
    Users, Plus, Search, Edit2, Trash2,
    X, Eye, EyeOff, ChevronLeft, ChevronRight,
    AlertTriangle, CheckCircle, UserCheck
} from 'lucide-react';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';
import api from '../api/axios';

// ========================================== //
// SECTION 2: HELPER – LOADING SPINNER
// ========================================== //
const Spinner = () => (
    <div style={{ display: 'flex', justifyContent: 'center', alignItems: 'center', padding: '3rem' }}>
        <div style={{
            width: '40px', height: '40px',
            border: '4px solid #e2e8f0',
            borderTop: '4px solid #319795',
            borderRadius: '50%',
            animation: 'spin 0.8s linear infinite'
        }} />
        <style>{`@keyframes spin { to { transform: rotate(360deg); } }`}</style>
    </div>
);

// ========================================== //
// SECTION 3: USER FORM MODAL (Create & Edit)
// ========================================== //
const UserFormModal = ({ mode, user, onClose, onSaved, availableRoles }) => {
    // mode = 'create' | 'edit'
    const [form, setForm] = useState({
        userName: user?.userName || '',
        firstName: user?.firstNameEn || user?.firstName || '',
        lastName: user?.lastNameEn || user?.lastName || '',
        email: user?.email || '',
        password: '',
        roleId: '', // initially empty
    });

    // Sync roleId when availableRoles or user changes
    useEffect(() => {
        if (availableRoles?.length > 0) {
            let initialRoleId = '';
            if (mode === 'edit' && user?.roles?.length > 0) {
                const currentRole = availableRoles.find(r =>
                    user.roles.some(userRole => userRole.toLowerCase() === r.name.toLowerCase())
                );
                if (currentRole) initialRoleId = currentRole.id;
            } else if (mode === 'create') {
                const userRole = availableRoles.find(r => r.name.toLowerCase() === 'user');
                if (userRole) initialRoleId = userRole.id;
            }
            setForm(prev => ({ ...prev, roleId: initialRoleId }));
        }
    }, [availableRoles, user, mode]);
    const [showPass, setShowPass] = useState(false);
    const [loading, setLoading] = useState(false);
    const [error, setError] = useState('');

    const handleChange = (e) => setForm({ ...form, [e.target.name]: e.target.value });

    const handleSubmit = async (e) => {
        e.preventDefault();
        setError('');
        setLoading(true);
        try {
            if (mode === 'create') {
                // POST /api/Users — CreateUserDto
                await api.post('Users', {
                    userName: form.email.split('@')[0], // auto-generate from email
                    firstName: form.firstName,
                    lastName: form.lastName,
                    email: form.email,
                    password: form.password,
                    firstNameAr: '',
                    lastNameAr: '',
                    roleId: form.roleId ? parseInt(form.roleId) : null
                });
            } else {
                // PUT /api/Users/{id} — UpdateUserDto
                await api.put(`Users/${user.id}`, {
                    id: user.id,
                    userName: form.email ? form.email.split('@')[0] : form.userName,
                    firstName: form.firstName,
                    lastName: form.lastName,
                    email: form.email,
                    password: form.password || null,
                    firstNameAr: '',
                    lastNameAr: '',
                    roleId: form.roleId ? parseInt(form.roleId) : null
                });
            }
            onSaved(); // refresh parent list
            onClose();
        } catch (err) {
            setError(err.response?.data?.message || err.response?.data || 'Operation failed. Please try again.');
        } finally {
            setLoading(false);
        }
    };

    const inputStyle = {
        width: '100%', padding: '0.75rem 1rem', borderRadius: '10px',
        border: '1.5px solid #e2e8f0', fontSize: '0.95rem', color: '#2d3748',
        background: '#f8fafc', outline: 'none', boxSizing: 'border-box',
        transition: 'border-color 0.2s'
    };
    const labelStyle = { fontWeight: '600', fontSize: '0.85rem', color: '#4a5568', display: 'block', marginBottom: '6px' };

    return (
        // Modal Backdrop
        <div style={{
            position: 'fixed', inset: 0, background: 'rgba(0,0,0,0.4)',
            backdropFilter: 'blur(4px)', display: 'flex',
            alignItems: 'center', justifyContent: 'center', zIndex: 1000
        }}>
            {/* Modal Card */}
            <div style={{
                background: 'white', borderRadius: '24px', padding: '2.5rem',
                width: '100%', maxWidth: '500px', boxShadow: '0 25px 50px rgba(0,0,0,0.15)',
                position: 'relative', animation: 'slideUp 0.3s ease'
            }}>
                <style>{`@keyframes slideUp { from { opacity:0; transform:translateY(20px); } to { opacity:1; transform:translateY(0); } }`}</style>

                {/* Header Row */}
                <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center', marginBottom: '2rem' }}>
                    <div>
                        <h2 style={{ margin: 0, fontSize: '1.4rem', fontWeight: '800', color: '#1e293b' }}>
                            {mode === 'create' ? '➕ Create New User' : '✏️ Edit User'}
                        </h2>
                        <p style={{ margin: '4px 0 0', color: '#64748b', fontSize: '0.9rem' }}>
                            {mode === 'create' ? 'Assign university credentials to a new user.' : 'Update the user\'s details below.'}
                        </p>
                    </div>
                    <button onClick={onClose} style={{ background: '#f1f5f9', border: 'none', borderRadius: '10px', padding: '8px', cursor: 'pointer' }}>
                        <X size={20} color="#64748b" />
                    </button>
                </div>

                {/* Error Banner */}
                {error && (
                    <div style={{ background: '#fff5f5', border: '1px solid #fed7d7', borderRadius: '10px', padding: '0.75rem 1rem', marginBottom: '1.25rem', color: '#c53030', fontSize: '0.9rem', display: 'flex', gap: '8px', alignItems: 'center' }}>
                        <AlertTriangle size={16} /> {error}
                    </div>
                )}

                {/* Form */}
                <form onSubmit={handleSubmit}>
                    <div style={{ display: 'grid', gridTemplateColumns: '1fr 1fr', gap: '1rem', marginBottom: '1rem' }}>
                        <div>
                            <label style={labelStyle}>First Name</label>
                            <input name="firstName" style={inputStyle} placeholder="Enter First Name" value={form.firstName} onChange={handleChange} required
                                onFocus={e => e.target.style.borderColor = '#319795'} onBlur={e => e.target.style.borderColor = '#e2e8f0'} />
                        </div>
                        <div>
                            <label style={labelStyle}>Last Name</label>
                            <input name="lastName" style={inputStyle} placeholder="Enter Last Name" value={form.lastName} onChange={handleChange} required
                                onFocus={e => e.target.style.borderColor = '#319795'} onBlur={e => e.target.style.borderColor = '#e2e8f0'} />
                        </div>
                    </div>

                    <div style={{ display: 'grid', gridTemplateColumns: '2fr 1fr', gap: '1rem', marginBottom: '1rem' }}>
                        <div>
                            <label style={labelStyle}>University Email</label>
                            <input name="email" type="email" style={inputStyle} placeholder="Enter Email" value={form.email} onChange={handleChange} required
                                onFocus={e => e.target.style.borderColor = '#319795'} onBlur={e => e.target.style.borderColor = '#e2e8f0'} />
                        </div>
                        <div>
                            <label style={labelStyle}>Assign Role</label>
                            <select name="roleId" style={{ ...inputStyle, cursor: 'pointer', appearance: 'none', background: '#f8fafc url("data:image/svg+xml;charset=US-ASCII,%3Csvg%20width%3D%2220%22%20height%3D%2220%22%20xmlns%3D%22http%3A%2F%2Fwww.w3.org%2F2000%2Fsvg%22%3E%3Cpath%20d%3D%22M5%208l5%205%205-5%22%20stroke%3D%22%2364748b%22%20stroke-width%3D%222%22%20fill%3D%22none%22%20stroke-linecap%3D%22round%22%20stroke-linejoin%3D%22round%22%2F%3E%3C%2Fsvg%3E") no-repeat right 10px center' }} value={form.roleId} onChange={handleChange} required>
                                <option value="" disabled>Select Role</option>
                                {availableRoles?.map(role => (
                                    <option key={role.id} value={role.id}>{role.name}</option>
                                ))}
                            </select>
                        </div>
                    </div>

                    <div style={{ marginBottom: '1.5rem' }}>
                        <label style={labelStyle}>
                            {mode === 'create' ? 'Assign Password' : 'New Password (leave blank to keep current)'}
                        </label>
                        <div style={{ position: 'relative' }}>
                            <input
                                name="password" type={showPass ? 'text' : 'password'}
                                style={{ ...inputStyle, paddingRight: '3rem' }}
                                placeholder={mode === 'create' ? 'Min. 8 chars, 1 uppercase, 1 number' : 'Enter New Password'}
                                value={form.password} onChange={handleChange}
                                required={mode === 'create'}
                                onFocus={e => e.target.style.borderColor = '#319795'} onBlur={e => e.target.style.borderColor = '#e2e8f0'}
                            />
                            <button type="button" onClick={() => setShowPass(!showPass)} style={{ position: 'absolute', right: '12px', top: '50%', transform: 'translateY(-50%)', background: 'none', border: 'none', cursor: 'pointer', color: '#94a3b8' }}>
                                {showPass ? <EyeOff size={18} /> : <Eye size={18} />}
                            </button>
                        </div>
                        {mode === 'create' && <p style={{ margin: '6px 0 0', fontSize: '0.78rem', color: '#94a3b8' }}>Password policy: min 8 chars, 1 uppercase letter, 1 digit.</p>}
                    </div>

                    {/* Action Buttons */}
                    <div style={{ display: 'flex', gap: '1rem' }}>
                        <button type="button" onClick={onClose} style={{ flex: 1, padding: '0.85rem', borderRadius: '12px', border: '1.5px solid #e2e8f0', background: 'white', color: '#64748b', fontWeight: '600', cursor: 'pointer', fontSize: '0.95rem' }}>
                            Cancel
                        </button>
                        <button type="submit" disabled={loading} style={{ flex: 2, padding: '0.85rem', borderRadius: '12px', border: 'none', background: loading ? '#a0aec0' : 'linear-gradient(135deg, #319795, #2c7a7b)', color: 'white', fontWeight: '700', cursor: loading ? 'not-allowed' : 'pointer', fontSize: '0.95rem', display: 'flex', alignItems: 'center', justifyContent: 'center', gap: '8px' }}>
                            {loading ? 'Saving...' : (mode === 'create' ? <><UserCheck size={18} /> Create User</> : <><CheckCircle size={18} /> Save Changes</>)}
                        </button>
                    </div>
                </form>
            </div>
        </div>
    );
};

// ========================================== //
// SECTION 4: DELETE CONFIRM MODAL
// ========================================== //
const DeleteModal = ({ user, onClose, onDeleted }) => {
    const [loading, setLoading] = useState(false);
    const [error, setError] = useState('');

    const handleDelete = async () => {
        setLoading(true);
        try {
            await api.delete(`Users/${user.id}`);
            onDeleted();
            onClose();
        } catch (err) {
            setError(err.response?.data?.message || 'Failed to delete user.');
        } finally {
            setLoading(false);
        }
    };

    return (
        <div style={{ position: 'fixed', inset: 0, background: 'rgba(0,0,0,0.4)', backdropFilter: 'blur(4px)', display: 'flex', alignItems: 'center', justifyContent: 'center', zIndex: 1000 }}>
            <div style={{ background: 'white', borderRadius: '24px', padding: '2.5rem', maxWidth: '420px', width: '100%', boxShadow: '0 25px 50px rgba(0,0,0,0.15)', textAlign: 'center' }}>
                <div style={{ width: '60px', height: '60px', background: '#fff5f5', borderRadius: '50%', display: 'flex', alignItems: 'center', justifyContent: 'center', margin: '0 auto 1.5rem' }}>
                    <AlertTriangle size={28} color="#e53e3e" />
                </div>
                <h2 style={{ margin: '0 0 0.5rem', color: '#1e293b', fontWeight: '800', fontSize: '1.3rem' }}>Delete User?</h2>
                <p style={{ color: '#64748b', fontSize: '0.95rem', marginBottom: '0.5rem' }}>
                    You are about to permanently delete:
                </p>
                <p style={{ fontWeight: '700', color: '#e53e3e', fontSize: '1rem', margin: '0 0 1.5rem' }}>
                    {user.firstNameEn || user.firstName} {user.lastNameEn || user.lastName} ({user.email})
                </p>
                {error && <p style={{ color: '#e53e3e', fontSize: '0.9rem', marginBottom: '1rem' }}>{error}</p>}
                <div style={{ display: 'flex', gap: '1rem' }}>
                    <button onClick={onClose} style={{ flex: 1, padding: '0.85rem', borderRadius: '12px', border: '1.5px solid #e2e8f0', background: 'white', color: '#64748b', fontWeight: '600', cursor: 'pointer' }}>Cancel</button>
                    <button onClick={handleDelete} disabled={loading} style={{ flex: 1, padding: '0.85rem', borderRadius: '12px', border: 'none', background: '#e53e3e', color: 'white', fontWeight: '700', cursor: loading ? 'not-allowed' : 'pointer' }}>
                        {loading ? 'Deleting...' : 'Yes, Delete'}
                    </button>
                </div>
            </div>
        </div>
    );
};

// ========================================== //
// SECTION 5: MAIN MANAGE USERS PAGE
// ========================================== //
const AdminManageUsers = () => {
    // --- State ---
    const [users, setUsers] = useState([]);
    const [totalUsers, setTotalUsers] = useState(0);
    const [loading, setLoading] = useState(true);
    const [searchQuery, setSearchQuery] = useState('');
    const [page, setPage] = useState(0);         // 0-indexed
    const [pageSize] = useState(10);

    // Modal state
    const [showCreate, setShowCreate] = useState(false);
    const [editUser, setEditUser] = useState(null);   // user object | null
    const [deleteUser, setDeleteUser] = useState(null); // user object | null
    const [availableRoles, setAvailableRoles] = useState([]);

    // ---- Fetch Roles ----
    useEffect(() => {
        const fetchRoles = async () => {
            try {
                const response = await api.get('roles/GetAllRoles');
                console.log("Fetched roles:", response.data);
                setAvailableRoles(response.data || []);
            } catch (err) {
                console.error("Failed to fetch roles", err);
            }
        };
        fetchRoles();
    }, []);

    // ---- Fetch Users from Backend ----
    const fetchUsers = useCallback(async () => {
        setLoading(true);
        try {
            // Build the DataTableRequest the backend expects
            const requestBody = {
                draw: 1,
                start: page * pageSize,
                length: pageSize,
                search: { value: searchQuery, regex: false },
                order: [{ column: 0, dir: 'asc' }],
                columns: [
                    { data: 'email', name: 'Email', searchable: true, orderable: true, search: { value: '', regex: false } }
                ]
            };
            const response = await api.post('Users/list', requestBody);
            setUsers(response.data.result || []);
            setTotalUsers(response.data.recordsTotal || 0);
        } catch (err) {
            console.error('Failed to fetch users:', err);
            setUsers([]);
        } finally {
            setLoading(false);
        }
    }, [page, pageSize, searchQuery]);

    useEffect(() => {
        // Debounce search so we don't hammer API on every keypress
        const timer = setTimeout(fetchUsers, 400);
        return () => clearTimeout(timer);
    }, [fetchUsers]);

    const totalPages = Math.ceil(totalUsers / pageSize);

    // ---- UI Helpers ----
    const getRoleColor = (roles) => {
        if (!roles || roles.length === 0) return { bg: '#f1f5f9', color: '#64748b' };
        if (roles.some(r => r.toLowerCase().includes('admin'))) return { bg: '#fef3c7', color: '#d97706' };
        return { bg: '#e6fffa', color: '#319795' };
    };

    return (
        <div className="dashboard-container">
            {/* Sidebar with isAdmin=true to show admin nav */}
            <Sidebar isAdmin={true} />

            <main className="main-content" style={{ background: '#f8fafc', padding: '2.5rem' }}>
                <Header title="Manage Users" subtitle="View, create, edit and delete university user accounts." />

                <div style={{ marginTop: '2rem' }}>

                    {/* ---- TOP ACTION BAR ---- */}
                    <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center', marginBottom: '1.5rem', flexWrap: 'wrap', gap: '1rem' }}>

                        {/* Page Title + Count */}
                        <div style={{ display: 'flex', alignItems: 'center', gap: '12px' }}>
                            <div style={{ width: '44px', height: '44px', background: 'linear-gradient(135deg, #319795, #2c7a7b)', borderRadius: '12px', display: 'flex', alignItems: 'center', justifyContent: 'center' }}>
                                <Users size={22} color="white" />
                            </div>
                            <div>
                                <h2 style={{ margin: 0, fontSize: '1.5rem', fontWeight: '800', color: '#1e293b' }}>All Users</h2>
                                <p style={{ margin: 0, color: '#64748b', fontSize: '0.9rem' }}>{totalUsers} total registered accounts</p>
                            </div>
                        </div>

                        {/* Search + Create Button */}
                        <div style={{ display: 'flex', gap: '1rem', alignItems: 'center', flexWrap: 'wrap' }}>
                            {/* Search Box */}
                            <div style={{ position: 'relative' }}>
                                <Search size={16} style={{ position: 'absolute', left: '12px', top: '50%', transform: 'translateY(-50%)', color: '#94a3b8' }} />
                                <input
                                    type="text"
                                    placeholder="Search by email or name..."
                                    value={searchQuery}
                                    onChange={e => { setSearchQuery(e.target.value); setPage(0); }}
                                    style={{
                                        paddingLeft: '36px', paddingRight: '16px', paddingTop: '10px', paddingBottom: '10px',
                                        borderRadius: '12px', border: '1.5px solid #e2e8f0', background: 'white',
                                        fontSize: '0.9rem', color: '#2d3748', outline: 'none', width: '260px'
                                    }}
                                    onFocus={e => e.target.style.borderColor = '#319795'}
                                    onBlur={e => e.target.style.borderColor = '#e2e8f0'}
                                />
                            </div>

                            {/* Create Button */}
                            <button
                                onClick={() => setShowCreate(true)}
                                style={{
                                    display: 'flex', alignItems: 'center', gap: '8px',
                                    padding: '10px 20px', borderRadius: '12px', border: 'none',
                                    background: 'linear-gradient(135deg, #319795, #2c7a7b)',
                                    color: 'white', fontWeight: '700', fontSize: '0.95rem', cursor: 'pointer',
                                    boxShadow: '0 4px 12px rgba(49,151,149,0.35)',
                                    transition: 'transform 0.2s, box-shadow 0.2s'
                                }}
                                onMouseOver={e => { e.currentTarget.style.transform = 'translateY(-2px)'; e.currentTarget.style.boxShadow = '0 6px 18px rgba(49,151,149,0.45)'; }}
                                onMouseOut={e => { e.currentTarget.style.transform = 'none'; e.currentTarget.style.boxShadow = '0 4px 12px rgba(49,151,149,0.35)'; }}
                            >
                                <Plus size={18} /> Create New User
                            </button>
                        </div>
                    </div>

                    {/* ---- USERS TABLE CARD ---- */}
                    <div style={{ background: 'white', borderRadius: '20px', border: '1px solid #e2e8f0', boxShadow: '0 4px 6px rgba(0,0,0,0.02)', overflow: 'hidden' }}>

                        {/* Table Header */}
                        <div style={{ display: 'grid', gridTemplateColumns: '2fr 2.5fr 1.5fr 1fr', gap: '1rem', padding: '1rem 1.5rem', background: '#f8fafc', borderBottom: '1px solid #e2e8f0' }}>
                            {['Name', 'Email', 'Role', 'Actions'].map(col => (
                                <span key={col} style={{ fontWeight: '700', fontSize: '0.8rem', color: '#64748b', textTransform: 'uppercase', letterSpacing: '0.5px' }}>{col}</span>
                            ))}
                        </div>

                        {/* Table Body */}
                        {loading ? (
                            <Spinner />
                        ) : users.length === 0 ? (
                            <div style={{ padding: '4rem', textAlign: 'center', color: '#94a3b8' }}>
                                <Users size={48} style={{ margin: '0 auto 1rem', opacity: 0.3 }} />
                                <p style={{ fontWeight: '600', fontSize: '1.1rem' }}>No users found</p>
                                <p style={{ fontSize: '0.9rem' }}>Try adjusting your search or create a new user.</p>
                            </div>
                        ) : (
                            users.map((user, idx) => {
                                const roleStyle = getRoleColor(user.roles);
                                return (
                                    <div
                                        key={user.id || idx}
                                        style={{
                                            display: 'grid', gridTemplateColumns: '2fr 2.5fr 1.5fr 1fr',
                                            gap: '1rem', padding: '1rem 1.5rem',
                                            borderBottom: idx === users.length - 1 ? 'none' : '1px solid #f1f5f9',
                                            alignItems: 'center', transition: 'background 0.15s'
                                        }}
                                        onMouseOver={e => e.currentTarget.style.background = '#fafbfc'}
                                        onMouseOut={e => e.currentTarget.style.background = 'transparent'}
                                    >
                                        {/* Name + Avatar */}
                                        <div style={{ display: 'flex', alignItems: 'center', gap: '12px' }}>
                                            <div style={{
                                                width: '38px', height: '38px', borderRadius: '50%',
                                                background: 'linear-gradient(135deg, #e6fffa, #b2f5ea)',
                                                display: 'flex', alignItems: 'center', justifyContent: 'center',
                                                fontWeight: '700', color: '#319795', fontSize: '0.9rem', flexShrink: 0
                                            }}>
                                                {((user.firstNameEn || user.firstName)?.[0] || user.email?.[0] || '?').toUpperCase()}
                                            </div>
                                            <div>
                                                <p style={{ margin: 0, fontWeight: '700', color: '#1e293b', fontSize: '0.95rem' }}>
                                                    {user.firstNameEn || user.firstName || ''} {user.lastNameEn || user.lastName || ''}
                                                </p>
                                                <p style={{ margin: 0, fontSize: '0.8rem', color: '#94a3b8' }}>@{user.userName || ''}</p>
                                            </div>
                                        </div>

                                        {/* Email */}
                                        <span style={{ fontSize: '0.9rem', color: '#475569' }}>{user.email}</span>

                                        {/* Role Badge */}
                                        <div>
                                            {user.roles && user.roles.length > 0 ? (
                                                user.roles.map((r, i) => (
                                                    <span key={i} style={{
                                                        background: roleStyle.bg, color: roleStyle.color,
                                                        padding: '3px 10px', borderRadius: '20px',
                                                        fontSize: '0.8rem', fontWeight: '600', marginRight: '4px'
                                                    }}>{r}</span>
                                                ))
                                            ) : (
                                                <span style={{ background: '#f1f5f9', color: '#94a3b8', padding: '3px 10px', borderRadius: '20px', fontSize: '0.8rem', fontWeight: '600' }}>No Role</span>
                                            )}
                                        </div>

                                        {/* Action Buttons */}
                                        <div style={{ display: 'flex', gap: '8px' }}>
                                            {/* Edit */}
                                            <button
                                                onClick={() => setEditUser(user)}
                                                title="Edit User"
                                                style={{ background: '#eff6ff', border: '1px solid #bfdbfe', color: '#3b82f6', borderRadius: '8px', padding: '6px 10px', cursor: 'pointer', display: 'flex', alignItems: 'center', gap: '4px', fontWeight: '600', fontSize: '0.82rem', transition: 'all 0.2s' }}
                                                onMouseOver={e => e.currentTarget.style.background = '#dbeafe'}
                                                onMouseOut={e => e.currentTarget.style.background = '#eff6ff'}
                                            >
                                                <Edit2 size={14} /> Edit
                                            </button>
                                            {/* Delete */}
                                            <button
                                                onClick={() => setDeleteUser(user)}
                                                title="Delete User"
                                                style={{ background: '#fff5f5', border: '1px solid #fed7d7', color: '#e53e3e', borderRadius: '8px', padding: '6px 10px', cursor: 'pointer', display: 'flex', alignItems: 'center', gap: '4px', fontWeight: '600', fontSize: '0.82rem', transition: 'all 0.2s' }}
                                                onMouseOver={e => e.currentTarget.style.background = '#fed7d7'}
                                                onMouseOut={e => e.currentTarget.style.background = '#fff5f5'}
                                            >
                                                <Trash2 size={14} /> Delete
                                            </button>
                                        </div>
                                    </div>
                                );
                            })
                        )}

                        {/* ---- PAGINATION FOOTER ---- */}
                        {!loading && totalPages > 1 && (
                            <div style={{ padding: '1rem 1.5rem', borderTop: '1px solid #f1f5f9', display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
                                <span style={{ fontSize: '0.88rem', color: '#64748b' }}>
                                    Showing {page * pageSize + 1}–{Math.min((page + 1) * pageSize, totalUsers)} of {totalUsers} users
                                </span>
                                <div style={{ display: 'flex', gap: '8px' }}>
                                    <button
                                        onClick={() => setPage(p => Math.max(0, p - 1))}
                                        disabled={page === 0}
                                        style={{ padding: '6px 12px', borderRadius: '8px', border: '1px solid #e2e8f0', background: page === 0 ? '#f8fafc' : 'white', color: page === 0 ? '#cbd5e0' : '#334155', cursor: page === 0 ? 'default' : 'pointer', display: 'flex', alignItems: 'center', gap: '4px', fontWeight: '600', fontSize: '0.85rem' }}
                                    >
                                        <ChevronLeft size={16} /> Prev
                                    </button>
                                    <button
                                        onClick={() => setPage(p => Math.min(totalPages - 1, p + 1))}
                                        disabled={page >= totalPages - 1}
                                        style={{ padding: '6px 12px', borderRadius: '8px', border: '1px solid #e2e8f0', background: page >= totalPages - 1 ? '#f8fafc' : 'white', color: page >= totalPages - 1 ? '#cbd5e0' : '#334155', cursor: page >= totalPages - 1 ? 'default' : 'pointer', display: 'flex', alignItems: 'center', gap: '4px', fontWeight: '600', fontSize: '0.85rem' }}
                                    >
                                        Next <ChevronRight size={16} />
                                    </button>
                                </div>
                            </div>
                        )}
                    </div>
                </div>
            </main>

            {/* ---- MODALS ---- */}
            {showCreate && (
                <UserFormModal
                    mode="create"
                    user={null}
                    availableRoles={availableRoles}
                    onClose={() => setShowCreate(false)}
                    onSaved={fetchUsers}
                />
            )}
            {editUser && (
                <UserFormModal
                    mode="edit"
                    user={editUser}
                    availableRoles={availableRoles}
                    onClose={() => setEditUser(null)}
                    onSaved={fetchUsers}
                />
            )}
            {deleteUser && (
                <DeleteModal
                    user={deleteUser}
                    onClose={() => setDeleteUser(null)}
                    onDeleted={fetchUsers}
                />
            )}
        </div>
    );
};

export default AdminManageUsers;
