////////////////////////////////////////////
//// BUILD AN XML STRING FOR A FOOTER TO EXPORT TO EXCEL
function buildXMLRecFooter() {
    var tempXML = "";
    tempXML += "</table>";
    return tempXML;
}

function buildXMLUserFooter() {
    var tempXML = "";
    tempXML += "</table>";
    return tempXML;
}


////////////////////////////////////////////
//// BUILD AN XML STRING TO EXPORT TO EXCEL
function buildXMLString(tableObject, locationObject) {
    var properties = "valign='middle' align='left'";
    var width500 = "width='500'";
    var width1500 = "width='1500'";
    var width750 = "width='750'";
    var tempXML = "";
    for(x = 0; x < tableObject.length; x++) {
        tempXML += "<tr>";
        tempXML += "<td " + properties + ">" + tableObject[x].FileNo + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.ClientLocNo() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.Division() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.City() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.StProv() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.Country() + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecYear + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecMo + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecNumber + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecSubLetter + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecStatus + "</td>";
        if (tableObject[x].StatusDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].StatusDate.toString().indexOf('1900') > -1 || tableObject[x].StatusDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].StatusDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + width500 + ">" + tableObject[x].RecImpact + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].Hazard + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].PrimaryRecType + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].SecondaryRecType + "</td>";
        tempXML += "<td " + properties + " " + width750 + ">" + tableObject[x].RecKeywords + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].CurrentLERange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].CompletedLERange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].EstCostToCompleteRange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].ActualCostToComplete + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].SavingsRatio + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].IntendedAction + "</td>";
        if (tableObject[x].RespDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].RespDate.toString().indexOf('1900') > -1 || tableObject[x].RespDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].RespDate, 'dd-MMM-yy') + "</td>";
        }        
        tempXML += "<td " + properties + ">" + tableObject[x].RespFrom + "</td>";
        tempXML += "<td " + properties + " " + width1500 + ">" + tableObject[x].FacilityComment + "</td>";
        if (tableObject[x].ExpdComplDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].ExpdComplDate.toString().indexOf('1900') > -1 || tableObject[x].ExpdComplDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].ExpdComplDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "</tr>";
    }   
    return tempXML;
}

function buildXMLStringMgmt(tableObject, locationObject) {
    var properties = "valign='middle' align='left'";
    var width500 = "width='500'";
    var width1500 = "width='1500'";
    var width750 = "width='750'";
    var tempXML = "";
    for (x = 0; x < tableObject.length; x++) {
        tempXML += "<tr>";
        tempXML += "<td " + properties + ">" + tableObject[x].FileNo + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.ClientLocNo() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.Division() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.City() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.StProv() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.Country() + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecYear + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecMo + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecNumber + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecSubLetter + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecStatus + "</td>";
        if (tableObject[x].StatusDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].StatusDate.toString().indexOf('1900') > -1 || tableObject[x].StatusDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].StatusDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + width500 + ">" + tableObject[x].RecImpact + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].Hazard + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].PrimaryRecType + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].SecondaryRecType + "</td>";
        tempXML += "<td " + properties + " " + width750 + ">" + tableObject[x].RecKeywords + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].CurrentLERange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].CompletedLERange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].EstCostToCompleteRange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].ActualCostToComplete + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].SavingsRatio + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].IntendedAction + "</td>";
        if (tableObject[x].RespDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].RespDate.toString().indexOf('1900') > -1 || tableObject[x].RespDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].RespDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + ">" + tableObject[x].RespFrom + "</td>";
        tempXML += "<td " + properties + " " + width1500 + ">" + tableObject[x].FacilityComment + "</td>";
        if (tableObject[x].ExpdComplDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].ExpdComplDate.toString().indexOf('1900') > -1 || tableObject[x].ExpdComplDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].ExpdComplDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + ">" + tableObject[x].MgmtRespAction + "</td>";
        if (tableObject[x].MgmtRespDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].MgmtRespDate.toString().indexOf('1900') > -1 || tableObject[x].MgmtRespDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].MgmtRespDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + ">" + tableObject[x].MgmtRespFrom + "</td>";
        tempXML += "<td " + properties + " " + width1500 + ">" + tableObject[x].MgmtRespComment + "</td>";
        tempXML += "</tr>";
    }
    return tempXML;
}


////////////////////////////////////////////
//// BUILD AN XML STRING TO EXPORT TO EXCEL FOR B&M
function buildXMLString_Boiler(tableObject, locationObject) {
    var properties = "valign='middle' align='left'";
    var width500 = "width='500'";
    var width1500 = "width='1500'";
    var width750 = "width='750'";
    var tempXML = "";
    for (x = 0; x < tableObject.length; x++) {
        tempXML += "<tr>";
        tempXML += "<td " + properties + ">" + tableObject[x].FileNo + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.ClientLocNo() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.Division() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.City() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.StProv() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.Country() + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecYear + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecMo + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecNumber + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecSubLetter + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecStatus + "</td>";
        if (tableObject[x].StatusDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].StatusDate.toString().indexOf('1900') > -1 || tableObject[x].StatusDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].StatusDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + width500 + ">" + tableObject[x].RecImpact + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].PrimaryRecType + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].SecondaryRecType + "</td>";
        tempXML += "<td " + properties + " " + width750 + ">" + tableObject[x].RecKeywords + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].CurrentLERange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].CompletedLERange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].EstCostToCompleteRange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].ActualCostToComplete + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].SavingsRatio + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].IntendedAction + "</td>";
        if (tableObject[x].RespDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].RespDate.toString().indexOf('1900') > -1 || tableObject[x].RespDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].RespDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + ">" + tableObject[x].RespFrom + "</td>";
        tempXML += "<td " + properties + " " + width1500 + ">" + tableObject[x].FacilityComment + "</td>";
        if (tableObject[x].ExpdComplDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].ExpdComplDate.toString().indexOf('1900') > -1 || tableObject[x].ExpdComplDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].ExpdComplDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "</tr>";
    }
    return tempXML;
}

function buildXMLString_BoilerMgmt(tableObject, locationObject) {
    var properties = "valign='middle' align='left'";
    var width500 = "width='500'";
    var width1500 = "width='1500'";
    var width750 = "width='750'";
    var tempXML = "";
    for (x = 0; x < tableObject.length; x++) {
        tempXML += "<tr>";
        tempXML += "<td " + properties + ">" + tableObject[x].FileNo + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.ClientLocNo() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.Division() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.City() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.StProv() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.Country() + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecYear + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecMo + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecNumber + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecSubLetter + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecStatus + "</td>";
        if (tableObject[x].StatusDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].StatusDate.toString().indexOf('1900') > -1 || tableObject[x].StatusDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].StatusDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + width500 + ">" + tableObject[x].RecImpact + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].PrimaryRecType + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].SecondaryRecType + "</td>";
        tempXML += "<td " + properties + " " + width750 + ">" + tableObject[x].RecKeywords + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].CurrentLERange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].CompletedLERange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].EstCostToCompleteRange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].ActualCostToComplete + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].SavingsRatio + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].IntendedAction + "</td>";
        if (tableObject[x].RespDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].RespDate.toString().indexOf('1900') > -1 || tableObject[x].RespDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].RespDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + ">" + tableObject[x].RespFrom + "</td>";
        tempXML += "<td " + properties + " " + width1500 + ">" + tableObject[x].FacilityComment + "</td>";
        if (tableObject[x].ExpdComplDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].ExpdComplDate.toString().indexOf('1900') > -1 || tableObject[x].ExpdComplDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].ExpdComplDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + ">" + tableObject[x].MgmtRespAction + "</td>";
        if (tableObject[x].MgmtRespDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].MgmtRespDate.toString().indexOf('1900') > -1 || tableObject[x].MgmtRespDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].MgmtRespDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + ">" + tableObject[x].MgmtRespFrom + "</td>";
        tempXML += "<td " + properties + " " + width1500 + ">" + tableObject[x].MgmtRespComment + "</td>";
        tempXML += "</tr>";
    }
    return tempXML;
}

