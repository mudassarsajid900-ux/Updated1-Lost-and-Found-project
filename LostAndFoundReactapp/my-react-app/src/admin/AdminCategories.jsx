/**
 * @file AdminCategories.jsx
 * @description Master category management module for the GAC system.
 * Allows administrators to define dynamic item archetypes with custom forensic attributes.
 * These categories are reflected in real-time across the student reporting interface.
 */
import React, { useState, useEffect } from 'react';
import { 
    Plus, Trash2, Box, Tag, Settings, Save, X, 
    Layers, ChevronRight, Hash, Type, Info, CheckCircle2, AlertCircle, Edit2
} from 'lucide-react';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';
import api from '../api/axios';

const AdminCategories = () => {
    const [categories, setCategories] = useState([]);
    const [loading, setLoading] = useState(true);
    const [showModal, setShowModal] = useState(false);
    const [submitting, setSubmitting] = useState(false);
    const [editingId, setEditingId] = useState(null);

    // New/Edit Category State
    const [categoryForm, setCategoryForm] = useState({
        name: '',
        fields: [] 
    });

    useEffect(() => {
        fetchCategories();
    }, []);

    const fetchCategories = async () => {
        setLoading(true);
        try {
            const res = await api.get('ItemType/get-all');
            setCategories(res.data.data || []);
        } catch (error) {
            console.error("Error fetching categories:", error);
        } finally {
            setLoading(false);
        }
    };

    const handleAddAttribute = () => {
        setCategoryForm({
            ...categoryForm,
            fields: [...categoryForm.fields, { fieldName: '' }]
        });
    };

    const handleRemoveAttribute = (index) => {
        const updatedFields = [...categoryForm.fields];
        updatedFields.splice(index, 1);
        setCategoryForm({ ...categoryForm, fields: updatedFields });
    };

    const handleAttributeChange = (index, value) => {
        const updatedFields = [...categoryForm.fields];
        updatedFields[index].fieldName = value;
        setCategoryForm({ ...categoryForm, fields: updatedFields });
    };

    const handleEdit = (cat) => {
        setEditingId(cat.id);
        setCategoryForm({
            name: cat.name,
            fields: cat.fields ? cat.fields.map(f => ({ fieldName: f.fieldName })) : []
        });
        setShowModal(true);
    };

    const handleSubmit = async (e) => {
        e.preventDefault();
        
        if (!categoryForm.name.trim()) {
            alert("Please enter a category name.");
            return;
        }

        const emptyFields = categoryForm.fields.some(f => !f.fieldName.trim());
        if (emptyFields) {
            alert("Please provide a name for all attributes.");
            return;
        }

        const names = categoryForm.fields.map(f => f.fieldName.trim().toLowerCase());
        if (new Set(names).size !== names.length) {
            alert("Duplicate attribute names detected. Each forensic field must be unique to ensure accurate reporting.");
            return;
        }
        
        setSubmitting(true);
        try {
            const payload = {
                name: categoryForm.name,
                fields: categoryForm.fields.map(f => ({ fieldName: f.fieldName.trim() }))
            };
            
            let response;
            if (editingId) {
                response = await api.put('ItemType/update', { ...payload, id: editingId });
            } else {
                response = await api.post('ItemType/create', payload);
            }
            
            if (response.data.isSucceeded || response.data.IsSucceeded) {
                setShowModal(false);
                resetForm();
                fetchCategories();
            } else {
                alert(response.data.message || "Operation failed.");
            }
        } catch (error) {
            console.error("Error saving category:", error);
            alert(error.response?.data?.message || "Communication failure.");
        } finally {
            setSubmitting(false);
        }
    };

    const resetForm = () => {
        setEditingId(null);
        setCategoryForm({ name: '', fields: [] });
    };

    const handleDelete = async (id) => {
        if (!window.confirm("Are you sure? This will hide the category from all future reports.")) return;
        
        try {
            const res = await api.delete(`ItemType/${id}`);
            if (res.data.isSucceeded || res.data.IsSucceeded) {
                fetchCategories();
            } else {
                alert(res.data.message || "Failed to delete.");
            }
        } catch (error) {
            alert(error.response?.data?.message || "Error deleting category.");
        }
    };

    return (
        <div className="admin-dashboard-layout" style={{ display: 'flex', minHeight: '100vh', background: '#f8fafc' }}>
            <Sidebar isAdmin={true} />
            
            <main style={{ flex: 1, padding: '2rem', marginLeft: '260px' }}>
                <Header 
                    title="Category Architect" 
                    subtitle="Define the item classifications and forensic attributes for your campus" 
                />

                <div style={{ marginTop: '2rem' }}>
                    <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center', marginBottom: '2rem' }}>
                        <div style={{ display: 'flex', gap: '1rem', alignItems: 'center' }}>
                            <div style={{ background: '#fff', padding: '12px 20px', borderRadius: '16px', border: '1px solid #e2e8f0', display: 'flex', alignItems: 'center', gap: '10px' }}>
                                <Layers size={18} color="#64748b" />
                                <span style={{ fontWeight: '800', color: '#1e293b' }}>{categories.length} Total Archetypes</span>
                            </div>
                        </div>
                        <button 
                            onClick={() => setShowModal(true)}
                            style={{ background: '#3182ce', color: 'white', padding: '12px 24px', borderRadius: '14px', border: 'none', fontWeight: '900', display: 'flex', alignItems: 'center', gap: '10px', cursor: 'pointer', boxShadow: '0 4px 12px rgba(49, 130, 206, 0.3)' }}
                        >
                            <Plus size={20} /> Create New Category
                        </button>
                    </div>

                    {loading ? (
                        <div style={{ padding: '4rem', textAlign: 'center' }}>
                            <div className="animate-spin" style={{ display: 'inline-block' }}><Settings size={32} color="#94a3b8" /></div>
                        </div>
                    ) : (
                        <div style={{ display: 'grid', gridTemplateColumns: 'repeat(auto-fill, minmax(320px, 1fr))', gap: '1.5rem' }}>
                            {categories.map((cat) => (
                                <div key={cat.id} style={{ background: '#fff', borderRadius: '24px', border: '1px solid #e2e8f0', overflow: 'hidden', transition: 'all 0.3s ease' }}>
                                    <div style={{ padding: '1.5rem', borderBottom: '1px solid #f1f5f9', display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
                                        <div style={{ display: 'flex', alignItems: 'center', gap: '12px' }}>
                                            <div style={{ background: '#eff6ff', padding: '10px', borderRadius: '12px' }}>
                                                <Box size={20} color="#3b82f6" />
                                            </div>
                                            <h3 style={{ margin: 0, fontWeight: '900', color: '#1e293b', fontSize: '1.1rem' }}>{cat.name}</h3>
                                        </div>
                                        <div style={{ display: 'flex', gap: '8px' }}>
                                            <button 
                                                onClick={() => handleEdit(cat)}
                                                style={{ color: '#3b82f6', background: '#eff6ff', border: 'none', padding: '8px', borderRadius: '10px', cursor: 'pointer' }}
                                                title="Edit Category"
                                            >
                                                <Edit2 size={16} />
                                            </button>
                                            <button 
                                                onClick={() => handleDelete(cat.id)}
                                                style={{ color: '#ef4444', background: '#fef2f2', border: 'none', padding: '8px', borderRadius: '10px', cursor: 'pointer' }}
                                                title="Delete Category"
                                            >
                                                <Trash2 size={16} />
                                            </button>
                                        </div>
                                    </div>
                                    <div style={{ padding: '1.5rem' }}>
                                        <div style={{ fontSize: '0.7rem', color: '#94a3b8', fontWeight: '900', textTransform: 'uppercase', letterSpacing: '1px', marginBottom: '12px' }}>Forensic Attributes</div>
                                        <div style={{ display: 'flex', flexWrap: 'wrap', gap: '8px' }}>
                                            {cat.fields && cat.fields.length > 0 ? cat.fields.map((f, i) => (
                                                <div key={i} style={{ background: '#f8fafc', border: '1px solid #edf2f7', padding: '6px 14px', borderRadius: '10px', fontSize: '0.8rem', color: '#475569', fontWeight: '800', display: 'flex', alignItems: 'center', gap: '6px' }}>
                                                    <Tag size={12} color="#94a3b8" /> {f.fieldName}
                                                </div>
                                            )) : (
                                                <span style={{ fontSize: '0.8rem', color: '#cbd5e0', fontStyle: 'italic' }}>No custom attributes defined</span>
                                            )}
                                        </div>
                                    </div>
                                </div>
                            ))}
                        </div>
                    )}
                </div>

                {/* CREATION MODAL */}
                {showModal && (
                    <div style={{ position: 'fixed', top: 0, left: 0, width: '100%', height: '100%', backgroundColor: 'rgba(15, 23, 42, 0.7)', backdropFilter: 'blur(8px)', display: 'flex', alignItems: 'center', justifyContent: 'center', zIndex: 1100, padding: '20px' }}>
                        <div style={{ background: '#fff', width: '100%', maxWidth: '500px', borderRadius: '28px', overflow: 'hidden', boxShadow: '0 25px 50px -12px rgba(0, 0, 0, 0.5)', animation: 'fadeIn 0.3s ease-out' }}>
                            <div style={{ background: 'linear-gradient(135deg, #1e293b 0%, #0f172a 100%)', padding: '1.5rem 2rem', color: 'white', display: 'flex', justifyContent: 'space-between', alignItems: 'center' }}>
                                <h3 style={{ margin: 0, fontWeight: '900', fontSize: '1.25rem' }}>Category Architect</h3>
                                <button onClick={() => setShowModal(false)} style={{ background: 'rgba(255,255,255,0.1)', border: 'none', color: 'white', padding: '8px', borderRadius: '12px', cursor: 'pointer' }}><X size={20}/></button>
                            </div>

                            <form onSubmit={handleSubmit} style={{ padding: '2rem' }}>
                                <div style={{ marginBottom: '1.5rem' }}>
                                    <label style={{ display: 'block', fontSize: '0.8rem', fontWeight: '800', color: '#64748b', textTransform: 'uppercase', marginBottom: '8px' }}>Category Name</label>
                                    <div style={{ position: 'relative' }}>
                                        <Box size={18} color="#94a3b8" style={{ position: 'absolute', left: '16px', top: '16px' }} />
                                        <input 
                                            required
                                            value={categoryForm.name}
                                            onChange={(e) => setCategoryForm({...categoryForm, name: e.target.value})}
                                            placeholder="e.g. Wireless Charger, Lab Equipment..." 
                                            style={{ width: '100%', padding: '14px 14px 14px 48px', borderRadius: '14px', border: '2px solid #e2e8f0', fontSize: '1rem', fontWeight: '700', outline: 'none' }}
                                        />
                                    </div>
                                </div>

                                <div style={{ marginBottom: '2rem' }}>
                                    <div style={{ display: 'flex', justifyContent: 'space-between', alignItems: 'center', marginBottom: '12px' }}>
                                        <label style={{ fontSize: '0.8rem', fontWeight: '800', color: '#64748b', textTransform: 'uppercase' }}>Forensic Attributes</label>
                                        <button 
                                            type="button"
                                            onClick={handleAddAttribute}
                                            style={{ padding: '4px 12px', background: '#f0f9ff', color: '#0369a1', border: '1px solid #bae6fd', borderRadius: '8px', fontSize: '0.75rem', fontWeight: '900', cursor: 'pointer' }}
                                        >
                                            + Add Attribute
                                        </button>
                                    </div>

                                    <div style={{ maxHeight: '200px', overflowY: 'auto', paddingRight: '10px' }}>
                                        {categoryForm.fields.map((field, idx) => (
                                            <div key={idx} style={{ display: 'flex', gap: '10px', marginBottom: '10px', animation: 'fadeInRight 0.2s ease-out' }}>
                                                <div style={{ flex: 1, position: 'relative' }}>
                                                    <Tag size={16} color="#94a3b8" style={{ position: 'absolute', left: '12px', top: '12px' }} />
                                                    <input 
                                                        required
                                                        placeholder="Attribute Name (e.g. Brand, Color)"
                                                        value={field.fieldName}
                                                        onChange={(e) => handleAttributeChange(idx, e.target.value)}
                                                        style={{ width: '100%', padding: '10px 10px 10px 40px', borderRadius: '12px', border: '1px solid #e2e8f0', fontSize: '0.9rem', fontWeight: '700' }}
                                                    />
                                                </div>
                                                <button 
                                                    type="button"
                                                    onClick={() => handleRemoveAttribute(idx)}
                                                    style={{ color: '#ef4444', background: '#fef2f2', border: 'none', padding: '10px', borderRadius: '12px', cursor: 'pointer' }}
                                                >
                                                    <Trash2 size={16} />
                                                </button>
                                            </div>
                                        ))}

                                        {categoryForm.fields.length === 0 && (
                                            <div style={{ padding: '20px', textAlign: 'center', background: '#f8fafc', borderRadius: '16px', border: '1px dashed #e2e8f0' }}>
                                                <p style={{ margin: 0, fontSize: '0.8rem', color: '#94a3b8', fontStyle: 'italic' }}>No custom attributes. Every report will only have a general description.</p>
                                            </div>
                                        )}
                                    </div>
                                </div>

                                <button 
                                    disabled={submitting}
                                    style={{ width: '100%', background: 'linear-gradient(135deg, #3182ce 0%, #2b6cb0 100%)', color: 'white', padding: '16px', borderRadius: '16px', border: 'none', fontWeight: '900', fontSize: '1rem', display: 'flex', alignItems: 'center', justifyContent: 'center', gap: '10px', cursor: 'pointer', boxShadow: '0 10px 20px -5px rgba(49, 130, 206, 0.4)' }}
                                >
                                    {submitting ? 'Constructing Archetype...' : 'Finalize & Deploy Category'}
                                </button>
                            </form>
                        </div>
                    </div>
                )}
            </main>

            <style>{`
                @keyframes fadeIn { from { opacity: 0; transform: scale(0.95); } to { opacity: 1; transform: scale(1); } }
                @keyframes fadeInRight { from { opacity: 0; transform: translateX(20px); } to { opacity: 1; transform: translateX(0); } }
                .animate-spin { animation: spin 2s linear infinite; }
                @keyframes spin { from { transform: rotate(0deg); } to { transform: rotate(360deg); } }
            `}</style>
        </div>
    );
};

export default AdminCategories;
