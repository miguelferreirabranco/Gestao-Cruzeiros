<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Novo_Registo_Funcionário
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox_nome = New System.Windows.Forms.TextBox()
        Me.TextBox_password = New System.Windows.Forms.TextBox()
        Me.TextBox_nib = New System.Windows.Forms.TextBox()
        Me.TextBox_username = New System.Windows.Forms.TextBox()
        Me.TextBox_ncc = New System.Windows.Forms.TextBox()
        Me.TextBox_datanasc = New System.Windows.Forms.TextBox()
        Me.TextBox_sexo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(36, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 20)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "N.º Cartão Cidadão:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 179)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(147, 20)
        Me.Label3.TabIndex = 55
        Me.Label3.Text = "Nome de Utilizador:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(103, 205)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 20)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Password:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(145, 154)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 20)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "NIB:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 20)
        Me.Label6.TabIndex = 58
        Me.Label6.Text = "Data de Nascimento:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(136, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 20)
        Me.Label7.TabIndex = 59
        Me.Label7.Text = "Sexo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(130, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 20)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Nome:"
        '
        'TextBox_nome
        '
        Me.TextBox_nome.Location = New System.Drawing.Point(205, 50)
        Me.TextBox_nome.Name = "TextBox_nome"
        Me.TextBox_nome.Size = New System.Drawing.Size(185, 20)
        Me.TextBox_nome.TabIndex = 61
        '
        'TextBox_password
        '
        Me.TextBox_password.Location = New System.Drawing.Point(205, 205)
        Me.TextBox_password.Name = "TextBox_password"
        Me.TextBox_password.Size = New System.Drawing.Size(185, 20)
        Me.TextBox_password.TabIndex = 62
        '
        'TextBox_nib
        '
        Me.TextBox_nib.Location = New System.Drawing.Point(205, 154)
        Me.TextBox_nib.Name = "TextBox_nib"
        Me.TextBox_nib.Size = New System.Drawing.Size(185, 20)
        Me.TextBox_nib.TabIndex = 63
        '
        'TextBox_username
        '
        Me.TextBox_username.Location = New System.Drawing.Point(205, 179)
        Me.TextBox_username.Name = "TextBox_username"
        Me.TextBox_username.Size = New System.Drawing.Size(185, 20)
        Me.TextBox_username.TabIndex = 64
        '
        'TextBox_ncc
        '
        Me.TextBox_ncc.Location = New System.Drawing.Point(205, 128)
        Me.TextBox_ncc.Name = "TextBox_ncc"
        Me.TextBox_ncc.Size = New System.Drawing.Size(185, 20)
        Me.TextBox_ncc.TabIndex = 65
        '
        'TextBox_datanasc
        '
        Me.TextBox_datanasc.Location = New System.Drawing.Point(205, 102)
        Me.TextBox_datanasc.Name = "TextBox_datanasc"
        Me.TextBox_datanasc.Size = New System.Drawing.Size(185, 20)
        Me.TextBox_datanasc.TabIndex = 66
        '
        'TextBox_sexo
        '
        Me.TextBox_sexo.Location = New System.Drawing.Point(205, 76)
        Me.TextBox_sexo.Name = "TextBox_sexo"
        Me.TextBox_sexo.Size = New System.Drawing.Size(185, 20)
        Me.TextBox_sexo.TabIndex = 67
        '
        'Novo_Registo_Funcionário
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(524, 290)
        Me.Controls.Add(Me.TextBox_sexo)
        Me.Controls.Add(Me.TextBox_datanasc)
        Me.Controls.Add(Me.TextBox_ncc)
        Me.Controls.Add(Me.TextBox_username)
        Me.Controls.Add(Me.TextBox_nib)
        Me.Controls.Add(Me.TextBox_password)
        Me.Controls.Add(Me.TextBox_nome)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Novo_Registo_Funcionário"
        Me.Text = "Novo_Registo_Funcionário"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox_nome As TextBox
    Friend WithEvents TextBox_password As TextBox
    Friend WithEvents TextBox_nib As TextBox
    Friend WithEvents TextBox_username As TextBox
    Friend WithEvents TextBox_ncc As TextBox
    Friend WithEvents TextBox_datanasc As TextBox
    Friend WithEvents TextBox_sexo As TextBox
End Class
