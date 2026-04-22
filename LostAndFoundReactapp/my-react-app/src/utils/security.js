/**
 * @file security.js
 * @description Centralized security utilities for the GAC frontend.
 * Implements "Invisible Hardening" by sanitizing user inputs before they reach the backend.
 */

/**
 * Sanitizes a string by stripping potentially malicious HTML tags and attributes.
 * Prevents XSS attacks in dynamic forensic attribute rendering.
 * @param {string} input - The raw user input.
 * @returns {string} - The sanitized output.
 */
export const sanitizeInput = (input) => {
    if (typeof input !== 'string') return input;
    
    // Replace < and > with entity codes to neutralize HTML tags
    // This is "Invisible" to the user as it renders correctly in most UI contexts
    // but prevents the browser from executing scripts.
    return input
        .replace(/</g, "&lt;")
        .replace(/>/g, "&gt;")
        .replace(/"/g, "&quot;")
        .replace(/'/g, "&#039;")
        .trim();
};

/**
 * Validates file constraints (MIME type and Size) before upload.
 * Part of the "Failure Tester" audit: ensures malicious files never hit the server.
 */
export const validateFileUpload = (file) => {
    const allowedTypes = ['image/jpeg', 'image/png', 'image/gif', 'image/webp'];
    const maxSize = 5 * 1024 * 1024; // 5MB

    if (!allowedTypes.includes(file.type)) {
        return { valid: false, message: "Security Error: Unsupported file format. Use JPG, PNG, or WEBP." };
    }

    if (file.size > maxSize) {
        return { valid: false, message: "Limit Error: Image exceeds 5MB." };
    }

    return { valid: true };
};
