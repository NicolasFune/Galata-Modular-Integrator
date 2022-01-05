Public Class form_ManutençãoDoBancoDeDados
    Dim BancoDeDados As New Class_BancoDeDados

    Private Sub Barra_Manut_MouseDown(sender As Object, e As MouseEventArgs) Handles Barra_Manut.MouseDown
        DraggableForm_Instância1.Mouse_Down(Me, Me.bot_maximizar_manut)
    End Sub

    Private Sub Barra_Manut_MouseMove(sender As Object, e As MouseEventArgs) Handles Barra_Manut.MouseMove
        DraggableForm_Instância1.Mouse_Move(Me)

    End Sub

    Private Sub Barra_Manut_MouseUp(sender As Object, e As MouseEventArgs) Handles Barra_Manut.MouseUp
        DraggableForm_Instância1.Mouse_Up()
    End Sub

    Private Sub bot_fechar_manut_Click(sender As Object, e As EventArgs) Handles bot_fechar_manut.Click
        Mod_Window_State.Fechar(Me)
    End Sub

    Private Sub bot_maximizar_manut_Click(sender As Object, e As EventArgs) Handles bot_maximizar_manut.Click
        Mod_Window_State.Maximizar(Me, Me.bot_maximizar_manut)
    End Sub

    Private Sub bot_minimizar_manut_Click(sender As Object, e As EventArgs) Handles bot_minimizar_manut.Click
        Mod_Window_State.Minimizar(Me)
    End Sub

    Private Sub form_ManutençãoDoBancoDeDados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        combobox_Tabelas.DataSource = BancoDeDados.ColetarOsNomesDasTabelasDoBD_RetornaArray()
    End Sub
    Private Sub combobox_Tabelas_TextChanged(sender As Object, e As EventArgs) Handles combobox_Tabelas.TextChanged
        Me.Grid_Manut.DataSource = BancoDeDados.ConverterTabelaSQLEmDataTable_RetornaDataTable(combobox_Tabelas.Text, "*", "")
        Me.Grid_Manut.AutoResizeColumns()
        combobox_Colunas.DataSource = BancoDeDados.ColetarOsNomesDasColunasDeterminadasDestaTabela_RetornaArrayDeStrings(combobox_Tabelas.Text, "*")
    End Sub

    Private Sub bot_Inserir_Click(sender As Object, e As EventArgs) Handles bot_Inserir.Click
        Dim Dados_ArrayList As New ArrayList
        Dados_ArrayList.Clear()
        For Each line In Me.richbox_Dados.Lines
            Dados_ArrayList.Add(line)
        Next
        BancoDeDados.InserirVariosDadosEmUmaColunaDaTabelaEColunaEspecífica(combobox_Tabelas.Text, combobox_Colunas.Text, Dados_ArrayList)
        Me.Grid_Manut.DataSource = BancoDeDados.ConverterTabelaSQLEmDataTable_RetornaDataTable(combobox_Tabelas.Text, "*", "")
        Me.Grid_Manut.AutoResizeColumns()
        Me.richbox_Dados.Clear()
    End Sub

    Private Sub Grid_Manut_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles Grid_Manut.CellValueChanged
        Dim ActiveColumnName As String
        Dim NovoValor As String
        IDdaLinha = Me.Grid_Manut.Rows.Item(Me.Grid_Manut.CurrentCell.RowIndex).Cells.Item("ID").Value
        If IsDBNull(Me.Grid_Manut.CurrentCell.Value) Then
            NovoValor = ""
        Else
            NovoValor = Me.Grid_Manut.CurrentCell.Value
        End If
        ActiveColumnName = Me.Grid_Manut.Columns.Item(Me.Grid_Manut.CurrentCell.ColumnIndex).Name
        BancoDeDados_Instância1.Atualizar(combobox_Tabelas.Text, ActiveColumnName, NovoValor, IDdaLinha)
        IDdaLinha = Nothing
    End Sub

    Private Sub Grid_Manut_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Grid_Manut.RowHeaderMouseClick
        IDdaLinha = Me.Grid_Manut.Rows.Item(Me.Grid_Manut.CurrentRow.Index).Cells.Item("ID").Value
    End Sub

    Private Sub Grid_Manut_KeyDown(sender As Object, e As KeyEventArgs) Handles Grid_Manut.KeyDown
        If e.KeyCode = Keys.Delete Then
            If IDdaLinha <> Nothing Then
                Dim result As DialogResult = MessageBox.Show("Deseja mesmo deletar todos os dados da linha selecionada?", "Gálata", MessageBoxButtons.YesNoCancel)
                If result = DialogResult.Yes Then
                    BancoDeDados_Instância1.DeletarEsteIDDestaTabela(IDdaLinha, combobox_Tabelas.Text)
                    Me.Grid_Manut.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(combobox_Tabelas.Text, "*", "")
                    Me.Grid_Manut.AutoResizeColumns()
                End If
            End If
        End If
    End Sub
End Class