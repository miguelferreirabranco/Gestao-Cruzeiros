Public Class ClassParagem
    Private _localParagem As String
    Private _data As Date
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

    Public Property Data As Date
        Get
            Return _data
        End Get
        Set(value As Date)
            _data = value
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

    Public Sub New(ByVal localparagem As String, ByVal data As Date, ByVal horainicio As Integer, ByVal horafim As Integer)
        Me.LocalParagem = localparagem
        Me.Data = data
        Me.HoraInicio = horainicio
        Me.HoraFim = horafim

    End Sub

    Public Function ParaString() As String
        Return Me.LocalParagem & vbTab & Me.Data & vbTab & Me.HoraInicio & vbTab & Me.HoraFim
    End Function
End Class
