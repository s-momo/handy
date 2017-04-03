Public Class popUpClass
    Private Shared cl As System.Drawing.Color = Color.Aqua

    Public Shared Sub PopUpOk(ByVal text As String)
        Dim popup = New popUp
        popup.BackColor = Color.FromArgb(192, 255, 255)
        popup.Text = "確認"
        popup.Label1.Text = text
        popup.Button1.DialogResult = DialogResult.OK
        popup.ShowDialog()
        popup.Dispose()
    End Sub

    Public Shared Sub BackColor(ByVal co As System.Drawing.Color)
        cl = co
    End Sub

    Public Shared Sub popUpError(ByRef text As String)
        Dim popup = New popUp
        popup.BackColor = cl
        popup.Text = "エラー"
        popup.Label1.Text = text
        popup.Button1.DialogResult = DialogResult.OK
        popup.ShowDialog()
        popup.Dispose()
        cl = Color.Aqua
    End Sub

    Public Shared Function PopUp_Yes_No(Optional ByVal text As String = "終了しますか？")
        Dim Yes_No As DialogResult
        Dim popup = New popUp
        popup.Text = "確認"
        popup.Left = 0
        popup.Top = 0
        'button1修正
        popup.Label1.Text = text
        popup.Button1.Text = "はい"
        popup.Location = New Point(30, 190)
        popup.Button1.Size = New System.Drawing.Size(70, 35)
        popup.Button1.DialogResult = DialogResult.Yes
        'button2作成
        Dim Button = New System.Windows.Forms.Button()
        Button.Name = "Button2"
        Button.Text = "いいえ"
        Button.Location = New Point(140, 190)
        Button.Size = New System.Drawing.Size(70, 35)
        Button.DialogResult = DialogResult.No
        popup.Controls.Add(Button)
        popup.ShowDialog()
        Yes_No = popup.DialogResult
        popup.Dispose()
        Return Yes_No
    End Function
End Class
