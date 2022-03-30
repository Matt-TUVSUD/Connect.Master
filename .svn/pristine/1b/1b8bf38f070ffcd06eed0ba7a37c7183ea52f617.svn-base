function(pData) {
    var zReturn = " ";
    var zColor = "transparent";
    if (pData.elecequipc !== undefined) {
        switch (pData.elecequipc.toString().toLowerCase()) {
            case "10":
                zColor = "{{tblMetaColorAlias.fldAlias=ElecEquipC10}}";
                break;
            case "9":
                zColor = "{{tblMetaColorAlias.fldAlias=ElecEquipC09}}";
                break;
            case "8":
                zColor = "{{tblMetaColorAlias.fldAlias=ElecEquipC08}}";
                break;
            case "7":
                zColor = "{{tblMetaColorAlias.fldAlias=ElecEquipC07}}";
                break;
            case "6":
                zColor = "{{tblMetaColorAlias.fldAlias=ElecEquipC06}}";
                break;
            case "5":
                zColor = "{{tblMetaColorAlias.fldAlias=ElecEquipC05}}";
                break;
            case "4":
                zColor = "{{tblMetaColorAlias.fldAlias=ElecEquipC04}}";
                break;
            case "3":
                zColor = "{{tblMetaColorAlias.fldAlias=ElecEquipC03}}";
                break;
            case "2":
                zColor = "{{tblMetaColorAlias.fldAlias=ElecEquipC02}}";
                break;
            case "1":
                zColor = "{{tblMetaColorAlias.fldAlias=ElecEquipC01}}";
                break;
        }
        zReturn = "<div class='gridColorHighlight elecequipcColor' style='background-color: " + zColor + "'>" + pData.elecequipc + "</div>";
    }
    return zReturn;
}