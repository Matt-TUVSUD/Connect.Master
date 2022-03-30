<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="tab_rectracking.aspx.vb" Inherits="GRC.Connect.Web.tab_rectracking_infared" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="Stylesheet" type="text/css" href="../../css/pages/rectracking.css" />
    <script src="../../Lib_{{VER}}/knockoutkendo/knockout-kendo.min.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCLocationListingIR.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCLocationListingIR.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/Findings.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/Findings.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCRecCompletedLossEstList.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCRecCurrentLossEstList.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCRecEstCostToCompleteList.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCRecImpactList.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCRecIntendedActionList.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCTranslationMgmtIntendedAction.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/ViewCCTranslationMgmtIntendedAction.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCRecPrimaryTypeList.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCRecSecondaryTypeList.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Generated/ViewCCRecStatusList.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Mapping/moment.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div class="headerFindCriteria" id="viewFindCriteria_rectracking" data-bind="with: viewFindCriteria_rectracking">
        <label data-bind="text: $parent.findCriteria" id="findCriteria"></label>&nbsp;
    </div>
    <div id="view_RecTracking" data-bind="with: view_RecTracking">
    <!-- TABLE FOR COMPANY / ADDRESS INFORMATION -->
    <!-- SPECIFIC STYLES TO ROWS OR COLUMNS SHOULD BE INLINE -->
    <div class="tableDiv">
        <div class="tabRow">
            <span class="companyLabels1"><label data-bind="text: $parent.objLanguageLabels().lblGRCLocNo, css: { findOn: $parent.objFind().findFileNo, findOff: !$parent.objFind().findFileNo }">GRC Loc. No.</label></span>
            <span class="companyInputs1"><input data-bind="value: $parent.objListing().FileNo, css: { findOnInput: $parent.objFind().findFileNo, findOffInput: !$parent.objFind().findFileNo }" id="FileNo" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs1" tabindex="1" /></span>
            <span class="companyLabels2"><label data-bind="text: $parent.objLanguageLabels().lblClientLocNo, css: { findOn: $parent.objFind().findClientLocNo, findOff: !$parent.objFind().findClientLocNo }">Client Loc. No.</label></span>
            <span class="companyInputs2"><input data-bind="value: $parent.objListing().ClientLocNo, css: { findOnInput: $parent.objFind().findClientLocNo, findOffInput: !$parent.objFind().findClientLocNo }" id="ClientLocNo" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs2" tabindex="2" /></span>
            <span class="companyLabels5"><label data-bind="text: $parent.objLanguageLabels().lblLatitude, css: { findOn: $parent.objFind().findLatitude, findOff: !$parent.objFind().findLatitude }">Latitude</label></span>
            <span class="companyInputs4"><input data-bind="value: $parent.objListing().Latitude, css: { findOnInput: $parent.objFind().findLatitude, findOffInput: !$parent.objFind().findLatitude }" id="Latitude" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs4" tabindex="3"  /></span>
            <span class="companyLabels4"><label data-bind="text: $parent.objLanguageLabels().lblLongitude, css: { findOn: $parent.objFind().findLongitude, findOff: !$parent.objFind().findLongitude }">Longitude</label></span>
            <span class="companyInputs4"><input data-bind="value: $parent.objListing().Longitude, css: { findOnInput: $parent.objFind().findLongitude, findOffInput: !$parent.objFind().findLongitude }" id="Longitude" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs4" tabindex="4"  /></span>
        </div>
        <div class="tabRow">
            <span class="companyLabels1"><label data-bind="text: $parent.objLanguageLabels().lblAddress1, css: { findOn: $parent.objFind().findAddress1, findOff: !$parent.objFind().findAddress1 }">Address</label></span>
            <span class="companyInputs6"><input data-bind="value: $parent.objListing().Address1, css: { findOnInput: $parent.objFind().findAddress1, findOffInput: !$parent.objFind().findAddress1 }" id="Address1" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs6" tabindex="5"  /></span>
            <span class="companyLabels3"><label data-bind="text: $parent.objLanguageLabels().lblDivisionName, css: { findOn: $parent.objFind().findDivision, findOff: !$parent.objFind().findDivision }">Division Name</label></span>
            <span class="companyInputs5"><input data-bind="value: $parent.objListing().Division, css: { findOnInput: $parent.objFind().findDivision, findOffInput: !$parent.objFind().findDivision }" id="Division" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="6"  /></span>
        </div>
        <div class="tabRow">
            <span class="companyLabels1"><label data-bind="text: $parent.objLanguageLabels().lblCity, css: { findOn: $parent.objFind().findCity, findOff: !$parent.objFind().findCity }">City</label></span>
            <span class="companyInputs1"><input data-bind="value: $parent.objListing().City, css: { findOnInput: $parent.objFind().findCity, findOffInput: !$parent.objFind().findCity }" id="City" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs1" tabindex="7"  /></span>
            <span class="stateLabels"><label data-bind="text: $parent.objLanguageLabels().lblState, css: { findOn: $parent.objFind().findStProv, findOff: !$parent.objFind().findStProv }">State</label></span>
            <span class="stateInputs"><input data-bind="value: $parent.objListing().StProv, css: { findOnInput: $parent.objFind().findStProv, findOffInput: !$parent.objFind().findStProv }" id="StProv" class="k-autocomplete k-input inputNoEdit inputLeft stateInputs" tabindex="8"  /></span>
            <span class="countryLabels"><label data-bind="text: $parent.objLanguageLabels().lblCountry, css: { findOn: $parent.objFind().findCountry, findOff: !$parent.objFind().findCountry }">Country</label></span>
            <span class="countryInputs"><input data-bind="value: $parent.objListing().Country, css: { findOnInput: $parent.objFind().findCountry, findOffInput: !$parent.objFind().findCountry }" id="Country" class="k-autocomplete k-input inputNoEdit inputLeft countryInputs" tabindex="9"  /></span>
            <span class="postalLabels"><label data-bind="text: $parent.objLanguageLabels().lblPostalCode, css: { findOn: $parent.objFind().findZip, findOff: !$parent.objFind().findZip }">Postal</label></span>
            <span class="postalInputs"><input data-bind="value: $parent.objListing().Zip, css: { findOnInput: $parent.objFind().findZip, findOffInput: !$parent.objFind().findZip }" id="Zip" class="k-autocomplete k-input inputNoEdit inputLeft postalInputs" tabindex="10"  /></span>
            <span class="companyLabels3"><label data-bind="text: $parent.objLanguageLabels().lblFacilityName, css: { findOn: $parent.objFind().findFacility, findOff: !$parent.objFind().findFacility }">Facility Name</label></span>
            <span class="companyInputs5"><input data-bind="value: $parent.objListing().Facility, css: { findOnInput: $parent.objFind().findFacility, findOffInput: !$parent.objFind().findFacility }" id="Facility" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="11"  /></span>
        </div>
        <div class="tabRow">
            <!-- BUTTONS FOR LOCATION / FILE NUMBER WALK / FIND LOCATION -->
            <span class="companyLabels1"></span>
            <span class="buttonContainerLocationLoading" style="display:flex;">
                <span><button data-bind="click: $parent.onFileFirst, enable: $parent.enableFilePrev" type="button" class="grcBlueBtn pagerBtn" id="btnFileFirst" tabindex="15" style="margin-right:2px;"><i class="fas fa-step-backward"></i></button></span>
                <span><button data-bind="click: $parent.onFilePrevious, enable: $parent.enableFilePrev" type="button" class="grcBlueBtn pagerBtn" id="btnFilePrevious" tabindex="16"><i class="fas fa-caret-left"></i></button></span>
                <span class="buttonFileRecordLabel" style="width: 130px;">&nbsp;<label data-bind="text: $parent.objLanguageLabels().lblFileRecord">Location</label> <input data-bind="    value: $parent.txtFileRecordNumber" id="txtFileRecordNumber" class="k-autocomplete k-input inputCenter inputNoEdit buttonInput" style="width: 80px; margin-bottom: 3px;" readonly="true" />&nbsp;</span>
                <span><button data-bind="click: $parent.onFileNext, enable: $parent.enableFileNext" type="button" class="grcBlueBtn pagerBtn" id="btnFileNext" tabindex="17" style="margin-right:2px;"><i class="fas fa-caret-right"></i></button></span>
                <span><button data-bind="click: $parent.onFileLast, enable: $parent.enableFileNext" type="button" class="grcBlueBtn pagerBtn" id="btnFileLast" tabindex="18"><i class="fas fa-step-forward"></i></button></span>
                <span>&nbsp;</span>
                <span><button data-bind="click: $parent.onFindClear, css: { hidden: $parent.findEngaged }" type="button" class="k-button buttonFindClearShape hidden" tabindex="13">Clear Find</button></span>
                <span><button data-bind="click: $parent.onFind" class="grcBlueBtn findBtn" type="submit" tabindex="14">Find</button></span>
            </span>
            <!-- END BUTTONS FOR LOCATION / FILE NUMBER WALK / FIND LOCATION -->
            <span class="companyLabels6"><label data-bind="text: $parent.objLanguageLabels().lblCustomerAccess, css: { findOn: $parent.objFind().findCustomAccess, findOff: !$parent.objFind().findCustomAccess }">Custom Access</label></span>
            <span class="companyInputs5"><input data-bind="value: $parent.objListing().CustomAccess, css: { findOnInput: $parent.objFind().findCustomAccess, findOffInput: !$parent.objFind().findCustomAccess }" id="CustomAccess" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="12"  /></span>
        </div>
    </div>
    <!-- END TABLE FOR COMPANY / ADDRESS INFORMATION -->

    <!-- TABLE FOR RECOMMENDATION TRACKING INFORMATION -->
    <!-- SPECIFIC STYLES TO ROWS OR COLUMNS SHOULD BE INLINE -->
    <div class="tableDiv">
        <div class="tabBannerHeader" style="justify-content: flex-start; margin-bottom:5px;">
            <label style="margin-left: 10px; font-size:16px;">Recommendation Tracking</label>
        </div>
    </div>
    <div class="tableDivAutoBorders">
    <div class="tableDiv">
        <div class="tabRow">
            <span class="bufferLeft" style="height: 21px;"></span>
            <span class="recLabelLeft" style="height: 21px;"><label data-bind="text: $parent.objLanguageLabels().lblRecNo">Rec. No.</label></span>
            <span class="recInputRecNo" style="height: 21px;">
                <input data-bind="value: $parent.objRec().RecYear" id="RecYear" class="k-autocomplete k-input inputNoEdit inputLeft" maxlength="4" readonly="readonly" style="width: 40px;" />
                <input data-bind="value: $parent.objRec().RecMonth" id="RecMonth" class="k-autocomplete k-input inputNoEdit inputLeft" maxlength="2" readonly="readonly" style="width: 20px;" />
                <input data-bind="value: $parent.objRec().RecNumber" id="RecNumber" class="k-autocomplete k-input inputNoEdit inputLeft" maxlength="3" readonly="readonly" style="width: 30px;" />
            </span>
            <span class="recLabelRecImpact" style="height: 21px;"><label data-bind="text: $parent.objLanguageLabels().lblRecImpact">Rec. Impact</label></span>
            <span class="recInputRecImpact" id="Impact" style="height: 21px;">
                <select id="clearImpact" class="inputNoEdit recInputRecImpact" data-bind="kendoDropDownList: {
    data: $parent.KOcollImpactList,
    value: $parent.objRec().Impact,
    enabled: $parent.enableAlwaysOff,
    close: $parent.onCloseAll,
    widget: $parent.widgetImpact
}"></select>
            </span>
            <span class="recLabelRecStatus" style="height: 21px;"><label data-bind="text: $parent.objLanguageLabels().lblRecStatus">Rec. Status</label></span>
            <span class="recInputRec" id="RecStatus" style="height: 21px;">
                <select  class="inputNoEdit recInputRec" data-bind="kendoDropDownList: {
    data: $parent.KOcollStatuslist,
    value: $parent.objRec().RecStatus,
    enabled: $parent.enableAlwaysOff,
    close: $parent.onCloseAll,
    widget: $parent.widgetRecStatus
}"></select>
            </span>
            <span class="recLabelRecSmall" style="height: 21px; width: 40px;"><label data-bind="text: $parent.objLanguageLabels().lblHistory">History</label></span>
            <span class="recInputRecCode" style="height: 21px;"><input data-bind="value: $parent.objRec().History" id="History" class="k-autocomplete k-input inputNoEdit inputLeft recInputRecCode" readonly="readonly"/></span>
            <span class="recLabelRecSmall" style="padding-left: 11px; height: 21px;"><label data-bind="text: $parent.objLanguageLabels().lblStatusDate">Status Date</label></span> 
            <span class="recInputDate" style="height: 21px;"><input data-bind="" id="StatusDate" class="k-numerictextbox inputNoEdit recInputDate" readonly="readonly" /></span>
            <span class="bufferRight" style="height: 21px;"></span>
        </div>
        <div class="tabRow">
            <span class="bufferLeft"></span>
            <span class="recLabelLeft" style="height: 21px;"><label data-bind="text: $parent.objLanguageLabels().lblSeverity">Severity</label></span>
            <span class="recInputRecCode" style="height: 21px;"><input data-bind="value: $parent.objRec().Severityrating" id="Severityrating" class="k-autocomplete k-input inputNoEdit inputLeft recInputRecCode" readonly="readonly"/></span>
            <span class="recLabelHazard"><label data-bind="text: $parent.objLanguageLabels().lblRecPrimary">Primary Rec. Type</label></span>
            <span class="recInputHazard"><input readonly="readonly" data-bind="value: $parent.objRec().RecPrimary" id="RecPrimaryText" class="k-autocomplete k-input inputNoEdit inputLeftKendo recInputHazard" /></span>
            <span class="recLabelSecondary"><label data-bind="text: $parent.objLanguageLabels().lblRecSecondary">Secondary Rec. Type</label></span>
            <span class="recInputHazard"><input readonly="readonly" data-bind="value: $parent.objRec().RecSecondary" id="RecSecondaryText" class="k-autocomplete k-input inputNoEdit inputLeftKendo recInputHazard" /></span>
            <span class="bufferRight" style="padding-left: 7px;"></span>
        </div>
        <div class="tabRow">
            <span class="bufferLeft"></span>
            <span class="recLabelLeft"><label data-bind="text: $parent.objLanguageLabels().lblRecKeyWord">Rec. Key Word</label></span>
            <span class="recInputKeyWordsLong"><input data-bind="value: $parent.objRec().Recommendation" id="Recommendation" class="k-autocomplete k-input inputNoEdit inputLeftKendo recInputKeyWordsLong" readonly="readonly" /></span>
            <span class="bufferRight" style="padding-left: 5px;"></span>
        </div>
        <div class="tabRow">
            <span class="borderBottom bufferLeft" style="height: 5px;"></span>
            <span class="borderBottom" style="height: 5px; width: 782px;"></span> 
            <span class="borderBottom bufferRight" style="height: 5px;"></span>
        </div>
        <div class="tabRow">
            <span class="bufferLeft" style="height: 5px;"></span>
            <span class="" style="height: 5px; width: 782px;"></span>
            <span class="bufferRight" style="height: 5px;"></span>
        </div>


        <div class="tabRow">
            <span class="bufferLeft"></span>
            <span class="recLabelLeft"><label data-bind="text: $parent.objLanguageLabels().lblEquipmentNo">Equipment No.</label></span>
            <span class="recInputRecCode"><input data-bind="value: $parent.objRec().Itemno" id="Itemno" class="k-autocomplete k-input inputNoEdit inputLeft recInputRecCode" readonly="readonly"/></span>
            <span class="recLabelFindingNo"><label data-bind="text: $parent.objLanguageLabels().lblFindingNo">Finding No.</label></span>
            <span class="recInputRecCode"><input data-bind="value: $parent.objRec().Findingno" id="Findingno" class="k-autocomplete k-input inputNoEdit inputLeft recInputRecCode" readonly="readonly"/></span>
            <span class="recLabelRecPlantArea"><label data-bind="text: $parent.objLanguageLabels().lblPlantArea">Plant Area</label></span>
            <span class="recLabelRecLarge"><input data-bind="value: $parent.objRec().PlantAreaAffected" id="PlantAreaAffected" class="k-autocomplete k-input inputNoEdit inputLeft recInputRec" readonly="readonly"/></span>
            <span class="recLabelIntendedAction" style="padding-left: 32px;"><label data-bind="text: $parent.objLanguageLabels().lblProbableEquipmentDamageCost">Prob. Equip. Dam. Cost</label></span>
            <span class="recInputDateSmall"><input data-bind="value: $parent.objRec().ProbableEquipmentDamageCost" id="ProbableEquipmentDamageCost" class="k-autocomplete k-input inputNoEdit inputLeft recInputDateSmall" readonly="readonly"/></span>
            <span class="bufferRight"></span>
        </div>
        <div class="tabRow">
            <span class="bufferLeft"></span>
            <span class="recLabelLeft"><label data-bind="text: $parent.objLanguageLabels().lblFaultType">Fault Type</label></span>
            <span class="recInputRecFaultType"><input data-bind="value: $parent.objRec().FaultType" id="FaultType" class="k-autocomplete k-input inputNoEdit inputLeft recInputRecFaultType" readonly="readonly"/></span>
            <span class="recLabelLengthOfBusinessInterruption"><label data-bind="text: $parent.objLanguageLabels().lblLengthOfBusinessInterruption">Length Of Bus. Inter.</label></span>
            <span class="recInputRecCode"><input data-bind="value: $parent.objRec().LengthOfBusinessInterruption" id="LengthOfBusinessInterruption" class="k-autocomplete k-input inputNoEdit inputLeft recInputRecCode" readonly="readonly"/></span>
            <span class="recLabelRecPlantArea"><label data-bind="text: $parent.objLanguageLabels().lblDetectedWith">Detected With</label></span>
            <span class="recInputRec"><input data-bind="value: $parent.objRec().DetectedWith" id="DetectedWith" class="k-autocomplete k-input inputNoEdit inputLeft recInputRec" readonly="readonly"/></span>
            <span class="recLabelRecLarge"><label data-bind="text: $parent.objLanguageLabels().lblRedundancySpare">Redundancy Spare</label></span>
            <span class="recInputRecRedundancy"><input data-bind="value: $parent.objRec().RedundancySpare" id="RedundancySpare" class="k-autocomplete k-input inputNoEdit inputLeft recInputRecRedundancy" readonly="readonly"/></span>
            <span class="bufferRight"></span>
        </div>
        <div class="tabRow">
            <span class="bufferLeft"></span>
            <span class="recLabelLeft"><label data-bind="text: $parent.objLanguageLabels().lblRespDate">Resp. Date</label></span>
            <span class="recInputDateSmall"><input data-bind="" id="ResponseDate" class="k-numerictextbox inputNoEdit recInputDateSmall" /></span>
            <span class="recLabelRespSmall"><label data-bind="text: $parent.objLanguageLabels().lblRespForm">Resp. From</label></span>
            <span class="recInputRespSmall"><input data-bind="value: $parent.objRec().ResponseFrom" id="ResponseFrom" class="k-autocomplete k-input inputNoEdit inputLeftKendo recInputRespSmall" /></span>
            <span class="recLabelIntendedActionSmall"><label data-bind="text: $parent.objLanguageLabels().lblRecIntendedAction">Rec. Intended Action</label></span>
            <span class="recInputIntendedActionSmall" id="IntendedAction">
                <select class="inputNoEdit recInputIntendedActionSmall" data-bind="kendoDropDownList: {
    data: $parent.KOcollIntendedaction,
    value: $parent.objRec().IntendedAction,
    enabled: $parent.enablePickers,
    close: $parent.onCloseIntendedAction,
    widget: $parent.widgetIntendedAction
}"></select>
            </span>            
            <span class="recLabelExpCompleteSmall"><label data-bind="text: $parent.objLanguageLabels().lblExpdComplDate">Exp'd Compl. Date</label></span>
            <span class="recInputDateSmall"><input data-bind="" id="ExpectedCompletionDate" class="k-numerictextbox inputNoEdit recInputDateSmall" /></span>
            <span class="bufferRight" style="padding-left: 4px;"></span>
        </div>
        <div class="tabRow">
            <span class="bufferLeft" style="height: 32px;"></span>
            <span class="recLabelLeft" style="height: 32px;"><label data-bind="text: $parent.objLanguageLabels().lblFacilityComment">Facility Comment</label></span>
            <span class="recInputCommentsLarge" style="height: 32px;">
                <textarea data-bind="value: $parent.objRec().PlantComment, attr: { title: $parent.objRec().PlantComment }" id="PlantComment" class="k-textbox inputNoEdit recInputCommentsLarge" rows="8" cols="20" style="white-space: pre-wrap;"></textarea>
            </span>
            <span class="bufferRight" style="height: 32px; padding-left: 4px;"></span>
        </div>

        <!-- THE BELOW FIELDS WILL BE CHANGED AND UN COMMENTED WHEN GARY ADDS NEW MANAGER RESPONSE FIELDS TO THE DB -->
        <div class="tabRow" data-bind="if: $parent.clientFeatures().search('Q') > -1">
            <span class="borderBottom bufferLeft" style="height: 5px;"></span>
            <span class="borderBottom" style="height: 5px; width: 782px;"></span> 
            <span class="borderBottom bufferRight" style="height: 5px;"></span>
        </div>
        <div class="tabRow" data-bind="if: $parent.clientFeatures().search('Q') > -1">
            <span class="bufferLeft" style="height: 5px;"></span>
            <span class="" style="height: 5px; width: 782px;"></span> 
            <span class="bufferRight" style="height: 5px;"></span>
        </div>
        <div class="tabRow" data-bind="if: $parent.clientFeatures().search('Q') > -1">
            <span class="bufferLeft"></span>
            <span class="recLabelLeft"><label data-bind="text: $parent.objLanguageLabels().lblMgmtRespDate">Mgmt. Resp. Date</label></span>
            <span class="recInputDateSmall"><input data-bind="" id="MgmtRespDate" class="k-numerictextbox inputNoEdit recInputDateSmall" /></span>
            <span class="recLabelRespSmall"><label data-bind="text: $parent.objLanguageLabels().lblMgmtRespFrom">Resp. From</label></span>
            <span class="recInputRespSmall"><input data-bind="value: $parent.objRec().MgmtRespFrom" id="MgmtRespFrom" class="k-autocomplete k-input inputNoEdit inputLeft recInputRespSmall" /></span>
            <span class="recLabelIntendedActionSmall"><label data-bind="text: $parent.objLanguageLabels().lblMgmtRespAction">Mgmt. Action</label></span>
            <span class="recInputIntendedActionSmall" id="MgmtRespAction">
                <select class="inputNoEdit recInputIntendedActionSmall" data-bind="kendoDropDownList: {
    data: $parent.KOcollIntendedactionMgmt,
    value: $parent.objRec().MgmtRespAction,
    enabled: $parent.enablePickers,
    close: $parent.onCloseMgmtIntendedAction,
    widget: $parent.widgetIntendedActionMgmt
}"></select>
            </span>
        </div>
        <div class="tabRow" data-bind="if: $parent.clientFeatures().search('Q') > -1">
            <span class="bufferLeft" style="height: 32px;"></span>
            <span class="recLabelLeft" style="height: 32px;"><label data-bind="text: $parent.objLanguageLabels().lblMgmtComment">Mgmt. Comment</label></span>
            <span class="recInputCommentsLarge" style="height: 32px;">
                <textarea data-bind="value: $parent.objRec().MgmtRespComment, attr: { title: $parent.objRec().MgmtRespComment }" id="MgmtRespComment" class="k-textbox inputNoEdit recInputCommentsLarge" rows="8" cols="20" style="white-space: pre-wrap;"></textarea>
            </span>
            <span class="bufferRight" style="height: 32px; padding-left: 4px"></span>
        </div>
        <div class="tabRow" style="height: 0px;">
            <span id="MgmtRespDateEmpty" style="height: 0px;"></span>
            <span id="MgmtRespActionEmpty" style="height: 0px;"></span>
        </div>
        <!-- THE ABOVE FIELDS WILL BE CHANGED AND UN COMMENTED WHEN GARY ADDS NEW MANAGER RESPONSE FIELDS TO THE DB -->

            <!-- START 3rd Level Field Markup -->
            <div data-bind="if: $parent.clientFeatures().search('@') > -1">
                <div class="tabRow">
                    <span class="bufferLeft"></span><span class="recLabelLeft"><label>3rd Lvl Resp. Date</label></span>
                    <span class="recInputDateSmall"><input data-bind="" id="lvl3RespDate" class="k-numerictextbox inputNoEdit recInputDateSmall" /></span>
                    <span class="recLabelRespSmall"><label data-bind="">Resp. From</label></span>
                    <span class="recInputRespSmall"><input data-bind="value: $parent.objRec().ThirdLevelRespFrom" id="lvl3RespFrom" class="k-autocomplete k-input inputNoEdit inputLeftKendo recInputRespSmall" /></span>
                    <span class="recLabelIntendedActionSmall"><label>3rd Lvl Action</label></span>
                    <span class="recInputIntendedActionSmall" id="lvl3ActionDD">
                         <select class="inputNoEdit recInputIntendedActionSmall" data-bind="kendoDropDownList: {
    data: $parent.KOcollIntendedactionThirdLvl,
    value: $parent.objRec().ThirdLevelRespAction,
    enabled: $parent.enablePickers,
    close: $parent.onCloseThirdLvlIntendedAction,
    widget: $parent.widgetIntendedActionThirdLevel
                    }"></select>
                    </span>
                </div>
                <div class="tabRow">
                    <span class="bufferLeft" style="height: 32px;"></span>
                    <span class="recLabelLeft" style="height: 32px;">
                        <label data-bind="">3rd Lvl Comment</label></span>
                    <span class="recInputCommentsLarge" style="height: 32px;">
                        <textarea data-bind="value: $parent.objRec().ThirdLevelRespComment" id="lvl3Commment" class="k-textbox inputNoEdit recInputCommentsLarge" rows="8" cols="20" style="white-space: pre-wrap;"></textarea>
                    </span>
                </div>
            </div>
            <!-- END 3rd Level Field Markup -->
            <div class="tabRow">
                <span class="bufferLeft"></span>
                <span class="buttonCell" style="text-align: left; padding-left: 89px;"><button class="grcBlueBtn tabActionBtn" id="editSave" data-bind="click: $parent.onEditSave, text: $parent.txtEditSave, enable: $parent.enableNoLocationFound">Edit</button></span>
                <span class="buttonCell" style="text-align: left;"><button class="grcRedBtn tabActionBtn" id="cancelDelete" data-bind="visible: $parent.enableDelete, click: $parent.onCancelDelete, text: $parent.txtCancelDelete, enable: $parent.enableNoLocationFound">Delete</button></span>
                <span class="buttonCellRecord">
                    <div class="buttonContainer" style="display:flex;">
                        <span><button data-bind="click: $parent.onFirst, enable: $parent.enablePrev" class="grcBlueBtn pagerBtn" id="btnFirst" style="margin-right:2px;"><i class="fas fa-step-backward"></i></button></span>
                        <span><button data-bind="click: $parent.onPrevious, enable: $parent.enablePrev" class="grcBlueBtn pagerBtn" id="btnPrevious"><i class="fas fa-caret-left"></i></button></span>
                        <span class="buttonRecordLabel">&nbsp;<label data-bind="text: $parent.objLanguageLabels().lblRecord">Record</label> <input data-bind="    value: $parent.txtRecordNumber" id="txtRecordNumber" class="k-autocomplete k-input inputCenter inputNoEdit buttonInput" style="margin-bottom: 3px;" readonly="true" />&nbsp;</span>
                        <span><button data-bind="click: $parent.onNext, enable: $parent.enableNext" class="grcBlueBtn pagerBtn" id="btnNext" style="margin-right:2px;"><i class="fas fa-caret-right"></i></button></span>
                        <span><button data-bind="click: $parent.onLast, enable: $parent.enableNext" class="grcBlueBtn pagerBtn" id="btnLast"><i class="fas fa-step-forward"></i></button></span>
                    </div>
                </span>
                <span class="buttonCell"><a id="hypRecDatasheet" href="#" data-bind="click: $parent.onDatasheetView, enable: $parent.enableNoLocationFound">Datasheet View</a></span>
                <span class="bufferRight"></span>
            </div>
            <div class="tabRow">
                <span class="bufferLeftAutoHeight"></span>
                <span class="messageHeight" style="padding-left: 0px;">
                    &nbsp;<label class="messageNotice" data-bind="text: $parent.messageSave"></label><label class="messageError" data-bind="    text: $parent.messageValidation"></label>
                </span> 
                <span class="bufferRight"></span>
            </div>
            <div class="tabRow">
                <span class="bufferLeft"></span>
                <span class="" style="height: 0px;">&nbsp;</span> 
                <span class="bufferRight"></span>
            </div>
        </div>
        </div>
        <!-- END TABLE FOR RECOMMENDATION TRACKING INFORMATION -->

    <!-- AREA FOR ERROR AND NOTICE MESSAGES -->
    <div style="padding-top: 0px; text-align: center;"><label class="messageError" data-bind="text: $parent.messageError"></label><label class="messageNotice" data-bind="    text: $parent.messageNotice"></label><label class="messageWarning" data-bind="    text: $parent.messageWarning"></label>&nbsp;</div>

    <!-- ERROR WINDOW FOR NO RECORD FOUND NOTIFICATION -->
    <div id="windowNoLocation" class="windowContent" style="font-size:13px;">
        <div><img src="../images/icons/warning/sign_warning_32x32.png" align="left" alt="Warning" class="windowImage" /></div>
        <div style="margin-bottom:5px;"><label data-bind="text: $parent.objLanguageLabels().lblNoLocationFoundMessage">Warning: There are no recommendation records found for this location.</label></div>
        <div style="margin-bottom:5px;"><label data-bind="text: $parent.objLanguageLabels().lblNoLocationFoundDescription">Click the below button to go back to the Location Details page, or use the Location Navigation buttons to go to another location record.</label></div>
        <div style="justify-content: center; width:100%; display:flex;"><button class="grcBlueBtn" data-bind="text: $parent.objLanguageLabels().lblGoBackToDetails, click: $parent.onLocationDetailsRedirect">Go Back To Location Details</button></div>
    </div>

