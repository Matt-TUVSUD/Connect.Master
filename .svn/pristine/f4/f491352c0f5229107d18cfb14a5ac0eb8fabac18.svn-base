//$(document).ready(function () {
//    /////////////////////////////////
//    //// GENERAL DECLARATIONS
//    var gSafeGuid = getGSafeGUID();
//    var collSiteMap = new es.objects.ViewCCNavLinkCollection();
//    var parms = "";
//    var dsMainMenuNavigation = [];
//    var dsMainMenuQuickRef = [];
//    var dsMainMenuLibrary = [];
//    var dsFireLocationListing = [];
//    var dsFireOutputReports = [];
//    var dsFireDataExtracts = [];
//    var dsBMLocationListing = [];
//    var dsBMOutputReports = [];
//    var dsBMDataExtracts = [];
//    var dsIRLocationListing = [];
//    var dsIROutputReports = [];
//    var dsIRDataExtracts = [];
//    var dsJurisLocationListing = [];
//    var dsJurisOutputReports = []
//    var dsJurisDataExtracts = [];
//    var dsNatHazSeismicLocationListing = [];
//    var dsNatHazSeismicOutputReports = [];
//    var dsNatHazSeismicDataExtracts = [];
//    var dsNatHazFloodLocationListing = [];
//    var dsNatHazFloodOutputReports = [];
//    var dsNatHazFloodDataExtracts = [];
//    var dsNatHazWindLocationListing = [];
//    var dsNatHazWindOutputReports = [];
//    var dsNatHazWindDataExtracts = [];


//    /////////////////////////////////
//    //// BUILD DATASOURCES
//    //// MAIN MENU
//    parms = gSafeGuid + "|" + "MainMenuNavigation";
//    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
//    if (!collSiteMap.ViewCCNavLinksByKeyword(parms)) {
//        dsMainMenuNavigation = buildDataSource();
//    } else {
//        alert("Error: Unable to build Main Menu Navigation.");
//    }
//    parms = gSafeGuid + "|" + "MainMenuQuickRef";
//    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
//    if (!collSiteMap.ViewCCNavLinksByKeyword(parms)) {
//        dsMainMenuQuickRef = buildDataSource();
//    } else {
//        alert("Error: Unable to build Main Menu Quick Reference.");
//    }
//    parms = gSafeGuid + "|" + "MainMenuLibrary";
//    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
//    if (!collSiteMap.ViewCCNavLinksByKeyword(parms)) {
//        dsMainMenuLibrary = buildDataSource();
//    } else {
//        alert("Error: Unable to build Main Menu Libraries.");
//    }

//    //// FIRE
//    parms = gSafeGuid + "|" + "FireLocationListing";
//    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
//    if (!collSiteMap.ViewCCNavLinksByKeyword(parms)) {
//        dsFireLocationListing = buildDataSource();
//    } else {
//        alert("Error: Unable to build Fire Location Listing.");
//    }
//    parms = gSafeGuid + "|" + "FireOutputReports";
//    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
//    if (!collSiteMap.ViewCCNavLinksByKeyword(parms)) {
//        dsFireOutputReports = buildDataSource();
//    } else {
//        alert("Error: Unable to build Fire Output Reports.");
//    }
//    parms = gSafeGuid + "|" + "FireDataExtracts";
//    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
//    if (!collSiteMap.ViewCCNavLinksByKeyword(parms)) {
//        dsFireDataExtracts = buildDataSource();
//    } else {
//        alert("Error: Unable to build Fire Data Extracts.");
//    }

//    //// BOILER
//    parms = gSafeGuid + "|" + "BMLocationListing";
//    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
//    if (!collSiteMap.ViewCCNavLinksByKeyword(parms)) {
//        dsBMLocationListing = buildDataSource();
//    } else {
//        alert("Error: Unable to build Boiler Location Listing.");
//    }
//    parms = gSafeGuid + "|" + "BMOutputReports";
//    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
//    if (!collSiteMap.ViewCCNavLinksByKeyword(parms)) {
//        dsBMOutputReports = buildDataSource();
//    } else {
//        alert("Error: Unable to build Boiler Output Reports.");
//    }
//    parms = gSafeGuid + "|" + "BMDataExtracts";
//    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
//    if (!collSiteMap.ViewCCNavLinksByKeyword(parms)) {
//        dsBMDataExtracts = buildDataSource();
//    } else {
//        alert("Error: Unable to build Boiler Data Extracts.");
//    }

//    //// INFRARED
//    parms = gSafeGuid + "|" + "IRLocationListing";
//    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
//    if (!collSiteMap.ViewCCNavLinksByKeyword(parms)) {
//        dsIRLocationListing = buildDataSource();
//    } else {
//        alert("Error: Unable to build Infrared Location Listing.");
//    }
//    parms = gSafeGuid + "|" + "IROutputReports";
//    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
//    if (!collSiteMap.ViewCCNavLinksByKeyword(parms)) {
//        dsIROutputReports = buildDataSource();
//    } else {
//        alert("Error: Unable to build Infrared Output Reports.");
//    }
//    parms = gSafeGuid + "|" + "IRDataExtracts";
//    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
//    if (!collSiteMap.ViewCCNavLinksByKeyword(parms)) {
//        dsIRDataExtracts = buildDataSource();
//    } else {
//        alert("Error: Unable to build Infrared Data Extracts.");
//    }