////////////////////////////////////////////
//// BUILD AN XML STRING TO EXPORT TO EXCEL FOR B&M
function buildXMLString_Boiler_Features_L(tableObject, locationObject) {
    var properties = "valign='middle' align='left'";
    var width500 = "width='500'";
    var width1500 = "width='1500'";
    var width750 = "width='750'";
    var tempXML = "";
    for (x = 0; x < tableObject.length; x++) {
        tempXML += "<tr>";
        tempXML += "<td " + properties + ">" + tableObject[x].FileNo + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.ClientLocNo() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.Division() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.City() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.StProv() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.Country() + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecYear + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecMo + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecNumber + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecSubLetter + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecStatus + "</td>";
        if (tableObject[x].StatusDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].StatusDate.toString().indexOf('1900') > -1 || tableObject[x].StatusDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].StatusDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + width500 + ">" + tableObject[x].RecImpact + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].PrimaryRecType + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].SecondaryRecType + "</td>";
        tempXML += "<td " + properties + " " + width750 + ">" + tableObject[x].RecKeywords + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].CurrentLEActual + "</td>"; // ACTUAL
        tempXML += "<td " + properties + ">" + tableObject[x].CurrentLERange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].CompletedLEActual + "</td>";  // ACTUAL
        tempXML += "<td " + properties + ">" + tableObject[x].CompletedLERange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].EstCostToCompleteActual + "</td>";       // ACTUAL
        tempXML += "<td " + properties + ">" + tableObject[x].EstCostToCompleteRange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].ActualCostToComplete + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].SavingsRatio + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].IntendedAction + "</td>";
        if (tableObject[x].RespDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].RespDate.toString().indexOf('1900') > -1 || tableObject[x].RespDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].RespDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + ">" + tableObject[x].RespFrom + "</td>";
        tempXML += "<td " + properties + " " + width1500 + ">" + tableObject[x].FacilityComment + "</td>";
        if (tableObject[x].ExpdComplDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].ExpdComplDate.toString().indexOf('1900') > -1 || tableObject[x].ExpdComplDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].ExpdComplDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "</tr>";
    }
    return tempXML;
}

function buildXMLString_Boiler_Features_LMgmt(tableObject, locationObject) {
    var properties = "valign='middle' align='left'";
    var width500 = "width='500'";
    var width1500 = "width='1500'";
    var width750 = "width='750'";
    var tempXML = "";
    for (x = 0; x < tableObject.length; x++) {
        tempXML += "<tr>";
        tempXML += "<td " + properties + ">" + tableObject[x].FileNo + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.ClientLocNo() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.Division() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.City() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.StProv() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.Country() + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecYear + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecMo + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecNumber + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecSubLetter + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecStatus + "</td>";
        if (tableObject[x].StatusDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].StatusDate.toString().indexOf('1900') > -1 || tableObject[x].StatusDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].StatusDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + width500 + ">" + tableObject[x].RecImpact + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].PrimaryRecType + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].SecondaryRecType + "</td>";
        tempXML += "<td " + properties + " " + width750 + ">" + tableObject[x].RecKeywords + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].CurrentLEActual + "</td>"; // ACTUAL
        tempXML += "<td " + properties + ">" + tableObject[x].CurrentLERange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].CompletedLEActual + "</td>";  // ACTUAL
        tempXML += "<td " + properties + ">" + tableObject[x].CompletedLERange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].EstCostToCompleteActual + "</td>";       // ACTUAL
        tempXML += "<td " + properties + ">" + tableObject[x].EstCostToCompleteRange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].ActualCostToComplete + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].SavingsRatio + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].IntendedAction + "</td>";
        if (tableObject[x].RespDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].RespDate.toString().indexOf('1900') > -1 || tableObject[x].RespDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].RespDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + ">" + tableObject[x].RespFrom + "</td>";
        tempXML += "<td " + properties + " " + width1500 + ">" + tableObject[x].FacilityComment + "</td>";
        if (tableObject[x].ExpdComplDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].ExpdComplDate.toString().indexOf('1900') > -1 || tableObject[x].ExpdComplDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].ExpdComplDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + ">" + tableObject[x].MgmtRespAction + "</td>";
        if (tableObject[x].MgmtRespDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].MgmtRespDate.toString().indexOf('1900') > -1 || tableObject[x].MgmtRespDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].MgmtRespDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + ">" + tableObject[x].MgmtRespFrom + "</td>";
        tempXML += "<td " + properties + " " + width1500 + ">" + tableObject[x].MgmtRespComment + "</td>";
        tempXML += "</tr>";
    }
    return tempXML;
}




////////////////////////////////////////////
//// BUILD AN XML STRING TO EXPORT TO EXCEL FOR CUSTOM FEATURES X
function buildXMLString_Features_X(tableObject, locationObject) {
    var properties = "valign='middle' align='left'";
    var width500 = "width='500'";
    var width1500 = "width='1500'";
    var width750 = "width='750'";
    var tempXML = "";
    for (x = 0; x < tableObject.length; x++) {
        tempXML += "<tr>";
        tempXML += "<td " + properties + ">" + tableObject[x].FileNo + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.ClientLocNo() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.Division() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.City() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.StProv() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.Country() + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecYear + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecMo + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecNumber + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecSubLetter + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecStatus + "</td>";
        if (tableObject[x].StatusDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].StatusDate.toString().indexOf('1900') > -1 || tableObject[x].StatusDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].StatusDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + ">" + tableObject[x].RecCode + "</td>";
        tempXML += "<td " + properties + width500 + ">" + tableObject[x].RecImpact + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].Hazard + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].PrimaryRecType + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].SecondaryRecType + "</td>";
        tempXML += "<td " + properties + " " + width750 + ">" + tableObject[x].RecKeywords + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].CurrentLEActual + "</td>"; // ACTUAL
        tempXML += "<td " + properties + ">" + tableObject[x].CurrentLERange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].CompletedLEActual + "</td>";  // ACTUAL
        tempXML += "<td " + properties + ">" + tableObject[x].CompletedLERange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].EstCostToCompleteActual + "</td>";       // ACTUAL
        tempXML += "<td " + properties + ">" + tableObject[x].EstCostToCompleteRange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].ActualCostToComplete + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].SavingsRatio + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].IntendedAction + "</td>";
        if (tableObject[x].RespDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].RespDate.toString().indexOf('1900') > -1 || tableObject[x].RespDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].RespDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + ">" + tableObject[x].RespFrom + "</td>";
        tempXML += "<td " + properties + " " + width1500 + ">" + tableObject[x].FacilityComment + "</td>";
        if (tableObject[x].ExpdComplDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].ExpdComplDate.toString().indexOf('1900') > -1 || tableObject[x].ExpdComplDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].ExpdComplDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "</tr>";
    }
    return tempXML;
}

