Public Class Items

    Public Shared Function GetItem(ByVal bcode As String) As stockItemClass
        For i = 0 To StockItemArray.Count - 1
            Dim item = DirectCast(StockItemArray(i), stockItemClass)
            If item.bcode = bcode Then Return item
        Next
        Return Nothing
    End Function

End Class
