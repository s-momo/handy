Imports Newtonsoft.Json
Imports handy.ApiConfig.Type
Imports handy.ApiConfig

Public Class JsonParse
    Private jobj As Linq.JObject

    Private Class JsonKey
        Friend Const CODE As String = "code"
        Friend Const MESSAGE As String = "message"
        Friend Const MESSAGE_OK As String = ""
        Friend Const DATA As String = "data"
        Friend Const UPDATE As String = "update"

        Friend Class StatusCode
            Friend Const OK As Integer = 0
        End Class

        Friend Class Login
            Friend Const ACCOUNT_ID As String = "account_id"
            Friend Const NAME As String = "name"
        End Class

        Friend Class Shop
            Friend Const SHOPS As String = "shops"
            Friend Const SHOP_ID As String = "shop_id"
            Friend Const SHOP_NAME As String = "name"
        End Class

        Friend Class Order

            Friend Const ORDER_ID As String = "order_id"
            Friend Const TRACKING_NO As String = "tracking_no"
            Friend Const STATUS As String = "status"
            Friend Const ITEMS As String = "items"
            Friend Const BARCODE As String = "barcode"
            Friend Const CODE As String = "code"
            Friend Const NAME As String = "name"
            Friend Const NUM As String = "num"
        End Class

        Friend Class Stock
            Friend Const NAME As String = "name"
            Friend Const CODE As String = "code"
            Friend Const BARCODE As String = "barcode"
            Friend Const LOCATION As String = "location1"
            Friend Const STOCK As String = "stock"
            Friend Const ZAIKO As String = "zaiko"
        End Class
    End Class

    Public Sub New(ByVal json As String)
        Me.jobj = Linq.JObject.Parse(json)
    End Sub

    Public Function Parse(ByVal type As String)
        Try
            If CheckCode() AndAlso CheckMessage() Then
                Select Case type
                    Case STAFF
                        ParseStaff()
                    Case SHOP
                        clientAll.Clear()
                        ParseShop()
                    Case SHIPMENT
                        itemCountArray.Clear()
                        ParseShipment()
                    Case ITEMSTOCK
                        StockItemArray.Clear()
                        ParseItemStock()
                    Case LOCASTOCK
                        StockItemArray.Clear()
                        ParseLocaStock()
                    Case CHANGELOCA
                        ParseChangeLoca()
                    Case RETURNE
                        ParseReturne()
                    Case Else
                        popUpClass.popUpError("ParseTypeが不明です")
                        Return False
                End Select
                Return True
            End If
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function
    'スタッフjsonパース
    Private Sub ParseStaff()
        Try
            StaffName = jobj(JsonKey.DATA)(1)(JsonKey.Login.NAME)
            StaffCode = jobj(JsonKey.DATA)(1)(JsonKey.Login.ACCOUNT_ID)
        Catch ex As Exception
            exErrorMessage(ex)
            Throw
        End Try
    End Sub
    '荷主jsonパース
    Private Sub ParseShop()
        Try
            '   エラーテスト-----------------------
            'Dim jdata = Me.jobj(JsonKey.Order.NAME)
            '--------------------------------------
            Dim jdata = Me.jobj(JsonKey.DATA)
            For Each shopdata In jdata(1)(JsonKey.Shop.SHOPS)
                Dim shop As New shopClass
                shop.shop_id = shopdata(JsonKey.Shop.SHOP_ID)
                shop.shop_name = shopdata(JsonKey.Shop.SHOP_NAME)
                shop.shop_disp = shop.shop_id + shop.shop_name
                clientAll.Add(shop)
            Next
        Catch ex As Exception
            exErrorMessage(ex)
            Throw
        End Try
    End Sub
    '出荷検品商品jsonパース
    Private Sub ParseShipment()
        Try
            Dim jdata = Me.jobj(JsonKey.DATA)(1)
            If StoN(jdata(JsonKey.Order.STATUS)) = OrderStatusNO.mikenpinn Then
                shipmentNo = jdata(JsonKey.Order.ORDER_ID)
                For Each item In jdata(JsonKey.Order.ITEMS)
                    Dim itemct As New itemCount
                    itemct.code = item(JsonKey.Order.CODE)
                    itemct.gname = item(JsonKey.Order.NAME)
                    itemct.bcode = item(JsonKey.Order.BARCODE)
                    itemct.suu = StoN(item(JsonKey.Order.NUM))
                    itemCountArray.Add(itemct)
                Next
            Else
                Throw New Exception(ErrorStatus(Convert.ToInt32(jdata(JsonKey.Order.STATUS))))
            End If
        Catch ex As Exception
            exErrorMessage(ex)
            Throw
        End Try
    End Sub
    '商品在庫jsonパース
    Private Sub ParseItemStock()
        Try
            Dim items = Me.jobj(JsonKey.DATA)
            If items.Count() = 0 Then
                Throw New Exception("該当データが有りません")
            Else
                'For Each item In items(1)
                Dim item = items(1)
                Dim stock As New stockItemClass
                stock.name = item(JsonKey.Stock.NAME)
                stock.code = item(JsonKey.Stock.CODE)
                stock.bcode = item(JsonKey.Stock.BARCODE)
                stock.loca = item(JsonKey.Stock.LOCATION)
                stock.suu = StoN(item(JsonKey.Stock.STOCK))
                StockItemArray.Add(stock)
                'Next
            End If
        Catch ex As Exception
            exErrorMessage(ex)
            Throw
        End Try
    End Sub
    'ロケーション在庫jsonパース
    Private Sub ParseLocaStock()
        Try
            If Me.jobj(JsonKey.DATA).Count = 0 Then
                Throw New Exception("該当データが有りません")
            Else
                For Each item In Me.jobj(JsonKey.DATA)
                    Dim stock As New stockItemClass
                    stock.loca = item(JsonKey.Stock.LOCATION)
                    stock.bcode = item(JsonKey.Stock.BARCODE)
                    stock.code = item(JsonKey.Stock.CODE)
                    stock.name = item(JsonKey.Stock.NAME)
                    stock.suu = StoN(item(JsonKey.Stock.ZAIKO))
                    StockItemArray.Add(stock)
                Next
            End If
        Catch ex As Exception
            exErrorMessage(ex)
            Throw
        End Try
    End Sub
    'ロケーション変更
    Private Sub ParseChangeLoca()
        Try
            Dim item = Me.jobj(JsonKey.DATA)
            If item.Count() = 0 AndAlso StoN(item(1)(JsonKey.UPDATE)) = 0 Then
                Throw New Exception("移動に失敗しました")
            Else
                popUpClass.PopUpOk("ロケーションを移動しました")
            End If
        Catch ex As Exception
            exErrorMessage(ex)
            Throw
        End Try
    End Sub
    '返品処理
    Private Sub ParseReturne()

    End Sub

    Private Function CheckCode() As Boolean
        Try
            If StoN(Me.jobj(JsonKey.CODE)) = JsonKey.StatusCode.OK Then Return True
            ErrorCode(Convert.ToInt32(Me.jobj(JsonKey.CODE)))
            Return False
        Catch ex As Exception
            popUpClass.BackColor(Color.Gray)
            exErrorMessage(ex)
        End Try
    End Function

    Private Function CheckMessage() As Boolean
        Try
            If Me.jobj(JsonKey.MESSAGE) = JsonKey.MESSAGE_OK Then Return True
            ErrorJsonData()
            Return False
        Catch ex As Exception
            popUpClass.BackColor(Color.Pink)
            exErrorMessage(ex)
            Return False
        End Try
    End Function

    Private Sub ErrorCode(ByVal code As Integer)
        Dim messagDisp As String = ""
        Select Case code
            Case 0
                messagDisp = "プログラムエラー"
            Case Else
                messagDisp = "エラーコードは" & Convert.ToString(code) & "です"
        End Select
        popUpClass.popUpError(messagDisp)
    End Sub

    Private Sub exErrorMessage(ByVal ex As Exception)
        popUpClass.popUpError(ex.Message)
    End Sub

    Private Sub ErrorJsonData()
        popUpClass.BackColor(Color.Pink)
        Dim msg As String
        Select Case Me.jobj(JsonKey.MESSAGE)
            Case "array_values() expects parameter 1 to be array, null given"
                msg = "該当データが有りません"
            Case Else
                msg = Me.jobj(JsonKey.MESSAGE)
        End Select
        popUpClass.popUpError(msg)
    End Sub

    Private Function ErrorStatus(ByVal statusNo As Integer) As String
        Dim messagDisp As String = ""
        Select Case statusNo
            Case OrderStatusNO.kenpin_tyuu
                messagDisp = "検品中です"
            Case OrderStatusNO.kenpin_OK
                messagDisp = "検品済みです"
            Case Else
                messagDisp = "ステータスが不明です"
        End Select
        Return messagDisp
    End Function
End Class
