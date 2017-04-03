Public Class NewLocaForm

    Private Sub NewLocaForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm(Me)
        FormReset()
    End Sub

    Private Sub SuuTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles SuuTextBox.GotFocus
        InputNumber()
    End Sub

    Private Sub FormKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles SuuTextBox.KeyDown, MyBase.KeyDown, F1Button.KeyDown, F2Button.KeyDown, F3Button.KeyDown, F4Button.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                LabelDisp(Nothing)
            Case Keys.F3
            Case Keys.Enter
                If SuuTextBox.Visible Then
                    LabelDisp(Nothing)
                End If
            Case Keys.F4
                F4()
        End Select
    End Sub

    Private Sub F4Pibox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F4Pibox.Click
        F4()
    End Sub

    Private Sub ClientPibox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ClientPibox.Paint
        printPictureBox.show_imag(ClientImg, ClientPibox)
    End Sub

    Private Sub Fkye_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles F1Pibox.Paint, F2Pibox.Paint, F3Pibox.Paint, F4Pibox.Paint
        Dim pi_box As PictureBox = sender
        Select Case pi_box.Name
            Case F1Pibox.Name
                printPictureBox.get_F1_imag(F1Pibox, False)
            Case F2Pibox.Name
                printPictureBox.get_F2_imag(F2Pibox, False)
            Case F3Pibox.Name
                printPictureBox.Fkye_none(F3Pibox)
            Case F4Pibox.Name
                If MokuziLocaLabel.Visible = False Then
                    printPictureBox.get_F4_imag(F4Pibox, 2)
                Else
                    printPictureBox.get_F4_imag(F4Pibox, 0)
                End If
        End Select
    End Sub

    Private Sub FormReset()
        labelValueReset()
        LocaLabel.Visible = False
        MokuziLocaLabel.Visible = False
        MokuziSuuLabel.Visible = False
        SuuTextBox.Visible = False
        HelpLabel.Text = "商品をスキャン" & vbCrLf & "してください"
        PiBoxReset()
    End Sub

    Private Sub PiBoxReset()
        F4Pibox.Image = Nothing
    End Sub

    Private Sub labelValueReset()
        LabelClear(ItemCodeLabel, BcodeLabel, ItemLabel, LocaLabel)
        TextBoxClear(SuuTextBox)
    End Sub

    Private Sub ScanCode()
        HelpLabel.Text = "ロケーションをスキャン" & vbCrLf & "してください"
        MokuziLocaLabel.Visible = True
        LocaLabel.Visible = True
        PiBoxReset()
    End Sub

    Private Sub ScanLoca()
        HelpLabel.Text = "数量を入力" & vbCrLf & "してください"
        MokuziSuuLabel.Visible = True
        SuuTextBox.Visible = True
        SuuTextBox.Focus()
    End Sub

    Public Sub LabelDisp(ByVal item As stockItemClass)
        If MokuziLocaLabel.Visible = False Then
            If item Is Nothing Then
                test()
            Else
                LabelText(item)
            End If
            ScanCode()
        ElseIf MokuziSuuLabel.Visible = False Then
            test2()
            ScanLoca()
        ElseIf MokuziSuuLabel.Visible = True Then
            If 0 < SuuTextBox.TextLength Then
                popUpClass.PopUpOk(LocaLabel.Text & "に" & vbCrLf & SuuTextBox.Text & "個登録しました。")
                FormReset()
            End If
        End If
    End Sub

    Private Sub F4()
        If LocaLabel.Visible Then
            If popUpClass.PopUp_Yes_No("キャンセルしますか？") = DialogResult.Yes Then
                FormReset()
            End If
        Else
            If popUpClass.PopUp_Yes_No() = DialogResult.Yes Then
                FormReset()
                activeform = 0
                ScanDisableKeySense()
                menuForm.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub test()
        ItemCodeLabel.Text = "rrrrrrrrrrrrrrr"
        BcodeLabel.Text = "9584784599358"
        ItemLabel.Text = "test商品"
    End Sub

    Private Sub LabelText(ByVal item As stockItemClass)
        ItemCodeLabel.Text = item.code
        BcodeLabel.Text = item.bcode
        ItemLabel.Text = item.name
    End Sub

    Private Sub test2()
        LocaLabel.Text = "ASDFL-8889"
    End Sub

End Class