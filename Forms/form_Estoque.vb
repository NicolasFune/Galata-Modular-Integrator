
Public Class form_Estoque
    Private Sub form_Estoque_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        form_Estoque_Instância1 = Me
        Mod_Window_State.MaximizarNoLoadEvent(Me)
        Mod_ProgressBar.Increment(20)

        Mod_Displays_BotõesDeDisplay.MudarEstadoDoBotãoMatériaPrimaParaPressionado(Me.bot_matpri, Me.bot_consumíveis)
        Mod_Displays_BotõesDeDisplay.CarregarEstaTabelaNesteDisplay("TB_MAT_PRI", Me.Grid)

        Me.bot_usuário.Text = UsuárioLogado
        combobox_ColunasFiltro.DataSource = BancoDeDados_Instância1.ColetarOsNomesDasColunasDeterminadasDestaTabela_RetornaArrayDeStrings(TabelaCarregadaNoDisplay, ColunasQueIrãoAparecerNoDsiplay_String)
        Mod_ProgressBar.Increment(20)
        Mod_ProgressBar.Increment(20)
        Mod_ProgressBar.Increment(20)
        Mod_ProgressBar.Increment(20)

    End Sub
    Private Sub bot_matpri_Click(sender As Object, e As EventArgs) Handles bot_matpri.Click
        Mod_Displays_BotõesDeDisplay.MudarEstadoDoBotãoMatériaPrimaParaPressionado(Me.bot_matpri, Me.bot_consumíveis)
        Mod_Displays_BotõesDeDisplay.CarregarEstaTabelaNesteDisplay("TB_MAT_PRI", Me.Grid)
        combobox_ColunasFiltro.DataSource = BancoDeDados_Instância1.ColetarOsNomesDasColunasDeterminadasDestaTabela_RetornaArrayDeStrings(TabelaCarregadaNoDisplay, ColunasQueIrãoAparecerNoDsiplay_String)

    End Sub
    Private Sub bot_consumíveis_Click(sender As Object, e As EventArgs) Handles bot_consumíveis.Click
        BancoDeDados_Consumíveis_Instância1.AtualizarDisplayConsumiveis()
        Mod_Displays_BotõesDeDisplay.MudarEstadoDoBotãoConsumíveisParaPressionado(Me.bot_matpri, Me.bot_consumíveis)
        Mod_Displays_BotõesDeDisplay.CarregarEstaTabelaNesteDisplay("Display_Consumiveis", Me.Grid)
        combobox_ColunasFiltro.DataSource = BancoDeDados_Instância1.ColetarOsNomesDasColunasDeterminadasDestaTabela_RetornaArrayDeStrings(TabelaCarregadaNoDisplay, ColunasQueIrãoAparecerNoDsiplay_String)



    End Sub
    Private Sub form_Estoque_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        DisplayQueIráSerFiltrado_Control = form_Estoque_Instância1.Grid
        If bot_matpri.BackColor = Color.FromArgb(0, 200, 200) Then
            TabelaCarregadaNoDisplay = "TB_MAT_PRI"
        ElseIf bot_consumíveis.BackColor = Color.FromArgb(0, 200, 200) Then
            TabelaCarregadaNoDisplay = "Display_Consumiveis"

        End If

    End Sub
    Private Sub Grid_DataSourceChanged(sender As Object, e As EventArgs) Handles Grid.DataSourceChanged

        If IsNothing(Me.Grid.DataSource) Then
        Else
            Me.Grid.Columns.Item("ID").Visible = False
        End If
        If Me.Grid.Rows.Count > 1 Then
            Me.Grid.FirstDisplayedScrollingRowIndex = Me.Grid.RowCount - 1
            Me.Grid.Rows(Me.Grid.Rows.Count - 1).Selected = True
        End If

    End Sub
    Private Sub bot_Nova_Classe_Click(sender As Object, e As EventArgs) Handles bot_Nova_Classe.Click
        If UsuárioLogado = "Administrador" Or UsuárioLogado = "Nícolas" Then
            form_Nova_Classe_Instância1.Show()
        Else
            MessageBox.Show("Apenas o desenvolvedor tem acesso a essa função")
        End If

    End Sub
    Private Sub downButton_Classes_Click(sender As Object, e As EventArgs) Handles downButton_Classes.Click
        'Carregar_Classes_No_Botão()
    End Sub

    Private Sub bot_ManutençãoDoBancoDeDados_Click(sender As Object, e As EventArgs) Handles bot_ManutençãoDoBancoDeDados.Click
        If UsuárioLogado = "Administrador" Or UsuárioLogado = "Nícolas" Then
            form_manut_Instância1 = New form_ManutençãoDoBancoDeDados
            form_manut_Instância1.Show()
        Else
            MessageBox.Show("Apenas o desenvolvedor tem acesso a essa função")
        End If

    End Sub

    Private Sub bot_Saídas_Click(sender As Object, e As EventArgs) Handles bot_saídas.Click
        form_RegistrosSaídas_Instância1 = New form_RegistrosSaídas
        form_RegistrosSaídas_Instância1.Show()
    End Sub
    Private Sub bot_NovaEntrada_Consumível_Click(sender As Object, e As EventArgs) Handles bot_NovaEntrada_Consumível.Click
        form_NovaEntrada_Consumível_Instância1 = New form_NovaEntrada_Consumível
        OformEstaSendoChamadoParaEditarDados = False
        form_NovaEntrada_Consumível_Instância1.Show()

    End Sub
    Private Sub bot_AtualizarEstoqueUni_Click(sender As Object, e As EventArgs) Handles bot_AtualizarEstoqueUni.Click
        BancoDeDados_Consumíveis_Instância1.AtualizarDisplayConsumiveis()
        Mod_Displays_BotõesDeDisplay.MudarEstadoDoBotãoConsumíveisParaPressionado(Me.bot_matpri, Me.bot_consumíveis)
        Mod_Displays_BotõesDeDisplay.CarregarEstaTabelaNesteDisplay("Display_Consumiveis", Me.Grid)
        combobox_ColunasFiltro.DataSource = BancoDeDados_Instância1.ColetarOsNomesDasColunasDeterminadasDestaTabela_RetornaArrayDeStrings(TabelaCarregadaNoDisplay, ColunasQueIrãoAparecerNoDsiplay_String)
    End Sub
    Private Sub bot_DadosFaltantes_Click(sender As Object, e As EventArgs)
        form_DadosFaltantes_Instância1 = New form_DadosFaltantes
        form_DadosFaltantes_Instância1.Show()
    End Sub
    Private Sub bot_refreshDadosFaltantes_Click(sender As Object, e As EventArgs)
        Dim result As DialogResult = MessageBox.Show(" CUIDADO!!! Deseja mesmo atualizar os dados faltantes? Este procedimento pode demorar muito!!", "Gálata", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            'Mod_ProgressBar.Show()
            Mod_ProgressBar.Menssagem("Iniciando Verificação")
            BancoDeDados_Instância1.VerificaQuantosItensEstãoEmBrancoEGeraUmDisplayDeRegistro()
        End If

    End Sub
    Private Sub bot_entradas_Click(sender As Object, e As EventArgs) Handles bot_entradas.Click
        form_RegistrosEntradas_Instância1 = New form_RegistrosEntradas
        form_RegistrosEntradas_Instância1.Show()
    End Sub
    Private Sub combobox_ColunasFiltro_SelectedValueChanged(sender As Object, e As EventArgs) Handles combobox_ColunasFiltro.SelectedValueChanged
        ColunaSelecionadaNoFiltro = Me.combobox_ColunasFiltro.Text
    End Sub
    Private Sub bot_search_Click(sender As Object, e As EventArgs) Handles bot_search.Click
        ColunasQueIrãoAparecerNoDsiplay_String = "*"
        If txtbox_search.Text = "" Then
            Me.Grid.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, ColunasQueIrãoAparecerNoDsiplay_String, "")
            Me.Grid.AutoResizeColumns()

        Else
            Me.Grid.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, ColunasQueIrãoAparecerNoDsiplay_String, Mod_FunçõesVariadas.GerarVetoresDeClausulasWHERE(combobox_ColunasFiltro.Text, txtbox_search.Text))
            Me.Grid.AutoResizeColumns()

        End If
        combobox_ColunasFiltro.SelectedItem = ColunaSelecionadaNoFiltro
    End Sub
    Private Sub txtbox_search_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_search.KeyDown
        ColunasQueIrãoAparecerNoDsiplay_String = "*"
        If e.KeyCode = Keys.Enter Then
            If txtbox_search.Text = "" Then
                Me.Grid.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, ColunasQueIrãoAparecerNoDsiplay_String, "")
                Me.Grid.AutoResizeColumns()

            Else
                Me.Grid.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, ColunasQueIrãoAparecerNoDsiplay_String, Mod_FunçõesVariadas.GerarVetoresDeClausulasWHERE(combobox_ColunasFiltro.Text, txtbox_search.Text))
                Me.Grid.AutoResizeColumns()
            End If
            combobox_ColunasFiltro.SelectedItem = ColunaSelecionadaNoFiltro
        End If
    End Sub
    Private Sub bot_Notificações_Click(sender As Object, e As EventArgs) Handles bot_Notificações.Click
        MessageBox.Show("Função ainda indisponível")
    End Sub

    Private Sub bot_Arruela_Click(sender As Object, e As EventArgs) Handles bot_Arruela.Click
        form_Nova_Entrada_Instância1 = New form_Nova_Entrada
        NovaMatériaPrima = New Class_ModeloDeClasseParaCriaçãoDeNovasClassesDeMatériaPrima
        NovaMatériaPrima.LabelDeDimensões_Dimensões = False
        form_Nova_Entrada_Instância1.lab_cus.Text = "Custo p/ Uni"
        NovaMatériaPrima.CaracterísticasQuePopularãoComboBoxes.AddRange({"Material", "Revestimento", "Dureza", "Norma"})
        NovaMatériaPrima.CaracterísticasQuePopularãoTextBoxes.AddRange({"Diâmetro (mm)"})
        NovaMatériaPrima.CriarControlesDentroDoControle(form_Nova_Entrada_Instância1.groupbox_Características_Específicas)
        CódigoDaClasse_Completo = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "COD", "NOME", "ARRUELA")
        form_Nova_Entrada_Instância1.cod_classe.Text = CódigoDaClasse_Completo
        form_Nova_Entrada_Instância1.cod_origem.Text = Mod_Codificação.CriarNovoCódigoDeOrigemParaEsteCodDeClasse_RetornaString(CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.TituloDaClasse.Text = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "NOME", "COD", CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.Show()
    End Sub

    Private Sub bot_barrachata_Click(sender As Object, e As EventArgs) Handles bot_barrachata.Click
        form_Nova_Entrada_Instância1 = New form_Nova_Entrada
        NovaMatériaPrima = New Class_ModeloDeClasseParaCriaçãoDeNovasClassesDeMatériaPrima
        NovaMatériaPrima.LabelDeDimensões_Dimensões = False
        form_Nova_Entrada_Instância1.lab_cus.Text = "Custo p/ KG"
        NovaMatériaPrima.CaracterísticasQuePopularãoComboBoxes.AddRange({"Material", "Espessura"})
        NovaMatériaPrima.CaracterísticasQuePopularãoTextBoxes.AddRange({"Comprimento (mm)", "Largura (mm)", "Peso (Kg)"})
        NovaMatériaPrima.CriarControlesDentroDoControle(form_Nova_Entrada_Instância1.groupbox_Características_Específicas)
        CódigoDaClasse_Completo = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "COD", "NOME", "BARRA CHATA")
        form_Nova_Entrada_Instância1.cod_classe.Text = CódigoDaClasse_Completo
        form_Nova_Entrada_Instância1.cod_origem.Text = Mod_Codificação.CriarNovoCódigoDeOrigemParaEsteCodDeClasse_RetornaString(CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.TituloDaClasse.Text = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "NOME", "COD", CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.Show()
    End Sub
    Private Sub bot_barraredonda_Click(sender As Object, e As EventArgs) Handles bot_barraredonda.Click
        form_Nova_Entrada_Instância1 = New form_Nova_Entrada
        NovaMatériaPrima = New Class_ModeloDeClasseParaCriaçãoDeNovasClassesDeMatériaPrima
        NovaMatériaPrima.LabelDeDimensões_Dimensões = False
        form_Nova_Entrada_Instância1.lab_cus.Text = "Custo p/ KG"
        NovaMatériaPrima.CaracterísticasQuePopularãoComboBoxes.AddRange({"Material"})
        NovaMatériaPrima.CaracterísticasQuePopularãoTextBoxes.AddRange({"Comprimento (mm)", "Diâmetro (mm)", "Peso (Kg)"})
        NovaMatériaPrima.CriarControlesDentroDoControle(form_Nova_Entrada_Instância1.groupbox_Características_Específicas)
        CódigoDaClasse_Completo = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "COD", "NOME", "BARRA REDONDA")
        form_Nova_Entrada_Instância1.cod_classe.Text = CódigoDaClasse_Completo
        form_Nova_Entrada_Instância1.cod_origem.Text = Mod_Codificação.CriarNovoCódigoDeOrigemParaEsteCodDeClasse_RetornaString(CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.TituloDaClasse.Text = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "NOME", "COD", CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.Show()
    End Sub

    Private Sub bot_cantoneira_Click(sender As Object, e As EventArgs) Handles bot_cantoneira.Click
        form_Nova_Entrada_Instância1 = New form_Nova_Entrada
        NovaMatériaPrima = New Class_ModeloDeClasseParaCriaçãoDeNovasClassesDeMatériaPrima
        NovaMatériaPrima.LabelDeDimensões_Dimensões = False
        form_Nova_Entrada_Instância1.lab_cus.Text = "Custo p/ KG"
        NovaMatériaPrima.CaracterísticasQuePopularãoComboBoxes.AddRange({"Material", "Espessura"})
        NovaMatériaPrima.CaracterísticasQuePopularãoTextBoxes.AddRange({"Comprimento (mm)", "Tamanho da Aba (mm)", "Peso (Kg)"})
        NovaMatériaPrima.CriarControlesDentroDoControle(form_Nova_Entrada_Instância1.groupbox_Características_Específicas)
        CódigoDaClasse_Completo = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "COD", "NOME", "CANTONEIRA")
        form_Nova_Entrada_Instância1.cod_classe.Text = CódigoDaClasse_Completo
        form_Nova_Entrada_Instância1.cod_origem.Text = Mod_Codificação.CriarNovoCódigoDeOrigemParaEsteCodDeClasse_RetornaString(CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.TituloDaClasse.Text = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "NOME", "COD", CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.Show()
    End Sub

    Private Sub bot_chapa_Click(sender As Object, e As EventArgs) Handles bot_chapa.Click
        form_Nova_Entrada_Instância1 = New form_Nova_Entrada
        NovaMatériaPrima = New Class_ModeloDeClasseParaCriaçãoDeNovasClassesDeMatériaPrima
        NovaMatériaPrima.LabelDeDimensões_Dimensões = False
        form_Nova_Entrada_Instância1.lab_cus.Text = "Custo p/ KG"
        NovaMatériaPrima.CaracterísticasQuePopularãoComboBoxes.AddRange({"Material", "Espessura"})
        NovaMatériaPrima.CaracterísticasQuePopularãoTextBoxes.AddRange({"Comprimento (mm)", "Largura (mm)", "Peso (Kg)"})
        NovaMatériaPrima.CriarControlesDentroDoControle(form_Nova_Entrada_Instância1.groupbox_Características_Específicas)
        CódigoDaClasse_Completo = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "COD", "NOME", "CHAPA")
        form_Nova_Entrada_Instância1.cod_classe.Text = CódigoDaClasse_Completo
        form_Nova_Entrada_Instância1.cod_origem.Text = Mod_Codificação.CriarNovoCódigoDeOrigemParaEsteCodDeClasse_RetornaString(CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.TituloDaClasse.Text = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "NOME", "COD", CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.Show()
    End Sub

    Private Sub bot_contrapino_Click(sender As Object, e As EventArgs) Handles bot_contrapino.Click
        form_Nova_Entrada_Instância1 = New form_Nova_Entrada
        NovaMatériaPrima = New Class_ModeloDeClasseParaCriaçãoDeNovasClassesDeMatériaPrima
        NovaMatériaPrima.LabelDeDimensões_Dimensões = False
        form_Nova_Entrada_Instância1.lab_cus.Text = "Custo p/ Uni"
        NovaMatériaPrima.CaracterísticasQuePopularãoComboBoxes.AddRange({"Material"})
        NovaMatériaPrima.CaracterísticasQuePopularãoTextBoxes.AddRange({"Comprimento (mm)", "Diâmetro (mm)"})
        NovaMatériaPrima.CriarControlesDentroDoControle(form_Nova_Entrada_Instância1.groupbox_Características_Específicas)
        CódigoDaClasse_Completo = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "COD", "NOME", "CONTRA PINO")
        form_Nova_Entrada_Instância1.cod_classe.Text = CódigoDaClasse_Completo
        form_Nova_Entrada_Instância1.cod_origem.Text = Mod_Codificação.CriarNovoCódigoDeOrigemParaEsteCodDeClasse_RetornaString(CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.TituloDaClasse.Text = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "NOME", "COD", CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.Show()
    End Sub

    Private Sub bot_parafuso_Click(sender As Object, e As EventArgs) Handles bot_parafuso.Click
        form_Nova_Entrada_Instância1 = New form_Nova_Entrada
        NovaMatériaPrima = New Class_ModeloDeClasseParaCriaçãoDeNovasClassesDeMatériaPrima
        NovaMatériaPrima.LabelDeDimensões_Dimensões = False
        form_Nova_Entrada_Instância1.lab_cus.Text = "Custo p/ Uni"
        NovaMatériaPrima.CaracterísticasQuePopularãoComboBoxes.AddRange({"Material", "Revestimento", "Dureza", "Norma"})
        NovaMatériaPrima.CaracterísticasQuePopularãoTextBoxes.AddRange({"Comprimento (mm)", "Diâmetro (mm)"})
        NovaMatériaPrima.CriarControlesDentroDoControle(form_Nova_Entrada_Instância1.groupbox_Características_Específicas)
        CódigoDaClasse_Completo = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "COD", "NOME", "PARAFUSO")
        form_Nova_Entrada_Instância1.cod_classe.Text = CódigoDaClasse_Completo
        form_Nova_Entrada_Instância1.cod_origem.Text = Mod_Codificação.CriarNovoCódigoDeOrigemParaEsteCodDeClasse_RetornaString(CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.TituloDaClasse.Text = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "NOME", "COD", CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.Show()
    End Sub
    Private Sub bot_porca_Click(sender As Object, e As EventArgs) Handles bot_porca.Click
        form_Nova_Entrada_Instância1 = New form_Nova_Entrada
        NovaMatériaPrima = New Class_ModeloDeClasseParaCriaçãoDeNovasClassesDeMatériaPrima
        NovaMatériaPrima.LabelDeDimensões_Dimensões = False
        form_Nova_Entrada_Instância1.lab_cus.Text = "Custo p/ Uni"
        NovaMatériaPrima.CaracterísticasQuePopularãoComboBoxes.AddRange({"Material", "Revestimento", "Dureza", "Norma"})
        NovaMatériaPrima.CaracterísticasQuePopularãoTextBoxes.AddRange({"Diâmetro (mm)"})
        NovaMatériaPrima.CriarControlesDentroDoControle(form_Nova_Entrada_Instância1.groupbox_Características_Específicas)
        CódigoDaClasse_Completo = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "COD", "NOME", "PORCA")
        form_Nova_Entrada_Instância1.cod_classe.Text = CódigoDaClasse_Completo
        form_Nova_Entrada_Instância1.cod_origem.Text = Mod_Codificação.CriarNovoCódigoDeOrigemParaEsteCodDeClasse_RetornaString(CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.TituloDaClasse.Text = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "NOME", "COD", CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.Show()
    End Sub

    Private Sub bot_vigaH_Click(sender As Object, e As EventArgs) Handles bot_vigaH.Click
        form_Nova_Entrada_Instância1 = New form_Nova_Entrada
        NovaMatériaPrima = New Class_ModeloDeClasseParaCriaçãoDeNovasClassesDeMatériaPrima
        NovaMatériaPrima.LabelDeDimensões_Dimensões = True
        form_Nova_Entrada_Instância1.lab_cus.Text = "Custo p/ KG"
        NovaMatériaPrima.CaracterísticasQuePopularãoComboBoxes.AddRange({"Material", "Dimensões_Perfis"})
        NovaMatériaPrima.CaracterísticasQuePopularãoTextBoxes.AddRange({"Comprimento (mm)"})
        NovaMatériaPrima.CriarControlesDentroDoControle(form_Nova_Entrada_Instância1.groupbox_Características_Específicas)
        CódigoDaClasse_Completo = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "COD", "NOME", "VIGA H")
        form_Nova_Entrada_Instância1.cod_classe.Text = CódigoDaClasse_Completo
        form_Nova_Entrada_Instância1.cod_origem.Text = Mod_Codificação.CriarNovoCódigoDeOrigemParaEsteCodDeClasse_RetornaString(CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.TituloDaClasse.Text = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "NOME", "COD", CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.Show()
    End Sub

    Private Sub bot_vigaHP_Click(sender As Object, e As EventArgs) Handles bot_vigaHP.Click
        form_Nova_Entrada_Instância1 = New form_Nova_Entrada
        NovaMatériaPrima = New Class_ModeloDeClasseParaCriaçãoDeNovasClassesDeMatériaPrima
        NovaMatériaPrima.LabelDeDimensões_Dimensões = True
        form_Nova_Entrada_Instância1.lab_cus.Text = "Custo p/ KG"
        NovaMatériaPrima.CaracterísticasQuePopularãoComboBoxes.AddRange({"Material", "Dimensões_Perfis"})
        NovaMatériaPrima.CaracterísticasQuePopularãoTextBoxes.AddRange({"Comprimento (mm)"})
        NovaMatériaPrima.CriarControlesDentroDoControle(form_Nova_Entrada_Instância1.groupbox_Características_Específicas)
        CódigoDaClasse_Completo = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "COD", "NOME", "VIGA HP")
        form_Nova_Entrada_Instância1.cod_classe.Text = CódigoDaClasse_Completo
        form_Nova_Entrada_Instância1.cod_origem.Text = Mod_Codificação.CriarNovoCódigoDeOrigemParaEsteCodDeClasse_RetornaString(CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.TituloDaClasse.Text = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "NOME", "COD", CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.Show()
    End Sub

    Private Sub bot_vigaI_Click(sender As Object, e As EventArgs) Handles bot_vigaI.Click
        form_Nova_Entrada_Instância1 = New form_Nova_Entrada
        NovaMatériaPrima = New Class_ModeloDeClasseParaCriaçãoDeNovasClassesDeMatériaPrima
        NovaMatériaPrima.LabelDeDimensões_Dimensões = True
        form_Nova_Entrada_Instância1.lab_cus.Text = "Custo p/ KG"
        NovaMatériaPrima.CaracterísticasQuePopularãoComboBoxes.AddRange({"Material", "Dimensões_I"})
        NovaMatériaPrima.CaracterísticasQuePopularãoTextBoxes.AddRange({"Comprimento (mm)"})
        NovaMatériaPrima.CriarControlesDentroDoControle(form_Nova_Entrada_Instância1.groupbox_Características_Específicas)
        CódigoDaClasse_Completo = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "COD", "NOME", "VIGA I")
        form_Nova_Entrada_Instância1.cod_classe.Text = CódigoDaClasse_Completo
        form_Nova_Entrada_Instância1.cod_origem.Text = Mod_Codificação.CriarNovoCódigoDeOrigemParaEsteCodDeClasse_RetornaString(CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.TituloDaClasse.Text = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "NOME", "COD", CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.Show()
    End Sub

    Private Sub bot_vigaU_Click(sender As Object, e As EventArgs) Handles bot_vigaU.Click
        form_Nova_Entrada_Instância1 = New form_Nova_Entrada
        NovaMatériaPrima = New Class_ModeloDeClasseParaCriaçãoDeNovasClassesDeMatériaPrima
        NovaMatériaPrima.LabelDeDimensões_Dimensões = True
        form_Nova_Entrada_Instância1.lab_cus.Text = "Custo p/ KG"
        NovaMatériaPrima.CaracterísticasQuePopularãoComboBoxes.AddRange({"Material", "Dimensões_U"})
        NovaMatériaPrima.CaracterísticasQuePopularãoTextBoxes.AddRange({"Comprimento (mm)"})
        NovaMatériaPrima.CriarControlesDentroDoControle(form_Nova_Entrada_Instância1.groupbox_Características_Específicas)
        CódigoDaClasse_Completo = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "COD", "NOME", "VIGA U")
        form_Nova_Entrada_Instância1.cod_classe.Text = CódigoDaClasse_Completo
        form_Nova_Entrada_Instância1.cod_origem.Text = Mod_Codificação.CriarNovoCódigoDeOrigemParaEsteCodDeClasse_RetornaString(CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.TituloDaClasse.Text = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "NOME", "COD", CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.Show()
    End Sub

    Private Sub bot_vigaW_Click(sender As Object, e As EventArgs) Handles bot_vigaW.Click
        form_Nova_Entrada_Instância1 = New form_Nova_Entrada
        NovaMatériaPrima = New Class_ModeloDeClasseParaCriaçãoDeNovasClassesDeMatériaPrima
        NovaMatériaPrima.LabelDeDimensões_Dimensões = True
        form_Nova_Entrada_Instância1.lab_cus.Text = "Custo p/ KG"
        NovaMatériaPrima.CaracterísticasQuePopularãoComboBoxes.AddRange({"Material", "Dimensões_Perfis"})
        NovaMatériaPrima.CaracterísticasQuePopularãoTextBoxes.AddRange({"Comprimento (mm)"})
        NovaMatériaPrima.CriarControlesDentroDoControle(form_Nova_Entrada_Instância1.groupbox_Características_Específicas)
        CódigoDaClasse_Completo = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "COD", "NOME", "VIGA W")
        form_Nova_Entrada_Instância1.cod_classe.Text = CódigoDaClasse_Completo
        form_Nova_Entrada_Instância1.cod_origem.Text = Mod_Codificação.CriarNovoCódigoDeOrigemParaEsteCodDeClasse_RetornaString(CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.TituloDaClasse.Text = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "NOME", "COD", CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.Show()
    End Sub

    Private Sub PersonalizadaToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles PersonalizadaToolStripMenuItem.Click
        form_Nova_Entrada_Instância1 = New form_Nova_Entrada
        NovaMatériaPrima = New Class_ModeloDeClasseParaCriaçãoDeNovasClassesDeMatériaPrima
        NovaMatériaPrima.LabelDeDimensões_Dimensões = False
        form_Nova_Entrada_Instância1.lab_cus.Text = "Custo p/ Uni"
        NovaMatériaPrima.CaracterísticasQuePopularãoComboBoxes.AddRange({})
        NovaMatériaPrima.CaracterísticasQuePopularãoTextBoxes.AddRange({"Descrição"})
        NovaMatériaPrima.CriarControlesDentroDoControle(form_Nova_Entrada_Instância1.groupbox_Características_Específicas)
        CódigoDaClasse_Completo = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "COD", "NOME", "PERSONALIZADA")
        form_Nova_Entrada_Instância1.cod_classe.Text = CódigoDaClasse_Completo
        form_Nova_Entrada_Instância1.cod_origem.Text = Mod_Codificação.CriarNovoCódigoDeOrigemParaEsteCodDeClasse_RetornaString(CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.TituloDaClasse.Text = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "NOME", "COD", CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.Show()
    End Sub

    Private Sub bot_tubo_Click(sender As Object, e As EventArgs) Handles bot_tubo.Click
        form_Nova_Entrada_Instância1 = New form_Nova_Entrada
        NovaMatériaPrima = New Class_ModeloDeClasseParaCriaçãoDeNovasClassesDeMatériaPrima
        NovaMatériaPrima.LabelDeDimensões_Dimensões = False
        form_Nova_Entrada_Instância1.lab_cus.Text = "Custo p/ KG"
        NovaMatériaPrima.CaracterísticasQuePopularãoComboBoxes.AddRange({"Material", "Espessura", "Norma"})
        NovaMatériaPrima.CaracterísticasQuePopularãoTextBoxes.AddRange({"Comprimento (mm)", "Diâmetro (mm)", "Peso (Kg)"})
        NovaMatériaPrima.CriarControlesDentroDoControle(form_Nova_Entrada_Instância1.groupbox_Características_Específicas)
        CódigoDaClasse_Completo = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "COD", "NOME", "TUBO")
        form_Nova_Entrada_Instância1.cod_classe.Text = CódigoDaClasse_Completo
        form_Nova_Entrada_Instância1.cod_origem.Text = Mod_Codificação.CriarNovoCódigoDeOrigemParaEsteCodDeClasse_RetornaString(CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.TituloDaClasse.Text = BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("TB_CLASSES", "NOME", "COD", CódigoDaClasse_Completo)
        form_Nova_Entrada_Instância1.Show()
    End Sub
    '====================================================================================================================================================================================================
    '====================================================================================================================================================================================================
    '====================================================================================================================================================================================================
    '====================================================================================================================================================================================================
    '====================================================================================================================================================================================================
    '====================================================================================================================================================================================================
    '====================================================================================================================================================================================================
    '====================================================================================================================================================================================================
    '====================================================================================================================================================================================================
    '====================================================================================================================================================================================================
    '====================================================================================================================================================================================================
    '====================================================================================================================================================================================================
    Private Sub CadastrarConsumívelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarConsumívelToolStripMenuItem.Click
        form_Cadastrar_Instância1 = New form_Cadastrar
        form_Cadastrar_Instância1.lab_TipoDeCadastro.Text = "Consumível"
        form_Cadastrar_Instância1.lab_tituloCadastro.Text = "Consumível"
        TabelaCarregadaNoDisplay = "CADASTRO_CONSUMIVEIS"
        form_Cadastrar_Instância1.pic_tipo.Image = My.Resources.weld_64px
        form_Cadastrar_Instância1.Grid_Cadastrar.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, "*", "")
        form_Cadastrar_Instância1.Grid_Cadastrar.AutoResizeColumns()
        form_Cadastrar_Instância1.Grid_Cadastrar.AutoResizeRows()
        form_Cadastrar_Instância1.Show()

    End Sub

    Private Sub CadastrarMatériaPrimaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarMatériaPrimaToolStripMenuItem.Click
        form_Cadastrar_Instância1 = New form_Cadastrar
        form_Cadastrar_Instância1.lab_TipoDeCadastro.Text = "Matéria Prima"
        form_Cadastrar_Instância1.lab_tituloCadastro.Text = "Matéria Prima"
        TabelaCarregadaNoDisplay = "CADASTRO_MATERIA_PRIMA"
        form_Cadastrar_Instância1.pic_tipo.Image = My.Resources.matéria_prima_64px
        form_Cadastrar_Instância1.Grid_Cadastrar.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, "*", "")
        form_Cadastrar_Instância1.Grid_Cadastrar.AutoResizeColumns()
        form_Cadastrar_Instância1.Grid_Cadastrar.AutoResizeRows()
        form_Cadastrar_Instância1.Show()
    End Sub

    Private Sub CadastrarFornecedorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarFornecedorToolStripMenuItem.Click
        form_Cadastrar_Instância1 = New form_Cadastrar
        form_Cadastrar_Instância1.lab_TipoDeCadastro.Text = "Fornecedor"
        form_Cadastrar_Instância1.lab_tituloCadastro.Text = "Fornecedor"
        TabelaCarregadaNoDisplay = "CADASTRO_FORNECEDOR"
        form_Cadastrar_Instância1.pic_tipo.Image = My.Resources.contact_64px
        form_Cadastrar_Instância1.Grid_Cadastrar.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, "*", "")
        form_Cadastrar_Instância1.Grid_Cadastrar.AutoResizeColumns()
        form_Cadastrar_Instância1.Grid_Cadastrar.AutoResizeRows()
        form_Cadastrar_Instância1.Show()
    End Sub

    Private Sub CadastrarMarcaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarMarcaToolStripMenuItem.Click
        form_Cadastrar_Instância1 = New form_Cadastrar
        form_Cadastrar_Instância1.lab_TipoDeCadastro.Text = "Marca"
        form_Cadastrar_Instância1.lab_tituloCadastro.Text = "Marca"
        TabelaCarregadaNoDisplay = "CADASTRO_MARCA"
        form_Cadastrar_Instância1.pic_tipo.Image = My.Resources.marca_64px
        form_Cadastrar_Instância1.Grid_Cadastrar.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, "*", "")
        form_Cadastrar_Instância1.Grid_Cadastrar.AutoResizeColumns()
        form_Cadastrar_Instância1.Grid_Cadastrar.AutoResizeRows()
        form_Cadastrar_Instância1.Show()
    End Sub

    Private Sub CadastrarEquipeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarEquipeToolStripMenuItem.Click
        form_Cadastrar_Instância1 = New form_Cadastrar
        form_Cadastrar_Instância1.lab_TipoDeCadastro.Text = "Equipe"
        form_Cadastrar_Instância1.lab_tituloCadastro.Text = "Equipe"
        TabelaCarregadaNoDisplay = "CADASTRO_EQUIPE"
        form_Cadastrar_Instância1.pic_tipo.Image = My.Resources.team_64px
        form_Cadastrar_Instância1.Grid_Cadastrar.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, "*", "")
        form_Cadastrar_Instância1.Grid_Cadastrar.AutoResizeColumns()
        form_Cadastrar_Instância1.Grid_Cadastrar.AutoResizeRows()
        form_Cadastrar_Instância1.Show()
    End Sub

    Private Sub CadastrarCentroDeCustoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CadastrarCentroDeCustoToolStripMenuItem.Click
        form_Cadastrar_Instância1 = New form_Cadastrar
        form_Cadastrar_Instância1.lab_TipoDeCadastro.Text = "Centro de Custo"
        form_Cadastrar_Instância1.lab_tituloCadastro.Text = "Centro de Custo"
        TabelaCarregadaNoDisplay = "CADASTRO_CENTRO_DE_CUSTO"
        form_Cadastrar_Instância1.pic_tipo.Image = My.Resources.centro_custo_64px
        form_Cadastrar_Instância1.Grid_Cadastrar.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, "*", "")
        form_Cadastrar_Instância1.Grid_Cadastrar.AutoResizeColumns()
        form_Cadastrar_Instância1.Grid_Cadastrar.AutoResizeRows()
        form_Cadastrar_Instância1.Show()
    End Sub
    Private Sub bot_fechar_estoque_Click(sender As Object, e As EventArgs) Handles bot_fechar_estoque.Click
        Fechar(Me)
        Application.Exit()
    End Sub

    Private Sub bot_maximizar_estoque_Click(sender As Object, e As EventArgs) Handles bot_maximizar_estoque.Click
        Maximizar(Me, Me.bot_maximizar_estoque)
    End Sub

    Private Sub bot_minimizar_estoque_Click(sender As Object, e As EventArgs) Handles bot_minimizar_estoque.Click
        Minimizar(Me)
    End Sub
    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Barra.MouseDown
        DraggableForm_Instância1.Mouse_Down(Me, Me.bot_maximizar_estoque)
    End Sub
    Private Sub Me_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Barra.MouseMove
        DraggableForm_Instância1.Mouse_Move(Me)
    End Sub
    Private Sub Me_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Barra.MouseUp
        DraggableForm_Instância1.Mouse_Up()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Excel.CriarNovaPastaDeTrabalhoEmBranco()
    End Sub
End Class