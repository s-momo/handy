Public Class NyuukaCode

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
                printPictureBox.get_F4_imag(F4Pibox, 2)
        End Select
    End Sub

    Private Sub ClientPibox_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ClientPibox.Paint
        printPictureBox.show_imag(ClientImg, ClientPibox)
    End Sub

    Private Sub CodeTextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles CodeTextBox.GotFocus
        InputHaneisuu()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles CodeTextBox.KeyDown
        Select Case e.KeyCode
            Case Keys.F1

            Case Keys.F3
                cp(Me.Name)
            Case Keys.F4
                F4()
        End Select
    End Sub

    Private Sub NyuukaCode_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Dim mode As UInt32
        Bt.SysLib.Display.btGetKeyCharacter(mode)
        If mode <> Bt.LibDef.BT_KEYINPUT_HANEISUU Then
            InputHaneisuu()
        End If
    End Sub

    Private Sub NyuukaCode_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load, MyBase.Resize
        LoadForm(Me)
        CodeTextBox.Focus()
    End Sub

    Private Sub F4()
        ScanDisableKeySense()
        activeform = 0
        menuForm.Show()
        Me.Hide()
    End Sub
End Class