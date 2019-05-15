﻿Imports System.Windows.Forms

Public Class FormPrincipal

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        ' Cria uma nova instância do formulário filho.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Torná-lo uma criança deste formulário MDI antes de mostrá-lo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Janela " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Adicione aqui código para abrir o arquivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Adicionar código aqui para salvar em arquivo o conteúdo atual do formulário.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Use My.Computer.Clipboard para inserir texto ou imagens selecionados na Área de Transferência
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Use My.Computer.Clipboard para inserir texto ou imagens selecionados na Área de Transferência
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Use My.Computer.Clipboard.GetText() ou My.Computer.Clipboard.GetData para obter informações da Área de Transferência.
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Feche todos os formulários filhos do pai.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub CruzeirosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CruzeirosToolStripMenuItem.Click
        ' Cria uma nova instância do formulário filho.
        Dim ChildForm As New Cruzeiros
        ' Torná-lo uma criança deste formulário MDI antes de mostrá-lo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Janela " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub QuartosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuartosToolStripMenuItem.Click
        ' Cria uma nova instância do formulário filho.
        Dim ChildForm As New Quartos
        ' Torná-lo uma criança deste formulário MDI antes de mostrá-lo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Janela " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub AtividadesNavioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtividadesNavioToolStripMenuItem.Click
        ' Cria uma nova instância do formulário filho.
        Dim ChildForm As New Paragens
        ' Torná-lo uma criança deste formulário MDI antes de mostrá-lo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Janela " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub NavioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NavioToolStripMenuItem.Click
        ' Cria uma nova instância do formulário filho.
        Dim ChildForm As New Atividades_Navio
        ' Torná-lo uma criança deste formulário MDI antes de mostrá-lo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Janela " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub ParagensToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ParagensToolStripMenuItem1.Click
        ' Cria uma nova instância do formulário filho.
        Dim ChildForm As New Atividades_Paragens
        ' Torná-lo uma criança deste formulário MDI antes de mostrá-lo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Janela " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub ViajantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViajantesToolStripMenuItem.Click
        ' Cria uma nova instância do formulário filho.
        Dim ChildForm As New Lista_Viajantes
        ' Torná-lo uma criança deste formulário MDI antes de mostrá-lo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Janela " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub FuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FuncionáriosToolStripMenuItem.Click
        ' Cria uma nova instância do formulário filho.
        Dim ChildForm As New Lista_Funcionários
        ' Torná-lo uma criança deste formulário MDI antes de mostrá-lo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Janela " & m_ChildFormNumber

        ChildForm.Show()
    End Sub
End Class
