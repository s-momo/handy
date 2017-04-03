Public Class shopClass
    Dim _shop_id As String
    Dim _shop_name As String
    Dim _shop_disp As String

    Property shop_id() As String
        Get
            Return _shop_id
        End Get
        Set(ByVal value As String)
            _shop_id = value
        End Set
    End Property

    Property shop_name() As String
        Get
            Return _shop_name
        End Get
        Set(ByVal value As String)
            _shop_name = value
        End Set
    End Property

    Property shop_disp() As String
        Get
            Return _shop_disp
        End Get
        Set(ByVal value As String)
            _shop_disp = value
        End Set
    End Property
End Class
