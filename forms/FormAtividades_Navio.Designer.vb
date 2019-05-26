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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePickerData = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.HoraFim = New System.Windows.Forms.NumericUpDown()
        Me.HoraInicio = New System.Windows.Forms.NumericUpDown()
        Me.MinutoFim = New System.Windows.Forms.NumericUpDown()
        Me.MinutoInicio = New System.Windows.Forms.NumericUpDown()
        Me.ComboBoxTipo = New System.Windows.Forms.ComboBox()
        Me.ComboBoxSeccao = New System.Windows.Forms.ComboBox()
        Me.ButtonNova = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeaderNome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderTipo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderData = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderHoras = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderSecao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.HoraFim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoraInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinutoFim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinutoInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button_anular
        '
        Me.Button_anular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_anular.Location = New System.Drawing.Point(156, 462)
        Me.Button_anular.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_anular.Name = "Button_anular"
        Me.Button_anular.Size = New System.Drawing.Size(117, 48)
        Me.Button_anular.TabIndex = 56
        Me.Button_anular.Text = "Anular"
        Me.Button_anular.UseVisualStyleBackColor = True
        '
        'Button_Marcar
        '
        Me.Button_Marcar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Marcar.Location = New System.Drawing.Point(31, 462)
        Me.Button_Marcar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_Marcar.Name = "Button_Marcar"
        Me.Button_Marcar.Size = New System.Drawing.Size(117, 48)
        Me.Button_Marcar.TabIndex = 54
        Me.Button_Marcar.Text = "Marcar"
        Me.Button_Marcar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(168, 222)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 25)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Tipo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(77, 287)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(137, 25)
        Me.Label4.TabIndex = 52
        Me.Label4.Text = "Hora de Início:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(91, 325)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 25)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Hora de Fim:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(151, 190)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 25)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Nome:"
        '
        'TextBox_nome
        '
        Me.TextBox_nome.Location = New System.Drawing.Point(247, 190)
        Me.TextBox_nome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox_nome.Name = "TextBox_nome"
        Me.TextBox_nome.Size = New System.Drawing.Size(185, 22)
        Me.TextBox_nome.TabIndex = 47
        '
        'Button_Adicionar
        '
        Me.Button_Adicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Adicionar.Location = New System.Drawing.Point(156, 406)
        Me.Button_Adicionar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_Adicionar.Name = "Button_Adicionar"
        Me.Button_Adicionar.Size = New System.Drawing.Size(117, 48)
        Me.Button_Adicionar.TabIndex = 46
        Me.Button_Adicionar.Text = "Adicionar"
        Me.Button_Adicionar.UseVisualStyleBackColor = True
        '
        'Button_fim
        '
        Me.Button_fim.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_fim.Location = New System.Drawing.Point(355, 89)
        Me.Button_fim.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_fim.Name = "Button_fim"
        Me.Button_fim.Size = New System.Drawing.Size(100, 48)
        Me.Button_fim.TabIndex = 44
        Me.Button_fim.Text = ">>"
        Me.Button_fim.UseVisualStyleBackColor = True
        '
        'Button_seguinte
        '
        Me.Button_seguinte.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_seguinte.Location = New System.Drawing.Point(247, 89)
        Me.Button_seguinte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_seguinte.Name = "Button_seguinte"
        Me.Button_seguinte.Size = New System.Drawing.Size(100, 48)
        Me.Button_seguinte.TabIndex = 43
        Me.Button_seguinte.Text = ">"
        Me.Button_seguinte.UseVisualStyleBackColor = True
        '
        'Button_anterior
        '
        Me.Button_anterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_anterior.Location = New System.Drawing.Point(139, 89)
        Me.Button_anterior.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_anterior.Name = "Button_anterior"
        Me.Button_anterior.Size = New System.Drawing.Size(100, 48)
        Me.Button_anterior.TabIndex = 42
        Me.Button_anterior.Text = "<"
        Me.Button_anterior.UseVisualStyleBackColor = True
        '
        'Button_inicio
        '
        Me.Button_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_inicio.Location = New System.Drawing.Point(31, 89)
        Me.Button_inicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_inicio.Name = "Button_inicio"
        Me.Button_inicio.Size = New System.Drawing.Size(100, 48)
        Me.Button_inicio.TabIndex = 41
        Me.Button_inicio.Text = "<<"
        Me.Button_inicio.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 358)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 25)
        Me.Label3.TabIndex = 58
        Me.Label3.Text = "Secção do Navio:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(380, 11)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(273, 31)
        Me.Label6.TabIndex = 61
        Me.Label6.Text = "Atividades no Navio"
        '
        'DateTimePickerData
        '
        Me.DateTimePickerData.Location = New System.Drawing.Point(247, 255)
        Me.DateTimePickerData.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateTimePickerData.Name = "DateTimePickerData"
        Me.DateTimePickerData.Size = New System.Drawing.Size(185, 22)
        Me.DateTimePickerData.TabIndex = 62
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(160, 256)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(59, 25)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Data:"
        '
        'HoraFim
        '
        Me.HoraFim.Location = New System.Drawing.Point(247, 329)
        Me.HoraFim.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HoraFim.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.HoraFim.Name = "HoraFim"
        Me.HoraFim.Size = New System.Drawing.Size(47, 22)
        Me.HoraFim.TabIndex = 110
        '
        'HoraInicio
        '
        Me.HoraInicio.Location = New System.Drawing.Point(247, 293)
        Me.HoraInicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.HoraInicio.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.HoraInicio.Name = "HoraInicio"
        Me.HoraInicio.Size = New System.Drawing.Size(47, 22)
        Me.HoraInicio.TabIndex = 109
        '
        'MinutoFim
        '
        Me.MinutoFim.Location = New System.Drawing.Point(301, 329)
        Me.MinutoFim.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinutoFim.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.MinutoFim.Name = "MinutoFim"
        Me.MinutoFim.Size = New System.Drawing.Size(47, 22)
        Me.MinutoFim.TabIndex = 108
        '
        'MinutoInicio
        '
        Me.MinutoInicio.Location = New System.Drawing.Point(301, 293)
        Me.MinutoInicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinutoInicio.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.MinutoInicio.Name = "MinutoInicio"
        Me.MinutoInicio.Size = New System.Drawing.Size(47, 22)
        Me.MinutoInicio.TabIndex = 107
        '
        'ComboBoxTipo
        '
        Me.ComboBoxTipo.FormattingEnabled = True
        Me.ComboBoxTipo.Items.AddRange(New Object() {"Entretenimento", "Cultural", "Lazer", "Desportivo"})
        Me.ComboBoxTipo.Location = New System.Drawing.Point(247, 219)
        Me.ComboBoxTipo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxTipo.Name = "ComboBoxTipo"
        Me.ComboBoxTipo.Size = New System.Drawing.Size(185, 24)
        Me.ComboBoxTipo.TabIndex = 111
        '
        'ComboBoxSeccao
        '
        Me.ComboBoxSeccao.FormattingEnabled = True
        Me.ComboBoxSeccao.Items.AddRange(New Object() {"Convés Superior", "Convés Inferior", "Sala de Eventos", "Piscina/Jacuzi"})
        Me.ComboBoxSeccao.Location = New System.Drawing.Point(247, 358)
        Me.ComboBoxSeccao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxSeccao.Name = "ComboBoxSeccao"
        Me.ComboBoxSeccao.Size = New System.Drawing.Size(185, 24)
        Me.ComboBoxSeccao.TabIndex = 112
        '
        'ButtonNova
        '
        Me.ButtonNova.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNova.Location = New System.Drawing.Point(31, 406)
        Me.ButtonNova.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ButtonNova.Name = "ButtonNova"
        Me.ButtonNova.Size = New System.Drawing.Size(117, 48)
        Me.ButtonNova.TabIndex = 113
        Me.ButtonNova.Text = "Nova"
        Me.ButtonNova.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderNome, Me.ColumnHeaderTipo, Me.ColumnHeaderData, Me.ColumnHeaderHoras, Me.ColumnHeaderSecao})
        Me.ListView1.Location = New System.Drawing.Point(449, 158)
        Me.ListView1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(765, 370)
        Me.ListView1.TabIndex = 114
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
        'ColumnHeaderSecao
        '
        Me.ColumnHeaderSecao.Text = "Secção"
        Me.ColumnHeaderSecao.Width = 115
        '
        'FormAtividades_Navio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1220, 561)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ButtonNova)
        Me.Controls.Add(Me.ComboBoxSeccao)
        Me.Controls.Add(Me.ComboBoxTipo)
        Me.Controls.Add(Me.HoraFim)
        Me.Controls.Add(Me.HoraInicio)
        Me.Controls.Add(Me.MinutoFim)
        Me.Controls.Add(Me.MinutoInicio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.DateTimePickerData)
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
        Me.Name = "FormAtividades_Navio"
        Me.Text = "Atividades no Navio"
        CType(Me.HoraFim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoraInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinutoFim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinutoInicio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePickerData As DateTimePicker
    Friend WithEvents Label7 As Label

    Friend WithEvents HoraFim As NumericUpDown
    Friend WithEvents HoraInicio As NumericUpDown
    Friend WithEvents MinutoFim As NumericUpDown
    Friend WithEvents MinutoInicio As NumericUpDown
    Friend WithEvents ComboBoxTipo As ComboBox
    Friend WithEvents ComboBoxSeccao As ComboBox
    Friend WithEvents ButtonNova As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeaderNome As ColumnHeader
    Friend WithEvents ColumnHeaderTipo As ColumnHeader
    Friend WithEvents ColumnHeaderData As ColumnHeader
    Friend WithEvents ColumnHeaderHoras As ColumnHeader
    Friend WithEvents ColumnHeaderSecao As ColumnHeader
End Class
