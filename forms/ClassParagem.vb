Public Class ClassParagem
    Private _localParagem As String
    Private _dia As Integer
    Private _horaInicio As Integer
    Private _horaFim As Integer

    Public Property LocalParagem As String
        Get
            Return _localParagem
        End Get
        Set(value As String)
            _localParagem = value
        End Set
    End Property

    Public Property Dia As Integer
        Get
            Return _dia
        End Get
        Set(value As Integer)
            _dia = value
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

    Public Sub New()

    End Sub

    Public Sub New(ByVal localparagem As String, ByVal dia As Integer, ByVal horainicio As Integer, ByVal horafim As Integer)
        Me.LocalParagem = localparagem
        Me.Dia = dia
        Me.HoraInicio = horainicio
        Me.HoraFim = horafim

    End Sub
End Class
