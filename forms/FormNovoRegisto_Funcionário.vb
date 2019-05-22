Public Class FormNovoRegisto_Funcionário


    Private Sub Button_Registar_Click(sender As Object, e As EventArgs) Handles Button_Registar.Click
        Dim novofuncionario As ClassFuncionario


        If funcionario_existente(Me.TextBox_ncc.Text) = True Then
            Dim TempForm As New FormLogin
            TempForm.Show()

            MsgBox("Já possui um registo! Basta fazer o login!")
        Else
            If username_existente(Me.TextBox_username.Text) = True Then
                MsgBox("Este nome de utilizador já existe! Experimente outro diferente!")
                Me.TextBox_username.Clear()
            Else
                novofuncionario = New ClassFuncionario(TextBox_nome.Text, TextBox_sexo.Text, DateTimePicker_datanasc.Value,
                                              TextBox_ncc.Text, TextBox_username.Text, TextBox_password.Text,
                                             TextBox_nib.Text)
                EmpresaCruzeiros.Funcionarios.Add(novofuncionario)
                FuncionarioVisivel = EmpresaCruzeiros.Funcionarios.Count - 1

                Dim TempForm As New FormLogin
                TempForm.Show()

                MsgBox("Registo efetuado com sucesso! Autentique-se com os seus dados de Login!")
            End If
        End If

        EmpresaCruzeiros.gravar()

    End Sub

    Public Function funcionario_existente(ByVal cod As String) As Boolean
        Dim temp As Boolean = False
        Dim k As Integer = 0
        While k <= EmpresaCruzeiros.Funcionarios.Count - 1 And temp = False
            If EmpresaCruzeiros.Funcionarios(k).Numero_cc = cod Then
                temp = True
            Else
                temp = False
            End If
            k = k + 1
        End While
        Return temp
    End Function

    Public Function username_existente(ByVal name As String) As Boolean
        Dim temp As Boolean = False
        Dim k As Integer = 0
        While k <= EmpresaCruzeiros.Funcionarios.Count - 1 And temp = False
            If EmpresaCruzeiros.Funcionarios(k).Login = name Then
                temp = True
            Else
                temp = False
            End If
            k = k + 1
        End While
        Return temp
    End Function

End Class