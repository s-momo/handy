Public Class NyuukoItem

    Public Sub LabelDisp(ByVal item As stockItemClass)
        CodeLabel.Text = item.code
        BcodeLabel.Text = item.bcode
        itemLabel.Text = item.name
        TextboxVisible(True)
        F4Pibox.Invalidate()
        IriBox.Focus()
    End Sub

    Private Sub F4Pibox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F4Pibox.Click
        F4()
    End Sub

    Private Sub Fkye_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles F1Pibox.Paint, F2Pibox.Paint, F3Pibox.Paint, F4Pibox.Paint
        Select Case DirectCast(sender, PictureBox).Name
            Case F1Pibox.Name
                printPictureBox.get_F1_imag(F1Pibox, False)
            Case F2Pibox.Name
                printPictureBox.get_F2_imag(F2Pibox, False)
            Case F3Pibox.Name
                printPictureBox.Fkye_none(F3Pibox)
            Case F4Pibox.Name
                If IriBox.Visible Then
                    printPictureBox.get_F4_imag(F4Pibox, 0)
                Else
                    printPictureBox.get_F4_imag(F4Pibox, 3)
                End If
        End Select
    End Sub

    Private Sub ClientPibox_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ClientPibox.Paint
        printPictureBox.show_imag(ClientImg, ClientPibox)
    End Sub

    Private Sub LabelClearAll()
        LabelClear(CodeLabel, BcodeLabel, itemLabel)
    End Sub

    Private Sub TextBoxClearAll()
        TextBoxClear(IriBox, HakoBox, BaraBox)
    End Sub

    Private Sub TextboxVisible(ByVal flg As Boolean)
        IriBox.Visible = flg
        HakoBox.Visible = flg
        BaraBox.Visible = flg
        IriLabel.Visible = flg
        HakoLabel.Visible = flg
        BaraLabel.Visible = flg
    End Sub

    Private Sub NyuukoItemForm1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                F1()
            Case Keys.F2
                F2()
            Case Keys.F3
                F3()
            Case Keys.F4
                F4()
        End Select
    End Sub

    Private Sub F1()

    End Sub

    Private Sub F2()

    End Sub

    Private Sub F3()
        cp(Me.Name)
    End Sub

    Private Sub F4()
        If IriBox.Visible Then
            FormClear()
        Else
            If popUpClass.PopUp_Yes_No = DialogResult.Yes Then
                activeform = 10
                NyuukaCode.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub NyuukoItem_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm(Me)
        FormClear()
    End Sub

    Private Sub FormClear()
        LabelClearAll()
        TextBoxClearAll()
        TextboxVisible(False)
        F4Pibox.Invalidate()
    End Sub

    Private Sub Box_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles IriBox.GotFocus, HakoBox.GotFocus, BaraBox.GotFocus
        InputNumber()
    End Sub

    Private Sub Box_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles IriBox.KeyDown, HakoBox.KeyDown, BaraBox.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
            Case Keys.F3
                cp(Me.Name & "2")
            Case Keys.F4
                F4()
            Case Keys.Enter
                NextBox(sender)
            Case Keys.Back
                BackBox(sender)
        End Select
    End Sub

    Private Sub NextBox(ByVal box As TextBox)
        If box.Text.Length <> 0 Then
            Select Case box.Name
                Case IriBox.Name
                    HakoBox.Focus()
                Case HakoBox.Name
                    BaraBox.Focus()
                Case BaraBox.Name
                    Dim sum As Integer = BoxSum()
                    If 0 < sum AndAlso popUpClass.PopUp_Yes_No("登録しますか？") = DialogResult.Yes Then popUpClass.PopUpOk(sum.ToString)
            End Select
        End If
    End Sub

    Private Sub BackBox(ByVal box As TextBox)
        If box.Text.Length = 0 Then
            Select Case box.Name
                Case IriBox.Name

                Case HakoBox.Name
                    IriBox.Focus()
                Case BaraBox.Name
                    HakoBox.Focus()
            End Select
        End If
    End Sub

    Private Function BoxSum() As Integer
        Return Convert.ToInt32(IriBox.Text) * Convert.ToInt32(HakoBox.Text) + Convert.ToInt32(BaraBox.Text)
    End Function
End Class