function buildXMLString_Features_XMgmt(tableObject, locationObject) {
    var properties = "valign='middle' align='left'";
    var width500 = "width='500'";
    var width1500 = "width='1500'";
    var width750 = "width='750'";
    var tempXML = "";
    for (x = 0; x < tableObject.length; x++) {
        tempXML += "<tr>";
        tempXML += "<td " + properties + ">" + tableObject[x].FileNo + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.ClientLocNo() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.Division() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.City() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.StProv() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.Country() + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecYear + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecMo + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecNumber + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecSubLetter + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecStatus + "</td>";
        if (tableObject[x].StatusDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].StatusDate.toString().indexOf('1900') > -1 || tableObject[x].StatusDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].StatusDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + ">" + tableObject[x].RecCode + "</td>";
        tempXML += "<td " + properties + width500 + ">" + tableObject[x].RecImpact + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].Hazard + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].PrimaryRecType + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].SecondaryRecType + "</td>";
        tempXML += "<td " + properties + " " + width750 + ">" + tableObject[x].RecKeywords + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].CurrentLEActual + "</td>"; // ACTUAL
        tempXML += "<td " + properties + ">" + tableObject[x].CurrentLERange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].CompletedLEActual + "</td>";  // ACTUAL
        tempXML += "<td " + properties + ">" + tableObject[x].CompletedLERange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].EstCostToCompleteActual + "</td>";       // ACTUAL
        tempXML += "<td " + properties + ">" + tableObject[x].EstCostToCompleteRange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].ActualCostToComplete + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].SavingsRatio + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].IntendedAction + "</td>";
        if (tableObject[x].RespDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].RespDate.toString().indexOf('1900') > -1 || tableObject[x].RespDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].RespDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + ">" + tableObject[x].RespFrom + "</td>";
        tempXML += "<td " + properties + " " + width1500 + ">" + tableObject[x].FacilityComment + "</td>";
        if (tableObject[x].ExpdComplDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].ExpdComplDate.toString().indexOf('1900') > -1 || tableObject[x].ExpdComplDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].ExpdComplDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + ">" + tableObject[x].MgmtRespAction + "</td>";
        if (tableObject[x].MgmtRespDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].MgmtRespDate.toString().indexOf('1900') > -1 || tableObject[x].MgmtRespDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].MgmtRespDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + ">" + tableObject[x].MgmtRespFrom + "</td>";
        tempXML += "<td " + properties + " " + width1500 + ">" + tableObject[x].MgmtRespComment + "</td>";
        tempXML += "</tr>";
    }
    return tempXML;
}


////////////////////////////////////////////
//// BUILD AN XML STRING TO EXPORT TO EXCEL FOR CUSTOM FEATURES L
function buildXMLString_Features_L(tableObject, locationObject) {
    var properties = "valign='middle' align='left'";
    var width500 = "width='500'";
    var width1500 = "width='1500'";
    var width750 = "width='750'";
    var tempXML = "";
    for (x = 0; x < tableObject.length; x++) {
        tempXML += "<tr>";
        tempXML += "<td " + properties + ">" + tableObject[x].FileNo + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.ClientLocNo() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.Division() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.City() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.StProv() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.Country() + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecYear + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecMo + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecNumber + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecSubLetter + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecStatus + "</td>";
        if (tableObject[x].StatusDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].StatusDate.toString().indexOf('1900') > -1 || tableObject[x].StatusDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].StatusDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + width500 + ">" + tableObject[x].RecImpact + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].Hazard + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].PrimaryRecType + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].SecondaryRecType + "</td>";
        tempXML += "<td " + properties + " " + width750 + ">" + tableObject[x].RecKeywords + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].CurrentLEActual + "</td>"; // ACTUAL
        tempXML += "<td " + properties + ">" + tableObject[x].CurrentLERange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].CompletedLEActual + "</td>";  // ACTUAL
        tempXML += "<td " + properties + ">" + tableObject[x].CompletedLERange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].EstCostToCompleteActual + "</td>";       // ACTUAL
        tempXML += "<td " + properties + ">" + tableObject[x].EstCostToCompleteRange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].ActualCostToComplete + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].SavingsRatio + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].IntendedAction + "</td>";
        if (tableObject[x].RespDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].RespDate.toString().indexOf('1900') > -1 || tableObject[x].RespDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].RespDate, 'dd-MMM-yy') + "</td>";
        }        
        tempXML += "<td " + properties + ">" + tableObject[x].RespFrom + "</td>";
        tempXML += "<td " + properties + " " + width1500 + ">" + tableObject[x].FacilityComment + "</td>";
        if (tableObject[x].ExpdComplDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].ExpdComplDate.toString().indexOf('1900') > -1 || tableObject[x].ExpdComplDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].ExpdComplDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "</tr>";
    }
    return tempXML;
}

function buildXMLString_Features_LMgmt(tableObject, locationObject) {
    var properties = "valign='middle' align='left'";
    var width500 = "width='500'";
    var width1500 = "width='1500'";
    var width750 = "width='750'";
    var tempXML = "";
    for (x = 0; x < tableObject.length; x++) {
        tempXML += "<tr>";
        tempXML += "<td " + properties + ">" + tableObject[x].FileNo + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.ClientLocNo() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.Division() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.City() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.StProv() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.Country() + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecYear + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecMo + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecNumber + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecSubLetter + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecStatus + "</td>";
        if (tableObject[x].StatusDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].StatusDate.toString().indexOf('1900') > -1 || tableObject[x].StatusDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].StatusDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + width500 + ">" + tableObject[x].RecImpact + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].Hazard + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].PrimaryRecType + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].SecondaryRecType + "</td>";
        tempXML += "<td " + properties + " " + width750 + ">" + tableObject[x].RecKeywords + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].CurrentLEActual + "</td>"; // ACTUAL
        tempXML += "<td " + properties + ">" + tableObject[x].CurrentLERange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].CompletedLEActual + "</td>";  // ACTUAL
        tempXML += "<td " + properties + ">" + tableObject[x].CompletedLERange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].EstCostToCompleteActual + "</td>";       // ACTUAL
        tempXML += "<td " + properties + ">" + tableObject[x].EstCostToCompleteRange + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].ActualCostToComplete + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].SavingsRatio + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].IntendedAction + "</td>";
        if (tableObject[x].RespDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].RespDate.toString().indexOf('1900') > -1 || tableObject[x].RespDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].RespDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + ">" + tableObject[x].RespFrom + "</td>";
        tempXML += "<td " + properties + " " + width1500 + ">" + tableObject[x].FacilityComment + "</td>";
        if (tableObject[x].ExpdComplDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].ExpdComplDate.toString().indexOf('1900') > -1 || tableObject[x].ExpdComplDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].ExpdComplDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + ">" + tableObject[x].MgmtRespAction + "</td>";
        if (tableObject[x].MgmtRespDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].MgmtRespDate.toString().indexOf('1900') > -1 || tableObject[x].MgmtRespDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].MgmtRespDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + ">" + tableObject[x].MgmtRespFrom + "</td>";
        tempXML += "<td " + properties + " " + width1500 + ">" + tableObject[x].MgmtRespComment + "</td>";
        tempXML += "</tr>";
    }
    return tempXML;
}


////////////////////////////////////////////
//// BUILD AN XML STRING TO EXPORT TO EXCEL FOR INFRARED
function buildXMLString_Infrared(tableObject, locationObject) {
    var properties = "valign='middle' align='left'";
    var width250 = "width='250'";
    var width500 = "width='500'";
    var width1500 = "width='1500'";
    var width750 = "width='750'";
    var tempXML = "";
    for (x = 0; x < tableObject.length; x++) {
        tempXML += "<tr>";
        tempXML += "<td " + properties + ">" + tableObject[x].FileNo + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.ClientLocNo() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.Division() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.City() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.StProv() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.Country() + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecYear + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecMonth + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecNumber + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecStatus + "</td>";
        if (tableObject[x].StatusDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].StatusDate.toString().indexOf('1900') > -1 || tableObject[x].StatusDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].StatusDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + ">" + tableObject[x].Severityrating + "</td>";
        tempXML += "<td " + properties + width250 + ">" + tableObject[x].Impact + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecPrimary + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecSecondary + "</td>";
        tempXML += "<td " + properties + " " + width750 + ">" + tableObject[x].Recommendation + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].History + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].Itemno + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].Findingno + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].PlantAreaAffected + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].ProbableEquipmentDamageCost + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].FaultType + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].LengthOfBusinessInterruption + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].DetectedWith + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RedundancySpare + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].IntendedAction + "</td>";
        if (tableObject[x].ResponseDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].ResponseDate.toString().indexOf('1900') > -1 || tableObject[x].ResponseDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].ResponseDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + ">" + tableObject[x].ResponseFrom + "</td>";
        tempXML += "<td " + properties + " " + width1500 + ">" + tableObject[x].PlantComment + "</td>";
        if (tableObject[x].ExpectedCompletionDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].ExpectedCompletionDate.toString().indexOf('1900') > -1 || tableObject[x].ExpectedCompletionDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].ExpectedCompletionDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "</tr>";
    }
    return tempXML;
}

