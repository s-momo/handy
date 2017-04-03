<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class NewLocaForm
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
        Me.HelpLabel = New System.Windows.Forms.Label
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.MokuziItemLabel = New System.Windows.Forms.Label
        Me.ItemLabel = New System.Windows.Forms.Label
        Me.F4Button = New System.Windows.Forms.Button
        Me.F3Button = New System.Windows.Forms.Button
        Me.F2Button = New System.Windows.Forms.Button
        Me.F1Button = New System.Windows.Forms.Button
        Me.LocaLabel = New System.Windows.Forms.Label
        Me.MokuziLocaLabel = New System.Windows.Forms.Label
        Me.MokuziSuuLabel = New System.Windows.Forms.Label
        Me.SuuTextBox = New System.Windows.Forms.TextBox
        Me.ItemCodeLabel = New System.Windows.Forms.Label
        Me.MokuziItemCodeLabel = New System.Windows.Forms.Label
        Me.F4Pibox = New System.Windows.Forms.PictureBox
        Me.F3Pibox = New System.Windows.Forms.PictureBox
        Me.F2Pibox = New System.Windows.Forms.PictureBox
        Me.F1Pibox = New System.Windows.Forms.PictureBox
        Me.BcodeLabel = New System.Windows.Forms.Label
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
        'HelpLabel
        '
        Me.HelpLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HelpLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.HelpLabel.Location = New System.Drawing.Point(5, 36)
        Me.HelpLabel.Name = "HelpLabel"
        Me.HelpLabel.Size = New System.Drawing.Size(230, 45)
        Me.HelpLabel.Text = "商品をスキャン" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "してください"
        Me.HelpLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(5, 44)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
        '
        'MokuziItemLabel
        '
        Me.MokuziItemLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MokuziItemLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.MokuziItemLabel.Location = New System.Drawing.Point(1, 110)
        Me.MokuziItemLabel.Name = "MokuziItemLabel"
        Me.MokuziItemLabel.Size = New System.Drawing.Size(90, 25)
        Me.MokuziItemLabel.Text = "バーコード"
        Me.MokuziItemLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ItemLabel
        '
        Me.ItemLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ItemLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.ItemLabel.Location = New System.Drawing.Point(1, 135)
        Me.ItemLabel.Name = "ItemLabel"
        Me.ItemLabel.Size = New System.Drawing.Size(236, 48)
        Me.ItemLabel.Text = "ああああああああああああああああああああああああああ"
        '
        'F4Button
        '
        Me.F4Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.F4Button.Enabled = False
        Me.F4Button.Font = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Regular)
        Me.F4Button.Location = New System.Drawing.Point(179, 250)
        Me.F4Button.Name = "F4Button"
        Me.F4Button.Size = New System.Drawing.Size(59, 45)
        Me.F4Button.TabIndex = 28
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
        Me.F3Button.TabIndex = 27
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
        Me.F2Button.TabIndex = 26
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
        Me.F1Button.TabIndex = 25
        Me.F1Button.TabStop = False
        '
        'LocaLabel
        '
        Me.LocaLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LocaLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.LocaLabel.Location = New System.Drawing.Point(107, 185)
        Me.LocaLabel.Name = "LocaLabel"
        Me.LocaLabel.Size = New System.Drawing.Size(130, 25)
        Me.LocaLabel.Text = "AB-YYHHHH"
        '
        'MokuziLocaLabel
        '
        Me.MokuziLocaLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MokuziLocaLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.MokuziLocaLabel.Location = New System.Drawing.Point(1, 185)
        Me.MokuziLocaLabel.Name = "MokuziLocaLabel"
        Me.MokuziLocaLabel.Size = New System.Drawing.Size(105, 25)
        Me.MokuziLocaLabel.Text = "ロケーション"
        '
        'MokuziSuuLabel
        '
        Me.MokuziSuuLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MokuziSuuLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.MokuziSuuLabel.Location = New System.Drawing.Point(1, 214)
        Me.MokuziSuuLabel.Name = "MokuziSuuLabel"
        Me.MokuziSuuLabel.Size = New System.Drawing.Size(44, 25)
        Me.MokuziSuuLabel.Text = "数量"
        '
        'SuuTextBox
        '
        Me.SuuTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SuuTextBox.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.SuuTextBox.Location = New System.Drawing.Point(45, 214)
        Me.SuuTextBox.Name = "SuuTextBox"
        Me.SuuTextBox.Size = New System.Drawing.Size(73, 30)
        Me.SuuTextBox.TabIndex = 34
        '
        'ItemCodeLabel
        '
        Me.ItemCodeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ItemCodeLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.ItemCodeLabel.Location = New System.Drawing.Point(88, 83)
        Me.ItemCodeLabel.Name = "ItemCodeLabel"
        Me.ItemCodeLabel.Size = New System.Drawing.Size(149, 25)
        Me.ItemCodeLabel.Text = "12345678901234"
        '
        'MokuziItemCodeLabel
        '
        Me.MokuziItemCodeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MokuziItemCodeLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.MokuziItemCodeLabel.Location = New System.Drawing.Point(1, 83)
        Me.MokuziItemCodeLabel.Name = "MokuziItemCodeLabel"
        Me.MokuziItemCodeLabel.Size = New System.Drawing.Size(91, 25)
        Me.MokuziItemCodeLabel.Text = "商品コード"
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
        'BcodeLabel
        '
        Me.BcodeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BcodeLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.BcodeLabel.Location = New System.Drawing.Point(88, 110)
        Me.BcodeLabel.Name = "BcodeLabel"
        Me.BcodeLabel.Size = New System.Drawing.Size(149, 25)
        Me.BcodeLabel.Text = "12345678901234"
        '
        'NewLocaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(238, 295)
        Me.Controls.Add(Me.MokuziLocaLabel)
        Me.Controls.Add(Me.BcodeLabel)
        Me.Controls.Add(Me.F4Pibox)
        Me.Controls.Add(Me.F3Pibox)
        Me.Controls.Add(Me.F2Pibox)
        Me.Controls.Add(Me.F1Pibox)
        Me.Controls.Add(Me.ItemCodeLabel)
        Me.Controls.Add(Me.MokuziItemCodeLabel)
        Me.Controls.Add(Me.SuuTextBox)
        Me.Controls.Add(Me.MokuziSuuLabel)
        Me.Controls.Add(Me.LocaLabel)
        Me.Controls.Add(Me.F4Button)
        Me.Controls.Add(Me.F3Button)
        Me.Controls.Add(Me.F2Button)
        Me.Controls.Add(Me.F1Button)
        Me.Controls.Add(Me.MokuziItemLabel)
        Me.Controls.Add(Me.ItemLabel)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.HelpLabel)
        Me.Controls.Add(Me.shopLabel)
        Me.Controls.Add(Me.ClientPibox)
        Me.Font = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Regular)
        Me.Name = "NewLocaForm"
        Me.Text = "NewRokeForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents shopLabel As System.Windows.Forms.Label
    Friend WithEvents ClientPibox As System.Windows.Forms.PictureBox
    Friend WithEvents HelpLabel As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents MokuziItemLabel As System.Windows.Forms.Label
    Friend WithEvents ItemLabel As System.Windows.Forms.Label
    Friend WithEvents F4Button As System.Windows.Forms.Button
    Friend WithEvents F3Button As System.Windows.Forms.Button
    Friend WithEvents F2Button As System.Windows.Forms.Button
    Friend WithEvents F1Button As System.Windows.Forms.Button
    Friend WithEvents LocaLabel As System.Windows.Forms.Label
    Friend WithEvents MokuziLocaLabel As System.Windows.Forms.Label
    Friend WithEvents MokuziSuuLabel As System.Windows.Forms.Label
    Friend WithEvents SuuTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ItemCodeLabel As System.Windows.Forms.Label
    Friend WithEvents MokuziItemCodeLabel As System.Windows.Forms.Label
    Friend WithEvents F4Pibox As System.Windows.Forms.PictureBox
    Friend WithEvents F3Pibox As System.Windows.Forms.PictureBox
    Friend WithEvents F2Pibox As System.Windows.Forms.PictureBox
    Friend WithEvents F1Pibox As System.Windows.Forms.PictureBox
    Friend WithEvents BcodeLabel As System.Windows.Forms.Label
End Class
