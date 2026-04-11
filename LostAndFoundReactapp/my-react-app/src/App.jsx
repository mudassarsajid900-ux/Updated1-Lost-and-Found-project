import React from 'react';
import { BrowserRouter as Router, Routes, Route, Navigate } from 'react-router-dom';
import ProtectedRoute from './components/ProtectedRoute';
import AuthPage from './pages/AuthPage';
import Dashboard from './pages/Dashboard';
import ReportFound from './pages/ReportFound';
import ReportLost from './pages/ReportLost';
import MyItems from './pages/MyItems';
import Auction from './pages/Auction';
import Settings from './pages/Settings';
import ItemReplacement from './pages/ItemReplacement';
import Welcome from './pages/Welcome';
import MatchDetails from './pages/MatchDetails';
import ClaimItem from './pages/ClaimItem';
import ClaimStatus from './pages/ClaimStatus';

import ReviewClaim from './pages/ReviewClaim';
import AdminDashboard from './admin/AdminDashboard';
import AdminManageUsers from './admin/AdminManageUsers';
import AdminSettings from './admin/AdminSettings';
import AdminReplacements from './admin/AdminReplacements';
import AdminHandover from './admin/AdminHandover';
import AdminAuctions from './admin/AdminAuctions';
import AdminInventory from './admin/AdminInventory';
import AdminCategories from './admin/AdminCategories';
import AdminReportControl from './admin/AdminReportControl';
import ReportDetails from './pages/ReportDetails';


function App() {
  return (
    <Router>
      <Routes>
        {/* PUBLIC ROUTES */}
        <Route path="/" element={<Welcome />} />
        <Route path="/login" element={<AuthPage />} />

        {/* USER PROTECTED ROUTES */}
        <Route path="/dashboard" element={<ProtectedRoute><Dashboard /></ProtectedRoute>} />
        <Route path="/report-found" element={<ProtectedRoute><ReportFound /></ProtectedRoute>} />
        <Route path="/report-lost" element={<ProtectedRoute><ReportLost /></ProtectedRoute>} />
        <Route path="/my-items" element={<ProtectedRoute><MyItems /></ProtectedRoute>} />
        <Route path="/auction" element={<ProtectedRoute><Auction /></ProtectedRoute>} />
        <Route path="/settings" element={<ProtectedRoute><Settings /></ProtectedRoute>} />
        <Route path="/item-replacement" element={<ProtectedRoute><ItemReplacement /></ProtectedRoute>} />
        <Route path="/match-details" element={<ProtectedRoute><MatchDetails /></ProtectedRoute>} />
        <Route path="/match-details/:lostItemId/:foundItemId" element={<ProtectedRoute><MatchDetails /></ProtectedRoute>} />
        <Route path="/claim-item" element={<ProtectedRoute><ClaimItem /></ProtectedRoute>} />
        <Route path="/claim-item/:lostItemId/:foundItemId" element={<ProtectedRoute><ClaimItem /></ProtectedRoute>} />
        <Route path="/claim-status" element={<ProtectedRoute><ClaimStatus /></ProtectedRoute>} />
        <Route path="/review-claim" element={<ProtectedRoute><ReviewClaim /></ProtectedRoute>} />
        <Route path="/report-details/:id" element={<ProtectedRoute><ReportDetails /></ProtectedRoute>} />

        {/* ADMIN PROTECTED ROUTES */}
        <Route path="/admin-dashboard" element={<ProtectedRoute adminOnly={true}><AdminDashboard /></ProtectedRoute>} />
        <Route path="/admin-users" element={<ProtectedRoute adminOnly={true}><AdminManageUsers /></ProtectedRoute>} />
        <Route path="/admin-settings" element={<ProtectedRoute adminOnly={true}><AdminSettings /></ProtectedRoute>} />
        <Route path="/admin-replacements" element={<ProtectedRoute adminOnly={true}><AdminReplacements /></ProtectedRoute>} />
        <Route path="/admin-handover" element={<ProtectedRoute adminOnly={true}><AdminHandover /></ProtectedRoute>} />
        <Route path="/admin-auctions" element={<ProtectedRoute adminOnly={true}><AdminAuctions /></ProtectedRoute>} />
        <Route path="/admin-reports" element={<ProtectedRoute adminOnly={true}><AdminInventory /></ProtectedRoute>} />
        <Route path="/admin-categories" element={<ProtectedRoute adminOnly={true}><AdminCategories /></ProtectedRoute>} />
        <Route path="/admin-report-control/:id" element={<ProtectedRoute adminOnly={true}><AdminReportControl /></ProtectedRoute>} />

        {/* CATCH ALL - Redirect to Welcome */}
        <Route path="*" element={<Navigate to="/" replace />} />
      </Routes>
    </Router>
  );
}

export default App;
