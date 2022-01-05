Public Class form_Cadastrar
    Private Sub form_Cadastrar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        form_Cadastrar_Instância1.Grid_Cadastrar.Columns.Item("ID").Visible = False
        box_cod.Text = Mod_Codificação.CriarNovoCódigoDeCadastro(TabelaCarregadaNoDisplay)
        form_Cadastrar_Instância1.Grid_Cadastrar.Columns.Item("CODIGO").ReadOnly = True
    End Sub
    Private Sub form_Cadastrar_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        Select Case lab_TipoDeCadastro.Text
            Case "Consumível"
                TabelaCarregadaNoDisplay = "CADASTRO_CONSUMIVEIS"
            Case "Matéria Prima"
                TabelaCarregadaNoDisplay = "CADASTRO_MATERIA_PRIMA"
            Case "Fornecedor"
                TabelaCarregadaNoDisplay = "CADASTRO_FORNECEDOR"
            Case "Marca"
                TabelaCarregadaNoDisplay = "CADASTRO_MARCA"
            Case "Equipe"
                TabelaCarregadaNoDisplay = "CADASTRO_EQUIPE"
            Case "Centro de Custo"
                TabelaCarregadaNoDisplay = "CADASTRO_CENTRO_DE_CUSTO"
        End Select
    End Sub
    Private Sub bot_add_Click(sender As Object, e As EventArgs) Handles bot_add.Click
        Dim Nome As String = box_cadastro.Text.Replace("""", "")
        Dim Código As String = box_cod.Text
        If Nome <> "" And Código <> "" Then
            BancoDeDados_Instância1.InserirDoisDadosEmDuasColunasDaTabelaEspecíficada(TabelaCarregadaNoDisplay, "CODIGO", Código, "NOME", Nome)
            form_Cadastrar_Instância1.Grid_Cadastrar.DataSource = Nothing
            form_Cadastrar_Instância1.Grid_Cadastrar.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, "*", "")
            form_Cadastrar_Instância1.Grid_Cadastrar.Columns.Item("ID").Visible = False
            form_Cadastrar_Instância1.Grid_Cadastrar.AutoResizeColumns()
            form_Cadastrar_Instância1.Grid_Cadastrar.AutoResizeRows()
            box_cod.Text = Mod_Codificação.CriarNovoCódigoDeCadastro(TabelaCarregadaNoDisplay)
        Else
            MessageBox.Show("Preencha o campo")
        End If

    End Sub
    Private Sub bot_incluirCadastrosJaRegistrados_Click(sender As Object, e As EventArgs) Handles bot_incluirCadastrosJaRegistrados.Click

        Dim result As DialogResult = MessageBox.Show("Deseja mesmo coletar todas as descrições dos registros de entradas e transforma-los em cadastros?", "Gálata", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            If BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("Usuários_Senhas", "ACESSO", "Usuário", UsuárioLogado) = 3 Then
                Mod_ProgressBar.Show()
                Select Case TabelaCarregadaNoDisplay
                    Case "CADASTRO_CONSUMIVEIS"
                        BancoDeDados_Instância1.ColetarEAdicionarOsDadosNãoDuplicadosDeUmaColunaDeUmaTabelaEAdicionarEmOutraColunaDeOutraTabela("TB_CONSUMÍVEIS", "DESCRIÇÃO", "CADASTRO_CONSUMIVEIS", "NOME")
                    Case "CADASTRO_FORNECEDOR"
                        BancoDeDados_Instância1.ColetarEAdicionarOsDadosNãoDuplicadosDeUmaColunaDeUmaTabelaEAdicionarEmOutraColunaDeOutraTabela("TB_CONSUMÍVEIS", "FORNECEDOR", "CADASTRO_FORNECEDOR", "NOME")
                    Case "CADASTRO_MARCA"
                        BancoDeDados_Instância1.ColetarEAdicionarOsDadosNãoDuplicadosDeUmaColunaDeUmaTabelaEAdicionarEmOutraColunaDeOutraTabela("TB_CONSUMÍVEIS", "MARCA", "CADASTRO_MARCA", "NOME")
                End Select
                Dim TodosOsNomes As New ArrayList
                Dim TodasAsIDS As New ArrayList
                TodosOsNomes.Clear()
                TodasAsIDS.Clear()
                TodosOsNomes = BancoDeDados_Instância1.ColetarTodosOsDadosNãoNulosDeUmaColunaDeUmaTabela_RetornaArrayList(TabelaCarregadaNoDisplay, "NOME")
                TodasAsIDS = BancoDeDados_Instância1.ColetarTodosOsDadosNãoNulosDeUmaColunaDeUmaTabela_RetornaArrayList(TabelaCarregadaNoDisplay, "ID")
                TodosOsNomes.RemoveAt(0)
                TodasAsIDS.RemoveAt(0)
                Mod_ProgressBar.Max = TodosOsNomes.Count - 1
                For i = 0 To TodosOsNomes.Count - 1
                    BancoDeDados_Instância1.Atualizar(TabelaCarregadaNoDisplay, "CODIGO", Mod_Codificação.CriarNovoCódigoDeCadastro(TabelaCarregadaNoDisplay), TodasAsIDS.Item(i))
                    Mod_ProgressBar.Increment(1)
                Next
                form_Cadastrar_Instância1.Grid_Cadastrar.DataSource = Nothing
                form_Cadastrar_Instância1.Grid_Cadastrar.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, "*", "")
                form_Cadastrar_Instância1.Grid_Cadastrar.Columns.Item("ID").Visible = False
                form_Cadastrar_Instância1.Grid_Cadastrar.AutoResizeColumns()
                form_Cadastrar_Instância1.Grid_Cadastrar.AutoResizeRows()
                box_cod.Text = Mod_Codificação.CriarNovoCódigoDeCadastro(TabelaCarregadaNoDisplay)
                Mod_ProgressBar.FecharForm()
            Else
                MessageBox.Show("Você não tem o nível de acesso necessário para usar essa função")
            End If
        End If





    End Sub
    Private Sub bot_reset_Click(sender As Object, e As EventArgs) Handles bot_reset.Click
        Dim result As DialogResult = MessageBox.Show("Deseja mesmo deletar todos os dados deste cadastro?", "Gálata", MessageBoxButtons.YesNoCancel)
        If result = DialogResult.Yes Then
            If BancoDeDados_Instância1.ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString("Usuários_Senhas", "ACESSO", "Usuário", UsuárioLogado) = 3 Then
                BancoDeDados_Instância1.DeletarTodosOsDadosDestaTabelaMenosAPrimeiraLinhaCore(TabelaCarregadaNoDisplay)
                form_Cadastrar_Instância1.Grid_Cadastrar.DataSource = Nothing
                form_Cadastrar_Instância1.Grid_Cadastrar.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, "*", "")
                form_Cadastrar_Instância1.Grid_Cadastrar.Columns.Item("ID").Visible = False
                form_Cadastrar_Instância1.Grid_Cadastrar.AutoResizeColumns()
                form_Cadastrar_Instância1.Grid_Cadastrar.AutoResizeRows()
                box_cod.Text = Mod_Codificação.CriarNovoCódigoDeCadastro(TabelaCarregadaNoDisplay)
            Else
                MessageBox.Show("Você não tem o nível de acesso necessário para usar essa função")
            End If
        End If

    End Sub
    Private Sub Grid_Cadastrar_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Grid_Cadastrar.RowHeaderMouseClick

        If IsDBNull(Me.Grid_Cadastrar.Rows.Item(Me.Grid_Cadastrar.CurrentRow.Index).Cells.Item("ID").Value) Then
            IDdaLinha = ""
        Else
            IDdaLinha = Me.Grid_Cadastrar.Rows.Item(Me.Grid_Cadastrar.CurrentRow.Index).Cells.Item("ID").Value
        End If


        If IsDBNull(Me.Grid_Cadastrar.Rows.Item(Me.Grid_Cadastrar.CurrentRow.Index).Cells.Item("NOME").Value) Then
            NomeDaLinha = ""
        Else
            NomeDaLinha = Me.Grid_Cadastrar.Rows.Item(Me.Grid_Cadastrar.CurrentRow.Index).Cells.Item("NOME").Value
        End If

    End Sub
    Private Sub Grid_Cadastrar_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_Cadastrar.CellEnter
        If IsDBNull(Me.Grid_Cadastrar.CurrentCell.Value) Then
            ValorAtualDaCélulaQuandoEntraNela = ""
        Else
            ValorAtualDaCélulaQuandoEntraNela = Me.Grid_Cadastrar.CurrentCell.Value
        End If

    End Sub
    Private Sub Grid_Cadastrar_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_Cadastrar.CellValueChanged
        Dim ActiveColumnName As String
        Dim NovoValor As String
        IDdaLinha = Me.Grid_Cadastrar.Rows.Item(Me.Grid_Cadastrar.CurrentCell.RowIndex).Cells.Item("ID").Value
        If IsDBNull(Me.Grid_Cadastrar.CurrentCell.Value) Then
            NovoValor = ""
        Else
            NovoValor = Me.Grid_Cadastrar.CurrentCell.Value
        End If
        ActiveColumnName = Me.Grid_Cadastrar.Columns.Item(Me.Grid_Cadastrar.CurrentCell.ColumnIndex).Name
        If IDdaLinha = 1 Then
            MessageBox.Show("Esta linha não pode ser editada ou deletada por questões de configuração do sistema")
            Me.Grid_Cadastrar.CurrentCell.Value = ValorAtualDaCélulaQuandoEntraNela
        Else
            BancoDeDados_Instância1.Atualizar(TabelaCarregadaNoDisplay, ActiveColumnName, NovoValor, IDdaLinha)
        End If

        IDdaLinha = Nothing
    End Sub

    Private Sub Grid_Cadastrar_KeyDown(sender As Object, e As KeyEventArgs) Handles Grid_Cadastrar.KeyDown

        If e.KeyCode = Keys.Delete And IDdaLinha <> Nothing Then
            Dim result As DialogResult = MessageBox.Show("Deseja mesmo deletar todos os dados da linha selecionada?", "Gálata", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                If IDdaLinha = 1 Then
                    MessageBox.Show("Esta linha não pode ser editada ou deletada por questões de configuração do sistema")
                Else
                    BancoDeDados_Instância1.DeletarEsteIDDestaTabela(IDdaLinha, TabelaCarregadaNoDisplay)
                    Me.Grid_Cadastrar.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, "*", "")
                    form_Cadastrar_Instância1.Grid_Cadastrar.AutoResizeColumns()
                    form_Cadastrar_Instância1.Grid_Cadastrar.AutoResizeRows()
                    box_cod.Text = Mod_Codificação.CriarNovoCódigoDeCadastro(TabelaCarregadaNoDisplay)
                End If

            End If

        End If

    End Sub
    Private Sub bot_search_Click(sender As Object, e As EventArgs) Handles bot_search.Click
        If txtbox_search.Text = "" Then
            Me.Grid_Cadastrar.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, "*", "")
            Me.Grid_Cadastrar.AutoResizeColumns()
            form_Cadastrar_Instância1.Grid_Cadastrar.AutoResizeRows()
        Else
            Me.Grid_Cadastrar.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, "*", Mod_FunçõesVariadas.GerarVetoresDeClausulasWHERE("NOME", txtbox_search.Text))
            Me.Grid_Cadastrar.AutoResizeColumns()
            form_Cadastrar_Instância1.Grid_Cadastrar.AutoResizeRows()
        End If
    End Sub

    Private Sub txtbox_search_KeyDown(sender As Object, e As KeyEventArgs) Handles txtbox_search.KeyDown
        If e.KeyCode = Keys.Enter Then
            If txtbox_search.Text = "" Then
                Me.Grid_Cadastrar.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, "*", "")
                Me.Grid_Cadastrar.AutoResizeColumns()
                form_Cadastrar_Instância1.Grid_Cadastrar.AutoResizeRows()
            Else
                Me.Grid_Cadastrar.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, "*", Mod_FunçõesVariadas.GerarVetoresDeClausulasWHERE("NOME", txtbox_search.Text))
                Me.Grid_Cadastrar.AutoResizeColumns()
                form_Cadastrar_Instância1.Grid_Cadastrar.AutoResizeRows()
            End If
        End If
    End Sub
    Private Sub Barra_MouseDown(sender As Object, e As EventArgs) Handles Barra.MouseDown
        DraggableForm_Instância1.Mouse_Down(Me, Me.bot_MaximizarCadastros)
    End Sub

    Private Sub Barra_MouseMove(sender As Object, e As MouseEventArgs) Handles Barra.MouseMove
        DraggableForm_Instância1.Mouse_Move(Me)
    End Sub

    Private Sub Barra_MouseUp(sender As Object, e As MouseEventArgs) Handles Barra.MouseUp
        DraggableForm_Instância1.Mouse_Up()
    End Sub

    Private Sub bot_fecharCadastros_Click(sender As Object, e As EventArgs) Handles bot_fecharCadastros.Click
        Mod_Window_State.Fechar(Me)
    End Sub

    Private Sub bot_MaximizarCadastros_Click(sender As Object, e As EventArgs) Handles bot_MaximizarCadastros.Click
        Mod_Window_State.Maximizar(Me, Me.bot_MaximizarCadastros)
    End Sub

    Private Sub bot_MinimizarCadastros_Click(sender As Object, e As EventArgs) Handles bot_MinimizarCadastros.Click
        Mod_Window_State.Minimizar(Me)
    End Sub


End Class