function buildXMLString_InfraredMgmt(tableObject, locationObject) {
    var properties = "valign='middle' align='left'";
    var width250 = "width='250'";
    var width500 = "width='500'";
    var width1500 = "width='1500'";
    var width750 = "width='750'";
    var tempXML = "";
    for (x = 0; x < tableObject.length; x++) {
        tempXML += "<tr>";
        tempXML += "<td " + properties + ">" + tableObject[x].FileNo + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.ClientLocNo() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.Division() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.City() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.StProv() + "</td>";
        tempXML += "<td " + properties + ">" + locationObject.Country() + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecYear + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecMonth + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecNumber + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecStatus + "</td>";
        if (tableObject[x].StatusDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].StatusDate.toString().indexOf('1900') > -1 || tableObject[x].StatusDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].StatusDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + ">" + tableObject[x].Severityrating + "</td>";
        tempXML += "<td " + properties + width250 + ">" + tableObject[x].Impact + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecPrimary + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RecSecondary + "</td>";
        tempXML += "<td " + properties + " " + width750 + ">" + tableObject[x].Recommendation + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].History + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].Itemno + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].Findingno + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].PlantAreaAffected + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].ProbableEquipmentDamageCost + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].FaultType + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].LengthOfBusinessInterruption + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].DetectedWith + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RedundancySpare + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].IntendedAction + "</td>";
        tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].ResponseDate, 'dd-MMM-yy') + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].ResponseFrom + "</td>";
        tempXML += "<td " + properties + " " + width1500 + ">" + tableObject[x].PlantComment + "</td>";
        if (tableObject[x].ExpectedCompletionDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].ExpectedCompletionDate.toString().indexOf('1900') > -1 || tableObject[x].ExpectedCompletionDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].ExpectedCompletionDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + ">" + tableObject[x].MgmtRespAction + "</td>";
        if (tableObject[x].MgmtRespDate.toString() == "Mon Jan 1 00:00:00 EST 1900" || tableObject[x].MgmtRespDate.toString().indexOf('1900') > -1 || tableObject[x].MgmtRespDate.toString().indexOf('1899') > -1) {
            tempXML += "<td " + properties + ">" + "" + "</td>";
        } else {
            tempXML += "<td " + properties + ">" + kendo.toString(tableObject[x].MgmtRespDate, 'dd-MMM-yy') + "</td>";
        }
        tempXML += "<td " + properties + ">" + tableObject[x].MgmtRespFrom + "</td>";
        tempXML += "<td " + properties + " " + width1500 + ">" + tableObject[x].MgmtRespComment + "</td>";
        tempXML += "</tr>";
    }
    return tempXML;
}



////////////////////////////////////////////
//// BUILD AN XML STRING TO EXPORT TO EXCEL FOR USERS
function buildXMLString_Users(tableObject) {
    var properties = "valign='middle' align='left'";
    var width250 = "width='250'";
    var width500 = "width='500'";
    var width1500 = "width='1500'";
    var width750 = "width='750'";
    var tempXML = "";
    var tempDateTimeStamp = "";
    var tempLastLogin = "";
    var tempActiveUser = "";
    var tempCCActive = "";
    var tempExpOverdue = "";
    var tempThirdParty = "";
    var tempInternal = "";
    var tempAccountAccess = "";
    var tempDocAccess = "";
    var tempCustomAccess = "";
    var tempDivisionAccess = "";
    var tempPlantAccess = "";
    var tempWorkOrder = "";

    for (x = 0; x < tableObject.length; x++) {
        if (tableObject[x].DateTimeStamp.toString() != "Mon Jan 1 00:00:00 EST 1900" && tableObject[x].DateTimeStamp.toString().indexOf('1900') < 0 && tableObject[x].DateTimeStamp.toString().indexOf('1899') < 0) { tempDateTimeStamp = kendo.toString(tableObject[x].DateTimeStamp, 'dd-MMM-yy'); } else { tempDateTimeStamp = ""; }
        if (tableObject[x].LastLogin.toString() != "Mon Jan 1 00:00:00 EST 1900" && tableObject[x].LastLogin.toString().indexOf('1900') < 0 && tableObject[x].LastLogin.toString().indexOf('1899') < 0) { tempLastLogin = kendo.toString(tableObject[x].LastLogin, 'dd-MMM-yy'); } else { tempLastLogin = ""; }
        if (tableObject[x].CCActive) { tempCCActive = "Yes"; } else { tempCCActive = ""; }
        //if (tableObject[x].ExpOverdue) { tempExpOverdue = "Yes"; } else { tempExpOverdue = ""; }
        if (tableObject[x].ActiveUser) { tempActiveUser = "Yes"; } else { tempActiveUser = ""; }
        if (tableObject[x].ThirdParty) { tempThirdParty = "Yes"; } else { tempThirdParty = ""; }
        if (tableObject[x].Internal) { tempInternal = "Yes"; } else { tempInternal = ""; }
        if (tableObject[x].RiskManager) { tempAccountAccess = "Yes"; } else { tempAccountAccess = ""; }
        if (tableObject[x].DocumentAccess) { tempDocAccess = "Yes"; } else { tempDocAccess = ""; }
        if (tableObject[x].CustomAccess) { tempCustomAccess = "Yes"; } else { tempCustomAccess = ""; }
        if (tableObject[x].DivisionManager) { tempDivisionAccess = "Yes"; } else { tempDivisionAccess = ""; }
        if (tableObject[x].PlantManager) { tempPlantAccess = "Yes"; } else { tempPlantAccess = ""; }
        if (tableObject[x].WO) { tempWorkOrder = "Yes"; } else { tempWorkOrder = ""; }

        tempXML += "<tr>";
        tempXML += "<td " + properties + width500 + ">" + tableObject[x].FullName + "</td>";
        //tempXML += "<td " + properties + width500 + ">" + tableObject[x].UserID + "</td>"; // USER ID IS NOT REQUIRED
        tempXML += "<td " + properties + width500 + ">" + tableObject[x].Email + "</td>";
        tempXML += "<td " + properties + width250 + " style='color: red;'>" + tableObject[x].Password + "</td>";
        tempXML += "<td " + properties + ">" + tempDateTimeStamp + "</td>";
        tempXML += "<td " + properties + ">" + tempLastLogin + "</td>";
        tempXML += "<td " + properties + ">" + tempActiveUser + "</td>";
        tempXML += "<td " + properties + ">" + tempThirdParty + "</td>";
        tempXML += "<td " + properties + ">" + tempInternal + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].GRCAdministrator + "</td>";
        tempXML += "<td " + properties + ">" + tempAccountAccess + "</td>";
        tempXML += "<td " + properties + ">" + tempDocAccess + "</td>";
        tempXML += "<td " + properties + ">" + tempCustomAccess + "</td>";
        tempXML += "<td " + properties + width250 + ">" + tableObject[x].CustomAccessText + "</td>";
        tempXML += "<td " + properties + ">" + tempDivisionAccess + "</td>";
        tempXML += "<td " + properties + width250 + ">" + tableObject[x].Division + "</td>";
        tempXML += "<td " + properties + ">" + tempPlantAccess + "</td>";
        tempXML += "<td " + properties + width250 + ">" + tableObject[x].Plant + "</td>";
        tempXML += "<td " + properties + width250 + ">" + tableObject[x].Phone + "</td>";
        tempXML += "<td " + properties + width250 + ">" + tableObject[x].Fax + "</td>";
        tempXML += "<td " + properties + width500 + ">" + tableObject[x].Comments + "</td>";
        tempXML += "<td " + properties + ">" + tempCCActive + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RInit + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RReport + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RFU1 + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RFU2 + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].RFU3 + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].ROverdue1 + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].ROverdue2 + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].ROverdue3 + "</td>";
        tempXML += "<td " + properties + ">" + tableObject[x].ExpOverdue + "</td>";
        //tempXML += "<td " + properties + ">" + tempWorkOrder + "</td>"; // WORK ORDER IS NOT REQUIRED
        tempXML += "</tr>";
    }
    return tempXML;
}

