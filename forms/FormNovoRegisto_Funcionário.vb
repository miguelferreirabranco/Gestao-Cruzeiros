Public Class FormNovoRegisto_Funcionário
    Private novofuncionario As ClassFuncionario
    Private lista_func As ClassFuncionarios
    Private visivel_func As Integer = 0

    Private Sub Button_Registar_Click(sender As Object, e As EventArgs) Handles Button_Registar.Click
        novofuncionario = New ClassFuncionario(TextBox_nome.Text, TextBox_sexo.Text, DateTimePicker_datanasc.Value,
                                               TextBox_ncc.Text, TextBox_username.Text, TextBox_password.Text,
                                              TextBox_nib.Text)

        If pessoa_existente(Me.TextBox_ncc.Text) = True Then
            Dim TempForm As New FormLogin
            TempForm.Show()
            'Dúvida!!! Forço a abertura do FormLogin ou deixo o utilizador fechar este e ir para o do login 
            MsgBox("Já possui um registo! Basta fazer o login!")
        Else
            If username_existente(Me.TextBox_username.Text) = True Then
                MsgBox("Este nome de utilizador já existe! Experimente outro diferente!")
                Me.TextBox_username.Clear()
            Else
                Me.lista_func.Add(novofuncionario)
                visivel_func = Me.lista_func.Count - 1
                Dim TempForm As New FormLogin
                TempForm.Show()
                'Mesma dúvida!!!
                MsgBox("Registo efetuado com sucesso! Autentique-se com os seus dados de Login!")
            End If
        End If
    End Sub

    Public Function pessoa_existente(ByVal cod As String) As Boolean
        Dim temp As Boolean = False
        Dim k As Integer = 0
        While k <= Me.lista_func.Count - 1 And temp = False
            If Me.lista_func(k).Numero_cc = cod Then
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
        While k <= Me.lista_func.Count - 1 And temp = False
            If Me.lista_func(k).Login = name Then
                temp = True
            Else
                temp = False
            End If
            k = k + 1
        End While
        Return temp
    End Function

End Class