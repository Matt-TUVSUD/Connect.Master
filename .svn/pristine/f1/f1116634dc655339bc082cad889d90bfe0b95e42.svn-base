<%@ Page Title="Infrared Recommendation | Global Risk Consultants" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectServerDetail.Master" CodeBehind="rectracking.aspx.vb" Inherits="GRC.Connect.Web.rectracking_infrared" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

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
</asp:Content>

<asp:Content ID="ContentFindCriteria" ContentPlaceHolderID="ContentFindCriteria" runat="server">
    <div class="headerFindCriteria" id="viewFindCriteria" data-bind="with: viewFindCriteria">
        <label data-bind="text: $parent.findCriteria" id="findCriteria"></label>&nbsp;
    </div>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div id="view" data-bind="with: view">
    <!-- TABLE FOR COMPANY / ADDRESS INFORMATION -->
    <!-- SPECIFIC STYLES TO ROWS OR COLUMNS SHOULD BE INLINE -->
    <div class="tableDiv">
        <div>
            <span class="companyLabels1"><label data-bind="text: $parent.objLanguageLabels().lblGRCLocNo, css: { findOn: $parent.objFind().findFileNo, findOff: !$parent.objFind().findFileNo }">GRC Loc. No.</label></span>
            <span class="companyInputs1"><input data-bind="value: $parent.objListing().FileNo, css: { findOnInput: $parent.objFind().findFileNo, findOffInput: !$parent.objFind().findFileNo }" id="FileNo" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs1" tabindex="1" /></span>
            <span class="companyLabels2"><label data-bind="text: $parent.objLanguageLabels().lblClientLocNo, css: { findOn: $parent.objFind().findClientLocNo, findOff: !$parent.objFind().findClientLocNo }">Client Loc. No.</label></span>
            <span class="companyInputs2"><input data-bind="value: $parent.objListing().ClientLocNo, css: { findOnInput: $parent.objFind().findClientLocNo, findOffInput: !$parent.objFind().findClientLocNo }" id="ClientLocNo" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs2" tabindex="2" /></span>
            <span class="companyLabels5"><label data-bind="text: $parent.objLanguageLabels().lblLatitude, css: { findOn: $parent.objFind().findLatitude, findOff: !$parent.objFind().findLatitude }">Latitude</label></span>
            <span class="companyInputs4"><input data-bind="value: $parent.objListing().Latitude, css: { findOnInput: $parent.objFind().findLatitude, findOffInput: !$parent.objFind().findLatitude }" id="Latitude" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs4" tabindex="3"  /></span>
            <span class="companyLabels4"><label data-bind="text: $parent.objLanguageLabels().lblLongitude, css: { findOn: $parent.objFind().findLongitude, findOff: !$parent.objFind().findLongitude }">Longitude</label></span>
            <span class="companyInputs4"><input data-bind="value: $parent.objListing().Longitude, css: { findOnInput: $parent.objFind().findLongitude, findOffInput: !$parent.objFind().findLongitude }" id="Longitude" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs4" tabindex="4"  /></span>
        </div>
        <div>
            <span class="companyLabels1"><label data-bind="text: $parent.objLanguageLabels().lblAddress1, css: { findOn: $parent.objFind().findAddress1, findOff: !$parent.objFind().findAddress1 }">Address</label></span>
            <span class="companyInputs6"><input data-bind="value: $parent.objListing().Address1, css: { findOnInput: $parent.objFind().findAddress1, findOffInput: !$parent.objFind().findAddress1 }" id="Address1" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs6" tabindex="5"  /></span>
            <span class="companyLabels3"><label data-bind="text: $parent.objLanguageLabels().lblDivisionName, css: { findOn: $parent.objFind().findDivision, findOff: !$parent.objFind().findDivision }">Division Name</label></span>
            <span class="companyInputs5"><input data-bind="value: $parent.objListing().Division, css: { findOnInput: $parent.objFind().findDivision, findOffInput: !$parent.objFind().findDivision }" id="Division" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="6"  /></span>
        </div>
        <div>
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
        <div>
            <!-- BUTTONS FOR LOCATION / FILE NUMBER WALK / FIND LOCATION -->
            <span class="companyLabels1"><%--<img data-bind="visible: $parent.loading" src="../../Home_{{VER}}/Images/loading/loadingdetails.gif" style="height: 20px; width: 75px; border: 0px;" alt="Loading" />--%></span>
            <span class="buttonContainerLocationLoading">
                <span><button data-bind="click: $parent.onFileFirst, enable: $parent.enableFilePrev" type="button" class="k-button buttonShape k-icon k-i-seek-w" id="btnFileFirst" tabindex="15"></button></span>
                <span><button data-bind="click: $parent.onFilePrevious, enable: $parent.enableFilePrev" type="button" class="k-button buttonShape k-icon k-i-arrow-w" id="btnFilePrevious" tabindex="16"></button></span>
                <span class="buttonFileRecordLabel" style="width: 130px;">&nbsp;<label data-bind="text: $parent.objLanguageLabels().lblFileRecord">Location</label> <input data-bind="value: $parent.txtFileRecordNumber" id="txtFileRecordNumber" class="k-autocomplete k-input inputCenter inputNoEdit buttonInput" style="width: 80px; margin-bottom: 3px;" readonly="true" />&nbsp;</span>
                <span><button data-bind="click: $parent.onFileNext, enable: $parent.enableFileNext" type="button" class="k-button buttonShape k-icon k-i-arrow-e" id="btnFileNext" tabindex="17"></button></span>
                <span><button data-bind="click: $parent.onFileLast, enable: $parent.enableFileNext" type="button" class="k-button buttonShape k-icon k-i-seek-e" id="btnFileLast" tabindex="18"></button></span>
                <span>&nbsp;</span>
                <span><button data-bind="click: $parent.onFindClear, css: { hidden: $parent.findEngaged }" type="button" class="k-button buttonFindClearShape hidden" tabindex="13">Clear Find</button></span>
                <%--<span><button data-bind="click: $parent.onFind" class="k-button buttonShape" type="submit" style="width: 0px; line-height: normal; border-color: White; background-color: White; padding: 0; margin: 0;" tabindex="14"></button></span>--%><span><button data-bind="click: $parent.onFind" class="k-button buttonFindShape" type="submit" tabindex="14">Find</button></span>
            </span>
            <!-- END BUTTONS FOR LOCATION / FILE NUMBER WALK / FIND LOCATION -->
            <span class="companyLabels6"><label data-bind="text: $parent.objLanguageLabels().lblCustomerAccess, css: { findOn: $parent.objFind().findCustomAccess, findOff: !$parent.objFind().findCustomAccess }">Custom Access</label></span>
            <span class="companyInputs5"><input data-bind="value: $parent.objListing().CustomAccess, css: { findOnInput: $parent.objFind().findCustomAccess, findOffInput: !$parent.objFind().findCustomAccess }" id="CustomAccess" class="k-autocomplete k-input inputNoEdit inputLeft companyInputs5" tabindex="12"  /></span>
        </div>
    </div>
    <!-- END TABLE FOR COMPANY / ADDRESS INFORMATION -->

    <br />&nbsp;<br />

    <!-- TABLE FOR RECOMMENDATION TRACKING INFORMATION -->
    <!-- SPECIFIC STYLES TO ROWS OR COLUMNS SHOULD BE INLINE -->
    <div class="tableDiv">
        <div class="tableDivHeader" style="height: 32px;">
            <img src="../images/banners/rectracking/banner_rectrackingsmall_english.png" alt="Recommendations Tracking Banner" style="width: 810px; height: 32px;" />
        </div>
    </div>
    <div class="tableDivAutoBorders">
    <div class="tableDiv">
        <div>
            <!-- EMPTY ROW AT TOP MUST HAVE HEIGHT SPECIFIED OR IT WILL BE 23px -->
            <span class="bufferLeft" style="height: 10px;"></span>
            <span class="" style="height: 10px; width: 782px;">&nbsp;</span>
            <span class="bufferRight" style="height: 10px;"></span>
        </div>
        <div>
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
        <div>
            <span class="bufferLeft"></span>
            <span class="recLabelLeft" style="height: 21px;"><label data-bind="text: $parent.objLanguageLabels().lblSeverity">Severity</label></span>
            <span class="recInputRecCode" style="height: 21px;"><input data-bind="value: $parent.objRec().Severityrating" id="Severityrating" class="k-autocomplete k-input inputNoEdit inputLeft recInputRecCode" readonly="readonly"/></span>
            <span class="recLabelHazard"><label data-bind="text: $parent.objLanguageLabels().lblRecPrimary">Primary Rec. Type</label></span>
            <span class="recInputHazard"><input data-bind="value: $parent.objRec().RecPrimary" id="RecPrimaryText" class="k-autocomplete k-input inputNoEdit inputLeftKendo recInputHazard" /></span>
            <%--<span class="recInputHazard" id="RecPrimary" style="display: none;">
                <select class="inputNoEdit recInputHazard" data-bind="kendoDropDownList: {
                    data: $parent.KOcollRecPrimary,
                    value: $parent.objRec().RecPrimary,
                    enabled: $parent.enableAlwaysOff,
                    close: $parent.onClosePrimary,
                    widget: $parent.widgetRecPrimary
                }"></select>
            </span>--%>
            <span class="recLabelSecondary"><label data-bind="text: $parent.objLanguageLabels().lblRecSecondary">Secondary Rec. Type</label></span>
            <span class="recInputHazard"><input data-bind="value: $parent.objRec().RecSecondary" id="RecSecondaryText" class="k-autocomplete k-input inputNoEdit inputLeftKendo recInputHazard" /></span>
            <%--<span class="recInputHazard" id="RecSecondary" style="display: none;">
                <select class="inputNoEdit recInputHazard" data-bind="kendoDropDownList: {
                    data: $parent.KOcollRecSecondary,
                    value: $parent.objRec().RecSecondary,
                    enabled: $parent.enableAlwaysOff,
                    close: $parent.onCloseAll,
                    widget: $parent.widgetRecSecondary
                }"></select>
            </span>--%>
            <span class="bufferRight" style="padding-left: 7px;"></span>
        </div>
        <div>
            <span class="bufferLeft"></span>
            <span class="recLabelLeft"><label data-bind="text: $parent.objLanguageLabels().lblRecKeyWord">Rec. Key Word</label></span>
            <span class="recInputKeyWordsLong"><input data-bind="value: $parent.objRec().Recommendation" id="Recommendation" class="k-autocomplete k-input inputNoEdit inputLeftKendo recInputKeyWordsLong" readonly="readonly" /></span>
            <span class="bufferRight" style="padding-left: 5px;"></span>
        </div>
        <div>
            <span class="borderBottom bufferLeft" style="height: 5px;"></span>
            <span class="borderBottom" style="height: 5px; width: 782px;"></span> 
            <span class="borderBottom bufferRight" style="height: 5px;"></span>
        </div>
        <div>
            <span class="bufferLeft" style="height: 5px;"></span>
            <span class="" style="height: 5px; width: 782px;"></span>
            <span class="bufferRight" style="height: 5px;"></span>
        </div>

        <%--
        <div>
            <span class="bufferLeft"></span>
            <span class="recLabelLeft">&nbsp;</span>
            <span class="recLabelRangeLarge"><label data-bind="text: $parent.objLanguageLabels().lblCurrentLossEst">Current Loss Est.</label></span>
            <span class="recLabelRangeLarge"><label data-bind="text: $parent.objLanguageLabels().lblCompletedLossEst">Completed Loss Est.</label></span>
            <span class="recLabelRangeLarge"><label data-bind="text: $parent.objLanguageLabels().lblEstCostToComplete">Est. Cost to Complete</label></span>
            <span class="recLabelRangeSmall"><label data-bind="text: $parent.objLanguageLabels().lblSavingsRatio">Savings Ratio</label></span>
            <span class="recLabelRangeLarge"><label data-bind="text: $parent.objLanguageLabels().lblActCostToComplete">Act. Cost to Complete</label></span>
            <span class="bufferRight" style="padding-left: 1px;"></span>
        </div>
        <!-- ACTUAL LE FIELDS SHOWN ONLY IF CLIENT FEATURES CONTAIN 'L' -->
        <div>
            <span class="bufferLeft"></span>
            <span class="recLabelLeft"><label data-bind="text: $parent.objLanguageLabels().lblActual">Actual</label></span>
            <span class="recInputRangeLargeActual"><input data-bind="value: $parent.objRec().LossExpectancyBeforeActual" id="LossExpectancyBeforeActual" class="k-autocomplete k-input inputNoEdit inputLeft recInputRangeLargeActual" readonly="readonly" /></span>
            <span class="recInputRangeLargeActual"><input data-bind="value: $parent.objRec().LossExpectancyAfterActual" id="LossExpectancyAfterActual" class="k-autocomplete k-input inputNoEdit inputLeft recInputRangeLargeActual" readonly="readonly" /></span>
            <span class="recInputRangeLargeActual"><input data-bind="value: $parent.objRec().CostToCompleteActual" id="CostToCompleteActual" class="k-autocomplete k-input inputNoEdit inputLeft recInputRangeLargeActual" readonly="readonly" /></span>
            <span class="bufferRight" style="padding-left: 2px;"></span>
        </div>
        <!-- LE FIELDS -->
        <div>
            <span class="bufferLeft"></span>
            <span class="recLabelLeft"><label data-bind="text: $parent.objLanguageLabels().lblRange">Range</label></span>
            <span class="recInputRangeCellLarge" id="LossExpectancyBefore">
                <select class="inputNoEdit recInputRangeLarge" data-bind="kendoDropDownList: {
                    data: $parent.KOcollLossbefore,
                    value: $parent.objRec().LossExpectancyBefore,
                    enabled: $parent.enableAlwaysOff,
                    close: $parent.onCloseAll,
                    widget: $parent.widgetLossExpectancyBefore
                }"></select>
            </span>
            <span class="recInputRangeCellLarge" id="LossExpectancyAfter">
                <select class="inputNoEdit recInputRangeLarge" data-bind="kendoDropDownList: {
                    data: $parent.KOcollLossafter,
                    value: $parent.objRec().LossExpectancyAfter,
                    enabled: $parent.enableAlwaysOff,
                    close: $parent.onCloseAll,
                    widget: $parent.widgetLossExpectancyAfter
                }"></select>
            </span>
            <span class="recInputRangeCellLarge" id="CostToComplete">
                <select class="inputNoEdit recInputRangeLarge" data-bind="kendoDropDownList: {
                    data: $parent.KOcollCosttocomplete,
                    value: $parent.objRec().CostToComplete,
                    enabled: $parent.enableAlwaysOff,
                    close: $parent.onCloseAll,
                    widget: $parent.widgetCostToComplete
                }"></select>
            </span>
            <span class="recInputRangeSmallCell"><input data-bind="value: $parent.objRec().SavingsRatio" id="SavingsRatio" class="k-autocomplete k-input inputNoEdit inputLeftKendo recInputRangeSmall" /></span>
            <span class="recInputActualCostToComplete" style="padding-left: 5px;"><input data-bind="value: $parent.objRec().ActualCostToComplete" id="ActualCostToComplete" class="k-autocomplete k-input inputNoEdit inputLeft recInputActualCostToComplete" /></span>
            <span class="bufferRight" style="padding-left: 2px;"></span>
        </div>
        --%>

        <div>
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
        <div>
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
        <div>
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
        <div>
            <span class="bufferLeft" style="height: 32px;"></span>
            <span class="recLabelLeft" style="height: 32px;"><label data-bind="text: $parent.objLanguageLabels().lblFacilityComment">Facility Comment</label></span>
            <span class="recInputCommentsLarge" style="height: 32px;">
                <textarea data-bind="value: $parent.objRec().PlantComment, attr: { title: $parent.objRec().PlantComment }" id="PlantComment" class="k-textbox inputNoEdit recInputCommentsLarge" rows="8" cols="20" style="white-space: pre-wrap;"></textarea>
            </span>
            <span class="bufferRight" style="height: 32px; padding-left: 4px;"></span>
        </div>

        <%-- THE BELOW FIELDS WILL BE CHANGED AND UN COMMENTED WHEN GARY ADDS NEW MANAGER RESPONSE FIELDS TO THE DB --%>
        <div data-bind="if: $parent.clientFeatures().search('Q') > -1">
            <span class="borderBottom bufferLeft" style="height: 5px;"></span>
            <span class="borderBottom" style="height: 5px; width: 782px;"></span> 
            <span class="borderBottom bufferRight" style="height: 5px;"></span>
        </div>
        <div data-bind="if: $parent.clientFeatures().search('Q') > -1">
            <span class="bufferLeft" style="height: 5px;"></span>
            <span class="" style="height: 5px; width: 782px;"></span> 
            <span class="bufferRight" style="height: 5px;"></span>
        </div>
        <div data-bind="if: $parent.clientFeatures().search('Q') > -1">
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
        <div data-bind="if: $parent.clientFeatures().search('Q') > -1">
            <span class="bufferLeft" style="height: 32px;"></span>
            <span class="recLabelLeft" style="height: 32px;"><label data-bind="text: $parent.objLanguageLabels().lblMgmtComment">Mgmt. Comment</label></span>
            <span class="recInputCommentsLarge" style="height: 32px;">
                <textarea data-bind="value: $parent.objRec().MgmtRespComment, attr: { title: $parent.objRec().MgmtRespComment }" id="MgmtRespComment" class="k-textbox inputNoEdit recInputCommentsLarge" rows="8" cols="20" style="white-space: pre-wrap;"></textarea>
            </span>
            <span class="bufferRight" style="height: 32px; padding-left: 4px"></span>
        </div>
        <div style="height: 0px;">
            <span id="MgmtRespDateEmpty" style="height: 0px;"></span>
            <span id="MgmtRespActionEmpty" style="height: 0px;"></span>
        </div>
        <%-- THE ABOVE FIELDS WILL BE CHANGED AND UN COMMENTED WHEN GARY ADDS NEW MANAGER RESPONSE FIELDS TO THE DB --%>

        <div>
            <span class="bufferLeft"></span>
            <span class="buttonCell" style="text-align: left; padding-left: 89px;"><button class="k-button k-button-padding" style="width: 90px;" id="editSave" data-bind="click: $parent.onEditSave, text: $parent.txtEditSave, enable: $parent.enableNoLocationFound">Edit</button></span>
            <span class="buttonCell" style="text-align: left;"><button class="k-button k-button-padding" style="width: 90px;" id="cancelDelete" data-bind="visible: $parent.enableDelete, click: $parent.onCancelDelete, text: $parent.txtCancelDelete, enable: $parent.enableNoLocationFound">Delete</button></span>
            <span class="buttonCellRecord">
                <div class="buttonContainer">
                    <span><button data-bind="click: $parent.onFirst, enable: $parent.enablePrev" class="k-button buttonShape k-icon k-i-seek-w" id="btnFirst"></button></span>
                    <span><button data-bind="click: $parent.onPrevious, enable: $parent.enablePrev" class="k-button buttonShape k-icon k-i-arrow-w" id="btnPrevious"></button></span>
                    <span class="buttonRecordLabel">&nbsp;<label data-bind="text: $parent.objLanguageLabels().lblRecord">Record</label> <input data-bind="value: $parent.txtRecordNumber" id="txtRecordNumber" class="k-autocomplete k-input inputCenter inputNoEdit buttonInput" style="margin-bottom: 3px;" readonly="true" />&nbsp;</span>
                    <span><button data-bind="click: $parent.onNext, enable: $parent.enableNext" class="k-button buttonShape k-icon k-i-arrow-e" id="btnNext"></button></span>
                    <span><button data-bind="click: $parent.onLast, enable: $parent.enableNext" class="k-button buttonShape k-icon k-i-seek-e" id="btnLast"></button></span>
                </div>
            </span>
            <%--<span class="buttonCell"><div class="k-button k-button-padding" style="width: 110px; margin-left: 60px;" data-bind="click: $parent.onDatasheetView, enable: $parent.enableNoLocationFound"><label data-bind="text: $parent.objLanguageLabels().lblDatasheetView">Datasheet View</label></div></span>--%>
            <span class="buttonCell"><a id="hypRecDatasheet" href="#" data-bind="click: $parent.onDatasheetView, enable: $parent.enableNoLocationFound">Datasheet View</a></span>
            <span class="bufferRight"></span>
        </div>
        <div>
            <span class="bufferLeftAutoHeight"></span>
            <span class="messageHeight" style="padding-left: 0px;">
                &nbsp;<label class="messageNotice" data-bind="text: $parent.messageSave"></label><label class="messageError" data-bind="text: $parent.messageValidation"></label>
            </span> 
            <span class="bufferRight"></span>
        </div>
        <div>
            <span class="bufferLeft"></span>
            <span class="" style="height: 15px;">&nbsp;</span> 
            <span class="bufferRight"></span>
        </div>
    </div>
    </div>
    <!-- END TABLE FOR RECOMMENDATION TRACKING INFORMATION -->

    <!-- AREA FOR ERROR AND NOTICE MESSAGES -->
    <div style="padding-top: 20px; text-align: center;"><label class="messageError" data-bind="text: $parent.messageError"></label><label class="messageNotice" data-bind="text: $parent.messageNotice"></label><label class="messageWarning" data-bind="text: $parent.messageWarning"></label>&nbsp;</div>

    <!-- ERROR WINDOW FOR NO RECORD FOUND NOTIFICATION -->
    <div id="windowNoLocation" class="windowContent" style="font-size:13px;">
        <div><img src="../images/icons/warning/sign_warning_32x32.png" align="left" alt="Warning" class="windowImage" /></div>
        <div style="margin-bottom:5px;"><label data-bind="text: $parent.objLanguageLabels().lblNoLocationFoundMessage">Warning: There are no recommendation records found for this location.</label></div>
        <div style="margin-bottom:5px;"><label data-bind="text: $parent.objLanguageLabels().lblNoLocationFoundDescription">Click the below button to go back to the Location Details page, or use the Location Navigation buttons to go to another location record.</label></div>
        <div style="justify-content: center; width:100%; display:flex;"><button class="k-button k-button-padding" data-bind="text: $parent.objLanguageLabels().lblGoBackToDetails, click: $parent.onLocationDetailsRedirect">Go Back To Location Details</button></div>
    </div>

    <br />&nbsp;<br />


