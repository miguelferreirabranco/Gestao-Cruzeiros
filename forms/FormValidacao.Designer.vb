<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormValidacao
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxCodigo = New System.Windows.Forms.TextBox()
        Me.ButtonValidar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(106, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 20)
        Me.Label6.TabIndex = 100
        Me.Label6.Text = "Código:"
        '
        'TextBoxCodigo
        '
        Me.TextBoxCodigo.Location = New System.Drawing.Point(85, 67)
        Me.TextBoxCodigo.Name = "TextBoxCodigo"
        Me.TextBoxCodigo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxCodigo.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCodigo.TabIndex = 101
        '
        'ButtonValidar
        '
        Me.ButtonValidar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonValidar.Location = New System.Drawing.Point(89, 123)
        Me.ButtonValidar.Name = "ButtonValidar"
        Me.ButtonValidar.Size = New System.Drawing.Size(88, 39)
        Me.ButtonValidar.TabIndex = 108
        Me.ButtonValidar.Text = "Validar"
        Me.ButtonValidar.UseVisualStyleBackColor = True
        '
        'FormValidacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.ButtonValidar)
        Me.Controls.Add(Me.TextBoxCodigo)
        Me.Controls.Add(Me.Label6)
        Me.Name = "FormValidacao"
        Me.Text = "Validação"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxCodigo As TextBox
    Friend WithEvents ButtonValidar As Button
End Class
