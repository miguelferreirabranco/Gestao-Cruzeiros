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
        Me.Button_Reservar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_npessoas = New System.Windows.Forms.TextBox()
        Me.TextBox_seccao = New System.Windows.Forms.TextBox()
        Me.TextBox_numero = New System.Windows.Forms.TextBox()
        Me.Button_Adicionar = New System.Windows.Forms.Button()
        Me.ListBox_Quartos = New System.Windows.Forms.ListBox()
        Me.Button_fim = New System.Windows.Forms.Button()
        Me.Button_seguinte = New System.Windows.Forms.Button()
        Me.Button_anterior = New System.Windows.Forms.Button()
        Me.Button_inicio = New System.Windows.Forms.Button()
        Me.TextBox_preco = New System.Windows.Forms.TextBox()
        Me.Button_anular = New System.Windows.Forms.Button()
        Me.Button_reservaVIP = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button_Reservar
        '
        Me.Button_Reservar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Reservar.Location = New System.Drawing.Point(40, 448)
        Me.Button_Reservar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_Reservar.Name = "Button_Reservar"
        Me.Button_Reservar.Size = New System.Drawing.Size(117, 48)
        Me.Button_Reservar.TabIndex = 37
        Me.Button_Reservar.Text = "Reservar"
        Me.Button_Reservar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(145, 272)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 25)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "Secção:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 304)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 25)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Número de Pessoas:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 336)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 25)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "Preço por pessoa:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(143, 240)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 25)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Número:"
        '
        'TextBox_npessoas
        '
        Me.TextBox_npessoas.Location = New System.Drawing.Point(256, 304)
        Me.TextBox_npessoas.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox_npessoas.Name = "TextBox_npessoas"
        Me.TextBox_npessoas.Size = New System.Drawing.Size(185, 22)
        Me.TextBox_npessoas.TabIndex = 28
        '
        'TextBox_seccao
        '
        Me.TextBox_seccao.Location = New System.Drawing.Point(256, 272)
        Me.TextBox_seccao.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox_seccao.Name = "TextBox_seccao"
        Me.TextBox_seccao.Size = New System.Drawing.Size(185, 22)
        Me.TextBox_seccao.TabIndex = 27
        '
        'TextBox_numero
        '
        Me.TextBox_numero.Location = New System.Drawing.Point(256, 240)
        Me.TextBox_numero.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox_numero.Name = "TextBox_numero"
        Me.TextBox_numero.Size = New System.Drawing.Size(185, 22)
        Me.TextBox_numero.TabIndex = 26
        '
        'Button_Adicionar
        '
        Me.Button_Adicionar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_Adicionar.Location = New System.Drawing.Point(40, 393)
        Me.Button_Adicionar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_Adicionar.Name = "Button_Adicionar"
        Me.Button_Adicionar.Size = New System.Drawing.Size(117, 48)
        Me.Button_Adicionar.TabIndex = 25
        Me.Button_Adicionar.Text = "Adicionar"
        Me.Button_Adicionar.UseVisualStyleBackColor = True
        '
        'ListBox_Quartos
        '
        Me.ListBox_Quartos.FormattingEnabled = True
        Me.ListBox_Quartos.ItemHeight = 16
        Me.ListBox_Quartos.Location = New System.Drawing.Point(588, 185)
        Me.ListBox_Quartos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ListBox_Quartos.Name = "ListBox_Quartos"
        Me.ListBox_Quartos.Size = New System.Drawing.Size(437, 372)
        Me.ListBox_Quartos.TabIndex = 24
        '
        'Button_fim
        '
        Me.Button_fim.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_fim.Location = New System.Drawing.Point(364, 100)
        Me.Button_fim.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_fim.Name = "Button_fim"
        Me.Button_fim.Size = New System.Drawing.Size(100, 48)
        Me.Button_fim.TabIndex = 23
        Me.Button_fim.Text = ">>"
        Me.Button_fim.UseVisualStyleBackColor = True
        '
        'Button_seguinte
        '
        Me.Button_seguinte.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_seguinte.Location = New System.Drawing.Point(256, 100)
        Me.Button_seguinte.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_seguinte.Name = "Button_seguinte"
        Me.Button_seguinte.Size = New System.Drawing.Size(100, 48)
        Me.Button_seguinte.TabIndex = 22
        Me.Button_seguinte.Text = ">"
        Me.Button_seguinte.UseVisualStyleBackColor = True
        '
        'Button_anterior
        '
        Me.Button_anterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_anterior.Location = New System.Drawing.Point(148, 100)
        Me.Button_anterior.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_anterior.Name = "Button_anterior"
        Me.Button_anterior.Size = New System.Drawing.Size(100, 48)
        Me.Button_anterior.TabIndex = 21
        Me.Button_anterior.Text = "<"
        Me.Button_anterior.UseVisualStyleBackColor = True
        '
        'Button_inicio
        '
        Me.Button_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_inicio.Location = New System.Drawing.Point(40, 100)
        Me.Button_inicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_inicio.Name = "Button_inicio"
        Me.Button_inicio.Size = New System.Drawing.Size(100, 48)
        Me.Button_inicio.TabIndex = 20
        Me.Button_inicio.Text = "<<"
        Me.Button_inicio.UseVisualStyleBackColor = True
        '
        'TextBox_preco
        '
        Me.TextBox_preco.Location = New System.Drawing.Point(256, 336)
        Me.TextBox_preco.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox_preco.Name = "TextBox_preco"
        Me.TextBox_preco.Size = New System.Drawing.Size(185, 22)
        Me.TextBox_preco.TabIndex = 38
        '
        'Button_anular
        '
        Me.Button_anular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_anular.Location = New System.Drawing.Point(291, 448)
        Me.Button_anular.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_anular.Name = "Button_anular"
        Me.Button_anular.Size = New System.Drawing.Size(117, 48)
        Me.Button_anular.TabIndex = 39
        Me.Button_anular.Text = "Anular"
        Me.Button_anular.UseVisualStyleBackColor = True
        '
        'Button_reservaVIP
        '
        Me.Button_reservaVIP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button_reservaVIP.Location = New System.Drawing.Point(165, 448)
        Me.Button_reservaVIP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button_reservaVIP.Name = "Button_reservaVIP"
        Me.Button_reservaVIP.Size = New System.Drawing.Size(117, 48)
        Me.Button_reservaVIP.TabIndex = 40
        Me.Button_reservaVIP.Text = "Reserva VIP"
        Me.Button_reservaVIP.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(441, 11)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 31)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Quartos"
        '
        'FormQuartos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1071, 572)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button_reservaVIP)
        Me.Controls.Add(Me.Button_anular)
        Me.Controls.Add(Me.TextBox_preco)
        Me.Controls.Add(Me.Button_Reservar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_npessoas)
        Me.Controls.Add(Me.TextBox_seccao)
        Me.Controls.Add(Me.TextBox_numero)
        Me.Controls.Add(Me.Button_Adicionar)
        Me.Controls.Add(Me.ListBox_Quartos)
        Me.Controls.Add(Me.Button_fim)
        Me.Controls.Add(Me.Button_seguinte)
        Me.Controls.Add(Me.Button_anterior)
        Me.Controls.Add(Me.Button_inicio)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "FormQuartos"
        Me.Text = "Quartos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Reservar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox_npessoas As TextBox
    Friend WithEvents TextBox_seccao As TextBox
    Friend WithEvents TextBox_numero As TextBox
    Friend WithEvents Button_Adicionar As Button
    Friend WithEvents ListBox_Quartos As ListBox
    Friend WithEvents Button_fim As Button
    Friend WithEvents Button_seguinte As Button
    Friend WithEvents Button_anterior As Button
    Friend WithEvents Button_inicio As Button
    Friend WithEvents TextBox_preco As TextBox
    Friend WithEvents Button_anular As Button
    Friend WithEvents Button_reservaVIP As Button
    Friend WithEvents Label6 As Label
End Class
