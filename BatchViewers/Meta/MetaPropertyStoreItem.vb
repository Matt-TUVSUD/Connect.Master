Namespace Meta
    Public Class MetaPropertyStoreItem
        Inherits Telerik.WinControls.UI.PropertyStoreItem

        Private _DataObject As Object

        Sub New(pPropertyType As System.Type, pPropertyName As String, pValue As Object, pDataObject As Object, pCategory As String, Optional pOwner As Telerik.WinControls.UI.RadPropertyStore = Nothing)
            MyBase.New(pPropertyType, pPropertyName, pValue)
            _DataObject = pDataObject
            Me.Category = pCategory
            Me.ReadOnly = False
            Me.Owner = pOwner
        End Sub

        Private Sub MetaPropertyStoreItem_PropertyChanged(sender As Object, e As ComponentModel.PropertyChangedEventArgs) Handles Me.PropertyChanged
            If e.PropertyName <> "Owner" And e.PropertyName <> "Category" Then
                Dim zTable As Type = _DataObject.GetTableType()
                _DataObject.GetType.GetProperty(Me.PropertyName).SetValue(_DataObject, Me.Value)
                zTable.InvokeMember("Save", Reflection.BindingFlags.Public Or Reflection.BindingFlags.InvokeMethod Or Reflection.BindingFlags.Static, Nothing, Nothing, New Object() {_DataObject})
            End If
        End Sub

    End Class

    Public Class MetaPropertyStore
        Inherits Telerik.WinControls.UI.RadPropertyStore

        Public MetaColumn As IMetaIDColumn
        Public ID As Integer?

        Public Sub RefreshStoreItems()
            Me.Clear()
            Me.AddRange(MetaColumn.GetPropertyStore(ID))
        End Sub

        Public Sub New(pColumn As IMetaIDColumn)
            MetaColumn = pColumn
            AddHandler Me.ItemValueChanged, AddressOf ItemValueChangedHandler
        End Sub

        Public Sub ItemValueChangedHandler(sender As Object, e As Telerik.WinControls.UI.PropertyStoreItemValueChangedEventArgs)
            Dim zTemplate As Telerik.WinControls.UI.GridViewTemplate = DirectCast(MetaColumn, Telerik.WinControls.UI.GridViewColumn).OwnerTemplate
            zTemplate.Refresh()
        End Sub

    End Class
End Namespace

