Public Class FormQuartos
    Dim i As Integer = 0
    Private Sub Button_anterior_Click(sender As Object, e As EventArgs) Handles Button_anterior.Click
        If i = 0 Then
            MsgBox("Encontra-se já a ver o primeiro quarto!")
        Else
            i += -1
            LoadForm()
        End If
    End Sub
    Sub LoadForm()
        Me.TextBox_numero.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(i).Nquarto
        Me.TextBox_npessoas.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(i).Npessoas
        Me.TextBox_preco.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(i).Ppessoa
        Me.TextBox_seccao.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(i).Seccao
    End Sub

    Private Sub Button_inicio_Click(sender As Object, e As EventArgs) Handles Button_inicio.Click
        i = 0
        LoadForm()
    End Sub

    Private Sub Button_seguinte_Click(sender As Object, e As EventArgs) Handles Button_seguinte.Click
        If i = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos.Count - 1 Then
            MsgBox("Encontra-se já a ver o último quarto!")
        Else
            i += 1
            LoadForm()
        End If
    End Sub

    Private Sub Button_fim_Click(sender As Object, e As EventArgs) Handles Button_fim.Click
        i = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos.Count - 1
        LoadForm()
    End Sub

    Private Sub Button_Adicionar_Click(sender As Object, e As EventArgs) Handles Button_Adicionar.Click
        Dim quarto As ClassQuarto
        quarto = New ClassQuarto(Me.TextBox_npessoas.Text, i + 1, Me.TextBox_preco.Text, Me.TextBox_seccao.Text)
        EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos.Add(quarto)
        i = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos.Count - 1

        EmpresaCruzeiros.gravar()
    End Sub

    Private Sub Button_Reservar_Click(sender As Object, e As EventArgs) Handles Button_Reservar.Click

        EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(i).Reservar(username) ' ajustar quando se puser um login


        EmpresaCruzeiros.gravar()

    End Sub

    Private Sub Button_anular_Click(sender As Object, e As EventArgs) Handles Button_anular.Click

        EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(i).AnularReserva(username) ' ajustar quando se puser um login

        EmpresaCruzeiros.gravar()

    End Sub

    Private Sub Button_reservaVIP_Click(sender As Object, e As EventArgs) Handles Button_reservaVIP.Click

        EmpresaCruzeiros.gravar()
    End Sub
End Class