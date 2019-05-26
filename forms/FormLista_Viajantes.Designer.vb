<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLista_Viajantes
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeaderLogin = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderNome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderCC = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderNIF = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(236, 11)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(261, 31)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Lista dos Viajantes"
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderLogin, Me.ColumnHeaderNome, Me.ColumnHeaderCC, Me.ColumnHeaderNIF})
        Me.ListView1.Location = New System.Drawing.Point(61, 76)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(639, 370)
        Me.ListView1.TabIndex = 117
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
        'ColumnHeaderNIF
        '
        Me.ColumnHeaderNIF.Text = "NIF"
        Me.ColumnHeaderNIF.Width = 102
        '
        'FormLista_Viajantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 479)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.Label6)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormLista_Viajantes"
        Me.Text = "Lista dos Viajantes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As Label
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeaderLogin As ColumnHeader
    Friend WithEvents ColumnHeaderNome As ColumnHeader
    Friend WithEvents ColumnHeaderCC As ColumnHeader
    Friend WithEvents ColumnHeaderNIF As ColumnHeader
End Class
