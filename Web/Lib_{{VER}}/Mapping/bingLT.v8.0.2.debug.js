/** 
VERSION: v8.0.2
DATE: 2017.04.18
NOTE: PLEASE UPTATE THE VERSION VARIABLES IN THE CLASS BELOW

FOR INFORMATION ABOUT THE CONVERSION FROM v7 TO v8 SEE THE BELOW LINK:
https://social.technet.microsoft.com/wiki/contents/articles/34563.bing-maps-v7-to-v8-migration-guide.aspx#Deprecated_Modules

BING AJAX MAP HELPER = utilBingMap
A Helper class to assist with Bing Maps AJAX 7 library.  
 
*** REQUIREMENTS: ***
JQuery 1.11 or above
Bing Maps AJAX javascript library 7 
FUTURE OPTION = Heatmap Library
FUTURE OPTION = Other Map Libraries
OLDER BROWSERS REQUIRE json2.js

*** INSTRUCTIONS: ***
To use this class there must be five steps in place. To make use of the intellisense, please add this file to your _references.js file.

1)  Build an HTML structure to hold the map and messages.
    Example:
    <div id="mapContainer"></div>
    <div id="mapMessages"></div>

2)  Initialize the object using the initMap() function to a local object in your MVVM.
    Example:
    view.myMap = new bingLT();
    view.myMap.optionsBingLT.ZZZ //SET ANY OPTIONS YOU LIKE HERE BY REPLACING ZZZ AND ASSIGNING A VALUE
    view.myMap.initMap(pMapDOM, pMessageDOM, pApp, pAppGUID, pKey, pLoggingType, pServiceURL);

3)  Create any client side functions or events to tie into 
**/

