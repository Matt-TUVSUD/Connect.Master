var gSafeGuid = getGSafeGUID();

$(document).ready(function () {
    var viewFooter = {
        termsLink: ko.observable(SITEBASEURL + "Home_{{VER}}/Files-PDFS/Terms_of_use.pdf"),

        bindForm: function () {
            ko.applyBindings(viewFooter, $("#viewFooter")[0]);
        }
    }

    viewFooter.bindForm();
});