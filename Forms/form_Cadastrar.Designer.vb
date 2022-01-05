<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_Cadastrar
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Barra = New System.Windows.Forms.Panel()
        Me.bot_fecharCadastros = New System.Windows.Forms.PictureBox()
        Me.bot_MinimizarCadastros = New System.Windows.Forms.PictureBox()
        Me.bot_MaximizarCadastros = New System.Windows.Forms.PictureBox()
        Me.lab_TipoDeCadastro = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bot_fechar_estoque = New System.Windows.Forms.PictureBox()
        Me.bot_minimizar_estoque = New System.Windows.Forms.PictureBox()
        Me.bot_maximizar_estoque = New System.Windows.Forms.PictureBox()
        Me.bot_Fechar = New System.Windows.Forms.PictureBox()
        Me.bot_Minimizar = New System.Windows.Forms.PictureBox()
        Me.bot_Maximizar = New System.Windows.Forms.PictureBox()
        Me.Grid_Cadastrar = New System.Windows.Forms.DataGridView()
        Me.bot_search = New System.Windows.Forms.PictureBox()
        Me.txtbox_search = New System.Windows.Forms.TextBox()
        Me.box_cadastro = New System.Windows.Forms.TextBox()
        Me.lab_tituloCadastro = New System.Windows.Forms.Label()
        Me.bot_add = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.pic_tipo = New System.Windows.Forms.PictureBox()
        Me.box_cod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bot_incluirCadastrosJaRegistrados = New System.Windows.Forms.Button()
        Me.bot_reset = New System.Windows.Forms.Button()
        Me.Barra.SuspendLayout()
        CType(Me.bot_fecharCadastros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_MinimizarCadastros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_MaximizarCadastros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_fechar_estoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_minimizar_estoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_maximizar_estoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_Fechar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_Maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Grid_Cadastrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_search, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_add, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic_tipo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Barra
        '
        Me.Barra.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Barra.Controls.Add(Me.bot_fecharCadastros)
        Me.Barra.Controls.Add(Me.bot_MinimizarCadastros)
        Me.Barra.Controls.Add(Me.bot_MaximizarCadastros)
        Me.Barra.Controls.Add(Me.lab_TipoDeCadastro)
        Me.Barra.Controls.Add(Me.Label4)
        Me.Barra.Controls.Add(Me.bot_fechar_estoque)
        Me.Barra.Controls.Add(Me.bot_minimizar_estoque)
        Me.Barra.Controls.Add(Me.bot_maximizar_estoque)
        Me.Barra.Controls.Add(Me.bot_Fechar)
        Me.Barra.Controls.Add(Me.bot_Minimizar)
        Me.Barra.Controls.Add(Me.bot_Maximizar)
        Me.Barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.Barra.Location = New System.Drawing.Point(0, 0)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(1229, 57)
        Me.Barra.TabIndex = 9
        '
        'bot_fecharCadastros
        '
        Me.bot_fecharCadastros.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_fecharCadastros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_fecharCadastros.Image = Global.Gálata.My.Resources.Resources.close_24px
        Me.bot_fecharCadastros.Location = New System.Drawing.Point(1193, 12)
        Me.bot_fecharCadastros.Name = "bot_fecharCadastros"
        Me.bot_fecharCadastros.Size = New System.Drawing.Size(24, 24)
        Me.bot_fecharCadastros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_fecharCadastros.TabIndex = 19
        Me.bot_fecharCadastros.TabStop = False
        '
        'bot_MinimizarCadastros
        '
        Me.bot_MinimizarCadastros.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_MinimizarCadastros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_MinimizarCadastros.Image = Global.Gálata.My.Resources.Resources.minimizar2_24px
        Me.bot_MinimizarCadastros.Location = New System.Drawing.Point(1081, 12)
        Me.bot_MinimizarCadastros.Name = "bot_MinimizarCadastros"
        Me.bot_MinimizarCadastros.Size = New System.Drawing.Size(24, 24)
        Me.bot_MinimizarCadastros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_MinimizarCadastros.TabIndex = 17
        Me.bot_MinimizarCadastros.TabStop = False
        '
        'bot_MaximizarCadastros
        '
        Me.bot_MaximizarCadastros.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_MaximizarCadastros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_MaximizarCadastros.Image = Global.Gálata.My.Resources.Resources.maximizar_24px
        Me.bot_MaximizarCadastros.Location = New System.Drawing.Point(1137, 12)
        Me.bot_MaximizarCadastros.Name = "bot_MaximizarCadastros"
        Me.bot_MaximizarCadastros.Size = New System.Drawing.Size(24, 24)
        Me.bot_MaximizarCadastros.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_MaximizarCadastros.TabIndex = 18
        Me.bot_MaximizarCadastros.TabStop = False
        '
        'lab_TipoDeCadastro
        '
        Me.lab_TipoDeCadastro.AutoSize = True
        Me.lab_TipoDeCadastro.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lab_TipoDeCadastro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lab_TipoDeCadastro.Location = New System.Drawing.Point(127, 9)
        Me.lab_TipoDeCadastro.Name = "lab_TipoDeCadastro"
        Me.lab_TipoDeCadastro.Size = New System.Drawing.Size(109, 23)
        Me.lab_TipoDeCadastro.TabIndex = 16
        Me.lab_TipoDeCadastro.Text = "Cadastrar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 23)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Cadastrar"
        '
        'bot_fechar_estoque
        '
        Me.bot_fechar_estoque.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_fechar_estoque.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_fechar_estoque.Image = Global.Gálata.My.Resources.Resources.close_24px
        Me.bot_fechar_estoque.Location = New System.Drawing.Point(2176, -10)
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
        Me.bot_minimizar_estoque.Location = New System.Drawing.Point(2064, -10)
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
        Me.bot_maximizar_estoque.Location = New System.Drawing.Point(2120, -10)
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
        Me.bot_Fechar.Location = New System.Drawing.Point(3114, -27)
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
        Me.bot_Minimizar.Location = New System.Drawing.Point(3002, -27)
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
        Me.bot_Maximizar.Location = New System.Drawing.Point(3058, -27)
        Me.bot_Maximizar.Name = "bot_Maximizar"
        Me.bot_Maximizar.Size = New System.Drawing.Size(24, 24)
        Me.bot_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_Maximizar.TabIndex = 6
        Me.bot_Maximizar.TabStop = False
        '
        'Grid_Cadastrar
        '
        Me.Grid_Cadastrar.AllowUserToAddRows = False
        Me.Grid_Cadastrar.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid_Cadastrar.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Grid_Cadastrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Grid_Cadastrar.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Grid_Cadastrar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Grid_Cadastrar.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(77, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid_Cadastrar.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Grid_Cadastrar.ColumnHeadersHeight = 40
        Me.Grid_Cadastrar.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid_Cadastrar.DefaultCellStyle = DataGridViewCellStyle3
        Me.Grid_Cadastrar.Location = New System.Drawing.Point(227, 253)
        Me.Grid_Cadastrar.Name = "Grid_Cadastrar"
        Me.Grid_Cadastrar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(77, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid_Cadastrar.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Grid_Cadastrar.RowHeadersWidth = 51
        Me.Grid_Cadastrar.RowTemplate.Height = 29
        Me.Grid_Cadastrar.Size = New System.Drawing.Size(842, 386)
        Me.Grid_Cadastrar.TabIndex = 15
        '
        'bot_search
        '
        Me.bot_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.bot_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_search.Image = Global.Gálata.My.Resources.Resources.search_32px
        Me.bot_search.Location = New System.Drawing.Point(527, 201)
        Me.bot_search.Name = "bot_search"
        Me.bot_search.Size = New System.Drawing.Size(32, 32)
        Me.bot_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_search.TabIndex = 18
        Me.bot_search.TabStop = False
        Me.ToolTip1.SetToolTip(Me.bot_search, "Pesquisar")
        '
        'txtbox_search
        '
        Me.txtbox_search.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtbox_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtbox_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbox_search.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtbox_search.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_search.Location = New System.Drawing.Point(227, 208)
        Me.txtbox_search.Name = "txtbox_search"
        Me.txtbox_search.Size = New System.Drawing.Size(272, 25)
        Me.txtbox_search.TabIndex = 17
        '
        'box_cadastro
        '
        Me.box_cadastro.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.box_cadastro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.box_cadastro.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.box_cadastro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.box_cadastro.Location = New System.Drawing.Point(303, 116)
        Me.box_cadastro.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.box_cadastro.Name = "box_cadastro"
        Me.box_cadastro.Size = New System.Drawing.Size(702, 28)
        Me.box_cadastro.TabIndex = 28
        '
        'lab_tituloCadastro
        '
        Me.lab_tituloCadastro.AutoSize = True
        Me.lab_tituloCadastro.Font = New System.Drawing.Font("Bell MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lab_tituloCadastro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.lab_tituloCadastro.Location = New System.Drawing.Point(612, 79)
        Me.lab_tituloCadastro.Name = "lab_tituloCadastro"
        Me.lab_tituloCadastro.Size = New System.Drawing.Size(84, 22)
        Me.lab_tituloCadastro.TabIndex = 27
        Me.lab_tituloCadastro.Text = "Descrição"
        '
        'bot_add
        '
        Me.bot_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_add.Image = Global.Gálata.My.Resources.Resources.add_32px
        Me.bot_add.Location = New System.Drawing.Point(1037, 116)
        Me.bot_add.Name = "bot_add"
        Me.bot_add.Size = New System.Drawing.Size(32, 32)
        Me.bot_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_add.TabIndex = 29
        Me.bot_add.TabStop = False
        Me.ToolTip1.SetToolTip(Me.bot_add, "Adiconar")
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 1000
        Me.ToolTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ToolTip1.ForeColor = System.Drawing.Color.Black
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 50
        '
        'pic_tipo
        '
        Me.pic_tipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pic_tipo.Image = Global.Gálata.My.Resources.Resources.team_64px
        Me.pic_tipo.Location = New System.Drawing.Point(12, 63)
        Me.pic_tipo.Name = "pic_tipo"
        Me.pic_tipo.Size = New System.Drawing.Size(64, 64)
        Me.pic_tipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pic_tipo.TabIndex = 29
        Me.pic_tipo.TabStop = False
        '
        'box_cod
        '
        Me.box_cod.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.box_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.box_cod.Enabled = False
        Me.box_cod.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.box_cod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.box_cod.Location = New System.Drawing.Point(176, 116)
        Me.box_cod.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.box_cod.Name = "box_cod"
        Me.box_cod.Size = New System.Drawing.Size(83, 28)
        Me.box_cod.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(15, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(196, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 22)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "Cod"
        '
        'bot_incluirCadastrosJaRegistrados
        '
        Me.bot_incluirCadastrosJaRegistrados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_incluirCadastrosJaRegistrados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bot_incluirCadastrosJaRegistrados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.bot_incluirCadastrosJaRegistrados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.bot_incluirCadastrosJaRegistrados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bot_incluirCadastrosJaRegistrados.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bot_incluirCadastrosJaRegistrados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.bot_incluirCadastrosJaRegistrados.Image = Global.Gálata.My.Resources.Resources._32_px_down_arrow
        Me.bot_incluirCadastrosJaRegistrados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bot_incluirCadastrosJaRegistrados.Location = New System.Drawing.Point(27, 253)
        Me.bot_incluirCadastrosJaRegistrados.Name = "bot_incluirCadastrosJaRegistrados"
        Me.bot_incluirCadastrosJaRegistrados.Size = New System.Drawing.Size(181, 92)
        Me.bot_incluirCadastrosJaRegistrados.TabIndex = 31
        Me.bot_incluirCadastrosJaRegistrados.Text = "Transformar Itens Registrados em Cadastros"
        Me.bot_incluirCadastrosJaRegistrados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bot_incluirCadastrosJaRegistrados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bot_incluirCadastrosJaRegistrados.UseVisualStyleBackColor = True
        '
        'bot_reset
        '
        Me.bot_reset.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_reset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bot_reset.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.bot_reset.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.bot_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bot_reset.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bot_reset.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.bot_reset.Image = Global.Gálata.My.Resources.Resources._32px_reset
        Me.bot_reset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bot_reset.Location = New System.Drawing.Point(27, 370)
        Me.bot_reset.Name = "bot_reset"
        Me.bot_reset.Size = New System.Drawing.Size(181, 60)
        Me.bot_reset.TabIndex = 31
        Me.bot_reset.Text = "Resetar Cadastro"
        Me.bot_reset.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bot_reset.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bot_reset.UseVisualStyleBackColor = True
        '
        'form_Cadastrar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1229, 672)
        Me.Controls.Add(Me.bot_reset)
        Me.Controls.Add(Me.bot_incluirCadastrosJaRegistrados)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pic_tipo)
        Me.Controls.Add(Me.bot_add)
        Me.Controls.Add(Me.box_cod)
        Me.Controls.Add(Me.box_cadastro)
        Me.Controls.Add(Me.lab_tituloCadastro)
        Me.Controls.Add(Me.bot_search)
        Me.Controls.Add(Me.txtbox_search)
        Me.Controls.Add(Me.Grid_Cadastrar)
        Me.Controls.Add(Me.Barra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "form_Cadastrar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form_Cadastrar"
        Me.Barra.ResumeLayout(False)
        Me.Barra.PerformLayout()
        CType(Me.bot_fecharCadastros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_MinimizarCadastros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_MaximizarCadastros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_fechar_estoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_minimizar_estoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_maximizar_estoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_Fechar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_Maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Grid_Cadastrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_search, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_add, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic_tipo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Barra As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents bot_fechar_estoque As PictureBox
    Friend WithEvents bot_minimizar_estoque As PictureBox
    Friend WithEvents bot_maximizar_estoque As PictureBox
    Friend WithEvents bot_Fechar As PictureBox
    Friend WithEvents bot_Minimizar As PictureBox
    Friend WithEvents bot_Maximizar As PictureBox
    Friend WithEvents lab_TipoDeCadastro As Label
    Friend WithEvents bot_fecharCadastros As PictureBox
    Friend WithEvents bot_MinimizarCadastros As PictureBox
    Friend WithEvents bot_MaximizarCadastros As PictureBox
    Friend WithEvents Grid_Cadastrar As DataGridView
    Friend WithEvents bot_search As PictureBox
    Friend WithEvents txtbox_search As TextBox
    Friend WithEvents box_cadastro As TextBox
    Friend WithEvents lab_tituloCadastro As Label
    Friend WithEvents bot_add As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents pic_tipo As PictureBox
    Friend WithEvents box_cod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bot_incluirCadastrosJaRegistrados As Button
    Friend WithEvents bot_reset As Button
End Class
