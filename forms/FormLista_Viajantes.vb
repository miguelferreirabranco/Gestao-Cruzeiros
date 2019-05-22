Public Class FormLista_Viajantes

    Private Sub FormLista_Viajantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        EmpresaCruzeiros.ler()

        ListBox_viajantes.Items.Clear()

        For i = 0 To EmpresaCruzeiros.Viajantes.Count - 1

            ListBox_viajantes.Items.Add(EmpresaCruzeiros.Viajantes(i).Pessoa_str)

        Next

    End Sub

End Class