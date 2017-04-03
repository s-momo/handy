<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ScanItemForm
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
        Me.shipmentLabel = New System.Windows.Forms.Label
        Me.CodePibox = New System.Windows.Forms.PictureBox
        Me.shopLabel = New System.Windows.Forms.Label
        Me.ClientPibox = New System.Windows.Forms.PictureBox
        Me.BcodeTextBox = New System.Windows.Forms.TextBox
        Me.ItemCodeLabel = New System.Windows.Forms.Label
        Me.ItemNameLabel = New System.Windows.Forms.Label
        Me.KenpinSuuLabel = New System.Windows.Forms.Label
        Me.KenpinMaxSuuLabel = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.KenpinLabel = New System.Windows.Forms.Label
        Me.MokuziItemCodeLabel = New System.Windows.Forms.Label
        Me.MokuziItemLabel = New System.Windows.Forms.Label
        Me.F4Button = New System.Windows.Forms.Button
        Me.F3Button = New System.Windows.Forms.Button
        Me.F2Button = New System.Windows.Forms.Button
        Me.F1Button = New System.Windows.Forms.Button
        Me.F4Pibox = New System.Windows.Forms.PictureBox
        Me.F3Pibox = New System.Windows.Forms.PictureBox
        Me.F2Pibox = New System.Windows.Forms.PictureBox
        Me.F1Pibox = New System.Windows.Forms.PictureBox
        Me.SuspendLayout()
        '
        'shipmentLabel
        '
        Me.shipmentLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.shipmentLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.shipmentLabel.Location = New System.Drawing.Point(35, 35)
        Me.shipmentLabel.Name = "shipmentLabel"
        Me.shipmentLabel.Size = New System.Drawing.Size(200, 32)
        Me.shipmentLabel.Text = "出荷番号"
        '
        'CodePibox
        '
        Me.CodePibox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CodePibox.Location = New System.Drawing.Point(3, 35)
        Me.CodePibox.Name = "CodePibox"
        Me.CodePibox.Size = New System.Drawing.Size(32, 32)
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
        'BcodeTextBox
        '
        Me.BcodeTextBox.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.BcodeTextBox.Location = New System.Drawing.Point(5, 70)
        Me.BcodeTextBox.Name = "BcodeTextBox"
        Me.BcodeTextBox.Size = New System.Drawing.Size(230, 30)
        Me.BcodeTextBox.TabIndex = 8
        '
        'ItemCodeLabel
        '
        Me.ItemCodeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ItemCodeLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.ItemCodeLabel.Location = New System.Drawing.Point(88, 100)
        Me.ItemCodeLabel.Name = "ItemCodeLabel"
        Me.ItemCodeLabel.Size = New System.Drawing.Size(149, 25)
        Me.ItemCodeLabel.Text = "12345678901234"
        '
        'ItemNameLabel
        '
        Me.ItemNameLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ItemNameLabel.Font = New System.Drawing.Font("メイリオ", 18.0!, System.Drawing.FontStyle.Regular)
        Me.ItemNameLabel.Location = New System.Drawing.Point(3, 150)
        Me.ItemNameLabel.Name = "ItemNameLabel"
        Me.ItemNameLabel.Size = New System.Drawing.Size(232, 70)
        Me.ItemNameLabel.Text = "あああああああああああああああああああああああ"
        '
        'KenpinSuuLabel
        '
        Me.KenpinSuuLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.KenpinSuuLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.KenpinSuuLabel.Location = New System.Drawing.Point(70, 223)
        Me.KenpinSuuLabel.Name = "KenpinSuuLabel"
        Me.KenpinSuuLabel.Size = New System.Drawing.Size(74, 22)
        Me.KenpinSuuLabel.Text = "99999"
        Me.KenpinSuuLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'KenpinMaxSuuLabel
        '
        Me.KenpinMaxSuuLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.KenpinMaxSuuLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.KenpinMaxSuuLabel.Location = New System.Drawing.Point(156, 223)
        Me.KenpinMaxSuuLabel.Name = "KenpinMaxSuuLabel"
        Me.KenpinMaxSuuLabel.Size = New System.Drawing.Size(80, 22)
        Me.KenpinMaxSuuLabel.Text = "99999"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.Label11.Location = New System.Drawing.Point(144, 223)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 22)
        Me.Label11.Text = "/"
        '
        'KenpinLabel
        '
        Me.KenpinLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.KenpinLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.KenpinLabel.Location = New System.Drawing.Point(2, 223)
        Me.KenpinLabel.Name = "KenpinLabel"
        Me.KenpinLabel.Size = New System.Drawing.Size(75, 22)
        Me.KenpinLabel.Text = "検品数"
        '
        'MokuziItemCodeLabel
        '
        Me.MokuziItemCodeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MokuziItemCodeLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.MokuziItemCodeLabel.Location = New System.Drawing.Point(1, 100)
        Me.MokuziItemCodeLabel.Name = "MokuziItemCodeLabel"
        Me.MokuziItemCodeLabel.Size = New System.Drawing.Size(91, 25)
        Me.MokuziItemCodeLabel.Text = "商品コード"
        '
        'MokuziItemLabel
        '
        Me.MokuziItemLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MokuziItemLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.MokuziItemLabel.Location = New System.Drawing.Point(3, 128)
        Me.MokuziItemLabel.Name = "MokuziItemLabel"
        Me.MokuziItemLabel.Size = New System.Drawing.Size(232, 22)
        Me.MokuziItemLabel.Text = "商品名"
        Me.MokuziItemLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'F4Button
        '
        Me.F4Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.F4Button.Enabled = False
        Me.F4Button.Font = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Regular)
        Me.F4Button.Location = New System.Drawing.Point(179, 250)
        Me.F4Button.Name = "F4Button"
        Me.F4Button.Size = New System.Drawing.Size(59, 45)
        Me.F4Button.TabIndex = 24
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
        Me.F3Button.TabIndex = 23
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
        Me.F2Button.TabIndex = 22
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
        Me.F1Button.TabIndex = 21
        Me.F1Button.TabStop = False
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
        'ScanItemForm
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
        Me.Controls.Add(Me.F4Button)
        Me.Controls.Add(Me.F3Button)
        Me.Controls.Add(Me.F2Button)
        Me.Controls.Add(Me.F1Button)
        Me.Controls.Add(Me.MokuziItemLabel)
        Me.Controls.Add(Me.ItemCodeLabel)
        Me.Controls.Add(Me.MokuziItemCodeLabel)
        Me.Controls.Add(Me.KenpinSuuLabel)
        Me.Controls.Add(Me.KenpinMaxSuuLabel)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.KenpinLabel)
        Me.Controls.Add(Me.ItemNameLabel)
        Me.Controls.Add(Me.BcodeTextBox)
        Me.Controls.Add(Me.shipmentLabel)
        Me.Controls.Add(Me.CodePibox)
        Me.Controls.Add(Me.shopLabel)
        Me.Controls.Add(Me.ClientPibox)
        Me.Font = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Regular)
        Me.Name = "ScanItemForm"
        Me.Text = "ScanItemForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents shipmentLabel As System.Windows.Forms.Label
    Friend WithEvents CodePibox As System.Windows.Forms.PictureBox
    Friend WithEvents shopLabel As System.Windows.Forms.Label
    Friend WithEvents ClientPibox As System.Windows.Forms.PictureBox
    Friend WithEvents BcodeTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ItemCodeLabel As System.Windows.Forms.Label
    Friend WithEvents ItemNameLabel As System.Windows.Forms.Label
    Friend WithEvents KenpinSuuLabel As System.Windows.Forms.Label
    Friend WithEvents KenpinMaxSuuLabel As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents KenpinLabel As System.Windows.Forms.Label
    Friend WithEvents MokuziItemCodeLabel As System.Windows.Forms.Label
    Friend WithEvents MokuziItemLabel As System.Windows.Forms.Label
    Friend WithEvents F4Button As System.Windows.Forms.Button
    Friend WithEvents F3Button As System.Windows.Forms.Button
    Friend WithEvents F2Button As System.Windows.Forms.Button
    Friend WithEvents F1Button As System.Windows.Forms.Button
    Friend WithEvents F4Pibox As System.Windows.Forms.PictureBox
    Friend WithEvents F3Pibox As System.Windows.Forms.PictureBox
    Friend WithEvents F2Pibox As System.Windows.Forms.PictureBox
    Friend WithEvents F1Pibox As System.Windows.Forms.PictureBox
End Class
