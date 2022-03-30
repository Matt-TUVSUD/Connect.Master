$(document).ready(function () {
    var zGUID = getGSafeGUID();
    var defaultUrl = SITEBASEURL;
    //var URLCreateNew = 'CreateNewReport.aspx?gsid=' + zGUID;
    var dashboardPage = '../Home_{{VER}}/Dashboards/DashboardRedirect.aspx';
    var gsafeIdErrorMessage = "GSafeId is required.";
    var defaultErrorMessage = "Report Id is missing.";

    //REPORT NEW REQUIRED - RENAME POPUP DEFAULT
    $("#sRequired").hide();
    //$("#<%= txtNewReportName.ClientID%>").val('');

    //INITIAL LOAD - DISABLE ALL BUTTONS EXCEPT CREATE NEW
    //CONST IS NOT VALID FOR IE11 - MUST BE RE-WRITTEN
    //for (const btn of $("#tblButtons button.selectButton").not('.uCreate')) {
    //    $(btn).prop("disabled", true);
    //}
    $(".uPubPriv").prop("disabled", true);
    $(".uDelete").prop("disabled", true);

    //DISABLE CONNECT DASHBOARDS 'OPEN' BUTTON ON PAGE LOAD
    $('#btnOpenReport').prop("disabled", true);

    var cn = '<%= URLCreateNew %>';
    //if (zGUID != null) {
    //    var cn = URLCreateNew;
    //} else {
    //    cn = '#';
    //}
    if (cn == '#') {
        $(".uCreate").prop("disabled", true);
    }

    $("#grcReportsList").find("button").on("click", function () {
        debugger;
        $(this).addClass('active');
        $('#btnOpenReport').prop("disabled", false);
        var rptId = $(this).attr('reportId');
        $('#btnOpenReport').attr("selectedid", rptId);
        $("#<%=txtSelectedReport.ClientID %>").val(rptId);
    });

    //MANAGE AND SET EVENTS ON RENDERED USER REPORTS 
    $("#userReportsList").find("button").on("click", function () {
        //for (const li of $("div.list-group button.active")) {
        //    li.classList.remove("active");
        //}
        $(this).addClass("active");

        //Get report information for operation of buttons
        //console.log($(this).attr("reportId"), $(this).attr("IsOwner"));
        $(".uOpen").prop("disabled", false);
        var rptId = $(this).attr("reportId");
        $(".uOpen").attr("selectedid", rptId);

        var isOwner = $(this).attr("IsOwner");
        if (isOwner == 'True') {
            $(".uEdit").prop("disabled", false);
            $(".uPubPriv").prop("disabled", false);
            $(".uRename").prop("disabled", false);
            $(".uDelete").prop("disabled", false);
        }
        else {
            $(".uEdit").prop("disabled", true);
            $(".uPubPriv").prop("disabled", true);
            $(".uRename").prop("disabled", true);
            $(".uDelete").prop("disabled", true);
        }

        //COPY OPTION AVAILABLE FOR ALL
        $(".uCopy").prop("disabled", false);

        //SET REPORT ID
        $("#<%=txtSelectedReport.ClientID %>").val(rptId);
    });

    //Open report in View Mode
    $(".uOpen").on("click", function () {
        //var gsId = '<%= GSafeID %>';
        var gsId = zGUID;
        var rptId = $(".uOpen").attr("selectedid");
        if (gsId != '' && rptId > 0) {
            var url = defaultUrl + dashboardPage;
            //var params = "?gsid=<%= GSafeID %>&m=v&rptId=" + rptId;
            var params = "?gsid=" + zGUID + "&m=v&rptId=" + rptId;
            window.open(url + params, "_blank");
        }
        else {
            alert(defaultErrorMessage);
        }
    });

    //Open report in Edit Mode
    $(".uEdit").on("click", function () {
        //var gsId = '<%= GSafeID %>';
        var gsId = zGUID;
        var rptId = $(".uOpen").attr("selectedid");
        if (gsId != '' && rptId > 0) {
            var url = defaultUrl + dashboardPage;
            //var params = "?gsid=<%= GSafeID %>&m=e&rptId=" + rptId;
            var params = "?gsid=" + zGUID + "&m=e&rptId=" + rptId;
            window.open(url + params, "_blank");
        }
        else {
            alert(defaultErrorMessage);
        }
    });

    //Open report in Edit Mode with Save As option
    $(".uCopy").on("click", function () {
        //var gsId = '<%= GSafeID %>';
        var gsId = zGUID;
        var rptId = $(".uOpen").attr("selectedid");
        if (gsId != '' && rptId > 0) {
            var url = defaultUrl + dashboardPage;
            //var params = "?gsid=<%= GSafeID %>&m=c&rptId=" + rptId;
            var params = "?gsid=" + zGUID + "&m=c&rptId=" + rptId;
            window.open(url + params, "_blank");
        }
        else {
            alert(defaultErrorMessage);
        }
    });

    //Create New Report
    $(".uCreate").on("click", function () {
        //var gsId = '<%= GSafeID %>';
        var gsId = zGUID;
        if (gsId != '') {
            //var cn = '<%= URLCreateNew %>';
            var cn = URLCreateNew;
            if (cn != '#') {
                //var url = defaultUrl + '<%= URLCreateNew %>';
                var url = defaultUrl + URLCreateNew;
                window.open(url, "_blank");
            }
            else {
                alert("You do not have access to Create Report!");
            }
        }
        else {
            alert(gsafeIdErrorMessage);
        }
    });

    $("#btnOpenReport").on("click", function () {
        //var gsId = '<%= GSafeID %>';
        var gsId = zGUID;
        var rptId = $(".uOpenGRC").attr("selectedid");
        if (gsId != '' && rptId > 0) {
            var url = defaultUrl + dashboardPage;
            //var params = "?gsid=<%= GSafeID %>&rptId=" + rptId;
            var params = "?gsid=" + zGUID + "&rptId=" + rptId;
            window.open(url + params, "_blank");
        }
        else {
            alert(defaultErrorMessage);
        }
    });
});

fnRename = function () {
    var nReportName = $("#<%= txtNewReportName.ClientID%>").val().trim();
    if (nReportName.length > 0) {
        $("#sRequired").hide();
        return true;
    }
    else {
        $("#sRequired").show();
        return false;
    }
}