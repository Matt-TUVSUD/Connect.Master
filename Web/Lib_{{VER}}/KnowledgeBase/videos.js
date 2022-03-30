$(document).ready(function () {
    var viewVideos = {
        countLoading: 0,
        userGUID: ko.observable(getGSafeGUID()),
        systemNode: ko.observable("videos"),
        EnglishPanelData: ko.observableArray(),
        SpanishPanelData: ko.observableArray(),

        init: function () {
            viewVideos.countLoading = 1;
            viewVideos.loadVideos(viewVideos.systemNode());
        },

        loadVideos: function () {
            try {
                var pGSafeGuid = viewVideos.userGUID();
                var zServiceName = "GetTrainingVideos";
                var zParms = ko.toJSON({
                    "pGSafeGuid": getGSafeGUID()
                });
                global.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, viewVideos.loadVideosSuccess, viewVideos.loadVideosError, null);
            } catch (pException) {
                viewVideos.processMessage("An error occurred while starting the videos data call: " + pException.message);
            }
        },

        loadVideosSuccess: function (pResults) {
            try {


                
                if (pResults.isSuccess) {

                    var EnglishVideos = new kendo.data.DataSource;
                    var SpanishVideos = new kendo.data.DataSource;

                    for (var i = 0; i < pResults.data.length; i++) {
                                switch (pResults.data[i]["Language"]) {
                                    case "English":
                                        EnglishVideos.add(pResults.data[i]);
                                        viewVideos.EnglishPanelData(pResults.data[i]);
                                        break;
                                    case "Spanish":
                                        SpanishVideos.add(pResults.data[i]);
                                        viewVideos.SpanishPanelData(pResults.data[i]);
                                        break;
                                }
                    }

                    viewVideos.setupKendo();

                    var listView = $("#listView").kendoListView({
                        dataSource: EnglishVideos,
                        selectable: true,
                        scrollable: false,
                        template: kendo.template($("#template").html()),
                        change: onChange,
                        dataBound: onDataBound
                    });


                    var listView2 = $("#listView2").kendoListView({
                        dataSource: SpanishVideos,
                        selectable: true,
                        scrollable: false,
                        template: kendo.template($("#template").html()),
                        change: onChange2,
                        dataBound: onDataBound
                    });


                }
            } catch (pException) {
                viewVideos.processMessage("An error occurred while completinging the videos data call: " + pException.message);
            }
        },

        loadVideosError: function (pResults, pMessage, pErrorDetail, pParms) {
            viewVideos.processMessage("Error while loading Video data. " + pMessage);
        },

        selectPanel: function (panelId) {
            var panelBar = $('#VideosPanel').data("kendoPanelBar");
            if (panelId) {
                switch (panelId) {
                    case 'English':
                        panelBar.expand($('#englishPanel'));
                        break;
                    case "Spanish":
                        panelBar.expand($('#spanishPanel'));
                        break;
                }
            }
        },

        setupKendo: function () {
            $('#VideosPanel').kendoPanelBar({
                expandMode: "multiple",
            });

            $("#mediaplayer").kendoMediaPlayer({
                autoPlay: false
            });

            $("#mediaplayer2").kendoMediaPlayer({
                autoPlay: false
            });
        },

        processMessage: function (pMessage) {
            alert(pMessage);
        },

        bindForm: function () {
            ko.applyBindings(viewVideos, $("#viewVideos")[0]);
        },

    }

    //INITIALIZE PAGE
    viewVideos.bindForm();
    viewVideos.init();

    function onChange() {
        var index = this.select().index();
        var dataItem = this.dataSource.view()[index];
        $("#mediaplayer").data("kendoMediaPlayer").media(dataItem);
    }

    function onChange2() {
        var index = this.select().index();
        var dataItem = this.dataSource.view()[index];
        $("#mediaplayer2").data("kendoMediaPlayer").media(dataItem);
    }

    function onDataBound() {
        this.select(this.element.children().first());
    }

});
