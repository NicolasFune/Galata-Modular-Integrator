Public Class form_NovaEntrada_Consumível
    Private Sub form_NovaEntrada_Consumível_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        form_NovaEntrada_Consumível_Instância1.box_des.DataSource = BancoDeDados_Instância1.ColetarTodosOsDadosNãoNulosDeUmaColunaDeUmaTabela_RetornaArrayList("CADASTRO_CONSUMIVEIS", "NOME")
        form_NovaEntrada_Consumível_Instância1.box_for.DataSource = BancoDeDados_Instância1.ColetarTodosOsDadosNãoNulosDeUmaColunaDeUmaTabela_RetornaArrayList("CADASTRO_FORNECEDOR", "NOME")
        form_NovaEntrada_Consumível_Instância1.box_mar.DataSource = BancoDeDados_Instância1.ColetarTodosOsDadosNãoNulosDeUmaColunaDeUmaTabela_RetornaArrayList("CADASTRO_MARCA", "NOME")

        If OformEstaSendoChamadoParaEditarDados Then

            cod_rastreio.Text = RastreioDaLinha
            form_NovaEntrada_Consumível_Instância1.box_des.Text = DescriçãoDaLinha
            form_NovaEntrada_Consumível_Instância1.box_for.Text = FornecedorDaLinha
            form_NovaEntrada_Consumível_Instância1.box_mar.Text = MarcaDaLinha
            form_NovaEntrada_Consumível_Instância1.box_dataChegada.Text = DataDeChegadaDaLinha
            form_NovaEntrada_Consumível_Instância1.box_qua.Value = CDbl(QuantidadeDaLinha)
            form_NovaEntrada_Consumível_Instância1.box_cus.Value = CDbl(CustoPorUniDaLinha)
            form_NovaEntrada_Consumível_Instância1.box_nota.Text = NumeroDaNotaDaLinha
        Else
            cod_rastreio.Text = Mod_Codificação.CriarNovoCódigoDeRastreioParaEstaEntradaDeConsumível()
        End If


    End Sub
    Private Sub Barra_MouseDown(sender As Object, e As MouseEventArgs) Handles Barra.MouseDown
        DraggableForm_Instância1.Mouse_Down(Me, Me.bot_maximizar_NovaEntradaConsumível)
    End Sub

    Private Sub Barra_MouseUp(sender As Object, e As MouseEventArgs) Handles Barra.MouseUp
        DraggableForm_Instância1.Mouse_Up()
    End Sub

    Private Sub Barra_MouseMove(sender As Object, e As MouseEventArgs) Handles Barra.MouseMove
        DraggableForm_Instância1.Mouse_Move(Me)
    End Sub

    Private Sub bot_fecharNovaEntradaConsumível_Click(sender As Object, e As EventArgs) Handles bot_fecharNovaEntradaConsumível.Click
        Mod_Window_State.Fechar(Me)
    End Sub

    Private Sub bot_maximizar_NovaEntradaConsumível_Click(sender As Object, e As EventArgs) Handles bot_maximizar_NovaEntradaConsumível.Click
        Mod_Window_State.Maximizar(Me, Me.bot_maximizar_NovaEntradaConsumível)
    End Sub

    Private Sub bot_minimizar_NovaEntradaConsumível_Click(sender As Object, e As EventArgs) Handles bot_minimizar_NovaEntradaConsumível.Click
        Mod_Window_State.Minimizar(Me)
    End Sub
    Private Sub bot_cancel_Click(sender As Object, e As EventArgs) Handles bot_cancel.Click
        Me.Close()
    End Sub

    Private Sub bot_ok_Click(sender As Object, e As EventArgs) Handles bot_ok.Click

        BancoDeDados_Consumíveis_Instância1 = New Class_BancoDeDados.Consumíveis

        If OformEstaSendoChamadoParaEditarDados Then
            BancoDeDados_Consumíveis_Instância1.EditarDadosNaTabelaConsumíveis()
            form_RegistrosEntradas_Instância1.bot_matpriEntradas.BackColor = Color.FromArgb(0, 100, 100)
            form_RegistrosEntradas_Instância1.bot_consumíveisEntradas.BackColor = Color.FromArgb(0, 200, 200)
            form_RegistrosEntradas_Instância1.Grid_RegistrosEntradas.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, "*", "")
            form_RegistrosEntradas_Instância1.Grid_RegistrosEntradas.AutoResizeColumns()
            form_RegistrosEntradas_Instância1.Grid_RegistrosEntradas.FirstDisplayedScrollingRowIndex = IndexDaLinha
            form_RegistrosEntradas_Instância1.Grid_RegistrosEntradas.Rows.Item(IndexDaLinha).Selected = True
            IDdaLinha = Nothing
            IndexDaLinha = Nothing
        Else
            BancoDeDados_Consumíveis_Instância1.InserirDadosNaTabelaDeConsumíveis("TB_CONSUMÍVEIS")
            form_Estoque_Instância1.bot_matpri.BackColor = Color.FromArgb(0, 100, 100)
            form_Estoque_Instância1.bot_consumíveis.BackColor = Color.FromArgb(0, 200, 200)
            form_Estoque_Instância1.Grid.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable(TabelaCarregadaNoDisplay, "*", "")
            form_Estoque_Instância1.Grid.AutoResizeColumns()
        End If
        Me.Close()

    End Sub
End Class