Public Class Quarto
    Private _npessoas As Integer
    Private _nquarto As Integer
    Private _ppessoa As Single
    Private _userNumber As String

    Public Property Npessoas As Integer
        Get
            Return _npessoas
        End Get
        Set(value As Integer)
            _npessoas = value
        End Set
    End Property

    Public Property Nquarto As Integer
        Get
            Return _nquarto
        End Get
        Set(value As Integer)
            _nquarto = value
        End Set
    End Property

    Public Property Ppessoa As Single
        Get
            Return _ppessoa
        End Get
        Set(value As Single)
            _ppessoa = value
        End Set
    End Property

    Public Property UserNumber As String
        Get
            Return _userNumber
        End Get
        Set(value As String)
            _userNumber = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(npessoas As Integer, nquarto As Integer, ppessoa As Single)
        _npessoas = npessoas
        _nquarto = nquarto
        _ppessoa = ppessoa
        _userNumber = ""
    End Sub
    Public Sub Reservar(Nome As String)
        If Me.UserNumber = "" Then
            Me.UserNumber = Nome
        Else
            MsgBox("O quarto em questao já se encontra reservado")
        End If
    End Sub
    Public Sub AnularReserva(Nome As String)
        If Me.UserNumber = Nome Then
            Me.UserNumber = ""
        Else
            MsgBox("O quarto em questao nao se encontra reservado ou n esta reservado por si")
        End If
    End Sub
End Class

