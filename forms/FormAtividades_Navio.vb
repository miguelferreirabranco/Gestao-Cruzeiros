Public Class FormAtividades_Navio
    Public AtividadeNavioVisivel As Integer = 0

    Public Sub mostra()
        Dim k As Integer

        If EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio.Count > 0 Then

            If AtividadeNavioVisivel < 0 Then
                AtividadeNavioVisivel = 0
            ElseIf AtividadeNavioVisivel > EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio.Count - 1 Then
                AtividadeNavioVisivel = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio.Count - 1
            End If

            TextBox_nome.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio(AtividadeNavioVisivel).Nome
            TextBox_tipo.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio(AtividadeNavioVisivel).Tipo
            TextBox_horainicio.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio(AtividadeNavioVisivel).HoraInicio
            TextBox_horafim.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio(AtividadeNavioVisivel).HoraFim
            TextBox_seccao.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio(AtividadeNavioVisivel).SeccaoNavio

            ListBox_Atividades_Navio.Items.Clear()

            For k = 0 To EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio.Count - 1
                ListBox_Atividades_Navio.Items.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio(k).AtividadeParaString)
            Next
        End If
    End Sub

    Private Sub Button_Adicionar_Click(sender As Object, e As EventArgs) Handles Button_Adicionar.Click
        Dim NovaAtividadeNavio As ClassAtividadeNavio

        NovaAtividadeNavio = New ClassAtividadeNavio(Me.TextBox_nome.Text, Me.TextBox_horainicio.Text, Me.TextBox_horafim.Text, Me.TextBox_tipo.Text, Me.TextBox_seccao.Text)

        EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio.Add(NovaAtividadeNavio)
        AtividadeNavioVisivel = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio.Count - 1

        gravar()
        mostra()
    End Sub

    Private Sub Button_Marcar_Click(sender As Object, e As EventArgs) Handles Button_Marcar.Click
        EmpresaCruzeiros.Viajantes(ViajanteVisivel).MarcarAtividadeNavio(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio(AtividadeNavioVisivel))
        AtividadeNavioVisivel = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio.Count - 1
        mostra()
    End Sub

    Private Sub Button_anular_Click(sender As Object, e As EventArgs) Handles Button_anular.Click
        EmpresaCruzeiros.Viajantes(ViajanteVisivel).AnularMarcacaoNavio(Me.TextBox_nome.Text)
        AtividadeNavioVisivel = 0
        mostra()
    End Sub

    Private Sub Button_inicio_Click(sender As Object, e As EventArgs) Handles Button_inicio.Click
        AtividadeNavioVisivel = 0
        mostra()
    End Sub

    Private Sub Button_anterior_Click(sender As Object, e As EventArgs) Handles Button_anterior.Click
        AtividadeNavioVisivel = AtividadeNavioVisivel - 1
        mostra()
    End Sub

    Private Sub Button_seguinte_Click(sender As Object, e As EventArgs) Handles Button_seguinte.Click
        AtividadeNavioVisivel = AtividadeNavioVisivel + 1
        mostra()
    End Sub

    Private Sub Button_fim_Click(sender As Object, e As EventArgs) Handles Button_fim.Click
        AtividadeNavioVisivel = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio.Count - 1
        mostra()
    End Sub



    Private Sub FormAtividades_Navio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If NivelVisivel = "Viajante" Then
            Me.Button_Adicionar.Visible = False
            Me.TextBox_nome.Enabled = False
            Me.TextBox_seccao.Enabled = False
            Me.TextBox_tipo.Enabled = False
            Me.TextBox_horafim.Enabled = False
            Me.TextBox_horainicio.Enabled = False
        ElseIf NivelVisivel = "Funcionario" Then
            Me.Button_Marcar.Visible = False
            Me.Button_anular.Visible = False
        End If
        mostra()
    End Sub


End Class