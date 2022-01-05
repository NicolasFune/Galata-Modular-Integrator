<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_RegistrosEntradas
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_RegistrosEntradas))
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Barra_RegistrosEntradas = New System.Windows.Forms.Panel()
        Me.bot_fecharRegistrosEntradas = New System.Windows.Forms.PictureBox()
        Me.bot_minimizarRegistrosEntradas = New System.Windows.Forms.PictureBox()
        Me.bot_maximizarRegistrosEntradas = New System.Windows.Forms.PictureBox()
        Me.bot_fecharRegistrosSaídas = New System.Windows.Forms.PictureBox()
        Me.bot_minimizarRegistrosSaídas = New System.Windows.Forms.PictureBox()
        Me.bot_maximizarRegistrosSaídas = New System.Windows.Forms.PictureBox()
        Me.bot_Fechar_Padrão = New System.Windows.Forms.PictureBox()
        Me.bot_Minimizar_Padrão = New System.Windows.Forms.PictureBox()
        Me.bot_Maximizar_Padrão = New System.Windows.Forms.PictureBox()
        Me.bot_fechar_estoque = New System.Windows.Forms.PictureBox()
        Me.bot_minimizar_estoque = New System.Windows.Forms.PictureBox()
        Me.bot_maximizar_estoque = New System.Windows.Forms.PictureBox()
        Me.bot_Fechar = New System.Windows.Forms.PictureBox()
        Me.bot_Minimizar = New System.Windows.Forms.PictureBox()
        Me.bot_Maximizar = New System.Windows.Forms.PictureBox()
        Me.bot_consumíveisEntradas = New System.Windows.Forms.Button()
        Me.bot_matpriEntradas = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.bot_deletar = New System.Windows.Forms.Button()
        Me.bot_editar = New System.Windows.Forms.Button()
        Me.box_cod = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.combobox_ColunasFiltro = New System.Windows.Forms.ComboBox()
        Me.bot_search = New System.Windows.Forms.PictureBox()
        Me.txtbox_search = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Grid_RegistrosEntradas = New System.Windows.Forms.DataGridView()
        Me.bot_NovaSaída = New System.Windows.Forms.PictureBox()
        Me.Barra_RegistrosEntradas.SuspendLayout()
        CType(Me.bot_fecharRegistrosEntradas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_minimizarRegistrosEntradas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_maximizarRegistrosEntradas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_fecharRegistrosSaídas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_minimizarRegistrosSaídas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_maximizarRegistrosSaídas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_Fechar_Padrão, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_Minimizar_Padrão, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_Maximizar_Padrão, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_fechar_estoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_minimizar_estoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_maximizar_estoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_Fechar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_Maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.bot_search, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.Grid_RegistrosEntradas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_NovaSaída, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 23)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Entradas"
        '
        'Barra_RegistrosEntradas
        '
        Me.Barra_RegistrosEntradas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Barra_RegistrosEntradas.Controls.Add(Me.bot_fecharRegistrosEntradas)
        Me.Barra_RegistrosEntradas.Controls.Add(Me.bot_minimizarRegistrosEntradas)
        Me.Barra_RegistrosEntradas.Controls.Add(Me.bot_maximizarRegistrosEntradas)
        Me.Barra_RegistrosEntradas.Controls.Add(Me.Label4)
        Me.Barra_RegistrosEntradas.Controls.Add(Me.bot_fecharRegistrosSaídas)
        Me.Barra_RegistrosEntradas.Controls.Add(Me.bot_minimizarRegistrosSaídas)
        Me.Barra_RegistrosEntradas.Controls.Add(Me.bot_maximizarRegistrosSaídas)
        Me.Barra_RegistrosEntradas.Controls.Add(Me.bot_Fechar_Padrão)
        Me.Barra_RegistrosEntradas.Controls.Add(Me.bot_Minimizar_Padrão)
        Me.Barra_RegistrosEntradas.Controls.Add(Me.bot_Maximizar_Padrão)
        Me.Barra_RegistrosEntradas.Controls.Add(Me.bot_fechar_estoque)
        Me.Barra_RegistrosEntradas.Controls.Add(Me.bot_minimizar_estoque)
        Me.Barra_RegistrosEntradas.Controls.Add(Me.bot_maximizar_estoque)
        Me.Barra_RegistrosEntradas.Controls.Add(Me.bot_Fechar)
        Me.Barra_RegistrosEntradas.Controls.Add(Me.bot_Minimizar)
        Me.Barra_RegistrosEntradas.Controls.Add(Me.bot_Maximizar)
        Me.Barra_RegistrosEntradas.Dock = System.Windows.Forms.DockStyle.Top
        Me.Barra_RegistrosEntradas.Location = New System.Drawing.Point(0, 0)
        Me.Barra_RegistrosEntradas.Name = "Barra_RegistrosEntradas"
        Me.Barra_RegistrosEntradas.Size = New System.Drawing.Size(1551, 57)
        Me.Barra_RegistrosEntradas.TabIndex = 11
        '
        'bot_fecharRegistrosEntradas
        '
        Me.bot_fecharRegistrosEntradas.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_fecharRegistrosEntradas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_fecharRegistrosEntradas.Image = Global.Gálata.My.Resources.Resources.close_24px
        Me.bot_fecharRegistrosEntradas.Location = New System.Drawing.Point(1515, 12)
        Me.bot_fecharRegistrosEntradas.Name = "bot_fecharRegistrosEntradas"
        Me.bot_fecharRegistrosEntradas.Size = New System.Drawing.Size(24, 24)
        Me.bot_fecharRegistrosEntradas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_fecharRegistrosEntradas.TabIndex = 20
        Me.bot_fecharRegistrosEntradas.TabStop = False
        '
        'bot_minimizarRegistrosEntradas
        '
        Me.bot_minimizarRegistrosEntradas.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_minimizarRegistrosEntradas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_minimizarRegistrosEntradas.Image = Global.Gálata.My.Resources.Resources.minimizar2_24px
        Me.bot_minimizarRegistrosEntradas.Location = New System.Drawing.Point(1403, 12)
        Me.bot_minimizarRegistrosEntradas.Name = "bot_minimizarRegistrosEntradas"
        Me.bot_minimizarRegistrosEntradas.Size = New System.Drawing.Size(24, 24)
        Me.bot_minimizarRegistrosEntradas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_minimizarRegistrosEntradas.TabIndex = 18
        Me.bot_minimizarRegistrosEntradas.TabStop = False
        '
        'bot_maximizarRegistrosEntradas
        '
        Me.bot_maximizarRegistrosEntradas.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_maximizarRegistrosEntradas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_maximizarRegistrosEntradas.Image = Global.Gálata.My.Resources.Resources.maximizar_24px
        Me.bot_maximizarRegistrosEntradas.Location = New System.Drawing.Point(1459, 12)
        Me.bot_maximizarRegistrosEntradas.Name = "bot_maximizarRegistrosEntradas"
        Me.bot_maximizarRegistrosEntradas.Size = New System.Drawing.Size(24, 24)
        Me.bot_maximizarRegistrosEntradas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_maximizarRegistrosEntradas.TabIndex = 19
        Me.bot_maximizarRegistrosEntradas.TabStop = False
        '
        'bot_fecharRegistrosSaídas
        '
        Me.bot_fecharRegistrosSaídas.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_fecharRegistrosSaídas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_fecharRegistrosSaídas.Image = Global.Gálata.My.Resources.Resources.close_24px
        Me.bot_fecharRegistrosSaídas.Location = New System.Drawing.Point(2556, -10)
        Me.bot_fecharRegistrosSaídas.Name = "bot_fecharRegistrosSaídas"
        Me.bot_fecharRegistrosSaídas.Size = New System.Drawing.Size(24, 24)
        Me.bot_fecharRegistrosSaídas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_fecharRegistrosSaídas.TabIndex = 16
        Me.bot_fecharRegistrosSaídas.TabStop = False
        '
        'bot_minimizarRegistrosSaídas
        '
        Me.bot_minimizarRegistrosSaídas.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_minimizarRegistrosSaídas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_minimizarRegistrosSaídas.Image = Global.Gálata.My.Resources.Resources.minimizar2_24px
        Me.bot_minimizarRegistrosSaídas.Location = New System.Drawing.Point(2444, -10)
        Me.bot_minimizarRegistrosSaídas.Name = "bot_minimizarRegistrosSaídas"
        Me.bot_minimizarRegistrosSaídas.Size = New System.Drawing.Size(24, 24)
        Me.bot_minimizarRegistrosSaídas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_minimizarRegistrosSaídas.TabIndex = 14
        Me.bot_minimizarRegistrosSaídas.TabStop = False
        '
        'bot_maximizarRegistrosSaídas
        '
        Me.bot_maximizarRegistrosSaídas.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_maximizarRegistrosSaídas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_maximizarRegistrosSaídas.Image = Global.Gálata.My.Resources.Resources.maximizar_24px
        Me.bot_maximizarRegistrosSaídas.Location = New System.Drawing.Point(2500, -10)
        Me.bot_maximizarRegistrosSaídas.Name = "bot_maximizarRegistrosSaídas"
        Me.bot_maximizarRegistrosSaídas.Size = New System.Drawing.Size(24, 24)
        Me.bot_maximizarRegistrosSaídas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_maximizarRegistrosSaídas.TabIndex = 15
        Me.bot_maximizarRegistrosSaídas.TabStop = False
        '
        'bot_Fechar_Padrão
        '
        Me.bot_Fechar_Padrão.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_Fechar_Padrão.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_Fechar_Padrão.Image = Global.Gálata.My.Resources.Resources.close_24px
        Me.bot_Fechar_Padrão.Location = New System.Drawing.Point(3234, -32)
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
        Me.bot_Minimizar_Padrão.Location = New System.Drawing.Point(3122, -32)
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
        Me.bot_Maximizar_Padrão.Location = New System.Drawing.Point(3178, -32)
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
        Me.bot_fechar_estoque.Location = New System.Drawing.Point(4217, -54)
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
        Me.bot_minimizar_estoque.Location = New System.Drawing.Point(4105, -54)
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
        Me.bot_maximizar_estoque.Location = New System.Drawing.Point(4161, -54)
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
        Me.bot_Fechar.Location = New System.Drawing.Point(5155, -71)
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
        Me.bot_Minimizar.Location = New System.Drawing.Point(5043, -71)
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
        Me.bot_Maximizar.Location = New System.Drawing.Point(5099, -71)
        Me.bot_Maximizar.Name = "bot_Maximizar"
        Me.bot_Maximizar.Size = New System.Drawing.Size(24, 24)
        Me.bot_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_Maximizar.TabIndex = 6
        Me.bot_Maximizar.TabStop = False
        '
        'bot_consumíveisEntradas
        '
        Me.bot_consumíveisEntradas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_consumíveisEntradas.Dock = System.Windows.Forms.DockStyle.Left
        Me.bot_consumíveisEntradas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bot_consumíveisEntradas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.bot_consumíveisEntradas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.bot_consumíveisEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bot_consumíveisEntradas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bot_consumíveisEntradas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.bot_consumíveisEntradas.Image = Global.Gálata.My.Resources.Resources.weld_32px1
        Me.bot_consumíveisEntradas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bot_consumíveisEntradas.Location = New System.Drawing.Point(121, 0)
        Me.bot_consumíveisEntradas.Name = "bot_consumíveisEntradas"
        Me.bot_consumíveisEntradas.Size = New System.Drawing.Size(144, 60)
        Me.bot_consumíveisEntradas.TabIndex = 1
        Me.bot_consumíveisEntradas.Text = "Consumíveis"
        Me.bot_consumíveisEntradas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bot_consumíveisEntradas.UseVisualStyleBackColor = True
        '
        'bot_matpriEntradas
        '
        Me.bot_matpriEntradas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_matpriEntradas.Dock = System.Windows.Forms.DockStyle.Left
        Me.bot_matpriEntradas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bot_matpriEntradas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.bot_matpriEntradas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.bot_matpriEntradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bot_matpriEntradas.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bot_matpriEntradas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.bot_matpriEntradas.Image = Global.Gálata.My.Resources.Resources.matéria_prima_32px
        Me.bot_matpriEntradas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bot_matpriEntradas.Location = New System.Drawing.Point(0, 0)
        Me.bot_matpriEntradas.Name = "bot_matpriEntradas"
        Me.bot_matpriEntradas.Size = New System.Drawing.Size(121, 60)
        Me.bot_matpriEntradas.TabIndex = 0
        Me.bot_matpriEntradas.Text = "Matéria Prima"
        Me.bot_matpriEntradas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bot_matpriEntradas.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel4.Controls.Add(Me.bot_NovaSaída)
        Me.Panel4.Controls.Add(Me.bot_deletar)
        Me.Panel4.Controls.Add(Me.bot_editar)
        Me.Panel4.Controls.Add(Me.bot_consumíveisEntradas)
        Me.Panel4.Controls.Add(Me.bot_matpriEntradas)
        Me.Panel4.Controls.Add(Me.box_cod)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 57)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1551, 60)
        Me.Panel4.TabIndex = 17
        '
        'bot_deletar
        '
        Me.bot_deletar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_deletar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bot_deletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.bot_deletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.bot_deletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bot_deletar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bot_deletar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.bot_deletar.Image = Global.Gálata.My.Resources.Resources.delete_24px
        Me.bot_deletar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bot_deletar.Location = New System.Drawing.Point(918, 0)
        Me.bot_deletar.Name = "bot_deletar"
        Me.bot_deletar.Size = New System.Drawing.Size(164, 60)
        Me.bot_deletar.TabIndex = 19
        Me.bot_deletar.Text = "Deletar Entrada"
        Me.bot_deletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bot_deletar.UseVisualStyleBackColor = True
        '
        'bot_editar
        '
        Me.bot_editar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_editar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(77, Byte), Integer))
        Me.bot_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.bot_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.bot_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bot_editar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bot_editar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.bot_editar.Image = Global.Gálata.My.Resources.Resources.edit_24px
        Me.bot_editar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bot_editar.Location = New System.Drawing.Point(720, 0)
        Me.bot_editar.Name = "bot_editar"
        Me.bot_editar.Size = New System.Drawing.Size(174, 60)
        Me.bot_editar.TabIndex = 18
        Me.bot_editar.Text = "Editar Entrada"
        Me.bot_editar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bot_editar.UseVisualStyleBackColor = True
        '
        'box_cod
        '
        Me.box_cod.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.box_cod.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.box_cod.Enabled = False
        Me.box_cod.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.box_cod.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.box_cod.Location = New System.Drawing.Point(500, 17)
        Me.box_cod.Name = "box_cod"
        Me.box_cod.Size = New System.Drawing.Size(184, 25)
        Me.box_cod.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Consolas", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(180, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(304, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(189, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Entrada Selecionada:"
        '
        'combobox_ColunasFiltro
        '
        Me.combobox_ColunasFiltro.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.combobox_ColunasFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_ColunasFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.combobox_ColunasFiltro.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.combobox_ColunasFiltro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combobox_ColunasFiltro.FormattingEnabled = True
        Me.combobox_ColunasFiltro.Location = New System.Drawing.Point(29, 16)
        Me.combobox_ColunasFiltro.Name = "combobox_ColunasFiltro"
        Me.combobox_ColunasFiltro.Size = New System.Drawing.Size(208, 25)
        Me.combobox_ColunasFiltro.TabIndex = 9
        '
        'bot_search
        '
        Me.bot_search.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_search.Image = Global.Gálata.My.Resources.Resources.search_32px
        Me.bot_search.Location = New System.Drawing.Point(478, 9)
        Me.bot_search.Name = "bot_search"
        Me.bot_search.Size = New System.Drawing.Size(32, 32)
        Me.bot_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_search.TabIndex = 8
        Me.bot_search.TabStop = False
        '
        'txtbox_search
        '
        Me.txtbox_search.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtbox_search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbox_search.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.txtbox_search.ForeColor = System.Drawing.Color.FromArgb(CType(CType(77, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbox_search.Location = New System.Drawing.Point(267, 16)
        Me.txtbox_search.Name = "txtbox_search"
        Me.txtbox_search.Size = New System.Drawing.Size(184, 25)
        Me.txtbox_search.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.Panel5.Controls.Add(Me.combobox_ColunasFiltro)
        Me.Panel5.Controls.Add(Me.bot_search)
        Me.Panel5.Controls.Add(Me.txtbox_search)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 117)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1551, 58)
        Me.Panel5.TabIndex = 22
        '
        'Grid_RegistrosEntradas
        '
        Me.Grid_RegistrosEntradas.AllowUserToAddRows = False
        Me.Grid_RegistrosEntradas.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid_RegistrosEntradas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Grid_RegistrosEntradas.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Grid_RegistrosEntradas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Grid_RegistrosEntradas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(77, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid_RegistrosEntradas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Grid_RegistrosEntradas.ColumnHeadersHeight = 40
        Me.Grid_RegistrosEntradas.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid_RegistrosEntradas.DefaultCellStyle = DataGridViewCellStyle3
        Me.Grid_RegistrosEntradas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Grid_RegistrosEntradas.Location = New System.Drawing.Point(0, 175)
        Me.Grid_RegistrosEntradas.Name = "Grid_RegistrosEntradas"
        Me.Grid_RegistrosEntradas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(77, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid_RegistrosEntradas.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Grid_RegistrosEntradas.RowHeadersWidth = 51
        Me.Grid_RegistrosEntradas.RowTemplate.Height = 29
        Me.Grid_RegistrosEntradas.Size = New System.Drawing.Size(1551, 429)
        Me.Grid_RegistrosEntradas.TabIndex = 23
        '
        'bot_NovaSaída
        '
        Me.bot_NovaSaída.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_NovaSaída.Image = Global.Gálata.My.Resources.Resources.saida2_32px
        Me.bot_NovaSaída.Location = New System.Drawing.Point(1141, 10)
        Me.bot_NovaSaída.Name = "bot_NovaSaída"
        Me.bot_NovaSaída.Size = New System.Drawing.Size(32, 32)
        Me.bot_NovaSaída.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_NovaSaída.TabIndex = 20
        Me.bot_NovaSaída.TabStop = False
        '
        'form_RegistrosEntradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1551, 604)
        Me.Controls.Add(Me.Grid_RegistrosEntradas)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Barra_RegistrosEntradas)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_RegistrosEntradas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form_RegistrosEntradas"
        Me.Barra_RegistrosEntradas.ResumeLayout(False)
        Me.Barra_RegistrosEntradas.PerformLayout()
        CType(Me.bot_fecharRegistrosEntradas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_minimizarRegistrosEntradas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_maximizarRegistrosEntradas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_fecharRegistrosSaídas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_minimizarRegistrosSaídas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_maximizarRegistrosSaídas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_Fechar_Padrão, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_Minimizar_Padrão, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_Maximizar_Padrão, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_fechar_estoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_minimizar_estoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_maximizar_estoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_Fechar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_Maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.bot_search, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.Grid_RegistrosEntradas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_NovaSaída, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Barra_RegistrosEntradas As Panel
    Friend WithEvents bot_fecharRegistrosSaídas As PictureBox
    Friend WithEvents bot_minimizarRegistrosSaídas As PictureBox
    Friend WithEvents bot_maximizarRegistrosSaídas As PictureBox
    Friend WithEvents bot_Fechar_Padrão As PictureBox
    Friend WithEvents bot_Minimizar_Padrão As PictureBox
    Friend WithEvents bot_Maximizar_Padrão As PictureBox
    Friend WithEvents bot_fechar_estoque As PictureBox
    Friend WithEvents bot_minimizar_estoque As PictureBox
    Friend WithEvents bot_maximizar_estoque As PictureBox
    Friend WithEvents bot_Fechar As PictureBox
    Friend WithEvents bot_Minimizar As PictureBox
    Friend WithEvents bot_Maximizar As PictureBox
    Friend WithEvents bot_fecharRegistrosEntradas As PictureBox
    Friend WithEvents bot_minimizarRegistrosEntradas As PictureBox
    Friend WithEvents bot_maximizarRegistrosEntradas As PictureBox
    Friend WithEvents bot_consumíveisEntradas As Button
    Friend WithEvents bot_matpriEntradas As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents combobox_ColunasFiltro As ComboBox
    Friend WithEvents bot_search As PictureBox
    Friend WithEvents txtbox_search As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Grid_RegistrosEntradas As DataGridView
    Friend WithEvents bot_deletar As Button
    Friend WithEvents bot_editar As Button
    Friend WithEvents box_cod As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents bot_NovaSaída As PictureBox
End Class
