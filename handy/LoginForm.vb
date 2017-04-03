 Public Class LoginForm
    Private Sub PictureBox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint
        printPictureBox.show_imag(IdImg, PictureBox1)
    End Sub

    Private Sub LoginForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                If ApiControlClass.GetStaff("444") Then
                    activeform = 0
                    Me.Close()
                End If
            Case Keys.F3
                cp(Me.Name)
            Case Keys.F4
                F4()
        End Select
    End Sub
    Private Sub LoginForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm(Me)
    End Sub

    Private Sub Fkye_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles F1Pibox.Paint, F2Pibox.Paint, F3Pibox.Paint, F4Pibox.Paint
        Select Case CType(sender, PictureBox).Name
            Case F1Pibox.Name
                printPictureBox.get_F1_imag(F1Pibox, False)
            Case F2Pibox.Name
                printPictureBox.get_F2_imag(F2Pibox, False)
            Case F3Pibox.Name
                printPictureBox.Fkye_none(F3Pibox)
            Case F4Pibox.Name
                printPictureBox.get_F4_imag(F4Pibox, 2)
        End Select
    End Sub

    Private Sub F4Pibox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F4Pibox.Click
        F4()
    End Sub

    Private Sub F4()
        activeform = 0
        Me.Close()
    End Sub
End Class
