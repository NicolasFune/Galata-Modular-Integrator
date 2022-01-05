Imports System.ComponentModel
Public Class form_Nova_Entrada
    Private Sub form_Nova_Entrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        box_os.DataSource = BancoDeDados_Instância1.ColetarTodosOsDadosNãoNulosDeUmaColunaDeUmaTabela_RetornaArrayList("TB_CARACTERÍSTICAS", "OS")
    End Sub

    Private Sub bot_ok_Click(sender As Object, e As EventArgs) Handles bot_ok.Click
        BancoDeDados_MatériaPrima_Instância1.InserirNovaMatériaPrima("TB_MAT_PRI")
        BancoDeDados_MatériaPrima_Instância1.InserirNovaMatériaPrima("TB_REGISTROS_ENTRADAS_MATPRI")
        form_Estoque_Instância1.Grid.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable("TB_MAT_PRI", "*", "")
        form_Estoque_Instância1.Grid.AutoResizeColumns()
        Me.Close()
    End Sub

    Private Sub form_Nova_Entrada_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed

    End Sub

    Private Sub Barra_NovaEntradaMatériaPrima_MouseDown(sender As Object, e As MouseEventArgs) Handles Barra_NovaEntradaMatériaPrima.MouseDown
        DraggableForm_Instância1.Mouse_Down(Me, Me.bot_maximizar_novamatpri)
    End Sub

    Private Sub Barra_NovaEntradaMatériaPrima_MouseMove(sender As Object, e As MouseEventArgs) Handles Barra_NovaEntradaMatériaPrima.MouseMove
        DraggableForm_Instância1.Mouse_Move(Me)
    End Sub

    Private Sub Barra_NovaEntradaMatériaPrima_MouseUp(sender As Object, e As MouseEventArgs) Handles Barra_NovaEntradaMatériaPrima.MouseUp
        DraggableForm_Instância1.Mouse_Up()
    End Sub

    Private Sub bot_minimizar_novamatpri_Click(sender As Object, e As EventArgs) Handles bot_minimizar_novamatpri.Click
        Mod_Window_State.Minimizar(Me)
    End Sub

    Private Sub bot_maximizar_novamatpri_Click(sender As Object, e As EventArgs) Handles bot_maximizar_novamatpri.Click
        Mod_Window_State.Maximizar(Me, Me.bot_maximizar_novamatpri)
    End Sub

    Private Sub bot_fechar_novamatpri_Click(sender As Object, e As EventArgs) Handles bot_fechar_novamatpri.Click
        Mod_Window_State.Fechar(Me)
    End Sub
End Class