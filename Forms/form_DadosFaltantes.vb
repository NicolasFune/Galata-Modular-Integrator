Public Class form_DadosFaltantes
    Private Sub Barra_DadosFaltantes_MouseDown(sender As Object, e As MouseEventArgs) Handles Barra_DadosFaltantes.MouseDown
        DraggableForm_Instância1.Mouse_Down(Me, Me.bot_maximizarDadosFaltantes)
    End Sub

    Private Sub Barra_DadosFaltantes_MouseMove(sender As Object, e As MouseEventArgs) Handles Barra_DadosFaltantes.MouseMove
        DraggableForm_Instância1.Mouse_Move(Me)
    End Sub

    Private Sub Barra_DadosFaltantes_MouseUp(sender As Object, e As MouseEventArgs) Handles Barra_DadosFaltantes.MouseUp
        DraggableForm_Instância1.Mouse_Up()
    End Sub

    Private Sub bot_MinimizarDadosFaltantes_Click(sender As Object, e As EventArgs) Handles bot_MinimizarDadosFaltantes.Click
        Mod_Window_State.Minimizar(Me)
    End Sub

    Private Sub bot_maximizarDadosFaltantes_Click(sender As Object, e As EventArgs) Handles bot_maximizarDadosFaltantes.Click
        Mod_Window_State.Maximizar(Me, Me.bot_maximizarDadosFaltantes)
    End Sub

    Private Sub bot_fecharDadosFaltantes_Click(sender As Object, e As EventArgs) Handles bot_fecharDadosFaltantes.Click
        Mod_Window_State.Fechar(Me)
    End Sub
    Private Sub form_DadosFaltantes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Grid_DadosFaltantes.DataSource = BancoDeDados_Instância1.ConverterTabelaSQLEmDataTable_RetornaDataTable("Display_DadosFaltantes", "*", "")
        Grid_DadosFaltantes.AutoResizeColumns()
    End Sub
End Class