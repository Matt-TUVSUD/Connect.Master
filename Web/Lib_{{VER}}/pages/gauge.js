///////////////////////////////////////////////////////////
//////// JAVASCRIPT FOR THE LARGE FADING QUOTES - ALL LANGUAGES - SERVICES PAGE
//////// AND FOR THE GUAGE MOUSE OVER BANNER - ALL LANGUAGES - SERVICES PAGE

var firstClick = true;
var currentBanner = 0;
var killSwitch = false;

// GUAGE IMAGE MAP  
function showBanner(x) {
    $('#dialMain').hide();
    $('#dial' + x).show();
}

function resetDial() {
    $('#dialMain').show();
    $('#dial1').hide();
    $('#dial2').hide();
    $('#dial3').hide();
    $('#dial4').hide();
    $('#dial5').hide();
}

function resetBanner(x) {
    $('#dialMain').show();
    $('#dial' + x).hide();
}

function clickBanner(x) {
    //// RESERVED FOR CLICK ACTIONS
}

function hoverResetBanner(x) {
    //// UNCOMMENT THE BELOW TO HIDE THE DIAL NEEDLE ON MOUSEOUT
    //$('#dial' + x).hide();
    //$('#dialMain').show();
}

function hoverBanner(x) {
    //// STOP THE AUTO SHOW
    killSwitch = true;

    //// SET THE DIAL FIRST
    resetDial();
    resetBanner(x);
    showBanner(x);

    //// ONLY SHOW IF WE ARE ON A NEW PRACTICE
    if (x != currentBanner) {
        //// SET BANNERS AND INFO BACK TO NORMAL FIRST
        currentBanner = x;
        $('#bannerMain').show();
        $('#banner1').hide();
        $('#banner2').hide();
        $('#banner3').hide();
        $('#banner4').hide();
        $('#banner5').hide();
        $('#dialMain').hide();
        $('#gaugeStats1').slideUp();
        $('#gaugeStats2').slideUp();
        $('#gaugeStats3').slideUp();
        $('#gaugeStats4').slideUp();
        $('#gaugeStats5').slideUp();

        //// SHOW THE NEW BANNER AND STATS
        $('#dial' + x).show();
        $('#bannerMain').hide();
        if (!firstClick) {
            $('#banner' + x).delay(500).show();
            $('#gaugeStats' + x).delay(500).slideDown();
            firstClick = false;
        } else {
            $('#banner' + x).show();
            $('#gaugeStats' + x).slideDown();
            firstClick = false;
        }
    }
}

function autoBanner(x) {
    //// SET BANNERS AND INFO BACK TO NORMAL FIRST
    currentBanner = x;
    $('#bannerMain').hide();
    $('#dialMain').hide();

    //// SHOW THE NEW BANNER AND STATS
    $('#banner' + x).fadeIn();
    $('#dial' + x).fadeIn();
    $('#gaugeStats' + x).slideDown();
}

function autoReset(x) {
    $('#banner' + x).fadeOut("fast", function () {
        $('#bannerMain').show();
    });
    $('#dial' + x).fadeOut("fast", function () {
        $('#dialMain').show();
    });
    $('#gaugeStats1').slideUp();
    $('#gaugeStats2').slideUp();
    $('#gaugeStats3').slideUp();
    $('#gaugeStats4').slideUp();
    $('#gaugeStats5').slideUp();
}


//// BUILD THE LINK FOR THE QUICK INFO LINKS
function buildStatLink(area, filter) {
    var GSafeGUID = getGSafeGUID();
    var tempUrl = "GaugeDirect.aspx?sid=" + GSafeGUID + "&p1=" + area + "&p2=" + filter;
    window.open(tempUrl);
}


//// REFRESH THE PAGE ON UNLOAD TO PREVENT BACK BUTTON ISSUES
//$(window).unload(function () {
//    $("#gaugeContainer").html();
//});

//// INTERVAL TO AUTO LOOP THROUGH PRACTICES ON GAUGE
$(document).ready(function () {
    //// ID OF INTERVAL
    //// START AT NUMBER HIGHER THAN ZERO TO REDUCE THE TIME FROM PAGE LOAD TO FIRST BANNER SHOWING
    var i = 5;

    //// LOOP THROUGH INTERVAL
    var gaugeLoop = self.setInterval(function () {
        if (!killSwitch) {
            switch (i) {
                case 5:
                    autoBanner(1); break;
                case 11:
                    autoReset(1); break;
                case 13:
                    autoBanner(2); break;
                case 18:
                    autoReset(2); break;
                case 20:
                    autoBanner(3); break;
                case 25:
                    autoReset(3); break;
                case 27:
                    autoBanner(4); break;
                case 32:
                    autoReset(4); break;
                case 34:
                    autoBanner(5); break;
                case 39:
                    autoReset(5); break;
                case 41:
                    autoBanner(1); break;
                case 46:
                    autoReset(1); break;
                case 47:
                    i = 12; break;
                default:
                    //// DO NOTHING
            }
            i++;
        } else {
            clearInterval(gaugeLoop);
        }
    }, 800);
    //// NOTE: 800ms = 4 SECONDS TO DISPLAY EACH SERVICE WITH 0.8 SECONDS PAUSE BETWEEN EACH
    //// NOTE: 1000ms = 5 SECONDS TO DISPLAY EACH SERVICE WITH 1.0 SECOND PAUSE BETWEEN EACH
});