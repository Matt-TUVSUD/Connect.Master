/// A helper class to hold data and perform functions in global scope.
var global_countLoading = 2;

var global = {
    // PARAMETERS
    _transisionType: "fade",

    ///REST SERVICE FUNCTIONALITY FOR WHAT IF TOOL TYPE="GET"
    callWIRestService: function (pURL, pSuccess, pError, pParms) {
        try {
            $.ajax({
                type: "GET",
                url: pURL,
                timeout: 120000,
                cache: false,
                processData: true,
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                success: function (pResults) {
                    if (pSuccess != undefined) {
                        pSuccess(pResults, pParms);
                    }
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    if (pError != undefined) {
                        pError(pResults, pMessage, pErrorDetail);
                    } else {
                        alert("Error: " + pMessage);
                    }
                }
            });
        } catch (pErrorMessage) {
            alert("Error: " + pErrorMessage);
        }
    },

    ///REST SERVICE FUNCTIONALITY FOR WHAT IF TOOL TYPE="POST"
    callWIRestServicePOST: function (pURL, pData, pSuccess, pError, pParms) {
        try {
            $.ajax({
                type: "POST",
                url: pURL,
                data: pData,
                timeout: 120000,
                cache: false,
                processData: true,
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                success: function (pResults) {
                    if (pSuccess != undefined) {
                        pSuccess(pResults, pParms);
                    }
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    if (pError != undefined) {
                        pError(pResults, pMessage, pErrorDetail);
                    } else {
                        alert("Error: " + pMessage);
                    }
                }
            });
        } catch (pErrorMessage) {
            alert("Error: " + pErrorMessage);
        }
    },

    /// A function to call the server side REST service.
    /// pURL (STRING)
    /// pService (STRING)
    /// pData (JSON STRING)
    /// pSuccess (optional FUNCTION)
    /// pError (optional FUNCTION)
    callRestService: function (pURL, pService, pData, pSuccess, pError, pParms) {
        try {
            $.ajax({
                type: "POST",
                url: pURL + pService,
                data: pData,
                timeout: 120000,
                cache: false,
                processData: true,
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                success: function (pResults) {
                    if (pSuccess != undefined) {
                        pSuccess(pResults, pParms);
                    }
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    if (pError != undefined) {
                        pError(pResults, pMessage, pErrorDetail, pParms);
                    } else {
                        alert("Error: " + pMessage);
                    }
                }
            });
        } catch (pErrorMessage) {
            alert("Error: " + pErrorMessage);
        }
    },

    /// A function to call the server side REST service.
    /// pURL (STRING)
    /// pService (STRING)
    /// pData (JSON STRING)
    /// pSuccess (optional FUNCTION)
    /// pError (optional FUNCTION)
    callRestServiceSyncronous: function (pURL, pService, pData, pSuccess, pError, pParms) {
        try {
            $.ajax({
                type: "POST",
                url: pURL + pService,
                data: pData,
                async: false,
                timeout: 120000,
                cache: false,
                processData: true,
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                success: function (pResults) {
                    if (pSuccess != undefined) {
                        pSuccess(pResults, pParms);
                    }
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    if (pError != undefined) {
                        pError(pResults, pMessage, pErrorDetail, pParms);
                    } else {
                        alert("Error: " + pMessage);
                    }
                }
            });
        } catch (pErrorMessage) {
            alert("Error: " + pErrorMessage);
        }
    },


    /// A function to call the server side REST service with caching turned on.
    /// pURL (STRING)
    /// pService (STRING)
    /// pData (JSON STRING)
    /// pSuccess (optional FUNCTION)
    /// pError (optional FUNCTION)
    callRestServiceCached: function (pURL, pService, pData, pSuccess, pError, pParms) {
        try {
            $.ajax({
                type: "POST",
                url: pURL + pService,
                data: pData,
                timeout: 120000,
                cache: true,
                processData: true,
                dataType: "json",
                contentType: "application/json; charset=utf-8",
                success: function (pResults) {
                    if (pSuccess != undefined) {
                        pSuccess(pResults, pParms);
                    }
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    if (pError != undefined) {
                        pError(pResults, pMessage, pErrorDetail, pParms);
                    } else {
                        alert("Error: " + pMessage);
                    }
                }
            });
        } catch (pErrorMessage) {
            alert("Error: " + pErrorMessage);
        }
    },


    /// A function to call the server side REST service using JSONP.
    /// pURL (STRING)
    /// pService (STRING)
    /// pData (JSON)
    /// pCallback (STRING)
    /// pSuccess (optional FUNCTION)
    /// pError (optional FUNCTION)
    callRestServicePadded: function (pURL, pService, pData, pCallback, pSuccess, pError) {
        try {
            $.ajax({
                type: "GET",
                url: pURL + pService,
                data: pData,
                dataType: "jsonp",
                contentType: "application/json",
                timeout: 120000,
                crossDomain: true,
                cache: false,
                jsonp: false,
                jsonpCallback: pCallback,
                processData: true,
                success: function (pResults) {
                    if (pSuccess != undefined) {
                        pSuccess(pResults);
                    }
                },
                error: function (pResults, pMessage, pErrorDetail) {
                    if (pResults != undefined && pResults.status != undefined && pResults.status != 200) {
                        if (pError != undefined) {
                            pError(pResults, pMessage, pErrorDetail);
                        } else {
                            alert("Error: " + pMessage);
                        }
                    }
                }
            });
        } catch (pErrorMessage) {
            alert("Error: " + pErrorMessage);
        }
    },


    /// Show a message or info DOM with a yellow highlight
    messageShow: function (pDOM, pClass) {
        var zTimeShort = 250;
        var zTimeLong = 1500;
        if (pClass != undefined && pClass != null) {
            $("#" + pDOM).removeClass("messageWarning");
            $("#" + pDOM).removeClass("messageError");
            $("#" + pDOM).removeClass("messageNotice");
            $("#" + pDOM).removeClass("messageGridWarning");
            $("#" + pDOM).removeClass("messageGridError");
            $("#" + pDOM).removeClass("messageGridNotice");
            $("#" + pDOM).removeClass("messageErrorNoBold");
            $("#" + pDOM).removeClass("messageNoticeNoBold");
            $("#" + pDOM).removeClass("messageBlack");
            $("#" + pDOM).removeClass("messageNoticeNoBoldSmall");
            $("#" + pDOM).removeClass("messageInstructions");
            $("#" + pDOM).removeClass("messageInstructionsLeft");
            $("#" + pDOM).removeClass("messageRedBold");
            //switch (pClass.toString().toLowerCase()) {
            //    case "messagewarning":
            //        $("#" + pDOM).addClass("messageWarning");
            //        break;
            //    case "messageerror":
            //        $("#" + pDOM).addClass("messageError");
            //        break;
            //    default:
            //        $("#" + pDOM).addClass("messageNotice");
            //        break;
            //}
            $("#" + pDOM).addClass(pClass);
        }
        //$("#" + pDOM).show().effect("highlight", zTimeShort, function () {
        //    $("#" + pDOM).show().effect("highlight", zTimeLong);
        //});
        $("#" + pDOM).show(function () {
            $("#" + pDOM).show();
        });
    },


    /// A function to show a section of HTML going in a positive direction.
    /// pDOMToHide (STRING id of DOM to hide)
    /// pDOMToShow (STRING id of DOM to show)
    showPositive: function (pDOMToHide, pDOMToShow) {
        var transTimeIn = 400;
        var transTimeOut = 600;
        var zDOMToHide = pDOMToHide.toString().replace("#", "");
        var zDOMToShow = pDOMToShow.toString().replace("#", "");
        $("#" + zDOMToHide).hide(global._transisionType, { direction: "left", easing: "easeInBack" }, transTimeIn, function () {
            $("#" + zDOMToShow).show(global._transisionType, { direction: "right", easing: "easeOutQuad" }, transTimeOut);
        });
    },


    /// A function to show a section of HTML going in a negative direction.
    /// pDOMToHide (STRING id of DOM to hide)
    /// pDOMToShow (STRING id of DOM to show)
    showNegative: function (pDOMToHide, pDOMToShow) {
        var transTimeIn = 400;
        var transTimeOut = 600;
        var zDOMToHide = pDOMToHide.toString().replace("#", "");
        var zDOMToShow = pDOMToShow.toString().replace("#", "");
        $("#" + zDOMToHide).hide(global._transisionType, { direction: "right", easing: "easeInBack" }, transTimeIn, function () {
            $("#" + zDOMToShow).show(global._transisionType, { direction: "left", easing: "easeOutQuad" }, transTimeOut);
        });
    },


    /// A function to show a section of HTML going in a positive direction without hiding another section.
    /// pDOMToShow (STRING id of DOM to show)
    showPositiveNoHide: function (pDOMToShow) {
        var transTimeIn = 400;
        var transTimeOut = 600;
        var zDOMToShow = pDOMToShow.toString().replace("#", "");
        $("#" + zDOMToShow).show(global._transisionType, { direction: "right", easing: "easeOutQuad" }, transTimeOut);
    },


    /// A function to show a section of HTML going in a negative direction without hiding another section.
    /// pDOMToShow (STRING id of DOM to show)
    showNegativeNoHide: function (pDOMToShow) {
        var transTimeIn = 400;
        var transTimeOut = 600;
        var zDOMToShow = pDOMToShow.toString().replace("#", "");
        $("#" + zDOMToShow).show(global._transisionType, { direction: "left", easing: "easeOutQuad" }, transTimeOut);
    },


    /// A funciton to get a query string from the url
    /// pName (STRING name of the url parameter to search and get value)
    getQueryVariable: function (pName) {
        var query = window.location.search.substring(1);
        var vars = query.split("&");
        for (var i = 0; i < vars.length; i++) {
            var pair = vars[i].split("=");
            if (pair[0] == pName) {
                return pair[1];
            }
        }
        return null;
    },


    /// A function to return a bing map static imagery url
    /// pLatitude (STRING the number value for latitude)
    /// pLongitude (STRING the number value for longitude)
    /// pMapWidth (INT the number value for the width of the imagery)
    /// pMapHeight (INT the number value for the height of the imagery)
    /// pKey (STRING the bing map key)
    getStaticMap: function (pLatitude, pLongitude, pMapWidth, pMapHeight, pKey) {
        try {
            var zKey = this._mapKey;
            var zCenterPoint = pLatitude + "," + pLongitude + "/";
            var zZoomLevel = "18/";
            var zImagerySet = "AerialWithLabels/";
            var zPushPins = "&pp=" + pLatitude + "," + pLongitude + ";" + "32" + ";";
            var zMapSize = "?ms=" + pMapWidth + "," + pMapHeight;
            if (pKey) {
                zKey = pKey;
            }
            var StaticImageURL = "https://dev.virtualearth.net/REST/v1/Imagery/Map/" + zImagerySet + zCenterPoint + zZoomLevel + zMapSize + "&format=png" + "&key=" + zKey;
            return StaticImageURL;
        } catch (pException) {
            //Return URL for placeholder map image
            var noMapImage = "../../Home_{{VER}}/Images/maps/nomap.jpg";
            return noMapImage;
        }
    },


    /// A function to fetch a PDF from HTML information.
    /// pHTML (STRING The HTML to be converted)
    /// pCSS (STRING The CSS that is used in the HTML to be converted)
    /// pZoomFactor (STRING The zoom factor to be used when converting.  This is a decimal value)
    /// pOrientation (STRING The PDF page orientation. Available options are "Landscape" and "Portrait")
    /// pFileName (STRING The name of the PDF file WITHOUT the extension)
    /// For reference please see: https://wkhtmltopdf.org/libwkhtmltox/pagesettings.html
    getPdfFromHtml: function (pHTML, pCSS, pZoomFactor, pOrientation, pFileName) {
        // REMOVE ANY NO PRINT DOMS
        var zDocument = $(pHTML).clone();
        zDocument.find(".printNone").each(function () {
            $(this).remove();
        });
        zDocument.find(".printOnly").each(function () {
            $(this).removeClass("printOnly");
        });
        zHTML = $(zDocument).html();

        zHTML = zHTML.replace(/(\r\n|\n|\r)/gm, " "); // REMOVE ALL LINE BRAKES
        zHTML = zHTML.replace(/(\r\t|\t|\r)/gm, " "); // REMOVE ALL TABS
        zHTML = zHTML.replace(/(\")/gm, "'"); // REPLACE ALL ESCAPED DOUBLE QUOTES WITH SINGLE QUOTES
        zHTML = zHTML.replace(/(<)/gm, "||OPEN||"); // REPLACE ALL OPEN BRACKETS
        zHTML = zHTML.replace(/(>)/gm, "||CLOSE||"); // REPLACE ALL CLOSING BRACKETS
        zCSS = pCSS;
        zCSS = zCSS.replace(/(\r\n|\n|\r)/gm, " "); // REMOVE ALL LINE BRAKES
        zCSS = zCSS.replace(/(\")/gm, "'"); // REPLACE ALL ESCAPED DOUBLE QUOTES WITH SINGLE QUOTES
        //zCSS = zCSS.replace(/1px/gm, "2px"); // REPLACE ALL 1PX LINES TO THICKER

        // REVERT INCORRECT REPLACEMENTS WHERE < OR > ARE LEGIT AND FIX NESTED QUOTES
        //zHTML = zHTML.replace(/\) \|\|CLOSE\|\| -1/gm, ") > -1"); // REPLACE ") > -1"
        //zHTML = zHTML.replace(/\) \|\|OPEN\|\| 0/gm, ") < 0"); // REPLACE ") < 0"
        zHTML = zHTML.replace(/(.search\('q'\))/gm, '.search("q")');
        zHTML = zHTML.replace(/(.search\('x'\))/gm, '.search("x")');
        zHTML = zHTML.replace(/(.search\('f'\))/gm, '.search("f")');
        zHTML = zHTML.replace(/(.search\('a'\))/gm, '.search("a")');

        // CALL HANDLER PAGE BY CREATING A FORM
        // CREATE A FORM DOM ELEMENT
        var zForm = document.createElement("form");
        zForm.setAttribute("id", "frmPDF");
        zForm.setAttribute("method", "post");
        //zForm.setAttribute("target", "_blank");
        zForm.setAttribute("action", "../../../Home_{{VER}}/FD/ServeHTMLToPDF.ashx?sid=" + getGSafeGUID() + "&reportId=" + getQueryVariable("reportId"));
        document.body.appendChild(zForm);

        // CREATE HIDDEN INPUT DOM ELEMENTS
        var zField1 = document.createElement("input");
        zField1.setAttribute("type", "hidden");
        zField1.setAttribute("id", "pHTML");
        zField1.setAttribute("name", "pHTML");
        zField1.setAttribute("value", zHTML);
        zForm.appendChild(zField1);
        var zField2 = document.createElement("input");
        zField2.setAttribute("type", "hidden");
        zField2.setAttribute("id", "pCSS");
        zField2.setAttribute("name", "pCSS");
        zField2.setAttribute("value", zCSS);
        zForm.appendChild(zField2);
        var zField3 = document.createElement("input");
        zField3.setAttribute("type", "hidden");
        zField3.setAttribute("id", "pZoomFactor");
        zField3.setAttribute("name", "pZoomFactor");
        zField3.setAttribute("value", pZoomFactor);
        zForm.appendChild(zField3);
        var zField4 = document.createElement("input");
        zField4.setAttribute("type", "hidden");
        zField4.setAttribute("id", "pOrientation");
        zField4.setAttribute("name", "pOrientation");
        zField4.setAttribute("value", pOrientation);
        zForm.appendChild(zField4);
        if (pFileName) {
            var zField5 = document.createElement("input");
            zField5.setAttribute("type", "hidden");
            zField5.setAttribute("id", "pFileNameParm");
            zField5.setAttribute("name", "pFileNameParm");
            zField5.setAttribute("value", pFileName);
            zForm.appendChild(zField5);
        }

        // SUBMIT THE FORM AND DELETE IT SO IT CAN BE RUN AGAIN
        zForm.submit();
        zForm.removeChild(zField1);
        zForm.removeChild(zField2);
        zForm.removeChild(zField3);
        zForm.removeChild(zField4);
        if (pFileName) {
            zForm.removeChild(zField5);
        }
        document.body.removeChild(zForm);
    },




    /// Deep copy an array of objects by value
    /// pObject (OBJECT of objects to be copied)
    copyObject: function (pObject) {
        //var out, v, key;
        //out = Array.isArray(pObject) ? [] : {};
        //for (key in pObject) {
        //    v = pObject[key];
        //    if (typeof v === "object") {
        //        if (v === null) {
        //            out[key] = v;
        //        } else if (typeof v.getMonth === "function") {
        //            out[key] = v;
        //        } else {
        //            out[key] = global.copyObject(v);
        //        }
        //    } else {
        //        out[key] = v;
        //    }
        //}
        //return out;

        var copy;

        // Handle the 3 simple types, and null or undefined
        if (null == pObject || "object" != typeof pObject) {
            return pObject;
        }

        // Handle Date
        if (pObject instanceof Date) {
            copy = new Date();
            copy.setTime(pObject.getTime());
            return copy;
        }

        // Handle Array
        if (pObject instanceof Array) {
            copy = [];
            for (var i = 0, len = pObject.length; i < len; i++) {
                copy[i] = global.copyObject(pObject[i]);
            }
            return copy;
        }

        // Handle Object
        if (pObject instanceof Object) {
            copy = {};
            for (var attr in pObject) {
                if (pObject.hasOwnProperty(attr)) copy[attr] = global.copyObject(pObject[attr]);
            }
            return copy;
        }

        alert("Unable to copy object. Its type isn't supported.");
    },

    /// A funciton that converts a number into a string with currency notation
    /// n (INT) the number to format
    /// c (INT OPTIONAL) the number of places after to extend the cents
    /// d (CHAR OPTIONAL) the character to use for the decimal point
    /// t (CHAR OPTIONAL) the character to use for the thousands separator
    formatMoney: function (n, c, d, t) {
        c = isNaN(c = Math.abs(c)) ? 2 : c;
        d = d == undefined ? "." : d;
        t = t == undefined ? "," : t;
        s = n < 0 ? "-" : "";
        i = parseInt(n = Math.abs(+n || 0).toFixed(c)) + "";
        j = (j = i.length) > 3 ? j % 3 : 0;
        return "$ " + s + (j ? i.substr(0, j) + t : "") + i.substr(j).replace(/(\d{3})(?=\d)/g, "$1" + t) + (c ? d + Math.abs(n - i).toFixed(c).slice(2) : "");
    },

    /// A funciton that converts a number into a string WITHOUT currency notation
    /// n (INT) the number to format
    /// c (INT OPTIONAL) the number of places after to extend the cents
    /// d (CHAR OPTIONAL) the character to use for the decimal point
    /// t (CHAR OPTIONAL) the character to use for the thousands separator
    formatMoneyNoSymbol: function (n, c, d, t) {
        c = isNaN(c = Math.abs(c)) ? 2 : c;
        d = d == undefined ? "." : d;
        t = t == undefined ? "," : t;
        s = n < 0 ? "-" : "";
        i = parseInt(n = Math.abs(+n || 0).toFixed(c)) + "";
        j = (j = i.length) > 3 ? j % 3 : 0;
        return (j ? i.substr(0, j) + t : "") + i.substr(j).replace(/(\d{3})(?=\d)/g, "$1" + t) + (c ? d + Math.abs(n - i).toFixed(c).slice(2) : "");
    },

    /// A funciton that converts a number into a string with percent notation
    /// Note: This function does not divide by 100.
    /// n (INT) the number to format
    formatPercent: function (n) {
        n = n == undefined ? "0" : n;
        return n + " %";
    },


    /// A function to convert the time portion of a date to UTC time.
    /// pDate (DATE the date object to convert to UTC time)
    convertDateToUTC: function (pDate) {
        var zReturn = null;
        var zConvertedDate = new Date(pDate);
        if (zConvertedDate !== undefined && zConvertedDate !== null && zConvertedDate != "Invalid Date") {
            //var zFullYear = zConvertedDate.getFullYear();
            //var zMonth = zConvertedDate.getMonth();
            //var zDate = zConvertedDate.getDate();
            //var zHours = zConvertedDate.getHours();
            //var zMinutes = zConvertedDate.getMinutes();
            //var zSeconds = zConvertedDate.getSeconds();

            //zReturn = new Date(Date.UTC(pDate)); //Invalid Date
            //zReturn = new Date().toUTCString(pDate); //Thu, 23 Oct 2014 15:52:52 UTC
            //zReturn = new Date().toISOString(pDate); //2014-10-23T15:51:32.004Z 
            //zReturn = new Date(Date.UTC(pDate)); //Invalid Date
            //zReturn = new Date(Date.UTC(zFullYear, zMonth, zDate, zHours, zMinutes)); //Wed Oct 22 16:00:00 EDT 2014 
            //zReturn = Date.UTC(zFullYear, zMonth, zDate, zHours, zMinutes); //1414008000000
            //zReturn = new Date(zFullYear, zMonth, zDate, zHours, zMinutes); //Thu Oct 23 00:00:00 EDT 2014 
            //var zDateUTC = zConvertedDate.toString().replace("EDT", "UTC");

            zConvertedDate.setHours(zConvertedDate.getHours() - zConvertedDate.getTimezoneOffset() / 60);
            zReturn = zConvertedDate;

        }
        return zReturn;
    },


    /// A function to convert the time portion of a date to local time from UTC time.
    /// pDate (DATE the date object to convert to local time)
    convertDateJSONToLocal: function (pDate) {
        var zReturn = null;
        var zConvertedDate = new Date(pDate);
        if (zConvertedDate !== undefined && zConvertedDate !== null && zConvertedDate != "Invalid Date") {
            var zFullYear = zConvertedDate.getUTCFullYear();
            var zMonth = zConvertedDate.getUTCMonth();
            var zDate = zConvertedDate.getUTCDate();
            var zHours = zConvertedDate.getUTCHours();
            var zMinutes = zConvertedDate.getUTCMinutes();
            var zSeconds = zConvertedDate.getUTCSeconds();
            zReturn = new Date(zFullYear, zMonth, zDate, zHours, zMinutes);
        }
        return zReturn;
    },


    /// A function to convert a GRC date string to a date object
    convertGRCStringToDate: function (pDate) {
        var zReturn = null;
        try {
            var zMonthArray = [
                { id: 0, month: "Jan" },
                { id: 1, month: "Feb" },
                { id: 2, month: "Mar" },
                { id: 3, month: "Apr" },
                { id: 4, month: "May" },
                { id: 5, month: "Jun" },
                { id: 6, month: "Jul" },
                { id: 7, month: "Aug" },
                { id: 8, month: "Sep" },
                { id: 9, month: "Oct" },
                { id: 10, month: "Nov" },
                { id: 11, month: "Dec" },
            ];

            if (pDate) {
                var zDay = 0;
                var zYear = 0;
                var zMonth = 0;
                if (pDate.length == 9) {
                    zDay = parseInt(pDate.substring(0, 2));
                    zYear = parseInt(pDate.substring(7, 9)) + 2000;
                    zMonth = pDate.substring(3, 6).toLowerCase();
                } else if (pDate.length == 8) {
                    zDay = parseInt(pDate.substring(0, 1));
                    zYear = parseInt(pDate.substring(6, 8)) + 2000;
                    zMonth = pDate.substring(2, 5).toLowerCase();
                }
                for (var x = 0; x < zMonthArray.length; x++) {
                    if (zMonth == zMonthArray[x].month.toLowerCase()) {
                        zMonth = zMonthArray[x].id;
                        break;
                    }
                }
                zReturn = new Date(zYear, zMonth, zDay);
            }
        } catch (pException) {
            zReturn = null;
        }
        return zReturn;
    },


    /// A funciton that converts a date into a string
    /// Example: 1/31/2099
    /// pDate (DATE) the date to format
    formatShortDate: function (pDate) {
        var zReturn = "";
        try {
            if (pDate != null && pDate != undefined) {
                if (new Date(pDate) == "Invalid Date") {
                    var zDate = new Date(pDate.replace(/^(....).(..).(.{11}).*$/, "$1/$2/$3"));
                    var zMonth = zDate.getMonth() + 1;
                    var zDay = zDate.getDate();
                    var zYear = zDate.getFullYear();
                    zReturn = "" + zMonth.toString() + "/" + zDay.toString() + "/" + zYear.toString();
                } else {
                    var zDate = new Date(pDate);
                    var zMonth = zDate.getMonth() + 1;
                    var zDay = zDate.getDate();
                    var zYear = zDate.getFullYear();
                    zReturn = "" + zMonth.toString() + "/" + zDay.toString() + "/" + zYear.toString();
                }
            }
        } catch (pError) {
            zReturn = "";
        }
        return zReturn;
    },


    /// A funciton that converts a date into a string that is numerically sortable
    /// Example: 2099/31/1
    /// pDate (DATE) the date to format
    formatSortableDate: function (pDate) {
        var zReturn = "";
        try {
            if (pDate != null && pDate != undefined) {
                if (new Date(pDate) == "Invalid Date") {
                    var zDate = new Date(pDate.replace(/^(....).(..).(.{11}).*$/, "$1/$2/$3"));
                    var zMonth = zDate.getMonth() + 1;
                    var zDay = zDate.getDate();
                    var zYear = zDate.getFullYear();
                    zReturn = "" + zYear.toString() + "/" + zMonth.toString() + "/" + zDay.toString();
                } else {
                    var zDate = new Date(pDate);
                    var zMonth = zDate.getMonth() + 1;
                    var zDay = zDate.getDate();
                    var zYear = zDate.getFullYear();
                    zReturn = "" + zYear.toString() + "/" + zMonth.toString() + "/" + zDay.toString();
                }
            }
        } catch (pError) {
            zReturn = "";
        }
        return zReturn;
    },


    /// A funciton that converts a date into a string with long names for days and months
    /// Example: Monday, January 31, 2099
    /// pDate (DATE) the date to format
    formatLongDate: function (pDate) {
        var zReturn = "";
        var zDayName = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
        var zMonthName = ["January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"];
        try {
            if (pDate != null && pDate != undefined) {
                if (new Date(pDate) == "Invalid Date") {
                    var zDate = new Date(pDate.replace(/^(....).(..).(.{11}).*$/, "$1/$2/$3"));
                    var zMonth = zDate.getMonth();
                    var zDay = zDate.getDay();
                    var zDate = zDate.getDate();
                    var zYear = zDate.getFullYear();
                    zReturn = "" + zDayName[zDayOfWeek] + ", " + zMonthName[zMonth] + " " + zDay.toString() + ", " + zYear.toString();
                } else {
                    var zDate = new Date(pDate);
                    var zMonth = zDate.getMonth();
                    var zDayOfWeek = zDate.getDay();
                    var zDay = zDate.getDate();
                    var zYear = zDate.getFullYear();
                    zReturn = "" + zDayName[zDayOfWeek] + ", " + zMonthName[zMonth] + " " + zDay.toString() + ", " + zYear.toString();
                }
            }
        } catch (pError) {
            zReturn = "";
        }
        return zReturn;
    },


    /// A funciton that converts a date into a string with abbreviated months
    /// Example: 31-Jan-2099
    /// pDate (DATE) the date to format
    formatShortDateWithMonth: function (pDate) {
        var zReturn = "";
        var zMonthArray = ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"];
        try {
            if (pDate != null && pDate != undefined) {
                if (new Date(pDate) == "Invalid Date") {
                    var zDate = new Date(pDate.replace(/^(....).(..).(.{11}).*$/, "$1/$2/$3"));
                    var zMonth = zMonthArray[zDate.getMonth()];
                    var zDay = zDate.getDate();
                    var zYear = zDate.getFullYear();
                    zReturn = "" + zDay.toString() + "-" + zMonth.toString() + "-" + zYear.toString();
                } else {
                    var zDate = new Date(pDate);
                    var zMonth = zMonthArray[zDate.getMonth()];
                    var zDay = zDate.getDate();
                    var zYear = zDate.getFullYear();
                    zReturn = "" + zDay.toString() + "-" + zMonth.toString() + "-" + zYear.toString();
                }
            }
        } catch (pError) {
            zReturn = "";
        }
        return zReturn;
    },


    /// A funciton that converts a date into a string with abbreviated months and no days
    /// Example: Jan-2099
    /// pDate (DATE) the date to format
    formatShortDateWithMonthNoDay: function (pDate) {
        var zReturn = "";
        var zMonthArray = ["Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sep", "Oct", "Nov", "Dec"];
        try {
            if (pDate != null && pDate != undefined && pDate != "") {
                if (new Date(pDate) == "Invalid Date") {
                    var zDate = new Date(pDate.replace(/^(....).(..).(.{11}).*$/, "$1/$2/$3"));
                    var zMonth = zMonthArray[zDate.getMonth()];
                    var zDay = zDate.getDate();
                    var zYear = zDate.getFullYear();
                    zReturn = "" + zMonth.toString() + "-" + zYear.toString();
                } else {
                    var zDate = new Date(pDate);
                    var zMonth = zMonthArray[zDate.getMonth()];
                    var zDay = zDate.getDate();
                    var zYear = zDate.getFullYear();
                    zReturn = "" + zMonth.toString() + "-" + zYear.toString();
                }
            }
        } catch (pError) {
            zReturn = "";
        }
        return zReturn;
    },


    /// CREATE DATE RANGE
    getDateRangeMonthYear: function (x, historical) {
        var startDay = 1;
        var numMonths = ((x * 12) + 1);

        var d = new Date();
        var month = d.getMonth();
        month = month + 1;
        var year = d.getFullYear();

        var createOptions = []; //array storage for options
        createOptions.push({
            id: null,
            name: ""
        });

        if ((historical != "") && (historical != null) && (historical != undefined)) {
            historical = new Date(historical);

            var getHistoricalYear = historical.getFullYear();
            var getHistoricalMonth = historical.getMonth();
            getHistoricalMonth = getHistoricalMonth + 1;

            switch (getHistoricalMonth) {
                case 1: setHistoricalMonth = "Jan"; break;
                case 2: setHistoricalMonth = "Feb"; break;
                case 3: setHistoricalMonth = "Mar"; break;
                case 4: setHistoricalMonth = "Apr"; break;
                case 5: setHistoricalMonth = "May"; break;
                case 6: setHistoricalMonth = "Jun"; break;
                case 7: setHistoricalMonth = "Jul"; break;
                case 8: setHistoricalMonth = "Aug"; break;
                case 9: setHistoricalMonth = "Sep"; break;
                case 10: setHistoricalMonth = "Oct"; break;
                case 11: setHistoricalMonth = "Nov"; break;
                case 12: setHistoricalMonth = "Dec"; break;
            }

            var setHistoricalSimple = setHistoricalMonth + "-" + getHistoricalYear;

            if ((getHistoricalYear < year) || ((getHistoricalYear == year) && (getHistoricalMonth < month))) {
                createOptions.push({
                    id: historical,
                    name: setHistoricalSimple
                });
            }
        }

        var tempMonth = month - 1;
        var tempYear = 0;
        for (i = 0; i < numMonths; i++) {

            if (tempMonth >= 12) {
                tempMonth = tempMonth - 11;
                tempYear++;
            } else {
                tempMonth++;
            }

            switch (tempMonth) {
                case 1: simpleMonth = "Jan"; break;
                case 2: simpleMonth = "Feb"; break;
                case 3: simpleMonth = "Mar"; break;
                case 4: simpleMonth = "Apr"; break;
                case 5: simpleMonth = "May"; break;
                case 6: simpleMonth = "Jun"; break;
                case 7: simpleMonth = "Jul"; break;
                case 8: simpleMonth = "Aug"; break;
                case 9: simpleMonth = "Sep"; break;
                case 10: simpleMonth = "Oct"; break;
                case 11: simpleMonth = "Nov"; break;
                case 12: simpleMonth = "Dec"; break;
            }

            //var makeDate = tempMonth + "/" + startDay + "/" + (year + tempYear);
            var makeDate = new Date((year + tempYear), tempMonth - 1, startDay); //TEST OF SETTING ID TO ACTUAL DATE STB 7/14/2014
            var makeSimple = simpleMonth + "-" + (year + tempYear);

            //createOptions.push("<option value='" + makeDate + "'>" + makeSimple + "</option>");
            var obj = {
                id: makeDate,
                name: makeSimple
            }
            createOptions.push(obj);

        }
        return createOptions;
        //alert(JSON.stringify(createOptions));
    },


    /// A funciton that validates if a parameter is a number
    /// pNumber (VARIANT) the parm to verify
    isNumeric: function (pNumber) {
        return !isNaN(parseFloat(pNumber)) && isFinite(pNumber);
    },

    
    base64ToArrayBuffer: function(data) {
            var binaryString = window.atob(data);
    var binaryLen = binaryString.length;
    var bytes = new Uint8Array(binaryLen);
    for (var i = 0; i < binaryLen; i++) {
        var ascii = binaryString.charCodeAt(i);
        bytes[i] = ascii;
    }
    return bytes;
    },

    openFile: function (base64Data, fileName, mimeType) {
        var arrBuffer = global.base64ToArrayBuffer(base64Data);

        // It is necessary to create a new blob object with mime-type explicitly set
        // otherwise only Chrome works like it should
        var newBlob = new Blob([arrBuffer], { type: mimeType });

        // IE doesn't allow using a blob object directly as link href
        // instead it is necessary to use msSaveOrOpenBlob
        if (window.navigator && window.navigator.msSaveOrOpenBlob) {
            window.navigator.msSaveOrOpenBlob(newBlob);
            return;
        }

        // For other browsers: 
        // Create a link pointing to the ObjectURL containing the blob.
        var data = window.URL.createObjectURL(newBlob);

        var link = document.createElement('a');
        document.body.appendChild(link); //required in FF, optional for Chrome
        link.href = data;
        link.download = fileName;
        link.click();
        window.URL.revokeObjectURL(data);
        link.remove();

    }

}


function wrapChartLabels(pText, pMaxLength) {
    var zReturn = "";
    var zLineCount = 0;
    var zWords = pText.split(" ");

    // DON'T DO ANYTHING IF THERE ARE NOTHING BUT SPACES
    var pNoSpaceCount = pText.replace(/ /g, "");
    if (pNoSpaceCount.length > 0) {

        // WRAP IF IT IS TOO LONG
        for (var x = 0; x < zWords.length; x++) {
            var zLength = pText.length;
            zReturn += zWords[x] + " ";
            var zNext = "";
            if (x < zWords.length) {
                zNext = zReturn + zWords[x + 1];
                if (zNext.length > pMaxLength + (zLineCount * pMaxLength)) {
                    zReturn += "\n";
                    zLineCount++;
                }
            }
        }
        // ADD SPACES IF IT IS TOO SHORT
        if (zReturn.length < pMaxLength) {
            var zCharsToAdd = pMaxLength - zReturn.length - 11;
            for (var x = 0; x < zCharsToAdd; x++) {
                zReturn = zReturn + " . ";
            }
        }

    }
    return zReturn;
}


function wrapChartLabelsByLocation(pText, pMaxLength) {
    var zReturn = "";
    var zLineCount = 0;
    var zWords = pText.split(" ");

    // DON'T DO ANYTHING IF THERE ARE NOTHING BUT SPACES
    var pNoSpaceCount = pText.replace(/ /g, "");
    if (pNoSpaceCount.length > 0) {

        // WRAP IF IT IS TOO LONG
        for (var x = 0; x < zWords.length; x++) {
            var zLength = pText.length;
            zReturn += zWords[x] + " ";
            var zNext = "";
            if (x < zWords.length) {
                zNext = zReturn + zWords[x + 1];
                if (zNext.length > pMaxLength + (zLineCount * pMaxLength)) {
                    zReturn += "\n";
                    zLineCount++;
                }
            }
        }
        //// ADD SPACES IF IT IS TOO SHORT
        //if (zReturn.length < pMaxLength) {
        //    var zCharsToAdd = pMaxLength - zReturn.length - 11;
        //    for (var x = 0; x < zCharsToAdd; x++) {
        //        zReturn = zReturn + " . ";
        //    }
        //}

    }
    return zReturn;
}


function wrapChartLabelsOnSpace(pText, pMaxLength) {
    var zReturn = "";
    var zLineCount = 0;
    var zWords = pText.split(" ");
    // WRAP IF THERE IS A SPACE
    for (var x = 0; x < zWords.length; x++) {
        var zLength = pText.length;
        zReturn += zWords[x] + "\n";
    }
    return zReturn;
}

// A FUNCTION TO DECRIMENT THE LOADING COUNTER AND HIDE LOADING SCREEN IF NEEDED
function global_processLoading() {
    global_countLoading--;
    if (global_countLoading < 1) {
        global_hideLoading();
    }
}

// A FUNCTION TO HIDE THE LOADING SCREEN
function global_hideLoading() {
    //$("#containerLoading").fadeOut(333, function () {
    //    $("#containerContent").fadeIn(333);
    //});
    $("#divContainerLoading").fadeOut(500);
}
