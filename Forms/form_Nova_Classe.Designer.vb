<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_Nova_Classe
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_nome = New System.Windows.Forms.TextBox()
        Me.txt_numero_caixas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.bot_Gerar = New System.Windows.Forms.Button()
        Me.bot_proximo1 = New System.Windows.Forms.Button()
        Me.Painel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome da Classe:"
        '
        'txt_nome
        '
        Me.txt_nome.Location = New System.Drawing.Point(401, 29)
        Me.txt_nome.Name = "txt_nome"
        Me.txt_nome.Size = New System.Drawing.Size(125, 27)
        Me.txt_nome.TabIndex = 1
        '
        'txt_numero_caixas
        '
        Me.txt_numero_caixas.Location = New System.Drawing.Point(401, 78)
        Me.txt_numero_caixas.Name = "txt_numero_caixas"
        Me.txt_numero_caixas.Size = New System.Drawing.Size(125, 27)
        Me.txt_numero_caixas.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(40, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(299, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Quantas Características específicas ela terá?"
        '
        'bot_Gerar
        '
        Me.bot_Gerar.Location = New System.Drawing.Point(547, 150)
        Me.bot_Gerar.Name = "bot_Gerar"
        Me.bot_Gerar.Size = New System.Drawing.Size(94, 29)
        Me.bot_Gerar.TabIndex = 4
        Me.bot_Gerar.Text = "Gerar"
        Me.bot_Gerar.UseVisualStyleBackColor = True
        '
        'bot_proximo1
        '
        Me.bot_proximo1.Location = New System.Drawing.Point(432, 150)
        Me.bot_proximo1.Name = "bot_proximo1"
        Me.bot_proximo1.Size = New System.Drawing.Size(94, 29)
        Me.bot_proximo1.TabIndex = 5
        Me.bot_proximo1.Text = "Proximo"
        Me.bot_proximo1.UseVisualStyleBackColor = True
        '
        'Painel
        '
        Me.Painel.Location = New System.Drawing.Point(12, 185)
        Me.Painel.Name = "Painel"
        Me.Painel.Size = New System.Drawing.Size(543, 607)
        Me.Painel.TabIndex = 6
        '
        'form_Nova_Classe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 804)
        Me.Controls.Add(Me.Painel)
        Me.Controls.Add(Me.bot_proximo1)
        Me.Controls.Add(Me.bot_Gerar)
        Me.Controls.Add(Me.txt_numero_caixas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_nome)
        Me.Controls.Add(Me.Label1)
        Me.Name = "form_Nova_Classe"
        Me.Text = "form_Nova_Classe"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_nome As TextBox
    Friend WithEvents txt_numero_caixas As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents bot_Gerar As Button
    Friend WithEvents bot_proximo1 As Button
    Friend WithEvents Painel As Panel
End Class
