Public Class form_RegistrosEntradas
    Private Sub form_RegistrosEntradas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mod_Displays_BotõesDeDisplay.MudarEstadoDoBotãoMatériaPrimaParaPressionado(Me.bot_matpriEntradas, Me.bot_consumíveisEntradas)
        Mod_Displays_BotõesDeDisplay.CarregarEstaTabelaNesteDisplay("TB_REGISTROS_ENTRADAS_MATPRI", Me.Grid_RegistrosEntradas)
        Mod_Window_State.MaximizarNoLoadEvent(Me)
        combobox_ColunasFiltro.DataSource = BancoDeDados_Instância1.ColetarOsNomesDasColunasDeterminadasDestaTabela_RetornaArrayDeStrings(TabelaCarregadaNoDisplay, ColunasQueIrãoAparecerNoDsiplay_String)
        IDdaLinha = Nothing
        IndexDaLinha = Nothing

    End Sub
    Private Sub bot_matpriEntradas_Click(sender As Object, e As EventArgs) Handles bot_matpriEntradas.Click
        Mod_Displays_BotõesDeDisplay.MudarEstadoDoBotãoMatériaPrimaParaPressionado(Me.bot_matpriEntradas, Me.bot_consumíveisEntradas)
        Mod_Displays_BotõesDeDisplay.CarregarEstaTabelaNesteDisplay("TB_REGISTROS_ENTRADAS_MATPRI", Me.Grid_RegistrosEntradas)
        combobox_ColunasFiltro.DataSource = BancoDeDados_Instância1.ColetarOsNomesDasColunasDeterminadasDestaTabela_RetornaArrayDeStrings(TabelaCarregadaNoDisplay, ColunasQueIrãoAparecerNoDsiplay_String)
        If Me.Grid_RegistrosEntradas.Rows.Count > 1 Then
            Me.Grid_RegistrosEntradas.FirstDisplayedScrollingRowIndex = Me.Grid_RegistrosEntradas.RowCount - 1
            Me.Grid_RegistrosEntradas.Rows(Me.Grid_RegistrosEntradas.Rows.Count - 1).Selected = True
        End If
    End Sub

    Private Sub bot_consumíveisEntradas_Click(sender As Object, e As EventArgs) Handles bot_consumíveisEntradas.Click
        Mod_Displays_BotõesDeDisplay.MudarEstadoDoBotãoConsumíveisParaPressionado(Me.bot_matpriEntradas, Me.bot_consumíveisEntradas)
        Mod_Displays_BotõesDeDisplay.CarregarEstaTabelaNesteDisplay("TB_CONSUMÍVEIS", Me.Grid_RegistrosEntradas)
        combobox_ColunasFiltro.DataSource = BancoDeDados_Instância1.ColetarOsNomesDasColunasDeterminadasDestaTabela_RetornaArrayDeStrings(TabelaCarregadaNoDisplay, ColunasQueIrãoAparecerNoDsiplay_String)
        If Me.Grid_RegistrosEntradas.Rows.Count > 1 Then
            Me.Grid_RegistrosEntradas.FirstDisplayedScrollingRowIndex = Me.Grid_RegistrosEntradas.RowCount - 1
            Me.Grid_RegistrosEntradas.Rows(Me.Grid_RegistrosEntradas.Rows.Count - 1).Selected = True
        End If
    End Sub
    Private Sub form_RegistrosEntradas_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        DisplayQueIráSerFiltrado_Control = form_RegistrosEntradas_Instância1.Grid_RegistrosEntradas
        If bot_matpriEntradas.BackColor = Color.FromArgb(0, 200, 200) Then
            TabelaCarregadaNoDisplay = "TB_REGISTROS_ENTRADAS_MATPRI"
        Else
            TabelaCarregadaNoDisplay = "TB_CONSUMÍVEIS"
        End If

    End Sub
    Private Sub bot_editar_Click(sender As Object, e As EventArgs) Handles bot_editar.Click
        If IDdaLinha <> Nothing And IndexDaLinha <> Nothing Then
            form_NovaEntrada_Consumível_Instância1 = New form_NovaEntrada_Consumível
            OformEstaSendoChamadoParaEditarDados = True
            form_NovaEntrada_Consumível_Instância1.Show()
        Else
            MessageBox.Show("Por gentileza selecione um registro selecionando a linha completa clicando em seu cabeçalho horizontal")
        End If

    End Sub

    Private Sub bot_deletar_Click(sender As Object, e As EventArgs) Handles bot_deletar.Click
        If IDdaLinha <> Nothing And IndexDaLinha <> Nothing Then
            Dim result As DialogResult = MessageBox.Show("Deseja mesmo deletar todos os dados da linha selecionada?", "Gálata", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                BancoDeDados_Instância1.DeletarEsteIDDestaTabela(IDdaLinha, TabelaCarregadaNoDisplay)
                Me.Grid_RegistrosEntradas.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, "*", "")
                Me.Grid_RegistrosEntradas.AutoResizeColumns()
                form_RegistrosEntradas_Instância1.Grid_RegistrosEntradas.FirstDisplayedScrollingRowIndex = IndexDaLinha
                form_RegistrosEntradas_Instância1.Grid_RegistrosEntradas.Rows.Item(IndexDaLinha).Selected = True
                IDdaLinha = Nothing
                IndexDaLinha = Nothing
            End If
        Else
            MessageBox.Show("Por gentileza selecione um registro selecionando a linha completa clicando em seu cabeçalho horizontal")
        End If

    End Sub
    Private Sub Grid_RegistrosEntradas_DataSourceChanged(sender As Object, e As EventArgs) Handles Grid_RegistrosEntradas.DataSourceChanged

        If IsNothing(Me.Grid_RegistrosEntradas.DataSource) Then
        Else
            Me.Grid_RegistrosEntradas.Columns.Item("ID").Visible = False
            Me.Grid_RegistrosEntradas.ReadOnly = True
        End If



    End Sub
    Private Sub combobox_ColunasFiltro_SelectedValueChanged(sender As Object, e As EventArgs) Handles combobox_ColunasFiltro.SelectedValueChanged
        ColunaSelecionadaNoFiltro = Me.combobox_ColunasFiltro.Text
    End Sub
    Private Sub bot_search_Click(sender As Object, e As EventArgs) Handles bot_search.Click
        ColunasQueIrãoAparecerNoDsiplay_String = "*"
        If txtbox_search.Text = "" Then
            Me.Grid_RegistrosEntradas.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, ColunasQueIrãoAparecerNoDsiplay_String, "")
            Me.Grid_RegistrosEntradas.AutoResizeColumns()

        Else
            Me.Grid_RegistrosEntradas.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, ColunasQueIrãoAparecerNoDsiplay_String, Mod_FunçõesVariadas.GerarVetoresDeClausulasWHERE(combobox_ColunasFiltro.Text, txtbox_search.Text))
            Me.Grid_RegistrosEntradas.AutoResizeColumns()

        End If
        combobox_ColunasFiltro.SelectedItem = ColunaSelecionadaNoFiltro
    End Sub
    Private Sub txtbox_search_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_search.KeyDown, box_cod.KeyDown
        ColunasQueIrãoAparecerNoDsiplay_String = "*"
        If e.KeyCode = Keys.Enter Then
            If txtbox_search.Text = "" Then
                Me.Grid_RegistrosEntradas.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, ColunasQueIrãoAparecerNoDsiplay_String, "")
                Me.Grid_RegistrosEntradas.AutoResizeColumns()

            Else
                Me.Grid_RegistrosEntradas.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, ColunasQueIrãoAparecerNoDsiplay_String, Mod_FunçõesVariadas.GerarVetoresDeClausulasWHERE(combobox_ColunasFiltro.Text, txtbox_search.Text))
                Me.Grid_RegistrosEntradas.AutoResizeColumns()
            End If
            combobox_ColunasFiltro.SelectedItem = ColunaSelecionadaNoFiltro
        End If
    End Sub
    Private Sub bot_NovaSaída_Click(sender As Object, e As EventArgs) Handles bot_NovaSaída.Click
        If box_cod.Text <> "" Then
            form_NovaSaída_Instância1 = New form_NovaSaída
            form_NovaSaída_Instância1.Show()
        Else
            MessageBox.Show("Selecione uma linha válida por gentileza", "Gálata")
        End If
    End Sub
    '............................................................................................................................................................................................................................................................................................................
    '............................................................................................................................................................................................................................................................................................................
    '............................................................................................................................................................................................................................................................................................................
    '............................................................................................................................................................................................................................................................................................................
    '............................................................................................................................................................................................................................................................................................................
    '............................................................................................................................................................................................................................................................................................................
    '............................................................................................................................................................................................................................................................................................................
    '............................................................................................................................................................................................................................................................................................................
    '............................................................................................................................................................................................................................................................................................................
    '............................................................................................................................................................................................................................................................................................................
    'Private Sub Grid_RegistrosEntradas_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
    '    Dim ActiveColumnName As String
    '    Dim NovoValor As String
    '    If Me.Grid_RegistrosEntradas.CurrentCell.RowIndex = 0 And AtualLinhaÉALinhaCore Then
    '        MessageBox.Show("Os dados desta linha não podem ser alterados por questões de configuração do sistema")
    '        Me.Grid_RegistrosEntradas.CurrentCell.Value = ValorAtualDaCélulaQuandoEntraNela
    '        Exit Sub
    '    Else
    '        IDdaLinha = Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentCell.RowIndex).Cells.Item("ID").Value
    '        If IsDBNull(Me.Grid_RegistrosEntradas.CurrentCell.Value) Then
    '            NovoValor = ""
    '        Else
    '            NovoValor = Me.Grid_RegistrosEntradas.CurrentCell.Value
    '        End If
    '        ActiveColumnName = Me.Grid_RegistrosEntradas.Columns.Item(Me.Grid_RegistrosEntradas.CurrentCell.ColumnIndex).Name
    '        BancoDeDados_Instância1.Atualizar(TabelaCarregadaNoDisplay, ActiveColumnName, NovoValor, IDdaLinha)
    '        BancoDeDados_Instância1.Atualizar(TabelaCarregadaNoDisplay, "DATA_ALTERAÇÃO", Now, IDdaLinha)
    '        IDdaLinha = Nothing

    '    End If

    'End Sub
    'Private Sub Grid_RegistrosEntradas_CellEnter(sender As Object, e As DataGridViewCellEventArgs)
    '    If IsDBNull(Me.Grid_RegistrosEntradas.CurrentCell.Value) Then
    '        ValorAtualDaCélulaQuandoEntraNela = ""
    '    Else
    '        ValorAtualDaCélulaQuandoEntraNela = Me.Grid_RegistrosEntradas.CurrentCell.Value
    '        If Me.Grid_RegistrosEntradas.CurrentRow.Index = 0 Then
    '            AtualLinhaÉALinhaCore = True
    '        Else
    '            AtualLinhaÉALinhaCore = False
    '        End If
    '    End If

    'End Sub
    Private Sub Grid_RegistrosEntradas_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Grid_RegistrosEntradas.RowHeaderMouseClick
        IndexDaLinha = Me.Grid_RegistrosEntradas.SelectedRows.Item(0).Index

        If IsDBNull(Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("DESCRIÇÃO").Value) Then
            DescriçãoDaLinha = ""
        Else
            DescriçãoDaLinha = Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("DESCRIÇÃO").Value
        End If

        If Me.Grid_RegistrosEntradas.CurrentRow.Index = 0 Then
            AtualLinhaÉALinhaCore = True
        Else
            AtualLinhaÉALinhaCore = False
        End If

        If TabelaCarregadaNoDisplay = "TB_MAT_PRI" Then
            IDdaLinha = Nothing
            DescriçãoDaLinha = Nothing
            OrigemDaLinha = Nothing
            QuantidadeDaLinha = Nothing
            PesoDaLinha = Nothing
            CustoPorUniDaLinha = Nothing
            CustoPorKiloDaLinha = Nothing


            If IsDBNull(Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("ID").Value) Then
                IDdaLinha = ""
            Else
                IDdaLinha = Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("ID").Value
            End If


            If IsDBNull(Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("COD_ORIGEM").Value) Then
                OrigemDaLinha = ""
            Else
                OrigemDaLinha = Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("COD_ORIGEM").Value
            End If


            If IsDBNull(Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("QUANTIDADE").Value) Then
                QuantidadeDaLinha = ""
            Else
                QuantidadeDaLinha = Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("QUANTIDADE").Value
            End If


            If IsDBNull(Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("PESO").Value) Then
                PesoDaLinha = ""
            Else
                PesoDaLinha = Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("PESO").Value
            End If


            If PesoDaLinha = "n/a" Then
                If IsDBNull(Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("CUSTO").Value) Then
                    CustoPorUniDaLinha = ""
                Else
                    CustoPorUniDaLinha = Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("CUSTO").Value
                    CustoPorKiloDaLinha = "n/a"
                End If


            ElseIf PesoDaLinha <> "n/a" Then
                If IsDBNull(Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("CUSTO").Value) Then
                    CustoPorKiloDaLinha = ""
                Else
                    CustoPorKiloDaLinha = Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("CUSTO").Value
                    CustoPorUniDaLinha = "n/a"
                End If

            End If

        ElseIf TabelaCarregadaNoDisplay = "TB_CONSUMÍVEIS" Then
            IDdaLinha = Nothing
            DescriçãoDaLinha = Nothing
            RastreioDaLinha = Nothing
            QuantidadeDaLinha = Nothing
            CustoPorUniDaLinha = Nothing
            RastreioDaLinha = Nothing

            If IsDBNull(Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("CUSTO").Value) Then
                CustoPorUniDaLinha = ""
            Else
                CustoPorUniDaLinha = Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("CUSTO").Value
            End If


            If IsDBNull(Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("QUANTIDADE").Value) Then
                QuantidadeDaLinha = ""
            Else
                QuantidadeDaLinha = Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("QUANTIDADE").Value
            End If


            If IsDBNull(Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("COD_RASTREIO").Value) Then
                RastreioDaLinha = ""
            Else
                RastreioDaLinha = Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("COD_RASTREIO").Value
            End If


            If IsDBNull(Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("ID").Value) Then
                IDdaLinha = ""
            Else
                IDdaLinha = Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("ID").Value
            End If


            If IsDBNull(Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("DESCRIÇÃO").Value) Then
                DescriçãoDaLinha = ""
            Else
                DescriçãoDaLinha = Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("DESCRIÇÃO").Value
            End If


            If IsDBNull(Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("FORNECEDOR").Value) Then
                FornecedorDaLinha = ""
            Else
                FornecedorDaLinha = Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("FORNECEDOR").Value
            End If


            If IsDBNull(Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("DATA_CHEGADA").Value) Then
                DataDeChegadaDaLinha = ""
            Else
                DataDeChegadaDaLinha = Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("DATA_CHEGADA").Value
            End If


            If IsDBNull(Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("NOTA_FISCAL").Value) Then
                NumeroDaNotaDaLinha = ""
            Else
                NumeroDaNotaDaLinha = Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("NOTA_FISCAL").Value
            End If


            If IsDBNull(Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("MARCA").Value) Then
                MarcaDaLinha = ""
            Else
                MarcaDaLinha = Me.Grid_RegistrosEntradas.Rows.Item(Me.Grid_RegistrosEntradas.CurrentRow.Index).Cells.Item("MARCA").Value
            End If
            Me.box_cod.Text = RastreioDaLinha

        End If
    End Sub

    Private Sub Grid_RegistrosEntradas_KeyDown(sender As Object, e As KeyEventArgs) Handles Grid_RegistrosEntradas.KeyDown
        If e.KeyCode = Keys.Delete Then
            If AtualLinhaÉALinhaCore Then
                MessageBox.Show("Os dados desta linha não podem ser deletados por questões de configuração do sistema")
                Exit Sub
            End If
            If IDdaLinha <> Nothing Then
                Dim result As DialogResult = MessageBox.Show("Deseja mesmo deletar todos os dados da linha selecionada?", "Gálata", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Yes Then
                    BancoDeDados_Instância1.DeletarEsteIDDestaTabela(IDdaLinha, TabelaCarregadaNoDisplay)
                    Me.Grid_RegistrosEntradas.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, "*", "")
                    Me.Grid_RegistrosEntradas.AutoResizeColumns()
                End If
            End If
        End If

    End Sub
    Private Sub Barra_RegistrosEntradas_MouseDown(sender As Object, e As MouseEventArgs) Handles Barra_RegistrosEntradas.MouseDown
        DraggableForm_Instância1.Mouse_Down(Me, Me.bot_maximizarRegistrosEntradas)
    End Sub

    Private Sub Barra_RegistrosEntradas_MouseMove(sender As Object, e As MouseEventArgs) Handles Barra_RegistrosEntradas.MouseMove
        DraggableForm_Instância1.Mouse_Move(Me)
    End Sub

    Private Sub Barra_RegistrosEntradas_MouseUp(sender As Object, e As MouseEventArgs) Handles Barra_RegistrosEntradas.MouseUp
        DraggableForm_Instância1.Mouse_Up()
    End Sub

    Private Sub bot_fecharRegistrosEntradas_Click(sender As Object, e As EventArgs) Handles bot_fecharRegistrosEntradas.Click
        Mod_Window_State.Fechar(Me)
    End Sub

    Private Sub bot_maximizarRegistrosEntradas_Click(sender As Object, e As EventArgs) Handles bot_maximizarRegistrosEntradas.Click
        Mod_Window_State.Maximizar(Me, Me.bot_maximizarRegistrosEntradas)
    End Sub

    Private Sub bot_minimizarRegistrosEntradas_Click(sender As Object, e As EventArgs) Handles bot_minimizarRegistrosEntradas.Click
        Mod_Window_State.Minimizar(Me)
    End Sub


End Class