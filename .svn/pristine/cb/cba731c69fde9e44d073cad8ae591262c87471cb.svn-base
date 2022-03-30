$(document).ready(function () {
    
    view = {

        gridData: ko.observable(),
        ratingScoreChartWindow: ko.observable(),
        achievableRatingChartWindow: ko.observable(),
        riskImprovmentChartWindow: ko.observable(),

        init: function () {
            view.loadData();
        },

        loadData: function () {
            view.gridData(whatIfData);
            view.setupKendoCharts();
            view.setupKendoGrid();
            view.fixMagColumn();
            view.setupKendoWindows();
        },
        //loadDataSuccess: function () { },
        //loadDataError: function () { },

        fixMagColumn: function () {
            $('td').has('.searchImg').css('padding', '0px');
        },

        setupKendoGrid: function () {
            $('#gridDiv').kendoGrid({
                dataSource: {
                    data: view.gridData(),
                    pageSize: 10
                },
                scrollable: true,
                filterable: true,
                sortable: true,
                height: 285,
                width: 1700,
                pageable: true,
                toolbar: kendo.template($('#gridToolbar').html()),
                columns: [
                    {
                        width:25,
                        template: "<a href='\\#' class='searchImg'></a>",
                    },
                    {
                        field: "Link_to_Popup",
                        title: "Location Link",
                        width:50
                    },
                    {
                        selectable: true,
                        width: 35
                    },
                    {
                        field: "FileNo",
                        title: "File No.",
                        width: 85
                    },
                    {
                        field: "client",
                        title: "Client",
                        width:140
                    },
                    {
                        field: "ClientLocNo",
                        title: "Client Loc. No.",
                        width: 85
                    },
                    {
                        field: "Division",
                        title: "Division",
                        width: 140
                    },
                    {
                        field: "Facility",
                        title: "Facility",
                        width: 175
                    },
                    {
                        field: "address",
                        title: "Address",
                        width: 265
                    },
                    {
                        field: "City",
                        title: "City",
                        width: 85
                    },
                    {
                        field: "StProv",
                        title: "StProv",
                        width: 85
                    },
                    {
                        field: "Country",
                        title: "Country",
                        width: 85
                    },
                    {
                        field: "TIV",
                        title: "TIV",
                        width: 85
                    },
                    {
                        field: "RecYear",
                        title: "RecYear",
                        width: 85
                    },
                    {
                        field: "RecMonth",
                        title: "RecMonth",
                        width:85
                    },
                    {
                        field: "RecNumber",
                        title: "RecNumber",
                        width: 85
                    },
                    {
                        field: "RecSubletter",
                        title: "RecSubletter",
                        width: 85
                    },
                    {
                        field: "RecStatus",
                        title: "RecStatus",
                        width: 135
                    },
                    {
                        field: "StatusDate",
                        title: "Status Date",
                        width: 85
                    },
                    {
                        field: "RecCategory",
                        title: "RecCategory",
                        width: 115
                    },
                    {
                        field: "PrimaryRecType",
                        title: "PrimaryRecType",
                        width: 115
                    },
                    {
                        field: "SecondaryRecType",
                        title: "SecondaryRecType",
                        width: 115
                    },
                    {
                        field: "RecKeyWords",
                        title: "RecKeyWords",
                        width: 185
                    },
                    {
                        field: "RecPriority",
                        title: "Rec. Priority",
                        width: 85
                    },
                    {
                        field: "RecCode",
                        title: "RecCode",
                        width: 85
                    },
                    {
                        field: "Hazard",
                        title: "Hazard",
                        width: 85
                    },
                    {
                        field: "LossExpectancyBeforeActual",
                        title: "LossExpectancyBeforeActual",
                        width:100
                    },
                    {
                        field: "LossExpectancyBefore",
                        title: "LossExpectancyBefore",
                        width: 100
                    },
                    {
                        field: "LossExpectancyAfterActual",
                        title: "LossExpectancyAfterActual",
                        width: 100
                    },
                    {
                        field: "LossExpectancyAfter",
                        title: "LossExpectancyAfter",
                        width: 100
                    },
                    {
                        field: "CostToCompleteActual",
                        title: "CostToCompleteActual",
                        width: 100
                    }
                ],
            });
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
                    data: view.gridData()
                },
                seriesDefaults: {
                    type: "column",
                    labels: {
                        color: "#000"
                    }
                },
                series: [{
                    name: "Client",
                    field: "",
                    categoryField: "CategoryLabel",
                    color: "#4472c4",
                    labels: {
                        color: "#000000"
                    }
                }, {
                    name: "What If Rating",
                    field: "",
                    categoryField: "CategoryLabel",
                    color: "#70ad47",
                    labels: {
                        color: "#000000"
                    }
                }],
                chartArea: {
                    height: 225,
                    width: 585,
                    background: "#ffffff",
                    color: "#000000"
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
                    data: view.gridData()
                },
                seriesDefaults: {
                    type: "column",
                    labels: {
                        color: "#000"
                    }
                },
                series: [{
                    name: "Current Achievable",
                    field: "",
                    categoryField: "CategoryLabel",
                    color: "#4472c4",
                    labels: {
                        color: "#000000"
                    }
                }, {
                    name: "What If Achievable",
                    field: "",
                    categoryField: "CategoryLabel",
                    color: "#70ad47",
                    labels: {
                        color: "#000000"
                    }
                }],
                chartArea: {
                    height: 225,
                    width: 585,
                    background: "#ffffff",
                    color: "#000000"
                },
            });

            $('#RiskImporvmentChart').kendoChart({
                legend: {
                    labels: {
                        color: "#000"
                    },
                    position: "bottom"
                },
                dataSource: {
                    data: view.gridData()
                },
                seriesDefaults: {
                    type: "column",
                    labels: {
                        color: "#000"
                    }
                },
                series: [{
                    name: "Risk",
                    field: "",
                    categoryField: "CategoryLabel",
                    color: "#4472c4",
                    labels: {
                        color: "#000000"
                    }
                }, {
                    name: "Cost",
                    field: "",
                    categoryField: "CategoryLabel",
                    color: "#70ad47",
                    labels: {
                        color: "#000000"
                    }
                }],
                chartArea: {
                    height: 225,
                    width: 585,
                    background: "#ffffff",
                    color: "#000000"
                },
            });
        },

        setupKendoWindows: function () {
            $('#ratingScoreChartWindow').kendoWindow({
                visible: false,
                title: "Rating Score",
                actions: ["Close"],
                width: "575px",
                height: "200px",
                modal: true,
                draggable: false,
                resizable: false
            });
            view.ratingScoreChartWindow = $('#ratingScoreChartWindow').data("kendoWindow");
        },

        ratingScoreClick: function () {
            view.ratingScoreChartWindow.center().open();
        },

        bindForm: function () {
            ko.applyBindings(view, $("#view")[0]);
        },
    }

    view.bindForm();
    view.init();

})