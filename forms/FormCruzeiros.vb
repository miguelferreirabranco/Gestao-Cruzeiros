Public Class FormCruzeiros

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

            ListBox_Cruzeiros.Items.Clear()

            For k = 0 To EmpresaCruzeiros.Cruzeiros.Count - 1
                ListBox_Cruzeiros.Items.Add(EmpresaCruzeiros.Cruzeiros(k).CruzeiroParaString)
            Next

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

    Private Sub Button_Adicionar_Click(sender As Object, e As EventArgs) Handles Button_Adicionar.Click
        Dim novocruzeiro As ClassCruzeiro
        novocruzeiro = New ClassCruzeiro(TextBox_nome.Text, DateTimePicker_datainicial.Value, DateTimePicker_datafinal.Value, TextBox_origem.Text, TextBox_destino.Text)
        EmpresaCruzeiros.Cruzeiros.Add(novocruzeiro)
        EmpresaCruzeiros.gravar()
        CruzeiroVisivel = EmpresaCruzeiros.Cruzeiros.Count - 1
        mostra()
    End Sub

    Private Sub Button_Reservar_Click(sender As Object, e As EventArgs) Handles Button_Reservar.Click

    End Sub
End Class