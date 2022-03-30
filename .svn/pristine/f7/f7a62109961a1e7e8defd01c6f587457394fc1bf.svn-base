var dsChartArea = {
    height: 150,
    width: 215
};

var dsStartingAngle = 150; //270

var dsLegend = {
    visible: false
};

var dsToolTip = {
    visible: true,
    template: "#= category#" // = #= value#%"
};

var dsSeriesDefaults = {
    labels: {
        visible: true,
        background: "transparent",
        border: {
            width: 0,
            color: "transparent"
        },
        template: "#= wrapChartLabelsOnSpace(category, 6)#", //"#= category#", //template: "#= value#%",
        font: "9px arial",
        align:  "circle", //"column",
        position: function (e) {
            if (e.percentage < 0.15) {
                return "insideEnd";
            } else {
                return "insideEnd"; //insideEnd, outsideEnd, center
            }
        },
        margin: function (e) {
            if (e.percentage < 0.15) {
                return 0; //-10
            } else {
                return 0;
            }
        }
    },
    overlay: {
        gradient: "roundedBevel"
    },
    border: {
        width: 1,
        color: "#6C6C6C"
    },
    padding: 12 //35
};

