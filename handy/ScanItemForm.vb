Public Class ScanItemForm

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BcodeTextBox.KeyDown
        Select Case e.KeyCode
            Case Keys.F1

            Case Keys.F2
                test()
            Case Keys.F3
                F3()
            Case Keys.F4
                F4()
        End Select
    End Sub

    Private Sub ClientPibox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ClientPibox.Paint
        printPictureBox.show_imag(ClientImg, ClientPibox)
    End Sub

    Private Sub CodePibox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles CodePibox.Paint
        printPictureBox.show_imag(CodeImg, CodePibox)
    End Sub

    Private Sub ScanItemForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm(Me)
        BcodeTextBox.Focus()
    End Sub

    Private Sub Fkye_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles F1Pibox.Paint, F2Pibox.Paint, F3Pibox.Paint, F4Pibox.Paint
        Select Case CType(sender, PictureBox).Name
            Case F1Pibox.Name
                printPictureBox.get_F1_imag(F1Pibox, False)
            Case F2Pibox.Name
                printPictureBox.get_F2_imag(F2Pibox, False)
            Case F3Pibox.Name
                printPictureBox.show_imag(BoxImg, sender)
            Case F4Pibox.Name
                printPictureBox.get_F4_imag(F4Pibox, 0)
        End Select
    End Sub

    Private Sub Pibox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F1Pibox.Click, F2Pibox.Click, F3Pibox.Click, F4Pibox.Click
        Select Case CType(sender, PictureBox).Name
            Case F1Pibox.Name

            Case F2Pibox.Name

            Case F3Pibox.Name
                F3()
            Case F4Pibox.Name
                F4()
        End Select
    End Sub

    Private Sub test()
        ResultForm.shopLabel.Text = ClientName
        ResultForm.shipmentLabel.Text = shipmentNo
        ResultForm.TextBox1.Text = ""
        ResultForm.Show()
        Me.Hide()
    End Sub

    Private Sub F3()
        Dim frm As Form = New IncompleteForm()
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub F4()
        If popUpClass.PopUp_Yes_No() = DialogResult.Yes AndAlso ApiControlClass.ChangeShipment(shipmentNo, Convert.ToString(ApiConfig.OrderStatusNO.mikenpinn)) Then
            activeform = 20
            CodeForm.Show()
            Me.Hide()
        End If
    End Sub
End Class