Public Class ShipmentClass
    Public Shared total As Integer = 0

    Public Shared Function CountUp(ByVal bcode As String, ByVal suu As Integer) As Boolean
        Dim item As New itemCount
        If GetItem(bcode, item) Then
            If item.suu >= suu + item.zitu_suu Then
                item.zitu_suu += suu
                If ScanMode Then
                    LabelDispScanItem(item)
                Else
                    SuuLabelCountUp(suu)
                End If
                If item.suu = item.zitu_suu Then
                    Return CheckComplete()
                End If
            Else
                popUpClass.popUpError("数量が多すぎます")
                Return False
            End If
        Else
            Return False
        End If
    End Function

    Public Shared Function GetMaxSuu() As Integer
        Dim ii As Integer = 0
        For i = 0 To itemCountArray.Count - 1
            Dim item = DirectCast(itemCountArray(i), itemCount)
            ii += item.suu
        Next
        Return ii
    End Function

    Private Shared Function CheckComplete() As Boolean
        For i = 0 To itemCountArray.Count - 1
            Dim item = DirectCast(itemCountArray(i), itemCount)
            If item.suu <> item.zitu_suu Then
                total = 0
                Return False
            End If
            total += item.zitu_suu
        Next
        Return True
    End Function

    Private Shared Function GetItem(ByVal bcode As String, ByRef reitem As itemCount) As Boolean
        For i = 0 To itemCountArray.Count - 1
            Dim item = DirectCast(itemCountArray(i), itemCount)
            If item.bcode = bcode Then
                reitem = item
                Return True
            End If
        Next
        popUpClass.popUpError("商品が有りません")
        Return False
    End Function

    Private Shared Sub LabelDispScanItem(ByVal item As itemCount)
        With My.Forms.ScanItemForm
            .ItemCodeLabel.Text = item.bcode
            .ItemNameLabel.Text = item.gname
            .KenpinSuuLabel.Text = Convert.ToString(Convert.ToInt32(.KenpinSuuLabel.Text) + 1)
        End With
    End Sub

    Private Shared Sub SuuLabelCountUp(ByVal suu As Integer)
        With My.Forms.ItemForm
            .KenpinSuuLabel.Text = Convert.ToString(Convert.ToInt32(.KenpinSuuLabel.Text) + suu)
        End With
    End Sub

    Public Shared Function GetBcodeToItem(ByVal bcode As String) As Boolean
        Dim item As New itemCount
        If GetItem(bcode, item) Then
            LabelDispItem(item, bcode)
            Return True
        End If
        Return False
    End Function

    Private Shared Sub LabelDispItem(ByVal item As itemCount, ByVal bcode As String)
        With My.Forms.ItemForm
            .BcodeTextBox.Text = bcode
            .ItemNameLabel.Text = item.gname
        End With
    End Sub
End Class
