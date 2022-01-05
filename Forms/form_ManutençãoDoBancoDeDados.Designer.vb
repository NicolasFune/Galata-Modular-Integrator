<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class form_ManutençãoDoBancoDeDados
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Barra_Manut = New System.Windows.Forms.Panel()
        Me.bot_fechar_manut = New System.Windows.Forms.PictureBox()
        Me.bot_minimizar_manut = New System.Windows.Forms.PictureBox()
        Me.bot_maximizar_manut = New System.Windows.Forms.PictureBox()
        Me.bot_fecharRegistrosEntradas = New System.Windows.Forms.PictureBox()
        Me.bot_minimizarRegistrosEntradas = New System.Windows.Forms.PictureBox()
        Me.bot_maximizarRegistrosEntradas = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.Grid_Manut = New System.Windows.Forms.DataGridView()
        Me.combobox_Tabelas = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.combobox_Colunas = New System.Windows.Forms.ComboBox()
        Me.richbox_Dados = New System.Windows.Forms.RichTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.bot_Inserir = New System.Windows.Forms.Button()
        Me.Barra_Manut.SuspendLayout()
        CType(Me.bot_fechar_manut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_minimizar_manut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_maximizar_manut, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.Grid_Manut, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Barra_Manut
        '
        Me.Barra_Manut.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Barra_Manut.Controls.Add(Me.bot_fechar_manut)
        Me.Barra_Manut.Controls.Add(Me.bot_minimizar_manut)
        Me.Barra_Manut.Controls.Add(Me.bot_maximizar_manut)
        Me.Barra_Manut.Controls.Add(Me.bot_fecharRegistrosEntradas)
        Me.Barra_Manut.Controls.Add(Me.bot_minimizarRegistrosEntradas)
        Me.Barra_Manut.Controls.Add(Me.bot_maximizarRegistrosEntradas)
        Me.Barra_Manut.Controls.Add(Me.Label4)
        Me.Barra_Manut.Controls.Add(Me.bot_fecharRegistrosSaídas)
        Me.Barra_Manut.Controls.Add(Me.bot_minimizarRegistrosSaídas)
        Me.Barra_Manut.Controls.Add(Me.bot_maximizarRegistrosSaídas)
        Me.Barra_Manut.Controls.Add(Me.bot_Fechar_Padrão)
        Me.Barra_Manut.Controls.Add(Me.bot_Minimizar_Padrão)
        Me.Barra_Manut.Controls.Add(Me.bot_Maximizar_Padrão)
        Me.Barra_Manut.Controls.Add(Me.bot_fechar_estoque)
        Me.Barra_Manut.Controls.Add(Me.bot_minimizar_estoque)
        Me.Barra_Manut.Controls.Add(Me.bot_maximizar_estoque)
        Me.Barra_Manut.Controls.Add(Me.bot_Fechar)
        Me.Barra_Manut.Controls.Add(Me.bot_Minimizar)
        Me.Barra_Manut.Controls.Add(Me.bot_Maximizar)
        Me.Barra_Manut.Dock = System.Windows.Forms.DockStyle.Top
        Me.Barra_Manut.Location = New System.Drawing.Point(0, 0)
        Me.Barra_Manut.Name = "Barra_Manut"
        Me.Barra_Manut.Size = New System.Drawing.Size(1563, 57)
        Me.Barra_Manut.TabIndex = 12
        '
        'bot_fechar_manut
        '
        Me.bot_fechar_manut.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_fechar_manut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_fechar_manut.Image = Global.Gálata.My.Resources.Resources.close_24px
        Me.bot_fechar_manut.Location = New System.Drawing.Point(1527, 12)
        Me.bot_fechar_manut.Name = "bot_fechar_manut"
        Me.bot_fechar_manut.Size = New System.Drawing.Size(24, 24)
        Me.bot_fechar_manut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_fechar_manut.TabIndex = 23
        Me.bot_fechar_manut.TabStop = False
        '
        'bot_minimizar_manut
        '
        Me.bot_minimizar_manut.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_minimizar_manut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_minimizar_manut.Image = Global.Gálata.My.Resources.Resources.minimizar2_24px
        Me.bot_minimizar_manut.Location = New System.Drawing.Point(1415, 12)
        Me.bot_minimizar_manut.Name = "bot_minimizar_manut"
        Me.bot_minimizar_manut.Size = New System.Drawing.Size(24, 24)
        Me.bot_minimizar_manut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_minimizar_manut.TabIndex = 21
        Me.bot_minimizar_manut.TabStop = False
        '
        'bot_maximizar_manut
        '
        Me.bot_maximizar_manut.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_maximizar_manut.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_maximizar_manut.Image = Global.Gálata.My.Resources.Resources.maximizar_24px
        Me.bot_maximizar_manut.Location = New System.Drawing.Point(1471, 12)
        Me.bot_maximizar_manut.Name = "bot_maximizar_manut"
        Me.bot_maximizar_manut.Size = New System.Drawing.Size(24, 24)
        Me.bot_maximizar_manut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_maximizar_manut.TabIndex = 22
        Me.bot_maximizar_manut.TabStop = False
        '
        'bot_fecharRegistrosEntradas
        '
        Me.bot_fecharRegistrosEntradas.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_fecharRegistrosEntradas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_fecharRegistrosEntradas.Image = Global.Gálata.My.Resources.Resources.close_24px
        Me.bot_fecharRegistrosEntradas.Location = New System.Drawing.Point(2878, -10)
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
        Me.bot_minimizarRegistrosEntradas.Location = New System.Drawing.Point(2766, -10)
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
        Me.bot_maximizarRegistrosEntradas.Location = New System.Drawing.Point(2822, -10)
        Me.bot_maximizarRegistrosEntradas.Name = "bot_maximizarRegistrosEntradas"
        Me.bot_maximizarRegistrosEntradas.Size = New System.Drawing.Size(24, 24)
        Me.bot_maximizarRegistrosEntradas.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_maximizarRegistrosEntradas.TabIndex = 19
        Me.bot_maximizarRegistrosEntradas.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(339, 23)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Manipulador de Banco de Dados"
        '
        'bot_fecharRegistrosSaídas
        '
        Me.bot_fecharRegistrosSaídas.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_fecharRegistrosSaídas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_fecharRegistrosSaídas.Image = Global.Gálata.My.Resources.Resources.close_24px
        Me.bot_fecharRegistrosSaídas.Location = New System.Drawing.Point(3919, -32)
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
        Me.bot_minimizarRegistrosSaídas.Location = New System.Drawing.Point(3807, -32)
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
        Me.bot_maximizarRegistrosSaídas.Location = New System.Drawing.Point(3863, -32)
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
        Me.bot_Fechar_Padrão.Location = New System.Drawing.Point(4597, -54)
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
        Me.bot_Minimizar_Padrão.Location = New System.Drawing.Point(4485, -54)
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
        Me.bot_Maximizar_Padrão.Location = New System.Drawing.Point(4541, -54)
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
        Me.bot_fechar_estoque.Location = New System.Drawing.Point(5580, -76)
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
        Me.bot_minimizar_estoque.Location = New System.Drawing.Point(5468, -76)
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
        Me.bot_maximizar_estoque.Location = New System.Drawing.Point(5524, -76)
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
        Me.bot_Fechar.Location = New System.Drawing.Point(6518, -93)
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
        Me.bot_Minimizar.Location = New System.Drawing.Point(6406, -93)
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
        Me.bot_Maximizar.Location = New System.Drawing.Point(6462, -93)
        Me.bot_Maximizar.Name = "bot_Maximizar"
        Me.bot_Maximizar.Size = New System.Drawing.Size(24, 24)
        Me.bot_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_Maximizar.TabIndex = 6
        Me.bot_Maximizar.TabStop = False
        '
        'Grid_Manut
        '
        Me.Grid_Manut.AllowUserToAddRows = False
        Me.Grid_Manut.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(77, Byte), Integer), CType(CType(77, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid_Manut.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.Grid_Manut.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.Grid_Manut.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.Grid_Manut.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(77, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid_Manut.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.Grid_Manut.ColumnHeadersHeight = 40
        Me.Grid_Manut.Cursor = System.Windows.Forms.Cursors.Hand
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid_Manut.DefaultCellStyle = DataGridViewCellStyle3
        Me.Grid_Manut.Location = New System.Drawing.Point(12, 63)
        Me.Grid_Manut.Name = "Grid_Manut"
        Me.Grid_Manut.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(77, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(204, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Grid_Manut.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.Grid_Manut.RowHeadersWidth = 51
        Me.Grid_Manut.RowTemplate.Height = 29
        Me.Grid_Manut.Size = New System.Drawing.Size(1522, 334)
        Me.Grid_Manut.TabIndex = 22
        '
        'combobox_Tabelas
        '
        Me.combobox_Tabelas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.combobox_Tabelas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_Tabelas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.combobox_Tabelas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combobox_Tabelas.FormattingEnabled = True
        Me.combobox_Tabelas.Location = New System.Drawing.Point(39, 476)
        Me.combobox_Tabelas.Name = "combobox_Tabelas"
        Me.combobox_Tabelas.Size = New System.Drawing.Size(230, 28)
        Me.combobox_Tabelas.TabIndex = 23
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(110, 427)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 23)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Tabelas"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(400, 427)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 23)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "Colunas"
        '
        'combobox_Colunas
        '
        Me.combobox_Colunas.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.combobox_Colunas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combobox_Colunas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.combobox_Colunas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.combobox_Colunas.FormattingEnabled = True
        Me.combobox_Colunas.Location = New System.Drawing.Point(329, 476)
        Me.combobox_Colunas.Name = "combobox_Colunas"
        Me.combobox_Colunas.Size = New System.Drawing.Size(230, 28)
        Me.combobox_Colunas.TabIndex = 25
        '
        'richbox_Dados
        '
        Me.richbox_Dados.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.richbox_Dados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.richbox_Dados.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.richbox_Dados.Location = New System.Drawing.Point(640, 476)
        Me.richbox_Dados.Name = "richbox_Dados"
        Me.richbox_Dados.Size = New System.Drawing.Size(409, 348)
        Me.richbox_Dados.TabIndex = 27
        Me.richbox_Dados.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(809, 427)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 23)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Dados"
        '
        'bot_Inserir
        '
        Me.bot_Inserir.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(61, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.bot_Inserir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_Inserir.FlatAppearance.BorderSize = 0
        Me.bot_Inserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bot_Inserir.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.bot_Inserir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.bot_Inserir.Location = New System.Drawing.Point(1192, 476)
        Me.bot_Inserir.Name = "bot_Inserir"
        Me.bot_Inserir.Size = New System.Drawing.Size(342, 29)
        Me.bot_Inserir.TabIndex = 29
        Me.bot_Inserir.Text = "Inserir"
        Me.bot_Inserir.UseVisualStyleBackColor = False
        '
        'form_ManutençãoDoBancoDeDados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(100, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1563, 913)
        Me.Controls.Add(Me.bot_Inserir)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.richbox_Dados)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.combobox_Colunas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.combobox_Tabelas)
        Me.Controls.Add(Me.Grid_Manut)
        Me.Controls.Add(Me.Barra_Manut)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "form_ManutençãoDoBancoDeDados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Barra_Manut.ResumeLayout(False)
        Me.Barra_Manut.PerformLayout()
        CType(Me.bot_fechar_manut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_minimizar_manut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_maximizar_manut, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.Grid_Manut, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Barra_Manut As Panel
    Friend WithEvents bot_fecharRegistrosEntradas As PictureBox
    Friend WithEvents bot_minimizarRegistrosEntradas As PictureBox
    Friend WithEvents bot_maximizarRegistrosEntradas As PictureBox
    Friend WithEvents Label4 As Label
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
    Friend WithEvents bot_fechar_manut As PictureBox
    Friend WithEvents bot_minimizar_manut As PictureBox
    Friend WithEvents bot_maximizar_manut As PictureBox
    Friend WithEvents Grid_Manut As DataGridView
    Friend WithEvents combobox_Tabelas As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents combobox_Colunas As ComboBox
    Friend WithEvents richbox_Dados As RichTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents bot_Inserir As Button
End Class
