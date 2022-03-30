Public Interface IRestResponse

    Property IsSuccess As Boolean
    Property Message As String

End Interface

Public Interface IGridDataRestResponse
    Property GridData As IGridData
End Interface

Public Interface IFormDataRestResponse

End Interface

Public Interface IRatingRestResponse
    Property RatingData As ILocationRating
End Interface

Public Interface IPickListRestResponse
    Property PickList As IPickListData
End Interface


