Public Class RatingTrend
    Private _JSON As String = ""

    Public Property JSON As String
        Get
            Return _JSON
        End Get
        Set(value As String)
            _JSON = value
        End Set
    End Property

    Public Sub BuildJSON()
        Dim zJSON As New Dictionary(Of String, Object)

        Try

            Dim zDataList As New List(Of Object)
            Dim zDataPoint As Dictionary(Of String, Object)

            'Begin loop for data points
            zDataPoint = New Dictionary(Of String, Object)
            zDataPoint.Add("fldOrdinal", 1)
            zDataPoint.Add("FileNo", "2174.0002")
            zDataPoint.Add("ActiveScore", 33.5)
            zDataPoint.Add("fldYear", "2006")
            zDataPoint.Add("fldColor", "#18375B")
            zDataPoint.Add("fldToolTip", "Rating Text")
            zDataList.Add(zDataPoint)

            zDataPoint = New Dictionary(Of String, Object)
            zDataPoint.Add("fldOrdinal", 2)
            zDataPoint.Add("FileNo", "2174.0002")
            zDataPoint.Add("ActiveScore", 37)
            zDataPoint.Add("fldYear", "2006")
            zDataPoint.Add("fldColor", "#18375B")
            zDataPoint.Add("fldToolTip", "Rating Text")
            zDataList.Add(zDataPoint)
            'End loop for data points

            Dim zMarker As Dictionary(Of String, Object)

            zMarker = New Dictionary(Of String, Object)
            zMarker.Add("visible", True)
            zMarker.Add("background", "#18375B")
            zMarker.Add("type", "square")
            zMarker.Add("size", 5)


            Dim zSeriesList As New List(Of Object)
            Dim zSeriesSetting As Dictionary(Of String, Object)

            'Begin loop for series settings
            zSeriesSetting = New Dictionary(Of String, Object)
            zSeriesSetting.Add("name", "Active Score")
            zSeriesSetting.Add("type", "line")
            zSeriesSetting.Add("field", "ActiveScore")
            zSeriesSetting.Add("categoryField", "fldOrdinal")
            zSeriesSetting.Add("colorField", "fldColor")
            zSeriesSetting.Add("color", "#18375B")
            zSeriesSetting.Add("markers", zMarker)
            zSeriesSetting.Add("data", zDataList)
            zSeriesList.Add(zSeriesSetting)
            'End loop for series settings

            Dim zPlotBands As New List(Of Object)
            Dim zActiveData As Dictionary(Of String, Object)

            zActiveData = New Dictionary(Of String, Object)
            zActiveData.Add("transitions", True)
            zActiveData.Add("fldPlotBands", zPlotBands)
            zActiveData.Add("fldTitleChart", "Active Rating Trending Chart")
            zActiveData.Add("fldTitleValueAxis", "Location")
            zActiveData.Add("fldTitleLocation", "2174.0002")
            zActiveData.Add("fldValueAxisMin", 13.5)  'Add offset value minus from the min
            zActiveData.Add("fldValueAxisMax", 51)    'Add offset value added to the max
            zActiveData.Add("series", zSeriesList)


            Dim zLocs As New List(Of Object)
            Dim zLoc As Dictionary(Of String, Object)

            'Begin loop for array of locations
            zLoc = New Dictionary(Of String, Object)
            zLoc.Add("FileNo", "2174.0002")
            zLoc.Add("ClientLocNo", "Andres")
            zLoc.Add("Division", "Mexico, Central America and Caribbean")
            zLoc.Add("Facility", "CT - Combined Cycle")
            zLoc.Add("Address", "Calle Aurora No. 1, Punta Caucedo, Boca Chica, Dominican Republic")
            zLoc.Add("TIV", 816)
            zLoc.Add("ActiveData", zActiveData)
            zLoc.Add("PassiveData", zActiveData)
            zLoc.Add("TotalData", zActiveData)

            zLocs.Add(zLoc)
            'End loop

            'Document data object
            Dim zDoc As New Dictionary(Of String, Object)
            zDoc.Add("TotalLocations", 1)
            zDoc.Add("Locations", zLocs)

            'Top level object
            zJSON.Add("isSuccess", True)
            zJSON.Add("message", "Success")
            zJSON.Add("data", zDoc)

        Catch ex As Exception
            zJSON.Add("isSuccess", False)
            zJSON.Add("message", ex.Message)
            zJSON.Add("data", Nothing)
            zJSON.Add("settings", Nothing)
        End Try

        _JSON = Newtonsoft.Json.JsonConvert.SerializeObject(zJSON)
    End Sub
End Class
