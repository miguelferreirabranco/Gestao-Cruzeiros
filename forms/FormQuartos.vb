Public Class FormQuartos
    Dim i As Integer = 0
    Private Sub Button_anterior_Click(sender As Object, e As EventArgs) Handles Button_anterior.Click
        If i = 0 Then
            MsgBox("ja se encontra no ultimo quarto")
        Else
            i += -1
            LoadForm()
        End If
    End Sub
    Sub LoadForm()
        Me.TextBox_numero.Text = EmpresaCruzeiros(CruzeiroVisivel).Quartos(i).Nquarto
        Me.TextBox_npessoas.Text = EmpresaCruzeiros(CruzeiroVisivel).Quartos(i).Npessoas
        Me.TextBox_preco.Text = EmpresaCruzeiros(CruzeiroVisivel).Quartos(i).Ppessoa
        Me.TextBox_seccao.Text = EmpresaCruzeiros(CruzeiroVisivel).Quartos(i).Seccao
        Me.ListBox_Quartos.Items.Clear()
        For k = 0 To EmpresaCruzeiros(CruzeiroVisivel).Quartos.Count - 1
            Me.ListBox_Quartos.Items.Add(EmpresaCruzeiros(CruzeiroVisivel).Quartos(k).ParaString)
        Next
    End Sub

    Private Sub Button_inicio_Click(sender As Object, e As EventArgs) Handles Button_inicio.Click
        i = 0
        LoadForm()
    End Sub

    Private Sub Button_seguinte_Click(sender As Object, e As EventArgs) Handles Button_seguinte.Click
        If i = EmpresaCruzeiros(CruzeiroVisivel).Quartos.Count - 1 Then
            MsgBox("encontra-se ja a ver o ultimo quarto")
        Else
            i += 1
            LoadForm()
        End If
    End Sub

    Private Sub Button_fim_Click(sender As Object, e As EventArgs) Handles Button_fim.Click
        i = EmpresaCruzeiros(CruzeiroVisivel).Quartos.Count - 1
        LoadForm()
    End Sub

    Private Sub Button_Adicionar_Click(sender As Object, e As EventArgs) Handles Button_Adicionar.Click
        Dim quarto As ClassQuarto
        quarto = New ClassQuarto(Me.TextBox_npessoas.Text, i + 1, Me.TextBox_preco.Text, Me.TextBox_seccao.Text)
        EmpresaCruzeiros(CruzeiroVisivel).Quartos.Add(quarto)
        i = EmpresaCruzeiros(CruzeiroVisivel).Quartos.Count - 1
    End Sub

    Private Sub Button_Reservar_Click(sender As Object, e As EventArgs) Handles Button_Reservar.Click

        EmpresaCruzeiros(CruzeiroVisivel).Quartos(i).Reservar(EmpresaCruzeiros(CruzeiroVisivel).Viajantes(ViajanteVisivel).Nome) ' ajustar quando se puser um login
    End Sub

    Private Sub Button_anular_Click(sender As Object, e As EventArgs) Handles Button_anular.Click

        EmpresaCruzeiros(CruzeiroVisivel).Quartos(i).AnularReserva(EmpresaCruzeiros(CruzeiroVisivel).Viajantes(ViajanteVisivel).Nome) ' ajustar quando se puser um login
    End Sub

    Private Sub Button_reservaVIP_Click(sender As Object, e As EventArgs) Handles Button_reservaVIP.Click

    End Sub

    Private Sub ListBox_Quartos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox_Quartos.SelectedIndexChanged

    End Sub
End Class