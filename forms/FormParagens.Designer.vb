﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormParagens
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
        Me.TextBox_local = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button_Adicionar = New System.Windows.Forms.Button()
        Me.Button_fim = New System.Windows.Forms.Button()
        Me.Button_seguinte = New System.Windows.Forms.Button()
        Me.Button_anterior = New System.Windows.Forms.Button()
        Me.Button_inicio = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DateTimePickerData = New System.Windows.Forms.DateTimePicker()
        Me.MinutoInicio = New System.Windows.Forms.NumericUpDown()
        Me.MinutoFim = New System.Windows.Forms.NumericUpDown()
        Me.HoraInicio = New System.Windows.Forms.NumericUpDown()
        Me.HoraFim = New System.Windows.Forms.NumericUpDown()
        Me.ButtonNova = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeaderLocal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderData = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeaderHoras = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        CType(Me.MinutoInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MinutoFim, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoraInicio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HoraFim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextBox_local
        '
        Me.TextBox_local.Location = New System.Drawing.Point(141, 164)
        Me.TextBox_local.Name = "TextBox_local"
        Me.TextBox_local.Size = New System.Drawing.Size(174, 20)
        Me.TextBox_local.TabIndex = 100
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(73, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 20)
        Me.Label6.TabIndex = 99
        Me.Label6.Text = "Local:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(73, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 20)
        Me.Label5.TabIndex = 92
        Me.Label5.Text = "Data:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 216)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 20)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Hora de Início:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(24, 242)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "Hora de Fim:"
        '
        'Button_Adicionar
        '
        Me.Button_Adicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Adicionar.Location = New System.Drawing.Point(227, 302)
        Me.Button_Adicionar.Name = "Button_Adicionar"
        Me.Button_Adicionar.Size = New System.Drawing.Size(88, 39)
        Me.Button_Adicionar.TabIndex = 86
        Me.Button_Adicionar.Text = "Adicionar"
        Me.Button_Adicionar.UseVisualStyleBackColor = True
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
        'DateTimePickerData
        '
        Me.DateTimePickerData.Location = New System.Drawing.Point(141, 190)
        Me.DateTimePickerData.Name = "DateTimePickerData"
        Me.DateTimePickerData.Size = New System.Drawing.Size(174, 20)
        Me.DateTimePickerData.TabIndex = 102
        '
        'MinutoInicio
        '
        Me.MinutoInicio.Location = New System.Drawing.Point(181, 216)
        Me.MinutoInicio.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.MinutoInicio.Name = "MinutoInicio"
        Me.MinutoInicio.Size = New System.Drawing.Size(35, 20)
        Me.MinutoInicio.TabIndex = 103
        '
        'MinutoFim
        '
        Me.MinutoFim.Location = New System.Drawing.Point(181, 245)
        Me.MinutoFim.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.MinutoFim.Name = "MinutoFim"
        Me.MinutoFim.Size = New System.Drawing.Size(35, 20)
        Me.MinutoFim.TabIndex = 104
        '
        'HoraInicio
        '
        Me.HoraInicio.Location = New System.Drawing.Point(140, 216)
        Me.HoraInicio.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.HoraInicio.Name = "HoraInicio"
        Me.HoraInicio.Size = New System.Drawing.Size(35, 20)
        Me.HoraInicio.TabIndex = 105
        '
        'HoraFim
        '
        Me.HoraFim.Location = New System.Drawing.Point(140, 245)
        Me.HoraFim.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.HoraFim.Name = "HoraFim"
        Me.HoraFim.Size = New System.Drawing.Size(35, 20)
        Me.HoraFim.TabIndex = 106
        '
        'ButtonNova
        '
        Me.ButtonNova.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonNova.Location = New System.Drawing.Point(133, 302)
        Me.ButtonNova.Name = "ButtonNova"
        Me.ButtonNova.Size = New System.Drawing.Size(88, 39)
        Me.ButtonNova.TabIndex = 107
        Me.ButtonNova.Text = "Nova"
        Me.ButtonNova.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeaderLocal, Me.ColumnHeaderData, Me.ColumnHeaderHoras})
        Me.ListView1.Location = New System.Drawing.Point(399, 131)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(401, 301)
        Me.ListView1.TabIndex = 118
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeaderLocal
        '
        Me.ColumnHeaderLocal.Text = "Local"
        Me.ColumnHeaderLocal.Width = 128
        '
        'ColumnHeaderData
        '
        Me.ColumnHeaderData.Text = "Data"
        Me.ColumnHeaderData.Width = 137
        '
        'ColumnHeaderHoras
        '
        Me.ColumnHeaderHoras.Text = "Hora Inicial - Hora Final"
        Me.ColumnHeaderHoras.Width = 131
        '
        'FormParagens
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 466)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.ButtonNova)
        Me.Controls.Add(Me.HoraFim)
        Me.Controls.Add(Me.HoraInicio)
        Me.Controls.Add(Me.MinutoFim)
        Me.Controls.Add(Me.MinutoInicio)
        Me.Controls.Add(Me.DateTimePickerData)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_local)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button_Adicionar)
        Me.Controls.Add(Me.Button_fim)
        Me.Controls.Add(Me.Button_seguinte)
        Me.Controls.Add(Me.Button_anterior)
        Me.Controls.Add(Me.Button_inicio)
        Me.Name = "FormParagens"
        Me.Text = "Paragens"
        CType(Me.MinutoInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MinutoFim, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoraInicio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HoraFim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_local As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button_Adicionar As Button
    Friend WithEvents Button_fim As Button
    Friend WithEvents Button_seguinte As Button
    Friend WithEvents Button_anterior As Button
    Friend WithEvents Button_inicio As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePickerData As DateTimePicker

    Friend WithEvents MinutoInicio As NumericUpDown
    Friend WithEvents MinutoFim As NumericUpDown
    Friend WithEvents HoraInicio As NumericUpDown
    Friend WithEvents HoraFim As NumericUpDown
    Friend WithEvents ButtonNova As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeaderLocal As ColumnHeader
    Friend WithEvents ColumnHeaderData As ColumnHeader
    Friend WithEvents ColumnHeaderHoras As ColumnHeader
End Class
