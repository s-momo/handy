Imports System.Text
Imports System.Net
Imports handy.ApiConfig.URL
Imports handy.ApiConfig.HttpMethod


Public Class ApiAccess
    Private enc As Encoding = Encoding.UTF8
    Private rs As ApiConfig.Responce
    Public Sub New()
        ServicePointManager.CertificatePolicy = New MyPolicy()
        Me.rs = New ApiConfig.Responce
    End Sub

    Public Function api(ByRef url As String, ByRef method As String) As ApiConfig.Responce
        Dim webreq As WebRequest = WebRequest.Create(url)
        webreq.Method = method
        Me.access(webreq)
        Return Me.rs
    End Function

    Private Sub access(ByRef webreq As WebRequest)
        Dim webres As WebResponse = Nothing
        Dim st As System.IO.Stream = Nothing
        Dim sr As System.IO.StreamReader = Nothing
        Try
            webres = webreq.GetResponse()
            st = webres.GetResponseStream()
            sr = New System.IO.StreamReader(st, Me.enc)
            Me.rs.SetResponceData(sr.ReadToEnd())
        Catch ex As Exception
            Me.rs.SetEx(ex)
            popUpClass.BackColor(Color.Yellow)
            popUpClass.popUpError(ex.Message)
        Finally
            If sr IsNot Nothing Then sr.Close()
            If st IsNot Nothing Then st.Close()
            If webres IsNot Nothing Then webres.Close()
        End Try
    End Sub

    Public Function GetItem(ByVal code As String) As String
        Return ""
    End Function
 
    Private Sub ApiMethodError()
        popUpClass.popUpError("HTTPメソッドが不正です")
    End Sub

    '---------------------------------------------------------------------
    'テスト用メソッド
    '---------------------------------------------------------------------
    Public Function api(ByRef url As String, ByRef method As String, ByVal code As String) As ApiConfig.Responce
        Select Case url
            Case STAFF_URL
                Select Case method
                    Case HTTPGET
                        StaffName = "テスト太郎" & code
                        StaffCode = code
                    Case Else
                        ApiMethodError()
                End Select
            Case SHOP_URL
                Dim rs = New ApiConfig.Responce
                rs.SetResponceData(TestStr())
                Return rs
                'For i = 0 To 5
                '    Dim shop As New shopClass
                '    shop.shop_id = CType(i, String)
                '    shop.shop_name = "テスト会社" & CType(i, String)
                '    shop.shop_disp = shop.shop_name & shop.shop_id
                '    clientAll.Add(shop)
                'Next

            Case SHIPMENT_URL
                shipmentNo = "4939027000518"
                itemCountArray.Clear()
                For i = 0 To 1
                    Dim item As New itemCount
                    If i = 0 Then
                        item.bcode = "4939027000518"
                        item.gname = "ティッシュ"
                        item.suu = 4
                        item.zitu_suu = 0
                    Else
                        item.bcode = "4902102110846"
                        item.gname = "紅茶"
                        item.suu = 2
                        item.zitu_suu = 0
                    End If
                    itemCountArray.Add(item)
                Next

            Case ITEMSTOCK_URL
                StockItemArray.Clear()
                If code = "4939027000518" Then
                    For i = 0 To 1
                        Dim item As New stockItemClass
                        If i = 0 Then
                            item.name = "ティッシュ"
                            item.code = "aaaaaaaaaaaaa"
                            item.bcode = "4939027000518"
                            item.suu = 40
                            item.loca = "AAAA-111199"
                        Else
                            item.name = "タラタラしてんじゃねーよ"
                            item.code = "bbbbbbbbbb"
                            item.bcode = "4903041201282"
                            item.suu = 200
                            item.loca = "BBBB-000088"
                        End If
                        StockItemArray.Add(item)
                    Next
                ElseIf code = "4903041201282" Then
                    Dim item As New stockItemClass
                    item.name = "タラタラしてんじゃねーよ"
                    item.code = "bbbbbbbbbb"
                    item.bcode = "4903041201282"
                    item.suu = 20
                    item.loca = "BBBB-000088"
                    StockItemArray.Add(item)
                Else
                    popUpClass.popUpError("該当商品が有りません。")
                End If
            Case LOCASTOCK_URL
                StockItemArray.Clear()
                If code = "4939027000518" Then
                    For i = 0 To 1
                        Dim item As New stockItemClass
                        If i = 0 Then
                            item.name = "ティッシュ"
                            item.code = "aaaaaaaaaaaaa"
                            item.bcode = "4939027000518"
                            item.suu = 40
                            item.loca = "AAAA-111199"
                        Else
                            item.name = "タラタラしてんじゃねーよ"
                            item.code = "bbbbbbbbbb"
                            item.bcode = "4903041201282"
                            item.suu = 200
                            item.loca = "AAAA-111199"
                        End If
                        StockItemArray.Add(item)
                    Next
                ElseIf code = "4903041201282" Then
                    Dim item As New stockItemClass
                    item.name = "タラタラしてんじゃねーよ"
                    item.code = "bbbbbbbbbb"
                    item.bcode = "4903041201282"
                    item.suu = 20
                    item.loca = "BBBB-000088"
                    StockItemArray.Add(item)
                Else
                    popUpClass.popUpError("該当商品が有りません。")
                End If

            Case RETURNE_URL
                If code = "4939027000518" Then
                    Dim item As New stockItemClass
                    item.name = "ティッシュ"
                    item.code = "aaaaaaaaaaaaa"
                    item.bcode = "4939027000518"
                    item.suu = 40
                    item.loca = "AAAA-111199"
                End If
        End Select
        Return Nothing
    End Function

    Public Function GetItem(ByVal code As String, ByVal test As String) As stockItemClass
        Dim item As New stockItemClass
        If code = "4939027000518" Then
            item.name = "ティッシュ"
            item.code = "aaaaaaaaaaaaa"
            item.bcode = "4939027000518"
            item.suu = 40
        ElseIf code = "4903041201282" Then
            item.name = "タラタラしてんじゃねーよ"
            item.code = "bbbbbbbbbb"
            item.bcode = "4903041201282"
            item.suu = 20
        Else
            popUpClass.popUpError("該当商品が有りません。")
            Return Nothing
        End If
        Return item
    End Function

    Public Function GetNyuukoCode(ByVal code As String) As Boolean
        If code = "4939027000518" Then
            Return True
        End If
        Return False
    End Function

    Public Sub Test()
        Dim test = New jsonSerialize
        test.code = "0"
        test.message = ""
        test.data = New String() {"1", "2", "3", "4"}
        Dim disp As String = Newtonsoft.Json.JsonConvert.SerializeObject(test, Newtonsoft.Json.Formatting.Indented)
        MessageBox.Show(disp)
    End Sub

    Public Function TestStr()
        Dim str As String = "{""code"":0,""message"":"""",""data"":[""result"",{""account_id"":""0"",""name"":""\u62c5\u5f53\u8005"",""shops"":[{""shop_id"":""538"",""name"":""\u682a\u5f0f\u4f1a\u793e \u30b9\u30bf\u30a4\u30eb\u30b2\u30fc\u30c8""},{""shop_id"":""539"",""name"":""\u30b0\u30eb\u30fc\u30dd\u30f3\u30fb\u30b5\u30fc\u30d3\u30b9\u682a\u5f0f\u4f1a\u793e""}]}]}"
        Return str
    End Function
    '---------------------------------------------------------------------

End Class
