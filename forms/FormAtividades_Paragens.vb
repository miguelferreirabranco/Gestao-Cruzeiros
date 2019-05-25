Public Class FormAtividades_Paragens
    Public AtividadeParagemVisivel As Integer = 0

    Public Sub mostra()
        Dim k As Integer

        If EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens.Count > 0 Then

            If AtividadeParagemVisivel < 0 Then
                AtividadeParagemVisivel = 0
            ElseIf AtividadeParagemVisivel > EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens.Count - 1 Then
                AtividadeParagemVisivel = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens.Count - 1
            End If

            TextBox_nome.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens(AtividadeParagemVisivel).Nome
            TextBox_tipo.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens(AtividadeParagemVisivel).Tipo
            DateTimePickerHoraInicio.Value = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens(AtividadeParagemVisivel).HoraInicio
            DateTimePickerHoraFim.Value = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens(AtividadeParagemVisivel).HoraFim
            TextBox_paragem.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens(AtividadeParagemVisivel).Paragem.LocalParagem
            TextBox_local.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens(AtividadeParagemVisivel).LocalaVisitar

            ListBox_Atividades_Paragens.Items.Clear()

            For k = 0 To EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens.Count - 1
                ListBox_Atividades_Paragens.Items.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens(k).AtividadeParaString)
            Next
        End If
    End Sub

    Private Sub Button_Adicionar_Click(sender As Object, e As EventArgs) Handles Button_Adicionar.Click
        Dim NovaAtividadeParagem As ClassAtividadeParagens
        Dim k As Integer = 0
        Dim temp As Boolean
        Dim paragem As ClassParagem

        While k <= EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens.Count - 1
            If Me.TextBox_paragem.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(k).LocalParagem Then
                temp = True
                paragem = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(k)
            End If
            k = k + 1
        End While

        NovaAtividadeParagem = New ClassAtividadeParagens(Me.TextBox_nome.Text, Me.DateTimePickerHoraInicio.Value.ToShortTimeString, Me.DateTimePickerHoraFim.Value.ToShortTimeString, Me.TextBox_tipo.Text, paragem, Me.TextBox_local.Text)

        EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens.Add(NovaAtividadeParagem)
        AtividadeParagemVisivel = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens.Count - 1

        gravar()
        mostra()
    End Sub

    Private Sub Button_Marcar_Click(sender As Object, e As EventArgs) Handles Button_Marcar.Click
        EmpresaCruzeiros.Viajantes(ViajanteVisivel).MarcarAtividadeParagem(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens(AtividadeParagemVisivel))
        AtividadeParagemVisivel = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens.Count - 1
        mostra()
    End Sub

    Private Sub Button_anular_Click(sender As Object, e As EventArgs) Handles Button_anular.Click
        EmpresaCruzeiros.Viajantes(ViajanteVisivel).AnularMarcacaoParagem(Me.TextBox_nome.Text)
        AtividadeParagemVisivel = 0
        mostra()
    End Sub

    Private Sub Button_inicio_Click(sender As Object, e As EventArgs) Handles Button_inicio.Click
        AtividadeParagemVisivel = 0
        mostra()
    End Sub

    Private Sub Button_anterior_Click(sender As Object, e As EventArgs) Handles Button_anterior.Click
        AtividadeParagemVisivel = AtividadeParagemVisivel - 1
        mostra()
    End Sub

    Private Sub Button_seguinte_Click(sender As Object, e As EventArgs) Handles Button_seguinte.Click
        AtividadeParagemVisivel = AtividadeParagemVisivel + 1
        mostra()
    End Sub

    Private Sub Button_fim_Click(sender As Object, e As EventArgs) Handles Button_fim.Click
        AtividadeParagemVisivel = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens.Count - 1
        mostra()
    End Sub

    Private Sub FormAtividades_Paragens_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If NivelVisivel = "Viajante" Then
            Me.Button_Adicionar.Visible = False
            Me.DateTimePickerHoraInicio.Enabled = False
            Me.DateTimePickerHoraFim.Enabled = False
            Me.TextBox_local.Enabled = False
            Me.TextBox_nome.Enabled = False
            Me.TextBox_paragem.Enabled = False
            Me.TextBox_tipo.Enabled = False

        ElseIf NivelVisivel = "Funcionario" Then
            Me.Button_Marcar.Visible = False
            Me.Button_anular.Visible = False
        End If
        ler()
        mostra()
    End Sub
End Class