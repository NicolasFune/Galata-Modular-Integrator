<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_NovaEntrada_Consumível
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_NovaEntrada_Consumível))
        Me.Barra = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bot_fecharNovaEntradaConsumível = New System.Windows.Forms.PictureBox()
        Me.bot_minimizar_NovaEntradaConsumível = New System.Windows.Forms.PictureBox()
        Me.bot_maximizar_NovaEntradaConsumível = New System.Windows.Forms.PictureBox()
        Me.bot_fechar_estoque = New System.Windows.Forms.PictureBox()
        Me.bot_minimizar_estoque = New System.Windows.Forms.PictureBox()
        Me.bot_maximizar_estoque = New System.Windows.Forms.PictureBox()
        Me.bot_Fechar = New System.Windows.Forms.PictureBox()
        Me.bot_Minimizar = New System.Windows.Forms.PictureBox()
        Me.bot_Maximizar = New System.Windows.Forms.PictureBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.box_qua = New System.Windows.Forms.NumericUpDown()
        Me.box_cus = New System.Windows.Forms.NumericUpDown()
        Me.box_dataChegada = New System.Windows.Forms.DateTimePicker()
        Me.box_nota = New System.Windows.Forms.TextBox()
        Me.box_mar = New System.Windows.Forms.ComboBox()
        Me.box_for = New System.Windows.Forms.ComboBox()
        Me.box_des = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cod_rastreio = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.bot_cancel = New System.Windows.Forms.PictureBox()
        Me.bot_ok = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Barra.SuspendLayout()
        CType(Me.bot_fecharNovaEntradaConsumível, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_minimizar_NovaEntradaConsumível, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_maximizar_NovaEntradaConsumível, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_fechar_estoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_minimizar_estoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_maximizar_estoque, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_Fechar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_Minimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_Maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.box_qua, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.box_cus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_cancel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bot_ok, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Barra
        '
        Me.Barra.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.Barra.Controls.Add(Me.Label1)
        Me.Barra.Controls.Add(Me.bot_fecharNovaEntradaConsumível)
        Me.Barra.Controls.Add(Me.bot_minimizar_NovaEntradaConsumível)
        Me.Barra.Controls.Add(Me.bot_maximizar_NovaEntradaConsumível)
        Me.Barra.Controls.Add(Me.bot_fechar_estoque)
        Me.Barra.Controls.Add(Me.bot_minimizar_estoque)
        Me.Barra.Controls.Add(Me.bot_maximizar_estoque)
        Me.Barra.Controls.Add(Me.bot_Fechar)
        Me.Barra.Controls.Add(Me.bot_Minimizar)
        Me.Barra.Controls.Add(Me.bot_Maximizar)
        Me.Barra.Dock = System.Windows.Forms.DockStyle.Top
        Me.Barra.Location = New System.Drawing.Point(0, 0)
        Me.Barra.Name = "Barra"
        Me.Barra.Size = New System.Drawing.Size(901, 57)
        Me.Barra.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(27, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(304, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Nova Entrada de Consumível"
        '
        'bot_fecharNovaEntradaConsumível
        '
        Me.bot_fecharNovaEntradaConsumível.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_fecharNovaEntradaConsumível.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_fecharNovaEntradaConsumível.Image = Global.Gálata.My.Resources.Resources.close_24px
        Me.bot_fecharNovaEntradaConsumível.Location = New System.Drawing.Point(865, 12)
        Me.bot_fecharNovaEntradaConsumível.Name = "bot_fecharNovaEntradaConsumível"
        Me.bot_fecharNovaEntradaConsumível.Size = New System.Drawing.Size(24, 24)
        Me.bot_fecharNovaEntradaConsumível.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_fecharNovaEntradaConsumível.TabIndex = 13
        Me.bot_fecharNovaEntradaConsumível.TabStop = False
        '
        'bot_minimizar_NovaEntradaConsumível
        '
        Me.bot_minimizar_NovaEntradaConsumível.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_minimizar_NovaEntradaConsumível.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_minimizar_NovaEntradaConsumível.Image = Global.Gálata.My.Resources.Resources.minimizar2_24px
        Me.bot_minimizar_NovaEntradaConsumível.Location = New System.Drawing.Point(753, 12)
        Me.bot_minimizar_NovaEntradaConsumível.Name = "bot_minimizar_NovaEntradaConsumível"
        Me.bot_minimizar_NovaEntradaConsumível.Size = New System.Drawing.Size(24, 24)
        Me.bot_minimizar_NovaEntradaConsumível.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_minimizar_NovaEntradaConsumível.TabIndex = 11
        Me.bot_minimizar_NovaEntradaConsumível.TabStop = False
        '
        'bot_maximizar_NovaEntradaConsumível
        '
        Me.bot_maximizar_NovaEntradaConsumível.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_maximizar_NovaEntradaConsumível.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_maximizar_NovaEntradaConsumível.Image = Global.Gálata.My.Resources.Resources.maximizar_24px
        Me.bot_maximizar_NovaEntradaConsumível.Location = New System.Drawing.Point(809, 12)
        Me.bot_maximizar_NovaEntradaConsumível.Name = "bot_maximizar_NovaEntradaConsumível"
        Me.bot_maximizar_NovaEntradaConsumível.Size = New System.Drawing.Size(24, 24)
        Me.bot_maximizar_NovaEntradaConsumível.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_maximizar_NovaEntradaConsumível.TabIndex = 12
        Me.bot_maximizar_NovaEntradaConsumível.TabStop = False
        '
        'bot_fechar_estoque
        '
        Me.bot_fechar_estoque.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.bot_fechar_estoque.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_fechar_estoque.Image = Global.Gálata.My.Resources.Resources.close_24px
        Me.bot_fechar_estoque.Location = New System.Drawing.Point(1848, -10)
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
        Me.bot_minimizar_estoque.Location = New System.Drawing.Point(1736, -10)
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
        Me.bot_maximizar_estoque.Location = New System.Drawing.Point(1792, -10)
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
        Me.bot_Fechar.Location = New System.Drawing.Point(2786, -27)
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
        Me.bot_Minimizar.Location = New System.Drawing.Point(2674, -27)
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
        Me.bot_Maximizar.Location = New System.Drawing.Point(2730, -27)
        Me.bot_Maximizar.Name = "bot_Maximizar"
        Me.bot_Maximizar.Size = New System.Drawing.Size(24, 24)
        Me.bot_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_Maximizar.TabIndex = 6
        Me.bot_Maximizar.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(70, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.box_qua)
        Me.GroupBox2.Controls.Add(Me.box_cus)
        Me.GroupBox2.Controls.Add(Me.box_dataChegada)
        Me.GroupBox2.Controls.Add(Me.box_nota)
        Me.GroupBox2.Controls.Add(Me.box_mar)
        Me.GroupBox2.Controls.Add(Me.box_for)
        Me.GroupBox2.Controls.Add(Me.box_des)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.GroupBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.GroupBox2.Location = New System.Drawing.Point(27, 64)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(834, 296)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Características Gerais"
        '
        'box_qua
        '
        Me.box_qua.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.box_qua.Cursor = System.Windows.Forms.Cursors.Hand
        Me.box_qua.DecimalPlaces = 2
        Me.box_qua.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.box_qua.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.box_qua.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.box_qua.Location = New System.Drawing.Point(257, 201)
        Me.box_qua.Name = "box_qua"
        Me.box_qua.Size = New System.Drawing.Size(140, 27)
        Me.box_qua.TabIndex = 27
        Me.box_qua.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.box_qua.ThousandsSeparator = True
        '
        'box_cus
        '
        Me.box_cus.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.box_cus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.box_cus.DecimalPlaces = 2
        Me.box_cus.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.box_cus.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.box_cus.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.box_cus.Location = New System.Drawing.Point(666, 94)
        Me.box_cus.Name = "box_cus"
        Me.box_cus.Size = New System.Drawing.Size(140, 27)
        Me.box_cus.TabIndex = 27
        Me.box_cus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.box_cus.ThousandsSeparator = True
        '
        'box_dataChegada
        '
        Me.box_dataChegada.CalendarFont = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.box_dataChegada.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.box_dataChegada.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.box_dataChegada.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.box_dataChegada.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.box_dataChegada.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.box_dataChegada.Cursor = System.Windows.Forms.Cursors.Hand
        Me.box_dataChegada.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.box_dataChegada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.box_dataChegada.Location = New System.Drawing.Point(257, 145)
        Me.box_dataChegada.Name = "box_dataChegada"
        Me.box_dataChegada.Size = New System.Drawing.Size(140, 27)
        Me.box_dataChegada.TabIndex = 26
        '
        'box_nota
        '
        Me.box_nota.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.box_nota.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.box_nota.Location = New System.Drawing.Point(577, 138)
        Me.box_nota.Name = "box_nota"
        Me.box_nota.Size = New System.Drawing.Size(229, 27)
        Me.box_nota.TabIndex = 25
        '
        'box_mar
        '
        Me.box_mar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.box_mar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.box_mar.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.box_mar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.box_mar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.box_mar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.box_mar.FormattingEnabled = True
        Me.box_mar.Location = New System.Drawing.Point(577, 190)
        Me.box_mar.MaxDropDownItems = 5
        Me.box_mar.Name = "box_mar"
        Me.box_mar.Size = New System.Drawing.Size(229, 28)
        Me.box_mar.TabIndex = 24
        '
        'box_for
        '
        Me.box_for.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.box_for.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.box_for.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.box_for.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.box_for.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.box_for.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.box_for.FormattingEnabled = True
        Me.box_for.Location = New System.Drawing.Point(176, 95)
        Me.box_for.MaxDropDownItems = 5
        Me.box_for.Name = "box_for"
        Me.box_for.Size = New System.Drawing.Size(221, 28)
        Me.box_for.TabIndex = 24
        '
        'box_des
        '
        Me.box_des.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.box_des.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.box_des.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.box_des.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.box_des.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.box_des.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.box_des.FormattingEnabled = True
        Me.box_des.Location = New System.Drawing.Point(176, 44)
        Me.box_des.MaxDropDownItems = 5
        Me.box_des.Name = "box_des"
        Me.box_des.Size = New System.Drawing.Size(630, 28)
        Me.box_des.TabIndex = 24
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bell MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(8, 95)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 22)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Fornecedor"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bell MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(8, 143)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 22)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Data de Chegada"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bell MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(8, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 22)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Descrição"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Bell MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(8, 196)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(134, 22)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Quantidade (uni)"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Bell MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(416, 199)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(58, 22)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Marca"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Bell MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(416, 95)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(122, 22)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "Custo Unitário"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Bell MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(416, 149)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(143, 22)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "Nº da Nota Fiscal"
        '
        'cod_rastreio
        '
        Me.cod_rastreio.AutoSize = True
        Me.cod_rastreio.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.cod_rastreio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.cod_rastreio.Location = New System.Drawing.Point(536, 399)
        Me.cod_rastreio.Name = "cod_rastreio"
        Me.cod_rastreio.Size = New System.Drawing.Size(81, 21)
        Me.cod_rastreio.TabIndex = 39
        Me.cod_rastreio.Text = "Label27"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial Rounded MT Bold", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label28.ForeColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.Label28.Location = New System.Drawing.Point(307, 399)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(180, 21)
        Me.Label28.TabIndex = 38
        Me.Label28.Text = "Código de Origem: "
        '
        'bot_cancel
        '
        Me.bot_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_cancel.Image = Global.Gálata.My.Resources.Resources.cancel2_32px
        Me.bot_cancel.Location = New System.Drawing.Point(730, 388)
        Me.bot_cancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bot_cancel.Name = "bot_cancel"
        Me.bot_cancel.Size = New System.Drawing.Size(32, 32)
        Me.bot_cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_cancel.TabIndex = 41
        Me.bot_cancel.TabStop = False
        Me.ToolTip1.SetToolTip(Me.bot_cancel, "Cancelar")
        '
        'bot_ok
        '
        Me.bot_ok.Cursor = System.Windows.Forms.Cursors.Hand
        Me.bot_ok.Image = Global.Gálata.My.Resources.Resources.enter3_32px1
        Me.bot_ok.Location = New System.Drawing.Point(820, 388)
        Me.bot_ok.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bot_ok.Name = "bot_ok"
        Me.bot_ok.Size = New System.Drawing.Size(32, 32)
        Me.bot_ok.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.bot_ok.TabIndex = 40
        Me.bot_ok.TabStop = False
        Me.ToolTip1.SetToolTip(Me.bot_ok, "Adicionar")
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 1000
        Me.ToolTip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(200, Byte), Integer), CType(CType(200, Byte), Integer))
        Me.ToolTip1.ForeColor = System.Drawing.Color.Black
        Me.ToolTip1.InitialDelay = 50
        Me.ToolTip1.ReshowDelay = 50
        '
        'form_NovaEntrada_Consumível
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(901, 479)
        Me.Controls.Add(Me.bot_cancel)
        Me.Controls.Add(Me.bot_ok)
        Me.Controls.Add(Me.cod_rastreio)
        Me.Controls.Add(Me.Label28)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Barra)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "form_NovaEntrada_Consumível"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "form_NovaEntrada_Consumível"
        Me.Barra.ResumeLayout(False)
        Me.Barra.PerformLayout()
        CType(Me.bot_fecharNovaEntradaConsumível, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_minimizar_NovaEntradaConsumível, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_maximizar_NovaEntradaConsumível, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_fechar_estoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_minimizar_estoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_maximizar_estoque, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_Fechar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_Minimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_Maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.box_qua, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.box_cus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_cancel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bot_ok, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Barra As Panel
    Friend WithEvents bot_fechar_estoque As PictureBox
    Friend WithEvents bot_minimizar_estoque As PictureBox
    Friend WithEvents bot_maximizar_estoque As PictureBox
    Friend WithEvents bot_Fechar As PictureBox
    Friend WithEvents bot_Minimizar As PictureBox
    Friend WithEvents bot_Maximizar As PictureBox
    Friend WithEvents bot_fecharNovaEntradaConsumível As PictureBox
    Friend WithEvents bot_minimizar_NovaEntradaConsumível As PictureBox
    Friend WithEvents bot_maximizar_NovaEntradaConsumível As PictureBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cod_rastreio As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents bot_cancel As PictureBox
    Friend WithEvents bot_ok As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents box_des As ComboBox
    Friend WithEvents box_nota As TextBox
    Friend WithEvents box_mar As ComboBox
    Friend WithEvents box_for As ComboBox
    Friend WithEvents box_cus As NumericUpDown
    Friend WithEvents box_dataChegada As DateTimePicker
    Friend WithEvents box_qua As NumericUpDown
End Class
