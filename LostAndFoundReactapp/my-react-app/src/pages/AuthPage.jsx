// ========================================== //
// SECTION 1: IMPORTS
// We import React and necessary components from libraries.
// 'lucide-react' provides the icons used on the page.
// 'react-router-dom' provides navigation features.
// ========================================== //
import React, { useState } from 'react';
import { useLocation, useNavigate, Link } from 'react-router-dom';
import { User, Mail, Lock, Search, Package, Smartphone, Wallet, Laptop, ShoppingBag } from 'lucide-react';
import api from '../api/axios';

// ========================================== //
// SECTION 2: MAIN LOGIN PAGE COMPONENT
// This 'AuthPage' component holds the entire layout of the login screen.
// It divides the screen into two halves: Left (Branding) and Right (Login Form).
// ========================================== //
const AuthPage = () => {
    const location = useLocation();

    // 'navigate' allows us to redirect the user to other pages programmatically
    const navigate = useNavigate();

    return (
        <div className="auth-container">

            {/* The main white card containing everything on the page */}
            <div className="auth-card">

                {/* ------------------------------------------- */}
                {/* LEFT PANEL: BRANDING & ILLUSTRATION */}
                {/* This section contains the visual design, logo, and welcome text. */}
                {/* ------------------------------------------- */}
                <div className="auth-left">
                    <div className="brand-hero" style={{ marginBottom: '2rem' }}>

                        {/* The centered spinning graphic */}
                        <div style={{ position: 'relative', width: '120px', height: '120px', margin: '0 auto' }}>
                            {/* Background Spinner Ring */}
                            <div style={{
                                position: 'absolute',
                                top: 0, left: 0, width: '100%', height: '100%',
                                borderRadius: '50%', border: '1.5px dashed rgba(49, 151, 149, 0.2)',
                            }} />

                            {/* Centered Box with 'Package' Icon */}
                            <div style={{
                                width: '80px', height: '80px',
                                backgroundColor: 'white', borderRadius: '24px',
                                display: 'flex', alignItems: 'center', justifyContent: 'center',
                                boxShadow: '0 15px 30px rgba(0,0,0,0.08)',
                                position: 'relative', zIndex: 2, top: '20px', left: '20px'
                            }}>
                                <Package size={40} color="#2d3748" strokeWidth={1.5} />

                                {/* Small green 'Search' icon badge attached to the package box */}
                                <div style={{
                                    position: 'absolute', bottom: '-10px', right: '-10px',
                                    background: '#319795', borderRadius: '10px', padding: '6px',
                                    border: '2px solid white', boxShadow: '0 4px 10px rgba(49, 151, 149, 0.3)'
                                }}>
                                    <Search size={16} color="white" strokeWidth={3} />
                                </div>
                            </div>
                        </div>
                    </div>

                    {/* Logo and Main Heading */}
                    <div style={{ display: 'flex', alignItems: 'center', gap: '12px', marginBottom: '1rem' }}>
                        <div style={{
                            width: '32px', height: '32px',
                            background: 'linear-gradient(135deg, #e6fffa 0%, #b2f5ea 100%)',
                            borderRadius: '10px', display: 'flex', alignItems: 'center', justifyContent: 'center',
                            border: '1px solid rgba(49, 151, 149, 0.1)'
                        }}>
                            <User size={16} color="#319795" />
                        </div>
                        <h1 style={{ margin: 0, fontSize: '1.5rem', fontWeight: '900', color: '#2d3748' }}>
                            Lost & Found <span style={{ color: '#319795' }}>Hub</span>
                        </h1>
                    </div>

                    {/* Subtitle text */}
                    <p style={{ color: '#4a5568', fontWeight: '500' }}>The professional way to report lost items and reunite with what matters most.</p>
                </div>

                {/* ------------------------------------------- */}
                {/* RIGHT PANEL: LOGIN FORM AREA */}
                {/* This section holds the actual inputs for user authentication. */}
                {/* ------------------------------------------- */}
                <div className="auth-right">

                    {/* Header text above the form */}
                    <div className="auth-header">
                        <h2>Welcome Back</h2>
                        <p>Please enter your university credentials to sign in.</p>
                    </div>

                    {/* Form Container: Here we render the LoginForm component seen below */}
                    <div className="auth-form-container">
                        <LoginForm navigate={navigate} />
                    </div>
                </div>
            </div>
        </div>
    );
};

