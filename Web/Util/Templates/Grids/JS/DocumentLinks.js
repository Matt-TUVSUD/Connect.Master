function(pData) {
    var zReturn = " ";
    if (pData.linktoer !== undefined && pData.linktoer !== null && pData.linktoer.toString().length > 0) {
        zReturn = "<a tabIndex='-1' href='\#' onclick='buildFileOpenLink(\\"" + pData.linktoer + "\\", null, \\"\\", \\"\\", true)'>Click Here</a>";
    }
    return zReturn;
}

function(pData) {
    var zReturn = " ";
    if (pData.linktourorlereport !== undefined && pData.linktourorlereport !== null && pData.linktourorlereport.toString().length > 0) {
        zReturn = "<a tabIndex='-1' href='\#' onclick='buildFileOpenLink(\\"" + pData.linktourorlereport + "\\", null, \\"\\", \\"\\", true)'>Click Here</a>";
    }
    return zReturn;
}

function(pData) {
    var zReturn = " ";
    if (pData.linktodiagram !== undefined && pData.linktodiagram !== null && pData.linktodiagram.toString().length > 0) {
        zReturn = "<a tabIndex='-1' href='\#' onclick='buildFileOpenLink(\\"" + pData.linktodiagram + "\\", null, \\"\\", \\"\\", true)'>Click Here</a>";
    }
    return zReturn;
}