//    //// JURIS
//    parms = gSafeGuid + "|" + "JurisLocationListing";
//    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
//    if (!collSiteMap.ViewCCNavLinksByKeyword(parms)) {
//        dsJurisLocationListing = buildDataSource();
//    } else {
//        alert("Error: Unable to build Jurisdictional Location Listing.");
//    }
//    parms = gSafeGuid + "|" + "JurisOutputReports";
//    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
//    if (!collSiteMap.ViewCCNavLinksByKeyword(parms)) {
//        dsJurisOutputReports = buildDataSource();
//    } else {
//        alert("Error: Unable to build Jurisdictional Output Reports.");
//    }
//    parms = gSafeGuid + "|" + "JurisDataExtracts";
//    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
//    if (!collSiteMap.ViewCCNavLinksByKeyword(parms)) {
//        dsJurisDataExtracts = buildDataSource();
//    } else {
//        alert("Error: Unable to build Jurisdictional Data Extracts.");
//    }

//    //// SEISMIC
//    parms = gSafeGuid + "|" + "NatHazSeismicLocationListing";
//    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
//    if (!collSiteMap.ViewCCNavLinksByKeyword(parms)) {
//        dsNatHazSeismicLocationListing = buildDataSource();
//    } else {
//        alert("Error: Unable to build Seismic Location Listing.");
//    }
//    parms = gSafeGuid + "|" + "NatHazSeismicOutputReports";
//    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
//    if (!collSiteMap.ViewCCNavLinksByKeyword(parms)) {
//        dsNatHazSeismicOutputReports = buildDataSource();
//    } else {
//        alert("Error: Unable to build Seismic Output Reports.");
//    }
//    parms = gSafeGuid + "|" + "NatHazSeismicDataExtracts";
//    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
//    if (!collSiteMap.ViewCCNavLinksByKeyword(parms)) {
//        dsNatHazSeismicDataExtracts = buildDataSource();
//    } else {
//        alert("Error: Unable to build Seismic Data Extracts.");
//    }

//    //// FLOOD
//    parms = gSafeGuid + "|" + "NatHazFloodLocationListing";
//    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
//    if (!collSiteMap.ViewCCNavLinksByKeyword(parms)) {
//        dsNatHazFloodLocationListing = buildDataSource();
//    } else {
//        alert("Error: Unable to build Flood Location Listing.");
//    }
//    parms = gSafeGuid + "|" + "NatHazFloodOutputReports";
//    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
//    if (!collSiteMap.ViewCCNavLinksByKeyword(parms)) {
//        dsNatHazFloodOutputReports = buildDataSource();
//    } else {
//        alert("Error: Unable to build Flood Output Reports.");
//    }
//    parms = gSafeGuid + "|" + "NatHazFloodDataExtracts";
//    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
//    if (!collSiteMap.ViewCCNavLinksByKeyword(parms)) {
//        dsNatHazFloodDataExtracts = buildDataSource();
//    } else {
//        alert("Error: Unable to build Flood Data Extracts.");
//    }

//    //// WIND
//    parms = gSafeGuid + "|" + "NatHazWindLocationListing";
//    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
//    if (!collSiteMap.ViewCCNavLinksByKeyword(parms)) {
//        dsNatHazWindLocationListing = buildDataSource();
//    } else {
//        alert("Error: Unable to build Wind Location Listing.");
//    }
//    parms = gSafeGuid + "|" + "NatHazWindOutputReports";
//    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
//    if (!collSiteMap.ViewCCNavLinksByKeyword(parms)) {
//        dsNatHazWindOutputReports = buildDataSource();
//    } else {
//        alert("Error: Unable to build Wind Output Reports.");
//    }
//    parms = gSafeGuid + "|" + "NatHazWindDataExtracts";
//    es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
//    if (!collSiteMap.ViewCCNavLinksByKeyword(parms)) {
//        dsNatHazWindDataExtracts = buildDataSource();
//    } else {
//        alert("Error: Unable to build Wind Data Extracts.");
//    }


