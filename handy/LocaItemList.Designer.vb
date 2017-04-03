<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class LocaItemList
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
        Me.LocaLabel = New System.Windows.Forms.Label
        Me.LocaPibox = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.SuspendLayout()
        '
        'LocaLabel
        '
        Me.LocaLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LocaLabel.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.LocaLabel.Location = New System.Drawing.Point(35, 1)
        Me.LocaLabel.Name = "LocaLabel"
        Me.LocaLabel.Size = New System.Drawing.Size(200, 32)
        Me.LocaLabel.Text = "ロケーション"
        '
        'LocaPibox
        '
        Me.LocaPibox.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LocaPibox.Location = New System.Drawing.Point(3, 1)
        Me.LocaPibox.Name = "LocaPibox"
        Me.LocaPibox.Size = New System.Drawing.Size(32, 32)
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("メイリオ", 12.0!, System.Drawing.FontStyle.Regular)
        Me.Label2.Location = New System.Drawing.Point(4, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(230, 32)
        Me.Label2.Text = "商品を選択してください"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'ListView1
        '
        Me.ListView1.Font = New System.Drawing.Font("メイリオ", 14.0!, System.Drawing.FontStyle.Regular)
        Me.ListView1.Location = New System.Drawing.Point(5, 70)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(230, 222)
        Me.ListView1.TabIndex = 7
        '
        'LocaItemList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(238, 295)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.LocaLabel)
        Me.Controls.Add(Me.LocaPibox)
        Me.Font = New System.Drawing.Font("メイリオ", 10.0!, System.Drawing.FontStyle.Regular)
        Me.Name = "LocaItemList"
        Me.Text = "LocaItemList"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LocaLabel As System.Windows.Forms.Label
    Friend WithEvents LocaPibox As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
End Class
