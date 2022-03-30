<%@ Page Title="Rec. Response Grid | Global Risk Consultants" Language="vb" AutoEventWireup="false" MasterPageFile="~/RecResponse_{{VER}}/ClientConnectRecResponse.Master" CodeBehind="recdatasheet.aspx.vb" Inherits="GRC.Connect.Web.recdatasheet_fire_recresponse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-grid.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/rectracking.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/rectracking_translation.css" />
    <script src="../../Lib_{{VER}}/Generated/ViewCCLocationListingRecResponseFire.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCLocationListingRecResponseFire.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCFireRecommendationGrid.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCFireRecommendationGrid.js" type="text/javascript"></script>
    <%--<script src="../../Lib_{{VER}}/KendoUI/kendo.all.min.js" type="text/javascript"></script>--%>

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="view" data-bind="with: view">
    <!-- TABLE FOR COMPANY / ADDRESS INFORMATION -->
    <!-- SPECIFIC STYLES TO ROWS OR COLUMNS SHOULD BE INLINE -->
    <div class="tableDiv" style="width: 100%;">
        <div>
            <span class="companyLabels1"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblGRCLocNo">GRC Loc. No.</label></span>
            <span class="companyInputs1"><input readonly="true" data-bind="value: $parent.objListing().FileNo" id="FileNo" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs1" tabindex="1" /></span>
            <span class="companyLabels2"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblClientLocNo">Client Loc. No.</label></span>
            <span class="companyInputs2"><input readonly="true" data-bind="value: $parent.objListing().ClientLocNo" id="ClientLocNo" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs2" tabindex="2" /></span>
            <span class="companyLabels5"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblLatitude">Latitude</label></span>
            <span class="companyInputs4"><input readonly="true" data-bind="value: $parent.objListing().Latitude" id="Latitude" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs4" tabindex="3"  /></span>
            <span class="companyLabels4"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblLongitude">Longitude</label></span>
            <span class="companyInputs4"><input readonly="true" data-bind="value: $parent.objListing().Longitude" id="Longitude" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs4" tabindex="4"  /></span>
        </div>
        <div>
            <span class="companyLabels1"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblAddress1">Address</label></span>
            <span class="companyInputs6"><input readonly="true" data-bind="value: $parent.objListing().Address1" id="Address1" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs6" tabindex="5"  /></span>
            <span class="companyLabels3"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblDivisionName">Division Name</label></span>
            <span class="companyInputs5"><input readonly="true" data-bind="value: $parent.objListing().Division" id="Division" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="6"  /></span>
        </div>
        <div>
            <span class="companyLabels1"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblCity">City</label></span>
            <span class="companyInputs1"><input readonly="true" data-bind="value: $parent.objListing().City" id="City" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs1" tabindex="7"  /></span>
            <span class="stateLabels"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblState">State</label></span>
            <span class="stateInputs"><input readonly="true" data-bind="value: $parent.objListing().StProv" id="StProv" class="k-autocomplete k-input inputNoEdit inputLeft stateInputs" tabindex="8"  /></span>
            <span class="countryLabels"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblCountry">Country</label></span>
            <span class="countryInputs"><input readonly="true" data-bind="value: $parent.objListing().Country" id="Country" class="k-autocomplete k-input inputNoEdit inputLeft countryInputs" tabindex="9"  /></span>
            <span class="postalLabels"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblPostalCode">Postal</label></span>
            <span class="postalInputs"><input readonly="true" data-bind="value: $parent.objListing().Zip" id="Zip" class="k-autocomplete k-input inputNoEdit inputLeft postalInputs" tabindex="10"  /></span>
            <span class="companyLabels3"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblFacilityName">Facility Name</label></span>
            <span class="companyInputs5"><input readonly="true" data-bind="value: $parent.objListing().Facility" id="Facility" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="11"  /></span>
        </div>
        <div>
            <!-- BUTTONS FOR LOCATION / FILE NUMBER WALK / FIND LOCATION -->
            <span class="companyLabels1"><%--<img data-bind="visible: $parent.loading" src="../../Home_{{VER}}/Images/loading/loadingdetails.gif" style="height: 20px; width: 75px; border: 0px;" alt="Loading" />--%></span>
            <span class="buttonContainerLocationLoading">
            </span>
            <!-- END BUTTONS FOR LOCATION / FILE NUMBER WALK / FIND LOCATION -->
            <span class="companyLabels6"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblCustomerAccess">Custom Access</label></span>
            <span class="companyInputs5"><input readonly="true" data-bind="value: $parent.objListing().CustomAccess" id="CustomAccess" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="12"  /></span>
        </div>
    </div>
    <!-- END TABLE FOR COMPANY / ADDRESS INFORMATION -->

    <!-- AREA FOR ERROR AND NOTICE MESSAGES -->
    <div style="padding-top: 20px;"><label class="messageError" data-bind="text: $parent.messageError"></label><label class="messageNotice" data-bind="text: $parent.messageNotice"></label><label class="messageWarning" data-bind="text: $parent.messageWarning"></label>&nbsp;</div>

    <!-- ERROR WINDOW FOR NO RECORD FOUND NOTIFICATION -->
    <div id="windowNoLocation" class="windowContent">
        <div><img src="../../Home_{{VER}}/images/icons/warning/sign_warning_32x32.png" align="left" alt="Warning" class="windowImage" /></div>
        <div><label data-bind="text: $parent.objLanguageLabels().lblNoLocationFoundMessage">Warning: There are no recommendation records found for this location.</label></div>
        <br />&nbsp;<br />
        <div><label data-bind="text: $parent.objLanguageLabels().lblPleaseLogOutAndTryAgain">Please log out and try again.</label></div>
    </div>

