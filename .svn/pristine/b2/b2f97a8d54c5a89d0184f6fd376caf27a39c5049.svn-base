<%@ Page Title="Infrared Recommendation | Global Risk Consultants" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectServerDetail.Master" CodeBehind="recdatasheet.aspx.vb" Inherits="GRC.Connect.Web.recdatasheet_Infrared" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

<%--    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-grid.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/rectracking.css" />
    <script src="../../Lib_{{VER}}/Generated/ViewCCLocationListingIR.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCLocationListingIR.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCIRRecommendationGrid.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCIRRecommendationGrid.js" type="text/javascript"></script>--%>
    <%--<script src="../../Lib_{{VER}}/KendoUI/kendo.all.min.js" type="text/javascript"></script>--%>

</asp:Content>

<asp:Content ID="ContentFindCriteria" ContentPlaceHolderID="ContentFindCriteria" runat="server">
<%--    <div class="headerFindCriteria" id="viewFindCriteria" data-bind="with: viewFindCriteria">
        <label data-bind="text: $parent.findCriteria" id="findCriteria"></label>&nbsp;
    </div>--%>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<%--<div id="view" data-bind="with: view">
    <!-- TABLE FOR COMPANY / ADDRESS INFORMATION -->
    <!-- SPECIFIC STYLES TO ROWS OR COLUMNS SHOULD BE INLINE -->
    <div class="tableDiv">
        <div>
            <span class="companyLabels1"><label data-bind="text: $parent.objLanguageLabels().lblGRCLocNo, css: { findOn: $parent.objFind().findFileNo, findOff: !$parent.objFind().findFileNo }">GRC Loc. No.</label></span>
            <span class="companyInputs1"><input data-bind="value: $parent.objListing().FileNo, css: { findOnInput: $parent.objFind().findFileNo, findOffInput: !$parent.objFind().findFileNo }" id="FileNo" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs1" tabindex="1" /></span>
            <span class="companyLabels2"><label data-bind="text: $parent.objLanguageLabels().lblClientLocNo, css: { findOn: $parent.objFind().findClientLocNo, findOff: !$parent.objFind().findClientLocNo }">Client Loc. No.</label></span>
            <span class="companyInputs2"><input data-bind="value: $parent.objListing().ClientLocNo, css: { findOnInput: $parent.objFind().findClientLocNo, findOffInput: !$parent.objFind().findClientLocNo }" id="ClientLocNo" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs2" tabindex="2" /></span>
            <span class="companyLabels5"><label data-bind="text: $parent.objLanguageLabels().lblLatitude, css: { findOn: $parent.objFind().findLatitude, findOff: !$parent.objFind().findLatitude }">Latitude</label></span>
            <span class="companyInputs4"><input data-bind="value: $parent.objListing().Latitude, css: { findOnInput: $parent.objFind().findLatitude, findOffInput: !$parent.objFind().findLatitude }" id="Latitude" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs4" tabindex="3"  /></span>
            <span class="companyLabels4"><label data-bind="text: $parent.objLanguageLabels().lblLongitude, css: { findOn: $parent.objFind().findLongitude, findOff: !$parent.objFind().findLongitude }">Longitude</label></span>
            <span class="companyInputs4"><input data-bind="value: $parent.objListing().Longitude, css: { findOnInput: $parent.objFind().findLongitude, findOffInput: !$parent.objFind().findLongitude }" id="Longitude" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs4" tabindex="4"  /></span>
        </div>
        <div>
            <span class="companyLabels1"><label data-bind="text: $parent.objLanguageLabels().lblAddress1, css: { findOn: $parent.objFind().findAddress1, findOff: !$parent.objFind().findAddress1 }">Address</label></span>
            <span class="companyInputs6"><input data-bind="value: $parent.objListing().Address1, css: { findOnInput: $parent.objFind().findAddress1, findOffInput: !$parent.objFind().findAddress1 }" id="Address1" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs6" tabindex="5"  /></span>
            <span class="companyLabels3"><label data-bind="text: $parent.objLanguageLabels().lblDivisionName, css: { findOn: $parent.objFind().findDivision, findOff: !$parent.objFind().findDivision }">Division Name</label></span>
            <span class="companyInputs5"><input data-bind="value: $parent.objListing().Division, css: { findOnInput: $parent.objFind().findDivision, findOffInput: !$parent.objFind().findDivision }" id="Division" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="6"  /></span>
        </div>
        <div>
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
        <div>
            <!-- BUTTONS FOR LOCATION / FILE NUMBER WALK / FIND LOCATION -->
            <span class="companyLabels1"><%--<img data-bind="visible: $parent.loading" src="../../Home_{{VER}}/Images/loading/loadingdetails.gif" style="height: 20px; width: 75px; border: 0px;" alt="Loading" />--%></span>
            <span class="buttonContainerLocationLoading">
                <span><button data-bind="click: $parent.onFileFirst, enable: $parent.enableFilePrev" type="button" class="k-button buttonShape k-icon k-i-seek-w" id="btnFileFirst" tabindex="15"></button></span>
                <span><button data-bind="click: $parent.onFilePrevious, enable: $parent.enableFilePrev" type="button" class="k-button buttonShape k-icon k-i-arrow-w" id="btnFilePrevious" tabindex="16"></button></span>
                <span class="buttonFileRecordLabel" style="width: 130px;">&nbsp;<label data-bind="text: $parent.objLanguageLabels().lblFileRecord">Location</label> <input data-bind="value: $parent.txtFileRecordNumber" id="txtFileRecordNumber" class="k-autocomplete k-input inputCenter inputNoEdit buttonInput" style="width: 80px; margin-bottom: 3px;" readonly="true" />&nbsp;</span>
                <span><button data-bind="click: $parent.onFileNext, enable: $parent.enableFileNext" type="button" class="k-button buttonShape k-icon k-i-arrow-e" id="btnFileNext" tabindex="17"></button></span>
                <span><button data-bind="click: $parent.onFileLast, enable: $parent.enableFileNext" type="button" class="k-button buttonShape k-icon k-i-seek-e" id="btnFileLast" tabindex="18"></button></span>
                <span>&nbsp;</span>
                <span><button data-bind="click: $parent.onFindClear, css: { hidden: $parent.findEngaged }" type="button" class="k-button buttonFindClearShape hidden" tabindex="13">Clear Find</button></span>
                <%--<span><button data-bind="click: $parent.onFind" class="k-button buttonShape" type="submit" style="width: 0px; line-height: normal; border-color: White; background-color: White; padding: 0; margin: 0;" tabindex="14"></button></span>--%><span><button data-bind="click: $parent.onFind" class="k-button buttonFindShape" type="submit" tabindex="14">Find</button></span>
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
        <div style="margin-bottom:5px;"><label data-bind="text: $parent.objLanguageLabels().lblNoLocationFoundMessage">Warning: There are no recommendation records found for this location.</label></div>
        <div style="margin-bottom:5px;"><label data-bind="text: $parent.objLanguageLabels().lblNoLocationFoundDescription">Click the below button to go back to the Location Details page, or use the Location Navigation buttons to go to another location record.</label></div>
        <div style="justify-content: center; width:100%; display:flex;"><button class="grcBlueBtn" style="padding: 6px;" data-bind="text: $parent.objLanguageLabels().lblGoBackToDetails, click: $parent.onLocationDetailsRedirect">Go Back To Location Details</button></div>
    </div>

