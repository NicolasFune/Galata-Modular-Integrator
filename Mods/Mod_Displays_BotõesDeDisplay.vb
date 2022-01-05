Module Mod_Displays_BotõesDeDisplay
    Public Sub CarregarEstaTabelaNesteDisplay(TabelaSQL As String, DataGridView As DataGridView)
        TabelaCarregadaNoDisplay = TabelaSQL
        DisplayQueIráSerFiltrado_Control = DataGridView
        DataGridView.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, "*", " ORDER BY DESCRIÇÃO ASC")
        DataGridView.AutoResizeColumns()
    End Sub
    Public Sub MudarEstadoDoBotãoMatériaPrimaParaPressionado(Botão_MatériaPrima As Button, Botão_Consumíveis As Button)
        Botão_MatériaPrima.BackColor = Color.FromArgb(0, 200, 200)
        Botão_Consumíveis.BackColor = Color.FromArgb(0, 100, 100)
    End Sub
    Public Sub MudarEstadoDoBotãoConsumíveisParaPressionado(Botão_MatériaPrima As Button, Botão_Consumíveis As Button)
        Botão_MatériaPrima.BackColor = Color.FromArgb(0, 100, 100)
        Botão_Consumíveis.BackColor = Color.FromArgb(0, 200, 200)
    End Sub
End Module
