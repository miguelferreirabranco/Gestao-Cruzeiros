Public Class FormParagens
    Public i As Integer = 0


    Private Sub Button_inicio_Click(sender As Object, e As EventArgs) Handles Button_inicio.Click
        i = 0
        LoadForm()
    End Sub
    Sub LoadForm()
        Me.TextBox_dia.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(i).Data
        Me.TextBox_horafim.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(i).HoraFim
        Me.TextBox_horainicio.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(i).HoraInicio
        Me.TextBox_local.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(i).LocalParagem
    End Sub

    Private Sub Button_anterior_Click(sender As Object, e As EventArgs) Handles Button_anterior.Click
        If i = 0 Then
            MsgBox("Já está a ver a primeira paragem!")
        Else
            i += -1
            LoadForm()
        End If
    End Sub

    Private Sub Button_seguinte_Click(sender As Object, e As EventArgs) Handles Button_seguinte.Click
        If i = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens.Count - 1 Then
            MsgBox("Já está a ver a última paragem!")
        Else
            i += 1
            LoadForm()
        End If
    End Sub

    Private Sub Button_fim_Click(sender As Object, e As EventArgs) Handles Button_fim.Click
        i = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens.Count - 1
        LoadForm()
    End Sub

    Private Sub Button_Adicionar_Click(sender As Object, e As EventArgs) Handles Button_Adicionar.Click
        Dim paragem As ClassParagem
        paragem = New ClassParagem(Me.TextBox_local.Text, Me.TextBox_dia.Text, Me.TextBox_horainicio.Text, Me.TextBox_horafim.Text)
        EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens.Add(paragem)

        i = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens.Count - 1

        For k = 0 To EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens.Count - 1
            Me.ListBox_Paragens.Items.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(k).ParaString)
        Next

        gravar()

    End Sub

    Private Sub FormParagens_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If NivelVisivel = "Viajante" Then
            Me.Button_Adicionar.Visible = False
        End If
    End Sub
End Class