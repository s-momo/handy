Imports Newtonsoft.Json
Public Class jsonSerialize
    Private _code As String
    Private _message As String
    Private _data As String()


    Public Property code() As String
        Get
            Return _code
        End Get
        Set(ByVal value As String)
            _code = value
        End Set
    End Property

    Public Property message() As String
        Get
            Return _message
        End Get
        Set(ByVal value As String)
            _message = value
        End Set
    End Property

    Public Property data() As String()
        Get
            Return _data
        End Get
        Set(ByVal value As String())
            _data = value
        End Set
    End Property
End Class
