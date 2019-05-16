Public Class FormLogin
    Private Sub Button_entrar_Click(sender As Object, e As EventArgs) Handles Button_entrar.Click
        Dim TempForm As New FormPrincipal

        TempForm.Show()

    End Sub

    Private Sub Button_Adicionar_Click(sender As Object, e As EventArgs) Handles Button_Adicionar.Click
        Dim TempForm As New FormNovoRegisto_Viajante

        TempForm.Show()
    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VariavelGlobal.InitVars()
    End Sub
End Class