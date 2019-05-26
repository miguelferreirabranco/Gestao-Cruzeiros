Public Class FormAtividades_Paragens
    Public AtividadeParagemVisivel As Integer = 0
    Dim CurrentParagem As Integer = 0

    Public Sub mostra()
        Dim k As Integer

        If EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens.Count > 0 Then

            If AtividadeParagemVisivel < 0 Then
                AtividadeParagemVisivel = 0
            ElseIf AtividadeParagemVisivel > EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens.Count - 1 Then
                AtividadeParagemVisivel = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens.Count - 1
            End If

            TextBox_nome.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens(AtividadeParagemVisivel).Nome

            Me.ComboBoxTipo1.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens(AtividadeParagemVisivel).Tipo

            Me.HoraInicio.Value = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens(AtividadeParagemVisivel).DataInicio.Hour
            Me.MinutoInicio.Value = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens(AtividadeParagemVisivel).DataInicio.Minute
            Me.HoraFim.Value = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens(AtividadeParagemVisivel).DataFim.Hour
            Me.MinutoFim.Value = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens(AtividadeParagemVisivel).DataFim.Minute
            Me.DateTimePickerData.Value = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens(AtividadeParagemVisivel).DataInicio
            Me.ComboBoxParagem.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens(AtividadeParagemVisivel).Paragem.LocalParagem
            TextBox_local.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens(AtividadeParagemVisivel).LocalaVisitar


            ListView1.Items.Clear()

            For k = 0 To EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens.Count - 1
                Dim item As New ListViewItem(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens(k).Nome)
                item.SubItems.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens(k).Tipo)
                item.SubItems.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens(k).DataInicio.ToShortDateString)
                item.SubItems.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens(k).DataInicio.Hour & ":" & EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens(k).DataInicio.Minute & " - " & EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens(k).DataFim.Hour & ":" & EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens(k).DataFim.Minute)
                item.SubItems.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens(k).Paragem.LocalParagem)
                item.SubItems.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesParagens(k).LocalaVisitar)
                ListView1.Items.Add(item)
            Next
        End If
    End Sub

    Private Sub ButtonNova1_Click(sender As Object, e As EventArgs) Handles ButtonNova1.Click
        Me.TextBox_nome.Clear()
        Me.HoraInicio.Value = 0
        Me.MinutoInicio.Value = 0
        Me.HoraFim.Value = 0
        Me.MinutoFim.Value = 0
        Me.ComboBoxTipo1.Text = ""
        Me.TextBox_local.Clear()
        Me.ComboBoxParagem.Text = ""
        Me.DateTimePickerData.Value = Today
    End Sub


    Private Sub Button_Adicionar_Click(sender As Object, e As EventArgs) Handles Button_Adicionar.Click
        Dim NovaAtividadeParagem As ClassAtividadeParagens
        Dim k As Integer = 0

        Dim data As Date = Me.DateTimePickerData.Value
        Dim datainicio As New System.DateTime(data.Year, data.Month, data.Day, Me.HoraInicio.Value, Me.MinutoInicio.Value, 0)
        Dim datafim As New System.DateTime(data.Year, data.Month, data.Day, Me.HoraFim.Value, Me.MinutoFim.Value, 0)
        Dim i As Integer = 0




        'PERGUNTAR SE NAO FALTA NADA NO CICLO PARA O I



        Dim paragem As ClassParagem
        While k = 0
            If Me.ComboBoxParagem.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(i).LocalParagem Then
                paragem = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(i)
                k = 1
            End If
            i += 1
        End While


        NovaAtividadeParagem = New ClassAtividadeParagens(Me.TextBox_nome.Text, datainicio, datafim, Me.ComboBoxTipo1.Text, paragem, Me.TextBox_local.Text)

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
        If EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens.Count > 0 Then

            For i = 0 To EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens.Count - 1
                Me.ComboBoxParagem.Items.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(i).LocalParagem)
            Next
        End If

        If NivelVisivel = "Viajante" Then
            Me.Button_Adicionar.Visible = False
            Me.DateTimePickerData.Enabled = False
            Me.HoraFim.Enabled = False
            Me.MinutoFim.Enabled = False
            Me.HoraInicio.Enabled = False
            Me.MinutoInicio.Enabled = False
            Me.TextBox_local.Enabled = False
            Me.TextBox_nome.Enabled = False

            Me.ComboBoxParagem.Enabled = False
            Me.ComboBoxTipo1.Enabled = False
            Me.ButtonNova.Visible = False

        ElseIf NivelVisivel = "Funcionario" Then
            Me.Button_Marcar.Visible = False
            Me.Button_anular.Visible = False
        End If
        ler()
        mostra()
    End Sub



End Class