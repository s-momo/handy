Public Class ItemForm

    Private Sub ItemForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm(Me)
        TextBoxClear(BcodeTextBox, IriTextBox, HakoTextBox, BaraTextBox)
        ThreeTextBoxEnable(False)
        BcodeTextBox.Focus()
    End Sub

    Private Sub BcodeTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles BcodeTextBox.GotFocus
        InputHaneisuu()
    End Sub

    Private Sub BcodeTextBox_KeyDown1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BcodeTextBox.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                ScanDisableKeySense()
                NextForm()
            Case Keys.F3
                Dim frm As Form = New IncompleteForm()
                frm.Show()
                Me.Hide()
            Case Keys.F4
                If popUpClass.PopUp_Yes_No = DialogResult.Yes AndAlso ApiControlClass.ChangeShipment(shipmentNo, Convert.ToString(ApiConfig.OrderStatusNO.mikenpinn)) Then
                    activeform = 20
                    CodeForm.Show()
                    Me.Hide()
                End If
            Case Keys.Enter
                If BcodeTextBox.TextLength > 0 Then
                    BcodeTextLostFocus(BcodeTextBox.Text)
                End If
        End Select
    End Sub

    Private Sub ClientPibox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ClientPibox.Paint
        printPictureBox.show_imag(ClientImg, ClientPibox)
    End Sub

    Private Sub CodePibox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles CodePibox.Paint
        printPictureBox.show_imag(CodeImg, CodePibox)
    End Sub

    Private Sub Fkye_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles F1Pibox.Paint, F2Pibox.Paint, F3Pibox.Paint, F4Pibox.Paint
        Select Case CType(sender, PictureBox).Name
            Case F1Pibox.Name
                printPictureBox.get_F1_imag(F1Pibox, False)
            Case F2Pibox.Name
                printPictureBox.get_F2_imag(F2Pibox, False)
            Case F3Pibox.Name
                If BcodeTextBox.Enabled Then
                    printPictureBox.show_imag(BoxImg, sender)
                Else
                    printPictureBox.Fkye_none(F3Pibox)
                End If
            Case F4Pibox.Name
                If BcodeTextBox.Enabled Then
                    printPictureBox.get_F4_imag(F4Pibox, 0)
                Else
                    printPictureBox.Fkye_none(F4Pibox)
                End If
        End Select
    End Sub

    Private Sub TextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles IriTextBox.GotFocus, HakoTextBox.GotFocus, BaraTextBox.GotFocus
        InputNumber()
    End Sub

    Private Sub IriTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles IriTextBox.KeyDown
        If e.KeyCode = Keys.Enter And IriTextBox.TextLength > 0 Then
            HakoTextBox.Focus()
        ElseIf e.KeyCode = Keys.Back And IriTextBox.TextLength = 0 Then
            BcodeTextFocus()
        End If
    End Sub

    Private Sub HakoTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles HakoTextBox.KeyDown
        If e.KeyCode = Keys.Enter And HakoTextBox.TextLength > 0 Then
            BaraTextBox.Focus()
        ElseIf e.KeyCode = Keys.Back And HakoTextBox.TextLength = 0 Then
            IriTextBox.Focus()
        End If
    End Sub

    Private Sub BaraTextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BaraTextBox.KeyDown
        If e.KeyCode = Keys.Enter And BaraTextBox.TextLength > 0 Then
            If ShipmentClass.CountUp(BcodeTextBox.Text, Convert.ToInt32(HakoTextBox.Text) * Convert.ToInt32(IriTextBox.Text) + Convert.ToInt32(BaraTextBox.Text)) Then
                BcodeTextFocus()
                NextForm()
            Else
                BcodeTextFocus()
            End If
        ElseIf e.KeyCode = Keys.Back And BaraTextBox.TextLength = 0 Then
            HakoTextBox.Focus()
        End If
    End Sub

    Private Sub BcodeTextFocus()
        BcodeTextBox.Enabled = True
        BcodeTextBox.Focus()
        ItemClear()
        ThreeTextBoxEnable(False)
        PiboxInvalidate()
        ScanEnable(True)
    End Sub

    Public Sub BcodeTextLostFocus(ByVal bcode As String)
        If ShipmentClass.GetBcodeToItem(bcode) Then
            BcodeTextBox.Enabled = False
            ThreeTextBoxEnable(True)
            IriTextBox.Focus()
            PiboxInvalidate()
            ScanDisableKeySense()
        End If
    End Sub

    Private Sub ThreeTextBoxEnable(ByVal flg As Boolean)
        TextBoxEnable(flg, IriTextBox, HakoTextBox, BaraTextBox)
    End Sub

    Private Sub AllTextBoxClear()
        TextBoxClear(BcodeTextBox, IriTextBox, HakoTextBox, BaraTextBox)
    End Sub

    Private Sub PiboxInvalidate()
        F3Pibox.Invalidate()
        F4Pibox.Invalidate()
    End Sub

    Private Sub NextForm()
        With ResultForm
            .shopLabel.Text = ClientName
            .shipmentLabel.Text = shipmentNo
            .TextBox1.Text = ""
            .Show()
        End With
        Me.Hide()
    End Sub

    Private Sub ItemClear()
        TextBoxClear(BcodeTextBox, HakoTextBox, IriTextBox, BaraTextBox)
        LabelClear(ItemNameLabel)
    End Sub
End Class