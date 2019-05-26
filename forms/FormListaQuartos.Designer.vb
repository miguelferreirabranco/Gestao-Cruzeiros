<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormListaQuartos
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox_preco = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_npessoas = New System.Windows.Forms.TextBox()
        Me.TextBox_numero = New System.Windows.Forms.TextBox()
        Me.Button_anular = New System.Windows.Forms.Button()
        Me.Button_Reservar = New System.Windows.Forms.Button()
        Me.ComboBoxSeccao = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxEstado = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Location = New System.Drawing.Point(393, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(409, 384)
        Me.DataGridView1.TabIndex = 0
        '
        'TextBox_preco
        '
        Me.TextBox_preco.Location = New System.Drawing.Point(194, 208)
        Me.TextBox_preco.Name = "TextBox_preco"
        Me.TextBox_preco.Size = New System.Drawing.Size(140, 20)
        Me.TextBox_preco.TabIndex = 46
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(111, 156)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Secção:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 20)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Número de Pessoas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(41, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 20)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "Preço por pessoa:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "Número:"
        '
        'TextBox_npessoas
        '
        Me.TextBox_npessoas.Location = New System.Drawing.Point(194, 182)
        Me.TextBox_npessoas.Name = "TextBox_npessoas"
        Me.TextBox_npessoas.Size = New System.Drawing.Size(140, 20)
        Me.TextBox_npessoas.TabIndex = 41
        '
        'TextBox_numero
        '
        Me.TextBox_numero.Location = New System.Drawing.Point(194, 130)
        Me.TextBox_numero.Name = "TextBox_numero"
        Me.TextBox_numero.Size = New System.Drawing.Size(140, 20)
        Me.TextBox_numero.TabIndex = 39
        '
        'Button_anular
        '
        Me.Button_anular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_anular.Location = New System.Drawing.Point(152, 319)
        Me.Button_anular.Name = "Button_anular"
        Me.Button_anular.Size = New System.Drawing.Size(88, 39)
        Me.Button_anular.TabIndex = 48
        Me.Button_anular.Text = "Anular"
        Me.Button_anular.UseVisualStyleBackColor = True
        '
        'Button_Reservar
        '
        Me.Button_Reservar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Reservar.Location = New System.Drawing.Point(58, 319)
        Me.Button_Reservar.Name = "Button_Reservar"
        Me.Button_Reservar.Size = New System.Drawing.Size(88, 39)
        Me.Button_Reservar.TabIndex = 47
        Me.Button_Reservar.Text = "Reservar"
        Me.Button_Reservar.UseVisualStyleBackColor = True
        '
        'ComboBoxSeccao
        '
        Me.ComboBoxSeccao.FormattingEnabled = True
        Me.ComboBoxSeccao.Items.AddRange(New Object() {"Convés Superior", "Convés Inferior", "Sala de eventos", "Piscina"})
        Me.ComboBoxSeccao.Location = New System.Drawing.Point(194, 155)
        Me.ComboBoxSeccao.Name = "ComboBoxSeccao"
        Me.ComboBoxSeccao.Size = New System.Drawing.Size(140, 21)
        Me.ComboBoxSeccao.TabIndex = 67
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(114, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 20)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Estado:"
        '
        'TextBoxEstado
        '
        Me.TextBoxEstado.Location = New System.Drawing.Point(194, 255)
        Me.TextBoxEstado.Name = "TextBoxEstado"
        Me.TextBoxEstado.Size = New System.Drawing.Size(140, 20)
        Me.TextBoxEstado.TabIndex = 69
        '
        'FormListaQuartos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 409)
        Me.Controls.Add(Me.TextBoxEstado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBoxSeccao)
        Me.Controls.Add(Me.Button_anular)
        Me.Controls.Add(Me.Button_Reservar)
        Me.Controls.Add(Me.TextBox_preco)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_npessoas)
        Me.Controls.Add(Me.TextBox_numero)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FormListaQuartos"
        Me.Text = "Lista dos Quartos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox_preco As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_npessoas As TextBox
    Friend WithEvents TextBox_numero As TextBox
    Friend WithEvents Button_anular As Button
    Friend WithEvents Button_Reservar As Button
    Friend WithEvents ComboBoxSeccao As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxEstado As TextBox
End Class
