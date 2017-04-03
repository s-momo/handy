Public Class menuForm
    Inherits Form
    Private msgwin As MsgWindowClass
    Private bt As New SolidBrush(Color.Black)
    Private btaqua As New SolidBrush(Color.Red)

    Public Sub New()
        ' この呼び出しは、Windows フォーム デザイナで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        Me.msgwin = New MsgWindowClass()
    End Sub

    Private Sub menuForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm(Me)
        activeform = 90
        ScanEnable(False)
        TextBoxColor(Color.White, NyuukoTextBox, ShukkaTextBox, TanaireTextBox, TanaidouTextBox, ZaikoTextBox, HenpinTextBox)
        LabelColor(Color.White, NyuukoLabel, ShukkaLabel, TanaireLabel, TanaidouLabel, ZaikoLabel, HenpinLabel)
        BoxSendToback()
        NyuukoTextBox.Focus()
    End Sub

    Private Sub TextBox_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NyuukoTextBox.GotFocus, ShukkaTextBox.GotFocus, TanaireTextBox.GotFocus, TanaidouTextBox.GotFocus, ZaikoTextBox.GotFocus, HenpinTextBox.GotFocus
        BoxSelectToLabel(Color.Aqua, sender)
        BoxSelectToPibox(sender)
    End Sub

    Private Sub TextBox_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles NyuukoTextBox.LostFocus, ShukkaTextBox.LostFocus, TanaireTextBox.LostFocus, TanaidouTextBox.LostFocus, ZaikoTextBox.LostFocus, HenpinTextBox.LostFocus
        BoxSelectToLabel(Color.White, sender)
        BoxSelectToPibox(sender)
    End Sub

    Private Sub TextBox_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles NyuukoTextBox.KeyDown, ShukkaTextBox.KeyDown, TanaireTextBox.KeyDown, TanaidouTextBox.KeyDown, ZaikoTextBox.KeyDown, HenpinTextBox.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                If GetUpdate() Then
                    ThreadSleep(3000)
                    Me.Close()
                End If
            Case Keys.F2
                ApiControlClass.test(True)
                MsgBox(clientAll.Count.ToString)
            Case Keys.F3
                ApiControlClass.test(False)
                MsgBox(StaffName)
            Case Keys.F4
                F4()
            Case Keys.Enter
                NextForm(sender)
            Case Keys.Up, Keys.Down, Keys.Right, Keys.Left
                NextFocus(sender, e)
        End Select
    End Sub

    Private Sub PictureBox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles NyuukoPictureBox.Click, ShuukaPictureBox.Click, TanairePictureBox.Click, TanaidouPictureBox.Click, ZaikoPictureBox.Click, HenpinPictureBox.Click
        Dim box As TextBox
        Select Case CType(sender, PictureBox).Name
            Case NyuukoPictureBox.Name
                box = NyuukoTextBox
            Case ShuukaPictureBox.Name
                box = ShukkaTextBox
            Case TanairePictureBox.Name
                box = TanaireTextBox
            Case TanaidouPictureBox.Name
                box = TanaidouTextBox
            Case ZaikoPictureBox.Name
                box = ZaikoTextBox
            Case HenpinPictureBox.Name
                box = HenpinTextBox
            Case Else
                Exit Sub
        End Select
        box.Focus()
        NextForm(box)
    End Sub

    Private Sub Pibox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F4Pibox.Click
        F4()
    End Sub

    Private Sub PictureBox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles NyuukoPictureBox.Paint, ShuukaPictureBox.Paint, TanairePictureBox.Paint, TanaidouPictureBox.Paint, ZaikoPictureBox.Paint, HenpinPictureBox.Paint
        Dim str As String = ""
        GetPictureBoxString(sender, str)
        If GetFocus(sender) Then
            printPictureBox.showImagAndString(MenuBarImg, sender, str, bt)
        Else
            printPictureBox.showImagAndString(MenuBarImg, sender, str, btaqua)
        End If
    End Sub

    Private Sub Fkye_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles F1Pibox.Paint, F2Pibox.Paint, F3Pibox.Paint, F4Pibox.Paint
        Select Case DirectCast(sender, PictureBox).Name
            Case F1Pibox.Name
                printPictureBox.get_F1_imag(F1Pibox, False)
            Case F2Pibox.Name
                printPictureBox.get_F2_imag(F2Pibox, False)
            Case F3Pibox.Name
                printPictureBox.Fkye_none(F3Pibox)
            Case F4Pibox.Name
                printPictureBox.get_F4_imag(F4Pibox, 0)
        End Select
    End Sub

    Private Sub NextFocus(ByVal box As TextBox, ByVal e As System.Windows.Forms.KeyEventArgs)
        e.Handled = True
        Select Case box.Name
            Case NyuukoTextBox.Name
                NyuukoTextBoxKey(e)
            Case ShukkaTextBox.Name
                ShukkaTextBoxKey(e)
            Case TanaireTextBox.Name
                TanaireTextBoxKey(e)
            Case TanaidouTextBox.Name
                TanaidouTextBoxkey(e)
            Case ZaikoTextBox.Name
                ZaikoTextBoxkey(e)
            Case HenpinTextBox.Name
                HenpinTextBoxkey(e)
        End Select
    End Sub

    Private Sub NyuukoTextBoxKey(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Up
                ZaikoTextBox.Focus()
            Case Keys.Down
                TanaireTextBox.Focus()
            Case Keys.Right
                ShukkaTextBox.Focus()
            Case Keys.Left
                HenpinTextBox.Focus()
        End Select
    End Sub

    Private Sub ShukkaTextBoxKey(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Up
                HenpinTextBox.Focus()
            Case Keys.Down
                TanaidouTextBox.Focus()
            Case Keys.Right
                TanaireTextBox.Focus()
            Case Keys.Left
                NyuukoTextBox.Focus()
        End Select
    End Sub

    Private Sub TanaireTextBoxKey(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Up
                NyuukoTextBox.Focus()
            Case Keys.Down
                ZaikoTextBox.Focus()
            Case Keys.Right
                TanaidouTextBox.Focus()
            Case Keys.Left
                ShukkaTextBox.Focus()
        End Select
    End Sub

    Private Sub TanaidouTextBoxkey(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Up
                ShukkaTextBox.Focus()
            Case Keys.Down
                HenpinTextBox.Focus()
            Case Keys.Right
                ZaikoTextBox.Focus()
            Case Keys.Left
                TanaireTextBox.Focus()
        End Select
    End Sub

    Private Sub ZaikoTextBoxkey(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Up
                TanaireTextBox.Focus()
            Case Keys.Down
                NyuukoTextBox.Focus()
            Case Keys.Right
                HenpinTextBox.Focus()
            Case Keys.Left
                TanaidouTextBox.Focus()
        End Select
    End Sub

    Private Sub HenpinTextBoxkey(ByVal e As System.Windows.Forms.KeyEventArgs)
        Select Case e.KeyCode
            Case Keys.Up
                TanaidouTextBox.Focus()
            Case Keys.Down
                ShukkaTextBox.Focus()
            Case Keys.Right
                NyuukoTextBox.Focus()
            Case Keys.Left
                ZaikoTextBox.Focus()
        End Select
    End Sub

    Private Sub BoxSelectToLabel(ByVal iro As Color, ByVal box As TextBox)
        Dim lb As Label
        Select Case box.Name
            Case NyuukoTextBox.Name
                lb = NyuukoLabel
            Case ShukkaTextBox.Name
                lb = ShukkaLabel
            Case TanaireTextBox.Name
                lb = TanaireLabel
            Case TanaidouTextBox.Name
                lb = TanaidouLabel
            Case ZaikoTextBox.Name
                lb = ZaikoLabel
            Case HenpinTextBox.Name
                lb = HenpinLabel
            Case Else
                Exit Sub
        End Select
        LabelColor(iro, lb)
    End Sub

    Private Sub BoxSelectToPibox(ByVal box As TextBox)
        Dim pibox As PictureBox
        Select Case box.Name
            Case NyuukoTextBox.Name
                pibox = NyuukoPictureBox
            Case ShukkaTextBox.Name
                pibox = ShuukaPictureBox
            Case TanaireTextBox.Name
                pibox = TanairePictureBox
            Case TanaidouTextBox.Name
                pibox = TanaidouPictureBox
            Case ZaikoTextBox.Name
                pibox = ZaikoPictureBox
            Case HenpinTextBox.Name
                pibox = HenpinPictureBox
            Case Else
                Exit Sub
        End Select
        pibox.Invalidate()
    End Sub

    Private Sub TextBoxColor(ByVal iro As Color, ByVal ParamArray box() As TextBox)
        For i = 0 To box.Count - 1
            box(i).BackColor = iro
        Next
    End Sub

    Private Sub LabelColor(ByVal iro As Color, ByVal ParamArray label() As Label)
        For i = 0 To label.Count - 1
            label(i).BackColor = iro
        Next
    End Sub

    Private Sub BoxSendToback()
        NyuukoTextBox.SendToBack()
        ShukkaTextBox.SendToBack()
        TanaireTextBox.SendToBack()
        TanaidouTextBox.SendToBack()
        ZaikoTextBox.SendToBack()
        HenpinTextBox.SendToBack()
    End Sub

    Private Sub GetPictureBoxString(ByVal pibox As PictureBox, ByRef str As String)
        Select Case pibox.Name
            Case NyuukoPictureBox.Name
                str = "入庫"
            Case ShuukaPictureBox.Name
                str = "出荷"
            Case TanairePictureBox.Name
                str = "棚入れ"
            Case TanaidouPictureBox.Name
                str = "棚移動"
            Case ZaikoPictureBox.Name
                str = "在庫"
            Case HenpinPictureBox.Name
                str = "返品"
        End Select
    End Sub

    Private Function GetFocus(ByVal pibox As PictureBox) As Boolean
        Dim lb As Label
        Select Case pibox.Name
            Case NyuukoPictureBox.Name
                lb = NyuukoLabel
            Case ShuukaPictureBox.Name
                lb = ShukkaLabel
            Case TanairePictureBox.Name
                lb = TanaireLabel
            Case TanaidouPictureBox.Name
                lb = TanaidouLabel
            Case ZaikoPictureBox.Name
                lb = ZaikoLabel
            Case HenpinPictureBox.Name
                lb = HenpinLabel
            Case Else
                lb = NyuukoLabel
        End Select
        If lb.BackColor = Color.White Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub NextForm(ByVal box As TextBox)
        If box.Name = ZaikoTextBox.Name Then
            StockMenuForm.Show()
            Me.Hide()
        Else
            If Login() Then
                Select Case box.Name
                    Case NyuukoTextBox.Name
                        activeform = 10
                        ScanEnable(True)
                        NyuukaCode.shopLabel.Text = ClientName
                        NyuukaCode.Show()
                    Case ShukkaTextBox.Name
                        activeform = 1
                        DayForm.shoplabel.Text = ClientName
                        DayForm.Show()
                    Case TanaireTextBox.Name
                        activeform = 30
                        ScanEnable(True)
                        NewLocaForm.shopLabel.Text = ClientName
                        NewLocaForm.Show()
                    Case TanaidouTextBox.Name
                        activeform = 40
                        ScanEnable(True)
                        LocaMotoForm.shopLabel.Text = ClientName
                        LocaMotoForm.Show()
                    Case HenpinTextBox.Name
                        activeform = 70
                        ScanEnable(True)
                        ReturnedGoodsForm.shopLabel.Text = ClientName
                        ReturnedGoodsForm.Show()
                End Select
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub F4()
        If popUpClass.PopUp_Yes_No() = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

End Class