//////////////////////////////////
//// HEADERS
//////////////////////////////////


////////////////////////////////////////////
//// BUILD AN XML STRING FOR HARDCODED HEADER TO EXPORT TO EXCEL
function buildXMLRecHeader() {
    var properties = "valign='middle' align='center' bgcolor='#C6D1DE'";
    var tempXML = "";

    //// STYLE AND HEADER
    tempXML += "<style>br{mso-data-placement:same-cell;}</style>";
    tempXML += "<table border='1'>";
    tempXML += "<tr>";

    //// COLUMNS
    tempXML += "<td " + properties + "><b>File No.</b></td>";
    tempXML += "<td " + properties + "><b>Client<br>Loc ID</b></td>";
    tempXML += "<td " + properties + "><b>Division</b></td>";
    tempXML += "<td " + properties + "><b>City</b></td>";
    tempXML += "<td " + properties + "><b>St. / Prov.</b></td>";
    tempXML += "<td " + properties + "><b>Country</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Year</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Month</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Number</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Subletter</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Status</b></td>";
    tempXML += "<td " + properties + "><b>Status Date</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Impact</b></td>";
    tempXML += "<td " + properties + "><b>Hazard</b></td>";
    tempXML += "<td " + properties + "><b>Primary Rec. Type</b></td>";
    tempXML += "<td " + properties + "><b>Secondary Rec. Type</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Key Words</b></td>";
    tempXML += "<td " + properties + "><b>Current LE<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Completed LE<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Est. Cost To Complete<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Actual<br>Cost To Complete</b></td>";
    tempXML += "<td " + properties + "><b>Savings Ratio</b></td>";
    tempXML += "<td " + properties + "><b>Intended Action</b></td>";
    tempXML += "<td " + properties + "><b>Response Date</b></td>";
    tempXML += "<td " + properties + "><b>Response From</b></td>";
    tempXML += "<td " + properties + "><b>Facility Comment</b></td>";
    tempXML += "<td " + properties + "><b>Expected Completion Date</b></td>";
    tempXML += "</tr>";
    return tempXML;
}

function buildXMLRecHeaderMgmt() {
    var properties = "valign='middle' align='center' bgcolor='#C6D1DE'";
    var tempXML = "";

    //// STYLE AND HEADER
    tempXML += "<style>br{mso-data-placement:same-cell;}</style>";
    tempXML += "<table border='1'>";
    tempXML += "<tr>";

    //// COLUMNS
    tempXML += "<td " + properties + "><b>File No.</b></td>";
    tempXML += "<td " + properties + "><b>Client<br>Loc ID</b></td>";
    tempXML += "<td " + properties + "><b>Division</b></td>";
    tempXML += "<td " + properties + "><b>City</b></td>";
    tempXML += "<td " + properties + "><b>St. / Prov.</b></td>";
    tempXML += "<td " + properties + "><b>Country</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Year</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Month</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Number</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Subletter</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Status</b></td>";
    tempXML += "<td " + properties + "><b>Status Date</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Impact</b></td>";
    tempXML += "<td " + properties + "><b>Hazard</b></td>";
    tempXML += "<td " + properties + "><b>Primary Rec. Type</b></td>";
    tempXML += "<td " + properties + "><b>Secondary Rec. Type</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Key Words</b></td>";
    tempXML += "<td " + properties + "><b>Current LE<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Completed LE<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Est. Cost To Complete<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Actual<br>Cost To Complete</b></td>";
    tempXML += "<td " + properties + "><b>Savings Ratio</b></td>";
    tempXML += "<td " + properties + "><b>Intended Action</b></td>";
    tempXML += "<td " + properties + "><b>Response Date</b></td>";
    tempXML += "<td " + properties + "><b>Response From</b></td>";
    tempXML += "<td " + properties + "><b>Facility Comment</b></td>";
    tempXML += "<td " + properties + "><b>Expected Completion Date</b></td>";
    tempXML += "<td " + properties + "><b>Mgmt. Action</b></td>";
    tempXML += "<td " + properties + "><b>Mgmt. Resp. Date</b></td>";
    tempXML += "<td " + properties + "><b>Mgmt. Resp. From</b></td>";
    tempXML += "<td " + properties + "><b>Mgmt. Comment</b></td>";
    tempXML += "</tr>";
    return tempXML;
}


////////////////////////////////////////////
//// BUILD AN XML STRING FOR HARDCODED HEADER TO EXPORT TO EXCEL FOR SPECIAL FEATURES 'X'
function buildXMLRecHeader_Features_X() {
    var properties = "valign='middle' align='center' bgcolor='#C6D1DE'";
    var tempXML = "";

    //// STYLE AND HEADER
    tempXML += "<style>br{mso-data-placement:same-cell;}</style>";
    tempXML += "<table border='1'>";
    tempXML += "<tr>";

    //// COLUMNS
    tempXML += "<td " + properties + "><b>File No.</b></td>";
    tempXML += "<td " + properties + "><b>Client<br>Loc ID</b></td>";
    tempXML += "<td " + properties + "><b>Division</b></td>";
    tempXML += "<td " + properties + "><b>City</b></td>";
    tempXML += "<td " + properties + "><b>St. / Prov.</b></td>";
    tempXML += "<td " + properties + "><b>Country</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Year</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Month</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Number</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Subletter</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Status</b></td>";
    tempXML += "<td " + properties + "><b>Status Date</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Code</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Impact</b></td>";
    tempXML += "<td " + properties + "><b>Hazard</b></td>";
    tempXML += "<td " + properties + "><b>Primary Rec. Type</b></td>";
    tempXML += "<td " + properties + "><b>Secondary Rec. Type</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Key Words</b></td>";
    tempXML += "<td " + properties + "><b>Current LE<br>USD</td>";
    tempXML += "<td " + properties + "><b>Current LE<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Completed LE<br>USD</b></td>";
    tempXML += "<td " + properties + "><b>Completed LE<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Est. Cost To Complete<br>USD</b></td>";
    tempXML += "<td " + properties + "><b>Est. Cost To Complete<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Actual<br>Cost To Complete</b></td>";
    tempXML += "<td " + properties + "><b>Savings Ratio</b></td>";
    tempXML += "<td " + properties + "><b>Intended Action</b></td>";
    tempXML += "<td " + properties + "><b>Response Date</b></td>";
    tempXML += "<td " + properties + "><b>Response From</b></td>";
    tempXML += "<td " + properties + "><b>Facility Comment</b></td>";
    tempXML += "<td " + properties + "><b>Expected Completion Date</b></td>";
    tempXML += "</tr>";
    return tempXML;
}

