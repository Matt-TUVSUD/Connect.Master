<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="tab_recdatasheetfeaturesX.aspx.vb" Inherits="GRC.Connect.Web.tab_recdatasheetfeaturesX_fire" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-grid.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/rectracking.css" />
    <script src="../../Lib_{{VER}}/Generated/ViewCCLocationListingFire.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCLocationListingFire.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCFireRecommendationGrid.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCFireRecommendationGrid.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="headerFindCriteria" id="viewFindCriteria_RecDatasheet" data-bind="with: viewFindCriteria_RecDatasheet">
        <label data-bind="text: $parent.findCriteria" id="findCriteria"></label>&nbsp;
    </div>
    <div id="view_RecDatasheet" data-bind="with: view_RecDatasheet">
        <!-- TABLE FOR COMPANY / ADDRESS INFORMATION -->
        <!-- SPECIFIC STYLES TO ROWS OR COLUMNS SHOULD BE INLINE -->
        <div class="tableDiv">
            <div class="tabRow">
                <span class="companyLabels1"><label data-bind="text: $parent.objLanguageLabels().lblGRCLocNo, css: { findOn: $parent.objFind().findFileNo, findOff: !$parent.objFind().findFileNo }">GRC Loc. No.</label></span>
                <span class="companyInputs1"><input data-bind="value: $parent.objListing().FileNo, css: { findOnInput: $parent.objFind().findFileNo, findOffInput: !$parent.objFind().findFileNo }" id="FileNo" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs1" tabindex="1" /></span>
                <span class="companyLabels2"><label data-bind="text: $parent.objLanguageLabels().lblClientLocNo, css: { findOn: $parent.objFind().findClientLocNo, findOff: !$parent.objFind().findClientLocNo }">Client Loc. No.</label></span>
                <span class="companyInputs2"><input data-bind="value: $parent.objListing().ClientLocNo, css: { findOnInput: $parent.objFind().findClientLocNo, findOffInput: !$parent.objFind().findClientLocNo }" id="ClientLocNo" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs2" tabindex="2" /></span>
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
                <span class="stateLabels"><label data-bind="text: $parent.objLanguageLabels().lblState, css: { findOn: $parent.objFind().findStProv, findOff: !$parent.objFind().findStProv }">State</label></span>
                <span class="stateInputs"><input data-bind="value: $parent.objListing().StProv, css: { findOnInput: $parent.objFind().findStProv, findOffInput: !$parent.objFind().findStProv }" id="StProv" class="k-autocomplete k-input inputNoEdit inputLeft stateInputs" tabindex="8"  /></span>
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
                    <span><button data-bind="click: $parent.onFileFirst, enable: $parent.enableFilePrev" type="button" class="grcBlueBtn pagerBtn" id="btnFileFirst" tabindex="15"><i class="fas fa-step-backward"></i></button></span>
                    <span><button data-bind="click: $parent.onFilePrevious, enable: $parent.enableFilePrev" type="button" class="grcBlueBtn pagerBtn" id="btnFilePrevious" tabindex="16"><i class="fas fa-caret-left"></i><</button></span>
                    <span class="buttonFileRecordLabel" style="width: 130px;">&nbsp;<label data-bind="text: $parent.objLanguageLabels().lblFileRecord">Location</label> <input data-bind="value: $parent.txtFileRecordNumber" id="txtFileRecordNumber" class="k-autocomplete k-input inputCenter inputNoEdit buttonInput" style="width: 80px; margin-bottom: 3px;" readonly="true" />&nbsp;</span>
                    <span><button data-bind="click: $parent.onFileNext, enable: $parent.enableFileNext" type="button" class="grcBlueBtn pagerBtn" id="btnFileNext" tabindex="17"><i class="fas fa-caret-right"></i></button></span>
                    <span><button data-bind="click: $parent.onFileLast, enable: $parent.enableFileNext" type="button" class="grcBlueBtn pagerBtn" id="btnFileLast" tabindex="18"><i class="fas fa-step-forward"></i></button></span>
                    <span>&nbsp;</span>
                    <span><button data-bind="click: $parent.onFindClear, css: { hidden: $parent.findEngaged }" type="button" class="k-button buttonFindClearShape hidden" tabindex="13">Clear Find</button></span>
                    <span><button data-bind="click: $parent.onFind" class="grcBlueBtn findBtn" type="submit" tabindex="14">Find</button></span>
                </span>
                <!-- END BUTTONS FOR LOCATION / FILE NUMBER WALK / FIND LOCATION -->
                <span class="companyLabels6"><label data-bind="text: $parent.objLanguageLabels().lblCustomerAccess, css: { findOn: $parent.objFind().findCustomAccess, findOff: !$parent.objFind().findCustomAccess }">Custom Access</label></span>
                <span class="companyInputs5"><input data-bind="value: $parent.objListing().CustomAccess, css: { findOnInput: $parent.objFind().findCustomAccess, findOffInput: !$parent.objFind().findCustomAccess }" id="CustomAccess" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="12"  /></span>
            </div>
        </div>
        <!-- END TABLE FOR COMPANY / ADDRESS INFORMATION -->

        <!-- AREA FOR ERROR AND NOTICE MESSAGES -->
        <div style="padding-top: 20px;"><label class="messageError" data-bind="text: $parent.messageError"></label><label class="messageNotice" data-bind="text: $parent.messageNotice"></label><label class="messageWarning" data-bind="text: $parent.messageWarning"></label>&nbsp;</div>

        <!-- ERROR WINDOW FOR NO RECORD FOUND NOTIFICATION -->
        <div id="windowNoLocation" class="windowContent" style="font-size:13px;">
            <div><img src="../images/icons/warning/sign_warning_32x32.png" align="left" alt="Warning" class="windowImage" /></div>
            <div style="margin-bottom:5px;">
                <label data-bind="text: $parent.objLanguageLabels().lblNoLocationFoundMessage">Warning: There are no recommendation records found for this location.</label>
            </div>
            <div style="margin-bottom:5px;">
                <label data-bind="text: $parent.objLanguageLabels().lblNoLocationFoundDescription">Click the below button to go back to the Location Details page, or use the Location Navigation buttons to go to another location record.</label>
            </div>
            <div style="justify-content: center; width:100%; display:flex;">
                <button class="grcBlueBtn" style="padding: 6px;" data-bind="text: $parent.objLanguageLabels().lblGoBackToDetails, click: $parent.onLocationDetailsRedirect">Go Back To Location Details</button>
            </div>
        </div>

    </div>

    <!-- TABLE FOR RECOMMENDATION TRACKING INFORMATION -->
    <!-- THE GRID -->
    <div id="gridContainer" style="clear: both;">
        <div id="gridRecDatasheet" style="width: 810px; height: 325px;"></div>
        <div id="view2_RecDatasheet" data-bind="with: view_RecDatasheet" class="k-pager-wrap k-grid-pager" style="height: 22px; width: 806px;">
        </div>
    </div>

    <br />&nbsp;<br />

    <script type="text/javascript">
        $(document).ready(function () {
            ///////////////////////////////////////////
            //// LOAD SESSION VARIABLES
            var dsLanguageLabels = {
                //// COMPANY INFORMATION
                lblGRCLocNo: "GRC Loc. No.",
                lblClientLocNo: "Client Loc. No.",
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

                //// MISC
                lblEnterSelectedRecord: "Enter Selected Recommendation",
                lblRecord: "Record",
                lblFileRecord: "Location",
                lblNoLocationFoundTitle: "No Recommendations Found",
                lblNoLocationFoundMessage: "Warning: There are no recommendation records found for this location.",
                lblNoLocationFoundDescription: "Click the below button to go back to the Location Details page, or use the Location Navigation buttons to go to another location record.",
                lblGoBackToDetails: "Go Back To Location Details",
                lblSearchNotFound: "This location is not active for Fire.  Choose a different service."
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
            //// VIEWMODEL
            var viewFindCriteria_RecDatasheet = {
                findCriteria: ko.observable()
            };
            var view_RecDatasheet = {
                //// DECLARATIONS
                index: 0,
                enablePrev: ko.observable(true),
                enableNext: ko.observable(true),
                enableFilePrev: ko.observable(true),
                enableFileNext: ko.observable(true),
                messageError: ko.observable(),
                messageWarning: ko.observable(),
                messageNotice: ko.observable(),
                messageSave: ko.observable(),
                fileDirection: ko.observable(""),
                findEngaged: ko.observable(true),

                //// COLLECTIONS / OBJECTS
                //// CHANGE THE NAME OF THE ES.OBJECTS PROTOTYPE
                gSafeGuid: getQueryVariable('sid'),
                clientFeatures: ko.observable(),
                collRec: new es.objects.ViewCCFireRecommendationGridCollection(),
                collListing: new es.objects.ViewCCLocationListingFireCollection(),
                collGrid: ko.observableArray(),

                objRec: ko.observable(),
                objListing: ko.observable(),
                objLanguageLabels: ko.observable(dsLanguageLabels),
                objFind: ko.observable(),

                //// MISC
                txtRecordNumber: ko.observable(),
                txtFileRecordNumber: ko.observable(),
                txtSchedulingComments: ko.observable(),
                loading: ko.observable(false),

                //// BUTTONS FOR RECORD NAVIGATION
                onNext: function () {
                    if (view_RecDatasheet.index < view_RecDatasheet.collRec().length - 1) {
                        view_RecDatasheet.index++;
                        view_RecDatasheet.objRec(view_RecDatasheet.collRec()[view_RecDatasheet.index]);
                    }
                    view_RecDatasheet.setupButtons();
                    view_RecDatasheet.resetPickers();
                },

                onPrevious: function () {
                    if (view_RecDatasheet.index > 0) {
                        view_RecDatasheet.index--;
                        view_RecDatasheet.objRec(view_RecDatasheet.collRec()[view_RecDatasheet.index]);
                    }
                    view_RecDatasheet.setupButtons();
                    view_RecDatasheet.resetPickers();
                },

                onFirst: function () {
                    if (view_RecDatasheet.index > 0) {
                        view_RecDatasheet.index = 0;
                        view_RecDatasheet.objRec(view_RecDatasheet.collRec()[view_RecDatasheet.index]);
                    }
                    view_RecDatasheet.setupButtons();
                    view_RecDatasheet.resetPickers();
                },

                onLast: function () {
                    if (view_RecDatasheet.index < view_RecDatasheet.collRec().length - 1) {
                        view_RecDatasheet.index = view_RecDatasheet.collRec().length - 1;
                        view_RecDatasheet.objRec(view_RecDatasheet.collRec()[view_RecDatasheet.index]);
                    }
                    view_RecDatasheet.setupButtons();
                    view_RecDatasheet.resetPickers();
                },

                //// BUTTONS FOR FILE NUMBER / LOCATION WALK
                onFileFirst: function () {
                    view_RecDatasheet.fileDirection("first");
                    view_RecDatasheet.loadFileNumber();
                    view_RecDatasheet.fileDirection("");
                    view_RecDatasheet.resetPickers();
                },

                onFilePrevious: function () {
                    view_RecDatasheet.fileDirection("previous");
                    view_RecDatasheet.loadFileNumber();
                    view_RecDatasheet.fileDirection("");
                    view_RecDatasheet.resetPickers();
                },

                onFileNext: function () {
                    view_RecDatasheet.fileDirection("next");
                    view_RecDatasheet.loadFileNumber();
                    view_RecDatasheet.fileDirection("");
                    view_RecDatasheet.resetPickers();
                },

                onFileLast: function () {
                    view_RecDatasheet.fileDirection("last");
                    view_RecDatasheet.loadFileNumber();
                    view_RecDatasheet.fileDirection("");
                    view_RecDatasheet.resetPickers();
                },

                //// FIND A RECORD FROM THE LOCATION FIELDS
                onFind: function () {
                    //// SET THE GSAFE
                    setFindLocationFields(view_RecDatasheet.gSafeGuid, view_RecDatasheet.objFind(), view_RecDatasheet.objListing());
                    //// LOOKUP RECORD USING THE ON FIRST NAVIGATE
                    view_RecDatasheet.onFileFirst();
                    view_RecDatasheet.resetPickers();
                },

                onFindClear: function () {
                    //// CLEAR THE OBJECT
                    view_RecDatasheet.resetPickers();
                    //// SET THE GSAFE
                    setFindLocationFields(view_RecDatasheet.gSafeGuid, view_RecDatasheet.objFind(), view_RecDatasheet.objListing());
                    //// RELOAD THE FILE NUMBER TO GET THE CORRECT LOCATION COUNT
                    view_RecDatasheet.onFileFirst();
                    view_RecDatasheet.resetPickers();
                },

                onLocationDetailsRedirect: function () {
                    //// REDIRECT THE USER TO THE LOCATION DETAILS PAGE
                    document.location.href = "locationdetails.aspx" + "?sid=" + view_RecDatasheet.gSafeGuid;
                },

                onSelect: function () {
                },

                //// EXPORT TO A CSV
                onExport: function () {
                    //// BUILD THE DATA FROM THE GRID
                    gridRecDatasheet.saveChanges();
                    var gridXMLString = "";
                    var Header = "";
                    var Content = "";
                    var Footer = "";
                    if (view_RecDatasheet.clientFeatures().indexOf("Q") > -1) {
                        Header = buildXMLRecHeader_Features_XMgmt();
                        Content = buildXMLString_Features_XMgmt(gridRecDatasheet.dataSource._view, view_RecDatasheet.objListing());
                        Footer = buildXMLRecFooter();
                    } else {
                        Header = buildXMLRecHeader_Features_X();
                        Content = buildXMLString_Features_X(gridRecDatasheet.dataSource._view, view_RecDatasheet.objListing());
                        Footer = buildXMLRecFooter();
                    }
                    gridXMLString = Header + Content + Footer;

                    // REMOVE DANGEROUS CHARACTERS
                    gridXMLString = gridXMLString.replace(/(\r\n|\n|\r)/gm, " "); // REMOVE ALL LINE BRAKES
                    gridXMLString = gridXMLString.replace(/(\r\t|\t|\r)/gm, " "); // REMOVE ALL TABS
                    gridXMLString = gridXMLString.replace(/(\")/gm, "'"); // REPLACE ALL ESCAPED DOUBLE QUOTES WITH SINGLE QUOTES
                    gridXMLString = gridXMLString.replace(/(<)/gm, "||OPEN||"); // REPLACE ALL OPEN BRACKETS
                    gridXMLString = gridXMLString.replace(/(>)/gm, "||CLOSE||"); // REPLACE ALL CLOSING BRACKETS

                    //// CREATE A FORM DOM ELEMENT
                    var form = document.createElement("form");
                    form.setAttribute("id", "frmExport");
                    form.setAttribute("method", "post");
                    //form.setAttribute("target", "_blank");
                    form.setAttribute("action", "../Exports/RecommendationExport.ashx");
                    document.body.appendChild(form);

                    //// CREATE A HIDDEN INPUT DOM ELEMENT
                    var hiddenField = document.createElement("input");
                    hiddenField.setAttribute("type", "hidden");
                    hiddenField.setAttribute("id", "fldHidden");
                    hiddenField.setAttribute("name", "XMLData");
                    hiddenField.setAttribute("value", gridXMLString);
                    form.appendChild(hiddenField);

                    //// SUBMIT THE FORM AND DELETE IT SO IT CAN BE RUN AGAIN
                    form.submit();
                    form.removeChild(hiddenField);
                    document.body.removeChild(form);
                },

                //// ENABLE OR DISABLE BUTTONS AND SHOW RECORD NUMBER
                setupButtons: function () {
                    if (view_RecDatasheet.index == 0) { view_RecDatasheet.enablePrev(false); } else { view_RecDatasheet.enablePrev(true); }
                    if (view_RecDatasheet.index == view_RecDatasheet.collRec().length - 1) { view_RecDatasheet.enableNext(false); } else { view_RecDatasheet.enableNext(true); }
                    view_RecDatasheet.txtRecordNumber((view_RecDatasheet.index + 1) + " of " + view_RecDatasheet.collRec().length);
                },

                setupFileButtons: function () {
                    if (view_RecDatasheet.objListing().RecNum() <= 1) { view_RecDatasheet.enableFilePrev(false); } else { view_RecDatasheet.enableFilePrev(true); }
                    if (view_RecDatasheet.objListing().RecNum() >= view_RecDatasheet.objListing().RecCount()) { view_RecDatasheet.enableFileNext(false); } else { view_RecDatasheet.enableFileNext(true); }
                    if (view_RecDatasheet.objListing().RecCount() <= 1) { view_RecDatasheet.enableFilePrev(false); view_RecDatasheet.enableFilePrev(false); }
                    view_RecDatasheet.txtFileRecordNumber(view_RecDatasheet.objListing().RecNum() + " of " + view_RecDatasheet.objListing().RecCount());
                },

                //// SETUP FIND FIELDS FOR LOCATIONS
                setupFindFields: function () {
                    //// FIND TEXT BOXES
                    view_RecDatasheet.objFind().findFileNo = view_RecDatasheet.objListing().FileNo();
                    view_RecDatasheet.objFind().findClientLocNo = view_RecDatasheet.objListing().ClientLocNo();
                    view_RecDatasheet.objFind().findAddress1 = view_RecDatasheet.objListing().Address1();
                    view_RecDatasheet.objFind().findCity = view_RecDatasheet.objListing().City();
                    view_RecDatasheet.objFind().findStProv = view_RecDatasheet.objListing().StProv();
                    view_RecDatasheet.objFind().findCountry = view_RecDatasheet.objListing().Country();
                    view_RecDatasheet.objFind().findZip = view_RecDatasheet.objListing().Zip();
                    view_RecDatasheet.objFind().findDivision = view_RecDatasheet.objListing().Division();
                    view_RecDatasheet.objFind().findFacility = view_RecDatasheet.objListing().Facility();
                    view_RecDatasheet.objFind().findCustomAccess = view_RecDatasheet.objListing().CustomAccess();
                    view_RecDatasheet.objFind().findLatitude = view_RecDatasheet.objListing().Latitude();
                    view_RecDatasheet.objFind().findLongitude = view_RecDatasheet.objListing().Longitude();
                },

                //// RESET FIELDS ON LOAD RECORD
                resetPickers: function () {
                    //// COPY THE FIND FIELDS
                    view_RecDatasheet.setupFindFields();

                    //// REFRESH THE GRID
                    gridRecDatasheet.dataSource.data(view_RecDatasheet.collGrid());
                    gridRecDatasheet.dataSource.page(1);

                    //// DISPLAY WINDOW IF NO RECORD EXISTS OR A MESSAGE IF NO SEARCH FOUND
                    windowNoLocation.data("kendoWindow").close();
                    view_RecDatasheet.messageError("");
                    if (view_RecDatasheet.collRec()[0].FileNo() == "Not Found") { // There is no object because the grid uses a collection.  No window needed.
                        view_RecDatasheet.collGrid([]);
                        gridRecDatasheet.dataSource.data(view_RecDatasheet.collGrid());
                        //windowNoLocation.data("kendoWindow").open();
                        //$("#windowNoLocation").css("display", "block");
                    } else if (view_RecDatasheet.objListing().FileNo() == "Not Found") {
                        view_RecDatasheet.collGrid([]);
                        gridRecDatasheet.dataSource.data(view_RecDatasheet.collGrid());
                        view_RecDatasheet.messageError(view_RecDatasheet.objLanguageLabels().lblSearchNotFound);
                    }
                },

                //// BUILD THE DATASOURCE FOR THE GRID
                buildGrid: function () {
                    view_RecDatasheet.collGrid([]);
                    for (y = 0; y < view_RecDatasheet.collRec().length; y++) {
                        if (view_RecDatasheet.clientFeatures().indexOf("Q") > -1) {
                            if (view_RecDatasheet.collRec()[y].FileNo() == view_RecDatasheet.objListing().FileNo()) {
                                view_RecDatasheet.collGrid().push({
                                    Id: y,
                                    FileNo: view_RecDatasheet.collRec()[y].FileNo(),
                                    RecYear: view_RecDatasheet.collRec()[y].RecYear(),
                                    RecMo: view_RecDatasheet.collRec()[y].RecMo(),
                                    RecNumber: view_RecDatasheet.collRec()[y].RecNumber(),
                                    RecSubLetter: view_RecDatasheet.collRec()[y].RecSubLetter(),
                                    RecStatus: view_RecDatasheet.collRec()[y].RecStatus(),
                                    StatusDate: view_RecDatasheet.collRec()[y].StatusDate(),
                                    RecCode: view_RecDatasheet.collRec()[y].RecCode(),
                                    RecImpact: view_RecDatasheet.collRec()[y].RecImpact(),
                                    Hazard: view_RecDatasheet.collRec()[y].Hazard(),
                                    PrimaryRecType: view_RecDatasheet.collRec()[y].PrimaryRecType(),
                                    SecondaryRecType: view_RecDatasheet.collRec()[y].SecondaryRecType(),
                                    RecKeywords: view_RecDatasheet.collRec()[y].RecKeywords(),
                                    CurrentLEActual: view_RecDatasheet.collRec()[y].CurrentLEActual(),
                                    CurrentLERange: view_RecDatasheet.collRec()[y].CurrentLERange(),
                                    CompletedLEActual: view_RecDatasheet.collRec()[y].CompletedLEActual(),
                                    CompletedLERange: view_RecDatasheet.collRec()[y].CompletedLERange(),
                                    EstCostToCompleteActual: view_RecDatasheet.collRec()[y].EstCostToCompleteActual(),
                                    EstCostToCompleteRange: view_RecDatasheet.collRec()[y].EstCostToCompleteRange(),
                                    ActualCostToComplete: view_RecDatasheet.collRec()[y].ActualCostToComplete(),
                                    ExpdComplDate: view_RecDatasheet.collRec()[y].ExpdComplDate(),
                                    SavingsRatio: view_RecDatasheet.collRec()[y].SavingsRatio(),
                                    IntendedAction: view_RecDatasheet.collRec()[y].IntendedAction(),
                                    RespDate: view_RecDatasheet.collRec()[y].RespDate(),
                                    RespFrom: view_RecDatasheet.collRec()[y].RespFrom(),
                                    FacilityComment: view_RecDatasheet.collRec()[y].FacilityComment(),
                                    MgmtRespAction: view_RecDatasheet.collRec()[y].MgmtRespAction(),
                                    MgmtRespDate: view_RecDatasheet.collRec()[y].MgmtRespDate(),
                                    MgmtRespFrom: view_RecDatasheet.collRec()[y].MgmtRespFrom(),
                                    MgmtRespComment: view_RecDatasheet.collRec()[y].MgmtRespComment()
                                });
                            }
                        } else {
                            if (view_RecDatasheet.collRec()[y].FileNo() == view_RecDatasheet.objListing().FileNo()) {
                                view_RecDatasheet.collGrid().push({
                                    Id: y,
                                    FileNo: view_RecDatasheet.collRec()[y].FileNo(),
                                    RecYear: view_RecDatasheet.collRec()[y].RecYear(),
                                    RecMo: view_RecDatasheet.collRec()[y].RecMo(),
                                    RecNumber: view_RecDatasheet.collRec()[y].RecNumber(),
                                    RecSubLetter: view_RecDatasheet.collRec()[y].RecSubLetter(),
                                    RecStatus: view_RecDatasheet.collRec()[y].RecStatus(),
                                    StatusDate: view_RecDatasheet.collRec()[y].StatusDate(),
                                    RecCode: view_RecDatasheet.collRec()[y].RecCode(),
                                    RecImpact: view_RecDatasheet.collRec()[y].RecImpact(),
                                    Hazard: view_RecDatasheet.collRec()[y].Hazard(),
                                    PrimaryRecType: view_RecDatasheet.collRec()[y].PrimaryRecType(),
                                    SecondaryRecType: view_RecDatasheet.collRec()[y].SecondaryRecType(),
                                    RecKeywords: view_RecDatasheet.collRec()[y].RecKeywords(),
                                    CurrentLEActual: view_RecDatasheet.collRec()[y].CurrentLEActual(),
                                    CurrentLERange: view_RecDatasheet.collRec()[y].CurrentLERange(),
                                    CompletedLEActual: view_RecDatasheet.collRec()[y].CompletedLEActual(),
                                    CompletedLERange: view_RecDatasheet.collRec()[y].CompletedLERange(),
                                    EstCostToCompleteActual: view_RecDatasheet.collRec()[y].EstCostToCompleteActual(),
                                    EstCostToCompleteRange: view_RecDatasheet.collRec()[y].EstCostToCompleteRange(),
                                    ActualCostToComplete: view_RecDatasheet.collRec()[y].ActualCostToComplete(),
                                    ExpdComplDate: view_RecDatasheet.collRec()[y].ExpdComplDate(),
                                    SavingsRatio: view_RecDatasheet.collRec()[y].SavingsRatio(),
                                    IntendedAction: view_RecDatasheet.collRec()[y].IntendedAction(),
                                    RespDate: view_RecDatasheet.collRec()[y].RespDate(),
                                    RespFrom: view_RecDatasheet.collRec()[y].RespFrom(),
                                    FacilityComment: view_RecDatasheet.collRec()[y].FacilityComment()
                                });
                            }
                        }
                    }
                },

                //// LOAD RECORDS
                loadFileNumber: function () {
                    var tempHemisphere = getHemisphere(calculate_time_zone());
                    var tempParm = view_RecDatasheet.gSafeGuid + "|" + view_RecDatasheet.fileDirection() + "|one|False";
                    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                    //if (!view_RecDatasheet.collListing.ViewCCLocationFireRecommendationCollections(tempParm)) {
                    if (!view_RecDatasheet.collListing.ViewCCLocationFireCollections(tempParm)) {
                        es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                        if (!view_RecDatasheet.collRec.viewCCFireRecommendationGridCollection(view_RecDatasheet.gSafeGuid + "|" + tempHemisphere)) {
                            //view_RecDatasheet.objRec(view_RecDatasheet.collRec()[0]);
                            view_RecDatasheet.objListing(view_RecDatasheet.collListing()[0]);
                            view_RecDatasheet.clientFeatures(getClientFeatures(view_RecDatasheet.gSafeGuid));
                            view_RecDatasheet.objFind(getFindLocationFields(view_RecDatasheet.gSafeGuid));
                            view_RecDatasheet.buildGrid();
                            //view_RecDatasheet.setupButtons();
                            view_RecDatasheet.setupFileButtons();
                            if (view_RecDatasheet.objFind().findCriteria == undefined || view_RecDatasheet.objFind().findCriteria == "") {
                                viewFindCriteria_RecDatasheet.findCriteria(" ");
                                view_RecDatasheet.findEngaged(true);
                            } else {
                                viewFindCriteria_RecDatasheet.findCriteria(view_RecDatasheet.objFind().findCriteria);
                                view_RecDatasheet.findEngaged(false);
                            }
                        } else {
                            view_RecDatasheet.messageError("* Error while loading Recommendation Details.");
                        }
                    } else {
                        view_RecDatasheet.messageError("* Error while loading Location Listing.");
                    }
                }
            };


            ///////////////////////////////////////////
            //// SETUP BASE URL FOR DATA SERVICE AND LOAD ALL DATA
            view_RecDatasheet.loadFileNumber();


            ///////////////////////////////////////////
            //// SETUP GRID DATASOURCE
            var dsRec;
            if (view_RecDatasheet.clientFeatures().indexOf("Q") > -1) {
                dsRec = new kendo.data.DataSource({
                serverOperation: false,
                data: view_RecDatasheet.collGrid(),
                schema: {
                    model: {
                        id: "FileNo",
                        fields: {
                            Id: { type: "string", editable: false },
                            FileNo: { type: "string", editable: false },
                            RecYear: { type: "string", editable: true },
                            RecMo: { type: "string", editable: true },
                            RecNumber: { type: "string", editable: true },
                            RecSubLetter: { type: "string", editable: true },
                            RecCode: { type: "string", editable: true },
                            RecStatus: { type: "string", editable: true },
                            StatusDate: { type: "date", editable: true },
                            RecImpact: { type: "string", editable: true },
                            Hazard: { type: "string", editable: true },
                            PrimaryRecType: { type: "string", editable: true },
                            SecondaryRecType: { type: "string", editable: true },
                            RecKeywords: { type: "string", editable: true },
                            CurrentLEActual: { type: "string", editable: true },
                            CurrentLERange: { type: "string", editable: true },
                            CompletedLEActual: { type: "string", editable: true },
                            CompletedLERange: { type: "string", editable: true },
                            EstCostToCompleteActual: { type: "string", editable: true },
                            EstCostToCompleteRange: { type: "string", editable: true },
                            ActualCostToComplete: { type: "string", editable: true },
                            LossExpectancyBeforeActual: { type: "string", editable: true },
                            LossExpectancyAfterActual: { type: "string", editable: true },
                            CostToCompleteActual: { type: "string", editable: true },
                            ExpdComplDate: { type: "date", editable: true },
                            SavingsRatio: { type: "string", editable: true },
                            IntendedAction: { type: "string", editable: true },
                            RespDate: { type: "date", editable: true },
                            RespFrom: { type: "string", editable: true },
                            FacilityComment: { type: "string", editable: true },
                                MgmtRespAction: { type: "string", editable: true },
                                MgmtRespDate: { type: "date", editable: true },
                                MgmtRespFrom: { type: "string", editable: true },
                                MgmtRespComment: { type: "string", editable: true }
                        }
                    }
                }
            });
            } else {
                dsRec = new kendo.data.DataSource({
                serverOperation: false,
                data: view_RecDatasheet.collGrid(),
                schema: {
                    model: {
                        id: "FileNo",
                        fields: {
                            Id: { type: "string", editable: false },
                            FileNo: { type: "string", editable: false },
                            RecYear: { type: "string", editable: true },
                            RecMo: { type: "string", editable: true },
                            RecNumber: { type: "string", editable: true },
                            RecSubLetter: { type: "string", editable: true },
                            RecCode: { type: "string", editable: true },
                            RecStatus: { type: "string", editable: true },
                            StatusDate: { type: "date", editable: true },
                            RecImpact: { type: "string", editable: true },
                            Hazard: { type: "string", editable: true },
                            PrimaryRecType: { type: "string", editable: true },
                            SecondaryRecType: { type: "string", editable: true },
                            RecKeywords: { type: "string", editable: true },
                            CurrentLEActual: { type: "string", editable: true },
                            CurrentLERange: { type: "string", editable: true },
                            CompletedLEActual: { type: "string", editable: true },
                            CompletedLERange: { type: "string", editable: true },
                            EstCostToCompleteActual: { type: "string", editable: true },
                            EstCostToCompleteRange: { type: "string", editable: true },
                            ActualCostToComplete: { type: "string", editable: true },
                            LossExpectancyBeforeActual: { type: "string", editable: true },
                            LossExpectancyAfterActual: { type: "string", editable: true },
                            CostToCompleteActual: { type: "string", editable: true },
                            ExpdComplDate: { type: "date", editable: true },
                            SavingsRatio: { type: "string", editable: true },
                            IntendedAction: { type: "string", editable: true },
                            RespDate: { type: "date", editable: true },
                            RespFrom: { type: "string", editable: true },
                            FacilityComment: { type: "string", editable: true }
                        }
                    }
                }
            });
            }

            ///////////////////////////////////////////
            //// SETUP THE GRID
            var gridRecDatasheet;
            if (view_RecDatasheet.clientFeatures().indexOf("Q") > -1) {
                gridRecDatasheet = $("#gridRecDatasheet").kendoGrid({
                dataSource: dsRec,
                width: 885,
                height: 325,
                pageable: false,
                scrollable: true,
                sortable: true,
                filterable: true,
                editable: false,
                selectable: "row",
                columns: [
                    { command: { text: "Enter", click: onEnter }, title: "", width: "60px" },
                    { field: "Id", width: "0px", title: "", filterable: false, sortable: false, template: "<a name='#=Id#' id='#=Id#'>#=Id#</a>" },
                    { field: "RecYear", width: "75px", title: "Rec. Year" },
                    { field: "RecMo", width: "75px", title: "Rec. Mo." },
                    { field: "RecNumber", width: "75px", title: "Rec. No." },
                    { field: "RecSubLetter", width: "100px", title: "Rec. SubLetter" },
                    { field: "RecStatus", width: "100px", title: "Rec. Status" },
                        { field: "StatusDate", width: "75px", title: "Status Date", template: "#= (StatusDate == null || StatusDate == undefined || StatusDate == '' || StatusDate == '1/1/00' || StatusDate == '1/1/1900' || StatusDate == '01-Jan-00' || StatusDate == '31-Dec-99' || StatusDate == '12/31/99' || StatusDate == '12/31/1899' || StatusDate.toString().indexOf('1900') > -1 || StatusDate.toString().indexOf('1899') > -1) ? ' ' : kendo.toString(StatusDate, 'dd-MMM-yy') #" },
                    { field: "RecCode", width: "75px", title: "Rec. Code" },
                    { field: "RecImpact", width: "100px", title: "Rec. Impact" },
                    { field: "Hazard", width: "100px", title: "Hazard" },
                    { field: "PrimaryRecType", width: "200px", title: "Primary Rec. Type" },
                    { field: "SecondaryRecType", width: "200px", title: "Secondary Rec. Type" },
                    { field: "RecKeywords", width: "450px", title: "Rec. Key Words", template: "#= RecKeywords.length > 75 ? RecKeywords.substr(0, 75) + ' ...': RecKeywords #" },
                    { field: "CurrentLEActual", width: "250px", title: "Current LE USD" },
                    { field: "CurrentLERange", width: "250px", title: "Current LE Range" },
                    { field: "CompletedLEActual", width: "250px", title: "Completed LE USD" },
                    { field: "CompletedLERange", width: "250px", title: "Completed LE Range" },
                    { field: "EstCostToCompleteActual", width: "250px", title: "Est. Cost To Complete USD" },
                    { field: "EstCostToCompleteRange", width: "250px", title: "Est. Cost To Complete Range" },
                    { field: "ActualCostToComplete", width: "250px", title: "Actual Cost To Complete" },
                    { field: "SavingsRatio", width: "100px", title: "Savings Ratio" },
                    { field: "IntendedAction", width: "250px", title: "Intended Action" },
                        { field: "RespDate", width: "75px", title: "Resp. Date", template: "#= (RespDate == null || RespDate == undefined || RespDate == '' || RespDate == '1/1/00' || RespDate == '1/1/1900' || RespDate == '01-Jan-00' || RespDate == '31-Dec-99' || RespDate == '12/31/99' || RespDate == '12/31/1899' || RespDate.toString().indexOf('1900') > -1 || RespDate.toString().indexOf('1899') > -1) ? ' ' : kendo.toString(RespDate, 'dd-MMM-yy') #" },
                    { field: "RespFrom", width: "150px", title: "Resp. From" },
                    { field: "FacilityComment", width: "450px", title: "Facility Comment", template: "#= FacilityComment.length > 75 ? FacilityComment.substr(0, 75) + ' ...': FacilityComment #" },
                        { field: "ExpdComplDate", width: "125px", title: "Expd. Compl. Date", template: "#= (ExpdComplDate == null || ExpdComplDate == undefined || ExpdComplDate == '' || ExpdComplDate == '1/1/00' || ExpdComplDate == '1/1/1900' || ExpdComplDate == '01-Jan-00' || ExpdComplDate == '31-Dec-99' || ExpdComplDate == '12/31/99' || ExpdComplDate == '12/31/1899' || ExpdComplDate.toString().indexOf('1900') > -1 || ExpdComplDate.toString().indexOf('1899') > -1) ? ' ' : kendo.toString(ExpdComplDate, 'dd-MMM-yy') #" },
                        { field: "MgmtRespAction", width: "250px", title: "Mgmt. Action" },
                        { field: "MgmtRespDate", width: "125px", title: "Mgmt. Resp. Date", template: "#= (MgmtRespDate == null || MgmtRespDate == undefined || MgmtRespDate == '' || MgmtRespDate == '1/1/00' || MgmtRespDate == '1/1/1900' || MgmtRespDate == '01-Jan-00' || MgmtRespDate == '31-Dec-99' || MgmtRespDate == '12/31/99' || MgmtRespDate == '12/31/1899' || MgmtRespDate.toString().indexOf('1900') > -1 || MgmtRespDate.toString().indexOf('1899') > -1) ? ' ' : kendo.toString(MgmtRespDate, 'dd-MMM-yy') #" },
                        { field: "MgmtRespFrom", width: "150px", title: "Mgmt. Resp. From" },
                        { field: "MgmtRespComment", width: "450px", title: "Mgmt. Comment", template: "#= MgmtRespComment.length > 75 ? MgmtRespComment.substr(0, 75) + ' ...': MgmtRespComment #" },
                ]
            }).data("kendoGrid");
            } else {
                gridRecDatasheet = $("#gridRecDatasheet").kendoGrid({
                dataSource: dsRec,
                width: 885,
                height: 325,
                pageable: false,
                scrollable: true,
                sortable: true,
                filterable: true,
                editable: false,
                selectable: "row",
                columns: [
                    { command: { text: "Enter", click: onEnter }, title: "", width: "60px" },
                    { field: "Id", width: "0px", title: "", filterable: false, sortable: false, template: "<a name='#=Id#' id='#=Id#'>#=Id#</a>" },
                    { field: "RecYear", width: "75px", title: "Rec. Year" },
                    { field: "RecMo", width: "75px", title: "Rec. Mo." },
                    { field: "RecNumber", width: "75px", title: "Rec. No." },
                    { field: "RecSubLetter", width: "100px", title: "Rec. SubLetter" },
                    { field: "RecStatus", width: "100px", title: "Rec. Status" },
                        { field: "StatusDate", width: "75px", title: "Status Date", template: "#= (StatusDate == null || StatusDate == undefined || StatusDate == '' || StatusDate == '1/1/00' || StatusDate == '1/1/1900' || StatusDate == '01-Jan-00' || StatusDate == '31-Dec-99' || StatusDate == '12/31/99' || StatusDate == '12/31/1899' || StatusDate.toString().indexOf('1900') > -1 || StatusDate.toString().indexOf('1899') > -1) ? ' ' : kendo.toString(StatusDate, 'dd-MMM-yy') #" },
                    { field: "RecCode", width: "75px", title: "Rec. Code" },
                    { field: "RecImpact", width: "100px", title: "Rec. Impact" },
                    { field: "Hazard", width: "100px", title: "Hazard" },
                    { field: "PrimaryRecType", width: "200px", title: "Primary Rec. Type" },
                    { field: "SecondaryRecType", width: "200px", title: "Secondary Rec. Type" },
                    { field: "RecKeywords", width: "450px", title: "Rec. Key Words", template: "#= RecKeywords.length > 75 ? RecKeywords.substr(0, 75) + ' ...': RecKeywords #" },
                    { field: "CurrentLEActual", width: "250px", title: "Current LE USD" },
                    { field: "CurrentLERange", width: "250px", title: "Current LE Range" },
                    { field: "CompletedLEActual", width: "250px", title: "Completed LE USD" },
                    { field: "CompletedLERange", width: "250px", title: "Completed LE Range" },
                    { field: "EstCostToCompleteActual", width: "250px", title: "Est. Cost To Complete USD" },
                    { field: "EstCostToCompleteRange", width: "250px", title: "Est. Cost To Complete Range" },
                    { field: "ActualCostToComplete", width: "250px", title: "Actual Cost To Complete" },
                    { field: "SavingsRatio", width: "100px", title: "Savings Ratio" },
                    { field: "IntendedAction", width: "250px", title: "Intended Action" },
                        { field: "RespDate", width: "75px", title: "Resp. Date", template: "#= (RespDate == null || RespDate == undefined || RespDate == '' || RespDate == '1/1/00' || RespDate == '1/1/1900' || RespDate == '01-Jan-00' || RespDate == '31-Dec-99' || RespDate == '12/31/99' || RespDate == '12/31/1899' || RespDate.toString().indexOf('1900') > -1 || RespDate.toString().indexOf('1899') > -1) ? ' ' : kendo.toString(RespDate, 'dd-MMM-yy') #" },
                    { field: "RespFrom", width: "150px", title: "Resp. From" },
                    { field: "FacilityComment", width: "450px", title: "Facility Comment", template: "#= FacilityComment.length > 75 ? FacilityComment.substr(0, 75) + ' ...': FacilityComment #" },
                        { field: "ExpdComplDate", width: "125px", title: "Expd. Compl. Date", template: "#= (ExpdComplDate == null || ExpdComplDate == undefined || ExpdComplDate == '' || ExpdComplDate == '1/1/00' || ExpdComplDate == '1/1/1900' || ExpdComplDate == '01-Jan-00' || ExpdComplDate == '31-Dec-99' || ExpdComplDate == '12/31/99' || ExpdComplDate == '12/31/1899' || ExpdComplDate.toString().indexOf('1900') > -1 || ExpdComplDate.toString().indexOf('1899') > -1) ? ' ' : kendo.toString(ExpdComplDate, 'dd-MMM-yy') #" }
                ]
            }).data("kendoGrid");
            }


            ///////////////////////////////////////////
            //// ACTIVATE BINDINGS LAST
            ko.applyBindings(view_RecDatasheet, $("#view_RecDatasheet")[0]);
            ko.applyBindings(view_RecDatasheet, $("#view2_RecDatasheet")[0]);
            ko.applyBindings(viewFindCriteria_RecDatasheet, $("#viewFindCriteria_RecDatasheet")[0]);


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
                animation: { open: { effects: "none" }, close: { effects: "default"} }
            });
            $("#windowNoLocation").closest(".k-window").css({
                top: 285,
                left: 400
            });
            $("#windowNoLocation").prev().find(".k-window-title").append("<img src='../images/icons/warning/window_warning_24x24.png' align='left' alt='Warning Icon' class='windowIcon'/>  " + view_RecDatasheet.objLanguageLabels().lblNoLocationFoundTitle);

            //// most plain text inputs do not need bound in JS but need kendo widgets for styles
            //        $("#FileNo").kendoAutoComplete();
            //        $("#ClientLocNo").kendoAutoComplete();
            //        $("#Latitude").kendoAutoComplete();
            //        $("#Longitude").kendoAutoComplete();
            //        $("#Address1").kendoAutoComplete();
            //        $("#Division").kendoAutoComplete();
            //        $("#City").kendoAutoComplete();
            //        $("#StProv").kendoAutoComplete();
            //        $("#Facility").kendoAutoComplete();
            //        $("#Country").kendoAutoComplete();
            //        $("#Zip").kendoAutoComplete();
            //        $("#CustomAccess").kendoAutoComplete();

            //////////////////////////////
            //// WHEN ALL DONE CALL THE RESET TO SYNC THE FIND AND THE PICKERS
            view_RecDatasheet.setupFindFields();
            view_RecDatasheet.resetPickers();

            //////////////////////////////
            //// AUTOMATICALLY SCROLL TO THE POSITION OF THE PREVIOUS VIEWED RECOMMENDATION
            var tempRec = parseInt(getRecId());
            if (tempRec != 0) {
                $("#gridRecDatasheet .k-grid-content").scrollTop(27 * (tempRec - 1) + 10);
            }
            var row = gridRecDatasheet.tbody.find(">tr:not(.k-grouping-row)").eq(tempRec);
            gridRecDatasheet.select(row);
        });

        function onEnter(e) {
            e.preventDefault();
            var dataItem = this.dataItem($(e.currentTarget).closest("tr"));
            var tempUrl = "tab_rectrackingfeaturesX.aspx?sid=" + getGSafeGUID() + "&rec=" + dataItem.Id;
            //document.location.href = tempUrl;
            gReloadTab(tempUrl, dataItem.Id);
        }

    </script>
    </form>
</body>
</html>
