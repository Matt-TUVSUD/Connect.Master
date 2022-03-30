//// GLOBAL VAR FOR COMMENTS TEXTAREA
var txtFeedbackComments = "#txtFeedbackCommentsText";
var btnCommentsSubmit = "#btnCommentsSubmit";
var lblCommentsPleaseWait = "#lblCommentsPleaseWait";
var lblCommentsErrorMessage = "#lblCommentsErrorMessage";

///////////////////////////////////////////
//// EVENTS
//// JQUERY TO HIDE WATERMARK ON FOCUS OF TEXTBOX
$(document).ready(function () {
    //// POPULATE THE USER NAME FIELD
    var userFullName = getUserFullName(getGSafeGUID());
    $("#lblCommentsUserFullName").text(userFullName);

    //// MOUSE CLICK OR TAB INTO TEXT AREA (FOCUS)
    $(txtFeedbackComments).focus(function () {
        if ($(txtFeedbackComments).val() == "Enter Comments Here") {
            $(txtFeedbackComments).val("");
            $(btnCommentsSubmit).attr("disabled", "disabled");
            $(btnCommentsSubmit).addClass("grcBlueDisabledBtn");
            $(txtFeedbackComments).val("");
        } else {
            $(btnCommentsSubmit).removeAttr("disabled");
            $(btnCommentsSubmit).removeClass("grcBlueDisabledBtn");
        }
        $(txtFeedbackComments).removeClass("watermark_TextArea");
    });

    //// MOUSE CLICK OFF OF OR TAB OUT OF TEXT AREA (LOST FOCUS)
    $(txtFeedbackComments).blur(function () {
        if ($(txtFeedbackComments).val() == "") {
            $(txtFeedbackComments).val("Enter Comments Here");
            $(txtFeedbackComments).addClass("watermark_TextArea");
            $(btnCommentsSubmit).attr("disabled", "disabled");
            $(btnCommentsSubmit).addClass("grcBlueDisabledBtn");
        } else if ($(txtFeedbackComments).val() == "Enter Comments Here") {
            $(btnCommentsSubmit).attr("disabled", "disabled");
            $(btnCommentsSubmit).addClass("grcBlueDisabledBtn");
        } else {
            $(btnCommentsSubmit).removeAttr("disabled");
            $(btnCommentsSubmit).removeClass("grcBlueDisabledBtn");
        }
    });

    //// KEYBOARD EVENT TO ACTIVATE SUBMIT BUTTON
    $(txtFeedbackComments).keypress(function () {
        if ($(txtFeedbackComments).val() == "" || $(txtFeedbackComments).val() == "Enter Comments Here") {
            $(btnCommentsSubmit).attr("disabled", "disabled");
            $(btnCommentsSubmit).addClass("grcBlueDisabledBtn");
        } else {
            $(btnCommentsSubmit).removeAttr("disabled");
            $(btnCommentsSubmit).removeClass("grcBlueDisabledBtn");
        }
    });


    //// SET SUBMIT BUTTON TO DISABLE TO START
    $(btnCommentsSubmit).attr("disabled", "disabled");
    $(btnCommentsSubmit).addClass("grcBlueDisabledBtn");




///////////////////////////////////////////
//// SETUP KENDOUI
//// COMMENTS WINDOW
var windowComments = $("#windowComments");
windowComments.kendoWindow({
    width: "750px",
    height: "300px",
    title: "", // title added below with JQuery
    modal: true,
    actions: ["Close"]
});
$("#windowComments").closest(".k-window").css({
    top: 200,
    left: 200
});
$("#windowComments").prev().find(".k-window-title").append("<img src='../images/icons/reports/document_information_32x32.png' align='left' alt='Warning Icon' class='windowIcon'/>  Provide Feedback");

});

///////////////////////////////////////////
//// FUNCTIONS
function onCommentsOpen() {
    //// OPEN THE COMMENTS WINDOW
    windowComments.data("kendoWindow").open();
    $("#windowComments").css("display", "block");
}

function clearCommentBox(e) {
    $('#txtFeedbackCommentsText').val("");
}

function onCommentsHide() {
    //// HIDE ALL WINDOWS RELATED TO COMMENTS

    $(lblCommentsPleaseWait).hide();
    //windowComments.data("kendoWindow").close();
    windowCommentsSuccess.data("kendoWindow").close();
    //windowCommentsFail.data("kendoWindow").close();
}

function onCommentsSubmit() {
    //// SUBMIT COMMENT AND CALL SERVER SIDE EMAIL HANDLER
    $(btnCommentsSubmit).attr("disabled", "disabled");
    $(btnCommentsSubmit).addClass("grcBlueDisabledBtn");
    $(txtFeedbackComments).attr("disabled", "disabled");
    $(lblCommentsPleaseWait).show();
    createEmail();
}

function createEmail() {
    //// PARAMETERS
    var GUID = getGSafeGUID();
    var tempURL = document.URL;
    var comments = $(txtFeedbackComments).val();

    //// CALL THE SERVER SIDE EMAIL HANDLER, IF RESPONSE IS SUCCESS THEN OPEN SUCCESS WINDOW, ELSE OPEN FAIL WINDOW
    $.get(
        "../Email/EmailIt.ashx",
        {
            GSafeGUID: GUID,
            PageURL: tempURL,
            Comments: comments
        },
        function (data, status) {
            $(txtFeedbackComments).val("Enter Comments Here");
            $(txtFeedbackComments).addClass("watermark_TextArea");
            $(txtFeedbackComments).removeAttr("disabled");
            $(lblCommentsPleaseWait).hide();
            if (data == "success") {
                windowCommentsSuccess.data("kendoWindow").center().open();
                $("#windowCommentsSuccess").css("display", "block");
            } else {
                $(lblCommentsErrorMessage).html(data);
                windowCommentsFail.data("kendoWindow").open();
                $("#windowCommentsFail").css("display", "block");
            }
        },
        "text"
    );
}
