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

    Public Sub MarcarAtividadeNavio(ByVal novaatividadenavio As ClassAtividadeNavio)
        Dim temp As Boolean = False
        Dim k As Integer = 0

        If Me.AtividadesNavioMarcadas.Count > 0 Then

            While k <= Me.AtividadesNavioMarcadas.Count - 1 And temp = False
                If novaatividadenavio.Data = Me.AtividadesNavioMarcadas(k).Data Then
                    If (novaatividadenavio.HoraInicio >= Me.AtividadesNavioMarcadas(k).HoraInicio And novaatividadenavio.HoraInicio <= Me.AtividadesNavioMarcadas(k).HoraFim) Or (novaatividadenavio.HoraFim >= Me.AtividadesNavioMarcadas(k).HoraInicio And novaatividadenavio.HoraFim <= Me.AtividadesNavioMarcadas(k).HoraFim) Then
                        temp = True
                    End If

                End If
                k = k + 1
            End While

            If temp = False Then
                Me.AtividadesNavioMarcadas.Add(novaatividadenavio)
            Else
                MsgBox("Já tem uma atividade marcada nesse horário!")
            End If
        End If
    End Sub

    Public Sub AnularMarcacaoNavio(ByVal NomeAtividade As String)
        Dim k As Integer = 0
        Dim temp As Boolean = False

        While k <= Me.AtividadesNavioMarcadas.Count And temp = False
            If Me.AtividadesNavioMarcadas(k).Nome = NomeAtividade Then
                Me.AtividadesNavioMarcadas.RemoveAt(k)
                temp = True
            End If

        End While

        If temp = False Then
            MsgBox("Não tem esta atividade marcada!")
        End If


    End Sub

    Public Sub MarcarAtividadeParagem(ByVal novaatividadeparagem As ClassAtividadeParagem)
        Dim temp As Boolean = False
        Dim k As Integer = 0

        If Me.AtividadesNavioMarcadas.Count > 0 Then

            While k <= Me.AtividadesNavioMarcadas.Count - 1 And temp = False
                If novaatividadenavio.Data = Me.AtividadesNavioMarcadas(k).Data Then
                    If (novaatividadenavio.HoraInicio >= Me.AtividadesNavioMarcadas(k).HoraInicio And novaatividadenavio.HoraInicio <= Me.AtividadesNavioMarcadas(k).HoraFim) Or (novaatividadenavio.HoraFim >= Me.AtividadesNavioMarcadas(k).HoraInicio And novaatividadenavio.HoraFim <= Me.AtividadesNavioMarcadas(k).HoraFim) Then
                        temp = True
                    End If

                End If
                k = k + 1
            End While

            If temp = False Then
                Me.AtividadesNavioMarcadas.Add(novaatividadenavio)
            Else
                MsgBox("Já tem uma atividade marcada nesse horário!")
            End If
        End If
    End Sub

End Class
