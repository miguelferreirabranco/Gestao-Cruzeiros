Public Class Utilizador
    Private _nome As String
    Private _sexo As String
    Private _data_nasc As Date
    Private _idade As Integer
    Private _numero_cc As String
    Private _login As String
    Private _password As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal nome As String, ByVal sexo As String, ByVal data As Date, ByVal cc As String)
        Me._nome = nome
        Me._sexo = sexo
        Me._data_nasc = data
        Me._numero_cc = cc
    End Sub

    Public Sub New(ByVal nome As String, ByVal sexo As String, ByVal data As Date, ByVal cc As String,
                   ByVal login As String, ByVal pass As String)
        Me._nome = nome
        Me._sexo = sexo
        Me._data_nasc = data
        Me._numero_cc = cc
        Me._login = login
        Me._password = pass
    End Sub

    Public Property Nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property

    Public Property Sexo As String
        Get
            Return _sexo
        End Get
        Set(value As String)
            _sexo = value
        End Set
    End Property

    Public Property Data_nasc As Date
        Get
            Return _data_nasc
        End Get
        Set(value As Date)
            _data_nasc = value
        End Set
    End Property

    Public Property Idade As Integer
        Get
            Return DateDiff(DateInterval.Year, _data_nasc, Today)
        End Get
        Set(value As Integer)
            _idade = value
        End Set
    End Property

    Public Property Numero_cc As String
        Get
            Return _numero_cc
        End Get
        Set(value As String)
            _numero_cc = value
        End Set
    End Property

    Public Property Login As String
        Get
            Return _login
        End Get
        Set(value As String)
            _login = value
        End Set
    End Property

    Public Property Password As String
        Get
            Return _password
        End Get
        Set(value As String)
            _password = value
        End Set
    End Property
End Class
