Public Class ResultForm

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        InputNumber()
    End Sub
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.F2, Keys.Enter
                F2()
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

    Private Sub ResultForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm(Me)
        TextBox1.Focus()
    End Sub

    Private Sub Fkye_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles F1Pibox.Paint, F2Pibox.Paint, F3Pibox.Paint, F4Pibox.Paint
        Select Case CType(sender, PictureBox).Name
            Case F1Pibox.Name
                printPictureBox.get_F1_imag(F1Pibox, False)
            Case F2Pibox.Name
                If TextBox1.TextLength > 0 Then
                    printPictureBox.get_F2_imag(F2Pibox)
                Else
                    printPictureBox.get_F2_imag(F2Pibox, False)
                End If
            Case F3Pibox.Name
                printPictureBox.Fkye_none(sender)
            Case F4Pibox.Name
                printPictureBox.get_F4_imag(F4Pibox, 0)
        End Select
    End Sub

    Private Sub Pibox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F1Pibox.Click, F2Pibox.Click, F3Pibox.Click, F4Pibox.Click
        Select Case CType(sender, PictureBox).Name
            Case F1Pibox.Name

            Case F2Pibox.Name
                F2()
            Case F3Pibox.Name

            Case F4Pibox.Name
                F4()
        End Select
    End Sub

    Private Sub F2()
        If TextBox1.TextLength > 0 _
        AndAlso CType(TextBox1.Text, Integer) = ShipmentClass.total _
        AndAlso ApiControlClass.ChangeShipment(shipmentNo, Convert.ToString(ApiConfig.OrderStatusNO.kenpin_OK)) Then
            TextBox1.Text = ""
            CompForm.shopLabel.Text = ClientName
            CompForm.shipmentLabel.Text = shipmentNo
            ShipmentClass.total = 0
            CompForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub F4()
        If popUpClass.PopUp_Yes_No("取り消しますか？") = DialogResult.Yes Then
            TextBox1.Text = ""
            activeform = 20
            ScanEnable(True)
            CodeForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        F2Pibox.Invalidate()
    End Sub
End Class