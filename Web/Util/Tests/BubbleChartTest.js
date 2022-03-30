$(document).ready(function () {
    view = {
        bubbleChart: null,
        chartDataSet: ko.observableArray(),
        BubbleChartLbl: ko.observable("City"),
        labelDropDownData: ko.observableArray(),

        init: function () {
            view.loadData();
            $('#chartTooltip').kendoTooltip({content:''});
            view.setUpBubbleChart();
            //view.makeToolTipsStayOpen();
            view.setUpKendoDropDown();
        },

        loadData: function () {
            view.chartDataSet(dataObject30.data);
            view.labelDropDownData(dataObject30.labelDropDownData);
        },

        labelDDChange: function (e) {
            if (e.sender.selectedIndex >= 0) {
                for (var i = e.sender.selectedIndex; i < view.labelDropDownData().length; i++) {
                    view.BubbleChartLbl(view.labelDropDownData()[i].value);
                    var chart = $("#bubbleChart").data("kendoChart");
                    chart.options.series[0].categoryField = view.BubbleChartLbl();
                    chart.refresh();
                    break;
                }
            }
        },

        onSeriesClick: function (e) {
            $('#bubbleChart .k-tooltip').html(e.dataItem).show();
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

        setUpBubbleChart: function () {
            $('#bubbleChart').kendoChart({
                dataSource: {
                    data: view.chartDataSet()
                },
                chartArea: {
                    background: "#ffffff",
                    color: "#000000",
                    height: 700
                },
                title: "Circle size represents the Maximum Forseable Loss (MFL)",
                //seriesClick: view.onSeriesClick,
                seriesHover: function (e) {
                    var toolTip = $('#chartTooltip').data('kendoTooltip');
                    toolTip.options.content = e.category + ": " + e.value.size;
                    toolTip.show($(e.element));
                },
                series: [{
                    type: "bubble",
                    xField: "CurrentLossEstUSD",
                    yField: "CurrentScore",
                    sizeField: "MFL_TOTAL",
                    color: "#dadfe1",
                    border: {
                        color: "#6c7a89",
                        width: 1
                    },
                    categoryField: view.BubbleChartLbl(),
                    labels: {
                        visible: true,
                        color: "#000",
                        format: "{3}"
                    },
                    //tooltip: {
                    //    visible: true,
                    //    format: "{3}: MFL - {2:N0}",
                    //    autoHide: false
                    //},
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
                    plotBands: [
                        {
                            from: 0,
                            to: dataObject30.ChartDetails.RatingLowBounds,
                            color: dataObject30.ChartDetails.RatingLowBGHex,
                            opacity: .7
                        },
                        {
                            from: 60,
                            to: dataObject30.ChartDetails.RatingMidBounds,
                            color: dataObject30.ChartDetails.RatingMidBGHex,
                            opacity: .7
                        },
                        {
                            from: 90,
                            to: dataObject30.ChartDetails.RatingHighBounds,
                            color: dataObject30.ChartDetails.RatingHighBGHex,
                            opacity: .7
                        }
                    ],
                    title: {
                        text: "Rating"
                    }
                },
            });
        },

        setUpKendoDropDown: function () {
            $('#labelDD').kendoDropDownList({
                dataTextField: "text",
                dataValueField: "value",
                dataSource: view.labelDropDownData(),
                index: 0,
                change: function (e) { view.labelDDChange(e) }
            });
        },

        makeToolTipsStayOpen: function () {
            //var chart = $("#bubbleChart").data("kendoChart");
            var tooltip = $('#htmlCanvasHldr').kendoTooltip({
                autoHide: false
            }).data("kendoTooltip");
        },

        bindForm: function () {
            ko.applyBindings(view, $("#view")[0]);
        }
    }

    view.bindForm();
    view.init();
});