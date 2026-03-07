// ========================================== //
// SECTION 1: IMPORTS
// We import React and necessary components from libraries.
// 'lucide-react' provides the icons used on the page.
// 'react-router-dom' provides navigation features.
// ========================================== //
import React from 'react';
import { useNavigate } from 'react-router-dom';
import { Package, Search, Heart, Smartphone, Laptop, Wallet, ShoppingBag, User } from 'lucide-react';

// ========================================== //
// SECTION 2: MAIN WELCOME PAGE COMPONENT
// This is the first page users see when they open the application.
// It contains the hero illustration, branding, and the login button.
// ========================================== //
const Welcome = () => {
  // 'navigate' allows us to redirect the user to other pages
  const navigate = useNavigate();

  return (
    <div className="auth-container" style={{
      position: 'relative',
      overflow: 'hidden',
      display: 'flex',
      flexDirection: 'column',
      justifyContent: 'center',
      alignItems: 'center',
      padding: '2rem',
      textAlign: 'center',
      minHeight: '100vh'
    }}>

      {/* ------------------------------------------- */}
      {/* SECTION 3: BACKGROUND DECORATION */}
      {/* These divs create the soft, blurry pastel shapes in the background */}
      {/* ------------------------------------------- */}
      <div style={{
        position: 'absolute',
        top: '5%',
        left: '2%',
        width: '300px',
        height: '300px',
        background: 'rgba(217, 239, 226, 0.4)',
        borderRadius: '50%',
        filter: 'blur(80px)',
        zIndex: 0
      }} />
      <div style={{
        position: 'absolute',
        bottom: '5%',
        right: '2%',
        width: '350px',
        height: '350px',
        background: 'rgba(175, 203, 240, 0.3)',
        borderRadius: '50%',
        filter: 'blur(100px)',
        zIndex: 0
      }} />

      <div className="welcome-content" style={{ position: 'relative', zIndex: 1, maxWidth: '420px', width: '100%' }}>

        {/* ------------------------------------------- */}
        {/* SECTION 4: HERO ILLUSTRATION GRAPHIC */}
        {/* Code below generates the floating box, laptop, and wallet icons */}
        {/* ------------------------------------------- */}
        <div style={{
          marginBottom: '3.5rem',
          position: 'relative',
          display: 'inline-block',
          animation: 'floatHero 6s ease-in-out infinite'
        }}>
          {/* Main Branding Cluster */}
          <div style={{
            width: '240px',
            height: '240px',
            position: 'relative',
            display: 'flex',
            alignItems: 'center',
            justifyContent: 'center'
          }}>
            {/* Background Spinning dashed circle */}
            <div style={{
              position: 'absolute',
              width: '100%',
              height: '100%',
              borderRadius: '50%',
              border: '2px dashed rgba(49, 151, 149, 0.2)',
              animation: 'spin 20s linear infinite'
            }} />

            {/* Laptop Icon (Deep Layer / Behind) */}
            <div style={{ position: 'absolute', top: '15%', right: '5%', opacity: 0.15, transform: 'rotate(10deg)' }}>
              <Laptop size={120} color="#2d3748" strokeWidth={0.5} />
            </div>

            {/* The main central glass card holding the Box and Search icon */}
            <div style={{
              width: '180px',
              height: '180px',
              backgroundColor: 'rgba(255, 255, 255, 0.7)',
              borderRadius: '40px',
              display: 'flex',
              alignItems: 'center',
              justifyContent: 'center',
              boxShadow: '0 25px 50px -12px rgba(0, 0, 0, 0.1)',
              border: '1px solid rgba(255, 255, 255, 0.8)',
              backdropFilter: 'blur(12px)',
              position: 'relative',
              zIndex: 2
            }}>
              <div style={{ position: 'relative' }}>
                <Package size={80} color="#2d3748" strokeWidth={1} />

                {/* Floating Smartphone Icon */}
                <div style={{ position: 'absolute', top: '-25px', right: '-35px', animation: 'floatHero 4s ease-in-out infinite alternate' }}>
                  <div style={{ background: 'white', padding: '10px', borderRadius: '14px', boxShadow: '0 8px 16px rgba(0,0,0,0.06)', border: '1px solid #edf2f7' }}>
                    <Smartphone size={24} color="#4a5568" />
                  </div>
                </div>

                {/* Floating Wallet Icon */}
                <div style={{ position: 'absolute', bottom: '-20px', left: '-30px', animation: 'floatHero 5s ease-in-out infinite alternate-reverse 1s' }}>
                  <div style={{ background: 'white', padding: '12px', borderRadius: '15px', boxShadow: '0 8px 16px rgba(0,0,0,0.06)', border: '1px solid #edf2f7' }}>
                    <Wallet size={28} color="#a0522d" />
                  </div>
                </div>

                {/* Search Accent Icon overlay attached to the box */}
                <div style={{
                  position: 'absolute',
                  bottom: '-15px',
                  right: '-25px',
                  background: 'linear-gradient(135deg, #319795 0%, #2c7a7b 100%)',
                  borderRadius: '18px',
                  padding: '12px',
                  boxShadow: '0 12px 20px -5px rgba(49, 151, 149, 0.4)',
                  border: '3px solid white',
                  display: 'flex',
                  alignItems: 'center',
                  justifyContent: 'center'
                }}>
                  <Search size={28} color="white" strokeWidth={2.5} />
                </div>
              </div>
            </div>

            {/* Bag Icon slightly peaking from behind */}
            <div style={{ position: 'absolute', bottom: '10%', left: '5%', opacity: 0.2 }}>
              <ShoppingBag size={60} color="#2d3748" strokeWidth={1} />
            </div>
          </div>
        </div>

        {/* ------------------------------------------- */}
        {/* SECTION 5: TEXT AND BRANDING TITLE */}
        {/* Displays the main title ("Lost & Found Hub") */}
        {/* ------------------------------------------- */}
        <div style={{ display: 'flex', alignItems: 'center', justifyContent: 'center', gap: '1.25rem', marginBottom: '1.25rem' }}>
          {/* Logo Icon */}
          <div style={{
            width: '48px',
            height: '48px',
            background: 'linear-gradient(135deg, #e6fffa 0%, #b2f5ea 100%)',
            borderRadius: '14px',
            display: 'flex',
            alignItems: 'center',
            justifyContent: 'center',
            boxShadow: '0 4px 12px rgba(49, 151, 149, 0.15)',
            border: '1px solid rgba(49, 151, 149, 0.1)'
          }}>
            <User size={24} color="#319795" />
          </div>
          <h1 style={{
            fontSize: '2.8rem',
            fontWeight: '900',
            color: '#2d3748',
            margin: 0,
            letterSpacing: '-1.5px',
            lineHeight: '1.1'
          }}>
            Lost & Found<br />
            <span style={{ color: '#319795' }}>Hub</span>
          </h1>
        </div>

        {/* Short description text */}
        <p style={{
          fontSize: '1.15rem',
          color: '#718096',
          marginBottom: '4rem',
          fontWeight: '500',
          maxWidth: '340px',
          margin: '1.25rem auto 4rem',
          lineHeight: '1.6'
        }}>
          Experience the smartest and most elegant way to reunite with your lost belongings.
        </p>

        {/* ------------------------------------------- */}
        {/* SECTION 6: ACTION BUTTONS */}
        {/* Takes the user to the login page */}
        {/* ------------------------------------------- */}
        <div style={{
          display: 'flex',
          flexDirection: 'column',
          gap: '1.25rem',
          width: '100%'
        }}>
          {/* Main Login Button */}
          <button
            onClick={() => navigate('/login')}
            className="submit-btn"
            style={{
              margin: 0,
              padding: '1.25rem',
              fontSize: '1.15rem',
              background: 'var(--focus-color)',
              boxShadow: 'var(--shadow-color)',
              borderRadius: '16px',
              fontWeight: '700',
              transform: 'translateY(0)',
              transition: 'all 0.3s cubic-bezier(0.175, 0.885, 0.32, 1.275)'
            }}
            onMouseOver={(e) => {
              e.currentTarget.style.transform = 'scale(1.03) translateY(-2px)';
              e.currentTarget.style.boxShadow = '0 15px 30px rgba(49, 151, 149, 0.4)';
            }}
            onMouseOut={(e) => {
              e.currentTarget.style.transform = 'scale(1) translateY(0)';
              e.currentTarget.style.boxShadow = 'var(--shadow-color)';
            }}
          >
            Sign In to Portal
          </button>
        </div>

        {/* ------------------------------------------- */}
        {/* SECTION 7: STATISTICS DISPLAY */}
        {/* Shows fake dummy statistics to make the page look busy */}
        {/* ------------------------------------------- */}
        <div style={{
          marginTop: '4rem',
          display: 'flex',
          justifyContent: 'center',
          alignItems: 'center',
          gap: '2rem',
          opacity: 0.7
        }}>
          <div style={{ textAlign: 'center' }}>
            <div style={{ fontSize: '1.2rem', fontWeight: '800', color: '#2d3748' }}>50k+</div>
            <div style={{ fontSize: '0.75rem', color: '#718096', fontWeight: '600' }}>Active Users</div>
          </div>

          {/* Vertical dividing line */}
          <div style={{ width: '1px', height: '30px', background: '#e2e8f0' }} />

          <div style={{ textAlign: 'center' }}>
            <div style={{ fontSize: '1.2rem', fontWeight: '800', color: '#2d3748' }}>Over 95%</div>
            <div style={{ fontSize: '0.75rem', color: '#718096', fontWeight: '600' }}>Items Returned</div>
          </div>
        </div>
      </div>

      {/* ------------------------------------------- */}
      {/* SECTION 8: CUSTOM CSS ANIMATIONS */}
      {/* ------------------------------------------- */}
      <style>
        {`
            @keyframes floatHero {
                0%, 100% { transform: translateY(0) rotate(0deg); }
                50% { transform: translateY(-15px) rotate(1deg); }
            }
            @keyframes spin {
                from { transform: rotate(0deg); }
                to { transform: rotate(360deg); }
            }
            @keyframes subtlePulse {
                0%, 100% { transform: scale(1); box-shadow: 0 4px 6px rgba(0,0,0,0.05); }
                50% { transform: scale(1.05); box-shadow: 0 10px 15px rgba(239, 68, 68, 0.1); }
            }
            .submit-btn {
                cursor: pointer;
                border: none;
                color: white !important;
            }
        `}
      </style>
    </div>
  );
};

export default Welcome;
