$(document).ready(function () {
    // BEFORE ANY CODE, TURN ON THE LOADING ICON, AND SETUP THE FORM
    //kendo.ui.progress($("#divContainerLoading"), false);
    //$('#divContainerLoading').show();

    viewBubbleChart = {
        bubbleChart: null,
        chartDataSet: ko.observableArray(),
        bubbleChartLbl: ko.observable("City"),
        chartRatingRanges: ko.observableArray(),
        customAccessLbl: ko.observable(),
        labelDropDownData: ko.observableArray([
            { text: "City", value: "City" },
            { text: "Client Location ID", value: "ClientLocID" },
            { text: "Facility Name", value: "Facility" },
            { text: "Division", value: "Division" },
            { text: "GRC File No.", value: "FileNo" }]),
        userGUID: ko.observable(),
        gridFilter: ko.observable(),
        practiceId: ko.observable(),
        txtMessage: ko.observable(),
        countLoading: 3,

        init: function () {
            viewBubbleChart.userGUID(global.getQueryVariable('sid'));
            var decodedFilter = decodeURI(global.getQueryVariable('filter'));
            viewBubbleChart.practiceId(parseInt(global.getQueryVariable('gridId')));
            viewBubbleChart.gridFilter(decodedFilter);
            viewBubbleChart.loadData(viewBubbleChart.userGUID(), viewBubbleChart.gridFilter());
            $('#chartTooltip').kendoTooltip({ content: '' });
        },


        /* START DATA FUNCTIONS */
        loadData: function (pGUID, pFilter) {
            viewBubbleChart.getCustomAccessLabel(pGUID);
            viewBubbleChart.getClientRatingRanges(pGUID);
        },

        getCustomAccessLabel: function (pGuid) {
            try {
                var zGUID = pGuid;
                var zServiceName = "GetCustomAccessLabel";
                var zParms = ko.toJSON({
                    "pGSafeGuid": getGSafeGUID()
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewBubbleChart.getCustomAccessLabelSuccess, viewBubbleChart.getCustomAccessLabelError, null);
            } catch (pException) {
                viewBubbleChart.processMessage("An error occurred while starting the custom access data call: " + pException.message);
            }
        },
        getCustomAccessLabelSuccess: function (pResults) {
            try {
                if (pResults.isSuccess) {
                    viewBubbleChart.customAccessLbl({ text: pResults.data, value: "CustomAccess" });
                    viewBubbleChart.setUpKendoDropDown();
                    //CHECK IF WE SHOULD HIDE LOADING SPINNER
                    viewBubbleChart.countLoading--;
                    if (viewBubbleChart.countLoading == 0) {
                        viewBubbleChart.hideLoadingScreen();
                    }
                }
            } catch (pException) {
                viewBubbleChart.processMessage("An error occurred while starting the custom access data call: " + pException.message);
            }
        },
        getCustomAccessLabelError: function (pResults, pMessage, pErrorDetail, pParms) {
            try {
                alert("Error while calling the custom access service. " + pMessage);
                viewBubbleChart.processMessage("Error while starting the custom access data call " + pMessage);
            } catch (pException) {
                viewBubbleChart.processMessage("An error occurred while starting the custom access data call: " + pException.message);
            }
        },

        getClientRatingRanges: function (pGuid) {
            try {
                var zGUID = pGuid;
                var zServiceName = "GetClientRatingRanges";
                var zParms = ko.toJSON({
                    "pGSafeGuid": getGSafeGUID()
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewBubbleChart.getClientRatingRangesSucces, viewBubbleChart.getClientRatingRangesError, null);
            } catch (pException) {
                viewBubbleChart.processMessage("An error occurred while starting the client rating ranges data call: " + pException.message);
            }
        },
        getClientRatingRangesSucces: function (pResults, pParms) {
            try {
                if (pResults.isSuccess) {
                    viewBubbleChart.chartRatingRanges(pResults.data);
                    //CHECK IF WE SHOULD HIDE LOADING SPINNER
                    viewBubbleChart.countLoading--;
                    if (viewBubbleChart.countLoading == 0) {
                        viewBubbleChart.hideLoadingScreen();
                    }
                    viewBubbleChart.getRatingByRecLE(viewBubbleChart.userGUID(), viewBubbleChart.gridFilter());
                }
            } catch (pException) {
                viewBubbleChart.processMessage("An error occurred while starting the client rating ranges data call: " + pException.message);
            }
        },
        getClientRatingRangesError: function (pResults, pMessage, pErrorDetail, pParms) {
            try {
                alert("Error while calling the client rating ranges service. " + pMessage);
                viewBubbleChart.processMessage("Error while starting the client rating ranges data call " + pMessage);
            } catch (pException) {
                viewBubbleChart.processMessage("An error occurred while starting the client rating ranges data call: " + pException.message);
            }
        },

        getRatingByRecLE: function (pGuid, pFilter) {
            try {
                var zGUID = pGuid;
                var zFilterGUID = pFilter;
                var zServiceName = "GetRatingByRecLeData";
                var zParms = ko.toJSON({
                    "pGSafeGuid": zGUID,
                    "pGridFilterGuid": zFilterGUID,
                    "pMetaPracticeID": viewBubbleChart.practiceId()
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewBubbleChart.getRatingByRecLESuccess, viewBubbleChart.getRatingByRecLEError, null);
            } catch (pException) {
                viewBubbleChart.processMessage("An error occurred while starting the rating by rec LE data call: " + pException.message);
            }
        },
        getRatingByRecLESuccess: function (pResults, pParms) {
            try {
                if (pResults.isSuccess) {
                    viewBubbleChart.chartDataSet(pResults.data);
                    viewBubbleChart.setUpBubbleChart();
                    //CHECK IF WE SHOULD HIDE LOADING SPINNER
                    viewBubbleChart.countLoading--;
                    if (viewBubbleChart.countLoading == 0) {
                        viewBubbleChart.hideLoadingScreen();
                    }
                }
            } catch (pException) {
                viewBubbleChart.processMessage("An error occurred while starting the rating by rec LE data call: " + pException.message);
            }
        },
        getRatingByRecLEError: function (pResults, pMessage, pErrorDetail, pParms) {
            try {
                alert("Error while calling the rating by rec LE service. " + pMessage);
                viewBubbleChart.processMessage("Error while starting the rating by rec LE data call " + pMessage);
            } catch (pException) {
                viewBubbleChart.processMessage("An error occurred while starting the rating by rec LE data call: " + pException.message);
            }
        },

        /* END DATA FUNCTIONS */

        /* START PAGE FUNCTIONS */

        setUpKendoDropDown: function () {
            viewBubbleChart.labelDropDownData().push(viewBubbleChart.customAccessLbl());
            $('#labelDD').kendoDropDownList({
                dataTextField: "text",
                dataValueField: "value",
                dataSource: viewBubbleChart.labelDropDownData(),
                index: 0,
                change: function (e) { viewBubbleChart.labelDDChange(e) }
            });
        },

        labelDDChange: function (e) {
            if (e.sender.selectedIndex >= 0) {
                for (var i = e.sender.selectedIndex; i < viewBubbleChart.labelDropDownData().length; i++) {
                    viewBubbleChart.bubbleChartLbl(viewBubbleChart.labelDropDownData()[i].value);
                    
                    var chart = $("#bubbleChart").data("kendoChart");
                    chart.options.series[0].categoryField = viewBubbleChart.bubbleChartLbl();
                    chart.refresh();
                    break;
                }
            }
        },

        makeChartImage: function () {
            var chart = $("#bubbleChart").data("kendoChart");
            chart.exportImage().done(function (data) {
                kendo.saveAs({
                    dataURI: data,
                    fileName: "chart.png"
                });
            })
        },

        makeChartPDF: function () {
            var chart = $("#bubbleChart").data("kendoChart");
            chart.exportPDF({ paperSize: "auto", margin: { left: "1cm", top: "1cm", right: "1cm", bottom: "1cm" } }).done(function (data) {
                kendo.saveAs({
                    dataURI: data,
                    fileName: "chart.pdf"
                });
            });
        },

        /* END PAGE FUNCTIONS */

        /* START CHART FUNCTIONS */

        setUpBubbleChart: function () {
            $('#bubbleChart').kendoChart({
                dataSource: {
                    data: viewBubbleChart.chartDataSet()
                },
                chartArea: {
                    background: "#ffffff",
                    color: "#000000",
                    height: 700
                },
                title: "Circle size represents the Maximum Forseable Loss (MFL)",
                seriesHover: function (e) {
                    var toolTip = $('#chartTooltip').data('kendoTooltip');
                    toolTip.options.content = e.category + ": " + e.value.size;
                    toolTip.show($(e.element));
                },
                series: [{
                    type: "bubble",
                    xField: "LossEstBefore",
                    yField: "CurrentScore",
                    sizeField: "Mfl",
                    color: "#dadfe1",
                    border: {
                        color: "#6c7a89",
                        width: 1
                    },
                    categoryField: viewBubbleChart.bubbleChartLbl(),
                    labels: {
                        visible: true,
                        color: "#000",
                        format: "{3}"
                    },
                }],
                axisDefaults: {
                    majorGridLines: {
                        visible: false
                    }
                },
                xAxis: {
                    title: {
                        text: "Loss Expectancy"
                    },
                    labels: {
                        format: "{0:N0}"
                    },
                },
                yAxis: {
                    min:0,
                    max:120,
                    plotBands: [
                        {
                            from: viewBubbleChart.chartRatingRanges()[2].colFldScoreLow,
                            to: viewBubbleChart.chartRatingRanges()[2].colFldScoreHigh,
                            color: viewBubbleChart.chartRatingRanges()[2].colHexBackColor,
                            opacity: .7
                        },
                        {
                            from: viewBubbleChart.chartRatingRanges()[1].colFldScoreLow,
                            to: viewBubbleChart.chartRatingRanges()[1].colFldScoreHigh,
                            color: viewBubbleChart.chartRatingRanges()[1].colHexBackColor,
                            opacity: .7
                        },
                        {
                            from: viewBubbleChart.chartRatingRanges()[0].colFldScoreLow,
                            to: viewBubbleChart.chartRatingRanges()[0].colFldScoreHigh,
                            color: viewBubbleChart.chartRatingRanges()[0].colHexBackColor,
                            opacity: .7
                        }
                    ],
                    title: {
                        text: "Rating"
                    }
                },
            });
        },

        /* END CHART FUNCTIONS */

        bindForm: function () {
            ko.applyBindings(viewBubbleChart, $("#viewBubbleChart")[0]);
        },

        hideLoadingScreen: function () {
            $('#divContainerLoading').hide();
        },

        processMessage: function (pMessage) {
            viewBubbleChart.txtMessage(pMessage);
            global.messageShow("txtMessage", "messageGridError");
            viewBubbleChart.hideLoadingScreen();
        },
    }

    viewBubbleChart.bindForm();
    viewBubbleChart.init();
});