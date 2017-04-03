
Public Class shopForm

    Private Sub shopForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ClientCode = ""
        ClientName = ""
        LoadForm(Me)
        listAll()
        TextBox1.Focus()
    End Sub

    Private Sub TextBox1_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        InputNumber()
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown, ListBox1.KeyDown
        Select Case e.KeyCode
            Case Keys.F1
                F1()
            Case Keys.F2, Keys.Enter
                If e.KeyCode = Keys.Enter AndAlso TypeOf sender Is TextBox Then
                    If TextBox1.Text.Length <> 0 Then
                        SearchShops()
                    Else
                        listAll()
                    End If
                Else
                    F2()
                End If
            Case Keys.F3
                cp(Me.Name)
            Case Keys.F4
                F4()
            Case Keys.Up
                If ListBox1.SelectedIndex = 0 Then
                    TextBox1.Focus()
                End If
            Case Keys.Down
                ListBox1.Focus()
        End Select
    End Sub
    Private Sub PictureBox_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBox1.Paint, PictureBox2.Paint
        Dim bmp As Bitmap
        Select Case CType(sender, PictureBox).Name
            Case PictureBox1.Name
                bmp = ClientImg
            Case PictureBox2.Name
                bmp = StaffImg
            Case Else
                Exit Sub
        End Select
        printPictureBox.show_imag(bmp, sender)
    End Sub

    Private Sub Fkye_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles F1Pibox.Paint, F2Pibox.Paint, F3Pibox.Paint, F4Pibox.Paint
        Select Case CType(sender, PictureBox).Name
            Case F1Pibox.Name
                printPictureBox.get_F1_imag(F1Pibox)
            Case F2Pibox.Name
                printPictureBox.get_F2_imag(F2Pibox)
            Case F3Pibox.Name
                printPictureBox.Fkye_none(F3Pibox)
            Case F4Pibox.Name
                printPictureBox.get_F4_imag(F4Pibox, 2)
        End Select
    End Sub

    Private Sub listAll()
        Try
            ListBox1.Items.Clear()
            For i = 0 To clientAll.Count - 1
                Dim st As shopClass = DirectCast(clientAll(i), shopClass)
                ListBox1.Items.Add(st.shop_disp)
                If st.shop_name = ClientName Then
                    ListBox1.SelectedItem = st.shop_disp
                End If
            Next
            If ClientName = "" Then
                ListBox1.SelectedIndex = 0
            End If
        Catch ex As Exception
            popUpClass.popUpError(ex.Message)
        End Try
    End Sub

    Private Sub ShopSelect()
        If 0 < ListBox1.Items.Count Then
            For i = 0 To clientAll.Count - 1
                Dim st As shopClass = DirectCast(clientAll(i), shopClass)
                If ListBox1.SelectedItem = st.shop_disp Then
                    ClientCode = st.shop_id
                    ClientName = st.shop_name
                End If
            Next
        End If
    End Sub

    Private Sub SearchShops()
        ListBox1.Items.Clear()
        For i = 0 To clientAll.Count - 1
            Dim st As shopClass = DirectCast(clientAll(i), shopClass)
            If InStr(st.shop_id, TextBox1.Text) Then
                ListBox1.Items.Add(st.shop_disp)
            End If
        Next
        If ListBox1.Items.Count = 0 Then listAll()
        ListBox1.SelectedIndex = 0
    End Sub

    Private Sub F4Pibox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F1Pibox.Click, F2Pibox.Click, F4Pibox.Click
        Select Case CType(sender, PictureBox).Name
            Case F1Pibox.Name
                F1()
            Case F2Pibox.Name
                F2()
            Case F4Pibox.Name
                F4()
        End Select
    End Sub

    Private Sub F1()
        DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub F2()
        ShopSelect()
        DialogResult = Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub F4()
        DialogResult = Windows.Forms.DialogResult.No
        Me.Close()
    End Sub

End Class