</div>

<div style="width: 987px; padding-top: 50px; padding-left: 0px; padding-right: 0px; padding-bottom: 0px; clear: both;"></div>

<script type="text/javascript">
    $(document).ready(function () {
        ///////////////////////////////////////////
        //// LOAD SESSION VARIABLES
        var dsLanguageLabels = {
            //// COMPANY INFORMATION
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

            //// REC TRACKING
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

            //// MISC
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
            MgmtRespComment: ""
        };


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
        //// VIEWMODEL
        var viewFindCriteria = {
            findCriteria: ko.observable()
        };
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

            objRec: ko.observable(),
            objListing: ko.observable(),
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
                if (!view.collImpactList.loadAll()) {
                    tempArray = new Array();
                    for (i = 0; i < view.collImpactList().length; i++) {
                        tempArray.push(view.collImpactList()[i].CategoryText());
                    }
                    view.KOcollImpactList(tempArray);
                } else {
                    view.messageError("* Error while loading Impact Data List.");
                }

                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collIntendedaction.loadAll()) {
                    tempArray = new Array();
                    for (i = 0; i < view.collIntendedaction().length; i++) {
                        tempArray.push(view.collIntendedaction()[i].IntendedActionText());
                    }
                    view.KOcollIntendedaction(tempArray);
                } else {
                    view.messageError("* Error while loading Intended Action Data List.");
                }

                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collIntendedactionMgmt.GetMgmtIntendedActionByFilePrefix(view.gSafeGuid)) {
                    tempArray = new Array();
                    for (i = 0; i < view.collIntendedactionMgmt().length; i++) {
                        tempArray.push(view.collIntendedactionMgmt()[i].EnglishTranslation());
                    }
                    view.KOcollIntendedactionMgmt(tempArray);
                } else {
                    view.messageError("* Error while loading Intended Action Data List.");
                }

                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collRecPrimary.loadAll()) {
                    /////////////////////// PrimaryType THIS IS TWO COLUMN WITH Hazard AS KEY OR collRec().Hazard()
                    tempArray = new Array();
                    for (i = 0; i < view.collRecPrimary().length; i++) {
                        //if (view.collRecPrimary()[i].Hazard() == view.objRec().Hazard()) {
                        tempArray.push(view.collRecPrimary()[i].PrimaryType());
                        //}
                    }
                    view.KOcollRecPrimary(tempArray);
                } else {
                    view.messageError("* Error while loading Primary Rec. Type Data List.");
                }

                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collRecSecondary.loadAll()) {
                    /////////////////////// SecondaryType THIS IS TWO COLUMN WITH PrimaryType AS KEY
                    tempArray = new Array();
                    for (i = 0; i < view.collRecSecondary().length; i++) {
                        if (view.collRecSecondary()[i].PrimaryType() == view.objRec().RecPrimary()) {
                            tempArray.push(view.collRecSecondary()[i].SecondarType());
                        }
                    }
                    view.KOcollRecSecondary(tempArray);
                } else {
                    view.messageError("* Error while loading Secondary Rec. Type Data List.");
                }

                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collStatuslist.loadAll()) {
                    tempArray = new Array();
                    for (i = 0; i < view.collStatuslist().length; i++) {
                        tempArray.push(view.collStatuslist()[i].StatusText());
                    }
                    view.KOcollStatuslist(tempArray);
                } else {
                    view.messageError("* Error while loading Status Data List.");
                }
            },

            //            buildSecondaryRecType: function () {
            //                var tempArray2 = new Array();
            //                for (i = 0; i < view.collSecondaryrectype().length; i++) {
            //                    if (view.collSecondaryrectype()[i].PrimaryType() == view.objRec().PrimaryRecType()) {
            //                        tempArray2.push(view.collSecondaryrectype()[i].SecondarType());
            //                    }
            //                }
            //                view.KOcollSecondaryrectype(tempArray2);
            //            },

            //// BUTTONS FOR RECORD NAVIGATION
            onNext: function () {
                if (view.stateOnlyOneDetailRecordLoaded) {
                    view.loadDetailsOnly();
                }
                if (view.index < view.collRec().length - 1) {
                    view.index++;
                    view.objRec(view.collRec()[view.index]);
                }
                view.setupButtons();
                view.resetPickers();
                view.messageSave("");
                view.messageValidation("");
            },

            onPrevious: function () {
                if (view.index > 0) {
                    view.index--;
                    view.objRec(view.collRec()[view.index]);
                }
                view.setupButtons();
                view.resetPickers();
                view.messageSave("");
                view.messageValidation("");
            },

            onFirst: function () {
                if (view.index > 0) {
                    view.index = 0;
                    view.objRec(view.collRec()[view.index]);
                }
                view.setupButtons();
                view.resetPickers();
                view.messageSave("");
                view.messageValidation("");
            },

            onLast: function () {
                if (view.stateOnlyOneDetailRecordLoaded) {
                    view.loadDetailsOnly();
                }
                if (view.index < view.collRec().length - 1) {
                    view.index = view.collRec().length - 1;
                    view.objRec(view.collRec()[view.index]);
                }
                view.setupButtons();
                view.resetPickers();
                view.messageSave("");
                view.messageValidation("");
            },

            //// BUTTONS FOR FILE NUMBER / LOCATION WALK
            onFileFirst: function () {
                view.fileDirection("first");
                view.index = 0;
                view.stateDetailsLoadOneRecord = true;
                view.loadOneFileNumber(); //view.loadFileNumber();
                view.fileDirection("");
                view.resetPickers();
                view.messageSave("");
                view.messageValidation("");
            },

            onFilePrevious: function () {
                view.fileDirection("previous");
                view.index = 0;
                view.stateDetailsLoadOneRecord = true;
                view.loadOneFileNumber(); //view.loadFileNumber();
                view.fileDirection("");
                view.resetPickers();
                view.messageSave("");
                view.messageValidation("");
            },

            onFileNext: function () {
                view.fileDirection("next");
                view.index = 0;
                view.stateDetailsLoadOneRecord = true;
                view.loadOneFileNumber(); //view.loadFileNumber();
                view.fileDirection("");
                view.resetPickers();
                view.messageSave("");
                view.messageValidation("");
            },

            onFileLast: function () {
                view.fileDirection("last");
                view.index = 0;
                view.stateDetailsLoadOneRecord = true;
                view.loadOneFileNumber(); //view.loadFileNumber();
                view.fileDirection("");
                view.resetPickers();
                view.messageSave("");
                view.messageValidation("");
            },

            //// FIND A RECORD FROM THE LOCATION FIELDS
            onFind: function () {
                //// SET THE GSAFE
                setFindLocationFields(view.gSafeGuid, view.objFind(), view.objListing());
                //// LOOKUP RECORD USING THE ON FIRST NAVIGATE
                view.onFileFirst();
                view.resetPickers();
            },

            onFindClear: function () {
                //// CLEAR THE OBJECT
                view.resetPickers();
                //// SET THE GSAFE
                setFindLocationFields(view.gSafeGuid, view.objFind(), view.objListing());
                //// RELOAD THE FILE NUMBER TO GET THE CORRECT LOCATION COUNT
                view.onFileFirst();
                view.resetPickers();
            },

            onLocationDetailsRedirect: function () {
                //// REDIRECT THE USER TO THE LOCATION DETAILS PAGE
                document.location.href = "locationdetails.aspx" + "?sid=" + view.gSafeGuid;
            },

            onDatasheetView: function () {
                //// BUILD URL AND GO TO DATASHEET VIEW
                var tempURL = "";
                if (view.clientFeatures().search('L') > -1) {
                    tempURL = "recdatasheet.aspx?sid=" + view.gSafeGuid + "&rec=" + view.index;
                } else {
                    tempURL = "recdatasheet.aspx?sid=" + view.gSafeGuid + "&rec=" + view.index;
                }
                document.location.href = tempURL;
            },

            //// ENABLE OR DISABLE BUTTONS AND SHOW RECORD NUMBER
            setupButtons: function () {
                if (view.index == 0) { view.enablePrev(false); } else { view.enablePrev(true); }
                if (view.index == view.collRec().length - 1) { view.enableNext(false); } else { view.enableNext(true); }
                if (view.stateOnlyOneDetailRecordLoaded == true) { view.enableNext(true); }
                if (!view.editState()) {
                    view.txtEditSave(view.objLanguageLabels().lblEdit);
                    view.txtCancelDelete(view.objLanguageLabels().lblDelete);
                } else {
                    view.txtEditSave(view.objLanguageLabels().lblSave);
                    view.txtCancelDelete(view.objLanguageLabels().lblCancel);
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

            setupFileButtons: function () {
                if (view.objListing().RecNum() <= 1) { view.enableFilePrev(false); } else { view.enableFilePrev(true); }
                if (view.objListing().RecNum() >= view.objListing().RecCount()) { view.enableFileNext(false); } else { view.enableFileNext(true); }
                if (view.objListing().RecCount() <= 1) { view.enableFilePrev(false); view.enableFilePrev(false); }
                if (!view.editState()) {
                    // do nothing
                } else {
                    view.enableFilePrev(false);
                    view.enableFileNext(false);
                }
                view.txtFileRecordNumber(view.objListing().RecNum() + " of " + view.objListing().RecCount());
            },

            //// SETUP FIND FIELDS FOR LOCATIONS
            setupFindFields: function () {
                //// FIND TEXT BOXES
                view.objFind().findFileNo = view.objListing().FileNo();
                view.objFind().findClientLocNo = view.objListing().ClientLocNo();
                view.objFind().findAddress1 = view.objListing().Address1();
                view.objFind().findCity = view.objListing().City();
                view.objFind().findStProv = view.objListing().StProv();
                view.objFind().findCountry = view.objListing().Country();
                view.objFind().findZip = view.objListing().Zip();
                view.objFind().findDivision = view.objListing().Division();
                view.objFind().findFacility = view.objListing().Facility();
                view.objFind().findCustomAccess = view.objListing().CustomAccess();
                view.objFind().findLatitude = view.objListing().Latitude();
                view.objFind().findLongitude = view.objListing().Longitude();
            },

            //// RESET FIELDS ON LOAD RECORD
            resetPickers: function () {
                //// COPY THE FIND FIELDS
                view.setupFindFields();

                if (view.objRec().StatusDate() == undefined) { StatusDate.value(""); } else { StatusDate.value(view.objRec().StatusDate()); }
                if (view.objRec().ResponseDate() == undefined) { ResponseDate.value(""); } else { ResponseDate.value(view.objRec().ResponseDate()); }
                if (view.objRec().ExpectedCompletionDate() == undefined) { ExpectedCompletionDate.value(""); } else { ExpectedCompletionDate.value(view.objRec().ExpectedCompletionDate()); }
                view.widgetImpact().value(view.objRec().Impact());
                view.widgetRecStatus().value(view.objRec().RecStatus());
                //view.widgetRecPrimary().value(view.objRec().RecPrimary());
                //view.widgetRecSecondary().value(view.objRec().RecSecondary());
                //view.widgetLossExpectancyBefore().value(view.objRec().LossExpectancyBefore());
                //view.widgetLossExpectancyAfter().value(view.objRec().LossExpectancyAfter());
                //view.widgetCostToComplete().value(view.objRec().CostToComplete());
                view.widgetIntendedAction().value(view.objRec().IntendedAction());
                if (view.clientFeatures().indexOf("Q") > -1) {
                    if (view.objRec().MgmtRespAction() == undefined) { view.widgetIntendedActionMgmt().value(""); } else { view.widgetIntendedActionMgmt().value(view.objRec().MgmtRespAction()); }
                }
                if (view.clientFeatures().indexOf("Q") > -1) {
                    if (view.objRec().MgmtRespDate() == undefined) { MgmtRespDate.value(""); } else { MgmtRespDate.value(view.objRec().MgmtRespDate()); }
                }

                //// DISPLAY WINDOW IF NO RECORD EXISTS OR A MESSAGE IF NO SEARCH FOUND
                windowNoLocation.data("kendoWindow").close();
                view.messageError("");
                view.enableNoLocationFound(true);
                if ((view.objRec().FileNo() == "Not Found" && view.pageRequestedFrom == "topnav") || (view.objListing().FileNo() == "Not Found" && view.pageRequestedFrom == "topnav")) {
                    view.enableNoLocationFound(false);
                    view.messageError(view.objLanguageLabels().lblNoActiveLocations);
                    view.clearPickers();
                    view.clearAddressFields();
                } else if (view.objRec().FileNo() == "Not Found") {
                    view.enableNoLocationFound(false);
                    windowNoLocation.data("kendoWindow").open();
                    $("#windowNoLocation").css("display", "block");
                    view.clearPickers();
                } else if (view.objListing().FileNo() == "Not Found") {
                    view.enableNoLocationFound(false);
                    view.enableNext(false);
                    view.enablePrev(false);
                    view.messageError(view.objLanguageLabels().lblSearchNotFound);
                    view.clearPickers();
                }

                //// ALWAYS CLEAR THE REQUESTING VARIABLE FOR USE OF CLIENT SIDE BUTTON NAVIGATION
                view.pageRequestedFrom = "";

                //// REDRAW THE PAGE
                view.onEnablePickers();
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
                //view.widgetRecPrimary().value("");
                //view.widgetRecSecondary().value("");
                //view.widgetLossExpectancyBefore().value("");
                //view.widgetLossExpectancyAfter().value("");
                //view.widgetCostToComplete().value("");
                view.widgetIntendedAction().value("");
                if (view.clientFeatures().indexOf("Q") > -1) { view.widgetIntendedActionMgmt().value(""); }

                //// HTML / KNOCKOUT DOMS
                $("#RecYear").val("");
                $("#RecMonth").val("");
                $("#RecNumber").val("");
                $("#Findingno").val("");
                $("#Itemno").val("");
                $("#ProbableEquipmentDamageCost").val("");
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
                //objCancel.Recommendation = view.objRec().Recommendation();
                //objCancel.LossExpectancyBefore = view.objRec().LossExpectancyBefore();
                //objCancel.LossExpectancyAfter = view.objRec().LossExpectancyAfter();
                //objCancel.CostToComplete = view.objRec().CostToComplete();
                //objCancel.SavingsRatio = view.objRec().SavingsRatio();
                //objCancel.ActualCostToComplete = view.objRec().ActualCostToComplete();
                if (view.objRec().ResponseDate() == undefined) { objCancel.ResponseDate = null; } else { objCancel.ResponseDate = view.objRec().ResponseDate(); }
                objCancel.ResponseFrom = view.objRec().ResponseFrom();
                objCancel.IntendedAction = view.objRec().IntendedAction();
                if (view.objRec().ExpectedCompletionDate() == undefined) { objCancel.ExpectedCompletionDate = null; } else { objCancel.ExpectedCompletionDate = view.objRec().ExpectedCompletionDate(); }
                objCancel.PlantComment = view.objRec().PlantComment();
                if (view.objRec().MgmtRespDate() == undefined) { objCancel.MgmtRespDate = null; } else { objCancel.MgmtRespDate = view.objRec().MgmtRespDate(); }
                objCancel.MgmtRespFrom = view.objRec().MgmtRespFrom();
                objCancel.IntendedActionMgmt = view.objRec().IntendedAction();
                objCancel.MgmtRespAction = view.objRec().MgmtRespAction();
                //objCancel.ExpectedCompletionDateManager = view.objRec().ExpectedCompletionDateManager();
                objCancel.MgmtRespComment = view.objRec().MgmtRespComment();
            },

            //// RESET FIELDS ON LOAD RECORD
            cancelPickers: function () {
                view.objRec().RecYear(objCancel.RecYear);
                view.objRec().RecMonth(objCancel.RecMonth);
                view.objRec().RecNumber(objCancel.RecNumber);
                view.objRec().RecStatus(objCancel.RecStatus);
                view.objRec().ResponseDate(objCancel.ResponseDate);
                view.objRec().ResponseFrom(objCancel.ResponseFrom);
                view.objRec().IntendedAction(objCancel.IntendedAction);
                view.objRec().ExpectedCompletionDate(objCancel.ExpectedCompletionDate);
                view.objRec().PlantComment(objCancel.PlantComment);
                view.objRec().MgmtRespDate(objCancel.MgmtRespDate);
                view.objRec().MgmtRespFrom(objCancel.MgmtRespFrom);
                view.objRec().MgmtRespAction(objCancel.MgmtRespAction);
                //view.objRec().ExpectedCompletionDateManager(objCancel.ExpectedCompletionDateManager);
                view.objRec().MgmtRespComment(objCancel.MgmtRespComment);
                view.resetPickers();
            },

            resetObjRec: function () {
                view.objRec().RecYear($("#RecYear").val());
                view.objRec().RecMonth($("#RecMonth").val());
                view.objRec().RecNumber($("#RecNumber").val());
            },

            onEnablePickers: function () {
                if (view.adminUser) {
                    //// AN ADMIN USER
                    if (view.enablePickers()) {
                        //// USER IS AN ADMIN AND ENABLES
                        //// ENABLE PICKERS NOT BOUND BY KNOCKOUT AND CHANGE TO YELLOW WHERE NEEDED
                        //// DATES
                        ResponseDate.enable();
                        ResponseDate.wrapper.find(".k-icon").removeClass("noedit").addClass("editRequired");
                        ResponseDate.wrapper.find(".k-picker-wrap").removeClass("noedit").addClass("editRequired");
                        ResponseDate.wrapper.find(".k-autocomplete").removeClass("noedit").addClass("editRequired");
                        if (view.clientFeatures().indexOf("Q") > -1) {
                            MgmtRespDate.enable();
                            MgmtRespDate.wrapper.find(".k-icon").removeClass("noedit").addClass("editRequired");
                            MgmtRespDate.wrapper.find(".k-picker-wrap").removeClass("noedit").addClass("editRequired");
                            MgmtRespDate.wrapper.find(".k-autocomplete").removeClass("noedit").addClass("editRequired");
                        }
                        ExpectedCompletionDate.enable();
                        ExpectedCompletionDate.wrapper.find(".k-icon").removeClass("noedit").addClass("editRequired");
                        ExpectedCompletionDate.wrapper.find(".k-picker-wrap").removeClass("noedit").addClass("editRequired");
                        ExpectedCompletionDate.wrapper.find(".k-autocomplete").removeClass("noedit").addClass("editRequired");
                        //                        ExpectedCompletionDateManager.enable();
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-icon").removeClass("noedit").addClass("editRequired");
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-picker-wrap").removeClass("noedit").addClass("editRequired");
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-autocomplete").removeClass("noedit").addClass("editRequired");
                        //// DROPDOWNS
                        IntendedAction.find(".k-icon").removeClass("noedit").addClass("editRequired");
                        IntendedAction.find(".k-dropdown-wrap").removeClass("noedit").addClass("editRequired");
                        MgmtRespAction.find(".k-icon").removeClass("noedit").addClass("editRequired");
                        MgmtRespAction.find(".k-dropdown-wrap").removeClass("noedit").addClass("editRequired");

                        //// SHOW OR HIDE ICONS
                        StatusDate.wrapper.find(".k-icon").hide();
                        RecStatus.find(".k-icon").hide();
                        IntendedAction.find(".k-icon").show();
                        MgmtRespAction.find(".k-icon").show();
                        ResponseDate.wrapper.find(".k-icon").show();
                        ExpectedCompletionDate.wrapper.find(".k-icon").show();
                        if (view.clientFeatures().indexOf("Q") > -1) { MgmtRespDate.wrapper.find(".k-icon").show(); }
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-icon").show();
                        Impact.find(".k-icon").hide();
                        //RecPrimary.find(".k-icon").hide();
                        //RecSecondary.find(".k-icon").hide();
                        //LossExpectancyBefore.find(".k-icon").hide();
                        //LossExpectancyAfter.find(".k-icon").hide();
                        //CostToComplete.find(".k-icon").hide();

                        //// PLAIN TEXT
                        //$("#RecYear").removeAttr("readonly");
                        //$("#RecYear").removeClass("noedit").addClass("editRequired");
                        //$("#RecMonth").removeAttr("readonly");
                        //$("#RecMonth").removeClass("noedit").addClass("editRequired");
                        //$("#RecNumber").removeAttr("readonly");
                        //$("#RecNumber").removeClass("noedit").addClass("editRequired");
                        $("#ResponseFrom").removeAttr("readonly");
                        $("#ResponseFrom").removeClass("noedit").addClass("editRequired");
                        $("#PlantComment").removeAttr("readonly");
                        $("#PlantComment").removeClass("noedit").addClass("editRequired");
                        $("#ActualCostToComplete").removeAttr("readonly");
                        $("#ActualCostToComplete").removeClass("noedit").addClass("editRequired");
                        $("#MgmtRespFrom").removeAttr("readonly");
                        $("#MgmtRespFrom").removeClass("noedit").addClass("editRequired");
                        $("#MgmtRespComment").removeAttr("readonly");
                        $("#MgmtRespComment").removeClass("noedit").addClass("editRequired");
                        view.enableAdminFields(true);

                    } else {
                        //// USER IS AN ADMIN AND DISABLES
                        //// DISABLE PICKERS NOT BOUT BY KNOCKOUT AND CHANGE ALL BACK TO WHITE
                        //// DATES
                        StatusDate.enable(false);
                        ResponseDate.enable(false);
                        ResponseDate.wrapper.find(".k-icon").removeClass("editRequired").addClass("noedit");
                        ResponseDate.wrapper.find(".k-picker-wrap").removeClass("editRequired").addClass("noedit");
                        ResponseDate.wrapper.find(".k-autocomplete").removeClass("editRequired").addClass("noedit");
                        ExpectedCompletionDate.enable(false);
                        ExpectedCompletionDate.wrapper.find(".k-icon").removeClass("editRequired").addClass("noedit");
                        ExpectedCompletionDate.wrapper.find(".k-picker-wrap").removeClass("editRequired").addClass("noedit");
                        ExpectedCompletionDate.wrapper.find(".k-autocomplete").removeClass("editRequired").addClass("noedit");
                        if (view.clientFeatures().indexOf("Q") > -1) {
                            MgmtRespDate.enable(false);
                            MgmtRespDate.wrapper.find(".k-icon").removeClass("editRequired").addClass("noedit");
                            MgmtRespDate.wrapper.find(".k-picker-wrap").removeClass("editRequired").addClass("noedit");
                            MgmtRespDate.wrapper.find(".k-autocomplete").removeClass("editRequired").addClass("noedit");
                        }
                        //                        ExpectedCompletionDateManager.enable(false);
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-icon").removeClass("editRequired").addClass("noedit");
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-picker-wrap").removeClass("editRequired").addClass("noedit");
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-autocomplete").removeClass("editRequired").addClass("noedit");
                        //// DROPDOWNS
                        //LossExpectancyBefore.find(".k-icon").removeClass("editRequired").addClass("noedit");
                        //LossExpectancyBefore.find(".k-dropdown-wrap").removeClass("editRequired").addClass("noedit");
                        //LossExpectancyAfter.find(".k-icon").removeClass("editRequired").addClass("noedit");
                        //LossExpectancyAfter.find(".k-dropdown-wrap").removeClass("editRequired").addClass("noedit");
                        //CostToComplete.find(".k-icon").removeClass("editRequired").addClass("noedit");
                        //CostToComplete.find(".k-dropdown-wrap").removeClass("editRequired").addClass("noedit");
                        IntendedAction.find(".k-icon").removeClass("editRequired").addClass("noedit");
                        IntendedAction.find(".k-dropdown-wrap").removeClass("editRequired").addClass("noedit");
                        MgmtRespAction.find(".k-icon").removeClass("editRequired").addClass("noedit");
                        MgmtRespAction.find(".k-dropdown-wrap").removeClass("editRequired").addClass("noedit");

                        //// SHOW OR HIDE ICONS
                        IntendedAction.find(".k-icon").show();
                        MgmtRespAction.find(".k-icon").show();
                        ResponseDate.wrapper.find(".k-icon").show();
                        ExpectedCompletionDate.wrapper.find(".k-icon").show();
                        Impact.find(".k-icon").hide();
                        //RecPrimary.find(".k-icon").hide();
                        //RecSecondary.find(".k-icon").hide();
                        StatusDate.wrapper.find(".k-icon").hide();
                        RecStatus.find(".k-icon").hide();
                        if (view.clientFeatures().indexOf("Q") > -1) { MgmtRespDate.wrapper.find(".k-icon").show(); }

                        //                        ExpectedCompletionDateManager.wrapper.find(".k-icon").show();
                        //LossExpectancyBefore.find(".k-icon").hide();
                        //LossExpectancyAfter.find(".k-icon").hide();
                        //CostToComplete.find(".k-icon").hide();

                        //// PLAIN TEXT
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
                        $("#PlantComment").attr("readonly", "readonly");
                        $("#PlantComment").removeClass("editRequired").addClass("noedit");
                        $("#MgmtRespFrom").attr("readonly", "readonly");
                        $("#MgmtRespFrom").removeClass("editRequired").addClass("noedit");
                        $("#MgmtRespComment").attr("readonly", "readonly");
                        $("#MgmtRespComment").removeClass("editRequired").addClass("noedit");
                        view.enableAdminFields(false);
                    }

                } else {
                    //// NOT AN ADMIN USER
                    if (view.enablePickers()) {
                        //// USER IS NOT AN ADMIN AND ENABLES
                        //// ENABLE PICKERS NOT BOUND BY KNOCKOUT AND CHANGE TO YELLOW WHERE NEEDED
                        //// DATES
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
                        if (view.clientFeatures().indexOf("Q") > -1) {
                            MgmtRespDate.enable();
                            MgmtRespDate.wrapper.find(".k-icon").removeClass("noedit").addClass("editRequired");
                            MgmtRespDate.wrapper.find(".k-picker-wrap").removeClass("noedit").addClass("editRequired");
                            MgmtRespDate.wrapper.find(".k-autocomplete").removeClass("noedit").addClass("editRequired");
                        }
                        //                        ExpectedCompletionDateManager.enable();
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-icon").removeClass("noedit").addClass("editRequired");
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-picker-wrap").removeClass("noedit").addClass("editRequired");
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-autocomplete").removeClass("noedit").addClass("editRequired");
                        //// DROPDOWNS
                        view.enableAdminFields(false);
                        IntendedAction.find(".k-icon").removeClass("noedit").addClass("editRequired");
                        IntendedAction.find(".k-dropdown-wrap").removeClass("noedit").addClass("editRequired");
                        MgmtRespAction.find(".k-icon").removeClass("noedit").addClass("editRequired");
                        MgmtRespAction.find(".k-dropdown-wrap").removeClass("noedit").addClass("editRequired");

                        //// PLAIN TEXT
                        $("#ActualCostToComplete").removeAttr("readonly");
                        $("#ActualCostToComplete").removeClass("noedit").addClass("editRequired");
                        $("#PlantComment").removeAttr("readonly");
                        $("#PlantComment").removeClass("noedit").addClass("editRequired");
                        $("#ResponseFrom").removeAttr("readonly");
                        $("#ResponseFrom").removeClass("noedit").addClass("editRequired");
                        $("#MgmtRespFrom").removeAttr("readonly");
                        $("#MgmtRespFrom").removeClass("noedit").addClass("editRequired");
                        $("#MgmtRespComment").removeAttr("readonly");
                        $("#MgmtRespComment").removeClass("noedit").addClass("editRequired");

                        //$("#RecYear").attr("readonly", "readonly");
                        //$("#RecYear").removeClass("editRequired").addClass("noedit");
                        //$("#RecMonth").attr("readonly", "readonly");
                        //$("#RecMonth").removeClass("editRequired").addClass("noedit");
                        //$("#RecNumber").attr("readonly", "readonly");
                        //$("#RecNumber").removeClass("editRequired").addClass("noedit");
                        //$("#SavingsRatio").attr("readonly", "readonly");
                        //$("#SavingsRatio").removeClass("editRequired").addClass("noedit");

                        //// SHOW ICONS ON NO ADMIN
                        //LossExpectancyBefore.find(".k-icon").hide();
                        //LossExpectancyAfter.find(".k-icon").hide();
                        //CostToComplete.find(".k-icon").hide();
                        StatusDate.wrapper.find(".k-icon").hide();
                        RecStatus.find(".k-icon").hide();
                        Impact.find(".k-icon").hide();
                        //RecPrimary.find(".k-icon").hide();
                        //RecSecondary.find(".k-icon").hide();
                        IntendedAction.find(".k-icon").show();
                        MgmtRespAction.find(".k-icon").show();
                        ResponseDate.wrapper.find(".k-icon").show();
                        ExpectedCompletionDate.wrapper.find(".k-icon").show();
                        if (view.clientFeatures().indexOf("Q") > -1) { MgmtRespDate.wrapper.find(".k-icon").show(); }
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-icon").show();

                    } else {
                        //// USER IS NOT AN ADMIN AND DISABLES
                        //// DISABLE PICKERS NOT BOUT BY KNOCKOUT AND CHANGE ALL BACK TO WHITE
                        //// DATES
                        StatusDate.enable(false);
                        ResponseDate.enable(false);
                        ResponseDate.wrapper.find(".k-icon").removeClass("editRequired").addClass("noedit");
                        ResponseDate.wrapper.find(".k-picker-wrap").removeClass("editRequired").addClass("noedit");
                        ResponseDate.wrapper.find(".k-autocomplete").removeClass("editRequired").addClass("noedit");
                        ExpectedCompletionDate.enable(false);
                        ExpectedCompletionDate.wrapper.find(".k-icon").removeClass("editRequired").addClass("noedit");
                        ExpectedCompletionDate.wrapper.find(".k-picker-wrap").removeClass("editRequired").addClass("noedit");
                        ExpectedCompletionDate.wrapper.find(".k-autocomplete").removeClass("editRequired").addClass("noedit");
                        if (view.clientFeatures().indexOf("Q") > -1) {
                            MgmtRespDate.enable(false);
                            MgmtRespDate.wrapper.find(".k-icon").removeClass("editRequired").addClass("noedit");
                            MgmtRespDate.wrapper.find(".k-picker-wrap").removeClass("editRequired").addClass("noedit");
                            MgmtRespDate.wrapper.find(".k-autocomplete").removeClass("editRequired").addClass("noedit");
                        }
                        //                        ExpectedCompletionDateManager.enable(false);
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-icon").removeClass("editRequired").addClass("noedit");
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-picker-wrap").removeClass("editRequired").addClass("noedit");
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-autocomplete").removeClass("editRequired").addClass("noedit");
                        //// DROPDOWNS
                        view.enableAdminFields(false);
                        IntendedAction.find(".k-icon").removeClass("editRequired").addClass("noedit");
                        IntendedAction.find(".k-dropdown-wrap").removeClass("editRequired").addClass("noedit");
                        MgmtRespAction.find(".k-icon").removeClass("editRequired").addClass("noedit");
                        MgmtRespAction.find(".k-dropdown-wrap").removeClass("editRequired").addClass("noedit");
                        //// PLAIN TEXT
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
                        $("#PlantComment").attr("readonly", "readonly");
                        $("#PlantComment").removeClass("editRequired").addClass("noedit");
                        $("#MgmtRespFrom").attr("readonly", "readonly");
                        $("#MgmtRespFrom").removeClass("editRequired").addClass("noedit");
                        $("#MgmtRespComment").attr("readonly", "readonly");
                        $("#MgmtRespComment").removeClass("editRequired").addClass("noedit");
                        //// HIDE ICONS ON NO ADMIN
                        ResponseDate.wrapper.find(".k-icon").hide();
                        ExpectedCompletionDate.wrapper.find(".k-icon").hide();
                        Impact.find(".k-icon").hide();
                        //RecPrimary.find(".k-icon").hide();
                        //RecSecondary.find(".k-icon").hide();
                        StatusDate.wrapper.find(".k-icon").hide();
                        RecStatus.find(".k-icon").hide();

                        if (view.clientFeatures().indexOf("Q") > -1) { MgmtRespDate.wrapper.find(".k-icon").hide(); }
                        //                        ExpectedCompletionDateManager.wrapper.find(".k-icon").hide();
                        //LossExpectancyBefore.find(".k-icon").hide();
                        //LossExpectancyAfter.find(".k-icon").hide();
                        //CostToComplete.find(".k-icon").hide();
                        IntendedAction.find(".k-icon").hide();
                        MgmtRespAction.find(".k-icon").hide();
                    }
                }
            },

            //// LOAD ONLY THE LOWER DETAILS, ONE OR ALL DEPENDING ON STATE
            loadDetailsOnly: function () {
                view.stateLoadError = false;
                var tempHemisphere = getHemisphere(calculate_time_zone());
                var tempParm = view.gSafeGuid;
                es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
                if (view.stateDetailsLoadOneRecord == true && view.stateLoadError == false) {
                    if (!view.collRec.IRRecommendationCollection_BrowseByLocation(tempParm + "|" + tempHemisphere + "|one")) { view.stateLoadError = false } else { view.stateLoadError = true }
                    view.stateDetailsLoadOneRecord = false;
                    view.stateOnlyOneDetailRecordLoaded = true;
                } else {
                    if (!view.collRec.IRRecommendationCollection_BrowseByLocation(tempParm + "|" + tempHemisphere + "|all")) { view.stateLoadError = false } else { view.stateLoadError = true }
                    view.stateDetailsLoadOneRecord = false;
                    view.stateOnlyOneDetailRecordLoaded = false;
                }
                if (!view.stateLoadError) {
                    view.objRec(view.collRec()[view.index]);
                } else {
                    //// DISPLAY ERROR MESSAGE
                    view.messageError("* Error while loading record.");
                }
            },

            //// LOAD ONE FILE NUMBER AND ONE DETAIL
            loadOneFileNumber: function () {
                view.stateLoadError = false;

                var tempParm = view.gSafeGuid + "|" + view.fileDirection() + "|one";
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collListing.ViewCCLocationIRCollections(tempParm)) { view.stateLoadError = false } else { view.stateLoadError = true }
                view.stateListingLoadOneRecord = false;

                var tempHemisphere = getHemisphere(calculate_time_zone());
                tempParm = view.gSafeGuid + "|" + tempHemisphere + "|one";
                es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
                if (!view.collRec.IRRecommendationCollection_BrowseByLocation(tempParm)) { view.stateLoadError = false } else { view.stateLoadError = true }
                view.stateDetailsLoadOneRecord = false;
                view.stateOnlyOneDetailRecordLoaded = true;

                view.objListing(view.collListing()[0]);
                view.objRec(view.collRec()[0]);
                view.objFind(getFindLocationFields(view.gSafeGuid));
                if (view.objFind().findCriteria == undefined || view.objFind().findCriteria == "") {
                    viewFindCriteria.findCriteria(" ");
                    view.findEngaged(true);
                } else {
                    viewFindCriteria.findCriteria(view.objFind().findCriteria);
                    view.findEngaged(false);
                }
                view.setupButtons();
                view.setupFileButtons();
            },

            //// LOAD ALL RECORDS AND ALL DETAILS
            loadFileNumber: function () {
                view.stateLoadError = false;

                //// LOAD THE LOACATION LISTINGS, ONE OR ALL, WITH FILE DIRECTION
                var tempParm = view.gSafeGuid + "|" + view.fileDirection() + "|one";
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!view.collListing.ViewCCLocationIRCollections(tempParm)) { view.stateLoadError = false } else { view.stateLoadError = true }
                view.stateListingLoadOneRecord = false;

                //// LOAD ALL DETAILS
                var tempHemisphere = getHemisphere(calculate_time_zone());
                tempParm = view.gSafeGuid + "|" + tempHemisphere + "|all";
                es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
                if (!view.collRec.IRRecommendationCollection_BrowseByLocation(tempParm)) { view.stateLoadError = false } else { view.stateLoadError = true }
                view.stateDetailsLoadOneRecord = false;
                view.stateOnlyOneDetailRecordLoaded = false;

                //// DO THE REMAINING CODE TO POPUPLATE THE PAGE
                if (!view.stateLoadError) {
                    view.objListing(view.collListing()[0]);
                    view.objRec(view.collRec()[view.index]);
                    view.clientFeatures(getClientFeatures(view.gSafeGuid));
                    view.objFind(getFindLocationFields(view.gSafeGuid));
                    view.setupButtons();
                    view.setupFileButtons();
                    if (view.objFind().findCriteria == undefined || view.objFind().findCriteria == "") {
                        viewFindCriteria.findCriteria(" ");
                        view.findEngaged(true);
                    } else {
                        viewFindCriteria.findCriteria(view.objFind().findCriteria);
                        view.findEngaged(false);
                    }
                } else {
                    //// DISPLAY ERROR MESSAGE
                    view.messageError("* Error while loading record.");
                }
            },

            //// RELOAD AND REFRESH PICKERS
            onClosePrimary: function () {
                view.loadPickers();
                view.objRec().RecSecondary(view.KOcollRecSecondary()[0]);
                view.resetPickers();
                view.messageSave("");
                view.messageValidation("");
            },

            onCloseIntendedAction: function () {
                if (view.objRec().RecStatus().toLowerCase() != "advisory" && view.objRec().RecStatus().toLowerCase() != "conf completed" && view.objRec().RecStatus().toLowerCase() != "removed") {
                    if (view.widgetIntendedAction().value() == "Completed") {
                        view.objRec().RecStatus("Rptd Completed");
                    } else if (view.widgetIntendedAction().value() == "In Progress") {
                        view.objRec().RecStatus("In Progress");
                    } else {
                        view.objRec().RecStatus("Outstanding");
                    }
                }
                view.objRec().IntendedAction(view.widgetIntendedAction().value());
                view.resetPickers();
                view.messageSave("");
                view.messageValidation("");
            },

            onCloseMgmtIntendedAction: function () {
                //                if (view.intendedActionMgmtFirstEditIndex == undefined) {
                //                    view.intendedActionFirstEditIndex = view.index;
                //                    view.intendedActionFirstEditValue = view.collRec()[intendedActionFirstEditIndex].view.objRec().MgmtRespAction();
                //                }
                view.objRec().MgmtRespAction(view.widgetIntendedActionMgmt().value());
                view.resetPickers();
                view.messageSave("");
                view.messageValidation("");
            },

            onCloseAll: function () {
                view.messageSave("");
                view.messageValidation("");
                view.objRec().RecStatus(view.widgetRecStatus().value());
            },

            onSave: function () {
                view.resetObjRec();
                var objTemp = new es.objects.Findings();
                objTemp = view.objRec();

                //// PROTECT AGAINST NULLS
                if (objTemp.ResponseFrom() == undefined) { objTemp.ResponseFrom(""); }
                if (objTemp.PlantComment() == undefined) { objTemp.PlantComment(""); }
                if (objTemp.IntendedAction() == undefined) { objTemp.IntendedAction(""); }
                if (objTemp.MgmtRespAction() == undefined) { objTemp.MgmtRespAction(""); }
                if (objTemp.RecStatus() == undefined) { objTemp.RecStatus(""); }

                es.dataProvider.baseURL = SITEBASEURL + DATASERVERENDPOINT;
                objTemp.save();
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
                        view.messageValidation("* Error: Please enter a valid " + tempError);
                    } else {
                        if (!view.isResponseActionDateValid("onSave")) {
                            view.messageValidation(view.objLanguageLabels().lblPleaseCheckIntendedActionValidDate);
                        } else {
                            view.onSave();
                            view.editState(false);
                            view.enablePickers(false);
                            view.loadDetailsOnly(); //// ADDED TO CORRECT PROBLEMS WITH WRONG DROPDOWN VALUES.
                            view.onEnablePickers();
                            view.messageSave("Your change has been saved.");
                            view.messageValidation("");
                            view.setupButtons();
                            view.setupFileButtons();
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
                    view.setupFileButtons();
                    view.enableDelete(true);
                }
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

            onCancelDelete: function () {
                if (view.editState()) {
                    //// USER CLICKED CANCEL, CHANGE BACK TO NORMAL AND DO NOT SAVE, RELOAD ORIGINAL, DISABLE PICKERS, CHANGE COLOR BACK TO WHITE
                    //view.loadFileNumber();
                    view.cancelPickers();
                    view.objRec(view.collRec()[view.index]);
                    view.editState(false);
                    view.enablePickers(false);
                    view.onEnablePickers();
                    view.resetPickers();
                    view.messageSave("");
                    view.messageValidation("");
                } else {
                    //// USER CLICKED DELETE, CONFIRM WITH POPUP OR SOMETHING AND DELETE THE RECORD, DISABLE PICKERS, CHANGE COLOR BACK TO WHITE
                    var yesno = confirm("Are you sure you want to delete this recommendation?");
                    if (yesno) {
                        //// DELETE THE RECORD
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
                            view.resetPickers();
                            view.messageSave("The record has been deleted.");
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
                view.setupFileButtons();
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
        view.adminUser = getAdminUser(view.gSafeGuid);
        view.loadFileNumber();
        view.loadPickers();


        ///////////////////////////////////////////
        //// ACTIVATE BINDINGS LAST
        ko.applyBindings(view, $("#view")[0]);
        ko.applyBindings(viewFindCriteria, $("#viewFindCriteria")[0]);


        ///////////////////////////////////////////
        //// SETUP KENDOUI
        //// TEXTBOXES

        //// ERROR WINDOW
        var windowNoLocation = $("#windowNoLocation");
        windowNoLocation.kendoWindow({
            width: "300px",
            height: "200px",
            title: "", // title added below with JQuery
            actions: ["Close"],
            animation: { open: { effects: "none" }, close: { effects: "default"} }
        });
        $("#windowNoLocation").closest(".k-window").css({
            top: 275,
            left: 400
        });
        $(document).find(".k-window-title").append("<img src='../images/icons/warning/window_warning_24x24.png' align='left' alt='Warning Icon' class='windowIcon'/>  " + view.objLanguageLabels().lblNoLocationFoundTitle);


        //// most plain text inputs do not need bound in JS but need kendo widgets for styles
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

        //// DATES
        var StatusDate = $("#StatusDate").kendoDatePicker({
            value: view.objRec().StatusDate(),
            format: "dd-MMM-yy",
            change: function (e) {
                var tempDate = this.value() == null ? null : kendo.toString(new Date(this.value().toString().replace("00:", "12:")))
                view.objRec().StatusDate(kendo.toString(tempDate));
                view.onCloseAll();
            }
        }).data("kendoDatePicker");
        StatusDate.wrapper
            .find(".k-picker-wrap").addClass("expand-padding recInputDate").css("height", "14px")
            .find(".k-select").css("height", "14px").css("border-style", "none")
            .find(".k-icon").css("height", "12px").css("margin-top", "1px");

        var ResponseDate = $("#ResponseDate").kendoDatePicker({
            value: view.objRec().ResponseDate(),
            format: "dd-MMM-yy",
            change: function (e) {
                var tempDate = this.value() == null ? null : kendo.toString(new Date(this.value().toString().replace("00:", "12:")))
                view.objRec().ResponseDate(kendo.toString(tempDate));
                view.onCloseAll();
            }
        }).data("kendoDatePicker");
        ResponseDate.wrapper
            .find(".k-picker-wrap").addClass("expand-padding recInputDateSmall").css("height", "14px")
            .find(".k-select").css("height", "14px").css("border-style", "none")
            .find(".k-icon").css("height", "12px").css("margin-top", "1px");

        var MgmtRespDate;
        if (view.clientFeatures().indexOf("Q") > -1) {
            MgmtRespDate = $("#MgmtRespDate").kendoDatePicker({
                value: view.objRec().MgmtRespDate(),
                format: "dd-MMM-yy",
                change: function (e) {
                    var tempDate = this.value() == null ? null : kendo.toString(new Date(this.value().toString().replace("00:", "12:")))
                    view.objRec().MgmtRespDate(kendo.toString(tempDate));
                    view.onCloseAll();
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
            value: view.objRec().ExpectedCompletionDate(),
            format: "dd-MMM-yy",
            change: function (e) {
                var tempDate = this.value() == null ? null : kendo.toString(new Date(this.value().toString().replace("00:", "12:")))
                view.objRec().ExpectedCompletionDate(kendo.toString(tempDate));
                view.onCloseAll();
            }
        }).data("kendoDatePicker");
        ExpectedCompletionDate.wrapper
            .find(".k-picker-wrap").addClass("expand-padding recInputDateSmall").css("height", "14px")
            .find(".k-select").css("height", "14px").css("border-style", "none")
            .find(".k-icon").css("height", "12px").css("margin-top", "1px");

        //        var ExpectedCompletionDateManager = $("#ExpectedCompletionDateManager").kendoDatePicker({
        //            //value: view.objRec().ExpectedCompletionDateManager(),
        //            format: "dd-MMM-yy",
        //            change: function (e) {
        //                view.objRec().ExpectedCompletionDateManager(kendo.toString(this.value()));
        //                view.onCloseAll();
        //            }
        //        }).data("kendoDatePicker");
        //        ExpectedCompletionDateManager.wrapper
        //            .find(".k-picker-wrap").addClass("expand-padding recInputDateSmall").css("height", "14px")
        //            .find(".k-select").css("height", "14px")
        //            .find(".k-icon").css("height", "12px").css("margin-top", "-2px");

        //// DROPDOWN STYLES
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
        if (view.clientFeatures().indexOf("Q") > -1) {
            MgmtRespAction = $("#MgmtRespAction");
            MgmtRespAction.find(".k-dropdown-wrap").addClass("expand-padding recInputIntendedActionSmall").css("height", "14px").css("top", "-1px");
            MgmtRespAction.find(".k-select").css("height", "14px");
            MgmtRespAction.find(".k-icon").css("height", "12px").css("margin-top", "-2px");
        } else {
            MgmtRespAction = $("#MgmtRespActionEmpty");
        }

        //////////////////////////////
        //// WHEN ALL DONE CALL THE RESET TO SYNC THE FIND AND THE PICKERS
        //// DISABLE THE PICKERS FROM EDITING
        view.setupFindFields();
        view.onEnablePickers();
        view.resetPickers();


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
