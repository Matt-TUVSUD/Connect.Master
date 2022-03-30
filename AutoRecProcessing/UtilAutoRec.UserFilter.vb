Partial Class UtilAutoRec

    Public Class UserFilter

        Public Property Filter As UtilAutoRec.EzUserManagerType
        Public Property FilterValue As String = "*"

        Public Sub New(pFilterBy As EzUserManagerType, pValue As String)
            Filter = pFilterBy
            FilterValue = pValue
        End Sub

        Public ReadOnly Property Division As String
            Get
                If Filter = EzUserManagerType.DivisionManager Then
                    Return FilterValue
                Else
                    Return "*"
                End If
            End Get
        End Property

        Public ReadOnly Property CustomAccess As String
            Get
                If Filter = EzUserManagerType.CustomAccessManager Then
                    Return FilterValue
                Else
                    Return "*"
                End If
            End Get
        End Property

        Public ReadOnly Property Country As String
            Get
                If Filter = EzUserManagerType.CountryManager Then
                    Return FilterValue
                Else
                    Return "*"
                End If
            End Get
        End Property

        Public ReadOnly Property Facility As String
            Get
                If Filter = EzUserManagerType.FacilityManager Then
                    Return FilterValue
                Else
                    Return "*"
                End If
            End Get
        End Property

        Public ReadOnly Property ClientLocNo As String
            Get
                If Filter = EzUserManagerType.ClientLocNoManager Then
                    Return FilterValue
                Else
                    Return "*"
                End If
            End Get
        End Property

        Public ReadOnly Property StProv As String
            Get
                If Filter = EzUserManagerType.StProvManager Then
                    Return FilterValue
                Else
                    Return "*"
                End If
            End Get
        End Property

        Public ReadOnly Property City As String
            Get
                If Filter = EzUserManagerType.CityManager Then
                    Return FilterValue
                Else
                    Return "*"
                End If
            End Get
        End Property

        Public ReadOnly Property Plant As String
            Get
                If Filter = EzUserManagerType.PlantManager Then
                    Return FilterValue
                Else
                    Return "*"
                End If
            End Get
        End Property
    End Class
End Class
