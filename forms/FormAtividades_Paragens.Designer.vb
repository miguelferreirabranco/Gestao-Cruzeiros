<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAtividades_Paragens
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button_anular = New System.Windows.Forms.Button()
        Me.Button_Marcar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_nome = New System.Windows.Forms.TextBox()
        Me.Button_Adicionar = New System.Windows.Forms.Button()
        Me.Button_fim = New System.Windows.Forms.Button()
        Me.Button_seguinte = New System.Windows.Forms.Button()
        Me.Button_anterior = New System.Windows.Forms.Button()
        Me.Button_inicio = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox_local = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateTimePickerData = New System.Windows.Forms.DateTimePicker()
        Me.ComboBoxParagem = New System.Windows.Forms.ComboBox()
        Me.HoraFim = New System.Windows.Forms.NumericUpDown()
        Me.HoraInicio = New System.Windows.Forms.NumericUpDown()
        Me.MinutoFim = New System.Windows.Forms.NumericUpDown()
        Me.MinutoInicio = New System.Windows.Forms.NumericUpDown()
        Me.ButtonNova1 = New System.Windows.Forms.Button()
        Me.ComboBoxTipo1 = New System.Windows.Forms.ComboBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeaderNome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderTipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderData = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderHoras = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderParagem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderLocal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.HoraFim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoraInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinutoFim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinutoInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(57, 342)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 25)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "Paragem:"
        '
        'Button_anular
        '
        Me.Button_anular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_anular.Location = New System.Drawing.Point(172, 473)
        Me.Button_anular.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_anular.Name = "Button_anular"
        Me.Button_anular.Size = New System.Drawing.Size(117, 48)
        Me.Button_anular.TabIndex = 75
        Me.Button_anular.Text = "Anular"
        Me.Button_anular.UseVisualStyleBackColor = True
        '
        'Button_Marcar
        '
        Me.Button_Marcar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Marcar.Location = New System.Drawing.Point(47, 473)
        Me.Button_Marcar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_Marcar.Name = "Button_Marcar"
        Me.Button_Marcar.Size = New System.Drawing.Size(117, 48)
        Me.Button_Marcar.TabIndex = 73
        Me.Button_Marcar.Text = "Marcar"
        Me.Button_Marcar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(103, 206)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 25)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Tipo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 271)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 25)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Hora de Início:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(25, 305)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 25)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Hora de Fim:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 174)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 25)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "Nome:"
        '
        'TextBox_nome
        '
        Me.TextBox_nome.Location = New System.Drawing.Point(181, 174)
        Me.TextBox_nome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox_nome.Name = "TextBox_nome"
        Me.TextBox_nome.Size = New System.Drawing.Size(185, 22)
        Me.TextBox_nome.TabIndex = 67
        '
        'Button_Adicionar
        '
        Me.Button_Adicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Adicionar.Location = New System.Drawing.Point(172, 417)
        Me.Button_Adicionar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_Adicionar.Name = "Button_Adicionar"
        Me.Button_Adicionar.Size = New System.Drawing.Size(117, 48)
        Me.Button_Adicionar.TabIndex = 66
        Me.Button_Adicionar.Text = "Adicionar"
        Me.Button_Adicionar.UseVisualStyleBackColor = True
        '
        'Button_fim
        '
        Me.Button_fim.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_fim.Location = New System.Drawing.Point(371, 89)
        Me.Button_fim.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_fim.Name = "Button_fim"
        Me.Button_fim.Size = New System.Drawing.Size(100, 48)
        Me.Button_fim.TabIndex = 64
        Me.Button_fim.Text = ">>"
        Me.Button_fim.UseVisualStyleBackColor = True
        '
        'Button_seguinte
        '
        Me.Button_seguinte.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_seguinte.Location = New System.Drawing.Point(263, 89)
        Me.Button_seguinte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_seguinte.Name = "Button_seguinte"
        Me.Button_seguinte.Size = New System.Drawing.Size(100, 48)
        Me.Button_seguinte.TabIndex = 63
        Me.Button_seguinte.Text = ">"
        Me.Button_seguinte.UseVisualStyleBackColor = True
        '
        'Button_anterior
        '
        Me.Button_anterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_anterior.Location = New System.Drawing.Point(155, 89)
        Me.Button_anterior.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_anterior.Name = "Button_anterior"
        Me.Button_anterior.Size = New System.Drawing.Size(100, 48)
        Me.Button_anterior.TabIndex = 62
        Me.Button_anterior.Text = "<"
        Me.Button_anterior.UseVisualStyleBackColor = True
        '
        'Button_inicio
        '
        Me.Button_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_inicio.Location = New System.Drawing.Point(47, 89)
        Me.Button_inicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_inicio.Name = "Button_inicio"
        Me.Button_inicio.Size = New System.Drawing.Size(100, 48)
        Me.Button_inicio.TabIndex = 61
        Me.Button_inicio.Text = "<<"
        Me.Button_inicio.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(91, 374)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 25)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Local:"
        '
        'TextBox_local
        '
        Me.TextBox_local.Location = New System.Drawing.Point(181, 374)
        Me.TextBox_local.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox_local.Name = "TextBox_local"
        Me.TextBox_local.Size = New System.Drawing.Size(185, 22)
        Me.TextBox_local.TabIndex = 80
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(364, 11)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(337, 31)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Atividades nas Paragens"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(101, 239)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 25)
        Me.Label8.TabIndex = 82
        Me.Label8.Text = "Data:"
        '
        'DateTimePickerData
        '
        Me.DateTimePickerData.Location = New System.Drawing.Point(181, 238)
        Me.DateTimePickerData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimePickerData.Name = "DateTimePickerData"
        Me.DateTimePickerData.Size = New System.Drawing.Size(185, 22)
        Me.DateTimePickerData.TabIndex = 83
        '
        'ComboBoxParagem
        '
        Me.ComboBoxParagem.FormattingEnabled = True
        Me.ComboBoxParagem.Location = New System.Drawing.Point(181, 342)
        Me.ComboBoxParagem.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxParagem.Name = "ComboBoxParagem"
        Me.ComboBoxParagem.Size = New System.Drawing.Size(185, 24)
        Me.ComboBoxParagem.TabIndex = 84
        '
        'HoraFim
        '
        Me.HoraFim.Location = New System.Drawing.Point(181, 306)
        Me.HoraFim.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HoraFim.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.HoraFim.Name = "HoraFim"
        Me.HoraFim.Size = New System.Drawing.Size(47, 22)
        Me.HoraFim.TabIndex = 110
        '
        'HoraInicio
        '
        Me.HoraInicio.Location = New System.Drawing.Point(181, 271)
        Me.HoraInicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HoraInicio.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.HoraInicio.Name = "HoraInicio"
        Me.HoraInicio.Size = New System.Drawing.Size(47, 22)
        Me.HoraInicio.TabIndex = 109
        '
        'MinutoFim
        '
        Me.MinutoFim.Location = New System.Drawing.Point(236, 306)
        Me.MinutoFim.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinutoFim.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.MinutoFim.Name = "MinutoFim"
        Me.MinutoFim.Size = New System.Drawing.Size(47, 22)
        Me.MinutoFim.TabIndex = 108
        '
        'MinutoInicio
        '
        Me.MinutoInicio.Location = New System.Drawing.Point(236, 271)
        Me.MinutoInicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinutoInicio.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.MinutoInicio.Name = "MinutoInicio"
        Me.MinutoInicio.Size = New System.Drawing.Size(47, 22)
        Me.MinutoInicio.TabIndex = 107
        '
        'ButtonNova1
        '
        Me.ButtonNova1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNova1.Location = New System.Drawing.Point(47, 417)
        Me.ButtonNova1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonNova1.Name = "ButtonNova1"
        Me.ButtonNova1.Size = New System.Drawing.Size(117, 48)
        Me.ButtonNova1.TabIndex = 111
        Me.ButtonNova1.Text = "Nova"
        Me.ButtonNova1.UseVisualStyleBackColor = True
        '
        'ComboBoxTipo1
        '
        Me.ComboBoxTipo1.FormattingEnabled = True
        Me.ComboBoxTipo1.Items.AddRange(New Object() {"Cultural", "Entretenimento", "Lazer", "Desportivo"})
        Me.ComboBoxTipo1.Location = New System.Drawing.Point(181, 203)
        Me.ComboBoxTipo1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxTipo1.Name = "ComboBoxTipo1"
        Me.ComboBoxTipo1.Size = New System.Drawing.Size(185, 24)
        Me.ComboBoxTipo1.TabIndex = 112
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderNome, Me.ColumnHeaderTipo, Me.ColumnHeaderData, Me.ColumnHeaderHoras, Me.ColumnHeaderParagem, Me.ColumnHeaderLocal})
        Me.ListView1.Location = New System.Drawing.Point(389, 150)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(823, 370)
        Me.ListView1.TabIndex = 115
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderNome
        '
        Me.ColumnHeaderNome.Text = "Nome"
        Me.ColumnHeaderNome.Width = 99
        '
        'ColumnHeaderTipo
        '
        Me.ColumnHeaderTipo.Text = "Tipo"
        Me.ColumnHeaderTipo.Width = 106
        '
        'ColumnHeaderData
        '
        Me.ColumnHeaderData.Text = "Data"
        Me.ColumnHeaderData.Width = 88
        '
        'ColumnHeaderHoras
        '
        Me.ColumnHeaderHoras.Text = "Horas Inicial-Hora Final"
        Me.ColumnHeaderHoras.Width = 152
        '
        'ColumnHeaderParagem
        '
        Me.ColumnHeaderParagem.Text = "Paragem"
        Me.ColumnHeaderParagem.Width = 115
        '
        'ColumnHeaderLocal
        '
        Me.ColumnHeaderLocal.Text = "Local"
        '
        'FormAtividades_Paragens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1232, 572)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ComboBoxTipo1)
        Me.Controls.Add(Me.ButtonNova1)
        Me.Controls.Add(Me.HoraFim)
        Me.Controls.Add(Me.HoraInicio)
        Me.Controls.Add(Me.MinutoFim)
        Me.Controls.Add(Me.MinutoInicio)
        Me.Controls.Add(Me.ComboBoxParagem)
        Me.Controls.Add(Me.DateTimePickerData)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox_local)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button_anular)
        Me.Controls.Add(Me.Button_Marcar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_nome)
        Me.Controls.Add(Me.Button_Adicionar)
        Me.Controls.Add(Me.Button_fim)
        Me.Controls.Add(Me.Button_seguinte)
        Me.Controls.Add(Me.Button_anterior)
        Me.Controls.Add(Me.Button_inicio)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormAtividades_Paragens"
        Me.Text = "Atividades nas Paragens"
        CType(Me.HoraFim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoraInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinutoFim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinutoInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Button_anular As Button
    Friend WithEvents Button_Marcar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_nome As TextBox
    Friend WithEvents Button_Adicionar As Button
    Friend WithEvents Button_fim As Button
    Friend WithEvents Button_seguinte As Button
    Friend WithEvents Button_anterior As Button
    Friend WithEvents Button_inicio As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox_local As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DateTimePickerData As DateTimePicker

    Friend WithEvents ComboBoxParagem As ComboBox
    Friend WithEvents HoraFim As NumericUpDown
    Friend WithEvents HoraInicio As NumericUpDown
    Friend WithEvents MinutoFim As NumericUpDown
    Friend WithEvents MinutoInicio As NumericUpDown


    Friend WithEvents ButtonNova As Button

    Friend WithEvents ComboBoxTipo As ComboBox
    Friend WithEvents ButtonNova1 As Button
    Friend WithEvents ComboBoxTipo1 As ComboBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeaderNome As ColumnHeader
    Friend WithEvents ColumnHeaderTipo As ColumnHeader
    Friend WithEvents ColumnHeaderData As ColumnHeader
    Friend WithEvents ColumnHeaderHoras As ColumnHeader
    Friend WithEvents ColumnHeaderParagem As ColumnHeader
    Friend WithEvents ColumnHeaderLocal As ColumnHeader
End Class
