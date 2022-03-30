var dsBar = [
    { value: 30, date: new Date("2011/12/20") },
    { value: 50, date: new Date("2011/12/21") },
    { value: 45, date: new Date("2011/12/22") },
    { value: 40, date: new Date("2011/12/23") },
    { value: 35, date: new Date("2011/12/24") },
    { value: 40, date: new Date("2011/12/25") },
    { value: 42, date: new Date("2011/12/26") },
    { value: 40, date: new Date("2011/12/27") },
    { value: 35, date: new Date("2011/12/28") },
    { value: 43, date: new Date("2011/12/29") },
    { value: 38, date: new Date("2011/12/30") },
    { value: 30, date: new Date("2011/12/31") },
    { value: 48, date: new Date("2012/01/01") },
    { value: 50, date: new Date("2012/01/02") },
    { value: 55, date: new Date("2012/01/03") },
    { value: 35, date: new Date("2012/01/04") },
    { value: 30, date: new Date("2012/01/05") }
];


dsMultiAxis = [{
    type: "column",
    data: [20, 40, 45, 30, 50],
    stack: true,
    name: "on battery",
    color: "#cc6e38"
}, {
    type: "column",
    data: [20, 30, 35, 35, 40],
    stack: true,
    name: "on gas",
    color: "#ef955f"
}, {
    type: "line",
    data: [30, 38, 40, 32, 42],
    name: "mpg",
    color: "#ec5e0a",
    axis: "mpg"
}, {
    type: "line",
    data: [7.8, 6.2, 5.9, 7.4, 5.6],
    name: "l/100 km",
    color: "#4e4141",
    axis: "l100km"
}];


dsMultiAxisValues = [{
    title: { text: "miles" },
    min: 0,
    max: 100
}, {
    name: "km",
    title: { text: "km" },
    min: 0,
    max: 161,
    majorUnit: 32
}, {
    name: "mpg",
    title: { text: "miles per gallon" },
    color: "#ec5e0a"
}, {
    name: "l100km",
    title: { text: "liters per 100km" },
    color: "#4e4141"
}];


dsPie = [{
    category: "Football",
    value: 35
}, {
    category: "Basketball",
    value: 25
}, {
    category: "Volleyball",
    value: 20
}, {
    category: "Rugby",
    value: 10
}, {
    category: "Tennis",
    value: 10
}];