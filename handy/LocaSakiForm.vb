Public Class LocaSakiForm
    Private Sub LocaSakiForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                F1()
            Case Keys.F2
                F2()
            Case Keys.F4
                F4()
        End Select
    End Sub

    Private Sub Pibox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F1Pibox.Click, F2Pibox.Click, F3Pibox.Click, F4Pibox.Click
        Select Case CType(sender, PictureBox).Name
            Case F1Pibox.Name
                F1()
            Case F2Pibox.Name
            Case F3Pibox.Name
            Case F4Pibox.Name
                F4()
        End Select
    End Sub

    Private Sub Fkye_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles F1Pibox.Paint, F2Pibox.Paint, F3Pibox.Paint, F4Pibox.Paint
        Dim pi_box As PictureBox = sender
        Select Case pi_box.Name
            Case F1Pibox.Name
                printPictureBox.get_F1_imag(F1Pibox)
            Case F2Pibox.Name
                printPictureBox.get_F2_imag(F2Pibox, False)
            Case F3Pibox.Name
                printPictureBox.Fkye_none(F3Pibox)
            Case F4Pibox.Name
                printPictureBox.get_F4_imag(F4Pibox, 0)
        End Select
    End Sub

    Private Sub LocaSakiForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm(Me)
    End Sub

    Private Sub F1()
        If popUpClass.PopUp_Yes_No("数量を変更しますか？") = DialogResult.Yes Then
            activeform = 41
            LocaItemForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub F2()
        My.Forms.LocaItemForm.ItemClear()
        activeform = 40
        LocaMotoForm.Show()
        Me.Hide()
    End Sub

    Private Sub F4()
        If popUpClass.PopUp_Yes_No() = DialogResult.Yes Then
            activeform = 40
            LocaMotoForm.Show()
            Me.Hide()
        End If
    End Sub
End Class