//    /////////////////////////////////
//    //// SETUP KENDO UI WIDGETS
//    //// ROW 01
//    var cell0101TreeView = $("#cell0101TreeView").kendoTreeView({
//        dataSource: dsMainMenuNavigation, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html())
//    }).data("kendoTreeView");
//    var cell0102TreeView = $("#cell0102TreeView").kendoTreeView({
//        dataSource: dsFireLocationListing, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html())
//    }).data("kendoTreeView");
//    var cell0103TreeView = $("#cell0103TreeView").kendoTreeView({
//        dataSource: dsBMLocationListing, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html())
//    }).data("kendoTreeView");
//    var cell0104TreeView = $("#cell0104TreeView").kendoTreeView({
//        dataSource: dsIRLocationListing, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html())
//    }).data("kendoTreeView");
//    var cell0105TreeView = $("#cell0105TreeView").kendoTreeView({
//        dataSource: dsJurisLocationListing, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html())
//    }).data("kendoTreeView");
//    var cell0106TreeView = $("#cell0106TreeView").kendoTreeView({
//        dataSource: dsNatHazSeismicLocationListing, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html())
//    }).data("kendoTreeView");
//    var cell0107TreeView = $("#cell0107TreeView").kendoTreeView({
//        dataSource: dsNatHazFloodLocationListing, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html())
//    }).data("kendoTreeView");
//    var cell0108TreeView = $("#cell0108TreeView").kendoTreeView({
//        dataSource: dsNatHazWindLocationListing, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html())
//    }).data("kendoTreeView");

//    //// ROW 02
//    var cell0201TreeView = $("#cell0201TreeView").kendoTreeView({
//        dataSource: dsMainMenuQuickRef, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html())
//    }).data("kendoTreeView");
//    var cell0202TreeView = $("#cell0202TreeView").kendoTreeView({
//        dataSource: dsFireOutputReports, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html())
//    }).data("kendoTreeView");
//    var cell0203TreeView = $("#cell0203TreeView").kendoTreeView({
//        dataSource: dsBMOutputReports, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html())
//    }).data("kendoTreeView");
//    var cell0204TreeView = $("#cell0204TreeView").kendoTreeView({
//        dataSource: dsIROutputReports, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html())
//    }).data("kendoTreeView");
//    var cell0205TreeView = $("#cell0205TreeView").kendoTreeView({
//        dataSource: dsJurisOutputReports, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html())
//    }).data("kendoTreeView");
//    var cell0206TreeView = $("#cell0206TreeView").kendoTreeView({
//        dataSource: dsNatHazSeismicOutputReports, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html())
//    }).data("kendoTreeView");
//    var cell0207TreeView = $("#cell0207TreeView").kendoTreeView({
//        dataSource: dsNatHazFloodOutputReports, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html())
//    }).data("kendoTreeView");
//    var cell0208TreeView = $("#cell0208TreeView").kendoTreeView({
//        dataSource: dsNatHazWindOutputReports, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html())
//    }).data("kendoTreeView");

//    //// ROW 03
//    var cell0301TreeView = $("#cell0301TreeView").kendoTreeView({
//        dataSource: dsMainMenuLibrary, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html())
//    }).data("kendoTreeView");
//    var cell0302TreeView = $("#cell0302TreeView").kendoTreeView({
//        dataSource: dsFireDataExtracts, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html())
//    }).data("kendoTreeView");
//    var cell0303TreeView = $("#cell0303TreeView").kendoTreeView({
//        dataSource: dsBMDataExtracts, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html())
//    }).data("kendoTreeView");
//    var cell0304TreeView = $("#cell0304TreeView").kendoTreeView({
//        dataSource: dsIRDataExtracts, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html())
//    }).data("kendoTreeView");
//    var cell0305TreeView = $("#cell0305TreeView").kendoTreeView({
//        dataSource: dsJurisDataExtracts, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html())
//    }).data("kendoTreeView");
//    var cell0306TreeView = $("#cell0306TreeView").kendoTreeView({
//        dataSource: dsNatHazSeismicDataExtracts, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html())
//    }).data("kendoTreeView");
//    var cell0307TreeView = $("#cell0307TreeView").kendoTreeView({
//        dataSource: dsNatHazFloodDataExtracts, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html())
//    }).data("kendoTreeView");
//    var cell0308TreeView = $("#cell0308TreeView").kendoTreeView({
//        dataSource: dsNatHazWindDataExtracts, dragAndDrop: false, expand: false, collapse: false, template: kendo.template($("#templateUrl").html())
//    }).data("kendoTreeView");


