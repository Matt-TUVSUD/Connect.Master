<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CheckWCFJSON.aspx.vb" Inherits="GRC.Connect.Web.CheckWCFJSON" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" style="height: 100%; width: 100%">
<head runat="server">
    <title>Test WCF JSON Results</title>
    <link rel="Stylesheet" type="text/css" href="../css/Kendo.v2014.1.318/kendo.common.min.css" />
    <link rel="Stylesheet" type="text/css" href="../css/kendo-lightblue-noedit.css" />
    <link rel="Stylesheet" type="text/css" href="../css/kendo-lightblue-grid.css" />
    <link rel="Stylesheet" type="text/css" href="../css/kendo-lightblue-menu.css" />
    <link rel="Stylesheet" type="text/css" href="../css/pages/global.css" />
    <link rel="Stylesheet" type="text/css" href="../css/pages/gauge.css" />
    <link rel="Stylesheet" type="text/css" href="../css/pages/topbanner.css" />
    <link rel="Stylesheet" type="text/css" href="../css/pages/windows.css" />
    <link rel="Stylesheet" type="text/css" href="../css/pages/icons.css" />
    <link rel="Stylesheet" type="text/css" href="../css/Telerik/RadTreeView.css" />
    <link rel="Stylesheet" type="text/css" href="../css/Telerik/RadTreeViewOffice2010Silver.css" />
    <link rel="Stylesheet" type="text/css" href="../css/Telerik/RadFileExplorer.css" />
    <link rel="Stylesheet" type="text/css" href="../css/Telerik/RadFileExplorerOffice2010Silver.css" />
    <link rel="Stylesheet" type="text/css" href="../css/Telerik/RadWindow.css" />
    <link rel="Stylesheet" type="text/css" href="../css/Telerik/RadWindowOffice2010Blue.css" />

    <style>
        textarea {
            /*direction:rtl;*/
            display:block;
            width:100%;
            max-width:100%;
            height:100%;
            max-height: 100%;
        }
    </style>

    <script src="../Lib_{{VER}}/JQuery.v1.11.3/jquery-1.11.3.min.js" type="text/javascript"></script>
    <script src="../Lib_{{VER}}/Knockout.v3.3.0/knockout-3.3.0.js" type="text/javascript"></script>
    <script src="../Lib_{{VER}}/KendoUI.v2014.1.416/kendo.web.min.js" type="text/javascript"></script>
    <%--<script src="../Lib_{{VER}}/KendoUI.v2014.1.416/kendo.all.min.js" type="text/javascript"></script>--%>
    <script src="../../Lib_{{VER}}/kendo.all.min.js" type="text/javascript"></script>
    <script src="../Lib_{{VER}}/knockoutkendo.v0.9.3/knockout-kendo.min.js" type="text/javascript"></script>
    <script src="../Lib_{{VER}}/JQuery/jquery.hoverintent.min.js" type="text/javascript"></script>
    <script src="../Lib_{{VER}}/json/json2.js" type="text/javascript"></script>
    <script src="../Lib_{{VER}}/ES/entityspaces.XHR.js" type="text/javascript"></script>
    <script src="../Lib_{{VER}}/Generated/GSafeDetail.js" type="text/javascript"></script>
    <script src="../Lib_{{VER}}/Custom/GSafeDetail.js" type="text/javascript"></script>
    <script src="../Lib_{{VER}}/Generated/GSafeHeader.js" type="text/javascript"></script>
    <script src="../Lib_{{VER}}/Custom/GSafeHeader.js" type="text/javascript"></script>
    <script src="../Lib_{{VER}}/Generated/NavLink.js" type="text/javascript"></script>
    <script src="../Lib_{{VER}}/Config/baseurl.js" type="text/javascript"></script>
    <script src="../Lib_{{VER}}/Session/sessvars.js" type="text/javascript"></script>
    <script src="../Lib_{{VER}}/pages/util_{{VER}}.js" type="text/javascript"></script>
    <script src="../Lib_{{VER}}/pages/gauge.js" type="text/javascript"></script>
    <script src="../Lib_{{VER}}/pages/topbanner.js" type="text/javascript"></script>
    <script src="../Lib_{{VER}}/pages/nav.js" type="text/javascript"></script>
    <script src="../Lib_{{VER}}/pages/export.js" type="text/javascript"></script>
</head>

<body style="height: 100%; width: 100%">
    <form id="form1" runat="server">
    <div id="view">
        <!-- LOADING -->
        <div id="divContainerLoading" class="containerLoading"></div>

        <!-- HEADER -->
        <div></div>

        <!-- CONTENT -->
        <div style="text-align: center;">
            <br /><br />
            JetProc Name: <input type="text" data-bind="value: txtJetProcName" /> &nbsp;&nbsp; Parameter Value: <input type="text" data-bind="value: txtParameterValue" />
            <br /><br />
            <button data-bind="click: onLoadJSON">Call JetProc</button>
            <br /><br /><br />
            <div style="min-height: 400px; min-width: 300px; padding: 25px;">
                <textarea id="txtResults" rows="30" cols="100" data-bind="value: txtResults"></textarea>
            </div>
            <br /><br /><br /><br />
        </div>

        <!-- FOOTER -->
        <div></div>
    </div>
    </form>
