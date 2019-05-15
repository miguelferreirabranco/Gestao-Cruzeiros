<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Paragens
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
        Me.TextBox_local = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_horafim = New System.Windows.Forms.TextBox()
        Me.TextBox_horainicio = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_dia = New System.Windows.Forms.TextBox()
        Me.Button_Adicionar = New System.Windows.Forms.Button()
        Me.ListBox_Paragens = New System.Windows.Forms.ListBox()
        Me.Button_fim = New System.Windows.Forms.Button()
        Me.Button_seguinte = New System.Windows.Forms.Button()
        Me.Button_anterior = New System.Windows.Forms.Button()
        Me.Button_inicio = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox_local
        '
        Me.TextBox_local.Location = New System.Drawing.Point(185, 164)
        Me.TextBox_local.Name = "TextBox_local"
        Me.TextBox_local.Size = New System.Drawing.Size(140, 20)
        Me.TextBox_local.TabIndex = 100
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(117, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 20)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "Local:"
        '
        'TextBox_horafim
        '
        Me.TextBox_horafim.Location = New System.Drawing.Point(185, 242)
        Me.TextBox_horafim.Name = "TextBox_horafim"
        Me.TextBox_horafim.Size = New System.Drawing.Size(140, 20)
        Me.TextBox_horafim.TabIndex = 98
        '
        'TextBox_horainicio
        '
        Me.TextBox_horainicio.Location = New System.Drawing.Point(185, 216)
        Me.TextBox_horainicio.Name = "TextBox_horainicio"
        Me.TextBox_horainicio.Size = New System.Drawing.Size(140, 20)
        Me.TextBox_horainicio.TabIndex = 97
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(131, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 20)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Dia:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(57, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 20)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Hora de Início:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Hora de Fim:"
        '
        'TextBox_dia
        '
        Me.TextBox_dia.Location = New System.Drawing.Point(185, 190)
        Me.TextBox_dia.Name = "TextBox_dia"
        Me.TextBox_dia.Size = New System.Drawing.Size(140, 20)
        Me.TextBox_dia.TabIndex = 88
        '
        'Button_Adicionar
        '
        Me.Button_Adicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Adicionar.Location = New System.Drawing.Point(23, 331)
        Me.Button_Adicionar.Name = "Button_Adicionar"
        Me.Button_Adicionar.Size = New System.Drawing.Size(88, 39)
        Me.Button_Adicionar.TabIndex = 86
        Me.Button_Adicionar.Text = "Adicionar"
        Me.Button_Adicionar.UseVisualStyleBackColor = True
        '
        'ListBox_Paragens
        '
        Me.ListBox_Paragens.FormattingEnabled = True
        Me.ListBox_Paragens.Location = New System.Drawing.Point(434, 151)
        Me.ListBox_Paragens.Name = "ListBox_Paragens"
        Me.ListBox_Paragens.Size = New System.Drawing.Size(329, 303)
        Me.ListBox_Paragens.TabIndex = 85
        '
        'Button_fim
        '
        Me.Button_fim.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_fim.Location = New System.Drawing.Point(266, 82)
        Me.Button_fim.Name = "Button_fim"
        Me.Button_fim.Size = New System.Drawing.Size(75, 39)
        Me.Button_fim.TabIndex = 84
        Me.Button_fim.Text = ">>"
        Me.Button_fim.UseVisualStyleBackColor = True
        '
        'Button_seguinte
        '
        Me.Button_seguinte.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_seguinte.Location = New System.Drawing.Point(185, 82)
        Me.Button_seguinte.Name = "Button_seguinte"
        Me.Button_seguinte.Size = New System.Drawing.Size(75, 39)
        Me.Button_seguinte.TabIndex = 83
        Me.Button_seguinte.Text = ">"
        Me.Button_seguinte.UseVisualStyleBackColor = True
        '
        'Button_anterior
        '
        Me.Button_anterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_anterior.Location = New System.Drawing.Point(104, 82)
        Me.Button_anterior.Name = "Button_anterior"
        Me.Button_anterior.Size = New System.Drawing.Size(75, 39)
        Me.Button_anterior.TabIndex = 82
        Me.Button_anterior.Text = "<"
        Me.Button_anterior.UseVisualStyleBackColor = True
        '
        'Button_inicio
        '
        Me.Button_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_inicio.Location = New System.Drawing.Point(23, 82)
        Me.Button_inicio.Name = "Button_inicio"
        Me.Button_inicio.Size = New System.Drawing.Size(75, 39)
        Me.Button_inicio.TabIndex = 81
        Me.Button_inicio.Text = "<<"
        Me.Button_inicio.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(324, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 25)
        Me.Label1.TabIndex = 101
        Me.Label1.Text = "Paragens"
        '
        'Paragens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 466)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_local)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox_horafim)
        Me.Controls.Add(Me.TextBox_horainicio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_dia)
        Me.Controls.Add(Me.Button_Adicionar)
        Me.Controls.Add(Me.ListBox_Paragens)
        Me.Controls.Add(Me.Button_fim)
        Me.Controls.Add(Me.Button_seguinte)
        Me.Controls.Add(Me.Button_anterior)
        Me.Controls.Add(Me.Button_inicio)
        Me.Name = "Paragens"
        Me.Text = "Paragens"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_local As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_horafim As TextBox
    Friend WithEvents TextBox_horainicio As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_dia As TextBox
    Friend WithEvents Button_Adicionar As Button
    Friend WithEvents ListBox_Paragens As ListBox
    Friend WithEvents Button_fim As Button
    Friend WithEvents Button_seguinte As Button
    Friend WithEvents Button_anterior As Button
    Friend WithEvents Button_inicio As Button
    Friend WithEvents Label1 As Label
End Class
