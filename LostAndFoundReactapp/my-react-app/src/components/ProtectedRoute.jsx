import React from 'react';
import { Navigate, useLocation } from 'react-router-dom';

/**
 * ProtectedRoute component - prevents unauthorized access to sensitive pages.
 * 
 * @param {Object} props
 * @param {React.ReactNode} props.children - The component to render if authorized
 * @param {boolean} [props.adminOnly=false] - If true, only users with 'isAdmin' status can see it
 */
const ProtectedRoute = ({ children, adminOnly = false }) => {
    const location = useLocation();
    
    // 1. Check if the user is logged in (has a token)
    const token = localStorage.getItem('token');
    
    // 2. Check if the user is an admin
    const isAdmin = localStorage.getItem('isAdmin') === 'true';

    // If NO token, force them to the login page immediately
    if (!token) {
        return <Navigate to="/login" state={{ from: location }} replace />;
    }

    // If the route is ADMIN ONLY but the user is NOT an admin
    if (adminOnly && !isAdmin) {
        // Redirect regular users to their dashboard if they try to peek at admin pages
        return <Navigate to="/dashboard" replace />;
    }

    // If everything is fine, show the requested page
    return children;
};

export default ProtectedRoute;
