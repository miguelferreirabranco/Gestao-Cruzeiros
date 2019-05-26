Public Class FormParagens
    Public paragemvisivel As Integer = 0



    Public Sub mostra()
        Dim k As Integer

        If EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens.Count > 0 Then

            If paragemvisivel < 0 Then
                paragemvisivel = 0
            ElseIf paragemvisivel > EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens.Count - 1 Then
                paragemvisivel = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens.Count - 1

            End If

            Me.DateTimePickerData.Value = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(paragemvisivel).DataInicio.Date
            Me.HoraInicio.Value = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(paragemvisivel).DataInicio.Hour
            Me.MinutoInicio.Value = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(paragemvisivel).DataInicio.Minute
            Me.HoraFim.Value = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(paragemvisivel).DataFim.Hour
            Me.MinutoFim.Value = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(paragemvisivel).DataFim.Minute
            Me.TextBox_local.Text = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(paragemvisivel).LocalParagem



            ListView1.Items.Clear()

            For k = 0 To EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens.Count - 1
                Dim item As New ListViewItem(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(k).LocalParagem)
                item.SubItems.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(k).DataInicio.ToShortDateString)
                item.SubItems.Add(EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(k).DataInicio.Hour & ":" & EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(k).DataInicio.Minute & " - " & EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(k).DataFim.Hour & ":" & EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens(k).DataFim.Minute)
                ListView1.Items.Add(item)
            Next
        End If
    End Sub
    Private Sub Button_inicio_Click(sender As Object, e As EventArgs) Handles Button_inicio.Click
        paragemvisivel = 0
        mostra()
    End Sub
    Private Sub Button_anterior_Click(sender As Object, e As EventArgs) Handles Button_anterior.Click
        paragemvisivel = paragemvisivel - 1
        mostra()
    End Sub

    Private Sub Button_seguinte_Click(sender As Object, e As EventArgs) Handles Button_seguinte.Click
        paragemvisivel = paragemvisivel + 1
        mostra()
    End Sub

    Private Sub Button_fim_Click(sender As Object, e As EventArgs) Handles Button_fim.Click
        paragemvisivel = paragemvisivel + 1
        mostra()
    End Sub


    Private Sub Button_Adicionar_Click(sender As Object, e As EventArgs) Handles Button_Adicionar.Click
        Dim paragem As ClassParagem
        Dim data As Date = Me.DateTimePickerData.Value
        Dim datainicio As New System.DateTime(data.Year, data.Month, data.Day, Me.HoraInicio.Value, Me.MinutoInicio.Value, 0)
        Dim datafim As New System.DateTime(data.Year, data.Month, data.Day, Me.HoraFim.Value, Me.MinutoFim.Value, 0)
        paragem = New ClassParagem(Me.TextBox_local.Text, datainicio, datafim)
        EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens.Add(paragem)

        paragemvisivel = EmpresaCruzeiros.Cruzeiros(CruzeiroVisivel).Paragens.Count - 1
        gravar()

        mostra()

    End Sub

    Private Sub FormParagens_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If NivelVisivel = "Viajante" Then
            Me.Button_Adicionar.Visible = False
            Me.HoraFim.Enabled = False
            Me.HoraInicio.Enabled = False
            Me.MinutoFim.Enabled = False
            Me.MinutoInicio.Enabled = False
            Me.TextBox_local.Enabled = False
            Me.DateTimePickerData.Enabled = False
            Me.ButtonNova.Visible = False
        End If

        mostra()
    End Sub

    Private Sub ButtonNova_Click(sender As Object, e As EventArgs) Handles ButtonNova.Click
        Me.TextBox_local.Clear()
        Me.DateTimePickerData.Value = Today
        Me.HoraInicio.Value = 0
        Me.HoraFim.Value = 0
    End Sub
End Class