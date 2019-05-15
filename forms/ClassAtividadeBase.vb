Imports TrabalhoPCII

Public Class ClassAtividadeBase
    Private _nome As String
    Private _horaInicio As Integer
    Private _horaFim As Integer
    Private _tipo As String
    Private _npessoas As Integer = 0
    Private _pessoas As ClassViajantes

    Public Property Nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property

    Public Property HoraInicio As Integer
        Get
            Return _horaInicio
        End Get
        Set(value As Integer)
            _horaInicio = value
        End Set
    End Property

    Public Property HoraFim As Integer
        Get
            Return _horaFim
        End Get
        Set(value As Integer)
            _horaFim = value
        End Set
    End Property

    Public Property Tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
        End Set
    End Property

    Public Property Npessoas As Integer
        Get
            Return Me.Pessoas.Count
        End Get
        Set(value As Integer)
            _npessoas = value
        End Set
    End Property

    Public Property Pessoas As ClassViajantes
        Get
            Return _pessoas
        End Get
        Set(value As ClassViajantes)
            _pessoas = value
        End Set
    End Property

    Public Sub New()

    End Sub


    Public Sub New(ByVal Nome As String, ByVal HoraInicio As Integer, ByVal HoraFim As Integer, ByVal Tipo As String)
        Me.Nome = Nome
        Me.HoraInicio = HoraInicio
        Me.HoraFim = HoraFim
        Me.Tipo = Tipo
        Me.Pessoas = New ClassViajantes
    End Sub

    Public Sub Marcar(ByVal Nlogin As Integer)
        Dim k As Integer = 0

        While k <= Me.Npessoas - 1 And Nlogin <> Me.Pessoas(k).Login
            k = k + 1
        End While

        If k = Me.Npessoas - 1 And Nlogin <> Me.Pessoas(k).Login Then
            'usar a variavel globlal para procurar o viajante atraves do login e adiciona-lo a lista de pessoas
        Else
            MsgBox("O viajante indicado já tem marcação!")
        End If



    End Sub

    Public Sub Desmarcar(ByVal Nlogin As Integer)
        Dim k As Integer = 0


        While k <= Me.Npessoas - 1 And Nlogin <> Me.Pessoas(k).Login
            k = k + 1
        End While

        If k = Me.Npessoas - 1 And Nlogin <> Me.Pessoas(k).Login Then
            MsgBox("O viajante indicado não tem marcação!")
        Else
            Me.Pessoas.RemoveAt(k)
        End If


    End Sub

    'No form criar algo para adicionar nova atividade!!!!

End Class
