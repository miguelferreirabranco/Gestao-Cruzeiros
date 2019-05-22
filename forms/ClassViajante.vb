Public Class ClassViajante
    Inherits ClassUtilizador

    Private _nif As String
    Public CruzeirosMarcados As ClassCruzeiros
    Public QuartosMarcados As ClassQuartos
    Public AtividadesNavioMarcadas As ClassAtividadesNavio
    Public AtividadesParagensMarcadas As ClassAtividadesParagens

    Public Sub New()

    End Sub

    Public Sub New(ByVal nome As String, ByVal sexo As String, ByVal data As Date, ByVal cc As String,
                   ByVal login As String, ByVal pass As String, ByVal nif As String)
        MyBase.New(nome, sexo, data, cc, login, pass)
        Me._nif = nif
    End Sub

    Public Property Nif As String
        Get
            Return _nif
        End Get
        Set(value As String)
            _nif = value
        End Set
    End Property

    Public Overrides Function Pessoa_str() As String
        Return MyBase.Pessoa_str() & vbTab & Me.Nif
    End Function

    Public Sub MarcarAtividadeNavio(ByVal atividadenavio As ClassAtividadeNavio)
        Dim temp As Boolean = False
        Dim k As Integer

        Me.AtividadesNavioMarcadas.Add(atividadenavio)
    End Sub



End Class
