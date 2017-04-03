Public Class ReturnedGoodsForm

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode

            Case Keys.F2

            Case Keys.F4
                F4()
        End Select
    End Sub

    Private Sub ClientPibox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ClientPibox.Paint
        printPictureBox.show_imag(ClientImg, ClientPibox)
    End Sub

    Private Sub F4Pibox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F4Pibox.Click
        F4()
    End Sub

    Private Sub Fkye_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles F1Pibox.Paint, F2Pibox.Paint, F3Pibox.Paint, F4Pibox.Paint
        Select Case DirectCast(sender, PictureBox).Name
            Case F1Pibox.Name
                printPictureBox.get_F1_imag(F1Pibox, False)
            Case F2Pibox.Name
                printPictureBox.get_F2_imag(F2Pibox, False)
            Case F3Pibox.Name
                printPictureBox.Fkye_none(sender)
            Case F4Pibox.Name
                If IriTextBox.Visible Then
                    printPictureBox.get_F4_imag(F4Pibox, 0)
                Else
                    printPictureBox.get_F4_imag(F4Pibox, 2)
                End If
        End Select
    End Sub

    Private Sub ReturnedGoodsForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm(Me)
        FormClear()
    End Sub

    Private Sub FormClear()
        LabelClearAll()
        TextboxClearAll()
        TextboxVisibleAll(False)
        HelpLabel.Text = "商品をスキャンして下さい"
        F4Pibox.Invalidate()
        Me.Focus()
    End Sub

    Public Sub LabelDisp(ByVal item As stockItemClass)
        CodeLabel.Text = item.code
        BcodeLabel.Text = item.bcode
        NameLabel.Text = item.name
        TextboxVisibleAll(True)
        HelpLabel.Text = "数量を入力して下さい"
        F4Pibox.Invalidate()
        IriTextBox.Focus()
    End Sub

    Private Sub LabelClearAll()
        LabelClear(CodeLabel, BcodeLabel, NameLabel)
    End Sub

    Private Sub LabelVisibleAll(ByVal flg As Boolean)
        IriLabel.Visible = flg
        HakoLabel.Visible = flg
        BaraLabel.Visible = flg
    End Sub

    Private Sub TextboxClearAll()
        TextBoxClear(IriTextBox, HakoTextBox, BaraTextBox)
    End Sub

    Private Sub TextboxVisibleAll(ByVal flg As Boolean)
        IriTextBox.Visible = flg
        HakoTextBox.Visible = flg
        BaraTextBox.Visible = flg
        LabelVisibleAll(flg)
    End Sub

    Private Sub F4()
        FormClear()
        activeform = 0
        ScanDisableKeySense()
        menuForm.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles IriTextBox.GotFocus, HakoTextBox.GotFocus, BaraTextBox.GotFocus
        InputNumber()
    End Sub

    Private Sub TextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles IriTextBox.KeyDown, HakoTextBox.KeyDown, BaraTextBox.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                If DirectCast(sender, TextBox).Text.Length <> 0 Then
                    NextBox(sender)
                End If
            Case Keys.Back
                If DirectCast(sender, TextBox).Text.Length = 0 Then
                    BackBox(sender)
                End If
            Case Keys.F4
                FormClear()
        End Select
    End Sub

    Private Sub NextBox(ByVal box As TextBox)
        Select Case box.Name
            Case IriTextBox.Name
                HakoTextBox.Focus()
            Case HakoTextBox.Name
                BaraTextBox.Focus()
            Case BaraTextBox.Name
                Dim total = SumBox(IriTextBox, HakoTextBox, BaraTextBox)
                If total <> 0 Then
                    popUpClass.PopUpOk(total.ToString)
                    FormClear()
                End If
        End Select
    End Sub

    Private Sub BackBox(ByVal box As TextBox)
        Select Case box.Name
            Case IriTextBox.Name

            Case HakoTextBox.Name
                IriTextBox.Focus()
            Case BaraTextBox.Name
                HakoTextBox.Focus()
        End Select
    End Sub

    Private Function SumBox(ByVal iri As TextBox, ByVal hako As TextBox, ByVal bara As TextBox) As Integer
        If BoxCheck(iri, hako, bara) Then
            Return Convert.ToInt32(iri.Text) * Convert.ToInt32(hako.Text) + Convert.ToInt32(bara.Text)
        End If
        popUpClass.popUpError("値が無効な項目が有ります")
        Return 0
    End Function

    Private Function BoxCheck(ByVal ParamArray Box As TextBox()) As Boolean
        For i = 0 To Box.Count - 1
            If Box(i).Text.Length = 0 Then
                Return False
            End If
        Next
        Return True
    End Function

End Class