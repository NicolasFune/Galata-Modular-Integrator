Public Class form_RegistrosSaídas
    Private Sub Me_Load(sender As Object, e As EventArgs) Handles Me.Load
        Mod_Displays_BotõesDeDisplay.MudarEstadoDoBotãoMatériaPrimaParaPressionado(Me.bot_matpri, Me.bot_consumíveis)
        Mod_Displays_BotõesDeDisplay.CarregarEstaTabelaNesteDisplay("TB_REGISTROS_SAÍDAS_MATPRI", Me.Grid_RegistrosSaídas)
        Mod_Window_State.MaximizarNoLoadEvent(Me)
        combobox_ColunasFiltro.DataSource = BancoDeDados_Instância1.ColetarOsNomesDasColunasDeterminadasDestaTabela_RetornaArrayDeStrings(TabelaCarregadaNoDisplay, ColunasQueIrãoAparecerNoDsiplay_String)

    End Sub
    Private Sub bot_matpri_Click(sender As Object, e As EventArgs) Handles bot_matpri.Click
        Mod_Displays_BotõesDeDisplay.MudarEstadoDoBotãoMatériaPrimaParaPressionado(Me.bot_matpri, Me.bot_consumíveis)
        Mod_Displays_BotõesDeDisplay.CarregarEstaTabelaNesteDisplay("TB_REGISTROS_SAÍDAS_MATPRI", Me.Grid_RegistrosSaídas)
        combobox_ColunasFiltro.DataSource = BancoDeDados_Instância1.ColetarOsNomesDasColunasDeterminadasDestaTabela_RetornaArrayDeStrings(TabelaCarregadaNoDisplay, ColunasQueIrãoAparecerNoDsiplay_String)

    End Sub
    Private Sub bot_consumíveis_Click(sender As Object, e As EventArgs) Handles bot_consumíveis.Click
        Mod_Displays_BotõesDeDisplay.MudarEstadoDoBotãoConsumíveisParaPressionado(Me.bot_matpri, Me.bot_consumíveis)
        Mod_Displays_BotõesDeDisplay.CarregarEstaTabelaNesteDisplay("TB_REGISTROS_SAÍDAS_CON", Me.Grid_RegistrosSaídas)
        combobox_ColunasFiltro.DataSource = BancoDeDados_Instância1.ColetarOsNomesDasColunasDeterminadasDestaTabela_RetornaArrayDeStrings(TabelaCarregadaNoDisplay, ColunasQueIrãoAparecerNoDsiplay_String)

    End Sub
    Private Sub form_RegistrosSaídas_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        DisplayQueIráSerFiltrado_Control = form_RegistrosSaídas_Instância1.Grid_RegistrosSaídas
        If bot_consumíveis.BackColor = Color.FromArgb(0, 100, 100) Then
            TabelaCarregadaNoDisplay = "TB_REGISTROS_SAÍDAS_MATPRI"
        Else
            TabelaCarregadaNoDisplay = "TB_REGISTROS_SAÍDAS_CON"
        End If

    End Sub
    Private Sub Grid_RegistrosSaídas_DataSourceChanged(sender As Object, e As EventArgs) Handles Grid_RegistrosSaídas.DataSourceChanged

        If IsNothing(Me.Grid_RegistrosSaídas.DataSource) Then
        Else
            Me.Grid_RegistrosSaídas.Columns.Item("ID").Visible = False
        End If
        If Me.Grid_RegistrosSaídas.Rows.Count > 1 Then
            Me.Grid_RegistrosSaídas.FirstDisplayedScrollingRowIndex = Me.Grid_RegistrosSaídas.RowCount - 1
            Me.Grid_RegistrosSaídas.Rows(Me.Grid_RegistrosSaídas.Rows.Count - 1).Selected = True
        End If

    End Sub
    Private Sub combobox_ColunasFiltro_SelectedValueChanged(sender As Object, e As EventArgs) Handles combobox_ColunasFiltro.SelectedValueChanged
        ColunaSelecionadaNoFiltro = Me.combobox_ColunasFiltro.Text
    End Sub
    Private Sub bot_search_Click(sender As Object, e As EventArgs) Handles bot_search.Click
        ColunasQueIrãoAparecerNoDsiplay_String = "*"
        If txtbox_search.Text = "" Then
            Me.Grid_RegistrosSaídas.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, ColunasQueIrãoAparecerNoDsiplay_String, "")
            Me.Grid_RegistrosSaídas.AutoResizeColumns()

        Else
            Me.Grid_RegistrosSaídas.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, ColunasQueIrãoAparecerNoDsiplay_String, Mod_FunçõesVariadas.GerarVetoresDeClausulasWHERE(combobox_ColunasFiltro.Text, txtbox_search.Text))
            Me.Grid_RegistrosSaídas.AutoResizeColumns()

        End If
        combobox_ColunasFiltro.SelectedItem = ColunaSelecionadaNoFiltro
    End Sub
    Private Sub txtbox_search_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_search.KeyDown
        ColunasQueIrãoAparecerNoDsiplay_String = "*"
        If e.KeyCode = Keys.Enter Then
            If txtbox_search.Text = "" Then
                Me.Grid_RegistrosSaídas.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, ColunasQueIrãoAparecerNoDsiplay_String, "")
                Me.Grid_RegistrosSaídas.AutoResizeColumns()

            Else
                Me.Grid_RegistrosSaídas.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, ColunasQueIrãoAparecerNoDsiplay_String, Mod_FunçõesVariadas.GerarVetoresDeClausulasWHERE(combobox_ColunasFiltro.Text, txtbox_search.Text))
                Me.Grid_RegistrosSaídas.AutoResizeColumns()
            End If
            combobox_ColunasFiltro.SelectedItem = ColunaSelecionadaNoFiltro
        End If
    End Sub
    Private Sub Barra_RegistrosSaídas_MouseDown(sender As Object, e As MouseEventArgs) Handles Barra_RegistrosSaídas.MouseDown
        DraggableForm_Instância1.Mouse_Down(Me, Me.bot_maximizarRegistrosSaídas)
    End Sub

    Private Sub Barra_RegistrosSaídas_MouseMove(sender As Object, e As MouseEventArgs) Handles Barra_RegistrosSaídas.MouseMove
        DraggableForm_Instância1.Mouse_Move(Me)
    End Sub

    Private Sub Barra_RegistrosSaídas_MouseUp(sender As Object, e As MouseEventArgs) Handles Barra_RegistrosSaídas.MouseUp
        DraggableForm_Instância1.Mouse_Up()
    End Sub

    Private Sub bot_minimizarRegistrosSaídas_Click(sender As Object, e As EventArgs) Handles bot_minimizarRegistrosSaídas.Click
        Mod_Window_State.Minimizar(Me)
    End Sub

    Private Sub bot_maximizarRegistrosSaídas_Click(sender As Object, e As EventArgs) Handles bot_maximizarRegistrosSaídas.Click
        Mod_Window_State.Maximizar(Me, Me.bot_maximizarRegistrosSaídas)
    End Sub

    Private Sub bot_fecharRegistrosSaídas_Click(sender As Object, e As EventArgs) Handles bot_fecharRegistrosSaídas.Click
        Mod_Window_State.Fechar(Me)
    End Sub




End Class