//    /////////////////////////////////
//    //// RESET STYLES FOR LINK UNDERLINE
//    //// ROW 1
//    $("#cell0101TreeView a").each(function () {
//        $(this).css("text-decoration", "underline");
//    });
//    $("#cell0102TreeView a").each(function () {
//        $(this).css("text-decoration", "underline");
//    });
//    $("#cell0103TreeView a").each(function () {
//        $(this).css("text-decoration", "underline");
//    });
//    $("#cell0104TreeView a").each(function () {
//        $(this).css("text-decoration", "underline");
//    });
//    $("#cell0105TreeView a").each(function () {
//        $(this).css("text-decoration", "underline");
//    });
//    $("#cell0106TreeView a").each(function () {
//        $(this).css("text-decoration", "underline");
//    });
//    $("#cell0107TreeView a").each(function () {
//        $(this).css("text-decoration", "underline");
//    });
//    $("#cell0108TreeView a").each(function () {
//        $(this).css("text-decoration", "underline");
//    });
//    //// ROW 2
//    $("#cell0201TreeView a").each(function () {
//        $(this).css("text-decoration", "underline");
//    });
//    $("#cell0202TreeView a").each(function () {
//        $(this).css("text-decoration", "underline");
//    });
//    $("#cell0203TreeView a").each(function () {
//        $(this).css("text-decoration", "underline");
//    });
//    $("#cell0204TreeView a").each(function () {
//        $(this).css("text-decoration", "underline");
//    });
//    $("#cell0205TreeView a").each(function () {
//        $(this).css("text-decoration", "underline");
//    });
//    $("#cell0206TreeView a").each(function () {
//        $(this).css("text-decoration", "underline");
//    });
//    $("#cell0207TreeView a").each(function () {
//        $(this).css("text-decoration", "underline");
//    });
//    $("#cell0208TreeView a").each(function () {
//        $(this).css("text-decoration", "underline");
//    });
//    //// ROW 3
//    $("#cell0301TreeView a").each(function () {
//        $(this).css("text-decoration", "underline");
//    });
//    $("#cell0302TreeView a").each(function () {
//        $(this).css("text-decoration", "underline");
//    });
//    $("#cell0303TreeView a").each(function () {
//        $(this).css("text-decoration", "underline");
//    });
//    $("#cell0304TreeView a").each(function () {
//        $(this).css("text-decoration", "underline");
//    });
//    $("#cell0305TreeView a").each(function () {
//        $(this).css("text-decoration", "underline");
//    });
//    $("#cell0306TreeView a").each(function () {
//        $(this).css("text-decoration", "underline");
//    });
//    $("#cell0307TreeView a").each(function () {
//        $(this).css("text-decoration", "underline");
//    });
//    $("#cell0308TreeView a").each(function () {
//        $(this).css("text-decoration", "underline");
//    });
//    $("#cell0309TreeView a").each(function () {
//        $(this).css("text-decoration", "underline");
//    });


//    /////////////////////////////////
//    //// ZOOM IN, ZOOM OUT, AND EVENTS    
//    //// BIND MOUSE OVER EVENTS TO SITEMAP CELLS

//    //// ROW 1
//    var cell0101Config = {
//        interval: 300,
//        over: function (event) { zoomIn("#cell0101", 1, "left", "top", "0px", "325px"); cell0101TreeView.expand(".k-item"); },
//        out: function (event) { zoomOut("#cell0101", "200px"); cell0101TreeView.collapse(".k-item"); }
//    };
//    $("#cell0101").hoverIntent(cell0101Config);

//    var cell0102Config = {
//        interval: 300,
//        over: function (event) { zoomIn("#cell0102", 1, "middle", "top", "0px", "325px"); cell0102TreeView.expand(".k-item"); },
//        out: function (event) { zoomOut("#cell0102", "200px"); cell0102TreeView.collapse(".k-item"); }
//    };
//    $("#cell0102").hoverIntent(cell0102Config);

//    var cell0103Config = {
//        interval: 300,
//        over: function (event) { zoomIn("#cell0103", 1, "middle", "top", "0px", "325px"); cell0103TreeView.expand(".k-item"); },
//        out: function (event) { zoomOut("#cell0103", "200px"); cell0103TreeView.collapse(".k-item"); }
//    };
//    $("#cell0103").hoverIntent(cell0103Config);

//    var cell0104Config = {
//        interval: 300,
//        over: function (event) { zoomIn("#cell0104", 1, "middle", "top", "0px", "325px"); cell0104TreeView.expand(".k-item"); },
//        out: function (event) { zoomOut("#cell0104", "200px"); cell0104TreeView.collapse(".k-item"); }
//    };
//    $("#cell0104").hoverIntent(cell0104Config);

//    var cell0105Config = {
//        interval: 300,
//        over: function (event) { zoomIn("#cell0105", 1, "middle", "top", "0px", "325px"); cell0105TreeView.expand(".k-item"); },
//        out: function (event) { zoomOut("#cell0105", "200px"); cell0105TreeView.collapse(".k-item"); }
//    };
//    $("#cell0105").hoverIntent(cell0105Config);

//    var cell0106Config = {
//        interval: 300,
//        over: function (event) { zoomIn("#cell0106", 1, "middle", "top", "0px", "325px"); cell0106TreeView.expand(".k-item"); },
//        out: function (event) { zoomOut("#cell0106", "200px"); cell0106TreeView.collapse(".k-item"); }
//    };
//    $("#cell0106").hoverIntent(cell0106Config);

//    var cell0107Config = {
//        interval: 300,
//        over: function (event) { zoomIn("#cell0107", 1, "middle", "top", "0px", "325px"); cell0107TreeView.expand(".k-item"); },
//        out: function (event) { zoomOut("#cell0107", "200px"); cell0107TreeView.collapse(".k-item"); }
//    };
//    $("#cell0107").hoverIntent(cell0107Config);

