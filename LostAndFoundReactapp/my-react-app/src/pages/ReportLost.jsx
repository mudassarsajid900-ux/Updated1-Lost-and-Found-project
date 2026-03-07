import React, { useState, useEffect } from 'react';
import { User, Home, Folder, PlusCircle, Settings, LogOut, ChevronLeft, Calendar, MapPin, Clock, Camera, Search, Gavel, UploadCloud } from 'lucide-react';
import { useNavigate, useLocation } from 'react-router-dom';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';
import api from '../api/axios';

// ========================================== //
// SECTION 2: MAIN 'REPORT LOST ITEM' COMPONENT
// This page allows a user to submit a lost item report.
// Logic:
// 1. Fetches item types, locations, and mobile data from API on mount.
// 2. Uses a dynamic configuration object (itemConfigurations) to render 
//    specific questions based on the category (e.g., Phone vs Laptop).
// 3. Formats date/time for C# DateTime compatibility before submission.
// 4. Uses FormData to allow image/file uploads and complex nested list binding.
// ========================================== //
const ReportLost = () => {
    // Allows us to redirect the user
    const navigate = useNavigate();

    // Allows us to see if we came here from the 'Edit' button on MyItems page
    const location = useLocation();
    const editData = location.state?.itemData; // If we are editing, this holds the old data

    const [mobileCompanies, setMobileCompanies] = useState([]);
    const [mobileModels, setMobileModels] = useState([]);
    const [loadingModels, setLoadingModels] = useState(false);

    // State for Dynamic Dropdowns (Fetched from Database)
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
    // E.g., If you pick 'Phone', it asks for Brand, IMEI. If you pick 'Wallet', it asks for Cards.
    // ========================================== //
    const itemConfigurations = {
        "Mobile Phone": {
            brand: { type: "dropdown", options: mobileCompanies.map(c => c.name) },
            modelName: {
                type: "dropdown",
                options: mobileModels.map(m => m.name),
                placeholder: loadingModels ? "Loading models..." : "Select model"
            },
            // RAM and ROM shown side-by-side as text inputs (reference image style)
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
            imei_Visible: { type: "radio", options: ["Yes (on back/tray)", "No", "Unknown"] }
        },

        "Laptop": {
            brand: { type: "dropdown", options: ["Apple", "Dell", "HP", "Lenovo", "Asus", "Other"] },
            screenSize: { type: "radio", options: ["13 inch", "14 inch", "15-16 inch", "Unknown"] },
            // RAM and ROM shown side-by-side as text inputs (reference image style)
            ramRom: {
                type: "row",
                fields: {
                    ram: { type: "text", label: "RAM", placeholder: "RAM" },
                    rom: { type: "text", label: "ROM", placeholder: "ROM" }
                }
            },
            colorOptions: { type: "radio", options: ["Black", "Blue", "Red", "Gold", "White", "Other"] },
            passwordLocked: { type: "radio", options: ["Yes", "No", "Unknown"] },
            sticker_OR_AnyMark: { type: "text", placeholder: "e.g. Apple sticker, Blue ink mark on corner" },
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
            estimatedSize: { type: "radio", options: ["Small (250-500ml)", "Medium (750ml-1L)", "Large (1.5L+)"] },
            stickersOrName: { type: "text", placeholder: "e.g. Name sticker 'Sarah', Doraemon sticker" }
        },

        "Bag / Backpack": {
            brand: { type: "dropdown", options: ["Nike", "Adidas", "Puma", "Jansport", "Samsonite", "Other"] },
            material: { type: "radio", options: ["Leather", "Canvas", "Nylon", "Synthetic"] },
            colorOptions: { type: "radio", options: ["Black", "Blue", "Red", "Gold", "White", "Other"] },
            size: { type: "radio", options: ["Small (Pouch/Crossbody)", "Medium (Backpack)", "Large (Duffel/Luggage)"] },
            visible_Items_Inside: { type: "text", placeholder: "e.g. Blue notebook, Umbrella" }
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
    // If they are editing, it fills it with 'editData'. Otherwise it is empty.
    // ========================================== //
    const [selectedCategory, setSelectedCategory] = useState(editData?.itemType || "");

    const [formData, setFormData] = useState({
        itemType: editData?.itemType || "",
        attributes: editData?.attributes || {},
        lastSeenLocation: editData?.lastSeenLocation || "",
        dateLost: editData?.dateLost || "",
        timeLost: editData?.timeLost || "",
        description: editData?.description || ""
    });


    // ========================================== //
    // SECTION 5: INPUT HANDLERS
    // These functions run when a user types or clicks on the form.
    // They update the formData variables above.
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

    // When user changes the main Dropdown (e.g. switches from Phone to Bag)
    const handleCategoryChange = (e) => {
        const category = e.target.value;
        setSelectedCategory(category);

        // Reset the form when category changes
        setFormData({
            itemType: category,
            attributes: {},
            lastSeenLocation: "",
            dateLost: "",
            timeLost: "",
            description: ""
        });
    };

    // When the user answers a specific question (like Brand or Color)
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

    // When the user types into normal text inputs like location, date, time
    const handleInputChange = (e) => {
        const { name, value } = e.target;
        setFormData(prev => ({ ...prev, [name]: value }));
    };

    // Form Submission Logic
    const handleSubmit = async (e) => {
        e.preventDefault();

        // basic validation
        if (!selectedCategory || !formData.lastSeenLocation || !formData.dateLost || !formData.timeLost) {
            setSubmitStatus({ type: 'error', message: 'Please fill in all required fields (Item Type, Location, Date, Time)' });
            window.scrollTo({ top: 0, behavior: 'smooth' });
            return;
        }

        setIsSubmitting(true);
        setSubmitStatus({ type: '', message: '' });

        try {
            // STEP 1: Identification
            // Find IDs of selected category and location names from the pre-loaded lists
            const typeEntity = itemTypes.find(t => t.name === selectedCategory);
            const locationEntity = universityLocations.find(l => l.name === formData.lastSeenLocation);

            // STEP 2: Date/Time Synchronization
            // .NET requires ISO string or specific format. We clean user input and append seconds.
            const cleanTime = formData.timeLost.split(' ')[0];
            const isoDateTime = `${formData.dateLost}T${cleanTime}:00`;

            // STEP 3: Data Packaging
            // We use FormData because:
            // a) Files (images) can't be sent via raw JSON easily.
            // b) The backend uses [FromForm] attributes.
            const data = new FormData();
            data.append('eventTime', isoDateTime);
            data.append('locationId', locationEntity?.id || 0);
            data.append('itemTypeId', typeEntity?.id || 0);
            data.append('status', 0);      // Enum: 0 = Lost
            data.append('reportType', 0);  // Enum: 0 = Lost Report

            // STEP 4: Dynamic Attributes Mapping
            // Backend model binding for List<Attribute> expects indexed naming:
            // Attributes[0].FieldName, Attributes[0].FieldValue
            let attrIndex = 0;
            Object.entries(formData.attributes).forEach(([key, val]) => {
                data.append(`Attributes[${attrIndex}].FieldName`, key);
                data.append(`Attributes[${attrIndex}].FieldValue`, String(val));
                attrIndex++;
            });

            // STEP 5: Additional Info
            // If the user provided a custom description, we treat it as an extra attribute
            if (formData.description) {
                data.append(`Attributes[${attrIndex}].FieldName`, 'Additional Description');
                data.append(`Attributes[${attrIndex}].FieldValue`, formData.description);
            }

            // STEP 6: API Communication
            console.log("Submitting Lost Report...");
            const response = await api.post('Item/create', data, {
                headers: { 'Content-Type': 'multipart/form-data' }
            });
            console.log("Server Response:", response.data);

            if (response.data.isSucceeded || response.data.IsSucceeded) {
                setSubmitStatus({ type: 'success', message: response.data.message || 'Report submitted successfully!' });
                setTimeout(() => navigate('/dashboard'), 2000);
            } else {
                setSubmitStatus({ type: 'error', message: response.data.message || 'Failed to submit report' });
            }

        } catch (err) {
            console.error("Submission Error:", err);
            const errMsg = err.response?.data?.message || err.message || 'An unexpected error occurred. Please try again.';
            setSubmitStatus({ type: 'error', message: errMsg });
            window.scrollTo({ top: 0, behavior: 'smooth' });
        } finally {
            setIsSubmitting(false);
        }
    };


    // ========================================== //
    // SECTION 6: DYNAMIC HTML GENERATOR
    // This function magically generates the correct HTML (dropdown, radio, color picker)
    // based on the configuration we wrote in SECTION 3.
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
                </div>
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
    };

    // Loops through the chosen category and builds a box for each question.
    // Supports a special 'row' type that renders two inputs (e.g. RAM & ROM) side-by-side.
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
    // SECTION 7: PAGE LAYOUT AND HTML
    // ========================================== //
    return (
        <div className="dashboard-container">

            {/* Display Sidebar Menu */}
            <Sidebar />

            <main className="main-content">

                {/* 7A. Header with Title */}
                <Header
                    title={editData ? "Edit Lost Report" : "Report Lost Item"}
                    subtitle={editData ? "Update your item details below." : "Tell us what happened."}
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
                        {/* 7B. LEFT COLUMN (Item Details) */}
                        {/* Contains Category Dropdown & Dynamic Questions */}
                        {/* ------------------------------------------- */}
                        <div className="form-column">
                            <h3 className="column-title">Item Specification</h3>

                            {/* Main Category Dropdown */}
                            <div className="input-card">
                                <label className="field-label">What did you lose?</label>
                                <select className="custom-select"
                                    value={selectedCategory}
                                    onChange={handleCategoryChange}>
                                    <option value="" disabled>Select item type...</option>
                                    {itemTypes.map(cat => (
                                        <option key={cat.id} value={cat.name}>{cat.name}</option>
                                    ))}
                                </select>
                            </div>

                            {/* Spits out all the specific questions based on dropdown choice */}
                            {renderDynamicAttributes()}

                            {/* Shows this message if nothing is selected yet */}
                            {selectedCategory === "" && (
                                <div className="empty-state-card" style={{ marginTop: '1rem' }}>
                                    <p style={{ color: '#718096', fontStyle: 'italic' }}>Select an item type to see specific attributes.</p>
                                </div>
                            )}
                        </div>

                        {/* ------------------------------------------- */}
                        {/* 7C. RIGHT COLUMN (Incident Details) */}
                        {/* Contains Time, Date, Location, and Submit Button */}
                        {/* ------------------------------------------- */}
                        <div className="form-column">
                            <h3 className="column-title">Incident Details</h3>

                            {/* Last Seen Location Input */}
                            <div className="input-card flex-row">
                                <select
                                    name="lastSeenLocation"
                                    className="custom-input"
                                    value={formData.lastSeenLocation}
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

                            {/* Date Lost Input (Calendar) */}
                            <div className="input-card flex-row mt-2">
                                <input type="date" name="dateLost"
                                    className="custom-input"
                                    value={formData.dateLost}
                                    onChange={handleInputChange} />
                                <Calendar size={20} color="#718096" />
                            </div>

                            {/* Time Lost Input (Clock) */}
                            <div className="input-card flex-row mt-2">
                                <input type="time" name="timeLost"
                                    className="custom-input"
                                    value={formData.timeLost}
                                    onChange={handleInputChange} />
                                <Clock size={20} color="#718096" />
                            </div>

                            {/* Extra Notes Input Box */}
                            <div className="input-card mt-3">
                                <label className="field-label">Additional Notes</label>
                                <textarea
                                    name="description"
                                    className="custom-input"
                                    rows="4"
                                    placeholder="Optional description..."
                                    value={formData.description}
                                    onChange={handleInputChange}
                                    style={{ resize: 'none' }}
                                />
                            </div>

                        </div>

                        {/* ------------------------------------------- */}
                        {/* BOTTOM SUBMIT BUTTON */}
                        {/* ------------------------------------------- */}
                        <div className="form-footer-action">
                            <button
                                type="submit"
                                className={`submit-action-btn ${isSubmitting ? 'loading' : ''}`}
                                disabled={isSubmitting}
                            >
                                {isSubmitting ? 'Submitting...' : (editData ? "Update Lost Report" : "Submit Lost Report")}
                            </button>
                        </div>

                    </form>
                </div>
            </main>
        </div>
    );
};

export default ReportLost;
