Public Class ClassAtividadeParagens

    Inherits ClassAtividadeBase

    Private _paragem As ClassParagem
    Private _localavisitar As String

    Public Property Paragem As ClassParagem
        Get
            Return _paragem
        End Get
        Set(value As ClassParagem)
            _paragem = value
        End Set
    End Property

    Public Property LocalaVisitar As String
        Get
            Return _localavisitar
        End Get
        Set(value As String)
            _localavisitar = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal Nome As String, ByVal HoraInicio As Date, ByVal HoraFim As Date, ByVal Tipo As String, ByVal Paragem As ClassParagem, ByVal Localavisitar As String)
        MyBase.New(Nome, HoraInicio, HoraFim, Tipo)
        Me.Paragem = Paragem
        Me.LocalaVisitar = Localavisitar
    End Sub
    Public Overrides Function AtividadeParaString() As String
        Return MyBase.AtividadeParaString() & vbTab & Me.Paragem.LocalParagem & vbTab & Me.LocalaVisitar
    End Function
End Class
