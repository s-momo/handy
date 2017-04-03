Public Class CompForm

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        F2()
    End Sub

    Private Sub ClientPibox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ClientPibox.Paint
        printPictureBox.show_imag(ClientImg, ClientPibox)
    End Sub

    Private Sub CodePibox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles CodePibox.Paint
        printPictureBox.show_imag(CodeImg, CodePibox)
    End Sub

    Private Sub CompForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown, Button1.KeyDown
        Select Case e.KeyCode
            Case Keys.F1

            Case Keys.F2, Keys.Enter
                F2()
            Case Keys.F3

            Case Keys.F4
        End Select
    End Sub

    Private Sub CompForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm(Me)
        Button1.Focus()
    End Sub

    Private Sub Fkye_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles F1Pibox.Paint, F2Pibox.Paint, F3Pibox.Paint, F4Pibox.Paint
        Select Case CType(sender, PictureBox).Name
            Case F1Pibox.Name
                printPictureBox.get_F1_imag(F1Pibox, False)
            Case F2Pibox.Name
                printPictureBox.get_F2_imag(F2Pibox)
            Case F3Pibox.Name
                printPictureBox.Fkye_none(sender)
            Case F4Pibox.Name
                printPictureBox.Fkye_none(sender)
        End Select
    End Sub

    Private Sub Pibox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F1Pibox.Click, F2Pibox.Click, F3Pibox.Click, F4Pibox.Click
        Select Case CType(sender, PictureBox).Name
            Case F1Pibox.Name

            Case F2Pibox.Name
                F2()
            Case F3Pibox.Name

            Case F4Pibox.Name
        End Select
    End Sub

    Private Sub F2()
        performance += 1
        ShipmentClear()
        CodeForm.ZissekiSuuLabelLabel.Text = CType(performance, String) & "件"
        activeform = 20
        ScanEnable(True)
        CodeForm.Show()
        Me.Hide()
    End Sub
End Class