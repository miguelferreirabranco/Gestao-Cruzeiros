Public Class FormLogin
    Private Sub Button_entrar_Click(sender As Object, e As EventArgs) Handles Button_entrar.Click
        Dim TempForm As New FormPrincipal

        TempForm.Show()

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

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim loginok As Boolean
        Dim Nivel As Integer

        ValidaLogin(Me.TextBox_username.Text, Me.TextBox_password.Text, loginok, Nivel)
        _loginok = loginok

        If _loginok Then
            RaiseEvent loginok(Me.TextBox_username.Text, Nivel)
            Me.Close()
        Else
            MsgBox("Login Errado")

        End If




    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click

        _loginok = False
        RaiseEvent LoginErro(Me.TextBox_username.Text, "Login Cancelado")
        Me.Close()
    End Sub



    Private Sub LoginForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

    End Sub

    Private Sub ValidaLogin(ByVal NomeUser As String, ByVal Password As String, ByRef loginok As Boolean, ByRef Nivel As Single)
        loginok = False
        For i = 0 To EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Viajantes.Count - 1
            If EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Viajantes(i).Login = NomeUser Then
                If EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Viajantes(i).Password = Password Then
                    ViajanteVisivel = i
                    Nivel = "Viajante"
                    MsgBox("Login efetuado com sucesso como viajante")
                    loginok = True
                    Exit Sub
                End If
            End If
        Next

        For i = 0 To EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Funcionarios.Count - 1
            If EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Funcionarios(i).Login = NomeUser Then
                If EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Funcionarios(i).Password = Password Then
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