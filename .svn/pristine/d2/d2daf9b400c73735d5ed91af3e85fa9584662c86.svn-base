function(pData) {
    var zReturn = " ";
    var zColor = "transparent";
    if (pData.elecbattery !== undefined) {
        switch (pData.elecbattery.toString().toLowerCase()) {
            case "adequate":
            case "not applicable":
                zColor = "{{tblMetaColorAlias.fldAlias=Adequate}}";
                break;
            case "inadequate":
                zColor = "{{tblMetaColorAlias.fldAlias=Inadequate}}";
                break;
            case "tolerable":
                zColor = "{{tblMetaColorAlias.fldAlias=Tolerable}}";
                break;
        }
        zReturn = "<div class='gridColorHighlight elecbatteryColor' style='background-color: " + zColor + "'>" + pData.elecbattery + "</div>";
    }
    return zReturn;
}