</div>

<!-- TABLE FOR RECOMMENDATION TRACKING INFORMATION -->
<!-- THE GRID -->
<div id="gridContainer" style="clear: both;">
    <div id="gridRecDatasheet" style="width: 810px; height: 325px;"></div>
    <div id="view2" data-bind="with: view" class="k-pager-wrap k-grid-pager" style="height: 22px; width: 806px;">
        <%--<button class="k-button k-button-padding k-button-100wide" style="line-height: 1.5em;" id="btnExport" data-bind="click: $parent.onExport">Export</button>--%>
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
            lblSearchNotFound: "This location is not active for IR.  Choose a different service."
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
        var viewFindCriteria = {
            findCriteria: ko.observable()
        };
        var view = {
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
            collRec: new es.objects.ViewCCIRRecommendationGridCollection(),
            collListing: new es.objects.ViewCCLocationListingIRCollection(),
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
                if (view.index < view.collRec().length - 1) {
                    view.index++;
                    view.objRec(view.collRec()[view.index]);
                }
                view.setupButtons();
                view.resetPickers();
            },

            onPrevious: function () {
                if (view.index > 0) {
                    view.index--;
                    view.objRec(view.collRec()[view.index]);
                }
                view.setupButtons();
                view.resetPickers();
            },

            onFirst: function () {
                if (view.index > 0) {
                    view.index = 0;
                    view.objRec(view.collRec()[view.index]);
                }
                view.setupButtons();
                view.resetPickers();
            },

            onLast: function () {
                if (view.index < view.collRec().length - 1) {
                    view.index = view.collRec().length - 1;
                    view.objRec(view.collRec()[view.index]);
                }
                view.setupButtons();
                view.resetPickers();
            },

            //// BUTTONS FOR FILE NUMBER / LOCATION WALK
            onFileFirst: function () {
                view.fileDirection("first");
                view.loadFileNumber();
                view.fileDirection("");
                view.resetPickers();
            },

            onFilePrevious: function () {
                view.fileDirection("previous");
                view.loadFileNumber();
                view.fileDirection("");
                view.resetPickers();
            },

            onFileNext: function () {
                view.fileDirection("next");
                view.loadFileNumber();
                view.fileDirection("");
                view.resetPickers();
            },

            onFileLast: function () {
                view.fileDirection("last");
                view.loadFileNumber();
                view.fileDirection("");
                view.resetPickers();
            },

            //// FIND A RECORD FROM THE LOCATION FIELDS
            onFind: function () {
                //// SET THE GSAFE
                setFindLocationFields(view.gSafeGuid, view.objFind(), view.objListing());
                //// LOOKUP RECORD USING THE ON FIRST NAVIGATE
                view.onFileFirst();
                view.resetPickers();
            },

            onFindClear: function () {
                //// CLEAR THE OBJECT
                view.resetPickers();
                //// SET THE GSAFE
                setFindLocationFields(view.gSafeGuid, view.objFind(), view.objListing());
                //// RELOAD THE FILE NUMBER TO GET THE CORRECT LOCATION COUNT
                view.onFileFirst();
                view.resetPickers();
            },

            onLocationDetailsRedirect: function () {
                //// REDIRECT THE USER TO THE LOCATION DETAILS PAGE
                document.location.href = "locationdetails.aspx" + "?sid=" + view.gSafeGuid;
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
                if (view.clientFeatures().indexOf("Q") > -1) {
                    Header = buildXMLRecHeader_InfraredMgmt();
                    Content = buildXMLString_InfraredMgmt(gridRecDatasheet.dataSource._view, view.objListing());
                    Footer = buildXMLRecFooter();
                } else {
                    Header = buildXMLRecHeader_Infrared();
                    Content = buildXMLString_Infrared(gridRecDatasheet.dataSource._view, view.objListing());
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
                if (view.index == 0) { view.enablePrev(false); } else { view.enablePrev(true); }
                if (view.index == view.collRec().length - 1) { view.enableNext(false); } else { view.enableNext(true); }
                view.txtRecordNumber((view.index + 1) + " of " + view.collRec().length);
            },

            setupFileButtons: function () {
                if (view.objListing().RecNum() <= 1) { view.enableFilePrev(false); } else { view.enableFilePrev(true); }
                if (view.objListing().RecNum() >= view.objListing().RecCount()) { view.enableFileNext(false); } else { view.enableFileNext(true); }
                if (view.objListing().RecCount() <= 1) { view.enableFilePrev(false); view.enableFilePrev(false); }
                view.txtFileRecordNumber(view.objListing().RecNum() + " of " + view.objListing().RecCount());
            },

            //// SETUP FIND FIELDS FOR LOCATIONS
            setupFindFields: function () {
                //// FIND TEXT BOXES
                view.objFind().findFileNo = view.objListing().FileNo();
                view.objFind().findClientLocNo = view.objListing().ClientLocNo();
                view.objFind().findAddress1 = view.objListing().Address1();
                view.objFind().findCity = view.objListing().City();
                view.objFind().findStProv = view.objListing().StProv();
                view.objFind().findCountry = view.objListing().Country();
                view.objFind().findZip = view.objListing().Zip();
                view.objFind().findDivision = view.objListing().Division();
                view.objFind().findFacility = view.objListing().Facility();
                view.objFind().findCustomAccess = view.objListing().CustomAccess();
                view.objFind().findLatitude = view.objListing().Latitude();
                view.objFind().findLongitude = view.objListing().Longitude();
            },

            //// RESET FIELDS ON LOAD RECORD
            resetPickers: function () {
                //// COPY THE FIND FIELDS
                view.setupFindFields();

                //// REFRESH THE GRID
                gridRecDatasheet.dataSource.data(view.collGrid());
                gridRecDatasheet.dataSource.page(1);

                //// DISPLAY WINDOW IF NO RECORD EXISTS OR A MESSAGE IF NO SEARCH FOUND
                windowNoLocation.data("kendoWindow").close();
                view.messageError("");
                if (view.collRec()[0].FileNo() == "Not Found") { // There is no object because the grid uses a collection.  No window needed.
                    view.collGrid([]);
                    gridRecDatasheet.dataSource.data(view.collGrid());
                    windowNoLocation.data("kendoWindow").open();
                    $("#windowNoLocation").css("display", "block");
                } else if (view.objListing().FileNo() == "Not Found") {
                    view.collGrid([]);
                    gridRecDatasheet.dataSource.data(view.collGrid());
                    view.messageError(view.objLanguageLabels().lblSearchNotFound);
                }
            },

            //// BUILD THE DATASOURCE FOR THE GRID
            buildGrid: function () {
                view.collGrid([]);
                for (y = 0; y < view.collRec().length; y++) {
                    if (view.clientFeatures().indexOf("Q") > -1) {
                        if (view.collRec()[y].FileNo() == view.objListing().FileNo()) {
                            view.collGrid().push({
                                IdWeb: y,
                                FileNo: view.collRec()[y].FileNo(),
                                RecMonth: view.collRec()[y].RecMonth(),
                                RecNumber: view.collRec()[y].RecNumber(),
                                RecYear: view.collRec()[y].RecYear(),
                                Severityrating: view.collRec()[y].Severityrating(),
                                Recommendation: view.collRec()[y].Recommendation(),
                                RecommendationID: view.collRec()[y].RecommendationID(),
                                FindEquip: view.collRec()[y].FindEquip(),
                                Itemno: view.collRec()[y].Itemno(),
                                Findingno: view.collRec()[y].Findingno(),
                                PlantAreaAffected: view.collRec()[y].PlantAreaAffected(),
                                FaultType: view.collRec()[y].FaultType(),
                                ProbableEquipmentDamageCost: view.collRec()[y].ProbableEquipmentDamageCost(),
                                LengthOfBusinessInterruption: view.collRec()[y].LengthOfBusinessInterruption(),
                                CostOfBusinessInterruption: view.collRec()[y].CostOfBusinessInterruption(),
                                DetectedWith: view.collRec()[y].DetectedWith(),
                                Impact: view.collRec()[y].Impact(),
                                Comments2: view.collRec()[y].Comments2(),
                                RecStatus: view.collRec()[y].RecStatus(),
                                StatusDate: view.collRec()[y].StatusDate(),
                                ResponseFrom: view.collRec()[y].ResponseFrom(),
                                ResponseDate: view.collRec()[y].ResponseDate(),
                                ResponseComment: view.collRec()[y].ResponseComment(),
                                ResponseStatus: view.collRec()[y].ResponseStatus(),
                                RedundancySpare: view.collRec()[y].RedundancySpare(),
                                RecPrimary: view.collRec()[y].RecPrimary(),
                                RecSecondary: view.collRec()[y].RecSecondary(),
                                IntendedAction: view.collRec()[y].IntendedAction(),
                                PlantComment: view.collRec()[y].PlantComment(),
                                Id: view.collRec()[y].Id(),
                                History: view.collRec()[y].History(),
                                Comments: view.collRec()[y].Comments(),
                                ExpectedCompletionDate: view.collRec()[y].ExpectedCompletionDate(),
                                MgmtRespAction: view.collRec()[y].MgmtRespAction(),
                                MgmtRespDate: view.collRec()[y].MgmtRespDate(),
                                MgmtRespFrom: view.collRec()[y].MgmtRespFrom(),
                                MgmtRespComment: view.collRec()[y].MgmtRespComment()
                            });
                        }
                    } else {
                        if (view.collRec()[y].FileNo() == view.objListing().FileNo()) {
                            view.collGrid().push({
                                IdWeb: y,
                                FileNo: view.collRec()[y].FileNo(),
                                RecMonth: view.collRec()[y].RecMonth(),
                                RecNumber: view.collRec()[y].RecNumber(),
                                RecYear: view.collRec()[y].RecYear(),
                                Severityrating: view.collRec()[y].Severityrating(),
                                Recommendation: view.collRec()[y].Recommendation(),
                                RecommendationID: view.collRec()[y].RecommendationID(),
                                FindEquip: view.collRec()[y].FindEquip(),
                                Itemno: view.collRec()[y].Itemno(),
                                Findingno: view.collRec()[y].Findingno(),
                                PlantAreaAffected: view.collRec()[y].PlantAreaAffected(),
                                FaultType: view.collRec()[y].FaultType(),
                                ProbableEquipmentDamageCost: view.collRec()[y].ProbableEquipmentDamageCost(),
                                LengthOfBusinessInterruption: view.collRec()[y].LengthOfBusinessInterruption(),
                                CostOfBusinessInterruption: view.collRec()[y].CostOfBusinessInterruption(),
                                DetectedWith: view.collRec()[y].DetectedWith(),
                                Impact: view.collRec()[y].Impact(),
                                Comments2: view.collRec()[y].Comments2(),
                                RecStatus: view.collRec()[y].RecStatus(),
                                StatusDate: view.collRec()[y].StatusDate(),
                                ResponseFrom: view.collRec()[y].ResponseFrom(),
                                ResponseDate: view.collRec()[y].ResponseDate(),
                                ResponseComment: view.collRec()[y].ResponseComment(),
                                ResponseStatus: view.collRec()[y].ResponseStatus(),
                                RedundancySpare: view.collRec()[y].RedundancySpare(),
                                RecPrimary: view.collRec()[y].RecPrimary(),
                                RecSecondary: view.collRec()[y].RecSecondary(),
                                IntendedAction: view.collRec()[y].IntendedAction(),
                                PlantComment: view.collRec()[y].PlantComment(),
                                Id: view.collRec()[y].Id(),
                                History: view.collRec()[y].History(),
                                Comments: view.collRec()[y].Comments(),
                                ExpectedCompletionDate: view.collRec()[y].ExpectedCompletionDate()
                            });
                        }
                    }
                }
            },

            //// LOAD RECORDS
            loadFileNumber: function () {
                var tempParm = view.gSafeGuid + "|" + view.fileDirection();
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                //if (!view.collListing.ViewCCLocationIRRecommendationCollections(tempParm)) {
                if (!view.collListing.ViewCCLocationIRCollections(tempParm)) {
                    var tempHemisphere = getHemisphere(calculate_time_zone());
                    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                    if (!view.collRec.viewCCIRRecommendationGridCollection(view.gSafeGuid + "|" + tempHemisphere)) {
                        //view.objRec(view.collRec()[0]);
                        view.objListing(view.collListing()[0]);
                        view.clientFeatures(getClientFeatures(view.gSafeGuid));
                        view.objFind(getFindLocationFields(view.gSafeGuid));
                        view.buildGrid();
                        //view.setupButtons();
                        view.setupFileButtons();
                        if (view.objFind().findCriteria == undefined || view.objFind().findCriteria == "") {
                            viewFindCriteria.findCriteria(" ");
                            view.findEngaged(true);
                        } else {
                            viewFindCriteria.findCriteria(view.objFind().findCriteria);
                            view.findEngaged(false);
                        }
                    } else {
                        view.messageError("* Error while loading Recommendation Details.");
                    }
                } else {
                    view.messageError("* Error while loading Location Listing.");
                }
            }
        };


        ///////////////////////////////////////////
        //// SETUP BASE URL FOR DATA SERVICE AND LOAD ALL DATA
        view.loadFileNumber();


        ///////////////////////////////////////////
        //// SETUP GRID DATASOURCE
        var dsRec;
        if (view.clientFeatures().indexOf("Q") > -1) {
            dsRec = new kendo.data.DataSource({
            serverOperation: false,
            data: view.collGrid(),
            schema: {
                model: {
                    id: "FileNo",
                    fields: {
                        IdWeb: { type: "string", editable: false },
                        FileNo: { type: "string", editable: false },
                        RecMonth: { type: "string", editable: false },
                        RecNumber: { type: "string", editable: false },
                        RecYear: { type: "string", editable: false },
                        Severityrating: { type: "string", editable: false },
                        Recommendation: { type: "string", editable: false },
                        RecommendationID: { type: "string", editable: false },
                        FindEquip: { type: "string", editable: false },
                        Itemno: { type: "string", editable: false },
                        Findingno: { type: "string", editable: false },
                        PlantAreaAffected: { type: "string", editable: false },
                        FaultType: { type: "string", editable: false },
                        ProbableEquipmentDamageCost: { type: "string", editable: false },
                        LengthOfBusinessInterruption: { type: "string", editable: false },
                        CostOfBusinessInterruption: { type: "string", editable: false },
                        DetectedWith: { type: "string", editable: false },
                        Impact: { type: "string", editable: false },
                        Comments2: { type: "string", editable: false },
                        RecStatus: { type: "string", editable: false },
                        StatusDate: { type: "date", editable: false },
                        ResponseFrom: { type: "string", editable: false },
                        ResponseDate: { type: "date", editable: false },
                        ResponseComment: { type: "string", editable: false },
                        ResponseStatus: { type: "string", editable: false },
                        RedundancySpare: { type: "string", editable: false },
                        RecPrimary: { type: "string", editable: false },
                        RecSecondary: { type: "string", editable: false },
                        IntendedAction: { type: "string", editable: false },
                        PlantComment: { type: "string", editable: false },
                        Id: { type: "string", editable: false },
                        History: { type: "string", editable: false },
                        Comments: { type: "string", editable: false },
                        ExpectedCompletionDate: { type: "date", editable: false },
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
            data: view.collGrid(),
            schema: {
                model: {
                    id: "FileNo",
                    fields: {
                        IdWeb: { type: "string", editable: false },
                        FileNo: { type: "string", editable: false },
                        RecMonth: { type: "string", editable: false },
                        RecNumber: { type: "string", editable: false },
                        RecYear: { type: "string", editable: false },
                        Severityrating: { type: "string", editable: false },
                        Recommendation: { type: "string", editable: false },
                        RecommendationID: { type: "string", editable: false },
                        FindEquip: { type: "string", editable: false },
                        Itemno: { type: "string", editable: false },
                        Findingno: { type: "string", editable: false },
                        PlantAreaAffected: { type: "string", editable: false },
                        FaultType: { type: "string", editable: false },
                        ProbableEquipmentDamageCost: { type: "string", editable: false },
                        LengthOfBusinessInterruption: { type: "string", editable: false },
                        CostOfBusinessInterruption: { type: "string", editable: false },
                        DetectedWith: { type: "string", editable: false },
                        Impact: { type: "string", editable: false },
                        Comments2: { type: "string", editable: false },
                        RecStatus: { type: "string", editable: false },
                        StatusDate: { type: "date", editable: false },
                        ResponseFrom: { type: "string", editable: false },
                        ResponseDate: { type: "date", editable: false },
                        ResponseComment: { type: "string", editable: false },
                        ResponseStatus: { type: "string", editable: false },
                        RedundancySpare: { type: "string", editable: false },
                        RecPrimary: { type: "string", editable: false },
                        RecSecondary: { type: "string", editable: false },
                        IntendedAction: { type: "string", editable: false },
                        PlantComment: { type: "string", editable: false },
                        Id: { type: "string", editable: false },
                        History: { type: "string", editable: false },
                        Comments: { type: "string", editable: false },
                        ExpectedCompletionDate: { type: "date", editable: false }
                    }
                }
            }
        });
        }

        ///////////////////////////////////////////
        //// SETUP THE GRID
        var gridRecDatasheet;
        if (view.clientFeatures().indexOf("Q") > -1) {
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
                { field: "IdWeb", width: "0px", title: "", filterable: false, sortable: false, template: "<a name='#=IdWeb#' id='#=Id#'>#=IdWeb#</a>" },
                { field: "RecYear", width: "75px", title: "Rec. Year" },
                { field: "RecMonth", width: "75px", title: "Rec. Mo." },
                { field: "RecNumber", width: "75px", title: "Rec. No." },
                { field: "RecStatus", width: "100px", title: "Rec. Status" },
                { field: "StatusDate", width: "75px", title: "Status Date", template: "#= (StatusDate == null || StatusDate == undefined || StatusDate == '' || StatusDate == 'Mon Jan 1 00:00:00 EST 1900' || StatusDate.toString().indexOf('1900') > -1 || StatusDate.toString().indexOf('1899') > -1) ? ' ' : kendo.toString(StatusDate, 'dd-MMM-yy') #" },
                { field: "Severityrating", width: "100px", title: "Severity" },
                { field: "Impact", width: "100px", title: "Rec. Impact" },
                { field: "RecPrimary", width: "200px", title: "Primary Rec. Type" },
                { field: "RecSecondary", width: "200px", title: "Secondary Rec. Type" },
                { field: "Recommendation", width: "450px", title: "Rec. Key Words", template: "#= Recommendation.length > 75 ? Recommendation.substr(0, 75) + ' ...': Recommendation #" },
                { field: "History", width: "100px", title: "History" },
                { field: "Itemno", width: "75px", title: "Equip. No." },
                { field: "Findingno", width: "75px", title: "Finding No." },
                { field: "PlantAreaAffected", width: "200px", title: "Plant Area Affected" },
                { field: "ProbableEquipmentDamageCost", width: "175px", title: "Probable Equipment Damage" },
                { field: "FaultType", width: "150px", title: "Fault Type" },
                { field: "DetectedWith", width: "100px", title: "Detected With" },
                { field: "RedundancySpare", width: "250px", title: "Redundancy Spare" },
                { field: "IntendedAction", width: "250px", title: "Intended Action" },
                { field: "ResponseDate", width: "75px", title: "Resp. Date", template: "#= (ResponseDate == null || ResponseDate == undefined || ResponseDate == '' || ResponseDate == 'Mon Jan 1 00:00:00 EST 1900' || ResponseDate.toString().indexOf('1900') > -1 || ResponseDate.toString().indexOf('1899') > -1) ? ' ' : kendo.toString(ResponseDate, 'dd-MMM-yy') #" },
                { field: "ResponseFrom", width: "150px", title: "Resp. From" },
                { field: "PlantComment", width: "450px", title: "Facility Comment", template: "#= PlantComment.length > 75 ? PlantComment.substr(0, 75) + ' ...': PlantComment #" },
                { field: "ExpdComplDate", width: "125px", title: "Expd. Compl. Date", template: "#= (ExpectedCompletionDate == null || ExpectedCompletionDate == undefined || ExpectedCompletionDate == '' || ExpectedCompletionDate == 'Mon Jan 1 00:00:00 EST 1900' || ExpectedCompletionDate.toString().indexOf('1900') > -1 || ExpectedCompletionDate.toString().indexOf('1899') > -1) ? ' ' : kendo.toString(ExpectedCompletionDate, 'dd-MMM-yy') #" },
                { field: "MgmtRespAction", width: "250px", title: "Mgmt. Action" },
                { field: "MgmtRespDate", width: "125px", title: "Mgmt. Resp. Date", template: "#= (MgmtRespDate == null || MgmtRespDate == undefined || MgmtRespDate == '' || MgmtRespDate == '1/1/00' || MgmtRespDate == '1/1/1900' || MgmtRespDate == '01-Jan-00' || MgmtRespDate == 'Mon Jan 1 00:00:00 EST 1900' || MgmtRespDate.toString().indexOf('1900') > -1 || MgmtRespDate.toString().indexOf('1899') > -1) ? ' ' : kendo.toString(MgmtRespDate, 'dd-MMM-yy') #" },
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
                { field: "IdWeb", width: "0px", title: "", filterable: false, sortable: false, template: "<a name='#=IdWeb#' id='#=Id#'>#=IdWeb#</a>" },
                { field: "RecYear", width: "75px", title: "Rec. Year" },
                { field: "RecMonth", width: "75px", title: "Rec. Mo." },
                { field: "RecNumber", width: "75px", title: "Rec. No." },
                { field: "RecStatus", width: "100px", title: "Rec. Status" },
                { field: "StatusDate", width: "75px", title: "Status Date", template: "#= (StatusDate == null || StatusDate == undefined || StatusDate == '' || StatusDate == 'Mon Jan 1 00:00:00 EST 1900' || StatusDate.toString().indexOf('1900') > -1 || StatusDate.toString().indexOf('1899') > -1) ? ' ' : kendo.toString(StatusDate, 'dd-MMM-yy') #" },
                { field: "Severityrating", width: "100px", title: "Severity" },
                { field: "Impact", width: "100px", title: "Rec. Impact" },
                { field: "RecPrimary", width: "200px", title: "Primary Rec. Type" },
                { field: "RecSecondary", width: "200px", title: "Secondary Rec. Type" },
                { field: "Recommendation", width: "450px", title: "Rec. Key Words", template: "#= Recommendation.length > 75 ? Recommendation.substr(0, 75) + ' ...': Recommendation #" },
                { field: "History", width: "100px", title: "History" },
                { field: "Itemno", width: "75px", title: "Equip. No." },
                { field: "Findingno", width: "75px", title: "Finding No." },
                { field: "PlantAreaAffected", width: "200px", title: "Plant Area Affected" },
                { field: "ProbableEquipmentDamageCost", width: "175px", title: "Probable Equipment Damage" },
                { field: "FaultType", width: "150px", title: "Fault Type" },
                { field: "DetectedWith", width: "100px", title: "Detected With" },
                { field: "RedundancySpare", width: "250px", title: "Redundancy Spare" },
                { field: "IntendedAction", width: "250px", title: "Intended Action" },
                { field: "ResponseDate", width: "75px", title: "Resp. Date", template: "#= (ResponseDate == null || ResponseDate == undefined || ResponseDate == '' || ResponseDate == 'Mon Jan 1 00:00:00 EST 1900' || ResponseDate.toString().indexOf('1900') > -1 || ResponseDate.toString().indexOf('1899') > -1) ? ' ' : kendo.toString(ResponseDate, 'dd-MMM-yy') #" },
                { field: "ResponseFrom", width: "150px", title: "Resp. From" },
                { field: "PlantComment", width: "450px", title: "Facility Comment", template: "#= PlantComment.length > 75 ? PlantComment.substr(0, 75) + ' ...': PlantComment #" },
                { field: "ExpdComplDate", width: "125px", title: "Expd. Compl. Date", template: "#= (ExpectedCompletionDate == null || ExpectedCompletionDate == undefined || ExpectedCompletionDate == '' || ExpectedCompletionDate == 'Mon Jan 1 00:00:00 EST 1900' || ExpectedCompletionDate.toString().indexOf('1900') > -1 || ExpectedCompletionDate.toString().indexOf('1899') > -1) ? ' ' : kendo.toString(ExpectedCompletionDate, 'dd-MMM-yy') #" }
            ]
        }).data("kendoGrid");
        }


        ///////////////////////////////////////////
        //// ACTIVATE BINDINGS LAST
        ko.applyBindings(view, $("#view")[0]);
        ko.applyBindings(view, $("#view2")[0]);
        ko.applyBindings(viewFindCriteria, $("#viewFindCriteria")[0]);


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
        $(document).find(".k-window-title").append("<img src='../images/icons/warning/window_warning_24x24.png' align='left' alt='Warning Icon' class='windowIcon'/>  " + view.objLanguageLabels().lblNoLocationFoundTitle);

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
        view.setupFindFields();
        view.resetPickers();

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
        var tempUrl = "rectracking.aspx?sid=" + getGSafeGUID() + "&rec=" + dataItem.IdWeb;
        document.location.href = tempUrl;
    }

</script>--%>

</asp:Content>
