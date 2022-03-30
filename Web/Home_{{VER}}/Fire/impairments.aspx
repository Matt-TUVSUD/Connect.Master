<%@ Page Title="Fire Impairments | Global Risk Consultants" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectServerDetail.Master" CodeBehind="impairments.aspx.vb" Inherits="GRC.Connect.Web.impairments_fire" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-grid.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/rectracking.css" />
    <script src="../../Lib_{{VER}}/Generated/ViewCCLocationListingFire.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCLocationListingFire.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCImpairmentsFormFire.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCImpairmentsFormFire.js" type="text/javascript"></script>

</asp:Content>

<asp:Content ID="ContentFindCriteria" ContentPlaceHolderID="ContentFindCriteria" runat="server">
    <div class="headerFindCriteria" id="viewFindCriteria" data-bind="with: viewFindCriteria">
        <label data-bind="text: $parent.findCriteria" id="findCriteria"></label>&nbsp;
    </div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="view" data-bind="with: view">
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
            <span class="companyLabels1"></span>
            <span class="buttonContainerLocationLoading">
                <span><button data-bind="click: $parent.onFileFirst, enable: $parent.enableFilePrev" type="button" class="k-button buttonShape k-icon k-i-seek-w" id="btnFileFirst" tabindex="15"></button></span>
                <span><button data-bind="click: $parent.onFilePrevious, enable: $parent.enableFilePrev" type="button" class="k-button buttonShape k-icon k-i-arrow-w" id="btnFilePrevious" tabindex="16"></button></span>
                <span class="buttonFileRecordLabel" style="width: 130px;">&nbsp;<label data-bind="text: $parent.objLanguageLabels().lblFileRecord">Location</label> <input data-bind="value: $parent.txtFileRecordNumber" id="txtFileRecordNumber" class="k-autocomplete k-input inputCenter inputNoEdit buttonInput" style="width: 80px; margin-bottom: 3px;" readonly="true" />&nbsp;</span>
                <span><button data-bind="click: $parent.onFileNext, enable: $parent.enableFileNext" type="button" class="k-button buttonShape k-icon k-i-arrow-e" id="btnFileNext" tabindex="17"></button></span>
                <span><button data-bind="click: $parent.onFileLast, enable: $parent.enableFileNext" type="button" class="k-button buttonShape k-icon k-i-seek-e" id="btnFileLast" tabindex="18"></button></span>
                <span>&nbsp;</span>
                <span><button data-bind="click: $parent.onFindClear, css: { hidden: $parent.findEngaged }" type="button" class="k-button buttonFindClearShape hidden" tabindex="13">Clear Find</button></span>
                <span><button data-bind="click: $parent.onFind" class="k-button buttonShape" type="submit" style="width: 0px; line-height: normal; border-color: White; background-color: White; padding: 0; margin: 0;" tabindex="14"></button></span>
            </span>
            <!-- END BUTTONS FOR LOCATION / FILE NUMBER WALK / FIND LOCATION -->
            <span class="companyLabels6"><label data-bind="text: $parent.objLanguageLabels().lblCustomerAccess, css: { findOn: $parent.objFind().findCustomAccess, findOff: !$parent.objFind().findCustomAccess }">Custom Access</label></span>
            <span class="companyInputs5"><input data-bind="value: $parent.objListing().CustomAccess, css: { findOnInput: $parent.objFind().findCustomAccess, findOffInput: !$parent.objFind().findCustomAccess }" id="CustomAccess" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="12"  /></span>
        </div>
    </div>
    <!-- END TABLE FOR COMPANY / ADDRESS INFORMATION -->
</div>

<br />&nbsp;<br />

