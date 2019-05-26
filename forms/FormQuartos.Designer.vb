<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormQuartos
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_npessoas = New System.Windows.Forms.TextBox()
        Me.TextBox_numero = New System.Windows.Forms.TextBox()
        Me.Button_Adicionar = New System.Windows.Forms.Button()
        Me.Button_fim = New System.Windows.Forms.Button()
        Me.Button_seguinte = New System.Windows.Forms.Button()
        Me.Button_anterior = New System.Windows.Forms.Button()
        Me.Button_inicio = New System.Windows.Forms.Button()
        Me.TextBox_preco = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonNovo = New System.Windows.Forms.Button()
        Me.ComboBoxSeccao = New System.Windows.Forms.ComboBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeaderNumero = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderSeccao = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderNPessoas = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderPrecoPessoa = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(109, 221)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 20)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Secção:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 247)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(156, 20)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Número de Pessoas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 273)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 20)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Preço por pessoa:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 195)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Número:"
        '
        'TextBox_npessoas
        '
        Me.TextBox_npessoas.Location = New System.Drawing.Point(192, 247)
        Me.TextBox_npessoas.Name = "TextBox_npessoas"
        Me.TextBox_npessoas.Size = New System.Drawing.Size(140, 20)
        Me.TextBox_npessoas.TabIndex = 28
        '
        'TextBox_numero
        '
        Me.TextBox_numero.Location = New System.Drawing.Point(192, 195)
        Me.TextBox_numero.Name = "TextBox_numero"
        Me.TextBox_numero.Size = New System.Drawing.Size(140, 20)
        Me.TextBox_numero.TabIndex = 26
        '
        'Button_Adicionar
        '
        Me.Button_Adicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Adicionar.Location = New System.Drawing.Point(192, 319)
        Me.Button_Adicionar.Name = "Button_Adicionar"
        Me.Button_Adicionar.Size = New System.Drawing.Size(88, 39)
        Me.Button_Adicionar.TabIndex = 25
        Me.Button_Adicionar.Text = "Adicionar"
        Me.Button_Adicionar.UseVisualStyleBackColor = True
        '
        'Button_fim
        '
        Me.Button_fim.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_fim.Location = New System.Drawing.Point(273, 81)
        Me.Button_fim.Name = "Button_fim"
        Me.Button_fim.Size = New System.Drawing.Size(75, 39)
        Me.Button_fim.TabIndex = 23
        Me.Button_fim.Text = ">>"
        Me.Button_fim.UseVisualStyleBackColor = True
        '
        'Button_seguinte
        '
        Me.Button_seguinte.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_seguinte.Location = New System.Drawing.Point(192, 81)
        Me.Button_seguinte.Name = "Button_seguinte"
        Me.Button_seguinte.Size = New System.Drawing.Size(75, 39)
        Me.Button_seguinte.TabIndex = 22
        Me.Button_seguinte.Text = ">"
        Me.Button_seguinte.UseVisualStyleBackColor = True
        '
        'Button_anterior
        '
        Me.Button_anterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_anterior.Location = New System.Drawing.Point(111, 81)
        Me.Button_anterior.Name = "Button_anterior"
        Me.Button_anterior.Size = New System.Drawing.Size(75, 39)
        Me.Button_anterior.TabIndex = 21
        Me.Button_anterior.Text = "<"
        Me.Button_anterior.UseVisualStyleBackColor = True
        '
        'Button_inicio
        '
        Me.Button_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_inicio.Location = New System.Drawing.Point(30, 81)
        Me.Button_inicio.Name = "Button_inicio"
        Me.Button_inicio.Size = New System.Drawing.Size(75, 39)
        Me.Button_inicio.TabIndex = 20
        Me.Button_inicio.Text = "<<"
        Me.Button_inicio.UseVisualStyleBackColor = True
        '
        'TextBox_preco
        '
        Me.TextBox_preco.Location = New System.Drawing.Point(192, 273)
        Me.TextBox_preco.Name = "TextBox_preco"
        Me.TextBox_preco.Size = New System.Drawing.Size(140, 20)
        Me.TextBox_preco.TabIndex = 38
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(331, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 25)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Quartos"
        '
        'ButtonNovo
        '
        Me.ButtonNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNovo.Location = New System.Drawing.Point(98, 319)
        Me.ButtonNovo.Name = "ButtonNovo"
        Me.ButtonNovo.Size = New System.Drawing.Size(88, 39)
        Me.ButtonNovo.TabIndex = 64
        Me.ButtonNovo.Text = "Novo"
        Me.ButtonNovo.UseVisualStyleBackColor = True
        '
        'ComboBoxSeccao
        '
        Me.ComboBoxSeccao.FormattingEnabled = True
        Me.ComboBoxSeccao.Items.AddRange(New Object() {"Camarote Interior", "Camarote Exterior", "Camarote Com Varanda", "Suite"})
        Me.ComboBoxSeccao.Location = New System.Drawing.Point(192, 221)
        Me.ComboBoxSeccao.Name = "ComboBoxSeccao"
        Me.ComboBoxSeccao.Size = New System.Drawing.Size(140, 21)
        Me.ComboBoxSeccao.TabIndex = 67
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderNumero, Me.ColumnHeaderSeccao, Me.ColumnHeaderNPessoas, Me.ColumnHeaderPrecoPessoa})
        Me.ListView1.Location = New System.Drawing.Point(360, 131)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(511, 301)
        Me.ListView1.TabIndex = 119
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderNumero
        '
        Me.ColumnHeaderNumero.Text = "Número"
        Me.ColumnHeaderNumero.Width = 128
        '
        'ColumnHeaderSeccao
        '
        Me.ColumnHeaderSeccao.Text = "Secção"
        Me.ColumnHeaderSeccao.Width = 137
        '
        'ColumnHeaderNPessoas
        '
        Me.ColumnHeaderNPessoas.Text = "Número de Pessoas"
        Me.ColumnHeaderNPessoas.Width = 131
        '
        'ColumnHeaderPrecoPessoa
        '
        Me.ColumnHeaderPrecoPessoa.Text = "Preço por pessoa"
        Me.ColumnHeaderPrecoPessoa.Width = 110
        '
        'FormQuartos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(901, 465)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ComboBoxSeccao)
        Me.Controls.Add(Me.ButtonNovo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox_preco)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_npessoas)
        Me.Controls.Add(Me.TextBox_numero)
        Me.Controls.Add(Me.Button_Adicionar)
        Me.Controls.Add(Me.Button_fim)
        Me.Controls.Add(Me.Button_seguinte)
        Me.Controls.Add(Me.Button_anterior)
        Me.Controls.Add(Me.Button_inicio)
        Me.Name = "FormQuartos"
        Me.Text = "Quartos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_npessoas As TextBox
    Friend WithEvents TextBox_numero As TextBox
    Friend WithEvents Button_Adicionar As Button
    Friend WithEvents Button_fim As Button
    Friend WithEvents Button_seguinte As Button
    Friend WithEvents Button_anterior As Button
    Friend WithEvents Button_inicio As Button
    Friend WithEvents TextBox_preco As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonNovo As Button
    Friend WithEvents ComboBoxSeccao As ComboBox
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeaderNumero As ColumnHeader
    Friend WithEvents ColumnHeaderSeccao As ColumnHeader
    Friend WithEvents ColumnHeaderNPessoas As ColumnHeader
    Friend WithEvents ColumnHeaderPrecoPessoa As ColumnHeader
End Class
