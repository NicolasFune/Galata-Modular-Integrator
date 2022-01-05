<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_NovaSaída
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_NovaSaída))
        Me.Barra_Padrão = New System.Windows.Forms.Panel()
        Me.lab_tipoSaída = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bot_Fechar_Padrão = New System.Windows.Forms.PictureBox()
        Me.bot_Minimizar_Padrão = New System.Windows.Forms.PictureBox()
        Me.bot_Maximizar_Padrão = New System.Windows.Forms.PictureBox()
        Me.bot_fechar_estoque = New System.Windows.Forms.PictureBox()
        Me.bot_minimizar_estoque = New System.Windows.Forms.PictureBox()
        Me.bot_maximizar_estoque = New System.Windows.Forms.PictureBox()
        Me.bot_Fechar = New System.Windows.Forms.PictureBox()
        Me.bot_Minimizar = New System.Windows.Forms.PictureBox()
        Me.bot_Maximizar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lab_codOrigem = New System.Windows.Forms.Label()
        Me.lab_Descrição = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.box_os = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bot_NovaSaída = New System.Windows.Forms.PictureBox()
        Me.lab_cus = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lab_qua = New System.Windows.Forms.Label()
        Me.lab_pes = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Requisição = New System.Windows.Forms.Label()
        Me.box_req = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.box_data = New System.Windows.Forms.DateTimePicker()
        Me.box_qua = New System.Windows.Forms.NumericUpDown()
        Me.box_equ = New System.Windows.Forms.ComboBox()
        Me.Barra_Padrão.SuspendLayout()
        CType(Me.bot_Fechar_Padrão, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_Minimizar_Padrão, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_Maximizar_Padrão, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_fechar_estoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_minimizar_estoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_maximizar_estoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_Fechar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_Maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_NovaSaída, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.box_qua, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Barra_Padrão
        '
        Me.Barra_Padrão.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Barra_Padrão.Controls.Add(Me.lab_tipoSaída)
        Me.Barra_Padrão.Controls.Add(Me.Label5)
        Me.Barra_Padrão.Controls.Add(Me.bot_Fechar_Padrão)
        Me.Barra_Padrão.Controls.Add(Me.bot_Minimizar_Padrão)
        Me.Barra_Padrão.Controls.Add(Me.bot_Maximizar_Padrão)
        Me.Barra_Padrão.Controls.Add(Me.bot_fechar_estoque)
        Me.Barra_Padrão.Controls.Add(Me.bot_minimizar_estoque)
        Me.Barra_Padrão.Controls.Add(Me.bot_maximizar_estoque)
        Me.Barra_Padrão.Controls.Add(Me.bot_Fechar)
        Me.Barra_Padrão.Controls.Add(Me.bot_Minimizar)
        Me.Barra_Padrão.Controls.Add(Me.bot_Maximizar)
        Me.Barra_Padrão.Dock = System.Windows.Forms.DockStyle.Top
        Me.Barra_Padrão.Location = New System.Drawing.Point(0, 0)
        Me.Barra_Padrão.Name = "Barra_Padrão"
        Me.Barra_Padrão.Size = New System.Drawing.Size(1014, 57)
        Me.Barra_Padrão.TabIndex = 9
        '
        'lab_tipoSaída
        '
        Me.lab_tipoSaída.AutoSize = True
        Me.lab_tipoSaída.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lab_tipoSaída.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lab_tipoSaída.Location = New System.Drawing.Point(155, 9)
        Me.lab_tipoSaída.Name = "lab_tipoSaída"
        Me.lab_tipoSaída.Size = New System.Drawing.Size(147, 23)
        Me.lab_tipoSaída.TabIndex = 16
        Me.lab_tipoSaída.Text = "Nova Saída - "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(12, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(147, 23)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Nova Saída - "
        '
        'bot_Fechar_Padrão
        '
        Me.bot_Fechar_Padrão.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_Fechar_Padrão.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_Fechar_Padrão.Image = Global.Gálata.My.Resources.Resources.close_24px
        Me.bot_Fechar_Padrão.Location = New System.Drawing.Point(978, 12)
        Me.bot_Fechar_Padrão.Name = "bot_Fechar_Padrão"
        Me.bot_Fechar_Padrão.Size = New System.Drawing.Size(24, 24)
        Me.bot_Fechar_Padrão.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_Fechar_Padrão.TabIndex = 13
        Me.bot_Fechar_Padrão.TabStop = False
        '
        'bot_Minimizar_Padrão
        '
        Me.bot_Minimizar_Padrão.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_Minimizar_Padrão.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_Minimizar_Padrão.Image = Global.Gálata.My.Resources.Resources.minimizar2_24px
        Me.bot_Minimizar_Padrão.Location = New System.Drawing.Point(866, 12)
        Me.bot_Minimizar_Padrão.Name = "bot_Minimizar_Padrão"
        Me.bot_Minimizar_Padrão.Size = New System.Drawing.Size(24, 24)
        Me.bot_Minimizar_Padrão.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_Minimizar_Padrão.TabIndex = 11
        Me.bot_Minimizar_Padrão.TabStop = False
        '
        'bot_Maximizar_Padrão
        '
        Me.bot_Maximizar_Padrão.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_Maximizar_Padrão.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_Maximizar_Padrão.Image = Global.Gálata.My.Resources.Resources.maximizar_24px
        Me.bot_Maximizar_Padrão.Location = New System.Drawing.Point(922, 12)
        Me.bot_Maximizar_Padrão.Name = "bot_Maximizar_Padrão"
        Me.bot_Maximizar_Padrão.Size = New System.Drawing.Size(24, 24)
        Me.bot_Maximizar_Padrão.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_Maximizar_Padrão.TabIndex = 12
        Me.bot_Maximizar_Padrão.TabStop = False
        '
        'bot_fechar_estoque
        '
        Me.bot_fechar_estoque.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_fechar_estoque.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_fechar_estoque.Image = Global.Gálata.My.Resources.Resources.close_24px
        Me.bot_fechar_estoque.Location = New System.Drawing.Point(1961, -10)
        Me.bot_fechar_estoque.Name = "bot_fechar_estoque"
        Me.bot_fechar_estoque.Size = New System.Drawing.Size(24, 24)
        Me.bot_fechar_estoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_fechar_estoque.TabIndex = 10
        Me.bot_fechar_estoque.TabStop = False
        '
        'bot_minimizar_estoque
        '
        Me.bot_minimizar_estoque.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_minimizar_estoque.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_minimizar_estoque.Image = Global.Gálata.My.Resources.Resources.minimizar2_24px
        Me.bot_minimizar_estoque.Location = New System.Drawing.Point(1849, -10)
        Me.bot_minimizar_estoque.Name = "bot_minimizar_estoque"
        Me.bot_minimizar_estoque.Size = New System.Drawing.Size(24, 24)
        Me.bot_minimizar_estoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_minimizar_estoque.TabIndex = 8
        Me.bot_minimizar_estoque.TabStop = False
        '
        'bot_maximizar_estoque
        '
        Me.bot_maximizar_estoque.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_maximizar_estoque.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_maximizar_estoque.Image = Global.Gálata.My.Resources.Resources.maximizar_24px
        Me.bot_maximizar_estoque.Location = New System.Drawing.Point(1905, -10)
        Me.bot_maximizar_estoque.Name = "bot_maximizar_estoque"
        Me.bot_maximizar_estoque.Size = New System.Drawing.Size(24, 24)
        Me.bot_maximizar_estoque.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_maximizar_estoque.TabIndex = 9
        Me.bot_maximizar_estoque.TabStop = False
        '
        'bot_Fechar
        '
        Me.bot_Fechar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_Fechar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_Fechar.Image = Global.Gálata.My.Resources.Resources.close_24px
        Me.bot_Fechar.Location = New System.Drawing.Point(2899, -27)
        Me.bot_Fechar.Name = "bot_Fechar"
        Me.bot_Fechar.Size = New System.Drawing.Size(24, 24)
        Me.bot_Fechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_Fechar.TabIndex = 7
        Me.bot_Fechar.TabStop = False
        '
        'bot_Minimizar
        '
        Me.bot_Minimizar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_Minimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_Minimizar.Image = Global.Gálata.My.Resources.Resources.minimizar2_24px
        Me.bot_Minimizar.Location = New System.Drawing.Point(2787, -27)
        Me.bot_Minimizar.Name = "bot_Minimizar"
        Me.bot_Minimizar.Size = New System.Drawing.Size(24, 24)
        Me.bot_Minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_Minimizar.TabIndex = 5
        Me.bot_Minimizar.TabStop = False
        '
        'bot_Maximizar
        '
        Me.bot_Maximizar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_Maximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_Maximizar.Image = Global.Gálata.My.Resources.Resources.maximizar_24px
        Me.bot_Maximizar.Location = New System.Drawing.Point(2843, -27)
        Me.bot_Maximizar.Name = "bot_Maximizar"
        Me.bot_Maximizar.Size = New System.Drawing.Size(24, 24)
        Me.bot_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_Maximizar.TabIndex = 6
        Me.bot_Maximizar.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(59, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 23)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Código de Origem"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(448, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 23)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Descrição"
        '
        'lab_codOrigem
        '
        Me.lab_codOrigem.AutoSize = True
        Me.lab_codOrigem.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lab_codOrigem.ForeColor = System.Drawing.Color.White
        Me.lab_codOrigem.Location = New System.Drawing.Point(59, 148)
        Me.lab_codOrigem.Name = "lab_codOrigem"
        Me.lab_codOrigem.Size = New System.Drawing.Size(159, 20)
        Me.lab_codOrigem.TabIndex = 12
        Me.lab_codOrigem.Text = "Código de Origem"
        '
        'lab_Descrição
        '
        Me.lab_Descrição.AutoSize = True
        Me.lab_Descrição.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lab_Descrição.ForeColor = System.Drawing.Color.White
        Me.lab_Descrição.Location = New System.Drawing.Point(434, 148)
        Me.lab_Descrição.Name = "lab_Descrição"
        Me.lab_Descrição.Size = New System.Drawing.Size(159, 20)
        Me.lab_Descrição.TabIndex = 13
        Me.lab_Descrição.Text = "Código de Origem"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(37, 376)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(284, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Para qua OS irá estes itens?"
        '
        'box_os
        '
        Me.box_os.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.box_os.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.box_os.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.box_os.ForeColor = System.Drawing.Color.White
        Me.box_os.FormattingEnabled = True
        Me.box_os.Location = New System.Drawing.Point(96, 430)
        Me.box_os.Name = "box_os"
        Me.box_os.Size = New System.Drawing.Size(151, 25)
        Me.box_os.TabIndex = 15
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(366, 376)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 23)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Quantidade (Uni)"
        '
        'bot_NovaSaída
        '
        Me.bot_NovaSaída.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bot_NovaSaída.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_NovaSaída.Image = Global.Gálata.My.Resources.Resources.saida2_32px
        Me.bot_NovaSaída.Location = New System.Drawing.Point(955, 568)
        Me.bot_NovaSaída.Name = "bot_NovaSaída"
        Me.bot_NovaSaída.Size = New System.Drawing.Size(32, 32)
        Me.bot_NovaSaída.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_NovaSaída.TabIndex = 18
        Me.bot_NovaSaída.TabStop = False
        '
        'lab_cus
        '
        Me.lab_cus.AutoSize = True
        Me.lab_cus.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lab_cus.ForeColor = System.Drawing.Color.White
        Me.lab_cus.Location = New System.Drawing.Point(822, 148)
        Me.lab_cus.Name = "lab_cus"
        Me.lab_cus.Size = New System.Drawing.Size(159, 20)
        Me.lab_cus.TabIndex = 20
        Me.lab_cus.Text = "Código de Origem"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(836, 86)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 23)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Custo"
        '
        'lab_qua
        '
        Me.lab_qua.AutoSize = True
        Me.lab_qua.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lab_qua.ForeColor = System.Drawing.Color.White
        Me.lab_qua.Location = New System.Drawing.Point(490, 290)
        Me.lab_qua.Name = "lab_qua"
        Me.lab_qua.Size = New System.Drawing.Size(159, 20)
        Me.lab_qua.TabIndex = 24
        Me.lab_qua.Text = "Código de Origem"
        '
        'lab_pes
        '
        Me.lab_pes.AutoSize = True
        Me.lab_pes.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lab_pes.ForeColor = System.Drawing.Color.White
        Me.lab_pes.Location = New System.Drawing.Point(59, 290)
        Me.lab_pes.Name = "lab_pes"
        Me.lab_pes.Size = New System.Drawing.Size(159, 20)
        Me.lab_pes.TabIndex = 23
        Me.lab_pes.Text = "Código de Origem"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(448, 228)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(244, 23)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "Quantidade em Estoque"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(59, 228)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(178, 23)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Peso em Estoque"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(626, 376)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 23)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Equipe"
        '
        'Requisição
        '
        Me.Requisição.AutoSize = True
        Me.Requisição.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Requisição.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Requisição.Location = New System.Drawing.Point(845, 376)
        Me.Requisição.Name = "Requisição"
        Me.Requisição.Size = New System.Drawing.Size(118, 23)
        Me.Requisição.TabIndex = 27
        Me.Requisição.Text = "Requisição"
        '
        'box_req
        '
        Me.box_req.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.box_req.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.box_req.Font = New System.Drawing.Font("Arial Rounded MT Bold", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.box_req.ForeColor = System.Drawing.Color.FromArgb(CType(CType(153, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.box_req.Location = New System.Drawing.Point(822, 420)
        Me.box_req.Name = "box_req"
        Me.box_req.Size = New System.Drawing.Size(165, 34)
        Me.box_req.TabIndex = 29
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(90, 501)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(146, 23)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Data da Saída"
        '
        'box_data
        '
        Me.box_data.CalendarFont = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.box_data.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.box_data.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.box_data.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.box_data.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.box_data.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.box_data.Cursor = System.Windows.Forms.Cursors.Hand
        Me.box_data.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.box_data.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.box_data.Location = New System.Drawing.Point(90, 556)
        Me.box_data.Name = "box_data"
        Me.box_data.Size = New System.Drawing.Size(140, 27)
        Me.box_data.TabIndex = 32
        '
        'box_qua
        '
        Me.box_qua.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.box_qua.Cursor = System.Windows.Forms.Cursors.Hand
        Me.box_qua.DecimalPlaces = 2
        Me.box_qua.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.box_qua.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.box_qua.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.box_qua.Location = New System.Drawing.Point(401, 427)
        Me.box_qua.Name = "box_qua"
        Me.box_qua.Size = New System.Drawing.Size(140, 27)
        Me.box_qua.TabIndex = 33
        Me.box_qua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.box_qua.ThousandsSeparator = True
        '
        'box_equ
        '
        Me.box_equ.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.box_equ.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.box_equ.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.box_equ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.box_equ.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.box_equ.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.box_equ.FormattingEnabled = True
        Me.box_equ.Location = New System.Drawing.Point(594, 427)
        Me.box_equ.MaxDropDownItems = 5
        Me.box_equ.Name = "box_equ"
        Me.box_equ.Size = New System.Drawing.Size(165, 28)
        Me.box_equ.TabIndex = 34
        '
        'form_NovaSaída
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1014, 612)
        Me.Controls.Add(Me.box_equ)
        Me.Controls.Add(Me.box_qua)
        Me.Controls.Add(Me.box_data)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.box_req)
        Me.Controls.Add(Me.Requisição)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lab_qua)
        Me.Controls.Add(Me.lab_pes)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lab_cus)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.bot_NovaSaída)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.box_os)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lab_Descrição)
        Me.Controls.Add(Me.lab_codOrigem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Barra_Padrão)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_NovaSaída"
        Me.Text = "form_NovaSaída"
        Me.Barra_Padrão.ResumeLayout(False)
        Me.Barra_Padrão.PerformLayout()
        CType(Me.bot_Fechar_Padrão, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_Minimizar_Padrão, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_Maximizar_Padrão, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_fechar_estoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_minimizar_estoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_maximizar_estoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_Fechar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_Maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_NovaSaída, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.box_qua, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Barra_Padrão As Panel
    Friend WithEvents bot_fechar_estoque As PictureBox
    Friend WithEvents bot_minimizar_estoque As PictureBox
    Friend WithEvents bot_maximizar_estoque As PictureBox
    Friend WithEvents bot_Fechar As PictureBox
    Friend WithEvents bot_Minimizar As PictureBox
    Friend WithEvents bot_Maximizar As PictureBox
    Friend WithEvents bot_Fechar_Padrão As PictureBox
    Friend WithEvents bot_Minimizar_Padrão As PictureBox
    Friend WithEvents bot_Maximizar_Padrão As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lab_codOrigem As Label
    Friend WithEvents lab_Descrição As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents box_os As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents bot_NovaSaída As PictureBox
    Friend WithEvents lab_cus As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lab_qua As Label
    Friend WithEvents lab_pes As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents lab_tipoSaída As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Requisição As Label
    Friend WithEvents box_req As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents box_data As DateTimePicker
    Friend WithEvents box_qua As NumericUpDown
    Friend WithEvents box_equ As ComboBox
End Class
