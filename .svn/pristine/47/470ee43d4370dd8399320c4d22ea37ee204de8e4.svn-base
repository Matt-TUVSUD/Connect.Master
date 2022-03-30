Public Class UtilRecMeta

    Dim RecStatuses As New TblMetaRecStatusCollection
    Dim RecIAs As New TblMetaRecIntendedActionCollection
    Dim RecTypePairs As New VwMetaRecTypePairCollection
    Dim RecImpacts As New TblMetaRecImpactCollection

    Public Sub New()
        RecStatuses.LoadAll()

        Dim q As TblMetaRecIntendedActionQuery = New TblMetaRecIntendedActionQuery("x")
        q.SelectAll()
        q.Where("FldAction IS NOT NULL")
        RecIAs.Load(q)

        LoadRecTypePairs()
        RecImpacts.LoadAll()
    End Sub

    Public Sub Dispose()
        RecStatuses.Dispose()
        RecIAs.Dispose()
        RecTypePairs.Dispose()
        RecImpacts.Dispose()
    End Sub

    Private Sub LoadRecTypePairs()
        Dim qry As New VwMetaRecTypePairQuery("a")
        qry.SelectAll()
        qry.Where(qry.LanguageId = 1)
        RecTypePairs.Load(qry)
    End Sub


    Public Sub SetIds(o As EntitySpaces.Core.esEntity, result As ImportTableResult, info As ImportTableInfo)

        If TypeOf o Is FireRecommendations Then

            Dim x = DirectCast(o, FireRecommendations)

            x.RecCategoryId = GetRecCategoryId(x.RecYear, x.RecNumber, x.RecCategory, result)
            x.RecStatusId = GetRecStatusId(x.RecYear, x.RecNumber, x.RecStatus, result)
            x.IntendedActionId = GetIntendedActionId(x.RecYear, x.RecNumber, x.IntendedAction, result)

            Dim pair As RecTypePair = GetRecTypes(x.RecYear, x.RecNumber, x.PrimaryRecType.ToLower.Trim(), x.SecondaryRecType.ToLower.Trim(), result, info)
            x.PrimaryRecTypeId = pair.PrimaryRecTypeId
            x.SecondaryRecTypeId = pair.SecondaryRecTypeId

        End If


        If TypeOf o Is BMRecommendations Then

            Dim x = DirectCast(o, BMRecommendations)

            x.RecCategoryId = GetRecCategoryId(x.RecYear, x.RecNumber, x.RecCategory, result)
            x.RecStatusId = GetRecStatusId(x.RecYear, x.RecNumber, x.RecStatus, result)
            x.IntendedActionId = GetIntendedActionId(x.RecYear, x.RecNumber, x.IntendedAction, result)

            Dim pair As RecTypePair = GetRecTypes(x.RecYear, x.RecNumber, x.PrimaryRecType.ToLower.Trim(), x.SecondaryRecType.ToLower.Trim(), result, info)
            x.PrimaryRecTypeId = pair.PrimaryRecTypeId
            x.SecondaryRecTypeId = pair.SecondaryRecTypeId

        End If

        If TypeOf o Is PSRecommendations Then

            Dim x = DirectCast(o, PSRecommendations)

            x.RecCategoryId = GetRecCategoryId(x.RecYear, x.RecNumber, x.RecCategory, result)
            x.RecStatusId = GetRecStatusId(x.RecYear, x.RecNumber, x.RecStatus, result)
            x.IntendedActionId = GetIntendedActionId(x.RecYear, x.RecNumber, x.IntendedAction, result)

            Dim pair As RecTypePair = GetRecTypes(x.RecYear, x.RecNumber, x.PrimaryRecType.ToLower.Trim(), x.SecondaryRecType.ToLower.Trim(), result, info)
            x.PrimaryRecTypeId = pair.PrimaryRecTypeId
            x.SecondaryRecTypeId = pair.SecondaryRecTypeId

        End If

    End Sub

    Public Function GetIntendedActionId(recYear As String, recNumber As String, intendedAction As String, result As ImportTableResult) As Integer?

        Dim ia As TblMetaRecIntendedAction = RecIAs.Where(Function(x) x.FldAction.ToLower = intendedAction.ToLower).FirstOrDefault()

        If IsNothing(ia) Then
            result.ErrorList.Add(New ValidationError(ValidationError.ValidationErrorType.InvalidIntendedAction, New Dictionary(Of String, Object) From {{"RecYear", recYear}, {"RecNumber", recNumber}, {"Intended Action", intendedAction}}))
            Return Nothing
        Else
            Return ia.FldId
        End If

    End Function

    Private Function GetRecStatusId(recYear As String, recNumber As String, recStatus As String, result As ImportTableResult) As Integer?

        Dim rs As TblMetaRecStatus = RecStatuses.Where(Function(x) x.FldStatus.ToLower = recStatus.ToLower).FirstOrDefault()

        If IsNothing(rs) Then
            result.ErrorList.Add(New ValidationError(ValidationError.ValidationErrorType.InvalidRecStatus, New Dictionary(Of String, Object) From {{"RecYear", recYear}, {"RecNumber", recNumber}, {"Rec Status", recStatus}}))
            Return Nothing
        Else
            Return rs.FldId
        End If
    End Function

    Private Function GetRecTypes(recYear As String, recNumber As String, primaryType As String, secondaryType As String, result As ImportTableResult, info As ImportTableInfo) As RecTypePair?

        Dim practiceId As Integer? = CInt(info.MetaPractice)

        Dim rt As VwMetaRecTypePair = RecTypePairs.Where(Function(x) x.PrimaryRecType.ToLower = primaryType.ToLower And x.SecondaryRecType.ToLower = secondaryType.ToLower And x.PracticeId = practiceId And x.IsImportable = True).FirstOrDefault()

        If IsNothing(rt) Then

            result.ErrorList.Add(New ValidationError(ValidationError.ValidationErrorType.InvalidPrimarySecondaryTypes, New Dictionary(Of String, Object) From {{"RecYear", recYear}, {"RecNumber", recNumber}, {"Primary Rec Type", primaryType}, {"Secondary Rec Type", secondaryType}}))
            Return New RecTypePair
        Else
            Return New RecTypePair(rt.PrimaryRecTypeId, rt.SecondaryRecTypeId)
        End If

    End Function

    Private Function GetRecCategoryId(recYear As String, recNumber As String, recImpact As String, result As ImportTableResult) As Integer?

        Dim ri As TblMetaRecImpact = RecImpacts.Where(Function(x) x.FldImpact.ToLower = recImpact.ToLower).FirstOrDefault()

        If IsNothing(ri) Then
            result.ErrorList.Add(New ValidationError(ValidationError.ValidationErrorType.InvalidRecategory, New Dictionary(Of String, Object) From {{"RecYear", recYear}, {"RecNumber", recNumber}, {"Rec Category/Impact", recImpact}}))
            Return Nothing
        Else
            Return ri.FldId
        End If

    End Function

    Private Sub AddNewPair(primaryType As String, secondaryType As String, metaPractice As UtilMetaPractice.Practices)

        Dim recTypes As New TblMetaRecTypeCollection
        recTypes.LoadAll()

        Dim ptype As TblMetaRecType = recTypes.Where(Function(x) x.FldType.ToLower = primaryType.ToLower).FirstOrDefault()
        Dim sType As TblMetaRecType = recTypes.Where(Function(x) x.FldType.ToLower = secondaryType.ToLower).FirstOrDefault()

        If IsNothing(ptype) And IsNothing(sType) Then

            Dim p As New TblMetaRecType
            p.FldType = primaryType
            p.Save()

            Dim s As New TblMetaRecType
            s.FldType = secondaryType
            s.Save()

            Dim pair As New TblMetaRecTypePair
            pair.FldPrimaryRecTypeId = p.FldId
            pair.FldSecondaryRecTypeId = s.FldId
            pair.Save()

            Dim pairPractice As New TblMetaRecTypePairPractice
            pairPractice.FldPrimaryRecTypeId = p.FldId
            pairPractice.FldSecondaryRecTypeId = s.FldId
            pairPractice.FldPracticeId = CInt(metaPractice)
            pairPractice.FldIsImportable = False
            pairPractice.Save()

        ElseIf IsNothing(ptype) Then

            Dim p As New TblMetaRecType
            p.FldType = primaryType
            p.Save()

            Dim pair As New TblMetaRecTypePair
            pair.FldPrimaryRecTypeId = p.FldId
            pair.FldSecondaryRecTypeId = sType.FldId
            pair.Save()

            Dim pairPractice As New TblMetaRecTypePairPractice
            pairPractice.FldPrimaryRecTypeId = p.FldId
            pairPractice.FldSecondaryRecTypeId = sType.FldId
            pairPractice.FldPracticeId = CInt(metaPractice)
            pairPractice.FldIsImportable = False
            pairPractice.Save()


        Else

            Dim s As New TblMetaRecType
            s.FldType = secondaryType
            s.Save()

            Dim pair As New TblMetaRecTypePair
            pair.FldPrimaryRecTypeId = ptype.FldId
            pair.FldSecondaryRecTypeId = s.FldId
            pair.Save()

            Dim pairPractice As New TblMetaRecTypePairPractice
            pairPractice.FldPrimaryRecTypeId = ptype.FldId
            pairPractice.FldSecondaryRecTypeId = s.FldId
            pairPractice.FldPracticeId = CInt(metaPractice)
            pairPractice.FldIsImportable = False
            pairPractice.Save()

        End If
    End Sub


    Private Structure RecTypePair

        Public Property PrimaryRecTypeId As Integer?

        Public Property SecondaryRecTypeId As Integer?

        Public Sub New(primaryId As Integer, secondaryId As Integer)
            PrimaryRecTypeId = primaryId
            SecondaryRecTypeId = secondaryId
        End Sub

    End Structure

End Class
