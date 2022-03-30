<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="RecTestPage.aspx.vb" Inherits="GRC.Connect.Web.RecTestPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="Stylesheet" type="text/css" href="../../css/Kendo.v2014.1.318/kendo.common.min.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-noedit.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-grid.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-menu.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Kendo.v2014.1.318/kendo.grid.css" />
    <link rel="stylesheet" type="text/css" href="../../css/Header/header.css" />
    <link rel="stylesheet" type="text/css" href="../../css/Nav/nav.css" />
    <link rel="stylesheet" type="text/css" href="../../css/pages/mainPageBody.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Utilities/utilities.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/font-awesome.min.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Font-Awesome/all.css" />
    <link rel="stylesheet" type="text/css" href="../../css/pages/Recommendations.css" />

    <script src="../../Lib_{{VER}}/JQuery/jQuery.3.4.1.min.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/JQuery/jquery.cookie.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/JQuery/cache-controller_{{VER}}.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Knockout.v3.3.0/knockout-3.3.0.js" type="text/javascript"></script>
    <script src="https://kendo.cdn.telerik.com/2019.1.220/js/kendo.all.min.js"></script>
    <script src="../../Lib_{{VER}}/pages/global.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/json/json2.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/ES/entityspaces.XHR.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/GSafeDetail.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/GSafeDetail.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/GSafeHeader.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/GSafeHeader.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Config/baseurl.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Session/sessvars.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/pages/constants.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/pages/util_{{VER}}.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Picklist/Picklist_v2015.04.09.js"></script>
    <script src="../../Lib_{{VER}}/Recommendations/recommendations.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
        <header>
            <div id="viewHeader" class="headerInfo printNone">
                <div class="logo">
                    <a href="#" onclick="homeLinkClick()">
                        <img data-bind="attr: { src: logoURL }" alt="Global Risk Consultants" />
                    </a>
                </div>
                <div id="headerTxtHldr">
                    <div id="clientNameHldr">
                        &nbsp;
                    </div>
                    <div id="headerInfoHldr" class="printNone">
                        &nbsp;
                    </div>
                </div>
            </div>
        </header>
        <section class="pageBodyHldr">
        <div class="navHldr">
            &nbsp;
        </div>
            <div class="pageContentHldr">
                <div id="viewRecs" class="recContainer" style="" data-bind="with: viewRecs">
                    <div class="locationHeaderBar">
                        <label class="facilityLabel" data-bind="text: $parent.facility"></label>
                    </div>
                    <div class="locationCard" style="width:1000px;">
                        <div class="locationInfoHldr">
                            <div class="locationUpper" style="background: #eee;">
                                <div style="display: flex; width: 75%; flex-direction: column">
                                    <div class="cardRow">
                                        <label class="cardLbl"></label>
                                    </div>
                                    <div class="cardRow">
                                        <label class="cardLbl" data-bind="text: $parent.address"></label>
                                    </div>
                                    <div class="cardRow">
                                        <label class="cardLbl" data-bind="text: $parent.cityStateZipCombindedText"></label>
                                    </div>
                                    <div class="cardRow">
                                        <label class="cardLbl">United States</label>
                                    </div>
                                    <div class="cardRow">
                                        <label class="cardLbl">Longitude:</label>
                                        <label class="cardValue" data-bind="text: $parent.longitude"></label>
                                    </div>
                                    <div class="cardRow" style="margin-bottom: 0px;">
                                        <label class="cardLbl">Latitude:</label>
                                        <label class="cardValue" data-bind="text: $parent.latitude"></label>
                                    </div>
                                </div>
                                <div class="" style="width: 25%; display: flex; justify-content: flex-end; flex-direction: column; align-items: center;">
                                    <div class="recBtnRow">
                                        <a href="#" class="grcBlueBtn printNone" style="width:145px; font-size: 14px;">
                                            <i class="far fa-file" style="font-size: 20px; margin-right: 5px"></i>Current ER Report
                                        </a>
                                    </div>
                                    <div class="recBtnRow">
                                        <a href="#" class="grcBlueBtn printNone" style="width:145px; font-size: 14px;">
                                            <i class="far fa-file" style="font-size: 20px; margin-right: 5px;"></i>Current Diagram
                                        </a>
                                    </div>
                                    <div class="recBtnRow">
                                        <a href="#" class="grcBlueBtn printNone" style="width:145px; font-size: 14px;">
                                            <i class="far fa-file" style="font-size: 20px; margin-right: 5px;"></i>Print
                                        </a>
                                    </div>
                                </div>
                            </div>
                            <div class="locationLower" style="background: #fff;">
                                <div class="cardRow">
                                    <label class="cardLbl">File No.:</label>
                                    <label class="cardValue" data-bind="text: $parent.fileNo"></label>
                                </div>
                                <div class="cardRow">
                                    <label class="cardLbl">Client Loc Id:</label>
                                    <label class="cardValue" data-bind="text: $parent.clientLocNo"></label>
                                </div>
                                <div class="cardRow">
                                    <label class="cardLbl">Division:</label>
                                    <label class="cardValue" data-bind="text: $parent.division"></label>
                                </div>
                                <div class="cardRow">
                                    <label class="cardLbl">TIV (millions) USD:</label>
                                    <%--<label class="cardValue" data-bind="text: $parent."></label>--%>
                                </div>
                                <div class="cardRow">
                                    <label class="cardLbl">Custom Access:</label>
                                    <label class="cardValue" data-bind="text: $parent.customAccess"></label>
                                </div>
                                <div class="" style="width: 100%; display:flex; justify-content:flex-end">
                                    <span>
                                        <button type="button" class="grcBlueBtn pagerBtn" id="Button1" tabindex="15" style="margin-right: 2px;" data-bind="click: $parent.firstLocation"><i class="fas fa-step-backward"></i></button>
                                    </span>
                                    <span>
                                        <button type="button" class="grcBlueBtn pagerBtn" id="Button2" tabindex="16" data-bind="click: $parent.previousLocation"><i class="fas fa-caret-left"></i></button>
                                    </span>
                                    <span class="buttonFileRecordLabel" id="locationCountBox" data-bind="text: $parent.locationsCountBoxText" style="width: 130px; display: flex; justify-content: center;"></span>
                                        <%--<span  class="k-autocomplete k-input inputCenter inputNoEdit buttonInput" style="width: 80px; margin-bottom: 3px;" readonly="true" />&nbsp;</span>--%>
                                    <span>
                                        <button type="button" class="grcBlueBtn pagerBtn" id="Button3" data-bind="click: $parent.nextLocation" tabindex="17" style="margin-right: 2px;"><i class="fas fa-caret-right"></i></button>
                                    </span>
                                    <span>
                                        <button type="button" class="grcBlueBtn pagerBtn" id="Button4" tabindex="18" data-bind="click: $parent.lastLocation"><i class="fas fa-step-forward"></i></button>
                                    </span>
                                </div>
                            </div>
                        </div>
                        <div class="satImgHldr">
                            <img style="max-width:100%;" src="https://dev.virtualearth.net/REST/v1/Imagery/Map/AerialWithLabels/40.6299,-74.3033/18/?ms=320,300&format=png&key=dcLcFIaVh7HHr3kYxMqq~z3IOleVdt0Pv_JDxdK0X7Q~AgX3x6H0kBmnonP50fMwBHcpzgeQnf3y27XpwSahxCwjJQii-TcLAqgDAv10pa0s" />
                        </div>
                    </div>
                    <div id="recGridHldr" class="recGridCard" style="">
                        <div id="recGrid"></div>
                    </div>
                   <div id="recSection" class="recDataSection" style="display:none;">
                       <div class="recResponseBar">
                           <label>Number of Completed Recs:</label>
                           <label>Number of Recs Needing Response:</label>
                       </div>
                       <div class="recHeaderBar">
                           <label class="facilityLabel">Recommendation</label>
                           <a href="#" class="closeRec" data-bind="click: $parent.hideRecForm">X</a>
                       </div>
                       <div class="recDataCard">
                           <div class="recDataContainer">
                               <div class="recData">
                               <div class="cardRow">
                                   <label class="cardLbl">Number:</label>
                                   <label class="cardValue"></label>
                               </div>
                               <div class="cardRow">
                                   <label class="cardLbl">Hazard:</label>
                                   <label class="cardValue"></label>
                               </div>
                               <div class="cardRow">
                                   <label class="cardLbl">Impact:</label>
                                   <label class="cardValue"></label>
                               </div>
                               <div class="cardRow">
                                   <label class="cardLbl" style="width:140px;">Primary Type:</label>
                                   <label class="cardValue"></label>
                               </div>
                               <div class="cardRow">
                                   <label class="cardLbl" style="width:140px;">Secondary Type:</label>
                                   <label class="cardValue"></label>
                               </div>
                               <div class="cardRow">
                                   <label class="cardLbl">Key Words:</label>
                                   <label class="cardValue"></label>
                               </div>
                               <div class="cardRow">
                                   <!-- HEADER ROW -->
                                   <label class="cardLbl" style="width:200px;">&nbsp;</label>
                                   <label class="cardLbl">Actual</label>
                                   <label class="cardLbl">Range</label>
                               </div>
                               <div class="cardRow">
                                   <label class="cardLbl">Current Loss Est.:</label>
                               </div>
                               <div class="cardRow">
                                   <label class="cardLbl">Completed Loss Est.:</label>
                               </div>
                               <div class="cardRow">
                                   <label class="cardLbl">Est. Cost To Complete:</label>
                               </div>
                               <div class="cardRow">
                                   <label class="cardLbl">Savings Ratio:</label>
                               </div>
                           </div>
                               <div class="recEditFields">
                               <div class="cardRow">
                                   <label class="cardLbl">Status:</label>
                               </div>
                               <div class="cardRow">
                                   <label class="cardLbl">Status Date:</label>
                               </div>
                               <div class="cardRow">
                                   <!-- THIS IS A HEADER ROW -->
                                   <label class="cardLbl" style="width:200px;">&nbsp;</label>
                                   <label class="cardLbl">Facility</label>
                                   <label class="cardLbl">Managment</label>
                                   <label class="cardLbl">3rd Level</label>
                               </div>
                               <div class="cardRow">
                                   <label class="cardLbl">Response Date:</label>
                               </div>
                               <div class="cardRow">
                                   <label class="cardLbl">Response From:</label>
                               </div>
                               <div class="cardRow">
                                   <label class="cardLbl">Intended Action:</label>
                               </div>
                               <div class="cardRow">
                                   <label class="cardLbl">Comment:</label>
                               </div>
                               <div class="cardRow">
                                   <label class="cardLbl">Expected Completeion Date:</label>
                               </div>
                               <div class="cardRow">
                                   <label class="cardLbl">Actual Cost To Complete:</label>
                               </div>
                           </div>
                           </div>
                           <div class="locationCardBtnHldr" style="width:990px;">
                               <span>
                                   <button type="button" class="grcBlueBtn pagerBtn" id="btnFileFirst" tabindex="15" style="margin-right: 2px;"><i class="fas fa-step-backward"></i></button>
                               </span>
                               <span>
                                   <button type="button" class="grcBlueBtn pagerBtn" id="btnFilePrevious" tabindex="16"><i class="fas fa-caret-left"></i></button>
                               </span>
                               <span class="buttonFileRecordLabel" style="width: 130px; display:flex; justify-content:center;">
                                   <input id="txtFileRecordNumber" class="k-autocomplete k-input inputCenter inputNoEdit buttonInput" style="width: 80px; margin-bottom: 3px;" readonly="true" />&nbsp;</span>
                               <span>
                                   <button type="button" class="grcBlueBtn pagerBtn" id="btnFileNext" tabindex="17" style="margin-right: 2px;"><i class="fas fa-caret-right"></i></button>
                               </span>
                               <span>
                                   <button type="button" class="grcBlueBtn pagerBtn" id="btnFileLast" tabindex="18"><i class="fas fa-step-forward"></i></button>
                               </span>
                           </div>
                            <div class="locationCardBtnHldr" style="padding:5px; width:990px;">
                                <button class="grcBlueBtn" style="margin-right:10px;">Edit</button>
                                <button class="grcRedBtn">Delete</button>
                            </div>
                       </div>
                   </div>
                </div>
            </div>
        </section>
    </form>
</body>
</html>