﻿Public Class ClassViajante
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

    'Public Overrides Function Pessoa_str() As String
    '    Return MyBase.Pessoa_str() & vbTab & vbTab & Me.Nif
    'End Function

    Public Sub MarcarAtividadeNavio(ByVal novaatividadenavio As ClassAtividadeNavio)
        Dim temp As Boolean = False
        Dim k As Integer = 0

        If Me.AtividadesNavioMarcadas.Count > 0 Then

            While k <= Me.AtividadesNavioMarcadas.Count - 1 And temp = False
                If novaatividadenavio.DataInicio.Date = Me.AtividadesNavioMarcadas(k).DataInicio.Date Then
                    If (novaatividadenavio.DataInicio.Hour >= Me.AtividadesNavioMarcadas(k).DataInicio.Hour And novaatividadenavio.DataInicio.Hour <= Me.AtividadesNavioMarcadas(k).DataFim.Hour) Or (novaatividadenavio.DataFim.Hour >= Me.AtividadesNavioMarcadas(k).DataInicio.Hour And novaatividadenavio.DataFim.Hour <= Me.AtividadesNavioMarcadas(k).DataFim.Hour) Then
                        temp = True
                    End If

                End If
                k = k + 1
            End While

            If temp = False Then
                k = 0
                While k <= Me.AtividadesParagensMarcadas.Count - 1 And temp = False
                    If novaatividadenavio.DataInicio.Date = Me.AtividadesParagensMarcadas(k).DataInicio.Date Then
                        If (novaatividadenavio.DataInicio.Hour >= Me.AtividadesParagensMarcadas(k).DataInicio.Hour And novaatividadenavio.DataInicio.Hour <= Me.AtividadesParagensMarcadas(k).DataInicio.Hour) Or (novaatividadenavio.DataFim.Hour >= Me.AtividadesParagensMarcadas(k).DataInicio.Hour And novaatividadenavio.DataFim.Hour <= Me.AtividadesParagensMarcadas(k).DataFim.Hour) Then
                            temp = True
                        End If

                    End If
                    k = k + 1
                End While
                If temp = False Then
                    Me.AtividadesNavioMarcadas.Add(novaatividadenavio)
                    MsgBox("A atividade foi marcada!")
                Else
                    MsgBox("Já tem uma atividade marcada nesse horário!")

                End If
            Else
                MsgBox("Já tem uma atividade marcada nesse horário!")
            End If
        End If
    End Sub

    Public Sub AnularMarcacaoNavio(ByVal NomeAtividade As String)
        Dim k As Integer = 0
        Dim temp As Boolean = False

        While k <= Me.AtividadesNavioMarcadas.Count - 1 And temp = False
            If Me.AtividadesNavioMarcadas(k).Nome = NomeAtividade Then
                Me.AtividadesNavioMarcadas.RemoveAt(k)
                MsgBox("A marcação desta atividade foi anulada!")
                temp = True
            End If

        End While

        If temp = False Then
            MsgBox("Não tem esta atividade marcada!")
        End If


    End Sub

    Public Sub MarcarAtividadeParagem(ByVal novaatividadeparagem As ClassAtividadeParagens)
        Dim temp As Boolean = False
        Dim k As Integer = 0

        If Me.AtividadesParagensMarcadas.Count > 0 Then

            While k <= Me.AtividadesParagensMarcadas.Count - 1 And temp = False
                If novaatividadeparagem.DataInicio.Date = Me.AtividadesParagensMarcadas(k).DataInicio.Date Then
                    If (novaatividadeparagem.DataInicio.Hour >= Me.AtividadesParagensMarcadas(k).DataInicio.Hour And novaatividadeparagem.DataInicio.Hour <= Me.AtividadesParagensMarcadas(k).DataFim.Hour) Or (novaatividadeparagem.DataFim.Hour >= Me.AtividadesParagensMarcadas(k).DataInicio.Hour And novaatividadeparagem.DataFim.Hour <= Me.AtividadesParagensMarcadas(k).DataFim.Hour) Then
                        temp = True
                    End If

                End If
                k = k + 1
            End While

            If temp = False Then
                k = 0
                While k <= Me.AtividadesNavioMarcadas.Count - 1 And temp = False
                    If novaatividadeparagem.DataInicio.Date = Me.AtividadesNavioMarcadas(k).DataInicio.Date Then
                        If (novaatividadeparagem.DataInicio.Hour >= Me.AtividadesNavioMarcadas(k).DataInicio.Hour And novaatividadeparagem.DataInicio.Hour <= Me.AtividadesNavioMarcadas(k).DataFim.Hour) Or (novaatividadeparagem.DataFim.Hour >= Me.AtividadesNavioMarcadas(k).DataInicio.Hour And novaatividadeparagem.DataFim.Hour <= Me.AtividadesNavioMarcadas(k).DataFim.Hour) Then
                            temp = True
                        End If

                    End If
                    k = k + 1
                End While

                If temp = False Then
                    Me.AtividadesParagensMarcadas.Add(novaatividadeparagem)
                    MsgBox("A atividade foi marcada!")
                Else
                    MsgBox("Já tem uma atividade marcada nesse horário!")
                End If

            Else
                MsgBox("Já tem uma atividade marcada nesse horário!")
            End If
        End If
    End Sub

    Public Sub AnularMarcacaoParagem(ByVal NomeAtividade As String)
        Dim k As Integer = 0
        Dim temp As Boolean = False

        While k <= Me.AtividadesParagensMarcadas.Count - 1 And temp = False
            If Me.AtividadesParagensMarcadas(k).Nome = NomeAtividade Then
                Me.AtividadesParagensMarcadas.RemoveAt(k)
                MsgBox("A marcação desta atividade foi anulada!")
                temp = True
            End If

        End While

        If temp = False Then
            MsgBox("Não tem esta atividade marcada!")
        End If


    End Sub
End Class
