﻿Public Class FormAtividades_Navio
    Public AtividadeNavioVisivel As Integer = 0

    Public Sub mostra()
        Dim k As Integer

        If EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio.Count > 0 Then

            If AtividadeNavioVisivel < 0 Then
                AtividadeNavioVisivel = 0
            ElseIf AtividadeNavioVisivel > EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio.Count - 1 Then
                AtividadeNavioVisivel = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio.Count - 1
            End If


            Me.TextBox_nome.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio(AtividadeNavioVisivel).Nome
            Me.ComboBoxTipo.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio(AtividadeNavioVisivel).Tipo
            Me.ComboBoxSeccao.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio(AtividadeNavioVisivel).SeccaoNavio
            Me.DateTimePickerData.Value = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio(AtividadeNavioVisivel).DataInicio
            Me.HoraInicio.Value = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio(AtividadeNavioVisivel).DataInicio.Hour
            Me.MinutoInicio.Value = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio(AtividadeNavioVisivel).DataInicio.Minute
            Me.HoraFim.Value = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio(AtividadeNavioVisivel).DataFim.Hour
            Me.MinutoFim.Value = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio(AtividadeNavioVisivel).DataFim.Minute


            ListView1.Items.Clear()

            For k = 0 To EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio.Count - 1
                Dim item As New ListViewItem(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio(k).Nome)
                item.SubItems.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio(k).Tipo)
                item.SubItems.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio(k).DataInicio.ToShortDateString)
                item.SubItems.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio(k).DataInicio.Hour & ":" & EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio(k).DataInicio.Minute & " - " & EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio(k).DataFim.Hour & ":" & EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio(k).DataFim.Minute)
                item.SubItems.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio(k).SeccaoNavio)
                ListView1.Items.Add(item)
            Next
        End If
    End Sub
    Private Sub ButtonNova_Click(sender As Object, e As EventArgs) Handles ButtonNova.Click
        Me.TextBox_nome.Clear()
        Me.HoraInicio.Value = 0
        Me.MinutoInicio.Value = 0
        Me.HoraFim.Value = 0
        Me.MinutoFim.Value = 0
        Me.ComboBoxSeccao.Text = ""
        Me.ComboBoxTipo.Text = ""
        Me.DateTimePickerData.Value = Today

    End Sub
    Private Sub Button_Adicionar_Click(sender As Object, e As EventArgs) Handles Button_Adicionar.Click
        Dim NovaAtividadeNavio As ClassAtividadeNavio
        Dim data As Date = Me.DateTimePickerData.Value
        Dim datainicio As New System.DateTime(data.Year, data.Month, data.Day, Me.HoraInicio.Value, Me.MinutoInicio.Value, 0)
        Dim datafim As New System.DateTime(data.Year, data.Month, data.Day, Me.HoraFim.Value, Me.MinutoFim.Value, 0)


        NovaAtividadeNavio = New ClassAtividadeNavio(Me.TextBox_nome.Text, datainicio, datafim, Me.ComboBoxTipo.Text, Me.ComboBoxSeccao.Text)

        EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio.Add(NovaAtividadeNavio)
        AtividadeNavioVisivel = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio.Count - 1

        gravar()
        mostra()
    End Sub

    Private Sub Button_Marcar_Click(sender As Object, e As EventArgs) Handles Button_Marcar.Click
        EmpresaCruzeiros.Viajantes(ViajanteVisivel).MarcarAtividadeNavio(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio(AtividadeNavioVisivel))
        AtividadeNavioVisivel = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).AtividadesNavio.Count - 1

        gravar()
        mostra()
    End Sub

    Private Sub Button_anular_Click(sender As Object, e As EventArgs) Handles Button_anular.Click
        EmpresaCruzeiros.Viajantes(ViajanteVisivel).AnularMarcacaoNavio(Me.TextBox_nome.Text)
        AtividadeNavioVisivel = 0
        gravar()
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
            Me.ComboBoxSeccao.Enabled = False
            Me.ComboBoxTipo.Enabled = False
            Me.DateTimePickerData.Enabled = False
            Me.HoraFim.Enabled = False
            Me.HoraInicio.Enabled = False
            Me.MinutoFim.Enabled = False
            Me.MinutoInicio.Enabled = False
            Me.ButtonNova.Visible = False
        ElseIf NivelVisivel = "Funcionario" Then
            Me.Button_Marcar.Visible = False
            Me.Button_anular.Visible = False
        End If
        ler()
        mostra()
    End Sub


End Class