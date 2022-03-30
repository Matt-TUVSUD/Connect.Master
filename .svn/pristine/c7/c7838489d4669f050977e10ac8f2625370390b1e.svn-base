/*
<!-- BEGIN CACHE CONTROL -->
    <meta http-equiv="CACHE-CONTROL" content="NO-STORE" />
    <meta http-equiv="PRAGMA" content="NO-CACHE" />
    <meta name="EXPIRES" content="0" />
    <meta name="VERSION" content="{{VER}}" />
<!-- END CACHE CONTROL -->
*/

var SVNVERSION = 0;
/*** IMPORTANT NOTE: DO NOT CHANGE THE BELOW COMMENT, USED SITE BUILD SCRIPTS. ***/
// REPLACE SVNVERSION
/*** END IMPORTANT NOTE ***/

$("document").ready(function () {

//    var thisVersion = SVNVERSION.toString();

//    var metaCheck1 = $("meta[http-equiv=CACHE-CONTROL]").attr("content");
//    var metaCheck2 = $("meta[http-equiv=PRAGMA]").attr("content");
//    var metaCheck3 = $("meta[name=EXPIRES]").attr("content");
//    var metaCheck4 = $("meta[name=VERSION]").attr("content");

//    if (metaCheck4 == "{{VER}}") {
//        // do nothing
//        //alert(metaCheck4);
//    } else {
//        // make this toupper always
//        if ((metaCheck1 !== "NO-STORE") || (metaCheck2 !== "NO-CACHE") || (metaCheck3 !== "0") || (metaCheck4 !== thisVersion)) {

//            // Look for cookie / get value
//            var cacheControllerValue = $.cookie("cacheController");

//            // see if cookie exists
//            if (!cacheControllerValue) {
//                // set cookie on first run
//                $.cookie("cacheController", 0);
//                cacheControllerValue = $.cookie("cacheController");
//                //alert(cacheControllerValue);
//                refreshURL();
//            } else if (cacheControllerValue <= 4) {
//                // get value inside cookie & if cookie is not set to 5 refresh else +1
//                cacheControllerValue = parseInt(cacheControllerValue);
//                cacheControllerValue = cacheControllerValue + 1;
//                $.cookie("cacheController", cacheControllerValue);
//                //alert(cacheControllerValue);
//                refreshURL();
//            } else {
//                promtClose(metaCheck4);
//            }

//        }
//    }

});

function refreshURL() {
    //window.location.href = document.URL;
    window.location.reload(true);
}

function promtClose(metaCheck4) {
    var x;
    if (confirm("Error: You are accessing an outdated version of this form. (Version: " + metaCheck4 + ")\n\nPlease close this page by clicking okay and then re-open your internet browser, clear your cache, then please try to access this form again.") == true) {
        window.close();
    } else {
        window.close();
    }
}