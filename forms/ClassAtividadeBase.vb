

Public Class ClassAtividadeBase
    Private _nome As String
    Private _data As Date
    Private _horaInicio As Date
    Private _horaFim As Date
    Private _tipo As String


    Public Property Nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property

    Public Property HoraInicio As Date
        Get
            Return _horaInicio
        End Get
        Set(value As Date)
            _horaInicio = value
        End Set
    End Property

    Public Property HoraFim As Date
        Get
            Return _horaFim
        End Get
        Set(value As Date)
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


    Public Sub New(ByVal Nome As String, ByVal HoraInicio As Date, ByVal HoraFim As Date, ByVal Tipo As String)
        Me.Nome = Nome
        Me.HoraInicio = HoraInicio
        Me.HoraFim = HoraFim
        Me.Tipo = Tipo

    End Sub

    Public Overridable Function AtividadeParaString() As String
        Return Me.Nome & vbTab & Me.Tipo & vbTab & Me.Data & vbTab & Me.HoraInicio & vbTab & Me.HoraFim
    End Function

End Class
