Public Class FormLista_Funcionários

    Private Sub FormLista_Funcionários_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        EmpresaCruzeiros.ler()

        ListBox_funcionarios.Items.Clear()

        For i = 0 To EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Funcionarios.Count - 1

            ListBox_funcionarios.Items.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Funcionarios(i).Pessoa_str)

        Next

    End Sub

End Class