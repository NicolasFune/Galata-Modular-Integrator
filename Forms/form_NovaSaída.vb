Public Class form_NovaSaída
    Private Sub Me_Load(Sender As Object, e As EventArgs) Handles Me.Load
        If TabelaCarregadaNoDisplay = "TB_MAT_PRI" Then
            box_equ.Enabled = False
            box_req.Enabled = False
            lab_tipoSaída.Text = "Matéria Prima"
            lab_codOrigem.Text = OrigemDaLinha
            lab_Descrição.Text = DescriçãoDaLinha
            lab_pes.Text = PesoDaLinha
            lab_qua.Text = QuantidadeDaLinha
            If PesoDaLinha = "n/a" Then
                lab_cus.Text = CustoPorUniDaLinha
            ElseIf PesoDaLinha <> "n/a" Then
                lab_cus.Text = CustoPorKiloDaLinha
            End If
        ElseIf TabelaCarregadaNoDisplay = "TB_CONSUMÍVEIS" Then
            box_equ.Enabled = True
            box_req.Enabled = True
            lab_tipoSaída.Text = "Consumível"
            lab_codOrigem.Text = RastreioDaLinha
            lab_Descrição.Text = DescriçãoDaLinha
            lab_qua.Text = QuantidadeDaLinha
            lab_pes.Text = "n/a"
            lab_cus.Text = CustoPorUniDaLinha
        End If
        box_os.DataSource = BancoDeDados_Instância1.ColetarTodosOsDadosNãoNulosDeUmaColunaDeUmaTabela_RetornaArrayList("TB_CARACTERÍSTICAS", "OS")
        box_equ.DataSource = BancoDeDados_Instância1.ColetarTodosOsDadosNãoNulosDeUmaColunaDeUmaTabela_RetornaArrayList("CADASTRO_EQUIPE", "NOME")

    End Sub
    Private Sub Barra_Padrão_MouseDown(sender As Object, e As MouseEventArgs) Handles Barra_Padrão.MouseDown
        DraggableForm_Instância1.Mouse_Down(Me, Me.bot_Maximizar_Padrão)
    End Sub

    Private Sub Barra_Padrão_MouseMove(sender As Object, e As MouseEventArgs) Handles Barra_Padrão.MouseMove
        DraggableForm_Instância1.Mouse_Move(Me)
    End Sub

    Private Sub Barra_Padrão_MouseUp(sender As Object, e As MouseEventArgs) Handles Barra_Padrão.MouseUp
        DraggableForm_Instância1.Mouse_Up()
    End Sub

    Private Sub bot_Fechar_Padrão_Click(sender As Object, e As EventArgs) Handles bot_Fechar_Padrão.Click
        Mod_Window_State.Fechar(Me)
    End Sub

    Private Sub bot_Maximizar_Padrão_Click(sender As Object, e As EventArgs) Handles bot_Maximizar_Padrão.Click
        Mod_Window_State.Maximizar(Me, Me.bot_Maximizar_Padrão)
    End Sub

    Private Sub bot_Minimizar_Padrão_Click(sender As Object, e As EventArgs) Handles bot_Minimizar_Padrão.Click
        Mod_Window_State.Minimizar(Me)
    End Sub

    Private Sub bot_NovaSaída_Click(sender As Object, e As EventArgs) Handles bot_NovaSaída.Click
        If TabelaCarregadaNoDisplay = "TB_MAT_PRI" Then
            NovaSaída = New Class_BancoDeDados.Saídas
            NovaSaída.Origem = OrigemDaLinha
            NovaSaída.Descrição = DescriçãoDaLinha
            NovaSaída.OS = Me.box_os.Text
            NovaSaída.QuantUni = Me.box_qua.Text
            NovaSaída.Usuário = UsuárioLogado
            NovaSaída.DataDaSaída = Me.box_data.Text
            If CustoPorKiloDaLinha = "n/a" Then
                NovaSaída.Valor = CStr(CDbl(CustoPorUniDaLinha) * CDbl(box_qua.Text))
                NovaSaída.QuantKilo = "n/a"
                QuantidadeApósSaída = CStr(CDbl(QuantidadeDaLinha) - CDbl(box_qua.Text))
                BancoDeDados_Instância1.Atualizar("TB_MAT_PRI", "QUANTIDADE", QuantidadeApósSaída, IDdaLinha)
            ElseIf CustoPorKiloDaLinha <> "n/a" Then
                KiloporUni = CDbl(PesoDaLinha) / CDbl(QuantidadeDaLinha)
                MassaQueIráSair = CStr(KiloporUni * CDbl(box_qua.Text))
                NovaSaída.Valor = CStr(CDbl(CustoPorKiloDaLinha) * CDbl(MassaQueIráSair))
                NovaSaída.QuantKilo = MassaQueIráSair
                PesoApósSaída = CStr(CDbl(PesoDaLinha) - CDbl(MassaQueIráSair))
                QuantidadeApósSaída = CStr(CDbl(QuantidadeDaLinha) - CDbl(box_qua.Text))
                BancoDeDados_Instância1.Atualizar("TB_MAT_PRI", "PESO", PesoApósSaída, IDdaLinha)
                BancoDeDados_Instância1.Atualizar("TB_MAT_PRI", "QUANTIDADE", QuantidadeApósSaída, IDdaLinha)
            End If
            NovaSaída.InserirRegistroDeNovaSaída_MatériaPrima()
            BancoDeDados_Instância1.Atualizar(TabelaCarregadaNoDisplay, "DATA_ULTIMA_SAÍDA", Now, IDdaLinha)
            form_Estoque_Instância1.Grid.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable("TB_MAT_PRI", "*", "")
            form_Estoque_Instância1.bot_consumíveis.BackColor = Color.FromArgb(0, 100, 100)
            form_Estoque_Instância1.bot_matpri.BackColor = Color.FromArgb(0, 200, 200)
            TabelaCarregadaNoDisplay = "TB_MAT_PRI"
            Me.Close()
        ElseIf TabelaCarregadaNoDisplay = "TB_CONSUMÍVEIS" Then
            NovaSaída = New Class_BancoDeDados.Saídas
            NovaSaída.Rastreio = RastreioDaLinha
            NovaSaída.Descrição = DescriçãoDaLinha
            NovaSaída.OS = Me.box_os.Text
            NovaSaída.QuantUni = Me.box_qua.Text
            NovaSaída.Usuário = UsuárioLogado
            NovaSaída.Equipe = Me.box_equ.Text
            NovaSaída.Requisição = Me.box_req.Text
            NovaSaída.DataDaSaída = Me.box_data.Text
            NovaSaída.Valor = CStr(CDbl(CustoPorUniDaLinha) * CDbl(box_qua.Text))
            QuantidadeApósSaída = CStr(CDbl(QuantidadeDaLinha) - CDbl(box_qua.Text))
            BancoDeDados_Instância1.Atualizar("TB_CONSUMÍVEIS", "QUANTIDADE", QuantidadeApósSaída, IDdaLinha)
            NovaSaída.InserirRegistroDeNovaSaída_Consumível()
            BancoDeDados_Instância1.Atualizar(TabelaCarregadaNoDisplay, "DATA_ULTIMA_SAÍDA", Now, IDdaLinha)
            form_RegistrosEntradas_Instância1.Grid_RegistrosEntradas.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable("TB_CONSUMÍVEIS", "*", "")
            form_RegistrosEntradas_Instância1.bot_matpriEntradas.BackColor = Color.FromArgb(0, 100, 100)
            form_RegistrosEntradas_Instância1.bot_consumíveisEntradas.BackColor = Color.FromArgb(0, 200, 200)
            form_RegistrosEntradas_Instância1.Grid_RegistrosEntradas.FirstDisplayedScrollingRowIndex = form_RegistrosEntradas_Instância1.Grid_RegistrosEntradas.RowCount - 1
            form_RegistrosEntradas_Instância1.Grid_RegistrosEntradas.Rows(form_RegistrosEntradas_Instância1.Grid_RegistrosEntradas.Rows.Count - 1).Selected = True
            TabelaCarregadaNoDisplay = "TB_CONSUMÍVEIS"
            Me.Close()
        End If

    End Sub
End Class