bingLT = function () {
    this.version = "v8.0.2", this.lastUpdate = "2017.04.18", this._mapDOM = null, this._messageDOM = null, this._DOMUniqueIdentifier = Math.floor(1e5 * Math.random() + 1), this._closedScreenDOM = "divClosedScreen" + this._DOMUniqueIdentifier.toString(), this._closedFormDOM = "divClosedForm" + this._DOMUniqueIdentifier.toString(), this._lockoutScreenDOM = "divLockoutScreen" + this._DOMUniqueIdentifier.toString(), this._lockoutFormDOM = "divLockoutForm" + this._DOMUniqueIdentifier.toString(), this._lockoutButtonDOM = "divLockoutButton" + this._DOMUniqueIdentifier.toString(), this._lockoutMessageDOM = "divLockoutMessage" + this._DOMUniqueIdentifier.toString(), this._mapKey = null, this._appName = null, this._appGUID = null, this._sessionGUID = null, this._timeToExpire = null, this._isLockedOut = !1, this._loggingType = null, this._sessionExpirationTime = null, this._serviceBaseUrl = null, this._eventClickLogging = null, this._eventDoubleClickLogging = null, this._eventRightClickLogging = null, this._eventMouseDownLogging = null, this._eventMouseUpLogging = null, this._eventMouseMoveLogging = null, this._eventMouseOverLogging = null, this._eventMouseOutLogging = null, this._eventMouseWheelLogging = null, this._eventViewChangeStartLogging = null, this._eventViewChangeLogging = null, this._eventViewChangeEndLogging = null, this._eventImageryChangedLogging = null, this._eventCopyrightChangedLogging = null, this._startTimer = null, this.map = null, this.loggingTypes = {
        monitor: 1,
        required: 2,
        off: -1
    }, this.messageTypes = {
        error: 1,
        warning: 2,
        notice: 3,
        fatal: 4,
        none: -1
    }, this.messagePrefix = {
        error: "Map Error Message: ",
        warning: "Map Warning Message: ",
        notice: "Map Notice Message: ",
        fatal: "Map Fatal Message: ",
        none: "Map Message: "
    }, this.optionsBingLT = {
        colorTextError: "#B30000",
        colorTextWarning: "#CD8400",
        colorTextNotice: "#007C00",
        colorTextFatal: "#FFFFFF",
        colorTextLockout: "#FFFFFF",
        colorTextClosed: "#FFFFFF",
        colorScreenClosed: "#000000",
        colorScreenLockout: "#000089",
        colorScreenFatalError: "#B30000",
        defaultTimeToExpireSeconds: 10,
        textLockoutMessage: "Your session is waiting for an available Bing license. Please click the button below to try to restart your session.",
        textClosedMessage: "The session has been idle and has been closed. Please refresh your browser to restart your session.",
        textButtonRenew: "Renew / Request Session",
        isLocal: !1
    }, this.test = {
        autoRenew: !0,
        consoleLogging: !1,
        addDebugger: !1
    }, this._isSessionExpired = function () {
        var a = null;
        try {
            var b = new Date;
            a = this._sessionExpirationTime > b
        } catch (b) {
            var c = this.messageTypes.error;
            this.processMessage(c, b.message), a = null
        }
        return a
    }, this._setExpiredTime = function (a) {
        try {
            this._sessionExpirationTime = new Date, this._sessionExpirationTime.setSeconds(this._sessionExpirationTime.getSeconds() + a)
        } catch (a) {
            var b = this.messageTypes.error;
            this.processMessage(b, a.message)
        }
    }, this._setupMap = function () {
        try {
            this.map = new Microsoft.Maps.Map(document.getElementById(this._mapDOM), {
                credentials: this._mapKey,
                mapTypeId: Microsoft.Maps.MapTypeId.road
            });
            var a = this.map.getOptions();
            a.zoom = 3, a.showScalebar = !0, a.center = new Microsoft.Maps.Location(23.743722, -40.7479275), this.map.setView(a), this.test.consoleLogging && "undefined" != typeof console && (console.log("****************** Setup ****"), console.log("Setup Bing Map Complete"))
        } catch (a) {
            var b = this.messageTypes.error;
            this.processMessage(b, a.message)
        }
    }, this._setupElements = function () {
        try {
            var a = document.createElement("div");
            a.setAttribute("id", this._lockoutScreenDOM), a.setAttribute("style", "display: none; position: absolute; top: 0;left: 0; width: 100%; height: 100%; text-align: center; z-index: 1; opacity: 0.4; background: " + this.optionsBingLT.colorScreenLockout + ";");
            var b = document.createElement("div");
            b.setAttribute("id", this._lockoutFormDOM), b.setAttribute("style", "display: none; position: absolute; top: 0;left: 0; width: 100%; height: 100%; text-align: center; z-index: 1; margin-top: 20%; color: " + this.optionsBingLT.colorTextLockout + ";");
            var c = document.createElement("button"),
                d = document.createTextNode(this.optionsBingLT.textButtonRenew);
            c.setAttribute("id", this._lockoutButtonDOM), c.setAttribute("style", ""), c.appendChild(d);
            var e = document.createElement("p"),
                f = document.createTextNode(this.optionsBingLT.textLockoutMessage);
            e.setAttribute("style", ""), e.appendChild(f), b.appendChild(e), b.appendChild(c);
            var g = document.createElement("p"),
                h = document.createTextNode("");
            g.setAttribute("id", this._lockoutMessageDOM), g.setAttribute("style", ""), g.appendChild(h);
            var i = document.createElement("div");
            i.setAttribute("id", this._closedScreenDOM), i.setAttribute("style", "display: none; position: absolute; top: 0;left: 0; width: 100%; height: 100%; text-align: center; z-index: 1; opacity: 0.4; background: " + this.optionsBingLT.colorScreenClosed + ";");
            var j = document.createElement("div");
            j.setAttribute("id", this._closedFormDOM), j.setAttribute("style", "display: none; position: absolute; top: 0;left: 0; width: 100%; height: 100%; text-align: center; z-index: 1; margin-top: 20%; color: " + this.optionsBingLT.colorTextClosed + ";");
            var k = document.createElement("p"),
                l = document.createTextNode(this.optionsBingLT.textClosedMessage);
            k.setAttribute("style", ""), k.appendChild(l), j.appendChild(k);
            var m = document.getElementById(this._mapDOM);
            m.appendChild(i), m.appendChild(j), m.appendChild(a), m.appendChild(b), this.test.consoleLogging && "undefined" != typeof console && (console.log("****************** Setup ****"), console.log("Setup Elements Complete"))
        } catch (a) {
            var n = this.messageTypes.error;
            this.processMessage(n, a.message)
        }
    }, this._setupEvents = function () {
        try {
            this._setupEventsButtons(), this._setupEventsLogging()
        } catch (b) {
            var a = this.messageTypes.error;
            this.processMessage(a, b.message)
        }
    }, this._setupEventsButtons = function () {
        var a = this;
        try {
            $("#" + this._lockoutButtonDOM).bind("click", function (b) {
                return a.unlockSession(a, b), !1
            }), a.test.consoleLogging && "undefined" != typeof console && (console.log("****************** Setup ****"), console.log("Setup Events Buttons Complete"))
        } catch (a) {
            var b = this.messageTypes.error;
            this.processMessage(b, a.message)
        }
    }, this._setupEventsLogging = function () {
        var a = this;
        try {
            this._eventViewChangeLogging = Microsoft.Maps.Events.addHandler(this.map, "viewchange", function (b) {
                a._handleEventLogging(a, b)
            }), this._eventViewChangeEndLogging = Microsoft.Maps.Events.addHandler(this.map, "viewchangeend", function (b) {
                a._handleEventLogging(a, b)
            }), a.test.consoleLogging && "undefined" != typeof console && (console.log("****************** Setup ****"), console.log("Setup Events Logging Complete"))
        } catch (a) {
            var b = this.messageTypes.error;
            this.processMessage(b, a.message)
        }
    }, this._handleEventLogging = function (a, b) {
        try {
            a._isSessionExpired() || (1 == a.test.autoRenew ? a.renewSession() : a.processLockout(!0)), a.test.consoleLogging && "undefined" != typeof console && (console.log("****************** Event Handler ****"), console.log("Event: " + b.eventName), console.log("Session expired: " + a._isSessionExpired()), console.log("Auto Renew: " + a.test.autoRenew.toString()), console.log("Now Time: " + (new Date).getSeconds()), console.log("Exp Time: " + a._sessionExpirationTime.getSeconds()), console.log("Session GUID: " + a._sessionGUID), console.log("App GUID: " + a._appGUID))
        } catch (b) {
            var c = a.messageTypes.error;
            a.processMessage(c, b.message)
        }
    }, this._callLoggingService = function (a, b, c, d, e) {
        var f = this,
            g = this._serviceBaseUrl;
        try {
            $.ajax({
                type: "POST",
                url: g + a,
                data: JSON.stringify(b),
                timeout: 6e4,
                cache: !1,
                processData: !0,
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                success: function (a) {
                    void 0 != c && c(a, e, f)
                },
                error: function (a, b, c) {
                    void 0 != d ? d(a, b, c, e, f) : alert("Error: " + b)
                }
            })
        } catch (a) {
            var h = this.messageTypes.error;
            this.processMessage(h, a.message)
        }
    }, this._callLoggingServiceLocal = function (a, b, c, d, e) {
        this._serviceBaseUrl;
        try {
            var h = ko.toJSON({
                pJetProc: a,
                pJetData: JSON.stringify({
                    DoCmd: a,
                    Data: b,
                    Parms: e,
                    SuccessFunctionName: c,
                    ErrorFunctionName: d
                })
            }),
                j = document.getElementById("frameMapLocalSync").contentWindow;
            setTimeout(function () {
                pStringParms = JSON.stringify(h), j.postMessage(pStringParms, "http://app." + SITEDOMAIN + "/")
            }, 1)
        } catch (a) {
            var k = this.messageTypes.error;
            this.processMessage(k, a.message)
        }
    }, this.callLocalReturnSuccess = function (a, b, c) {
        var d = this;
        this[a](b, c, d)
    }, this.callLocalReturnError = function (a, b, c, d, e) {
        var f = this;
        this[a](b, c, d, e, f)
    }, this.initMap = function (a, b, c, d, e, f, g) {
        try {
            this._mapDOM = a, this._messageDOM = b, this._appName = c, this._mapKey = e, this._appGUID = d, this._loggingType = f, this._serviceBaseUrl = g, this._sessionExpirationTime = new Date, this._setExpiredTime(this.optionsBingLT.defaultTimeToExpireSeconds), this._setupElements(), this._setupMap(), this._setupEvents(), this.initSession(), this.test.consoleLogging && "undefined" != typeof console && (console.log("****************** Setup ****"), console.log("Init Complete"))
        } catch (a) {
            var h = this.messageTypes.error;
            this.processMessage(h, a.message)
        }
    }, this.setupOptions = function () {
        try {
            this.test.consoleLogging && "undefined" != typeof console && (console.log("****************** Setup ****"), console.log("Setup Options Complete"))
        } catch (b) {
            var a = this.messageTypes.error;
            this.processMessage(a, b.message)
        }
    }, this.rebuildMap = function () {
        try {
            this.clearMessage(), this.test.consoleLogging && "undefined" != typeof console && (console.log("****************** Rebuild ****"), console.log("Rebuild Map Complete"))
        } catch (b) {
            var a = this.messageTypes.error;
            this.processMessage(a, b.message)
        }
    }, this.initSession = function () {
        try {
            this.clearMessage();
            var a = {
                pBingKey: this._mapKey,
                pAppGUID: this._appGUID
            };
//            this.optionsBingLT.isLocal ? this._callLoggingServiceLocal("InitSession", a, "_initSessionSuccess", "_initSessionError", null) : this._callLoggingService("InitSession", a, this._initSessionSuccess, this._initSessionError, null)
        } catch (a) {
            var b = this.messageTypes.error;
            this.processMessage(b, a.message)
        }
    }, this._initSessionSuccess = function (a, b, c) {
        try {
            if (a.IsSuccess) c._setExpiredTime(a.Data.FldUsageTimeoutSec), c._sessionGUID = a.Data.FldSessionGUID, c.processLockout(!1);
            else {
                c.processLockout(!0);
                var d = c.messageTypes.error;
                c.processMessage(d, a.ErrorMessage)
            }
        } catch (a) {
            var d = c.messageTypes.error;
            c.processMessage(d, a.message)
        }
    }, this._initSessionError = function (a, b, c, d, e) {
        try {
            var f = e.messageTypes.fatal;
            e.processMessage(f, "An error occurred while initializing a map licence session: " + b + " " + c)
        } catch (a) {
            var f = e.messageTypes.fatal;
            e.processMessage(f, "An unknown error occurred while initializing a map licence session. Reference 365")
        }
    }, this.requestSession = function () {
        try {
            this.clearMessage();
            var a = {
                pSessionGUID: null,
                pAppGUID: this._appGUID
            };
            this.optionsBingLT.isLocal ? this._callLoggingServiceLocal("RequestSession", a, "_requestSessionSuccess", "_requestSessionError", null) : this._callLoggingService("RequestSession", a, this._requestSessionSuccess, this._requestSessionError, null)
        } catch (a) {
            var b = this.messageTypes.error;
            this.processMessage(b, a.message)
        }
    }, this._requestSessionSuccess = function (a, b, c) {
        try {
            if (a.IsSuccess) c._setExpiredTime(a.Data.FldUsageTimeoutSec), c._sessionGUID = a.Data.FldSessionGUID, c.processLockout(!1);
            else {
                c.processLockout(!0);
                var d = c.messageTypes.error;
                c.processMessage(d, a.ErrorMessage)
            }
        } catch (a) {
            var d = c.messageTypes.error;
            c.processMessage(d, a.message)
        }
    }, this._requestSessionError = function (a, b, c, d, e) {
        try {
            var f = e.messageTypes.fatal;
            e.processMessage(f, "An error occurred while requesting a map licence session: " + b + " " + c)
        } catch (a) {
            var f = e.messageTypes.fatal;
            e.processMessage(f, "An unknown error occurred while requesting a map licence session. Reference 366")
        }
    }, this.renewSession = function () {
        try {
            this.clearMessage();
            var a = {
                pSessionGUID: this._sessionGUID,
                pAppGUID: this._appGUID
            };
//            this.optionsBingLT.isLocal ? this._callLoggingServiceLocal("RenewSession", a, "_renewSessionSuccess", "_renewSessionError", null) : this._callLoggingService("RenewSession", a, this._renewSessionSuccess, this._renewSessionError, null)
        } catch (a) {
            var b = this.messageTypes.error;
            this.processMessage(b, a.message)
        }
    }, this._renewSessionSuccess = function (a, b, c) {
        try {
            if (a.IsSuccess) c._setExpiredTime(a.Data.FldUsageTimeoutSec), c._sessionGUID = a.Data.FldSessionGUID, c.processLockout(!1);
            else {
                c.processLockout(!0);
                var d = c.messageTypes.error;
                c.processMessage(d, a.ErrorMessage)
            }
        } catch (a) {
            var d = c.messageTypes.error;
            c.processMessage(d, a.message)
        }
    }, this._renewSessionError = function (a, b, c, d, e) {
        try {
            var f = e.messageTypes.fatal;
            e.processMessage(f, "An error occurred while renewing a map licence session:" + b + " " + c)
        } catch (a) {
            var f = e.messageTypes.fatal;
            e.processMessage(f, "An unknown error occurred while renewing a map licence session. Reference 402")
        }
    }, this.closeSession = function () {
        try {
            this.clearMessage();
            var a = {
                pSessionGUID: this._sessionGUID
            };
            this.optionsBingLT.isLocal ? this._callLoggingServiceLocal("CloseSession", a, "_closeSessionSuccess", "_closeSessionError", null) : this._callLoggingService("CloseSession", a, this._closeSessionSuccess, this._closeSessionError, null)
        } catch (a) {
            var b = this.messageTypes.error;
            this.processMessage(b, a.message)
        }
    }, this._closeSessionSuccess = function (a, b, c) {
        try {
            if (a.IsSuccess) $("#" + c._closedScreenDOM).fadeIn(250), $("#" + c._closedFormDOM).fadeIn(250);
            else {
                c.processLockout(!0);
                var d = c.messageTypes.error;
                c.processMessage(d, a.ErrorMessage)
            }
        } catch (a) {
            var d = c.messageTypes.error;
            c.processMessage(d, a.message)
        }
    }, this._closeSessionError = function (a, b, c, d, e) {
        try {
            var f = e.messageTypes.fatal;
            e.processMessage(f, "An error occurred while closing a map licence session:" + b + " " + c)
        } catch (a) {
            var f = e.messageTypes.fatal;
            e.processMessage(f, "An unknown error occurred while closing a map licence session. Reference 436")
        }
    }, this.unlockSession = function (a, b) {
        try {
            void 0 !== a._sessionGUID && null !== a._sessionGUID && a._sessionGUID.length > 0 ? a.renewSession() : a.requestSession()
        } catch (a) {
            var c = this.messageTypes.error;
            this.processMessage(c, a.message)
        }
    }, this.processMessage = function (a, b) {
        alert(b);
        this.test.addDebugger;
        try {
            switch (this.clearMessage(), a) {
                case this.messageTypes.error:
                    b = this.messagePrefix.error + b;
                    break;m
                case this.messageTypes.warning:
                    b = this.messagePrefix.warning + b;
                    break;
                case this.messageTypes.notice:
                    b = this.messagePrefix.notice + b;
                    break;
                case this.messageTypes.fatal:
                    b = this.messagePrefix.fatal + b;
                    break;
                default:
                    b = this.messagePrefix.none + b
            }
            if (a != this.messageTypes.fatal)
                if (0 == this._isLockedOut)
                    if (void 0 === this._messageDOM || null === this._messageDOM || this._messageDOM.length < 1) alert(a + " Message: " + b);
                    else {
                        var c = 250,
                            d = 1500;
                        $("#" + this._messageDOM).html(b), $("#" + this._messageDOM).parent().show().effect("highlight", c, function () {
                            $("#" + this._messageDOM).parent().show().effect("highlight", d)
                        })
                    } else $("#" + this._lockoutMessageDOM).html(b);
            else this.processFatalError(b);
            this.test.consoleLogging && "undefined" != typeof console && (console.log("****************** Message Processor ****"), console.log("Message Type: " + this.messageTypes[a]), console.log("Message : " + b))
        } catch (a) {
            this.test.addDebugger;
            var e = this.messageTypes.error;
            this.processMessage(e, a.message)
        }
    }, this.clearMessage = function () {
        try {
            $("#" + this._lockoutMessageDOM).html(""), $("#" + this._messageDOM).html("")
        } catch (b) {
            var a = this.messageTypes.error;
            this.processMessage(a, b.message)
        }
    }, this.processFatalError = function (a) {
        try {
            var b = document.createElement("div");
            b.setAttribute("id", "divFatalError" + this._DOMUniqueIdentifier.toString()), b.setAttribute("style", "position: absolute; top: 0;left: 0; width: 100%; height: 100%; text-align: center; z-index: 1; opacity: 0.4; background: " + this.optionsBingLT.colorScreenFatalError + "; color: " + this.optionsBingLT.colorTextFatal + "; padding-top: 50px; font-weight: bold; font-size: 14pt;");
            var c = document.createTextNode("A fatal error has occurred: " + a);
            b.appendChild(c);
            document.getElementById(this._mapDOM).appendChild(b), this.test.consoleLogging && "undefined" != typeof console && (console.log("****************** Fatal Error ****"), console.log("Message : " + a))
        } catch (b) {
            this.test.consoleLogging && "undefined" != typeof console && (console.log("****************** Fatal Error ****"), console.log("Message : " + a)), alert("A fatal error has occurred: " + a)
        }
    }, this.processLockout = function (a) {
        var b = this;
        try {
            a ? ($("#" + b._lockoutScreenDOM).fadeIn(250), $("#" + b._lockoutFormDOM).fadeIn(250), b._isLockedOut = !0) : setTimeout(function () {
                $("#" + b._lockoutScreenDOM).fadeOut(250), $("#" + b._lockoutFormDOM).fadeOut(250), b._isLockedOut = !1
            }, 250)
        } catch (a) {
            var c = b.messageTypes.error;
            b.processMessage(c, a.message)
        }
    }
};