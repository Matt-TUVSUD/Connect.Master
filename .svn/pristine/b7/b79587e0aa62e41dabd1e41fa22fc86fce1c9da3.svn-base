$(document).ready(function () {

    gChartRawData = null;
    gChartData250 = null;
    gChartData350 = null;
    gChartData450 = null;
    gChartData550 = null;
    gChartData1000 = null;



    gChartDataMedium = null;
    gChartDataLarge = null;


    view = {

        //DASHBOARD VARIABLES
        //ORIGINAL DATA ITEM
        originalDataSet: ko.observableArray(),
        //APPLIED FILTER LIST VARIABLE
        appliedFiltersTxt: ko.observable(),

        //MULTI-SELECT BOXES
        divisionDD: null,
        DivisionData: ko.observableArray(),
        
        ClientLocDD: null,
        ClientLocIDData: ko.observableArray(),

        IntendedActionDD: null,
        IntendedActionData: ko.observableArray(),
        
        //PICKLIST
        picklist: null,

        divisionPicklistWindow: null,
        clientLocIdPicklistWindow: null,
        intendedActionPicklistWindow: null,
        facilityPicklistWindow: null,
        secondaryRecTypePicklistWindow: null,

        //CHART FILTER COLLECTIONS
        selectedDivisionItems: ko.observableArray(),
        selectedClientLocationIDs: ko.observableArray(),
        selectedIntendedActionItems: ko.observableArray(),

        filteredDataSetForCharts: ko.observableArray(),
        hasDataBeenFiltered: ko.observable(false),

        //CHART
        ChartTest: null,
        
        //CHART DATA
        CategoryAxisLabels: ko.observableArray(),
        CategoryAxisMajorUnit: ko.observable(),
        PieChartData: ko.observableArray(),
        BarChartData: ko.observableArray(),
        BarChartTopCostToComplete: ko.observable(),

        NumOfRecsData: ko.observableArray(),
        CostToCompData: ko.observableArray(),

        ListOfYears: ko.observableArray(),
        MaxYear: ko.observable(),
        RecImpactData: ko.observableArray(),
        RecImpactLow: ko.observableArray(),
        RecImpactModerate: ko.observableArray(),
        RecImpactHigh: ko.observableArray(),

        PieChartAdvisory: ko.observableArray(),
        PieChartInProgress: ko.observableArray(),
        PieChartOutstanding: ko.observableArray(),
        PieChartRptdComp: ko.observableArray(),
        PieChartConfComp: ko.observableArray(),
        PieChartLabel: ko.observable(),

        init: function () {
            gChartRawData = testChartData;
            gChartDataLarge = testChartDataLarge;
            gChartDataMedium = testChartDataMedium;
            gChartData250 = data250Recs;
            gChartData350 = data350Recs;
            gChartData450 = data450Recs;
            gChartData550 = data550Recs;
            gChartData1000 = data1000Recs;


            view.loadData();
            view.setUpKendoWindows();
            view.setupKendoAccordian();
            view.setUpKendoCharts();
            view.setupPicklists();
        },

        loadData: function () {
            //view.originalDataSet(gChartRawData);
            //view.dataItemProcess(gChartRawData);
            //view.originalDataSet(gChartDataMedium);
            //view.dataItemProcess(gChartDataMedium);
            //view.originalDataSet(gChartDataLarge);
            //view.dataItemProcess(gChartDataLarge);
            //view.originalDataSet(gChartData550);
            //view.dataItemProcess(gChartData550);
            view.originalDataSet(gChartData1000);
            view.dataItemProcess(gChartData1000);
            
        },

        dataItemProcess: function (pData) {
            for (var i = 0; i < pData.length; i++) {
                /* BAR CHART AXIS LABELS */
                if (view.CategoryAxisLabels().indexOf(pData[i].PrimaryRecType) == -1) {
                    view.CategoryAxisLabels.push(pData[i].PrimaryRecType);
                }

                /* LINE CHART DATA */
                view.ListOfYears.push({ "year": pData[i].RecYear, "value": pData[i].RecNo });

                /* DATA FOR PICKLISTS */
                /* DIVISION */
                /* PULL SPACES OUT OF ANY DIVISION NAMES SO THEY CAN BE USED AS ID'S */
                var divIdVal = '';
                if (!$.isNumeric(pData[i].Division)) {
                    //IF ID HAS WHITE SPACE, REMOVE IT
                    if (pData[i].Division.indexOf(' ') > 0) {
                        divIdVal = pData[i].Division.replace(/\s/g, '');
                    }
                }
                view.DivisionData.push({ "name": pData[i].Division, "value": pData[i].Division, "id": divIdVal + i });

                /* CLIENT LOCATION ID */
                view.ClientLocIDData.push({ "name": pData[i].ClientLocID, "value": pData[i].ClientLocID, "id": pData[i].ClientLocID + i });

                /* INTENDED ACTION */
                /* PULL SPACES OUT OF ANY INTENDED ACTIONS SO THEY CAN BE USED AS ID'S */
                var intendIdVal = '';
                if (!$.isNumeric(pData[i].IntendedAction)) {
                    //IF ID HAS WHITE SPACE, REMOVE IT
                    if (pData[i].IntendedAction.indexOf(' ') > 0) {
                        intendIdVal = pData[i].IntendedAction.replace(/\s/g, '');
                    }
                }
                view.IntendedActionData.push({ "name": pData[i].IntendedAction, "value": pData[i].IntendedAction, "id": intendIdVal + i });
            }

            view.setAppliedFilterLabelText(view.selectedDivisionItems(), view.selectedClientLocationIDs(), view.selectedIntendedActionItems());

            //view.CategoryAxisLabels(view.removeDuplicates(view.CategoryAxisLabels()));
            view.PieChartData(view.removeDuplicates(view.PieChartData()));
            view.DivisionData(view.removeDuplicates(view.DivisionData()));
            view.ClientLocIDData(view.removeDuplicates(view.ClientLocIDData()));
            view.IntendedActionData(view.removeDuplicates(view.IntendedActionData()));

            //view.populatePieChartData(pData, view.PieChartData());
            view.splitChartData(pData, "Bar");
            view.splitChartData(pData, "Pie");
            view.splitChartData(pData, "Line");
            view.splitChartData(pData, "Column");
        },

        setAppliedFilterLabelText: function (pDivList, pClientLocList, pIntendedList) {
            //SET APPLIED FILTERS LABLE TEXT
            //debugger;
            view.appliedFiltersTxt('');
            if (pDivList.length == 0 && pClientLocList.length == 0 && pIntendedList == 0) {
                view.appliedFiltersTxt("None");
            } else if (pDivList.length > 0) {
                var divisionLabel = "Division: ";
                var tempLabel = "";
                tempLabel += divisionLabel;
                for (var i = 0; i < pDivList.length; i++) {
                    if (pDivList.length > 1) {
                        tempLabel += pDivList[i].name + ", ";
                    } else {
                        tempLabel += pDivList[i].name;
                    }
                }
                view.appliedFiltersTxt(tempLabel);
            }
        },

        splitChartData: function (pData, pChartType) {

            switch (pChartType) {
                case "Pie":
                    //CLEAR ARRAYS
                    view.PieChartAdvisory([]);
                    view.PieChartInProgress([]);
                    view.PieChartOutstanding([]);
                    view.PieChartRptdComp([]);
                    view.PieChartConfComp([]);
                    view.PieChartData([]);

                    for (var i = 0; i < pData.length; i++) {
                        switch (pData[i].RecStatus) {
                            case "Advisory":
                                view.PieChartAdvisory.push(pData[i]);
                                break;
                            case "In Progress":
                                view.PieChartInProgress.push(pData[i]);
                                break;
                            case "Outstanding":
                                view.PieChartOutstanding.push(pData[i]);
                                break;
                            case "Rptd Completed":
                                view.PieChartRptdComp.push(pData[i]);
                                break;
                            case "Conf Completed":
                                view.PieChartConfComp.push(pData[i]);
                                break;
                        }
                    }
                    if (view.PieChartAdvisory().length > 0) {
                        view.PieChartData.push({ "status": "Advisory", "count": view.PieChartAdvisory().length, "color": "#ffffff" });
                    }
                    if (view.PieChartInProgress().length > 0) {
                        view.PieChartData.push({ "status": "In Progress", "count": view.PieChartInProgress().length, "color": "#ffc000" });
                    }
                    if (view.PieChartOutstanding().length > 0) {
                        view.PieChartData.push({ "status": "Outstanding", "count": view.PieChartOutstanding().length, "color": "#fa0107" });
                    }
                    if (view.PieChartRptdComp().length > 0) {
                        view.PieChartData.push({ "status": "Rptd Completed", "count": view.PieChartRptdComp().length, "color": "#91d34d" });
                    }
                    if (view.PieChartConfComp().length > 0) {
                        view.PieChartData.push({ "status": "Conf Completed", "count": view.PieChartConfComp().length, "color": "#21596a" });
                    }
                    break;
                case "Line":
                    //LINE CHART IS ONLY CONFIMED COMPLETED RECS
                    var tempArray = [];
                    //REST DATA SET
                    view.ListOfYears([]);

                    for (var i = 0; i < pData.length; i++) {
                        if (pData[i].RecStatus == "Conf Completed") {
                            tempArray.push({ "year": pData[i].RecYear, "value": pData[i].RecNo });
                        }
                    }
                    
                    view.ListOfYears(tempArray);
                    break;
                case "Column":
                    //RESET DATA SET
                    view.RecImpactData([]);
                    view.RecImpactLow([]);
                    view.RecImpactModerate([]);
                    view.RecImpactHigh([]);

                    for (var i = 0; i < pData.length; i++) {
                        switch (pData[i].RecImpact) {
                            case "Low":
                                view.RecImpactLow.push(pData[i]);
                                break;
                            case "Moderate":
                                view.RecImpactModerate.push(pData[i]);
                                break;
                            case "High":
                                view.RecImpactHigh.push(pData[i]);
                                break;
                        }
                    }
                    if(view.RecImpactLow().length > 0){
                        view.RecImpactData.push({ "Impact": "Low", "Count": view.RecImpactLow().length, "Color": '#00FF00' });
                    }
                    if (view.RecImpactModerate().length > 0) {
                        view.RecImpactData.push({ "Impact": "Moderate", "Count": view.RecImpactModerate().length, "Color": '#FFFF37' });
                    }
                    if (view.RecImpactHigh().length > 0) {
                        view.RecImpactData.push({ "Impact": "High", "Count": view.RecImpactHigh().length, "Color": '#FF3737' });
                    }
                    break;
                case "Bar":
                    //RESET DATA SET
                    view.BarChartData([]);
                    
                    var tempRecTotal = 0;
                    var tempCostToComp = 0;
                    var oldCostTotal = 0;

                    for (var i = 0; i < pData.length; i++) {
                        for (var j = 0; j < view.CategoryAxisLabels().length; j++) {
                            if (tempCostToComp > oldCostTotal) {
                                oldCostTotal = tempCostToComp;
                            }
                            if (pData[i].PrimaryRecType == view.CategoryAxisLabels()[j]) {
                                var tempType = pData[i].PrimaryRecType;
                                tempRecTotal += pData[i].RecNo;
                                tempCostToComp += pData[i].EstdCostToCompUSD;
                                view.BarChartData.push({ "CategoryLabel" : tempType, "TotalRecs": tempRecTotal, "CostToComp": tempCostToComp});
                            }
                        }
                    }

                    view.BarChartTopCostToComplete(oldCostTotal);
                    break;
            }
            
        },

        removeDuplicates: function (pData) {
            var newArray = [];
            $.each(pData, function (key, value) {
                var exists = false;
                $.each(newArray, function (k, val2) {
                    if (value.name == val2.name) {
                        exists = true;
                    }
                });
                if (exists == false && value.name != '') {
                    newArray.push(value);
                }
            });
            return newArray;
            
        },

        setupKendoAccordian: function () {
            $('#panelbar').kendoPanelBar({
                expandMode: "single",
                select: view.expandCollapse
            });
        },

        setUpKendoCharts: function () {
            $('#BarChartTest').kendoChart({
                title: {
                    text: "Reported/Confirmed Completed Recomendations(By Rec Type)",
                    color: "#1961ad"
                },
                legend: {
                    labels: {
                        color: "#000"
                    },
                    position: "bottom"
                },
                dataSource: {
                    data: view.BarChartData()
                },
                seriesDefaults: {
                    type: "bar",
                    labels: {
                        color: "#000"
                    }
                },
                series: [{
                    axis: "Number Of Recs",
                    name: "Number Of Recs",
                    field: "TotalRecs",
                    categoryField: "CategoryLabel",
                    color: "#0000FF",
                    labels: {
                        color: "#000000"
                    }
                }, {
                    axis: "Cost To Complete",
                    name:"Average of Estimated Cost To Complete",
                    field: "CostToComp",
                    categoryField: "CategoryLabel",
                    color: "#008000",
                    labels: {
                        color: "#000000"
                    }
                }],
                valueAxis: [{
                    name: "Number Of Recs",
                    title: { text: "No. Of Recs", color: "#000000" },
                    min: 0,
                    majorUnit: view.CategoryAxisMajorUnit(),
                    labels: {
                        color: "#000"
                    }
                },
				{
				    name: "Cost To Complete",
				    title: { text: "Cost To Complete", color: "#000000" },
				    min: 0,
				    majorUnit: view.CategoryAxisMajorUnit(),
				    labels: {
				        rotation: -45,
				        format: "{0:n0}",
				        color: "#000000"
				    }

				}],
                chartArea: {
                    height: 425,
                    width: 750,
                    background: "#ffffff",
                    color: "#000000"
                },
                categoryAxis: {
                    axisCrossingValues: [50, 0],
                    labels: {
                        color: "#000"
                    }
                },
                tooltip: {
                    visible: true,
                    template: "#= series.name #: #= kendo.toString(value, 'n0') #",
                    format: "n0"
                },
                render: function (e) {
                    view.getMaxAxisValue(e, "Cost To Complete");
                    view.getMaxAxisValue(e, "Number Of Recs");
                }
            });

            $('#pieChartTest').kendoChart({
                title: {
                    text: "Recs by Status",
                    color: "#1961ad"
                },
                legend: {
                    labels: {
                        color: "#000"
                    }
                },
                chartArea: {
                    height: 425,
                    width: 650,
                    background: "#fff"
                },
                dataSource: {
                    data: view.PieChartData()
                },
                series: [{
                    type: "pie",
                    labels: {
                        visible: true,
                        background: "transparent",
                        template: "#= category #: \n #= value#",
                        color: "#000"
                    },
                    border: {
                        width: 1,
                        color: "#808080"
                    },
                    categoryField: "status",
                    field: "count",
                    color: "color",
                    displayPercentage: true,
                }],
            });

            $('#lineChartTest').kendoChart({
                title: {
                    text: "Reported/Confirmed Completed Recomendations(By Year)",
                    color: "#1961ad"
                },
                legend: {
                    labels: {
                        color: "#000"
                    }
                },
                chartArea: {
                    height: 300,
                    width: 750,
                    background: "#fff"
                },
                seriesDefaults: {
                    type: "line",
                    style: "smooth",
                    labels: {
                        color: "#000"
                    }
                },
                dataSource:{
                    data: view.ListOfYears(),
                    sort: {field: "year"}
                },
                series: [{
                    name: "Number Of Completed Recs",
                    field: "value",
                    categoryField: "year",
                    color:"#00457b"
                }
                ],
                valueAxis: {
                    labels: {
                        format: "{0}",
                        color: "#000"
                    },
                    line: {
                        visible: false
                    }
                },
                categoryAxis: {
                    majorGridLines: {
                        visible: false
                    },
                    baseUnit: "years",
                    labels: {
                        color: "#000"
                    }
                },
                dataBound: function (e) {
                    var axis = e.sender.options.categoryAxis;
                    axis.categories = axis.categories.sort();
                    if (view.ListOfYears().length > 5) {
                        e.sender.options.categoryAxis.labels.step = 2
                    } else {
                        e.sender.options.categoryAxis.labels.step = 1;
                    }
                }
            });

            $('#columnChartTest').kendoChart({
                title: {
                    text: "Recs by Impact",
                    color: "#1961ad"
                },
                chartArea: {
                    height: 300,
                    width: 600,
                    background: "#fff"
                },
                dataSource: {
                    data: view.RecImpactData()
                },
                categoryAxis: {
                    labels: {
                        color: "#000"
                    }
                },
                valueAxis: {
                    labels: {
                        format: "{0}",
                        color: "#000"
                    },
                },
                seriesDefaults: {
                    type: "column"
                },
                series: [
                    {
                        field: "Count",
                        categoryField: "Impact",
                        colorField: "Color"
                    }
                ],
                tooltip: {
                    visible: true,
                    format: "N0",
                    color: "#000"
                }
            });
        },

        setUpKendoWindows: function () {
            if (view.divisionPicklistWindow == null) {
                $('#divisionPicklistWindow').kendoWindow({
                    visible: false,
                    title: "Pick List",
                    actions: ["Close"],
                    width: "300px",
                    height: "425px",
                    modal: true
                });
                view.divisionPicklistWindow = $('#divisionPicklistWindow').data("kendoWindow");
            }

            if (view.clientLocIdPicklistWindow == null) {
                $('#clientLocIdPicklistWindow').kendoWindow({
                    visible: false,
                    title: "Pick List",
                    actions: ["Close"],
                    width: "300px",
                    height: "425px",
                    modal: true
                });
                view.clientLocIdPicklistWindow = $('#clientLocIdPicklistWindow').data("kendoWindow");
            }

            if (view.intendedActionPicklistWindow == null) {
                $('#intendedActionPicklistWindow').kendoWindow({
                    visible: false,
                    title: "Pick List",
                    actions: ["Close"],
                    width: "300px",
                    height: "425px",
                    modal: true
                });
                view.intendedActionPicklistWindow = $('#intendedActionPicklistWindow').data('kendoWindow');
            }

            if (view.facilityPicklistWindow == null) {
                $('#facilityPicklistWindow').kendoWindow({
                    visible: false,
                    title: "Pick List",
                    actions: ["Close"],
                    width: "300px",
                    height: "425px",
                    modal: true
                });
                view.facilityPicklistWindow = $('#facilityPicklistWindow').data('kendoWindow');
            }

            if (view.secondaryRecTypePicklistWindow == null) {
                $('#secondaryRecTypePicklistWindow').kendoWindow({
                    visible: false,
                    title: "Pick List",
                    actions: ["Close"],
                    width: "300px",
                    height: "425px",
                    modal: true
                });
                view.secondaryRecTypePicklistWindow = $('#secondaryRecTypePicklistWindow').data('kendoWindow');
            }

        },

        setupPicklists: function (pFilterData) {
            if (!view.picklist) {
                view.picklist = new utilPicklist();
                view.picklist.setupOptions();
                view.picklist.initPickList("divisionPicklistWindow", null, pFilterData, null);
                view.picklist.initPickList("clientLocIdPicklistWindow", null, pFilterData, null);
                view.picklist.initPickList("intendedActionPicklistWindow", null, pFilterData, null);

            } else {
                view.picklist.resetPicklist(pFilterData);
            }
        },

        /* 
        ** FUNCTION TO FIND MAX VALUE IN DATA SET
        ** THIS SETS UPPER BOUND FOR CATEGORY AXIS LABEL
        ** ALSO SETS THE 'MAJORUNIT' VALUE BASED ON CATEGORY AXIS UPPER BOUND
        ** KEEP THIS FOR PRODUCTION BUILD
        */
        getMaxAxisValue: function (pData, pAxis) {
            var range = pData.sender.getAxis(axis).range();
            var max = range.max;
            var tempMajorUnit = 0;
            var axis = pData.sender.options.valueAxis;
            if (axis.max !== max) {
                axis.max = max;
                tempMajorUnit = max / 10
                view.CategoryAxisMajorUnit(tempMajorUnit);
            }
        },

        onLineChartDataBind: function (e) {
            var lineChart = $('#lineChartTest').data("kendoChart");
        },

        /* FUNCTION TO CLOSE AN OPEN ACCORDIAN ON CLICK */
        expandCollapse: function (e) {
            if ($(e.item).is('.k-state-active')) {
                var that = this;
                window.setTimeout(function () { that.collapse(e.item); }, 1);
            }
        },

        changeChart: function (filterSet) {
            //SET CHART OBJECTS
            var barChart = $('#BarChartTest').data("kendoChart");
            var pieChart = $('#pieChartTest').data('kendoChart');
            var lineChart = $('#lineChartTest').data('kendoChart');
            var columnChart = $('#columnChartTest').data('kendoChart');

            //UPDATE CHARTS BASED ON SENT CRITERIA
            switch (filterSet) {
                case 'Division':
                    //Division

                    //filter data based on selected picklist items
                    if (view.selectedDivisionItems().length > 0) {
                        for (var i = 0; i < view.selectedDivisionItems().length; i++) {
                            for (var j = i; j < view.originalDataSet().length; j++) {
                                if (view.originalDataSet()[j].Division == view.selectedDivisionItems()[i].name) {
                                    view.filteredDataSetForCharts.push(view.originalDataSet()[j]);
                                }
                            }
                        }
                    } else {
                        view.filteredDataSetForCharts(view.originalDataSet());
                    }

                    //reset bar chart data
                    view.BarChartData([]);
                    
                    //filter new data set for charts
                    view.splitChartData(view.filteredDataSetForCharts(), "Bar");
                    view.splitChartData(view.filteredDataSetForCharts(), "Pie");
                    view.splitChartData(view.filteredDataSetForCharts(), "Line");
                    view.splitChartData(view.filteredDataSetForCharts(), "Column");

                    barChart.setDataSource(view.BarChartData());
                    //barChart.options.valueAxis[1].max = view.BarChartTopCostToComplete();
                    pieChart.setDataSource(view.PieChartData());
                    lineChart.setDataSource(view.ListOfYears());
                    columnChart.setDataSource(view.RecImpactData());

                    //redraw charts
                    barChart.refresh();
                    barChart.redraw();
                    pieChart.refresh();
                    lineChart.refresh();
                    columnChart.refresh();
                    view.setAppliedFilterLabelText(view.selectedDivisionItems(), view.selectedClientLocationIDs(), view.selectedIntendedActionItems());
                    break;
                case 'ClientLocation':
                    view.NumOfRecsData([]);
                    view.CategoryAxisLabels([]);
                    view.CostToCompData([]);
                    
                    if (view.selectedClientLocationIDs().length) {
                        for (var i = 0; i < view.selectedClientLocationIDs().length; i++) {
                            for (var j = i; j < view.originalDataSet().length; j++) {
                                if (view.originalDataSet()[j].ClientLocID == view.selectedClientLocationIDs()[i].name) {
                                    view.filteredDataSetForCharts.push(view.originalDataSet()[j]);
                                }
                            }
                        }
                    } else {
                        view.filteredDataSetForCharts(view.originalDataSet());
                    }

                    //filter new data set for charts
                    view.splitChartData(view.filteredDataSetForCharts(), "Bar");
                    view.splitChartData(view.filteredDataSetForCharts(), "Pie");
                    view.splitChartData(view.filteredDataSetForCharts(), "Line");
                    view.splitChartData(view.filteredDataSetForCharts(), "Column");

                    barChart.setDataSource(view.BarChartData());
                    //barChart.options.valueAxis[1].max = view.BarChartTopCostToComplete();
                    pieChart.setDataSource(view.PieChartData());
                    lineChart.setDataSource(view.ListOfYears());
                    columnChart.setDataSource(view.RecImpactData());

                    //redraw charts
                    barChart.refresh();
                    barChart.redraw();
                    pieChart.refresh();
                    lineChart.refresh();
                    columnChart.refresh();
                    view.setAppliedFilterLabelText(view.selectedDivisionItems(), view.selectedClientLocationIDs(), view.selectedIntendedActionItems());

                    break;
                case 3:
                    //All Three
                    alert('Functionality still in development');
                    break;
            }
             
        },

        /* PICKLIST FUNCTIONS */
        onDivPickList: function () {
            view.divisionPicklistWindow.center().open();
            //view.picklist.pickListOpen(view.divisionPicklistWindow);
        },

        divisionListItemClick: function (pId) {
            for (var i = 0; i < view.DivisionData().length; i++) {
                if (pId == view.DivisionData()[i].id) {
                    var item = $('#' + pId);
                    
                    if (item.is(":checked")) {
                        view.selectedDivisionItems.push(view.DivisionData()[i]);
                        view.changeChart('Division');
                        view.hasDataBeenFiltered(true);
                    } else {
                        var idxToRemove = view.selectedDivisionItems().indexOf(view.DivisionData()[i]);
                        view.selectedDivisionItems.splice(idxToRemove, 1);
                        view.changeChart('Division');
                        view.hasDataBeenFiltered(true);
                    }
                }
            }
        },

        clientLocIDListItemClick: function (pId) {
            for (var i = 0; i < view.ClientLocIDData().length; i++) {
                if (pId == view.ClientLocIDData()[i].id) {

                    var item = $('#' + pId);

                    if (item.is(":checked")) {
                        view.selectedClientLocationIDs.push(view.ClientLocIDData()[i]);
                        view.changeChart('ClientLocation');
                        view.hasDataBeenFiltered(true);
                    } else {
                        var idxToRemove = view.selectedClientLocationIDs().indexOf(view.ClientLocIDData()[i]);
                        view.selectedClientLocationIDs.splice(idxToRemove, 1);
                        view.changeChart('ClientLocation');
                        view.hasDataBeenFiltered(true);
                    }
                }
            }
        },

        pickListApplyFilter: function (pDataPointToChange) {
            var dataPointToChange = pDataPointToChange
            switch (dataPointToChange) {
                case 'Division':
                    view.changeChart('Division');
                    view.hasDataBeenFiltered(true);
                    view.divisionPicklistWindow.close();
                    view.selectedDivisionItems([]);
                    break;
                case 'ClientLocation':
                    view.changeChart('ClientLocation');
                    view.hasDataBeenFiltered(true);
                    view.clientLocIdPicklistWindow.close();
                    break;
                case 'IntendedAction':
                    view.changeChart('IntendedAction');
                    view.hasDataBeenFiltered(true);
                    view.intendedActionPicklistWindow.close();
            }
            
        },

        bindForm: function () {
            ko.applyBindings(view, $("#view")[0]);
        },

    }

    view.bindForm();
    view.init();

    gDivisionItemCheck = function (pID) {
        view.divisionListItemClick(pID);
    }

    gClientLocIDItemCheck = function (pID) {
        view.clientLocIDListItemClick(pID);
    }

    gPickListApplyFilter = function (currentPicklist) {
        view.pickListApplyFilter(currentPicklist);
    }

    
});

