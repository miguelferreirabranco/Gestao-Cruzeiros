Public Class FormNovoRegisto_Viajante


    Private Sub Button_Registar_Click(sender As Object, e As EventArgs) Handles Button_Registar.Click

        Dim novoviajante As ClassViajante

        If viajante_existente(Me.TextBox_ncc.Text) = True Then
            'Dim TempForm As New FormLogin

            'TempForm.Show()
            Me.Close()
            MsgBox("Já possui um registo! Basta fazer o login!")
        Else
            If username_existente(Me.TextBox_username.Text) = True Then
                MsgBox("Este nome de utilizador já existe! Experimente outro diferente!")
                Me.TextBox_username.Clear()
            Else
                novoviajante = New ClassViajante(TextBox_nome.Text, ComboBoxSexo.SelectedItem, DateTimePicker_datanasc.Value.ToShortDateString,
                                               TextBox_ncc.Text, TextBox_username.Text, TextBox_password.Text,
                                              TextBox_nif.Text)

                EmpresaCruzeiros.Viajantes.Add(novoviajante)
                gravar()
                ViajanteVisivel = EmpresaCruzeiros.Viajantes.Count - 1
                ' Dim TempForm As New FormLogin

                'TempForm.Show()
                Me.Close()
                MsgBox("Registo efetuado com sucesso! Autentique-se com os seus dados de Login!")
            End If
        End If



    End Sub

    Public Function viajante_existente(ByVal cod As String) As Boolean
        Dim temp As Boolean = False
        Dim k As Integer = 0
        While k <= EmpresaCruzeiros.Viajantes.Count - 1 And temp = False
            If EmpresaCruzeiros.Viajantes(k).Numero_cc = cod Then
                temp = True
            End If
            k = k + 1
        End While
        Return temp
    End Function

    Public Function username_existente(ByVal name As String) As Boolean
        Dim temp As Boolean = False
        Dim k As Integer = 0
        While k <= EmpresaCruzeiros.Viajantes.Count - 1 And temp = False
            If EmpresaCruzeiros.Viajantes(k).Login = name Then
                temp = True
            End If
            k = k + 1
        End While
        Return temp
    End Function

    Private Sub FormNovoRegisto_Viajante_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ler()
    End Sub
End Class