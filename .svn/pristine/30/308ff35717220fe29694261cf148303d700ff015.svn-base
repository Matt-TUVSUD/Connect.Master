Namespace razor
    Partial Public Class TblMetaUnitSystem
        Public Enum Systems
            English = 1
            Metric
        End Enum
    End Class

    Partial Public Class rowTblMetaUnitSystem
        Public ReadOnly Property System As TblMetaUnitSystem.Systems
            Get
                Return [Enum].Parse(GetType(TblMetaUnitSystem.Systems), colFldId)
            End Get
        End Property
    End Class
End Namespace