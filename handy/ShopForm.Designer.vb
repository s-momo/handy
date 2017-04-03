<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class shopForm
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
        Me.stafflabel = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
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
        'stafflabel
        '
        Me.stafflabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.stafflabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.stafflabel.Location = New System.Drawing.Point(5, 2)
        Me.stafflabel.Name = "stafflabel"
        Me.stafflabel.Size = New System.Drawing.Size(230, 32)
        Me.stafflabel.Text = "テスト太郎"
        Me.stafflabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("メイリオ", 14.0!, System.Drawing.FontStyle.Regular)
        Me.Label6.Location = New System.Drawing.Point(5, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(230, 32)
        Me.Label6.Text = "荷主を選択"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("メイリオ", 14.0!, System.Drawing.FontStyle.Regular)
        Me.TextBox1.Location = New System.Drawing.Point(5, 69)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(230, 34)
        Me.TextBox1.TabIndex = 10
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(36, 35)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("メイリオ", 14.0!, System.Drawing.FontStyle.Regular)
        Me.ListBox1.Location = New System.Drawing.Point(5, 95)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(230, 170)
        Me.ListBox1.TabIndex = 12
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.PictureBox2.Location = New System.Drawing.Point(37, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 32)
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
        'shopForm
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
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.stafflabel)
        Me.Font = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Regular)
        Me.Name = "shopForm"
        Me.Text = "shopForm"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents stafflabel As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents F4Button As System.Windows.Forms.Button
    Friend WithEvents F3Button As System.Windows.Forms.Button
    Friend WithEvents F2Button As System.Windows.Forms.Button
    Friend WithEvents F1Button As System.Windows.Forms.Button
    Friend WithEvents F4Pibox As System.Windows.Forms.PictureBox
    Friend WithEvents F3Pibox As System.Windows.Forms.PictureBox
    Friend WithEvents F2Pibox As System.Windows.Forms.PictureBox
    Friend WithEvents F1Pibox As System.Windows.Forms.PictureBox
End Class
