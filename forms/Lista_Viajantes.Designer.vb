<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Lista_Viajantes
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
        Me.ListBox_viajantes = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ListBox_viajantes
        '
        Me.ListBox_viajantes.FormattingEnabled = True
        Me.ListBox_viajantes.Location = New System.Drawing.Point(67, 85)
        Me.ListBox_viajantes.Name = "ListBox_viajantes"
        Me.ListBox_viajantes.Size = New System.Drawing.Size(461, 251)
        Me.ListBox_viajantes.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(177, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(213, 25)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Lista dos Viajantes"
        '
        'Lista_Viajantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(590, 389)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ListBox_viajantes)
        Me.Name = "Lista_Viajantes"
        Me.Text = "Lista_Viajantes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ListBox_viajantes As ListBox
    Friend WithEvents Label6 As Label
End Class
