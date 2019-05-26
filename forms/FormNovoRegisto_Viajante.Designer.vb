<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNovoRegisto_Viajante
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
        Me.TextBox_ncc = New System.Windows.Forms.TextBox()
        Me.TextBox_username = New System.Windows.Forms.TextBox()
        Me.TextBox_nif = New System.Windows.Forms.TextBox()
        Me.TextBox_password = New System.Windows.Forms.TextBox()
        Me.TextBox_nome = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button_Registar = New System.Windows.Forms.Button()
        Me.DateTimePicker_datanasc = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxSexo = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'TextBox_ncc
        '
        Me.TextBox_ncc.Location = New System.Drawing.Point(233, 139)
        Me.TextBox_ncc.Name = "TextBox_ncc"
        Me.TextBox_ncc.Size = New System.Drawing.Size(185, 20)
        Me.TextBox_ncc.TabIndex = 79
        '
        'TextBox_username
        '
        Me.TextBox_username.Location = New System.Drawing.Point(233, 190)
        Me.TextBox_username.Name = "TextBox_username"
        Me.TextBox_username.Size = New System.Drawing.Size(185, 20)
        Me.TextBox_username.TabIndex = 78
        '
        'TextBox_nif
        '
        Me.TextBox_nif.Location = New System.Drawing.Point(233, 165)
        Me.TextBox_nif.Name = "TextBox_nif"
        Me.TextBox_nif.Size = New System.Drawing.Size(185, 20)
        Me.TextBox_nif.TabIndex = 77
        '
        'TextBox_password
        '
        Me.TextBox_password.Location = New System.Drawing.Point(233, 216)
        Me.TextBox_password.Name = "TextBox_password"
        Me.TextBox_password.Size = New System.Drawing.Size(185, 20)
        Me.TextBox_password.TabIndex = 76
        '
        'TextBox_nome
        '
        Me.TextBox_nome.Location = New System.Drawing.Point(233, 61)
        Me.TextBox_nome.Name = "TextBox_nome"
        Me.TextBox_nome.Size = New System.Drawing.Size(185, 20)
        Me.TextBox_nome.TabIndex = 75
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(158, 61)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 20)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "Nome:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(164, 87)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 20)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Sexo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 20)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Data de Nascimento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(174, 165)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 20)
        Me.Label5.TabIndex = 71
        Me.Label5.Text = "NIF:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(131, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Password:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 190)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 20)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Nome de Utilizador:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(64, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 20)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "N.º Cartão Cidadão:"
        '
        'Button_Registar
        '
        Me.Button_Registar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Registar.Location = New System.Drawing.Point(330, 267)
        Me.Button_Registar.Name = "Button_Registar"
        Me.Button_Registar.Size = New System.Drawing.Size(88, 39)
        Me.Button_Registar.TabIndex = 88
        Me.Button_Registar.Text = "Registar"
        Me.Button_Registar.UseVisualStyleBackColor = True
        '
        'DateTimePicker_datanasc
        '
        Me.DateTimePicker_datanasc.Location = New System.Drawing.Point(233, 112)
        Me.DateTimePicker_datanasc.Name = "DateTimePicker_datanasc"
        Me.DateTimePicker_datanasc.Size = New System.Drawing.Size(185, 20)
        Me.DateTimePicker_datanasc.TabIndex = 89
        '
        'ComboBoxSexo
        '
        Me.ComboBoxSexo.FormattingEnabled = True
        Me.ComboBoxSexo.Items.AddRange(New Object() {"Feminino", "Masculino", "Outro"})
        Me.ComboBoxSexo.Location = New System.Drawing.Point(233, 87)
        Me.ComboBoxSexo.Name = "ComboBoxSexo"
        Me.ComboBoxSexo.Size = New System.Drawing.Size(185, 21)
        Me.ComboBoxSexo.TabIndex = 90
        '
        'FormNovoRegisto_Viajante
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 345)
        Me.Controls.Add(Me.ComboBoxSexo)
        Me.Controls.Add(Me.DateTimePicker_datanasc)
        Me.Controls.Add(Me.Button_Registar)
        Me.Controls.Add(Me.TextBox_ncc)
        Me.Controls.Add(Me.TextBox_username)
        Me.Controls.Add(Me.TextBox_nif)
        Me.Controls.Add(Me.TextBox_password)
        Me.Controls.Add(Me.TextBox_nome)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "FormNovoRegisto_Viajante"
        Me.Text = "Novo Registo Viajante"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox_ncc As TextBox
    Friend WithEvents TextBox_username As TextBox
    Friend WithEvents TextBox_nif As TextBox
    Friend WithEvents TextBox_password As TextBox
    Friend WithEvents TextBox_nome As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button_Registar As Button
    Friend WithEvents DateTimePicker_datanasc As DateTimePicker
    Friend WithEvents ComboBoxSexo As ComboBox
End Class
