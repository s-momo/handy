Public Class DayForm

    Private Sub DayForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown, Button1.KeyDown
        Select Case e.KeyCode
            Case Keys.F2, Keys.Enter
                next_form()
            Case Keys.F4
                F4()
        End Select
    End Sub

    Private Sub PictureBox1_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ClientPibox.Paint
        printPictureBox.show_imag(ClientImg, ClientPibox)
    End Sub

    Private Sub PictureBox2_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DayPibox.Paint
        printPictureBox.show_imag(Day48Img, DayPibox)
    End Sub

    Private Sub DayForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm(Me)
        Button1.Focus()
    End Sub

    Private Sub Pibox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F1Pibox.Click, F2Pibox.Click, F3Pibox.Click, F4Pibox.Click
        Select Case CType(sender, PictureBox).Name
            Case F1Pibox.Name

            Case F2Pibox.Name
                next_form()
            Case F3Pibox.Name

            Case F4Pibox.Name
                F4()
        End Select
    End Sub

    Private Sub Fkye_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles F1Pibox.Paint, F2Pibox.Paint, F3Pibox.Paint, F4Pibox.Paint
        Select Case CType(sender, PictureBox).Name
            Case F1Pibox.Name
                printPictureBox.get_F1_imag(F1Pibox, False)
            Case F2Pibox.Name
                printPictureBox.get_F2_imag(F2Pibox)
            Case F3Pibox.Name
                printPictureBox.Fkye_none(F3Pibox)
            Case F4Pibox.Name
                printPictureBox.get_F4_imag(F4Pibox, 2)
        End Select
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        next_form()
    End Sub
    Private Sub next_form()
        ScanEnable(True)
        activeform = 20
        CodeForm.ZissekiSuuLabelLabel.Text = CType(performance, String) & "件"
        CodeForm.shopLabel.Text = ClientName
        CodeForm.dayLabel.Text = DateTimePicker1.Value
        CodeForm.Show()
        Me.Hide()
    End Sub

    Private Sub F4()
        ShipmentClearAll()
        activeform = 0
        menuForm.Show()
        Me.Hide()
    End Sub
End Class