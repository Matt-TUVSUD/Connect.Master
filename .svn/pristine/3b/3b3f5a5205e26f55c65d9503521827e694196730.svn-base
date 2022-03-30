<%@ Page Language="vb" AutoEventWireup="false" MasterPageFile="~/Home_{{VER}}/HazMap.Master" CodeBehind="NatHazMap.aspx.vb" Inherits="GRC.Connect.Web.NatHazMap" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%--<script src="https://cdn.aerisapi.com/sdk/js/1.5.3/aerisweather.min.js" type="text/javascript"></script>--%>
    <script src="https://cdn.aerisapi.com/sdk/js/latest/aerisweather.min.js" type="text/javascript"></script>
    <link rel="stylesheet" href="https://cdn.aerisapi.com/sdk/js/latest/aerisweather.css">
	
     <style>
        #map {
            font-family: 'Helvetica','Arial',sans-serif;
            height: 800px;
		    margin: 30px auto;
		    width: 1915px;
        }
        
        .awxjs__app__ui-panel-info__obs-details .awxjs__ui-row>div {
            margin: 0px;
        }

         .awxjs__app__ui-panel-container .awxjs__app__ui-panel-content {
             width:auto !important;
             padding-right:0px !important;
         }
    </style>
	
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="NatHazMapContent" runat="server">
    <div class="pageContentHldr">
        <div id="viewHazMap" class="recContainer" style="" data-bind="with: viewHazMap">
            <div id="map"></div>
        </div>
    </div>

    <script>
        var tuvSudApp = function () {
            //apiHostPort = ""
            //inDebugMode = (apiHostPort != "");
            var endPointBase = "";
            var UserSid = global.getQueryVariable('sid');
            var filePrefix = gFilePrefix;
            var locationInfo = [];
            /* DETERMINE URL TO SET ENDPOINT BASE */
            var tempURL = window.location.href;
            /* DEV */
            endPointBase = "//dev.globalriskconsultants.com/capi/clients/";
            /* LIVE */
            if (tempURL.indexOf('grcconnect') > -1) {
                endPointBase = "//grcconnect.globalriskconsultants.com/capi/clients/";
            }
            /* TEST/BETA */
            if (tempURL.indexOf('test') > -1) {
                endPointBase = "//grcconnecttest.globalriskconsultants.com/capi/clients/";
            }
            var gURL = endPointBase + filePrefix + "/locations";
            //VECTOR SOURCE
            const facilitiesSources = {
                locations: {
                    url: gURL,
                    icon: {
                        url: '../../Home_{{VER}}/Images/icons/maps/icon-facility.svg'
                    }
                }
            };

            //Fetch new location objects
            const fetchData = () => {
                return fetch(facilitiesSources.locations.url, {
                    headers: {
                        "AppKey": "2F14E5EF-333D-4A14-AB41-0CCC586F7E48",
                        "UserSid": UserSid
                    }
                })
                    .then((response) => response.json())
                    .then((json) => {
                        return json.data;
                    });
            };

            

            // local cache for all returned results that get pushed to the datasource
            // per each update interval
            let payload = [];
            let exposureData = [];

            const aeris = new AerisWeather('itsH0ETre02EmR6CZIC4l', '5iI6TbpIJ9vmdNQDhcUeTVtXwYRmPGSE8CriqLJL');
            const utils = aeris.utils;
            aeris.apps().then((apps) => {
                const app = new apps.InteractiveMapApp("#map", {
                    map: {
                        strategy: 'leaflet',
                        zoom: 2,
                        center: { lat: 37, lon: -93 },
                        layers: 'radar',
                        timeline: {
                            from: -24 * 3600,
                            to: 24 * 3600,
                            autoplay: false,
                            alwaysShowPast: true,
                            alwaysShowFuture: true
                        },
                    },
                    panels: {
                        legends: {
                            title: 'Legends',
                            legend: {
                                size: {
                                    width: 400,
                                    height: 40
                                },
                                styles: {
                                    cell: {
                                        size: {
                                            width: 100,
                                            height: 20
                                        }
                                    }
                                }
                            }
                        },
                        layers: {
                            buttons: [
                                {
                                    id: 'facilities',
                                    title: 'Facilities',
                                    filter: true,
                                    selected: true,
                                    segments: [{
                                        title: 'Customer Locations',
                                        value: 'facilities'
                                    }]
                                },
                                {
                                    id: 'alerts',
                                    value: 'alerts',
                                    title: 'Alerts'
                                },
                                
                                {
                                    id: "ftemperaturesMinText",
                                    value: "ftemperatures-min-text",
                                    title: "Low temp Forecast"
                                },
                                {
                                    title: "Radar",
                                    buttons:[{
                                        id: "radarGlobal",
                                        value: "radar-global",
                                        title: 'Current Radar'
                                    },
                                    {
                                        id:"fradar",
                                        value:"fradar",
                                        title:"Forecast"
                                    }
                                    ]
                                },
                                {
                                    title: "Satellite",
                                    buttons: [{
                                        id: "geoColor",
                                        value: "satellite-geocolor",
                                        title: 'Current'
                                    },
                                    {
                                        id: "satForecast",
                                        value: "fsatellite",
                                        title:"Forecast"
                                    }
                                    ]
                                },
                                {
                                    title: "Tropical Systems",
                                    buttons: [
                                        {
                                            id: 'tropical',
                                            title: 'Current and Forecast',
                                            value: 'tropical-cyclones',
                                            controls: {
                                                settings: [{
                                                    type: 'opacity'
                                                }]
                                            }
                                        },
                                        {
                                            id:"forecastBreakpoints",
                                            value: "tropical-cyclones-break-points",
                                            title: "Forecast Breakpoints"
                                        }
                                    ]
                                    
                                },
                                {
                                    title: "Wind Gusts",
                                    buttons: [
                                        {
                                            id:"currentWind",
                                            value: "wind-gusts-text",
                                            title:"Current"
                                        }, {
                                            id: "gustForecast",
                                            value: "fwind-gusts",
                                            title:"Forecast"
                                        }
                                    ]
                                }, {
                                    title: "Fire (US Only)",
                                    buttons: [{
                                        id: "fire",
                                        value: "fires-obs-icons",
                                        title: "Current"
                                    },
                                    {
                                        id: "fireForecast",
                                        value: "fires-outlook",
                                        title:"Forecast"
                                    }
                                    ]
                                },
                                {
                                    title: "Lightning",
                                    buttons: [
                                        {
                                            id: "lightingStrikes",
                                            value: "lightning-strikes-15m-icons",
                                            title: "Strikes"
                                        },
                                        {
                                            id: "lightingStrikeDensity",
                                            value: "lightning-strike-density",
                                            title: "Density"
                                        }
                                    ]
                                }, {
                                    title: "Storm (US Only)",
                                    buttons: [{
                                        id: "stormReport",
                                        value: 'stormreports',
                                        title: '24 Hour History',
                                    },
                                    {
                                        id: "stormcells",
                                        value: "stormcells",
                                        title: "Current and Forecast"
                                    },
                                    {
                                        id: "convective",
                                        value: "convective",
                                        title: "Convective"
                                    },
                                    ]
                                }
                            ]
                        },
                        info: {
                            views: {
                                facility: {
                                    request: (data) => {
                                        const request = aeris.api();
                                        const forecastFields = 'timestamp,dateTimeISO,tempF,icon,weatherPrimary,windSpeedMPH,windSpeedMinMPH,windSpeedMaxMPH,windGustMPH,snowIN,precipIN'.split(',').map((key) => `periods.${key}`);
                                        request.addRequest(aeris.api().endpoint('observations'));
                                        request.addRequest(aeris.api().endpoint('forecasts').fields(forecastFields.join(',')).filter('3hr').limit(7));
                                        request.addRequest(aeris.api().endpoint('threats').radius('50mi'));
                                        request.addRequest(aeris.api().endpoint('alerts').fields('details.type,details.name,timestamps'));
                                        request.addRequest(aeris.api().endpoint('phrases/summary'));
                                        request.addRequest(aeris.api().endpoint('convective/outlook').action('contains'));
                                        request.addRequest(aeris.api().endpoint('lightning/summary').action('closest').radius('60mi').limit(100));

                                        return request;
                                    },
                                    views: [{
                                        renderer: (data) => {
                                            // View the data returned from the request just above
                                            if (!data.observations || !data.observations.place || !data.observations.place.city || !data.observations.place.state) return ('<p>No place data</p>');
                                            if (locationInfo[0].customAccess != null) {
                                                return (
                                                    '<div>' +
                                                    '<div class="awxjs__app__ui-panel-info__view-title">' +
                                                    locationInfo[0].address +
                                                    '</div>' +
                                                    '<div class="awxjs__app__ui-panel-info__view-title">' +
                                                    locationInfo[0].city + ', ' + locationInfo[0].state +
                                                    '</div>' +
                                                    '<div class="awxjs__app__ui-panel-info__view-title">' +
                                                    locationInfo[0].country +
                                                    '</div>' +
                                                    '<br/>' +
                                                    '<div class="awxjs__app__ui-panel-info__obs-details">' +
                                                    '<div class="awxjs__ui-row">' +
                                                    '<div>Latitude</div>' +
                                                    '<div>' + locationInfo[0].latitude + '</div>' +
                                                    '</div>' +
                                                    '<div class="awxjs__ui-row">' +
                                                    '<div>Longitude</div>' +
                                                    '<div>' + locationInfo[0].longitude + '</div>' +
                                                    '</div>' +
                                                    '<br/>' +
                                                    '<div class="awxjs__ui-row">' +
                                                    '<div>Facility</div>' +
                                                    '<div>' + locationInfo[0].facility + '</div>' +
                                                    '</div>' +
                                                    '<div class="awxjs__ui-row">' +
                                                    '<div>Client Location ID</div>' +
                                                    '<div>' + locationInfo[0].clientLocNo + '</div>' +
                                                    '</div>' +
                                                    '<div class="awxjs__ui-row">' +
                                                    '<div>Division</div>' +
                                                    '<div>' + locationInfo[0].division + '</div>' +
                                                    '</div>' +
                                                    '<div class="awxjs__ui-row">' +
                                                    '<div>Custom Access</div>' +
                                                    '<div>' + locationInfo[0].customAccess + '</div>' +
                                                    '</div>' +
                                                    '<div class="awxjs__ui-row">' +
                                                    '<div>TIV (millions)</div>' +
                                                    '<div>' + locationInfo[0].tiv + '</div>' +
                                                    '</div>' +
                                                    '<br/>' +
                                                    '<div class="awxjs__app__ui-panel-info__view-title">Exposure</div>' +
                                                    '<div class="awxjs__ui-row">' +
                                                    '<div class="awxjs__app__ui-panel-info__forecast-ts">&nbsp;</div>' +
                                                    '<div style="text-decoration:underline;">Rating</div>' +
                                                    '<div style="text-decoration:underline; font-weight:normal;">Zone</div>' +
                                                    '</div>' +
                                                    '<div class="awxjs__ui-row">' +
                                                    '<div>Seismic</div>' +
                                                    '<div>' + exposureData[0].seismicGrade + '</div>' +
                                                    '<div style="font-weight:normal;">' + exposureData[0].seismicZone + '</div>' +
                                                    '</div>' +
                                                    '<div class="awxjs__ui-row">' +
                                                    '<div>Flood</div>' +
                                                    '<div>' + exposureData[0].floodGrade + '</div>' +
                                                    '<div style="font-weight:normal;">' + exposureData[0].floodInundationDepth + '</div>' +
                                                    '</div>' +
                                                    '<div class="awxjs__ui-row">' +
                                                    '<div>Windstorm</div>' +
                                                    '<div>' + exposureData[0].windstormGrade + '</div>' +
                                                    '<div style="font-weight:normal;">' + exposureData[0].windstormMaxSustainedSpeed + 'mph' + '</div>' +
                                                    '</div>' +
                                                    '</div>' +
                                                    '</div>'
                                                );
                                            } else {
                                                return (
                                                    '<div>' +
                                                    '<div class="awxjs__app__ui-panel-info__view-title">' +
                                                    locationInfo[0].address +
                                                    '</div>' +
                                                    '<div class="awxjs__app__ui-panel-info__view-title">' +
                                                    locationInfo[0].city + ', ' + locationInfo[0].state +
                                                    '</div>' +
                                                    '<div class="awxjs__app__ui-panel-info__view-title">' +
                                                    locationInfo[0].country +
                                                    '</div>' +
                                                    '<br/>' +
                                                    '<div class="awxjs__app__ui-panel-info__obs-details">' +
                                                    '<div class="awxjs__ui-row">' +
                                                    '<div>Latitude</div>' +
                                                    '<div>' + locationInfo[0].latitude + '</div>' +
                                                    '</div>' +
                                                    '<div class="awxjs__ui-row">' +
                                                    '<div>Longitude</div>' +
                                                    '<div>' + locationInfo[0].longitude + '</div>' +
                                                    '</div>' +
                                                    '<br/>' +
                                                    '<div class="awxjs__ui-row">' +
                                                    '<div>Facility</div>' +
                                                    '<div>' + locationInfo[0].facility + '</div>' +
                                                    '</div>' +
                                                    '<div class="awxjs__ui-row">' +
                                                    '<div>Client Location ID</div>' +
                                                    '<div>' + locationInfo[0].clientLocNo + '</div>' +
                                                    '</div>' +
                                                    '<div class="awxjs__ui-row">' +
                                                    '<div>Division</div>' +
                                                    '<div>' + locationInfo[0].division + '</div>' +
                                                    '</div>' +
                                                    '<div class="awxjs__ui-row">' +
                                                    '<div>TIV (millions)</div>' +
                                                    '<div>' + locationInfo[0].tiv + '</div>' +
                                                    '</div>' +
                                                    '<br/>' +
                                                    '<div class="awxjs__app__ui-panel-info__view-title">Exposure</div>' +
                                                    '<div class="awxjs__ui-row">' +
                                                    '<div class="awxjs__app__ui-panel-info__forecast-ts">&nbsp;</div>' +
                                                    '<div style="text-decoration:underline;">Rating</div>' +
                                                    '<div style="text-decoration:underline; font-weight:normal;">Zone</div>' +
                                                    '</div>' +
                                                    '<div class="awxjs__ui-row">' +
                                                    '<div>Seismic</div>' +
                                                    '<div>' + exposureData[0].seismicGrade + '</div>' +
                                                    '<div style="font-weight:normal;">' + exposureData[0].seismicZone + '</div>' +
                                                    '</div>' +
                                                    '<div class="awxjs__ui-row">' +
                                                    '<div>Flood</div>' +
                                                    '<div>' + exposureData[0].floodGrade + '</div>' +
                                                    '<div style="font-weight:normal;">' + exposureData[0].floodInundationDepth + '</div>' +
                                                    '</div>' +
                                                    '<div class="awxjs__ui-row">' +
                                                    '<div>Windstorm</div>' +
                                                    '<div>' + exposureData[0].windstormGrade + '</div>' +
                                                    '<div style="font-weight:normal;">' + exposureData[0].windstormMaxSustainedSpeed + 'mph' + '</div>' +
                                                    '</div>' +
                                                    '</div>' +
                                                    '</div>'
                                                );
                                            }
                                        }
                                    }, {
                                        title: 'Active Alerts',
                                        renderer: 'alerts'
                                    }, {
                                        title: 'Active Threats',
                                        renderer: 'threats'
                                    }, {
                                        title: 'Impacts',
                                        renderer: 'hazards'
                                    }, {
                                        title: 'Observations',
                                        renderer: 'obs'
                                    }, {
                                        title: 'Outlook',
                                        renderer: 'outlook'
                                    }, {
                                        title: 'Short-Term Forecast',
                                        renderer: 'forecast'
                                    }]
                                }
                            }
                        }
                    }
                });

                // Add your custom vector source
                const customDataSource = app.addSource('facilities', 'vector', {
                    data: {
                        items: payload,
                        coordinate: (data) => {
                            const { latitude, longitude } = data;
                            return { lat: latitude, lon: longitude };
                        }
                    },
                    style: {
                        marker: data => {
                            const icon = facilitiesSources.locations.icon;
                            return {
                                className: "facilities",
                                icon: {
                                    url: icon.url
                                },
                                size: [25, 25]
                            };
                        }
                    }
                });


                app.on('ready', async () => {
                    //Once the app is ready, add our custom data source to the map
                    app.map.addSource(customDataSource);
                    //When we update our data source, we add the location object to our local cache "payload"
                    //	Then use the update method on the vector source to add all relevant locations
                    //	The local cache is necessary, as calling update overrides the data existing, it does not add to the data
                    const updateDataSource = (results) => {
                        payload = payload.concat(results);
                        customDataSource.update({ items: payload });
                    };
                    const updateExposureDataSource = (results) => {
                        if (results.length > 0) {
                            exposureData = exposureData.concat(results);
                        }
                    };

                    const getExposureData = (url) => {
                        return fetch(url, {
                            headers: {
                                "AppKey": "2F14E5EF-333D-4A14-AB41-0CCC586F7E48",
                                "UserSid": UserSid
                            }
                        })
                            .then((response) => response.json())
                            .then((json) => {
                                updateExposureDataSource(json.data);
                            });
                    };

                    app.map.on('marker:click', (e) => {
                        locationInfo = [];
                        if (e.data) {
                            let data = e.data.data || {};
                            const source = data.awxjs_source;
                            if (source === 'facilities') {
                                const loc = data.latitude + ',' + data.longitude;
                                const name = utils.strings.toName(data.fileNo);
                                for (let i = 0; i < payload.length; i++) {
                                    if (payload[i].fileNo == name) {
                                        locationInfo.push(payload[i]);
                                        for (let j = 0; j < payload[i]._Links.length; j++) {
                                            if (payload[i]._Links[j].rel == "copeExposure") {
                                                getExposureData(payload[i]._Links[j].href).catch((err) => { console.log(err); });
                                            }
                                        }
                                        break;
                                    }
                                }
                                app.showInfo('facility', name).load({ p: loc });
                            }
                        }
                    });

                    // fetch initial data set
                    updateDataSource(await fetchData());
                });
            });
        }
        tuvSudApp();
    </script>

</asp:Content>