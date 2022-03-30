<%@ Page Title="Fire Program Details | Global Risk Consultants" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectServerLocationDetail.Master" CodeBehind="locationdetails.aspx.vb" Inherits="GRC.Connect.Web.locationdetails_fire" %>
<%@ Register TagPrefix="grcRSC" TagName="Loader" Src="~/Home_{{VER}}/Controls/Loader.ascx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="ContentFindCriteria" ContentPlaceHolderID="ContentFindCriteria" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="tabLocDetailsContainer" class="tabLocDetailsContainer">
        
        <div id="tabLocDetailsLoading" class="tabLocDetailsLoading">
            <grcRSC:Loader runat="server" id="loader" />
        </div>
        <div class="choosePracticeHldr">
            <label>Choose Service:</label>
            <div id="firePracticeLvlDropDown"></div>
        </div>
        <div id="tabLocDetailsContainerInside" class="tabLocDetailsContainerInside">
            <div class="tabLocDetailBackground" style="">&nbsp;</div>
            <div id="tabLocDetails" class="tabLocDetails"></div>
        </div>
    </div>
    <script type="text/javascript">
        $(document).ready(function () {
            // GLOBAL VARIABLES
            gRecId = null;

            // MVVM
            var view = {
                // DECLARATIONS
                gSafeGuid: getGSafeGUID(),
                clientFeatures: null,
                tabLocDetails: null,
                firePracticeLvlDropDown: null,
                activeServicesForDropDown: [],

                // DETAIL PAGE LINKS
                urlParameters: null,
                urlLocationDetails: null,
                urlFacilityRatings: null,
                urlRecTracking: null,
                urlDataSource: [],

                // INIT THE VIEWMODEL
                init: function () {
                    view.loadData();
                },


                // LOAD ALL DATA
                loadData: function () {
                    view.loadPages();
                    view.loadSpecialFeatures();
                    view.loadActiveServices();
                    view.setupKendo();
                    view.bindForm();
                },


                // CREATE THE URLS USED IN THE TABSTRIP
                loadPages: function () {
                    try {
                        view.urlParameters = "?sid=" + view.gSafeGuid; //getQueryString();
                        view.urlLocationDetails = "tab_locationdetails.aspx";
                        view.urlFacilityRatings = "tab_facilityrating.aspx";
                        view.urlDataSource = [
                            { "id": 1, "label": "Scheduling & Values", "content": view.urlLocationDetails + view.urlParameters },
                            { "id": 2, "label": "Facility Ratings", "content": view.urlFacilityRatings + view.urlParameters },
                        ];
                    } catch (pException) {
                        alert("(61) An error occurred while building the detail page URLs: " + pException.message);
                    }
                },


                // LOAD THE SPECIAL FEATURES AND OVERRIED THE URLS
                loadSpecialFeatures: function () {
                    try {
                        view.clientFeatures = getClientFeatures(view.gSafeGuid);
                        if (view.clientFeatures) {
                            //DB: special feature letter change from x to g
                            if (view.clientFeatures.toLowerCase().indexOf("g") > -1) {
                                view.urlRecTracking = "tab_rectrackingfeaturesX.aspx";

                                //DB: reset the url in the datasource
                              //  view.tabLocDetails.setDataSource(view.urlDataSource);
                            }
                        }
                    } catch (pException) {
                        alert("(76) An error occurred while loading special features: " + pException.message);
                    }
                },


                //LOAD ACTIVE SERVICE LIST
                loadActiveServices: function () {
                    try {
                        var pGSafeGuid = getGSafeGUID();
                        var zServiceName = "GetActiveAccountServices";
                        var zParms = ko.toJSON({
                            "pGSafeGuid": getGSafeGUID()
                        });
                        global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, view.loadActiveServicesSuccess, view.loadActiveServicesError, null);
                    } catch (pException) {
                        alert("(76) An error occurred while loading active services: " + pException.message);
                    }
                },

                loadActiveServicesSuccess: function (pResults) {
                    try {
                        if (pResults.isSuccess) {
                            for (var i = 0; i < pResults.data.length; i++) {
                                if (pResults.data[i].colFldStatus == "Active") {
                                    view.activeServicesForDropDown.push({ "text": pResults.data[i].colFldReportDisplayTitle, "value": pResults.data[i].colFldPracticeGroupCode });
                                }
                            }

                            if (!view.firePracticeLvlDropDown) {
                                $('#firePracticeLvlDropDown').kendoDropDownList({
                                    dataSource: view.activeServicesForDropDown,
                                    dataTextField: "text",
                                    dataValueField: "value",
                                    change: view.serviceDDChange
                                });
                            }
                            view.firePracticeLvlDropDown = $('#firePracticeLvlDropDown').data("kendoDropDownList");
                            view.firePracticeLvlDropDown.select(function (dataItem) { return dataItem.value === "52" });
                        }
                    } catch (pException) {
                        alert("An error occurred while completinging the account active services data call: " + pException.message);
                    }
                },

                loadActiveServicesError: function (pResults, pMessage, pErrorDetail, pParms) {
                    alert("Error while loading active service data. " + pMessage);
                },

                // BIND THE FORM TO DATA
                bindForm: function () {
                    try {
                    } catch (pException) {
                        alert("(85) An error occurred while binding the form data: " + pException.message);
                    }
                },


                // RELOAD THE CURRENT TAB WITH A URL
                reloadTab: function (pURL) {
                    try {
                        if (pURL) {
                            // UPDATE THE URL IN THE DATASOURCE AND RELOAD
                            var zIndex = view.tabLocDetails.select().index();
                            var zTab = view.tabLocDetails.items()[zIndex];
                            // LOAD THE NEW URL INTO THE TAB
                            view.urlDataSource[zIndex].content = pURL;
                            view.tabLocDetails.setDataSource(view.urlDataSource);
                            //view.tabLocDetails.reload(zTab); // DOES NOT WORK
                            view.tabLocDetails.select(zIndex);
                        }
                    } catch (pException) {
                        alert("(95) An error occurred while reloading the tab detail page: " + pException.message);
                    }
                },


                // RESTORE DATASOURCE TO DEFAULT
                resetDataSource: function () {
                    view.loadPages();
                    view.loadSpecialFeatures();
                },


                // SETUP KENDO COMPONENTS
                setupKendo: function () {
                    try {
                        // BUILD THE TABSTRIP
                        if (!view.tabLocDetails) {
                            $("#tabLocDetails").kendoTabStrip({
                                animation: {
                                    open: { effects: "expand:vertical fadeIn", duration: 333 },
                                    close: { effects: "fadeOut", duration: 100 }
                                },
                                collapsible: false,
                                dataContentUrlField: "content",
                                dataTextField: "label",
                                dataSource: view.urlDataSource,
                                select: function (pEvent) {
                                    for (var x = 0; ; ++x) {
                                        var zTab = view.tabLocDetails.contentElement(x);
                                        if (zTab == null) { break; }
                                        if (zTab == pEvent.contentElement) {
                                            // DO NOTHING FOR CURRENT TAB
                                        } else {
                                            // EMPTY THE OTHER TABS TO GET FRESH CONTENT WHEN CLICKING
                                            $(zTab).html("");
                                        }
                                    }
                                }
                            });
                            $("#tabLocDetailsLoading").hide(function () {
                                $("#tabLocDetailsContainerInside").show();
                            });
                            view.tabLocDetails = $("#tabLocDetails").data('kendoTabStrip');
                            view.tabLocDetails.select(0);

                            
                        }
                    } catch (pException) {
                        alert("(124) An error occurred while building the details tabstrip: " + pException.message);
                    }
                },

                serviceDDChange: function (e) {
                    var currentURL = window.location.href;
                    var chosenServiceValue = this.value();
                    var currentP1ParmValue = getQueryVariable("p1");
                    var oldParm = "p1=" + currentP1ParmValue;
                    var tempFileNo = $("#FileNo").val();
                    var tempParm = "";
                    var tempURL = "";

                    switch (chosenServiceValue) {
                        case "51":
                            //B&M
                            tempURL = currentURL.replace("/Fire/", "/Boiler/");
                            tempParm = "p1=" + tempFileNo;
                            tempURL = tempURL.replace(oldParm, tempParm);
                            window.location.href = tempURL;
                            break;
                        case "52":
                            //FIRE
                            tempURL = currentURL.replace("/Fire/", "/Fire/");
                            tempParm = "p1=" + tempFileNo;
                            tempURL = tempURL.replace(oldParm, tempParm);
                            window.location.href = tempURL;
                            break;
                        case "53":
                            //IR
                            tempURL = currentURL.replace("/Fire/", "/Infrared/");
                            tempParm = "p1=" + tempFileNo;
                            tempURL = tempURL.replace(oldParm, tempParm);
                            window.location.href = tempURL;
                            break;
                        case "54":
                            //DIVSERV
                            tempURL = currentURL.replace("/Fire/", "/Diversified/");
                            tempParm = "p1=" + tempFileNo;
                            tempURL = tempURL.replace(oldParm, tempParm);
                            window.location.href = tempURL;
                            break;
                        case "55":
                            //NATHAZ
                            tempURL = currentURL.replace("/Fire/", "/NaturalHazards/");
                            tempParm = "p1=" + tempFileNo;
                            tempURL = tempURL.replace(oldParm, tempParm);
                            window.location.href = tempURL;
                            break;
                        case "56":
                            //JURIS
                            tempURL = currentURL.replace("/Fire/", "/Jurisdictional/");
                            tempParm = "p1=" + tempFileNo;
                            tempURL = tempURL.replace(oldParm, tempParm);
                            window.location.href = tempURL;
                            break;
                        case "57":
                            //PROCSAFETY
                            tempURL = currentURL.replace("/Fire/", "/ProcessSafety/");
                            tempParm = "p1=" + tempFileNo;
                            tempURL = tempURL.replace(oldParm, tempParm);
                            window.location.href = tempURL;
                            break;
                    }
                },
            }


            // START HERE
            view.init();


            // GLOBAL FUNCTIONS
            gReloadTab = function (pURL, pRecId) {
                if (pRecId) { gRecId = pRecId; }
                view.reloadTab(pURL);
            }
        });
    </script>
</asp:Content>
