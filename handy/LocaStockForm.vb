Public Class LocaStockForm

    Private Sub LocaStockForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                F2()
            Case Keys.F3
                F3()
            Case Keys.F4
                F4()
        End Select
    End Sub

    Private Sub ClientPibox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ClientPibox.Paint
        printPictureBox.show_imag(ClientImg, ClientPibox)
    End Sub

    Private Sub Pibox_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles F3Pibox.Click, F4Pibox.Click
        Select Case DirectCast(sender, PictureBox).Name
            Case F3Pibox.Name
                F3()
            Case F4Pibox.Name
                F4()
        End Select
    End Sub

    Private Sub Fkye_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles F1Pibox.Paint, F2Pibox.Paint, F3Pibox.Paint, F4Pibox.Paint
        Dim pi_box As PictureBox = sender
        Select Case pi_box.Name
            Case F1Pibox.Name
                printPictureBox.get_F1_imag(F1Pibox, False)
            Case F2Pibox.Name
                printPictureBox.get_F2_imag(F2Pibox, False)
            Case F3Pibox.Name
                If 1 < StockItemArray.Count Then
                    printPictureBox.show_imag(SearchImg, F3Pibox)
                Else
                    printPictureBox.Fkye_none(F3Pibox)
                End If
            Case F4Pibox.Name
                printPictureBox.get_F4_imag(F4Pibox, 2)
        End Select
    End Sub

    Private Sub LocaStockForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm(Me)
        LabelClearAll()
    End Sub

    Private Sub LabelDisp(ByVal i As Integer)
        Dim stock As stockItemClass = StockItemArray(i)
        CodeLabel.Text = stock.code
        BcodeLabel.Text = stock.bcode
        ItemLabel.Text = stock.name
        LocaLabel.Text = stock.loca
        StockLabel.Text = stock.suu
        If 1 < StockItemArray.Count Then
            HelpLabel.Text = "F3キーで前回ロケーション"
            F3Pibox.Invalidate()
        End If
    End Sub

    Private Sub LabelClearAll()
        LabelClear(CodeLabel, BcodeLabel, ItemLabel, LocaLabel, StockLabel)
        HelpLabel.Text = "ロケーションをスキャン"
    End Sub
 
    Public Sub LocaItem(ByVal code As String)
        LabelClearAll()
        If 1 < StockItemArray.Count Then
            ScanDisableKeySense()
            ShowLocaItemList(code)
        Else
            LabelDisp(0)
        End If
        ScanEnable(True)
    End Sub

    Private Sub ShowLocaItemList(ByVal code As String)
        Dim form As New LocaItemList
        form.LocaLabel.Text = code
        form.ShowDialog()
        LabelDisp(CType(form.Tag, Integer))
        form.Dispose()
    End Sub

    Private Sub F2()
        If ApiControlClass.GetLocaStock("4939027000518") Then
            LocaItem("4939027000518")
        End If
    End Sub

    Private Sub F3()
        If 0 < StockItemArray.Count Then
            LocaItem(LocaLabel.Text)
        End If
    End Sub

    Private Sub F4()
        StockItemArray.Clear()
        LabelClearAll()
        F3Pibox.Invalidate()
        StockMenuForm.Show()
        Me.Hide()
    End Sub
End Class