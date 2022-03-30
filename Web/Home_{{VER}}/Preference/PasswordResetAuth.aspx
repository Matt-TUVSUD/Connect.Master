<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectAuthServer.Master" CodeBehind="PasswordResetAuth.aspx.vb" Inherits="GRC.Connect.Web.PasswordResetAuth" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../../Lib_{{VER}}/Generated/EzyUsers.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/EzyUsers.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="loginImgHldr">
        <img class="loginImg" src="../Images/loginSplash.png" />
    </div>
    <%--<div id="imageHldr">
        <video class="video-background" autoplay="autoplay" muted="muted" loop="loop" src="../../Home_{{VER}}/Images/Home_{{VER}}/LoginVideo.mp4"></video>
    </div>--%>
    <div id="loginHldr">
        <div class="maintenanceMsgHldr" style="">
            <asp:Label runat="server" ID="lblMessageMaintenance" CssClass="loginMessageError"></asp:Label>
        </div>
        <%--<div id="logoHldr">
            <img src="../../Home_{{VER}}/Images/logos/StackedLogo_Vertical_Clear.png" />
        </div>
        <div id="tagLine">
            <p>Stay Connected to Your<br />
                Loss Control Information.</p>
        </div>--%>
        <h1 style="text-align:center;">Reset Your Password</h1>

        <div id="divEnterEmailAddress" runat="server" style="text-align:center;" class="">
            <div style="display:flex; justify-content:flex-start; align-items:flex-start; flex-direction:column;">
                <span style="font-size:12px; font-weight:700;">
                    <label data-bind="text: $parent.objLanguageLabels().lblEmailAddress">Email Address</label>: </span>
                <span class="" >
                    <asp:TextBox ID="txtEmail" runat="server" ClientIDMode="Static" CssClass="textInput"></asp:TextBox>
                </span>
                <span style="margin-top:17px;">
                    <asp:Button runat="server" ID="btnEnterEmail" Text="Enter" CssClass="loginBtn" />
                </span>
            </div>
            <div>
                <span style="width: 100%; line-height: 18px; padding-top: 4px; float: left; text-align: center; color: #000000; font-family: Arial, sans-serif;">
                    <label data-bind="text: $parent.objLanguageLabels().lblEnterYourEmailAddress">Please enter your Email Address</label></span>
            </div>
            <div style="clear: both;">
                <span class="messageError">
                    <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label></span>
            </div>
        </div>
    </div>

    <div style="text-align: center;" id="view" data-bind="with: view">
    </div>    

    <script type="text/javascript">
        $(document).ready(function () {
            // LANGUAGE LABELS
            var dsLanguageLabels = {
                lblEmailAddress: "Email Address",
                lblEnterYourEmailAddress: "Please enter your email address.",
                lblYouWillReceiveEmail: "You will receive an email containing a link for you",
                lblToResetPassword: "to reset your password.  Thank you!"
            };


            // VIEWMODEL
            var view = {
                // DECLARATIONS
                objLanguageLabels: ko.observable(dsLanguageLabels),

                // LOAD DEFAULTS FROM THE GSAFE
                loadDefaults: function () {
                }
            };


            // SETUP BASE URL FOR DATA SERVICE AND LOAD ALL DATA
            view.loadDefaults();


            // ACTIVATE BINDINGS LAST
            ko.applyBindings(view, $("#view")[0]);


            // KEYBOARD LISTENERS TO PREVENT ENTERING OF INVALID CHARS
            $("#txtEmail").keydown(function (e) {
                // DO NOT ALLOW PIPES "|" OR CARROTS "<" ">"
                if ((e.shiftKey && e.keyCode == 220) || (e.shiftKey && e.keyCode == 188)) {
                    e.preventDefault();
                }
            });//|| (e.shiftKey && e.keyCode == 190) was swallowing french keyboard "." key press
        });
    </script>



</asp:Content>
