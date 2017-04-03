Imports handy.ApiConfig
Public Class ApiControlClass

    Public Shared Function GetStaff(ByVal code As String) As Boolean
        Dim rs = ApiCall(URL.GetStaffAndShopsUrl(), HttpMethod.HTTPGET)
        If rs.flg Then
            Dim jc = New JsonParse(rs.ResponceData)
            rs.SetFlg(jc.Parse(ApiConfig.Type.STAFF))
            If rs.flg Then
                rs.SetFlg(jc.Parse(ApiConfig.Type.SHOP))
            End If
        End If
        Return rs.flg
    End Function

    Public Shared Function GetShipment(ByVal code As String) As Boolean
        'テスト--------------------------------------------------------------------------
        Dim rs = ApiCall(URL.GetShipmentUrl("62034748"), HttpMethod.HTTPGET)
        '--------------------------------------------------------------------------------
        'Dim rs = ApiCall(URL.GetShipmentUrl(code), HttpMethod.HTTPGET)
        If rs.flg Then
            Dim jc = New JsonParse(rs.ResponceData)
            rs.SetFlg(jc.Parse(Type.SHIPMENT))
            If rs.flg Then
                'テスト--------------------------------------------------------------------------
                'rs.SetFlg(ChangeShipment("62034748", Convert.ToString(OrderStatusNO.kenpin_tyuu)))
                '---------------------------------------------------------------------------------
            End If
        End If
        Return rs.flg
    End Function

    Public Shared Function GetItemStock(ByVal code As String) As Boolean
        'テスト--------------------------------------------------------
        Dim rs = ApiCall(URL.GetStockItemUrl("200000000429"))
        '---------------------------------------------------------------
        'Dim rs = ApiCall(URL.GetStockItemUrl(code))
        If rs.flg Then
            Dim jc = New JsonParse(rs.ResponceData)
            rs.SetFlg(jc.Parse(Type.ITEMSTOCK))
        End If
        Return rs.flg
    End Function

    Public Shared Function GetLocaStock(ByVal code As String) As Boolean
        'テスト--------------------------------------------------------
        Dim rs = ApiCall(URL.GetStockLocaUrl("8AA02403"))
        '---------------------------------------------------------------
        'Dim rs = ApiCall(URL.GetStockLocaUrl(code))
        If rs.flg Then
            Dim jc = New JsonParse(rs.ResponceData)
            rs.SetFlg(jc.Parse(Type.LOCASTOCK))
        End If
        Return rs.flg
    End Function

    Public Shared Function LocaChange(ByVal bcode As String, ByVal loca As String) As Boolean
        Dim rs = ApiCall(URL.GetLocaChangeURL(bcode, loca))
        If rs.flg Then
            Dim jc = New JsonParse(rs.ResponceData)
            rs.SetFlg(jc.Parse(Type.CHANGELOCA))
        End If
    End Function

    Public Shared Function GetItem(ByVal code As String) As stockItemClass
        Dim api As New ApiAccess
        Return api.GetItem(code, "")
    End Function

    Public Shared Function GetNyuukoCode(ByVal code As String) As Boolean
        Dim api = New ApiAccess
        Return api.GetNyuukoCode(code)
    End Function

    Private Shared Function ApiCall(ByVal URL As String, Optional ByVal method As String = HttpMethod.HTTPGET) As ApiConfig.Responce
        Dim api = New ApiAccess
        Return api.api(URL, method)
    End Function

    Private Shared Function ApiCall(ByVal URL As String, ByVal method As String, ByVal code As String) As ApiConfig.Responce
        Dim api As New ApiAccess
        Return api.api(URL, method, code)
    End Function

    Public Shared Function ChangeShipment(ByVal code As String, ByVal status As String) As Boolean
        Dim rs = ApiCall(URL.ChangeShipmentUrl(code, status))
        Return rs.flg
    End Function

    Public Shared Sub test(ByVal flg As Boolean)
        Dim api As New ApiAccess
        If flg Then
            'ApiControlClass.GetShop("")
            'api.Test()
        Else
            ApiControlClass.GetStaff("")
            'api.TestStr()
        End If
    End Sub
End Class
