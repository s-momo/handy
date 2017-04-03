Imports Bt

Public Class MsgWindowClass
    Inherits Microsoft.WindowsCE.Forms.MessageWindow
    Public Sub New()
    End Sub

    Protected Overrides Sub WndProc(ByRef m As Microsoft.WindowsCE.Forms.Message)
        Select Case m.Msg
            Case CType(LibDef.WM_BT_SCAN, Int32)
                ' 読み取り成功の場合
                If m.WParam.ToInt32() = CType(LibDef.BTMSG_WPARAM.WP_SCN_SUCCESS, Int32) Then
                    If scan = 1 Then
                        ScanKobetu()
                    ElseIf scan = 2 Then
                        ScanIkkatu()
                    End If
                ElseIf m.WParam.ToInt32() = CType(LibDef.BTMSG_WPARAM.WP_SCN_CANCEL, Int32) Then

                ElseIf m.WParam.ToInt32() = CType(LibDef.BTMSG_WPARAM.WP_SCN_DECODE_TIMEOUT, Int32) Then
                End If
                Exit Select
        End Select
        MyBase.WndProc(m)
    End Sub

    Public Shared Sub ScanKobetu()
        MsgBox("3")
    End Sub
    Public Shared Sub ScanIkkatu()
        Dim ret As Int32 = 0
        Dim disp As [String] = ""

        Dim codedataGet As [Byte]()
        Dim strCodedata As [String] = ""
        Dim codeLen As Int32 = 0
        Dim symbolGet As UInt16 = 0

        Try
            '-----------------------------------------------------------
            ' 読み取り(一括)
            '-----------------------------------------------------------
            codeLen = Bt.ScanLib.Control.btScanGetStringSize()
            If codeLen <= 0 Then
                disp = "btScanGetStringSize error ret[" & codeLen & "]"
                MessageBox.Show(disp, "エラー")
                GoTo L_END
            End If
            codedataGet = New [Byte](codeLen - 1) {}

            ret = Bt.ScanLib.Control.btScanGetString(codedataGet, symbolGet)
            If ret <> LibDef.BT_OK Then
                disp = "btScanGetString error ret[" & ret & "]"
                MessageBox.Show(disp, "エラー")
                GoTo L_END
            End If
            strCodedata = System.Text.Encoding.GetEncoding(932).GetString(codedataGet, 0, codeLen)
            ScanFormMethod(strCodedata, ret, disp)
L_END:
            'ret = Bt.ScanLib.Control.btScanDisable()
            'If ret <> LibDef.BT_OK Then
            '    disp = "btScanDisable error ret[" & ret & "]"
            '    MessageBox.Show(disp, "エラー")
            'End If
        Catch e As Exception
            MessageBox.Show(e.ToString())
        End Try
    End Sub

    Public Shared Sub ScanFormMethod(ByVal strdata As String, ByVal ret As Int32, ByVal disp As [String])
        '十の桁は機能毎に統一
        '10　入荷検品
        '20　出荷検品
        Select Case activeform
            Case 0
                MsgBox(strdata)
            Case FormNo.DayForm      'DayForm

            Case FormNo.NyuukoCodeForm    'NyuukoCode
                If ApiControlClass.GetNyuukoCode(strdata) Then
                    activeform = 11
                    My.Forms.NyuukoItem.NyuukaCodeLabel.Text = strdata
                    My.Forms.NyuukoItem.Show()
                Else
                    popUpClass.popUpError("コードが有りません")
                End If

            Case FormNo.NyuukoItemForm    'NyuukoItemForm
                Dim item As stockItemClass = ApiControlClass.GetItem(strdata)
                If item IsNot Nothing Then
                    My.Forms.NyuukoItem.LabelDisp(item)
                End If
            Case FormNo.CodeForm    'CodeForm
                My.Forms.CodeForm.NextForm(strdata)
            Case FormNo.ScanItemForm    'ScanItemForm
                If ShipmentClass.CountUp(strdata, 1) Then
                    With My.Forms.ResultForm
                        .shopLabel.Text = ClientName
                        .shipmentLabel.Text = shipmentNo
                        .TextBox1.Text = ""
                        .Show()
                    End With
                    ScanDisableKeySense()
                    My.Forms.ScanItemForm.Hide()
                End If
            Case FormNo.ItemForm    'ItemForm
                My.Forms.ItemForm.BcodeTextLostFocus(strdata)
            Case FormNo.NewLocaForm    'NewLocaForm
                Dim item As stockItemClass = ApiControlClass.GetItem(strdata)
                If item IsNot Nothing Then
                    My.Forms.NewLocaForm.LabelDisp(item)
                End If
            Case FormNo.LocaMotoForm    'LocaMotoForm
                My.Forms.LocaMotoForm.NextForm(strdata)
            Case FormNo.LocaItemForm    'LocaItemForm
                My.Forms.LocaItemForm.ItemSelect(strdata)
                ScanDisableKeySense()
            Case FormNo.LocaSakiForm    'LocaSakiForm
                ScanDisableKeySense()
                popUpClass.popUpError("移動しました")
                My.Forms.LocaItemForm.ItemClear()
                ScanEnable(True)
                activeform = 40
                My.Forms.LocaMotoForm.Show()
                My.Forms.LocaSakiForm.Hide()
            Case 50

            Case FormNo.LocaStockForm    'ロケーション在庫
                If ApiControlClass.GetLocaStock(strdata) Then
                    ScanDisableKeySense()
                    My.Forms.LocaStockForm.LocaItem(strdata)
                End If
            Case FormNo.StockItemForm    '商品在庫
                If ApiControlClass.GetItemStock(strdata) Then
                    My.Forms.StockItemForm.LabelDisp(0)
                    My.Forms.StockItemForm.StockAll()
                End If
            Case FormNo.ReturnedGoodsForm    '返品処理
                Dim item As stockItemClass = ApiControlClass.GetItem(strdata)
                If item IsNot Nothing Then
                    My.Forms.ReturnedGoodsForm.LabelDisp(item)
                End If
            Case 80

            Case 90
                ScanDisableKeySense()
            Case FormNo.LoginForm

                If ApiControlClass.GetStaff(strdata) Then
                    activeform = 0
                    LgForm.Close()
                End If
        End Select
        'diseble(ret, disp)
    End Sub

    Private Shared Sub diseble(ByVal ret As Int32, ByVal disp As [String])
        ret = Bt.ScanLib.Control.btScanDisable()
        If ret <> LibDef.BT_OK Then
            disp = "btScanDisable error ret[" & ret & "]"
            MessageBox.Show(disp, "エラー")
        End If
    End Sub
    'Private Shared Sub ThreadSleepWithScanDisable(Optional ByVal i As Integer = 200)
    '    ThreadSleep(i)
    '    ScanEnable(False)
    'End Sub
End Class
