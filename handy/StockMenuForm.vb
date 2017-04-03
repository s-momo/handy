Public Class StockMenuForm
    Private bt As New SolidBrush(Color.Black)
    Private ft As New Font(FontFamily.GenericMonospace, 16, FontStyle.Regular)

    Private Sub StockMenuForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm(Me)
        LocaZaiLabel.BackColor = Color.White
        ItemZaiLabel.BackColor = Color.White
        TanaOrosiLabel.BackColor = Color.White
        BoxSendToBack()
        LocaZaiTextBox.Focus()
    End Sub

    Private Sub colorlabel(ByVal box As TextBox, ByRef frg As Boolean)
        Dim colors As Color
        If frg Then
            colors = Drawing.Color.Aqua
        Else
            colors = Drawing.Color.White
        End If
        Select Case box.Name
            Case LocaZaiTextBox.Name
                LocaZaiLabel.BackColor = colors
            Case ItemZaiTextBox.Name
                ItemZaiLabel.BackColor = colors
            Case TanaOrosiTextBox.Name
                TanaOrosiLabel.BackColor = colors
        End Select
    End Sub

    Private Sub Pibox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F1Pibox.Click, F4Pibox.Click
        F1()
    End Sub

    Private Sub Fkye_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles F1Pibox.Paint, F2Pibox.Paint, F3Pibox.Paint, F4Pibox.Paint
        Select Case CType(sender, PictureBox).Name
            Case F1Pibox.Name
                printPictureBox.get_F1_imag(F1Pibox)
            Case F2Pibox.Name
                printPictureBox.get_F2_imag(F2Pibox, False)
            Case F3Pibox.Name
                printPictureBox.Fkye_none(F3Pibox)
            Case F4Pibox.Name
                printPictureBox.Fkye_none(F4Pibox)
        End Select
    End Sub

    Private Sub PictureBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LocaZaiPictureBox.Click, ItemZaiPictureBox.Click, TanaOrosiPictureBox.Click
        Dim box As TextBox
        Select Case DirectCast(sender, PictureBox).Name
            Case LocaZaiPictureBox.Name
                box = LocaZaiTextBox
            Case ItemZaiPictureBox.Name
                box = ItemZaiTextBox
            Case TanaOrosiPictureBox.Name
                box = TanaOrosiTextBox
            Case Else
                Exit Sub
        End Select
        box.Focus()
        NextForm(box)
    End Sub

    Private Sub PictureBox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles LocaZaiPictureBox.Paint, ItemZaiPictureBox.Paint, TanaOrosiPictureBox.Paint
        Dim lb = GetPictureBoxToLabel(sender)
        Dim str = GetPictureBoxToStr(sender)
        If lb.BackColor = Color.White Then
            printPictureBox.showImagAndStringDeff(ZaikoMenuOffImg, sender, str, bt, ft, 5, 10)
            CType(sender, PictureBox).BackColor = Color.White
        Else
            printPictureBox.showImagAndStringDeff(ZaikoMenuOnImg, sender, str, bt, ft, 5, 10)
            CType(sender, PictureBox).BackColor = Color.Aqua
        End If
    End Sub

    Private Sub TextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles LocaZaiTextBox.GotFocus, ItemZaiTextBox.GotFocus, TanaOrosiTextBox.GotFocus
        colorlabel(sender, True)
        Dim pibox = GetTextBoxToPictureBox(sender)
        pibox.Invalidate()
    End Sub

    Private Sub TextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles LocaZaiTextBox.LostFocus, ItemZaiTextBox.LostFocus, TanaOrosiTextBox.LostFocus
        colorlabel(sender, False)
        Dim pibox = GetTextBoxToPictureBox(sender)
        pibox.Invalidate()
    End Sub

    Private Sub TextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LocaZaiTextBox.KeyDown, ItemZaiTextBox.KeyDown, TanaOrosiTextBox.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                F1()
            Case Keys.F2, Keys.Enter
                NextForm(sender)
            Case Keys.F3
                cp(Me.Name)
            Case Keys.F4

            Case Keys.Up, Keys.Down
                NextBox(sender, e)
            Case Keys.NumPad1, Keys.NumPad2, Keys.NumPad3
                e.Handled = True
                Select Case e.KeyCode
                    Case Keys.NumPad1
                        LocaZaiTextBox.Focus()
                    Case Keys.NumPad2
                        ItemZaiTextBox.Focus()
                    Case Keys.NumPad3
                        TanaOrosiTextBox.Focus()
                End Select
        End Select
    End Sub

    Private Sub NextBox(ByVal box As TextBox, ByVal e As System.Windows.Forms.KeyEventArgs)
        e.Handled = True
        Select Case box.Name
            Case LocaZaiTextBox.Name
                Select Case e.KeyCode
                    Case Keys.Up
                        TanaOrosiTextBox.Focus()
                    Case Keys.Down
                        ItemZaiTextBox.Focus()
                End Select
            Case ItemZaiTextBox.Name
                Select Case e.KeyCode
                    Case Keys.Up
                        LocaZaiTextBox.Focus()
                    Case Keys.Down
                        TanaOrosiTextBox.Focus()
                End Select
            Case TanaOrosiTextBox.Name
                Select Case e.KeyCode
                    Case Keys.Up
                        ItemZaiTextBox.Focus()
                    Case Keys.Down
                        LocaZaiTextBox.Focus()
                End Select
        End Select
    End Sub

    Private Sub NextForm(ByVal box As TextBox)
        If Login() Then
            ScanEnable(True)
            Select Case box.Name
                Case LocaZaiTextBox.Name
                    activeform = 60
                    LocaStockForm.shopLabel.Text = ClientName
                    LocaStockForm.Show()
                Case ItemZaiTextBox.Name
                    activeform = 61
                    StockItemForm.ShopLabel.Text = ClientName
                    StockItemForm.Show()
                Case TanaOrosiTextBox.Name
                    popUpClass.popUpError("準備中です。")
                    ScanEnable(False)
                    Exit Sub
            End Select
            Me.Hide()
        End If
    End Sub

    Private Function GetTextBoxToPictureBox(ByVal box As TextBox) As PictureBox
        Select Case box.Name
            Case LocaZaiTextBox.Name
                Return LocaZaiPictureBox
            Case ItemZaiTextBox.Name
                Return ItemZaiPictureBox
            Case TanaOrosiTextBox.Name
                Return TanaOrosiPictureBox
            Case Else
                Return LocaZaiPictureBox
        End Select
    End Function

    Private Function GetPictureBoxToLabel(ByVal pibox As PictureBox) As Label
        Select Case pibox.Name
            Case LocaZaiPictureBox.Name
                Return LocaZaiLabel
            Case ItemZaiPictureBox.Name
                Return ItemZaiLabel
            Case TanaOrosiPictureBox.Name
                Return TanaOrosiLabel
            Case Else
                Return LocaZaiLabel
        End Select
    End Function

    Private Function GetPictureBoxToStr(ByVal pibox As PictureBox) As String
        Select Case pibox.Name
            Case LocaZaiPictureBox.Name
                Return "ロケーション"
            Case ItemZaiPictureBox.Name
                Return "商品在庫"
            Case TanaOrosiPictureBox.Name
                Return "棚卸し"
            Case Else
                Return "ロケーション"
        End Select
    End Function

    Private Sub BoxSendToBack()
        LocaZaiTextBox.SendToBack()
        ItemZaiTextBox.SendToBack()
        TanaOrosiTextBox.SendToBack()
    End Sub

    Private Sub F1()
        menuForm.Show()
        Me.Hide()
    End Sub

End Class