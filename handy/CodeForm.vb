Public Class CodeForm

    Private Sub ClientPibox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ClientPibox.Paint
        printPictureBox.show_imag(ClientImg, ClientPibox)
    End Sub

    Private Sub DayPibox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles DayPibox.Paint
        printPictureBox.show_imag(DayImg, DayPibox)
    End Sub

    Private Sub CodeForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm(Me)
        BcodeTextBox.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Input()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AllScan()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles BcodeTextBox.KeyDown, Button1.KeyDown, Button2.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                F1()
            Case Keys.F2
                NextForm(BcodeTextBox.Text)
            Case Keys.F3
                ModeChange()
            Case Keys.F4
                F4()
        End Select
    End Sub

    Private Sub ModePibox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ModePibox.Paint
        Dim bitmap As Bitmap
        If ScanMode Then
            bitmap = BarcodeImg
        Else
            bitmap = SearchImg
        End If
        printPictureBox.show_imag(bitmap, ModePibox)
    End Sub

    Public Sub NextForm(ByVal bcode As String)
        If ApiControlClass.GetShipment(bcode) Then
            If ScanMode Then
                activeform = 21
                With ScanItemForm
                    .shopLabel.Text = ClientName
                    .shipmentLabel.Text = shipmentNo
                    .KenpinSuuLabel.Text = "0"
                    .KenpinMaxSuuLabel.Text = CType(ShipmentClass.GetMaxSuu(), String)
                    TextBoxClear(.BcodeTextBox)
                    LabelClear(.ItemCodeLabel, .ItemNameLabel)
                    .Show()
                End With
            Else
                activeform = 22
                With ItemForm
                    .shopLabel.Text = ClientName
                    .shipmentLabel.Text = shipmentNo
                    .KenpinSuuLabel.Text = "0"
                    .KenpinSuuMaxLabel.Text = CType(ShipmentClass.GetMaxSuu(), String)
                    TextBoxClear(.BcodeTextBox, .IriTextBox, .HakoTextBox, .BaraTextBox)
                    LabelClear(.ItemNameLabel)
                    .Show()
                End With
            End If
            Me.Hide()
            'Else
            '    popUpClass.popUpError(bcode & "の" & vbCrLf & "出荷データが有りません")
        End If
    End Sub

    Private Sub ModeChange()
        If ScanMode Then
            Input()
        Else
            AllScan()
        End If
    End Sub

    Private Sub AllScan()
        Label8.Text = "総スキャン"
        Button2.BackColor = Color.Silver
        Button1.BackColor = Color.Red
        ModePibox.Invalidate()
        ScanMode = True
    End Sub

    Private Sub Input()
        Label8.Text = "数値入力"
        Button1.BackColor = Color.Silver
        Button2.BackColor = Color.Red
        ModePibox.Invalidate()
        ScanMode = False
    End Sub

    Private Sub Pibox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F1Pibox.Click, F2Pibox.Click, F3Pibox.Click, F4Pibox.Click
        Select Case CType(sender, PictureBox).Name
            Case F1Pibox.Name
                F1()
            Case F2Pibox.Name
                NextForm(BcodeTextBox.Text)
            Case F3Pibox.Name
                ModeChange()
            Case F4Pibox.Name
                F4()
        End Select
    End Sub

    Private Sub Fkye_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles F1Pibox.Paint, F2Pibox.Paint, F3Pibox.Paint, F4Pibox.Paint
        Select Case DirectCast(sender, PictureBox).Name
            Case F1Pibox.Name
                printPictureBox.get_F1_imag(F1Pibox)
            Case F2Pibox.Name
                printPictureBox.get_F2_imag(F2Pibox, False)
            Case F3Pibox.Name
                printPictureBox.show_imag(ChangeImg, sender)
            Case F4Pibox.Name
                printPictureBox.get_F4_imag(F4Pibox, 2)
        End Select
    End Sub

    Private Sub F1()
        ScanEnable(False)
        activeform = 1
        DayForm.Show()
        Me.Hide()
    End Sub

    Private Sub F4()
        ShipmentClearAll()
        ScanEnable(False)
        activeform = 0
        menuForm.Show()
        Me.Hide()
    End Sub
End Class