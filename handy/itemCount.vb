Public Class itemCount
    Private _code As String
    Private _name As String
    Private _bcode As String
    Private _suu As Integer
    Private _zitu_suu As Integer

    Property code() As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            _code = value
        End Set
    End Property

    Property gname() As String
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
    Property zitu_suu() As Integer
        Get
            Return _zitu_suu
        End Get
        Set(ByVal value As Integer)
            _zitu_suu = value
        End Set
    End Property
End Class
