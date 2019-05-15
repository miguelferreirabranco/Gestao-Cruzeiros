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
        Me.TextBox_numero.Text = EmpresaCruzeiros(X).Quartos(i).Nquarto
        Me.TextBox_npessoas.Text = EmpresaCruzeiros(X).Quartos(i).Npessoas
        Me.TextBox_preco.Text = EmpresaCruzeiros(X).Quartos(i).Ppessoa
        Me.TextBox_seccao.Text = EmpresaCruzeiros(X).Quartos(i).Seccao
    End Sub

    Private Sub Button_inicio_Click(sender As Object, e As EventArgs) Handles Button_inicio.Click
        i = 0
        LoadForm()
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
        Dim quarto As ClassQuarto
        quarto = New ClassQuarto(Me.TextBox_npessoas.Text, i + 1, Me.TextBox_preco.Text, Me.TextBox_seccao.Text)
        EmpresaCruzeiros(X).Quartos.Add(quarto)
        i = EmpresaCruzeiros(X).Quartos.Count - 1
    End Sub

    Private Sub Button_Reservar_Click(sender As Object, e As EventArgs) Handles Button_Reservar.Click

        EmpresaCruzeiros(X).Quartos(i).Reservar(USERNAME) ' ajustar quando se puser um login
    End Sub

    Private Sub Button_anular_Click(sender As Object, e As EventArgs) Handles Button_anular.Click

        EmpresaCruzeiros(X).Quartos(i).AnularReserva(USERNAME) ' ajustar quando se puser um login
    End Sub
End Class