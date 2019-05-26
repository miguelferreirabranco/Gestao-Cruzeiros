Public Class FormValidacao
    Private Sub ButtonValidar_Click(sender As Object, e As EventArgs) Handles ButtonValidar.Click
        If Me.TextBoxCodigo.Text = "func2019" Then
            Dim TempFormFuncionario As New FormNovoRegisto_Funcionário
            TempFormFuncionario.Show()
            Me.Close()
        Else
            MsgBox("Código incorreto, tente novamente!")
            Me.TextBoxCodigo.Clear()
        End If
    End Sub
End Class