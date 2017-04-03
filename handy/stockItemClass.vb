Public Class stockItemClass
    Dim _code As String
    Dim _name As String
    Dim _bcode As String
    Dim _suu As Integer
    Dim _Loca As String

    Property code() As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            _code = value
        End Set
    End Property

    Property name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Property bcode() As String
        Get
            Return _bcode
        End Get
        Set(ByVal value As String)
            _bcode = value
        End Set
    End Property

    Property suu() As Integer
        Get
            Return _suu
        End Get
        Set(ByVal value As Integer)
            _suu = value
        End Set
    End Property

    Property loca() As String
        Get
            Return _Loca
        End Get
        Set(ByVal value As String)
            _Loca = value
        End Set
    End Property
End Class