function buildXMLRecHeader_Features_XMgmt() {
    var properties = "valign='middle' align='center' bgcolor='#C6D1DE'";
    var tempXML = "";

    //// STYLE AND HEADER
    tempXML += "<style>br{mso-data-placement:same-cell;}</style>";
    tempXML += "<table border='1'>";
    tempXML += "<tr>";

    //// COLUMNS
    tempXML += "<td " + properties + "><b>File No.</b></td>";
    tempXML += "<td " + properties + "><b>Client<br>Loc ID</b></td>";
    tempXML += "<td " + properties + "><b>Division</b></td>";
    tempXML += "<td " + properties + "><b>City</b></td>";
    tempXML += "<td " + properties + "><b>St. / Prov.</b></td>";
    tempXML += "<td " + properties + "><b>Country</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Year</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Month</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Number</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Subletter</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Status</b></td>";
    tempXML += "<td " + properties + "><b>Status Date</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Code</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Impact</b></td>";
    tempXML += "<td " + properties + "><b>Hazard</b></td>";
    tempXML += "<td " + properties + "><b>Primary Rec. Type</b></td>";
    tempXML += "<td " + properties + "><b>Secondary Rec. Type</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Key Words</b></td>";
    tempXML += "<td " + properties + "><b>Current LE<br>USD</td>";
    tempXML += "<td " + properties + "><b>Current LE<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Completed LE<br>USD</b></td>";
    tempXML += "<td " + properties + "><b>Completed LE<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Est. Cost To Complete<br>USD</b></td>";
    tempXML += "<td " + properties + "><b>Est. Cost To Complete<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Actual<br>Cost To Complete</b></td>";
    tempXML += "<td " + properties + "><b>Savings Ratio</b></td>";
    tempXML += "<td " + properties + "><b>Intended Action</b></td>";
    tempXML += "<td " + properties + "><b>Response Date</b></td>";
    tempXML += "<td " + properties + "><b>Response From</b></td>";
    tempXML += "<td " + properties + "><b>Facility Comment</b></td>";
    tempXML += "<td " + properties + "><b>Expected Completion Date</b></td>";
    tempXML += "<td " + properties + "><b>Mgmt. Action</b></td>";
    tempXML += "<td " + properties + "><b>Mgmt. Resp. Date</b></td>";
    tempXML += "<td " + properties + "><b>Mgmt. Resp. From</b></td>";
    tempXML += "<td " + properties + "><b>Mgmt. Comment</b></td>";
    tempXML += "</tr>";
    return tempXML;
}


////////////////////////////////////////////
//// BUILD AN XML STRING FOR HARDCODED HEADER TO EXPORT TO EXCEL FOR SPECIAL FEATURES 'L'
function buildXMLRecHeader_Features_L() {
    var properties = "valign='middle' align='center' bgcolor='#C6D1DE'";
    var tempXML = "";

    //// STYLE AND HEADER
    tempXML += "<style>br{mso-data-placement:same-cell;}</style>";
    tempXML += "<table border='1'>";
    tempXML += "<tr>";

    //// COLUMNS
    tempXML += "<td " + properties + "><b>File No.</b></td>";
    tempXML += "<td " + properties + "><b>Client<br>Loc ID</b></td>";
    tempXML += "<td " + properties + "><b>Division</b></td>";
    tempXML += "<td " + properties + "><b>City</b></td>";
    tempXML += "<td " + properties + "><b>St. / Prov.</b></td>";
    tempXML += "<td " + properties + "><b>Country</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Year</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Month</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Number</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Subletter</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Status</b></td>";
    tempXML += "<td " + properties + "><b>Status Date</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Impact</b></td>";
    tempXML += "<td " + properties + "><b>Hazard</b></td>";
    tempXML += "<td " + properties + "><b>Primary Rec. Type</b></td>";
    tempXML += "<td " + properties + "><b>Secondary Rec. Type</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Key Words</b></td>";
    tempXML += "<td " + properties + "><b>Current LE<br>USD</td>";
    tempXML += "<td " + properties + "><b>Current LE<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Completed LE<br>USD</b></td>";
    tempXML += "<td " + properties + "><b>Completed LE<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Est. Cost To Complete<br>USD</b></td>";
    tempXML += "<td " + properties + "><b>Est. Cost To Complete<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Actual<br>Cost To Complete</b></td>";
    tempXML += "<td " + properties + "><b>Savings Ratio</b></td>";
    tempXML += "<td " + properties + "><b>Intended Action</b></td>";
    tempXML += "<td " + properties + "><b>Response Date</b></td>";
    tempXML += "<td " + properties + "><b>Response From</b></td>";
    tempXML += "<td " + properties + "><b>Facility Comment</b></td>";
    tempXML += "<td " + properties + "><b>Expected Completion Date</b></td>";
    tempXML += "</tr>";
    return tempXML;
}

function buildXMLRecHeader_Features_LMgmt() {
    var properties = "valign='middle' align='center' bgcolor='#C6D1DE'";
    var tempXML = "";

    //// STYLE AND HEADER
    tempXML += "<style>br{mso-data-placement:same-cell;}</style>";
    tempXML += "<table border='1'>";
    tempXML += "<tr>";

    //// COLUMNS
    tempXML += "<td " + properties + "><b>File No.</b></td>";
    tempXML += "<td " + properties + "><b>Client<br>Loc ID</b></td>";
    tempXML += "<td " + properties + "><b>Division</b></td>";
    tempXML += "<td " + properties + "><b>City</b></td>";
    tempXML += "<td " + properties + "><b>St. / Prov.</b></td>";
    tempXML += "<td " + properties + "><b>Country</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Year</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Month</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Number</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Subletter</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Status</b></td>";
    tempXML += "<td " + properties + "><b>Status Date</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Impact</b></td>";
    tempXML += "<td " + properties + "><b>Hazard</b></td>";
    tempXML += "<td " + properties + "><b>Primary Rec. Type</b></td>";
    tempXML += "<td " + properties + "><b>Secondary Rec. Type</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Key Words</b></td>";
    tempXML += "<td " + properties + "><b>Current LE<br>USD</td>";
    tempXML += "<td " + properties + "><b>Current LE<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Completed LE<br>USD</b></td>";
    tempXML += "<td " + properties + "><b>Completed LE<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Est. Cost To Complete<br>USD</b></td>";
    tempXML += "<td " + properties + "><b>Est. Cost To Complete<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Actual<br>Cost To Complete</b></td>";
    tempXML += "<td " + properties + "><b>Savings Ratio</b></td>";
    tempXML += "<td " + properties + "><b>Intended Action</b></td>";
    tempXML += "<td " + properties + "><b>Response Date</b></td>";
    tempXML += "<td " + properties + "><b>Response From</b></td>";
    tempXML += "<td " + properties + "><b>Facility Comment</b></td>";
    tempXML += "<td " + properties + "><b>Expected Completion Date</b></td>";
    tempXML += "<td " + properties + "><b>Mgmt. Action</b></td>";
    tempXML += "<td " + properties + "><b>Mgmt. Resp. Date</b></td>";
    tempXML += "<td " + properties + "><b>Mgmt. Resp. From</b></td>";
    tempXML += "<td " + properties + "><b>Mgmt. Comment</b></td>";
    tempXML += "</tr>";
    return tempXML;
}


