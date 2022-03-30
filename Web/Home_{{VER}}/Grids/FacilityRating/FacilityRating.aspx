<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/Grids/GridMasterPage.master" CodeBehind="FacilityRating.aspx.vb" Inherits="GRC.Connect.Web.Grids_FacilityRating" %>

<asp:Content ID="GridHeadContent" ContentPlaceHolderID="GridHeadContent" runat="server">
    <script src="../../../Lib_{{VER}}/Grids/FacilityRating.js"></script>
    <script>
        var ServerSide_GridId = "<%=ServerSide_GridId%>";
    </script>
</asp:Content>
<asp:Content ID="GridBodyContent" ContentPlaceHolderID="GridBodyContent" runat="server">
    <div id="viewFacilityRatingGrid" class="pgBodyContent" style="align-content:center; justify-content:center;">

        <!-- LOADING -->
        <%--<div id="divContainerLoading" class="containerLoading" style="display: none;"></div>--%>

        <!-- CONTENT -->
        <div class="" style="max-width: 1550px; width: 100%;">
        <div class="containerContent">
            <div class="containerFormStretch">
                <div id="txtMessage" style="text-align: left;"><%--<span>Message Center:</span>&nbsp;--%><label data-bind="text: txtMessage"></label>&nbsp;</div>
                <!-- SUMMARY LEGEND CHART -->
                <div id="divContainerLegendSummary" style="float: right; display: none;">
                    <table border="0" bordercolor="#cecfce" style="width: 100%; font-family: Arial; font-size: 7pt; font-weight: bold; text-align: center" cellpadding="1" cellspacing="0">
                        <tr align="right">
                            <td>
                                <table id="RatingKeyHeader" border="0" style="border: 1px solid #CECFCE; width: 280px; background:#0046ad; color:#fff;" cellpadding="0" cellspacing="0">
                                    <tr style="text-align: center;">
                                        <td style="width: 120px; border-right: 1px solid #CECFCE; border-bottom:1px solid #CECFCE;">
                                            <label>Overall Rating Key</label>
                                        </td>
                                        <td style="width: 80px; text-align: center;border-right: 1px solid #CECFCE; border-bottom:1px solid #CECFCE;">
                                            <label>% By TIV</label>
                                        </td>
                                        <td style="width: 80px; text-align: center; border-bottom:1px solid #CECFCE;">
                                            <label>% By No. of Loc</label>
                                        </td>
                                    </tr>
                                </table>
                                <table data-bind="foreach: { data: legendDataSummary, includeDestroyed: false }" id="RatingKeyData" border="0" style="width: 280px; border:1px solid #cecfce; border-top: none; margin-top: -1px; text-align:center;" cellpadding="0" cellspacing="0">
                                    <td id="RatingKeyRow1Col1" style="width: 120px; border-bottom:1px solid #CECFCE; border-right:1px solid #CECFCE;" data-bind="style: { backgroundColor: $data.RatingHexColor }">
                                        <label data-bind="text: $data.RatingDesc"></label>
                                    </td>
                                    <td style="width: 80px; font-size: 6pt; font-weight: normal; background:#fff; text-align: center; border-bottom:1px solid #CECFCE; border-right:1px solid #CECFCE;">
                                        <label data-bind="text: $data.PercentByTIV"></label>
                                    </td>
                                    <td style="width: 80px; font-size: 6pt; font-weight: normal; background:#fff; text-align: center; border-bottom:1px solid #CECFCE; ">
                                        <label data-bind="text: $data.PercentByLocations"></label>
                                    </td>
                                </table>
                            </td>
                        </tr>
                    </table>
                </div>
                <!-- DETAIL LEGEND CHART -->
                <div id="divContainerLegendDetail" style="float: right; display: none;">
                    <!-- LEGEND DETAILS CHART FOR FIRE -->
                    <div id="divContainerLegendDetailFire" style="display: none;">
                        <table border="0" style="width: 100%" cellpadding="1" cellspacing="0">
                            <tr align="right">
                                <td>
                                    <table border="0" cellpadding="0" cellspacing="0">
                                        <tr>
                                            <td>
                                                <table border="0" style="width: 600px; background:#0046ad; color:#fff;" cellpadding="0" cellspacing="0">
                                                    <tr>
                                                        <td style="width: 7%; height: 0px; text-align: center;">&nbsp;</td>
                                                        <td style="width: 54%; height: 0px; text-align: center;">
                                                            <label ID="lblPassive" runat="server" data-bind="text: lblPassivePhysicalTxt" style="font-weight: bold; font-family: Arial; font-size: 8pt; color:#eee;"></label>
                                                        </td>
                                                        <td style="width: 36%; height: 0px; text-align: center;">
                                                            <label ID="lblActive" runat="server" data-bind="text: lblActiveMGMTTxt" style="font-weight: bold; font-family: Arial; font-size: 8pt; color:#eee;"></label>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <table border="0" style="width: 600px; border-top:1px solid #eee; background:#0046ad; color:#fff;" cellpadding="1" cellspacing="0">
                                                    <tr>
                                                        <td style="width: 7%; text-align: center;">&nbsp;</td>
                                                        <td style="width: 9%; text-align: center;">
                                                            <label ID="lblFlood" runat="server" style="font-weight: bold; font-family: Arial; font-size: 7pt;">Flood</label>
                                                        </td>
                                                        <td style="width: 9%; text-align: center;">
                                                            <label ID="lblEQ" runat="server" style="font-weight: bold; font-family: Arial; font-size: 7pt;">EQ</label>
                                                        </td>
                                                        <td style="width: 9%; text-align: center;">
                                                            <label ID="lblWindstorm" runat="server" style="font-weight: bold; font-family: Arial; font-size: 7pt;">Wind.</label>
                                                        </td>
                                                        <td style="width: 9%; text-align: center;">
                                                            <label ID="lblConstruction" runat="server" style="font-weight: bold; font-family: Arial; font-size: 7pt;">Constr.</label>
                                                        </td>
                                                        <td style="width: 9%; text-align: center;">
                                                            <label ID="lblOccupancy" runat="server" style="font-weight: bold; font-family: Arial; font-size: 7pt;">Occup.</label>
                                                        </td>
                                                        <td style="width: 9%; text-align: center;">
                                                            <label ID="lblOther" runat="server" style="font-weight: bold; font-family: Arial; font-size: 7pt;">Other</label>
                                                        </td>
                                                        <td style="width: 9%; text-align: center;">
                                                            <label ID="lblPhyProt" runat="server" style="font-weight: bold; font-family: Arial; font-size: 7pt;">Phy. Prot.</label>
                                                        </td>
                                                        <td style="width: 9%; text-align: center;">
                                                            <label ID="lblHE" runat="server" style="font-weight: bold; font-family: Arial; font-size: 7pt;">HE</label>
                                                        </td>
                                                        <td style="width: 9%; text-align: center;">
                                                            <label ID="lblNatHaz" runat="server" style="font-weight: bold; font-family: Arial; font-size: 7pt;">Nat. Haz.</label>
                                                        </td>
                                                        <td style="width: 9%; text-align: center;">
                                                            <label ID="lblBCP" runat="server" style="font-weight: bold; font-family: Arial; font-size: 7pt;">BCP</label>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <table border="0" style="width: 600px" cellpadding="1" cellspacing="0">
                                                    <tr>
                                                        <td style="width: 7%; text-align: right; padding:0px; ">
                                                            <table border="0" style="width: 100%; height:43px;" cellpadding="0" cellspacing="0">
                                                                <tr>
                                                                    <td style="background:#0046ad; color:#fff; boarder-bottom:1px solid #eee;">
                                                                        <label ID="lblGRCLabel" runat="server" style="font-weight: bold; font-family: Arial; font-size: 8pt;">GRC:</label>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td style="background:#0046ad; color:#fff;">
                                                                        <label ID="lblClientLabel" runat="server" style="font-weight: bold; font-family: Arial; font-size: 8pt;">Client:</label>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                        <td style="width: 54%; text-align: left; ">
                                                            <table style="width: 100%; border:1px solid #cecfce; background:#fff;" cellpadding="0" cellspacing="0">
                                                                <tr>
                                                                    <td style="width: 9%; text-align: center; border-right:1px solid #cecfce; border-bottom:1px solid #cecfce;">
                                                                        <label ID="lblGRCFlood" runat="server" data-bind="text: legendWeightDetailFire().FloodWeightGRC" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 9%; text-align: center; border-right:1px solid #cecfce; border-bottom:1px solid #cecfce;">
                                                                        <label ID="lblGRCEQ" runat="server" data-bind="text: legendWeightDetailFire().EarthquakeWeightGRC" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 9%; text-align: center; border-right:1px solid #cecfce; border-bottom:1px solid #cecfce;">
                                                                        <label ID="lblGRCWindstorm" runat="server" data-bind="text: legendWeightDetailFire().WindstormWeightGRC" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 9%; text-align: center; border-right:1px solid #cecfce; border-bottom:1px solid #cecfce;">
                                                                        <label ID="lblGRCConstruction" runat="server" data-bind="text: legendWeightDetailFire().ConstructionWeightGRC" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 9%; text-align: center; border-right:1px solid #cecfce; border-bottom:1px solid #cecfce;">
                                                                        <label ID="lblGRCOccupancy" runat="server" data-bind="text: legendWeightDetailFire().OccupancyWeightGRC" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 9%; text-align: center; border-bottom:1px solid #cecfce;">
                                                                        <label ID="lblGRCOther" runat="server" data-bind="text: legendWeightDetailFire().OtherWeightGRC" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td style="width: 9%; text-align: center; border-right:1px solid #cecfce; ">
                                                                        <label ID="lblClientFlood" runat="server" data-bind="text: legendWeightDetailFire().FloodWeight" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 9%; text-align: center; border-right:1px solid #cecfce; ">
                                                                        <label ID="lblClientEQ" runat="server" data-bind="text: legendWeightDetailFire().EarthquakeWeight" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 9%; text-align: center; border-right:1px solid #cecfce; ">
                                                                        <label ID="lblClientWindstorm" runat="server" data-bind="text: legendWeightDetailFire().WindstormWeight" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 9%; text-align: center; border-right:1px solid #cecfce; ">
                                                                        <label ID="lblClientConstruction" runat="server" data-bind="text: legendWeightDetailFire().ConstructionWeight" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 9%; text-align: center; border-right:1px solid #cecfce; ">
                                                                        <label ID="lblClientOccupancy" runat="server" data-bind="text: legendWeightDetailFire().OccupancyWeight" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 9%; text-align: center;">
                                                                        <label ID="lblClientOther" runat="server" data-bind="text: legendWeightDetailFire().OtherWeight" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                        <td style="width: 36%; text-align: left;">
                                                            <table style="width: 100%; border:1px solid #cecfce; background:#fff;" cellpadding="0" cellspacing="0">
                                                                <tr>
                                                                    <td style="width: 9%; text-align: center; border-right:1px solid #cecfce; border-bottom:1px solid #cecfce;">
                                                                        <label ID="lblGRCPhyProt" runat="server" data-bind="text: legendWeightDetailFire().PhysicalProtectionWeightGRC" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 9%; text-align: center; border-right:1px solid #cecfce; border-bottom:1px solid #cecfce;">
                                                                        <label ID="lblGRCHE" runat="server" data-bind="text: legendWeightDetailFire().HumanElementWeightGRC" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 9%; text-align: center; border-right:1px solid #cecfce; border-bottom:1px solid #cecfce;">
                                                                        <label ID="lblGRCNatHaz" runat="server" data-bind="text: legendWeightDetailFire().NaturalHazardsProtectionWeightGRC" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 9%; text-align: center;border-bottom:1px solid #cecfce;">
                                                                        <label ID="lblGRCBCP" runat="server" data-bind="text: legendWeightDetailFire().BusinessContinuityWeightGRC" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td style="width: 9%; text-align: center; border-right:1px solid #cecfce;">
                                                                        <label ID="lblClientPhyProt" runat="server" data-bind="text: legendWeightDetailFire().PhysicalProtectionWeight" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 9%; text-align: center; border-right:1px solid #cecfce;">
                                                                        <label ID="lblClientHE" runat="server" data-bind="text: legendWeightDetailFire().HumanElementWeight" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 9%; text-align: center; border-right:1px solid #cecfce;">
                                                                        <label ID="lblClientNatHaz" runat="server" data-bind="text: legendWeightDetailFire().NaturalHazardsProtectionWeight" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 9%; text-align: center;">
                                                                        <label ID="lblClientBCP" runat="server" data-bind="text: legendWeightDetailFire().BusinessContinuityWeight" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </div>
                    <!-- DETAILS LEGEND CHART FOR BOILER -->
                    <div id="divContainerLegendDetailBM" style="display: none;">
                        <table border="0" bordercolor="black" style="width: 100%" cellpadding="1" cellspacing="0">
                            <tr align="right">
                                <td>
                                    <table border="0" bordercolor="black" cellpadding="0" cellspacing="0">
                                        <tr>
                                            <td>
                                                <table border="0" style="width: 650px; color:#fff; background:#0046ad; border-bottom:1px solid #eee;" cellpadding="0" cellspacing="0">
                                                    <tr>
                                                        <td style="width: 8%; height: 0px; text-align: center;">&nbsp;</td>
                                                        <td style="width: 48%; height: 0px; text-align: center;">
                                                            <label ID="Label1" runat="server" style="font-weight: bold; font-family: Arial; font-size: 8pt;">Physical Assets Weighting Percentages</label>
                                                        </td>
                                                        <td style="width: 40%; height: 0px; text-align: center;">
                                                            <label ID="Label2" runat="server" style="font-weight: bold; font-family: Arial; font-size: 8pt;">Management Programs Weighting Percentages</label>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <table border="0" bordercolor="black" style="width: 650px; color:#fff; background:#0046ad;" cellpadding="1" cellspacing="0">
                                                    <tr>
                                                        <td style="width: 8%; text-align: center;">&nbsp;</td>
                                                        <td style="width: 8%; text-align: center;">
                                                            <label ID="lblMechEquip" runat="server" style="font-weight: bold; font-family: Arial; font-size: 7pt;">Mech. Equip.</label>
                                                        </td>
                                                        <td style="width: 8%; text-align: center;">
                                                            <label ID="lblElecEquip" runat="server" style="font-weight: bold; font-family: Arial; font-size: 7pt;">Elec. Equip.</label>
                                                        </td>
                                                        <td style="width: 8%; text-align: center;">
                                                            <label ID="lblBoilers" runat="server" style="font-weight: bold; font-family: Arial; font-size: 7pt;">Boilers</label>
                                                        </td>
                                                        <td style="width: 8%; text-align: center;">
                                                            <label ID="lblProcEquip" runat="server" style="font-weight: bold; font-family: Arial; font-size: 7pt;">Proc. Equip.</label>
                                                        </td>
                                                        <td style="width: 8%; text-align: center;">
                                                            <label ID="lblOccup" runat="server" style="font-weight: bold; font-family: Arial; font-size: 7pt;">Occup.</label>
                                                        </td>
                                                        <td style="width: 8%; text-align: center;">
                                                            <label ID="lblCompSys" runat="server" style="font-weight: bold; font-family: Arial; font-size: 7pt;">Comp. Sys.</label>
                                                        </td>
                                                        <td style="width: 8%; text-align: center;">
                                                            <label ID="lblMechMaint" runat="server" style="font-weight: bold; font-family: Arial; font-size: 7pt;">Mech. Maint.</label>
                                                        </td>
                                                        <td style="width: 8%; text-align: center;">
                                                            <label ID="lblElecMaint" runat="server" style="font-weight: bold; font-family: Arial; font-size: 7pt;">Elec. Maint.</label>
                                                        </td>
                                                        <td style="width: 8%; text-align: center;">
                                                            <label ID="lblSpares" runat="server" style="font-weight: bold; font-family: Arial; font-size: 7pt;">Spares</label>
                                                        </td>
                                                        <td style="width: 8%; text-align: center;">
                                                            <label ID="Label3" runat="server" style="font-weight: bold; font-family: Arial; font-size: 7pt;">HE</label>
                                                        </td>
                                                        <td style="width: 8%; text-align: center;">
                                                            <label ID="Label4" runat="server" style="font-weight: bold; font-family: Arial; font-size: 7pt;">BCP</label>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <table border="0" bordercolor="black" style="width: 650px; background:#0046ad;" cellpadding="1" cellspacing="0">
                                                    <tr>
                                                        <td style="width: 8%; text-align: right;">
                                                            <table border="0" bordercolor="black" style="width: 100%" cellpadding="0" cellspacing="0">
                                                                <tr>
                                                                    <td>
                                                                        <label ID="Label5" runat="server" style="font-weight: bold; font-family: Arial; font-size: 8pt; color:#fff;">GRC:</label>
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td>
                                                                        <label ID="Label6" runat="server" style="font-weight: bold; font-family: Arial; font-size: 8pt; color:#fff;">Client:</label>
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                        <td style="width: 48%; text-align: left;">
                                                            <table style="width: 100%; border:1px solid #cecfec;" cellpadding="0" cellspacing="0">
                                                                <tr>
                                                                    <td style="width: 8%; text-align: center; background:#fff; border-right:1px solid #cecfec; border-bottom:1px solid #cecfec;">
                                                                        <label ID="lblGRCMechEquip" runat="server" data-bind="text: legendWeightDetailBM().MechEquipWeightGRC" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 8%; text-align: center; background:#fff; border-right:1px solid #cecfec; border-bottom:1px solid #cecfec;">
                                                                        <label ID="lblGRCElecEquip" runat="server" data-bind="text: legendWeightDetailBM().ElecEquipWeightGRC" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 8%; text-align: center; background:#fff; border-right:1px solid #cecfec; border-bottom:1px solid #cecfec;">
                                                                        <label ID="lblGRCBoilers" runat="server" data-bind="text: legendWeightDetailBM().BoilersWeightGRC" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 8%; text-align: center; background:#fff; border-right:1px solid #cecfec; border-bottom:1px solid #cecfec;">
                                                                        <label ID="lblGRCProcEquip" runat="server" data-bind="text: legendWeightDetailBM().ProcEquipWeightGRC" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 8%; text-align: center; background:#fff; border-right:1px solid #cecfec; border-bottom:1px solid #cecfec;">
                                                                        <label ID="lblGRCOccup" runat="server" data-bind="text: legendWeightDetailBM().OccupancyWeightGRC" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 8%; text-align: center; background:#fff; border-bottom:1px solid #cecfec;">
                                                                        <label ID="lblGRCCompSys" runat="server" data-bind="text: legendWeightDetailBM().CompSysWeightGRC" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td style="width: 8%; text-align: center; background:#fff; border-right:1px solid #cecfec;">
                                                                        <label ID="lblClientMechEquip" runat="server" data-bind="text: legendWeightDetailBM().MechEquipWeight" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 8%; text-align: center; background:#fff; border-right:1px solid #cecfec;">
                                                                        <label ID="lblClientElecEquip" runat="server" data-bind="text: legendWeightDetailBM().ElecEquipWeight" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 8%; text-align: center; background:#fff; border-right:1px solid #cecfec;">
                                                                        <label ID="lblClientBoilers" runat="server" data-bind="text: legendWeightDetailBM().BoilersWeight" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 8%; text-align: center; background:#fff; border-right:1px solid #cecfec;">
                                                                        <label ID="lblClientProcEquip" runat="server" data-bind="text: legendWeightDetailBM().ProcEquipWeight" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 8%; text-align: center; background:#fff; border-right:1px solid #cecfec;">
                                                                        <label ID="lblClientOccup" runat="server" data-bind="text: legendWeightDetailBM().OccupancyWeight" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 8%; text-align: center; background:#fff;">
                                                                        <label ID="lblClientCompSys" runat="server" data-bind="text: legendWeightDetailBM().CompSysWeightGRC" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                        <td style="width: 40%; text-align: left;">
                                                            <table style="width: 100%; border:1px solid #cecfec;" cellpadding="0" cellspacing="0">
                                                                <tr>
                                                                    <td style="width: 8%; text-align: center; background:#fff; border-right:1px solid #cecfec; border-bottom:1px solid #cecfec;">
                                                                        <label ID="lblGRCMechMaint" runat="server" data-bind="text: legendWeightDetailBM().MechMaintWeightGRC" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 8%; text-align: center; background:#fff; border-right:1px solid #cecfec; border-bottom:1px solid #cecfec;">
                                                                        <label ID="lblGRCElecMaint" runat="server" data-bind="text: legendWeightDetailBM().ElecMaintWeightGRC" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 8%; text-align: center; background:#fff; border-right:1px solid #cecfec; border-bottom:1px solid #cecfec;">
                                                                        <label ID="lblGRCSpares" runat="server" data-bind="text: legendWeightDetailBM().SparesWeightGRC" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 8%; text-align: center; background:#fff; border-right:1px solid #cecfec; border-bottom:1px solid #cecfec;">
                                                                        <label ID="Label7" runat="server" data-bind="text: legendWeightDetailBM().HumanElementWeightGRC" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 8%; text-align: center; background:#fff; border-bottom:1px solid #cecfec;">
                                                                        <label ID="Label8" runat="server" data-bind="text: legendWeightDetailBM().BCPWeightGRC" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                </tr>
                                                                <tr>
                                                                    <td style="width: 8%; text-align: center; background:#fff; border-right:1px solid #cecfec;">
                                                                        <label ID="lblClientMechMaint" runat="server" data-bind="text: legendWeightDetailBM().MechMaintWeight" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 8%; text-align: center; background:#fff; border-right:1px solid #cecfec;">
                                                                        <label ID="lblClientElecMaint" runat="server" data-bind="text: legendWeightDetailBM().ElecMaintWeight" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 8%; text-align: center; background:#fff; border-right:1px solid #cecfec;">
                                                                        <label ID="lblClientSpares" runat="server" data-bind="text: legendWeightDetailBM().SparesWeight" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 8%; text-align: center; background:#fff; border-right:1px solid #cecfec;">
                                                                        <label ID="Label9" runat="server" data-bind="text: legendWeightDetailBM().HumanElementWeight" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                    <td style="width: 8%; text-align: center; background:#fff;">
                                                                        <label ID="Label10" runat="server" data-bind="text: legendWeightDetailBM().BCPWeight" style="font-family: Arial; font-size: 7pt;"></label>&nbsp;
                                                                    </td>
                                                                </tr>
                                                            </table>
                                                        </td>
                                                    </tr>
                                                </table>
                                            </td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
                <!-- SORT FILTER PINNED INFO -->
                <div class="section gridTopInfoContainer" style="clear: both;">
                    <div class="col span2of2" style="margin-top: 3px;">
                        <div><label>Sorted:</label>&nbsp;&nbsp;&nbsp;&nbsp;<span data-bind="text: txtSortedBy" id="txtSortedBy"></span></div>
                        <div><label>Filtered:</label>&nbsp;&nbsp;<span data-bind="text: txtFilteredBy" id="txtFilteredBy"></span></div>
                        <div><label>Pinned:</label>&nbsp;&nbsp;&nbsp;<span data-bind="text: txtPinnedBy" id="txtPinnedBy"></span></div>
                    </div>
                    <div class="col span2of2" style="margin-top: 6px; margin-bottom: 4px;">
                        <div><label data-bind="text: txtTotalRecords" id="txtTotalRecords"></label><label> Records</label></div>
                    </div>
                </div>
                <div>
                    <!-- THE GRID -->
                    <div id="gridStandardContainer">
                        <div id="gridStandard"></div>
                    </div>
                </div>
            </div>
        </div>
        </div>

        <!-- FOOTER -->
        <div></div>


        <!-- HIDDEN DOMS -->
        <div id="windowFavorite" class="windowFavorite" style="display: none; margin: 0; padding: 0;">
            <div class="windowFavoriteHeader">To save your Favorite, type in a name in the name box and click Save.</div>
            <div class="windowFavoriteList" data-bind="foreach: { data: favoriteList, includeDestroyed: false }">
                <div class="windowFavoriteListItem"><label data-bind="text: $data.title"></label></div>
            </div>
            <div class="windowFavoriteFooter">
                <div style="float: left;">Name: <input type="text" data-bind="value: favoriteName" maxlength="249" class="k-autocomplete" style="width: 350px; height: 28px;" /></div>
                <div style="float: right;"><button class="k-button pickListButton" data-bind="click: onFavoriteSave">Save</button>&nbsp;<button class="k-button pickListButton" data-bind="    click: onFavoriteCancel">Cancel</button></div>
            </div>
        </div>


        <div id="windowPicklistStandard" class="pickListWindow" style="display: none;">
            <div class="pickListHeader"><label>Check the items to show.</label></div>
            <div class="pickListContent">
                <div id="windowPicklistStandard_Loading" class="pickListLoading"> <!-- MUST USE Name_Loading NAMING FORMAT FOR ID -->
                    <img src="../../Images/loading/loading_2x.gif" class="pickListLoadingImage" />
                </div>
                <div id="windowPicklistStandard_Table" class="pickListTable"></div> <!-- MUST USE Name_Table NAMING FORMAT FOR ID -->
            </div>
            <div class="pickListFooter">
                <button class="k-button pickListButton" data-bind="click: pickListCheckAll">All</button>&nbsp;
                <button class="k-button pickListButton" data-bind="click: pickListCheckNone">None</button>&nbsp;
                <button class="k-button pickListButton" data-bind="click: pickListCheckReverse">Reverse</button>&nbsp;
                <div style="height: 4px;">&nbsp;</div>
                <button class="k-button pickListButton" data-bind="click: pickListApplyFilter">Apply</button>&nbsp;
                <button class="k-button pickListButton" data-bind="click: pickListCancel">Cancel</button>
            </div>
        </div>

    </div>
</asp:Content>

