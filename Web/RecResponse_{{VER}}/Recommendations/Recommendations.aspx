<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/MasterNoMenu.master" CodeBehind="Recommendations.aspx.vb" Inherits="GRC.Connect.Web.Recommendations1" %>
<%--<%@ Register Src="~/Home_{{VER}}/Controls/Loader.ascx" TagName="Loader" TagPrefix="grcRSC" %>--%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-noedit.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-grid.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/kendo-lightblue-menu.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Kendo.v2014.1.318/kendo.grid.css" />
    <link rel="stylesheet" type="text/css" href="../../css/Header/header.css" />
    <link rel="stylesheet" type="text/css" href="../../css/Nav/nav.css" />
    <link rel="stylesheet" type="text/css" href="../../css/pages/mainPageBody.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/Utilities/utilities.css" />
    <link rel="stylesheet" type="text/css" href="../../css/pages/Recommendations.css" />
    <link rel="stylesheet" type="text/css" href="../../css/Utilities/Loader.css"  />
    <script src="../../Lib_{{VER}}/pages/global.js"></script>
    <script src="//cdnjs.cloudflare.com/ajax/libs/numeral.js/1.5.6/numeral.min.js"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCRecIntendedActionList.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCTranslationMgmtIntendedAction.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCTranslationMgmtIntendedAction.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCRecStatusList.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Day.js/dayjs.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Header/Header.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Footer/footer.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Recommendations/Recommendations.js" type="text/javascript"></script>
    
    <script>if (Function('/*@cc_on return document.documentMode===10@*/')()) { document.documentElement.className += ' ie10'; }</script>
    <script>var gServerSide_BingMapKey = "<%=ServerSide_BingMapKey%>";</script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="pageContentHldr">
        <div id="viewRecs" class="recContainer" style="" data-bind="with: viewRecs">
            <%--<grcRSC:Loader runat="server" ID="loader" />--%>
            <div class="locationHeaderBar">
                <label class="facilityLabel" style="margin-right:10px;">File No:</label><label class="facilityLabel" data-bind="    text: $parent.fileNo"></label>
            </div>
            <div class="locationCard" style="width: 875px; padding:10px;">
                <div class="locationInfoHldr" style="width:100%;">
                    <div class="locationUpper">
                        <div style="display: flex; width: 60%; flex-direction: column">
                            <div class="cardRow">
                                <label class="cardLbl"></label>
                            </div>
                            <div class="cardRow">
                                <label class="cardLbl" data-bind="text: $parent.facilityLbl">Facility:</label>
                                <label class="cardValue" data-bind="text: $parent.facility"></label>
                            </div>
                            <div class="cardRow">
                                <label class="cardLbl" data-bind="text: $parent.addressLbl">Address:</label>
                                <label class="cardValue" style="width: 255px;" data-bind="text: $parent.addressCityStateZipCombindedText"></label>
                            </div>
                            <div class="cardRow">
                                <label class="cardLbl" data-bind="text: $parent.countryLbl">Country:</label>
                                <label class="cardValue" data-bind="text: $parent.country"></label>
                            </div>
                            <div class="cardRow">
                                <label class="cardLbl" data-bind="text:$parent.longitudeLbl">Longitude:</label>
                                <label class="cardValue" data-bind="text: $parent.longitude"></label>
                            </div>
                            <div class="cardRow">
                                <label class="cardLbl" data-bind="text: $parent.latitudeLbl">Latitude:</label>
                                <label class="cardValue" data-bind="text: $parent.latitude"></label>
                            </div>
                            <div class="cardRow">
                                <label class="cardLbl" data-bind="text: $parent.clientLocIdLbl">Client Loc Id:</label>
                                <label class="cardValue" data-bind="text: $parent.clientLocNo"></label>
                            </div>
                            <div class="cardRow">
                                <label class="cardLbl" data-bind="text: $parent.divisionLbl">Division:</label>
                                <label class="cardValue" data-bind="text: $parent.division"></label>
                            </div>
                            <div class="cardRow">
                                <label class="cardLbl" data-bind="text: $parent.tivLbl">TIV (millions) USD:</label>
                                <label class="cardValue" data-bind="text: $parent.tiv"></label>
                            </div>
                            <div class="cardRow" style="margin-bottom: 0px;">
                                <label class="cardLbl" data-bind="text: $parent.customAccessLbl">Custom Access:</label>
                                <label class="cardValue" data-bind="text: $parent.customAccess"></label>
                            </div>
                        </div>
                        <div class="" style="width: 40%; display: flex; justify-content: space-between; flex-direction: row; align-items: center;">
                            <div>
                                <a href="#" class="grcBlueBtn printNone" data-bind="click: $parent.onCurrentERReport" style="width: 145px; font-size: 13px; margin-bottom:10px;">
                                    <i class="far fa-file" style="font-size: 20px; margin-right: 5px"></i>Current ER Report
                                </a>
                                <a href="#" class="grcBlueBtn printNone" data-bind="click: $parent.onCurrentDiagramReport" style="width: 145px; font-size: 13px;">
                                    <i class="far fa-file" style="font-size: 20px; margin-right: 5px;"></i>Current Diagram
                                </a>
                            </div>
                            <div>
                                <a href="#" class="grcBlueBtn printNone" data-bind="click: $parent.onPrint" style="width: 145px; font-size: 13px; margin-bottom:10px;">
                                    <i class="far fa-file" style="font-size: 20px; margin-right: 5px;"></i>Print
                                </a>
                                <a href="#" class="grcBlueBtn printNone" target="_blank" data-bind="attr: { href: $parent.staticImageURL }" style="width: 145px; font-size: 13px;">
                                    <i class="far fa-file" style="font-size: 20px; margin-right: 5px;"></i>Sat. Image
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div id="recGridHldr" class="recGridCard" style="">
                <div id="recGrid" style="width:1000px;"></div>
            </div>
            <div id="recSection" class="recDataSection" style="display: none;">
                <div class="recResponseBar">
                    <span>
                        <label>Number of Completed Recs:</label>
                        <label data-bind="text: $parent.numOfCompletedRec"></label>
                    </span>
                    <span>
                        <label>Number of Recs Needing Response:</label>
                        <label style="" data-bind="text: $parent.numOfRecsNeedingResponse"></label>
                    </span>
                </div>
                <div class="recHeaderBar">
                    <label class="facilityLabel">Recommendation</label>
                    <a href="#" class="closeRec" data-bind="click: $parent.hideRecForm">X</a>
                </div>
                <div class="recDataCard">
                    <div class="recDataContainer">
                        <div class="recData">
                            <div class="cardRow">
                                <label class="cardLbl" data-bind="text: $parent.recNumLbl">Number:</label>
                                <label class="cardValue" data-bind="text: $parent.recNumber"></label>
                            </div>
                            <div id="statusRow" class="cardRow">
                                <label class="cardLbl" data-bind="text: $parent.recStatusLbl">Status:</label>
                                <label id="recStatusDisplay" class="cardValue" data-bind="text: $parent.recStatus"></label>
                                <span id="recStatusDDHldr" class="noShow">
                                    <input id="recStatusDD" class="recEditField editRowEditValue" data-bind="text: $parent.recStatus" />
                                </span>
                            </div>
                            <div class="cardRow">
                                <label class="cardLbl" data-bind="text: $parent.recStatusDateLbl">Status Date:</label>
                                <label id="recStatusDateDisplay" class="cardValue" data-bind="text: $parent.recStatusDate"></label>
                                <span id="recStatusDatePickerHldr" class="noShow">
                                    <input id="recStatusDatePicker" class="recEditField editRowEditValue" data-bind="value: $parent.recStatusDate" />
                                </span>
                            </div>
                            <div class="cardRow">
                                <label class="cardLbl" data-bind="text: $parent.recHazardLbl">Service:</label>
                                <label class="cardValue" data-bind="text: $parent.recHazard" style="width:100px;"></label>
                                <i id="selfAuditFlag" class="noShow fas fa-flag" style="color:#ff0000;" title="This data was collected in the GRC Self Audit application by client personnel only.  This recommendation is a result of the client’s responses during a self audit."></i>
                            </div>
                            <div class="cardRow">
                                <label class="cardLbl" data-bind="text: $parent.recImpactLbl">Impact:</label>
                                <label class="cardValue" data-bind="text: $parent.recImpact"></label>
                            </div>
                            <div class="cardRow">
                                <label class="cardLbl" style="">Primary Type:</label>
                                <label class="cardValue" data-bind="text: $parent.recPrimaryType"></label>
                            </div>
                            <div class="cardRow">
                                <label class="cardLbl" style="">Secondary Type:</label>
                                <label class="cardValue" data-bind="text: $parent.recSecondaryType"></label>
                            </div>
                        </div>
                        <div class="recEditFields">
                            <div class="cardRow actualRangeRow">
                                <!-- HEADER ROW -->
                                <label class="cardLbl">&nbsp;</label>
                                <label class="cardLbl" style="width: 100px; text-align: center; margin-right: 0px;">Actual</label>
                                <label class="cardLbl" style="width: 225px; text-align: center; margin-right: 0px;">Range</label>
                            </div>
                            <div class="cardRow actualRangeRow">
                                <label class="cardLbl" style="">Current Loss Estimate:</label>
                                <!-- ACTUAL -->
                                <label class="actualValueLbl" style="" data-bind="text: $parent.recCurrentLossEstActual"></label>
                                <!-- RANGE -->
                                <label class="rangeValueLbl" style="" data-bind="text: $parent.recCurrentLossEstRange"></label>
                            </div>
                            <div class="cardRow actualRangeRow">
                                <label class="cardLbl" style="">Completed Loss Estimate:</label>
                                <!-- ACTUAL -->
                                <label class="actualValueLbl" style="" data-bind="text: $parent.recCompletedLossEstActual"></label>
                                <!-- RANGE -->
                                <label class="rangeValueLbl" style="" data-bind="text: $parent.recCompletedLossEstRange"></label>
                            </div>
                            <div class="cardRow actualRangeRow">
                                <label class="cardLbl" style="">Estimated Cost To Complete:</label>
                                <!-- ACTUAL -->
                                <label class="actualValueLbl" style="" data-bind="text: $parent.recEstCostToCompActual"></label>
                                <!-- RANGE -->
                                <label class="rangeValueLbl" style="" data-bind="text: $parent.recEstCostToCompRange"></label>
                            </div>
                            <div class="cardRow actualRangeRow">
                                <label class="cardLbl" style="">Savings Ratio:</label>
                                <!-- ACTUAL -->
                                <label class="actualValueLbl" style="" data-bind="text: $parent.recSavingsRatio"></label>
                                <!-- RANGE -->
                                <label class="rangeValueLbl" style="">&nbsp;</label>
                            </div>
                        </div>
                    </div>
                    <div id="editableFields" class="bottomFields">
                        <div class="cardRow">
                            <label class="cardLbl" style="width: 200px;">Key Words:</label>
                            <label class="cardValue" style="width: 893px;" data-bind="text: $parent.recKeywords"></label>
                        </div>
                        <div class="divider"></div>
                        <div class="cardRow">
                            <!-- THIS IS A HEADER ROW -->
                            <label class="cardLbl" style="width: 150px; margin-right: 18px;">&nbsp;</label>
                            <label class="cardLbl multiValueRowLbl" style="width: 130px; margin-right: 10px;">Response Date</label>
                            <label class="cardLbl multiValueRowLbl">Response From</label>
                            <label class="cardLbl multiValueRowLbl">Intended Action</label>
                            <label class="cardLbl multiValueRowLbl">Exp'd Comp. Date</label>
                            <label class="cardLbl multiValueRowLbl">Act. Cost To Comp.</label>
                            <label class="cardLbl multiValueRowLbl" style="width: 240px; margin-right: 0px;">Comment</label>
                        </div>
                        <div class="cardRow editRow" style="">
                            <label class="cardLbl" style="width:130px; margin-right:20px;">Facility:</label>

                            <label class="editRowDisplayValue respDateField" data-bind="text: $parent.recFacilityRespDate"></label>
                            <span id="recFacilityRespDatePickerHldr" class="noShow editValueHldr" style="width:135px;">
                                <input id="recFacilityRespDatePicker" class="respDateField recEditField editRowEditValue" data-bind="value: $parent.recFacilityRespDate" />
                            </span>
                            <label class="editRowDisplayValue respDateColor" data-bind="style: { 'background': $parent.recFacilityRespDateBackColor }">&nbsp</label>

                            <label class="editRowDisplayValue" data-bind="text: $parent.recFacilityRespFrom" style="width:145px; margin-right:40px;"></label>
                            <span id="respFromHldr" class="noShow editValueHldr">
                                <input id="recFacilityRespFrom" class="recEditField editInput editRowEditValue" data-changed="false" data-bind="value: $parent.recFacilityRespFrom" />
                            </span>

                            <label class="editRowDisplayValue" data-bind="text: $parent.recFacilityIntendedAction" style="width:140px; margin-right:40px;"></label>
                            <span id="recFacilityIntendedActionDDHldr" class="noShow editValueHldr">
                                <input id="recFacilityIntendedActionDD" class="recEditField editRowEditValue" data-bind="text: $parent.recFacilityIntendedAction" />
                            </span>
                            <label class="editRowDisplayValue" data-bind="text: $parent.recFacilityExpectedCompDate" style="width:115px;"></label>
                            <span id="recFacilityExpectedCompDatePickerHldr" class="noShow editValueHldr">
                                <input id="recFacilityExpectedCompDatePicker" class="recEditField editRowEditValue" data-bind="value: $parent.recFacilityExpectedCompDate" />
                            </span>
                            <label class="expectedCompDateBackColor" data-bind="style: {'background': $parent.recFacilityExpectedCompletionBackColor }">&nbsp;</label>

                            <label class="editRowDisplayValue" data-bind="text: $parent.recFacilityActualCostToComp" style=""></label>
                            <span id="actCostToCompHldr" class="noShow editValueHldr">
                                <input id="facilityActCostComp" class="recEditField editInput editRowEditValue" data-bind="value: $parent.recFacilityActualCostToComp" />
                            </span>
                            <label class="editRowDisplayValue cardValue commentLbl" data-bind="text: $parent.recFacilityComment" style="width: 240px; margin-right: 0px;"></label>
                            <span id="commentHldr" class="noShow editValueHldr" style="width: 235px; margin-right: 0px;">
                                <textarea id="recFacilityComment" class="recEditField editInputMultiLine editRowEditValue" style="width: 210px;" data-bind="value: $parent.recFacilityComment"></textarea>
                            </span>

                        </div>
                        <!-- ko if: $parent.showMGMT -->
                        <div class="cardRow editRow" style="">

                            <label class="cardLbl" style="width:130px; margin-right:20px;">Management:</label>

                            <label class="editRowDisplayValue respDateField" data-bind="text: $parent.recMGMTRespDate" style="width:95px;"></label>
                            <span id="mgmtRecRespDatePickerHldr" class=" noShow editValueHldr" style="width:135px;">
                                <input id="recMGMTRespDatePicker" class="respDateField recEditField editRowEditValue" data-bind="value: $parent.recMGMTRespDate" />
                            </span>

                            <label class="editRowDisplayValue" data-bind="text: $parent.recMGMTRespFrom" style=""></label>
                            <span id="mgmtRecRespFromHldr" class="noShow editValueHldr">
                                <input id="mgmtRecRespFrom" class="recEditField editInput editRowEditValue" data-bind="value: $parent.recMGMTRespFrom" />
                            </span>

                            <label class="editRowDisplayValue" data-bind="text: $parent.recMGMTIntendedAction" style=""></label>
                            <span id="mgmtRecIntendedActionHldr" class="noShow editValueHldr">
                                <input id="recMGMTIntendedActionDD" class="recEditField editRowEditValue" data-bind="text: $parent.recMGMTIntendedAction" />
                            </span>
                            <span class="editValueHldr">&nbsp;</span>
                            <span class="editValueHldr">&nbsp;</span>
                            <label class="editRowDisplayValue cardValue commentLbl" data-bind="text: $parent.recMGMTComment" style=""></label>
                            <span id="mgmtCommentHldr" class="noShow editValueHldr" style="width: 235px; margin-right: 0px;">
                                <textarea id="mgmtComment" class="recEditField editInputMultiLine editRowEditValue" style="width: 210px;" data-bind="value: $parent.recMGMTComment"></textarea>
                            </span>
                        </div>
                        <!-- /ko -->
                        <!-- ko if: $parent.show3rdLvl -->
                        <div class="cardRow editRow" style="">

                            <label class="cardLbl" style="width:130px; margin-right:0px;">3rd Level:</label>
                            
                            <label class="editRowDisplayValue respDateField" data-bind="text: $parent.recThirdLvlRespDate" style=""></label>
                            <span id="recThirdLvlRespDatePickerHldr" class="noShow editValueHldr" style="width:135px;">
                                <input id="recThirdLvlRespDatePicker" class="respDateField recEditField editRowEditValue" data-bind="value: $parent.recThirdLvlRespDate" />
                            </span>
                            
                            <label class="editRowDisplayValue" data-bind="text: $parent.recThirdLvlRespFrom" style=""></label>
                            <span id="recThirdLvlRespFromHldr" class="noShow editValueHldr">
                                <input id="recThirdLvlRespFrom" class="recEditField editInput editRowEditValue" data-bind="value: $parent.recThirdLvlRespFrom" />
                            </span>

                            <label class="editRowDisplayValue" data-bind="text: $parent.recThirdLvlIntendedAction" style=""></label>
                            <span id="recThirdLvlIntendedActionDDHldr" class="noShow editValueHldr">
                                <input id="recThirdLvlIntendedActionDD" class="recEditField editRowEditValue" data-bind="text: $parent.recThirdLvlIntendedAction" />
                            </span>
                            <span class="editValueHldr">&nbsp;</span>
                            <span class="editValueHldr">&nbsp;</span>
                            <label class="editRowDisplayValue cardValue commentLbl" data-bind="text: $parent.recThirdLvlComment" style=""></label>
                            <span id="thirdLvlCommentHldr" class="noShow editValueHldr" style="width: 235px; margin-right: 0px;">
                                <textarea id="thirdLvlComment" class="recEditField editInputMultiLine editRowEditValue" style="width: 210px;" data-bind="value: $parent.recThirdLvlComment"></textarea>
                            </span>
                        </div>
                        <!-- /ko -->
                    </div>
                    <div id="recPagerBtnHldr" class="" style="width: 100%; display: flex; justify-content: center">
                        <span>
                            <button type="button" class="grcBlueBtn pagerBtn" id="firstRecBtn" tabindex="15" style="margin-right: 2px;" data-bind="click: $parent.firstRec"><i class="fas fa-step-backward"></i></button>
                        </span>
                        <span>
                            <button type="button" class="grcBlueBtn pagerBtn" id="prevRecBtn" tabindex="16" data-bind="click: $parent.previousRec"><i class="fas fa-caret-left"></i></button>
                        </span>
                        <span class="buttonFileRecordLabel" id="Span1" data-bind="text: $parent.recommendationCountBoxText" style="width: 130px; display: flex; justify-content: center;"></span>
                        <span>
                            <button type="button" class="grcBlueBtn pagerBtn" id="nextRecBtn" data-bind="click: $parent.nextRec" tabindex="17" style="margin-right: 2px;"><i class="fas fa-caret-right"></i></button>
                        </span>
                        <span>
                            <button type="button" class="grcBlueBtn pagerBtn" id="lastRecBtn" tabindex="18" data-bind="click: $parent.lastRec"><i class="fas fa-step-forward"></i></button>
                        </span>
                    </div>
                    <div class="locationCardBtnHldr" style="padding: 5px; width: 1195px;">
                        <div id="editDelete">
                            <a href="#" class="grcBlueBtn" style="margin-right: 10px;" data-bind="click: function (data) { $parent.onEditBtnClick('edit') }">Edit</a>
                            <a href="#" class="grcRedBtn" data-bind="click: function(data){$parent.onDeleteBtnClick()}">Delete</a>
                        </div>
                        <div class="noShow" id="saveCancel">
                            <a href="#" class="grcGreenBtn" style="margin-right: 10px;" data-bind="click: $parent.onSaveBtnClick">Save</a>
                            <a href="#" class="grcNeutralBtn" data-bind="click: function (data) { $parent.onCancelBtnClick('cancel') } ">Cancel</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script>
        $(document).ready(function () {
            //SHOW OR HIDE TOP HORIZONTAL MENU
            $("#headerInfoHldr").addClass("noShow");
        });
    </script>
</asp:Content>