</div>

<%--<div style="width: 987px; padding-top: 0px; padding-left: 0px; padding-right: 0px; padding-bottom: 0px; clear: both;"></div>--%>

<script type="text/javascript">
    $(document).ready(function () {
        ///////////////////////
        // LOAD SESSION VARIABLES
        var dsLanguageLabels = {
            // COMPANY INFORMATION
            lblGRCLocNo: "GRC Loc. No.",
            lblClientLocNo: "Client Loc. No.",
            lblAddress1: "Address",
            lblCity: "City",
            lblState: "State",
            lblPostalCode: "Postal",
            lblCountry: "Country",
            lblLatitude: "Latitude",
            lblLongitude: "Longitude",
            lblDivisionName: "Division Name",
            lblFacilityName: "Facility Name",
            lblCustomerAccess: "Custom Access",

            // REC TRACKING
            lblRecNo: "Rec. No.",
            lblRecImpact: "Rec. Impact",
            lblSeverity: "Severity",
            lblRecStatus: "Rec. Status",
            lblHistory: "History",
            lblStatusDate: "Status Date",
            //lblHazard: "Hazard",
            lblRecPrimary: "Primary Rec. Type",
            lblRecSecondary: "Secondary Rec. Type",
            //lblCurrentLossEst: "Current Loss Est.",
            //lblCompletedLossEst: "Completed Loss Est.",
            //lblEstCostToComplete: "Est. Cost to Complete",
            //lblSavingsRatio: "Savings Ratio",
            //lblActCostToComplete: "Act. Cost to Complete",
            //lblActual: "Actual",
            //lblRange: "Range",
            lblEquipmentNo: "Equipment No.",
            lblFindingNo: "Finding No.",
            lblPlantArea: "Plant Area",
            lblProbableEquipmentDamageCost: "Prob. Equip. Dam. Cost",
            lblFaultType: "Fault Type",
            lblLengthOfBusinessInterruption: "Length Of Bus. Inter.",
            lblDetectedWith: "Detected With",
            lblRedundancySpare: "Redundancy Spare",
            lblRecKeyWord: "Rec. Key Word",
            lblRecIntendedAction: "Rec. Intended Action",
            lblRespDate: "Resp. Date",
            lblRespForm: "Resp. From",
            lblExpdComplDate: "Exp'd Compl. Date",
            lblFacilityComment: "Facility Comment",
            lblMgmtRespDate: "Mgmt. Resp. Date",
            lblMgmtRespFrom: "Resp. From",
            lblExpdComplDateManager: "Exp'd Compl. Date",
            lblMgmtRespAction: "Mgmt. Action",
            lblMgmtComment: "Mgmt. Comment",

            // MISC
            lblError: "Error",
            lblRecord: "Record",
            lblFileRecord: "Location",
            lblEdit: "Edit",
            lblSave: "Save",
            lblDelete: "Delete",
            lblCancel: "Cancel",
            lblDatasheetView: "Datasheet View",
            lblNoLocationFoundTitle: "No Recommendations Found",
            lblNoLocationFoundMessage: "Warning: There are no recommendation records found for this location.",
            lblNoLocationFoundDescription: "Click the below button to go back to the Location Details page, or use the Location Navigation buttons to go to another location record.",
            lblGoBackToDetails: "Go Back To Location Details",
            lblNoActiveLocations: "This location is not active for this Practice.",
            lblSearchNotFound: "This location is not active for IR.  Choose a different service.",
            lblPleaseCheckIntendedActionValidDate: 'Please remove the Expected Completion Date value as you have indicated "Disagree - Will Not Complete" as your Intended Action.'
        };

        var objCancel = {
            RecYear: "",
            RecMonth: "",
            RecNumber: "",
            //Impact: "",
            RecStatus: "",
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


        ///////////////////////
        // KEYBOARD EVENT HANDLES
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


        ///////////////////////
        // VIEWMODEL
        var viewFindCriteria_rectracking = {
            findCriteria: ko.observable()
        };
        var view_RecTracking = {
            // DECLARATIONS
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

            // COLLECTIONS / OBJECTS
            // CHANGE THE NAME OF THE ES.OBJECTS PROTOTYPE
            gSafeGuid: getGSafeGUID(), //getQueryVariable('sid'),
            clientFeatures: ko.observable(),
            collRec: new es.objects.FindingsCollection(),
            collListing: new es.objects.ViewCCLocationListingIRCollection(),

            collLossafter: new es.objects.ViewCCRecCompletedLossEstListCollection(), //LEText
            collLossbefore: new es.objects.ViewCCRecCurrentLossEstListCollection(), //LEText
            collCosttocomplete: new es.objects.ViewCCRecEstCostToCompleteListCollection(), //LEText
            collImpactList: new es.objects.ViewCCRecImpactListCollection(), //CategoryText
            collIntendedaction: new es.objects.ViewCCRecIntendedActionListCollection(), //IntendedActionText
            collIntendedactionMgmt: new es.objects.ViewCCTranslationMgmtIntendedActionCollection(), //IntendedActionText
            collRecPrimary: new es.objects.ViewCCRecPrimaryTypeListCollection(), //PrimaryType THIS IS TWO COLUMN WITH Hazard AS KEY
            collRecSecondary: new es.objects.ViewCCRecSecondaryTypeListCollection(), //SecondaryType THIS IS TWO COLUMN WITH PrimaryType AS KEY
            collStatuslist: new es.objects.ViewCCRecStatusListCollection(), //StatusText

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
            //widgetLossExpectancyBefore: ko.observable(),
            //widgetLossExpectancyAfter: ko.observable(),
            //widgetCostToComplete: ko.observable(),
            widgetIntendedAction: ko.observable(),
            widgetIntendedActionMgmt: ko.observable(),
			widgetIntendedActionThirdLevel: ko.observable(),

            objRec: ko.observable(),
            objListing: ko.observable(),
            objLanguageLabels: ko.observable(dsLanguageLabels),
            objFind: ko.observable(),

            // MISC
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

            // LOAD ALL LIST INFORMATION FROM THE DB
            loadPickers: function () {
                // LOAD LISTS
                var tempArray = new Array();
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view_RecTracking.collLossafter.loadAll()) {
                    for (i = 0; i < view_RecTracking.collLossafter().length; i++) {
                        tempArray.push(view_RecTracking.collLossafter()[i].LEText());
                    }
                    view_RecTracking.KOcollLossafter(tempArray);
                } else {
                    view_RecTracking.messageError("* Error while loading Loss After Data List.");
                }

                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view_RecTracking.collLossbefore.loadAll()) {
                    tempArray = new Array();
                    for (i = 0; i < view_RecTracking.collLossbefore().length; i++) {
                        tempArray.push(view_RecTracking.collLossbefore()[i].LEText());
                    }
                    view_RecTracking.KOcollLossbefore(tempArray);
                } else {
                    view_RecTracking.messageError("* Error while loading Loss Before Data List.");
                }

                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view_RecTracking.collCosttocomplete.loadAll()) {
                    tempArray = new Array();
                    for (i = 0; i < view_RecTracking.collCosttocomplete().length; i++) {
                        tempArray.push(view_RecTracking.collCosttocomplete()[i].LEText());
                    }
                    view_RecTracking.KOcollCosttocomplete(tempArray);
                } else {
                    view_RecTracking.messageError("* Error while loading Cost To Complete Data List.");
                }

                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view_RecTracking.collImpactList.loadAll()) {
                    tempArray = new Array();
                    for (i = 0; i < view_RecTracking.collImpactList().length; i++) {
                        tempArray.push(view_RecTracking.collImpactList()[i].CategoryText());
                    }
                    view_RecTracking.KOcollImpactList(tempArray);
                } else {
                    view_RecTracking.messageError("* Error while loading Impact Data List.");
                }

                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view_RecTracking.collIntendedaction.loadAll()) {
                    tempArray = new Array();
                    for (i = 0; i < view_RecTracking.collIntendedaction().length; i++) {
                        tempArray.push(view_RecTracking.collIntendedaction()[i].IntendedActionText());
                    }
                    view_RecTracking.KOcollIntendedaction(tempArray);
                } else {
                    view_RecTracking.messageError("* Error while loading Intended Action Data List.");
                }

                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view_RecTracking.collIntendedactionMgmt.GetMgmtIntendedActionByFilePrefix(view_RecTracking.gSafeGuid)) {
                    tempArray = new Array();
                    for (i = 0; i < view_RecTracking.collIntendedactionMgmt().length; i++) {
                        tempArray.push(view_RecTracking.collIntendedactionMgmt()[i].EnglishTranslation());
                    }
                    view_RecTracking.KOcollIntendedactionMgmt(tempArray);
                } else {
                    view_RecTracking.messageError("* Error while loading Intended Action Data List.");
                }

                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view_RecTracking.collRecPrimary.loadAll()) {
                    ///////////// PrimaryType THIS IS TWO COLUMN WITH Hazard AS KEY OR collRec().Hazard()
                    tempArray = new Array();
                    for (i = 0; i < view_RecTracking.collRecPrimary().length; i++) {
                        //if (view_RecTracking.collRecPrimary()[i].Hazard() == view_RecTracking.objRec().Hazard()) {
                        tempArray.push(view_RecTracking.collRecPrimary()[i].PrimaryType());
                        //}
                    }
                    view_RecTracking.KOcollRecPrimary(tempArray);
                } else {
                    view_RecTracking.messageError("* Error while loading Primary Rec. Type Data List.");
                }

                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view_RecTracking.collRecSecondary.loadAll()) {
                    ///////////// SecondaryType THIS IS TWO COLUMN WITH PrimaryType AS KEY
                    tempArray = new Array();
                    for (i = 0; i < view_RecTracking.collRecSecondary().length; i++) {
                        if (view_RecTracking.collRecSecondary()[i].PrimaryType() == view_RecTracking.objRec().RecPrimary()) {
                            tempArray.push(view_RecTracking.collRecSecondary()[i].SecondarType());
                        }
                    }
                    view_RecTracking.KOcollRecSecondary(tempArray);
                } else {
                    view_RecTracking.messageError("* Error while loading Secondary Rec. Type Data List.");
                }

                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view_RecTracking.collStatuslist.loadAll()) {
                    tempArray = new Array();
                    for (i = 0; i < view_RecTracking.collStatuslist().length; i++) {
                        tempArray.push(view_RecTracking.collStatuslist()[i].StatusText());
                    }
                    view_RecTracking.KOcollStatuslist(tempArray);
                } else {
                    view_RecTracking.messageError("* Error while loading Status Data List.");
                }
            },

            //            buildSecondaryRecType: function () {
            //                var tempArray2 = new Array();
            //                for (i = 0; i < view_RecTracking.collSecondaryrectype().length; i++) {
            //                    if (view_RecTracking.collSecondaryrectype()[i].PrimaryType() == view_RecTracking.objRec().PrimaryRecType()) {
            //                        tempArray2.push(view_RecTracking.collSecondaryrectype()[i].SecondarType());
            //                    }
            //                }
            //                view_RecTracking.KOcollSecondaryrectype(tempArray2);
            //            },

            // BUTTONS FOR RECORD NAVIGATION
            onNext: function () {
                if (view_RecTracking.stateOnlyOneDetailRecordLoaded) {
                    view_RecTracking.loadDetailsOnly();
                }
                if (view_RecTracking.index < view_RecTracking.collRec().length - 1) {
                    view_RecTracking.index++;
                    view_RecTracking.objRec(view_RecTracking.collRec()[view_RecTracking.index]);
                }
                view_RecTracking.setupButtons();
                view_RecTracking.resetPickers();
                view_RecTracking.messageSave("");
                view_RecTracking.messageValidation("");
            },

            onPrevious: function () {
                if (view_RecTracking.index > 0) {
                    view_RecTracking.index--;
                    view_RecTracking.objRec(view_RecTracking.collRec()[view_RecTracking.index]);
                }
                view_RecTracking.setupButtons();
                view_RecTracking.resetPickers();
                view_RecTracking.messageSave("");
                view_RecTracking.messageValidation("");
            },

            onFirst: function () {
                if (view_RecTracking.index > 0) {
                    view_RecTracking.index = 0;
                    view_RecTracking.objRec(view_RecTracking.collRec()[view_RecTracking.index]);
                }
                view_RecTracking.setupButtons();
                view_RecTracking.resetPickers();
                view_RecTracking.messageSave("");
                view_RecTracking.messageValidation("");
            },

            onLast: function () {
                if (view_RecTracking.stateOnlyOneDetailRecordLoaded) {
                    view_RecTracking.loadDetailsOnly();
                }
                if (view_RecTracking.index < view_RecTracking.collRec().length - 1) {
                    view_RecTracking.index = view_RecTracking.collRec().length - 1;
                    view_RecTracking.objRec(view_RecTracking.collRec()[view_RecTracking.index]);
                }
                view_RecTracking.setupButtons();
                view_RecTracking.resetPickers();
                view_RecTracking.messageSave("");
                view_RecTracking.messageValidation("");
            },

            // BUTTONS FOR FILE NUMBER / LOCATION WALK
            onFileFirst: function () {
                view_RecTracking.fileDirection("first");
                view_RecTracking.index = 0;
                view_RecTracking.stateDetailsLoadOneRecord = true;
                view_RecTracking.loadOneFileNumber(); //view_RecTracking.loadFileNumber();
                view_RecTracking.fileDirection("");
                view_RecTracking.resetPickers();
                view_RecTracking.messageSave("");
                view_RecTracking.messageValidation("");
            },

            onFilePrevious: function () {
                view_RecTracking.fileDirection("previous");
                view_RecTracking.index = 0;
                view_RecTracking.stateDetailsLoadOneRecord = true;
                view_RecTracking.loadOneFileNumber(); //view_RecTracking.loadFileNumber();
                view_RecTracking.fileDirection("");
                view_RecTracking.resetPickers();
                view_RecTracking.messageSave("");
                view_RecTracking.messageValidation("");
            },

            onFileNext: function () {
                view_RecTracking.fileDirection("next");
                view_RecTracking.index = 0;
                view_RecTracking.stateDetailsLoadOneRecord = true;
                view_RecTracking.loadOneFileNumber(); //view_RecTracking.loadFileNumber();
                view_RecTracking.fileDirection("");
                view_RecTracking.resetPickers();
                view_RecTracking.messageSave("");
                view_RecTracking.messageValidation("");
            },

            onFileLast: function () {
                view_RecTracking.fileDirection("last");
                view_RecTracking.index = 0;
                view_RecTracking.stateDetailsLoadOneRecord = true;
                view_RecTracking.loadOneFileNumber(); //view_RecTracking.loadFileNumber();
                view_RecTracking.fileDirection("");
                view_RecTracking.resetPickers();
                view_RecTracking.messageSave("");
                view_RecTracking.messageValidation("");
            },

            // FIND A RECORD FROM THE LOCATION FIELDS
            onFind: function () {
                // SET THE GSAFE
                setFindLocationFields(view_RecTracking.gSafeGuid, view_RecTracking.objFind(), view_RecTracking.objListing());
                // LOOKUP RECORD USING THE ON FIRST NAVIGATE
                view_RecTracking.onFileFirst();
                view_RecTracking.resetPickers();
            },

            onFindClear: function () {
                // CLEAR THE OBJECT
                view_RecTracking.resetPickers();
                // SET THE GSAFE
                setFindLocationFields(view_RecTracking.gSafeGuid, view_RecTracking.objFind(), view_RecTracking.objListing());
                // RELOAD THE FILE NUMBER TO GET THE CORRECT LOCATION COUNT
                view_RecTracking.onFileFirst();
                view_RecTracking.resetPickers();
            },

            onLocationDetailsRedirect: function () {
                // REDIRECT THE USER TO THE LOCATION DETAILS PAGE
                document.location.href = "locationdetails.aspx" + "?sid=" + view_RecTracking.gSafeGuid;
            },

            onDatasheetView: function () {
                // BUILD URL AND GO TO DATASHEET VIEW
                var tempURL = "";
                if (view_RecTracking.clientFeatures().search('L') > -1) {
                    tempURL = "tab_recdatasheet.aspx?sid=" + view_RecTracking.gSafeGuid + "&rec=" + view_RecTracking.index;
                } else {
                    tempURL = "tab_recdatasheet.aspx?sid=" + view_RecTracking.gSafeGuid + "&rec=" + view_RecTracking.index;
                }
                //document.location.href = tempURL;
                gReloadTab(tempURL);
            },

            // ENABLE OR DISABLE BUTTONS AND SHOW RECORD NUMBER
            setupButtons: function () {
                if (view_RecTracking.index == 0) {
                    view_RecTracking.enablePrev(false);
                    $('#btnFirst').addClass('grcBlueDisabledBtn');
                    $('#btnPrevious').addClass('grcBlueDisabledBtn');
                } else {
                    view_RecTracking.enablePrev(true);
                    $('#btnFirst').removeClass('grcBlueDisabledBtn');
                    $('#btnPrevious').removeClass('grcBlueDisabledBtn');
                }
                if (view_RecTracking.index == view_RecTracking.collRec().length - 1) {
                    view_RecTracking.enableNext(false);
                    $('#btnNext').addClass('grcBlueDisabledBtn');
                    $('#btnLast').addClass('grcBlueDisabledBtn');
                } else {
                    view_RecTracking.enableNext(true);
                    $('#btnNext').removeClass('grcBlueDisabledBtn');
                    $('#btnLast').removeClass('grcBlueDisabledBtn');
                }
                if (view_RecTracking.stateOnlyOneDetailRecordLoaded == true) {
                    view_RecTracking.enableNext(true);
                    $('#btnNext').removeClass('grcBlueDisabledBtn');
                    $('#btnLast').removeClass('grcBlueDisabledBtn');
                }
                if (!view_RecTracking.editState()) {
                    view_RecTracking.txtEditSave(view_RecTracking.objLanguageLabels().lblEdit);
                    view_RecTracking.txtCancelDelete(view_RecTracking.objLanguageLabels().lblDelete);
                    $('#cancelDelete').removeClass('grcNeutralBtn');
                    $('#cancelDelete').addClass('grcRedBtn');
                } else {
                    view_RecTracking.txtEditSave(view_RecTracking.objLanguageLabels().lblSave);
                    view_RecTracking.txtCancelDelete(view_RecTracking.objLanguageLabels().lblCancel);
                    view_RecTracking.enablePrev(false);
                    view_RecTracking.enableNext(false);
                    $('#btnFirst').addClass('grcBlueDisabledBtn');
                    $('#btnPrevious').addClass('grcBlueDisabledBtn');
                    $('#btnNext').addClass('grcBlueDisabledBtn');
                    $('#btnLast').addClass('grcBlueDisabledBtn');
                    $('#cancelDelete').removeClass('grcRedBtn');
                    $('#cancelDelete').addClass('grcNeutralBtn');
                }
                if (!view_RecTracking.adminUser) {
                    view_RecTracking.enableDelete(false);
                    $('#cancelDelete').addClass('grcRedDisabledBtn');
                } else {
                    view_RecTracking.enableDelete(true);
                    $('#cancelDelete').removeClass('grcRedDisabledBtn');
                }
                if (view_RecTracking.stateOnlyOneDetailRecordLoaded) {
                    view_RecTracking.txtRecordNumber("1...");
                } else {
                    view_RecTracking.txtRecordNumber((parseInt(view_RecTracking.index) + 1) + " of " + view_RecTracking.collRec().length);
                }
            },

            setupFileButtons: function () {
                if (view_RecTracking.objListing().RecNum() <= 1) {
                    view_RecTracking.enableFilePrev(false);
                    $('#btnFileFirst').addClass('grcBlueDisabledBtn');
                    $('#btnFilePrevious').addClass('grcBlueDisabledBtn');
                } else {
                    view_RecTracking.enableFilePrev(true);
                    $('#btnFileFirst').removeClass('grcBlueDisabledBtn');
                    $('#btnFilePrevious').removeClass('grcBlueDisabledBtn');
                }
                if (view_RecTracking.objListing().RecNum() >= view_RecTracking.objListing().RecCount()) {
                    view_RecTracking.enableFileNext(false);
                    $('#btnFileNext').addClass('grcBlueDisabledBtn');
                    $('#btnFileLast').addClass('grcBlueDisabledBtn');
                } else {
                    view_RecTracking.enableFileNext(true);
                    $('#btnFileNext').removeClass('grcBlueDisabledBtn');
                    $('#btnFileLast').removeClass('grcBlueDisabledBtn');
                }
                if (view_RecTracking.objListing().RecCount() <= 1) { view_RecTracking.enableFilePrev(false); view_RecTracking.enableFilePrev(false); }
                if (!view_RecTracking.editState()) {
                    // do nothing
                } else {
                    view_RecTracking.enableFilePrev(false);
                    view_RecTracking.enableFileNext(false);
                    $('#btnFileFirst').addClass('grcBlueDisabledBtn');
                    $('#btnFilePrevious').addClass('grcBlueDisabledBtn');
                    $('#btnFileNext').addClass('grcBlueDisabledBtn');
                    $('#btnFileLast').addClass('grcBlueDisabledBtn');
                }
                view_RecTracking.txtFileRecordNumber(view_RecTracking.objListing().RecNum() + " of " + view_RecTracking.objListing().RecCount());
            },

            // SETUP FIND FIELDS FOR LOCATIONS
            setupFindFields: function () {
                // FIND TEXT BOXES
                view_RecTracking.objFind().findFileNo = view_RecTracking.objListing().FileNo();
                view_RecTracking.objFind().findClientLocNo = view_RecTracking.objListing().ClientLocNo();
                view_RecTracking.objFind().findAddress1 = view_RecTracking.objListing().Address1();
                view_RecTracking.objFind().findCity = view_RecTracking.objListing().City();
                view_RecTracking.objFind().findStProv = view_RecTracking.objListing().StProv();
                view_RecTracking.objFind().findCountry = view_RecTracking.objListing().Country();
                view_RecTracking.objFind().findZip = view_RecTracking.objListing().Zip();
                view_RecTracking.objFind().findDivision = view_RecTracking.objListing().Division();
                view_RecTracking.objFind().findFacility = view_RecTracking.objListing().Facility();
                view_RecTracking.objFind().findCustomAccess = view_RecTracking.objListing().CustomAccess();
                view_RecTracking.objFind().findLatitude = view_RecTracking.objListing().Latitude();
                view_RecTracking.objFind().findLongitude = view_RecTracking.objListing().Longitude();
            },

            // RESET FIELDS ON LOAD RECORD
            resetPickers: function () {
                // COPY THE FIND FIELDS
                view_RecTracking.setupFindFields();

                if (view_RecTracking.objRec().StatusDate() == undefined) { StatusDate.value(""); } else { StatusDate.value(view_RecTracking.objRec().StatusDate()); }
                if (view_RecTracking.objRec().ResponseDate() == undefined) { ResponseDate.value(""); } else { ResponseDate.value(view_RecTracking.objRec().ResponseDate()); }
                if (view_RecTracking.objRec().ExpectedCompletionDate() == undefined) { ExpectedCompletionDate.value(""); } else { ExpectedCompletionDate.value(view_RecTracking.objRec().ExpectedCompletionDate()); }
                view_RecTracking.widgetImpact().value(view_RecTracking.objRec().Impact());
                view_RecTracking.widgetRecStatus().value(view_RecTracking.objRec().RecStatus());
                //view_RecTracking.widgetRecPrimary().value(view_RecTracking.objRec().RecPrimary());
                //view_RecTracking.widgetRecSecondary().value(view_RecTracking.objRec().RecSecondary());
                //view_RecTracking.widgetLossExpectancyBefore().value(view_RecTracking.objRec().LossExpectancyBefore());
                //view_RecTracking.widgetLossExpectancyAfter().value(view_RecTracking.objRec().LossExpectancyAfter());
                //view_RecTracking.widgetCostToComplete().value(view_RecTracking.objRec().CostToComplete());
                view_RecTracking.widgetIntendedAction().value(view_RecTracking.objRec().IntendedAction());
                if (view_RecTracking.clientFeatures().indexOf("Q") > -1) {
                    if (view_RecTracking.objRec().MgmtRespAction() == undefined) { view_RecTracking.widgetIntendedActionMgmt().value(""); } else { view_RecTracking.widgetIntendedActionMgmt().value(view_RecTracking.objRec().MgmtRespAction()); }
                }
                if (view_RecTracking.clientFeatures().indexOf("Q") > -1) {
                    if (view_RecTracking.objRec().MgmtRespDate() == undefined) { MgmtRespDate.value(""); } else { MgmtRespDate.value(view_RecTracking.objRec().MgmtRespDate()); }
                }
                if (view_RecTracking.clientFeatures().indexOf("@") > -1) {
                	if (view_RecTracking.objRec().ThirdLevelRespAction() == undefined) { view_RecTracking.widgetIntendedActionThirdLevel().value(""); } else { view_RecTracking.widgetIntendedActionThirdLevel().value(view_RecTracking.objRec().ThirdLevelRespAction()); }
                    if (view_RecTracking.objRec().ThirdLevelRespDate() == undefined) { lvl3RespDate.value(""); } else { lvl3RespDate.value(view_RecTracking.objRec().ThirdLevelRespDate()); }
                }
                // DISPLAY WINDOW IF NO RECORD EXISTS OR A MESSAGE IF NO SEARCH FOUND
                windowNoLocation.data("kendoWindow").close();
                view_RecTracking.messageError("");
                view_RecTracking.enableNoLocationFound(true);
                $('#cancelDelete').removeClass('grcRedDisabledBtn');
                $('#editSave').removeClass('grcBlueDisabledBtn');
                if ((view_RecTracking.objRec().FileNo() == "Not Found" && view_RecTracking.pageRequestedFrom == "topnav") || (view_RecTracking.objListing().FileNo() == "Not Found" && view_RecTracking.pageRequestedFrom == "topnav")) {
                    view_RecTracking.enableNoLocationFound(false);
                    view_RecTracking.messageError(view_RecTracking.objLanguageLabels().lblNoActiveLocations);
                    view_RecTracking.clearPickers();
                    view_RecTracking.clearAddressFields();
                    $('#cancelDelete').addClass('grcRedDisabledBtn');
                    $('#editSave').addClass('grcBlueDisabledBtn');
                } else if (view_RecTracking.objRec().FileNo() == "Not Found") {
                    view_RecTracking.enableNoLocationFound(false);
                    $('#cancelDelete').addClass('grcRedDisabledBtn');
                    $('#editSave').addClass('grcBlueDisabledBtn');
                    //windowNoLocation.data("kendoWindow").open();
                    //$("#windowNoLocation").css("display", "block");
                    view_RecTracking.clearPickers();
                } else if (view_RecTracking.objListing().FileNo() == "Not Found") {
                    view_RecTracking.enableNoLocationFound(false);
                    view_RecTracking.enableNext(false);
                    view_RecTracking.enablePrev(false);
                    view_RecTracking.messageError(view_RecTracking.objLanguageLabels().lblSearchNotFound);
                    view_RecTracking.clearPickers();
                    $('#cancelDelete').addClass('grcRedDisabledBtn');
                    $('#editSave').addClass('grcBlueDisabledBtn');
                }

                // ALWAYS CLEAR THE REQUESTING VARIABLE FOR USE OF CLIENT SIDE BUTTON NAVIGATION
                view_RecTracking.pageRequestedFrom = "";

                // REDRAW THE PAGE
                view_RecTracking.onEnablePickers();

                /* ADD RED BACKGROUND TO RESPONSE DATE FIELD IF RESPONSE IS NEEDED */
                if (view_RecTracking.objRec().ResponseDate() == null || view_RecTracking.objRec().ResponseDate() < view_RecTracking.objRec().StatusDate()) {
                    if (view_RecTracking.objRec().RecStatus() == 'Removed' || view_RecTracking.objRec().RecStatus() == 'Rptd Completed' || view_RecTracking.objRec().RecStatus() == 'Conf Completed' || view_RecTracking.objRec().RecStatus() == 'Advisory') {
                        $('#ResponseDate').removeClass('expiredDate'); 
                    } else {
                        $('#ResponseDate').addClass('expiredDate');
                    }
                } else {
                    $('#ResponseDate').removeClass('expiredDate');
                }

                // COLOR ANY PICKERS WITH SPECIAL BUSINESS LOGIC
                view_RecTracking.colorPickers();
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
                // KENDO WIDGETS
                StatusDate.value("");
                ResponseDate.value("");
                ExpectedCompletionDate.value("");
                view_RecTracking.widgetImpact().value("");
                view_RecTracking.widgetRecStatus().value("");
                //view_RecTracking.widgetRecPrimary().value("");
                //view_RecTracking.widgetRecSecondary().value("");
                //view_RecTracking.widgetLossExpectancyBefore().value("");
                //view_RecTracking.widgetLossExpectancyAfter().value("");
                //view_RecTracking.widgetCostToComplete().value("");
                view_RecTracking.widgetIntendedAction().value("");
                if (view_RecTracking.clientFeatures().indexOf("Q") > -1) {
                    view_RecTracking.widgetIntendedActionMgmt().value("");
                }
                if (view_RecTracking.clientFeatures().indexOf("@") > -1) {
                    view_RecTracking.widgetIntendedActionThirdLevel().value("");
                }

                // HTML / KNOCKOUT DOMS
                //$("#RecYear").val("");
                //$("#RecMonth").val("");
                //$("#RecNumber").val("");
                $("#Findingno").val("");
                $("#Itemno").val("");
                $("#ProbableEquipmentDamageCost").val("");
            },

            setCancelObject: function () {
                //objCancel.RecYear = view_RecTracking.objRec().RecYear();
                //objCancel.RecMonth = view_RecTracking.objRec().RecMonth();
                //objCancel.RecNumber = view_RecTracking.objRec().RecNumber();
                objCancel.Impact = view_RecTracking.objRec().Impact();
                objCancel.RecStatus = view_RecTracking.objRec().RecStatus();
                if (view_RecTracking.objRec().StatusDate() == undefined) { objCancel.StatusDate = null; } else { objCancel.StatusDate = view_RecTracking.objRec().StatusDate(); }
                objCancel.RecPrimary = view_RecTracking.objRec().RecPrimary();
                objCancel.RecSecondary = view_RecTracking.objRec().RecSecondary();
                if (view_RecTracking.objRec().ResponseDate() == undefined) { objCancel.ResponseDate = null; } else { objCancel.ResponseDate = view_RecTracking.objRec().ResponseDate(); }
                objCancel.ResponseFrom = view_RecTracking.objRec().ResponseFrom();
                objCancel.IntendedAction = view_RecTracking.objRec().IntendedAction();
                if (view_RecTracking.objRec().ExpectedCompletionDate() == undefined) { objCancel.ExpectedCompletionDate = null; } else { objCancel.ExpectedCompletionDate = view_RecTracking.objRec().ExpectedCompletionDate(); }
                objCancel.PlantComment = view_RecTracking.objRec().PlantComment();
                
                if (view_RecTracking.clientFeatures().indexOf("Q") > -1) {
                    if (view_RecTracking.objRec().MgmtRespDate() == undefined) {
                        objCancel.MgmtRespDate = null;
                    } else {
                        objCancel.MgmtRespDate = view_RecTracking.objRec().MgmtRespDate();
                    }
                    objCancel.MgmtRespFrom = view_RecTracking.objRec().MgmtRespFrom();
                    objCancel.IntendedActionMgmt = view_RecTracking.objRec().IntendedAction();
                    objCancel.MgmtRespAction = view_RecTracking.objRec().MgmtRespAction();
                    //objCancel.ExpectedCompletionDateManager = view_RecTracking.objRec().ExpectedCompletionDateManager();
                    objCancel.MgmtRespComment = view_RecTracking.objRec().MgmtRespComment();
                }
                
                if (view_RecTracking.clientFeatures().indexOf("@") > -1) {
                    if (view_RecTracking.objRec().ThirdLevelRespDate() == undefined) {
                        objCancel.ThirdLevelRespDate = null;
                    } else {
                        objCancel.ThirdLevelRespDate = view_RecTracking.objRec().ThirdLevelRespDate()
                    }
                    objCancel.ThirdLevelRespFrom = view_RecTracking.objRec().ThirdLevelRespFrom();
                    objCancel.ThirdLevelRespAction = view_RecTracking.objRec().ThirdLevelRespAction();
                    objCancel.ThirdLevelRespComment = view_RecTracking.objRec().ThirdLevelRespComment();
                }
            },

            // RESET FIELDS ON LOAD RECORD
            cancelPickers: function () {
                //view_RecTracking.objRec().RecYear(objCancel.RecYear);
                //view_RecTracking.objRec().RecMonth(objCancel.RecMonth);
                //view_RecTracking.objRec().RecNumber(objCancel.RecNumber);
                view_RecTracking.objRec().RecStatus(objCancel.RecStatus);
                view_RecTracking.objRec().ResponseDate(objCancel.ResponseDate);
                view_RecTracking.objRec().ResponseFrom(objCancel.ResponseFrom);
                view_RecTracking.objRec().IntendedAction(objCancel.IntendedAction);
                view_RecTracking.objRec().ExpectedCompletionDate(objCancel.ExpectedCompletionDate);
                view_RecTracking.objRec().PlantComment(objCancel.PlantComment);
                if (view_RecTracking.clientFeatures().indexOf("Q") > -1) {
                    view_RecTracking.objRec().MgmtRespDate(objCancel.MgmtRespDate);
                    view_RecTracking.objRec().MgmtRespFrom(objCancel.MgmtRespFrom);
                    view_RecTracking.objRec().MgmtRespAction(objCancel.MgmtRespAction);
                    //view_RecTracking.objRec().ExpectedCompletionDateManager(objCancel.ExpectedCompletionDateManager);
                    view_RecTracking.objRec().MgmtRespComment(objCancel.MgmtRespComment);
                }
                if (view_RecTracking.clientFeatures().indexOf("@") > -1) {
                    view_RecTracking.objRec().ThirdLevelRespDate(objCancel.ThirdLevelRespDate);
                    view_RecTracking.objRec().ThirdLevelRespFrom(objCancel.ThirdLevelRespFrom);
                    view_RecTracking.objRec().ThirdLevelRespAction(objCancel.ThirdLevelRespAction);
                    view_RecTracking.objRec().ThirdLevelRespComment(objCancel.ThirdLevelRespComment);
                }
                view_RecTracking.resetPickers();
            },

            resetObjRec: function () {
                //view_RecTracking.objRec().RecYear($("#RecYear").val());
                //view_RecTracking.objRec().RecMonth($("#RecMonth").val());
                //view_RecTracking.objRec().RecNumber($("#RecNumber").val());
            },

            colorPickers: function () {
                // ONLY CHANGE COLOR IF WE ARE IN EDIT MODE
                if (!view_RecTracking.enablePickers()) {
                    var today = new Date();
                    var ogDate = view_RecTracking.objRec().ExpectedCompletionDate();
                    var dateComplete = moment(view_RecTracking.objRec().ExpectedCompletionDate()).format();
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
                    if (view_RecTracking.objRec().RecStatus() == "In Progress" || view_RecTracking.objRec().RecStatus() == "Outstanding") {
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
                    if (view_RecTracking.objRec().RecStatus() == "In Progress" || view_RecTracking.objRec().RecStatus() == "Outstanding") {
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
                if (view_RecTracking.adminUser) {
                    // AN ADMIN USER
                    if (view_RecTracking.enablePickers()) {
                        // USER IS AN ADMIN AND ENABLES
                        // ENABLE PICKERS NOT BOUND BY KNOCKOUT AND CHANGE TO YELLOW WHERE NEEDED
                        // DATES
                        ResponseDate.enable();
                        ResponseDate.wrapper.find(".k-icon").removeClass("noedit").addClass("editRequired");
                        ResponseDate.wrapper.find(".k-picker-wrap").removeClass("noedit").addClass("editRequired");
                        ResponseDate.wrapper.find(".k-autocomplete").removeClass("noedit").addClass("editRequired");
                        if (view_RecTracking.clientFeatures().indexOf("Q") > -1) {
                            MgmtRespDate.enable();
                            MgmtRespDate.wrapper.find(".k-icon").removeClass("noedit").addClass("editRequired");
                            MgmtRespDate.wrapper.find(".k-picker-wrap").removeClass("noedit").addClass("editRequired");
                            MgmtRespDate.wrapper.find(".k-autocomplete").removeClass("noedit").addClass("editRequired");
                        }
                        if (view_RecTracking.clientFeatures().indexOf("@") > -1) {
                        	lvl3RespDate.enable();
                            lvl3RespDate.wrapper.find(".k-icon").removeClass("noedit").addClass("editRequired");
                            lvl3RespDate.wrapper.find(".k-picker-wrap").removeClass("noedit").addClass("editRequired");
                            lvl3RespDate.wrapper.find(".k-autocomplete").removeClass("noedit").addClass("editRequired");
                        }
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
                        //                        ExpectedCompletionDateManager.enable();
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-icon").removeClass("noedit").addClass("editRequired");
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-picker-wrap").removeClass("noedit").addClass("editRequired");
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-autocomplete").removeClass("noedit").addClass("editRequired");
                        // DROPDOWNS
                        IntendedAction.find(".k-icon").removeClass("noedit").addClass("editRequired");
                        IntendedAction.find(".k-dropdown-wrap").removeClass("noedit").addClass("editRequired");
                        if (view_RecTracking.clientFeatures().indexOf("Q") > -1) {
                            MgmtRespAction.find(".k-icon").removeClass("noedit").addClass("editRequired");
                            MgmtRespAction.find(".k-dropdown-wrap").removeClass("noedit").addClass("editRequired");
                        }
                        if (view_RecTracking.clientFeatures().indexOf("@") > -1) {
                            ThirdLvlRespAction.find(".k-icon").removeClass("noedit").addClass("editRequired");
                            ThirdLvlRespAction.find(".k-dropdown-wrap").removeClass("noedit").addClass("editRequired");
                        }

                        // SHOW OR HIDE ICONS
                        StatusDate.wrapper.find(".k-icon").hide();
                        RecStatus.find(".k-icon").hide();
                        IntendedAction.find(".k-icon").show();
                        ResponseDate.wrapper.find(".k-icon").show();
                        ExpectedCompletionDate.wrapper.find(".k-icon").show();
                        if (view_RecTracking.clientFeatures().indexOf("Q") > -1) {
                            MgmtRespAction.find(".k-icon").show();
                            MgmtRespDate.wrapper.find(".k-icon").show();
                        }
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-icon").show();
                        Impact.find(".k-icon").hide();
                        if (view_RecTracking.clientFeatures().indexOf("@") > -1) {
                            ThirdLvlRespAction.find(".k-icon").show();
                        }
                        //RecPrimary.find(".k-icon").hide();
                        //RecSecondary.find(".k-icon").hide();
                        //LossExpectancyBefore.find(".k-icon").hide();
                        //LossExpectancyAfter.find(".k-icon").hide();
                        //CostToComplete.find(".k-icon").hide();

                        // PLAIN TEXT
                        //$("#RecYear").removeAttr("readonly");
                        //$("#RecYear").removeClass("noedit").addClass("editRequired");
                        //$("#RecMonth").removeAttr("readonly");
                        //$("#RecMonth").removeClass("noedit").addClass("editRequired");
                        //$("#RecNumber").removeAttr("readonly");
                        //$("#RecNumber").removeClass("noedit").addClass("editRequired");
                        $("#ResponseFrom").removeAttr("readonly");
                        $("#ResponseFrom").removeClass("noedit").addClass("editRequired");
                        $("#lvl3RespFrom").removeAttr("readonly");
                        $("#lvl3RespFrom").removeClass("noedit").addClass("editRequired");
                        $("#PlantComment").removeAttr("readonly");
                        $("#PlantComment").removeClass("noedit").addClass("editRequired");
                        $("#ActualCostToComplete").removeAttr("readonly");
                        $("#ActualCostToComplete").removeClass("noedit").addClass("editRequired");
                        if (view_RecTracking.clientFeatures().indexOf("Q") > -1) {
                            $("#MgmtRespFrom").removeAttr("readonly");
                            $("#MgmtRespFrom").removeClass("noedit").addClass("editRequired");
                            $("#MgmtRespComment").removeAttr("readonly");
                            $("#MgmtRespComment").removeClass("noedit").addClass("editRequired");
                        }
                        if (view_RecTracking.clientFeatures().indexOf("@") > -1) {
                            $("#lvl3Commment").removeAttr("readonly");
                            $("#lvl3Commment").removeClass("noedit").addClass("editRequired");
                        }
                        view_RecTracking.enableAdminFields(true);

                    } else {
                        // USER IS AN ADMIN AND DISABLES
                        // DISABLE PICKERS NOT BOUT BY KNOCKOUT AND CHANGE ALL BACK TO WHITE
                        // DATES
                        StatusDate.enable(false);
                        ResponseDate.enable(false);
                        ResponseDate.wrapper.find(".k-icon").removeClass("editRequired").addClass("noedit");
                        ResponseDate.wrapper.find(".k-picker-wrap").removeClass("editRequired").addClass("noedit");
                        ResponseDate.wrapper.find(".k-autocomplete").removeClass("editRequired").addClass("noedit");
                        ExpectedCompletionDate.enable(false);
                        ExpectedCompletionDate.wrapper.find(".k-icon").removeClass("editRequired").addClass("noedit");
                        ExpectedCompletionDate.wrapper.find(".k-picker-wrap").removeClass("editRequired").addClass("noedit");
                        ExpectedCompletionDate.wrapper.find(".k-autocomplete").removeClass("editRequired").addClass("noedit");
                        if (view_RecTracking.clientFeatures().indexOf("Q") > -1) {
                            MgmtRespDate.enable(false);
                            MgmtRespDate.wrapper.find(".k-icon").removeClass("editRequired").addClass("noedit");
                            MgmtRespDate.wrapper.find(".k-picker-wrap").removeClass("editRequired").addClass("noedit");
                            MgmtRespDate.wrapper.find(".k-autocomplete").removeClass("editRequired").addClass("noedit");
                        }
						if (view_RecTracking.clientFeatures().indexOf("@") > -1) {
                        	lvl3RespDate.enable(false);
                            lvl3RespDate.wrapper.find(".k-icon").removeClass("editRequired").addClass("noedit");
                            lvl3RespDate.wrapper.find(".k-picker-wrap").removeClass("editRequired").addClass("noedit");
                            lvl3RespDate.wrapper.find(".k-picker-wrap").removeClass("editRequired").addClass("noedit");

                            //THIRD LEVEL DROPDOWN
                            ThirdLvlRespAction.find(".k-icon").removeClass("editRequired").addClass("noedit");
                            ThirdLvlRespAction.find(".k-dropdown-wrap").removeClass("editRequired").addClass("noedit");
                        }
                        //                        ExpectedCompletionDateManager.enable(false);
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-icon").removeClass("editRequired").addClass("noedit");
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-picker-wrap").removeClass("editRequired").addClass("noedit");
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-autocomplete").removeClass("editRequired").addClass("noedit");
                        // DROPDOWNS
                        //LossExpectancyBefore.find(".k-icon").removeClass("editRequired").addClass("noedit");
                        //LossExpectancyBefore.find(".k-dropdown-wrap").removeClass("editRequired").addClass("noedit");
                        //LossExpectancyAfter.find(".k-icon").removeClass("editRequired").addClass("noedit");
                        //LossExpectancyAfter.find(".k-dropdown-wrap").removeClass("editRequired").addClass("noedit");
                        //CostToComplete.find(".k-icon").removeClass("editRequired").addClass("noedit");
                        //CostToComplete.find(".k-dropdown-wrap").removeClass("editRequired").addClass("noedit");
                        IntendedAction.find(".k-icon").removeClass("editRequired").addClass("noedit");
                        IntendedAction.find(".k-dropdown-wrap").removeClass("editRequired").addClass("noedit");
                        if (view_RecTracking.clientFeatures().indexOf("Q") > -1) {
                            MgmtRespAction.find(".k-icon").removeClass("editRequired").addClass("noedit");
                            MgmtRespAction.find(".k-dropdown-wrap").removeClass("editRequired").addClass("noedit");
                        }

                        // SHOW OR HIDE ICONS
                        IntendedAction.find(".k-icon").show();
                        if (view_RecTracking.clientFeatures().indexOf("Q") > -1) {
                            MgmtRespAction.find(".k-icon").show();
                        }
                        ResponseDate.wrapper.find(".k-icon").show();
                        ExpectedCompletionDate.wrapper.find(".k-icon").show();
                        Impact.find(".k-icon").hide();
                        //RecPrimary.find(".k-icon").hide();
                        //RecSecondary.find(".k-icon").hide();
                        StatusDate.wrapper.find(".k-icon").hide();
                        RecStatus.find(".k-icon").hide();
                        if (view_RecTracking.clientFeatures().indexOf("Q") > -1) {
                            MgmtRespDate.wrapper.find(".k-icon").show();
                        }
                        if (view_RecTracking.clientFeatures().indexOf("@") > -1) {
                            ThirdLvlRespAction.find(".k-icon").show();
                        }
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-icon").show();
                        //LossExpectancyBefore.find(".k-icon").hide();
                        //LossExpectancyAfter.find(".k-icon").hide();
                        //CostToComplete.find(".k-icon").hide();

                        // PLAIN TEXT
                        //$("#RecYear").attr("readonly", "readonly");
                        //$("#RecYear").removeClass("editRequired").addClass("noedit");
                        //$("#RecMonth").attr("readonly", "readonly");
                        //$("#RecMonth").removeClass("editRequired").addClass("noedit");
                        //$("#RecNumber").attr("readonly", "readonly");
                        //$("#RecNumber").removeClass("editRequired").addClass("noedit");
                        //$("#SavingsRatio").attr("readonly", "readonly");
                        //$("#SavingsRatio").removeClass("editRequired").addClass("noedit");
                        //$("#ActualCostToComplete").attr("readonly", "readonly");
                        //$("#ActualCostToComplete").removeClass("editRequired").addClass("noedit");
                        $("#ResponseFrom").attr("readonly", "readonly");
                        $("#ResponseFrom").removeClass("editRequired").addClass("noedit");
                        if (view_RecTracking.clientFeatures().indexOf("@") > -1) {
                            $("#lvl3RespFrom").attr("readonly", "readonly");
                            $("#lvl3RespFrom").removeClass("editRequired").addClass("noedit");
                        }
                        $("#PlantComment").attr("readonly", "readonly");
                        $("#PlantComment").removeClass("editRequired").addClass("noedit");
                        if (view_RecTracking.clientFeatures().indexOf("Q") > -1) {
                            $("#MgmtRespFrom").attr("readonly", "readonly");
                            $("#MgmtRespFrom").removeClass("editRequired").addClass("noedit");
                            $("#MgmtRespComment").attr("readonly", "readonly");
                            $("#MgmtRespComment").removeClass("editRequired").addClass("noedit");
                        }
                        if (view_RecTracking.clientFeatures().indexOf("@") > -1) {
                            $("#lvl3Commment").attr("readonly", "readonly");
                            $("#lvl3Commment").removeClass("editRequired").addClass("noedit");
                        }
                        view_RecTracking.enableAdminFields(false);
                    }

                } else {
                    // NOT AN ADMIN USER
                    if (view_RecTracking.enablePickers()) {
                        // USER IS NOT AN ADMIN AND ENABLES
                        // ENABLE PICKERS NOT BOUND BY KNOCKOUT AND CHANGE TO YELLOW WHERE NEEDED
                        // DATES
                        //StatusDate.enable();
                        //StatusDate.wrapper.find(".k-icon").removeClass("noedit").addClass("editRequired");
                        //StatusDate.wrapper.find(".k-picker-wrap").removeClass("noedit").addClass("editRequired");
                        //StatusDate.wrapper.find(".k-autocomplete").removeClass("noedit").addClass("editRequired");
                        ResponseDate.enable();
                        ResponseDate.wrapper.find(".k-icon").removeClass("noedit").addClass("editRequired");
                        ResponseDate.wrapper.find(".k-picker-wrap").removeClass("noedit").addClass("editRequired");
                        ResponseDate.wrapper.find(".k-autocomplete").removeClass("noedit").addClass("editRequired");
                        ExpectedCompletionDate.enable();
                        ExpectedCompletionDate.wrapper.find(".k-icon").removeClass("noedit").addClass("editRequired");
                        ExpectedCompletionDate.wrapper.find(".k-picker-wrap").removeClass("noedit").addClass("editRequired");
                        ExpectedCompletionDate.wrapper.find(".k-autocomplete").removeClass("noedit").addClass("editRequired");
                        if (view_RecTracking.clientFeatures().indexOf("Q") > -1) {
                            MgmtRespDate.enable();
                            MgmtRespDate.wrapper.find(".k-icon").removeClass("noedit").addClass("editRequired");
                            MgmtRespDate.wrapper.find(".k-picker-wrap").removeClass("noedit").addClass("editRequired");
                            MgmtRespDate.wrapper.find(".k-autocomplete").removeClass("noedit").addClass("editRequired");
                        }
                        //                        ExpectedCompletionDateManager.enable();
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-icon").removeClass("noedit").addClass("editRequired");
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-picker-wrap").removeClass("noedit").addClass("editRequired");
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-autocomplete").removeClass("noedit").addClass("editRequired");
                        // DROPDOWNS
                        view_RecTracking.enableAdminFields(false);
                        IntendedAction.find(".k-icon").removeClass("noedit").addClass("editRequired");
                        IntendedAction.find(".k-dropdown-wrap").removeClass("noedit").addClass("editRequired");
                        if (view_RecTracking.clientFeatures().indexOf("Q") > -1) {
                            MgmtRespAction.find(".k-icon").removeClass("noedit").addClass("editRequired");
                            MgmtRespAction.find(".k-dropdown-wrap").removeClass("noedit").addClass("editRequired");
                        }
                        if (view_RecTracking.clientFeatures().indexOf("@") > -1) {
                            ThirdLvlRespAction.find(".k-icon").removeClass("noedit").addClass("editRequired");
                            ThirdLvlRespAction.find(".k-dropdown-wrap").removeClass("noedit").addClass("editRequired");
                        }

                        // PLAIN TEXT
                        $("#ActualCostToComplete").removeAttr("readonly");
                        $("#ActualCostToComplete").removeClass("noedit").addClass("editRequired");
                        $("#PlantComment").removeAttr("readonly");
                        $("#PlantComment").removeClass("noedit").addClass("editRequired");
                        $("#ResponseFrom").removeAttr("readonly");
                        $("#ResponseFrom").removeClass("noedit").addClass("editRequired");
                        if (view_RecTracking.clientFeatures().indexOf("Q") > -1) {
                            $("#MgmtRespFrom").removeAttr("readonly");
                            $("#MgmtRespFrom").removeClass("noedit").addClass("editRequired");
                            $("#MgmtRespComment").removeAttr("readonly");
                            $("#MgmtRespComment").removeClass("noedit").addClass("editRequired");
                        }
                        if (view_RecTracking.clientFeatures().indexOf("@") > -1) {
                            $("#lvl3RespFrom").removeAttr("readonly");
                            $("#lvl3RespFrom").removeClass("noedit").addClass("editRequired");
                            $("#lvl3Commment").removeAttr("readonly");
                            $("#lvl3Commment").removeClass("noedit").addClass("editRequired");
                        }
                        
                        //$("#RecYear").attr("readonly", "readonly");
                        //$("#RecYear").removeClass("editRequired").addClass("noedit");
                        //$("#RecMonth").attr("readonly", "readonly");
                        //$("#RecMonth").removeClass("editRequired").addClass("noedit");
                        //$("#RecNumber").attr("readonly", "readonly");
                        //$("#RecNumber").removeClass("editRequired").addClass("noedit");
                        //$("#SavingsRatio").attr("readonly", "readonly");
                        //$("#SavingsRatio").removeClass("editRequired").addClass("noedit");

                        // SHOW ICONS ON NO ADMIN
                        //LossExpectancyBefore.find(".k-icon").hide();
                        //LossExpectancyAfter.find(".k-icon").hide();
                        //CostToComplete.find(".k-icon").hide();
                        StatusDate.wrapper.find(".k-icon").hide();
                        RecStatus.find(".k-icon").hide();
                        Impact.find(".k-icon").hide();
                        //RecPrimary.find(".k-icon").hide();
                        //RecSecondary.find(".k-icon").hide();
                        IntendedAction.find(".k-icon").show();
                        if (view_RecTracking.clientFeatures().indexOf("Q") > -1) {
                            MgmtRespAction.find(".k-icon").show();
                        }
                        if (view_RecTracking.clientFeatures().indexOf("@") > -1) {
                            ThirdLvlRespAction.find(".k-icon").show();
                        }
                        ResponseDate.wrapper.find(".k-icon").show();
                        ExpectedCompletionDate.wrapper.find(".k-icon").show();
                        if (view_RecTracking.clientFeatures().indexOf("Q") > -1) { MgmtRespDate.wrapper.find(".k-icon").show(); }
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-icon").show();

                    } else {
                        // USER IS NOT AN ADMIN AND DISABLES
                        // DISABLE PICKERS NOT BOUT BY KNOCKOUT AND CHANGE ALL BACK TO WHITE
                        // DATES
                        StatusDate.enable(false);
                        ResponseDate.enable(false);
                        ResponseDate.wrapper.find(".k-icon").removeClass("editRequired").addClass("noedit");
                        ResponseDate.wrapper.find(".k-picker-wrap").removeClass("editRequired").addClass("noedit");
                        ResponseDate.wrapper.find(".k-autocomplete").removeClass("editRequired").addClass("noedit");
                        ExpectedCompletionDate.enable(false);
                        ExpectedCompletionDate.wrapper.find(".k-icon").removeClass("editRequired").addClass("noedit");
                        ExpectedCompletionDate.wrapper.find(".k-picker-wrap").removeClass("editRequired").addClass("noedit");
                        ExpectedCompletionDate.wrapper.find(".k-autocomplete").removeClass("editRequired").addClass("noedit");
                        if (view_RecTracking.clientFeatures().indexOf("Q") > -1) {
                            MgmtRespDate.enable(false);
                            MgmtRespDate.wrapper.find(".k-icon").removeClass("editRequired").addClass("noedit");
                            MgmtRespDate.wrapper.find(".k-picker-wrap").removeClass("editRequired").addClass("noedit");
                            MgmtRespDate.wrapper.find(".k-autocomplete").removeClass("editRequired").addClass("noedit");
                        }
                        //                        ExpectedCompletionDateManager.enable(false);
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-icon").removeClass("editRequired").addClass("noedit");
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-picker-wrap").removeClass("editRequired").addClass("noedit");
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-autocomplete").removeClass("editRequired").addClass("noedit");
                        // DROPDOWNS
                        view_RecTracking.enableAdminFields(false);
                        IntendedAction.find(".k-icon").removeClass("editRequired").addClass("noedit");
                        IntendedAction.find(".k-dropdown-wrap").removeClass("editRequired").addClass("noedit");
                        if (view_RecTracking.clientFeatures().indexOf("Q") > -1) {
                            MgmtRespAction.find(".k-icon").removeClass("editRequired").addClass("noedit");
                            MgmtRespAction.find(".k-dropdown-wrap").removeClass("editRequired").addClass("noedit");
                        }
                        if (view_RecTracking.clientFeatures().indexOf("@") > -1) {
                            ThirdLvlRespAction.find(".k-icon").removeClass("editRequired").addClass("noedit");
                            ThirdLvlRespAction.find(".k-dropdown-wrap").removeClass("editRequired").addClass("noedit");
                        }
                        // PLAIN TEXT
                        //$("#RecYear").attr("readonly", "readonly");
                        //$("#RecYear").removeClass("editRequired").addClass("noedit");
                        //$("#RecMonth").attr("readonly", "readonly");
                        //$("#RecMonth").removeClass("editRequired").addClass("noedit");
                        //$("#RecNumber").attr("readonly", "readonly");
                        //$("#RecNumber").removeClass("editRequired").addClass("noedit");
                        //$("#SavingsRatio").attr("readonly", "readonly");
                        //$("#SavingsRatio").removeClass("editRequired").addClass("noedit");
                        //$("#ActualCostToComplete").attr("readonly", "readonly");
                        //$("#ActualCostToComplete").removeClass("editRequired").addClass("noedit");
                        $("#ResponseFrom").attr("readonly", "readonly");
                        $("#ResponseFrom").removeClass("editRequired").addClass("noedit");
                        if (view_RecTracking.clientFeatures().indexOf("@") > -1) {
                            $("#lvl3RespFrom").attr("readonly", "readonly");
                            $("#lvl3RespFrom").removeClass("editRequired").addClass("noedit");
                        }
                        $("#PlantComment").attr("readonly", "readonly");
                        $("#PlantComment").removeClass("editRequired").addClass("noedit");
                        if (view_RecTracking.clientFeatures().indexOf("Q") > -1) {
                            $("#MgmtRespFrom").attr("readonly", "readonly");
                            $("#MgmtRespFrom").removeClass("editRequired").addClass("noedit");
                            $("#MgmtRespComment").attr("readonly", "readonly");
                            $("#MgmtRespComment").removeClass("editRequired").addClass("noedit");
                        }
                        // HIDE ICONS ON NO ADMIN
                        ResponseDate.wrapper.find(".k-icon").hide();
                        ExpectedCompletionDate.wrapper.find(".k-icon").hide();
                        Impact.find(".k-icon").hide();
                        //RecPrimary.find(".k-icon").hide();
                        //RecSecondary.find(".k-icon").hide();
                        StatusDate.wrapper.find(".k-icon").hide();
                        RecStatus.find(".k-icon").hide();

                        if (view_RecTracking.clientFeatures().indexOf("Q") > -1) {
                            MgmtRespDate.wrapper.find(".k-icon").hide();
                            MgmtRespAction.find(".k-icon").hide();
                        }
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-icon").hide();
                        //LossExpectancyBefore.find(".k-icon").hide();
                        //LossExpectancyAfter.find(".k-icon").hide();
                        //CostToComplete.find(".k-icon").hide();
                        IntendedAction.find(".k-icon").hide();
                        if (view_RecTracking.clientFeatures().indexOf("@") > -1) {
                            ThirdLvlRespAction.find(".k-icon").hide();
                        }
                    }
                }
            },

            // LOAD ONLY THE LOWER DETAILS, ONE OR ALL DEPENDING ON STATE
            loadDetailsOnly: function () {
                view_RecTracking.stateLoadError = false;
                var tempHemisphere = getHemisphere(calculate_time_zone());
                var tempParm = view_RecTracking.gSafeGuid;
                es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
                if (view_RecTracking.stateDetailsLoadOneRecord == true && view_RecTracking.stateLoadError == false) {
                    if (!view_RecTracking.collRec.IRRecommendationCollection_BrowseByLocation(tempParm + "|" + tempHemisphere + "|one")) { view_RecTracking.stateLoadError = false } else { view_RecTracking.stateLoadError = true }
                    view_RecTracking.stateDetailsLoadOneRecord = false;
                    view_RecTracking.stateOnlyOneDetailRecordLoaded = true;
                } else {
                    if (!view_RecTracking.collRec.IRRecommendationCollection_BrowseByLocation(tempParm + "|" + tempHemisphere + "|all")) { view_RecTracking.stateLoadError = false } else { view_RecTracking.stateLoadError = true }
                    view_RecTracking.stateDetailsLoadOneRecord = false;
                    view_RecTracking.stateOnlyOneDetailRecordLoaded = false;
                }
                if (!view_RecTracking.stateLoadError) {
                    view_RecTracking.objRec(view_RecTracking.collRec()[view_RecTracking.index]);
                } else {
                    // DISPLAY ERROR MESSAGE
                    view_RecTracking.messageError("* Error while loading record.");
                }
            },

            // LOAD ONE FILE NUMBER AND ONE DETAIL
            loadOneFileNumber: function () {
                view_RecTracking.stateLoadError = false;

                var tempParm = view_RecTracking.gSafeGuid + "|" + view_RecTracking.fileDirection() + "|one";
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view_RecTracking.collListing.ViewCCLocationIRCollections(tempParm)) { view_RecTracking.stateLoadError = false } else { view_RecTracking.stateLoadError = true }
                view_RecTracking.stateListingLoadOneRecord = false;

                var tempHemisphere = getHemisphere(calculate_time_zone());
                tempParm = view_RecTracking.gSafeGuid + "|" + tempHemisphere + "|one";
                es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
                if (!view_RecTracking.collRec.IRRecommendationCollection_BrowseByLocation(tempParm)) { view_RecTracking.stateLoadError = false } else { view_RecTracking.stateLoadError = true }
                view_RecTracking.stateDetailsLoadOneRecord = false;
                view_RecTracking.stateOnlyOneDetailRecordLoaded = true;

                view_RecTracking.objListing(view_RecTracking.collListing()[0]);
                view_RecTracking.objRec(view_RecTracking.collRec()[0]);
                view_RecTracking.objFind(getFindLocationFields(view_RecTracking.gSafeGuid));
                if (view_RecTracking.objFind().findCriteria == undefined || view_RecTracking.objFind().findCriteria == "") {
                    viewFindCriteria_rectracking.findCriteria(" ");
                    view_RecTracking.findEngaged(true);
                } else {
                    viewFindCriteria_rectracking.findCriteria(view_RecTracking.objFind().findCriteria);
                    view_RecTracking.findEngaged(false);
                }
                view_RecTracking.setupButtons();
                view_RecTracking.setupFileButtons();
            },

            // LOAD ALL RECORDS AND ALL DETAILS
            loadFileNumber: function () {
                view_RecTracking.stateLoadError = false;

                // LOAD THE LOACATION LISTINGS, ONE OR ALL, WITH FILE DIRECTION
                var tempParm = view_RecTracking.gSafeGuid + "|" + view_RecTracking.fileDirection() + "|one";
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view_RecTracking.collListing.ViewCCLocationIRCollections(tempParm)) { view_RecTracking.stateLoadError = false } else { view_RecTracking.stateLoadError = true }
                view_RecTracking.stateListingLoadOneRecord = false;

                // LOAD ALL DETAILS
                var tempHemisphere = getHemisphere(calculate_time_zone());
                tempParm = view_RecTracking.gSafeGuid + "|" + tempHemisphere + "|all";
                es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
                if (!view_RecTracking.collRec.IRRecommendationCollection_BrowseByLocation(tempParm)) { view_RecTracking.stateLoadError = false } else { view_RecTracking.stateLoadError = true }
                view_RecTracking.stateDetailsLoadOneRecord = false;
                view_RecTracking.stateOnlyOneDetailRecordLoaded = false;

                // DO THE REMAINING CODE TO POPUPLATE THE PAGE
                if (!view_RecTracking.stateLoadError) {
                    view_RecTracking.objListing(view_RecTracking.collListing()[0]);
                    view_RecTracking.objRec(view_RecTracking.collRec()[view_RecTracking.index]);
                    view_RecTracking.clientFeatures(getClientFeatures(view_RecTracking.gSafeGuid));
                    view_RecTracking.objFind(getFindLocationFields(view_RecTracking.gSafeGuid));
                    view_RecTracking.setupButtons();
                    view_RecTracking.setupFileButtons();
                    if (view_RecTracking.objFind().findCriteria == undefined || view_RecTracking.objFind().findCriteria == "") {
                        viewFindCriteria_rectracking.findCriteria(" ");
                        view_RecTracking.findEngaged(true);
                    } else {
                        viewFindCriteria_rectracking.findCriteria(view_RecTracking.objFind().findCriteria);
                        view_RecTracking.findEngaged(false);
                    }
                } else {
                    // DISPLAY ERROR MESSAGE
                    view_RecTracking.messageError("* Error while loading record.");
                }
            },

            // RELOAD AND REFRESH PICKERS
            onClosePrimary: function () {
                view_RecTracking.loadPickers();
                view_RecTracking.objRec().RecSecondary(view_RecTracking.KOcollRecSecondary()[0]);
                view_RecTracking.resetPickers();
                view_RecTracking.messageSave("");
                view_RecTracking.messageValidation("");
            },

            onCloseIntendedAction: function () {
                if (view_RecTracking.objRec().RecStatus().toLowerCase() != "advisory" && view_RecTracking.objRec().RecStatus().toLowerCase() != "conf completed" && view_RecTracking.objRec().RecStatus().toLowerCase() != "removed") {
                    if (view_RecTracking.widgetIntendedAction().value() == "Completed") {
                        view_RecTracking.objRec().RecStatus("Rptd Completed");
                    } else if (view_RecTracking.widgetIntendedAction().value() == "In Progress") {
                        view_RecTracking.objRec().RecStatus("In Progress");
                    } else {
                        view_RecTracking.objRec().RecStatus("Outstanding");
                    }
                }
                if (view_RecTracking.clientFeatures().indexOf("R") > -1) {
                    $('#ExpectedCompletionDate').removeClass('required');
                    if (view_RecTracking.widgetIntendedAction().value() != "Completed" && view_RecTracking.widgetIntendedAction().value() != "Disagree - Will Not Complete" && view_RecTracking.widgetIntendedAction().value() != "No Commitment") {
                        $('#ExpectedCompletionDate').addClass('required');
                    }
                }
                view_RecTracking.objRec().IntendedAction(view_RecTracking.widgetIntendedAction().value());
                view_RecTracking.resetPickers();
                view_RecTracking.messageSave("");
                view_RecTracking.messageValidation("");
            },

            onCloseMgmtIntendedAction: function () {
                //                if (view_RecTracking.intendedActionMgmtFirstEditIndex == undefined) {
                //                    view_RecTracking.intendedActionFirstEditIndex = view_RecTracking.index;
                //                    view_RecTracking.intendedActionFirstEditValue = view_RecTracking.collRec()[intendedActionFirstEditIndex].view_RecTracking.objRec().MgmtRespAction();
                //                }
                view_RecTracking.objRec().MgmtRespAction(view_RecTracking.widgetIntendedActionMgmt().value());
                view_RecTracking.resetPickers();
                view_RecTracking.messageSave("");
                view_RecTracking.messageValidation("");
            },
			
			onCloseThirdLvlIntendedAction: function () {
                    view_RecTracking.objRec().ThirdLevelRespAction(view_RecTracking.widgetIntendedActionThirdLevel().value());
                    view_RecTracking.resetPickers();
                    view_RecTracking.messageSave("");
                    view_RecTracking.messageValidation("");
                },
			
            onCloseAll: function () {
                view_RecTracking.messageSave("");
                view_RecTracking.messageValidation("");
                view_RecTracking.objRec().RecStatus(view_RecTracking.widgetRecStatus().value());
            },

            onSave: function () {
                view_RecTracking.resetObjRec();
                var objTemp = new es.objects.Findings();
                objTemp = view_RecTracking.objRec();
                // PROTECT AGAINST NULLS
                if (objTemp.ResponseFrom() == undefined) { objTemp.ResponseFrom(""); }
                if (objTemp.PlantComment() == undefined) { objTemp.PlantComment(""); }
                if (objTemp.IntendedAction() == undefined) { objTemp.IntendedAction(""); }
                if (objTemp.MgmtRespAction() == undefined) { objTemp.MgmtRespAction(""); }
                if (objTemp.ThirdLevelRespAction() == undefined) { objTemp.ThirdLevelRespAction(""); }
                if (objTemp.RecStatus() == undefined) { objTemp.RecStatus(""); }

                es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
                objTemp.save();
            },

            onEditSave: function () {
                if (view_RecTracking.editState()) {
                    // USER CLICKED SAVE, SAVE THE RECORD AND CHANGE THE BUTTONS AND ENABLE RECORD / LOCATION WALKERS, ENABLE PICKERS, CHANGE COLOR TO YELLOW
                    // VALIDATE IF CORRECT INFO IS IN REC FIELDS
                    view_RecTracking.messageValidation("");
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
                        view_RecTracking.messageValidation("* Error: Please enter a valid " + tempError);
                    } else {
                        if (!view_RecTracking.isResponseActionDateValid("onSave")) {
                            view_RecTracking.messageValidation(view_RecTracking.objLanguageLabels().lblPleaseCheckIntendedActionValidDate);
                        } else {
                            if (view_RecTracking.clientFeatures().indexOf("R") > -1) {
                                if (ExpectedCompletionDate.value() == undefined && ExpectedCompletionDate.value() == null) {
                                    if (view_RecTracking.widgetIntendedAction().value() == "Completed" || view_RecTracking.widgetIntendedAction().value() == "Disagree - Will Not Complete" || view_RecTracking.widgetIntendedAction().value() == "No Commitment") {
                                        $('#ExpectedCompletionDate').removeClass('required');
                                        view_RecTracking.onSave();
                                        view_RecTracking.editState(false);
                                        view_RecTracking.enablePickers(false);
                                        view_RecTracking.loadDetailsOnly(); // ADDED TO CORRECT PROBLEMS WITH WRONG DROPDOWN VALUES.
                                        view_RecTracking.onEnablePickers();
                                        view_RecTracking.messageSave("Your change has been saved.");
                                        view_RecTracking.messageValidation("");
                                        view_RecTracking.setupButtons();
                                        view_RecTracking.setupFileButtons();
                                    } else {
                                        alert("Expected Completion Date is required for this Intended Action.");
                                    }
                                } else {
                                    $('#ExpectedCompletionDate').removeClass('required');
                                    view_RecTracking.onSave();
                                    view_RecTracking.editState(false);
                                    view_RecTracking.enablePickers(false);
                                    view_RecTracking.loadDetailsOnly(); // ADDED TO CORRECT PROBLEMS WITH WRONG DROPDOWN VALUES.
                                    view_RecTracking.onEnablePickers();
                                    view_RecTracking.messageSave("Your change has been saved.");
                                    view_RecTracking.messageValidation("");
                                    view_RecTracking.setupButtons();
                                    view_RecTracking.setupFileButtons();
                                }
                            } else {
                                view_RecTracking.onSave();
                                view_RecTracking.editState(false);
                                view_RecTracking.enablePickers(false);
                                view_RecTracking.loadDetailsOnly(); // ADDED TO CORRECT PROBLEMS WITH WRONG DROPDOWN VALUES.
                                view_RecTracking.onEnablePickers();
                                view_RecTracking.messageSave("Your change has been saved.");
                                view_RecTracking.messageValidation("");
                                view_RecTracking.setupButtons();
                                view_RecTracking.setupFileButtons();
                            }
                        }
                    }
                } else {
                    // USER CLICKED EDIT, CHANGE THE BUTTONS AND ENABLE RECORD / LOCATION WALKERS, DISABLE PICKERS, CHANGE COLOR BACK TO WHITE
                    view_RecTracking.setCancelObject();
                    view_RecTracking.editState(true);
                    view_RecTracking.enablePickers(true);
                    view_RecTracking.onEnablePickers();
                    view_RecTracking.messageSave("");
                    view_RecTracking.messageValidation("");
                    view_RecTracking.setupButtons();
                    view_RecTracking.setupFileButtons();
                    view_RecTracking.enableDelete(true);
                    if ($('#ResponseDate').hasClass('expiredDate')) {
                        $('#ResponseDate').removeClass('expiredDate');
                    }
                }
            },

            isResponseActionDateValid: function (strAction) {
                var returnValue = true;
                if (view_RecTracking.editState()) {
                    if (view_RecTracking.objRec().IntendedAction().toString().toLowerCase().indexOf("will not complete") > -1) {
                        if (ExpectedCompletionDate.value() !== undefined && ExpectedCompletionDate.value() !== null) {
                            returnValue = false;
                        }
                    }
                }
                return returnValue;
            },

            onCancelDelete: function () {
                if (view_RecTracking.editState()) {
                    // USER CLICKED CANCEL, CHANGE BACK TO NORMAL AND DO NOT SAVE, RELOAD ORIGINAL, DISABLE PICKERS, CHANGE COLOR BACK TO WHITE
                    //view_RecTracking.loadFileNumber();
                    if ($('#ExpectedCompletionDate').hasClass('required')) {
                        $('#ExpectedCompletionDate').removeClass('required');
                    }
                    view_RecTracking.cancelPickers();
                    view_RecTracking.objRec(view_RecTracking.collRec()[view_RecTracking.index]);
                    view_RecTracking.editState(false);
                    view_RecTracking.enablePickers(false);
                    view_RecTracking.onEnablePickers();
                    view_RecTracking.resetPickers();
                    view_RecTracking.messageSave("");
                    view_RecTracking.messageValidation("");
                } else {
                    // USER CLICKED DELETE, CONFIRM WITH POPUP OR SOMETHING AND DELETE THE RECORD, DISABLE PICKERS, CHANGE COLOR BACK TO WHITE
                    var yesno = confirm("Are you sure you want to delete this recommendation?");
                    if (yesno) {
                        // DELETE THE RECORD
                        view_RecTracking.collRec.markAsDeleted(view_RecTracking.objRec());
                        if (view_RecTracking.collRec().length > 0) {
                            view_RecTracking.collRec.save();
                            view_RecTracking.editState(false);
                            view_RecTracking.enablePickers(false);
                            view_RecTracking.index--;
                            if (view_RecTracking.index < 0) {
                                view_RecTracking.index = 0;
                            }
                            view_RecTracking.loadFileNumber();
                            if (view_RecTracking.collRec().length < 1) {
                                // GO TO FIRST LOCATION AND FIRST RECORD
                                view_RecTracking.onFileFirst();
                            } else if (view_RecTracking.index >= view_RecTracking.collRec().length) {
                                // GO TO FIRST FIRST RECORD
                                view_RecTracking.onFirst();
                            } else {
                                // DO NOTHING
                            }
                            view_RecTracking.onEnablePickers();
                            view_RecTracking.resetPickers();
                            view_RecTracking.messageSave("The record has been deleted.");
                        } else {
                            view_RecTracking.editState(false);
                            view_RecTracking.enablePickers(false);
                            view_RecTracking.onEnablePickers();
                            view_RecTracking.messageSave("");
                            view_RecTracking.messageValidation("");
                        }
                    }
                }
                view_RecTracking.setupButtons();
                view_RecTracking.setupFileButtons();
            }
        };


        ///////////////////////
        // SETUP BASE URL FOR DATA SERVICE AND LOAD ALL DATA
        var tempIndex = getRecId();
        if (tempIndex != null && tempIndex != undefined) {
            view_RecTracking.index = tempIndex;
        } else {
            view_RecTracking.index = 0;
        }
        view_RecTracking.adminUser = getAdminUser(view_RecTracking.gSafeGuid);
        view_RecTracking.loadFileNumber();
        view_RecTracking.loadPickers();


        ///////////////////////
        // ACTIVATE BINDINGS LAST
        ko.applyBindings(view_RecTracking, $("#view_RecTracking")[0]);
        ko.applyBindings(viewFindCriteria_rectracking, $("#viewFindCriteria_rectracking")[0]);


        ///////////////////////
        // SETUP KENDOUI

        // TOOL TIPS
        var tooltip = $("#form1").kendoTooltip({
            filter: "textarea",
            showAfter: 333,
            width: 450,
            position: "top",
            show: function (e) {
                this.refresh();
                this.content.parent().css("visibility", "hidden");
                if (!view_RecTracking.enablePickers()) {
                    if ($("#PlantComment").is(":hover") && $("#PlantComment").val() != "") {
                        this.content.parent().css("visibility", "visible");
                    }
                    if ($("#MgmtRespComment").is(":hover") && $("#MgmtRespComment").val() != "") {
                        this.content.parent().css("visibility", "visible");
                    }
                }
            }
        }).data("kendoTooltip");

        // TEXTBOXES

        // ERROR WINDOW
        var windowNoLocation = $("#windowNoLocation");
        windowNoLocation.kendoWindow({
            width: "300px",
            height: "200px",
            title: "", // title added below with JQuery
            actions: ["Close"],
            modal: true,
            animation: { open: { effects: "none" }, close: { effects: "default" } }
        });
        
        $("#windowNoLocation").prev().find(".k-window-title").append("<img src='../images/icons/warning/window_warning_24x24.png' align='left' alt='Warning Icon' class='windowIcon'/>  " + view_RecTracking.objLanguageLabels().lblNoLocationFoundTitle);


        // most plain text inputs do not need bound in JS but need kendo widgets for styles
        //        $("#FileNo").kendoAutoComplete();
        //        $("#ClientLocNo").kendoAutoComplete();
        //        $("#Latitude").kendoAutoComplete();
        //        $("#Longitude").kendoAutoComplete();
        //        $("#Address1").kendoAutoComplete();
        //        $("#Division").kendoAutoComplete();
        //        $("#City").kendoAutoComplete();
        //        $("#StProv").kendoAutoComplete();
        //        $("#Facility").kendoAutoComplete();
        //        $("#Country").kendoAutoComplete();
        //        $("#Zip").kendoAutoComplete();
        //        $("#CustomAccess").kendoAutoComplete();

        //        $("#RecYear").kendoAutoComplete();
        //        $("#RecMonth").kendoAutoComplete();
        //        $("#RecNumber").kendoAutoComplete();
        //        var RecYear = $("#RecYear").kendoAutoComplete().data("kendoAutoComplete");
        //        var RecMonth = $("#RecMonth").kendoAutoComplete().data("kendoAutoComplete");
        //        var RecNumber = $("#RecNumber").kendoAutoComplete().data("kendoAutoComplete");

        //        var SavingsRatio = $("#SavingsRatio").kendoAutoComplete().data("kendoAutoComplete");
        //        var ActualCostToComplete = $("#ActualCostToComplete").kendoAutoComplete().data("kendoAutoComplete");
        //        var Recommendation = $("#Recommendation").kendoAutoComplete().data("kendoAutoComplete");
        //        var ResponseFrom = $("#ResponseFrom").kendoAutoComplete().data("kendoAutoComplete");
        //        var MgmtRespFrom = $("#MgmtRespFrom").kendoAutoComplete().data("kendoAutoComplete");

        // DATES
        var StatusDate = $("#StatusDate").kendoDatePicker({
            value: view_RecTracking.objRec().StatusDate(),
            format: "dd-MMM-yy",
            change: function (e) {
                var tempDate = this.value() == null ? null : kendo.toString(new Date(this.value().toString().replace("00:", "12:")))
                view_RecTracking.objRec().StatusDate(kendo.toString(tempDate));
                view_RecTracking.onCloseAll();
            }
        }).data("kendoDatePicker");
        StatusDate.wrapper
            .find(".k-picker-wrap").addClass("expand-padding recInputDate").css("height", "14px")
            .find(".k-select").css("height", "14px").css("border-style", "none")
            .find(".k-icon").css("height", "12px").css("margin-top", "1px");

        var ResponseDate = $("#ResponseDate").kendoDatePicker({
            value: view_RecTracking.objRec().ResponseDate(),
            format: "dd-MMM-yy",
            change: function (e) {
                var tempDate = this.value() == null ? null : kendo.toString(new Date(this.value().toString().replace("00:", "12:")))
                view_RecTracking.objRec().ResponseDate(kendo.toString(tempDate));
                view_RecTracking.onCloseAll();
            }
        }).data("kendoDatePicker");
        ResponseDate.wrapper
            .find(".k-picker-wrap").addClass("expand-padding recInputDateSmall").css("height", "14px")
            .find(".k-select").css("height", "14px").css("border-style", "none")
            .find(".k-icon").css("height", "12px").css("margin-top", "1px");

        var MgmtRespDate;
        if (view_RecTracking.clientFeatures().indexOf("Q") > -1) {
            MgmtRespDate = $("#MgmtRespDate").kendoDatePicker({
                value: view_RecTracking.objRec().MgmtRespDate(),
                format: "dd-MMM-yy",
                change: function (e) {
                    var tempDate = this.value() == null ? null : kendo.toString(new Date(this.value().toString().replace("00:", "12:")))
                    view_RecTracking.objRec().MgmtRespDate(kendo.toString(tempDate));
                    view_RecTracking.onCloseAll();
                }
            }).data("kendoDatePicker");
            MgmtRespDate.wrapper
                .find(".k-picker-wrap").addClass("expand-padding recInputDateSmall").css("height", "14px")
                .find(".k-select").css("height", "14px").css("border-style", "none")
                .find(".k-icon").css("height", "12px").css("margin-top", "1px");
        } else {
            MgmtRespDate = $("#MgmtRespDateEmpty");
        }

        var ExpectedCompletionDate = $("#ExpectedCompletionDate").kendoDatePicker({
            value: view_RecTracking.objRec().ExpectedCompletionDate(),
            format: "dd-MMM-yy",
            change: function (e) {
                var tempDate = this.value() == null ? null : kendo.toString(new Date(this.value().toString().replace("00:", "12:")))
                view_RecTracking.objRec().ExpectedCompletionDate(kendo.toString(tempDate));
                view_RecTracking.onCloseAll();
            }
        }).data("kendoDatePicker");
        ExpectedCompletionDate.wrapper
            .find(".k-picker-wrap").addClass("expand-padding recInputDateSmall").css("height", "14px")
            .find(".k-select").css("height", "14px").css("border-style", "none")
            .find(".k-icon").css("height", "12px").css("margin-top", "1px");

        //        var ExpectedCompletionDateManager = $("#ExpectedCompletionDateManager").kendoDatePicker({
        //            //value: view_RecTracking.objRec().ExpectedCompletionDateManager(),
        //            format: "dd-MMM-yy",
        //            change: function (e) {
        //                view_RecTracking.objRec().ExpectedCompletionDateManager(kendo.toString(this.value()));
        //                view_RecTracking.onCloseAll();
        //            }
        //        }).data("kendoDatePicker");
        //        ExpectedCompletionDateManager.wrapper
        //            .find(".k-picker-wrap").addClass("expand-padding recInputDateSmall").css("height", "14px")
        //            .find(".k-select").css("height", "14px")
        //            .find(".k-icon").css("height", "12px").css("margin-top", "-2px");

		var lvl3RespDate;
            if (view_RecTracking.clientFeatures().indexOf("@") > -1) {
                lvl3RespDate = $('#lvl3RespDate').kendoDatePicker({
                    value: view_RecTracking.objRec().ThirdLevelRespDate(),
                    format: "dd-MMM-yy",
                    change: function (e) {
                        var tempDate = this.value() == null ? null : kendo.toString(new Date(this.value().toString().replace("00:", "12:")))
                        view_RecTracking.objRec().ThirdLevelRespDate(kendo.toString(tempDate));
                        view_RecTracking.onCloseAll();
                    }
                }).data("kendoDatePicker");
                lvl3RespDate.wrapper
                    .find(".k-picker-wrap").addClass("expand-padding recInputDateSmall").css("height", "14px")
                    .find(".k-select").css("height", "14px").css("border-style", "none")
                    .find(".k-icon").css("height", "12px").css("margin-top", "1px");
            }
		
        // DROPDOWN STYLES
        var Impact = $("#Impact");
        Impact.find(".k-dropdown-wrap").addClass("expand-padding recInputRecImpact").css("height", "14px").css("top", "-1px");
        Impact.find(".k-select").css("height", "14px");
        Impact.find(".k-icon").css("height", "12px").css("margin-top", "-2px");

        var RecStatus = $("#RecStatus");
        RecStatus.find(".k-dropdown-wrap").addClass("expand-padding recInputRec").css("height", "14px").css("top", "-1px");
        RecStatus.find(".k-select").css("height", "14px");
        RecStatus.find(".k-icon").css("height", "12px").css("margin-top", "-2px");

        //        var RecPrimary = $("#RecPrimary");
        //        RecPrimary.find(".k-dropdown-wrap").addClass("expand-padding recInputHazard").css("height", "14px").css("top", "-1px");
        //        RecPrimary.find(".k-select").css("height", "14px");
        //        RecPrimary.find(".k-icon").css("height", "12px").css("margin-top", "-2px");

        //        var RecSecondary = $("#RecSecondary");
        //        RecSecondary.find(".k-dropdown-wrap").addClass("expand-padding recInputHazard").css("height", "14px").css("top", "-1px");
        //        RecSecondary.find(".k-select").css("height", "14px");
        //        RecSecondary.find(".k-icon").css("height", "12px").css("margin-top", "-2px");

        //var LossExpectancyBefore = $("#LossExpectancyBefore");
        //LossExpectancyBefore.find(".k-dropdown-wrap").addClass("expand-padding recInputRangeLarge").css("height", "14px").css("top", "-1px");
        //LossExpectancyBefore.find(".k-select").css("height", "14px");
        //LossExpectancyBefore.find(".k-icon").css("height", "12px").css("margin-top", "-2px");

        //var LossExpectancyAfter = $("#LossExpectancyAfter");
        //LossExpectancyAfter.find(".k-dropdown-wrap").addClass("expand-padding recInputRangeLarge").css("height", "14px").css("top", "-1px");
        //LossExpectancyAfter.find(".k-select").css("height", "14px");
        //LossExpectancyAfter.find(".k-icon").css("height", "12px").css("margin-top", "-2px");

        //var CostToComplete = $("#CostToComplete");
        //CostToComplete.find(".k-dropdown-wrap").addClass("expand-padding recInputRangeLarge").css("height", "14px").css("top", "-1px");
        //CostToComplete.find(".k-select").css("height", "14px");
        //CostToComplete.find(".k-icon").css("height", "12px").css("margin-top", "-2px");

        var IntendedAction = $("#IntendedAction");
        IntendedAction.find(".k-dropdown-wrap").addClass("expand-padding recInputIntendedActionSmall").css("height", "14px").css("top", "-1px");
        IntendedAction.find(".k-select").css("height", "14px");
        IntendedAction.find(".k-icon").css("height", "12px").css("margin-top", "-2px");

        var MgmtRespAction;
        if (view_RecTracking.clientFeatures().indexOf("Q") > -1) {
            MgmtRespAction = $("#MgmtRespAction");
            MgmtRespAction.find(".k-dropdown-wrap").addClass("expand-padding recInputIntendedActionSmall").css("height", "14px").css("top", "-1px");
            MgmtRespAction.find(".k-select").css("height", "14px");
            MgmtRespAction.find(".k-icon").css("height", "12px").css("margin-top", "-2px");
        } else {
            MgmtRespAction = $("#MgmtRespActionEmpty");
        }

            var ThirdLvlRespAction;
            if (view_RecTracking.clientFeatures().indexOf("@") > -1) {
                ThirdLvlRespAction = $("#lvl3ActionDD");
                ThirdLvlRespAction.find(".k-dropdown-wrap").addClass("expand-padding recInputIntendedActionSmall").css("height", "14px").css("top", "-1px");
                ThirdLvlRespAction.find(".k-select").css("height", "14px");
                ThirdLvlRespAction.find(".k-icon").css("height", "12px").css("margin-top", "-2px");
            }

            // WHEN ALL DONE CALL THE RESET TO SYNC THE FIND AND THE PICKERS
            // DISABLE THE PICKERS FROM EDITING
            view_RecTracking.setupFindFields();
            view_RecTracking.onEnablePickers();
            view_RecTracking.resetPickers();


        // VALIDATION FUNCTIONS
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

    </form>
</body>
</html>
