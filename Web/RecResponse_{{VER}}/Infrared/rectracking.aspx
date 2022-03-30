<%@ Page Title="Recommendation Response | Global Risk Consultants" Language="vb" AutoEventWireup="false" MasterPageFile="~/RecResponse_{{VER}}/ClientConnectRecResponse.Master" CodeBehind="rectracking.aspx.vb" Inherits="GRC.Connect.Web.rectracking_infrared_recresponse" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="Stylesheet" type="text/css" href="../../css/pages/rectracking.css" />
    <link rel="Stylesheet" type="text/css" href="../../css/pages/rectracking_translation.css" />
    <script src="../../Lib_{{VER}}/Generated/ViewCCLocationListingRecResponseIR.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCLocationListingRecResponseIR.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/Findings.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/Findings.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Mapping/moment.min.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="view" data-bind="with: view">
    <!-- TABLE FOR COMPANY / ADDRESS INFORMATION -->
    <!-- SPECIFIC STYLES TO ROWS OR COLUMNS SHOULD BE INLINE -->
    <div class="tableDiv" style="width: 100%;">
        <div class="tabRow">
            <span class="companyLabels1"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblGRCLocNo">GRC Loc. No.</label></span>
            <span class="companyInputs1"><input readonly="true" data-bind="value: $parent.objListing().FileNo" id="FileNo" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs1" tabindex="1" /></span>
            <span class="companyLabels2"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblClientLocNo">Client Loc. No.</label></span>
            <span class="companyInputs2"><input readonly="true" data-bind="value: $parent.objListing().ClientLocNo" id="ClientLocNo" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs2" tabindex="2" /></span>
            <span class="companyLabels5"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblLatitude">Latitude</label></span>
            <span class="companyInputs4"><input readonly="true" data-bind="value: $parent.objListing().Latitude" id="Latitude" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs4" tabindex="3"  /></span>
            <span class="companyLabels4"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblLongitude">Longitude</label></span>
            <span class="companyInputs4"><input readonly="true" data-bind="value: $parent.objListing().Longitude" id="Longitude" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs4" tabindex="4"  /></span>
        </div>
        <div class="tabRow">
            <span class="companyLabels1"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblAddress1">Address</label></span>
            <span class="companyInputs6"><input readonly="true" data-bind="value: $parent.objListing().Address1" id="Address1" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs6" tabindex="5"  /></span>
            <span class="companyLabels3"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblDivisionName">Division Name</label></span>
            <span class="companyInputs5"><input readonly="true" data-bind="value: $parent.objListing().Division" id="Division" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="6"  /></span>
        </div>
        <div class="tabRow">
            <span class="companyLabels1"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblCity">City</label></span>
            <span class="companyInputs1"><input readonly="true" data-bind="value: $parent.objListing().City" id="City" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs1" tabindex="7"  /></span>
            <span class="stateLabels"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblState">State</label></span>
            <span class="stateInputs"><input readonly="true" data-bind="value: $parent.objListing().StProv" id="StProv" class="k-autocomplete k-input inputNoEdit inputLeft stateInputs" tabindex="8"  /></span>
            <span class="countryLabels"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblCountry">Country</label></span>
            <span class="countryInputs"><input readonly="true" data-bind="value: $parent.objListing().Country" id="Country" class="k-autocomplete k-input inputNoEdit inputLeft countryInputs" tabindex="9"  /></span>
            <span class="postalLabels"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblPostalCode">Postal</label></span>
            <span class="postalInputs"><input readonly="true" data-bind="value: $parent.objListing().Zip" id="Zip" class="k-autocomplete k-input inputNoEdit inputLeft postalInputs" tabindex="10"  /></span>
            <span class="companyLabels3" style=""><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblFacilityName">Facility Name</label></span>
            <span class="companyInputs5"><input readonly="true" data-bind="value: $parent.objListing().Facility" id="Facility" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="11"  /></span>
        </div>
        <div class="tabRow">
            <!-- BUTTONS FOR LOCATION / FILE NUMBER WALK / FIND LOCATION -->
            <span class="companyLabels1"></span>
            <span class="buttonContainerLocationLoading">
            </span>
            <!-- END BUTTONS FOR LOCATION / FILE NUMBER WALK / FIND LOCATION -->
            <span class="companyLabels6"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblCustomerAccess">Custom Access</label></span>
            <span class="companyInputs5"><input readonly="true" data-bind="value: $parent.objListing().CustomAccess" id="CustomAccess" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="12"  /></span>
        </div>
    </div>
    <!-- END TABLE FOR COMPANY / ADDRESS INFORMATION -->

    <br />

    <!-- TABLE FOR RECOMMENDATION TRACKING INFORMATION -->
    <!-- SPECIFIC STYLES TO ROWS OR COLUMNS SHOULD BE INLINE -->
    <div class="tableDiv" style="width: 100%;">
        <div class="recResponse_TableDivHeader_Background">
            <div class="recResponse_TableDivHeader">
                <span class="recResponse_HeaderPadding">&nbsp;</span>
                <span class="recResponse_HeaderLabel"><label data-bind="text: $parent.objLanguageLabels().lblResponsesNeeded" id="lblResponsesNeeded">Responses Needed</label> = &nbsp;</span>
                <span id="recCountNeeded" class="recResponse_HeaderNumberRed"><label data-bind="text: $parent.countsNeeded" id="countsNeeded">0</label></span>
                <span class="recResponse_HeaderLabel"><label data-bind="text: $parent.objLanguageLabels().lblResponsesCompleted" id="lblResponsesCompleted">Responses Completed</label> = &nbsp;</span>
                <span class="recResponse_HeaderNumber"><label data-bind="text: $parent.countsCompleted" id="countsCompleted">0</label></span>
            </div>
        </div>
    </div>
    <div class="tableDivAutoBorders">
    <div class="tableDiv" style="width: 100%;">
        <div class="tabRow" style="height:35px;">
            <span class="bufferLeft" style="height: 21px;"></span>
            <span class="recLabelLeft" style="height: 21px;"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblRecNo">Rec. No.</label></span>
            <span class="recInputRecNoIR" style="height: 21px;">
                <input data-bind="value: $parent.objRec().RecYear, attr: { title: $parent.objRec().RecYear }" id="RecYear" class="k-autocomplete k-input inputNoEdit inputLeft" maxlength="4" readonly="readonly" style="width: 40px;" />
                <input data-bind="value: $parent.objRec().RecMonth, attr: { title: $parent.objRec().RecMonth }" id="RecMonth" class="k-autocomplete k-input inputNoEdit inputLeft" maxlength="2" readonly="readonly" style="width: 20px;" />
                <input data-bind="value: $parent.objRec().RecNumber, attr: { title: $parent.objRec().RecNumber }" id="RecNumber" class="k-autocomplete k-input inputNoEdit inputLeft" maxlength="3" readonly="readonly" style="width: 30px;" />
            </span>
            <span class="recLabelRecImpact" style="height: 21px;"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblRecImpact">Rec. Impact</label></span>
            <span class="recInputRecImpact" id="" style="height: 21px;">
                <input data-bind="value: $parent.widgetImpactPlaceHolder, attr: { title: $parent.widgetImpactPlaceHolder }" id="Impact" class="k-autocomplete k-input inputNoEdit inputLeft recInputRecImpact" style="margin-left: 2px;" readonly="readonly" />
                <select style="display: none;" id="clearImpact" class="inputNoEdit recInputRecImpact" data-bind="kendoDropDownList: {
                    data: $parent.KOcollImpactList,
                    value: $parent.objRec().Impact,
                    enabled: $parent.enableAlwaysOff,
                    close: $parent.onCloseAll,
                    widget: $parent.widgetImpact
                }"></select>
            </span>
            <span class="recLabelRecStatus" style="height: 21px;"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblRecStatus">Rec. Status</label></span>
            <span class="recInputRecStatusStandardIR" id="" style="height: 21px;">
                <input data-bind="value: $parent.widgetRecStatusPlaceHolder, attr: { title: $parent.widgetRecStatusPlaceHolder }" id="RecStatus" class="k-autocomplete k-input inputNoEdit inputLeft recInputRecStatusStandardIR" style="margin-left: 2px;" readonly="readonly" />
                <select style="display: none;" class="inputNoEdit recInputRec" data-bind="kendoDropDownList: {
                    data: $parent.KOcollStatuslist,
                    value: $parent.objRec().RecStatus,
                    enabled: $parent.enableAlwaysOff,
                    close: $parent.onCloseAll,
                    widget: $parent.widgetRecStatus
                }"></select>
            </span>
            <span class="recLabelHistory" style="height: 21px;"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblHistory">History</label></span>
            <span class="recInputRecCode" style="height: 21px;"><input data-bind="value: $parent.objRec().History, attr: { title: $parent.objRec().History }" id="History" class="k-autocomplete k-input inputNoEdit inputLeft recInputRecCode" readonly="readonly"/></span>
            <span class="recLabelRecSmall" style="padding-left: 11px; height: 21px;"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblStatusDate">Status Date</label></span>
            <span class="recInputDate" style=""><input data-bind="" id="StatusDate" class="k-autocomplete k-input inputCenter inputNoEdit recInputDate" readonly="readonly" /></span>
            <span class="bufferRight" style="height: 21px;"></span>
        </div>
        <div class="tabRow">
            <span class="bufferLeft"></span>
            <span class="recLabelLeft" style="height: 21px;"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblSeverity">Severity</label></span>
            <span class="recInputRecCode" style="height: 21px;"><input data-bind="value: $parent.objRec().Severityrating, attr: { title: $parent.objRec().Severityrating }" id="Severityrating" class="k-autocomplete k-input inputNoEdit inputLeft recInputRecCode" readonly="readonly"/></span>
            <span class="recLabelHazard"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblPrimaryRecType">Primary Rec. Type</label></span>
            <span class="recInputHazard"><input data-bind="value: $parent.objRec().RecPrimary, attr: { title: $parent.objRec().RecPrimary }" id="RecPrimaryText" class="k-autocomplete k-input inputNoEdit inputLeftKendo recInputHazard" readonly="readonly" /></span>
            <span class="recLabelSecondaryTypeSmall"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblSecondaryRecType">Secondary Rec. Type</label></span>
            <span class="recInputHazard"><input data-bind="value: $parent.objRec().RecSecondary, attr: { title: $parent.objRec().RecSecondary }" id="RecSecondaryText" class="k-autocomplete k-input inputNoEdit inputLeftKendo recInputHazard" readonly="readonly" /></span>
            <span class="bufferRight" style="padding-left: 7px;"></span>
        </div>
        <div class="tabRow">
            <span class="bufferLeft"></span>
            <span class="recLabelLeft"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblRecKeyWord">Rec. Key Word</label></span>
            <span class="recInputKeyWordsLong"><input data-bind="value: $parent.objRec().Recommendation, attr: { title: $parent.objRec().Recommendation }" id="Recommendation" class="k-autocomplete k-input inputNoEdit inputLeftKendo recInputKeyWordsLong" readonly="readonly" /></span>
            <span class="bufferRight" style="padding-left: 5px;"></span>
        </div>
        <div class="tabRow">
            <span class="borderBottom" style="height: 5px; width: 100%;">&nbsp;</span> 
        </div>
        <div>
            <span class="" style="height: 5px; width: 100%;">&nbsp;</span> 
        </div>
        <div class="tabRow">
            <span class="bufferLeft"></span>
            <span class="recLabelLeft"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblEquipmentNo">Equipment No.</label></span>
            <span class="recInputRecCode"><input data-bind="value: $parent.objRec().Itemno, attr: { title: $parent.objRec().Itemno }" id="Itemno" class="k-autocomplete k-input inputNoEdit inputLeft recInputRecCode" readonly="readonly"/></span>
            <span class="recLabelFindingNo"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblFindingNo">Finding No.</label></span>
            <span class="recInputRecCode"><input data-bind="value: $parent.objRec().Findingno, attr: { title: $parent.objRec().Findingno }" id="Findingno" class="k-autocomplete k-input inputNoEdit inputLeft recInputRecCode" readonly="readonly"/></span>
            <span class="recLabelRecPlantArea"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblPlantArea">Plant Area</label></span>
            <span class="recLabelRecLarge"><input data-bind="value: $parent.objRec().PlantAreaAffected, attr: { title: $parent.objRec().PlantAreaAffected }" id="PlantAreaAffected" class="k-autocomplete k-input inputNoEdit inputLeft recInputRec" readonly="readonly"/></span>
            <span class="recLabelProbEquipDamage"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblProbableEquipmentDamageCost">Prob. Equip. Dam. Cost</label></span>
            <span class="recInputDateSmall"><input data-bind="value: $parent.objRec().ProbableEquipmentDamageCost, attr: { title: $parent.objRec().ProbableEquipmentDamageCost }" id="ProbableEquipmentDamageCost" class="k-autocomplete k-input inputNoEdit inputLeft recInputDateSmall" readonly="readonly"/></span>
            <span class="bufferRight"></span>
        </div>
        <div class="tabRow">
            <span class="bufferLeft"></span>
            <span class="recLabelLeft"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblFaultType">Fault Type</label></span>
            <span class="recInputRecFaultType"><input data-bind="value: $parent.objRec().FaultType, attr: { title: $parent.objRec().FaultType }" id="FaultType" class="k-autocomplete k-input inputNoEdit inputLeft recInputRecFaultType" readonly="readonly"/></span>
            <span class="recLabelLengthOfBusinessInterruption"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblLengthOfBusinessInterruption">Length Of Bus. Inter.</label></span>
            <span class="recInputRecCode"><input data-bind="value: $parent.objRec().LengthOfBusinessInterruption, attr: { title: $parent.objRec().LengthOfBusinessInterruption }" id="LengthOfBusinessInterruption" class="k-autocomplete k-input inputNoEdit inputLeft recInputRecCode" readonly="readonly"/></span>
            <span class="recLabelRecPlantArea"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblDetectedWith">Detected With</label></span>
            <span class="recInputRec"><input data-bind="value: $parent.objRec().DetectedWith, attr: { title: $parent.objRec().DetectedWith }" id="DetectedWith" class="k-autocomplete k-input inputNoEdit inputLeft recInputRec" readonly="readonly"/></span>
            <span class="recLabelRedundancySpare"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblRedundancySpare">Redundancy Spare</label></span>
            <span class="recInputRecRedundancy"><input data-bind="value: $parent.objRec().RedundancySpare, attr: { title: $parent.objRec().RedundancySpare }" id="RedundancySpare" class="k-autocomplete k-input inputNoEdit inputLeft recInputRecRedundancy" readonly="readonly"/></span>
            <span class="bufferRight"></span>
        </div>
        <div class="tabRow" style="height:30px;">
            <span class="bufferLeft"></span>
            <span class="recLabelLeft"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblRespDate">Resp. Date</label></span>
            <span class="recInputDateSmall"><input data-bind="" id="ResponseDate" class="k-autocomplete k-input inputCenter inputNoEdit recInputDateSmall" readonly="readonly" /></span>
            <span class="recLabelRespSmall"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblRespForm">Resp. From</label></span>
            <span class="recInputRespSmall"><input data-bind="value: $parent.objRec().ResponseFrom, attr: { title: $parent.objRec().ResponseFrom }" id="ResponseFrom" class="k-autocomplete k-input inputNoEdit inputLeftKendo recInputRespSmall" readonly="readonly" /></span>
            <span class="bufferRight" style="padding-left: 4px;"></span>
        </div>
        <div class="tabRow" style="height:30px;">
            <span class="bufferLeft"></span>
            <span class="recLabelLeft"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblExpdComplDate">Exp. Compl. Date</label></span>
            <span class="recInputDateSmall"><input data-bind="" id="ExpectedCompletionDate" class="k-autocomplete k-input inputCenter inputNoEdit recInputDateSmall" /></span>
            <span class="recLabelIntendedActionSmall"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblRecIntendedAction">Rec. Intended Action</label></span>
            <span class="recInputIntendedActionSmall" id="IntendedAction" data-bind="attr: { title: $parent.widgetIntendedActionPlaceHolder }">
                <select class="inputNoEdit recInputIntendedActionSmall" data-bind="kendoDropDownList: {
                    data: $parent.KOcollIntendedaction,
                    value: $parent.objRec().IntendedAction,
                    enabled: $parent.enablePickers,
                    close: $parent.onCloseIntendedAction,
                    widget: $parent.widgetIntendedAction },
                    attr: { title: $parent.widgetIntendedActionPlaceHolder }">
                </select>
            </span>            
            <span class="bufferRight" style="padding-left: 4px;"></span>
        </div>
        <div class="tabRow">
            <span class="bufferLeft" style="height: 32px;"></span>
            <span class="recLabelLeft" style="height: 32px;"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblFacilityComment">Facility Comment</label></span>
            <span class="recInputCommentsLarge" style="height: 32px;">
                <textarea data-bind="value: $parent.objRec().PlantComment, attr: { title: $parent.objRec().PlantComment }" id="PlantComment" class="k-textbox inputNoEdit recInputCommentsLarge" rows="8" cols="20" style="white-space: pre-wrap;"></textarea>
            </span>
        </div>

        <%-- THE BELOW FIELDS WILL BE CHANGED AND UN COMMENTED WHEN GARY ADDS NEW MANAGER RESPONSE FIELDS TO THE DB --%>
        <!-- $parent.enableMgmtFields -->
        <!--<div data-bind="visible: $parent.clientFeatures().search('\.+') > -1">-->
        <div data-bind="visible: $.inArray('\+', $parent.clientFeatures()) > -1">
            <span class="borderBottom" style="height: 5px; width: 100%;"></span>
        </div>
        <!-- $parent.enableMgmtFields -->
        <%--<div data-bind="visible: $parent.clientFeatures().search('\.+') > -1">--%>
        <div data-bind="visible: $.inArray('\+', $parent.clientFeatures()) > -1">
            <span class="bufferLeft" style="height: 5px;"></span>
            <span class="" style="height: 5px; width: 782px;"></span> 
            <span class="bufferRight" style="height: 5px;"></span>
        </div>
        <!-- $parent.enableMgmtFields -->
        <div class="tabRow" data-bind="visible: $.inArray('\+', $parent.clientFeatures()) > -1">
            <span class="bufferLeft"></span>
            <span class="recLabelLeft"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblMgmtRespDate">Mgmt. Resp. Date</label></span>
            <span class="recInputDateSmall"><input data-bind="" id="MgmtRespDate" class="k-autocomplete k-input inputCenter inputNoEdit recInputDateSmall" readonly="readonly" /></span>
            <span class="recLabelRespSmall"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblMgmtRespFrom">Mgmt. Resp. From</label></span>
            <span class="recInputRespSmall"><input data-bind="value: $parent.objRec().MgmtRespFrom" id="MgmtRespFrom" class="k-autocomplete k-input inputNoEdit inputLeft recInputRespSmall" readonly="readonly" /></span>
            <span class="recLabelIntendedActionSmallMgmt"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblMgmtRespAction">Mgmt. Action</label></span>
            <span class="recInputIntendedActionSmall">
                <input data-bind="value: $parent.objRec().MgmtRespAction, attr: { title: $parent.objRec().MgmtRespAction }" id="MgmtRespAction" class="k-autocomplete k-input inputNoEdit inputLeft recInputIntendedActionSmall" style="margin-left: 3px;" readonly="readonly" />
                <select style="display:none; visibility:hidden;" class="inputNoEdit recInputIntendedActionSmall" data-bind="kendoDropDownList: {
                    data: $parent.KOcollIntendedactionMgmt,
                    value: $parent.objRec().MgmtRespAction,
                    enabled: $parent.enablePickers,
                    close: $parent.onCloseMgmtIntendedAction,
                    widget: $parent.widgetIntendedActionMgmt },
                    attr: { title: $parent.widgetIntendedActionMgmt }">
                </select>
            </span>
        </div>
        <!-- $parent.enableMgmtFields -->
        <%--<div class="ui-helper-clearfix" data-bind="visible: $parent.clientFeatures().search('\.+') > -1">--%>
        <div class="tabRow" data-bind="visible: $.inArray('\+', $parent.clientFeatures()) > -1">
            <span class="bufferLeft" style="height: 32px;"></span>
            <span class="recLabelLeft" style="height: 32px;"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblMgmtRespComment">Mgmt. Comment</label></span>
            <span class="recInputCommentsLarge" style="height: 32px;">
                <textarea data-bind="value: $parent.objRec().MgmtRespComment, attr: { title: $parent.objRec().MgmtRespComment }" id="MgmtRespComment" class="k-textbox inputNoEdit recInputCommentsLarge" rows="8" cols="20" readonly="readonly" style="white-space: pre-wrap;"></textarea>
            </span>
            <span class="bufferRight" style="height: 32px; padding-left: 4px"></span>
        </div>
        <div style="height: 0px;">
            <span id="MgmtRespDateEmpty" style="height: 0px;"></span>
            <span id="MgmtRespActionEmpty" style="height: 0px;"></span>
        </div>
        <%-- END NEW MANAGER RESPONSE FIELDS --%>
        <!-- START 3rd Level Field Markup -->
            <div data-bind="if: $parent.clientFeatures().search('!') > -1">
                <div class="tabRow">
                    <span class="bufferLeft"></span><span class="recLabelLeft"><label>3rd Lvl Resp. Date</label></span>
                    <span class="recInputDateSmall"><input data-bind="" id="lvl3RespDate" class="k-numerictextbox inputNoEdit recInputDateSmall" /></span>
                    <span class="recLabelRespSmall"><label data-bind="">Resp. From</label></span>
                    <span class="recInputRespSmall"><input data-bind="value: $parent.objRec().ThirdLevelRespFrom" id="lvl3RespFrom" class="k-autocomplete k-input inputNoEdit inputLeftKendo recInputRespSmall" /></span>
                    <span class="recLabelIntendedActionSmall"><label>3rd Lvl Action</label></span>
                    <span class="recInputIntendedActionSmall" id="lvl3ActionDD">
                        <input class="k-autocomplete k-input inputNoEdit inputLeft recInputIntendedActionSmall" data-bind="text: $parent.objRec().ThirdLevelRespAction" style="margin-left: 3px;" readonly="readonly" />
                    </span>
                </div>
                <div class="tabRow">
                    <span class="bufferLeft" style="height: 32px;"></span>
                    <span class="recLabelLeft" style="height: 32px;">
                        <label data-bind="">3rd Lvl Comment</label></span>
                    <span class="recInputCommentsLarge" style="height: 32px;">
                        <textarea data-bind="value: $parent.objRec().ThirdLevelRespComment, attr: { title: $parent.objRec().ThirdLevelRespComment }" id="lvl3Commment" class="k-textbox inputNoEdit recInputCommentsLarge" rows="8" cols="20" style="white-space: pre-wrap;"></textarea>
                    </span>
                </div>
            </div>
            <!-- END 3rd Level Field Markup -->
        <div class="tabRow">
            <span class="bufferLeft"></span>
            <span class="buttonCell" style="text-align: left; padding-left: 104px;"><button class="k-button k-button-padding" style="width: 90px;" id="editSave" data-bind="click: $parent.onEditSave, text: $parent.txtEditSave, enable: $parent.enableNoLocationFound">Edit</button></span>
            <span class="buttonCell" style="text-align: left;"><button class="k-button k-button-padding" style="width: 90px;" id="cancelDelete" data-bind="visible: $parent.enableDelete, click: $parent.onCancelDelete, text: $parent.txtCancelDelete, enable: $parent.enableNoLocationFound">Delete</button></span>
            <span class="buttonCellRecord">
                <div class="buttonContainer">
                    <span><button data-bind="click: $parent.onFirst, enable: $parent.enablePrev" class="k-button buttonShape" id="btnFirst"><i class="fas fa-step-backward"></i></button></span>
                    <span><button data-bind="click: $parent.onPrevious, enable: $parent.enablePrev" class="k-button buttonShape" id="btnPrevious"><i class="fas fa-caret-left"></i></button></span>
                    <span class="buttonRecordLabel">&nbsp;<label data-bind="text: $parent.objLanguageLabels().lblRecord">Record</label> <input data-bind="value: $parent.txtRecordNumber" id="txtRecordNumber" class="k-autocomplete k-input inputCenter inputNoEdit buttonInput" style="margin-bottom: 3px;" readonly="true" />&nbsp;</span>
                    <span><button data-bind="click: $parent.onNext, enable: $parent.enableNext" class="k-button buttonShape" id="btnNext"><i class="fas fa-caret-right"></i></button></span>
                    <span><button data-bind="click: $parent.onLast, enable: $parent.enableNext" class="k-button buttonShape id="btnLast"><i class="fas fa-step-forward"></i></button></span>
                </div>
            </span>
            <span class="recLabelDatasheetView"><a class="recLabelVerticalCenter" id="hypRecDatasheet" href="#" data-bind="click: $parent.onDatasheetView, enable: $parent.enableNoLocationFound, text: $parent.objLanguageLabels().lblDatasheetView" class="recLabelVerticalCenter">Datasheet View</a></span>
            <span class="bufferRight"></span>
        </div>
        <div class="tabRow">
            <span class="bufferLeftAutoHeight" style="height: 14px;"></span>
            <span class="messageHeight" style="padding: 4px;">
                &nbsp;<label class="messageNotice" data-bind="text: $parent.messageSave"></label><label class="messageError" data-bind="text: $parent.messageValidation"></label>
            </span> 
            <span class="bufferRight" style="height: 14px;"></span>
        </div>
        <div>
            <span class="borderBottom" style="height: 5px; width: 100%;"></span> 
        </div>
        <div style="padding-top: 7px;" class="tabRow">
            <span class="bufferLeft" style="height: 24px;">&nbsp;</span>
            <span class="recResponse_DocumentsLabel"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblClickToViewCurrentReport">Click to View Current Report</label></span>
            <span class="recResponse_DocumentLink" style="height: 24px;">
                <span class="k-widget k-autocomplete k-header k-input inputCenter inputNoEdit inputLink recResponse_DocumentLink" style="line-height: normal;">
                    <label class="linkPointer" data-bind="visible: $parent.ToIRReport, text: $parent.objLanguageLabels().lblClickHere, click: function(data) { $parent.onBuildLink($parent.ToIRReport()) }"></label>
                </span>
            </span>
            <span class="recResponse_DocumentsLabel"><label class="recLabelVerticalCenter" data-bind="text: $parent.objLanguageLabels().lblClickToViewLatestDiagram">Click to View Latest Diagram</label></span>
            <span class="recResponse_DocumentLink" style="height: 24px;">
                <span class="k-widget k-autocomplete k-header k-input inputCenter inputNoEdit inputLink recResponse_DocumentLink" style="line-height: normal;">
                    <label class="linkPointer" data-bind="visible: $parent.ToIRDiagram, text: $parent.objLanguageLabels().lblClickHere, click: function(data) { $parent.onBuildLink($parent.ToIRDiagram()) }"></label>
                </span>
            </span>
            <span class="bufferRight" style="height: 24px;">&nbsp;</span>
        </div>
        <div>
            <span class="bufferLeft" style="height: 1px;">&nbsp;</span>
            <span class="" style="height: 1px;">&nbsp;</span>
            <span class="bufferRight" style="height: 1px;">&nbsp;</span>
        </div>
    </div>
    </div>
    <!-- END TABLE FOR RECOMMENDATION TRACKING INFORMATION -->

    <!-- AREA FOR ERROR AND NOTICE MESSAGES -->
    <div style="padding-top: 4px; text-align: center;"><label class="messageError" data-bind="text: $parent.messageError"></label><label class="messageNotice" data-bind="text: $parent.messageNotice"></label><label class="messageWarning" data-bind="text: $parent.messageWarning"></label>&nbsp;</div>

    <!-- ERROR WINDOW FOR REVIEW PREVIOUS RESPONSE -->
    <div id="windowRecReview" class="windowContent">
        <div><img src="../../Home_{{VER}}/images/icons/reports/document_information_32x32.png" align="left" alt="Warning" class="windowImageSmallPadding" style="width: 32px; height: 32px;" /></div>
        <div><label data-bind="text: $parent.objLanguageLabels().lblWindowRecReview_Message" id="">Please review the previous response information.</label></div>
        <br />&nbsp;<br />
        <div style="text-align: left;">
            <label data-bind="text: $parent.objLanguageLabels().lblWindowRecReview_Description" id="">You need to provide an updated response for this recommendation.  If the previous response is still applicable, click on the "OK" button, which will automatically update the Response Date for you.  If you need to revise, please click on the "Edit" button.</label>
        </div>
        <br />&nbsp;<br />
        <div style="text-align: center;">
            <button id="btnWindowRecReviewOK" class="k-button k-button-padding" style="width: 75px;" onclick="return false;" data-bind="text: $parent.objLanguageLabels().lblOK, click: $parent.onWindowRecReviewOK">OK</button>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <button id="btnWindowRecReviewCancel" class="k-button k-button-padding" style="width: 75px;" onclick="return false;" data-bind="text: $parent.objLanguageLabels().lblEdit, click: $parent.onWindowRecReviewCancel">Edit</button>
        </div>
        <br />
    </div>

    <!-- ERROR WINDOW FOR EDIT PREVIOUS RESPONSE -->
    <div id="windowRecEdit" class="windowContent">
        <div><img src="../../Home_{{VER}}/images/icons/reports/document_information_32x32.png" align="left" alt="Warning" class="windowImageSmallPadding" style="width: 32px; height: 32px;" /></div>
        <div><label data-bind="text: $parent.objLanguageLabels().lblWindowRecEdit_Message" id="">Please edit the previous response information.</label></div>
        <br />&nbsp;<br />
        <div style="text-align: left;">
            <label data-bind="text: $parent.objLanguageLabels().lblWindowRecEdit_Description" id="">The Expected Completion Date from the previous response has passed. Please click the "Edit" button and update the fields highlighted in yellow as applicable, then click the "Save" button.</label>
        </div>
        <br />&nbsp;<br />
        <div style="text-align: center;">
            <button id="btnWindowRecEditOK" class="k-button k-button-padding" style="width: 75px;" onclick="return false;" data-bind="text: $parent.objLanguageLabels().lblEdit, click: $parent.onWindowRecEditOK">Edit</button>
            <%--&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <button id="btnWindowRecEditCancel" class="k-button k-button-padding" style="width: 75px;" onclick="return false;" data-bind="text: $parent.objLanguageLabels().lblCancel, click: $parent.onWindowRecEditCancel">Cancel</button>--%>
        </div>
        <br />
    </div>

    <!-- ERROR WINDOW FOR CHECK RECENTLY SAVED INFORMATION -->
    <div id="windowRecRecentSave" class="windowContent">
        <div><img src="../../Home_{{VER}}/images/icons/reports/document_information_32x32.png" align="left" alt="Warning" class="windowImageSmallPadding" style="width: 32px; height: 32px;" /></div>
        <div><label data-bind="text: $parent.objLanguageLabels().lblWindowRecRecentSave_Message" id="">Please check your recently saved response information.</label></div>
        <br />&nbsp;<br />
        <div style="text-align: left;">
            <label data-bind="text: $parent.objLanguageLabels().lblWindowRecRecentSave_Description" id="">The Expected Completion Date from the previous response has passed.  Please check your information. If needed, click the "Edit" button and update the fields highlighted in yellow as applicable, then click the "Save" button.</label>
        </div>
        <br />&nbsp;<br />
        <div style="text-align: center;">
            <button id="btnWindowRecRecentSaveOK" class="k-button k-button-padding" style="width: 75px;" onclick="return false;" data-bind="text: $parent.objLanguageLabels().lblOK, click: $parent.onWindowRecRecentSaveOK">OK</button>
        </div>
        <br />
    </div>


