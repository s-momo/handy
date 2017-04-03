Public Class IncompleteForm
    Private max As Integer
    Private num As Integer

    Private Sub IncompleteForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                F1()
            Case Keys.F2
                F2()
            Case Keys.F3
            Case Keys.F4
                F4()
        End Select
    End Sub

    Private Sub IncompleteForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm(Me)
        shipmentLabel.Text = shipmentNo
        max = itemCountArray.Count
        num = 1
        ItemCountDisp(num)
        ItemDisp(itemCountArray(num - 1))
    End Sub

    Private Sub F4Button_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F4Button.Click
        F4()
    End Sub

    Private Sub CodePibox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles CodePibox.Paint
        printPictureBox.show_imag(CodeImg, CodePibox)
    End Sub

    Private Sub Fkye_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles F1Pibox.Paint, F2Pibox.Paint, F3Pibox.Paint, F4Pibox.Paint
        Dim flg As Boolean
        Select Case CType(sender, PictureBox).Name
            Case F1Pibox.Name
                If num = 1 Then
                    flg = False
                Else
                    flg = True
                End If
                printPictureBox.get_F1_imag(F1Pibox, flg)
            Case F2Pibox.Name
                If num = max Then
                    flg = False
                Else
                    flg = True
                End If
                printPictureBox.get_F2_imag(F2Pibox, flg)
            Case F3Pibox.Name
                printPictureBox.Fkye_none(F3Pibox)
            Case F4Pibox.Name
                printPictureBox.get_F4_imag(F4Pibox, 0)
        End Select
    End Sub
 
    Private Sub ItemDisp(ByVal Item As itemCount)
        CodeLabel.Text = Item.bcode
        ItemLabel.Text = Item.gname
        If Item.suu <> Item.zitu_suu Then
            KenpinSuuLabel.ForeColor = Color.Red
        Else
            KenpinSuuLabel.ForeColor = Color.Black
        End If
        KenpinSuuLabel.Text = Convert.ToInt32(Item.zitu_suu)
        ShukkaSuuLabel.Text = Convert.ToInt32(Item.suu)
    End Sub

    Private Sub ItemCountDisp(ByVal i As Integer)
        ItemCountLabel.Text = Convert.ToString(i) & "/" & Convert.ToString(max)
    End Sub

    Private Sub F1()
        If num <> 1 Then
            num -= 1
            ItemDisp(itemCountArray(num - 1))
            ItemCountDisp(num)
            F1Pibox.Invalidate()
            F2Pibox.Invalidate()
        End If
    End Sub

    Private Sub F2()
        If num < max Then
            num += 1
            ItemDisp(itemCountArray(num - 1))
            ItemCountDisp(num)
            F1Pibox.Invalidate()
            F2Pibox.Invalidate()
        End If
    End Sub

    Private Sub F4()
        If ScanMode Then
            ScanItemForm.Show()
            Me.Close()
        Else
            ItemForm.Show()
            Me.Close()
        End If
    End Sub
End Class