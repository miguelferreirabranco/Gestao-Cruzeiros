<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAtividades_Navio
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
        Me.Button_anular = New System.Windows.Forms.Button()
        Me.TextBox_seccao = New System.Windows.Forms.TextBox()
        Me.Button_Marcar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_tipo = New System.Windows.Forms.TextBox()
        Me.TextBox_nome = New System.Windows.Forms.TextBox()
        Me.Button_Adicionar = New System.Windows.Forms.Button()
        Me.ListBox_Atividades_Navio = New System.Windows.Forms.ListBox()
        Me.Button_fim = New System.Windows.Forms.Button()
        Me.Button_seguinte = New System.Windows.Forms.Button()
        Me.Button_anterior = New System.Windows.Forms.Button()
        Me.Button_inicio = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePickerData = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
<<<<<<< HEAD
        Me.HoraFim = New System.Windows.Forms.NumericUpDown()
        Me.HoraInicio = New System.Windows.Forms.NumericUpDown()
        Me.MinutoFim = New System.Windows.Forms.NumericUpDown()
        Me.MinutoInicio = New System.Windows.Forms.NumericUpDown()
        CType(Me.HoraFim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoraInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinutoFim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinutoInicio, System.ComponentModel.ISupportInitialize).BeginInit()
=======
        Me.ButtonNova = New System.Windows.Forms.Button()