/* THINGS THAT DIDN'T WORK/WERE NOT NEEDED */


/* PICKLIST FUNCTIONS */

/*

onClientLocPickList: function () {
            view.clientLocIdPicklistWindow.center().open();
        },

        onIntendedActionPickList: function () {
            view.intendedActionPicklistWindow.center().open();
        },

        onFacilityPickList: function () {
            view.facilityPicklistWindow.center().open();
        },

        onSecondaryRecTypePickList: function () {
            view.secondaryRecTypePicklistWindow.center().open();
        },

        pickListCheckAll: function (pList) {
            
            var currentWindowPicklist;
            try {
                if (pList != null) {
                    switch (pList) {
                        case 'Division':
                            currentWindowPicklist = view.DivisionData();
                            for (var x = 0; x < currentWindowPicklist.length; x++) {
                                debugger;
                                var item = $('#' + currentWindowPicklist[x].id);
                                if (item.prop('checked') != true) {
                                    debugger;
                                    item.prop('checked', true);
                                    view.selectedDivisionItems.push(currentWindowPicklist[x]);
                                }
                            }
                            break;
                        case 'ClientLocation':
                            currentWindowPicklist = view.ClientLocIDData();
                            for (var x = 0; x < currentWindowPicklist.length; x++) {
                                debugger;
                            }
                            break;
                        case 'IntendedAction':
                            currentWindowPicklist = view.IntendedActionData();
                            for (var x = 0; x < currentWindowPicklist.length; x++) {
                                debugger;
                            }
                            break;
                    }
                }
            } catch (pException) {
            }
        },

        pickListCheckNone: function () {

        },

        pickListCheckReverse: function () { },

        gPickListCheckAll = function (currentPicklist) {
        view.pickListCheckAll(currentPicklist);
    }

    gPicklistCancel = function (winID) {
        view.pickListCancel(winID);
    }

    pickListCancel: function (pID) {
            try {
                switch (pID) {
                    case 'Division':
                        view.divisionPicklistWindow.close();
                        break;
                    case 'ClientLocation':
                        view.clientLocIdPicklistWindow.close();
                        break;
                    case 'IntendedAction':
                        view.intendedActionPicklistWindow.close();
                        break;
                }
            } catch (pException) {
                view.processMessage("An error occurred while doing pick list action: " + pException.message);
            }
        },

*/