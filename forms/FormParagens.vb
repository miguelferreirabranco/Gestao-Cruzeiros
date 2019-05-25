Public Class FormParagens
    Public paragemvisivel As Integer = 0



    Public Sub mostra()
        Dim k As Integer

        If EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens.Count > 0 Then

            If paragemvisivel < 0 Then
                paragemvisivel = 0
            ElseIf paragemvisivel > EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens.Count - 1 Then
                paragemvisivel = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens.Count - 1

            End If

            Me.DateTimePickerData.Value = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(paragemvisivel).Data
            Me.TextBox_horainicio.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(paragemvisivel).HoraInicio
            Me.TextBox_horafim.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(paragemvisivel).HoraFim
            Me.TextBox_local.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(paragemvisivel).LocalParagem

            Me.ListBox_Paragens.Items.Clear()

            For k = 0 To EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens.Count - 1
                Me.ListBox_Paragens.Items.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(k).ParaString)
            Next
        End If
    End Sub
    Private Sub Button_inicio_Click(sender As Object, e As EventArgs) Handles Button_inicio.Click
        paragemvisivel = 0
        mostra()
    End Sub
    Private Sub Button_anterior_Click(sender As Object, e As EventArgs) Handles Button_anterior.Click
        paragemvisivel = paragemvisivel - 1
        mostra()
    End Sub

    Private Sub Button_seguinte_Click(sender As Object, e As EventArgs) Handles Button_seguinte.Click
        paragemvisivel = paragemvisivel + 1
        mostra()
    End Sub

    Private Sub Button_fim_Click(sender As Object, e As EventArgs) Handles Button_fim.Click
        paragemvisivel = paragemvisivel + 1
        mostra()
    End Sub

    Private Sub Button_Adicionar_Click(sender As Object, e As EventArgs) Handles Button_Adicionar.Click
        Dim paragem As ClassParagem
        paragem = New ClassParagem(Me.TextBox_local.Text, Me.DateTimePickerData.Value.ToShortDateString, Me.TextBox_horainicio.Text, Me.TextBox_horafim.Text)
        EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens.Add(paragem)

        paragemvisivel = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens.Count - 1
        gravar()

        mostra()



    End Sub

    Private Sub FormParagens_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If NivelVisivel = "Viajante" Then
            Me.Button_Adicionar.Visible = False
            Me.TextBox_horainicio.Enabled = False
            Me.TextBox_horafim.Enabled = False
            Me.TextBox_local.Enabled = False
            Me.DateTimePickerData.Enabled = False
        End If

        mostra()
    End Sub
End Class