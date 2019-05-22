Public Class FormCruzeiros
    Public Sub mostra()
        If EmpresaCruzeiros.Cruzeiros.Count > 0 Then
            If CruzeiroVisivel < 0 Then
                CruzeiroVisivel = 0
            ElseIf CruzeiroVisivel > EmpresaCruzeiros.Cruzeiros.Count - 1 Then
                CruzeiroVisivel = EmpresaCruzeiros.Cruzeiros.Count - 1
            End If

            TextBox_nome.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Nome
            TextBox_origem.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).LocalInicio
            TextBox_destino.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).LocalFim
            DateTimePicker_datainicial.Value = EmpresaCruzeiros.Cruzeiros(cr)
        End If
    End Sub

End Class