>>>>>>> 4c4b9c9148dffb25bf4ee37c46c885a476e0f38a
        Me.SuspendLayout()
        '
        'Button_anular
        '
        Me.Button_anular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_anular.Location = New System.Drawing.Point(132, 375)
        Me.Button_anular.Name = "Button_anular"
        Me.Button_anular.Size = New System.Drawing.Size(88, 39)
        Me.Button_anular.TabIndex = 56
        Me.Button_anular.Text = "Anular"
        Me.Button_anular.UseVisualStyleBackColor = True
        '
        'TextBox_seccao
        '
        Me.TextBox_seccao.Location = New System.Drawing.Point(200, 293)
        Me.TextBox_seccao.Name = "TextBox_seccao"
        Me.TextBox_seccao.Size = New System.Drawing.Size(140, 20)
        Me.TextBox_seccao.TabIndex = 55
        '
        'Button_Marcar
        '
        Me.Button_Marcar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Marcar.Location = New System.Drawing.Point(38, 375)
        Me.Button_Marcar.Name = "Button_Marcar"
        Me.Button_Marcar.Size = New System.Drawing.Size(88, 39)
        Me.Button_Marcar.TabIndex = 54
        Me.Button_Marcar.Text = "Marcar"
        Me.Button_Marcar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(141, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 20)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Tipo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(73, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 20)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Hora de Início:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(83, 264)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Hora de Fim:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(128, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Nome:"
        '
        'TextBox_tipo
        '
        Me.TextBox_tipo.Location = New System.Drawing.Point(200, 180)
        Me.TextBox_tipo.Name = "TextBox_tipo"
        Me.TextBox_tipo.Size = New System.Drawing.Size(140, 20)
        Me.TextBox_tipo.TabIndex = 48
        '
        'TextBox_nome
        '
        Me.TextBox_nome.Location = New System.Drawing.Point(200, 154)
        Me.TextBox_nome.Name = "TextBox_nome"
        Me.TextBox_nome.Size = New System.Drawing.Size(140, 20)
        Me.TextBox_nome.TabIndex = 47
        '
        'Button_Adicionar
        '
        Me.Button_Adicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Adicionar.Location = New System.Drawing.Point(132, 330)
        Me.Button_Adicionar.Name = "Button_Adicionar"
        Me.Button_Adicionar.Size = New System.Drawing.Size(88, 39)
        Me.Button_Adicionar.TabIndex = 46
        Me.Button_Adicionar.Text = "Adicionar"
        Me.Button_Adicionar.UseVisualStyleBackColor = True
        '
        'ListBox_Atividades_Navio
        '
        Me.ListBox_Atividades_Navio.FormattingEnabled = True
        Me.ListBox_Atividades_Navio.Location = New System.Drawing.Point(449, 141)
        Me.ListBox_Atividades_Navio.Name = "ListBox_Atividades_Navio"
        Me.ListBox_Atividades_Navio.Size = New System.Drawing.Size(329, 303)
        Me.ListBox_Atividades_Navio.TabIndex = 45
        '
        'Button_fim
        '
        Me.Button_fim.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_fim.Location = New System.Drawing.Point(281, 72)
        Me.Button_fim.Name = "Button_fim"
        Me.Button_fim.Size = New System.Drawing.Size(75, 39)
        Me.Button_fim.TabIndex = 44
        Me.Button_fim.Text = ">>"
        Me.Button_fim.UseVisualStyleBackColor = True
        '
        'Button_seguinte
        '
        Me.Button_seguinte.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_seguinte.Location = New System.Drawing.Point(200, 72)
        Me.Button_seguinte.Name = "Button_seguinte"
        Me.Button_seguinte.Size = New System.Drawing.Size(75, 39)
        Me.Button_seguinte.TabIndex = 43
        Me.Button_seguinte.Text = ">"
        Me.Button_seguinte.UseVisualStyleBackColor = True
        '
        'Button_anterior
        '
        Me.Button_anterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_anterior.Location = New System.Drawing.Point(119, 72)
        Me.Button_anterior.Name = "Button_anterior"
        Me.Button_anterior.Size = New System.Drawing.Size(75, 39)
        Me.Button_anterior.TabIndex = 42
        Me.Button_anterior.Text = "<"
        Me.Button_anterior.UseVisualStyleBackColor = True
        '
        'Button_inicio
        '
        Me.Button_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_inicio.Location = New System.Drawing.Point(38, 72)
        Me.Button_inicio.Name = "Button_inicio"
        Me.Button_inicio.Size = New System.Drawing.Size(75, 39)
        Me.Button_inicio.TabIndex = 41
        Me.Button_inicio.Text = "<<"
        Me.Button_inicio.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 20)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Secção do Navio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(285, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(222, 25)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Atividades no Navio"
        '
        'DateTimePickerData
        '
        Me.DateTimePickerData.Location = New System.Drawing.Point(200, 207)
        Me.DateTimePickerData.Name = "DateTimePickerData"
        Me.DateTimePickerData.Size = New System.Drawing.Size(140, 20)
        Me.DateTimePickerData.TabIndex = 62
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(135, 208)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(48, 20)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Data:"
        '
<<<<<<< HEAD
        'HoraFim
        '
        Me.HoraFim.Location = New System.Drawing.Point(200, 267)
        Me.HoraFim.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.HoraFim.Name = "HoraFim"
        Me.HoraFim.Size = New System.Drawing.Size(35, 20)
        Me.HoraFim.TabIndex = 110
        '
        'HoraInicio
        '
        Me.HoraInicio.Location = New System.Drawing.Point(200, 238)
        Me.HoraInicio.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.HoraInicio.Name = "HoraInicio"
        Me.HoraInicio.Size = New System.Drawing.Size(35, 20)
        Me.HoraInicio.TabIndex = 109
        '
        'MinutoFim
        '
        Me.MinutoFim.Location = New System.Drawing.Point(241, 267)
        Me.MinutoFim.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.MinutoFim.Name = "MinutoFim"
        Me.MinutoFim.Size = New System.Drawing.Size(35, 20)
        Me.MinutoFim.TabIndex = 108
        '
        'MinutoInicio
        '
        Me.MinutoInicio.Location = New System.Drawing.Point(241, 238)
        Me.MinutoInicio.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.MinutoInicio.Name = "MinutoInicio"
        Me.MinutoInicio.Size = New System.Drawing.Size(35, 20)
        Me.MinutoInicio.TabIndex = 107
=======
        'ButtonNova
        '
        Me.ButtonNova.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNova.Location = New System.Drawing.Point(38, 330)
        Me.ButtonNova.Name = "ButtonNova"
        Me.ButtonNova.Size = New System.Drawing.Size(88, 39)
        Me.ButtonNova.TabIndex = 64
        Me.ButtonNova.Text = "Nova"
        Me.ButtonNova.UseVisualStyleBackColor = True
>>>>>>> 4c4b9c9148dffb25bf4ee37c46c885a476e0f38a
        '
        'FormAtividades_Navio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 456)
<<<<<<< HEAD
        Me.Controls.Add(Me.HoraFim)
        Me.Controls.Add(Me.HoraInicio)
        Me.Controls.Add(Me.MinutoFim)
        Me.Controls.Add(Me.MinutoInicio)
=======
        Me.Controls.Add(Me.ButtonNova)
>>>>>>> 4c4b9c9148dffb25bf4ee37c46c885a476e0f38a
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePickerData)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button_anular)
        Me.Controls.Add(Me.TextBox_seccao)
        Me.Controls.Add(Me.Button_Marcar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_tipo)
        Me.Controls.Add(Me.TextBox_nome)
        Me.Controls.Add(Me.Button_Adicionar)
        Me.Controls.Add(Me.ListBox_Atividades_Navio)
        Me.Controls.Add(Me.Button_fim)
        Me.Controls.Add(Me.Button_seguinte)
        Me.Controls.Add(Me.Button_anterior)
        Me.Controls.Add(Me.Button_inicio)
        Me.Name = "FormAtividades_Navio"
        Me.Text = "Atividades_Navio"
        CType(Me.HoraFim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoraInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinutoFim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinutoInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button_anular As Button
    Friend WithEvents TextBox_seccao As TextBox
    Friend WithEvents Button_Marcar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_tipo As TextBox
    Friend WithEvents TextBox_nome As TextBox
    Friend WithEvents Button_Adicionar As Button
    Friend WithEvents ListBox_Atividades_Navio As ListBox
    Friend WithEvents Button_fim As Button
    Friend WithEvents Button_seguinte As Button
    Friend WithEvents Button_anterior As Button
    Friend WithEvents Button_inicio As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePickerData As DateTimePicker
    Friend WithEvents Label7 As Label
<<<<<<< HEAD
    Friend WithEvents HoraFim As NumericUpDown
    Friend WithEvents HoraInicio As NumericUpDown
    Friend WithEvents MinutoFim As NumericUpDown
    Friend WithEvents MinutoInicio As NumericUpDown
=======
    Friend WithEvents ButtonNova As Button
>>>>>>> 4c4b9c9148dffb25bf4ee37c46c885a476e0f38a
End Class
