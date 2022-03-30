<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/ClientConnectAuthServer.Master" CodeBehind="PasswordResetRequest.aspx.vb" Inherits="GRC.Connect.Web.PasswordResetRequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="../../Lib_{{VER}}/Generated/EzyUsers.js" type="text/javascript"></script>
    <script src="../../Lib_{{VER}}/Custom/EzyUsers.js" type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="view">
        <%--<div id="imageHldr">
            <video class="video-background" autoplay="autoplay" muted="muted" loop="loop" src="../../Home_{{VER}}/Images/Home_{{VER}}/LoginVideo.mp4"></video>
        </div>--%>
        <div class="loginImgHldr">
            <img class="loginImg" src="../Images/loginSplash.png" />
        </div>
        <div id="loginHldr">
            <div class="maintenanceMsgHldr" style="">
                <asp:Label runat="server" ID="lblMessageMaintenance" CssClass="loginMessageError"></asp:Label>
            </div>
            <%--<div id="logoHldr">
                <img src="../../Home_{{VER}}/Images/logos/StackedLogo_Vertical_Clear.png" />
            </div>
            <div id="tagLine">
                <p>
                    Stay Connected to Your<br />
                    Loss Control Information.
                </p>
            </div>--%>
            <div id="divEnterEmailAddress" runat="server" class="userHldr ui-helper-clearfix">
                <div>
                    <span class="emailLbl">
                        <label>Email</label>:</span>
                    <div style="margin-bottom:17px;">
                        <asp:TextBox ID="txtEmail" runat="server" ClientIDMode="Static" CssClass="textInput"></asp:TextBox>
                    </div>
                    <asp:Button runat="server" ID="btnEnterEmail" Text="Enter" CssClass="loginBtn" />
                </div>
                <div>
                    <span style="width: 100%; font-family: Arial, sans-serif; line-height: 18px; padding-top: 4px; float: left; text-align: center; color: #000000;">
                        <label>Please enter your Email Address</label>
                    </span>
                </div>
            </div>
            <%--PASSWORD TABLE--%>
            <div id="divEmailSent" runat="server" class="divTable">
                <div style="margin-top: 20px; text-align: center;">
                    <label style="font-family: Arial, sans-serif; font-size: 18px; font-weight: 700;" data-bind="text: $parent.objLanguageLabels().lblYouWillReceiveEmail">You will receive an email containing a link for you</label>
                    <br />
                    <label style="font-family: Arial, sans-serif; font-size: 18px; font-weight: 700;" data-bind="text: $parent.objLanguageLabels().lblToResetPassword">to reset your password.  Thank you!</label>
                </div>
            </div>

            <%-- MESSAGE AREA --%>
            <div id="divMessage" runat="server" class="divTable">
                <div style="text-align: center; margin-top: 20px;">
                    <span class="messageError">
                        <asp:Label ID="lblMessage" runat="server" Text=""></asp:Label>
                    </span>
                </div>
            </div>
        </div>
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
                if ((e.shiftKey && e.keyCode == 220) || (e.shiftKey && e.keyCode == 190) || (e.shiftKey && e.keyCode == 188)) {
                    e.preventDefault();
                }
            });
        });
    </script>



</asp:Content>
