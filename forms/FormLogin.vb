Public Class FormLogin
    Public Event LoginOK(ByVal NomeUser As String, ByVal Nivel As String)
    Public Event LoginErro()

    Private Verloginok As Boolean = False
    Private Sub Button_entrar_Click(sender As Object, e As EventArgs) Handles Button_entrar.Click
        Dim TempForm As New FormPrincipal

        Dim Nivel As String

        ValidaLogin(Me.TextBox_username.Text, Me.TextBox_password.Text, Verloginok, Nivel)



        If Verloginok = True Then
                NivelVisivel = Nivel
                RaiseEvent LoginOK(TextBox_username.Text, NivelVisivel)
            Me.Close()

        Else
                Me.TextBox_username.Clear()
                Me.TextBox_password.Clear()

                RaiseEvent LoginErro()

            End If


    End Sub

    Private Sub Button_Adicionar_Click(sender As Object, e As EventArgs) Handles Button_Adicionar.Click
        Dim TempFormViajante As New FormNovoRegisto_Viajante
        Dim TempFormFuncionario As New FormNovoRegisto_Funcionário

        If RadioButtonFuncionario.Checked Then
            TempFormFuncionario.Show()
        ElseIf RadioButtonViajante.Checked Then
            TempFormViajante.Show()
        Else

            MsgBox("Selecione qual o tipo de utilizador!")

        End If


    End Sub




    Private Sub ValidaLogin(ByVal NomeUser As String, ByVal Password As String, ByRef loginok As Boolean, ByRef Nivel As String)
        Dim i As Integer



        While i <= EmpresaCruzeiros.Viajantes.Count - 1 And loginok = False

            If EmpresaCruzeiros.Viajantes(i).Login = NomeUser Then
                If EmpresaCruzeiros.Viajantes(i).Password = Password Then
                    ViajanteVisivel = i
                    Nivel = "Viajante"
                    Verloginok = True

                End If
            End If
            i = i + 1
        End While

        If Verloginok = False Then
            i = 0
            While i <= EmpresaCruzeiros.Funcionarios.Count - 1 And loginok = False
                If EmpresaCruzeiros.Funcionarios(i).Login = NomeUser Then
                    If EmpresaCruzeiros.Funcionarios(i).Password = Password Then
                        FuncionarioVisivel = i
                        Nivel = "Funcionario"
                        Verloginok = True

                    End If
                End If
                i = i + 1
            End While
        End If


    End Sub

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        If NivelVisivel = "" Then
            FormPrincipal.Close()
        End If
    End Sub

    Private Sub FormLogin_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class