</div>

<%--<div style="width: 987px; padding-top: 50px; padding-left: 0px; padding-right: 0px; padding-bottom: 0px; clear: both;"></div>--%>

<script type="text/javascript">
    $(document).ready(function () {
        ///////////////////////////////////////////
        //// LOAD LANGUAGE VARIABLES
        var dsLanguageLabels = {};

        var dsLanguageOptions = [
            dsLanguageLabels.lblChooseLanguage,
            "Deutsch",
            "English",
            "Español",
            "Français",
            "Italiano",
            "Português"
        ];

        var objCancel = {
            RecYear: "",
            RecMonth: "",
            RecNumber: "",
            Impact: "",
            RecStatus: "", //widgetRecStatusPlaceHolder
            StatusDate: "",
            RecStatus: "",
            //RecPrimary: "",
            //RecSecondary: "",
            //Recommendation: "",
            //LossExpectancyBefore: "",
            //LossExpectancyAfter: "",
            //CostToComplete: "",
            //SavingsRatio: "",
            //ActualCostToComplete: "",
            ResponseDate: "",
            ResponseFrom: "",
            IntendedAction: "",
            ExpectedCompletionDate: "",
            PlantComment: "",
            MgmtRespDate: "",
            MgmtRespFrom: "",
            ExpectedCompletionDateManager: "",
            MgmtRespComment: "",
            ThirdLevelRespDate: "",
            ThirdLevelRespAction: "",
            ThirdLevelRespFrom: "",
            ThirdLevelRespComment: ""
        };


        ///////////////////////////////////////////
        //// VIEWMODELS
        var viewFindCriteria = {
            findCriteria: ko.observable()
        };
        var viewMaster = {
            objLanguageLabels: ko.observable(dsLanguageLabels),
            KOLanguageSelector: ko.observableArray(dsLanguageOptions),
            objLanguageSelector: ko.observable(),
            clientFeatures: ko.observable("<%= ServerSide_ClientFeatures %>"),
            onCloseLanguageSelector: function () {
                //// UPDATE DSLANGUAGELABELS
                switch (viewMaster.objLanguageSelector().toLowerCase()) {
                    case dsLanguageLabels.lblChooseLanguage:
                        view.loadLabelTranslations("english");
                        view.preferenceLanguage = "english";
                        break;
                    case "deutsch":
                        view.loadLabelTranslations("german");
                        view.preferenceLanguage = "german";
                        break;
                    case "english":
                        view.loadLabelTranslations("english");
                        view.preferenceLanguage = "english";
                        break;
                    case "español":
                        view.loadLabelTranslations("spanish");
                        view.preferenceLanguage = "spanish";
                        break;
                    case "français":
                        view.loadLabelTranslations("french");
                        view.preferenceLanguage = "french";
                        break;
                    case "italiano":
                        view.loadLabelTranslations("italian");
                        view.preferenceLanguage = "italian";
                        break;
                    case "português":
                        view.loadLabelTranslations("portuguese");
                        view.preferenceLanguage = "portuguese";
                        break;
                    default:
                        //// DO NOTHING, THE USER DOES NOT WANT TO MAKE A CHANGE
                        break;
                }
                view.loadPickers();
                view.resetPickers();
                view.setupButtons();
                view.saveLanguageSelection();

                //// MANUALLY RESET THE LANGUAGE USED ON MASTER PAGE POPUPS AND LOCAL POPUP TITLES
                $("#lblWindowResponded_Warning").html(viewMaster.objLanguageLabels().lblWindowResponded_Warning);
                $("#lblWindowResponded_AreYouSure").html(viewMaster.objLanguageLabels().lblWindowResponded_AreYouSure);
                $("#lblWindowResponded_ClickCancelToContinueWorking").html(viewMaster.objLanguageLabels().lblWindowResponded_ClickCancelToContinueWorking);
                $("#lblWindowResponded_ClickOKToExit").html(viewMaster.objLanguageLabels().lblWindowResponded_ClickOKToExit);
                $("#btnYes").html(viewMaster.objLanguageLabels().lblOK);
                $("#btnCancel").html(viewMaster.objLanguageLabels().lblCancel);
                $("#windowRecNotCompleted").prev().find(".k-window-title").html("<img src='../../Home_{{VER}}/images/icons/reports/document_information_24x24.png' align='left' alt='Information Icon' class='windowIcon'/>  " + viewMaster.objLanguageLabels().lblWindowResponded_Title);

                $("#lblWindowRespondedDatasheet_Warning").html(viewMaster.objLanguageLabels().lblWindowResponded_Warning);
                $("#lblWindowRespondedDatasheet_AreYouSure").html(viewMaster.objLanguageLabels().lblWindowResponded_AreYouSure);
                $("#lblWindowRespondedDatasheet_ClickCancelToContinueWorking").html(viewMaster.objLanguageLabels().lblWindowResponded_ClickCancelToContinueWorking);
                $("#lblWindowRespondedDatasheet_ClickOKToExit").html(viewMaster.objLanguageLabels().lblWindowResponded_ClickOKToExit);
                $("#btnYesDatasheet").html(viewMaster.objLanguageLabels().lblOK);
                $("#btnCancelDatasheet").html(viewMaster.objLanguageLabels().lblCancel);
                $("#windowRecNotCompletedDatasheet").prev().find(".k-window-title").html("<img src='../../Home_{{VER}}/images/icons/reports/document_information_24x24.png' align='left' alt='Information Icon' class='windowIcon'/>  " + viewMaster.objLanguageLabels().lblWindowResponded_Title);

                $("#windowRecReview").prev().find(".k-window-title").html("<img src='../../Home_{{VER}}/images/icons/reports/document_information_24x24.png' align='left' alt='Information Icon' class='windowIcon'/>  " + view.objLanguageLabels().lblWindowRecReview_Title);
                $("#windowRecEdit").prev().find(".k-window-title").html("<img src='../../Home_{{VER}}/images/icons/reports/document_information_24x24.png' align='left' alt='Information Icon' class='windowIcon'/>  " + view.objLanguageLabels().lblWindowRecEdit_Title);
                $("#windowRecRecentSave").prev().find(".k-window-title").html("<img src='../../Home_{{VER}}/images/icons/reports/document_information_24x24.png' align='left' alt='Information Icon' class='windowIcon'/>  " + view.objLanguageLabels().lblWindowRecRecentSave_Title);

            }
        };

        // GLOBAL VARIABLES
        gRecId = null;

        var view = {
            //// DECLARATIONS
            index: 0,
            enablePrev: ko.observable(true),
            enableNext: ko.observable(true),
            enableFilePrev: ko.observable(true),
            enableFileNext: ko.observable(true),
            enablePickers: ko.observable(false),
            enableDelete: ko.observable(false),
            enableAdminFields: ko.observable(false),
            enableAlwaysOff: ko.observable(false),
            enableNoLocationFound: ko.observable(true),
            messageError: ko.observable(),
            messageWarning: ko.observable(),
            messageNotice: ko.observable(),
            messageSave: ko.observable(),
            messageValidation: ko.observable(),
            fileDirection: ko.observable(""),
            findEngaged: ko.observable(true),
            editState: ko.observable(false),
            adminUser: false,
            stateListingLoadOneRecord: true,   // THIS WILL ONLY WORK WITH TWO STATE SERVER SIDE LOAD LOGIC
            stateDetailsLoadOneRecord: true,  // THIS WILL ONLY WORK WITH TWO STATE SERVER SIDE LOAD LOGIC
            stateOnlyOneDetailRecordLoaded: true,
            stateLoadError: false,
            stateOnlyLoadDetails: false,
            pageRequestedFrom: getQueryVariable("req"),

            //// COLLECTIONS / OBJECTS
            //// CHANGE THE NAME OF THE ES.OBJECTS PROTOTYPE
            gSafeGuid: "none",
            fullName: "<%= ServerSide_FullName %>",
            emailAddress: "<%= ServerSide_EmailAddress %>",
            enableMgmtFields: ko.observable(global_MgmtFields),
            fileNo: "<%= ServerSide_FileNo %>",
            clientFeatures: ko.observable("<%= ServerSide_ClientFeatures %>"),
            ToIRReport: ko.observable("<%= ServerSide_ToIRReport %>"),
            ToIRDiagram: ko.observable("<%= ServerSide_ToIRDiagram %>"),
            cldbName: "<%= ServerSide_cldbName %>",
            preferenceLanguage: "<%= ServerSide_LanguagePreference %>",
            RRLogGuid: "<%= ServerSide_RRLogGuid %>",
            currencyName: ko.observable("<%= ServerSide_CurrencyName %>"),
            collRec: new es.objects.FindingsCollection(),
            collListing: new es.objects.ViewCCLocationListingRecResponseIRCollection(),
            collCounts: new es.objects.ViewCCIRRecommendationCountsCollection(),
            collRRLog: new es.objects.RRLogCollection(),
            countsNeeded: ko.observable(),
            countsCompleted: ko.observable(),
            previouslyWarnedReview: false,
            previouslyWarnedEdit: false,
            recentlySaved: false,
            ignorePopups: false,
            intendedAction: "",

            collLossafter: new es.objects.ViewCCRecCompletedLossEstListCollection(), //LEText
            collLossbefore: new es.objects.ViewCCRecCurrentLossEstListCollection(), //LEText
            collCosttocomplete: new es.objects.ViewCCRecEstCostToCompleteListCollection(), //LEText

            collImpactList: new es.objects.ViewCCTranslationImpactCollection(), //CategoryText
            collIntendedaction: new es.objects.ViewCCTranslationIntendedActionCollection(), //IntendedActionText
            collIntendedactionMgmt: new es.objects.ViewCCTranslationMgmtIntendedActionCollection(), //IntendedActionText
            collStatuslist: new es.objects.ViewCCTranslationRecStatusCollection(), //StatusText
            collRecPrimary: new es.objects.ViewCCTranslationPrimaryRecCollection(), //PrimaryType THIS IS TWO COLUMN WITH Hazard AS KEY
            collRecSecondary: new es.objects.ViewCCTranslationSecondaryRecCollection(), //SecondaryType THIS IS TWO COLUMN WITH PrimaryType AS KEY

            KOcollLossafter: ko.observableArray(),
            KOcollLossbefore: ko.observableArray(),
            KOcollCosttocomplete: ko.observableArray(),
            KOcollImpactList: ko.observableArray(),
            KOcollIntendedaction: ko.observableArray(),
			KOcollIntendedactionMgmt: ko.observableArray(),
			KOcollIntendedactionThirdLvl: ko.observableArray(["Agree", "Disagree", "Under Review"]),
            KOcollRecPrimary: ko.observableArray(),
            KOcollRecSecondary: ko.observableArray(),
            KOcollStatuslist: ko.observableArray(),

            widgetImpact: ko.observable(),
            widgetRecStatus: ko.observable(),
            widgetRecPrimary: ko.observable(),
            widgetRecSecondary: ko.observable(),
            widgetLossExpectancyBefore: ko.observable(),
            widgetLossExpectancyAfter: ko.observable(),
            widgetCostToComplete: ko.observable(),
            widgetIntendedAction: ko.observable(),
			widgetIntendedActionMgmt: ko.observable(),

            widgetImpactPlaceHolder: ko.observable(),
            widgetRecStatusPlaceHolder: ko.observable(),
            widgetIntendedActionPlaceHolder: ko.observable(),
			widgetIntendedActionPlaceHolderMgmt: ko.observable(),
            widgetLossExpectancyBeforePlaceHolder: ko.observable(),
            widgetLossExpectancyAfterPlaceHolder: ko.observable(),
            widgetCostToCompletePlaceHolder: ko.observable(),
            widgetIntendedActionThirdLevel: ko.observable(),




            objRec: ko.observable(),
            objListing: ko.observable(),
            objRRLog: ko.observable(),
            objLanguageLabels: ko.observable(dsLanguageLabels),
            objFind: ko.observable(),

            //// MISC
            txtRecordNumber: ko.observable(),
            txtFileRecordNumber: ko.observable(),
            txtSchedulingComments: ko.observable(),
            txtEditSave: ko.observable(),
            txtCancelDelete: ko.observable(),
            colorEdit: ko.observable("#FFFF99"),
            colorNoEdit: ko.observable("#FFFFFF"),
            loading: ko.observable(false),
            invalidNumbers: " ABCDEFGHIJKLMNOPQRSTUVWXYZ!@#$%^&*()`-=[]\\,./;'~_+{}|<>?:\"",
            invalidLetters: " !@#$%^&*()`-=[]\\,./;'~_+{}|<>?:\"",

            //// LOAD ALL LIST INFORMATION FROM THE DB
            loadPickers: function () {
                //// LOAD LISTS
                var tempArray = new Array();
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collLossafter.loadAll()) {
                    for (i = 0; i < view.collLossafter().length; i++) {
                        tempArray.push(view.collLossafter()[i].LEText());
                    }
                    view.KOcollLossafter(tempArray);
                } else {
                    view.messageError("* Error while loading Loss After Data List.");
                }

                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collLossbefore.loadAll()) {
                    tempArray = new Array();
                    for (i = 0; i < view.collLossbefore().length; i++) {
                        tempArray.push(view.collLossbefore()[i].LEText());
                    }
                    view.KOcollLossbefore(tempArray);
                } else {
                    view.messageError("* Error while loading Loss Before Data List.");
                }

                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collCosttocomplete.loadAll()) {
                    tempArray = new Array();
                    for (i = 0; i < view.collCosttocomplete().length; i++) {
                        tempArray.push(view.collCosttocomplete()[i].LEText());
                    }
                    view.KOcollCosttocomplete(tempArray);
                } else {
                    view.messageError("* Error while loading Cost To Complete Data List.");
                }

                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collImpactList.GetImpactTranslationByLanguage(view.preferenceLanguage)) {
                    tempArray = new Array();
                    for (i = 0; i < view.collImpactList().length; i++) {
                        //tempArray.push(view.collImpactList()[i].CategoryText());
                        switch (view.preferenceLanguage.toLowerCase()) {
                            case "german": tempArray.push(view.collImpactList()[i].GermanTranslation()); break;
                            case "spanish": tempArray.push(view.collImpactList()[i].SpanishTranslation()); break;
                            case "french": tempArray.push(view.collImpactList()[i].FrenchTranslation()); break;
                            case "italian": tempArray.push(view.collImpactList()[i].ItalianTranslation()); break;
                            case "portuguese": tempArray.push(view.collImpactList()[i].PortugueseTranslation()); break;
                            default: tempArray.push(view.collImpactList()[i].EnglishTranslation()); break;
                        }
                    }
                    view.KOcollImpactList(tempArray);
                } else {
                    view.messageError("* Error while loading Impact Data List.");
                }

                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collIntendedaction.GetIntendedActionTranslationByLanguage(view.preferenceLanguage)) {
                    tempArray = new Array();
                    for (i = 0; i < view.collIntendedaction().length; i++) {
                        //tempArray.push(view.collIntendedaction()[i].IntendedActionText());
                        switch (view.preferenceLanguage.toLowerCase()) {
                            case "german": tempArray.push(view.collIntendedaction()[i].GermanTranslation()); break;
                            case "spanish": tempArray.push(view.collIntendedaction()[i].SpanishTranslation()); break;
                            case "french": tempArray.push(view.collIntendedaction()[i].FrenchTranslation()); break;
                            case "italian": tempArray.push(view.collIntendedaction()[i].ItalianTranslation()); break;
                            case "portuguese": tempArray.push(view.collIntendedaction()[i].PortugueseTranslation()); break;
                            default: tempArray.push(view.collIntendedaction()[i].EnglishTranslation()); break;
                        }
                    }
                    view.KOcollIntendedaction(tempArray);
                } else {
                    view.messageError("* Error while loading Intended Action Data List.");
                }

                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collIntendedactionMgmt.GetIntendedActionMgmtTranslationByLanguageFilePrefix(view.preferenceLanguage + "|" + view.fileNo)) {
                    tempArray = new Array();
                    for (i = 0; i < view.collIntendedactionMgmt().length; i++) {
                        //tempArray.push(view.collIntendedaction()[i].IntendedActionText());
                        switch (view.preferenceLanguage.toLowerCase()) {
                            case "german": tempArray.push(view.collIntendedactionMgmt()[i].GermanTranslation()); break;
                            case "spanish": tempArray.push(view.collIntendedactionMgmt()[i].SpanishTranslation()); break;
                            case "french": tempArray.push(view.collIntendedactionMgmt()[i].FrenchTranslation()); break;
                            case "italian": tempArray.push(view.collIntendedactionMgmt()[i].ItalianTranslation()); break;
                            case "portuguese": tempArray.push(view.collIntendedactionMgmt()[i].PortugueseTranslation()); break;
                            default: tempArray.push(view.collIntendedactionMgmt()[i].EnglishTranslation()); break;
                        }
                    }
                    view.KOcollIntendedactionMgmt(tempArray);
                } else {
                    view.messageError("* Error while loading Intended Action Data List.");
                }

                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collStatuslist.GetRecStatusTranslationByLanguage(view.preferenceLanguage)) {
                    tempArray = new Array();
                    for (i = 0; i < view.collStatuslist().length; i++) {
                        //tempArray.push(view.collStatuslist()[i].StatusText());
                        switch (view.preferenceLanguage.toLowerCase()) {
                            case "german": tempArray.push(view.collStatuslist()[i].GermanTranslation()); break;
                            case "spanish": tempArray.push(view.collStatuslist()[i].SpanishTranslation()); break;
                            case "french": tempArray.push(view.collStatuslist()[i].FrenchTranslation()); break;
                            case "italian": tempArray.push(view.collStatuslist()[i].ItalianTranslation()); break;
                            case "portuguese": tempArray.push(view.collStatuslist()[i].PortugueseTranslation()); break;
                            default: tempArray.push(view.collStatuslist()[i].EnglishTranslation()); break;
                        }
                    }
                    view.KOcollStatuslist(tempArray);
                } else {
                    view.messageError("* Error while loading Status Data List.");
                }

                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collRecPrimary.GetPrimaryRecTranslationByLanguage(view.preferenceLanguage + "|" + "Infrared")) {
                    tempArray = new Array();
                    for (i = 0; i < view.collRecPrimary().length; i++) {
                        //if (view.collRecPrimary()[i].Hazard() == "Infrared") {
                        //    tempArray.push(view.collRecPrimary()[i].PrimaryType());
                        //}
                        switch (view.preferenceLanguage.toLowerCase()) {
                            case "german": tempArray.push(view.collRecPrimary()[i].GermanTranslation()); break;
                            case "spanish": tempArray.push(view.collRecPrimary()[i].SpanishTranslation()); break;
                            case "french": tempArray.push(view.collRecPrimary()[i].FrenchTranslation()); break;
                            case "italian": tempArray.push(view.collRecPrimary()[i].ItalianTranslation()); break;
                            case "portuguese": tempArray.push(view.collRecPrimary()[i].PortugueseTranslation()); break;
                            default: tempArray.push(view.collRecPrimary()[i].EnglishTranslation()); break;
                        }
                    }
                    view.KOcollRecPrimary(tempArray);
                } else {
                    view.messageError("* Error while loading Primary Rec. Type Data List.");
                }

                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collRecSecondary.GetSecondaryRecTranslationByLanguage(view.preferenceLanguage + "|" + "Infrared")) {
                    /////////////////////// SecondaryType THIS IS TWO COLUMN WITH PrimaryType AS KEY
                    tempArray = new Array();
                    for (i = 0; i < view.collRecSecondary().length; i++) {
                        if (view.collRecSecondary()[i].PrimaryType() == view.objRec().RecPrimary()) {
                            //tempArray.push(view.collRecSecondary()[i].SecondarType());
                            switch (view.preferenceLanguage.toLowerCase()) {
                                case "german": tempArray.push(view.collRecSecondary()[i].GermanTranslation()); break;
                                case "spanish": tempArray.push(view.collRecSecondary()[i].SpanishTranslation()); break;
                                case "french": tempArray.push(view.collRecSecondary()[i].FrenchTranslation()); break;
                                case "italian": tempArray.push(view.collRecSecondary()[i].ItalianTranslation()); break;
                                case "portuguese": tempArray.push(view.collRecSecondary()[i].PortugueseTranslation()); break;
                                default: tempArray.push(view.collRecSecondary()[i].EnglishTranslation()); break;
                            }
                        }
                    }
                    view.KOcollRecSecondary(tempArray);
                } else {
                    view.messageError("* Error while loading Secondary Rec. Type Data List.");
                }
            },

            buildRecSecondary: function () {
                var tempArray2 = new Array();
                for (i = 0; i < view.collRecSecondary().length; i++) {
                    if (view.collRecSecondary()[i].PrimaryType() == view.objRec().RecPrimary()) {
                        //tempArray2.push(view.collRecSecondary()[i].SecondarType());
                        switch (view.preferenceLanguage.toLowerCase()) {
                            case "german": tempArray.push(view.collRecSecondary()[i].GermanTranslation()); break;
                            case "spanish": tempArray.push(view.collRecSecondary()[i].SpanishTranslation()); break;
                            case "french": tempArray.push(view.collRecSecondary()[i].FrenchTranslation()); break;
                            case "italian": tempArray.push(view.collRecSecondary()[i].ItalianTranslation()); break;
                            case "portuguese": tempArray.push(view.collRecSecondary()[i].PortugueseTranslation()); break;
                            default: tempArray.push(view.collRecSecondary()[i].EnglishTranslation()); break;
                        }
                    }
                }
                view.KOcollRecSecondary(tempArray2);
            },

            onBuildLink: function (fileName) {
                //buildFileOpenLink(fileName, view.gSafeGuid, "", "", false);
                buildFileOpenLink(fileName, "|none|" + view.cldbName, "", "", false); //// NEED TO ADD TO SERVIT.ASPX TO NOT USE GSAFE IN THIS CASE
            },

            //// BUTTONS FOR RECORD NAVIGATION
            onNext: function () {
                //if (view.isResponseValid("onNext")) {
                view.intendedAction = "";
                if (view.stateOnlyOneDetailRecordLoaded) {
                    view.loadDetailsOnly();
                }
                if (view.index < view.collRec().length - 1) {
                    view.index++;
                    view.objRec(view.collRec()[view.index]);
                }
                view.setupButtons();
                view.ignorePopups = false;
                view.resetPickers();
                view.messageSave("");
                view.messageValidation("");
                //}
            },

            onPrevious: function () {
                //if (view.isResponseValid("onPrevious")) {
                view.intendedAction = "";
                if (view.index > 0) {
                    view.index--;
                    view.objRec(view.collRec()[view.index]);
                }
                view.setupButtons();
                view.ignorePopups = false;
                view.resetPickers();
                view.messageSave("");
                view.messageValidation("");
                //}
            },

            onFirst: function () {
                //if (view.isResponseValid("onFirst")) {
                view.intendedAction = "";
                if (view.index > 0) {
                    view.index = 0;
                    view.objRec(view.collRec()[view.index]);
                }
                view.setupButtons();
                view.ignorePopups = false;
                view.resetPickers();
                view.messageSave("");
                view.messageValidation("");
                //}
            },

            onLast: function () {
                //if (view.isResponseValid("onLast")) {
                view.intendedAction = "";
                if (view.stateOnlyOneDetailRecordLoaded) {
                    view.loadDetailsOnly();
                }
                if (view.index < view.collRec().length - 1) {
                    view.index = view.collRec().length - 1;
                    view.objRec(view.collRec()[view.index]);
                }
                view.setupButtons();
                view.ignorePopups = false;
                view.resetPickers();
                view.messageSave("");
                view.messageValidation("");
                //}
            },

            //// BUTTONS FOR FILE NUMBER / LOCATION WALK
            onFileFirst: function () {
                //if (view.isResponseValid("onFileFirst")) {
                view.intendedAction = "";
                view.fileDirection("first");
                view.index = 0;
                view.stateDetailsLoadOneRecord = true;
                view.loadOneFileNumber(); //view.loadFileNumber();
                view.fileDirection("");
                view.ignorePopups = false;
                view.resetPickers();
                view.messageSave("");
                view.messageValidation("");
                //}
            },

            onFilePrevious: function () {
                //if (view.isResponseValid("onFilePrevious")) {
                view.intendedAction = "";
                view.fileDirection("previous");
                view.index = 0;
                view.stateDetailsLoadOneRecord = true;
                view.loadOneFileNumber(); //view.loadFileNumber();
                view.fileDirection("");
                view.ignorePopups = false;
                view.resetPickers();
                view.messageSave("");
                view.messageValidation("");
                //}
            },

            onFileNext: function () {
                //if (view.isResponseValid("onFileNext")) {
                view.intendedAction = "";
                view.fileDirection("next");
                view.index = 0;
                view.stateDetailsLoadOneRecord = true;
                view.loadOneFileNumber(); //view.loadFileNumber();
                view.fileDirection("");
                view.ignorePopups = false;
                view.resetPickers();
                view.messageSave("");
                view.messageValidation("");
                //}
            },

            onFileLast: function () {
                //if (view.isResponseValid("onFileLast")) {
                view.intendedAction = "";
                view.fileDirection("last");
                view.index = 0;
                view.stateDetailsLoadOneRecord = true;
                view.loadOneFileNumber(); //view.loadFileNumber();
                view.fileDirection("");
                view.ignorePopups = false;
                view.resetPickers();
                view.messageSave("");
                view.messageValidation("");
                //}
            },

            onDatasheetView: function () {
                //// BUILD URL AND GO TO DATASHEET VIEW
                view.intendedAction = "";
                var tempURL = "";
                if (view.clientFeatures().search('L') > -1) {
                    tempURL = "recdatasheet.aspx?f1=" + view.fileNo + "&rec=" + view.index;
                } else {
                    tempURL = "recdatasheet.aspx?f1=" + view.fileNo + "&rec=" + view.index;
                }
                global_DatasheetViewURL = tempURL;
                goToDataSheetView(tempURL);
            },

            //// ENABLE OR DISABLE BUTTONS AND SHOW RECORD NUMBER
            setupButtons: function () {
                if (view.index == 0) { view.enablePrev(false); } else { view.enablePrev(true); }
                if (view.index == view.collRec().length - 1) { view.enableNext(false); } else { view.enableNext(true); }
                if (view.stateOnlyOneDetailRecordLoaded == true) { view.enableNext(true); }
                if (!view.editState()) {
                    view.txtEditSave(view.objLanguageLabels().lblEdit);
                    view.txtCancelDelete(view.objLanguageLabels().lblDelete);
                    $("#editSave").removeClass("messageRedBold");
                } else {
                    view.txtEditSave(view.objLanguageLabels().lblSave);
                    view.txtCancelDelete(view.objLanguageLabels().lblCancel);
                    $("#editSave").addClass("messageRedBold");
                    view.enablePrev(false);
                    view.enableNext(false);
                }
                if (!view.adminUser) {
                    view.enableDelete(false);
                } else {
                    view.enableDelete(true);
                }
                if (view.stateOnlyOneDetailRecordLoaded) {
                    view.txtRecordNumber("1...");
                } else {
                    view.txtRecordNumber((parseInt(view.index) + 1) + " of " + view.collRec().length);
                }
            },


            //// RESET FIELDS ON LOAD RECORD
            resetPickers: function () {
                //// COPY THE FIND FIELDS
                view.buildRecSecondary();
                if (view.objRec().StatusDate() == undefined) { StatusDate.value(""); } else { StatusDate.value(view.objRec().StatusDate()); }
                if (view.objRec().ResponseDate() == undefined) { ResponseDate.value(""); } else { ResponseDate.value(view.objRec().ResponseDate()); }
                if (view.objRec().ExpectedCompletionDate() == undefined) { ExpectedCompletionDate.value(""); } else { ExpectedCompletionDate.value(view.objRec().ExpectedCompletionDate()); }

                for (y = 0; y < view.collImpactList().length; y++) {
                    if (view.collImpactList()[y].EnglishTranslation().toLowerCase() == view.objRec().Impact().toLowerCase()) {
                        switch (view.preferenceLanguage.toLowerCase()) {
                            case "german": view.widgetImpact().value(view.collImpactList()[y].GermanTranslation()); view.widgetImpactPlaceHolder(view.collImpactList()[y].GermanTranslation()); break;
                            case "spanish": view.widgetImpact().value(view.collImpactList()[y].SpanishTranslation()); view.widgetImpactPlaceHolder(view.collImpactList()[y].SpanishTranslation()); break;
                            case "french": view.widgetImpact().value(view.collImpactList()[y].FrenchTranslation()); view.widgetImpactPlaceHolder(view.collImpactList()[y].FrenchTranslation()); break;
                            case "italian": view.widgetImpact().value(view.collImpactList()[y].ItalianTranslation()); view.widgetImpactPlaceHolder(view.collImpactList()[y].ItalianTranslation()); break;
                            case "portuguese": view.widgetImpact().value(view.collImpactList()[y].PortugueseTranslation()); view.widgetImpactPlaceHolder(view.collImpactList()[y].PortugueseTranslation()); break;
                            default: view.widgetImpact().value(view.collImpactList()[y].EnglishTranslation()); view.widgetImpactPlaceHolder(view.collImpactList()[y].EnglishTranslation()); break;
                        }
                    }
                }
                for (y = 0; y < view.collStatuslist().length; y++) {
                    if (view.collStatuslist()[y].EnglishTranslation().toLowerCase() == view.objRec().RecStatus().toLowerCase()) {
                        switch (view.preferenceLanguage.toLowerCase()) {
                            case "german": view.widgetRecStatus().value(view.collStatuslist()[y].GermanTranslation()); view.widgetRecStatusPlaceHolder(view.collStatuslist()[y].GermanTranslation()); break;
                            case "spanish": view.widgetRecStatus().value(view.collStatuslist()[y].SpanishTranslation()); view.widgetRecStatusPlaceHolder(view.collStatuslist()[y].SpanishTranslation()); break;
                            case "french": view.widgetRecStatus().value(view.collStatuslist()[y].FrenchTranslation()); view.widgetRecStatusPlaceHolder(view.collStatuslist()[y].FrenchTranslation()); break;
                            case "italian": view.widgetRecStatus().value(view.collStatuslist()[y].ItalianTranslation()); view.widgetRecStatusPlaceHolder(view.collStatuslist()[y].ItalianTranslation()); break;
                            case "portuguese": view.widgetRecStatus().value(view.collStatuslist()[y].PortugueseTranslation()); view.widgetRecStatusPlaceHolder(view.collStatuslist()[y].PortugueseTranslation()); break;
                            default: view.widgetRecStatus().value(view.collStatuslist()[y].EnglishTranslation()); view.widgetRecStatusPlaceHolder(view.collStatuslist()[y].EnglishTranslation()); break;
                        }
                    }
                }
                for (y = 0; y < view.collIntendedaction().length; y++) {
                    if (view.collIntendedaction()[y].EnglishTranslation().toLowerCase() == view.objRec().IntendedAction().toLowerCase()) {
                        switch (view.preferenceLanguage.toLowerCase()) {
                            case "german": view.widgetIntendedAction().value(view.collIntendedaction()[y].GermanTranslation()); view.widgetIntendedActionPlaceHolder(view.collIntendedaction()[y].GermanTranslation()); break;
                            case "spanish": view.widgetIntendedAction().value(view.collIntendedaction()[y].SpanishTranslation()); view.widgetIntendedActionPlaceHolder(view.collIntendedaction()[y].SpanishTranslation()); break;
                            case "french": view.widgetIntendedAction().value(view.collIntendedaction()[y].FrenchTranslation()); view.widgetIntendedActionPlaceHolder(view.collIntendedaction()[y].FrenchTranslation()); break;
                            case "italian": view.widgetIntendedAction().value(view.collIntendedaction()[y].ItalianTranslation()); view.widgetIntendedActionPlaceHolder(view.collIntendedaction()[y].ItalianTranslation()); break;
                            case "portuguese": view.widgetIntendedAction().value(view.collIntendedaction()[y].PortugueseTranslation()); view.widgetIntendedActionPlaceHolder(view.collIntendedaction()[y].PortugueseTranslation()); break;
                            default: view.widgetIntendedAction().value(view.collIntendedaction()[y].EnglishTranslation()); view.widgetIntendedActionPlaceHolder(view.collIntendedaction()[y].EnglishTranslation()); break;
                        }
                    }
                }

                if ($.inArray('\+', view.clientFeatures()) > -1) {
                    if (view.objRec().MgmtRespDate() == undefined) {
                        MgmtRespDate.value("");
                    } else {
                        MgmtRespDate.value(view.objRec().MgmtRespDate());
                    }
                }

                if ($.inArray('\+', view.clientFeatures()) > -1) {
                    if (view.objRec().MgmtRespAction() == undefined) {
                        view.widgetIntendedActionMgmt().value(""); view.widgetIntendedActionPlaceHolderMgmt("");
                    } else {
                        for (y = 0; y < view.collIntendedactionMgmt().length; y++) {
                            if (view.collIntendedactionMgmt()[y].EnglishTranslation().toLowerCase() == view.objRec().MgmtRespAction().toLowerCase()) {
                                switch (view.preferenceLanguage.toLowerCase()) {
                                    case "german": view.widgetIntendedActionMgmt().value(view.collIntendedactionMgmt()[y].GermanTranslation()); view.widgetIntendedActionPlaceHolderMgmt(view.collIntendedactionMgmt()[y].GermanTranslation()); break;
                                    case "spanish": view.widgetIntendedActionMgmt().value(view.collIntendedactionMgmt()[y].SpanishTranslation()); view.widgetIntendedActionPlaceHolderMgmt(view.collIntendedactionMgmt()[y].SpanishTranslation()); break;
                                    case "french": view.widgetIntendedActionMgmt().value(view.collIntendedactionMgmt()[y].FrenchTranslation()); view.widgetIntendedActionPlaceHolderMgmt(view.collIntendedactionMgmt()[y].FrenchTranslation()); break;
                                    case "italian": view.widgetIntendedActionMgmt().value(view.collIntendedactionMgmt()[y].ItalianTranslation()); view.widgetIntendedActionPlaceHolderMgmt(view.collIntendedactionMgmt()[y].ItalianTranslation()); break;
                                    case "portuguese": view.widgetIntendedActionMgmt().value(view.collIntendedactionMgmt()[y].PortugueseTranslation()); view.widgetIntendedActionPlaceHolderMgmt(view.collIntendedactionMgmt()[y].PortugueseTranslation()); break;
                                    default: view.widgetIntendedActionMgmt().value(view.collIntendedactionMgmt()[y].EnglishTranslation()); view.widgetIntendedActionPlaceHolderMgmt(view.collIntendedactionMgmt()[y].EnglishTranslation()); break;
                                }
                            }
                        }
                    }
                }
                if (view.clientFeatures().search("!") > -1) {
                    if (view.objRec().ThirdLevelRespDate() == undefined) { lvl3RespDate.value(""); } else { lvl3RespDate.value(view.objRec().ThirdLevelRespDate()); }
                }
                for (y = 0; y < view.collRecPrimary().length; y++) {
                    if (view.collRecPrimary()[y].EnglishTranslation().toLowerCase() == view.objRec().RecPrimary().toLowerCase()) {
                        switch (view.preferenceLanguage.toLowerCase()) {
                            case "german": view.widgetRecPrimary(view.collRecPrimary()[y].GermanTranslation()); break;
                            case "spanish": view.widgetRecPrimary(view.collRecPrimary()[y].SpanishTranslation()); break;
                            case "french": view.widgetRecPrimary(view.collRecPrimary()[y].FrenchTranslation()); break;
                            case "italian": view.widgetRecPrimary(view.collRecPrimary()[y].ItalianTranslation()); break;
                            case "portuguese": view.widgetRecPrimary(view.collRecPrimary()[y].PortugueseTranslation()); break;
                            default: view.widgetRecPrimary(view.collRecPrimary()[y].EnglishTranslation()); break;
                        }
                    }
                }
                for (y = 0; y < view.collRecSecondary().length; y++) {
                    if (view.collRecSecondary()[y].EnglishTranslation().toLowerCase() == view.objRec().RecSecondary().toLowerCase()) {
                        switch (view.preferenceLanguage.toLowerCase()) {
                            case "german": view.widgetRecSecondary(view.collRecSecondary()[y].GermanTranslation()); break;
                            case "spanish": view.widgetRecSecondary(view.collRecSecondary()[y].SpanishTranslation()); break;
                            case "french": view.widgetRecSecondary(view.collRecSecondary()[y].FrenchTranslation()); break;
                            case "italian": view.widgetRecSecondary(view.collRecSecondary()[y].ItalianTranslation()); break;
                            case "portuguese": view.widgetRecSecondary(view.collRecSecondary()[y].PortugueseTranslation()); break;
                            default: view.widgetRecSecondary(view.collRecSecondary()[y].EnglishTranslation()); break;
                        }
                    }
                }

                //// CHANGE COLORS OF THE COUNTS
                if (view.countsNeeded() < 1) {
                    $("#recCountNeeded").removeClass("recResponse_HeaderNumberRed");
                    $("#recCountNeeded").addClass("recResponse_HeaderNumber");
                } else {
                    $("#recCountNeeded").removeClass("recResponse_HeaderNumber");
                    $("#recCountNeeded").addClass("recResponse_HeaderNumberRed");
                    /* ADD RED BACKGROUND TO RESPONSE DATE FIELD IF RESPONSE IS NEEDED */
                    if (view.objRec().ResponseDate() == null || view.objRec().ResponseDate() < view.objRec().StatusDate()) {
                        if (view.objRec().RecStatus() != 'Removed' && view.objRec().RecStatus() != 'Rptd Completed' && view.objRec().RecStatus() != 'Conf Completed') {
                            $('#ResponseDate').addClass('expiredDate');
                        } else {
                            $('#ResponseDate').removeClass('expiredDate');
                        }
                    } else {
                        $('#ResponseDate').removeClass('expiredDate');
                    }
                }

                //// DISPLAY WINDOW IF NO RECORD EXISTS OR A MESSAGE IF NO SEARCH FOUND

                view.enableNoLocationFound(true);
                if ((view.objRec().FileNo() == "Not Found" && view.pageRequestedFrom == "topnav") || (view.objListing().FileNo() == "Not Found" && view.pageRequestedFrom == "topnav")) {
                    view.enableNoLocationFound(false);
                    view.messageError(view.objLanguageLabels().lblNoActiveLocations);
                    view.clearPickers();
                    view.clearAddressFields();
                } else if (view.objRec().FileNo() == "Not Found") {
                    view.enableNoLocationFound(false);
                    //                    windowNoLocation.data("kendoWindow").open();
                    //                    $("#windowNoLocation").css("display", "block");
                    view.clearPickers();
                } else if (view.objListing().FileNo() == "Not Found") {
                    view.enableNoLocationFound(false);
                    view.enableNext(false);
                    view.enablePrev(false);
                    view.messageError(view.objLanguageLabels().lblSearchNotFound);
                    view.clearPickers();
                }

                //// CHECK TO SEE IF RECENTLY SAVED INFORMATION IS ACURATE AND CLEAR POPUP STATES
                if (!view.ignorePopups) { view.isResponseValid("resetpickers"); }
                view.ignorePopups = false;
                view.recentlySaved = false;
                view.previouslyWarnedEdit = false;
                view.previouslyWarnedReview = false;

                //// ALWAYS CLEAR THE REQUESTING VARIABLE FOR USE OF CLIENT SIDE BUTTON NAVIGATION
                view.pageRequestedFrom = "";

                //// REDRAW CANVAS
                view.onEnablePickers();

                // COLOR ANY PICKERS WITH SPECIAL BUSINESS LOGIC
                view.colorPickers();
            },

            clearAddressFields: function () {
                $("#FileNo").val("");
                $("#ClientLocNo").val("");
                $("#Latitude").val("");
                $("#Longitude").val("");
                $("#Address1").val("");
                $("#Division").val("");
                $("#City").val("");
                $("#StProv").val("");
                $("#Country").val("");
                $("#Zip").val("");
                $("#Facility").val("");
                $("#CustomAccess").val("");
                $("#txtFileRecordNumber").val("");
            },

            clearPickers: function () {
                //// KENDO WIDGETS
                StatusDate.value("");
                ResponseDate.value("");
                ExpectedCompletionDate.value("");
                view.widgetImpact().value("");
                view.widgetRecStatus().value("");
                view.widgetRecPrimary("");
                view.widgetRecSecondary("");
                view.widgetIntendedAction().value("");
                view.widgetIntendedActionMgmt().value("");

                view.widgetImpactPlaceHolder("");
                view.widgetRecStatusPlaceHolder("");
                view.widgetIntendedActionPlaceHolder("");

                view.widgetIntendedActionPlaceHolderMgmt("");

                //// HTML / KNOCKOUT DOMS
                $("#RecYear").val("");
                $("#RecMonth").val("");
                $("#RecNumber").val("");
                $("#SavingsRatio").val("");
            },

            setCancelObject: function () {
                objCancel.RecYear = view.objRec().RecYear();
                objCancel.RecMonth = view.objRec().RecMonth();
                objCancel.RecNumber = view.objRec().RecNumber();
                objCancel.Impact = view.objRec().Impact();
                objCancel.RecStatus = view.objRec().RecStatus();
                if (view.objRec().StatusDate() == undefined) { objCancel.StatusDate = null; } else { objCancel.StatusDate = view.objRec().StatusDate(); }
                objCancel.RecPrimary = view.objRec().RecPrimary();
                objCancel.RecSecondary = view.objRec().RecSecondary();
                if (view.objRec().ResponseDate() == undefined) { objCancel.ResponseDate = null; } else { objCancel.ResponseDate = view.objRec().ResponseDate(); }
                objCancel.ResponseFrom = view.objRec().ResponseFrom();
                objCancel.IntendedAction = view.objRec().IntendedAction();
                if (view.objRec().ExpectedCompletionDate() == undefined) { objCancel.ExpectedCompletionDate = null; } else { objCancel.ExpectedCompletionDate = view.objRec().ExpectedCompletionDate(); }
                objCancel.PlantComment = view.objRec().PlantComment();
                if ($.inArray('\+', view.clientFeatures()) > -1) {
                    if (view.objRec().MgmtRespDate() == undefined) { objCancel.MgmtRespDate = null; } else { objCancel.MgmtRespDate = view.objRec().MgmtRespDate(); }
                    objCancel.MgmtRespFrom = view.objRec().MgmtRespFrom();
                    objCancel.MgmtRespComment = view.objRec().MgmtRespComment();
                }
                if (view.objRec().ThirdLevelRespDate() == undefined) { objCancel.ThirdLevelRespDate = null; } else { objCancel.ThirdLevelRespDate = view.objRec().ThirdLevelRespDate() }
                objCancel.ThirdLevelRespFrom = view.objRec().ThirdLevelRespFrom();
                objCancel.ThirdLevelRespAction = view.objRec().ThirdLevelRespAction();
                objCancel.ThirdLevelRespComment = view.objRec().ThirdLevelRespComment();
            },

            //// RESET FIELDS ON LOAD RECORD
            cancelPickers: function () {
                view.objRec().RecYear(objCancel.RecYear);
                view.objRec().RecMonth(objCancel.RecMonth);
                view.objRec().RecNumber(objCancel.RecNumber);
                view.objRec().RecStatus(objCancel.RecStatus);
                view.widgetRecStatusPlaceHolder(objCancel.RecStatus);
                view.objRec().ResponseDate(objCancel.ResponseDate);
                view.objRec().ResponseFrom(objCancel.ResponseFrom);
                view.objRec().IntendedAction(objCancel.IntendedAction);
                view.objRec().ExpectedCompletionDate(objCancel.ExpectedCompletionDate);
                view.objRec().PlantComment(objCancel.PlantComment);
                if ($.inArray('\+', view.clientFeatures()) > -1) {
                    view.objRec().MgmtRespDate(objCancel.MgmtRespDate);
                    view.objRec().MgmtRespFrom(objCancel.MgmtRespFrom);
                    view.objRec().MgmtRespComment(objCancel.MgmtRespComment);
                }
                view.objRec().ThirdLevelRespDate(objCancel.ThirdLevelRespDate);
                view.objRec().ThirdLevelRespFrom(objCancel.ThirdLevelRespFrom);
                view.objRec().ThirdLevelRespAction(objCancel.ThirdLevelRespAction);
                view.objRec().ThirdLevelRespComment(objCancel.ThirdLevelRespComment);
                view.ignorePopups = true;
                view.resetPickers();
                view.ignorePopups = false;
            },

            resetObjRec: function () {
                view.objRec().RecYear($("#RecYear").val());
                view.objRec().RecMonth($("#RecMonth").val());
                view.objRec().RecNumber($("#RecNumber").val());
            },

            colorPickers: function () {
                // ONLY CHANGE COLOR IF WE ARE IN EDIT MODE
                if (!view.enablePickers()) {
                    var today = new Date();
                    var ogDate = view.objRec().ExpectedCompletionDate();
                    var dateComplete = moment(view.objRec().ExpectedCompletionDate()).format();
                    var warningDate = moment(today).add(29, 'days').format();
                    var expiredDate = moment(today).add(30, 'days').format();

                    if (ogDate === undefined) {
                        dateComplete = null;
                    }

                    // SPECIFICALLY REMOVE THE RED AND YELLOW CLASSES FROM PICKERS TO CHANGE
                    // AND ADD BACK THE noedit CLASS
                    ExpectedCompletionDate.wrapper.find(".k-icon").removeClass("expiredDate").addClass("noedit");
                    ExpectedCompletionDate.wrapper.find(".k-picker-wrap").removeClass("expiredDate").addClass("noedit");
                    ExpectedCompletionDate.wrapper.find(".k-autocomplete").removeClass("expiredDate").addClass("noedit");
                    ExpectedCompletionDate.wrapper.find(".k-icon").addClass("noedit").removeClass("warningDate");
                    ExpectedCompletionDate.wrapper.find(".k-picker-wrap").addClass("noedit").removeClass("warningDate");
                    ExpectedCompletionDate.wrapper.find(".k-autocomplete").addClass("noedit").removeClass("warningDate");

                    // IS THE EXPECTED COMPLETION DATE EXPIRED?
                    // THEN COLOR RED
                    if (view.widgetRecStatusPlaceHolder() === "In Progress" || view.widgetRecStatusPlaceHolder() === "Outstanding") {
                        if (dateComplete != null) {
                            if (moment(expiredDate).isAfter(dateComplete, 'day')) {
                                ExpectedCompletionDate.wrapper.find(".k-icon").removeClass("noedit").addClass("expiredDate");
                                ExpectedCompletionDate.wrapper.find(".k-picker-wrap").removeClass("noedit").addClass("expiredDate");
                                ExpectedCompletionDate.wrapper.find(".k-autocomplete").removeClass("noedit").addClass("expiredDate");

                                ExpectedCompletionDate.wrapper.find(".k-icon").removeClass("warningDate");
                                ExpectedCompletionDate.wrapper.find(".k-picker-wrap").removeClass("warningDate");
                                ExpectedCompletionDate.wrapper.find(".k-autocomplete").removeClass("warningDate");
                            }
                        }
                    }

                    // ELSE IS THE EXPECTED COMPLETION DATE TODAY PLUS THIRTY DAYS?
                    // THEN COLOR YELLOW
                    if (view.widgetRecStatusPlaceHolder() === "In Progress" || view.widgetRecStatusPlaceHolder() === "Outstanding") {
                        if (dateComplete != null) {
                            if (moment(dateComplete).isBetween(today, warningDate, 'day')) {
                                ExpectedCompletionDate.wrapper.find(".k-icon").removeClass("noedit").addClass("warningDate");
                                ExpectedCompletionDate.wrapper.find(".k-picker-wrap").removeClass("noedit").addClass("warningDate");
                                ExpectedCompletionDate.wrapper.find(".k-autocomplete").removeClass("noedit").addClass("warningDate");

                                ExpectedCompletionDate.wrapper.find(".k-icon").removeClass("expiredDate");
                                ExpectedCompletionDate.wrapper.find(".k-picker-wrap").removeClass("expiredDate");
                                ExpectedCompletionDate.wrapper.find(".k-autocomplete").removeClass("expiredDate");
                            }
                        }
                    }
                }
            },

            onEnablePickers: function () {
                //// NOT AN ADMIN USER
                if (view.enablePickers()) {
                    //// USER IS NOT AN ADMIN AND ENABLES
                    //// ENABLE PICKERS NOT BOUND BY KNOCKOUT AND CHANGE TO YELLOW WHERE NEEDED
                    //// DATES
                    ExpectedCompletionDate.enable();
                    ExpectedCompletionDate.wrapper.find(".k-icon").removeClass("noedit").addClass("editRequired");
                    ExpectedCompletionDate.wrapper.find(".k-picker-wrap").removeClass("noedit").addClass("editRequired");
                    ExpectedCompletionDate.wrapper.find(".k-autocomplete").removeClass("noedit").addClass("editRequired");
                    ExpectedCompletionDate.wrapper.find(".k-icon").removeClass("expiredDate").addClass("editRequired");
                    ExpectedCompletionDate.wrapper.find(".k-picker-wrap").removeClass("expiredDate").addClass("editRequired");
                    ExpectedCompletionDate.wrapper.find(".k-autocomplete").removeClass("expiredDate").addClass("editRequired");
                    ExpectedCompletionDate.wrapper.find(".k-icon").removeClass("warningDate").addClass("editRequired");
                    ExpectedCompletionDate.wrapper.find(".k-picker-wrap").removeClass("warningDate").addClass("editRequired");
                    ExpectedCompletionDate.wrapper.find(".k-autocomplete").removeClass("warningDate").addClass("editRequired");
                    //// DROPDOWNS
                    view.enableAdminFields(false);
                    IntendedAction.find(".k-icon").removeClass("noedit").addClass("editRequired");
                    IntendedAction.find(".k-dropdown-wrap").removeClass("noedit").addClass("editRequired");
                    //// PLAIN TEXT
                    $("#PlantComment").removeAttr("readonly");
                    $("#PlantComment").removeClass("noedit").addClass("editRequired");
                    $("#RecYear").attr("readonly", "readonly");
                    $("#RecYear").removeClass("editRequired").addClass("noedit");
                    $("#RecMonth").attr("readonly", "readonly");
                    $("#RecMonth").removeClass("editRequired").addClass("noedit");
                    $("#RecNumber").attr("readonly", "readonly");
                    $("#RecNumber").removeClass("editRequired").addClass("noedit");
                    $("#SavingsRatio").attr("readonly", "readonly");
                    $("#SavingsRatio").removeClass("editRequired").addClass("noedit");
                    $("#RecKeyWords").attr("readonly", "readonly");
                    $("#RecKeyWords").removeClass("editRequired").addClass("noedit");

                    //// SHOW ICONS ON NO ADMIN
                    StatusDate.wrapper.find(".k-icon").hide();
                    Impact.find(".k-icon").hide();
                    RecStatus.find(".k-icon").hide();
                    RecPrimary.find(".k-icon").hide();
                    RecSecondary.find(".k-icon").hide();
                    LossExpectancyBefore.find(".k-icon").hide();
                    LossExpectancyAfter.find(".k-icon").hide();
                    CostToComplete.find(".k-icon").hide();
                    IntendedAction.find(".k-icon").show();
                    ResponseDate.wrapper.find(".k-icon").hide();
                    ExpectedCompletionDate.wrapper.find(".k-icon").show();

                    if ($.inArray('\+', view.clientFeatures()) > -1) {
                        MgmtRespDate.wrapper.find(".k-icon").hide();
                        IntendedActionMgmt.find(".k-icon").hide();
                        MgmtRespAction.find(".k-icon").hide();
                    }
                } else {
                    //// USER IS NOT AN ADMIN AND DISABLES
                    //// DISABLE PICKERS NOT BOUND BY KNOCKOUT AND CHANGE ALL BACK TO WHITE
                    //// DATES
                    StatusDate.enable(false);
                    StatusDate.wrapper.find(".k-icon").removeClass("editRequired").addClass("noedit");
                    StatusDate.wrapper.find(".k-picker-wrap").removeClass("editRequired").addClass("noedit");
                    StatusDate.wrapper.find(".k-autocomplete").removeClass("editRequired").addClass("noedit");
                    ExpectedCompletionDate.enable(false);
                    ExpectedCompletionDate.wrapper.find(".k-icon").removeClass("editRequired").addClass("noedit");
                    ExpectedCompletionDate.wrapper.find(".k-picker-wrap").removeClass("editRequired").addClass("noedit");
                    ExpectedCompletionDate.wrapper.find(".k-autocomplete").removeClass("editRequired").addClass("noedit");
                    //// DROPDOWNS
                    view.enableAdminFields(false);
                    IntendedAction.find(".k-icon").removeClass("editRequired").addClass("noedit");
                    IntendedAction.find(".k-dropdown-wrap").removeClass("editRequired").addClass("noedit");
                    MgmtRespAction.find(".k-icon").removeClass("editRequired").addClass("noedit");
                    MgmtRespAction.find(".k-dropdown-wrap").removeClass("editRequired").addClass("noedit");

                    //// PLAIN TEXT
                    $("#RecYear").attr("readonly", "readonly");
                    $("#RecYear").removeClass("editRequired").addClass("noedit");
                    $("#RecMonth").attr("readonly", "readonly");
                    $("#RecMonth").removeClass("editRequired").addClass("noedit");
                    $("#RecNumber").attr("readonly", "readonly");
                    $("#RecNumber").removeClass("editRequired").addClass("noedit");
                    $("#SavingsRatio").attr("readonly", "readonly");
                    $("#SavingsRatio").removeClass("editRequired").addClass("noedit");
                    $("#RecKeyWords").attr("readonly", "readonly");
                    $("#RecKeyWords").removeClass("editRequired").addClass("noedit");
                    $("#PlantComment").attr("readonly", "readonly");
                    $("#PlantComment").removeClass("editRequired").addClass("noedit");
                    //// HIDE ICONS ON NO ADMIN
                    StatusDate.wrapper.find(".k-icon").hide();
                    ResponseDate.wrapper.find(".k-icon").hide();
                    ExpectedCompletionDate.wrapper.find(".k-icon").hide();
                    Impact.find(".k-icon").hide();
                    RecStatus.find(".k-icon").hide();
                    RecPrimary.find(".k-icon").hide();
                    RecSecondary.find(".k-icon").hide();
                    LossExpectancyBefore.find(".k-icon").hide();
                    LossExpectancyAfter.find(".k-icon").hide();
                    CostToComplete.find(".k-icon").hide();
                    IntendedAction.find(".k-icon").hide();

                    RecStatus.next().hide();
                    Impact.next().hide();

                    if ($.inArray('\+', view.clientFeatures()) > -1) {
                        MgmtRespDate.wrapper.find(".k-icon").hide();
                        IntendedActionMgmt.find(".k-icon").hide();
                        MgmtRespAction.find(".k-icon").hide();
                    }

                    if (view.clientFeatures().indexOf("!") > -1) {
                        lvl3RespDate.enable(false);
                        lvl3RespDate.wrapper.find(".k-icon").removeClass("editRequired").addClass("noedit");
                        lvl3RespDate.wrapper.find(".k-picker-wrap").removeClass("editRequired").addClass("noedit");
                        lvl3RespDate.wrapper.find(".k-picker-wrap").removeClass("editRequired").addClass("noedit");
                        lvl3RespDate.wrapper.find(".k-icon").hide();

                        ThirdLevelRespAction.find(".k-icon").removeClass("editRequired").addClass("noedit");
                        ThirdLevelRespAction.find(".k-dropdown-wrap").removeClass("editRequired").addClass("noedit");

                        ThirdLevelRespAction.find(".k-icon").hide();

                        $("#lvl3RespFrom").attr("readonly", "readonly");
                        $("#lvl3RespFrom").removeClass("editRequired").addClass("noedit");

                        $("#lvl3Commment").attr("readonly", "readonly");
                        $("#lvl3Commment").removeClass("editRequired").addClass("noedit");
                    }
                }
            },

            isResponseValid: function (strAction) {
                var returnValue = true;
                var todaysDate = new Date();
                view.intendedAction = strAction;

                //// CHECK IF EXPECTED COMPLETION DATE IS EMPTY. IF EMPTY DO NOT DO ANY OTHER VALIDATION
                //if (ExpectedCompletionDate.value() == undefined || ExpectedCompletionDate.value() == "" || ExpectedCompletionDate.value() == null) {
                if (1 == 2) {
                    // NOTE: MARGIE ASKED TO REMOVE THE ExpectedCompletionDate = null CHECK ON 9/15/2015
                    //// DO NOTHING
                } else {

                    //// CHECK FOR A NEW RESPONSE
                    if (view.objRec().IntendedAction().toLowerCase() != "completed") {
                        //if ((!view.recentlySaved) && !(ResponseDate.value() == undefined || ResponseDate.value() == "" || ResponseDate.value() == null) && !(ExpectedCompletionDate.value() == undefined || ExpectedCompletionDate.value() == "" || ExpectedCompletionDate.value() == null)) {
                        if ((!view.recentlySaved) && !(ResponseDate.value() == undefined || ResponseDate.value() == "" || ResponseDate.value() == null)) {
                            //// CHECK FOR "REVIEW PREVIOUS RESPONSE"
                            todaysDate = new Date();
                            if (view.editState()) { //// IF IN EDIT MODE DO NOT "REVIEW PREVIOUS RESPONSE"
                                //// CHECK FOR "EDIT PREVIOUS RESPONSE"
                                todaysDate = new Date();
                                if ((ExpectedCompletionDate.value() !== undefined && ExpectedCompletionDate.value() !== null) && (ExpectedCompletionDate.value() < todaysDate) && (!view.previouslyWarnedEdit)) {
                                    returnValue = false;
                                    view.previouslyWarnedEdit = true;
                                    if (!view.ignorePopups) {
                                        windowRecEdit.data("kendoWindow").open();
                                        $("#windowRecEdit").css("display", "block");
                                    }
                                }
                                //// CHECK FOR "REVIEW PREVIOUS RESPONSE"
                                //                            else if ((ResponseDate.value() < StatusDate.value()) && (ExpectedCompletionDate.value() > todaysDate || ExpectedCompletionDate.value() == undefined || ExpectedCompletionDate.value() == "" || ExpectedCompletionDate.value() == null)) {
                                //                                returnValue = false;
                                //                                view.previouslyWarnedReview = true;
                                //                                if (!view.ignorePopups) {
                                //                                    windowRecReview.data("kendoWindow").open();
                                //                                    $("#windowRecReview").css("display", "block");
                                //                                }
                                //                            }
                            } else {
                                if ((ExpectedCompletionDate.value() !== undefined && ExpectedCompletionDate.value() !== null) && (ExpectedCompletionDate.value() < todaysDate) && (!view.previouslyWarnedEdit)) {
                                    returnValue = false;
                                    view.previouslyWarnedEdit = true;
                                    if (!view.ignorePopups) {
                                        windowRecEdit.data("kendoWindow").open();
                                        $("#windowRecEdit").css("display", "block");
                                    }
                                }
                                //// CHECK FOR "REVIEW PREVIOUS RESPONSE"
                                else if ((ResponseDate.value() < StatusDate.value()) && (ExpectedCompletionDate.value() == undefined || ExpectedCompletionDate.value() == "" || ExpectedCompletionDate.value() == null || ExpectedCompletionDate.value() > todaysDate) && (!view.previouslyWarnedReview)) {
                                    returnValue = false;
                                    view.previouslyWarnedReview = true;
                                    if (!view.ignorePopups) {
                                        windowRecReview.data("kendoWindow").open();
                                        $("#windowRecReview").css("display", "block");
                                    }
                                }
                            }
                        }

                        //// CHECK FOR PREVIOUSLY SAVED INFORMATION
                        else if ((view.recentlySaved) && !(ResponseDate.value() == undefined || ResponseDate.value() == "" || ResponseDate.value() == null) && !(ExpectedCompletionDate.value() == undefined || ExpectedCompletionDate.value() == "" || ExpectedCompletionDate.value() == null)) {
                            todaysDate = new Date();
                            if ((ExpectedCompletionDate.value() < todaysDate) && (!view.previouslyWarnedEdit)) {
                                returnValue = false;
                                view.previouslyWarnedEdit = true;
                                if (!view.ignorePopups) {
                                    windowRecRecentSave.data("kendoWindow").open();
                                    $("#windowRecRecentSave").css("display", "block");
                                }
                            }
                            else if ((ResponseDate.value() < StatusDate.value()) && (ExpectedCompletionDate.value() == undefined || ExpectedCompletionDate.value() == "" || ExpectedCompletionDate.value() == null || ExpectedCompletionDate.value() > todaysDate) && (!view.previouslyWarnedReview)) {
                                returnValue = false;
                                view.previouslyWarnedEdit = true;
                                if (!view.ignorePopups) {
                                    windowRecRecentSave.data("kendoWindow").open();
                                    $("#windowRecRecentSave").css("display", "block");
                                }
                            }
                        }
                    }
                }

                return returnValue;
            },

            isResponseActionDateValid: function (strAction) {
                var returnValue = true;
                if (view.editState()) {
                    if (view.objRec().IntendedAction().toString().toLowerCase().indexOf("will not complete") > -1) {
                        if (ExpectedCompletionDate.value() !== undefined && ExpectedCompletionDate.value() !== null) {
                            returnValue = false;
                        }
                    }
                }
                return returnValue;
            },

            onWindowRecReviewOK: function () {
                windowRecReview.data("kendoWindow").close();
                var tempIntendedAction = view.intendedAction.toLowerCase();
                var todaysDate = new Date();
                ResponseDate.value(todaysDate);
                view.objRec().ResponseFrom(view.fullName);
                view.intendedAction = "";
                view.setupButtons();
                view.previouslyWarnedEdit = false;
                view.previouslyWarnedReview = false;
                view.ignorePopups = true;
                view.resetPickers();
                view.ignorePopups = false;
                view.messageSave(view.objLanguageLabels().lblTheRecResponseRecordHasBeenAutomaticallySaved);
                view.messageValidation("");

                switch (tempIntendedAction) {
                    case "onnext":
                        //view.onNext();
                        view.onSave();
                        break;
                    case "onprevious":
                        //view.onPrevious();
                        view.onSave();
                        break;
                    case "onfirst":
                        //view.onFirst();
                        view.onSave();
                        break;
                    case "onlast":
                        //view.onLast();
                        view.onSave();
                        break;
                    case "onfilenext":
                        //view.onFileNext();
                        view.onSave();
                        break;
                    case "onfileprevious":
                        //view.onFilePrevious();
                        view.onSave();
                        break;
                    case "onfilefirst":
                        //view.onFileFirst();
                        view.onSave();
                        break;
                    case "onfilelast":
                        //view.onFileLast();
                        view.onSave();
                        break;
                    case "ondatasheetview":
                        view.onSave();
                        view.onDatasheetView();
                        break;
                    case "oneditsave":
                        view.onSave();
                        break;
                    default:
                        view.onSave();
                        break;
                }
            },

            onWindowRecReviewCancel: function () {
                windowRecReview.data("kendoWindow").close();
                view.intendedAction = "";
                view.previouslyWarnedReview = true;
                view.setCancelObject();
                view.editState(true);
                view.enablePickers(true);
                view.onEnablePickers();
                view.messageSave("");
                view.messageValidation("");
                view.setupButtons();
                view.enableDelete(true);
            },

            onWindowRecEditOK: function () {
                windowRecEdit.data("kendoWindow").close();
                view.intendedAction = "";
                view.previouslyWarnedReview = true;
                view.setCancelObject();
                view.editState(true);
                view.enablePickers(true);
                view.onEnablePickers();
                view.messageSave("");
                view.messageValidation("");
                view.setupButtons();
                view.enableDelete(true);
            },

            onWindowRecRecentSaveOK: function () {
                windowRecRecentSave.data("kendoWindow").close();
                view.intendedAction = "";
                view.previouslyWarnedEdit = true;
            },

            loadCounts: function () {
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collCounts.GetRecommendationCountsIR(view.fileNo)) {
                    var responsesTotal = view.collCounts()[0].ResponsesTotal();
                    var responsesCompleted = view.collCounts()[0].ResponsesCompleted();
                    var responsesNeeded = responsesTotal - responsesCompleted;
                    //var responsesNeeded = view.collCounts()[0].ResponsesCompleted();
                    view.countsCompleted(responsesNeeded);
                    view.countsNeeded(responsesCompleted);
                } else {
                    view.countsCompleted(0);
                    view.countsNeeded(0);
                }
            },

            loadRRLog: function () {
                es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
                if (!view.collRRLog.GetRecordByGuid(view.RRLogGuid)) {
                    view.objRRLog(view.collRRLog()[0]);
                } else {
                    alert("Error loading Rec. Response log record. Please log out and try again.");
                }
            },

            loadLabelTranslations: function (pLanguage) {
                dsLanguageLabels = {};
                var tempLanguage = pLanguage.toLowerCase();
                tempLabelColl = new es.objects.ViewCCTranslationCollection();
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!tempLabelColl.GetTranslationByPage("1|" + tempLanguage)) {
                    switch (tempLanguage) {
                        case "english":
                            for (x = 0; x < tempLabelColl().length; x++) {
                                dsLanguageLabels[tempLabelColl()[x].LabelName()] = tempLabelColl()[x].EnglishTranslation();
                            }
                            break;
                        case "spanish":
                            for (x = 0; x < tempLabelColl().length; x++) {
                                dsLanguageLabels[tempLabelColl()[x].LabelName()] = tempLabelColl()[x].SpanishTranslation();
                            }
                            break;
                        case "german":
                            for (x = 0; x < tempLabelColl().length; x++) {
                                dsLanguageLabels[tempLabelColl()[x].LabelName()] = tempLabelColl()[x].GermanTranslation();
                            }
                            break;
                        case "italian":
                            for (x = 0; x < tempLabelColl().length; x++) {
                                dsLanguageLabels[tempLabelColl()[x].LabelName()] = tempLabelColl()[x].ItalianTranslation();
                            }
                            break;
                        case "portuguese":
                            for (x = 0; x < tempLabelColl().length; x++) {
                                dsLanguageLabels[tempLabelColl()[x].LabelName()] = tempLabelColl()[x].PortugueseTranslation();
                            }
                            break;
                        case "french":
                            for (x = 0; x < tempLabelColl().length; x++) {
                                dsLanguageLabels[tempLabelColl()[x].LabelName()] = tempLabelColl()[x].FrenchTranslation();
                            }
                            break;
                        default:
                            //// DO NOTHING, THE USER DOES NOT WANT TO MAKE A CHANGE
                            break;
                    }
                }
                view.objLanguageLabels(dsLanguageLabels);
                viewMaster.objLanguageLabels(dsLanguageLabels);
                dsLanguageOptions[0] = dsLanguageLabels.lblChooseLanguage;
            },

            //// LOAD ONLY THE LOWER DETAILS, ONE OR ALL DEPENDING ON STATE
            loadDetailsOnly: function () {
                view.stateLoadError = false;
                var tempHemisphere = getHemisphere(calculate_time_zone());
                var tempParm = view.fileNo;
                es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
                if (view.stateDetailsLoadOneRecord == true && view.stateLoadError == false) {
                    if (!view.collRec.GetFindingByFileNo(tempParm + "|" + tempHemisphere + "|one")) { view.stateLoadError = false } else { view.stateLoadError = true }
                    view.stateDetailsLoadOneRecord = false;
                    view.stateOnlyOneDetailRecordLoaded = true;
                } else {
                    if (!view.collRec.GetFindingByFileNo(tempParm + "|" + tempHemisphere + "|all")) { view.stateLoadError = false } else { view.stateLoadError = true }
                    view.stateDetailsLoadOneRecord = false;
                    view.stateOnlyOneDetailRecordLoaded = false;
                }
                if (!view.stateLoadError) {
                    view.loadLabelTranslations(view.preferenceLanguage);
                    view.objRec(view.collRec()[view.index]);
                } else {
                    //// DISPLAY ERROR MESSAGE
                    view.loadLabelTranslations(view.preferenceLanguage);
                    view.messageError("* Error while loading record.");
                }
            },

            //// LOAD ONE FILE NUMBER AND ONE DETAIL
            loadOneFileNumber: function () {
                view.stateLoadError = false;

                var tempHemisphere = getHemisphere(calculate_time_zone());
                var tempParm = view.fileNo + "|" + tempHemisphere + "|" + view.fileDirection() + "|one";
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collListing.GetRecResponseIRLocationByFileNo(tempParm)) { view.stateLoadError = false } else { view.stateLoadError = true }
                view.stateListingLoadOneRecord = false;

                tempParm = view.fileNo + "|" + tempHemisphere + "|one";
                es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
                if (!view.collRec.GetFindingByFileNo(tempParm)) { view.stateLoadError = false } else { view.stateLoadError = true }
                view.stateDetailsLoadOneRecord = false;
                view.stateOnlyOneDetailRecordLoaded = true;

                view.objListing(view.collListing()[0]);
                view.objRec(view.collRec()[0]);
                view.loadLabelTranslations(view.preferenceLanguage);
                view.loadCounts();
                view.setupButtons();
            },

            //// LOAD ALL RECORDS AND ALL DETAILS
            loadFileNumber: function () {
                view.stateLoadError = false;

                //// LOAD THE LOACATION LISTINGS, ONE OR ALL, WITH FILE DIRECTION
                var tempHemisphere = getHemisphere(calculate_time_zone());
                var tempParm = view.fileNo + "|" + tempHemisphere + "|" + view.fileDirection() + "|one";
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collListing.GetRecResponseIRLocationByFileNo(tempParm)) { view.stateLoadError = false } else { view.stateLoadError = true }
                view.stateListingLoadOneRecord = false;

                //// LOAD ALL DETAILS
                tempParm = view.fileNo + "|" + tempHemisphere + "|all";
                es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
                if (!view.collRec.GetFindingByFileNo(tempParm)) { view.stateLoadError = false } else { view.stateLoadError = true }
                view.stateDetailsLoadOneRecord = false;
                view.stateOnlyOneDetailRecordLoaded = false;

                //// DO THE REMAINING CODE TO POPUPLATE THE PAGE
                if (!view.stateLoadError) {
                    view.objListing(view.collListing()[0]);
                    view.objRec(view.collRec()[view.index]);
                    view.loadLabelTranslations(view.preferenceLanguage);
                    view.loadCounts();
                    view.setupButtons();
                } else {
                    //// DISPLAY ERROR MESSAGE
                    view.loadLabelTranslations(view.preferenceLanguage);
                    view.messageError("* Error while loading record.");
                }
            },

            //// RELOAD AND REFRESH PICKERS
            onClosePrimary: function () {
                view.loadPickers();
                view.objRec().RecSecondary(view.KOcollRecSecondary()[0]);
                view.ignorePopups = true;
                view.resetPickers();
                view.ignorePopups = false;
                view.messageSave("");
                view.messageValidation("");
            },

            onCloseIntendedAction: function () {
                if (view.objRec().RecStatus().toLowerCase() != "advisory" && view.objRec().RecStatus().toLowerCase() != "conf completed" && view.objRec().RecStatus().toLowerCase() != "removed") {
                    if (view.widgetIntendedAction().value().toLowerCase() == "completed"
                     || view.widgetIntendedAction().value().toLowerCase() == "umgesetzt"
                     || view.widgetIntendedAction().value().toLowerCase() == "implementado"
                     || view.widgetIntendedAction().value().toLowerCase() == "fait - rec réalisée"
                     || view.widgetIntendedAction().value().toLowerCase() == "completato"
                     || view.widgetIntendedAction().value().toLowerCase() == "implementado") {
                        view.objRec().RecStatus("Rptd Completed");
                        switch (view.preferenceLanguage.toLowerCase()) {
                            case "german": view.widgetRecStatus().value(view.collStatuslist()[5].GermanTranslation()); break;
                            case "spanish": view.widgetRecStatus().value(view.collStatuslist()[5].SpanishTranslation()); break;
                            case "french": view.widgetRecStatus().value(view.collStatuslist()[5].FrenchTranslation()); break;
                            case "italian": view.widgetRecStatus().value(view.collStatuslist()[5].ItalianTranslation()); break;
                            case "portuguese": view.widgetRecStatus().value(view.collStatuslist()[5].PortugueseTranslation()); break;
                            default: view.widgetRecStatus().value(view.collStatuslist()[5].EnglishTranslation()); break;
                        }
                    } else if (view.widgetIntendedAction().value().toLowerCase() == "in progress"
                        || view.widgetIntendedAction().value().toLowerCase() == "in arbeit"
                        || view.widgetIntendedAction().value().toLowerCase() == "en implementación"
                        || view.widgetIntendedAction().value().toLowerCase() == "en cours"
                        || view.widgetIntendedAction().value().toLowerCase() == "in corso"
                        || view.widgetIntendedAction().value().toLowerCase() == "em andamento") {
                        view.objRec().RecStatus("In Progress");
                        switch (view.preferenceLanguage.toLowerCase()) {
                            case "german": view.widgetRecStatus().value(view.collStatuslist()[2].GermanTranslation()); break;
                            case "spanish": view.widgetRecStatus().value(view.collStatuslist()[2].SpanishTranslation()); break;
                            case "french": view.widgetRecStatus().value(view.collStatuslist()[2].FrenchTranslation()); break;
                            case "italian": view.widgetRecStatus().value(view.collStatuslist()[2].ItalianTranslation()); break;
                            case "portuguese": view.widgetRecStatus().value(view.collStatuslist()[2].PortugueseTranslation()); break;
                            default: view.widgetRecStatus().value(view.collStatuslist()[2].EnglishTranslation()); break;
                        }
                    } else {
                        view.objRec().RecStatus("Outstanding");
                        switch (view.preferenceLanguage.toLowerCase()) {
                            case "german": view.widgetRecStatus().value(view.collStatuslist()[3].GermanTranslation()); break;
                            case "spanish": view.widgetRecStatus().value(view.collStatuslist()[3].SpanishTranslation()); break;
                            case "french": view.widgetRecStatus().value(view.collStatuslist()[3].FrenchTranslation()); break;
                            case "italian": view.widgetRecStatus().value(view.collStatuslist()[3].ItalianTranslation()); break;
                            case "portuguese": view.widgetRecStatus().value(view.collStatuslist()[3].PortugueseTranslation()); break;
                            default: view.widgetRecStatus().value(view.collStatuslist()[3].EnglishTranslation()); break;
                        }
                    }
                }
                if (view.clientFeatures().indexOf("R") > -1) {
                    $('#ExpectedCompletionDate').removeClass('required');
                    if (view.widgetIntendedAction().value().toLowerCase() != "completed"
                        && view.widgetIntendedAction().value().toLowerCase() != "umgesetzt"
                        && view.widgetIntendedAction().value().toLowerCase() != "implementado"
                        && view.widgetIntendedAction().value().toLowerCase() != "fait - rec réalisée"
                        && view.widgetIntendedAction().value().toLowerCase() != "completato"
                        && view.widgetIntendedAction().value().toLowerCase() != "implementado"
                        && view.widgetIntendedAction().value().toLowerCase() != "disagree - will not complete"
                        && view.widgetIntendedAction().value().toLowerCase() != "Nicht einverstanden - wird nicht umgesetzt"
                        && view.widgetIntendedAction().value().toLowerCase() != "en desacuerdo-no se implementará"
                        && view.widgetIntendedAction().value().toLowerCase() != "désaccord - ne sera pas fait"
                        && view.widgetIntendedAction().value().toLowerCase() != "non si concorda - non verrà completato"
                        && view.widgetIntendedAction().value().toLowerCase() != "nao concorda-Nao vai ser implementado"
                        && view.widgetIntendedAction().value().toLowerCase() != "no commitment"
                        && view.widgetIntendedAction().value().toLowerCase() != "keine aussage"
                        && view.widgetIntendedAction().value().toLowerCase() != "no hubo compromiso"
                        && view.widgetIntendedAction().value().toLowerCase() != "pas d'engagement"
                        && view.widgetIntendedAction().value().toLowerCase() != "non si prende un impegno"
                        && view.widgetIntendedAction().value().toLowerCase() != "sem compromiso"
                        ) {
                        $('#ExpectedCompletionDate').addClass('required');
                    }
                }
                //view.objRec().IntendedAction(view.widgetIntendedAction().value());
                for (q = 0; q < view.collIntendedaction().length; q++) {
                    switch (view.preferenceLanguage.toLowerCase()) {
                        case "german": if (view.widgetIntendedAction().value() == view.collIntendedaction()[q].GermanTranslation()) { view.objRec().IntendedAction(view.collIntendedaction()[q].EnglishTranslation()); } break;
                        case "spanish": if (view.widgetIntendedAction().value() == view.collIntendedaction()[q].SpanishTranslation()) { view.objRec().IntendedAction(view.collIntendedaction()[q].EnglishTranslation()); } break;
                        case "french": if (view.widgetIntendedAction().value() == view.collIntendedaction()[q].FrenchTranslation()) { view.objRec().IntendedAction(view.collIntendedaction()[q].EnglishTranslation()); } break;
                        case "italian": if (view.widgetIntendedAction().value() == view.collIntendedaction()[q].ItalianTranslation()) { view.objRec().IntendedAction(view.collIntendedaction()[q].EnglishTranslation()); } break;
                        case "portuguese": if (view.widgetIntendedAction().value() == view.collIntendedaction()[q].PortugueseTranslation()) { view.objRec().IntendedAction(view.collIntendedaction()[q].EnglishTranslation()); } break;
                        default: if (view.widgetIntendedAction().value() == view.collIntendedaction()[q].EnglishTranslation()) { view.objRec().IntendedAction(view.collIntendedaction()[q].EnglishTranslation()); } break;
                    }
                }

                view.ignorePopups = true;
                view.resetPickers();
                view.ignorePopups = false;
                view.messageSave("");
                view.messageValidation("");
            },

            onCloseMgmtIntendedAction: function () {
                for (q = 0; q < view.collIntendedactionMgmt().length; q++) {
                    switch (view.preferenceLanguage.toLowerCase()) {
                        case "german": if (view.widgetIntendedActionMgmt().value() == view.collIntendedactionMgmt()[q].GermanTranslation()) { view.objRec().MgmtRespAction(view.collIntendedactionMgmt()[q].EnglishTranslation()); } break;
                        case "spanish": if (view.widgetIntendedActionMgmt().value() == view.collIntendedactionMgmt()[q].SpanishTranslation()) { view.objRec().MgmtRespAction(view.collIntendedactionMgmt()[q].EnglishTranslation()); } break;
                        case "french": if (view.widgetIntendedActionMgmt().value() == view.collIntendedactionMgmt()[q].FrenchTranslation()) { view.objRec().MgmtRespAction(view.collIntendedactionMgmt()[q].EnglishTranslation()); } break;
                        case "italian": if (view.widgetIntendedActionMgmt().value() == view.collIntendedactionMgmt()[q].ItalianTranslation()) { view.objRec().MgmtRespAction(view.collIntendedactionMgmt()[q].EnglishTranslation()); } break;
                        case "portuguese": if (view.widgetIntendedActionMgmt().value() == view.collIntendedactionMgmt()[q].PortugueseTranslation()) { view.objRec().MgmtRespAction(view.collIntendedactionMgmt()[q].EnglishTranslation()); } break;
                        default: if (view.widgetIntendedActionMgmt().value() == view.collIntendedactionMgmt()[q].EnglishTranslation()) { view.objRec().MgmtRespAction(view.collIntendedactionMgmt()[q].EnglishTranslation()); } break;
                    }
                }
            },

            onCloseAll: function () {
                view.messageSave("");
                view.messageValidation("");
            },

            saveLanguageSelection: function () {
                //// SAVE THE RRLOG RECORD
                view.objRRLog().LanguagePreference(view.preferenceLanguage);
                objTempRRLog = new es.objects.RRLog();
                objTempRRLog = view.objRRLog();
                es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
                objTempRRLog.save();
            },

            onSave: function () {
                view.resetObjRec();

                //// CREATE REQUIRED FIELDS
                var today = new Date();
                view.objRec().ResponseDate(today);
                view.objRec().ResponseFrom(view.fullName);

                //// SAVE THE RECOMMENDATION RECORD
                var objTemp = new es.objects.Findings();
                objTemp = view.objRec();

                //// PROTECT AGAINST NULLS
                if (objTemp.ResponseFrom() == undefined) { objTemp.ResponseFrom(""); }
                if (objTemp.PlantComment() == undefined) { objTemp.PlantComment(""); }
                if (objTemp.IntendedAction() == undefined) { objTemp.IntendedAction(""); }
                if (objTemp.RecStatus() == undefined) { objTemp.RecStatus(""); }

                es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
                objTemp.save();

                //// SAVE THE RRLOG RECORD
                objTempRRLog = new es.objects.RRLog();
                objTempRRLog = view.objRRLog();
                objTempRRLog.ResponseActive(1);
                objTempRRLog.Changed(1);
                objTempRRLog.ResponseLastActivity(today);
                es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
                objTempRRLog.save();

                //// REFRESH THE DATA FOR ACCURACY IN OTHER TIMEZONES
                //view.loadOneFileNumber();
                view.loadDetailsOnly(); //// ADDED TO CORRECT PROBLEMS WITH WRONG DROPDOWN VALUES.

                //// RELOAD THE COUNTS
                view.loadCounts();
                view.ignorePopups = false;
                view.resetPickers();
            },

            onEditSave: function () {
                if (view.editState()) {
                    //// USER CLICKED SAVE, SAVE THE RECORD AND CHANGE THE BUTTONS AND ENABLE RECORD / LOCATION WALKERS, ENABLE PICKERS, CHANGE COLOR TO YELLOW
                    //// VALIDATE IF CORRECT INFO IS IN REC FIELDS
                    view.messageValidation("");
                    var tempDate = new Date();
                    var tempError = "";
                    if ($("#RecYear").val() < 1000 || $("#RecYear").val() > tempDate.getFullYear()) {
                        tempError += "Rec. Year ";
                    }
                    if ($("#RecMonth").val() < 1 || $("#RecMonth").val() > 12) {
                        if ($("#RecMonth").val() != '') {
                            if (tempError.length > 0) {
                                tempError += "and Rec. Month ";
                            } else {
                                tempError += "Rec. Month ";
                            }
                        }
                    } else {
                        if ($("#RecMonth").val() < 10 && $("#RecMonth").val() > 0 && $("#RecMonth").val().length < 2) {
                            $("#RecMonth").val("0" + $("#RecMonth").val());
                        }
                    }

                    if ($("#RecNumber").val() == '') {
                        $("#RecNumber").val(0);
                    }

                    if (tempError.length > 0) {
                        view.messageValidation(view.objLanguageLabels().lblPleaseEnterValidInformation + ": " + tempError);
                    } else {
                        view.ignorePopups = true;
                        view.previouslyWarnedEdit = false;
                        if (!view.isResponseValid("onSave")) {
                            view.messageValidation(view.objLanguageLabels().lblError + ": " + view.objLanguageLabels().lblPleaseCheckValidDates);
                            view.ignorePopups = false;
                        } else if (!view.isResponseActionDateValid("onSave")) {
                            view.messageValidation(view.objLanguageLabels().lblPleaseCheckIntendedActionValidDate);
                            view.ignorePopups = false;
                        } else {
                            if (view.clientFeatures().indexOf("R") > -1) {
                                if (ExpectedCompletionDate.value() == undefined && ExpectedCompletionDate.value() == null) {
                                    if (view.widgetIntendedAction().value().toLowerCase() == "completed"
                                        || view.widgetIntendedAction().value().toLowerCase() == "umgesetzt"
                                        || view.widgetIntendedAction().value().toLowerCase() == "implementado"
                                        || view.widgetIntendedAction().value().toLowerCase() == "fait - rec réalisée"
                                        || view.widgetIntendedAction().value().toLowerCase() == "completato"
                                        || view.widgetIntendedAction().value().toLowerCase() == "implementado"
                                        || view.widgetIntendedAction().value().toLowerCase() == "disagree - will not complete"
                                        || view.widgetIntendedAction().value().toLowerCase() == "nicht einverstanden - wird nicht umgesetzt"
                                        || view.widgetIntendedAction().value().toLowerCase() == "en desacuerdo-no se implementará"
                                        || view.widgetIntendedAction().value().toLowerCase() == "désaccord - ne sera pas fait"
                                        || view.widgetIntendedAction().value().toLowerCase() == "non si concorda - non verrà completato"
                                        || view.widgetIntendedAction().value().toLowerCase() == "nao concorda-nao vai ser implementado"
                                        || view.widgetIntendedAction().value().toLowerCase() == "no commitment"
                                        || view.widgetIntendedAction().value().toLowerCase() == "keine aussage"
                                        || view.widgetIntendedAction().value().toLowerCase() == "no hubo compromiso"
                                        || view.widgetIntendedAction().value().toLowerCase() == "pas d'engagement"
                                        || view.widgetIntendedAction().value().toLowerCase() == "non si prende un impegno"
                                        || view.widgetIntendedAction().value().toLowerCase() == "sem compromiso") {
                                        $('#ExpectedCompletionDate').removeClass('required');
                                        view.intendedAction = "";
                                        view.recentlySaved = true;
                                        view.onSave();
                                        view.editState(false);
                                        view.enablePickers(false);
                                        view.onEnablePickers();
                                        view.messageSave(view.objLanguageLabels().lblYourChangeHasBeenSaved);
                                        view.messageValidation("");
                                        view.setupButtons();
                                        //// ALLOW USER TO LOGOUT WITHOUT WARNING
                                        global_SaveNotComplete = false;
                                    } else {
                                        alert("Expected Completion Date is required for this Intended Action.");
                                    }
                                } else {
                                    $('#ExpectedCompletionDate').removeClass('required');
                                    view.intendedAction = "";
                                    view.recentlySaved = true;
                                    view.onSave();
                                    view.editState(false);
                                    view.enablePickers(false);
                                    view.onEnablePickers();
                                    view.messageSave(view.objLanguageLabels().lblYourChangeHasBeenSaved);
                                    view.messageValidation("");
                                    view.setupButtons();
                                    //// ALLOW USER TO LOGOUT WITHOUT WARNING
                                    global_SaveNotComplete = false;
                                }
                            } else {
                                view.intendedAction = "";
                                view.recentlySaved = true;
                                view.onSave();
                                view.editState(false);
                                view.enablePickers(false);
                                view.onEnablePickers();
                                view.messageSave(view.objLanguageLabels().lblYourChangeHasBeenSaved);
                                view.messageValidation("");
                                view.setupButtons();
                                //// ALLOW USER TO LOGOUT WITHOUT WARNING
                                global_SaveNotComplete = false;
                            }
                        }
                    }
                } else {
                    //// USER CLICKED EDIT, CHANGE THE BUTTONS AND ENABLE RECORD / LOCATION WALKERS, DISABLE PICKERS, CHANGE COLOR BACK TO WHITE
                    view.setCancelObject();
                    view.editState(true);
                    view.enablePickers(true);
                    view.onEnablePickers();
                    view.messageSave("");
                    view.messageValidation("");
                    view.setupButtons();
                    view.enableDelete(true);
                    //// TURN ON WARNING IF USER TRIES TO LOG OUT
                    global_SaveNotComplete = true;
                }
            },

            onCancelDelete: function () {
                if (view.editState()) {
                    //// USER CLICKED CANCEL, CHANGE BACK TO NORMAL AND DO NOT SAVE, RELOAD ORIGINAL, DISABLE PICKERS, CHANGE COLOR BACK TO WHITE
                    //view.loadFileNumber();
                    if ($('#ExpectedCompletionDate').hasClass('required')) {
                        $('#ExpectedCompletionDate').removeClass('required');
                    }
                    view.cancelPickers();
                    view.objRec(view.collRec()[view.index]);
                    view.editState(false);
                    view.enablePickers(false);
                    view.onEnablePickers();
                    view.ignorePopups = true;
                    view.resetPickers();
                    view.ignorePopups = false;
                    view.messageSave("");
                    view.messageValidation("");
                } else {
                    //// USER CLICKED DELETE, CONFIRM WITH POPUP OR SOMETHING AND DELETE THE RECORD, DISABLE PICKERS, CHANGE COLOR BACK TO WHITE
                    var yesno = confirm(view.objLanguageLabels().lblAreYouSureYouWantToDeleteRecommendation);
                    if (yesno) {
                        view.collRec.markAsDeleted(view.objRec());
                        if (view.collRec().length > 0) {
                            view.collRec.save();
                            view.editState(false);
                            view.enablePickers(false);
                            view.index--;
                            if (view.index < 0) {
                                view.index = 0;
                            }
                            view.loadFileNumber();
                            if (view.collRec().length < 1) {
                                //// GO TO FIRST LOCATION AND FIRST RECORD
                                view.onFileFirst();
                            } else if (view.index >= view.collRec().length) {
                                //// GO TO FIRST FIRST RECORD
                                view.onFirst();
                            } else {
                                //// DO NOTHING
                            }
                            view.onEnablePickers();
                            view.ignorePopups = true;
                            view.resetPickers();
                            view.ignorePopups = false;
                            view.messageSave(view.objLanguageLabels().lblTheRecordHasBeenDeleted);
                        } else {
                            view.editState(false);
                            view.enablePickers(false);
                            view.onEnablePickers();
                            view.messageSave("");
                            view.messageValidation("");
                        }
                    }
                }
                view.setupButtons();
            }
        };


        ///////////////////////////////////////////
        //// SETUP BASE URL FOR DATA SERVICE AND LOAD ALL DATA
        var tempIndex = getRecId();
        if (tempIndex != null && tempIndex != undefined) {
            view.index = tempIndex;
        } else {
            view.index = 0;
        }
        view.loadFileNumber();
        view.loadPickers();
        view.loadRRLog();
        viewMaster.objLanguageSelector(viewMaster.KOLanguageSelector()[0]);


        ///////////////////////////////////////////
        //// ACTIVATE BINDINGS LAST
        ko.applyBindings(view, $("#view")[0]);
        ko.applyBindings(viewMaster, $("#viewMaster")[0]);


        ///////////////////////////////////////////
        //// SETUP KENDOUI
        //// TEXTBOXES

        //// ERROR WINDOW
        //        var windowNoLocation = $("#windowNoLocation");
        //        windowNoLocation.kendoWindow({
        //            width: "300px",
        //            height: "200px",
        //            title: "", // title added below with JQuery
        //            actions: ["Close"],
        //            animation: { open: { effects: "none" }, close: { effects: "default"} }
        //        });
        //        $("#windowNoLocation").closest(".k-window").css({
        //            top: 275,
        //            left: 400
        //        });
        //        $(document).find(".k-window-title").append("<img src='../../Home_{{VER}}/images/icons/warning/window_warning_24x24.png' align='left' alt='Warning Icon' class='windowIcon'/>  " + view.objLanguageLabels().lblNoLocationFoundTitle);

        //// MANUALLY RESET THE LANGUAGE USED ON MASTER PAGE POPUPS AND LOCAL POPUP TITLES
        $("#lblWindowResponded_Warning").html(viewMaster.objLanguageLabels().lblWindowResponded_Warning);
        $("#lblWindowResponded_AreYouSure").html(viewMaster.objLanguageLabels().lblWindowResponded_AreYouSure);
        $("#lblWindowResponded_ClickCancelToContinueWorking").html(viewMaster.objLanguageLabels().lblWindowResponded_ClickCancelToContinueWorking);
        $("#lblWindowResponded_ClickOKToExit").html(viewMaster.objLanguageLabels().lblWindowResponded_ClickOKToExit);
        $("#btnYes").html(viewMaster.objLanguageLabels().lblOK);
        $("#btnCancel").html(viewMaster.objLanguageLabels().lblCancel);
        $("#windowRecNotCompleted").prev().find(".k-window-title").html("<img src='../../Home_{{VER}}/images/icons/reports/document_information_24x24.png' align='left' alt='Information Icon' class='windowIcon'/>  " + viewMaster.objLanguageLabels().lblWindowResponded_Title);

        $("#lblWindowRespondedDatasheet_Warning").html(viewMaster.objLanguageLabels().lblWindowResponded_Warning);
        $("#lblWindowRespondedDatasheet_AreYouSure").html(viewMaster.objLanguageLabels().lblWindowResponded_AreYouSure);
        $("#lblWindowRespondedDatasheet_ClickCancelToContinueWorking").html(viewMaster.objLanguageLabels().lblWindowResponded_ClickCancelToContinueWorking);
        $("#lblWindowRespondedDatasheet_ClickOKToExit").html(viewMaster.objLanguageLabels().lblWindowResponded_ClickOKToExit);
        $("#btnYesDatasheet").html(viewMaster.objLanguageLabels().lblOK);
        $("#btnCancelDatasheet").html(viewMaster.objLanguageLabels().lblCancel);
        $("#windowRecNotCompletedDatasheet").prev().find(".k-window-title").html("<img src='../../Home_{{VER}}/images/icons/reports/document_information_24x24.png' align='left' alt='Information Icon' class='windowIcon'/>  " + viewMaster.objLanguageLabels().lblWindowResponded_Title);

        //// SETUP REC POPUP WINDOWS
        var windowRecReview = $("#windowRecReview");
        windowRecReview.kendoWindow({
            width: "300px",
            height: "235px",
            title: "", // title added below with JQuery
            actions: ["Close"],
            animation: { open: { effects: "none" }, close: { effects: "default"} }
        });
        $("#windowRecReview").closest(".k-window").css({
            top: 275,
            left: 400
        });
        $("#windowRecReview").prev().find(".k-window-title").html("<img src='../../Home_{{VER}}/images/icons/reports/document_information_24x24.png' align='left' alt='Information Icon' class='windowIcon'/>  " + view.objLanguageLabels().lblWindowRecReview_Title);

        var windowRecEdit = $("#windowRecEdit");
        windowRecEdit.kendoWindow({
            width: "300px",
            height: "215px",
            title: "", // title added below with JQuery
            actions: ["Close"],
            modal:true,
            animation: { open: { effects: "none" }, close: { effects: "default"} }
        });
        $("#windowRecEdit").closest(".k-window").css({
            top: 275,
            left: 400
        });
        $("#windowRecEdit").prev().find(".k-window-title").html("<img src='../../Home_{{VER}}/images/icons/reports/document_information_24x24.png' align='left' alt='Information Icon' class='windowIcon'/>  " + view.objLanguageLabels().lblWindowRecEdit_Title);

        var windowRecRecentSave = $("#windowRecRecentSave");
        windowRecRecentSave.kendoWindow({
            width: "300px",
            height: "215px",
            title: "", // title added below with JQuery
            actions: ["Close"],
            animation: { open: { effects: "none" }, close: { effects: "default"} }
        });
        $("#windowRecRecentSave").closest(".k-window").css({
            top: 275,
            left: 400
        });
        $("#windowRecRecentSave").prev().find(".k-window-title").html("<img src='../../Home_{{VER}}/images/icons/reports/document_information_24x24.png' align='left' alt='Information Icon' class='windowIcon'/>  " + view.objLanguageLabels().lblWindowRecRecentSave_Title);

        //// DATES
        var StatusDate = $("#StatusDate").kendoDatePicker({
            value: view.objRec().StatusDate(),
            format: "dd-MMM-yy",
            change: function (e) {
                var tempDate = null;
                if (this.value() == null) {
                    tempDate = null;
                    view.objRec().StatusDate(tempDate);
                } else {
                    tempDate = kendo.toString(new Date(this.value().toString().replace("00:", "12:")))
                    view.objRec().StatusDate(kendo.toString(tempDate));
                }
                view.onCloseAll();
            }
        }).data("kendoDatePicker");
        StatusDate.wrapper
            .find(".k-picker-wrap").addClass("expand-padding recInputDate")
            .find(".k-select").css("border", "none")
            .find(".k-icon").css("height", "12px").css("margin-top", "-2px");

        var ResponseDate = $("#ResponseDate").kendoDatePicker({
            value: view.objRec().ResponseDate(),
            format: "dd-MMM-yy",
            change: function (e) {
                var tempDate = null;
                if (this.value() == null) {
                    tempDate = null;
                    view.objRec().ResponseDate(tempDate);
                } else {
                    tempDate = kendo.toString(new Date(this.value().toString().replace("00:", "12:")))
                    view.objRec().ResponseDate(kendo.toString(tempDate));
                }
                view.onCloseAll();
            }
        }).data("kendoDatePicker");
        ResponseDate.wrapper
            .find(".k-picker-wrap").addClass("expand-padding recInputDateSmall")
            .find(".k-select").css("border", "none")
            .find(".k-icon").css("height", "12px").css("margin-top", "-2px");

        var MgmtRespDate;
        //view.enableMgmtFields
        //if (view.clientFeatures().search("\.+") > -1) {
        if ($.inArray("\+", view.clientFeatures()) > -1) {
            MgmtRespDate = $("#MgmtRespDate").kendoDatePicker({
                value: view.objRec().MgmtRespDate(),
                format: "dd-MMM-yy",
                change: function (e) {
                    var tempDate = null;
                    if (this.value() == null) {
                        tempDate = null;
                        view.objRec().MgmtRespDate(tempDate);
                    } else {
                        tempDate = kendo.toString(new Date(this.value().toString().replace("00:", "12:")))
                        view.objRec().MgmtRespDate(kendo.toString(tempDate));
                    }
                    view.onCloseAll();
                }
            }).data("kendoDatePicker");
            MgmtRespDate.wrapper
                .find(".k-picker-wrap").addClass("expand-padding recInputDateSmall")
                .find(".k-select").css("border", "none")
                .find(".k-icon").css("height", "12px").css("margin-top", "-2px");
        }

        var lvl3RespDate;
        if (view.clientFeatures().search("!") > -1) {
            lvl3RespDate = $('#lvl3RespDate').kendoDatePicker({
                value: view.objRec().ThirdLevelRespDate(),
                format: "dd-MMM-yy",
                change: function (e) {
                    var tempDate = this.value() == null ? null : kendo.toString(new Date(this.value().toString().replace("00:", "12:")))
                    view.objRec().ThirdLevelRespDate(kendo.toString(tempDate));
                    view.onCloseAll();
                }
            }).data("kendoDatePicker");
            lvl3RespDate.wrapper
                .find(".k-picker-wrap").addClass("expand-padding recInputDateSmall")
                .find(".k-select").css("border-style", "none")
                .find(".k-icon").css("height", "12px").css("margin-top", "1px");
        }

        var ExpectedCompletionDate = $("#ExpectedCompletionDate").kendoDatePicker({
            value: view.objRec().ExpectedCompletionDate(),
            format: "dd-MMM-yy",
            change: function (e) {
                var tempDate = null;
                if (this.value() == null) {
                    tempDate = null;
                    view.objRec().ExpectedCompletionDate(tempDate);
                } else {
                    tempDate = kendo.toString(new Date(this.value().toString().replace("00:", "12:")))
                    view.objRec().ExpectedCompletionDate(kendo.toString(tempDate));
                }
                view.onCloseAll();
            }
        }).data("kendoDatePicker");
        ExpectedCompletionDate.wrapper
            .find(".k-picker-wrap").addClass("expand-padding recInputDateSmall").css({"margin-top": "-1px"})
            .find(".k-select").css("border", "none")
            .find(".k-icon").css("height", "12px").css("margin-top", "-2px");

        //// DROPDOWN STYLES
        var Impact = $("#Impact");
        Impact.find(".k-dropdown-wrap").addClass("expand-padding recInputImpact").css("height", "14px").css("top", "-1px");
        Impact.find(".k-select").css("height", "14px");
        Impact.find(".k-icon").css("height", "12px").css("margin-top", "-2px");

        var RecStatus = $("#RecStatus");
        RecStatus.find(".k-dropdown-wrap").addClass("expand-padding recInputRecStatus").css("height", "14px").css("top", "-1px");
        RecStatus.find(".k-select").css("height", "14px");
        RecStatus.find(".k-icon").css("height", "12px").css("margin-top", "-2px");

        var RecPrimary = $("#RecPrimary");
        RecPrimary.find(".k-dropdown-wrap").addClass("expand-padding recInputHazard").css("height", "14px").css("top", "-1px");
        RecPrimary.find(".k-select").css("height", "14px");
        RecPrimary.find(".k-icon").css("height", "12px").css("margin-top", "-2px");

        var RecSecondary = $("#RecSecondary");
        RecSecondary.find(".k-dropdown-wrap").addClass("expand-padding recInputHazard").css("height", "14px").css("top", "-1px");
        RecSecondary.find(".k-select").css("height", "14px");
        RecSecondary.find(".k-icon").css("height", "12px").css("margin-top", "-2px");

        var LossExpectancyBefore = $("#LossExpectancyBefore");
        LossExpectancyBefore.find(".k-dropdown-wrap").addClass("expand-padding recInputRangeLarge").css("height", "14px").css("top", "-1px");
        LossExpectancyBefore.find(".k-select").css("height", "14px");
        LossExpectancyBefore.find(".k-icon").css("height", "12px").css("margin-top", "-2px");

        var LossExpectancyAfter = $("#LossExpectancyAfter");
        LossExpectancyAfter.find(".k-dropdown-wrap").addClass("expand-padding recInputRangeLarge").css("height", "14px").css("top", "-1px");
        LossExpectancyAfter.find(".k-select").css("height", "14px");
        LossExpectancyAfter.find(".k-icon").css("height", "12px").css("margin-top", "-2px");

        var CostToComplete = $("#CostToComplete");
        CostToComplete.find(".k-dropdown-wrap").addClass("expand-padding recInputRangeLarge").css("height", "14px").css("top", "-1px");
        CostToComplete.find(".k-select").css("height", "14px");
        CostToComplete.find(".k-icon").css("height", "12px").css("margin-top", "-2px");

        var IntendedAction = $("#IntendedAction");
        IntendedAction.find(".k-dropdown-wrap").addClass("expand-padding recInputIntendedActionSmall").css("height", "14px").css("top", "-1px");
        IntendedAction.find(".k-select").css("height", "14px");
        IntendedAction.find(".k-icon").css("height", "12px").css("margin-top", "-2px");

        var IntendedActionMgmt = $("#IntendedActionMgmt");
        IntendedActionMgmt.find(".k-dropdown-wrap").addClass("expand-padding recInputIntendedActionSmall").css("height", "14px").css("top", "-1px");
        IntendedActionMgmt.find(".k-select").css("height", "14px");
        IntendedActionMgmt.find(".k-icon").css("height", "12px").css("margin-top", "-2px");

        var MgmtRespAction;
        //if (view.clientFeatures().search("\.+") > -1) {
        if ($.inArray('\+', view.clientFeatures()) > -1) {
            MgmtRespAction = $("#MgmtRespAction");
            MgmtRespAction.find(".k-dropdown-wrap").addClass("expand-padding recInputIntendedActionSmall").css("height", "14px").css("top", "-1px");
            MgmtRespAction.find(".k-select").css("height", "14px");
            MgmtRespAction.find(".k-icon").css("height", "12px").css("margin-top", "-2px");
        } else {
            MgmtRespAction = $("#MgmtRespActionEmpty");
        }

        var ThirdLevelRespAction;
        if (view.clientFeatures().indexOf("!") > -1) {
            ThirdLevelRespAction = $("#lvl3ActionDD");
            ThirdLevelRespAction.find(".k-dropdown-wrap").addClass("expand-padding recInputIntendedActionSmall").css("height", "14px").css("top", "-1px");
            ThirdLevelRespAction.find(".k-select").css("height", "14px");
            ThirdLevelRespAction.find(".k-icon").css("height", "12px").css("margin-top", "-2px");
        }

        //////////////////////////////
        //// WHEN ALL DONE CALL THE RESET TO SYNC THE FIND AND THE PICKERS
        //// DISABLE THE PICKERS FROM EDITING
        view.onEnablePickers();
        view.ignorePopups = false;
        view.resetPickers();
        view.ignorePopups = false;


        ///////////////////////////////////////////
        //// KEYBOARD EVENT HANDLES
        ko.bindingHandlers.enterKey = {
            init: function (element, valueAccessor, allBindings, vm) {
                ko.utils.registerEventHandler(element, "keyup", function (event) {
                    if (event.keyCode === 13) {
                        ko.utils.triggerEvent(element, "change");
                        valueAccessor().call(vm, vm);
                    }
                    return true;
                });
            }
        };


        ///////////////////////////////////////////
        //// VALIDATION FUNCTIONS
        $("#RecYear").keydown(function (e) {
            // ALLOW: backspace, delete, tab, escape, enter, home, end, left, right, Ctrl+A, Ctrl+C, Ctrl+V
            if (e.keyCode == 46 || e.keyCode == 8 || e.keyCode == 9 || e.keyCode == 27 || e.keyCode == 13 || (e.keyCode >= 35 && e.keyCode <= 39) || (e.keyCode == 65 && e.ctrlKey === true) || (e.keyCode == 67 && e.ctrlKey === true) || (e.keyCode == 86 && e.ctrlKey === true)) {
                // DO NOTHING
                return;
            } else {
                // ALLOW NUMBERS ONLY OR STOP THE KEYPRESS
                if (e.shiftKey || (e.keyCode < 48 || e.keyCode > 57) && (e.keyCode < 96 || e.keyCode > 105)) {
                    e.preventDefault();
                }
            }
        });

        $("#RecMonth").keydown(function (e) {
            // ALLOW: backspace, delete, tab, escape, enter, home, end, left, right, Ctrl+A, Ctrl+C, Ctrl+V
            if (e.keyCode == 46 || e.keyCode == 8 || e.keyCode == 9 || e.keyCode == 27 || e.keyCode == 13 || (e.keyCode >= 35 && e.keyCode <= 39) || (e.keyCode == 65 && e.ctrlKey === true) || (e.keyCode == 67 && e.ctrlKey === true) || (e.keyCode == 86 && e.ctrlKey === true)) {
                // DO NOTHING
                return;
            } else {
                // ALLOW NUMBERS ONLY OR STOP THE KEYPRESS
                if (e.shiftKey || (e.keyCode < 48 || e.keyCode > 57) && (e.keyCode < 96 || e.keyCode > 105)) {
                    e.preventDefault();
                }
            }
        });

        $("#RecNumber").keydown(function (e) {
            // ALLOW: backspace, delete, tab, escape, enter, home, end, left, right, Ctrl+A, Ctrl+C, Ctrl+V
            if (e.keyCode == 46 || e.keyCode == 8 || e.keyCode == 9 || e.keyCode == 27 || e.keyCode == 13 || (e.keyCode >= 35 && e.keyCode <= 39) || (e.keyCode == 65 && e.ctrlKey === true) || (e.keyCode == 67 && e.ctrlKey === true) || (e.keyCode == 86 && e.ctrlKey === true)) {
                // DO NOTHING
                return;
            } else {
                // ALLOW NUMBERS ONLY OR STOP THE KEYPRESS
                if (e.shiftKey || (e.keyCode < 48 || e.keyCode > 57) && (e.keyCode < 96 || e.keyCode > 105)) {
                    e.preventDefault();
                }
            }
        });

        //        $("#RecSubletter").keydown(function (e) {
        //            // ALLOW: backspace, delete, tab, escape, enter, home, end, left, right, Ctrl+A, Ctrl+C, Ctrl+V
        //            if (e.keyCode == 46 || e.keyCode == 8 || e.keyCode == 9 || e.keyCode == 27 || e.keyCode == 13 || (e.keyCode >= 35 && e.keyCode <= 39) || (e.keyCode == 65 && e.ctrlKey === true) || (e.keyCode == 67 && e.ctrlKey === true) || (e.keyCode == 86 && e.ctrlKey === true)) {
        //                // DO NOTHING
        //                return;
        //            } else {
        //                // ALLOW LETTERS ONLY OR STOP THE KEYPRESS
        //                if (e.keyCode < 65 || e.keyCode > 90) {
        //                    e.preventDefault();
        //                }
        //            }
        //        });

        //        $("#RecSubletter").keyup(function (e) {
        //            // CONVERT TO UPPERCASE
        //            if (e.keyCode > 64 && e.keyCode < 91) {
        //                $(this).val($(this).val().toUpperCase());
        //            }
        //        });

        //        $("#ActualCostToComplete").keydown(function (e) {
        //            // ALLOW: backspace, delete, tab, escape, enter, home, end, left, right, Ctrl+A, Ctrl+C, Ctrl+V
        //            if (e.keyCode == 46 || e.keyCode == 8 || e.keyCode == 9 || e.keyCode == 27 || e.keyCode == 13 || (e.keyCode >= 35 && e.keyCode <= 39) || (e.keyCode == 65 && e.ctrlKey === true) || (e.keyCode == 67 && e.ctrlKey === true) || (e.keyCode == 86 && e.ctrlKey === true)) {
        //                // DO NOTHING
        //                return;
        //            } else {
        //                // ALLOW NUMBERS AND DECIMAL ONLY OR STOP THE KEYPRESS
        //                if (e.shiftKey || (e.keyCode < 48 || e.keyCode > 57) && (e.keyCode < 96 || e.keyCode > 105)) {
        //                    e.preventDefault();
        //                }
        //            }
        //        });
    });
</script>

</asp:Content>
