Public Class StockItemForm
    Private F1flg As Boolean = False
    Private F2flg As Boolean = False
    Private nowitem As Integer = 0

    Private Sub Form_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                F1()
            Case Keys.F2
                F2()
            Case Keys.F4
                F4()
        End Select
    End Sub

    Private Sub ClientPibox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles ClientPibox.Paint
        printPictureBox.show_imag(ClientImg, ClientPibox)
    End Sub

    Private Sub Fkye_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles F1Pibox.Paint, F2Pibox.Paint, F3Pibox.Paint, F4Pibox.Paint
        Dim pi_box As PictureBox = sender
        Select Case pi_box.Name
            Case F1Pibox.Name
                printPictureBox.get_F1_imag(F1Pibox, F1flg)
            Case F2Pibox.Name
                printPictureBox.get_F2_imag(F2Pibox, F2flg)
            Case F3Pibox.Name
                printPictureBox.Fkye_none(F3Pibox)
            Case F4Pibox.Name
                printPictureBox.get_F4_imag(F4Pibox, 2)
        End Select
    End Sub

    Private Sub StockItemForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm(Me)
        FormClear()
    End Sub

    Public Sub StockAll()
        Dim stockall As Integer = 0
        For i = 0 To StockItemArray.Count - 1
            Dim item = DirectCast(StockItemArray(i), stockItemClass)
            stockall += item.suu
        Next
        StockAllLabel.Text = stockall
    End Sub

    Public Sub LabelDisp(ByVal i As Integer)
        Dim item = DirectCast(StockItemArray(i), stockItemClass)
        nowitem = i
        LocaLabel.Text = item.loca
        ItemCodeLabel.Text = item.code
        ItemBcodeLabel.Text = item.bcode
        ItemNameLabel.Text = item.name
        StockLabel.Text = Convert.ToString(item.suu)
        F1PiboxDisp(i)
        F2PiboxDisp(i)
    End Sub

    Private Sub F1PiboxDisp(ByVal i As Integer)
        If i = 0 Then
            F1flg = False
        Else
            F1flg = True
        End If
        F1Pibox.Invalidate()
    End Sub

    Private Sub F2PiboxDisp(ByVal i As Integer)
        If i = StockItemArray.Count - 1 Then
            F2flg = False
        Else
            F2flg = True
        End If
        F2Pibox.Invalidate()
    End Sub

    Private Sub FormClear()
        F1flg = False
        F2flg = False
        nowitem = 0
        StockItemArray.Clear()
        LabelClearAll()
    End Sub

    Private Sub LabelClearAll()
        LabelClear(LocaLabel, StockLabel, ItemCodeLabel, ItemBcodeLabel, ItemNameLabel, StockAllLabel)
    End Sub

    Private Sub F1()
        If nowitem <> 0 Then
            LabelDisp(nowitem - 1)
        End If
    End Sub

    Private Sub F2()
        If nowitem < StockItemArray.Count - 1 Then
            LabelDisp(nowitem + 1)
        End If
    End Sub

    Private Sub F4()
        FormClear()
        ScanDisableKeySense()
        activeform = 0
        StockMenuForm.Show()
        Me.Hide()
    End Sub

End Class