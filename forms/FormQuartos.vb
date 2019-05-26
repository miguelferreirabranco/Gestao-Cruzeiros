﻿Public Class FormQuartos
    Dim QuartoVisivel As Integer = 0


    Public Sub Mostra()

        If EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos.Count > 0 Then

            If QuartoVisivel < 0 Then
                QuartoVisivel = 0
            ElseIf QuartoVisivel > EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos.count - 1 Then
                QuartoVisivel = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos.Count - 1
            End If

            Me.TextBox_numero.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(QuartoVisivel).Nquarto
            Me.TextBox_npessoas.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(QuartoVisivel).Npessoas
            Me.TextBox_preco.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(QuartoVisivel).Ppessoa
            Me.ComboBoxSeccao.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(QuartoVisivel).Seccao


            ListView1.Items.Clear()

            For k = 0 To EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos.Count - 1
                Dim item As New ListViewItem(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(k).Nquarto)
                item.SubItems.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(k).Seccao)
                item.SubItems.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(k).Npessoas)
                item.SubItems.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(k).Ppessoa)
                ListView1.Items.Add(item)
            Next
        End If
    End Sub

    Private Sub Button_inicio_Click(sender As Object, e As EventArgs) Handles Button_inicio.Click
        QuartoVisivel = 0
        Mostra()
    End Sub
    Private Sub Button_anterior_Click(sender As Object, e As EventArgs) Handles Button_anterior.Click
        QuartoVisivel = QuartoVisivel - 1
        Mostra()
    End Sub
    Private Sub Button_seguinte_Click(sender As Object, e As EventArgs) Handles Button_seguinte.Click
        QuartoVisivel = QuartoVisivel + 1
        Mostra()
    End Sub

    Private Sub Button_fim_Click(sender As Object, e As EventArgs) Handles Button_fim.Click
        QuartoVisivel = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos.Count - 1
        Mostra()
    End Sub
    Private Sub ButtonNovo_Click(sender As Object, e As EventArgs) Handles ButtonNovo.Click
        Me.TextBox_npessoas.Clear()
        Me.TextBox_numero.Clear()
        Me.TextBox_preco.Clear()
        Me.ComboBoxSeccao.Text = ""
        Me.TextBox_npessoas.Select()

    End Sub
    Private Sub Button_Adicionar_Click(sender As Object, e As EventArgs) Handles Button_Adicionar.Click
        Dim quarto As ClassQuarto
        quarto = New ClassQuarto(Me.TextBox_npessoas.Text, Me.TextBox_numero.Text, Me.TextBox_preco.Text, Me.ComboBoxSeccao.Text)
        EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos.Add(quarto)

        QuartoVisivel = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos.Count - 1
        Mostra()



    End Sub



    Private Sub FormQuartos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ler()
        Mostra()
    End Sub


End Class