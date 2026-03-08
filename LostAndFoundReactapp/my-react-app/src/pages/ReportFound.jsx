import React, { useState, useEffect } from 'react';
import { Camera, Search, Gavel, Home, Folder, PlusCircle, Settings, User, LogOut, ChevronLeft, Calendar, MapPin, UploadCloud, Sliders, Clock } from 'lucide-react';
import { useNavigate } from 'react-router-dom';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';
import api from '../api/axios';

// ========================================== //
// SECTION 2: MAIN 'REPORT FOUND ITEM' COMPONENT
// This page allows a user to submit a found item report so the owner can claim it.
// Logic:
// 1. Fetches item types, locations, and mobile data from API on mount.
// 2. Uses a dynamic configuration object (itemConfigurations) to render 
//    specific questions based on the category (e.g., Phone vs Laptop).
// 3. Allows for photo uploading which is crucial for verifying found items.
// 4. Formats data into FormData for C# multipart/form-data compatibility.
// ========================================== //
const ReportFound = () => {
    // Allows us to redirect the user back to the dashboard when they click Back
    const navigate = useNavigate();

    const [mobileCompanies, setMobileCompanies] = useState([]);
    const [mobileModels, setMobileModels] = useState([]);
    const [loadingModels, setLoadingModels] = useState(false);

    // New dynamic states with fallbacks
    const [itemTypes, setItemTypes] = useState([
        { id: 1, name: "Mobile Phone" },
        { id: 2, name: "Wallet" },
        { id: 3, name: "Laptop" },
        { id: 4, name: "Keys" },
        { id: 5, name: "Bag / Backpack" },
        { id: 6, name: "Watch" },
        { id: 7, name: "Passport / ID Card" },
        { id: 8, name: "Jewelry" },
        { id: 9, name: "Earphones / Headphones" },
        { id: 10, name: "Other" }
    ]);
    const [universityLocations, setUniversityLocations] = useState([
        { id: 1, name: "LT1" }, { id: 2, name: "LT2" }, { id: 3, name: "LT3" },
        { id: 14, name: "LAB-1" }, { id: 15, name: "LAB-2" }, { id: 26, name: "Parking" }
    ]);
    const [isSubmitting, setIsSubmitting] = useState(false);
    const [submitStatus, setSubmitStatus] = useState({ type: '', message: '' });
    const [photo, setPhoto] = useState(null);
    const [photoPreview, setPhotoPreview] = useState(null);

    // Fetch Initial Data
    useEffect(() => {
        const fetchData = async () => {
            try {
                // Removed leading slashes so they append correctly to the baseURL (/api)
                const [companiesRes, typesRes, locationsRes] = await Promise.all([
                    api.get('MobileModel/companies'),
                    api.get('ItemType/get-all'),
                    api.get('Location/get-all')
                ]);

                const processRes = (res) => {
                    if (res.data?.isSucceeded || res.data?.IsSucceeded) return res.data.data;
                    if (Array.isArray(res.data)) return res.data;
                    return null;
                };

                const companiesData = processRes(companiesRes);
                const typesData = processRes(typesRes);
                const locationsData = processRes(locationsRes);

                if (companiesData) setMobileCompanies(companiesData);
                if (typesData) setItemTypes(typesData);
                if (locationsData) {
                    setUniversityLocations(locationsData);
                    console.log(`Loaded ${locationsData.length} locations from API.`);
                }

            } catch (err) {
                console.error("Failed to fetch initial data. Falling back to default list.", err);
            }
        };
        fetchData();
    }, []);

    // ========================================== //
    // SECTION 3: DYNAMIC FORM CONFIGURATIONS
    // This giant object controls exactly which inputs show up when you pick a category.
    // If you report finding a Phone, it asks about screen lock. If you found a Bottle, it asks about stickers.
    // ========================================== //
    const itemConfigurations = {
        "Mobile Phone": {
            brand: { type: "dropdown", options: mobileCompanies.map(c => c.name) },
            modelName: {
                type: "dropdown",
                options: mobileModels.map(m => m.name),
                placeholder: loadingModels ? "Loading models..." : "Select model"
            },
            ramRom: {
                type: "row",
                fields: {
                    ram: { type: "text", label: "RAM", placeholder: "RAM" },
                    rom: { type: "text", label: "ROM", placeholder: "ROM" }
                }
            },
            colorOptions: { type: "radio", options: ["Black", "Blue", "Red", "Gold", "White", "Other"] },
            approximateSize: { type: "radio", options: ["Small (Mini)", "Medium (Standard)", "Large (Pro Max/Plus)"] },
            isLocked: { type: "radio", options: ["Yes (Locked)", "No (Unlocked)", "Unknown"] },
            simCardPresent: { type: "radio", options: ["Yes", "No", "Unknown"] },
            condition: { type: "dropdown", options: ["Good Condition", "Cracked Screen", "Scratched Body", "Heavy Wear"] },
            imeiVisible: { type: "radio", options: ["Yes (on back/tray)", "No", "Unknown"] }
        },

        "Laptop": {
            brand: { type: "dropdown", options: ["Apple", "Dell", "HP", "Lenovo", "Asus", "Other"] },
            screenSize: { type: "radio", options: ["13 inch", "14 inch", "15-16 inch", "Unknown"] },
            ramRom: {
                type: "row",
                fields: {
                    ram: { type: "text", label: "RAM", placeholder: "RAM" },
                    rom: { type: "text", label: "ROM", placeholder: "ROM" }
                }
            },
            colorOptions: { type: "radio", options: ["Black", "Blue", "Red", "Gold", "White", "Other"] },
            passwordLocked: { type: "radio", options: ["Yes", "No", "Unknown"] },
            stickersOrMarks: { type: "text", placeholder: "e.g. Apple sticker, Blue ink mark on corner" },
            chargerFound: { type: "radio", options: ["With Charger", "No Charger"] },
            serialNumberVisible: { type: "radio", options: ["Yes", "No"] }
        },

        "Wallet": {
            colorOptions: { type: "radio", options: ["Black", "Blue", "Red", "Gold", "White", "Other"] },
            material: { type: "radio", options: ["Leather", "Fabric", "Synthetic"] },
            idCardInside: { type: "radio", options: ["Yes", "No"] },
            cashInside: { type: "radio", options: ["Yes", "No"] },
            numberOfCards: { type: "dropdown", options: ["None", "1-3 Cards", "4-7 Cards", "8+ Cards"] }
        },

        "Bottle": {
            brandName: { type: "text", placeholder: "e.g. Hydro Flask, Stanley" },
            colorOptions: { type: "radio", options: ["Black", "Blue", "Red", "Gold", "White", "Other"] },
            estimatedSize: { type: "radio", options: ["Small (100-200ml)", "Medium (200-500ml)", "Large (500ml-1L)", "Other"] },
            stickersOrName: { type: "text", placeholder: "e.g. Name sticker 'Sarah', Doraemon sticker" }
        },

        "Bag / Backpack": {
            brand: { type: "dropdown", options: ["Nike", "Adidas", "Puma", "Jansport", "Samsonite", "Other"] },
            material: { type: "radio", options: ["Leather", "Canvas", "Nylon", "Synthetic"] },
            colorOptions: { type: "radio", options: ["Black", "Blue", "Red", "Gold", "White", "Other"] },
            size: { type: "radio", options: ["Small (Pouch/Crossbody)", "Medium (Backpack)", "Large (Duffel/Luggage)"] },
            visibleItemsInside: { type: "text", placeholder: "e.g. Blue notebook, Umbrella" }
        },

        "Keys": {
            numberOfKeys: { type: "dropdown", options: ["1", "2", "3", "4+"] },
            keyType: { type: "radio", options: ["Home Keys", "Car Key", "Bike Key", "Office Keys"] },
            hasKeychain: { type: "radio", options: ["Yes", "No"] },
            keychainDescription: { type: "text", placeholder: "e.g. Red ribbon, Spiderman keychain" }
        },

        "Watch": {
            brand: { type: "dropdown", options: ["Rolex", "Casio", "Seiko", "Apple", "Samsung", "Other"] },
            type: { type: "radio", options: ["Analog", "Digital", "Smartwatch"] },
            strapMaterial: { type: "radio", options: ["Leather", "Metal", "Silicon", "Fabric"] },
            colorOptions: { type: "radio", options: ["Black", "Blue", "Red", "Gold", "White", "Other"] }
        },

        "Jewelry": {
            type: { type: "dropdown", options: ["Ring", "Necklace", "Bracelet", "Earrings", "Other"] },
            material: { type: "radio", options: ["Gold", "Silver", "Platinum", "Artificial"] },
            colorOptions: { type: "radio", options: ["Gold", "Silver", "Rose Gold", "Other"] }
        },

        "Earphones / Headphones": {
            brand: { type: "dropdown", options: ["Apple Airpods", "Samsung Buds", "Sony", "JBL", "Other"] },
            type: { type: "radio", options: ["In-ear", "Over-ear", "Wireless", "Wired"] },
            colorOptions: { type: "radio", options: ["Black", "White", "Blue", "Other"] }
        },

        "Other": {
            visibleDescription: { type: "textarea", placeholder: "Please describe only visible marks, colors, or unique features..." }
        }
    };

    // Get the list of main categories (Phone, Laptop, etc) from the object above
    const categories = Object.keys(itemConfigurations);


    // ========================================== //
    // SECTION 4: FORM STATE VARIABLES
    // These variables store the answers the user types into the form.
    // ========================================== //

    // Which big dropdown category is selected (e.g. "Phone")
    const [selectedCategory, setSelectedCategory] = useState("");

    // The rest of the form answers
    const [formData, setFormData] = useState({
        itemType: "",
        attributes: {},
        dateFound: "",
        venue: "",
        description: "" // Found form usually doesn't have a separate description in sidebar, but we keep it
    });


    // ========================================== //
    // SECTION 5: INPUT HANDLERS
    // These functions run when a user types or clicks on the form to save their answers.
    // ========================================== //

    // Fetch Models when Brand changes
    useEffect(() => {
        const fetchModels = async () => {
            const brand = formData.attributes.brand;
            if (selectedCategory === "Mobile Phone" && brand) {
                const company = mobileCompanies.find(c => c.name === brand);
                if (company) {
                    setLoadingModels(true);
                    try {
                        const res = await api.get(`MobileModel/companies/${company.id}/models`);
                        if (res.data.isSucceeded || res.data.IsSucceeded) {
                            setMobileModels(res.data.data);
                        }
                    } catch (err) {
                        console.error("Failed to fetch models", err);
                    } finally {
                        setLoadingModels(false);
                    }
                }
            } else {
                setMobileModels([]);
            }
        };
        fetchModels();
    }, [formData.attributes.brand, selectedCategory, mobileCompanies]);

    // Typing in plain text or date fields
    const handlePhotoChange = (e) => {
        const file = e.target.files[0];
        if (file) {
            setPhoto(file);
            setPhotoPreview(URL.createObjectURL(file));
        }
    };

    const handleInputChange = (e) => {
        const { name, value } = e.target;
        setFormData(prev => ({ ...prev, [name]: value }));
    };

    // Changing the main Category dropdown resets the form
    const handleCategoryChange = (e) => {
        const category = e.target.value;
        setSelectedCategory(category);

        setFormData({
            itemType: category,
            attributes: {},
            dateFound: "",
            venue: "",
            description: ""
        });
    };

    // Answering one of the specific dynamically generated questions
    const handleAttributeChange = (name, value, type) => {
        setFormData(prev => {
            const updated = { ...prev.attributes };

            if (type === "checkbox") {
                const current = updated[name] || [];
                updated[name] = current.includes(value)
                    ? current.filter(v => v !== value)
                    : [...current, value];
            } else {
                updated[name] = value;
                // If brand changes, clear the modelName
                if (name === "brand" && selectedCategory === "Mobile Phone") {
                    delete updated["modelName"];
                }
            }

            return { ...prev, attributes: updated };
        });
    };

    // Form Submission Logic
    const handleSubmit = async (e) => {
        e.preventDefault();

        // basic validation
        if (!selectedCategory || !formData.venue || !formData.dateFound) {
            setSubmitStatus({ type: 'error', message: 'Please fill in all required fields (Item Type, Location, Date)' });
            window.scrollTo({ top: 0, behavior: 'smooth' });
            return;
        }

        setIsSubmitting(true);
        setSubmitStatus({ type: '', message: '' });

        try {
            // STEP 1: Identification
            // Retrieve actual database IDs for the selected Type and Location
            const typeEntity = itemTypes.find(t => t.name === selectedCategory);
            const locationEntity = universityLocations.find(l => l.name === formData.venue);

            // STEP 2: Data Packaging (Multipart FormData)
            // We use FormData to support the photo upload and complex list binding
            const data = new FormData();

            // Format found date with a default noon time for C# compatibility
            data.append('eventTime', `${formData.dateFound}T12:00:00`);
            data.append('locationId', locationEntity?.id || 0);
            data.append('itemTypeId', typeEntity?.id || 0);
            data.append('status', 1);      // Enum: 1 = Found
            data.append('reportType', 1);  // Enum: 1 = Found Report

            // STEP 3: Map Dynamic Attributes
            // .NET list binding expects Attributes[index].Property naming convention
            Object.entries(formData.attributes).forEach(([key, val], index) => {
                data.append(`Attributes[${index}].FieldName`, key);
                data.append(`Attributes[${index}].FieldValue`, String(val));
            });

            // STEP 4: Secondary Description
            // Adding description as a final attribute in the list
            const descIndex = Object.keys(formData.attributes).length;
            if (formData.description) {
                data.append(`Attributes[${descIndex}].FieldName`, 'Found Description');
                data.append(`Attributes[${descIndex}].FieldValue`, formData.description);
            }

            // STEP 5: Add Photo
            // If the user selected an image, append it to the file list
            if (photo) {
                data.append('photo', photo);
            }

            // STEP 6: API Request
            console.log("Submitting Found Report...");
            if (photo) {
                data.append('photo', photo);
            }

            console.log("Sending FormData...");
            const response = await api.post('Item/create', data, {
                headers: { 'Content-Type': 'multipart/form-data' }
            });
            console.log("Server Response:", response.data);

            if (response.data.isSucceeded || response.data.IsSucceeded) {
                setSubmitStatus({ type: 'success', message: response.data.message || 'Found report published successfully!' });
                setTimeout(() => navigate('/dashboard'), 2000);
            } else {
                setSubmitStatus({ type: 'error', message: response.data.message || 'Failed to publish report' });
            }

        } catch (err) {
            console.error("Submission Error:", err);
            const errMsg = err.response?.data?.message || err.message || 'An unexpected error occurred. Please try again.';
            setSubmitStatus({ type: 'error', message: errMsg });
            window.scrollTo({ top: 0, behavior: 'smooth' }); // Scroll up to see the error
        } finally {
            setIsSubmitting(false);
        }
    };


    // ========================================== //
    // SECTION 6: DYNAMIC HTML GENERATOR
    // Converts the rules we wrote in SECTION 3 into actual HTML Dropdowns, TextBoxes, Radio Buttons etc.
    // ========================================== //
    const renderAttribute = (name, config) => {
        const value = formData.attributes[name];

        if (config.type === "dropdown") {
            return (
                <select className="custom-select"
                    value={value || ""}
                    onChange={(e) => handleAttributeChange(name, e.target.value, "dropdown")}
                >
                    <option value="" disabled>{config.placeholder || `Select ${name}`}</option>
                    {config.options.map(opt => (
                        <option key={opt} value={opt}>{opt}</option>
                    ))}
                </select>
            );
        }

        if (config.type === "text") {
            return (
                <input
                    type="text"
                    className="custom-input"
                    placeholder={config.placeholder}
                    value={value || ""}
                    onChange={(e) => handleAttributeChange(name, e.target.value, "text")}
                />
            );
        }

        if (config.type === "textarea") {
            return (
                <textarea
                    className="custom-input"
                    rows="4"
                    placeholder={config.placeholder}
                    value={value || ""}
                    onChange={(e) => handleAttributeChange(name, e.target.value, "textarea")}
                    style={{ resize: 'none' }}
                />
            );
        }

        if (config.type === "radio") {
            return (
                <div className="radio-group">
                    {config.options.map(opt => (
                        <label key={opt} className="custom-radio-label">
                            <input
                                type="radio"
                                checked={value === opt}
                                onChange={() => handleAttributeChange(name, opt, "radio")}
                            />
                            <span className="radio-text">{opt}</span>
                        </label>
                    ))}
                </div>
            );
        }

        if (config.type === "checkbox") {
            return (
                <div className="checkbox-grid">
                    {config.options.map(opt => (
                        <label key={opt} className="custom-checkbox-label">
                            <input
                                type="checkbox"
                                checked={(value || []).includes(opt)}
                                onChange={() => handleAttributeChange(name, opt, "checkbox")}
                            />
                            <span className="checkbox-text">{opt}</span>
                        </label>
                    ))}
                </div>
            );
        }

        if (config.type === "color") {
            return (
                <div className="color-picker-container">
                    <input
                        type="color"
                        value={value || "#000000"}
                        onChange={(e) => handleAttributeChange(name, e.target.value, "color")}
                        className="custom-color-input"
                    />
                    <span className="color-value-label">{value || "#000000"}</span>
                </div>
            );
        }

        if (config.type === "range") {
            return (
                <div className="range-slider-container">
                    <input
                        type="range"
                        min={config.min}
                        max={config.max}
                        step={config.step}
                        value={value || config.min}
                        onChange={(e) => handleAttributeChange(name, e.target.value, "range")}
                    />
                    <div className="range-labels">
                        {config.labels.map(label => <span key={label}>{label}</span>)}
                    </div>
                    <p className="mt-2 text-sm font-semibold text-teal-600">Selected: {value || config.min} ml</p>
                </div>
            );
        }
    };

    // Loops through all rules in the chosen category and draws them
    const renderDynamicAttributes = () => {
        const config = itemConfigurations[selectedCategory];

        if (!config) {
            // Default fields for types not explicitly configured
            return (
                <div className="input-card mt-3">
                    <label className="field-label">VISIBLE DESCRIPTION</label>
                    <textarea
                        className="custom-input"
                        rows="4"
                        placeholder="Please describe unique markings, colors, or features..."
                        value={formData.attributes.visibleDescription || ""}
                        onChange={(e) => handleAttributeChange("visibleDescription", e.target.value, "textarea")}
                        style={{ resize: 'none' }}
                    />
                </div>
            );
        }

        return Object.entries(config).map(([name, attrConfig]) => {
            // --- SPECIAL CASE: 'row' type renders multiple fields side by side ---
            if (attrConfig.type === "row") {
                return (
                    <div key={name} style={{ display: 'flex', gap: '1rem', marginTop: '1rem' }}>
                        {Object.entries(attrConfig.fields).map(([fieldName, fieldConfig]) => (
                            <div key={fieldName} className="input-card" style={{ flex: 1, marginTop: 0 }}>
                                <label className="field-label">{fieldConfig.label || fieldName.toUpperCase()}</label>
                                {renderAttribute(fieldName, fieldConfig)}
                            </div>
                        ))}
                    </div>
                );
            }

            // --- DEFAULT CASE: render a single full-width input card ---
            return (
                <div key={name} className="input-card mt-3">
                    <label className="field-label">{name.toUpperCase()}</label>
                    {renderAttribute(name, attrConfig)}
                </div>
            );
        });
    };

    // ========================================== //
    // SECTION 7: PAGE LAYOUT AND HTML RENDER
    // ========================================== //
    return (
        <div className="dashboard-container">

            {/* Show left Sidebar menu */}
            <Sidebar />

            {/* Main content Area */}
            <main className="main-content">

                {/* 7A. Page Header showing Title */}
                <Header
                    title="Report Found Item"
                    subtitle="Fill in the details to help find the owner."
                    showBack={true}
                    onBack={() => navigate('/dashboard')}
                />

                <div className="content-wrapper">
                    {submitStatus.message && (
                        <div className={`notification-banner ${submitStatus.type}`}>
                            {submitStatus.message}
                        </div>
                    )}

                    <form className="report-form-grid" onSubmit={handleSubmit}>

                        {/* ------------------------------------------- */}
                        {/* 7B. LEFT COLUMN (Item Specification Area) */}
                        {/* ------------------------------------------- */}
                        <div className="form-column">
                            <h3 className="column-title">Item Specification</h3>

                            {/* Main Category Dropdown ('What did you find?') */}
                            <div className="form-section">
                                <label className="section-label">Item Type</label>
                                <div className="input-card">
                                    <label className="field-label">What did you find?</label>
                                    <select
                                        className="custom-select"
                                        value={selectedCategory}
                                        onChange={handleCategoryChange}
                                        style={{ width: '100%' }}
                                    >
                                        <option value="" disabled>Select item type...</option>
                                        {itemTypes.map(cat => (
                                            <option key={cat.id} value={cat.name}>{cat.name}</option>
                                        ))}
                                    </select>
                                </div>
                            </div>

                            {/* Insert the magically generated dynamic form HTML here */}
                            {renderDynamicAttributes()}

                            {/* Show a friendly message if the user hasn't selected a category yet */}
                            {selectedCategory === "" && (
                                <div className="empty-state-card" style={{ marginTop: '1rem' }}>
                                    <p style={{ color: '#718096', fontStyle: 'italic' }}>Select an item type to show specific attributes.</p>
                                </div>
                            )}
                        </div>

                        {/* ------------------------------------------- */}
                        {/* 7C. RIGHT COLUMN (Logistics & Proof Area) */}
                        {/* Includes Date, Location, and Image Upload */}
                        {/* ------------------------------------------- */}
                        <div className="form-column">
                            <h3 className="column-title">Logistics & Proof</h3>

                            {/* When was it found? */}
                            <div className="form-section">
                                <label className="section-label">Date Found</label>
                                <div className="input-card flex-row">
                                    <input
                                        type="date"
                                        name="dateFound"
                                        className="custom-input"
                                        onChange={handleInputChange}
                                    />
                                    <Calendar size={20} color="#718096" />
                                </div>
                            </div>

                            {/* Where was it found? */}
                            <div className="form-section">
                                <label className="section-label">Location</label>
                                <div className="input-card">
                                    <label className="field-label">Where exactly did you find it?</label>
                                    <div className="flex-row" style={{ display: 'flex', alignItems: 'center' }}>
                                        <select
                                            name="venue"
                                            className="custom-input"
                                            value={formData.venue}
                                            onChange={handleInputChange}
                                            style={{ flex: 1, backgroundColor: 'transparent', border: 'none', outline: 'none', appearance: 'none' }}
                                        >
                                            <option value="" disabled>Select Location...</option>
                                            {universityLocations.map(loc => (
                                                <option key={loc.id} value={loc.name}>{loc.name}</option>
                                            ))}
                                        </select>
                                        <MapPin size={20} color="#718096" />
                                    </div>
                                </div>
                            </div>

                            {/* Photos / Proof Area */}
                            <div className="form-section">
                                <label className="section-label">Upload Photo</label>
                                <div
                                    className="upload-card"
                                    onClick={() => document.getElementById('photo-input').click()}
                                    style={{ cursor: 'pointer', overflow: 'hidden' }}
                                >
                                    {photoPreview ? (
                                        <img src={photoPreview} alt="Preview" style={{ width: '100%', height: '100%', objectFit: 'cover' }} />
                                    ) : (
                                        <>
                                            <UploadCloud size={48} color="#cbd5e0" />
                                            <p className="upload-text">Drag & Drop or Click to Upload</p>
                                            <p className="upload-sub">Supports: JPG, PNG</p>
                                        </>
                                    )}
                                    <input
                                        type="file"
                                        id="photo-input"
                                        accept="image/*"
                                        onChange={handlePhotoChange}
                                        style={{ display: 'none' }}
                                    />
                                </div>
                            </div>
                        </div>

                        {/* ------------------------------------------- */}
                        {/* FULL-WIDTH BOTTOM SUBMIT BUTTON */}
                        {/* ------------------------------------------- */}
                        <div className="form-footer-action">
                            <button
                                type="submit"
                                className={`submit-action-btn ${isSubmitting ? 'loading' : ''}`}
                                disabled={isSubmitting}
                            >
                                {isSubmitting ? 'Publishing...' : 'Publish Found Item Report'}
                            </button>
                        </div>

                    </form>
                </div>
            </main>
        </div>
    );
};

export default ReportFound;