////////////////////////////////////////////
//// BUILD AN XML STRING FOR INFRARED HEADER
function buildXMLRecHeader_Infrared() {
    var properties = "valign='middle' align='center' bgcolor='#C6D1DE'";
    var tempXML = "";

    //// STYLE AND HEADER
    tempXML += "<style>br{mso-data-placement:same-cell;}</style>";
    tempXML += "<table border='1'>";
    tempXML += "<tr>";

    //// COLUMNS
    tempXML += "<td " + properties + "><b>File No.</b></td>";
    tempXML += "<td " + properties + "><b>Client<br>Loc ID</b></td>";
    tempXML += "<td " + properties + "><b>Division</b></td>";
    tempXML += "<td " + properties + "><b>City</b></td>";
    tempXML += "<td " + properties + "><b>St. / Prov.</b></td>";
    tempXML += "<td " + properties + "><b>Country</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Year</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Month</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Number</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Status</b></td>";
    tempXML += "<td " + properties + "><b>Status Date</b></td>";
    tempXML += "<td " + properties + "><b>Severity</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Impact</b></td>";
    tempXML += "<td " + properties + "><b>Primary Rec. Type</b></td>";
    tempXML += "<td " + properties + "><b>Secondary Rec. Type</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Key Words</b></td>";
    tempXML += "<td " + properties + "><b>History</b></td>";
    tempXML += "<td " + properties + "><b>Equip. No.</b></td>";
    tempXML += "<td " + properties + "><b>Finding No.</b></td>";
    tempXML += "<td " + properties + "><b>Plant Area Affected</b></td>";
    tempXML += "<td " + properties + "><b>Probable Equipment Damage Cost</b></td>";
    tempXML += "<td " + properties + "><b>Fault Type</b></td>";
    tempXML += "<td " + properties + "><b>Length of Business Interruption</b></td>";
    tempXML += "<td " + properties + "><b>Detected With</b></td>";
    tempXML += "<td " + properties + "><b>Redundancy Spare</b></td>";
    tempXML += "<td " + properties + "><b>Intended Action</b></td>";
    tempXML += "<td " + properties + "><b>Response Date</b></td>";
    tempXML += "<td " + properties + "><b>Response From</b></td>";
    tempXML += "<td " + properties + "><b>Facility Comment</b></td>";
    tempXML += "<td " + properties + "><b>Expected Completion Date</b></td>";
    tempXML += "</tr>";
    return tempXML;
}

function buildXMLRecHeader_InfraredMgmt() {
    var properties = "valign='middle' align='center' bgcolor='#C6D1DE'";
    var tempXML = "";

    //// STYLE AND HEADER
    tempXML += "<style>br{mso-data-placement:same-cell;}</style>";
    tempXML += "<table border='1'>";
    tempXML += "<tr>";

    //// COLUMNS
    tempXML += "<td " + properties + "><b>File No.</b></td>";
    tempXML += "<td " + properties + "><b>Client<br>Loc ID</b></td>";
    tempXML += "<td " + properties + "><b>Division</b></td>";
    tempXML += "<td " + properties + "><b>City</b></td>";
    tempXML += "<td " + properties + "><b>St. / Prov.</b></td>";
    tempXML += "<td " + properties + "><b>Country</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Year</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Month</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Number</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Status</b></td>";
    tempXML += "<td " + properties + "><b>Status Date</b></td>";
    tempXML += "<td " + properties + "><b>Severity</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Impact</b></td>";
    tempXML += "<td " + properties + "><b>Primary Rec. Type</b></td>";
    tempXML += "<td " + properties + "><b>Secondary Rec. Type</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Key Words</b></td>";
    tempXML += "<td " + properties + "><b>History</b></td>";
    tempXML += "<td " + properties + "><b>Equip. No.</b></td>";
    tempXML += "<td " + properties + "><b>Finding No.</b></td>";
    tempXML += "<td " + properties + "><b>Plant Area Affected</b></td>";
    tempXML += "<td " + properties + "><b>Probable Equipment Damage Cost</b></td>";
    tempXML += "<td " + properties + "><b>Fault Type</b></td>";
    tempXML += "<td " + properties + "><b>Length of Business Interruption</b></td>";
    tempXML += "<td " + properties + "><b>Detected With</b></td>";
    tempXML += "<td " + properties + "><b>Redundancy Spare</b></td>";
    tempXML += "<td " + properties + "><b>Intended Action</b></td>";
    tempXML += "<td " + properties + "><b>Response Date</b></td>";
    tempXML += "<td " + properties + "><b>Response From</b></td>";
    tempXML += "<td " + properties + "><b>Facility Comment</b></td>";
    tempXML += "<td " + properties + "><b>Expected Completion Date</b></td>";
    tempXML += "<td " + properties + "><b>Mgmt. Action</b></td>";
    tempXML += "<td " + properties + "><b>Mgmt. Resp. Date</b></td>";
    tempXML += "<td " + properties + "><b>Mgmt. Resp. From</b></td>";
    tempXML += "<td " + properties + "><b>Mgmt. Comment</b></td>";
    tempXML += "</tr>";
    return tempXML;
}



////////////////////////////////////////////
//// BUILD AN XML STRING FOR HARDCODED HEADER TO EXPORT TO EXCEL
function buildXMLRecHeader_Boiler() {
    var properties = "valign='middle' align='center' bgcolor='#C6D1DE'";
    var tempXML = "";

    //// STYLE AND HEADER
    tempXML += "<style>br{mso-data-placement:same-cell;}</style>";
    tempXML += "<table border='1'>";
    tempXML += "<tr>";

    //// COLUMNS
    tempXML += "<td " + properties + "><b>File No.</b></td>";
    tempXML += "<td " + properties + "><b>Client<br>Loc ID</b></td>";
    tempXML += "<td " + properties + "><b>Division</b></td>";
    tempXML += "<td " + properties + "><b>City</b></td>";
    tempXML += "<td " + properties + "><b>St. / Prov.</b></td>";
    tempXML += "<td " + properties + "><b>Country</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Year</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Month</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Number</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Subletter</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Status</b></td>";
    tempXML += "<td " + properties + "><b>Status Date</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Impact</b></td>";
    tempXML += "<td " + properties + "><b>Primary Rec. Type</b></td>";
    tempXML += "<td " + properties + "><b>Secondary Rec. Type</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Key Words</b></td>";
    tempXML += "<td " + properties + "><b>Current LE<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Completed LE<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Est. Cost To Complete<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Actual<br>Cost To Complete</b></td>";
    tempXML += "<td " + properties + "><b>Savings Ratio</b></td>";
    tempXML += "<td " + properties + "><b>Intended Action</b></td>";
    tempXML += "<td " + properties + "><b>Response Date</b></td>";
    tempXML += "<td " + properties + "><b>Response From</b></td>";
    tempXML += "<td " + properties + "><b>Facility Comment</b></td>";
    tempXML += "<td " + properties + "><b>Expected Completion Date</b></td>";
    tempXML += "</tr>";
    return tempXML;
}

function buildXMLRecHeader_BoilerMgmt() {
    var properties = "valign='middle' align='center' bgcolor='#C6D1DE'";
    var tempXML = "";

    //// STYLE AND HEADER
    tempXML += "<style>br{mso-data-placement:same-cell;}</style>";
    tempXML += "<table border='1'>";
    tempXML += "<tr>";

    //// COLUMNS
    tempXML += "<td " + properties + "><b>File No.</b></td>";
    tempXML += "<td " + properties + "><b>Client<br>Loc ID</b></td>";
    tempXML += "<td " + properties + "><b>Division</b></td>";
    tempXML += "<td " + properties + "><b>City</b></td>";
    tempXML += "<td " + properties + "><b>St. / Prov.</b></td>";
    tempXML += "<td " + properties + "><b>Country</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Year</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Month</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Number</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Subletter</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Status</b></td>";
    tempXML += "<td " + properties + "><b>Status Date</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Impact</b></td>";
    tempXML += "<td " + properties + "><b>Primary Rec. Type</b></td>";
    tempXML += "<td " + properties + "><b>Secondary Rec. Type</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Key Words</b></td>";
    tempXML += "<td " + properties + "><b>Current LE<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Completed LE<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Est. Cost To Complete<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Actual<br>Cost To Complete</b></td>";
    tempXML += "<td " + properties + "><b>Savings Ratio</b></td>";
    tempXML += "<td " + properties + "><b>Intended Action</b></td>";
    tempXML += "<td " + properties + "><b>Response Date</b></td>";
    tempXML += "<td " + properties + "><b>Response From</b></td>";
    tempXML += "<td " + properties + "><b>Facility Comment</b></td>";
    tempXML += "<td " + properties + "><b>Expected Completion Date</b></td>";
    tempXML += "<td " + properties + "><b>Mgmt. Action</b></td>";
    tempXML += "<td " + properties + "><b>Mgmt. Resp. Date</b></td>";
    tempXML += "<td " + properties + "><b>Mgmt. Resp. From</b></td>";
    tempXML += "<td " + properties + "><b>Mgmt. Comment</b></td>";
    tempXML += "</tr>";
    return tempXML;
}


