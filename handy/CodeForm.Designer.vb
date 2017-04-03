<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class CodeForm
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Windows フォーム デザイナで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナで必要です。
    'Windows フォーム デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.shopLabel = New System.Windows.Forms.Label
        Me.ClientPibox = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.DayPibox = New System.Windows.Forms.PictureBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.ModePibox = New System.Windows.Forms.PictureBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Label9 = New System.Windows.Forms.Label
        Me.BcodeTextBox = New System.Windows.Forms.TextBox
        Me.ZissekiLabel = New System.Windows.Forms.Label
        Me.ZissekiSuuLabelLabel = New System.Windows.Forms.Label
        Me.F4Button = New System.Windows.Forms.Button
        Me.F3Button = New System.Windows.Forms.Button
        Me.F2Button = New System.Windows.Forms.Button
        Me.F1Button = New System.Windows.Forms.Button
        Me.dayLabel = New System.Windows.Forms.Label
        Me.F4Pibox = New System.Windows.Forms.PictureBox
        Me.F3Pibox = New System.Windows.Forms.PictureBox
        Me.F2Pibox = New System.Windows.Forms.PictureBox
        Me.F1Pibox = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'shopLabel
        '
        Me.shopLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.shopLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.shopLabel.Location = New System.Drawing.Point(35, 1)
        Me.shopLabel.Name = "shopLabel"
        Me.shopLabel.Size = New System.Drawing.Size(200, 32)
        Me.shopLabel.Text = "テスト株式会社"
        '
        'ClientPibox
        '
        Me.ClientPibox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientPibox.Location = New System.Drawing.Point(3, 1)
        Me.ClientPibox.Name = "ClientPibox"
        Me.ClientPibox.Size = New System.Drawing.Size(32, 32)
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.Location = New System.Drawing.Point(35, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 32)
        '
        'DayPibox
        '
        Me.DayPibox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.DayPibox.Location = New System.Drawing.Point(3, 36)
        Me.DayPibox.Name = "DayPibox"
        Me.DayPibox.Size = New System.Drawing.Size(32, 32)
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.Label7.Location = New System.Drawing.Point(3, 72)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 32)
        Me.Label7.Text = "検品モード"
        '
        'ModePibox
        '
        Me.ModePibox.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ModePibox.Location = New System.Drawing.Point(104, 72)
        Me.ModePibox.Name = "ModePibox"
        Me.ModePibox.Size = New System.Drawing.Size(32, 32)
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.Label8.Location = New System.Drawing.Point(136, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 32)
        Me.Label8.Text = "総スキャン"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Red
        Me.Button1.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.Button1.Location = New System.Drawing.Point(4, 109)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 32)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "総スキャン"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Silver
        Me.Button2.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.Button2.Location = New System.Drawing.Point(119, 109)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(115, 32)
        Me.Button2.TabIndex = 20
        Me.Button2.Text = "数値入力"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("メイリオ", 14.0!, System.Drawing.FontStyle.Regular)
        Me.Label9.Location = New System.Drawing.Point(4, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(230, 32)
        Me.Label9.Text = "出荷番号"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BcodeTextBox
        '
        Me.BcodeTextBox.Font = New System.Drawing.Font("メイリオ", 14.0!, System.Drawing.FontStyle.Regular)
        Me.BcodeTextBox.Location = New System.Drawing.Point(5, 180)
        Me.BcodeTextBox.Name = "BcodeTextBox"
        Me.BcodeTextBox.Size = New System.Drawing.Size(230, 34)
        Me.BcodeTextBox.TabIndex = 22
        '
        'ZissekiLabel
        '
        Me.ZissekiLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.ZissekiLabel.Location = New System.Drawing.Point(37, 220)
        Me.ZissekiLabel.Name = "ZissekiLabel"
        Me.ZissekiLabel.Size = New System.Drawing.Size(80, 25)
        Me.ZissekiLabel.Text = "検品実績"
        '
        'ZissekiSuuLabelLabel
        '
        Me.ZissekiSuuLabelLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.ZissekiSuuLabelLabel.Location = New System.Drawing.Point(122, 220)
        Me.ZissekiSuuLabelLabel.Name = "ZissekiSuuLabelLabel"
        Me.ZissekiSuuLabelLabel.Size = New System.Drawing.Size(113, 25)
        Me.ZissekiSuuLabelLabel.Text = "1234件"
        '
        'F4Button
        '
        Me.F4Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.F4Button.Enabled = False
        Me.F4Button.Font = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Regular)
        Me.F4Button.Location = New System.Drawing.Point(179, 250)
        Me.F4Button.Name = "F4Button"
        Me.F4Button.Size = New System.Drawing.Size(59, 45)
        Me.F4Button.TabIndex = 38
        Me.F4Button.TabStop = False
        '
        'F3Button
        '
        Me.F3Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.F3Button.Enabled = False
        Me.F3Button.Font = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Regular)
        Me.F3Button.Location = New System.Drawing.Point(119, 250)
        Me.F3Button.Name = "F3Button"
        Me.F3Button.Size = New System.Drawing.Size(60, 45)
        Me.F3Button.TabIndex = 37
        Me.F3Button.TabStop = False
        '
        'F2Button
        '
        Me.F2Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.F2Button.Enabled = False
        Me.F2Button.Font = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Regular)
        Me.F2Button.Location = New System.Drawing.Point(59, 250)
        Me.F2Button.Name = "F2Button"
        Me.F2Button.Size = New System.Drawing.Size(60, 45)
        Me.F2Button.TabIndex = 36
        Me.F2Button.TabStop = False
        '
        'F1Button
        '
        Me.F1Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.F1Button.Enabled = False
        Me.F1Button.Font = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Regular)
        Me.F1Button.Location = New System.Drawing.Point(0, 250)
        Me.F1Button.Name = "F1Button"
        Me.F1Button.Size = New System.Drawing.Size(59, 45)
        Me.F1Button.TabIndex = 35
        Me.F1Button.TabStop = False
        '
        'dayLabel
        '
        Me.dayLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dayLabel.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular)
        Me.dayLabel.Location = New System.Drawing.Point(35, 43)
        Me.dayLabel.Name = "dayLabel"
        Me.dayLabel.Size = New System.Drawing.Size(180, 19)
        Me.dayLabel.Text = "出荷日"
        '
        'F4Pibox
        '
        Me.F4Pibox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.F4Pibox.Location = New System.Drawing.Point(193, 257)
        Me.F4Pibox.Name = "F4Pibox"
        Me.F4Pibox.Size = New System.Drawing.Size(32, 32)
        '
        'F3Pibox
        '
        Me.F3Pibox.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.F3Pibox.Location = New System.Drawing.Point(133, 257)
        Me.F3Pibox.Name = "F3Pibox"
        Me.F3Pibox.Size = New System.Drawing.Size(32, 32)
        '
        'F2Pibox
        '
        Me.F2Pibox.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.F2Pibox.Location = New System.Drawing.Point(73, 257)
        Me.F2Pibox.Name = "F2Pibox"
        Me.F2Pibox.Size = New System.Drawing.Size(32, 32)
        '
        'F1Pibox
        '
        Me.F1Pibox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.F1Pibox.Location = New System.Drawing.Point(13, 257)
        Me.F1Pibox.Name = "F1Pibox"
        Me.F1Pibox.Size = New System.Drawing.Size(32, 32)
        '
        'CodeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(238, 295)
        Me.Controls.Add(Me.F4Pibox)
        Me.Controls.Add(Me.F3Pibox)
        Me.Controls.Add(Me.F2Pibox)
        Me.Controls.Add(Me.F1Pibox)
        Me.Controls.Add(Me.dayLabel)
        Me.Controls.Add(Me.F4Button)
        Me.Controls.Add(Me.F3Button)
        Me.Controls.Add(Me.F2Button)
        Me.Controls.Add(Me.F1Button)
        Me.Controls.Add(Me.ZissekiSuuLabelLabel)
        Me.Controls.Add(Me.ZissekiLabel)
        Me.Controls.Add(Me.BcodeTextBox)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ModePibox)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DayPibox)
        Me.Controls.Add(Me.shopLabel)
        Me.Controls.Add(Me.ClientPibox)
        Me.Font = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Regular)
        Me.Name = "CodeForm"
        Me.Text = "CodeForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents shopLabel As System.Windows.Forms.Label
    Friend WithEvents ClientPibox As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DayPibox As System.Windows.Forms.PictureBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ModePibox As System.Windows.Forms.PictureBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BcodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ZissekiLabel As System.Windows.Forms.Label
    Friend WithEvents ZissekiSuuLabelLabel As System.Windows.Forms.Label
    Friend WithEvents F4Button As System.Windows.Forms.Button
    Friend WithEvents F3Button As System.Windows.Forms.Button
    Friend WithEvents F2Button As System.Windows.Forms.Button
    Friend WithEvents F1Button As System.Windows.Forms.Button
    Friend WithEvents dayLabel As System.Windows.Forms.Label
    Friend WithEvents F4Pibox As System.Windows.Forms.PictureBox
    Friend WithEvents F3Pibox As System.Windows.Forms.PictureBox
    Friend WithEvents F2Pibox As System.Windows.Forms.PictureBox
    Friend WithEvents F1Pibox As System.Windows.Forms.PictureBox
End Class
