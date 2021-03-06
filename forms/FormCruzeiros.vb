﻿Public Class FormCruzeiros

    Public Sub mostra()
        If EmpresaCruzeiros.Cruzeiros.Count > 0 Then
            If CruzeiroVisivel < 0 Then
                CruzeiroVisivel = 0
            ElseIf CruzeiroVisivel > EmpresaCruzeiros.Cruzeiros.Count - 1 Then
                CruzeiroVisivel = EmpresaCruzeiros.Cruzeiros.Count - 1
            End If

            TextBox_nome.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Nome
            TextBox_origem.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).LocalInicio
            TextBox_destino.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).LocalFim
            DateTimePicker_datainicial.Value = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).DataInicio
            DateTimePicker_datafinal.Value = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).DataFim

            ListView1.Items.Clear()

            For k = 0 To EmpresaCruzeiros.Cruzeiros.Count - 1
                Dim item As New ListViewItem(EmpresaCruzeiros.Cruzeiros(k).Nome)
                item.SubItems.Add(EmpresaCruzeiros.Cruzeiros(k).LocalInicio)
                item.SubItems.Add(EmpresaCruzeiros.Cruzeiros(k).LocalFim)
                item.SubItems.Add(EmpresaCruzeiros.Cruzeiros(k).DataInicio.ToShortDateString)
                item.SubItems.Add(EmpresaCruzeiros.Cruzeiros(k).DataFim.ToShortDateString)
                ListView1.Items.Add(item)
            Next

            If NivelVisivel = "Funcionario" Then
                Me.LabelReceitaEmpresa.Text = EmpresaCruzeiros.ReceitaTotal & "€"
                Me.LabelReceitaCruzeiroV.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).ReceitaTotal & "€"
            End If
        End If


    End Sub

    Private Sub Button_inicio_Click(sender As Object, e As EventArgs) Handles Button_inicio.Click
        CruzeiroVisivel = 0
        mostra()
    End Sub

    Private Sub Button_anterior_Click(sender As Object, e As EventArgs) Handles Button_anterior.Click
        CruzeiroVisivel = CruzeiroVisivel - 1
        mostra()
    End Sub

    Private Sub Button_seguinte_Click(sender As Object, e As EventArgs) Handles Button_seguinte.Click
        CruzeiroVisivel = CruzeiroVisivel + 1
        mostra()
    End Sub

    Private Sub Button_fim_Click(sender As Object, e As EventArgs) Handles Button_fim.Click
        CruzeiroVisivel = EmpresaCruzeiros.Cruzeiros.Count - 1
        mostra()
    End Sub
    Private Sub ButtonNovo_Click(sender As Object, e As EventArgs) Handles ButtonNovo.Click
        Me.TextBox_nome.Clear()
        Me.TextBox_origem.Clear()
        Me.TextBox_destino.Clear()
        Me.DateTimePicker_datafinal.Value = Today
        Me.DateTimePicker_datainicial.Value = Today
    End Sub

    Private Sub Button_Adicionar_Click(sender As Object, e As EventArgs) Handles Button_Adicionar.Click
        Dim novocruzeiro As ClassCruzeiro

        novocruzeiro = New ClassCruzeiro(TextBox_nome.Text, DateTimePicker_datainicial.Value.ToShortDateString, DateTimePicker_datafinal.Value.ToShortDateString, TextBox_origem.Text, TextBox_destino.Text)
        EmpresaCruzeiros.Cruzeiros.Add(novocruzeiro)
        gravar()
        CruzeiroVisivel = EmpresaCruzeiros.Cruzeiros.Count - 1
        mostra()
    End Sub


    Private Sub Button_modificar_Click(sender As Object, e As EventArgs) Handles Button_modificar.Click
        EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).modificar(Me.TextBox_nome.Text, Me.DateTimePicker_datainicial.Value.ToShortDateString, Me.DateTimePicker_datafinal.Value.ToShortDateString, Me.TextBox_origem.Text, Me.TextBox_destino.Text)
        gravar()
        mostra()
    End Sub

    Private Sub Button_Reservar_Click(sender As Object, e As EventArgs) Handles Button_Reservar.Click
        Dim k As Integer = 0
        Dim temp As Boolean = False

        If EmpresaCruzeiros.Viajantes(ViajanteVisivel).CruzeirosMarcados.Count > 0 Then
            While k <= EmpresaCruzeiros.Viajantes(ViajanteVisivel).CruzeirosMarcados.Count - 1 And temp = False
                If (EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).DataInicio >= EmpresaCruzeiros.Cruzeiros(k).DataInicio And EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).DataInicio <= EmpresaCruzeiros.Cruzeiros(k).DataFim) Or (EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).DataFim >= EmpresaCruzeiros.Cruzeiros(k).DataInicio And EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).DataFim <= EmpresaCruzeiros.Cruzeiros(k).DataFim) Then
                    temp = True
                End If
                k = k + 1
            End While
        End If

        If temp = True Then
            MsgBox("Já tem um cruzeiro marcado nesse intervalo!")
        Else
            EmpresaCruzeiros.Viajantes(ViajanteVisivel).CruzeirosMarcados.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel))
            gravar()
            FormPrincipal.QuartosToolStripMenuItem.Visible = True
            FormPrincipal.ParagensToolStripMenuItem.Visible = True
            MsgBox("Reservou o cruzeiro com sucesso, efetue agora a reserva do quarto e das atividades!")
        End If



    End Sub

    Private Sub FormCruzeiros_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If NivelVisivel = "Viajante" Then
            Me.Button_modificar.Visible = False
            Me.Button_Adicionar.Visible = False
            Me.TextBox_destino.Enabled = False
            Me.TextBox_nome.Enabled = False
            Me.TextBox_origem.Enabled = False
            Me.DateTimePicker_datainicial.Enabled = False
            Me.DateTimePicker_datafinal.Enabled = False
            Me.ButtonNovo.Visible = False
            Me.LabelE.Visible = False
            Me.LabelRCV.Visible = False
            Me.LabelReceitaCruzeiroV.Visible = False
            Me.LabelReceitaEmpresa.Visible = False
        ElseIf NivelVisivel = "Funcionario" Then
            Me.Button_Reservar.Visible = False
        End If
        ler()
        mostra()
    End Sub


End Class