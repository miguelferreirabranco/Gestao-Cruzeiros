<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLista_Funcionários
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeaderLogin = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderNome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderCC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderNIB = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(184, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(251, 25)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Lista dos Funcionários"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderLogin, Me.ColumnHeaderNome, Me.ColumnHeaderCC, Me.ColumnHeaderNIB})
        Me.ListView1.Location = New System.Drawing.Point(84, 59)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(480, 301)
        Me.ListView1.TabIndex = 116
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderLogin
        '
        Me.ColumnHeaderLogin.Text = "Login"
        Me.ColumnHeaderLogin.Width = 104
        '
        'ColumnHeaderNome
        '
        Me.ColumnHeaderNome.Text = "Nome"
        Me.ColumnHeaderNome.Width = 137
        '
        'ColumnHeaderCC
        '
        Me.ColumnHeaderCC.Text = "CC"
        Me.ColumnHeaderCC.Width = 131
        '
        'ColumnHeaderNIB
        '
        Me.ColumnHeaderNIB.Text = "NIB"
        Me.ColumnHeaderNIB.Width = 102
        '
        'FormLista_Funcionários
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 387)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label6)
        Me.Name = "FormLista_Funcionários"
        Me.Text = "Lista_Funcionários"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeaderLogin As ColumnHeader
    Friend WithEvents ColumnHeaderNome As ColumnHeader
    Friend WithEvents ColumnHeaderCC As ColumnHeader
    Friend WithEvents ColumnHeaderNIB As ColumnHeader
End Class
