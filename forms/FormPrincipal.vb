Imports System.Windows.Forms

Public Class FormPrincipal

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs)
        ' Cria uma nova instância do formulário filho.
        Dim ChildForm As New System.Windows.Forms.Form
        ' Torná-lo uma criança deste formulário MDI antes de mostrá-lo.
        ChildForm.MdiParent = Me

        m_ChildFormNumber += 1
        ChildForm.Text = "Janela " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs)
        Dim OpenFileDialog As New OpenFileDialog
        OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        OpenFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*"
        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = OpenFileDialog.FileName
            ' TODO: Adicione aqui código para abrir o arquivo.
        End If
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim SaveFileDialog As New SaveFileDialog
        SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
        SaveFileDialog.Filter = "Arquivos de texto (*.txt)|*.txt|Todos os arquivos (*.*)|*.*"

        If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            Dim FileName As String = SaveFileDialog.FileName
            ' TODO: Adicionar código aqui para salvar em arquivo o conteúdo atual do formulário.
        End If
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard para inserir texto ou imagens selecionados na Área de Transferência
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Use My.Computer.Clipboard para inserir texto ou imagens selecionados na Área de Transferência
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        'Use My.Computer.Clipboard.GetText() ou My.Computer.Clipboard.GetData para obter informações da Área de Transferência.
    End Sub

    'Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    'End Sub

    'Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
    '    Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    'End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' Feche todos os formulários filhos do pai.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer

    Private Sub CruzeirosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CruzeirosToolStripMenuItem.Click
        ' Cria uma nova instância do formulário filho.
        Dim ChildForm As New FormCruzeiros
        ' Torná-lo uma criança deste formulário MDI antes de mostrá-lo.
        ChildForm.MdiParent = Me

        'm_ChildFormNumber += 1
        'ChildForm.Text = "Janela " & m_ChildFormNumber

        ChildForm.Show()
    End Sub



    Private WithEvents FormLogin As FormLogin


    Private Sub LoginOK(ByVal username As String, ByVal nivel As String) Handles FormLogin.LoginOK
        MsgBox("Login efetuado com sucesso com o username " & username & " como " & nivel & "!")
        Me.Show()

        If NivelVisivel = "Viajante" Then
            ListaFuncionáriosToolStripMenuItem.Visible = False
            ListaViajantesToolStripMenuItem.Visible = False
            QuartosFuncionáriosToolStripMenuItem.Visible = False
        ElseIf NivelVisivel = "Funcionario" Then
            ReservasToolStripMenuItem.Visible = False
        End If

        If EmpresaCruzeiros.Viajantes(ViajanteVisivel).CruzeirosMarcados.Count = 0 Then
            QuartosToolStripMenuItem.Visible = False
            ParagensToolStripMenuItem.Visible = False
        End If

    End Sub

    Private Sub LoginErro() Handles FormLogin.LoginErro

        MsgBox("Dados de Login incorretos, tente novamente!")
    End Sub

    Private Sub FormPrincipal_Load(sender As Object, e As EventArgs) Handles Me.Load
        VariavelGlobal.InitVars()

        FormLogin = New FormLogin
        FormLogin.ShowDialog()

    End Sub

    Private Sub ParagensToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ParagensToolStripMenuItem1.Click
        ' Cria uma nova instância do formulário filho.
        Dim ChildForm As New FormParagens
        ' Torná-lo uma criança deste formulário MDI antes de mostrá-lo.
        ChildForm.MdiParent = Me

        'm_ChildFormNumber += 1
        'ChildForm.Text = "Janela " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub AtNavioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AtNavioToolStripMenuItem.Click
        ' Cria uma nova instância do formulário filho.
        Dim ChildForm As New FormAtividades_Navio
        ' Torná-lo uma criança deste formulário MDI antes de mostrá-lo.
        ChildForm.MdiParent = Me

        'm_ChildFormNumber += 1
        'ChildForm.Text = "Janela " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub AtParagensToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AtParagensToolStripMenuItem1.Click
        ' Cria uma nova instância do formulário filho.
        Dim ChildForm As New FormAtividades_Paragens
        ' Torná-lo uma criança deste formulário MDI antes de mostrá-lo.
        ChildForm.MdiParent = Me

        'm_ChildFormNumber += 1
        'ChildForm.Text = "Janela " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub ListaViajantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaViajantesToolStripMenuItem.Click
        ' Cria uma nova instância do formulário filho.
        Dim ChildForm As New FormLista_Viajantes
        ' Torná-lo uma criança deste formulário MDI antes de mostrá-lo.
        ChildForm.MdiParent = Me

        'm_ChildFormNumber += 1
        'ChildForm.Text = "Janela " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub ListaFuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListaFuncionáriosToolStripMenuItem.Click
        ' Cria uma nova instância do formulário filho.
        Dim ChildForm As New FormLista_Funcionários
        ' Torná-lo uma criança deste formulário MDI antes de mostrá-lo.
        ChildForm.MdiParent = Me

        'm_ChildFormNumber += 1
        'ChildForm.Text = "Janela " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub QuartosViajantesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuartosViajantesToolStripMenuItem.Click
        ' Cria uma nova instância do formulário filho.
        Dim ChildForm As New FormListaQuartos
        ' Torná-lo uma criança deste formulário MDI antes de mostrá-lo.
        ChildForm.MdiParent = Me

        'm_ChildFormNumber += 1
        'ChildForm.Text = "Janela " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub QuartosFuncionáriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuartosFuncionáriosToolStripMenuItem.Click
        ' Cria uma nova instância do formulário filho.
        Dim ChildForm As New FormQuartos
        ' Torná-lo uma criança deste formulário MDI antes de mostrá-lo.
        ChildForm.MdiParent = Me

        'm_ChildFormNumber += 1
        'ChildForm.Text = "Janela " & m_ChildFormNumber

        ChildForm.Show()
    End Sub

    Private Sub ReservasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservasToolStripMenuItem.Click
        ' Cria uma nova instância do formulário filho.
        Dim ChildForm As New FormReservas
        ' Torná-lo uma criança deste formulário MDI antes de mostrá-lo.
        ChildForm.MdiParent = Me

        'm_ChildFormNumber += 1
        'ChildForm.Text = "Janela " & m_ChildFormNumber

        ChildForm.Show()
    End Sub
End Class
