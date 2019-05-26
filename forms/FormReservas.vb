Public Class FormReservas

    Public Sub Mostra()
        Dim k, i, j, l As Integer

        ListBox1.Items.Clear()

        If EmpresaCruzeiros.Viajantes(ViajanteVisivel).CruzeirosMarcados.Count > 0 Then

            For k = 0 To EmpresaCruzeiros.Viajantes(ViajanteVisivel).CruzeirosMarcados.Count - 1
                ListBox1.Items.Add(EmpresaCruzeiros.Viajantes(ViajanteVisivel).CruzeirosMarcados(k).Nome)

                For i = 0 To EmpresaCruzeiros.Viajantes(ViajanteVisivel).CruzeirosMarcados(k).Quartos.Count - 1
                    ListBox1.Items.Add("Número do quarto: " & EmpresaCruzeiros.Viajantes(ViajanteVisivel).CruzeirosMarcados(k).Quartos(i).Nquarto)
                Next

                For j = 0 To EmpresaCruzeiros.Viajantes(ViajanteVisivel).CruzeirosMarcados(k).AtividadesNavio.Count - 1
                    ListBox1.Items.Add("Atividades no Navio: " & EmpresaCruzeiros.Viajantes(ViajanteVisivel).CruzeirosMarcados(k).AtividadesNavio(j).Nome)
                Next

                For l = 0 To EmpresaCruzeiros.Viajantes(ViajanteVisivel).CruzeirosMarcados(k).AtividadesParagens.Count - 1
                    ListBox1.Items.Add("Atividades nas Paragens: " & EmpresaCruzeiros.Viajantes(ViajanteVisivel).CruzeirosMarcados(k).AtividadesParagens(l).Nome)
                Next

            Next

        End If

    End Sub

End Class