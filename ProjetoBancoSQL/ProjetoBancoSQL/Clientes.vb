Public Class Clientes
    Private _CODCLI As Integer
    Private _NOMECLI As String
    Private _ENDCLI As String
    Private _TELCLI As String

    Public Property CODCLI As Integer
        Get
            Return _CODCLI
        End Get
        Set(value As Integer)
            _CODCLI = value
        End Set
    End Property

    Public Property NOMECLI As String
        Get
            Return _NOMECLI
        End Get
        Set(value As String)
            _NOMECLI = value
        End Set
    End Property

    Public Property ENDCLI As String
        Get
            Return _ENDCLI
        End Get
        Set(value As String)
            _ENDCLI = value
        End Set
    End Property

    Public Property TELCLI As String
        Get
            Return _TELCLI
        End Get
        Set(value As String)
            _TELCLI = value
        End Set
    End Property
End Class
