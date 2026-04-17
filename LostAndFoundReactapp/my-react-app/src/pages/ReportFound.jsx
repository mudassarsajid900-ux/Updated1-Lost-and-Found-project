/**
 * @file ReportFound.jsx
 * @description Advanced student interface for reporting discovered assets.
 * Features a Hybrid Rendering Engine:
 * 1. Static Configuration: High-performance layouts for common items (Phones, Laptops).
 * 2. Dynamic Archetype Rendering: Real-time reflection of administrator-defined 
 *    categories and forensic attributes from the database.
 */
import React, { useState, useEffect } from 'react';
import { useNavigate, useLocation } from 'react-router-dom';
import Sidebar from '../components/Sidebar';
import Header from '../components/Header';
import api from '../api/axios';
import { sanitizeInput, validateFileUpload } from '../utils/security';
import { 
    ChevronLeft, Camera, MapPin, Calendar, 
    Smartphone, Laptop, Wallet, Folder, 
    AlertCircle, CheckCircle, Info, Sparkles,
    Trash2, Plus, Gem, Headphones
} from 'lucide-react';
const ReportFound = () => {
    const navigate = useNavigate();
    const location = useLocation();
    const editData = location.state?.itemData;
    const isAdmin = localStorage.getItem('isAdmin') === 'true';

    const [mobileCompanies, setMobileCompanies] = useState([]);
    const [mobileModels, setMobileModels] = useState([]);
    const [loadingModels, setLoadingModels] = useState(false);

    // New dynamic states with fallbacks
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
    const [photo, setPhoto] = useState(null);
    const [photoPreview, setPhotoPreview] = useState(null);
    const [photoFile, setPhotoFile] = useState(null);

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
            estimatedSize: { type: "radio", options: ["Small (100-200ml)", "Medium (200-500ml)", "Large (500ml-1L)", "Other"] },
            stickersOrName: { type: "text", placeholder: "e.g. Name sticker 'Sarah', Doraemon sticker" }
        },

        "Bag / Luggage": {
            Brand: { type: "dropdown", options: ["Nike", "Adidas", "Puma", "Jansport", "Samsonite", "Other"] },
            Material: { type: "radio", options: ["Leather", "Canvas", "Nylon", "Synthetic"] },
            Color: { type: "radio", options: ["Black", "Blue", "Red", "Gold", "White", "Other"] },
            size: { type: "radio", options: ["Small (Pouch/Crossbody)", "Medium (Backpack)", "Large (Duffel/Luggage)"] },
            visibleItemsInside: { type: "text", placeholder: "e.g. Blue notebook, Umbrella" }
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
    // ========================================== //

    // Which big dropdown category is selected (e.g. "Phone")
    const [selectedCategory, setSelectedCategory] = useState(editData?.type || editData?.Type || "");

    const getInitialFormData = () => {
        if (!editData) return { itemType: "", attributes: {}, dateFound: "", venue: "", description: "" };
        const dateRaw = editData.eventTime || editData.EventTime;
        let dateFormatted = "";
        
        if (dateRaw) {
            try {
                const parsedDate = new Date(dateRaw);
                if (!isNaN(parsedDate.getTime())) {
                    dateFormatted = parsedDate.toISOString().split('T')[0];
                } else if (typeof dateRaw === 'string' && dateRaw.includes('/')) {
                    // Fallback for MM/DD/YYYY format
                    const parts = dateRaw.split(' ')[0].split('/');
                    if (parts.length === 3) {
                        // MM/DD/YYYY to YYYY-MM-DD
                        dateFormatted = `${parts[2]}-${parts[0].padStart(2, '0')}-${parts[1].padStart(2, '0')}`;
                    }
                }
            } catch (e) {
                console.error("Date parse error", e);
            }
        }

        const attrs = editData.attributes || editData.Attributes || [];
        let desc = "";
        const attrObj = {};
        attrs.forEach(a => {
            const fname = a.fieldName || a.FieldName;
            const fval = a.fieldValue || a.FieldValue;
            if (fname === 'Found Description') desc = fval;
            else attrObj[fname] = fval;
        });
        return {
            itemType: editData.type || editData.Type || "",
            attributes: attrObj,
            dateFound: dateFormatted,
            venue: editData.locationName || editData.LocationName || "",
            description: desc
        };
    };

    /**
     * Helper: Gets a Lucide React icon based on the string category/type name.
     */
    const getCategoryIcon = (itemType, size = 18) => {
        if (!itemType) return <Folder size={size} />;
        const typeLabel = itemType.toLowerCase();
        if (typeLabel.includes('wallet')) return <PlusCircle size={size} />; 
        if (typeLabel.includes('hardware') || typeLabel.includes('laptop')) return <Sliders size={size} />; 
        if (typeLabel.includes('device') || typeLabel.includes('phone') || typeLabel.includes('mobile')) return <Camera size={size} />;
        if (typeLabel.includes('luggage') || typeLabel.includes('bag')) return <Folder size={size} />;
        if (typeLabel.includes('security') || typeLabel.includes('key')) return <Gavel size={size} />;
        if (typeLabel.includes('timepiece') || typeLabel.includes('watch')) return <Clock size={size} />;
        return <PlusCircle size={size} />;
    };

    // The rest of the form answers
    const [formData, setFormData] = useState(getInitialFormData());


    // ========================================== //
    // SECTION 5: INPUT HANDLERS
    // These functions run when a user types or clicks on the form to save their answers.
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

    // Typing in plain text or date fields
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
                setPhoto(reader.result);
                setPhotoPreview(reader.result);
                setPhotoFile(file);
            };
            reader.readAsDataURL(file);
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
                // If brand changes, clear the model
                if ((name === "Brand" || name === "Manufacturer Brand" || name === "OEM Brand") && 
                    (selectedCategory.includes("Device") || selectedCategory.includes("Hardware"))) {
                    delete updated["Hardware Model"];
                    delete updated["Model"];
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

            let response;

            if (editData) {
                if (!formData.dateFound) {
                    throw new Error("Date is required. Please select a valid date.");
                }

                // Fix 1: status must be a number (1=Found). API may return string "Found" or number 1.
                const rawStatus = editData.status ?? editData.Status;
                let numericStatus = 1; // default = Found
                if (typeof rawStatus === 'number') numericStatus = rawStatus;
                else if (typeof rawStatus === 'string') {
                    const s = rawStatus.toLowerCase();
                    if (s === 'found') numericStatus = 1;
                    else if (s === 'lost') numericStatus = 0;
                    else numericStatus = parseInt(rawStatus) || 1;
                }

                // Fix 2: locationId — prefer name match but always fall back to original ID
                const safeLocationId = locationEntity?.id || editData.locationId || editData.LocationId || 0;
                const safeItemTypeId = typeEntity?.id || editData.itemTypeId || editData.ItemTypeId || 0;

                // UPDATE LOGIC (JSON body)
                const updateData = {
                    id: editData.id || editData.Id,
                    eventTime: `${formData.dateFound}T12:00:00`,
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
                        fieldName: 'Found Description',
                        fieldValue: formData.description
                    });
                }
                
                console.log("Submitting Update Request...", updateData);
                response = await api.put('Item/update', updateData);
                console.log("Server Response:", response.data);

            } else {
                // CREATE LOGIC (Multipart Form Data)
                // Security: Sanitize all forensic attributes before submission
                const payload = new FormData();
                payload.append('eventTime', `${formData.dateFound}T12:00:00`);
                payload.append('locationId', locationEntity?.id || 0);
                payload.append('itemTypeId', typeEntity?.id || 0);
                payload.append('status', 1);      // Enum: 1 = Found
                payload.append('reportType', 1);  // Enum: 1 = Found Report

                if (photoFile) {
                    payload.append('photo', photoFile);
                }

                Object.keys(formData.attributes).forEach((key, index) => {
                    const sanitizedValue = sanitizeInput(formData.attributes[key]);
                    payload.append(`Attributes[${index}].FieldName`, key);
                    payload.append(`Attributes[${index}].FieldValue`, String(sanitizedValue));
                });

                const descIndex = Object.keys(formData.attributes).length;
                if (formData.description) {
                    data.append(`Attributes[${descIndex}].FieldValue`, formData.description);
                }

                if (photo) {
                    data.append('photo', photo);
                }

                console.log("Submitting Found Report...");
                response = await api.post('Item/create', data, {
                    headers: { 'Content-Type': 'multipart/form-data' }
                });
                console.log("Server Response:", response.data);
            }

            if (response.data.isSucceeded || response.data.IsSucceeded) {
                setSubmitStatus({ type: 'success', message: response.data.message || 'Found report published successfully!' });
                setTimeout(() => {
                    const itemId = editData?.id || editData?.Id;
                    if (isAdmin) {
                        navigate(editData ? `/admin-report-control/${itemId}` : '/admin-reports');
                    } else {
                        navigate(editData ? '/my-items' : '/dashboard');
                    }
                }, 2000);
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
            <Sidebar isAdmin={isAdmin} />

            {/* Main content Area */}
            <main className="main-content">

                {/* 7A. Page Header showing Title */}
                <Header
                    title={editData ? "Edit Found Report" : "Report Found Item"}
                    subtitle={editData ? "Updating report details." : "Fill in the details to help find the owner."}
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
                        <div className={`notification-banner ${submitStatus.type} animate-fade-in`}>
                            {submitStatus.type === 'success' ? <CheckCircle size={20} /> : <AlertCircle size={20} />}
                            {submitStatus.message}
                        </div>
                    )}

                    {/* NEW: STEP INDICATOR */}
                    <div className="form-steps-indicator">
                        <div className={`step-dot ${selectedCategory ? 'active' : ''}`}>1<span>Spec</span></div>
                        <div className="step-line"></div>
                        <div className={`step-dot ${formData.dateFound && formData.venue ? 'active' : ''}`}>2<span>Logistics</span></div>
                        <div className="step-line"></div>
                        <div className={`step-dot ${photo ? 'active' : ''}`}>3<span>Proof</span></div>
                    </div>

                    <form className="report-form-grid" onSubmit={handleSubmit}>

                        {/* ------------------------------------------- */}
                        {/* 7B. LEFT COLUMN (Item Specification Area) */}
                        {/* ------------------------------------------- */}
                        <div className="form-column">
                            <h3 className="column-title">Item Specification</h3>

                            {/* Main Category Grid Selection */}
                            <div className="form-section">
                                <label className="section-label">1. Primary Classification</label>
                                <div className="category-selection-grid">
                                    {itemTypes.slice(0, 6).map(cat => (
                                        <div 
                                            key={cat.id} 
                                            className={`category-icon-card ${selectedCategory === cat.name ? 'active' : ''}`}
                                            onClick={() => handleCategoryChange({ target: { value: cat.name } })}
                                        >
                                            {getCategoryIcon(cat.name, 24)}
                                            <span>{cat.name}</span>
                                        </div>
                                    ))}
                                    <select
                                        className="category-pill-dropdown"
                                        value={selectedCategory}
                                        onChange={handleCategoryChange}
                                    >
                                        <option value="">More Categories...</option>
                                        {itemTypes.slice(6).map(cat => (
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
                                    <input
                                        type="date"
                                        name="dateFound"
                                        className="custom-input"
                                        value={formData.dateFound}
                                        onChange={handleInputChange}
                                        max={new Date().toISOString().split('T')[0]}
                                    />
                                    <Calendar size={20} color="#718096" />
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
