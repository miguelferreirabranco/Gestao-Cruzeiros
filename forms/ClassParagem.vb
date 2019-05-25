Public Class ClassParagem
    Private _localParagem As String
    Private _data As Date
    Private _horaInicio As Date
    Private _horaFim As Date

    Public Property LocalParagem As String
        Get
            Return _localParagem
        End Get
        Set(value As String)
            _localParagem = value
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

    Public Sub New()

    End Sub

    Public Sub New(ByVal localparagem As String, ByVal data As Date, ByVal horainicio As Date, ByVal horafim As Date)
        Me.LocalParagem = localparagem
        Me.Data = data
        Me.HoraInicio = horainicio
        Me.HoraFim = horafim

    End Sub

    Public Function ParaString() As String
        Return Me.LocalParagem & vbTab & Me.Data & vbTab & Me.HoraInicio & vbTab & Me.HoraFim
    End Function
End Class
