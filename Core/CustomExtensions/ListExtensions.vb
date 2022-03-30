Imports System.Runtime.CompilerServices

Namespace CustomExtensions
    Public Module ListExtensions
        <Extension()>
        Function ToDataTable(ByVal pList As List(Of Object)) As DataTable
            Dim zType As Type = pList(0).GetType
            Dim zFieldInfo As Reflection.FieldInfo() = zType.GetFields
            Dim zDT As New DataTable
            For Each zField As Reflection.FieldInfo In zFieldInfo
                Dim zCol As New DataColumn(zField.Name)
                zDT.Columns.Add(zCol)
            Next

            For Each zItem As Object In pList
                Dim zRow As DataRow = zDT.NewRow
                For Each zField As Reflection.FieldInfo In zFieldInfo
                    zRow(zField.Name) = zField.GetValue(zItem)
                Next
                zDT.Rows.Add(zRow)
            Next
            Return zDT

        End Function

        <Extension()>
        Function ToDataTable(ByVal pList As IList) As DataTable
            Dim zType As Type = pList(0).GetType
            Return CreateDataTable(zType, pList)
        End Function

        Private Function CreateDataTable(pType As Type, pList As IList) As DataTable
            Dim zType As Type = pType
            Dim zFieldInfo As Reflection.FieldInfo() = zType.GetFields
            Dim zDT As New DataTable
            zDT.ExtendedProperties.Add("BaseList", pList)

            For Each zField As Reflection.FieldInfo In zFieldInfo
                Dim zCol As New DataColumn(zField.Name)
                zDT.Columns.Add(zCol)
            Next

            For Each zItem As Object In pList
                Dim zRow As DataRow = zDT.NewRow
                For Each zField As Reflection.FieldInfo In zFieldInfo
                    zRow(zField.Name) = zField.GetValue(zItem)
                Next
                zDT.Rows.Add(zRow)
            Next
            Return zDT

        End Function
    End Module


    Public Class ListExtensionHelper

    End Class
End Namespace

