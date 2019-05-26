<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.CruzeirosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuartosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuartosViajantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuartosFuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParagensToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ParagensToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtNavioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AtParagensToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaDePessoasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaViajantesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListaFuncionáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReservasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CruzeirosToolStripMenuItem, Me.QuartosToolStripMenuItem, Me.ParagensToolStripMenuItem1, Me.ParagensToolStripMenuItem, Me.ListaDePessoasToolStripMenuItem, Me.ReservasToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1028, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'CruzeirosToolStripMenuItem
        '
        Me.CruzeirosToolStripMenuItem.Name = "CruzeirosToolStripMenuItem"
        Me.CruzeirosToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.CruzeirosToolStripMenuItem.Text = "Cruzeiros"
        '
        'QuartosToolStripMenuItem
        '
        Me.QuartosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuartosViajantesToolStripMenuItem, Me.QuartosFuncionáriosToolStripMenuItem})
        Me.QuartosToolStripMenuItem.Name = "QuartosToolStripMenuItem"
        Me.QuartosToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.QuartosToolStripMenuItem.Text = "Quartos"
        '
        'QuartosViajantesToolStripMenuItem
        '
        Me.QuartosViajantesToolStripMenuItem.Name = "QuartosViajantesToolStripMenuItem"
        Me.QuartosViajantesToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.QuartosViajantesToolStripMenuItem.Text = "Viajantes"
        '
        'QuartosFuncionáriosToolStripMenuItem
        '
        Me.QuartosFuncionáriosToolStripMenuItem.Name = "QuartosFuncionáriosToolStripMenuItem"
        Me.QuartosFuncionáriosToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.QuartosFuncionáriosToolStripMenuItem.Text = "Funcionários"
        '
        'ParagensToolStripMenuItem1
        '
        Me.ParagensToolStripMenuItem1.Name = "ParagensToolStripMenuItem1"
        Me.ParagensToolStripMenuItem1.Size = New System.Drawing.Size(67, 20)
        Me.ParagensToolStripMenuItem1.Text = "Paragens"
        '
        'ParagensToolStripMenuItem
        '
        Me.ParagensToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AtNavioToolStripMenuItem, Me.AtParagensToolStripMenuItem1})
        Me.ParagensToolStripMenuItem.Name = "ParagensToolStripMenuItem"
        Me.ParagensToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.ParagensToolStripMenuItem.Text = "Atividades"
        '
        'AtNavioToolStripMenuItem
        '
        Me.AtNavioToolStripMenuItem.Name = "AtNavioToolStripMenuItem"
        Me.AtNavioToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.AtNavioToolStripMenuItem.Text = "Navio"
        '
        'AtParagensToolStripMenuItem1
        '
        Me.AtParagensToolStripMenuItem1.Name = "AtParagensToolStripMenuItem1"
        Me.AtParagensToolStripMenuItem1.Size = New System.Drawing.Size(180, 22)
        Me.AtParagensToolStripMenuItem1.Text = "Paragens"
        '
        'ListaDePessoasToolStripMenuItem
        '
        Me.ListaDePessoasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListaViajantesToolStripMenuItem, Me.ListaFuncionáriosToolStripMenuItem})
        Me.ListaDePessoasToolStripMenuItem.Name = "ListaDePessoasToolStripMenuItem"
        Me.ListaDePessoasToolStripMenuItem.Size = New System.Drawing.Size(103, 20)
        Me.ListaDePessoasToolStripMenuItem.Text = "Lista de Pessoas"
        '
        'ListaViajantesToolStripMenuItem
        '
        Me.ListaViajantesToolStripMenuItem.Name = "ListaViajantesToolStripMenuItem"
        Me.ListaViajantesToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ListaViajantesToolStripMenuItem.Text = "Viajantes"
        '
        'ListaFuncionáriosToolStripMenuItem
        '
        Me.ListaFuncionáriosToolStripMenuItem.Name = "ListaFuncionáriosToolStripMenuItem"
        Me.ListaFuncionáriosToolStripMenuItem.Size = New System.Drawing.Size(142, 22)
        Me.ListaFuncionáriosToolStripMenuItem.Text = "Funcionários"
        '
        'ReservasToolStripMenuItem
        '
        Me.ReservasToolStripMenuItem.Name = "ReservasToolStripMenuItem"
        Me.ReservasToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.ReservasToolStripMenuItem.Text = "Reservas"
        '
        'StatusStrip
        '
        Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 587)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1028, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(39, 17)
        Me.ToolStripStatusLabel.Text = "Status"
        '
        'FormPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 609)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "FormPrincipal"
        Me.Text = "Empresa de Cruzeiros"
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents CruzeirosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParagensToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AtNavioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AtParagensToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ListaDePessoasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaViajantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListaFuncionáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ParagensToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents QuartosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuartosViajantesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuartosFuncionáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReservasToolStripMenuItem As ToolStripMenuItem
End Class
