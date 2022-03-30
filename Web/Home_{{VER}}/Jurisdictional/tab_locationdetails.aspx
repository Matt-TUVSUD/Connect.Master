<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="tab_locationdetails.aspx.vb" Inherits="GRC.Connect.Web.tab_locationdetails_juris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="Stylesheet" type="text/css" href="../../css/pages/locationdetails.css" />
    <script src="../../Lib_{{VER}}/Generated/ViewCCLocationListingJuris.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCLocationOpenViolationCountJuris.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCLocationListingJuris.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCLocationOpenViolationCountJuris.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="headerFindCriteria" id="viewFindCriteria_LocationDetails" data-bind="with: viewFindCriteria_LocationDetails">
        <label data-bind="text: $parent.findCriteria" id="findCriteria"></label>&nbsp;
    </div>
    <div id="view_LocationDetails" data-bind="with: view_LocationDetails">
    <!-- TABLE FOR COMPANY / ADDRESS INFORMATION -->
    <!-- SPECIFIC STYLES TO ROWS OR COLUMNS SHOULD BE INLINE -->
    <div class="tableDiv">
        <div class="tabRow">
            <span class="companyLabels1"><label data-bind="text: $parent.objLanguageLabels().lblGRCLocNo, css: { findOn: $parent.objFind().findFileNo, findOff: !$parent.objFind().findFileNo }">GRC Loc. No.</label></span>
            <span class="companyInputs1"><input data-bind="value: $parent.objListing().FileNo, css: { findOnInput: $parent.objFind().findFileNo, findOffInput: !$parent.objFind().findFileNo }" id="FileNo" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs1" tabindex="1" /></span>
            <span class="companyLabels2"><label data-bind="text: $parent.objLanguageLabels().lblClientlocno, css: { findOn: $parent.objFind().findClientlocno, findOff: !$parent.objFind().findClientlocno }">Client Loc. No.</label></span>
            <span class="companyInputs2"><input data-bind="value: $parent.objListing().Clientlocno, css: { findOnInput: $parent.objFind().findClientlocno, findOffInput: !$parent.objFind().findClientlocno }" id="Clientlocno" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs2" tabindex="2" /></span>
            <span class="companyLabels5"><label data-bind="text: $parent.objLanguageLabels().lblLatitude, css: { findOn: $parent.objFind().findLatitude, findOff: !$parent.objFind().findLatitude }">Latitude</label></span>
            <span class="companyInputs4"><input data-bind="value: $parent.objListing().Latitude, css: { findOnInput: $parent.objFind().findLatitude, findOffInput: !$parent.objFind().findLatitude }" id="Latitude" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs4" tabindex="3"  /></span>
            <span class="companyLabels4"><label data-bind="text: $parent.objLanguageLabels().lblLongitude, css: { findOn: $parent.objFind().findLongitude, findOff: !$parent.objFind().findLongitude }">Longitude</label></span>
            <span class="companyInputs4"><input data-bind="value: $parent.objListing().Longitude, css: { findOnInput: $parent.objFind().findLongitude, findOffInput: !$parent.objFind().findLongitude }" id="Longitude" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs4" tabindex="4"  /></span>
        </div>
        <div class="tabRow">
            <span class="companyLabels1"><label data-bind="text: $parent.objLanguageLabels().lblAddress1, css: { findOn: $parent.objFind().findAddress1, findOff: !$parent.objFind().findAddress1 }">Address</label></span>
            <span class="companyInputs6"><input data-bind="value: $parent.objListing().Address1, css: { findOnInput: $parent.objFind().findAddress1, findOffInput: !$parent.objFind().findAddress1 }" id="Address1" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs6" tabindex="5"  /></span>
            <span class="companyLabels3"><label data-bind="text: $parent.objLanguageLabels().lblDivisionName, css: { findOn: $parent.objFind().findDivision, findOff: !$parent.objFind().findDivision }">Division Name</label></span>
            <span class="companyInputs5"><input data-bind="value: $parent.objListing().Division, css: { findOnInput: $parent.objFind().findDivision, findOffInput: !$parent.objFind().findDivision }" id="Division" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="6"  /></span>
        </div>
        <div class="tabRow">
            <span class="companyLabels1"><label data-bind="text: $parent.objLanguageLabels().lblCity, css: { findOn: $parent.objFind().findCity, findOff: !$parent.objFind().findCity }">City</label></span>
            <span class="companyInputs1"><input data-bind="value: $parent.objListing().City, css: { findOnInput: $parent.objFind().findCity, findOffInput: !$parent.objFind().findCity }" id="City" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs1" tabindex="7"  /></span>
            <span class="stateLabels"><label data-bind="text: $parent.objLanguageLabels().lblState, css: { findOn: $parent.objFind().findStprov, findOff: !$parent.objFind().findStprov }">State</label></span>
            <span class="stateInputs"><input data-bind="value: $parent.objListing().Stprov, css: { findOnInput: $parent.objFind().findStprov, findOffInput: !$parent.objFind().findStprov }" id="Stprov" class="k-autocomplete k-input inputNoEdit inputLeft stateInputs" tabindex="8"  /></span>
            <span class="countryLabels"><label data-bind="text: $parent.objLanguageLabels().lblCountry, css: { findOn: $parent.objFind().findCountry, findOff: !$parent.objFind().findCountry }">Country</label></span>
            <span class="countryInputs"><input data-bind="value: $parent.objListing().Country, css: { findOnInput: $parent.objFind().findCountry, findOffInput: !$parent.objFind().findCountry }" id="Country" class="k-autocomplete k-input inputNoEdit inputLeft countryInputs" tabindex="9"  /></span>
            <span class="postalLabels"><label data-bind="text: $parent.objLanguageLabels().lblPostalCode, css: { findOn: $parent.objFind().findZip, findOff: !$parent.objFind().findZip }">Postal</label></span>
            <span class="postalInputs"><input data-bind="value: $parent.objListing().Zip, css: { findOnInput: $parent.objFind().findZip, findOffInput: !$parent.objFind().findZip }" id="Zip" class="k-autocomplete k-input inputNoEdit inputLeft postalInputs" tabindex="10"  /></span>
            <span class="companyLabels3"><label data-bind="text: $parent.objLanguageLabels().lblFacilityName, css: { findOn: $parent.objFind().findFacility, findOff: !$parent.objFind().findFacility }">Facility Name</label></span>
            <span class="companyInputs5"><input data-bind="value: $parent.objListing().Facility, css: { findOnInput: $parent.objFind().findFacility, findOffInput: !$parent.objFind().findFacility }" id="Facility" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="11"  /></span>
        </div>
        <div class="tabRow">
            <!-- BUTTONS FOR LOCATION / FILE NUMBER WALK / FIND LOCATION -->
            <span class="companyLabels1"></span>
            <span class="buttonContainerLocationLoading" style="display:flex;">
                <span><button data-bind="click: $parent.onFileFirst, enable: $parent.enableFilePrev" type="button" class="grcBlueBtn pagerBtn" id="btnFileFirst" tabindex="15" style="margin-right:2px;"><i class="fas fa-step-backward"></i></button></span>
                <span><button data-bind="click: $parent.onFilePrevious, enable: $parent.enableFilePrev" type="button" class="grcBlueBtn pagerBtn" id="btnFilePrevious" tabindex="16"><i class="fas fa-caret-left"></i></button></span>
                <span class="buttonFileRecordLabel" style="width: 130px;">&nbsp;<label data-bind="text: $parent.objLanguageLabels().lblFileRecord">Location</label> <input data-bind="    value: $parent.txtFileRecordNumber" id="txtFileRecordNumber" class="k-autocomplete k-input inputCenter inputNoEdit buttonInput" style="width: 80px; margin-bottom: 3px;" readonly="true" />&nbsp;</span>
                <span><button data-bind="click: $parent.onFileNext, enable: $parent.enableFileNext" type="button" class="grcBlueBtn pagerBtn" id="btnFileNext" tabindex="17" style="margin-right:2px;"><i class="fas fa-caret-right"></i></button></span>
                <span><button data-bind="click: $parent.onFileLast, enable: $parent.enableFileNext" type="button" class="grcBlueBtn pagerBtn" id="btnFileLast" tabindex="18"><i class="fas fa-step-forward"></i></button></span>
                <span>&nbsp;</span>
                <span><button data-bind="click: $parent.onFindClear, css: { hidden: $parent.findEngaged }" type="button" class="grcBlueBtn findBtn hidden" tabindex="13">Clear Find</button></span>
                
                <span><button data-bind="click: $parent.onFind" class="grcBlueBtn findBtn" type="submit" tabindex="14">Find</button></span>
            </span>
            <!-- END BUTTONS FOR LOCATION / FILE NUMBER WALK / FIND LOCATION -->
            <span class="companyLabels6"><label data-bind="text: $parent.objLanguageLabels().lblCustomerAccess, css: { findOn: $parent.objFind().findCustomAccess, findOff: !$parent.objFind().findCustomAccess }">Custom Access</label></span>
            <span class="companyInputs5"><input data-bind="value: $parent.objListing().CustomAccess, css: { findOnInput: $parent.objFind().findCustomAccess, findOffInput: !$parent.objFind().findCustomAccess }" id="CustomAccess" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="12"  /></span>
        </div>
    </div>
    <!-- END TABLE FOR COMPANY / ADDRESS INFORMATION -->



    <!-- TABLE FOR LOCATIONS LISTING INFORMATION -->
    <!-- SPECIFIC STYLES TO ROWS OR COLUMNS SHOULD BE INLINE -->
    <div class="tableDiv">
        <div class="tabBannerHeader" style="justify-content: flex-start; margin-bottom:5px;">
            <label style="margin-left: 10px; font-size:16px;">Open Recommendations</label>
        </div>
    </div>
    <div class="tableDivAutoBordersGray">
    <div class="tableDiv">
        <div class="tabRow">
            <span class="bufferLeft">&nbsp;</span>
            <span class="violationsLabels"><label data-bind="text: $parent.objLanguageLabels().lblNoOfOpenViolations"></label></span>
            <span class="violationsInputs"><input data-bind="value: $parent.objViolations().CountOpen" id="CountOpen" class="k-numerictextbox inputNoEdit locationsInputs1" style="text-align: center;" readonly="true" /></span>
            <span class="bufferRight">&nbsp;</span>
        </div>
        <div class="tabRow">
            <span class="bufferLeft">&nbsp;</span>
            <span class="bufferRight">&nbsp;</span>
        </div>
        <div class="tabRow">
            <span class="bufferLeft">&nbsp;</span>
            <span class="bufferRight">&nbsp;</span>
        </div>
        <div class="tabRow">
            <span class="bufferLeft">&nbsp;</span>
            <span class="bufferRight">&nbsp;</span>
        </div>

        <div class="tabRow">
            <span class="">&nbsp;</span>
        </div>
    </div>
    </div>
    <!-- END TABLE FOR LOCATIONS LISTING INFORMATION -->

    <!-- AREA FOR NO ACTIVE LOCATION PER PRACTICE MESSAGE -->
    <div style="height: 19px; padding-top: 6px; text-align: center;">
        <label id="lblNoActiveLocation" data-bind="text: $parent.messageNoActiveLocation" class="messageError"></label>&nbsp;
    </div>

    <!-- AREA FOR ERROR AND NOTICE MESSAGES -->
    <div style="padding-top: 20px; padding-bottom: 150px; text-align: center;"><label class="messageError" data-bind="text: $parent.messageError"></label><label class="messageNotice" data-bind="    text: $parent.messageNotice"></label><label class="messageWarning" data-bind="    text: $parent.messageWarning"></label>&nbsp;</div>


    <!-- ERROR WINDOW FOR NO RECORD FOUND NOTIFICATION -->
    <div id="windowNoLocation" class="windowContent" style="font-size:13px;">
        <div><img src="../images/icons/warning/sign_warning_32x32.png" align="left" alt="Warning" class="windowImage" /></div>
        <div style="margin-bottom:5px;">
            <label data-bind="text: $parent.objLanguageLabels().lblNoLocationFoundMessage">Warning: There is no Location Detail record found for this file number.</label>
        </div>
        <div style="margin-bottom:5px;">
            <label data-bind="text: $parent.objLanguageLabels().lblNoLocationFoundDescription">Click the below button to go back to the Location Details page, or use the Location Navigation buttons to go to another location record.</label>
        </div>
        <div style="width:100%; display:flex; justify-content: center;"><button class="grcBlueBtn" data-bind="text: $parent.objLanguageLabels().lblGoBackToDetails, click: $parent.onLocationDetailsRedirect">Go Back To Location Details</button></div>
    </div>