//    var cell0108Config = {
//        interval: 300,
//        over: function (event) { zoomIn("#cell0108", 1, "right", "top", "0px", "325px"); cell0108TreeView.expand(".k-item"); },
//        out: function (event) { zoomOut("#cell0108", "200px"); cell0108TreeView.collapse(".k-item"); }
//    };
//    $("#cell0108").hoverIntent(cell0108Config);

//    //// ROW 2
//    var cell0201Config = {
//        interval: 300,
//        over: function (event) { zoomIn("#cell0201", 2, "left", "middle", "-220px", "570px"); cell0201TreeView.expand(".k-item"); },
//        out: function (event) { zoomOut("#cell0201", "130px"); cell0201TreeView.collapse(".k-item"); }
//    };
//    $("#cell0201").hoverIntent(cell0201Config);

//    var cell0202Config = {
//        interval: 300,
//        over: function (event) { zoomIn("#cell0202", 2, "middle", "middle", "-220px", "570px"); cell0202TreeView.expand(".k-item"); },
//        out: function (event) { zoomOut("#cell0202", "130px"); cell0202TreeView.collapse(".k-item"); }
//    };
//    $("#cell0202").hoverIntent(cell0202Config);

//    var cell0203Config = {
//        interval: 300,
//        over: function (event) { zoomIn("#cell0203", 2, "middle", "middle", "-220px", "570px"); cell0203TreeView.expand(".k-item"); },
//        out: function (event) { zoomOut("#cell0203", "130px"); cell0203TreeView.collapse(".k-item"); }
//    };
//    $("#cell0203").hoverIntent(cell0203Config);

//    var cell0204Config = {
//        interval: 300,
//        over: function (event) { zoomIn("#cell0204", 2, "middle", "middle", "-220px", "570px"); cell0204TreeView.expand(".k-item"); },
//        out: function (event) { zoomOut("#cell0204", "130px"); cell0204TreeView.collapse(".k-item"); }
//    };
//    $("#cell0204").hoverIntent(cell0204Config);

//    var cell0205Config = {
//        interval: 300,
//        over: function (event) { zoomIn("#cell0205", 2, "middle", "middle", "-220px", "570px"); cell0205TreeView.expand(".k-item"); },
//        out: function (event) { zoomOut("#cell0205", "130px"); cell0205TreeView.collapse(".k-item"); }
//    };
//    $("#cell0205").hoverIntent(cell0205Config);

//    var cell0206Config = {
//        interval: 300,
//        over: function (event) { zoomIn("#cell0206", 2, "middle", "middle", "-220px", "520px"); cell0206TreeView.expand(".k-item"); },
//        out: function (event) { zoomOut("#cell0206", "130px"); cell0206TreeView.collapse(".k-item"); }
//    };
//    $("#cell0206").hoverIntent(cell0206Config);

//    var cell0207Config = {
//        interval: 300,
//        over: function (event) { zoomIn("#cell0207", 2, "middle", "middle", "-220px", "570px"); cell0207TreeView.expand(".k-item"); },
//        out: function (event) { zoomOut("#cell0207", "130px"); cell0207TreeView.collapse(".k-item"); }
//    };
//    $("#cell0207").hoverIntent(cell0207Config);

//    var cell0208Config = {
//        interval: 300,
//        over: function (event) { zoomIn("#cell0208", 2, "right", "middle", "-220px", "570px"); cell0208TreeView.expand(".k-item"); },
//        out: function (event) { zoomOut("#cell0208", "130px"); cell0208TreeView.collapse(".k-item"); }
//    };
//    $("#cell0208").hoverIntent(cell0208Config);

//    //// ROW 3
//    var cell0301Config = {
//        interval: 300,
//        over: function (event) { zoomIn("#cell0301", 3, "left", "bottom", "0px", "425px"); cell0301TreeView.expand(".k-item"); },
//        out: function (event) { zoomOut("#cell0301", "160px"); cell0301TreeView.collapse(".k-item"); }
//    };
//    $("#cell0301").hoverIntent(cell0301Config);

//    var cell0302Config = {
//        interval: 300,
//        over: function (event) { zoomIn("#cell0302", 3, "middle", "bottom", "0px", "425px"); cell0302TreeView.expand(".k-item"); },
//        out: function (event) { zoomOut("#cell0302", "160px"); cell0302TreeView.collapse(".k-item"); }
//    };
//    $("#cell0302").hoverIntent(cell0302Config);

//    var cell0303Config = {
//        interval: 300,
//        over: function (event) { zoomIn("#cell0303", 3, "middle", "bottom", "0px", "425px"); cell0303TreeView.expand(".k-item"); },
//        out: function (event) { zoomOut("#cell0303", "160px"); cell0303TreeView.collapse(".k-item"); }
//    };
//    $("#cell0303").hoverIntent(cell0303Config);

