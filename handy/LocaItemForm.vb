Public Class LocaItemForm

    Private Sub TextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles IriBox.GotFocus, BaraBox.GotFocus, HakoBox.GotFocus
        InputNumber()
    End Sub
    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                If IriBox.Enabled = False Then
                    F1()
                End If
            Case Keys.F2, Keys.Enter
                ItemSelect("1234567890")
                ScanEnable(False)
            Case Keys.F4
                F4()
            Case Keys.Back
                If IriBox.TextLength = 0 Then
                    ItemClear()
                End If
        End Select
    End Sub

    Private Sub F4Pibox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F4Pibox.Click
        F4()
    End Sub

    Private Sub Fkye_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles F1Pibox.Paint, F2Pibox.Paint, F3Pibox.Paint, F4Pibox.Paint
        Select Case CType(sender, PictureBox).Name
            Case F1Pibox.Name
                If IriBox.Enabled Then
                    printPictureBox.get_F1_imag(F1Pibox, False)
                Else
                    printPictureBox.get_F1_imag(F1Pibox)
                End If
            Case F2Pibox.Name
                printPictureBox.get_F2_imag(F2Pibox, False)
            Case F3Pibox.Name
                printPictureBox.Fkye_none(F3Pibox)
            Case F4Pibox.Name
                If IriBox.Enabled Then
                    printPictureBox.get_F4_imag(F4Pibox, 0)
                Else
                    printPictureBox.get_F4_imag(F4Pibox, 2)
                End If
        End Select
    End Sub

    Private Sub LocaItemForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm(Me)
        labelReset()
        TextBoxClear(IriBox, HakoBox, BaraBox)
        textBoxEnable(False)
    End Sub

    Private Sub textBoxEnable(ByVal flg As Boolean)
        IriBox.Enabled = flg
        HakoBox.Enabled = flg
        BaraBox.Enabled = flg
    End Sub

    Private Sub labelReset()
        LabelClear(itemcodeLabel, BcodeLabel, itemLabel, SuuLabel)
    End Sub

    Private Sub DispLabel(ByVal item As stockItemClass)
        itemcodeLabel.Text = item.code
        BcodeLabel.Text = item.bcode
        itemLabel.Text = item.name
        SuuLabel.Text = item.suu
    End Sub

    Private Sub enterTextBox(ByVal textbox As TextBox)
        If textBoxCheck(textbox) Then
            Select Case textbox.Name
                Case IriBox.Name
                    HakoBox.Focus()
                Case HakoBox.Name
                    BaraBox.Focus()
                Case BaraBox.Name
                    nextForm()
            End Select
        End If
    End Sub

    Private Sub CancelTextBox(ByVal textbox As TextBox)
        If Not textBoxCheck(textbox) Then
            Select Case textbox.Name
                Case HakoBox.Name
                    IriBox.Focus()
                Case BaraBox.Name
                    BaraBox.Focus()
            End Select
        End If
    End Sub

    Private Function textBoxCheck(ByVal textbox As TextBox) As Boolean
        If 0 < textbox.TextLength Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub nextForm()
        nextFormLabel()
        activeform = 42
        ScanEnable(True)
        LocaSakiForm.Show()
        Me.Hide()
    End Sub

    Private Sub nextFormLabel()
        With LocaSakiForm
            .motoLocaLabel.Text = locaLabel.Text
            .itemcodeLabel.Text = itemcodeLabel.Text
            .itemLabel.Text = itemLabel.Text
            .suuLabel.Text = CType(IriBox.Text, Integer) * CType(HakoBox.Text, Integer) + CType(BaraBox.Text, Integer)
        End With
    End Sub

    Private Sub F1()
        If popUpClass.PopUp_Yes_No("ロケーションを変更しますか?") = DialogResult.Yes Then
            ItemClear()
            activeform = 40
            LocaMotoForm.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub F4()
        If IriBox.Enabled = True Then
            ItemClear()
        Else
            If popUpClass.PopUp_Yes_No("終了しますか？") = DialogResult.Yes Then
                ItemClear()
                activeform = 0
                ScanDisableKeySense()
                menuForm.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Public Sub ItemClear()
        labelReset()
        TextBoxClear(IriBox, HakoBox, BaraBox)
        textBoxEnable(False)
        F1Pibox.Invalidate()
        F4Pibox.Invalidate()
        ScanEnable(True)
    End Sub

    Public Sub ItemSelect(ByVal bcode As String)
        Dim item = Items.GetItem(bcode)
        If Not item Is Nothing Then
            DispLabel(item)
            textBoxEnable(True)
            F1Pibox.Invalidate()
            F4Pibox.Invalidate()
            IriBox.Focus()
        End If
    End Sub

    Private Sub Box_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles IriBox.KeyDown, HakoBox.KeyDown, BaraBox.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                enterTextBox(sender)
            Case Keys.Back
                CancelTextBox(sender)
            Case Keys.F4
                F4()
        End Select
    End Sub
End Class