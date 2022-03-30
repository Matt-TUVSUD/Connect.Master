Public Class UtilTranslation

    Private _FromLang As Language
    Private _ToLang As Language

    Public Sub New(ByVal pFromLanguage As Language, ByVal pToLanguage As Language)
        _FromLang = pFromLanguage
        _ToLang = pToLanguage
    End Sub

    Public Function TranslateLabel(ByVal pValue As String) As String
        Dim zObj As New BusinessObjects.ViewCCTranslation
        Return zObj.Translate(pValue, _FromLang, _ToLang)
    End Function

    Public Function GetLabelTranslationDictionary(ByVal pKey As TranslateKey) As Dictionary(Of String, String)
        Return GetDictionary(TranslateType.AutoRecLabel, pKey)
    End Function

    ''' <summary>
    ''' Returns a dictionary of values
    ''' </summary>
    ''' <param name="pKey">This is the type of key to assign. Applicable only when TranslateObject is AutoRecLabel. When pKey is UseLabelName then the keys in the dictionary are based off of the LabelName.</param>
    ''' <param name="pObj">This is the type of dictionary to create.</param>
    ''' <returns></returns>
    ''' <remarks>By default the key of this dictionary is the actual word of the language to translate from.</remarks>

    Private Function GetDictionary(ByVal pObj As TranslateType, Optional ByVal pKey As TranslateKey = TranslateKey.ByValue) As Dictionary(Of String, String)
        Dim zObj As Object = Nothing

        Select Case pObj
            Case TranslateType.AutoRecLabel
                zObj = New BusinessObjects.ViewCCTranslationQuery

            Case TranslateType.Impact
                zObj = New BusinessObjects.ViewCCTranslationImpactQuery

            Case TranslateType.IntendedAction
                zObj = New BusinessObjects.ViewCCTranslationIntendedActionQuery

            Case TranslateType.PrimaryRecType
                zObj = New BusinessObjects.ViewCCTranslationPrimaryRecQuery

            Case TranslateType.RecStatus
                zObj = New BusinessObjects.ViewCCTranslationRecStatusQuery

            Case TranslateType.SecondaryRecType
                zObj = New BusinessObjects.ViewCCTranslationSecondaryRecQuery

            Case TranslateType.MgmtIntendedAction
                zObj = New BusinessObjects.ViewCCTranslationMgmtIntendedActionQuery

        End Select

        If pObj = TranslateType.AutoRecLabel And pKey = TranslateKey.ByLabelName Then
            zObj.Select(zObj.LabelName).es.Distinct = True
        Else
            zObj.Select(GetTranslationColumn(_FromLang)).es.Distinct = True
        End If

        zObj.Select(GetTranslationColumn(_ToLang)).es.Distinct = True

        Dim zDt As DataTable = zObj.LoadDataTable()
        Dim zDict As New Dictionary(Of String, String)
        For Each zRow As DataRow In zDt.Rows
            Try
                zDict.Add(zRow(0), zRow(1))
            Catch ex As Exception
            End Try

        Next

        Return zDict

    End Function

    Public Function TranslateImpact(ByVal pValue As String) As String
        Dim zObj As New BusinessObjects.ViewCCTranslationImpact
        Return zObj.Translate(pValue, _FromLang, _ToLang)
    End Function

    Public Function GetImpactTranslationDictionary() As Dictionary(Of String, String)
        Return GetDictionary(TranslateType.Impact)
    End Function

    Public Function TranslateIntendedAction(ByVal pValue As String) As String
        Dim zObj As New BusinessObjects.ViewCCTranslationIntendedAction
        Return zObj.Translate(pValue, _FromLang, _ToLang)
    End Function

    Public Function GetIntendedActionTranslationDictionary() As Dictionary(Of String, String)
        Return GetDictionary(TranslateType.IntendedAction)
    End Function

    Public Function TranslatePrimaryRecType(ByVal pValue As String) As String
        Dim zObj As New BusinessObjects.ViewCCTranslationPrimaryRec
        Return zObj.Translate(pValue, _FromLang, _ToLang)
    End Function

    Public Function GetPrimaryRecTranslationDictionary() As Dictionary(Of String, String)
        Return GetDictionary(TranslateType.PrimaryRecType)
    End Function

    Public Function TranslateSecondaryRecType(ByVal pValue As String) As String
        Dim zObj As New BusinessObjects.ViewCCTranslationSecondaryRec
        Return zObj.Translate(pValue, _FromLang, _ToLang)
    End Function

    Public Function GetSecondaryRecTranslationDictionary() As Dictionary(Of String, String)
        Return GetDictionary(TranslateType.SecondaryRecType)
    End Function

    Public Function TranslateRecStatus(ByVal pValue As String) As String
        Dim zObj As New BusinessObjects.ViewCCTranslationRecStatus
        Return zObj.Translate(pValue, _FromLang, _ToLang)
    End Function

    Public Function GetRecStatusTranslationDictionary() As Dictionary(Of String, String)
        Return GetDictionary(TranslateType.RecStatus)
    End Function

    Public Function GetMgmtIntendedActionTranslationDictionary() As Dictionary(Of String, String)
        Return GetDictionary(TranslateType.MgmtIntendedAction)
    End Function


    Public Shared Function GetTranslationColumn(ByVal pLanguage As UtilTranslation.Language) As String
        Select Case pLanguage
            Case Language.English
                Return "EnglishTranslation"

            Case Language.French
                Return "FrenchTranslation"

            Case Language.German
                Return "GermanTranslation"

            Case Language.Italian
                Return "ItalianTranslation"

            Case Language.Portugese
                Return "PortugueseTranslation"

            Case Language.Spanish
                Return "SpanishTranslation"

            Case Else
                Return ""
        End Select
    End Function

    Public Enum Language
        English
        Spanish
        German
        French
        Portugese
        Italian
    End Enum

    Public Enum TranslateKey
        ByLabelName
        ByValue
    End Enum

    Public Enum TranslateType
        Impact
        PrimaryRecType
        SecondaryRecType
        RecStatus
        IntendedAction
        AutoRecLabel
        MgmtIntendedAction
    End Enum

    Public Shared Function TranslateDay(ByVal pToLanguage As Language, ByVal pDay As UtilTranslation.Days) As String
        Dim zDayDict As New Dictionary(Of String, String)

        Select Case pToLanguage

            Case Libraries.CoreLib.UtilTranslation.Language.French
                zDayDict.Add("sunday", "dimanche")
                zDayDict.Add("monday", "lundi")
                zDayDict.Add("tuesday", "mardi")
                zDayDict.Add("wednesday", "mercredi")
                zDayDict.Add("thursday", "jeudi")
                zDayDict.Add("friday", "vendredi")
                zDayDict.Add("saturday", "samedi")

            Case Libraries.CoreLib.UtilTranslation.Language.German
                zDayDict.Add("sunday", "Sonntag")
                zDayDict.Add("monday", "Montag")
                zDayDict.Add("tuesday", "Dienstag")
                zDayDict.Add("wednesday", "Mittwoch")
                zDayDict.Add("thursday", "Donnerstag")
                zDayDict.Add("friday", "Freitag")
                zDayDict.Add("saturday", "Samstag")

            Case Libraries.CoreLib.UtilTranslation.Language.Italian
                zDayDict.Add("sunday", "Domenica")
                zDayDict.Add("monday", "Lunedi")
                zDayDict.Add("tuesday", "Martedì")
                zDayDict.Add("wednesday", "Mercoledì")
                zDayDict.Add("thursday", "Giovedi")
                zDayDict.Add("friday", "Venerdì")
                zDayDict.Add("saturday", "Sabato")

            Case Libraries.CoreLib.UtilTranslation.Language.Portugese
                zDayDict.Add("sunday", "domingo")
                zDayDict.Add("monday", "segunda-feira")
                zDayDict.Add("tuesday", "terça-feira")
                zDayDict.Add("wednesday", "quarta-feira")
                zDayDict.Add("thursday", "quinta-feira")
                zDayDict.Add("friday", "sexta-feira")
                zDayDict.Add("saturday", "sábado")

            Case Libraries.CoreLib.UtilTranslation.Language.Spanish
                zDayDict.Add("sunday", "Domingo")
                zDayDict.Add("monday", "Lunes")
                zDayDict.Add("tuesday", "Martes")
                zDayDict.Add("wednesday", "Miércoles")
                zDayDict.Add("thursday", "Jueves")
                zDayDict.Add("friday", "Viernes")
                zDayDict.Add("saturday", "Sábado")

            Case Else
                zDayDict.Add("sunday", "Sunday")
                zDayDict.Add("monday", "Monday")
                zDayDict.Add("tuesday", "Tuesday")
                zDayDict.Add("wednesday", "Wednesday")
                zDayDict.Add("thursday", "Thursday")
                zDayDict.Add("friday", "Friday")
                zDayDict.Add("saturday", "Saturday")
        End Select

        Dim zTranslatedDay As String = ""
        If zDayDict.TryGetValue(pDay.ToString.ToLower, zTranslatedDay) Then
            If zTranslatedDay IsNot Nothing Then
                Return zTranslatedDay
            Else
                Return ""
            End If
        Else
            Return ""
        End If


    End Function

    Public Shared Function TranslateMonth(ByVal pToLanguage As Language, ByVal pMonth As UtilTranslation.Months) As String
        Dim zMonthDict As New Dictionary(Of String, String)

        Select Case pToLanguage

            Case Libraries.CoreLib.UtilTranslation.Language.French

                zMonthDict.Add("january", "janvier")
                zMonthDict.Add("february", "février")
                zMonthDict.Add("march", "mars")
                zMonthDict.Add("april", "avril")
                zMonthDict.Add("may", "mai")
                zMonthDict.Add("june", "juin")
                zMonthDict.Add("july", "juillet")
                zMonthDict.Add("august", "août")
                zMonthDict.Add("september", "septembre")
                zMonthDict.Add("october", "octobre")
                zMonthDict.Add("november", "novembre")
                zMonthDict.Add("december", "décembre")


            Case Libraries.CoreLib.UtilTranslation.Language.German

                zMonthDict.Add("january", "Januar")
                zMonthDict.Add("february", "Februar")
                zMonthDict.Add("march", "März")
                zMonthDict.Add("april", "april")
                zMonthDict.Add("may", "Mai")
                zMonthDict.Add("june", "Juni")
                zMonthDict.Add("july", "Juli")
                zMonthDict.Add("august", "august")
                zMonthDict.Add("september", "september")
                zMonthDict.Add("october", "Oktober")
                zMonthDict.Add("november", "november")
                zMonthDict.Add("december", "Dezember")

            Case Libraries.CoreLib.UtilTranslation.Language.Italian

                zMonthDict.Add("january", "gennaio")
                zMonthDict.Add("february", "febbraio")
                zMonthDict.Add("march", "marzo")
                zMonthDict.Add("april", "aprile")
                zMonthDict.Add("may", "maggio")
                zMonthDict.Add("june", "giugno")
                zMonthDict.Add("july", "luglio")
                zMonthDict.Add("august", "agosto")
                zMonthDict.Add("september", "settembre")
                zMonthDict.Add("october", "ottobre")
                zMonthDict.Add("november", "novembre")
                zMonthDict.Add("december", "dicembre")

            Case Libraries.CoreLib.UtilTranslation.Language.Portugese

                zMonthDict.Add("january", "janeiro")
                zMonthDict.Add("february", "fevereiro")
                zMonthDict.Add("march", "março")
                zMonthDict.Add("april", "abril")
                zMonthDict.Add("may", "maio")
                zMonthDict.Add("june", "junho")
                zMonthDict.Add("july", "julho")
                zMonthDict.Add("august", "agosto")
                zMonthDict.Add("september", "setembro")
                zMonthDict.Add("october", "outubro")
                zMonthDict.Add("november", "novembro")
                zMonthDict.Add("december", "dezembro")

            Case Libraries.CoreLib.UtilTranslation.Language.Spanish

                zMonthDict.Add("january", "enero")
                zMonthDict.Add("february", "febrero")
                zMonthDict.Add("march", "marzo")
                zMonthDict.Add("april", "abril")
                zMonthDict.Add("may", "mayo")
                zMonthDict.Add("june", "junio")
                zMonthDict.Add("july", "julio")
                zMonthDict.Add("august", "agosto")
                zMonthDict.Add("september", "septiembre")
                zMonthDict.Add("october", "octubre")
                zMonthDict.Add("november", "noviembre")
                zMonthDict.Add("december", "diciembre")

            Case Else

                zMonthDict.Add("january", "January")
                zMonthDict.Add("february", "February")
                zMonthDict.Add("march", "March")
                zMonthDict.Add("april", "April")
                zMonthDict.Add("may", "May")
                zMonthDict.Add("june", "June")
                zMonthDict.Add("july", "July")
                zMonthDict.Add("august", "August")
                zMonthDict.Add("september", "September")
                zMonthDict.Add("october", "October")
                zMonthDict.Add("november", "November")
                zMonthDict.Add("december", "December")

        End Select

        Dim zTranslatedMonth As String = ""
        If zMonthDict.TryGetValue(pMonth.ToString.ToLower, zTranslatedMonth) Then
            If zTranslatedMonth IsNot Nothing Then
                Return zTranslatedMonth
            Else
                Return ""
            End If
        Else
            Return ""
        End If


    End Function

    Public Shared Function TranslateDate(ByVal pToLanguage As Language, ByVal pDate As Date) As String

        Dim zDay As Integer = [Enum].Parse(GetType(Days), Format(pDate, "dddd"))
        Dim zMonth As Integer = [Enum].Parse(GetType(Months), Format(pDate, "MMMM"))
        Dim zTranslatedDay As String = ""
        Dim zTranslatedMonth As String = ""

        Select Case pToLanguage

            Case Libraries.CoreLib.UtilTranslation.Language.French
                zTranslatedDay = TranslateDay(Language.French, zDay)
                zTranslatedMonth = TranslateMonth(Language.French, zMonth)
                Return zTranslatedDay & " " & Day(pDate) & " " & zTranslatedMonth & " " & Year(pDate)

            Case Libraries.CoreLib.UtilTranslation.Language.German
                zTranslatedDay = TranslateDay(Language.German, zDay)
                zTranslatedMonth = TranslateMonth(Language.German, zMonth)
                Return zTranslatedDay & " " & Day(pDate) & ". " & zTranslatedMonth & " " & Year(pDate)


            Case Libraries.CoreLib.UtilTranslation.Language.Italian
                zTranslatedDay = TranslateDay(Language.Italian, zDay)
                zTranslatedMonth = TranslateMonth(Language.Italian, zMonth)
                Return zTranslatedDay & " " & Day(pDate) & " " & zTranslatedMonth & " " & Year(pDate)


            Case Libraries.CoreLib.UtilTranslation.Language.Portugese
                zTranslatedDay = TranslateDay(Language.Portugese, zDay)
                zTranslatedMonth = TranslateMonth(Language.Portugese, zMonth)
                Return zTranslatedDay & " " & Day(pDate) & " de " & zTranslatedMonth & " de " & Year(pDate)


            Case Libraries.CoreLib.UtilTranslation.Language.Spanish
                zTranslatedDay = TranslateDay(Language.Spanish, zDay)
                zTranslatedMonth = TranslateMonth(Language.Spanish, zMonth)
                Return zTranslatedDay & " " & Day(pDate) & " de " & zTranslatedMonth & " " & Year(pDate)

            Case Else

                Return pDate.ToLongDateString

        End Select

    End Function

    Public Enum Months
        January
        February
        March
        April
        May
        June
        July
        August
        September
        October
        November
        December
    End Enum

    Public Enum Days
        Sunday
        Monday
        Tuesday
        Wednesday
        Thursday
        Friday
        Saturday
    End Enum
End Class
