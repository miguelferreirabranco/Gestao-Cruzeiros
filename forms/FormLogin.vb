Public Class FormLogin
    Private Sub Button_entrar_Click(sender As Object, e As EventArgs) Handles Button_entrar.Click
        Dim TempForm As New FormPrincipal
        Dim loginok As Boolean
        Dim Nivel As String

        ValidaLogin(Me.TextBox_username.Text, Me.TextBox_password.Text, loginok, Nivel)



        If loginok = True Then
            TempForm.Show()
        Else
            MsgBox("login Incorreto, tente outra vez")
        End If
    End Sub

    Private Sub Button_Adicionar_Click(sender As Object, e As EventArgs) Handles Button_Adicionar.Click
        Dim TempFormViajante As New FormNovoRegisto_Viajante
        Dim TempFormFuncionario As New FormNovoRegisto_Funcionário

        If RadioButtonFuncionario.Checked Then
            TempFormFuncionario.Show()
        Else
            TempFormViajante.Show()

        End If


    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        VariavelGlobal.InitVars()
    End Sub


    Public Event LoginOK(ByVal NomeUser As String, ByVal Nivel As String)
    Public Event LoginErro(ByVal NomeUser As String, ByVal Erro As String)

    Private _loginok As Boolean = False


    Private Sub ValidaLogin(ByVal NomeUser As String, ByVal Password As String, ByRef loginok As Boolean, ByRef Nivel As String)
        loginok = False
        For i = 0 To EmpresaCruzeiros.Viajantes.Count - 1
            If EmpresaCruzeiros.Viajantes(i).Login = NomeUser Then
                If EmpresaCruzeiros.Viajantes(i).Password = Password Then
                    ViajanteVisivel = i
                    Nivel = "Viajante"
                    MsgBox("Login efetuado com sucesso como viajante")
                    loginok = True
                    Exit Sub
                End If
            End If
        Next

        For i = 0 To EmpresaCruzeiros.Funcionarios.Count - 1
            If EmpresaCruzeiros.Funcionarios(i).Login = NomeUser Then
                If EmpresaCruzeiros.Funcionarios(i).Password = Password Then
                    FuncionarioVisivel = i
                    Nivel = "Funcionario"
                    MsgBox("Login efetuado com sucesso como funcionario")
                    loginok = True
                    Exit Sub
                End If
            End If
        Next

    End Sub
End Class