Imports Bt
Imports Bt.LibDef
Module statsModule
    Public scan As Int32 = 2    '1:個別 2:一括
    Public clientAll As New ArrayList   '荷主一覧
    Public day As String = ""        '日付

    Public LgForm As LoginForm
    '出荷検品用----------------------------------------
    Public ScanMode As Boolean = True    '出荷検品モード判別　True=総スキャン　False=数値入力
    Public shipmentNo As String = ""      '出荷番号
    Public performance As Integer = 0   '実績
    Public itemCountArray As New ArrayList
    Private compCode As New ArrayList    '出荷検品完了コード
    'Public itemAllCount As Integer = 0  '商品総数
    'Public itemCount As Integer = 0     '検品済数量
    '---------------------------------------------------
    '在庫用--------------------------------------------
    Public StockItemArray As New ArrayList   '商品在庫
    '---------------------------------------------------
    'プロパティ用--------------------------------------
    Private _StaffName As String = ""   '使用者名
    Private _StaffCode As String = ""   '使用者コード
    Private _activeForm As Integer      'Form判別用
    Private _ClientName As String = ""  '荷主
    Private _ClientCode As String = ""  '荷主コード
    '---------------------------------------------------

    Public Enum FormNo As Integer
        DayForm = 1
        NyuukoCodeForm = 10
        NyuukoItemForm = 11
        CodeForm = 20
        ScanItemForm = 21
        ItemForm = 22
        NewLocaForm = 30
        LocaMotoForm = 40
        LocaItemForm = 41
        LocaSakiForm = 42
        LocaStockForm = 60
        StockItemForm = 61
        ReturnedGoodsForm = 70
        LoginForm = 99
    End Enum

    Public Function StoN(ByVal st As Object) As Integer
        Return Convert.ToInt32(Convert.ToString(st).Replace("""", String.Empty))
    End Function

    Public Sub ScanEnable(ByVal flg As Boolean)
        If flg Then
            Bt.ScanLib.Control.btScanEnable()
        Else
            Bt.ScanLib.Control.btScanDisable()
        End If
    End Sub

    Public Sub keyget()
        Dim buzzer As BT_BUZZER_PARAM
        Dim vi As BT_VIBRATOR_PARAM
        Bt.SysLib.Device.btBuzzer(0, buzzer)
        Bt.SysLib.Device.btVibrator(0, vi)
        Dim a = Bt.SysLib.Device.btKeySense(0, BT_KEY_CTRG)
        ScanEnable(False)
    End Sub

    Public Sub InputHiragana()
        Bt.SysLib.Display.btSetKeyCharacter(BT_KEYINPUT_HIRAGANA)
    End Sub

    Public Sub InputHaneisuu()
        Dim ret = Bt.SysLib.Display.btSetKeyCharacter(BT_KEYINPUT_HANEISUU)
        If ret <> BT_OK Then
            MsgBox(ret.ToString)
        End If
    End Sub

    Public Sub InputNumber()
        Bt.SysLib.Display.btSetKeyCharacter(BT_KEYINPUT_DIRECT)
    End Sub

    Public Sub TextBoxClear(ByVal ParamArray box() As TextBox)
        For i = 0 To box.Count - 1
            box(i).Text = ""
        Next
    End Sub

    Public Sub TextBoxEnable(ByVal flg As Boolean, ByVal ParamArray box() As TextBox)
        For i = 0 To box.Count - 1
            box(i).Enabled = flg
        Next
    End Sub

    Public Sub LabelClear(ByVal ParamArray Lb() As Label)
        For i = 0 To Lb.Count - 1
            Lb(i).Text = ""
        Next
    End Sub

    Private Sub GetStaff()
        StaffName = ""
        ScanEnable(True)
        activeform = 99
        LgForm = New LoginForm
        LgForm.ShowDialog()
        ScanDisableKeySense()
    End Sub

    Private Function GetShop() As DialogResult
        Dim yes_no As DialogResult
        Dim form As New shopForm
        form.stafflabel.Text = StaffName
        InputHaneisuu()
        yes_no = form.ShowDialog()
        form.Dispose()
        Return yes_no
    End Function

    Public Sub ThreadSleep(ByVal i As Integer)
        System.Threading.Thread.Sleep(i)
    End Sub

    Public Function Login() As Boolean
Fast:
        GetStaff()
        If clientAll.Count <> 0 Then
            Select Case GetShop()
                Case DialogResult.Yes
                    Return True
                Case DialogResult.No
                    Return False
                Case DialogResult.Cancel
                    GoTo Fast
            End Select
        End If
        Return False
    End Function

    Public Sub getClient()
        clientAll.Clear()
        For i = 0 To 5
            Dim shop As New shopClass
            shop.shop_id = CType(i, String)
            shop.shop_name = "テスト会社" & CType(i, String)
            shop.shop_disp = shop.shop_id & shop.shop_name
            clientAll.Add(shop)
        Next
    End Sub

    Public Sub staffNameClear()
        StaffName = ""
    End Sub

    Public Sub shopDataClear()
        ClientName = ""
        ClientCode = ""
        clientAll.Clear()
    End Sub

    Property activeform() As Integer
        Get
            Return _activeForm
        End Get
        Set(ByVal value As Integer)
            _activeForm = value
        End Set
    End Property

    Property StaffName() As String
        Get
            Return _StaffName
        End Get
        Set(ByVal value As String)
            _StaffName = value
        End Set
    End Property

    Property StaffCode() As String
        Get
            Return _StaffCode
        End Get
        Set(ByVal value As String)
            _StaffCode = value
        End Set
    End Property

    Property ClientName() As String
        Get
            Return _ClientName
        End Get
        Set(ByVal value As String)
            _ClientName = value
        End Set
    End Property

    Property ClientCode() As String
        Get
            Return _ClientCode
        End Get
        Set(ByVal value As String)
            _ClientCode = value
        End Set
    End Property

    Public Sub btn_KeyWaite(ByVal kyecode As UInt32)
        Dim ret As Int32 = 0
        Dim disp As [String] = ""
        Dim nowkeyGet As UInt32 = 0
        Try
            '-----------------------------------------------------------
            ' 取得
            '-----------------------------------------------------------
            Do
                ret = Bt.SysLib.Device.btKeySense(kyecode, nowkeyGet)
                If ret <> LibDef.BT_OK Then
                    disp = "btKeySense error ret[" & ret & "]"
                    MessageBox.Show(disp, "エラー")
                    Return
                End If
                Dim strEnable As [String] = ""
                If nowkeyGet <> kyecode Then
                    Exit Do
                End If
                ThreadSleep(100)
            Loop
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try
    End Sub

    Public Sub ScanDisableKeySense()
        btn_KeyWaite(LibDef.BT_KEY_STRG)
        btn_KeyWaite(LibDef.BT_KEY_CTRG)
        ThreadSleep(300)
        ScanEnable(False)
    End Sub

    Public Sub ShipmentClear()
        shipmentNo = ""
        itemCountArray.Clear()
    End Sub

    Public Sub ShipmentClearAll()
        ShipmentClear()
        compCode.Clear()
        performance = 0
    End Sub

End Module
