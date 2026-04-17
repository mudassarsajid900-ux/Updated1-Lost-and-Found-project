/**
 * @file ReportLost.jsx
 * @description Advanced student interface for reporting lost personal assets.
 * Features a Hybrid Rendering Engine:
 * 1. Static Configuration: Pre-optimized layouts for common high-value items (Phones, Laptops).
 * 2. Dynamic Archetype Rendering: Real-time synchronization with administrator-defined 
 *    categories and forensic attributes from the database.
 */
import React, { useState, useEffect } from 'react';
import { useNavigate, useLocation } from 'react-router-dom';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';
import api from '../api/axios';
import { sanitizeInput, validateFileUpload } from '../utils/security';
import { 
    Calendar, MapPin, Clock, Smartphone, 
    Laptop, Wallet as WalletIcon, Folder, 
    Briefcase, Watch, HelpCircle 
} from 'lucide-react';
const ReportLost = () => {
    // Allows us to redirect the user
    const navigate = useNavigate();

    // Allows us to see if we came here from the 'Edit' button on MyItems page
    const location = useLocation();
    const editData = location.state?.itemData; // If we are editing, this holds the old data

    // Check admin status at the top so it's available throughout the component
    const isAdmin = localStorage.getItem('isAdmin') === 'true';

    const [mobileCompanies, setMobileCompanies] = useState([]);
    const [mobileModels, setMobileModels] = useState([]);
    const [loadingModels, setLoadingModels] = useState(false);
    const [photoFile, setPhotoFile] = useState(null);
    const [photoPreview, setPhotoPreview] = useState(null);

    // State for Dynamic Dropdowns (Fetched from Database)
    const [itemTypes, setItemTypes] = useState([
        { id: 1, name: "Mobile Device" },
        { id: 2, name: "Personal Wallet" },
        { id: 3, name: "Computing Hardware (Laptop)" },
        { id: 4, name: "Security Keys" },
        { id: 5, name: "Bag / Luggage" },
        { id: 6, name: "Timepiece (Watch)" },
        { id: 7, name: "Official Documentation (ID/Pass)" },
        { id: 8, name: "Jewelry & Valuables" },
        { id: 9, name: "Audio Peripheral (Headphones)" },
        { id: 10, name: "Miscellaneous Asset" }
    ]);
    const [universityLocations, setUniversityLocations] = useState([
        { id: 1, name: "LT1" }, { id: 2, name: "LT2" }, { id: 3, name: "LT3" },
        { id: 14, name: "LAB-1" }, { id: 15, name: "LAB-2" }, { id: 26, name: "Parking Central" },
        { id: 34, name: "Admin Office" }
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
        "Mobile Device": {
            "Manufacturer Brand": { type: "dropdown", options: mobileCompanies.map(c => c.name) },
            "Hardware Model": {
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
            "Exterior Color": { type: "radio", options: ["Black", "Blue", "Red", "Gold", "White", "Other"] },
            "approximateSize": { type: "radio", options: ["Small (Mini)", "Medium (Standard)", "Large (Pro Max/Plus)"] },
            "Screen Status (Locked)": { type: "radio", options: ["Yes (Locked)", "No (Unlocked)", "Unknown"] },
            simCardPresent: { type: "radio", options: ["Yes", "No", "Unknown"] },
            "Physical Condition": { type: "dropdown", options: ["Good Condition", "Cracked Screen", "Scratched Body", "Heavy Wear"] },
            "IMEI indexing (Last 4)": { type: "radio", options: ["Yes (on back/tray)", "No", "Unknown"] }
        },

        "Computing Hardware (Laptop)": {
            "OEM Brand": { type: "dropdown", options: ["Apple", "Dell", "HP", "Lenovo", "Asus", "Other"] },
            "Display Specification": { type: "radio", options: ["13 inch", "14 inch", "15-16 inch", "Unknown"] },
            ramRom: {
                type: "row",
                fields: {
                    ram: { type: "text", label: "RAM", placeholder: "RAM" },
                    rom: { type: "text", label: "ROM", placeholder: "ROM" }
                }
            },
            "Chassis Color": { type: "radio", options: ["Black", "Blue", "Red", "Gold", "White", "Other"] },
            "OS Security State": { type: "radio", options: ["Yes", "No", "Unknown"] },
            "Visual Customizations (Stickers)": { type: "text", placeholder: "e.g. Apple sticker, Blue ink mark on corner" },
            chargerFound: { type: "radio", options: ["With Charger", "No Charger"] },
            serialNumberVisible: { type: "radio", options: ["Yes", "No"] }
        },

        "Personal Wallet": {
            "Primary Color": { type: "radio", options: ["Black", "Blue", "Red", "Gold", "White", "Other"] },
            "Material Construction": { type: "radio", options: ["Leather", "Fabric", "Synthetic"] },
            "Personal ID Inclusion": { type: "radio", options: ["Yes", "No"] },
            "Currency Content Audit": { type: "radio", options: ["Yes", "No"] },
            numberOfCards: { type: "dropdown", options: ["None", "1-3 Cards", "4-7 Cards", "8+ Cards"] }
        },

        "Bottle": {
            brandName: { type: "text", placeholder: "e.g. Hydro Flask, Stanley" },
            Color: { type: "radio", options: ["Black", "Blue", "Red", "Gold", "White", "Other"] },
            estimatedSize: { type: "radio", options: ["Small (250-500ml)", "Medium (750ml-1L)", "Large (1.5L+)"] },
            stickersOrName: { type: "text", placeholder: "e.g. Name sticker 'Sarah', Doraemon sticker" }
        },

        "Bag / Luggage": {
            Brand: { type: "dropdown", options: ["Nike", "Adidas", "Puma", "Jansport", "Samsonite", "Other"] },
            Material: { type: "radio", options: ["Leather", "Canvas", "Nylon", "Synthetic"] },
            Color: { type: "radio", options: ["Black", "Blue", "Red", "Gold", "White", "Other"] },
            size: { type: "radio", options: ["Small (Pouch/Crossbody)", "Medium (Backpack)", "Large (Duffel/Luggage)"] },
            visible_Items_Inside: { type: "text", placeholder: "e.g. Blue notebook, Umbrella" }
        },

        "Security Keys": {
            "Number of Keys": { type: "dropdown", options: ["1", "2", "3", "4+"] },
            "Key Type": { type: "radio", options: ["Home Keys", "Car Key", "Bike Key", "Office Keys"] },
            "Has Keychain": { type: "radio", options: ["Yes", "No"] },
            keychainDescription: { type: "text", placeholder: "e.g. Red ribbon, Spiderman keychain" }
        },

        "Timepiece (Watch)": {
            Brand: { type: "dropdown", options: ["Rolex", "Casio", "Seiko", "Apple", "Samsung", "Other"] },
            type: { type: "radio", options: ["Analog", "Digital", "Smartwatch"] },
            "Strap Material": { type: "radio", options: ["Leather", "Metal", "Silicon", "Fabric"] },
            Color: { type: "radio", options: ["Black", "Blue", "Red", "Gold", "White", "Other"] }
        },

        "Jewelry & Valuables": {
            Type: { type: "dropdown", options: ["Ring", "Necklace", "Bracelet", "Earrings", "Other"] },
            Material: { type: "radio", options: ["Gold", "Silver", "Platinum", "Artificial"] },
            Color: { type: "radio", options: ["Gold", "Silver", "Rose Gold", "Other"] }
        },

        "Audio Peripheral (Headphones)": {
            Brand: { type: "dropdown", options: ["Apple Airpods", "Samsung Buds", "Sony", "JBL", "Other"] },
            Type: { type: "radio", options: ["In-ear", "Over-ear", "Wireless", "Wired"] },
            Color: { type: "radio", options: ["Black", "White", "Blue", "Other"] }
        },

        "Official Documentation (ID/Pass)": {
            "Document Classification": { type: "radio", options: ["National ID", "Student Card", "Passport", "Driving License"] },
            "Legal Name on Document": { type: "text", placeholder: "Enter name as it appears..." },
            "Document Identifier (Partial)": { type: "text", placeholder: "Last 4 digits or alpha code..." }
        },

        "Miscellaneous Asset": {
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
    const [selectedCategory, setSelectedCategory] = useState(editData?.type || editData?.Type || "");

    const getInitialFormData = () => {
        if (!editData) {
            return {
                itemType: "",
                attributes: {},
                lastSeenLocation: "",
                dateLost: "",
                timeLost: "",
                description: ""
            };
        }
        
        const dateRaw = editData.eventTime || editData.EventTime;
        let dateFormatted = "";
        let timeFormatted = "";
        
        if (dateRaw) {
            try {
                const parsedDate = new Date(dateRaw);
                if (!isNaN(parsedDate.getTime())) {
                    dateFormatted = parsedDate.toISOString().split('T')[0];
                    timeFormatted = parsedDate.toTimeString().substring(0, 5);
                }
            } catch (e) {
                console.error("Date parse error", e);
            }
        }
        
        const venue = editData.locationName || editData.LocationName || "";
        const attrs = editData.attributes || editData.Attributes || [];
        
        let desc = "";
        const attrObj = {};
        
        attrs.forEach(a => {
            const fname = a.fieldName || a.FieldName;
            const fval = a.fieldValue || a.FieldValue;
            if (fname === 'Additional Description' || fname === 'Lost Description') desc = fval;
            else attrObj[fname] = fval;
        });

        return {
            itemType: editData.type || editData.Type || "",
            attributes: attrObj,
            lastSeenLocation: venue,
            dateLost: dateFormatted,
            timeLost: timeFormatted,
            description: desc
        };
    };

    const [formData, setFormData] = useState(getInitialFormData());


    // ========================================== //
    // SECTION 5: INPUT HANDLERS
    // These functions run when a user types or clicks on the form.
    // They update the formData variables above.
    // ========================================== //

    // Fetch Models when Brand changes
    useEffect(() => {
        const fetchModels = async () => {
            const brand = formData.attributes.Brand;
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
    }, [formData.attributes.Brand, selectedCategory, mobileCompanies]);

    // When user changes the main Dropdown (e.g. switches from Phone to Bag)
    const handlePhotoChange = (e) => {
        const file = e.target.files[0];
        if (file) {
            // Audited: Perform security validation before processing upload
            const validation = validateFileUpload(file);
            if (!validation.valid) {
                 setSubmitStatus({ type: 'error', message: validation.message });
                 return;
            }

            const reader = new FileReader();
            reader.onloadend = () => {
                setPhotoPreview(reader.result);
                setPhotoFile(file);
            };
            reader.readAsDataURL(file);
        }
    };

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
                // If brand changes, clear the model
                if (name === "Brand" && selectedCategory === "Mobile Phone") {
                    delete updated["Model"];
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
            const typeEntity = itemTypes.find(t => t.name === selectedCategory);
            const locationEntity = universityLocations.find(l => l.name === formData.lastSeenLocation);

            // STEP 2: Date/Time Synchronization
            let cleanTime = "12:00";
            if (formData.timeLost) {
                // Handle both "HH:MM" and "HH:MM AM/PM"
                cleanTime = formData.timeLost.split(' ')[0];
                if (cleanTime.split(':').length < 2) cleanTime = "12:00";
            }
            
            if (!formData.dateLost) {
                throw new Error("Date is required. Please pick a date of the incident.");
            }
            
            const isoDateTime = `${formData.dateLost}T${cleanTime}:00`;

            let response;

            if (editData) {
                // UPDATE LOGIC (JSON body)

                // Fix 1: status must be a number (0=Lost). API may return string "Lost" or number 0.
                const rawStatus = editData.status ?? editData.Status;
                let numericStatus = 0; // default = Lost
                if (typeof rawStatus === 'number') numericStatus = rawStatus;
                else if (typeof rawStatus === 'string') {
                    const s = rawStatus.toLowerCase();
                    if (s === 'found') numericStatus = 1;
                    else if (s === 'lost') numericStatus = 0;
                    else numericStatus = parseInt(rawStatus) || 0;
                }

                // Fix 2: locationId — prefer name match but always fall back to original ID
                const safeLocationId = locationEntity?.id || editData.locationId || editData.LocationId || 0;
                const safeItemTypeId = typeEntity?.id || editData.itemTypeId || editData.ItemTypeId || 0;

                const updateData = {
                    id: editData.id || editData.Id,
                    eventTime: isoDateTime,
                    locationId: safeLocationId,
                    itemTypeId: safeItemTypeId,
                    status: numericStatus,
                    attributes: Object.entries(formData.attributes).map(([key, val]) => ({
                        fieldName: key,
                        fieldValue: Array.isArray(val) ? val.join(', ') : String(val)
                    }))
                };
                if (formData.description) {
                    updateData.attributes.push({
                        fieldName: 'Additional Description',
                        fieldValue: formData.description
                    });
                }
                
                console.log("Submitting Lost Report Update...", updateData);
                response = await api.put('Item/update', updateData);
                console.log("Server Response:", response.data);

            } else {
                // CREATE LOGIC (Multipart Form Data)
                // Security: Sanitize all forensic attributes before submission
                // This neutralizes attempts to inject HTML/Script into the Matching engine
                const data = new FormData();
                data.append('eventTime', isoDateTime);
                data.append('locationId', locationEntity?.id || 0);
                data.append('itemTypeId', typeEntity?.id || 0);
                data.append('status', 0);      // Enum: 0 = Lost
                data.append('reportType', 0);  // Enum: 0 = Lost Report

                if (photoFile) {
                    data.append('photo', photoFile);
                }

                let attrIndex = 0;
                Object.entries(formData.attributes).forEach(([key, val]) => {
                    const sanitizedValue = sanitizeInput(val);
                    data.append(`Attributes[${attrIndex}].FieldName`, key);
                    data.append(`Attributes[${attrIndex}].FieldValue`, String(sanitizedValue));
                    attrIndex++;
                });

                if (formData.description) {
                    data.append(`Attributes[${attrIndex}].FieldName`, 'Additional Description');
                    data.append(`Attributes[${attrIndex}].FieldValue`, formData.description);
                }

                console.log("Submitting Lost Report...");
                response = await api.post('Item/create', data, {
                    headers: { 'Content-Type': 'multipart/form-data' }
                });
                console.log("Server Response:", response.data);
            }

            if (response.data.isSucceeded || response.data.IsSucceeded) {
                setSubmitStatus({ type: 'success', message: response.data.message || 'Report submitted successfully!' });
                setTimeout(() => {
                    const itemId = editData?.id || editData?.Id;
                    if (isAdmin) {
                        navigate(editData ? `/admin-report-control/${itemId}` : '/admin-reports');
                    } else {
                        navigate(editData ? '/my-items' : '/dashboard');
                    }
                }, 2000);
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
        // 1. Try to find hardcoded config
        const config = itemConfigurations[selectedCategory];

        // 2. If not found, check if it's a dynamic category from the database
        if (!config) {
            const dynamicType = itemTypes.find(t => t.name === selectedCategory);
            const dynamicFields = dynamicType?.fields || dynamicType?.Fields || [];
            
            // If it has dynamic fields defined by admin, render them as text inputs
            if (dynamicFields.length > 0) {
                return (
                    <div className="dynamic-attributes-container animate-fade-in">
                        <h4 className="column-title" style={{ fontSize: '0.9rem', color: '#64748b', marginTop: '1.5rem', marginBottom: '0.5rem' }}>Forensic Attributes</h4>
                        {dynamicFields.map((field) => {
                            const fieldName = field.fieldName || field.FieldName;
                            return (
                                <div key={field.id || fieldName} className="input-card mt-3">
                                    <label className="field-label">{fieldName.toUpperCase()}</label>
                                    <input
                                        type="text"
                                        className="custom-input"
                                        placeholder={`Enter ${fieldName.toLowerCase()}...`}
                                        value={formData.attributes[fieldName] || ""}
                                        onChange={(e) => handleAttributeChange(fieldName, e.target.value, "text")}
                                    />
                                </div>
                            );
                        })}
                    </div>
                );
            }

            // Fallback for types with no specific configuration
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

        // Render hardcoded configuration (for complex types like Phone/Laptop)
        return Object.entries(config).map(([name, attrConfig]) => {
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

            return (
                <div key={name} className="input-card mt-3">
                    <label className="field-label">{name.toUpperCase()}</label>
                    {renderAttribute(name, attrConfig)}
                </div>
            );
        });
    };

    const isAdmin_ref = isAdmin; // isAdmin already declared at top of component

    // ========================================== //
    // SECTION 7: PAGE LAYOUT AND HTML
    // ========================================== //
    return (
        <div className="dashboard-container">

            {/* Display Sidebar Menu */}
            <Sidebar isAdmin={isAdmin} />

            <main className="main-content">

                {/* 7A. Header with Title */}
                <Header
                    title={editData ? "Edit Lost Report" : "Report Lost Item"}
                    subtitle={editData ? "Update your item details below." : "Tell us what happened."}
                    showBack={true}
                    onBack={() => {
                        const itemId = editData?.id || editData?.Id;
                        if (isAdmin) {
                            navigate(editData ? `/admin-report-control/${itemId}` : '/admin-reports');
                        } else {
                            navigate(editData ? '/my-items' : '/dashboard');
                        }
                    }}
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

                            {/* form steps indicator */}
                            <div className="form-steps-indicator">
                                <div className={`step-dot ${selectedCategory ? 'active' : ''}`}>1<span>Spec</span></div>
                                <div className="step-line"></div>
                                <div className={`step-dot ${formData.dateLost && formData.lastSeenLocation ? 'active' : ''}`}>2<span>Logistics</span></div>
                                <div className="step-line"></div>
                                <div className={`step-dot ${formData.description ? 'active' : ''}`}>3<span>Notes</span></div>
                            </div>

                            {/* Main Category Selection (Icon Grid) */}
                            <div className="category-selection-grid">
                                {itemTypes.slice(0, 6).map(cat => {
                                    const Icon = {
                                        "Mobile Phone": Smartphone,
                                        "Laptop": Laptop,
                                        "Wallet": WalletIcon,
                                        "Keys": Folder,
                                        "Bag / Backpack": Briefcase,
                                        "Watch": Watch
                                    }[cat.name] || HelpCircle;

                                    return (
                                        <div 
                                            key={cat.id} 
                                            className={`category-icon-card ${selectedCategory === cat.name ? 'active' : ''}`}
                                            onClick={() => handleCategoryChange({ target: { value: cat.name } })}
                                        >
                                            <Icon size={24} />
                                            <span>{cat.name}</span>
                                        </div>
                                    );
                                })}

                                <select className="custom-select category-pill-dropdown"
                                    value={selectedCategory}
                                    onChange={handleCategoryChange}>
                                    <option value="" disabled>Search more categories...</option>
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
                                    onChange={handleInputChange}
                                    max={new Date().toISOString().split('T')[0]} />
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
