<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectAuthServer.Master" CodeBehind="Edit_ORIGINAL.aspx.vb" Inherits="GRC.Connect.Web.EditPreferences_ORIGINAL" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-edit.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-menu.css" />
    <script src="../../Lib_{{VER}}/knockoutkendo/knockout-kendo.min.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCPrefCurrency.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCPrefCustomAccess.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCPrefDivision.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCPrefLocation.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCPrefTIV.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCPrefUnit.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCPref.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="text-align: center;">
        <h1>Welcome to <span class="logoLetters_h1">GRC</span> Connect</h1>
        <h3>Stay Connected to Your Loss Control Information</h3>
        <br />&nbsp;

        <div style="width: 495px; text-align: left; padding-left: 160px; float: left;">

            <%--ACCESS INFORMATION TABLE--%>
            <%--<div class="divTable borderBottom borderLeft borderTop borderRight" style="width: 455px; padding: 10px;">
                <b><label id="lblLogin" data-bind="text: objLanguageLabels().lblLogin"></label></b>
                <br />&nbsp;
                <div>
                    <span style="width: 155px; line-height: 24px; float:left;"><label id="lblEnterYourEmail" data-bind="text: objLanguageLabels().lblEnterYourEmail"></label>:</span>
                    <span style="width: 280px; float: right;"><asp:TextBox ID="txtEmail" CssClass="k-autocomplete k-input k-input-padding noedit" runat="server" Width="275px" Height="24px"></asp:TextBox></span>
                </div>
                <br />&nbsp;
                <div>
                    <span style="width: 155px; line-height: 24px; float:left;"><label id="lblPassword" data-bind="text: objLanguageLabels().lblPassword"></label></span>
                    <span style="width: 280px; float: right;"><asp:TextBox ID="txtPassword" CssClass="k-autocomplete k-input k-input-padding noedit" runat="server" Width="275px" Height="24px" TextMode="Password"></asp:TextBox></span>
                </div>
                <br />&nbsp;
            </div>--%>

            <%--ACCESS INFORMATION TABLE--%>
            <br />&nbsp;
            <div class="divTable borderBottom borderLeft borderTop borderRight" style="width: 455px; padding: 10px;">
                <b><label id="lblAccess" data-bind="text: objLanguageLabels().lblAccess">Access</label></b>
                <br />&nbsp;
                <div>
                    <span style="width: 155px; line-height: 24px; float:left;"><label id="lblClientSelection" data-bind="text: objLanguageLabels().lblClientSelection">Client Selection</label>:</span>
                    <span style="width: 280px; float: right;"><asp:TextBox ID="txtClientSelection" CssClass="k-autocomplete k-input k-input-padding noedit" runat="server" Width="275px" Height="24px"></asp:TextBox></span>
                </div>
                <br />&nbsp;
            </div>

            <%-- INSTRUCTIONS TO USER --%>
            <div style="text-align: center; padding-top: 20px; padding-bottom: 10px; margin-left: -35px; margin-right: -25px; color: Red;">
                <label id="lblInstrutions" data-bind="text: objLanguageLabels().lblInstructions1">Please be sure to click the 'Save Preferences' button to save all updates.</label>
                <br /><label id="lblInstrutions" data-bind="text: objLanguageLabels().lblInstructions2">Your preferences will be saved for all future login sessions.</label>
            </div>


            <%--PREFERENCE OPTIONS TABLE--%>
            <div class="divTable borderBottom borderLeft borderTop borderRight" style="width: 455px; padding: 10px;">
                <b><label id="lblPreferenceOptions" data-bind="text: objLanguageLabels().lblPreferenceOptions">Preference Options</label></b>
                <br />&nbsp;
                <div>
                    <span style="width: 155px; line-height: 24px; float:left;"><label id="lblCurrencyDefault" data-bind="text: objLanguageLabels().lblCurrencyDefault">Currency Default</label>:</span>
                    <span style="width: 280px; float: right;">
                        <select id="cboCurrencyDefault" class="editRequired" style="width: 275px;" data-bind="kendoDropDownList: {
                            data: KOcollCurrency,
                            value: objCurrency,
                            close: onClose
                        }"></select>
                    </span>
                </div>
                <br />&nbsp;
                <div>
                    <span style="width: 155px; line-height: 24px; float:left;"><label id="lblUnitsDefault" data-bind="text: objLanguageLabels().lblUnitsDefault">Units Default</label>:</span>
                    <span style="width: 280px; float: right;">
                        <select id="cboUnitDefault" class="editRequired" style="width: 275px;" data-bind="kendoDropDownList: {
                            data: KOcollUnit,
                            value: objUnit,
                            close: onClose
                        }"></select>
                    </span>
                </div>
                <%--<br />&nbsp;
                <div runat="server" id="divDivision">
                    <span style="width: 155px; line-height: 24px; float:left;"><label id="lblDivisionDefault" data-bind="text: objLanguageLabels().lblDivisionDefault">Division(s) Default</label>:</span>
                    <span style="width: 280px; float: right;">
                        <select id="cboDivisionDefault" class="editRequired" style="width: 275px;" data-bind="kendoDropDownList: {
                            data: KOcollDivision,
                            value: objDivision,
                            optionLabel: '(All)',
                            close: onClose
                        }"></select>
                    </span>
                </div>
                <br />&nbsp;
                <div runat="server" id="divCustomAccess">
                    <span style="width: 155px; line-height: 24px; float:left;"><label id="lblCusAccessDefault" data-bind="text: objLanguageLabels().lblCusAccessDefault">Custom Default</label>:</span>
                    <span style="width: 280px; float: right;">
                        <select id="cboCustomerAccessDefault" class="editRequired" style="width: 275px;" data-bind="kendoDropDownList: {
                            data: KOcollCustomAccess,
                            value: objCustomAccess,
                            optionLabel: '(All)',
                            close: onClose
                        }"></select>
                    </span>
                </div>
                <br />&nbsp;
                <div runat="server" id="divLocation">
                    <span style="width: 155px; line-height: 24px; float:left;"><label id="lblLocationsDefault" data-bind="text: objLanguageLabels().lblLocationsDefault">Locations(s) Default</label>:</span>
                    <span style="width: 280px; float: right;">
                        <select id="cboLocationDefault" class="editRequired" style="width: 275px;" data-bind="kendoDropDownList: {
                            data: KOcollLocation,
                            value: objLocation,
                            optionLabel: '(All)',
                            close: onClose
                        }"></select>
                    </span>
                </div>
                <br />&nbsp;
                <div runat="server" id="divTIV">
                    <span style="width: 155px; line-height: 24px; float:left;"><label id="lblTIVDefault" data-bind="text: objLanguageLabels().lblTIVDefault">TIV Default</label>:</span>
                    <span style="width: 280px; float: right;">
                        <select id="cboTIVDefault" class="editRequired" style="width: 275px;" data-bind="kendoDropDownList: {
                            data: KOcollTIV,
                            value: objTIV,
                            close: onClose
                        }"></select>
                    </span>
                </div>--%>
                <br />&nbsp;<br />&nbsp;
                <div style="text-align: center;">
                    <span style="width: 155px; line-height: 24px; float:left;">&nbsp;</span>
                    <span style="width: 280px; float: right; text-align: center;"><a href="#"><label id="lblSavePreferences" data-bind="click: onSave, text: objLanguageLabels().lblSavePreferences">Save Preferences</label></a>
                    <br /><label id="lblSaveComplete" data-bind="visible: saveComplete, text: objLanguageLabels().lblSaveComplete" class="messageNotice" style="font-size: 8pt;"></label></span>
                </div>
                <br />&nbsp;
            </div>
            <br />&nbsp;
            <div>
                <div class="icon_container">
                    <div style="padding-left: 450px;">
                        <div class="icon_exit" id="icoExit" runat="server"></div>
                    </div>
                    <div style="padding-left: 448px;">
                        <span class="icon_label"><asp:HyperLink class="hiddenLink" runat="server" ID="hypExit">Close</asp:HyperLink></span>
                    </div>
                </div>
            </div>

        </div>

        <%-- ALERT MESSAGE --%>
        <div style="clear: both;">
            <br />
            <br /><asp:Label ID="lblMessage" runat="server" CssClass="messageError"></asp:Label>
            <br />
        </div>

    </div>

    <script type="text/javascript">
        $(document).ready(function () {
            ///////////////////////////////////////////
            //// LOAD SESSION VARIABLES
            var dsLanguageLabels = {
                //// LOGIN
                lblLogin: "Login",
                lblEnterYourEmail: "Enter Your Email",
                lblPassword: "Password",

                //// ACCESS
                lblAccess: "Access",
                lblClientSelection: "Client Selection",

                //// PREFERENCE OPTIONS
                lblPreferenceOptions: "Preference Options",
                lblCurrencyDefault: "Currency Default",
                lblUnitsDefault: "Units Default",
                lblDivisionDefault: "Division(s) Default",
                lblCusAccessDefault: '<%=GRC.Connect.Libraries.CoreLib.UtilGSafe.GetValue(GRC.Connect.Libraries.CoreLib.UtilGSafe.GetGUIDFromQueryString(), GRC.Connect.Libraries.CoreLib.UtilGSafe.KeyName.CustomAccessLabelDefault)%>',
                lblLocationsDefault: "Locations(s) Default",
                lblTIVDefault: "TIV Default",

                //// MISC
                lblSavePreferences: "Save myPreferences",
                lblSaveComplete: "-Save Complete-",
                lblInstructions: "Please be sure to click the 'Save myPreferences' button to save all updates. Your Preferences will be saved for all future login sessions.",
                lblInstructions1: "Please be sure to click the 'Save myPreferences' button to save all updates.",
                lblInstructions2: "Your preferences will be saved for all future login sessions."
            };


            ///////////////////////////////////////////
            //// VIEWMODEL
            var view = {
                //// DECLARATIONS
                messageError: ko.observable(),
                messageWarning: ko.observable(),
                messageNotice: ko.observable(),
                saveComplete: ko.observable(false),

                //// GSAFE / CLIENT FEATURES / LANGUAGES
                gSafeGuid: getQueryVariable('sid'),
                objLanguageLabels: ko.observable(dsLanguageLabels),
                enableMultiUser: ko.observable(true),

                //// MISC COLLECTIONS / OBJECTS
                collDefaults: new es.objects.GSafeDetailCollection(),
                collUserType: new es.objects.GSafeDetailCollection(),

                //// DEFAULTS COLLECTIONS / OBJECTS
                collCurrency: new es.objects.ViewCCPrefCurrencyCollection(),
                KOcollCurrency: ko.observableArray(),
                objCurrency: ko.observable(),
                collUnit: new es.objects.ViewCCPrefUnitCollection(),
                KOcollUnit: ko.observableArray(),
                objUnit: ko.observable(),
                collDivision: new es.objects.ViewCCPrefDivisionCollection(),
                KOcollDivision: ko.observableArray(),
                objDivision: ko.observable(),
                collCustomAccess: new es.objects.ViewCCPrefCustomAccessCollection(),
                KOcollCustomAccess: ko.observableArray(),
                objCustomAccess: ko.observable(),
                collLocation: new es.objects.ViewCCPrefLocationCollection(),
                KOcollLocation: ko.observableArray(),
                objLocation: ko.observable(),
                collTIV: new es.objects.ViewCCPrefTIVCollection(),
                KOcollTIV: ko.observableArray(),
                objTIV: ko.observable(),

                //// DISPLAY FIELDS BASED ON USER LOGIN
                displayFields: function() {
                    //                    es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
                    //                    view.collUserType.getValuesByDataGroup([view.gSafeGuid, "Authentication"]);
                    //                    for (x = 0; x < view.collUserType().length; x++) {
                    //                        if(view.collUserType()[x].DataName() == "SingleUser") {
                    //                            if(view.collUserType()[x].DataValue().toLowerCase() == "true") {
                    //                                view.enableMultiUser(false);
                    //                            }
                    //                        }
                    //                    }
                },

                //// LOAD ALL INFORMATION FROM THE DB
                loadPickers: function () {
                    var tempArray = new Array();
                    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                    if (!view.collCurrency.viewCCPrefCurrencyCollection(view.gSafeGuid)) {
                        for (i = 0; i < view.collCurrency().length; i++) {
                            tempArray.push(view.collCurrency()[i].Code());
                        }
                        view.KOcollCurrency(tempArray);
                    } else {
                        view.messageError("* Error while loading currency list.");
                    }

                    if (!view.collUnit.viewCCPrefUnitCollection(view.gSafeGuid)) {
                        tempArray = new Array();
                        for (i = 0; i < view.collUnit().length; i++) {
                            tempArray.push(view.collUnit()[i].Code());
                        }
                        view.KOcollUnit(tempArray);
                    } else {
                        view.messageError("* Error while loading units list.");
                    }

                    if (!view.collDivision.viewCCPrefDivisionCollection(view.gSafeGuid)) {
                        tempArray = new Array();
                        for (i = 0; i < view.collDivision().length; i++) {
                            tempArray.push(view.collDivision()[i].Division());
                        }
                        view.KOcollDivision(tempArray);
                    } else {
                        view.messageError("* Error while loading division list.");
                    }

                    if (!view.collCustomAccess.viewCCPrefCustomAccessCollection(view.gSafeGuid)) {
                        tempArray = new Array();
                        for (i = 0; i < view.collCustomAccess().length; i++) {
                            tempArray.push(view.collCustomAccess()[i].CustomAccess());
                        }
                        view.KOcollCustomAccess(tempArray);
                    } else {
                        view.messageError("* Error while loading custom access list.");
                    }

                    if (!view.collLocation.viewCCPrefLocationCollection(view.gSafeGuid)) {
                        tempArray = new Array();
                        for (i = 0; i < view.collLocation().length; i++) {
                            tempArray.push(view.collLocation()[i].Location());
                        }
                        view.KOcollLocation(tempArray);
                    } else {
                        view.messageError("* Error while loading location list.");
                    }

                    if (!view.collTIV.viewCCPrefTIVCollection(view.gSafeGuid)) {
                        tempArray = new Array();
                        for (i = 0; i < view.collTIV().length; i++) {
                            tempArray.push(view.collTIV()[i].Code());
                        }
                        view.KOcollTIV(tempArray);
                    } else {
                        view.messageError("* Error while loading TIV list.");
                    }
                },

                //// LOAD DEFAULTS FROM THE GSAFE
                loadDefaults: function () {
                    es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
                    view.collDefaults.getValuesByDataGroup([view.gSafeGuid, "Preference"]);
                    for (i = 0; i < view.collDefaults().length; i++) {
                        switch (view.collDefaults()[i].DataName()) {
                            case "CurrencyDefaultText":
                                view.objCurrency(view.collDefaults()[i].DataValue());
                                break;
                            case "CustomAccessDefaultText":
                                view.objCustomAccess(view.collDefaults()[i].DataValue());
                                break;
                            case "DivisionDefaultText":
                                view.objDivision(view.collDefaults()[i].DataValue());
                                break;
                            case "LocationDefaultText":
                                view.objLocation(view.collDefaults()[i].DataValue());
                                break;
                            case "TIVDefaultText":
                                view.objTIV(view.collDefaults()[i].DataValue());
                                break;
                            case "UnitDefaultText":
                                view.objUnit(view.collDefaults()[i].DataValue());
                                break;
                        }
                    }
                },

                //// RESET FIELDS ON LOAD RECORD ON SELECT TO FILTER BASED ON SELECTION
                onClose: function (e) {
                    view.onSave();
                    view.loadPickers();
                    view.loadDefaults();
                    view.saveComplete(false);
                },

                onSave: function () {
                    if (view.objCurrency() == undefined || view.objCurrency() == "") { view.objCurrency("(All)"); }
                    if (view.objCustomAccess() == undefined || view.objCustomAccess() == "") { view.objCustomAccess("(All)"); }
                    if (view.objDivision() == undefined || view.objDivision() == "") { view.objDivision("(All)"); }
                    if (view.objLocation() == undefined || view.objLocation() == "") { view.objLocation("(All)"); }
                    if (view.objTIV() == undefined || view.objTIV() == "") { view.objTIV("(All)"); }
                    if (view.objUnit() == undefined || view.objUnit() == "") { view.objUnit("(All)"); }

                    //// SAVE TO THE GSAFE
                    setUserPrefs(
                        view.gSafeGuid,
                        view.objCurrency(),
                        view.objCustomAccess(),
                        view.objDivision(),
                        view.objLocation(),
                        view.objTIV(),
                        view.objUnit()
                    );
                    view.saveComplete(true);
                }
            };


            ///////////////////////////////////////////
            //// SETUP BASE URL FOR DATA SERVICE AND LOAD ALL DATA
            view.displayFields();
            view.loadPickers();
            view.loadDefaults();


            ///////////////////////////////////////////
            //// ACTIVATE BINDINGS LAST
            ko.applyBindings(view, $("#view")[0]);


            ///////////////////////////////////////////
            //// SETUP KENDOUI
            //// NOT NEEDED - USE KNOCKOUT-KENDO LIBRARY IN MARKUP INSTEAD
        });
</script>
</asp:Content>