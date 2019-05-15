Public Class ClassFuncionario
    Inherits ClassUtilizador

    Private _nib As String

    Public Sub New()

    End Sub

    Public Sub New(ByVal nome As String, ByVal sexo As String, ByVal data As Date, ByVal cc As String,
                  ByVal login As String, ByVal pass As String, ByVal nib As String)
        MyBase.New(nome, sexo, data, cc, login, pass)
        Me._nib = nib
    End Sub

    Public Property Nib As String
        Get
            Return _nib
        End Get
        Set(value As String)
            _nib = value
        End Set
    End Property
End Class
