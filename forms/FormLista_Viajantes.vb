Public Class FormLista_Viajantes

    Private Sub FormLista_Viajantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ler()




        ListView1.Items.Clear()

        For k = 0 To EmpresaCruzeiros.Viajantes.Count - 1
            Dim item As New ListViewItem(EmpresaCruzeiros.Viajantes(k).Login)
            item.SubItems.Add(EmpresaCruzeiros.Viajantes(k).Nome)
            item.SubItems.Add(EmpresaCruzeiros.Viajantes(k).Numero_cc)
            item.SubItems.Add(EmpresaCruzeiros.Viajantes(k).Nif)
            ListView1.Items.Add(item)
        Next
    End Sub

End Class