// ========================================== //
// SECTION 3: LOGIN FORM COMPONENT
// This component controls the email & password inputs.
// It also contains the logic to check if a user is an Admin or Normal User.
// ========================================== //
const LoginForm = ({ navigate }) => {

    // State variables to hold what the user types in the input fields
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [error, setError] = useState('');
    const successMessage = location.state?.message;

    // Function triggered when the user clicks 'Log In'
    const handleLogin = async (e) => {
        // Prevent the page from refreshing when clicking the button
        e.preventDefault();
        setError('');

        try {
            // Post email and password to our backend API
            const response = await api.post('Auth/login', {
                email: email,
                password: password
            });

            // Extract token and user data from the backend response (defensive casing)
            const token = response.data.token || response.data.Token;
            const roles = response.data.roles || response.data.Roles;

            console.log("Login successful, received token:", token ? "Yes" : "No");

            if (token) {
                // Save the JWT token to local storage so the axios interceptor can use it
                localStorage.setItem('token', token);

                // Save additional user info for UI display
                const username = response.data.username || response.data.Username;
                const userEmail = response.data.email || response.data.Email;
                if (username) localStorage.setItem('username', username);
                if (userEmail) localStorage.setItem('userEmail', userEmail);

                // Route user based on their Role
                if (roles && roles.includes('Admin')) {
                    localStorage.setItem('isAdmin', 'true');
                    navigate('/admin-dashboard');
                } else {
                    localStorage.setItem('isAdmin', 'false');
                    navigate('/dashboard');
                }
            } else {
                setError('Login failed: Invalid response from server.');
            }
        } catch (err) {
            // Check if backend returned a specific error message, otherwise show generic message
            if (err.response && err.response.status === 401) {
                setError('Invalid credentials.');
            } else {
                setError(err.response?.data?.message || err.response?.data?.Message || 'Connection to server failed.');
            }
        }
    };

    return (
        <form className="auth-form" onSubmit={handleLogin}>

            {/* Display error message dynamically if login fails */}
            {error && <div style={{ color: '#e53e3e', fontSize: '0.85rem', marginBottom: '1rem', textAlign: 'center', background: '#fff5f5', padding: '8px', borderRadius: '8px' }}>{error}</div>}
            {successMessage && <div style={{ color: '#319795', fontSize: '0.85rem', marginBottom: '1rem', textAlign: 'center', background: '#f0fff4', padding: '8px', borderRadius: '8px' }}>{successMessage}</div>}

            {/* Email Input Field */}
            <div className="floating-group">
                <input
                    type="email"
                    className="floating-input"
                    placeholder=" "
                    required
                    value={email}
                    onChange={(e) => { setEmail(e.target.value); setError(''); }}
                />
                <label className="floating-label">Email Address</label>
            </div>

            {/* Password Input Field */}
            <div className="floating-group">
                <input
                    type="password"
                    className="floating-input"
                    placeholder=" "
                    required
                    value={password}
                    onChange={(e) => { setPassword(e.target.value); setError(''); }}
                />
                <label className="floating-label">Password</label>
            </div>

            {/* Remember Me Checkbox & Forgot Password Link */}
            <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center', fontSize: '0.85rem', color: '#718096', marginBottom: '1.5rem' }}>
                <label style={{ display: 'flex', alignItems: 'center', gap: '0.5rem', cursor: 'pointer' }}>
                    <input type="checkbox" style={{ accentColor: '#319795' }} /> Remember me
                </label>
                <a href="#" style={{ color: '#319795', textDecoration: 'none', fontWeight: '500' }}>Forgot password?</a>
            </div>

            {/* Submit Button */}
            <button type="submit" className="submit-btn">Log In</button>
        </form>
    );
};

export default AuthPage;
