Public Class FormListaQuartos

    Private WithEvents FormQuartos As FormQuartos
    Private QuartoVisivel As Integer = 0
    Public UltimaLinha As Integer

    Private Sub FormListaQuartos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.ColumnCount = 4
        UltimaLinha = Me.DataGridView1.Rows.Count()
        mostra()
    End Sub


    Private Sub QuartoAdicionado(ByVal nquarto As Integer) Handles FormQuartos.AdicionarQuarto
        'Dim k As Integer = 1
        'Dim temp As Boolean = False
        'While k <= 4 And temp = False
        '    If Me.DataGridView1.Item(k, UltimaLinha).Value = "" Then
        '        Me.DataGridView1.Item(k, UltimaLinha).Value = nquarto
        '        temp = True
        '    End If
        '    k = k + 1
        'End While

        'If temp = False Then
        '    Me.DataGridView1.RowCount = Me.DataGridView1.RowCount + 1
        '    UltimaLinha = Me.DataGridView1.Rows.Count()
        '    Me.DataGridView1.Item(1, UltimaLinha).Value = nquarto
        'End If

        Me.DataGridView1.Item(3, 1).Value = 103

    End Sub

    Public Sub mostra()
        Me.TextBox_numero.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(QuartoVisivel).Nquarto
        Me.TextBox_npessoas.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(QuartoVisivel).Npessoas
        Me.TextBox_preco.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(QuartoVisivel).Ppessoa
        Me.TextBox_seccao.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(QuartoVisivel).Seccao
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
            Me.DataGridView1.Item(ncoluna, nlinha).Value = "Reservado!"
        Else
            Me.DataGridView1.Item(ncoluna, nlinha).Style.BackColor = Color.Green
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Dim nlinha As Integer = e.RowIndex
        ' Dim ncoluna As Integer = e.ColumnIndex
        'Dim nlinha As Integer = 1
        'Dim ncoluna As Integer = 1
        Dim numeroquarto As Integer 'numero que apareca na celula
        Dim numeroposicao As Integer 'posicao do quarto na lista

        numeroquarto = DataGridView1.Item(ncoluna, nlinha).Value
        numeroposicao = ProcurarQuarto(numeroquarto)
        MudarCor(numeroposicao, nlinha, ncoluna)

        QuartoVisivel = numeroposicao
        mostra()
    End Sub



    Private Sub Button_Reservar_Click(sender As Object, e As EventArgs) Handles Button_Reservar.Click
        EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(QuartoVisivel).Reservar(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Viajantes(ViajanteVisivel).Login)

        gravar()
    End Sub

    Private Sub Button_anular_Click(sender As Object, e As EventArgs) Handles Button_anular.Click
        EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Quartos(QuartoVisivel).AnularReserva(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Viajantes(ViajanteVisivel).Login)

        gravar()
    End Sub
End Class