<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/MasterNoMenu.master" CodeBehind="Recommendations.aspx.vb" Inherits="GRC.Connect.Web.Recommendations" %>
<%@ Register Src="~/Home_{{VER}}/Controls/Loader.ascx" TagName="Loader" TagPrefix="grcRSC" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="../../css/kendo.common.min.css" />
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
            <grcRSC:Loader runat="server" ID="loader" />
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
                                <label class="cardLbl">Facility:</label>
                                <label class="cardValue" data-bind="text: $parent.facility"></label>
                            </div>
                            <div class="cardRow">
                                <label class="cardLbl">Address:</label>
                                <label class="cardValue" style="width:255px;" data-bind="text: $parent.addressCityStateZipCombindedText"></label>
                            </div>
                            <div class="cardRow">
                                <label class="cardLbl">Country:</label>
                                <label class="cardValue" data-bind="text: $parent.country"></label>
                            </div>
                            <div class="cardRow">
                                <label class="cardLbl">Longitude:</label>
                                <label class="cardValue" data-bind="text: $parent.longitude"></label>
                            </div>
                            <div class="cardRow">
                                <label class="cardLbl">Latitude:</label>
                                <label class="cardValue" data-bind="text: $parent.latitude"></label>
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
                                <label class="cardValue" data-bind="text: $parent.tiv"></label>
                            </div>
                            <div class="cardRow" style="margin-bottom: 0px;">
                                <label class="cardLbl">Custom Access:</label>
                                <label class="cardValue" data-bind="text: $parent.customAccess"></label>
                            </div>
                        </div>
                        <div class="" style="width: 40%; display: flex; justify-content: space-between; flex-direction: row; align-items: center;">
                            <div>
                                <a href="#" id="erReportBtn" class="grcBlueBtn printNone" data-bind="click: $parent.getERReport" style="width: 145px; font-size: 13px; margin-bottom:10px;" download>
                                    <i class="far fa-file" style="font-size: 20px; margin-right: 5px"></i>Current ER Report
                                </a>
                                <a href="#" id="diagramBtn" class="grcBlueBtn printNone" data-bind="click: $parent.getDiagramReport" style="width: 145px; font-size: 13px; margin-bottom:10px;">
                                    <i class="far fa-file" style="font-size: 20px; margin-right: 5px;"></i>Current Diagram
                                </a>
                                <a href="#" class="grcBlueBtn printNone" target="_blank" data-bind="attr: { href: $parent.staticImageURL }" style="width: 145px; font-size: 13px;">
                                    <i class="far fa-file" style="font-size: 20px; margin-right: 5px;"></i>Sat. Image
                                </a>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <div id="recResponseBar" class="recResponseBar">
                <span>
                    <label>Responses Completed:</label>
                    <label data-bind="text: $parent.numOfCompletedRec"></label>
                </span>
                <span>
                    <label id="switchLbl">Include All Recommendations:</label>
                    <input id="recSwitch" />
                </span>
                <span>
                    <label>Responses Needed:</label>
                    <label style="" data-bind="text: $parent.numOfRecsNeedingResponse"></label>
                </span>
            </div>
            <div id="recGridHldr" class="recGridCard" style="">
                <div id="recGrid" style="width:1000px;"></div>
            </div>
            <div id="recGridNoRecs" class="recGridCard noShow">
                    <p>There are no recommendations for this location.</p>
                </div>
            <div id="recSection" class="recDataSection" style="display: none;">
                
                <div class="recHeaderBar">
                    <label class="facilityLabel">Recommendation</label>
                    <div class="headerBarBtnHldr">
                        <div class="locationCardBtnHldr" style="background:transparent; margin-top:0px; width: 100%;">
                            <div id="editDelete">
                                <a href="#" class="grcBlueBtn" style="margin-right: 10px; border: 1px solid #fff;" data-bind="click: function(data) { $parent.onFilesBtnClick() }">Files&nbsp;(<span id="filesBtnBadge" data-bind="text: $parent.filesTotalCount"></span>)</a>
                                <a href="#" class="grcBlueBtn" style="margin-right: 10px; border: 1px solid #fff;" data-bind="click: function (data) { $parent.onEditBtnClick('edit') }">Edit</a>
                                <!-- ko if: $parent.isAdmin -->
                                <a href="#" class="grcRedBtn" style="margin-right: 10px; border: 1px solid #fff;" data-bind="click: function(data){$parent.onDeleteBtnClick()}">Delete</a>
                                <!-- /ko -->
                                <a href="#" class="grcNeutralBtn" style="border: 1px solid #fff;" data-bind="click: $parent.hideRecForm">Close</a>
                            </div>
                            <div class="noShow" id="saveCancel">
                                <a href="#" class="grcGreenBtn" style="margin-right: 10px; border: 1px solid #fff;" data-bind="click: $parent.onSaveBtnClick">Save</a>
                                <a href="#" class="grcNeutralBtn" data-bind="click: function (data) { $parent.onCancelBtnClick('cancel') } ">Cancel</a>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="recDataCard">
                    <div class="recDataContainer">
                        <div class="recData">
                            <div class="cardRow">
                                <label class="cardLbl">Number:</label>
                                <label class="cardValue" data-bind="text: $parent.recNumber"></label>
                            </div>
                            <div id="statusRow" class="cardRow">
                                <label class="cardLbl">Status:</label>
                                <label id="recStatusDisplay" class="cardValue" data-bind="text: $parent.recStatus"></label>
                                <span id="recStatusDDHldr" class="noShow">
                                    <input id="recStatusDD" class="recEditField editRowEditValue" data-bind="text: $parent.recStatus" />
                                </span>
                            </div>
                            <div class="cardRow">
                                <label class="cardLbl">Status Date:</label>
                                <label id="recStatusDateDisplay" class="cardValue" data-bind="text: $parent.recStatusDate"></label>
                                <span id="recStatusDatePickerHldr" class="noShow">
                                    <input id="recStatusDatePicker" class="recEditField editRowEditValue" data-bind="value: $parent.recStatusDate" />
                                </span>
                            </div>
                            <!-- ko ifnot: $parent.isIR -->
                            <div class="cardRow">
                                <label class="cardLbl">Service:</label>
                                <label class="cardValue" data-bind="text: $parent.recHazard" style="width:100px;"></label>
                                <i id="selfAuditFlag" class="noShow fas fa-flag" style="color:#ff0000;" title="This data was collected in the GRC Self Audit application by client personnel only.  This recommendation is a result of the client’s responses during a self audit."></i>
                            </div>
                            <!-- /ko -->
                            <!-- ko if: $parent.isIR -->
                            <div class="cardRow">
                                <label class="cardLbl">History:</label>
                                <label class="cardValue" data-bind="text: $parent.recHistory" style="width:100px;"></label>
                            </div>
                            <!-- /ko -->
                            
                            <div class="cardRow" data-bind="if: ($parent.isCargill() && $parent.isFire())">
                                <label class="cardLbl">Code:</label>
                                <label class="cardValue" data-bind="text: $parent.recCode"></label>
                            </div>
                            
                            <div class="cardRow">
                                <label class="cardLbl">Impact:</label>
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
                        <!-- ko ifnot: $parent.isIR-->
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
                        <!-- /ko -->
                        <!-- ko if: $parent.isIR -->
                        <div class="recEditFields">
                            <div class="cardRow">
                                <label class="cardLbl" style="width:185px;">Equipment No.:</label>
                                <label class="cardValue" data-bind="text: $parent.recEquipmentNo"></label>
                            </div>
                            <div class="cardRow">
                                <label class="cardLbl" style="width:185px;">Finding No.:</label>
                                <label class="cardValue" data-bind="text: $parent.recFindingNo"></label>
                            </div>
                            <div class="cardRow">
                                <label class="cardLbl" style="width:185px;">Plant Area:</label>
                                <label class="cardValue" data-bind="text: $parent.recPlantArea"></label>
                            </div>
                            <div class="cardRow">
                                <label class="cardLbl" style="width:185px;">Prob. Equip. Dam. Cost:</label>
                                <label class="cardValue" data-bind="text: $parent.recProbableEquipmentDamageCost"></label>
                            </div>
                            <div class="cardRow">
                                <label class="cardLbl" style="width:185px;">Fault Type:</label>
                                <label class="cardValue" data-bind="text: $parent.recFaultType"></label>
                            </div>
                            <div class="cardRow">
                                <label class="cardLbl" style="width:185px;">Length Of Bus. Inter.:</label>
                                <label class="cardValue" data-bind="text: $parent.recLengthBusInteruption"></label>
                            </div>
                            <div class="cardRow">
                                <label class="cardLbl" style="width:185px;">Detected With:</label>
                                <label class="cardValue" data-bind="text: $parent.recDetectedWith"></label>
                            </div>
                            <div class="cardRow">
                                <label class="cardLbl" style="width:185px;">Redundancy Spare:</label>
                                <label class="cardValue" data-bind="text: $parent.recRedundancySpare"></label>
                            </div>
                        </div>
                        <!-- /ko -->
                    </div>
                    <div id="editableFields" class="bottomFields">
                        <div class="cardRow">
                            <label class="cardLbl" style="width: 200px;">Key Words:</label>
                            <label class="cardValue" style="width: 949px;" data-bind="text: $parent.recKeywords"></label>
                        </div>
                        <div class="divider"></div>
                        <div class="editContainer" style="display:flex; justify-content:space-between;">
                            <div class="flexCol" style="">
                                <div class="flexRow" style="">
                                    <label>&nbsp;</label>
                                </div>
                                <div class="flexRow facilityRow" style="">
                                    <label class="cardLbl" style="">Facility:</label>
                                </div>
                                <div class="flexRow mgmtRow" style="">
                                    <label class="cardLbl" data-bind="if: $parent.showMGMT" style="">Management:</label>
                                </div>
                                <div class="flexRow thirLvlRow" style="">
                                    <label class="cardLbl" data-bind="if: $parent.show3rdLvl" style="">Third Level:</label>
                                </div>
                            </div>
                            <div class="flexCol" style="">
                                <div class="flexRow" style="">
                                    <label class="" style="font-size:16px; font-weight:700; text-align:center;">Response Date</label>
                                </div>
                                <div class="flexRow facilityRow" style="">
                                    <label class="editRowDisplayValue" style="width:100%; text-align:center;" data-bind="text: $parent.recFacilityRespDate"></label>
                                    <span id="recFacilityRespDatePickerHldr" class="noShow editValueHldr" style="">
                                        <input id="recFacilityRespDatePicker" class="respDateField recEditField editRowEditValue" data-bind="value: $parent.recFacilityRespDate" />
                                    </span>
                                    <label class="editRowDisplayValue respDateColor" data-bind="style: { 'background': $parent.recFacilityRespDateBackColor }">&nbsp</label>
                                </div>
                                <div class="flexRow mgmtRow" data-bind="if: $parent.showMGMT" style="">
                                    <label class="editRowDisplayValue respDateField" data-bind="text: $parent.recMGMTRespDate"></label>
                                    <span id="mgmtRecRespDatePickerHldr" class=" noShow editValueHldr" style="">
                                        <input id="recMGMTRespDatePicker" class="respDateField recEditField editRowEditValue" data-bind="value: $parent.recMGMTRespDate" />
                                    </span>
                                </div>
                                <div class="flexRow thirLvlRow" data-bind="if: $parent.show3rdLvl" style="">
                                    <label class="editRowDisplayValue respDateField" data-bind="text: $parent.recThirdLvlRespDate" style=""></label>
                                    <span id="recThirdLvlRespDatePickerHldr" class="noShow editValueHldr" style="">
                                        <input id="recThirdLvlRespDatePicker" class="respDateField recEditField editRowEditValue" data-bind="value: $parent.recThirdLvlRespDate" />
                                    </span>
                                </div>
                            </div>
                            <div class="flexCol" style="">
                                <div class="flexRow" style="">
                                    <label class="" style="font-size:16px; font-weight:700; text-align:center;">Response From</label>
                                </div>
                                <div class="flexRow facilityRow" style="">
                                    <label class="editRowDisplayValue" data-bind="text: $parent.recFacilityRespFrom" style=""></label>
                                    <span id="respFromHldr" class="noShow editValueHldr">
                                        <input id="recFacilityRespFrom" class="recEditField editInput editRowEditValue" data-changed="false" data-bind="value: $parent.recFacilityRespFrom" />
                                    </span>
                                </div>
                                <div class="flexRow mgmtRow" data-bind="if: $parent.showMGMT" style="">
                                    <label class="editRowDisplayValue" data-bind="text: $parent.recMGMTRespFrom" style=""></label>
                                    <span id="mgmtRecRespFromHldr" class="noShow editValueHldr">
                                        <input id="mgmtRecRespFrom" class="recEditField editInput editRowEditValue" data-bind="value: $parent.recMGMTRespFrom" />
                                    </span>
                                </div>
                                <div class="flexRow thirdLvlRow" data-bind="if: $parent.show3rdLvl" style="">
                                    <label class="editRowDisplayValue" data-bind="text: $parent.recThirdLvlRespFrom" style=""></label>
                                    <span id="recThirdLvlRespFromHldr" class="noShow editValueHldr">
                                        <input id="recThirdLvlRespFrom" class="recEditField editInput editRowEditValue" data-bind="value: $parent.recThirdLvlRespFrom" />
                                    </span>
                                </div>
                            </div>
                            <div class="flexCol" style="">
                                <div class="flexRow" style="">
                                    <label class="" style="font-size:16px; font-weight:700; text-align:center;">Intended Action</label>
                                </div>
                                <div class="flexRow facilityRow" style="">
                                    <label class="editRowDisplayValue" data-bind="text: $parent.recFacilityIntendedAction" style=""></label>
                                    <span id="recFacilityIntendedActionDDHldr" class="noShow editValueHldr">
                                        <input id="recFacilityIntendedActionDD" class="recEditField editRowEditValue" data-bind="text: $parent.recFacilityIntendedAction" />
                                    </span>
                                </div>
                                <div class="flexRow mgmtRow" data-bind="if: $parent.showMGMT" style="">
                                    <label class="editRowDisplayValue" data-bind="text: $parent.recMGMTIntendedAction" style=""></label>
                                    <span id="mgmtRecIntendedActionHldr" class="noShow editValueHldr">
                                        <input id="recMGMTIntendedActionDD" class="recEditField editRowEditValue" data-bind="text: $parent.recMGMTIntendedAction" />
                                    </span>
                                </div>
                                <div class="flexRow thirdLvlRow" data-bind="if: $parent.show3rdLvl" style="">
                                    <label class="editRowDisplayValue" data-bind="text: $parent.recThirdLvlIntendedAction" style=""></label>
                                    <span id="recThirdLvlIntendedActionDDHldr" class="noShow editValueHldr">
                                        <input id="recThirdLvlIntendedActionDD" class="recEditField editRowEditValue" data-bind="text: $parent.recThirdLvlIntendedAction" />
                                    </span>
                                </div>
                            </div>
                            <div class="flexCol" style="">
                                <div class="flexRow" style="">
                                    <label class="" style="font-size:16px; font-weight:700; text-align:center;">Exp'd Comp. Date</label>
                                </div>
                                <div class="flexRow facilityRow" style="">
                                    <label class="editRowDisplayValue" data-bind="text: $parent.recFacilityExpectedCompDate" style=""></label>
                                    <span id="recFacilityExpectedCompDatePickerHldr" class="noShow editValueHldr">
                                        <input id="recFacilityExpectedCompDatePicker" class="recEditField editRowEditValue" data-bind="value: $parent.recFacilityExpectedCompDate" />
                                    </span>
                                    <label class="expectedCompDateBackColor" data-bind="style: {'background': $parent.recFacilityExpectedCompletionBackColor }">&nbsp;</label>
                                </div>
                                <div class="flexRow mgmtRow" data-bind="if: $parent.showMGMT" style="">
                                    <span class="editValueHldr">&nbsp;</span>
                                </div>
                                <div class="flexRow thirdLvlRow" data-bind="if: $parent.show3rdLvl" style="">
                                    <span class="editValueHldr">&nbsp;</span>
                                </div>
                            </div>
                            <div class="flexCol" style="">
                                <!-- ko ifnot: $parent.isIR -->
                                <div class="flexRow" style="">
                                    <label class="" style="font-size:16px; font-weight:700; text-align:center;">Act. Cost To Comp.</label>
                                </div>
                                <div class="flexRow facilityRow" style="">
                                    <label class="editRowDisplayValue" data-bind="text: $parent.recFacilityActualCostToComp" style=""></label>
                                    <span id="actCostToCompHldr" class="noShow editValueHldr">
                                        <input id="facilityActCostComp" class="recEditField editInput editRowEditValue" data-bind="value: $parent.recFacilityActualCostToComp" />
                                    </span>
                                </div>
                                <!-- /ko -->
                                <div class="flexRow mgmtRow" data-bind="if: $parent.showMGMT" style="">
                                    <span class="editValueHldr">&nbsp;</span>
                                </div>
                                <div class="flexRow thirdLvlRow" data-bind="if: $parent.show3rdLvl" style="">
                                    <span class="editValueHldr">&nbsp;</span>
                                </div>
                            </div>
                            <div class="flexCol" style="">
                                <div class="flexRow" style="">
                                    <label class="cardLbl multiValueRowLbl" style="">Comment</label>
                                </div>
                                <div class="flexRow facilityRow" style="">
                                    <label id="commentLbl" class="editRowDisplayValue cardValue commentLbl" data-bind="text: $parent.recFacilityComment" style=""></label>
                                    <span id="commentHldr" class="noShow editValueHldr" style="">
                                        <textarea id="recFacilityComment" class="recEditField editInputMultiLine editRowEditValue" style="" data-bind="value: $parent.recFacilityComment"></textarea>
                                    </span>
                                </div>
                                <div class="flexRow mgmtRow" data-bind="if: $parent.showMGMT" style="">
                                    <label id="mgmtCommentLbl" class="editRowDisplayValue cardValue commentLbl" data-bind="text: $parent.recMGMTComment" style=""></label>
                                    <span id="mgmtCommentHldr" class="noShow editValueHldr" style="">
                                        <textarea id="mgmtComment" class="recEditField editInputMultiLine editRowEditValue" style="" data-bind="value: $parent.recMGMTComment"></textarea>
                                    </span>
                                </div>
                                <div class="flexRow thirLvlRow" data-bind="if: $parent.show3rdLvl" style="">
                                    <label id="thirdLvlCommentLbl" class="editRowDisplayValue cardValue commentLbl" data-bind="text: $parent.recThirdLvlComment" style=""></label>
                                    <span id="thirdLvlCommentHldr" class="noShow editValueHldr" style="">
                                        <textarea id="thirdLvlComment" class="recEditField editInputMultiLine editRowEditValue" style="" data-bind="value: $parent.recThirdLvlComment"></textarea>
                                    </span>
                                </div>
                            </div>
                        </div>
                    </div>
                    
                    <div id="recPagerBtnHldr" class="" style="width: 100%; display: flex; justify-content: center; margin-bottom:10px;">
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
                    
                </div>
            </div>
            <div id="filesSection" style="display:none;">
                <div class="recHeaderBar">
                    <label class="facilityLabel">Files</label>
                    <div class="headerBarBtnHldr">
                        <div class="locationCardBtnHldr" style="background:transparent; margin-top:0px; width: 100%;">
                            <div id="fileNav">
                                <a href="#" class="grcBlueBtn" style="margin-right: 10px; border: 1px solid #fff;" data-bind="click: $parent.onBackToRecClick">Rec</a> 
                                <a href="#" class="grcBlueBtn" style="margin-right: 10px; border: 1px solid #fff;" data-bind="click: $parent.onBackToRecGridClick()">Grid</a>
                            </div>
                        </div>
                    </div>
                </div>
                <input type="file" id="fileUpload" />
                <p id="noFilesMsg" style="display:none;">There are no files associated with this Recommendation. Use the dialog to upload a file.</p>
                <div id="filesGridHldr" class="" >
                    <div data-bind="foreach: $parent.fileListData">
                        <div class="linkHldr" data-bind="css: { altRow: $index() % 2 }">
                            <span class="fileTypeIcon" data-bind="html:$data.icon"></span>
                            <span class="fileText" data-bind="text:$data.name"></span>
                            <span class="fileDate" data-bind="text: $data.uploadDate"></span>
                            <span class="fileDownloadIcon" data-bind="click: function(e){ $parents[1].onFileDownload(e) } "><i class="far fa-download"></i></span>
                            <span class="fileDeleteIcon" data-bind="click: function(e){ $parents[1].onFileDelete(e) }"><i class="far fa-trash-alt"></i></span>
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