<!-- TABLE FOR IMPAIRMENTS INFORMATION -->
<!-- THE GRID -->
<div id="gridContainer" style="clear: both;">
    <div id="gridImpairments" style="width: 810px; height: 325px;"></div>
    <div id="view2" data-bind="with: view" class="k-pager-wrap k-grid-pager" style="height: 22px; width: 806px;"></div>
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
            lblRecord: "Record",
            lblFileRecord: "Location"
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
            collImpairments: new es.objects.ViewCCImpairmentsFormFireCollection(),
            collListing: new es.objects.ViewCCLocationListingFireCollection(),
            collGrid: ko.observableArray(),

            objImpairments: ko.observable(),
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
                if (view.index < view.collImpairments().length - 1) {
                    view.index++;
                    view.objImpairments(view.collImpairments()[view.index]);
                }
                view.setupButtons();
                view.resetPickers();
            },

            onPrevious: function () {
                if (view.index > 0) {
                    view.index--;
                    view.objImpairments(view.collImpairments()[view.index]);
                }
                view.setupButtons();
                view.resetPickers();
            },

            onFirst: function () {
                if (view.index > 0) {
                    view.index = 0;
                    view.objImpairments(view.collImpairments()[view.index]);
                }
                view.setupButtons();
                view.resetPickers();
            },

            onLast: function () {
                if (view.index < view.collImpairments().length - 1) {
                    view.index = view.collImpairments().length - 1;
                    view.objImpairments(view.collImpairments()[view.index]);
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

            onSelect: function () {
            },

            onExport: function () {
            },

            //// ENABLE OR DISABLE BUTTONS AND SHOW RECORD NUMBER
            setupButtons: function () {
                if (view.index == 0) { view.enablePrev(false); } else { view.enablePrev(true); }
                if (view.index == view.collImpairments().length - 1) { view.enableNext(false); } else { view.enableNext(true); }
                view.txtRecordNumber((view.index + 1) + " of " + view.collImpairments().length);
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
                gridImpairments.dataSource.data(view.collGrid());
                gridImpairments.dataSource.page(1);
            },

            //// BUILD THE DATASOURCE FOR THE GRID
            buildGrid: function () {
                view.collGrid([]);
                for (y = 0; y < view.collImpairments().length; y++) {
                    if (view.collImpairments()[y].FileNo() == view.objListing().FileNo()) {
                        view.collGrid().push({
                            ID: view.collImpairments()[y].Id(),
                            FileNo: view.collImpairments()[y].FileNo(),
                            Client: view.collImpairments()[y].Client(),
                            NotifiedVia: view.collImpairments()[y].NotifiedVia(),
                            Office: view.collImpairments()[y].Office(),
                            Status: view.collImpairments()[y].Status(),
                            DateReceived: view.collImpairments()[y].DateReceived(),
                            ImpairmentDate: view.collImpairments()[y].ImpairmentDate(),
                            Duration1: view.collImpairments()[y].Duration1(),
                            Duration2: view.collImpairments()[y].Duration2(),
                            DateRestored: view.collImpairments()[y].DateRestored(),
                            ActualNoOfDays: view.collImpairments()[y].ActualNoOfDays(),
                            EquipmentTagged: view.collImpairments()[y].EquipmentTagged(),
                            TagNo: view.collImpairments()[y].TagNo(),
                            EquipmentDescription: view.collImpairments()[y].EquipmentDescription(),
                            CauseForImpairment: view.collImpairments()[y].CauseForImpairment(),
                            ImpairmentSummary: view.collImpairments()[y].ImpairmentSummary(),
                            FollowUpCall: view.collImpairments()[y].FollowUpCall(),
                            FollowUpComment: view.collImpairments()[y].FollowUpComment(),
                            FollowUpCall2: view.collImpairments()[y].FollowUpCall2(),
                            FollowUpComment2: view.collImpairments()[y].FollowUpComment2(),
                            PlantContact: view.collImpairments()[y].PlantContact(),
                            PhoneNumber: view.collImpairments()[y].PhoneNumber(),
                            FaxNumber: view.collImpairments()[y].FaxNumber(),
                            EMail: view.collImpairments()[y].EMail(),
                            Address1: view.collImpairments()[y].Address1(),
                            City: view.collImpairments()[y].City(),
                            StProv: view.collImpairments()[y].StProv(),
                            Zip: view.collImpairments()[y].Zip(),
                            Country: view.collImpairments()[y].Country(),
                            ClientLocNo: view.collImpairments()[y].ClientLocNo(),
                            Facility: view.collImpairments()[y].Facility()
                        });
                    }
                }
            },

            //// LOAD RECORDS
            loadFileNumber: function () {
                var tempParm = view.gSafeGuid + "|" + view.fileDirection();
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collListing.ViewCCLocationFireRecommendationCollections(tempParm)) {
                    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                    if (!view.collImpairments.ViewCCImpairmentsFormFireCollections(view.gSafeGuid)) {
                        //view.objImpairments(view.collImpairments()[0]);
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
                        view.messageError("* Error while loading Impairment Details.");
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
        var dsImpairments = new kendo.data.DataSource({
            serverOperation: false,
            data: view.collGrid(),
            schema: {
                model: {
                    id: "FileNo",
                    fields: {
                        ID: { type: "string", editable: false },
                        FileNo: { type: "string", editable: false },
                        Client: { type: "string", editable: false },
                        NotifiedVia: { type: "string", editable: false },
                        Office: { type: "string", editable: false },
                        Status: { type: "string", editable: false },
                        DateReceived: { type: "date", editable: false },
                        ImpairmentDate: { type: "date", editable: false },
                        Duration1: { type: "string", editable: false },
                        Duration2: { type: "string", editable: false },
                        DateRestored: { type: "date", editable: false },
                        ActualNoOfDays: { type: "string", editable: false },
                        EquipmentTagged: { type: "string", editable: false },
                        TagNo: { type: "string", editable: false },
                        EquipmentDescription: { type: "string", editable: false },
                        CauseForImpairment: { type: "string", editable: false },
                        ImpairmentSummary: { type: "string", editable: false },
                        FollowUpCall: { type: "date", editable: false },
                        FollowUpComment: { type: "string", editable: false },
                        FollowUpCall2: { type: "date", editable: false },
                        FollowUpComment2: { type: "string", editable: false },
                        PlantContact: { type: "string", editable: false },
                        PhoneNumber: { type: "string", editable: false },
                        FaxNumber: { type: "string", editable: false },
                        EMail: { type: "string", editable: false },
                        Address1: { type: "string", editable: false },
                        City: { type: "string", editable: false },
                        StProv: { type: "string", editable: false },
                        Zip: { type: "string", editable: false },
                        Country: { type: "string", editable: false },
                        ClientLocNo: { type: "string", editable: false },
                        Facility: { type: "string", editable: false }
                    }
                }
            }
        });

        ///////////////////////////////////////////
        //// SETUP THE GRID
        var gridImpairments = $("#gridImpairments").kendoGrid({
            dataSource: dsImpairments,
            width: 885,
            height: 325,
            pageable: false,
            scrollable: true,
            sortable: true,
            filterable: true,
            editable: false,
            selectable: "row",
            columns: [
                { field: "ID", width: "50px", title: "ID" },
                { field: "FileNo", width: "75px", title: "File No." },
                { field: "Client", width: "150px", title: "Client" },
                { field: "ClientLocNo", width: "100px", title: "Client Loc. No." },
                { field: "Facility", width: "125px", title: "Facility" },
                { field: "Address1", width: "250px", title: "Address" },
                { field: "City", width: "150px", title: "City" },
                { field: "StProv", width: "125px", title: "St. / Prov." },
                { field: "Zip", width: "100px", title: "Zip / Postal" },
                { field: "Country", width: "150px", title: "Country" },
                { field: "NotifiedVia", width: "100px", title: "Notified Via" },
                { field: "Office", width: "100px", title: "Office" },
                { field: "Status", width: "100px", title: "Status" },
                { field: "DateReceived", width: "150px", title: "Date Received", template: "#= (DateReceived == null || DateReceived == undefined || DateReceived == '') ? ' ' : kendo.toString(DateReceived, 'dd-MMM-yy') #" },
                { field: "ImpairmentDate", width: "150px", title: "Impairment Date", template: "#= (ImpairmentDate == null || ImpairmentDate == undefined || ImpairmentDate == '') ? ' ' : kendo.toString(ImpairmentDate, 'dd-MMM-yy') #" },
                { field: "Duration1", width: "100px", title: "Duration 1" },
                { field: "Duration2", width: "100px", title: "Duration 2" },
                { field: "DateRestored", width: "100px", title: "Date Restored", template: "#= (DateRestored == null || DateRestored == undefined || DateRestored == '') ? ' ' : kendo.toString(DateRestored, 'dd-MMM-yy') #" },
                { field: "ActualNoOfDays", width: "125px", title: "Actual No. Of Days" },
                { field: "EquipmentTagged", width: "125px", title: "Equipment Tagged" },
                { field: "TagNo", width: "100px", title: "Tag No." },
                { field: "EquipmentDescription", width: "200px", title: "Equipment Description" },
                { field: "CauseForImpairment", width: "150px", title: "Cause For Impairment" },
                { field: "ImpairmentSummary", width: "350px", title: "Impairment Summary", template: "#= ImpairmentSummary.length > 65 ? ImpairmentSummary.substr(0, 65) + ' ...': ImpairmentSummary #" },
                { field: "FollowUpCall", width: "125px", title: "Follow Up Call 1", template: "#= (FollowUpCall == null || FollowUpCall == undefined || FollowUpCall == '') ? ' ' : kendo.toString(FollowUpCall, 'dd-MMM-yy') #" },
                { field: "FollowUpComment", width: "300px", title: "Follow Up Comment 1", template: "#= FollowUpComment.length > 50 ? FollowUpComment.substr(0, 50) + ' ...': FollowUpComment #" },
                { field: "FollowUpCall2", width: "125px", title: "Follow Up Call 2", template: "#= (FollowUpCall2 == null || FollowUpCall2 == undefined || FollowUpCall2 == '') ? ' ' : kendo.toString(FollowUpCall2, 'dd-MMM-yy') #" },
                { field: "FollowUpComment2", width: "300px", title: "Follow Up Comment 2", template: "#= FollowUpComment2.length > 50 ? FollowUpComment2.substr(0, 50) + ' ...': FollowUpComment2 #" },
                { field: "PlantContact", width: "250px", title: "Plant Contact" },
                { field: "PhoneNumber", width: "100px", title: "Phone Number" },
                { field: "FaxNumber", width: "100px", title: "Fax Number" },
                { field: "EMail", width: "175px", title: "EMail" }
            ]
        }).data("kendoGrid");


        ///////////////////////////////////////////
        //// ACTIVATE BINDINGS LAST
        ko.applyBindings(view, $("#view")[0]);
        ko.applyBindings(view, $("#view2")[0]);
        ko.applyBindings(viewFindCriteria, $("#viewFindCriteria")[0]);


        ///////////////////////////////////////////
        //// SETUP KENDOUI
        //// TEXTBOXES
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
    });
</script>

</asp:Content>