////////////////////////////////////////////
//// BUILD AN XML STRING FOR HARDCODED HEADER TO EXPORT TO EXCEL
function buildXMLRecHeader_Boiler_Features_L() {
    var properties = "valign='middle' align='center' bgcolor='#C6D1DE'";
    var tempXML = "";

    //// STYLE AND HEADER
    tempXML += "<style>br{mso-data-placement:same-cell;}</style>";
    tempXML += "<table border='1'>";
    tempXML += "<tr>";

    //// COLUMNS
    tempXML += "<td " + properties + "><b>File No.</b></td>";
    tempXML += "<td " + properties + "><b>Client<br>Loc ID</b></td>";
    tempXML += "<td " + properties + "><b>Division</b></td>";
    tempXML += "<td " + properties + "><b>City</b></td>";
    tempXML += "<td " + properties + "><b>St. / Prov.</b></td>";
    tempXML += "<td " + properties + "><b>Country</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Year</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Month</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Number</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Subletter</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Status</b></td>";
    tempXML += "<td " + properties + "><b>Status Date</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Impact</b></td>";
    tempXML += "<td " + properties + "><b>Primary Rec. Type</b></td>";
    tempXML += "<td " + properties + "><b>Secondary Rec. Type</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Key Words</b></td>";
    tempXML += "<td " + properties + "><b>Current LE<br>USD</td>";
    tempXML += "<td " + properties + "><b>Current LE<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Completed LE<br>USD</b></td>";
    tempXML += "<td " + properties + "><b>Completed LE<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Est. Cost To Complete<br>USD</b></td>";
    tempXML += "<td " + properties + "><b>Est. Cost To Complete<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Actual<br>Cost To Complete</b></td>";
    tempXML += "<td " + properties + "><b>Savings Ratio</b></td>";
    tempXML += "<td " + properties + "><b>Intended Action</b></td>";
    tempXML += "<td " + properties + "><b>Response Date</b></td>";
    tempXML += "<td " + properties + "><b>Response From</b></td>";
    tempXML += "<td " + properties + "><b>Facility Comment</b></td>";
    tempXML += "<td " + properties + "><b>Expected Completion Date</b></td>";
    tempXML += "</tr>";
    return tempXML;
}

function buildXMLRecHeader_Boiler_Features_LMgmt() {
    var properties = "valign='middle' align='center' bgcolor='#C6D1DE'";
    var tempXML = "";

    //// STYLE AND HEADER
    tempXML += "<style>br{mso-data-placement:same-cell;}</style>";
    tempXML += "<table border='1'>";
    tempXML += "<tr>";

    //// COLUMNS
    tempXML += "<td " + properties + "><b>File No.</b></td>";
    tempXML += "<td " + properties + "><b>Client<br>Loc ID</b></td>";
    tempXML += "<td " + properties + "><b>Division</b></td>";
    tempXML += "<td " + properties + "><b>City</b></td>";
    tempXML += "<td " + properties + "><b>St. / Prov.</b></td>";
    tempXML += "<td " + properties + "><b>Country</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Year</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Month</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Number</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Subletter</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Status</b></td>";
    tempXML += "<td " + properties + "><b>Status Date</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Impact</b></td>";
    tempXML += "<td " + properties + "><b>Primary Rec. Type</b></td>";
    tempXML += "<td " + properties + "><b>Secondary Rec. Type</b></td>";
    tempXML += "<td " + properties + "><b>Rec. Key Words</b></td>";
    tempXML += "<td " + properties + "><b>Current LE<br>USD</td>";
    tempXML += "<td " + properties + "><b>Current LE<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Completed LE<br>USD</b></td>";
    tempXML += "<td " + properties + "><b>Completed LE<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Est. Cost To Complete<br>USD</b></td>";
    tempXML += "<td " + properties + "><b>Est. Cost To Complete<br>Range</b></td>";
    tempXML += "<td " + properties + "><b>Actual<br>Cost To Complete</b></td>";
    tempXML += "<td " + properties + "><b>Savings Ratio</b></td>";
    tempXML += "<td " + properties + "><b>Intended Action</b></td>";
    tempXML += "<td " + properties + "><b>Response Date</b></td>";
    tempXML += "<td " + properties + "><b>Response From</b></td>";
    tempXML += "<td " + properties + "><b>Facility Comment</b></td>";
    tempXML += "<td " + properties + "><b>Expected Completion Date</b></td>";
    tempXML += "<td " + properties + "><b>Mgmt. Action</b></td>";
    tempXML += "<td " + properties + "><b>Mgmt. Resp. Date</b></td>";
    tempXML += "<td " + properties + "><b>Mgmt. Resp. From</b></td>";
    tempXML += "<td " + properties + "><b>Mgmt. Comment</b></td>";
    tempXML += "</tr>";
    return tempXML;
}


////////////////////////////////////////////
//// BUILD AN XML STRING FOR HARDCODED HEADER TO EXPORT TO EXCEL
function buildXMLUserHeader() {
    var properties = "valign='middle' align='center' bgcolor='#C6D1DE'";
    var tempXML = "";

    //// STYLE AND HEADER
    tempXML += "<style>br{mso-data-placement:same-cell;}</style>";
    tempXML += "<table border='1'>";
    tempXML += "<tr>";

    //// COLUMNS
    tempXML += "<td " + properties + "><b>Full Name</b></td>";
    //tempXML += "<td " + properties + "><b>User ID</b></td>"; // USER ID IS NOT REQUIRED
    tempXML += "<td " + properties + "><b>Email</b></td>";
    tempXML += "<td " + properties + " style='color: red;'><b>Password</b></td>";
    tempXML += "<td " + properties + "><b>Date Added</b></td>";
    tempXML += "<td " + properties + "><b>Last Login</b></td>";
    tempXML += "<td " + properties + "><b>Active User</b></td>";
    tempXML += "<td " + properties + "><b>Third Party</b></td>";
    tempXML += "<td " + properties + "><b>Internal</b></td>";
    tempXML += "<td " + properties + "><b>GRC. Admin.</b></td>";
    tempXML += "<td " + properties + "><b>Account Access</b></td>";
    tempXML += "<td " + properties + "><b>Doc. Access</b></td>";
    tempXML += "<td " + properties + "><b>Cust. Access</b></td>";
    tempXML += "<td " + properties + "><b>Custom Access Text</b></td>";
    tempXML += "<td " + properties + "><b>Div. Access</b></td>";
    tempXML += "<td " + properties + "><b>Division</b></td>";
    tempXML += "<td " + properties + "><b>Plant Manager</b></td>";
    tempXML += "<td " + properties + "><b>Plant</b></td>";
    tempXML += "<td " + properties + "><b>Phone</b></td>";
    tempXML += "<td " + properties + "><b>Fax</b></td>";
    tempXML += "<td " + properties + "><b>Comments</b></td>";
    tempXML += "<td " + properties + "><b>CC Active</b></td>";
    tempXML += "<td " + properties + "><b>R. Initial</b></td>";
    tempXML += "<td " + properties + "><b>R. Report</b></td>";
    tempXML += "<td " + properties + "><b>RFU1</b></td>";
    tempXML += "<td " + properties + "><b>RFU2</b></td>";
    tempXML += "<td " + properties + "><b>RFU3</b></td>";
    tempXML += "<td " + properties + "><b>R. Overdue 1</b></td>";
    tempXML += "<td " + properties + "><b>R. Overdue 2</b></td>";
    tempXML += "<td " + properties + "><b>R. Overdue 3</b></td>";
    tempXML += "<td " + properties + "><b>Exp. Overdue</b></td>";
    //tempXML += "<td " + properties + "><b>Work Order</b></td>"; // WORK ORDER IS NOT REQUIRED
    tempXML += "</tr>";
    return tempXML;
}
