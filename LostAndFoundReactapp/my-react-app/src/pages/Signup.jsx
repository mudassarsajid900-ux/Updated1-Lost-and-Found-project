import React, { useState } from 'react';
import { useNavigate } from 'react-router-dom';
import { User, Mail, Lock, ArrowLeft } from 'lucide-react';
import api from '../api/axios';

const Signup = () => {
    const navigate = useNavigate();
    const [formData, setFormData] = useState({
        fullName: '',
        email: '',
        password: '',
        confirmPassword: ''
    });
    const [error, setError] = useState('');

    const handleChange = (e) => {
        setFormData({ ...formData, [e.target.name]: e.target.value });
    };

    const handleSubmit = async (e) => {
        e.preventDefault();
        setError('');

        if (formData.password !== formData.confirmPassword) {
            setError('Passwords do not match.');
            return;
        }

        const nameParts = formData.fullName.split(' ');
        const firstName = nameParts[0];
        const lastName = nameParts.length > 1 ? nameParts.slice(1).join(' ') : '';

        try {
            await api.post('Auth/register', {
                userName: formData.email, // Using email as username for consistency
                email: formData.email,
                password: formData.password,
                firstName: firstName,
                lastName: lastName,
                isActive: true
            });

            // Redirect to login on success
            navigate('/login', { state: { message: 'Registration successful! Please log in.' } });
        } catch (err) {
            setError(err.response?.data?.message || err.response?.data?.Message || 'Registration failed.');
        }
    };

    return (
        <div className="container" style={{ minHeight: '100vh', display: 'flex', flexDirection: 'column', justifyContent: 'center' }}>
            <button
                onClick={() => navigate('/')}
                style={{ background: 'none', color: 'var(--text-muted)', display: 'flex', alignItems: 'center', gap: '0.5rem', marginBottom: '2rem' }}
            >
                <ArrowLeft size={20} /> Back
            </button>

            <h1 className="mb-4" style={{ fontSize: '2rem', fontWeight: 'bold' }}>Create Account</h1>
            <p className="text-muted mb-8">Join the community to help return lost items.</p>

            <form onSubmit={handleSubmit}>
                {error && <div style={{ color: '#e53e3e', fontSize: '0.85rem', marginBottom: '1rem', textAlign: 'center' }}>{error}</div>}
                <div className="input-group">
                    <label className="input-label">Full Name</label>
                    <div style={{ position: 'relative' }}>
                        <User size={20} className="text-muted" style={{ position: 'absolute', left: '1rem', top: '50%', transform: 'translateY(-50%)' }} />
                        <input
                            type="text"
                            name="fullName"
                            className="input-field"
                            style={{ paddingLeft: '3rem' }}
                            placeholder="John Doe"
                            value={formData.fullName}
                            onChange={handleChange}
                            required
                        />
                    </div>
                </div>

                <div className="input-group">
                    <label className="input-label">Email Address</label>
                    <div style={{ position: 'relative' }}>
                        <Mail size={20} className="text-muted" style={{ position: 'absolute', left: '1rem', top: '50%', transform: 'translateY(-50%)' }} />
                        <input
                            type="email"
                            name="email"
                            className="input-field"
                            style={{ paddingLeft: '3rem' }}
                            placeholder="example@gmail.com"
                            value={formData.email}
                            onChange={handleChange}
                            required
                        />
                    </div>
                </div>

                <div className="input-group">
                    <label className="input-label">Password</label>
                    <div style={{ position: 'relative' }}>
                        <Lock size={20} className="text-muted" style={{ position: 'absolute', left: '1rem', top: '50%', transform: 'translateY(-50%)' }} />
                        <input
                            type="password"
                            name="password"
                            className="input-field"
                            style={{ paddingLeft: '3rem' }}
                            placeholder="Create a password"
                            value={formData.password}
                            onChange={handleChange}
                            required
                        />
                    </div>
                </div>

                <div className="input-group">
                    <label className="input-label">Confirm Password</label>
                    <div style={{ position: 'relative' }}>
                        <Lock size={20} className="text-muted" style={{ position: 'absolute', left: '1rem', top: '50%', transform: 'translateY(-50%)' }} />
                        <input
                            type="password"
                            name="confirmPassword"
                            className="input-field"
                            style={{ paddingLeft: '3rem' }}
                            placeholder="Confirm your password"
                            value={formData.confirmPassword}
                            onChange={handleChange}
                            required
                        />
                    </div>
                </div>

                <button type="submit" className="btn btn-primary mb-6" style={{ marginTop: '1rem' }}>
                    By Signing Up
                </button>

                <p className="text-center text-muted">
                    Already have an account? <span className="text-primary" style={{ cursor: 'pointer' }} onClick={() => navigate('/login')}>Sign In</span>
                </p>
            </form>
        </div>
    );
};

export default Signup;
