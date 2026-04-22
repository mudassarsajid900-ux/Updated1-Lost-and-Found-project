/**
 * @file axios.js
 * @description Global API Orchestrator for the GAC system.
 * Configures the base axios instance with automated security token attachment 
 * and global error interceptors for resilient session management.
 */
import axios from 'axios';

const api = axios.create({
    // Dynamically loaded from environment variables for production flexibility
    baseURL: import.meta.env.VITE_API_BASE_URL + '/api/',
});

/**
 * Request Interceptor
 * Automatically scans local storage for a valid JWT and attaches it to the 
 * Authorization header using the 'Bearer' scheme.
 */
api.interceptors.request.use(
    (config) => {
        const token = localStorage.getItem('token');
        if (token) {
            config.headers.Authorization = `Bearer ${token}`; 
        }
        return config;
    },
    (error) => {
        return Promise.reject(error);
    }
);

/**
 * Response Interceptor
 * Implements global 'Fail-Safe' logic:
 * 1. 401 Unauthorized: Triggers session cleanup and redirection to Login.
 * 2. 403 Forbidden: Logs security violations for administrative audit.
 * 3. 500+ Internal Error: Standardizes error trace logging for support.
 */
api.interceptors.response.use(
    (response) => response,
    (error) => {
        // Log all API errors for debugging support with context
        console.error("API Error Trace:", {
            url: error.config?.url,
            status: error.response?.status,
            data: error.response?.data
        });

        const status = error.response?.status;

        if (status === 401 && !window.location.pathname.includes('/login')) {
            // Identity session expired or compromised
            console.warn("Unauthorized Session Detected! Purging credentials...");
            localStorage.clear(); 
            window.location.href = '/login';   
        } 
        else if (status === 403) {
            // Role-based access violation
            console.error("Security Violation: User lacks required permissions for this endpoint.");
        }

        return Promise.reject(error);
    }
);

export default api;