</div>

<!-- TABLE FOR RECOMMENDATION TRACKING INFORMATION -->
<!-- THE GRID -->
<div id="gridContainer" style="clear: both;">
    <div id="gridRecDatasheet" style="width: 945px; height: 325px;"></div>
    <div id="view2" data-bind="with: view" class="k-pager-wrap k-grid-pager" style="height: 22px; width: 940px;">
        <%--<button class="k-button k-button-padding k-button-100wide" style="line-height: 1.5em;" id="btnExport" data-bind="click: $parent.onExport">Export</button>--%>
        &nbsp;
    </div>
</div>

<br />&nbsp;<br />

<script type="text/javascript">
    $(document).ready(function () {
        ///////////////////////////////////////////
        //// LOAD SESSION VARIABLES
        var dsLanguageLabels = {};

        var dsLanguageOptions = [
            dsLanguageLabels.lblChooseLanguage,
            "Deutsch",
            "English",
            "Español",
            "Français",
            "Italiano",
            "Português"
        ];

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
        var viewFindCriteria = {
            findCriteria: ko.observable()
        };

        var viewMaster = {
            objLanguageLabels: ko.observable(dsLanguageLabels),
            KOLanguageSelector: ko.observableArray(dsLanguageOptions),
            objLanguageSelector: ko.observable(),
            clientFeatures: ko.observable("<%= ServerSide_ClientFeatures %>"),
            onCloseLanguageSelector: function () {
                //// UPDATE DSLANGUAGELABELS
                switch (viewMaster.objLanguageSelector().toLowerCase()) {
                    case dsLanguageLabels.lblChooseLanguage:
                        //// DO NOTHING, THE USER DOES NOT WANT TO MAKE A CHANGE
                        break;
                    case "deutsch":
                        view.loadLabelTranslations("german");
                        view.preferenceLanguage = "german";
                        break;
                    case "english":
                        view.loadLabelTranslations("english");
                        view.preferenceLanguage = "english";
                        break;
                    case "español":
                        view.loadLabelTranslations("spanish");
                        view.preferenceLanguage = "spanish";
                        break;
                    case "français":
                        view.loadLabelTranslations("french");
                        view.preferenceLanguage = "french";
                        break;
                    case "italiano":
                        view.loadLabelTranslations("italian");
                        view.preferenceLanguage = "italian";
                        break;
                    case "português":
                        view.loadLabelTranslations("portuguese");
                        view.preferenceLanguage = "portuguese";
                        break;
                    default:
                        //// DO NOTHING, THE USER DOES NOT WANT TO MAKE A CHANGE
                        break;
                }
                view.resetPickers();
                view.setupButtons();
                view.saveLanguageSelection();

                //// MANUALLY RESET THE LANGUAGE USED ON MASTER PAGE POPUPS AND LOCAL POPUP TITLES
                $("#lblWindowResponded_Warning").html(viewMaster.objLanguageLabels().lblWindowResponded_Warning);
                $("#lblWindowResponded_AreYouSure").html(viewMaster.objLanguageLabels().lblWindowResponded_AreYouSure);
                $("#lblWindowResponded_ClickCancelToContinueWorking").html(viewMaster.objLanguageLabels().lblWindowResponded_ClickCancelToContinueWorking);
                $("#lblWindowResponded_ClickOKToExit").html(viewMaster.objLanguageLabels().lblWindowResponded_ClickOKToExit);
                $("#btnYes").html(viewMaster.objLanguageLabels().lblOK);
                $("#btnCancel").html(viewMaster.objLanguageLabels().lblCancel);
                $("#windowRecNotCompleted").prev().find(".k-window-title").html("<img src='../../Home_{{VER}}/images/icons/reports/document_information_24x24.png' align='left' alt='Information Icon' class='windowIcon'/>  " + viewMaster.objLanguageLabels().lblWindowResponded_Title);

                $("#lblWindowRespondedDatasheet_Warning").html(viewMaster.objLanguageLabels().lblWindowResponded_Warning);
                $("#lblWindowRespondedDatasheet_AreYouSure").html(viewMaster.objLanguageLabels().lblWindowResponded_AreYouSure);
                $("#lblWindowRespondedDatasheet_ClickCancelToContinueWorking").html(viewMaster.objLanguageLabels().lblWindowResponded_ClickCancelToContinueWorking);
                $("#lblWindowRespondedDatasheet_ClickOKToExit").html(viewMaster.objLanguageLabels().lblWindowResponded_ClickOKToExit);
                $("#btnYesDatasheet").html(viewMaster.objLanguageLabels().lblOK);
                $("#btnCancelDatasheet").html(viewMaster.objLanguageLabels().lblCancel);
                $("#windowRecNotCompletedDatasheet").prev().find(".k-window-title").html("<img src='../../Home_{{VER}}/images/icons/reports/document_information_24x24.png' align='left' alt='Information Icon' class='windowIcon'/>  " + viewMaster.objLanguageLabels().lblWindowResponded_Title);

                $(document).find(".k-window-title").html("<img src='../../Home_{{VER}}/images/icons/warning/window_warning_24x24.png' align='left' alt='Warning Icon' class='windowIcon'/>  " + view.objLanguageLabels().lblNoLocationFoundTitle);
            }
        };

        // GLOBAL VARIABLES
        gRecId = null;

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
            columnTitles: [],

            //// COLLECTIONS / OBJECTS
            //// CHANGE THE NAME OF THE ES.OBJECTS PROTOTYPE
            gSafeGuid: "none",
            fullName: "<%= ServerSide_FullName %>",
            emailAddress: "<%= ServerSide_EmailAddress %>",
            fileNo: "<%= ServerSide_FileNo %>",
            enableMgmtFields: ko.observable(global_MgmtFields),
            clientFeatures: ko.observable("<%= ServerSide_ClientFeatures %>"),
            ToFireReport: ko.observable("<%= ServerSide_ToFireReport %>"),
            ToFireDiagram: ko.observable("<%= ServerSide_ToFireDiagram %>"),
            cldbName: "<%= ServerSide_cldbName %>",
            preferenceLanguage: "<%= ServerSide_LanguagePreference %>",
            RRLogGuid: "<%= ServerSide_RRLogGuid %>",

            collRec: new es.objects.ViewCCFireRecommendationGridCollection(),
            collListing: new es.objects.ViewCCLocationListingRecResponseFireCollection(),
            collRRLog: new es.objects.RRLogCollection(),
            collGrid: ko.observableArray(),
            collImpact: new es.objects.ViewCCTranslationImpactCollection(),
            collIntendedaction: new es.objects.ViewCCTranslationIntendedActionCollection(),
            collIntendedactionMgmt: new es.objects.ViewCCTranslationMgmtIntendedActionCollection(),
            collStatus: new es.objects.ViewCCTranslationRecStatusCollection(),
            collPrimaryrectype: new es.objects.ViewCCTranslationPrimaryRecCollection(),
            collSecondaryrectype: new es.objects.ViewCCTranslationSecondaryRecCollection(),
            collHazard: new es.objects.ViewCCTranslationHazardCollection(), // HAZARD

            objRec: ko.observable(),
            objListing: ko.observable(),
            objLanguageLabels: ko.observable(dsLanguageLabels),
            objFind: ko.observable(),
            objRRLog: ko.observable(),
            //objImpactList: new Array(),
            //objIntendedActionList: new Array(),
            //objStatusList: new Array(),
            //objPrimaryRecTypeList: new Array(),
            //objSecondaryRecTypeList: new Array(),

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
                if (view.enableMgmtFields() == true) {
                    Header = buildXMLRecHeaderMgmt();
                    Content = buildXMLStringMgmt(gridRecDatasheet.dataSource._view, view.objListing());
                    Footer = buildXMLRecFooterMgmt();
                } else {
                    Header = buildXMLRecHeader();
                    Content = buildXMLString(gridRecDatasheet.dataSource._view, view.objListing());
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

            //// RESET FIELDS ON LOAD RECORD
            resetPickers: function () {
                //// REFRESH THE GRID DATA
                view.loadCollections();
                view.buildGrid();
                gridRecDatasheet.dataSource.data(view.collGrid());
                gridRecDatasheet.dataSource.page(1);

                //// REFRESH THE GRID TITLES
                view.createColumnTitles();
                $("#gridRecDatasheet th .k-link").each(function (index) {
                    this.innerText = view.columnTitles[index];
                });

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

            loadRRLog: function () {
                es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
                if (!view.collRRLog.GetRecordByGuid(view.RRLogGuid)) {
                    view.objRRLog(view.collRRLog()[0]);
                } else {
                    alert(view.objLanguageLabels().lblErrorLoadingRecResponseLogRecord);
                }
            },

            saveLanguageSelection: function () {
                //// SAVE THE RRLOG RECORD
                view.objRRLog().LanguagePreference(view.preferenceLanguage);
                objTempRRLog = new es.objects.RRLog();
                objTempRRLog = view.objRRLog();
                es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
                objTempRRLog.save();
            },

            loadLabelTranslations: function (pLanguage) {
                dsLanguageLabels = {};
                var tempLanguage = pLanguage.toLowerCase();
                tempLabelColl = new es.objects.ViewCCTranslationCollection();
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!tempLabelColl.GetTranslationByPage("1|" + tempLanguage)) {
                    switch (tempLanguage) {
                        case "english":
                            for (x = 0; x < tempLabelColl().length; x++) {
                                dsLanguageLabels[tempLabelColl()[x].LabelName()] = tempLabelColl()[x].EnglishTranslation();
                            }
                            break;
                        case "spanish":
                            for (x = 0; x < tempLabelColl().length; x++) {
                                dsLanguageLabels[tempLabelColl()[x].LabelName()] = tempLabelColl()[x].SpanishTranslation();
                            }
                            break;
                        case "german":
                            for (x = 0; x < tempLabelColl().length; x++) {
                                dsLanguageLabels[tempLabelColl()[x].LabelName()] = tempLabelColl()[x].GermanTranslation();
                            }
                            break;
                        case "italian":
                            for (x = 0; x < tempLabelColl().length; x++) {
                                dsLanguageLabels[tempLabelColl()[x].LabelName()] = tempLabelColl()[x].ItalianTranslation();
                            }
                            break;
                        case "portuguese":
                            for (x = 0; x < tempLabelColl().length; x++) {
                                dsLanguageLabels[tempLabelColl()[x].LabelName()] = tempLabelColl()[x].PortugueseTranslation();
                            }
                            break;
                        case "french":
                            for (x = 0; x < tempLabelColl().length; x++) {
                                dsLanguageLabels[tempLabelColl()[x].LabelName()] = tempLabelColl()[x].FrenchTranslation();
                            }
                            break;
                        default:
                            //// DO NOTHING, THE USER DOES NOT WANT TO MAKE A CHANGE
                            break;
                    }
                }
                view.objLanguageLabels(dsLanguageLabels);
                viewMaster.objLanguageLabels(dsLanguageLabels);
                dsLanguageOptions[0] = dsLanguageLabels.lblChooseLanguage;
            },

            //// FUNCTIONS TO CREATE AND BUILD THE DATASOURCE AND THE GRID
            createGridObject: function () {
                if (view.enableMgmtFields() == false) {
                    gridRecDatasheet = $("#gridRecDatasheet").kendoGrid({
                        dataSource: dsRec,
                        width: 945, //885,
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
                        { field: "RecYear", width: "100px", title: view.objLanguageLabels().lblRecYear },
                        { field: "RecMo", width: "100px", title: view.objLanguageLabels().lblRecMonth },
                        { field: "RecNumber", width: "200px", title: view.objLanguageLabels().lblRecNo },
                        { field: "RecSubLetter", width: "100px", title: view.objLanguageLabels().lblRecSubletter },
                        { field: "RecStatus", width: "250px", title: view.objLanguageLabels().lblRecStatus },
                        { field: "StatusDate", width: "150px", title: view.objLanguageLabels().lblStatusDate, template: "#= (StatusDate == null || StatusDate == undefined || StatusDate == '' || StatusDate == '1/1/00' || StatusDate == '1/1/1900' || StatusDate == '01-Jan-00' || StatusDate == 'Mon Jan 1 00:00:00 EST 1900' || StatusDate.toString().indexOf('1900') > -1 || StatusDate.toString().indexOf('1899') > -1) ? ' ' : kendo.toString(StatusDate, 'dd-MMM-yy') #" },
                        { field: "RecImpact", width: "200px", title: view.objLanguageLabels().lblRecImpact },
                        { field: "Hazard", width: "100px", title: view.objLanguageLabels().lblHazard },
                        { field: "PrimaryRecType", width: "250px", title: view.objLanguageLabels().lblPrimaryRecType },
                        { field: "SecondaryRecType", width: "250px", title: view.objLanguageLabels().lblSecondaryRecType },
                        { field: "RecKeywords", width: "450px", title: view.objLanguageLabels().lblRecKeyWord, template: "#= RecKeywords.length > 75 ? RecKeywords.substr(0, 75) + ' ...': RecKeywords #" },
                        { field: "CurrentLERange", width: "250px", title: view.objLanguageLabels().lblCurrentLERange },
                        { field: "CompletedLERange", width: "250px", title: view.objLanguageLabels().lblCompleteLERange },
                        { field: "EstCostToCompleteRange", width: "250px", title: view.objLanguageLabels().lblEstimatedCostToCompleteRange },
                        { field: "ActualCostToComplete", width: "250px", title: view.objLanguageLabels().lblActCostToComplete },
                        { field: "SavingsRatio", width: "200px", title: view.objLanguageLabels().lblSavingsRatio },
                        { field: "IntendedAction", width: "325px", title: view.objLanguageLabels().lblRecIntendedAction },
                        { field: "RespDate", width: "150px", title: view.objLanguageLabels().lblRespDate, template: "#= (RespDate == null || RespDate == undefined || RespDate == '' || RespDate == '1/1/00' || RespDate == '1/1/1900' || RespDate == '01-Jan-00' || RespDate == 'Mon Jan 1 00:00:00 EST 1900' || RespDate.toString().indexOf('1900') > -1 || RespDate.toString().indexOf('1899') > -1) ? ' ' : kendo.toString(RespDate, 'dd-MMM-yy') #" },
                        { field: "RespFrom", width: "175px", title: view.objLanguageLabels().lblRespForm },
                        { field: "FacilityComment", width: "450px", title: view.objLanguageLabels().lblFacilityComment, template: "#= FacilityComment.length > 75 ? FacilityComment.substr(0, 75) + ' ...': FacilityComment #" },
                        { field: "ExpdComplDate", width: "250px", title: view.objLanguageLabels().lblExpdComplDate, template: "#= (ExpdComplDate == null || ExpdComplDate == undefined || ExpdComplDate == '' || ExpdComplDate == '1/1/00' || ExpdComplDate == '1/1/1900' || ExpdComplDate == '01-Jan-00' || ExpdComplDate == 'Mon Jan 1 00:00:00 EST 1900' || ExpdComplDate.toString().indexOf('1900') > -1 || ExpdComplDate.toString().indexOf('1899') > -1) ? ' ' : kendo.toString(ExpdComplDate, 'dd-MMM-yy') #" }
                    ]
                    }).data("kendoGrid");
                } else {
                    gridRecDatasheet = $("#gridRecDatasheet").kendoGrid({
                        dataSource: dsRec,
                        width: 945, //885,
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
                        { field: "RecYear", width: "100px", title: view.objLanguageLabels().lblRecYear },
                        { field: "RecMo", width: "100px", title: view.objLanguageLabels().lblRecMonth },
                        { field: "RecNumber", width: "200px", title: view.objLanguageLabels().lblRecNo },
                        { field: "RecSubLetter", width: "100px", title: view.objLanguageLabels().lblRecSubletter },
                        { field: "RecStatus", width: "250px", title: view.objLanguageLabels().lblRecStatus },
                        { field: "StatusDate", width: "150px", title: view.objLanguageLabels().lblStatusDate, template: "#= (StatusDate == null || StatusDate == undefined || StatusDate == '' || StatusDate == '1/1/00' || StatusDate == '1/1/1900' || StatusDate == '01-Jan-00' || StatusDate == 'Mon Jan 1 00:00:00 EST 1900' || StatusDate.toString().indexOf('1900') > -1 || StatusDate.toString().indexOf('1899') > -1) ? ' ' : kendo.toString(StatusDate, 'dd-MMM-yy') #" },
                        { field: "RecImpact", width: "200px", title: view.objLanguageLabels().lblRecImpact },
                        { field: "Hazard", width: "100px", title: view.objLanguageLabels().lblHazard },
                        { field: "PrimaryRecType", width: "250px", title: view.objLanguageLabels().lblPrimaryRecType },
                        { field: "SecondaryRecType", width: "250px", title: view.objLanguageLabels().lblSecondaryRecType },
                        { field: "RecKeywords", width: "450px", title: view.objLanguageLabels().lblRecKeyWord, template: "#= RecKeywords.length > 75 ? RecKeywords.substr(0, 75) + ' ...': RecKeywords #" },
                        { field: "CurrentLERange", width: "250px", title: view.objLanguageLabels().lblCurrentLERange },
                        { field: "CompletedLERange", width: "250px", title: view.objLanguageLabels().lblCompleteLERange },
                        { field: "EstCostToCompleteRange", width: "250px", title: view.objLanguageLabels().lblEstimatedCostToCompleteRange },
                        { field: "ActualCostToComplete", width: "250px", title: view.objLanguageLabels().lblActCostToComplete },
                        { field: "SavingsRatio", width: "200px", title: view.objLanguageLabels().lblSavingsRatio },
                        { field: "IntendedAction", width: "325px", title: view.objLanguageLabels().lblRecIntendedAction },
                        { field: "RespDate", width: "150px", title: view.objLanguageLabels().lblRespDate, template: "#= (RespDate == null || RespDate == undefined || RespDate == '' || RespDate == '1/1/00' || RespDate == '1/1/1900' || RespDate == '01-Jan-00' || RespDate == 'Mon Jan 1 00:00:00 EST 1900' || RespDate.toString().indexOf('1900') > -1 || RespDate.toString().indexOf('1899') > -1) ? ' ' : kendo.toString(RespDate, 'dd-MMM-yy') #" },
                        { field: "RespFrom", width: "175px", title: view.objLanguageLabels().lblRespForm },
                        { field: "FacilityComment", width: "450px", title: view.objLanguageLabels().lblFacilityComment, template: "#= FacilityComment.length > 75 ? FacilityComment.substr(0, 75) + ' ...': FacilityComment #" },
                        { field: "ExpdComplDate", width: "250px", title: view.objLanguageLabels().lblExpdComplDate, template: "#= (ExpdComplDate == null || ExpdComplDate == undefined || ExpdComplDate == '' || ExpdComplDate == '1/1/00' || ExpdComplDate == '1/1/1900' || ExpdComplDate == '01-Jan-00' || ExpdComplDate == 'Mon Jan 1 00:00:00 EST 1900' || ExpdComplDate.toString().indexOf('1900') > -1 || ExpdComplDate.toString().indexOf('1899') > -1) ? ' ' : kendo.toString(ExpdComplDate, 'dd-MMM-yy') #" },
                        { field: "MgmtRespAction", width: "250px", title: view.objLanguageLabels().lblMgmtRespAction },
                        { field: "MgmtRespDate", width: "125px", title: view.objLanguageLabels().lblMgmtRespDate, template: "#= (MgmtRespDate == null || MgmtRespDate == undefined || MgmtRespDate == '' || MgmtRespDate == '1/1/00' || MgmtRespDate == '1/1/1900' || MgmtRespDate == '01-Jan-00' || MgmtRespDate == 'Mon Jan 1 00:00:00 EST 1900' || MgmtRespDate.toString().indexOf('1900') > -1 || MgmtRespDate.toString().indexOf('1899') > -1) ? ' ' : kendo.toString(MgmtRespDate, 'dd-MMM-yy') #" },
                        { field: "MgmtRespFrom", width: "150px", title: view.objLanguageLabels().lblMgmtRespFrom },
                        { field: "MgmtRespComment", width: "450px", title: view.objLanguageLabels().lblMgmtComment, template: "#= MgmtRespComment.length > 75 ? MgmtRespComment.substr(0, 75) + ' ...': MgmtRespComment #" }
                    ]
                    }).data("kendoGrid");
                }
            },

            createColumnTitles: function () {
                view.columnTitles = [];
                view.columnTitles.push(view.objLanguageLabels().lblRecYear);
                view.columnTitles.push(view.objLanguageLabels().lblRecMonth);
                view.columnTitles.push(view.objLanguageLabels().lblRecNo);
                view.columnTitles.push(view.objLanguageLabels().lblRecSubletter);
                view.columnTitles.push(view.objLanguageLabels().lblRecStatus);
                view.columnTitles.push(view.objLanguageLabels().lblStatusDate);
                view.columnTitles.push(view.objLanguageLabels().lblRecImpact);
                view.columnTitles.push(view.objLanguageLabels().lblHazard);
                view.columnTitles.push(view.objLanguageLabels().lblPrimaryRecType);
                view.columnTitles.push(view.objLanguageLabels().lblSecondaryRecType);
                view.columnTitles.push(view.objLanguageLabels().lblRecKeyWord);
                view.columnTitles.push(view.objLanguageLabels().lblCurrentLERange);
                view.columnTitles.push(view.objLanguageLabels().lblCompleteLERange);
                view.columnTitles.push(view.objLanguageLabels().lblEstimatedCostToCompleteRange);
                view.columnTitles.push(view.objLanguageLabels().lblActCostToComplete);
                view.columnTitles.push(view.objLanguageLabels().lblSavingsRatio);
                view.columnTitles.push(view.objLanguageLabels().lblRecIntendedAction);
                view.columnTitles.push(view.objLanguageLabels().lblRespDate);
                view.columnTitles.push(view.objLanguageLabels().lblRespForm);
                view.columnTitles.push(view.objLanguageLabels().lblFacilityComment);
                view.columnTitles.push(view.objLanguageLabels().lblExpdComplDate);
                view.columnTitles.push(view.objLanguageLabels().lblMgmtRespAction);
                view.columnTitles.push(view.objLanguageLabels().lblMgmtRespDate);
                view.columnTitles.push(view.objLanguageLabels().lblMgmtRespFrom);
                view.columnTitles.push(view.objLanguageLabels().lblMgmtComment);
            },

            createDataSourceObject: function () {
                dsRec = new kendo.data.DataSource({
                    serverOperation: false,
                    data: view.collGrid(),
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
            },

            buildGrid: function () {
                view.collGrid([]);
                for (y = 0; y < view.collRec().length; y++) {
                    if (view.collRec()[y].FileNo() == view.objListing().FileNo()) {
                        view.collGrid().push({
                            Id: y,
                            FileNo: view.collRec()[y].FileNo(),
                            RecYear: view.collRec()[y].RecYear(),
                            RecMo: view.collRec()[y].RecMo(),
                            RecNumber: view.collRec()[y].RecNumber(),
                            RecSubLetter: view.collRec()[y].RecSubLetter(),
                            RecStatus: view.translateStatus(view.collRec()[y].RecStatus()),
                            StatusDate: view.collRec()[y].StatusDate(),
                            RecImpact: view.translateImpact(view.collRec()[y].RecImpact()),
                            Hazard: view.translateHazard(view.collRec()[y].Hazard()), //view.collRec()[y].Hazard(), // HAZARD
                            PrimaryRecType: view.translatePrimaryRecType(view.collRec()[y].PrimaryRecType()),
                            SecondaryRecType: view.translateSecondaryRecType(view.collRec()[y].SecondaryRecType()),
                            RecKeywords: view.collRec()[y].RecKeywords(),
                            CurrentLEActual: view.collRec()[y].CurrentLEActual(),
                            CurrentLERange: view.collRec()[y].CurrentLERange(),
                            CompletedLEActual: view.collRec()[y].CompletedLEActual(),
                            CompletedLERange: view.collRec()[y].CompletedLERange(),
                            EstCostToCompleteActual: view.collRec()[y].EstCostToCompleteActual(),
                            EstCostToCompleteRange: view.collRec()[y].EstCostToCompleteRange(),
                            ActualCostToComplete: view.collRec()[y].ActualCostToComplete(),
                            ExpdComplDate: view.collRec()[y].ExpdComplDate(),
                            SavingsRatio: view.collRec()[y].SavingsRatio(),
                            IntendedAction: view.translateIntendedAction(view.collRec()[y].IntendedAction()),
                            RespDate: view.collRec()[y].RespDate(),
                            RespFrom: view.collRec()[y].RespFrom(),
                            FacilityComment: view.collRec()[y].FacilityComment(),
                            MgmtRespAction: view.translateIntendedActionMgmt(view.collRec()[y].MgmtRespAction()),
                            MgmtRespDate: view.collRec()[y].MgmtRespDate(),
                            MgmtRespFrom: view.collRec()[y].MgmtRespFrom(),
                            MgmtRespComment: view.collRec()[y].MgmtRespComment()
                        });
                    }
                }
            },

            // HAZARD
            translateHazard: function (str) {
                var zReturn = str;
                for (z = 0; z < view.collHazard().length; z++) {
                    if (view.collHazard()[z].EnglishTranslation().toLowerCase() == str.toLowerCase()) {
                        switch (view.preferenceLanguage.toLowerCase()) {
                            case "german": zReturn = view.collHazard()[z].GermanTranslation(); break;
                            case "spanish": zReturn = view.collHazard()[z].SpanishTranslation(); break;
                            case "french": zReturn = view.collHazard()[z].FrenchTranslation(); break;
                            case "italian": zReturn = view.collHazard()[z].ItalianTranslation(); break;
                            case "portuguese": zReturn = view.collHazard()[z].PortugueseTranslation(); break;
                            default: zReturn = view.collHazard()[z].EnglishTranslation(); break;
                        }
                    }
                }
                return zReturn;
            },

            translateImpact: function (str) {
                var zReturn = str;
                for (z = 0; z < view.collImpact().length; z++) {
                    if (view.collImpact()[z].EnglishTranslation().toLowerCase() == str.toLowerCase()) {
                        switch (view.preferenceLanguage.toLowerCase()) {
                            case "german": zReturn = view.collImpact()[z].GermanTranslation(); break;
                            case "spanish": zReturn = view.collImpact()[z].SpanishTranslation(); break;
                            case "french": zReturn = view.collImpact()[z].FrenchTranslation(); break;
                            case "italian": zReturn = view.collImpact()[z].ItalianTranslation(); break;
                            case "portuguese": zReturn = view.collImpact()[z].PortugueseTranslation(); break;
                            default: zReturn = view.collImpact()[z].EnglishTranslation(); break;
                        }
                    }
                }
                return zReturn;
            },

            translateIntendedAction: function (str) {
                var zReturn = str;
                for (z = 0; z < view.collIntendedaction().length; z++) {
                    if (view.collIntendedaction()[z].EnglishTranslation().toLowerCase() == str.toLowerCase()) {
                        switch (view.preferenceLanguage.toLowerCase()) {
                            case "german": zReturn = view.collIntendedaction()[z].GermanTranslation(); break;
                            case "spanish": zReturn = view.collIntendedaction()[z].SpanishTranslation(); break;
                            case "french": zReturn = view.collIntendedaction()[z].FrenchTranslation(); break;
                            case "italian": zReturn = view.collIntendedaction()[z].ItalianTranslation(); break;
                            case "portuguese": zReturn = view.collIntendedaction()[z].PortugueseTranslation(); break;
                            default: zReturn = view.collIntendedaction()[z].EnglishTranslation(); break;
                        }
                    }
                }
                return zReturn;
            },

            translateIntendedActionMgmt: function (str) {
                var zReturn = str;
                for (z = 0; z < view.collIntendedactionMgmt().length; z++) {
                    if (view.collIntendedactionMgmt()[z].EnglishTranslation().toLowerCase() == str.toLowerCase()) {
                        switch (view.preferenceLanguage.toLowerCase()) {
                            case "german": zReturn = view.collIntendedactionMgmt()[z].GermanTranslation(); break;
                            case "spanish": zReturn = view.collIntendedactionMgmt()[z].SpanishTranslation(); break;
                            case "french": zReturn = view.collIntendedactionMgmt()[z].FrenchTranslation(); break;
                            case "italian": zReturn = view.collIntendedactionMgmt()[z].ItalianTranslation(); break;
                            case "portuguese": zReturn = view.collIntendedactionMgmt()[z].PortugueseTranslation(); break;
                            default: zReturn = view.collIntendedactionMgmt()[z].EnglishTranslation(); break;
                        }
                    }
                }
                return zReturn;
            },

            translateStatus: function (str) {
                var zReturn = str;
                for (z = 0; z < view.collStatus().length; z++) {
                    if (view.collStatus()[z].EnglishTranslation().toLowerCase() == str.toLowerCase()) {
                        switch (view.preferenceLanguage.toLowerCase()) {
                            case "german": zReturn = view.collStatus()[z].GermanTranslation(); break;
                            case "spanish": zReturn = view.collStatus()[z].SpanishTranslation(); break;
                            case "french": zReturn = view.collStatus()[z].FrenchTranslation(); break;
                            case "italian": zReturn = view.collStatus()[z].ItalianTranslation(); break;
                            case "portuguese": zReturn = view.collStatus()[z].PortugueseTranslation(); break;
                            default: zReturn = view.collStatus()[z].EnglishTranslation(); break;
                        }
                    }
                }
                return zReturn;
            },

            translatePrimaryRecType: function (str) {
                var zReturn = str;
                for (z = 0; z < view.collPrimaryrectype().length; z++) {
                    if (view.collPrimaryrectype()[z].EnglishTranslation().toLowerCase() == str.toLowerCase()) {
                        switch (view.preferenceLanguage.toLowerCase()) {
                            case "german": zReturn = view.collPrimaryrectype()[z].GermanTranslation(); break;
                            case "spanish": zReturn = view.collPrimaryrectype()[z].SpanishTranslation(); break;
                            case "french": zReturn = view.collPrimaryrectype()[z].FrenchTranslation(); break;
                            case "italian": zReturn = view.collPrimaryrectype()[z].ItalianTranslation(); break;
                            case "portuguese": zReturn = view.collPrimaryrectype()[z].PortugueseTranslation(); break;
                            default: zReturn = view.collPrimaryrectype()[z].EnglishTranslation(); break;
                        }
                    }
                }
                return zReturn;
            },

            translateSecondaryRecType: function (str) {
                var zReturn = str;
                for (z = 0; z < view.collSecondaryrectype().length; z++) {
                    if (view.collSecondaryrectype()[z].EnglishTranslation().toLowerCase() == str.toLowerCase()) {
                        switch (view.preferenceLanguage.toLowerCase()) {
                            case "german": zReturn = view.collSecondaryrectype()[z].GermanTranslation(); break;
                            case "spanish": zReturn = view.collSecondaryrectype()[z].SpanishTranslation(); break;
                            case "french": zReturn = view.collSecondaryrectype()[z].FrenchTranslation(); break;
                            case "italian": zReturn = view.collSecondaryrectype()[z].ItalianTranslation(); break;
                            case "portuguese": zReturn = view.collSecondaryrectype()[z].PortugueseTranslation(); break;
                            default: zReturn = view.collSecondaryrectype()[z].EnglishTranslation(); break;
                        }
                    }
                }
                return zReturn;
            },

            //// LOAD RECORDS
            loadFileNumber: function () {
                //var tempParm = view.gSafeGuid + "|" + view.fileDirection();
                var tempHemisphere = getHemisphere(calculate_time_zone());
                var tempParm = view.fileNo;
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collListing.GetRecResponseFireLocationByFileNo(tempParm + "|" + tempHemisphere)) {
                    
                    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                    if (!view.collRec.GetFireRecommendationGridByFileNo(tempParm + "|" + tempHemisphere)) {
                        view.loadLabelTranslations(view.preferenceLanguage);
                        view.objListing(view.collListing()[0]);
                        view.loadCollections();
                        view.buildGrid();
                        view.setupFileButtons();
                    } else {
                        view.messageError(view.objLanguageLabels().lblErrorWhileLoadingRecommendationDetails);
                    }
                } else {
                    view.messageError(view.objLanguageLabels().lblErrorWhileLoadingLocationListing);
                }
            },

            loadCollections: function () {
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collImpact.GetImpactTranslationByLanguage(view.preferenceLanguage)) { } else { view.messageError("* Error while loading Impact Data List."); }
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collIntendedaction.GetIntendedActionTranslationByLanguage(view.preferenceLanguage)) { } else { view.messageError("* Error while loading Intended Action Data List."); }
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collIntendedactionMgmt.GetIntendedActionMgmtTranslationByLanguageFilePrefix(view.preferenceLanguage + "|" + view.fileNo)) { } else { view.messageError("* Error while loading Intended Action Management Data List."); }
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collStatus.GetRecStatusTranslationByLanguage(view.preferenceLanguage)) { } else { view.messageError("* Error while loading Status Data List."); }
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collPrimaryrectype.GetPrimaryRecTranslationByLanguage(view.preferenceLanguage + "|" + view.collRec()[0].Hazard())) { } else { view.messageError("* Error while loading Primary Rec Data List."); }
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collSecondaryrectype.GetSecondaryRecTranslationByLanguage(view.preferenceLanguage + "|" + view.collRec()[0].Hazard())) { } else { view.messageError("* Error while loading Secondary Rec Data List."); }
                // HAZARD
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collHazard.GetHazardTranslationByLanguage(view.preferenceLanguage)) { } else { view.messageError("* Error while loading Hazard translations."); }
            }
        };


        ///////////////////////////////////////////
        //// LOAD THE DATA
        view.loadFileNumber();
        view.loadRRLog();
        viewMaster.objLanguageSelector(viewMaster.KOLanguageSelector()[0]);


        ///////////////////////////////////////////
        //// SETUP GRID DATASOURCE
        var dsRec; // = new kendo.data.DataSource({});
        view.createDataSourceObject();


        ///////////////////////////////////////////
        //// SETUP THE GRID
        var gridRecDatasheet; // = $("#gridRecDatasheet").kendoGrid({});
        view.createGridObject();


        ///////////////////////////////////////////
        //// ACTIVATE BINDINGS LAST
        ko.applyBindings(view, $("#view")[0]);
        ko.applyBindings(view, $("#view2")[0]);
        ko.applyBindings(viewMaster, $("#viewMaster")[0]);


        ///////////////////////////////////////////
        //// SETUP KENDOUI
        //// TEXTBOXES

        //// MANUALLY RESET THE LANGUAGE USED ON MASTER PAGE POPUPS AND LOCAL POPUP TITLES
        $("#lblWindowResponded_Warning").html(viewMaster.objLanguageLabels().lblWindowResponded_Warning);
        $("#lblWindowResponded_AreYouSure").html(viewMaster.objLanguageLabels().lblWindowResponded_AreYouSure);
        $("#lblWindowResponded_ClickCancelToContinueWorking").html(viewMaster.objLanguageLabels().lblWindowResponded_ClickCancelToContinueWorking);
        $("#lblWindowResponded_ClickOKToExit").html(viewMaster.objLanguageLabels().lblWindowResponded_ClickOKToExit);
        $("#btnYes").html(viewMaster.objLanguageLabels().lblOK);
        $("#btnCancel").html(viewMaster.objLanguageLabels().lblCancel);
        $("#windowRecNotCompleted").prev().find(".k-window-title").html("<img src='../../Home_{{VER}}/images/icons/reports/document_information_24x24.png' align='left' alt='Information Icon' class='windowIcon'/>  " + viewMaster.objLanguageLabels().lblWindowResponded_Title);

        $("#lblWindowRespondedDatasheet_Warning").html(viewMaster.objLanguageLabels().lblWindowResponded_Warning);
        $("#lblWindowRespondedDatasheet_AreYouSure").html(viewMaster.objLanguageLabels().lblWindowResponded_AreYouSure);
        $("#lblWindowRespondedDatasheet_ClickCancelToContinueWorking").html(viewMaster.objLanguageLabels().lblWindowResponded_ClickCancelToContinueWorking);
        $("#lblWindowRespondedDatasheet_ClickOKToExit").html(viewMaster.objLanguageLabels().lblWindowResponded_ClickOKToExit);
        $("#btnYesDatasheet").html(viewMaster.objLanguageLabels().lblOK);
        $("#btnCancelDatasheet").html(viewMaster.objLanguageLabels().lblCancel);
        $("#windowRecNotCompletedDatasheet").prev().find(".k-window-title").html("<img src='../../Home_{{VER}}/images/icons/reports/document_information_24x24.png' align='left' alt='Information Icon' class='windowIcon'/>  " + viewMaster.objLanguageLabels().lblWindowResponded_Title);

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
        $(document).find(".k-window-title").html("<img src='../../Home_{{VER}}/images/icons/warning/window_warning_24x24.png' align='left' alt='Warning Icon' class='windowIcon'/>  " + view.objLanguageLabels().lblNoLocationFoundTitle);


        //////////////////////////////
        //// WHEN ALL DONE CALL THE RESET TO SYNC THE FIND AND THE PICKERS
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
        var tempUrl = "rectracking.aspx?f1=" + "<%= ServerSide_FileNo %>" + "&rec=" + dataItem.Id;
        document.location.href = tempUrl;
    }

</script>

</asp:Content>
