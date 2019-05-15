Public Class FormParagens
    Public i As Integer = 0


    Private Sub Button_inicio_Click(sender As Object, e As EventArgs) Handles Button_inicio.Click
        i = 0
        LoadForm()
    End Sub
    Sub LoadForm()
        Me.TextBox_dia.Text = EmpresaCruzeiros(X).Paragens(i).Data
        Me.TextBox_horafim.Text = EmpresaCruzeiros(X).Paragens(i).HoraFim
        Me.TextBox_horainicio.Text = EmpresaCruzeiros(X).Paragens(i).HoraInicio
        Me.TextBox_local.Text = EmpresaCruzeiros(X).Paragens(i).LocalParagem
    End Sub

    Private Sub Button_anterior_Click(sender As Object, e As EventArgs) Handles Button_anterior.Click
        If i = 0 Then
            MsgBox("ja se encontra no ultimo quarto")
        Else
            i += -1
            LoadForm()
        End If
    End Sub

    Private Sub Button_seguinte_Click(sender As Object, e As EventArgs) Handles Button_seguinte.Click
        If i = EmpresaCruzeiros(X).Quartos.Count - 1 Then
            MsgBox("encontra-se ja a ver o ultimo quarto")
        Else
            i += 1
            LoadForm()
        End If
    End Sub

    Private Sub Button_fim_Click(sender As Object, e As EventArgs) Handles Button_fim.Click
        i = EmpresaCruzeiros(X).Quartos.Count - 1
        LoadForm()
    End Sub

    Private Sub Button_Adicionar_Click(sender As Object, e As EventArgs) Handles Button_Adicionar.Click
        Dim paragem As ClassParagem
        paragem = New ClassParagem(Me.TextBox_local.Text, Me.TextBox_dia.Text, Me.TextBox_horainicio.Text, Me.TextBox_horafim.Text)
        EmpresaCruzeiros(X).Paragens.Add(paragem)
        i = EmpresaCruzeiros(X).Paragens.Count - 1
        For k = 0 To EmpresaCruzeiros(X).Paragens.Count - 1
            Me.ListBox_Paragens.Items.Add(EmpresaCruzeiros(X).Paragens(k).ParaString)
        Next

    End Sub

End Class