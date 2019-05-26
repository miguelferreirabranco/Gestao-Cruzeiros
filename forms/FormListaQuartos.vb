Public Class FormListaQuartos

    Private WithEvents FormQuartos As New FormQuartos
    Private QuartoVisivel As Integer = 0


    Private Sub FormListaQuartos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ler()
        Me.TextBoxEstado.Enabled = False
        Me.TextBox_npessoas.Enabled = False
        Me.TextBox_numero.Enabled = False
        Me.TextBox_preco.Enabled = False
        Me.ComboBoxSeccao.Enabled = False

        DataGridView1.ColumnCount = 4
        mostradatagrid()
        mostratext()
    End Sub



    Public Sub mostratext()
        Me.TextBox_numero.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(QuartoVisivel).Nquarto
        Me.TextBox_npessoas.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(QuartoVisivel).Npessoas
        Me.TextBox_preco.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(QuartoVisivel).Ppessoa
        Me.ComboBoxSeccao.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(QuartoVisivel).Seccao

        If EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(QuartoVisivel).Reservado = True Then
            Me.TextBoxEstado.Text = "Reservado"
        Else
            Me.TextBoxEstado.Text = "Disponível"
        End If
    End Sub
    Public Sub mostradatagrid()
        Dim k As Integer
        Dim Len As Integer
        Dim aux As Integer
        Dim n As Integer

        Me.DataGridView1.Rows.Clear()

        Len = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos.Count
        aux = Len Mod 4

        k = 0
        n = 0
        While k < (Len - aux) / 4
            Me.DataGridView1.Rows.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(n).Nquarto, EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(n + 1).Nquarto, EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(n + 2).Nquarto, EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(n + 3).Nquarto)
            k = k + 1
            n = n + 4
        End While


        k = Len - aux
        If aux = 0 Then
            Me.DataGridView1.Rows.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(k).Nquarto, EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(k + 1).Nquarto, EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(k + 2).Nquarto, EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(k + 3).Nquarto)
        ElseIf aux = 1 Then
            Me.DataGridView1.Rows.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(k).Nquarto, "", "", "")
        ElseIf aux = 2 Then
            Me.DataGridView1.Rows.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(k).Nquarto, EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(k + 1).Nquarto, "", "")
        ElseIf aux = 3 Then
            Me.DataGridView1.Rows.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(k).Nquarto, EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(k + 1).Nquarto, EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(k + 2).Nquarto, "")
        End If

        k = 0
        Dim coluna As Integer = 0
        Dim linha As Integer = 0




    End Sub
    Private Function ProcurarQuarto(ByVal numero As Integer) As Integer
        Dim temp As Integer = -1
        Dim k As Integer = 0
        Dim aux As Boolean = False
        While k <= EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos.Count - 1 And aux = False
            If EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(k).Nquarto = numero Then
                temp = k
                aux = True
            End If
            k = k + 1
        End While
        Return temp
    End Function

    Private Sub MudarCor(ByVal posquarto As Integer, ByVal nlinha As Integer, ByVal ncoluna As Integer)
        If EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(posquarto).Reservado = True Then
            Me.DataGridView1.Item(ncoluna, nlinha).Style.BackColor = Color.Red
        Else
            Me.DataGridView1.Item(ncoluna, nlinha).Style.BackColor = Color.Green
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim nlinha As Integer = e.RowIndex
        Dim ncoluna As Integer = e.ColumnIndex

        Dim numeroquarto As Integer 'numero que apareca na celula
        Dim numeroposicao As Integer 'posicao do quarto na lista


        If DataGridView1.Item(ncoluna, nlinha).Value.ToString <> "" Then
            numeroquarto = DataGridView1.Item(ncoluna, nlinha).Value
            numeroposicao = ProcurarQuarto(numeroquarto)
            MudarCor(numeroposicao, nlinha, ncoluna)
        Else
            MsgBox("Esse quarto não existe!")
        End If

        QuartoVisivel = numeroposicao
        mostratext()
    End Sub



    Private Sub Button_Reservar_Click(sender As Object, e As EventArgs) Handles Button_Reservar.Click
        EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(QuartoVisivel).Reservar(EmpresaCruzeiros.Viajantes(ViajanteVisivel).Login)

        gravar()
    End Sub

    Private Sub Button_anular_Click(sender As Object, e As EventArgs) Handles Button_anular.Click
        EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(QuartoVisivel).AnularReserva(EmpresaCruzeiros.Viajantes(ViajanteVisivel).Login)

        gravar()
    End Sub
End Class