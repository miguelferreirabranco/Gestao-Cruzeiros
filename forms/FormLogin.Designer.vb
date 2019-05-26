<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_username = New System.Windows.Forms.TextBox()
        Me.TextBox_password = New System.Windows.Forms.TextBox()
        Me.Button_Adicionar = New System.Windows.Forms.Button()
        Me.Button_entrar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.RadioButtonFuncionario = New System.Windows.Forms.RadioButton()
        Me.RadioButtonViajante = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Password:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(21, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 20)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Nome de Utilizador:"
        '
        'TextBox_username
        '
        Me.TextBox_username.Location = New System.Drawing.Point(174, 22)
        Me.TextBox_username.Name = "TextBox_username"
        Me.TextBox_username.Size = New System.Drawing.Size(171, 20)
        Me.TextBox_username.TabIndex = 53
        '
        'TextBox_password
        '
        Me.TextBox_password.Location = New System.Drawing.Point(174, 64)
        Me.TextBox_password.Name = "TextBox_password"
        Me.TextBox_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_password.Size = New System.Drawing.Size(171, 20)
        Me.TextBox_password.TabIndex = 54
        '
        'Button_Adicionar
        '
        Me.Button_Adicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Adicionar.Location = New System.Drawing.Point(60, 154)
        Me.Button_Adicionar.Name = "Button_Adicionar"
        Me.Button_Adicionar.Size = New System.Drawing.Size(88, 46)
        Me.Button_Adicionar.TabIndex = 55
        Me.Button_Adicionar.Text = "Novo Registo"
        Me.Button_Adicionar.UseVisualStyleBackColor = True
        '
        'Button_entrar
        '
        Me.Button_entrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_entrar.Location = New System.Drawing.Point(257, 116)
        Me.Button_entrar.Name = "Button_entrar"
        Me.Button_entrar.Size = New System.Drawing.Size(88, 39)
        Me.Button_entrar.TabIndex = 56
        Me.Button_entrar.Text = "Entrar"
        Me.Button_entrar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(190, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Ainda não tem conta? Registe-se aqui!"
        '
        'RadioButtonFuncionario
        '
        Me.RadioButtonFuncionario.AutoSize = True
        Me.RadioButtonFuncionario.Location = New System.Drawing.Point(25, 206)
        Me.RadioButtonFuncionario.Margin = New System.Windows.Forms.Padding(2)
        Me.RadioButtonFuncionario.Name = "RadioButtonFuncionario"
        Me.RadioButtonFuncionario.Size = New System.Drawing.Size(80, 17)
        Me.RadioButtonFuncionario.TabIndex = 59
        Me.RadioButtonFuncionario.TabStop = True
        Me.RadioButtonFuncionario.Text = "Funcionario"
        Me.RadioButtonFuncionario.UseVisualStyleBackColor = True
        '
        'RadioButtonViajante
        '
        Me.RadioButtonViajante.AutoSize = True
        Me.RadioButtonViajante.BackgroundImage = CType(resources.GetObject("RadioButtonViajante.BackgroundImage"), System.Drawing.Image)
        Me.RadioButtonViajante.Location = New System.Drawing.Point(110, 206)
        Me.RadioButtonViajante.Name = "RadioButtonViajante"
        Me.RadioButtonViajante.Size = New System.Drawing.Size(63, 17)
        Me.RadioButtonViajante.TabIndex = 60
        Me.RadioButtonViajante.TabStop = True
        Me.RadioButtonViajante.Text = "Viajante"
        Me.RadioButtonViajante.UseVisualStyleBackColor = True
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 234)
        Me.Controls.Add(Me.RadioButtonViajante)
        Me.Controls.Add(Me.RadioButtonFuncionario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button_entrar)
        Me.Controls.Add(Me.Button_Adicionar)
        Me.Controls.Add(Me.TextBox_password)
        Me.Controls.Add(Me.TextBox_username)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FormLogin"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_username As TextBox
    Friend WithEvents TextBox_password As TextBox
    Friend WithEvents Button_Adicionar As Button
    Friend WithEvents Button_entrar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents RadioButtonFuncionario As RadioButton
    Friend WithEvents RadioButtonViajante As RadioButton
End Class
