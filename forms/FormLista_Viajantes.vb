Public Class FormLista_Viajantes

    Private Sub FormLista_Viajantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        EmpresaCruzeiros.ler()

        ListBox_viajantes.Items.Clear()

        For i = 0 To EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Viajantes.Count - 1

            ListBox_viajantes.Items.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Viajantes(i).Pessoa_str)

        Next

    End Sub

End Class