</body>
</html>


<script>
    $(document).ready(function () {
        view = {
            // DECLARATIONS
            firstLoad: true,
            countLoading: 0,
            txtJetProcName: ko.observable("PullGridMeta"),
            txtParameterValue: ko.observable("1"),
            txtResults: ko.observable(),
            timeStart: null,
            timeEnd: null,
            timeTotal: null,

            // PERMISSIONS

            // DATA
            
            // LABELS

            // BUTTON AND VISIBILITY CONTROLS

            // KENDO OBJECTS

            // FUNCTIONS
            onLoadJSON: function () {
                view.timeStart = performance.now();
                view.txtResults("Loading...");
                var zServiceName = "JetStream";
                var zJetProcName = view.txtJetProcName();
                var zParms = ko.toJSON({
                    pJetProc: zJetProcName,
                    pJetData: JSON.stringify(parseInt(view.txtParameterValue()))
                });
                view.callRestService(SITEBASEURL + RESTSERVERENDPOINT, zServiceName, zParms, view.loadJSONSuccess, view.loadJSONError, null);
            },
            loadJSONSuccess: function (pResults, pParms) {
                view.timeEnd = performance.now();
                view.timeTotal = view.timeEnd - view.timeStart;
                var zMSG = "Total time for request and pulling JSON: " + view.timeTotal + " milliseconds";
                zMSG = zMSG + "\nSize of JSON object: " + view.sizeOfObject(pResults) + " bytes";
                zMSG = zMSG + "\n\nJSON Results:\n\n" + JSON.stringify(pResults, null, 4);
                view.txtResults(zMSG);
            },
            loadJSONError: function (pResults, pMessage, pErrorDetail, pParms) {
                var zMSG = "Error message: " + pMessage;
                zMSG = zMSG + "\n\nError details: " + pErrorDetail;
                zMSG = zMSG + "\n\nResults:\n\n" + JSON.stringify(pResults, null, 4)
                view.txtResults(zMSG);
            },


            callRestService: function (pURL, pService, pData, pSuccess, pError, pParms) {
                try {
                    $.ajax({
                        type: "POST",
                        url: pURL + pService,
                        data: pData,
                        timeout: 120000,
                        cache: false,
                        processData: true,
                        dataType: "json",
                        contentType: "application/json; charset=utf-8",
                        success: function (pResults) {
                            if (pSuccess != undefined) {
                                pSuccess(pResults, pParms);
                            }
                        },
                        error: function (pResults, pMessage, pErrorDetail) {
                            if (pError != undefined) {
                                pError(pResults, pMessage, pErrorDetail, pParms);
                            } else {
                                alert("Error: " + pMessage);
                            }
                        }
                    });
                } catch (pErrorMessage) {
                    alert("Error: " + pErrorMessage);
                }
            },


            sizeOfObject: function(pObject) {
                var objectList = [];
                var stack = [pObject];
                var bytes = 0;
                while (stack.length) {
                    var value = stack.pop();

                    if (typeof value === 'boolean') {
                        bytes += 4;
                    }
                    else if (typeof value === 'string') {
                        bytes += value.length * 2;
                    }
                    else if (typeof value === 'number') {
                        bytes += 8;
                    }
                    else if
                    (
                        typeof value === 'object'
                        && objectList.indexOf(value) === -1
                    ) {
                        objectList.push(value);

                        for (var i in value) {
                            stack.push(value[i]);
                        }
                    }
                }
                return bytes;
            },


            init: function () {
                view.countLoading = 4;
                view.loadDictionary();
                view.loadData();
                view.setupKendo();
                view.setupEvents();
            },


            loadDictionary: function () {
                view.processLoading();
            },


            loadData: function () {
                view.processLoading();
            },


            setupKendo: function () {
                view.processLoading();
            },


            setupEvents: function () {
                view.processLoading();
            },


            bindForm: function () {
                ko.applyBindings(view, $("#view")[0]);
            },


            showLoading: function () {
                $("#divContainerLoading").fadeIn(100, function () { kendo.ui.progress($("#divContainerLoading"), true); });
            },


            hideLoading: function () {
                $("#divContainerLoading").fadeOut(100, function () { kendo.ui.progress($("#divContainerLoading"), false); });
            },


            processLoading: function () {
                view.countLoading--;
                if (view.countLoading < 1) {
                    view.hideLoading();
                } else {
                }
            }
        };


        // BIND AND INIT FORM
        view.bindForm();
        view.init();


        // GLOBAL FUNCTIONS NEEDED TO ACCESS VIEW
    });
</script>