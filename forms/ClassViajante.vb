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


    Public Sub MarcarAtividadeNavio(ByVal novaatividadenavio As ClassAtividadeNavio)
        Dim temp As Boolean = False
        Dim k As Integer = 0


        If Me.AtividadesNavioMarcadas.Count > 0 Then

            While k <= Me.AtividadesNavioMarcadas.Count - 1 And temp = False
                If novaatividadenavio.DataInicio.Day = Me.AtividadesNavioMarcadas(k).DataInicio.Day Then
                    If novaatividadenavio.DataInicio.Hour < Me.AtividadesNavioMarcadas(k).DataInicio.Hour And novaatividadenavio.DataFim.Hour = Me.AtividadesNavioMarcadas(k).DataInicio.Hour Then
                        If novaatividadenavio.DataFim.Minute > Me.AtividadesNavioMarcadas(k).DataInicio.Minute Then
                            temp = True
                        End If
                    ElseIf novaatividadenavio.DataInicio.Hour < Me.AtividadesNavioMarcadas(k).DataInicio.Hour And novaatividadenavio.DataFim.Hour > Me.AtividadesNavioMarcadas(k).DataInicio.Hour Then
                        temp = True
                    ElseIf novaatividadenavio.DataInicio.Hour = Me.AtividadesNavioMarcadas(k).DataInicio.Hour And novaatividadenavio.DataFim.Hour = Me.AtividadesNavioMarcadas(k).DataInicio.Hour Then
                        If novaatividadenavio.DataInicio.Minute < Me.AtividadesNavioMarcadas(k).DataInicio.Minute And novaatividadenavio.DataFim.Minute > Me.AtividadesNavioMarcadas(k).DataInicio.Minute Then
                            temp = True
                        End If


                    ElseIf novaatividadenavio.DataInicio.Hour >= Me.AtividadesNavioMarcadas(k).DataInicio.Hour And novaatividadenavio.DataInicio.Hour < Me.AtividadesNavioMarcadas(k).Datafim.Hour And novaatividadenavio.DataFim.hour >= Me.AtividadesNavioMarcadas(k).datafim.hour Then
                        temp = True
                    ElseIf novaatividadenavio.DataInicio.Hour = Me.AtividadesNavioMarcadas(k).DataFim.Hour And novaatividadenavio.Datafim.Hour = Me.AtividadesNavioMarcadas(k).DataFim.Hour Then
                        If novaatividadenavio.DataInicio.Minute < Me.AtividadesNavioMarcadas(k).DataFim.Minute Then
                            temp = True
                        End If
                    ElseIf novaatividadenavio.DataInicio.Hour = Me.AtividadesNavioMarcadas(k).DataFim.Hour And novaatividadenavio.DataFim.Hour > Me.AtividadesNavioMarcadas(k).DataFim.Hour Then
                        If novaatividadenavio.DataInicio.Minute < Me.AtividadesNavioMarcadas(k).DataFim.Minute Then
                            temp = True
                        End If
                    End If
                End If
                k = k + 1
            End While


        End If
        If temp = True Then
            MsgBox("Já tem uma atividade marcada nesse horário!")
        Else
            If Me.AtividadesParagensMarcadas.Count > 0 Then

                While k <= Me.AtividadesParagensMarcadas.Count - 1 And temp = False
                    If novaatividadenavio.DataInicio.Day = Me.AtividadesParagensMarcadas(k).DataInicio.Day Then
                        If novaatividadenavio.DataInicio.Hour < Me.AtividadesParagensMarcadas(k).DataInicio.Hour And novaatividadenavio.DataFim.Hour = Me.AtividadesParagensMarcadas(k).DataInicio.Hour Then
                            If novaatividadenavio.DataFim.Minute > Me.AtividadesNavioMarcadas(k).DataInicio.Minute Then
                                temp = True
                            End If
                        ElseIf novaatividadenavio.DataInicio.Hour < Me.AtividadesParagensMarcadas(k).DataInicio.Hour And novaatividadenavio.DataFim.Hour > Me.AtividadesParagensMarcadas(k).DataInicio.Hour Then
                            temp = True
                        ElseIf novaatividadenavio.DataInicio.Hour = Me.AtividadesParagensMarcadas(k).DataInicio.Hour And novaatividadenavio.DataFim.Hour = Me.AtividadesParagensMarcadas(k).DataInicio.Hour Then
                            If novaatividadenavio.DataInicio.Minute < Me.AtividadesParagensMarcadas(k).DataInicio.Minute And novaatividadenavio.DataFim.Minute > Me.AtividadesParagensMarcadas(k).DataInicio.Minute Then
                                temp = True
                            End If


                        ElseIf novaatividadenavio.DataInicio.Hour >= Me.AtividadesParagensMarcadas(k).DataInicio.Hour And novaatividadenavio.DataInicio.Hour < Me.AtividadesParagensMarcadas(k).DataFim.Hour And novaatividadenavio.DataFim.Hour >= Me.AtividadesParagensMarcadas(k).DataFim.Hour Then
                            temp = True
                        ElseIf novaatividadenavio.DataInicio.Hour = Me.AtividadesParagensMarcadas(k).DataFim.Hour And novaatividadenavio.DataFim.Hour = Me.AtividadesParagensMarcadas(k).DataFim.Hour Then
                            If novaatividadenavio.DataInicio.Minute < Me.AtividadesParagensMarcadas(k).DataFim.Minute Then
                                temp = True
                            End If
                        ElseIf novaatividadenavio.DataInicio.Hour = Me.AtividadesParagensMarcadas(k).DataFim.Hour And novaatividadenavio.DataFim.Hour > Me.AtividadesParagensMarcadas(k).DataFim.Hour Then
                            If novaatividadenavio.DataInicio.Minute < Me.AtividadesParagensMarcadas(k).DataFim.Minute Then
                                temp = True
                            End If
                        End If
                    End If
                    k = k + 1
                End While
            End If

            If temp = True Then
                MsgBox("Já tem uma atividade marcada nesse horário!")
            Else
                Me.AtividadesNavioMarcadas.Add(novaatividadenavio)
                MsgBox("A atividade foi marcada!")
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



        If Me.AtividadesNavioMarcadas.Count > 0 Then

            While k <= Me.AtividadesNavioMarcadas.Count - 1 And temp = False
                If novaatividadeparagem.DataInicio.Day = Me.AtividadesNavioMarcadas(k).DataInicio.Day Then
                    If novaatividadeparagem.DataInicio.Hour < Me.AtividadesNavioMarcadas(k).DataInicio.Hour And novaatividadeparagem.DataFim.Hour = Me.AtividadesNavioMarcadas(k).DataInicio.Hour Then
                        If novaatividadeparagem.DataFim.Minute > Me.AtividadesNavioMarcadas(k).DataInicio.Minute Then
                            temp = True
                        End If
                    ElseIf novaatividadeparagem.DataInicio.Hour < Me.AtividadesNavioMarcadas(k).DataInicio.Hour And novaatividadeparagem.DataFim.Hour > Me.AtividadesNavioMarcadas(k).DataInicio.Hour Then
                        temp = True
                    ElseIf novaatividadeparagem.DataInicio.Hour = Me.AtividadesNavioMarcadas(k).DataInicio.Hour And novaatividadeparagem.DataFim.Hour = Me.AtividadesNavioMarcadas(k).DataInicio.Hour Then
                        If novaatividadeparagem.DataInicio.Minute < Me.AtividadesNavioMarcadas(k).DataInicio.Minute And novaatividadeparagem.DataFim.Minute > Me.AtividadesNavioMarcadas(k).DataInicio.Minute Then
                            temp = True
                        End If


                    ElseIf novaatividadeparagem.DataInicio.Hour >= Me.AtividadesNavioMarcadas(k).DataInicio.Hour And novaatividadeparagem.DataInicio.Hour < Me.AtividadesNavioMarcadas(k).DataFim.Hour And novaatividadeparagem.DataFim.hour >= Me.AtividadesNavioMarcadas(k).DataFim.Hour Then
                        temp = True
                    ElseIf novaatividadeparagem.DataInicio.Hour = Me.AtividadesNavioMarcadas(k).DataFim.Hour And novaatividadeparagem.Datafim.Hour = Me.AtividadesNavioMarcadas(k).DataFim.Hour Then
                        If novaatividadeparagem.DataInicio.Minute < Me.AtividadesNavioMarcadas(k).DataFim.Minute Then
                            temp = True
                        End If
                    ElseIf novaatividadeparagem.DataInicio.Hour = Me.AtividadesNavioMarcadas(k).DataFim.Hour And novaatividadeparagem.DataFim.Hour > Me.AtividadesNavioMarcadas(k).DataFim.Hour Then
                        If novaatividadeparagem.DataInicio.Minute < Me.AtividadesNavioMarcadas(k).DataFim.Minute Then
                            temp = True
                        End If
                    End If
                End If
                k = k + 1
            End While


        End If
        If temp = True Then
            MsgBox("Já tem uma atividade marcada nesse horário!")
        Else
            If Me.AtividadesParagensMarcadas.Count > 0 Then

                While k <= Me.AtividadesParagensMarcadas.Count - 1 And temp = False
                    If novaatividadeparagem.DataInicio.Day = Me.AtividadesParagensMarcadas(k).DataInicio.Day Then
                        If novaatividadeparagem.DataInicio.Hour < Me.AtividadesParagensMarcadas(k).DataInicio.Hour And novaatividadeparagem.DataFim.Hour = Me.AtividadesParagensMarcadas(k).DataInicio.Hour Then
                            If novaatividadeparagem.DataFim.Minute > Me.AtividadesNavioMarcadas(k).DataInicio.Minute Then
                                temp = True
                            End If
                        ElseIf novaatividadeparagem.DataInicio.Hour < Me.AtividadesParagensMarcadas(k).DataInicio.Hour And novaatividadeparagem.DataFim.Hour > Me.AtividadesParagensMarcadas(k).DataInicio.Hour Then
                            temp = True
                        ElseIf novaatividadeparagem.DataInicio.Hour = Me.AtividadesParagensMarcadas(k).DataInicio.Hour And novaatividadeparagem.DataFim.Hour = Me.AtividadesParagensMarcadas(k).DataInicio.Hour Then
                            If novaatividadeparagem.DataInicio.Minute < Me.AtividadesParagensMarcadas(k).DataInicio.Minute And novaatividadeparagem.DataFim.Minute > Me.AtividadesParagensMarcadas(k).DataInicio.Minute Then
                                temp = True
                            End If


                        ElseIf novaatividadeparagem.DataInicio.Hour >= Me.AtividadesParagensMarcadas(k).DataInicio.Hour And novaatividadeparagem.DataInicio.Hour < Me.AtividadesParagensMarcadas(k).DataFim.Hour And novaatividadeparagem.DataFim.Hour >= Me.AtividadesParagensMarcadas(k).DataFim.Hour Then
                            temp = True
                        ElseIf novaatividadeparagem.DataInicio.Hour = Me.AtividadesParagensMarcadas(k).DataFim.Hour And novaatividadeparagem.DataFim.Hour = Me.AtividadesParagensMarcadas(k).DataFim.Hour Then
                            If novaatividadeparagem.DataInicio.Minute < Me.AtividadesParagensMarcadas(k).DataFim.Minute Then
                                temp = True
                            End If
                        ElseIf novaatividadeparagem.DataInicio.Hour = Me.AtividadesParagensMarcadas(k).DataFim.Hour And novaatividadeparagem.DataFim.Hour > Me.AtividadesParagensMarcadas(k).DataFim.Hour Then
                            If novaatividadeparagem.DataInicio.Minute < Me.AtividadesParagensMarcadas(k).DataFim.Minute Then
                                temp = True
                            End If
                        End If
                    End If
                    k = k + 1
                End While
            End If

            If temp = True Then
                MsgBox("Já tem uma atividade marcada nesse horário!")
            Else
                Me.AtividadesParagensMarcadas.Add(novaatividadeparagem)
                MsgBox("A atividade foi marcada!")
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
