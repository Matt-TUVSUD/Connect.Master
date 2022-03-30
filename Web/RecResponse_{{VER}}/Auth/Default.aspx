<%@ Page Title="" Language="vb" AutoEventWireup="false" MasterPageFile="~/RecResponse_{{VER}}/ClientConnectRecResponseLogin.Master" CodeBehind="Default.aspx.vb" Inherits="GRC.Connect.Web._RecResponse_Auth" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div id="view" data-bind="with: view" style="display:flex; flex-direction:column;">
    <%--<div id="imageHldr">
        <video class="video-background" autoplay="autoplay" muted="muted" loop="loop" src="../../Home_{{VER}}/Images/Home_{{VER}}/LoginVideo.mp4"></video>
    </div>--%>
    <div class="loginImgHldr">
        <img class="loginImg" src="../../Home_{{VER}}/Images/loginSplash.png" />
    </div>
    <div id="loginHldr">
        <div class="maintenanceMsgHldr" style="">
            <asp:Label runat="server" ID="lblMessageMaintenance" CssClass="messageError" Font-Size="10pt"></asp:Label>
        </div>
        <%--<div id="logoHldr">
            <img src="../../Home_{{VER}}/Images/logos/StackedLogo_Vertical_Clear.png" />
        </div>
        <div id="tagLine">
            <label data-bind="text: $parent.objLanguageLabels().lblRecResponse_Login_Title">Auto-Recommendation Response Login Page</label>
        </div>--%>
        <div class="messageErrorNoBold" style="font-size: 12px; font-family: Arial, sans-serif; color: #000; width:100%; margin-bottom:15px;">
            <label data-bind="text: $parent.objLanguageLabels().lblRecResponse_Login_Inst1">Please confirm that your Name and Email address are correct below. If you are not the person who originally received the email request with the link to this page, please overwrite with your Full Name and Email Address.</label>
        </div>
        <div class="userHldr" style="width:100%;">
            <label class="emailLbl" style="width:177px; margin-right:0px; display:flex;" data-bind="text: $parent.objLanguageLabels().lblRecResponse_Login_EnterYourName">Enter Your Full Name:</label>
            <asp:TextBox ID="txtFullName" style="background:#fff;" CssClass="k-autocomplete k-input k-input-padding" runat="server" Width="275px" Height="24px"></asp:TextBox>
        </div>
        <div class="userHldr" style="width:100%;">
            <label class="emailLbl" style="width:200px; margin-right:0px; display:flex;" data-bind="text: $parent.objLanguageLabels().lblRecResponse_Login_EnterYourEmail">Enter Your Email Address:</label>
            <asp:TextBox ID="txtEmailAddress" style="background:#fff;" CssClass="k-autocomplete k-input k-input-padding" runat="server" Width="275px" Height="24px"></asp:TextBox>
        </div>
        <div class="messageErrorNoBold" style="font-size: 12px; font-family: Arial, sans-serif; color: #000; width:100%; margin-bottom:15px;">
            <label data-bind="text: $parent.objLanguageLabels().lblRecResponse_Login_Inst2">By entering this site, you understand and agree that you will not share your access or any information unless authorized by your management, as this site contains confidential client information.</label>
        </div>
        <div style="text-align: center;">
            <asp:Button runat="server" ID="btnAuthenticate" CssClass="loginBtn" Text="Enter" />
        </div>
        <br />
        <div id="divError_InvalidLink" runat="server" class="messageError"><label data-bind="text: $parent.objLanguageLabels().lblRecResponseError_InvalidLink">You have not used a verified Recommendation Response email link to land on this page. Please use the Recommendation Reponse email that was sent to you.</label></div>
        <div id="divError_InactiveLink" runat="server" class="messageError"><label data-bind="text: $parent.objLanguageLabels().lblRecResponseError_InactiveLink">The Recommendation Response Link you have used to reach this page is no longer active.</label></div>
        <div id="divError_InvalidNameEmail" runat="server" class="messageError"><label data-bind="text: $parent.objLanguageLabels().lblRecResponseError_InvalidNameEmail">Please enter a valid name or email address.</label></div>
    </div>
</div>

<script type="text/javascript">
    $(document).ready(function () {
        var dsLanguageLabels = {
            lblRecResponse_Login_WelcomeTo: "Welcome to",
            lblRecResponse_Login_Title: "Auto-Recommendation Response Login Page",
            lblRecResponse_Login_Inst1: "Please confirm that your Name and Email address are correct below. If you are not the person who originally received the email request with the link to this page, please overwrite with your Full Name and Email Address.",
            lblRecResponse_Login_EnterYourName: "Enter Your Full Name",
            lblRecResponse_Login_EnterYourEmail: "Enter Your Email Address",
            lblRecResponse_Login_Inst2: "By entering this site, you understand and agree that you will not share your access or any information unless authorized by your management, as this site contains confidential client information.",
            lblRecResponseError_InvalidLink: "You have not used a verified Recommendation Response email link to land on this page. Please use the Recommendation Reponse email that was sent to you.",
            lblRecResponseError_InactiveLink: "The Recommendation Response Link you have used to reach this page is no longer active.",
            lblRecResponseError_InvalidNameEmail: "Please enter a valid name or email address."
        };
        
        var dsLanguageOptions = [
            dsLanguageLabels.lblChooseLanguage,
            "Deutsch",
            "English",
            "Español",
            "Français",
            "Italiano",
            "Português"
        ];
        var view = {
            preferenceLanguage: "english", //"<%= ServerSide_LanguagePreference %>", // USE DEFAULT ENGLISH UNTIL NEEDED
            objLanguageLabels: ko.observable(dsLanguageLabels),

            loadLabelTranslations: function (pLanguage) {
                dsLanguageLabels = {};
                var tempLanguage = pLanguage.toLowerCase();
                tempLabelColl = new es.objects.ViewCCTranslationCollection();
                es.dataProvider.baseURL = SITEBASEURL + VIEWSERVERENDPOINT;
                if (!tempLabelColl.GetTranslationByPage("1|" + tempLanguage)) {
                    switch (tempLanguage) {
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
                            for (x = 0; x < tempLabelColl().length; x++) {
                                dsLanguageLabels[tempLabelColl()[x].LabelName()] = tempLabelColl()[x].EnglishTranslation();
                            }
                            break;
                    }
                }
                view.objLanguageLabels(dsLanguageLabels);
                dsLanguageOptions[0] = dsLanguageLabels.lblChooseLanguage;
            }
        };

        //// LOAD THE LANGUAGE LABELS
        //view.loadLabelTranslations(view.preferenceLanguage); // TURN THIS FUNCTION CALL ON TO TURN ON MULTI-LANGUAGE.
        ko.applyBindings(view, $("#view")[0]);
    });
</script>

</asp:Content>
