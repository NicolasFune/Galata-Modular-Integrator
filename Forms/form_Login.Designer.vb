<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_Login))
        Me.bot_Fechar = New System.Windows.Forms.PictureBox()
        Me.bot_Maximizar = New System.Windows.Forms.PictureBox()
        Me.bot_Minimizar = New System.Windows.Forms.PictureBox()
        Me.Barra_Login = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bot_senha = New System.Windows.Forms.PictureBox()
        Me.txt_Usuário = New System.Windows.Forms.TextBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.txt_Senha = New System.Windows.Forms.TextBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.bot_Entrar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.bot_Fechar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_Maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Barra_Login.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.bot_senha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'bot_Fechar
        '
        Me.bot_Fechar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_Fechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_Fechar.Image = Global.Gálata.My.Resources.Resources.close_24px
        Me.bot_Fechar.Location = New System.Drawing.Point(1102, 17)
        Me.bot_Fechar.Name = "bot_Fechar"
        Me.bot_Fechar.Size = New System.Drawing.Size(24, 24)
        Me.bot_Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_Fechar.TabIndex = 7
        Me.bot_Fechar.TabStop = False
        '
        'bot_Maximizar
        '
        Me.bot_Maximizar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_Maximizar.Image = Global.Gálata.My.Resources.Resources.maximizar_24px
        Me.bot_Maximizar.Location = New System.Drawing.Point(1046, 17)
        Me.bot_Maximizar.Name = "bot_Maximizar"
        Me.bot_Maximizar.Size = New System.Drawing.Size(24, 24)
        Me.bot_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_Maximizar.TabIndex = 6
        Me.bot_Maximizar.TabStop = False
        '
        'bot_Minimizar
        '
        Me.bot_Minimizar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_Minimizar.Image = Global.Gálata.My.Resources.Resources.minimizar2_24px
        Me.bot_Minimizar.Location = New System.Drawing.Point(990, 17)
        Me.bot_Minimizar.Name = "bot_Minimizar"
        Me.bot_Minimizar.Size = New System.Drawing.Size(24, 24)
        Me.bot_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_Minimizar.TabIndex = 5
        Me.bot_Minimizar.TabStop = False
        '
        'Barra_Login
        '
        Me.Barra_Login.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Barra_Login.Controls.Add(Me.Label1)
        Me.Barra_Login.Controls.Add(Me.bot_Fechar)
        Me.Barra_Login.Controls.Add(Me.bot_Minimizar)
        Me.Barra_Login.Controls.Add(Me.bot_Maximizar)
        Me.Barra_Login.Dock = System.Windows.Forms.DockStyle.Top
        Me.Barra_Login.Location = New System.Drawing.Point(0, 0)
        Me.Barra_Login.Name = "Barra_Login"
        Me.Barra_Login.Size = New System.Drawing.Size(1158, 61)
        Me.Barra_Login.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 23)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Login"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 61)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(613, 684)
        Me.Panel4.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Gálata.My.Resources.Resources.menu_128px
        Me.PictureBox1.Location = New System.Drawing.Point(28, 104)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 128)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(363, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(130, 43)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Estoque"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(174, 139)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(297, 93)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Gálata"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.bot_senha)
        Me.Panel1.Controls.Add(Me.txt_Usuário)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.txt_Senha)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(613, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(545, 497)
        Me.Panel1.TabIndex = 8
        '
        'bot_senha
        '
        Me.bot_senha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.bot_senha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_senha.Image = Global.Gálata.My.Resources.Resources.olho_32px
        Me.bot_senha.Location = New System.Drawing.Point(433, 265)
        Me.bot_senha.Name = "bot_senha"
        Me.bot_senha.Size = New System.Drawing.Size(32, 32)
        Me.bot_senha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_senha.TabIndex = 5
        Me.bot_senha.TabStop = False
        '
        'txt_Usuário
        '
        Me.txt_Usuário.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Usuário.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txt_Usuário.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Usuário.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_Usuário.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Usuário.Location = New System.Drawing.Point(236, 177)
        Me.txt_Usuário.Name = "txt_Usuário"
        Me.txt_Usuário.Size = New System.Drawing.Size(165, 34)
        Me.txt_Usuário.TabIndex = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox3.Image = Global.Gálata.My.Resources.Resources.padlock2_32px
        Me.PictureBox3.Location = New System.Drawing.Point(144, 263)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox3.TabIndex = 4
        Me.PictureBox3.TabStop = False
        '
        'txt_Senha
        '
        Me.txt_Senha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txt_Senha.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txt_Senha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_Senha.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txt_Senha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txt_Senha.Location = New System.Drawing.Point(236, 263)
        Me.txt_Senha.Name = "txt_Senha"
        Me.txt_Senha.Size = New System.Drawing.Size(165, 34)
        Me.txt_Senha.TabIndex = 2
        Me.txt_Senha.UseSystemPasswordChar = True
        '
        'PictureBox4
        '
        Me.PictureBox4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.PictureBox4.Image = Global.Gálata.My.Resources.Resources.user2_32px
        Me.PictureBox4.Location = New System.Drawing.Point(144, 177)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'bot_Entrar
        '
        Me.bot_Entrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_Entrar.Dock = System.Windows.Forms.DockStyle.Top
        Me.bot_Entrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bot_Entrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bot_Entrar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bot_Entrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bot_Entrar.Location = New System.Drawing.Point(613, 558)
        Me.bot_Entrar.Name = "bot_Entrar"
        Me.bot_Entrar.Size = New System.Drawing.Size(545, 49)
        Me.bot_Entrar.TabIndex = 9
        Me.bot_Entrar.Text = "Entrar"
        Me.bot_Entrar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 640)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 30)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Versão: 1.5.1"
        '
        'form_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1158, 745)
        Me.Controls.Add(Me.bot_Entrar)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Barra_Login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form_Login"
        CType(Me.bot_Fechar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_Maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Barra_Login.ResumeLayout(False)
        Me.Barra_Login.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.bot_senha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bot_Fechar As PictureBox
    Friend WithEvents bot_Maximizar As PictureBox
    Friend WithEvents bot_Minimizar As PictureBox
    Friend WithEvents Barra_Login As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txt_Usuário As TextBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents txt_Senha As TextBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents bot_Entrar As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bot_senha As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