//    var cell0304Config = {
//        interval: 300,
//        over: function (event) { zoomIn("#cell0304", 3, "middle", "bottom", "0px", "425px"); cell0304TreeView.expand(".k-item"); },
//        out: function (event) { zoomOut("#cell0304", "160px"); cell0304TreeView.collapse(".k-item"); }
//    };
//    $("#cell0304").hoverIntent(cell0304Config);

//    var cell0305Config = {
//        interval: 300,
//        over: function (event) { zoomIn("#cell0305", 3, "middle", "bottom", "0px", "425px"); cell0305TreeView.expand(".k-item"); },
//        out: function (event) { zoomOut("#cell0305", "160px"); cell0305TreeView.collapse(".k-item"); }
//    };
//    $("#cell0305").hoverIntent(cell0305Config);

//    var cell0306Config = {
//        interval: 300,
//        over: function (event) { zoomIn("#cell0306", 3, "middle", "bottom", "0px", "425px"); cell0306TreeView.expand(".k-item"); },
//        out: function (event) { zoomOut("#cell0306", "160px"); cell0306TreeView.collapse(".k-item"); }
//    };
//    $("#cell0306").hoverIntent(cell0306Config);

//    var cell0307Config = {
//        interval: 300,
//        over: function (event) { zoomIn("#cell0307", 3, "middle", "bottom", "0px", "425px"); cell0307TreeView.expand(".k-item"); },
//        out: function (event) { zoomOut("#cell0307", "160px"); cell0307TreeView.collapse(".k-item"); }
//    };
//    $("#cell0307").hoverIntent(cell0307Config);

//    var cell0308Config = {
//        interval: 300,
//        over: function (event) { zoomIn("#cell0308", 3, "right", "bottom", "0px", "425px"); cell0308TreeView.expand(".k-item"); },
//        out: function (event) { zoomOut("#cell0308", "160px"); cell0308TreeView.collapse(".k-item"); }
//    };
//    $("#cell0308").hoverIntent(cell0308Config);


//    /////////////////////////////////
//    //// ZOOM IN AND ZOOM OUT, FUNCTIONS    
//    var animationFlag = true;
//    function zoomIn(cell, currentRow, hAlign, vAlign, marginTop, newContentHeight) {
//        if (animationFlag) {
//            animationFlag = false;
//            var mLeft = "0px";
//            var mTop = marginTop;
//            if (hAlign == "right") { mLeft = "-90px"; }
//            else if (hAlign == "left") { mLeft = "5px"; }
//            else { mLeft = "-40px"; }
//            if (vAlign == "top") { mTop = "-10px"; }
//            else if (vAlign == "bottom") { mTop = "-270px"; }
//            else if (vAlign == "middle" && mTop == "0px") { mTop = "-25px"; }

//            setZIn(cell, currentRow);
//            $(cell).addClass("sitemapShadows");
//            $(cell).animate({
//                marginLeft: mLeft,
//                marginTop: mTop
//            }, "fast");
//            $(cell + "SubHeading").stop().animate({
//                width: "280px",
//                height: "15px",
//                padding: "5px",
//                fontSize: "12pt"
//                //lineHeight: "15px"    //// THIS PROPERTY THROWS ERROR IN IE8
//            }, "fast");
//            $(cell + "Content").stop().animate({
//                width: "280px",
//                height: newContentHeight,
//                padding: "5px",
//                fontSize: "8pt"
//            }, "fast");
//            $(cell + "TreeView .k-in").stop().animate({
//                lineHeight: "12px"
//                //Height: "12px"
//            }, "fast");
//            $(cell + "TreeView").stop().animate({
//                width: "275px",
//                height: (parseInt(newContentHeight) - 30).toString() + "px",
//                //height: newContentHeight,
//                fontSize: "8pt"
//            }, "fast");
//            $(cell + "Instructions").show();
//            $(cell + "Instructions").stop().animate({
//                width: "275px",
//                height: "30px",
//                fontSize: "7.5pt"
//            }, "fast");
//        }
//    }

//    function zoomOut(cell, originalContentHeight) {
//        if (!animationFlag) {
//            $(cell).removeClass("sitemapShadows");
//            $(cell + "SubHeading").stop().animate({
//                width: "200px",
//                height: "12px",
//                padding: "3px",
//                fontSize: "7pt"
//                //lineHeight: "normal"    //// THIS PROPERTY THROWS ERROR IN IE8
//            }, "fast");
//            $(cell + "Content").stop().animate({
//                width: "200px",
//                height: originalContentHeight,
//                padding: "3px",
//                fontSize: "7pt"
//            }, "fast");
//            $(cell + "TreeView .k-in").stop().animate({
//                lineHeight: "8px"
//                //Height: "10px"
//            }, "fast");
//            $(cell + "TreeView").stop().animate({
//                width: "176px",
//                height: originalContentHeight - 50,
//                fontSize: "7pt"
//            }, "fast");
//            $(cell + "Instructions").stop().animate({
//                width: "176px",
//                //height: "30px",
//                fontSize: "7.5pt"
//            }, "fast");
//            $(cell + "Instructions").hide();
//            $(cell).animate({
//                marginLeft: "0px",
//                marginTop: "0px"
//            }, "fast", function () {
//                setZOut();
//            });
//            animationFlag = true;
//        }
//    }

