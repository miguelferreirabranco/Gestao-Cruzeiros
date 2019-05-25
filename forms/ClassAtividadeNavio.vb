Public Class ClassAtividadeNavio

    Inherits ClassAtividadeBase

    Private _seccaoNavio As String

    Public Property SeccaoNavio As String
        Get
            Return _seccaoNavio
        End Get
        Set(value As String)
            _seccaoNavio = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal Nome As String, ByVal HoraInicio As Integer, ByVal HoraFim As Integer, ByVal Tipo As String, ByVal SeccaoNavio As String)
        MyBase.New(Nome, HoraInicio, HoraFim, Tipo)
        Me.SeccaoNavio = SeccaoNavio
    End Sub

    Public Overrides Function AtividadeParaString() As String
        Return MyBase.AtividadeParaString() & vbTab & Me.SeccaoNavio
    End Function
End Class
