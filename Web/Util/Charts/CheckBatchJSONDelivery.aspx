<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="CheckBatchJSONDelivery.aspx.vb" Inherits="GRC.Connect.Web.CheckBatchJSONDelivery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="../../Lib_{{VER}}/JQuery.v1.11.3/jquery-1.11.3.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div id="divJSON">
            <textarea id="txtJSON1" cols="100" rows="15"></textarea>
            <br /><br />
            <textarea id="txtJSON2" cols="100" rows="15"></textarea>
        </div>
    </div>
    </form>

    <script>
        $(document).ready(function() {
            var zChartData = "<%= ServerSide_ChartData%>";
            var zFilter = "<%= ServerSide_LargeObjectFilter%>";
            var zCriteria = "<%= ServerSide_LargeObjectCriteria%>";
            var zSettings = "<%= ServerSide_LargeObjectSetting%>";

            var zJSON = JSON.parse(zChartData);

            $("#txtJSON1").val(zChartData);
            $("#txtJSON2").val(JSON.stringify(zJSON), null, 4);

        });

    </script>

</body>



</html>