//    //// SET THE Z-ORDER OF PASSED OBJECT
//    function setZIn(cell, currentRow) {
//        //// SET ALL CELLS TO ZERO
//        $("#row01").css("z-index", "101");
//        $("#row02").css("z-index", "102");
//        $("#row03").css("z-index", "103");
//        $("#cell0101").css("z-index", "200");
//        $("#cell0102").css("z-index", "200");
//        $("#cell0103").css("z-index", "200");
//        $("#cell0104").css("z-index", "200");
//        $("#cell0105").css("z-index", "200");
//        $("#cell0106").css("z-index", "200");
//        $("#cell0107").css("z-index", "200");
//        $("#cell0108").css("z-index", "200");
//        $("#cell0201").css("z-index", "200");
//        $("#cell0202").css("z-index", "200");
//        $("#cell0203").css("z-index", "200");
//        $("#cell0204").css("z-index", "200");
//        $("#cell0205").css("z-index", "200");
//        $("#cell0206").css("z-index", "200");
//        $("#cell0207").css("z-index", "200");
//        $("#cell0208").css("z-index", "200");
//        $("#cell0301").css("z-index", "200");
//        $("#cell0302").css("z-index", "200");
//        $("#cell0303").css("z-index", "200");
//        $("#cell0304").css("z-index", "200");
//        $("#cell0305").css("z-index", "200");
//        $("#cell0306").css("z-index", "200");
//        $("#cell0307").css("z-index", "200");
//        $("#cell0308").css("z-index", "200");
//        //// SET PASSED CELL AND ROW TO TOP
//        if (currentRow == 1) { $("#row01").css("z-index", "150"); }
//        else if (currentRow == 2) { $("#row02").css("z-index", "150"); }
//        else { $("#row03").css("z-index", "150"); }
//        $(cell).css("z-index", "999");
//    }
//    function setZOut() {
//        $("#row01").css("z-index", "101");
//        $("#row02").css("z-index", "102");
//        $("#row03").css("z-index", "103");
//        $("#cell0101").css("z-index", "200");
//        $("#cell0102").css("z-index", "200");
//        $("#cell0103").css("z-index", "200");
//        $("#cell0104").css("z-index", "200");
//        $("#cell0105").css("z-index", "200");
//        $("#cell0106").css("z-index", "200");
//        $("#cell0107").css("z-index", "200");
//        $("#cell0108").css("z-index", "200");
//        $("#cell0201").css("z-index", "200");
//        $("#cell0202").css("z-index", "200");
//        $("#cell0203").css("z-index", "200");
//        $("#cell0204").css("z-index", "200");
//        $("#cell0205").css("z-index", "200");
//        $("#cell0206").css("z-index", "200");
//        $("#cell0207").css("z-index", "200");
//        $("#cell0208").css("z-index", "200");
//        $("#cell0301").css("z-index", "200");
//        $("#cell0302").css("z-index", "200");
//        $("#cell0303").css("z-index", "200");
//        $("#cell0304").css("z-index", "200");
//        $("#cell0305").css("z-index", "200");
//        $("#cell0306").css("z-index", "200");
//        $("#cell0307").css("z-index", "200");
//        $("#cell0308").css("z-index", "200");
//    }


//    /////////////////////////////////
//    //// FUNCTIONS TO BUILD DATASOURCES
//    function buildDataSource() {
//        var parentId = getParentId();
//        var returnCollection = [];
//        var targetPracticeReport = "/Reports/PracticeReport.aspx";
//        var targetSingleReport = "/Reports/SingleReport.aspx";
//        var targetCharts = "/Charts/";

//        for (y = 0; y < collSiteMap().length; y++) {
//            if (collSiteMap()[y].NavParentLinkId() != undefined && collSiteMap()[y].NavParentLinkId() == parentId) {
//                //// GET CHILD NODES
//                var subMenu = buildSubMenu(collSiteMap()[y].NavLinkId());

//                //// GET THE TARGET OF THE NODE
//                var tempStr = collSiteMap()[y].NavUrl();
//                var tempTarget = "";
//                if (tempStr != undefined) {
//                    if (tempStr.search(targetPracticeReport) > -1) { tempTarget = "PracticeReport" }
//                    else if (tempStr.search(targetCharts) > -1) { tempTarget = "Charts" }
//                    else if (tempStr.search(targetSingleReport) > -1) { tempTarget = "SingleReport" }
//                    else { tempTarget = collSiteMap()[y].NavTarget() + "" }
//                }

