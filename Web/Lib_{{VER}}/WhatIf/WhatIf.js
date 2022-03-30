$(document).ready(function () {

    $('#divContainerLoading').show();

    view = {
        /* DATA OBJECTS */
        WIMetaData: ko.observable(),
        WI_Initial_Grid_Obj: ko.observable(),
        gridDataInitial: null,
        gridData: ko.observableArray(),
        gridDataSort: ko.observable(),
        gridDataFilter: ko.observable(),
        gridDataIndicies: ko.observable(),
        gridDataSources: ko.observable(),
        gridColumns: ko.observableArray(),
        gridFilteredData: ko.observableArray(),
        gridSelectedItems: ko.observableArray(),
        sortByDDData: ko.observableArray(),
        picklistIgnoreColumns: ko.observableArray(),
        

        /* ACCORDIAN OBJECTS */
        divisionAccordianData: ko.observableArray(),
        divisionAccordianID: null,
        selectedDivisionItems: ko.observableArray(),

        clientLocAccordianData: ko.observableArray(),
        clientLocAccordianID: null,
        selectedClientLocItems: ko.observableArray(),

        fileNoAccordianData: ko.observableArray(),
        fileNoAccordianID: null,
        selectedFileNoItems: ko.observableArray(),

        facilityAccordianData: ko.observableArray(),
        facilityAccordianID: null,
        selectedFacilityAccoridanItems: ko.observableArray(),

        customAccessAccordianData: ko.observableArray(),
        customAccessAccordianID: null,
        selectedCustomAccessItems: ko.observableArray(),
        showCustomAccessAccordian: ko.observable(false),

        accordianCheckedItem: ko.observable(),
        uncheckedAccordianItems: ko.observableArray(),

        /* GENERAL OBJECTS */
        picklist: null,
        wiGrid: null,
        countLoading: 0,
        gridLoadCount: 0,
        gridInitialLoad: false,
        gridFilters: ko.observableArray(),

        /* BUDGET DISPLAY VARIABLES */
        budgetBox: ko.observable(),
        costToCompleteBox: ko.observable(),
        remainingBudgetBox: ko.observable(),
        rawCostToComplete: ko.observable(),

        /* TEXT DATABIND OBJECTS */
        sortByString: ko.observable(),
        sortByIndex: ko.observable("1"),
        filterByForService: ko.observable(),
        filterByTxtString: ko.observable(),
        pinnedString: ko.observable(),
        estBudget: ko.observable(),
        rawBudgetNum: 0,
        estCostToComplete: ko.observable('$0'),
        remainingBudget: ko.observable(),
        TotalRecsSelectedCount: ko.observable(),
        TotalRecsSelectedScoreChange: ko.observable(),
        HERecsSelectedCount: ko.observable(),
        HERecsSelectedScoreChange: ko.observable(),
        gridTotalRecCount: ko.observable(),
        locationWindowTitle: ko.observable(),
        accordianAppliedFilters: ko.observable("None"),
        clientName: ko.observable(),
        txtMessage: ko.observable(),
        getSelectedOnly:ko.observable(false),


        /* REPORT VARIABLES */
        reportEstBudget: ko.observable("0"),
        reportEstCostToComplete: ko.observable("0"),
        reportRemainingBudget: ko.observable("0"),

        /* LOCATION SUMMARY WINDOW OBJECTS */
        currentScoreString: ko.observable(),
        currentScoreBackgroundColor: ko.observable(),
        currentScoreTextColor: ko.observable(),

        achievableRatingPercentString: ko.observable(),
        achievableRatingPercentBackgroundColor: ko.observable(),
        achievableRatingPercentTextColor: ko.observable(),

        totalRecsCompleteScoreString: ko.observable(),
        totalRecsCompleteScoreBackgroundColor: ko.observable(),
        totalRecsCompleteScoreTextColor: ko.observable(),

        totalWhatifAndRecsCompleteScoreString: ko.observable(),
        totalWhatifAndRecsCompleteScoreBackgroundColor: ko.observable(),
        totalWhatIfAndRecsCompleteScoreTextColor: ko.observable(),

        achievableRatingPercentRecsRptdCompleteString: ko.observable(),
        achievableRatingPercentRecsRptdCompleteBackgroundColor: ko.observable(),
        achievableRatingPercentRecsRptdCompleteTextColor: ko.observable(),

        allRecsCompAchievableRatingPercentString: ko.observable(),
        allRecsCompAchievableRatingPercentBackColor: ko.observable(),
        allRecsCompAchievableRatingPercentForeColor: ko.observable(),

        /* CHART DATA OBJECTS */
        ratingAverageScoreChartData: ko.observableArray(),
        achievableRatingChartData: ko.observableArray(),
        achievableRatingChartColumnColors: ko.observableArray(),
        riskImprovmentChartData: ko.observableArray(),
        riskImprovmentRiskData: ko.observableArray(),
        riskImprovmentCostData: ko.observableArray(),

        /* WINDOW OBJECTS */
        ratingScoreChartWindow: ko.observable(),
        achievableRatingChartWindow: ko.observable(),
        riskImprovementChartWindow: ko.observable(),
        locationListingWindow: ko.observable(),

        /* BUTTON ENABLE VARIABLES */
        enableFilterByBtn: ko.observable(true),
        enableClearSelectionsBtn: ko.observable(true),
        enableSortsFilterBtn: ko.observable(true),

        /* VARIABLE TO STORE GRID DATA URL */
        readURL: ko.observable(),

        /* CONTROL BOOLEANS */
        wasClearSortsFiltersClicked: ko.observable(false),

        init: function () {
            
            //DB: all we need in the endpoint for the grid
            view.readURL(SITEBASEURL + WIGETINITIALGRIDDATA + getGSafeGUID() + "/")
            view.countLoading = 4;
            view.loadMetaData();
            view.setupKendoWindows();
            view.setupKendoAccordian();
        },

        /* REST SERVICE CALLS */
        loadMetaData: function () {
            var pGUID = getGSafeGUID();
            var generatedServiceURL = SITEBASEURL + WIINIT + pGUID; 
            global.callWIRestService(generatedServiceURL, view.loadMetaDataSuccess, view.loadMetaDataError);
        },
        loadMetaDataSuccess: function (pResults) {
            try {

                if (pResults.IsSuccess) {
                    //SET CLIENT NAME
                    view.clientName(pResults.Client.ClientName);

                    //GET COLOR FOR ACHIEVABLE RATING % CHART BARS 
                    view.getClientRatingRanges();

                    view.WIMetaData(pResults);
                    for (var x = 0; x < view.WIMetaData().GridMeta.columns.length; x++) {
                        if (view.WIMetaData().GridMeta.columns[x].template !== undefined && view.WIMetaData().GridMeta.columns[x].template !== null && view.WIMetaData().GridMeta.columns[x].template.indexOf("function") == 0) {
                            view.WIMetaData().GridMeta.columns[x].template = "var fn = " + view.WIMetaData().GridMeta.columns[x].template;
                            var zFn = eval(view.WIMetaData().GridMeta.columns[x].template);
                            view.WIMetaData().GridMeta.columns[x].template = fn;
                        }
                    }
                    //SEED RIGHT SIDE INFORMATION SECTION WITH '0' ON LOAD
                    view.TotalRecsSelectedCount(view.WIMetaData().TotalSelected);
                    view.TotalRecsSelectedScoreChange(view.WIMetaData().TotalSelectedScoreChange);
                    view.HERecsSelectedCount(view.WIMetaData().HumanElementSelected);
                    view.HERecsSelectedScoreChange(view.WIMetaData().HumanElementSelectedScoreChange);

                    //SET 'SORT BY' DROPDOWN DATASOURCE
                    view.sortByDDData(view.WIMetaData().RecSorts);

                    //SET LOCATION LISTING WINDOW TITLE
                    view.locationWindowTitle("Location Rating Summary: ");

                    view.gridDataIndicies(view.WIMetaData().GridMeta.indices);
                    view.gridDataSources(view.WIMetaData().GridMeta.sources);
                    
                    //DETERMIN IF WE DISPLAY CUSTOM ACCESS ACCORDIAN
                    view.showCustomAccessAccordian(pResults.Client.ShowCustomAccess);
                    
                    //POPULATE ACCORDIAN PANEL DATA SOURCES AND ACCORDIAN ID'S
                    view.divisionAccordianData(view.WIMetaData().Client.Divisions);
                    if (view.divisionAccordianData().length > 0) {
                        view.divisionAccordianID = view.divisionAccordianData()[0].DescriptorID;
                    }

                    view.clientLocAccordianData(view.WIMetaData().Client.ClientLocIDs);
                    if (view.clientLocAccordianData().length > 0) {
                        view.clientLocAccordianID = view.clientLocAccordianData()[0].DescriptorID;
                    }
                    view.fileNoAccordianData(view.WIMetaData().Client.FileNos);
                    if (view.fileNoAccordianData().length > 0) {
                        view.fileNoAccordianID = view.fileNoAccordianData()[0].DescriptorID;
                    }

                    view.facilityAccordianData(view.WIMetaData().Client.Facilities);
                    if (view.facilityAccordianData().length > 0) {
                        view.facilityAccordianID = view.facilityAccordianData()[0].DescriptorID;
                    }

                    view.customAccessAccordianData(view.WIMetaData().Client.CustomAccess);
                    if (view.customAccessAccordianData().length > 0) {
                        view.customAccessAccordianID = view.customAccessAccordianData()[0].DescriptorID;
                    }

                    //CHECK IF WE SHOULD HIDE LOADING SPINNER
                    view.countLoading--;
                    if (view.countLoading == 0) {
                        view.hideLoadingScreen();
                    }

                    //SET GRID COLUMNS
                    view.gridColumns(view.WIMetaData().GridMeta.columns);

                    //DB: ADDED TO SETUP THE GRID
                    view.setupKendoGrid();

                    //LOAD MAIN FORM DATA
                    view.loadFormData();

                    //SET UP THE SORT BY DROPDOWN
                    //view.setupKendoDropdown();
                    
                }
            } catch (pException) {
                view.processMessage("An error occurred while loading What If meta data: " + pException.message);
            }
        },
        loadMetaDataError: function (pResults, pMessage, pErrorDetail, pParms) {
            view.processMessage("Error while loading meta data. " + pMessage);
        },

        loadFormData: function () {
            //THIS IS FOR CHART AND INFORMATION SECTION DATA
            var pGUID = getGSafeGUID();
            var formDataURL = SITEBASEURL + WIGETFORMDATA + pGUID;
            global.callWIRestService(formDataURL, view.loadFormDataSuccess, view.loadFormDataError);
        },
        loadFormDataSuccess: function (pResults) {
            try {

                if (pResults.IsSuccess) {
                    
                    view.estCostToComplete(global.formatMoney(pResults.EstCost, 0));
                    
                    if (pResults.EstCost) {
                        view.reportEstCostToComplete(pResults.EstCost);
                    }
                    view.TotalRecsSelectedCount(pResults.TotalSelected);
                    view.TotalRecsSelectedScoreChange(pResults.TotalSelectedScoreChange);
                    view.HERecsSelectedCount(pResults.HumanElementSelected);
                    view.HERecsSelectedScoreChange(pResults.HumanElementSelectedScoreChange);
                    
                    //DO REMAINING BUDGET CALCULATIONS IF NEEDED
                    view.rawCostToComplete(pResults.EstCost);
                    if (view.rawBudgetNum != 0) {
                        var rawRemainingNum = 0;
                        rawRemainingNum = view.rawBudgetNum - parseInt(pResults.EstCost);
                        if (rawRemainingNum < 0) {
                            $('#remainingBudgetBox').removeClass('overZero');
                            $('#remainingBudgetBox').addClass('underZero');
                        } else {
                            $('#remainingBudgetBox').removeClass('underZero');
                            $('#remainingBudgetBox').addClass('overZero');
                        }
                        view.reportRemainingBudget(rawRemainingNum);
                        var tempPrettyBudget = global.formatMoney(rawRemainingNum, 0);
                        view.remainingBudget(tempPrettyBudget);
                    }

                    //CHECK IF WE SHOULD HIDE LOADING SPINNER
                    view.countLoading--;
                    if (view.countLoading == 0) {
                        view.hideLoadingScreen();
                    }

                    //SET CHART DATA OBJECTS
                    view.createChartDataObjects(pResults.ChartData);

                    //view.loadGridData();
                    view.setupKendoCharts();

                }
            } catch (pException) {
                view.processMessage("An error occurred while loading What If form data: " + pException.message);
            }
        },
        loadFormDataError: function (pResults, pMessage, pErrorDetail, pParms) {
            view.processMessage("Error while loading form data. " + pMessage);
        },

        onGridLoadStart: function (pEvent) {
            view.processMessage("");
        },

        loadFilteredGridData: function (pFilter, pSort) {
            view.refreshGridData(false);
        },

        selectedGridData: function () {
            //REFRESH GRID DATA WITH SELECTED PARAMETER SET TO TRUE
            view.refreshGridData(true);
        },

        sortGridData: function () {

            //WILL NEED GRID SORT POPULATED

            //REFRESH GRID DATA WITH SELECTED PARAMETER SET TO FALSE
            view.refreshGridData(false);
            
        },

        sendAccordianData: function (pIsChecked, pAccordianID, pName) {
            var pGUID = getGSafeGUID();
            var encodedName = encodeURI(pName);
            var accordianServiceLink = SITEBASEURL + WIGETACCORDIAN + pGUID + "?val=" + pIsChecked + "&desc=" + pAccordianID + "&name=" + encodedName;
            view.readURL(accordianServiceLink);
            global.callWIRestService(accordianServiceLink, view.sendAccordianDataSuccss, view.sendAccordianDataError);
        },
        sendAccordianDataSuccss: function (pResults) {
            try {
                
                //FUNCTION TO REDRAW ENTIRE PAGE WITH NEW FILTERS APPLIED IN THE ACCORDIAN
                if (pResults.IsSuccess) {

                    //SET VARIABLES TO HOLD CHART OBJECTS
                    var ratingAverageScoreChart = $('#RatingScoreChart').data("kendoChart");
                    var achievableRatingPercentChart = $('#AchievableRatingChart').data("kendoChart");
                    var riskImprovmentChart = $('#RiskImporvementChart').data("kendoChart");

                    //RESET CHART DATA OBJECTS
                    view.ratingAverageScoreChartData([]);
                    view.achievableRatingChartData([]);
                    view.riskImprovmentChartData([]);

                    view.TotalRecsSelectedCount(pResults.TotalSelected);
                    view.TotalRecsSelectedScoreChange(pResults.TotalSelectedScoreChange);
                    view.HERecsSelectedCount(pResults.HumanElementSelected);
                    view.HERecsSelectedScoreChange(pResults.HumanElementSelectedScoreChange);

                    //UPDATE CHART DATA ITEMS BASED ON ACCORDIAN SELECTION
                    view.createChartDataObjects(pResults.ChartData);

                
                    //REDRAW CHARTS WITH NEW DATA
                    view.setupKendoCharts();
                    
                    //SET FILTER STRINGS
                    
                    view.accordianAppliedFilters(pResults.Filter);

                    //GET GRID OBJECT TO CHECK FOR A SORT AND FILTER
                    var grid = $('#gridDiv').data('kendoGrid');
                    var gridSort = "";
                    var gridFilter = "";

                    if (grid.dataSource.sort() != null || grid.dataSource.sort() != "") {
                        //URLENCODE SORT FOR SERVER USE
                        gridSort = encodeURI(grid.dataSource.sort());
                    }

                    if (grid.dataSource.filter() != null || grid.dataSource.filter() != "") {
                        //URLENCODE FILTERS FOR SERVER USE
                        gridFilter = encodeURI(grid.dataSource.filter());
                    }
                
                    //CALL SERVICE TO GET NEW GRID DATA
                    view.loadFilteredGridData(gridFilter, gridSort);
                
                }
            } catch (pException) {
                view.processMessage("An error occurred while filtering What If data: " + pException.message);
            }
            
        },
        sendAccordianDataError: function (pResults, pMessage, pErrorDetail, pParms) {
            view.processMessage("Error while sending accordian data. " + pMessage);
        },

        getLocationSummaryData: function (pFileNo) {
            var pGUID = getGSafeGUID();
            var locationListingServiceLink = SITEBASEURL + WIGETLOCATIONRATINGSUMMARY + pGUID + "?pFileNo=" + pFileNo;
            global.callWIRestService(locationListingServiceLink, view.getLocationSummaryDataSuccess, view.getLocationSummaryDataError);
        },
        getLocationSummaryDataSuccess: function (pResults) {
            try {
                
                if (pResults.IsSuccess) {
                    
                    //SET STRING VALUES
                    view.achievableRatingPercentString(pResults.AchievableRatingPercentString);
                    view.currentScoreString(pResults.TotalScoreString);
                    view.totalRecsCompleteScoreString(pResults.TotalScoreRecsAllRecsCompString);
                    view.achievableRatingPercentRecsRptdCompleteString(pResults.WhatIfAchievableRatingPercentString);
                    view.totalWhatifAndRecsCompleteScoreString(pResults.WhatIfScoreString);
                    view.allRecsCompAchievableRatingPercentString(pResults.AllRecsCompAchievableRatingPercentString);

                    //SET BACKGROUND COLORS
                    view.achievableRatingPercentBackgroundColor(pResults.AchievableRatingPercentBackColorHex);
                    view.currentScoreBackgroundColor(pResults.TotalScoreBackColorHex);
                    view.totalRecsCompleteScoreBackgroundColor(pResults.TotalScoreRecsAllRecsCompBackColorHex);
                    view.achievableRatingPercentRecsRptdCompleteBackgroundColor(pResults.WhatIfAchievableRatingPercentBackColorHex);
                    view.totalWhatifAndRecsCompleteScoreBackgroundColor(pResults.WhatIfScoreBackColorHex);
                    view.allRecsCompAchievableRatingPercentBackColor(pResults.AllRecsCompAchievableRatingPercentBackColorHex);

                    //SET TEXT COLORS
                    view.achievableRatingPercentTextColor(pResults.AchievableRatingPercentForeColorHex);
                    view.currentScoreTextColor(pResults.TotalScoreForeColorHex);
                    view.totalRecsCompleteScoreTextColor(pResults.TotalScoreRecsAllRecsCompForeColorHex);
                    view.achievableRatingPercentRecsRptdCompleteTextColor(pResults.WhatIfAchievableRatingPercentForeColorHex);
                    view.totalWhatIfAndRecsCompleteScoreTextColor(pResults.WhatIfScoreForeColorHex);
                    view.allRecsCompAchievableRatingPercentForeColor(pResults.AllRecsCompAchievableRatingPercentForeColorHex);
                }

            } catch (pException) {
                view.processMessage("An error occurred while loading What If Location Rating Summary data: " + pException.message);
            }
        },
        getLocationSummaryDataError: function (pResults, pMessage, pErrorDetail, pParms) {
            view.processMessage("Error while getting Location Summary data. " + pMessage);
        },

        getReportParms: function () {

            var grid = $('#gridDiv').data('kendoGrid');
            var gSort = grid.dataSource.sort();
            if (gSort == undefined) {
                gSort = null;
            }
            var gFilter = grid.dataSource.filter();
            if (gFilter == undefined) {
                gFilter = null;
            }
            var pGUID = getGSafeGUID();
            var zData = ko.toJSON({
                "pSid": pGUID,
                "pSort": JSON.stringify(gSort),
                "pFilter": JSON.stringify(gFilter),
                "pEstBudget": view.reportEstBudget(),
                "pEstCostToComplete": view.reportEstCostToComplete(),
                "pRemainBudget": view.reportRemainingBudget()
            });

            var reportParmsURL = SITEBASEURL + WIPOSTSETREPORTPARMS;
            global.callWIRestServicePOST(reportParmsURL, zData, view.getReportParmsSuccess, view.getReportParmsError, null);
        },
        getReportParmsSuccess: function (pResults) {
            try {
                if (pResults.IsSuccess) {
                    var zURL = "../../widownloadreport.ashx?pguid=" + pResults.HandlerGUID;
                    window.location.href = zURL;
                }
            } catch (pException) {
                view.processMessage("An error occurred while getting What If Report Parameters: " + pException.message);
            }
        },
        getReportParmsError: function (pResults, pMessage, pErrorDetail, pParms) {
            view.processMessage("Error while getting report parameters. " + pMessage);
        },

        extractData: function () {
            
            var grid = $('#gridDiv').data('kendoGrid');
            var gSort = grid.dataSource.sort();
            var gFilter = grid.dataSource.filter();
            var pGUID = getGSafeGUID();
            var zData = ko.toJSON({
                "pSid": pGUID,
                "pSort": JSON.stringify(gSort),
                "pFilter": JSON.stringify(gFilter)
            });

            var extractUrl = SITEBASEURL + WIPOSTSETEXTRACTPARMS;
            
            global.callWIRestServicePOST(extractUrl, zData, view.extractDataSuccess, view.extractDataError, null);
        },
        extractDataSuccess: function (pResults) {
            try {
                
                if (pResults.IsSuccess) {
                    
                    var zURL = "../../widownloadreport.ashx?pguid=" + pResults.HandlerGUID;
                    window.location.href = zURL;
                }
            } catch (pException) {
                view.processMessage("An error occurred while extracting What If data: " + pException.message);
            }
        },
        extractDataError: function (pResults, pMessage, pErrorDetail, pParms) {
            view.processMessage("Error while getting data extract parameters. " + pMessage);
        },

        selectAllRecs: function () {
            var pGUID = getGSafeGUID();
            var grid = $('#gridDiv').data('kendoGrid');
            var gFilter = grid.dataSource.filter();
            if (grid.dataSource.filter()) {
                gFilter = JSON.stringify(gFilter);
            } else {
                gFilter = null;
            }
            var zData = ko.toJSON({
                "pSid": pGUID,
                "pFilter": gFilter
            });
            var selectAllRecsURL = SITEBASEURL + WIPOSTSELECTALLRECS;

            global.callWIRestServicePOST(selectAllRecsURL, zData, view.selectAllRecsSuccess, view.selectAllRecsError, null);
        },
        selectAllRecsSuccess: function (pResults) {
            try {
                
                if (pResults.IsSuccess) {
                    //GET THE FORM DATA AGAIN BASED ON GRID SELECTION
                    view.loadFormData();
                    view.refreshGridData(true);
                }
            } catch (pException) {
                view.processMessage("An error occurred while selecting all What If Recs: " + pException.message);
            }
        },
        selectAllRecsError: function (pResults, pMessage, pErrorDetail, pParms) {
            view.processMessage("Error while selecting all recommendations. " + pMessage);
        },

        selectSingleRec: function (pRecID) {
            
            var pGUID = getGSafeGUID();
            var zData = ko.toJSON({
                "pSid": pGUID,
                "pRecID": pRecID
            });

            var selectRecURL = SITEBASEURL + WIPOSTSELECTREC;

            global.callWIRestServicePOST(selectRecURL, zData, view.selectSingleRecSuccess, view.selectSingleRecError, null);
        },
        selectSingleRecSuccess: function (pResults) {
            try {
                
                if (pResults.IsSuccess) {
                    //GET THE FORM DATA AGAIN BASED ON GRID SELECTION
                    view.loadFormData();
                }
            } catch (pException) {
                view.processMessage("An error occurred while selecting single What If Recs: " + pException.message);
            }
        },
        selectSingleRecError: function (pResults, pMessage, pErrorDetail, pParms) {
            view.processMessage("Error while selecting this recommendations. " + pMessage);
        },

        deSelectAllRecs: function () {
            var pGUID = getGSafeGUID();
            var grid = $('#gridDiv').data('kendoGrid');
            var gFilter = grid.dataSource.filter();
            if (grid.dataSource.filter()) {
                gFilter = JSON.stringify(gFilter);
            } else {
                gFilter = null;
            }
            var zData = ko.toJSON({
                "pSid": pGUID,
                "pFilter": gFilter
            });
            var deSelectAllRecsURL = SITEBASEURL + WIPOSTDESELECTALLRECS;
            global.callWIRestServicePOST(deSelectAllRecsURL, zData, view.deSelectAllRecsSuccess, view.deSelectAllRecsError, null);
        },
        deSelectAllRecsSuccess: function (pResults) {
            try {
                if (pResults.IsSuccess) {
                    //GET THE FORM DATA AGAIN BASED ON GRID SELECTION
                    view.loadFormData();
                    view.refreshGridData(false);
                }
            } catch (pException) {
                view.processMessage("An error occurred while de-selecting all What If Recs: " + pException.message);
            }
        },
        deSelectAllRecsError: function (pResults, pMessage, pErrorDetail, pParms) {
            view.processMessage("Error while de-selecting all recommendations. " + pMessage);
        },

        deSelectSingleRec: function (pRecID) {
            var pGUID = getGSafeGUID();
            var zData = ko.toJSON({
                "pSid": pGUID,
                "pRecID": pRecID
            });

            var deSelectRecURL = SITEBASEURL + WIPOSTDESELECTREC;

            global.callWIRestServicePOST(deSelectRecURL, zData, view.deSelectSingleRecSuccess, view.deSelectSingleRecError, null);
        },
        deSelectSingleRecSuccess: function (pResults) {
            try {
                
                if (pResults.IsSuccess) {
                    //GET THE FORM DATA AGAIN BASED ON GRID DE-SELECTION
                    view.loadFormData();
                }
            } catch (pException) {
                view.processMessage("An error occurred while de-selecting single What If Recs: " + pException.message);
            }
        },
        deSelectSingleRecError: function (pResults, pMessage, pErrorDetail, pParms) {
            view.processMessage("Error while de-selecting this recommendations. " + pMessage);
        },

        viewLink: function (pFileNo) {
            var pGUID = getGSafeGUID();
            var zData = ko.toJSON({
                "pSid": pGUID,
                "pFileNo": pFileNo
            });
            var viewLinkURL = SITEBASEURL + WIPOSTSETFACILITYREPORTPARMS;
            global.callWIRestServicePOST(viewLinkURL, zData, view.viewLinkSuccess, view.viewLinkError, null);
        },
        viewLinkSuccess: function (pResults) {
            try {
                
                if (pResults.IsSuccess) {
                    
                    var zURL = "../../widownloadreport.ashx?pguid=" + pResults.HandlerGUID;
                    window.location.href = zURL;
                }
            } catch (pException) {
                view.processMessage("An error occurred while getting facility report parameters: " + pException.message);
            }
        },
        viewLinkError: function (pResults, pMessage, pErrorDetail, pParms) {
            view.processMessage("Error while getting facility report parameters. " + pMessage);
        },

        getClientRatingRanges: function (pGuid) {
            try {
                var zGUID = pGuid;
                var zServiceName = "GetClientRatingRanges";
                var zParms = ko.toJSON({
                    "pGSafeGuid": getGSafeGUID()
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, view.getClientRatingRangesSucces, view.getClientRatingRangesError, null);
            } catch (pException) {
                view.processMessage("An error occurred while starting the client rating ranges data call: " + pException.message);
            }
        },
        getClientRatingRangesSucces: function (pResults, pParms) {
            try {
                if (pResults.isSuccess) {
                    view.achievableRatingChartColumnColors(pResults.data);
                }
            } catch (pException) {
                view.processMessage("An error occurred while starting the client rating ranges data call: " + pException.message);
            }
        },
        getClientRatingRangesError: function (pResults, pMessage, pErrorDetail, pParms) {
            try {
                alert("Error while calling the client rating ranges service. " + pMessage);
                view.processMessage("Error while starting the client rating ranges data call " + pMessage);
            } catch (pException) {
                view.processMessage("An error occurred while starting the client rating ranges data call: " + pException.message);
            }
        },

        /* END REST SERVICE CALLS */

        /* SETUP OF KENDO OBJECTS */

        setupKendoGrid: function () {
            
            var pGUID = getGSafeGUID();
            if (view.wiGrid == null) {
                var zFilter = null;
                view.wiGrid = new utilKendoGrid();
                view.wiGrid.optionsConstant.isServerLoading = true;
                view.wiGrid.optionsConstant.transportPickListAddress = SITEBASEURL + WIGETPICKLISTDATA + pGUID;
                view.wiGrid.optionsConstant.transportReadAddress = view.readURL();
                view.wiGrid.optionsConstant.transportCompleteFunction = function (pResults) { view.onGridLoadComplete(pResults) };
                view.wiGrid.optionsConstant.transportStartFunction = function (pEvent) { view.onGridLoadStart(pEvent) };
                view.wiGrid.optionsConstant.height = 345;
                view.wiGrid.optionsConstant.width = 1700;
                view.wiGrid.optionsConstant.serverLoadingNodeNameData = "Data";
                view.wiGrid.optionsConstant.serverLoadingNodeNameTotal = "Total";
                view.wiGrid.optionsConstant.detailTemplate = view.WIMetaData().GridMeta.detailTemplate;
                view.wiGrid.gSafeGuid = getGSafeGUID();
                view.wiGrid.toolbar = kendo.template($('#gridToolbar').html());
                view.wiGrid.optionsConstant.changeFunction = function (pEvent) { view.onGridChange(pEvent); };
                //view.wiGrid.optionsConstant.dataBoundFunction = function () { view.checkGridItems(pResults) };
                view.wiGrid.optionsConstant.sortFunction = function (pEvent) { view.sortFunction(pEvent) };
                view.wiGrid.optionsConstant.gridFilter = view.gridDataFilter();
                view.wiGrid.optionsConstant.gridSort = view.gridDataSort();
                view.wiGrid.pickListIgnoreColumns = ["WiIsSelected", "LocationRatingFormViewLink", "LocationRatingReportLink"];
                view.wiGrid.initGridWI('#gridDiv', '#gridHldr', '#windowPickList', view.gridData(), view.WIMetaData().GridMeta.schema, view.gridColumns(), false, null, zFilter, null, view.WIMetaData().GridMeta.indices, view.WIMetaData().GridMeta.sources);
                //view.processLoading();
                kendo.ui.progress($("#gridDiv"), false);
            }

            //CHECK IF WE SHOULD HIDE LOADING SPINNER
            view.countLoading--;
            if (view.countLoading == 0) {
                view.hideLoadingScreen();
            }
        },

        setupKendoCharts: function () {
            $('#RatingScoreChart').kendoChart({
                legend: {
                    labels: {
                        color: "#000"
                    },
                    position: "bottom"
                },
                dataSource: {
                    data: view.ratingAverageScoreChartData()
                },
                chartArea: {
                    height: 225,
                    width: 480,
                    background: "#ffffff",
                    color: "#000000"
                },
                seriesDefaults: {
                    type: "column",
                    labels: {
                        visible: true,
                        color: "#000",
                        template: '#=kendo.format("{0:0}", value)#'
                    }
                },
                series: [{
                    field: "field",
                    categoryField: "categoryField",
                    color: "#0046ad",
                    labels: {
                        color: "#000000"
                    },
                    tooltip: {
                        visible: true,
                        background: "#4472C4",
                        color: "#ffffff",
                        template: "#= category #, #= kendo.format( '{0:n0}' , value) #"
                    }
                }],
                categoryAxis: {
                    majorGridLines: {
                        visible: false
                    }
                },
                valueAxis: {
                    min: 0,
                    max: 120,
                    majorUnit: 20,
                    line: {
                        visible: false
                    },
                    title: {
                        text: "TIV Weighted Score %",
                        font: "12px Arial, Helvetica, sans-serif",
                        margin: 2
                    }
                },
                xAxis: {
                    line: {
                        visible: false
                    }
                },
                
            });

            $('#AchievableRatingChart').kendoChart({
                legend: {
                    labels: {
                        color: "#000"
                    },
                    position: "bottom"
                },
                dataSource: {
                    data: view.achievableRatingChartData()
                },
                chartArea: {
                    height: 225,
                    width: 480,
                    background: "#ffffff",
                    color: "#000000"
                },
                seriesDefaults: {
                    type: "column",
                    labels: {
                        visible: true,
                        color: "#000",
                        template: '#=kendo.format("{0:0}", value)#'
                    }
                },
                series: [{
                    field: "field",
                    categoryField: "categoryField",
                    color: "#0046ad",
                    labels: {
                        color: "#000000"
                    },
                    tooltip: {
                        visible: true,
                        background: "#4472C4",
                        color: "#ffffff",
                        template: "#= category #, #= kendo.format( '{0:n0}' , value) #"
                    }
                }],
                categoryAxis: {
                    majorGridLines: {
                        visible: false
                    }
                },
                valueAxis: {
                    min: 0,
                    max: 120,
                    majorUnit: 20,
                    line: {
                        visible: false
                    },
                    title: {
                        text: "TIV Weighted Score %",
                        font: "12px Arial, Helvetica, sans-serif",
                        margin: 2
                    }
                },
            });

            $('#RiskImporvementChart').kendoChart({
                legend: {
                    labels: {
                        color: "#000"
                    },
                    position: "bottom"
                },
                dataSource: {
                    data: view.riskImprovmentChartData(),
                },
                chartArea: {
                    height: 225,
                    width: 550,
                    background: "#ffffff",
                    color: "#000000"
                },
                seriesDefaults: {
                    type: "column",
                    labels: {
                        visible: true,
                        color: "#000",
                        template: '#=kendo.format("{0:n0}", value)#'
                    }
                },
                series: [{
                    field: "field",
                    categoryField: "categoryField",
                    color: "#0046ad",
                    labels: {
                        color: "#000000"
                    },
                    tooltip: {
                        visible: true,
                        background: "#4472C4",
                        color: "#ffffff",
                        template: "#= category #: #= kendo.format( '{0:n0}' , value) #"
                    }
                }],
                valueAxis: {
                    line: {
                        visible: false
                    },
                    labels: {
                        format: "{0:n0}"
                    },
                    title: {
                        text: "In millions",
                        font: "12px Arial, Helvetica, sans-serif",
                        margin: 2
                    }
                },
                categoryAxis: {
                    majorGridLines: {
                        visible: false
                    }
                },
            });
        },

        setupKendoWindows: function () {
            $('#ratingScoreChartWindow').kendoWindow({
                visible: false,
                title: "Average Rating Score",
                actions: ["Close"],
                width: "575px",
                height: "235px",
                modal: true
            });
            view.ratingScoreChartWindow = $('#ratingScoreChartWindow').data("kendoWindow");

            $('#achievableRatingChartWindow').kendoWindow({
                visible: false,
                title: "Achievable Rating %",
                actions: ["Close"],
                width: "575px",
                height: "235px",
                modal: true
            });
            view.achievableRatingChartWindow = $('#achievableRatingChartWindow').data('kendoWindow');

            $('#riskImprovementChartWindow').kendoWindow({
                visible: false,
                title: "Risk Improvement",
                actions: ["Close"],
                width: "575px",
                height: "295px",
                modal: true
            });
            view.riskImprovementChartWindow = $('#riskImprovementChartWindow').data('kendoWindow');

            $('#locationListingWindow').kendoWindow({
                visible: false,
                title: view.locationWindowTitle(),
                actions: ["Close"],
                width: "850px",
                height: "115px",
                modal: true
            });
            view.locationListingWindow = $('#locationListingWindow').data('kendoWindow');
        },

        setupKendoAccordian: function () {
            $('#panelBar').kendoPanelBar({
                expandMode: "single",
                select: view.expandCollapse
            });
        },
        
        /* END SETUP OF KENDO OBJECTS */

        /* FUNCTION TO CLOSE AN OPEN ACCORDIAN ON CLICK */
        expandCollapse: function (e) {
            if ($(e.item).is('.k-state-active')) {
                var that = this;
                window.setTimeout(function () { that.collapse(e.item); }, 1);
            }
        },

        /* GRID FUNCTIONS */
        
        sortFunction: function(pEvent){
            view.refreshGridData(false);
        },

        onGridLoadComplete: function (pData) {
            try {
                var totalBlurb = "Total Record Count: ";
                view.gridTotalRecCount(totalBlurb + pData.responseJSON.Total);
                if (pData.responseJSON.Total == 0) {
                    alert("There are no records that fit your criteria.");
                }
                view.gridData(pData);
                view.checkGridItems(view.gridData());
            } catch (pException) {
                view.processMessage("An error occurred while completing grid load: " + pException.message);
            }
        },

        onGridChange: function (pEvent) {

            /* SET SORTBY LABEL TEXT WITH BOTH DROPDOWN SORT VALUE AND GRID SORT VALUE */
            //var initSortString = "";
            var tempSort = view.wiGrid.getSortString();
            view.sortByString(tempSort);

            /* SET GRID FILTEREDBY LABEL TEXT WITH GRID FILTER VALUE */
            var tempFilterString = view.wiGrid.getFilterString();
            if (tempFilterString != "") {
                view.filterByTxtString(tempFilterString);
            }

            setTimeout(function () {
                view.cleanUpGrid();
            }, 500);
        },

        /* END GRID FUNCTIONS */

        /* PICKLIST FUNCTIONS */

        pickListCheckAll: function () {
            view.wiGrid.pickListCheckAll();
        },

        pickListCheckNone: function () {
            view.wiGrid.pickListCheckNone();
        },

        pickListCheckReverse: function () {
            view.wiGrid.pickListCheckReverse();
        },

        pickListApplyFilter: function () {
            view.wiGrid.pickListApplyFilter();
        },

        pickListCancel: function () {
            view.wiGrid.pickListCancel();
        },

        /* END PICKLIST FUNCTIONS */

        /* DROPDOWN CHANGE FUNCTION */
        onSortByDDChange: function (e) {
            
            var dataItem = e.sender.dataItem();
            view.sortByString(dataItem.Text);
            view.sortByIndex(dataItem.ID);

            view.sortGridData();
        },

        /* CLICK FUNCTIONS */
        ratingScoreClick: function () {
            view.ratingScoreChartWindow.center().open();
        },

        achievableRatingClick: function () {
            view.achievableRatingChartWindow.center().open();
        },

        riskImprovementClick: function () {
            view.riskImprovementChartWindow.center().open();
        },

        accordianItemCheck: function (pID, pPanelID, pName) {
            var grid = $('#gridDiv').data('kendoGrid');
            switch (pPanelID) {
                case 1:
                    //divisionListItemClick
                    for (var i = 0; i < view.divisionAccordianData().length; i++) {
                        
                        if (pID == view.divisionAccordianData()[i].ID) {
                            var item = $('#' + pID);
                            var itemIsChecked = false;
                            if (item.is(":checked")) {
                                itemIsChecked = true;
                                var pField = "Division";
                                view.sendAccordianData(itemIsChecked, pPanelID, pName);
                                view.accordianCheckedItem(pName);
                                break;
                            } else {
                                itemIsChecked = false;
                                var pField = "Division";
                                view.sendAccordianData(itemIsChecked, pPanelID, pName);
                                break;
                            }
                        }
                    }
                    break;
                case 2:
                    //fileNoListItemClick
                    for (var i = 0; i < view.fileNoAccordianData().length; i++) {

                        if (pID == view.fileNoAccordianData()[i].ID) {
                            var item = $('#' + pID);
                            var itemIsChecked = false;
                            if (item.is(":checked")) {
                                itemIsChecked = true;
                                var pField = "FileNo";
                                view.sendAccordianData(itemIsChecked, pPanelID, pName);
                                view.accordianCheckedItem(pName);
                                break;
                            } else {
                                itemIsChecked = false;
                                var pField = "FileNo";
                                view.sendAccordianData(itemIsChecked, pPanelID, pName);
                                break;
                            }
                        }
                    }

                    break;
                case 3:
                    //customAccessItemClick
                    for (var i = 0; i < view.customAccessAccordianData().length; i++) {

                        if (pID == view.customAccessAccordianData()[i].ID) {
                            var item = $('#' + pID);
                            var itemIsChecked = false;
                            if (item.is(":checked")) {
                                itemIsChecked = true;
                                var pField = "CustomAccess";
                                view.sendAccordianData(itemIsChecked, pPanelID, pName);
                                view.accordianCheckedItem(pName);
                                break;
                            } else {
                                itemIsChecked = false;
                                var pField = "CustomAccess";
                                view.sendAccordianData(itemIsChecked, pPanelID, pName);
                                break;
                            }
                        }
                    }

                    break;
                case 4:
                    //clientLocIDListItemClick
                    for (var i = 0; i < view.clientLocAccordianData().length; i++) {

                        if (pID == view.clientLocAccordianData()[i].ID) {
                            var item = $('#' + pID);
                            var itemIsChecked = false;
                            if (item.is(":checked")) {
                                itemIsChecked = true;
                                var pField = "ClientLocNo";
                                view.sendAccordianData(itemIsChecked, pPanelID, pName);
                                view.accordianCheckedItem(pName);
                                break;
                            } else {
                                itemIsChecked = false;
                                var pField = "ClientLocNo";
                                view.sendAccordianData(itemIsChecked, pPanelID, pName);
                                break;
                            }
                        }
                    }

                    break;
                case 5:
                    //facilityListItemClick
                    for (var i = 0; i < view.facilityAccordianData().length; i++) {
                        if (pID == view.facilityAccordianData()[i].ID) {
                            var item = $('#' + pID);
                            var itemIsChecked = false;
                            if (item.is(":checked")) {
                                itemIsChecked = true;
                                var pField = "Facility";
                                view.sendAccordianData(itemIsChecked, pPanelID, pName);
                                view.accordianCheckedItem(pName);
                                break;
                            } else {
                                itemIsChecked = false;
                                var pField = "Facility";
                                view.sendAccordianData(itemIsChecked, pPanelID, pName);
                                break;
                            }
                        }
                    }
                    break;
            }
        },

        filterBySelectionsClick: function () {
            view.selectedGridData();
        },

        clearSelctionsClick: function () {
            view.deSelectAllRecs();
        },

        clearSortsFiltersClick: function () {
            view.wasClearSortsFiltersClicked(true);
            view.wiGrid.optionsConstant.gridSort = "";
            view.wiGrid.optionsConstant.gridFilter = "";
            view.refreshGridData(false);
        },

        resetGridPageClick: function () {
            localStorage.clear()
            location.reload();
        },

        downloadReportClick: function () {
            view.getReportParms();
        },

        extractDataClick: function () {
            view.extractData();
        },

        magnifyingGlassClick: function (pFileNo) {
            if (pFileNo) {
                view.getLocationSummaryData(pFileNo);
            }
            view.locationListingWindow.title(view.locationWindowTitle());
            view.locationListingWindow.center().open();
        },

        viewLinkClick: function (pFileNo) {
            view.viewLink(pFileNo);
        },

        gridHeaderCheckboxClick: function (pIsChecked) {
            
            if (pIsChecked) {
                view.selectAllRecs();

            } else {
                view.deSelectAllRecs();
            }
        },

        gridSingleRowCheckboxClick: function (pCheckedID, pIsChecked) {
            
            if (pIsChecked) {
                view.selectSingleRec(pCheckedID);
            } else {
                view.deSelectSingleRec(pCheckedID);
            }
            
        },

        /* END CLICK FUNCTIONS */


        /* UTILITY FUNCTIONS */

        refreshGridData: function (pIsSelected) {
            
            var grid = $('#gridDiv').data('kendoGrid')
            view.wiGrid.optionsConstant.sortIndex = view.sortByIndex();
            view.wiGrid.optionsConstant.selectedRecsOnly = pIsSelected;

            if (grid.dataSource.filter() == undefined) {
                view.wiGrid.optionsConstant.gridFilter = "";
            }
            
            grid.dataSource.fetch();
            
        },

        cleanUpGrid: function () {
            /* FUNCTION TO REMOVE SORT ICON AND UPDATE SORTBY LABEL TEXT */
            var grid = $("#gridDiv").data("kendoGrid");

            if (view.wasClearSortsFiltersClicked()) {
                if ($("#gridDiv").find('span.k-i-sort-asc-sm') || $("#gridDiv").find('span.k-i-sort-desc-sm')) {
                    $("#gridDiv").find('span.k-i-sort-asc-sm').addClass("noShow");
                    $("#gridDiv").find('span.k-i-sort-desc-sm').addClass("noShow");
                }
                
                grid.dataSource.sort({});
                grid.dataSource.filter({});
                view.sortByString("");
                view.wasClearSortsFiltersClicked(false);
            }
        },

        createChartDataObjects: function (pData) {
            //CLEAR ALL CHART DATA OBJECTS  SO THEY HAVE CLEAN STARTING POINT FOR EACH RE-RENDER
            view.ratingAverageScoreChartData([]);
            view.achievableRatingChartData([]);
            view.riskImprovmentChartData([]);

            //SPLIT CHART DATA INTO APPROPRIATE DATA OBJECTS
            for (var i = 0; i < pData.length; i++) {
                if (i <= 2) {
                    view.ratingAverageScoreChartData.push({ "categoryField": pData[i].X, "field": pData[i].Y, "color": "#4472C4" }); //pData[i].Color
                } else if (i > 2 && i <= 5) {
                    //CHANGE COLOR OF BAR BASED ON RATING SCORE
                    for (var x = 0; x < view.achievableRatingChartColumnColors().length; x++) {
                        if (pData[i].Y > view.achievableRatingChartColumnColors()[x].colFldScoreLow && pData[i].Y < view.achievableRatingChartColumnColors()[x].colFldScoreHigh) {
                            pData[i].Color = view.achievableRatingChartColumnColors()[x].colHexBackColor;
                        }
                    }
                    view.achievableRatingChartData.push({ "categoryField": pData[i].X, "field": pData[i].Y, "color": pData[i].Color });
                } else if (i > 5 && i <= pData.length) {
                    view.riskImprovmentChartData.push({ "categoryField": pData[i].X, "field": pData[i].Y, "color": pData[i].Color });
                }
            }
        },

        generateGridFilter: function (pGrid, pField, pOperator, pValue) {

            var newFilter = { field: pField, operator: pOperator, value: pValue };
            var dataSource = pGrid.dataSource;
            var filters = null;

            if (dataSource.filter() != null) {
                filters = dataSource.filter().filters;
            }

            if (pValue && pValue.length > 0) {
                //Add filter
                if (filters == null) {
                    filters = [newFilter];
                } else {
                    var isNew = true;
                    var index = 0;
                    for (index = 0; index < filters.length; index++) {
                        if (filters[index].field == pField) {
                            isNew = false;
                            break;
                        }
                    }
                    if (isNew) {
                        filters.push(newFilter);
                    } else {
                        filters[index] = newFilter;
                    }
                }
            } else {
                //Remove Filter
                var removeIndex = -1;
                if (filters != null && filters.length > 0) {
                    for (var x = 0; x < filters.length; x++) {
                        var temp = filters[x];
                        if (temp.field == pField) {
                            removeIndex = x;
                            break;
                        }
                    }
                }
                if (removeIndex != -1) {
                    filters.splice(removeIndex, 1);
                }
            }

            view.gridFilters.push(filters);
            //dataSource.filter(filters);
        },

        hideLoadingScreen: function(){
            $('#divContainerLoading').hide();
        },

        budgetBoxOnBlur: function () {
            
            if ($('#budgetBox').val() != null) {

                var baseBudget = $('#budgetBox').val();
                var rawBudget = parseInt(baseBudget.replace(/,/g, ''));
                var grcPrettyNum = global.formatMoney(rawBudget, 0);

                view.rawBudgetNum = rawBudget;
                view.reportEstBudget(view.rawBudgetNum);
                view.estBudget(grcPrettyNum);

                if ($('#remainingBudgetBox').text() == "") {
                    view.remainingBudget(grcPrettyNum);
                }

                if (view.estCostToComplete() != "") {
                    var tempBudget = rawBudget - view.rawCostToComplete();
                    grcPrettyNum = global.formatMoney(tempBudget, 0);
                    view.remainingBudget(grcPrettyNum);
                }
            }
        },

        checkGridItems: function (pData) {
            for (var i = 0; i < pData.responseJSON.Data.length; i++) {

                var boxid = "#chkBx" + pData.responseJSON.Data[i].RecUniqueID

                if (pData.responseJSON.Data[i].WiIsSelected == true) {
                    $(boxid).prop("checked", true);
                } else {
                    $(boxid).prop("checked", false);
                }
            }
        },

        shouldButtonsBeDisabled: function (pTotal) {
            var btnClearSorts = $('#clearSortsFiltersBtn');
            var btnClearSelections = $('#clearSelectionsBtn');
            var btnFilterBy = $('#filterByBtn');

            if (pTotal == 0) {
                btnClearSorts.addClass('btnDisabled');
                view.enableSortsFilterBtn(false);

                btnClearSelections.addClass('btnDisabled');
                view.enableClearSelectionsBtn(false);

                btnFilterBy.addClass('btnDisabled');
                view.enableFilterByBtn(false);

            } else {
                btnClearSorts.removeClass('btnDisabled');
                view.enableSortsFilterBtn(true);

                btnClearSelections.removeClass('btnDisabled');
                view.enableClearSelectionsBtn(true);

                btnFilterBy.removeClass('btnDisabled');
                view.enableFilterByBtn(true);
            }
        },

        showLoading: function () {
            $("#divContainerLoading").fadeIn(100, function () { kendo.ui.progress($("#divContainerLoading"), true); });
        },

        hideLoading: function () {
            $("#divContainerLoading").fadeOut(100, function () { kendo.ui.progress($("#divContainerLoading"), false); });
        },

        processMessage: function (pMessage) {
            view.txtMessage(pMessage);
            global.messageShow("txtMessage", "messageWarning");
            view.hideLoading();
        },

        processLoading: function () {
            view.countLoading--;
            if (view.countLoading < 1) {
                view.hideLoading();
            } else {
            }
        },

        openFormView: function () { },

        closeFormView: function () { },

        bindForm: function () {
            ko.applyBindings(view, $("#view")[0]);
        },
    }

    view.bindForm();
    view.init();

    /* GLOBAL FUNCTIONS */
    gOpenlocationListingReport = function (pRowId, pFileNo, pClientName, pAddress, pCity, pStProv, pCountry) {
        var locationWinTitle = "Location Rating Summary: " + pFileNo + " - " + pClientName + " - " +
            pAddress + ", " + pCity + ", " + pStProv + " " + pCountry;
        view.locationWindowTitle(locationWinTitle);
        view.magnifyingGlassClick(pFileNo);
    }

    gOpenLocationRatingReport = function (pFileNo) {
        view.viewLinkClick(pFileNo);
    }

    gHeaderCheckBoxClick = function (pIsChecked) {
        view.gridHeaderCheckboxClick(pIsChecked);
    }

    gGridRowCheckBoxClick = function (pCheckedID, pIsChecked) {
        view.gridSingleRowCheckboxClick(pCheckedID, pIsChecked);
    }

    globalPickListCheck = function (pField, pId, pPickListDOM) {
        switch (pPickListDOM) {
            case "#windowPickList":
                view.wiGrid.pickListCheck(pField, pId);
                break;
            default:
                view.processMessage("An unknown error occurred. Picklist checking is not available at this time.");
                break;
        }
        return false;
    }

    globalOpenFormView = function (pFormName, pWindowTitle, pIdentifier1, pIdentifier2, pIdentifier3) {
        view.openFormView(pFormName, pWindowTitle, pIdentifier1, pIdentifier2, pIdentifier3);
    }

    globalCloseFormView = function () {
        view.closeFormView();
    }

    /* ACCORDIAN ITEM CLICK GLOBAL FUNCTION */
    gAccordianItemCheck = function (pID, pPanelID, pName) {
        view.accordianItemCheck(pID, pPanelID, pName);
    }

})