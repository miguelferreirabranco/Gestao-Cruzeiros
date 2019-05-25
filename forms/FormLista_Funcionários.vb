Public Class FormLista_Funcionários

    Private Sub FormLista_Funcionários_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ler()


        ListView1.Items.Clear()

        For k = 0 To EmpresaCruzeiros.Funcionarios.Count - 1
            Dim item As New ListViewItem(EmpresaCruzeiros.Funcionarios(k).Login)
            item.SubItems.Add(EmpresaCruzeiros.Funcionarios(k).Nome)
            item.SubItems.Add(EmpresaCruzeiros.Funcionarios(k).Numero_cc)
            item.SubItems.Add(EmpresaCruzeiros.Funcionarios(k).Nib)
            ListView1.Items.Add(item)
        Next
    End Sub

End Class