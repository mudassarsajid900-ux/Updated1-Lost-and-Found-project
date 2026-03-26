import React from 'react';
import { BrowserRouter as Router, Routes, Route, Navigate } from 'react-router-dom';
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
import AdminReportControl from './admin/AdminReportControl';
import ReportDetails from './pages/ReportDetails';


function App() {
  return (
    <Router>
      <Routes>
        <Route path="/" element={<Welcome />} />
        <Route path="/login" element={<AuthPage />} />
        <Route path="/dashboard" element={<Dashboard />} />
        <Route path="/admin-dashboard" element={<AdminDashboard />} />
        <Route path="/admin-users" element={<AdminManageUsers />} />
        <Route path="/admin-settings" element={<AdminSettings />} />
        <Route path="/admin-replacements" element={<AdminReplacements />} />
        <Route path="/admin-handover" element={<AdminHandover />} />
        <Route path="/admin-auctions" element={<AdminAuctions />} />
        <Route path="/admin-reports" element={<AdminInventory />} />
        <Route path="/admin-report-control/:id" element={<AdminReportControl />} />
        <Route path="/report-found" element={<ReportFound />} />
        <Route path="/report-lost" element={<ReportLost />} />
        <Route path="/my-items" element={<MyItems />} />

        <Route path="/auction" element={<Auction />} />
        <Route path="/settings" element={<Settings />} />
        <Route path="/item-replacement" element={<ItemReplacement />} />
        <Route path="/match-details" element={<MatchDetails />} />
        <Route path="/match-details/:lostItemId/:foundItemId" element={<MatchDetails />} />
        <Route path="/claim-item" element={<ClaimItem />} />
        <Route path="/claim-item/:lostItemId/:foundItemId" element={<ClaimItem />} />
        <Route path="/claim-status" element={<ClaimStatus />} />
        <Route path="/review-claim" element={<ReviewClaim />} />
        <Route path="/report-details/:id" element={<ReportDetails />} />

      </Routes>
    </Router>
  );
}

export default App;
