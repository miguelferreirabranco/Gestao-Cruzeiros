﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCruzeiros
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
        Me.Button_inicio = New System.Windows.Forms.Button()
        Me.Button_anterior = New System.Windows.Forms.Button()
        Me.Button_seguinte = New System.Windows.Forms.Button()
        Me.Button_fim = New System.Windows.Forms.Button()
        Me.Button_Adicionar = New System.Windows.Forms.Button()
        Me.TextBox_nome = New System.Windows.Forms.TextBox()
        Me.TextBox_destino = New System.Windows.Forms.TextBox()
        Me.TextBox_origem = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker_datainicial = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker_datafinal = New System.Windows.Forms.DateTimePicker()
        Me.Button_modificar = New System.Windows.Forms.Button()
        Me.Button_Reservar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ButtonNovo = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeaderNome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderOrigem = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderDestino = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderDataInicial1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderDataFinal1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LabelRCV = New System.Windows.Forms.Label()
        Me.LabelE = New System.Windows.Forms.Label()
        Me.LabelReceitaCruzeiroV = New System.Windows.Forms.Label()
        Me.LabelReceitaEmpresa = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button_inicio
        '
        Me.Button_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_inicio.Location = New System.Drawing.Point(31, 76)
        Me.Button_inicio.Name = "Button_inicio"
        Me.Button_inicio.Size = New System.Drawing.Size(75, 39)
        Me.Button_inicio.TabIndex = 0
        Me.Button_inicio.Text = "<<"
        Me.Button_inicio.UseVisualStyleBackColor = True
        '
        'Button_anterior
        '
        Me.Button_anterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_anterior.Location = New System.Drawing.Point(112, 76)
        Me.Button_anterior.Name = "Button_anterior"
        Me.Button_anterior.Size = New System.Drawing.Size(75, 39)
        Me.Button_anterior.TabIndex = 1
        Me.Button_anterior.Text = "<"
        Me.Button_anterior.UseVisualStyleBackColor = True
        '
        'Button_seguinte
        '
        Me.Button_seguinte.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_seguinte.Location = New System.Drawing.Point(193, 76)
        Me.Button_seguinte.Name = "Button_seguinte"
        Me.Button_seguinte.Size = New System.Drawing.Size(75, 39)
        Me.Button_seguinte.TabIndex = 2
        Me.Button_seguinte.Text = ">"
        Me.Button_seguinte.UseVisualStyleBackColor = True
        '
        'Button_fim
        '
        Me.Button_fim.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_fim.Location = New System.Drawing.Point(274, 76)
        Me.Button_fim.Name = "Button_fim"
        Me.Button_fim.Size = New System.Drawing.Size(75, 39)
        Me.Button_fim.TabIndex = 3
        Me.Button_fim.Text = ">>"
        Me.Button_fim.UseVisualStyleBackColor = True
        '
        'Button_Adicionar
        '
        Me.Button_Adicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Adicionar.Location = New System.Drawing.Point(264, 359)
        Me.Button_Adicionar.Name = "Button_Adicionar"
        Me.Button_Adicionar.Size = New System.Drawing.Size(88, 39)
        Me.Button_Adicionar.TabIndex = 5
        Me.Button_Adicionar.Text = "Adicionar"
        Me.Button_Adicionar.UseVisualStyleBackColor = True
        '
        'TextBox_nome
        '
        Me.TextBox_nome.Location = New System.Drawing.Point(145, 176)
        Me.TextBox_nome.Name = "TextBox_nome"
        Me.TextBox_nome.Size = New System.Drawing.Size(204, 20)
        Me.TextBox_nome.TabIndex = 6
        '
        'TextBox_destino
        '
        Me.TextBox_destino.Location = New System.Drawing.Point(145, 228)
        Me.TextBox_destino.Name = "TextBox_destino"
        Me.TextBox_destino.Size = New System.Drawing.Size(204, 20)
        Me.TextBox_destino.TabIndex = 8
        '
        'TextBox_origem
        '
        Me.TextBox_origem.Location = New System.Drawing.Point(145, 202)
        Me.TextBox_origem.Name = "TextBox_origem"
        Me.TextBox_origem.Size = New System.Drawing.Size(204, 20)
        Me.TextBox_origem.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 254)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Data de Início:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 280)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Data de Fim:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(66, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Origem:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(62, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Destino:"
        '
        'DateTimePicker_datainicial
        '
        Me.DateTimePicker_datainicial.Location = New System.Drawing.Point(145, 254)
        Me.DateTimePicker_datainicial.Name = "DateTimePicker_datainicial"
        Me.DateTimePicker_datainicial.Size = New System.Drawing.Size(204, 20)
        Me.DateTimePicker_datainicial.TabIndex = 16
        '
        'DateTimePicker_datafinal
        '
        Me.DateTimePicker_datafinal.Location = New System.Drawing.Point(145, 280)
        Me.DateTimePicker_datafinal.Name = "DateTimePicker_datafinal"
        Me.DateTimePicker_datafinal.Size = New System.Drawing.Size(204, 20)
        Me.DateTimePicker_datafinal.TabIndex = 17
        '
        'Button_modificar
        '
        Me.Button_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_modificar.Location = New System.Drawing.Point(66, 359)
        Me.Button_modificar.Name = "Button_modificar"
        Me.Button_modificar.Size = New System.Drawing.Size(88, 39)
        Me.Button_modificar.TabIndex = 18
        Me.Button_modificar.Text = "Modificar"
        Me.Button_modificar.UseVisualStyleBackColor = True
        '
        'Button_Reservar
        '
        Me.Button_Reservar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Reservar.Location = New System.Drawing.Point(66, 405)
        Me.Button_Reservar.Name = "Button_Reservar"
        Me.Button_Reservar.Size = New System.Drawing.Size(88, 39)
        Me.Button_Reservar.TabIndex = 19
        Me.Button_Reservar.Text = "Reservar"
        Me.Button_Reservar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(319, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(113, 25)
        Me.Label6.TabIndex = 62
        Me.Label6.Text = "Cruzeiros"
        '
        'ButtonNovo
        '
        Me.ButtonNovo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNovo.Location = New System.Drawing.Point(170, 359)
        Me.ButtonNovo.Name = "ButtonNovo"
        Me.ButtonNovo.Size = New System.Drawing.Size(88, 39)
        Me.ButtonNovo.TabIndex = 63
        Me.ButtonNovo.Text = "Novo"
        Me.ButtonNovo.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderNome, Me.ColumnHeaderOrigem, Me.ColumnHeaderDestino, Me.ColumnHeaderDataInicial1, Me.ColumnHeaderDataFinal1})
        Me.ListView1.Location = New System.Drawing.Point(376, 128)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(467, 301)
        Me.ListView1.TabIndex = 115
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderNome
        '
        Me.ColumnHeaderNome.Text = "Nome"
        Me.ColumnHeaderNome.Width = 124
        '
        'ColumnHeaderOrigem
        '
        Me.ColumnHeaderOrigem.Text = "Origem"
        Me.ColumnHeaderOrigem.Width = 79
        '
        'ColumnHeaderDestino
        '
        Me.ColumnHeaderDestino.Text = "Destino"
        Me.ColumnHeaderDestino.Width = 81
        '
        'ColumnHeaderDataInicial1
        '
        Me.ColumnHeaderDataInicial1.Text = "Data Inicial"
        Me.ColumnHeaderDataInicial1.Width = 98
        '
        'ColumnHeaderDataFinal1
        '
        Me.ColumnHeaderDataFinal1.Text = "Data Final"
        Me.ColumnHeaderDataFinal1.Width = 105
        '
        'LabelRCV
        '
        Me.LabelRCV.AutoSize = True
        Me.LabelRCV.Location = New System.Drawing.Point(561, 68)
        Me.LabelRCV.Name = "LabelRCV"
        Me.LabelRCV.Size = New System.Drawing.Size(138, 13)
        Me.LabelRCV.TabIndex = 116
        Me.LabelRCV.Text = "Receita do Cruzeiro Visível:"
        '
        'LabelE
        '
        Me.LabelE.AutoSize = True
        Me.LabelE.Location = New System.Drawing.Point(593, 91)
        Me.LabelE.Name = "LabelE"
        Me.LabelE.Size = New System.Drawing.Size(106, 13)
        Me.LabelE.TabIndex = 117
        Me.LabelE.Text = "Receita da Empresa:"
        '
        'LabelReceitaCruzeiroV
        '
        Me.LabelReceitaCruzeiroV.AutoSize = True
        Me.LabelReceitaCruzeiroV.Location = New System.Drawing.Point(708, 68)
        Me.LabelReceitaCruzeiroV.Name = "LabelReceitaCruzeiroV"
        Me.LabelReceitaCruzeiroV.Size = New System.Drawing.Size(39, 13)
        Me.LabelReceitaCruzeiroV.TabIndex = 118
        Me.LabelReceitaCruzeiroV.Text = "Label9"
        '
        'LabelReceitaEmpresa
        '
        Me.LabelReceitaEmpresa.AutoSize = True
        Me.LabelReceitaEmpresa.Location = New System.Drawing.Point(708, 91)
        Me.LabelReceitaEmpresa.Name = "LabelReceitaEmpresa"
        Me.LabelReceitaEmpresa.Size = New System.Drawing.Size(39, 13)
        Me.LabelReceitaEmpresa.TabIndex = 119
        Me.LabelReceitaEmpresa.Text = "Label9"
        '
        'FormCruzeiros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 465)
        Me.Controls.Add(Me.LabelReceitaEmpresa)
        Me.Controls.Add(Me.LabelReceitaCruzeiroV)
        Me.Controls.Add(Me.LabelE)
        Me.Controls.Add(Me.LabelRCV)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ButtonNovo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button_Reservar)
        Me.Controls.Add(Me.Button_modificar)
        Me.Controls.Add(Me.DateTimePicker_datafinal)
        Me.Controls.Add(Me.DateTimePicker_datainicial)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_origem)
        Me.Controls.Add(Me.TextBox_destino)
        Me.Controls.Add(Me.TextBox_nome)
        Me.Controls.Add(Me.Button_Adicionar)
        Me.Controls.Add(Me.Button_fim)
        Me.Controls.Add(Me.Button_seguinte)
        Me.Controls.Add(Me.Button_anterior)
        Me.Controls.Add(Me.Button_inicio)
        Me.Name = "FormCruzeiros"
        Me.Text = "Cruzeiros"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_inicio As Button
    Friend WithEvents Button_anterior As Button
    Friend WithEvents Button_seguinte As Button
    Friend WithEvents Button_fim As Button
    Friend WithEvents Button_Adicionar As Button
    Friend WithEvents TextBox_nome As TextBox
    Friend WithEvents TextBox_destino As TextBox
    Friend WithEvents TextBox_origem As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker_datainicial As DateTimePicker
    Friend WithEvents DateTimePicker_datafinal As DateTimePicker
    Friend WithEvents Button_modificar As Button
    Friend WithEvents Button_Reservar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents ButtonNovo As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeaderNome As ColumnHeader
    Friend WithEvents ColumnHeaderOrigem As ColumnHeader
    Friend WithEvents ColumnHeaderDestino As ColumnHeader
    Friend WithEvents ColumnHeaderDataInicial1 As ColumnHeader
    Friend WithEvents ColumnHeaderDataFinal1 As ColumnHeader
    Friend WithEvents LabelRCV As Label
    Friend WithEvents LabelE As Label
    Friend WithEvents LabelReceitaCruzeiroV As Label
    Friend WithEvents LabelReceitaEmpresa As Label
End Class
