<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class StockItemForm
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
        Me.ShopLabel = New System.Windows.Forms.Label
        Me.ClientPibox = New System.Windows.Forms.PictureBox
        Me.F4Button = New System.Windows.Forms.Button
        Me.F3Button = New System.Windows.Forms.Button
        Me.F2Button = New System.Windows.Forms.Button
        Me.F1Button = New System.Windows.Forms.Button
        Me.MokuziLocaLabel = New System.Windows.Forms.Label
        Me.LocaLabel = New System.Windows.Forms.Label
        Me.MokuziCodeLabel = New System.Windows.Forms.Label
        Me.ItemCodeLabel = New System.Windows.Forms.Label
        Me.MokuziBcodeLabel = New System.Windows.Forms.Label
        Me.ItemNameLabel = New System.Windows.Forms.Label
        Me.StockLabel = New System.Windows.Forms.Label
        Me.MokuziStockLabel = New System.Windows.Forms.Label
        Me.F4Pibox = New System.Windows.Forms.PictureBox
        Me.F3Pibox = New System.Windows.Forms.PictureBox
        Me.F2Pibox = New System.Windows.Forms.PictureBox
        Me.F1Pibox = New System.Windows.Forms.PictureBox
        Me.HelpLabel = New System.Windows.Forms.Label
        Me.ItemBcodeLabel = New System.Windows.Forms.Label
        Me.StockAllLabel = New System.Windows.Forms.Label
        Me.MokuziStockAllLabel = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'ShopLabel
        '
        Me.ShopLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ShopLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.ShopLabel.Location = New System.Drawing.Point(35, 1)
        Me.ShopLabel.Name = "ShopLabel"
        Me.ShopLabel.Size = New System.Drawing.Size(200, 32)
        Me.ShopLabel.Text = "テスト株式会社"
        '
        'ClientPibox
        '
        Me.ClientPibox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientPibox.Location = New System.Drawing.Point(3, 1)
        Me.ClientPibox.Name = "ClientPibox"
        Me.ClientPibox.Size = New System.Drawing.Size(32, 32)
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
        'MokuziLocaLabel
        '
        Me.MokuziLocaLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MokuziLocaLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.MokuziLocaLabel.Location = New System.Drawing.Point(1, 66)
        Me.MokuziLocaLabel.Name = "MokuziLocaLabel"
        Me.MokuziLocaLabel.Size = New System.Drawing.Size(45, 25)
        Me.MokuziLocaLabel.Text = "ロケ"
        '
        'LocaLabel
        '
        Me.LocaLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LocaLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.LocaLabel.Location = New System.Drawing.Point(46, 66)
        Me.LocaLabel.Name = "LocaLabel"
        Me.LocaLabel.Size = New System.Drawing.Size(191, 25)
        Me.LocaLabel.Text = "AB-YYHHHH"
        '
        'MokuziCodeLabel
        '
        Me.MokuziCodeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MokuziCodeLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.MokuziCodeLabel.Location = New System.Drawing.Point(1, 144)
        Me.MokuziCodeLabel.Name = "MokuziCodeLabel"
        Me.MokuziCodeLabel.Size = New System.Drawing.Size(90, 25)
        Me.MokuziCodeLabel.Text = "商品コード"
        '
        'ItemCodeLabel
        '
        Me.ItemCodeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ItemCodeLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.ItemCodeLabel.Location = New System.Drawing.Point(88, 144)
        Me.ItemCodeLabel.Name = "ItemCodeLabel"
        Me.ItemCodeLabel.Size = New System.Drawing.Size(149, 25)
        Me.ItemCodeLabel.Text = "AAAALLLLLLL"
        '
        'MokuziBcodeLabel
        '
        Me.MokuziBcodeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MokuziBcodeLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.MokuziBcodeLabel.Location = New System.Drawing.Point(1, 170)
        Me.MokuziBcodeLabel.Name = "MokuziBcodeLabel"
        Me.MokuziBcodeLabel.Size = New System.Drawing.Size(90, 25)
        Me.MokuziBcodeLabel.Text = "バーコード"
        '
        'ItemNameLabel
        '
        Me.ItemNameLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ItemNameLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.ItemNameLabel.Location = New System.Drawing.Point(1, 196)
        Me.ItemNameLabel.Name = "ItemNameLabel"
        Me.ItemNameLabel.Size = New System.Drawing.Size(236, 50)
        Me.ItemNameLabel.Text = "０１２３４５６７８９０１２３４５６７８９"
        '
        'StockLabel
        '
        Me.StockLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.StockLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.StockLabel.Location = New System.Drawing.Point(46, 92)
        Me.StockLabel.Name = "StockLabel"
        Me.StockLabel.Size = New System.Drawing.Size(191, 25)
        Me.StockLabel.Text = "90000"
        '
        'MokuziStockLabel
        '
        Me.MokuziStockLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MokuziStockLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.MokuziStockLabel.Location = New System.Drawing.Point(1, 92)
        Me.MokuziStockLabel.Name = "MokuziStockLabel"
        Me.MokuziStockLabel.Size = New System.Drawing.Size(45, 25)
        Me.MokuziStockLabel.Text = "在庫"
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
        'HelpLabel
        '
        Me.HelpLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.HelpLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.HelpLabel.Location = New System.Drawing.Point(1, 35)
        Me.HelpLabel.Name = "HelpLabel"
        Me.HelpLabel.Size = New System.Drawing.Size(236, 30)
        Me.HelpLabel.Text = "商品をスキャンして下さい"
        Me.HelpLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ItemBcodeLabel
        '
        Me.ItemBcodeLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ItemBcodeLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.ItemBcodeLabel.Location = New System.Drawing.Point(88, 170)
        Me.ItemBcodeLabel.Name = "ItemBcodeLabel"
        Me.ItemBcodeLabel.Size = New System.Drawing.Size(149, 25)
        Me.ItemBcodeLabel.Text = "AAAALLLLLLL"
        '
        'StockAllLabel
        '
        Me.StockAllLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.StockAllLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.StockAllLabel.Location = New System.Drawing.Point(88, 118)
        Me.StockAllLabel.Name = "StockAllLabel"
        Me.StockAllLabel.Size = New System.Drawing.Size(149, 25)
        Me.StockAllLabel.Text = "AAAALLLLLLL"
        '
        'MokuziStockAllLabel
        '
        Me.MokuziStockAllLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.MokuziStockAllLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.MokuziStockAllLabel.Location = New System.Drawing.Point(1, 118)
        Me.MokuziStockAllLabel.Name = "MokuziStockAllLabel"
        Me.MokuziStockAllLabel.Size = New System.Drawing.Size(90, 25)
        Me.MokuziStockAllLabel.Text = "総在庫"
        '
        'StockItemForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(238, 295)
        Me.Controls.Add(Me.StockAllLabel)
        Me.Controls.Add(Me.MokuziStockAllLabel)
        Me.Controls.Add(Me.ItemBcodeLabel)
        Me.Controls.Add(Me.HelpLabel)
        Me.Controls.Add(Me.F4Pibox)
        Me.Controls.Add(Me.F3Pibox)
        Me.Controls.Add(Me.F2Pibox)
        Me.Controls.Add(Me.F1Pibox)
        Me.Controls.Add(Me.StockLabel)
        Me.Controls.Add(Me.MokuziStockLabel)
        Me.Controls.Add(Me.ItemNameLabel)
        Me.Controls.Add(Me.MokuziBcodeLabel)
        Me.Controls.Add(Me.ItemCodeLabel)
        Me.Controls.Add(Me.MokuziCodeLabel)
        Me.Controls.Add(Me.LocaLabel)
        Me.Controls.Add(Me.MokuziLocaLabel)
        Me.Controls.Add(Me.F4Button)
        Me.Controls.Add(Me.F3Button)
        Me.Controls.Add(Me.F2Button)
        Me.Controls.Add(Me.F1Button)
        Me.Controls.Add(Me.ShopLabel)
        Me.Controls.Add(Me.ClientPibox)
        Me.Font = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Regular)
        Me.Name = "StockItemForm"
        Me.Text = "StockItemForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ShopLabel As System.Windows.Forms.Label
    Friend WithEvents ClientPibox As System.Windows.Forms.PictureBox
    Friend WithEvents F4Button As System.Windows.Forms.Button
    Friend WithEvents F3Button As System.Windows.Forms.Button
    Friend WithEvents F2Button As System.Windows.Forms.Button
    Friend WithEvents F1Button As System.Windows.Forms.Button
    Friend WithEvents MokuziLocaLabel As System.Windows.Forms.Label
    Friend WithEvents LocaLabel As System.Windows.Forms.Label
    Friend WithEvents MokuziCodeLabel As System.Windows.Forms.Label
    Friend WithEvents ItemCodeLabel As System.Windows.Forms.Label
    Friend WithEvents MokuziBcodeLabel As System.Windows.Forms.Label
    Friend WithEvents ItemNameLabel As System.Windows.Forms.Label
    Friend WithEvents StockLabel As System.Windows.Forms.Label
    Friend WithEvents MokuziStockLabel As System.Windows.Forms.Label
    Friend WithEvents F4Pibox As System.Windows.Forms.PictureBox
    Friend WithEvents F3Pibox As System.Windows.Forms.PictureBox
    Friend WithEvents F2Pibox As System.Windows.Forms.PictureBox
    Friend WithEvents F1Pibox As System.Windows.Forms.PictureBox
    Friend WithEvents HelpLabel As System.Windows.Forms.Label
    Friend WithEvents ItemBcodeLabel As System.Windows.Forms.Label
    Friend WithEvents StockAllLabel As System.Windows.Forms.Label
    Friend WithEvents MokuziStockAllLabel As System.Windows.Forms.Label
End Class
