

Public Class ClassAtividadeBase
    Private _nome As String
    Private _data As Date
    Private _horaInicio As Integer
    Private _horaFim As Integer
    Private _tipo As String


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



    Public Property Data As Date
        Get
            Return _data
        End Get
        Set(value As Date)
            _data = value
        End Set
    End Property

    Public Sub New()

    End Sub


    Public Sub New(ByVal Nome As String, ByVal HoraInicio As Integer, ByVal HoraFim As Integer, ByVal Tipo As String)
        Me.Nome = Nome
        Me.HoraInicio = HoraInicio
        Me.HoraFim = HoraFim
        Me.Tipo = Tipo

    End Sub

End Class
