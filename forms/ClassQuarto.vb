Public Class ClassQuarto
    Private _seccao As String
    Private _npessoas As Integer
    Private _nquarto As Integer
    Private _ppessoa As Single
    Private _NomedeReserva As String


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



    Public Property Nomedereserva As String
        Get
            Return _NomedeReserva
        End Get
        Set(value As String)
            _NomedeReserva = value
        End Set
    End Property

    Public Property Seccao As String
        Get
            Return _seccao
        End Get
        Set(value As String)
            _seccao = value
        End Set
    End Property


    Public Sub New()
    End Sub

    Public Sub New(ByVal npessoas As Integer, ByVal nquarto As Integer, ByVal ppessoa As Single, ByVal seccao As String)
        Me.Npessoas = npessoas
        Me.Nquarto = nquarto
        Me.Ppessoa = ppessoa
        Me.Seccao = seccao
        Me.Nomedereserva = ""
    End Sub

    Public Sub Reservar(ByVal Nome As String)
        If Me.Nomedereserva = "" Then
            Me.Nomedereserva = Nome
            MsgBox("Reservou o quarto nº " & Me.Nquarto & "!")
            gravar()
        Else
            MsgBox("O quarto em questão já se encontra reservado!")
        End If


    End Sub
    Public Sub AnularReserva(ByVal Nome As String)
        If Me.Nomedereserva = Nome Then
            Me.Nomedereserva = ""
            MsgBox("Anulou a reserva do quarto nº " & Me.Nquarto & "!")
            gravar()
        ElseIf Me.Nomedereserva = "" Then
            MsgBox("O quarto em questão não se encontra reservado!")
        Else
            MsgBox("O quarto em questão não está reservado por si!")

        End If
    End Sub


    Public Function Reservado() As Boolean
        Dim temp As Boolean = False
        If Me.Nomedereserva = "" Then
            temp = False
        Else
            temp = True
        End If
        Return temp
    End Function

End Class