//                //// BUILD THE NODE
//                if (returnCollection.length == 0) {
//                    returnCollection = [{
//                        key: collSiteMap()[y].NavLinkId(),
//                        text: collSiteMap()[y].NavText(),
//                        url: getNavUrl(collSiteMap()[y].NavUrl(), collSiteMap()[y].NavEnabled()),
//                        navEnabled: collSiteMap()[y].NavEnabled(),
//                        //type: collSiteMap()[y].NavType().toLowerCase(),
//                        items: subMenu,
//                        target: tempTarget,
//                        comment: "" //collSiteMap()[y].NavComment()
//                    }];
//                } else {
//                    returnCollection.push({
//                        key: collSiteMap()[y].NavLinkId(),
//                        text: collSiteMap()[y].NavText(),
//                        url: getNavUrl(collSiteMap()[y].NavUrl(), collSiteMap()[y].NavEnabled()),
//                        navEnabled: collSiteMap()[y].NavEnabled(),
//                        //type: collSiteMap()[y].NavType().toLowerCase(),
//                        items: subMenu,
//                        target: tempTarget,
//                        comment: "" //collSiteMap()[y].NavComment()
//                    });
//                }
//            }
//        }
//        //// SORT NO LONGER NEEDED BECAUSE THIS SHOULD BE DONE IN WCF WITH SORT COLUMN
//        //        returnCollection.sort(function (a, b) {
//        //            return (a.key - b.key);
//        //        });
//        return returnCollection;
//    }

//    function buildSubMenu(NavLinkId) {
//        var returnSubMenu = [];
//        var targetPracticeReport = "/Reports/PracticeReport.aspx";
//        var targetSingleReport = "/Reports/SingleReport.aspx";
//        var targetCharts = "/Charts/";

//        for (x = 0; x < collSiteMap().length; x++) {
//            if (NavLinkId == collSiteMap()[x].NavParentLinkId()) {
//                //// GET THE TARGET OF THE NODE
//                var tempChildStr = collSiteMap()[x].NavUrl();
//                var tempChildTarget = "";
//                if (tempChildStr != undefined) {
//                    if (tempChildStr.search(targetPracticeReport) > -1) { tempChildTarget = "PracticeReport" }
//                    else if (tempChildStr.search(targetCharts) > -1) { tempChildTarget = "Charts" }
//                    else if (tempChildStr.search(targetSingleReport) > -1) { tempChildTarget = "SingleReport" }
//                    else { tempChildTarget = collSiteMap()[x].NavTarget() + "" }
//                }

//                if (returnSubMenu.length == 0) {
//                    returnSubMenu = [{
//                        key: collSiteMap()[x].NavLinkId(),
//                        text: collSiteMap()[x].NavText(),
//                        url: getNavUrl(collSiteMap()[x].NavUrl(), collSiteMap()[y].NavEnabled()),
//                        navEnabled: collSiteMap()[x].NavEnabled(),
//                        //type: collSiteMap()[x].NavType().toLowerCase(),
//                        target: tempChildTarget,
//                        comment: "" //collSiteMap()[x].NavComment
//                    }];
//                } else {
//                    returnSubMenu.push({
//                        key: collSiteMap()[x].NavLinkId(),
//                        text: collSiteMap()[x].NavText(),
//                        url: getNavUrl(collSiteMap()[x].NavUrl(), collSiteMap()[y].NavEnabled()),
//                        navEnabled: collSiteMap()[x].NavEnabled(),
//                        //type: collSiteMap()[x].NavType().toLowerCase(),
//                        target: tempChildTarget,
//                        comment: "" //collSiteMap()[x].NavComment
//                    });
//                }
//            }
//        }
//        return returnSubMenu;
//    }

//    function getParentId() {
//        for (x = 0; x < collSiteMap().length; x++) {
//            if (collSiteMap()[x].NavParentLinkId() == undefined) {
//                return collSiteMap()[x].NavLinkId();
//            }
//        }
//    }

//    function getNavUrl(navUrl) {
//        if (navUrl != "" && navUrl != undefined) {
//            if (isEnabled != undefined && isEnabled != null && isEnabled != 0 && isEnabled != false) {
//                if (navUrl.indexOf("?") > 0) {
//                    return navUrl + "&sid=" + gSafeGuid;
//                } else {
//                    return navUrl + "?sid=" + gSafeGuid;
//                }
//            } else {
//                return "";
//            }
//        } else {
//            return "";
//        }
//    }


//    //// EXTEND JQUERY TO FIND HIGHEST Z-ORDER
//    //// THIS IS NO LONGER USED, Z-INDEX IS SET DIRECTLY IN ABOVE FUNCTIONS INSTEAD
//    //    $.maxZIndex = $.fn.maxZIndex = function (opt) {
//    //        var def = { inc: 10, group: "*" };
//    //        $.extend(def, opt);
//    //        var zmax = 0;
//    //        $(def.group).each(function () {
//    //            var cur = parseInt($(this).css('z-index'));
//    //            zmax = cur > zmax ? cur : zmax;
//    //        });
//    //        if (!this.jquery)
//    //            return zmax;

//    //        return this.each(function () {
//    //            zmax += def.inc;
//    //            $(this).css("z-index", zmax);
//    //        });
//    //    }

//});