</div>
<script type="text/javascript">
    $(document).ready(function () {
        ///////////////////////////////////////////
        //// LOAD SESSION VARIABLES
        var dsLanguageLabels = {
            //// COMPANY INFORMATION
            lblGRCLocNo: "GRC Loc. No.",
            lblClientlocno: "Client Loc. No.",
            lblAddress1: "Address",
            lblCity: "City",
            lblState: "State",
            lblPostalCode: "Postal",
            lblCountry: "Country",
            lblLatitude: "Latitude",
            lblLongitude: "Longitude",
            lblDivisionName: "Division Name",
            lblFacilityName: "Facility Name",
            lblCustomerAccess: "Custom Access",

            //// DOCUMENTS
            lblNoOfOpenViolations: "Total Number of Open Recommendations",

            //// ADMINISTRATION WINDOW
            //            lblWindowAdminTitle: "Administration Window",
            //            lblWindowLoadCOPEInfo: "Load C.O.P.E. Info",
            //            lblWindowLoadNatHazDataInfo: "Load NatHaz Data Info",
            //            lblWindowLoadNatHazModelData: "Load NatHaz Model Data",
            //            lblWindowLoadRecInfo: "Load Rec. Info",
            //            lblWindowLoadRatingInfo: "Load Rating Info",
            //            lblWindowLoadRetailInfo: "Load Retail Info",
            //            lblImport: "Import",
            //            lblSelectAll: "Select All ",
            //            lblSelectNone: "Select None",
            //            lblNoCheckboxesSelected: "Please select at least one import type in the checkboxes above to enable the import button.",
            //            lblIncorrectFileFormat: "The file you are uploading is an invalid file type.  Please try again.",
            //            lblUploadProgress: "Upload Progress",
            //            lblDefaultImportSuccess: "",
            //            lblDefaultImportError: "",
            //            lblContinue: "Continue",
            //            lblCancel: "Cancel",
            //            lblClose: "Close",
            //            lblLoading: "Loading, please wait...",

            //// MISC
            lblRecord: "Record",
            lblFileRecord: "Location",
            lblNoLocationFoundTitle: "No Location Details Found",
            lblNoLocationFoundMessage: "Warning: There is no Location Detail record found for this file number.",
            lblNoLocationFoundDescription: "Click the below button to go back to the Location Details page, or use the Location Navigation buttons to go to another location record.",
            lblGoBackToDetails: "Go Back To Location Details",
            lblNoActiveLocations: "This location is not active for this Practice.",
            lblSearchNotFound: "This location is not active for Jurisdictional.  Choose a different service."
        };

        ///////////////////////////////////////////
        //// KEYBOARD EVENT HANDLES
        ko.bindingHandlers.enterKey = {
            init: function (element, valueAccessor, allBindings, vm) {
                ko.utils.registerEventHandler(element, "keyup", function (event) {
                    if (event.keyCode === 13) {
                        ko.utils.triggerEvent(element, "change");
                        valueAccessor().call(vm, vm);
                    }
                    return true;
                });
            }
        };


        ///////////////////////////////////////////
        //// VIEWMODELS
        var viewFindCriteria_LocationDetails = {
            findCriteria: ko.observable()
        };
        var view_LocationDetails = {
            //// DECLARATIONS
            index: 0,
            enablePrev: ko.observable(true),
            enableNext: ko.observable(true),
            enableFilePrev: ko.observable(true),
            enableFileNext: ko.observable(true),
            enableButtons: ko.observable(true),
            //enableImport: ko.observable(false),
            //enableCloseCancelContinue: ko.observable(true),
            messageError: ko.observable(),
            messageWarning: ko.observable(),
            messageNotice: ko.observable(),
            //messageImport: ko.observable("Results..."),
            messageNoActiveLocation: ko.observable(""),
            fileDirection: ko.observable(""),
            findEngaged: ko.observable(true),
            stateListingLoadOneRecord: true,   // THIS WILL ONLY WORK WITH TWO STATE SERVER SIDE LOAD LOGIC
            stateDetailsLoadOneRecord: true,  // THIS WILL ONLY WORK WITH TWO STATE SERVER SIDE LOAD LOGIC
            stateOnlyOneDetailRecordLoaded: true,
            stateLoadError: false,
            stateOnlyLoadDetails: false,
            pageRequestedFrom: getQueryVariable("req"),

            //// COLLECTIONS / OBJECTS
            //// CHANGE THE NAME OF THE ES.OBJECTS PROTOTYPE
            gSafeGuid: getGSafeGUID(), //getQueryVariable('sid'),
            clientFeatures: ko.observable(),
            collViolations: new es.objects.ViewCCLocationOpenViolationCountJurisCollection(),
            collListing: new es.objects.ViewCCLocationListingJurisCollection(),
            objFind: ko.observable(),
            objListing: ko.observable(),
            objViolations: ko.observable(),
            objLanguageLabels: ko.observable(dsLanguageLabels),

            //// CHECKBOXES
            chkLoadCOPE: ko.observable(true),
            chkLoadNatHazDataInfo: ko.observable(true),
            chkLoadNatHazModelData: ko.observable(true),
            chkLoadRecInfo: ko.observable(true),
            chkLoadRatingInfo: ko.observable(true),
            chkLoadRetailInfo: ko.observable(true),

            //// MISC
            txtRecordNumber: ko.observable(),
            txtFileRecordNumber: ko.observable(),
            txtSchedulingComments: ko.observable(),
            //            txtCloseCancelContinue: ko.observable("Cancel"),
            //            //uploadProgress: ko.observable(),
            loading: ko.observable(false),

            //// BUTTONS FOR RECORD NAVIGATION
            onNext: function () {
                if (view_LocationDetails.stateOnlyOneDetailRecordLoaded) {
                    view_LocationDetails.loadDetailsOnly();
                }
                if (view_LocationDetails.index < view_LocationDetails.collViolations().length - 1) {
                    view_LocationDetails.index++;
                    view_LocationDetails.objViolations(view_LocationDetails.collViolations()[view_LocationDetails.index]);
                }
                view_LocationDetails.setupButtons();
                view_LocationDetails.resetPickers();
            },

            onPrevious: function () {
                if (view_LocationDetails.index > 0) {
                    view_LocationDetails.index--;
                    view_LocationDetails.objViolations(view_LocationDetails.collViolations()[view_LocationDetails.index]);
                }
                view_LocationDetails.setupButtons();
                view_LocationDetails.resetPickers();
            },

            onFirst: function () {
                if (view_LocationDetails.index > 0) {
                    view_LocationDetails.index = 0;
                    view_LocationDetails.objViolations(view_LocationDetails.collViolations()[view_LocationDetails.index]);
                }
                view_LocationDetails.setupButtons();
                view_LocationDetails.resetPickers();
            },

            onLast: function () {
                if (view_LocationDetails.stateOnlyOneDetailRecordLoaded) {
                    view_LocationDetails.loadDetailsOnly();
                }
                if (view_LocationDetails.index < view_LocationDetails.collViolations().length - 1) {
                    view_LocationDetails.index = view_LocationDetails.collViolations().length - 1;
                    view_LocationDetails.objViolations(view_LocationDetails.collViolations()[view_LocationDetails.index]);
                }
                view_LocationDetails.setupButtons();
                view_LocationDetails.resetPickers();
            },

            //// BUTTONS FOR FILE NUMBER / LOCATION WALK
            onFileFirst: function () {
                view_LocationDetails.fileDirection("first");
                view_LocationDetails.index = 0;
                view_LocationDetails.stateDetailsLoadOneRecord = true;
                view_LocationDetails.loadOneFileNumber(); //view_LocationDetails.loadFileNumber();
                view_LocationDetails.fileDirection("");
                view_LocationDetails.resetPickers();
            },

            onFilePrevious: function () {
                view_LocationDetails.fileDirection("previous");
                view_LocationDetails.index = 0;
                view_LocationDetails.stateDetailsLoadOneRecord = true;
                view_LocationDetails.loadOneFileNumber(); //view_LocationDetails.loadFileNumber();
                view_LocationDetails.fileDirection("");
                view_LocationDetails.resetPickers();
            },

            onFileNext: function () {
                view_LocationDetails.fileDirection("next");
                view_LocationDetails.index = 0;
                view_LocationDetails.stateDetailsLoadOneRecord = true;
                view_LocationDetails.loadOneFileNumber(); //view_LocationDetails.loadFileNumber();
                view_LocationDetails.fileDirection("");
                view_LocationDetails.resetPickers();
            },

            onFileLast: function () {
                view_LocationDetails.fileDirection("last");
                view_LocationDetails.index = 0;
                view_LocationDetails.stateDetailsLoadOneRecord = true;
                view_LocationDetails.loadOneFileNumber(); //view_LocationDetails.loadFileNumber();
                view_LocationDetails.fileDirection("");
                view_LocationDetails.resetPickers();
            },

            //// FIND A RECORD FROM THE LOCATION FIELDS
            onFind: function () {
                //// SET THE GSAFE
                setFindLocationFields(view_LocationDetails.gSafeGuid, view_LocationDetails.objFind(), view_LocationDetails.objListing(), true);
                //// LOOKUP RECORD USING THE ON FIRST NAVIGATE
                view_LocationDetails.onFileFirst();
                view_LocationDetails.resetPickers();
            },

            onFindClear: function () {
                //// CLEAR THE OBJECT
                view_LocationDetails.resetPickers();
                //// SET THE GSAFE
                setFindLocationFields(view_LocationDetails.gSafeGuid, view_LocationDetails.objFind(), view_LocationDetails.objListing(), true);
                //// RELOAD THE FILE NUMBER TO GET THE CORRECT LOCATION COUNT
                view_LocationDetails.onFileFirst();
                view_LocationDetails.resetPickers();
            },

            onLocationDetailsRedirect: function () {
                //// REDIRECT THE USER TO THE LOCATION DETAILS PAGE
                document.location.href = "locationdetails.aspx" + "?sid=" + view_LocationDetails.gSafeGuid;
            },

            onBuildLink: function (fileName) {
                buildFileOpenLink(fileName, view_LocationDetails.gSafeGuid, "", "", false);
            },

            //            onAdminClick: function () {
            //                windowAdmin.data("kendoWindow").open();
            //                $("#windowAdmin").css("display", "block");
            //            },

            //            onCheckBox: function () {
            //                if (!view_LocationDetails.chkLoadCOPE() && !view_LocationDetails.chkLoadRecInfo() && !view_LocationDetails.chkLoadRatingInfo() && !view_LocationDetails.chkLoadRetailInfo() && !view_LocationDetails.chkLoadNatHazDataInfo() && !view_LocationDetails.chkLoadNatHazModelData()) {
            //                    view_LocationDetails.enableImport(false);
            //                } else {
            //                    if ($(".k-widget.k-upload").find("ul").length > 0) {
            //                        view_LocationDetails.enableImport(true);
            //                    }
            //                }
            //                return true;
            //            },

            //            onSelectNone: function () {
            //                view_LocationDetails.chkLoadCOPE(false);
            //                view_LocationDetails.chkLoadNatHazDataInfo(false);
            //                view_LocationDetails.chkLoadNatHazModelData(false);
            //                view_LocationDetails.chkLoadRecInfo(false);
            //                view_LocationDetails.chkLoadRatingInfo(false);
            //                view_LocationDetails.chkLoadRetailInfo(false);
            //                view_LocationDetails.enableImport(false);
            //            },

            //            onSelectAll: function () {
            //                view_LocationDetails.chkLoadCOPE(true);
            //                view_LocationDetails.chkLoadNatHazDataInfo(true);
            //                view_LocationDetails.chkLoadNatHazModelData(true);
            //                view_LocationDetails.chkLoadRecInfo(true);
            //                view_LocationDetails.chkLoadRatingInfo(true);
            //                view_LocationDetails.chkLoadRetailInfo(true);
            //                if ($(".k-widget.k-upload").find("ul").length > 0) {
            //                    view_LocationDetails.enableImport(true);
            //                }
            //            },

            //            onSelect: function (e) {
            //                //// CLEAR OUT PREVIOUS MESSAGE
            //                view_LocationDetails.messageImport("Results...");

            //                //// CREATE CLICK EVENT FOR IMPORT BUTTON AND REMOVE CANNED UPLOAD BUTTON
            //                $("#btnImport").click(function (event) {
            //                    view_LocationDetails.messageImport(view_LocationDetails.objLanguageLabels().lblLoading);
            //                    view_LocationDetails.enableImport(false);
            //                    view_LocationDetails.enableCloseCancelContinue(false);
            //                    $(document).find(".k-upload-selected").trigger("click");
            //                });

            //                //// ENABLE BUTTONS
            //                view_LocationDetails.enableImport(true);

            //                //// VALIDATION ON CHECKBOXES
            //                if (!view_LocationDetails.chkLoadCOPE() && !view_LocationDetails.chkLoadRecInfo() && !view_LocationDetails.chkLoadRatingInfo() && !view_LocationDetails.chkLoadRetailInfo() && !view_LocationDetails.chkLoadNatHazDataInfo() && !view_LocationDetails.chkLoadNatHazModelData()) {
            //                    view_LocationDetails.messageImport(view_LocationDetails.objLanguageLabels().lblNoCheckboxesSelected);
            //                    view_LocationDetails.enableCloseCancelContinue(true);
            //                    view_LocationDetails.enableImport(false);
            //                }

            //                //// VALIDATION ON FILE EXTENSION
            //                if (e.files[0].extension != ".csv" && e.files[0].extension != ".xls" && e.files[0].extension != ".xlsx") {
            //                    view_LocationDetails.messageImport(view_LocationDetails.objLanguageLabels().lblIncorrectFileFormat);
            //                    view_LocationDetails.enableCloseCancelContinue(true);
            //                    view_LocationDetails.enableImport(false);
            //                    e.preventDefault();
            //                }
            //            },

            //            onProgress: function (e) {
            //                view_LocationDetails.uploadProgress(e.percentComplete);
            //            },

            //            onUpload: function (e) {
            //                //// BUILD UPLOAD
            //                var tempMsg = "";
            //                var tempImportSheet = "";
            //                var tempFileList = "";

            //                //// BUILD A STRING OF FILE NAMES
            //                for (x = 0; e.files.length > x; x++) {
            //                    tempFileList += e.files[x].name + ":";
            //                }
            //                if (tempFileList.length > 0) {
            //                    tempMsg += tempFileList.substring(0, tempFileList.length - 1) + "|";
            //                }

            //                //// BUILD A STRING OF IMPORT SHEETS
            //                //// ENUM DATA FROM IMPORT ENGINE
            //                // CopeData             = 0
            //                // RecTracking          = 1
            //                // RatingForm           = 2
            //                // RetailData           = 3
            //                // NatHazData           = 4
            //                // NatHazModelingData   = 5
            //                // FacilityData         = 6

            //                if (view_LocationDetails.chkLoadCOPE()) { tempImportSheet += "0:"; }
            //                if (view_LocationDetails.chkLoadRecInfo()) { tempImportSheet += "1:"; }
            //                if (view_LocationDetails.chkLoadRatingInfo()) { tempImportSheet += "2:"; }
            //                if (view_LocationDetails.chkLoadRetailInfo()) { tempImportSheet += "3:"; }
            //                if (view_LocationDetails.chkLoadNatHazDataInfo()) { tempImportSheet += "4:"; }
            //                if (view_LocationDetails.chkLoadNatHazModelData()) { tempImportSheet += "5:"; }
            //                if (tempImportSheet.length > 0) {
            //                    tempMsg += tempImportSheet.substring(0, tempImportSheet.length - 1);
            //                }

            //                //// PASS THE STRINGS TO THE SERVER
            //                e.data = {
            //                    ImportFileList: tempFileList.substring(0, tempFileList.length - 1),
            //                    ImportSheet: tempImportSheet.substring(0, tempImportSheet.length - 1),
            //                    ImportStrings: tempMsg
            //                };
            //            },

            //            onSuccess: function (e) {
            //                if (e.response == undefined || e.response.result == "") {
            //                    view_LocationDetails.messageImport("File(s) uploaded successfully.");
            //                } else {
            //                    view_LocationDetails.messageImport(e.response.result);
            //                }
            //                if (e.response != undefined && e.response.closeImport.toUpperCase() == "TRUE") { // VB RETURNS UPPER CASE FIRST LETTER
            //                    view_LocationDetails.txtCloseCancelContinue(view_LocationDetails.objLanguageLabels().lblClose);
            //                } else if (e.response != undefined && e.response.continueImport.toUpperCase() == "TRUE") {
            //                    view_LocationDetails.txtCloseCancelContinue(view_LocationDetails.objLanguageLabels().lblContinue);
            //                }
            //                view_LocationDetails.enableImport(false);
            //                view_LocationDetails.enableCloseCancelContinue(true);
            //                $(".k-widget.k-upload").find("ul").remove();
            //            },

            //            onError: function (e) {
            //                if (e.response == undefined || e.response.result == "") {
            //                    view_LocationDetails.messageImport("An unknown error occured while uploading your file(s).");
            //                } else {
            //                    view_LocationDetails.messageImport(e.response.result);
            //                }
            //                view_LocationDetails.enableImport(false);
            //                view_LocationDetails.enableCloseCancelContinue(true);
            //                view_LocationDetails.txtCloseCancelContinue(view_LocationDetails.objLanguageLabels().lblCancel);
            //                $(".k-widget.k-upload").find("ul").remove();
            //            },

            //            onCancel: function () {
            //                view_LocationDetails.enableImport(false);
            //                view_LocationDetails.enableCloseCancelContinue(true);
            //            },

            //            onCloseCancelContinue: function () {
            //                if (view_LocationDetails.txtCloseCancelContinue() == view_LocationDetails.objLanguageLabels().lblCancel || view_LocationDetails.txtCloseCancelContinue() == view_LocationDetails.objLanguageLabels().lblClose) {
            //                    $(".k-widget.k-upload").find("ul").remove();
            //                    view_LocationDetails.enableImport(false);
            //                    windowAdmin.data("kendoWindow").close();
            //                } else {
            //                    $(".k-widget.k-upload").find("ul").remove();
            //                    view_LocationDetails.enableImport(false);
            //                    var tab = windowAdminTabStrip.select();
            //                    var nextTab = tab.next();
            //                    windowAdminTabStrip.select(nextTab);
            //                }
            //            },

            //// ENABLE OR DISABLE BUTTONS AND SHOW RECORD NUMBER
            setupButtons: function () {
                if (view_LocationDetails.index == 0) { view_LocationDetails.enablePrev(false); } else { view_LocationDetails.enablePrev(true); }
                if (view_LocationDetails.index == view_LocationDetails.collViolations().length - 1) { view_LocationDetails.enableNext(false); } else { view_LocationDetails.enableNext(true); }
                if (view_LocationDetails.stateOnlyOneDetailRecordLoaded == true) { view_LocationDetails.enableNext(true); }
                if (view_LocationDetails.stateOnlyOneDetailRecordLoaded) {
                    view_LocationDetails.txtRecordNumber("1...");
                } else {
                    view_LocationDetails.txtRecordNumber((view_LocationDetails.index + 1) + " of " + view_LocationDetails.collViolations().length);
                }
            },

            setupFileButtons: function () {
                if (view_LocationDetails.objListing().RecNum() <= 1) {
                    view_LocationDetails.enableFilePrev(false);
                    $('#btnFileFirst').addClass('grcBlueDisabledBtn');
                    $('#btnFilePrevious').addClass('grcBlueDisabledBtn');
                } else {
                    view_LocationDetails.enableFilePrev(true);
                    $('#btnFileFirst').removeClass('grcBlueDisabledBtn');
                    $('#btnFilePrevious').removeClass('grcBlueDisabledBtn');
                }
                if (view_LocationDetails.objListing().RecNum() >= view_LocationDetails.objListing().RecCount()) {
                    view_LocationDetails.enableFileNext(false);
                    $('#btnFileNext').addClass('grcBlueDisabledBtn');
                    $('#btnFileLast').addClass('grcBlueDisabledBtn');
                } else {
                    view_LocationDetails.enableFileNext(true);
                    $('#btnFileNext').removeClass('grcBlueDisabledBtn');
                    $('#btnFileLast').removeClass('grcBlueDisabledBtn');
                }
                if (view_LocationDetails.objListing().RecCount() <= 1) {
                    view_LocationDetails.enableFilePrev(false);
                    view_LocationDetails.enableFilePrev(false);
                    $('#btnFileFirst').addClass('grcBlueDisabledBtn');
                    $('#btnFilePrevious').addClass('grcBlueDisabledBtn');
                }
                view_LocationDetails.txtFileRecordNumber(view_LocationDetails.objListing().RecNum() + " of " + view_LocationDetails.objListing().RecCount());
            },

            //// SETUP FIND FIELDS FOR LOCATIONS
            setupFindFields: function () {
                //// FIND TEXT BOXES
                view_LocationDetails.objFind().findFileNo = view_LocationDetails.objListing().FileNo();
                view_LocationDetails.objFind().findClientlocno = view_LocationDetails.objListing().Clientlocno();
                view_LocationDetails.objFind().findAddress1 = view_LocationDetails.objListing().Address1();
                view_LocationDetails.objFind().findCity = view_LocationDetails.objListing().City();
                view_LocationDetails.objFind().findStprov = view_LocationDetails.objListing().Stprov();
                view_LocationDetails.objFind().findCountry = view_LocationDetails.objListing().Country();
                view_LocationDetails.objFind().findZip = view_LocationDetails.objListing().Zip();
                view_LocationDetails.objFind().findDivision = view_LocationDetails.objListing().Division();
                view_LocationDetails.objFind().findFacility = view_LocationDetails.objListing().Facility();
                view_LocationDetails.objFind().findCustomAccess = view_LocationDetails.objListing().CustomAccess();
                view_LocationDetails.objFind().findLatitude = view_LocationDetails.objListing().Latitude();
                view_LocationDetails.objFind().findLongitude = view_LocationDetails.objListing().Longitude();
            },

            //// RESET FIELDS ON LOAD RECORD
            resetPickers: function () {
                //// CLEAR THE FIELDS OF ALL DATA
                //view_LocationDetails.clearAddressFields();
                view_LocationDetails.clearPickers(true);

                //// SET GLOBAL VARS
                global_PracticeCode = 560;
                global_EnableAdminWindow = true;

                //// COPY THE FIND FIELDS
                view_LocationDetails.setupFindFields();

                //// RESET THE COUNT FIELD
                CountOpen.value(view_LocationDetails.objViolations().CountOpen());

                //// DISPLAY WINDOW IF NO RECORD EXISTS OR A MESSAGE IF NO SEARCH FOUND
                windowNoLocation.data("kendoWindow").close();
                view_LocationDetails.messageError("");
                view_LocationDetails.messageNoActiveLocation("");
                if ((view_LocationDetails.objViolations().Fileno() == "Not Found" && view_LocationDetails.pageRequestedFrom == "topnav") || (view_LocationDetails.objListing().FileNo() == "Not Found" && view_LocationDetails.pageRequestedFrom == "topnav")) {
                    view_LocationDetails.messageNoActiveLocation(view_LocationDetails.objLanguageLabels().lblNoActiveLocations);
                    view_LocationDetails.clearPickers();
                    view_LocationDetails.clearAddressFields();
                    global_EnableAdminWindow = false;
                } else if (view_LocationDetails.objViolations().Fileno() == "Not Found") {
                    windowNoLocation.data("kendoWindow").center().open();
                    $("#windowNoLocation").css("display", "block");
                    view_LocationDetails.clearPickers();
                    global_EnableAdminWindow = false;
                } else if (view_LocationDetails.objListing().FileNo() == "Not Found") {
                    view_LocationDetails.messageError(view_LocationDetails.objLanguageLabels().lblSearchNotFound);
                    view_LocationDetails.clearPickers();
                    global_EnableAdminWindow = false;
                }

                //// ALWAYS CLEAR THE REQUESTING VARIABLE FOR USE OF CLIENT SIDE BUTTON NAVIGATION
                view_LocationDetails.pageRequestedFrom = "";
            },

            clearAddressFields: function () {
                $("#FileNo").val("");
                $("#Clientlocno").val("");
                $("#Latitude").val("");
                $("#Longitude").val("");
                $("#Address1").val("");
                $("#Division").val("");
                $("#City").val("");
                $("#Stprov").val("");
                $("#Country").val("");
                $("#Zip").val("");
                $("#Facility").val("");
                $("#CustomAccess").val("");
                $("#txtFileRecordNumber").val("");
            },

            clearPickers: function (pIsIgnoreTextFields) {
                //// KENDO WIDGETS
                CountOpen.value("");
            },

            //// LOAD ONLY THE LOWER DETAILS, ONE OR ALL DEPENDING ON STATE
            loadDetailsOnly: function () {
                view_LocationDetails.stateLoadError = false;

                var tempParm = view_LocationDetails.gSafeGuid;
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (view_LocationDetails.stateDetailsLoadOneRecord == true && view_LocationDetails.stateLoadError == false) {
                    if (!view_LocationDetails.collViolations.ViewCCLocationOpenViolationCountJurisCollections(tempParm + "|one")) { view_LocationDetails.stateLoadError = false } else { view_LocationDetails.stateLoadError = true }
                    view_LocationDetails.stateDetailsLoadOneRecord = false;
                    view_LocationDetails.stateOnlyOneDetailRecordLoaded = true;
                } else {
                    if (!view_LocationDetails.collViolations.ViewCCLocationOpenViolationCountJurisCollections(tempParm + "|all")) { view_LocationDetails.stateLoadError = false } else { view_LocationDetails.stateLoadError = true }
                    view_LocationDetails.stateDetailsLoadOneRecord = false;
                    view_LocationDetails.stateOnlyOneDetailRecordLoaded = false;
                }
                if (!view_LocationDetails.stateLoadError) {
                    view_LocationDetails.objViolations(view_LocationDetails.collViolations()[view_LocationDetails.index]);
                } else {
                    //// DISPLAY ERROR MESSAGE
                    view_LocationDetails.messageError("* Error while loading record.");
                }
            },

            //// LOAD ONE FILE NUMBER AND ONE DETAIL
            loadOneFileNumber: function () {
                view_LocationDetails.stateLoadError = false;

                var tempParm = view_LocationDetails.gSafeGuid + "|" + view_LocationDetails.fileDirection() + "|one";
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view_LocationDetails.collListing.ViewCCLocationJurisCollections(tempParm)) { view_LocationDetails.stateLoadError = false } else { view_LocationDetails.stateLoadError = true }
                view_LocationDetails.stateListingLoadOneRecord = false;

                tempParm = view_LocationDetails.gSafeGuid + "|one";
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view_LocationDetails.collViolations.ViewCCLocationOpenViolationCountJurisCollections(tempParm)) { view_LocationDetails.stateLoadError = false } else { view_LocationDetails.stateLoadError = true }
                view_LocationDetails.stateDetailsLoadOneRecord = false;
                view_LocationDetails.stateOnlyOneDetailRecordLoaded = true;

                view_LocationDetails.objListing(view_LocationDetails.collListing()[0]);
                view_LocationDetails.objViolations(view_LocationDetails.collViolations()[0]);
                view_LocationDetails.objFind(getFindLocationFields(view_LocationDetails.gSafeGuid));
                if (view_LocationDetails.objFind().findCriteria == undefined || view_LocationDetails.objFind().findCriteria == "") {
                    viewFindCriteria_LocationDetails.findCriteria(" ");
                    view_LocationDetails.findEngaged(true);
                } else {
                    viewFindCriteria_LocationDetails.findCriteria(view_LocationDetails.objFind().findCriteria);
                    view_LocationDetails.findEngaged(false);
                }
                view_LocationDetails.setupButtons();
                view_LocationDetails.setupFileButtons();
            },

            //// LOAD RECORDS
            loadFileNumber: function () {
                view_LocationDetails.stateLoadError = false;

                //// LOAD THE LOACATION LISTINGS, ONE OR ALL, WITH FILE DIRECTION
                var tempParm = view_LocationDetails.gSafeGuid + "|" + view_LocationDetails.fileDirection() + "|one";
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view_LocationDetails.collListing.ViewCCLocationJurisCollections(tempParm)) { view_LocationDetails.stateLoadError = false } else { view_LocationDetails.stateLoadError = true }
                view_LocationDetails.stateListingLoadOneRecord = false;

                //// LOAD ALL DETAILS
                tempParm = view_LocationDetails.gSafeGuid + "|all";
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view_LocationDetails.collViolations.ViewCCLocationOpenViolationCountJurisCollections(tempParm)) { view_LocationDetails.stateLoadError = false } else { view_LocationDetails.stateLoadError = true }
                view_LocationDetails.stateDetailsLoadOneRecord = false;
                view_LocationDetails.stateOnlyOneDetailRecordLoaded = false;

                //// DO THE REMAINING CODE TO POPUPLATE THE PAGE
                if (!view_LocationDetails.stateLoadError) {
                    view_LocationDetails.objListing(view_LocationDetails.collListing()[0]);
                    view_LocationDetails.objViolations(view_LocationDetails.collViolations()[view_LocationDetails.index]);
                    view_LocationDetails.clientFeatures(getClientFeatures(view_LocationDetails.gSafeGuid));
                    view_LocationDetails.objFind(getFindLocationFields(view_LocationDetails.gSafeGuid));
                    view_LocationDetails.setupButtons();
                    view_LocationDetails.setupFileButtons();
                    if (view_LocationDetails.objFind().findCriteria == undefined || view_LocationDetails.objFind().findCriteria == "") {
                        viewFindCriteria_LocationDetails.findCriteria(" ");
                        view_LocationDetails.findEngaged(true);
                    } else {
                        viewFindCriteria_LocationDetails.findCriteria(view_LocationDetails.objFind().findCriteria);
                        view_LocationDetails.findEngaged(false);
                    }
                } else {
                    //// DISPLAY ERROR MESSAGE
                    view_LocationDetails.messageError("* Error while loading record.");
                }
            }
        };


        ///////////////////////////////////////////
        //// SETUP BASE URL FOR DATA SERVICE AND LOAD ALL DATA
        view_LocationDetails.loadFileNumber();


        ///////////////////////////////////////////
        //// ACTIVATE BINDINGS LAST
        ko.applyBindings(view_LocationDetails, $("#view_LocationDetails")[0]);
        ko.applyBindings(viewFindCriteria_LocationDetails, $("#viewFindCriteria_LocationDetails")[0]);


        ///////////////////////////////////////////
        //// SETUP KENDOUI
        //// TEXTBOXES

        //// ERROR WINDOW
        var windowNoLocation = $("#windowNoLocation");
        windowNoLocation.kendoWindow({
            width: "300px",
            height: "200px",
            title: "", // title added below with JQuery
            actions: ["Close"],
            modal: true,
            animation: { open: { effects: "none" }, close: { effects: "default" } }
        });
        
        $("#windowNoLocation").prev().find(".k-window-title").append("<img src='../images/icons/warning/window_warning_24x24.png' align='left' alt='Warning Icon' class='windowIcon'/>  " + view_LocationDetails.objLanguageLabels().lblNoLocationFoundTitle);

        //// ADMIN WINDOW
        //        var windowAdmin = $("#windowAdmin");
        //        windowAdmin.kendoWindow({
        //            width: "725px",
        //            height: "460px",
        //            title: "", // title added below with JQuery
        //            actions: false
        //        });
        //        $("#windowAdmin").closest(".k-window").css({
        //            top: 145,
        //            left: 215
        //        });
        //        $("#windowAdmin").prev().find(".k-window-title").append("<img src='../images/icons/admin/businesswoman_24x24.png' align='left' alt='Administration Window' class='windowIcon'/>  " + view_LocationDetails.objLanguageLabels().lblWindowAdminTitle);

        //        //// ADMIN TABSTRIP
        //        var windowAdminTabStrip = $("#windowAdminTabStrip").kendoTabStrip({
        //            //select: onSelect,
        //            //activate: onActivate,
        //            animation: { open: { effects: "fadeIn"} }
        //        }).data("kendoTabStrip");
        //        windowAdminTabStrip.select(0);

        //        //// IMPORT UPLOADER
        //        var windowAdminUpload = $("#windowAdminUpload").kendoUpload({
        //            async: {
        //                saveUrl: "../Imports/ImportTest.aspx",
        //                autoUpload: false
        //            },
        //            localization: {
        //                select: "Select Files...",
        //                uploadSelectedFiles: "Start Import"
        //            },
        //            //complete: view_LocationDetails.onComplete,
        //            remove: view_LocationDetails.onCancel,
        //            cancel: view_LocationDetails.onCancel,
        //            select: view_LocationDetails.onSelect,
        //            progress: view_LocationDetails.onProgress,
        //            success: view_LocationDetails.onSuccess,
        //            error: view_LocationDetails.onError,
        //            upload: view_LocationDetails.onUpload
        //        }).data("kendoUpload");

        //// most plain text inputs do not need bound in JS but need kendo widgets for styles
        //        $("#FileNo").kendoAutoComplete();
        //        $("#Clientlocno").kendoAutoComplete();
        //        $("#Latitude").kendoAutoComplete();
        //        $("#Longitude").kendoAutoComplete();
        //        $("#Address1").kendoAutoComplete();
        //        $("#Division").kendoAutoComplete();
        //        $("#City").kendoAutoComplete();
        //        $("#Stprov").kendoAutoComplete();
        //        $("#Facility").kendoAutoComplete();
        //        $("#Country").kendoAutoComplete();
        //        $("#Zip").kendoAutoComplete();
        //        $("#CustomAccess").kendoAutoComplete();
        //        $("#txtRecordNumber").kendoAutoComplete();

        //// NUMERIC TEXTBOXES
        var CountOpen = $("#CountOpen").kendoNumericTextBox({
            value: view_LocationDetails.objViolations().CountOpen(),
            format: "#",
            decimals: 0
        }).data("kendoNumericTextBox");
        CountOpen.wrapper
            .find(".k-numeric-wrap").addClass("expand-padding").css("height", "13px").find(".k-select").hide();

        //// WHEN ALL DONE CALL THE RESET TO SYNC THE FIND AND THE PICKERS
        view_LocationDetails.setupFindFields();
        view_LocationDetails.resetPickers();


        //// A GLOBAL REFRESH FOR THE ADMIN WINDOW
        window.refreshPage = function () {
            view_LocationDetails.fileDirection("");
            view_LocationDetails.loadOneFileNumber();
            view_LocationDetails.resetPickers();
        }

    });
</script>

    </form>
</body>
</html>
