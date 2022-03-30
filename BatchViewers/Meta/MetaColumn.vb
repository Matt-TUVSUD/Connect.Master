Imports Telerik.WinControls.UI
Imports GRC.Connect.Libraries.DataLib.razor

Namespace Meta

    Public Class MetaDataTextBoxColumn
        Inherits GridViewTextBoxColumn

        Public Property IsRequired As Boolean

        Public Overridable Sub SetNewRowDefaultValues(pNewRow As GridViewNewRowInfo, pOldRow As GridViewRowInfo)

        End Sub

        Public Sub SetContextMenuItems(ByRef pContextMenu As RadDropDownMenu, ByVal pCellElement As GridCellElement, ByVal pForm As MetaUtilityForm)

            'If TypeOf Me Is IMetaIDColumn And TypeOf pCellElement Is GridDataCellElement Then
            '    Dim zGetPropertyMenuItem As New RadMenuItem("Get Properties [" & pCellElement.Value & "]...", New ContextMenuTagProps(Me, pForm))
            '    AddHandler zGetPropertyMenuItem.Click, AddressOf GetPropertiesHandler
            '    pContextMenu.Items.Add(zGetPropertyMenuItem)
            'End If

        End Sub

        Public Sub GetPropertiesHandler(sender As Object, e As EventArgs)
            Dim zRadMenuItem As RadMenuItem = sender
            Dim zProps As ContextMenuTagProps = zRadMenuItem.Tag
            zProps.Form.PropertyForm.LoadProperties(zProps.Column, zProps.Form.RadGridView1.CurrentCell.Value)
        End Sub

        Public Sub New()

        End Sub

        Private Class ContextMenuTagProps
            Public Column As IMetaIDColumn
            Public Form As MetaUtilityForm

            Public Sub New(pCol As IMetaIDColumn, pForm As MetaUtilityForm)
                Column = pCol
                Form = pForm
            End Sub

        End Class


    End Class

    Public Interface IMetaIDColumn
        Function GetPropertyStore(pID As Integer?) As RadPropertyStore
        Function ColumnBackColor() As System.Drawing.Color
    End Interface

    Public Class SourceIDMetaDataTextBoxColumn
        Inherits MetaDataTextBoxColumn
        Implements IMetaIDColumn

        Public Function GetPropertyStore(pID As Integer?) As RadPropertyStore Implements IMetaIDColumn.GetPropertyStore
            Dim zStore As New MetaPropertyStore(Me)
            If IsNumeric(pID.Value) Then
                zStore.ID = pID

                Dim zMeta As rowTblMetaSource = MetaData.Sources.Find(Function(x) x.colFldId = pID)

                If Not IsNothing(zMeta) Then
                    Dim zPropInfo As Reflection.PropertyInfo() = zMeta.GetType.GetProperties()
                    zPropInfo.ToList.ForEach(Sub(x) zStore.Add(New MetaPropertyStoreItem(x.PropertyType, x.Name, x.GetValue(zMeta), zMeta, "Source Meta")))
                Else
                    zStore.Add(New PropertyStoreItem(Type.GetType("System.String"), "No Properties", Nothing, "", "", True))
                End If
            Else
                zStore.Add(New PropertyStoreItem(Type.GetType("System.String"), "No Properties", Nothing, "", "", True))
            End If
            Return zStore
        End Function

        Public Function ColumnBackColor() As Drawing.Color Implements IMetaIDColumn.ColumnBackColor
            Return Drawing.Color.LightBlue
        End Function
    End Class

    Public Class GridIDMetaDataTextBoxColumn
        Inherits MetaDataTextBoxColumn
        Implements IMetaIDColumn

        Public Function GetPropertyStore(pID As Integer?) As RadPropertyStore Implements IMetaIDColumn.GetPropertyStore
            Dim zStore As New MetaPropertyStore(Me)
            If IsNumeric(pID.Value) Then
                zStore.ID = pID
                Dim zMeta As rowTblMetaGrid = MetaData.Grids.Find(Function(x) x.colFldId = pID)

                If Not IsNothing(zMeta) Then
                    Dim zPropInfo As Reflection.PropertyInfo() = zMeta.GetType.GetProperties()
                    zPropInfo.ToList.ForEach(Sub(x) zStore.Add(New MetaPropertyStoreItem(x.DeclaringType, x.Name, x.GetValue(zMeta), zMeta, "Grid Meta", zStore)))
                Else
                    zStore.Add(New PropertyStoreItem(Type.GetType("System.String"), "No Properties", Nothing, "", "", True))
                End If
            Else
                zStore.Add(New PropertyStoreItem(Type.GetType("System.String"), "No Properties", Nothing, "", "", True))
            End If

            Return zStore
        End Function

        Public Function ColumnBackColor() As Drawing.Color Implements IMetaIDColumn.ColumnBackColor
            Return Drawing.Color.LightGray
        End Function
    End Class

    Public Class ReportIDMetaDataTextBoxColumn
        Inherits MetaDataTextBoxColumn
        Implements IMetaIDColumn

        Public Function GetPropertyStore(pID As Integer?) As RadPropertyStore Implements IMetaIDColumn.GetPropertyStore
            Dim zStore As New MetaPropertyStore(Me)
            If IsNumeric(pID.Value) Then
                zStore.ID = pID
                Dim zMeta As rowTblMetaReport = MetaData.Reports.Find(Function(x) x.colFldId = pID)

                If Not IsNothing(zMeta) Then
                    Dim zPropInfo As Reflection.PropertyInfo() = zMeta.GetType.GetProperties()
                    zPropInfo.ToList.ForEach(Sub(x) zStore.Add(New MetaPropertyStoreItem(x.DeclaringType, x.Name, x.GetValue(zMeta), zMeta, "Report Meta")))
                Else
                    zStore.Add(New PropertyStoreItem(Type.GetType("System.String"), "No Properties", Nothing, "", "", True))
                End If

            Else
                zStore.Add(New PropertyStoreItem(Type.GetType("System.String"), "No Properties", Nothing, "", "", True))
            End If

            Return zStore
        End Function

        Public Function ColumnBackColor() As Drawing.Color Implements IMetaIDColumn.ColumnBackColor
            Return Drawing.Color.LightGreen
        End Function
    End Class

    Public Class GridColumnIDMetaDataTextBoxColumn
        Inherits MetaDataTextBoxColumn
        Implements IMetaIDColumn

        Public Function GetPropertyStore(pID As Integer?) As RadPropertyStore Implements IMetaIDColumn.GetPropertyStore
            Dim zStore As New MetaPropertyStore(Me)

            If IsNumeric(pID.Value) Then
                zStore.ID = pID

                Dim zMeta As rowTblMetaGridColumn = MetaData.GridColumns.Find(Function(x) x.colFldId = pID)

                If Not IsNothing(zMeta) Then
                    Dim zPropInfo As Reflection.PropertyInfo() = zMeta.GetType.GetProperties()
                    zPropInfo.ToList.ForEach(Sub(x) zStore.Add(New MetaPropertyStoreItem(x.DeclaringType, x.Name, x.GetValue(zMeta), zMeta, "Report Meta")))
                Else
                    zStore.Add(New PropertyStoreItem(Type.GetType("System.String"), "No Properties", Nothing, "", "", True))
                End If

            Else
                zStore.Add(New PropertyStoreItem(Type.GetType("System.String"), "No Properties", Nothing, "", "", True))
            End If

            Return zStore
        End Function

        Public Function ColumnBackColor() As Drawing.Color Implements IMetaIDColumn.ColumnBackColor
            Return Drawing.Color.LightCoral
        End Function
    End Class

    Public Class ChartIDMetaDataTextBoxColumn
        Inherits MetaDataTextBoxColumn
        Implements IMetaIDColumn

        Public Function GetPropertyStore(pID As Integer?) As RadPropertyStore Implements IMetaIDColumn.GetPropertyStore
            Dim zStore As New MetaPropertyStore(Me)
            If IsNumeric(pID.Value) Then
                zStore.ID = pID
                Dim zMeta As rowTblMetaChart = MetaData.Charts.Find(Function(x) x.colFldId = pID)

                If Not IsNothing(zMeta) Then
                    Dim zPropInfo As Reflection.PropertyInfo() = zMeta.GetType.GetProperties()
                    zPropInfo.ToList.ForEach(Sub(x) zStore.Add(New MetaPropertyStoreItem(x.DeclaringType, x.Name, x.GetValue(zMeta), zMeta, "Report Meta")))
                Else
                    zStore.Add(New PropertyStoreItem(Type.GetType("System.String"), "No Properties", Nothing, "", "", True))
                End If

            Else
                zStore.Add(New PropertyStoreItem(Type.GetType("System.String"), "No Properties", Nothing, "", "", True))
            End If

            Return zStore
        End Function

        Public Function ColumnBackColor() As Drawing.Color Implements IMetaIDColumn.ColumnBackColor
            Return Drawing.Color.LightPink
        End Function
    End Class

    Public Class ChartSeriesIDMetaDataTextBoxColumn
        Inherits MetaDataTextBoxColumn
        Implements IMetaIDColumn

        Public Function GetPropertyStore(pID As Integer?) As RadPropertyStore Implements IMetaIDColumn.GetPropertyStore
            Dim zStore As New MetaPropertyStore(Me)
            If IsNumeric(pID.Value) Then
                zStore.ID = pID
                Dim zMeta As rowTblMetaChartSeries = MetaData.ChartSeries.Find(Function(x) x.colFldId = pID)

                If Not IsNothing(zMeta) Then
                    Dim zPropInfo As Reflection.PropertyInfo() = zMeta.GetType.GetProperties()
                    zPropInfo.ToList.ForEach(Sub(x) zStore.Add(New MetaPropertyStoreItem(x.DeclaringType, x.Name, x.GetValue(zMeta), zMeta, "Report Meta")))
                Else
                    zStore.Add(New PropertyStoreItem(Type.GetType("System.String"), "No Properties", Nothing, "", "", True))
                End If

            Else
                zStore.Add(New PropertyStoreItem(Type.GetType("System.String"), "No Properties", Nothing, "", "", True))
            End If

            Return zStore
        End Function

        Public Function ColumnBackColor() As Drawing.Color Implements IMetaIDColumn.ColumnBackColor
            Return Drawing.Color.LightYellow
        End Function
    End Class

    Public Class ChartSeriesDetailIDMetaDataTextBoxColumn
        Inherits MetaDataTextBoxColumn
        Implements IMetaIDColumn

        Public Function GetPropertyStore(pID As Integer?) As RadPropertyStore Implements IMetaIDColumn.GetPropertyStore
            Dim zStore As New MetaPropertyStore(Me)
            If IsNumeric(pID.Value) Then
                zStore.ID = pID
                Dim zMeta As rowTblMetaChartSeriesDetail = MetaData.ChartSeriesDetails.Find(Function(x) x.colFldId = pID)
                If Not IsNothing(zMeta) Then
                    Dim zPropInfo As Reflection.PropertyInfo() = zMeta.GetType.GetProperties()
                    zPropInfo.ToList.ForEach(Sub(x) zStore.Add(New MetaPropertyStoreItem(x.DeclaringType, x.Name, x.GetValue(zMeta), zMeta, "Report Meta")))
                Else
                    zStore.Add(New PropertyStoreItem(Type.GetType("System.String"), "No Properties", Nothing, "", "", True))
                End If

            Else
                zStore.Add(New PropertyStoreItem(Type.GetType("System.String"), "No Properties", Nothing, "", "", True))
            End If

            Return zStore
        End Function

        Public Function ColumnBackColor() As Drawing.Color Implements IMetaIDColumn.ColumnBackColor
            Return Drawing.Color.LightSkyBlue
        End Function
    End Class

    Public Class NavLinkIDMetaDataTextBoxColumn
        Inherits MetaDataTextBoxColumn
        Implements IMetaIDColumn

        Public Function GetPropertyStore(pID As Integer?) As RadPropertyStore Implements IMetaIDColumn.GetPropertyStore
            Dim zStore As New MetaPropertyStore(Me)

            If IsNumeric(pID.Value) Then
                zStore.ID = pID

                Dim zMeta As rowTblNavLink = MetaData.Navlink.Find(Function(x) x.colNavLinkId = pID)
                If Not IsNothing(zMeta) Then
                    Dim zPropInfo As Reflection.PropertyInfo() = zMeta.GetType.GetProperties()
                    zPropInfo.ToList.ForEach(Sub(x) zStore.Add(New MetaPropertyStoreItem(x.DeclaringType, x.Name, x.GetValue(zMeta), zMeta, "NavLink Meta")))
                Else
                    zStore.Add(New PropertyStoreItem(Type.GetType("System.String"), "No Properties", Nothing, "", "", True))
                End If

            Else
                zStore.Add(New PropertyStoreItem(Type.GetType("System.String"), "No Properties", Nothing, "", "", True))
            End If

            Return zStore
        End Function

        Public Function ColumnBackColor() As Drawing.Color Implements IMetaIDColumn.ColumnBackColor

        End Function
    End Class

    Public Class DirectDrillDownIDMetaDataTextBoxColumn
        Inherits MetaDataTextBoxColumn
        Implements IMetaIDColumn

        Public Function GetPropertyStore(pID As Integer?) As RadPropertyStore Implements IMetaIDColumn.GetPropertyStore
            Dim zStore As New RadPropertyStore

            If IsNumeric(pID.Value) Then
                '                zStore.ID = pID

                Dim zMeta As rowTblMetaProgramStatus = MetaData.ProgramStatus.Find(Function(x) x.colFldDirectId = pID)
                If Not IsNothing(zMeta) Then
                    Dim zPropInfo As Reflection.PropertyInfo() = zMeta.GetType.GetProperties()
                    zPropInfo.ToList.ForEach(Sub(x) zStore.Add(New MetaPropertyStoreItem(x.DeclaringType, x.Name, x.GetValue(zMeta), zMeta, "Program Status Meta")))
                Else
                    zStore.Add(New PropertyStoreItem(Type.GetType("System.String"), "No Properties", Nothing, "", "", True))
                End If

            Else
                zStore.Add(New PropertyStoreItem(Type.GetType("System.String"), "No Properties", Nothing, "", "", True))
            End If

            Return zStore
        End Function

        Public Function ColumnBackColor() As Drawing.Color Implements IMetaIDColumn.ColumnBackColor
            Return Drawing.Color.LightSkyBlue
        End Function

        Public Overrides Sub SetNewRowDefaultValues(pNewRow As GridViewNewRowInfo, pOldRow As GridViewRowInfo)
            If TypeOf pOldRow.DataBoundItem Is rowTblMetaProgramStatus Then
                pNewRow.Cells(rowTblMetaProgramStatus.FieldIndex.colFldDirectId.ToString).Value = MetaData.ProgramStatus.Max(Function(x) x.colFldDirectId) + 1
            End If
        End Sub
    End Class

    Public Class CopyRowCommandButtonColumn
        Inherits Telerik.WinControls.UI.GridViewCommandColumn

        Public Sub New()
            Me.DefaultText = "Copy Row"
            Me.UseDefaultText = True
        End Sub

        Public Sub CopyRow(pRow As GridViewDataRowInfo)

            Dim zNewRow As GridViewNewRowInfo = pRow.ViewInfo.TableAddNewRow

            For Each zCell As GridViewCellInfo In pRow.Cells
                If Not TypeOf zCell.ColumnInfo Is CopyRowCommandButtonColumn Then
                    zNewRow.Cells(zCell.ColumnInfo.Name).Value = zCell.Value
                End If
            Next
            pRow.ViewInfo.CurrentRow = zNewRow
        End Sub

    End Class

End Namespace

