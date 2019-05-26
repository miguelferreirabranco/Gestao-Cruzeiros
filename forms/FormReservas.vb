Public Class FormReservas

    Public Sub Mostra()
        Dim k, j, l As Integer

        ListBox1.Items.Clear()

        If EmpresaCruzeiros.Viajantes(ViajanteVisivel).CruzeirosMarcados.Count > 0 Then

            ListBox1.Items.Add("Cruzeiros Marcados:")

            For k = 0 To EmpresaCruzeiros.Viajantes(ViajanteVisivel).CruzeirosMarcados.Count - 1
                ListBox1.Items.Add(EmpresaCruzeiros.Viajantes(ViajanteVisivel).CruzeirosMarcados(k).Nome)
            Next
            ListBox1.Items.Add("")
            ListBox1.Items.Add("Atividades no Navio Marcadas:")

            For j = 0 To EmpresaCruzeiros.Viajantes(ViajanteVisivel).AtividadesNavioMarcadas.Count - 1
                ListBox1.Items.Add(EmpresaCruzeiros.Viajantes(ViajanteVisivel).AtividadesNavioMarcadas(j).Nome)
            Next
            ListBox1.Items.Add("")
            ListBox1.Items.Add("Atividades nas Paragens Marcadas:")

            For l = 0 To EmpresaCruzeiros.Viajantes(ViajanteVisivel).AtividadesParagensMarcadas.Count - 1
                ListBox1.Items.Add(EmpresaCruzeiros.Viajantes(ViajanteVisivel).AtividadesParagensMarcadas(l).Nome)
            Next



        End If

    End Sub

    Private Sub FormReservas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ler()
        Mostra()
    End Sub
End Class