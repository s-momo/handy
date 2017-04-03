Public Class LocaItemList
 
    Private Sub LocaItemList_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadForm(Me)
        ListViewcolumnsadd()
        ListviewDisp()
        ListView1.Items(0).Selected = True
        ListView1.Items(0).Focused = True
    End Sub

    Private Sub ListViewcolumnsadd()
        With ListView1
            .FullRowSelect = True
            .View = View.Details
            .Columns.Add("コード", 120, HorizontalAlignment.Left)
            .Columns.Add("数量", 30, HorizontalAlignment.Left)
            .Columns.Add("商品名", 100, HorizontalAlignment.Left)
        End With
    End Sub

    Private Sub ListviewDisp()
        ListView1.Items.Clear()
        For i = 0 To StockItemArray.Count - 1
            Dim st As stockItemClass = DirectCast(StockItemArray(i), stockItemClass)
            Dim item As New ListViewItem
            With item
                .Text = st.code
                .SubItems.Add(st.suu)
                .SubItems.Add(st.name)
            End With
            ListView1.Items.Add(item)
        Next
    End Sub

    Private Sub ListView1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListView1.KeyDown
        Select Case e.KeyCode
            Case Keys.Enter
                Try
                    Me.Tag = ListView1.SelectedIndices(0)
                    Me.Close()
                Catch ex As Exception
                    ListView1.Items(ListView1.Items.Count - 1).Selected = True
                End Try
        End Select
    End Sub

    Private Sub LocaPibox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles LocaPibox.Paint
        printPictureBox.show_imag(zaikoImg, LocaPibox)
    End Sub
End Class