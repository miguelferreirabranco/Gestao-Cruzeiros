<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lista_Funcionários
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
        Me.ListBox_funcionarios = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox_funcionarios
        '
        Me.ListBox_funcionarios.FormattingEnabled = True
        Me.ListBox_funcionarios.Location = New System.Drawing.Point(55, 75)
        Me.ListBox_funcionarios.Name = "ListBox_funcionarios"
        Me.ListBox_funcionarios.Size = New System.Drawing.Size(513, 251)
        Me.ListBox_funcionarios.TabIndex = 0
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
        'Lista_Funcionários
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(636, 387)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListBox_funcionarios)
        Me.Name = "Lista_Funcionários"
        Me.Text = "Lista_Funcionários"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox_funcionarios As ListBox
    Friend WithEvents Label6 As Label
End Class
