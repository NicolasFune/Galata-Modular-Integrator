Public Class form_Login
    Private Sub bot_Fechar_Click(sender As Object, e As EventArgs) Handles bot_Fechar.Click
        Fechar(Me) ' Mod_Window_State
        Application.Exit()
    End Sub
    Private Sub bot_Maximizar_Click(sender As Object, e As EventArgs) Handles bot_Maximizar.Click
        Maximizar(Me, Me.bot_Maximizar) ' Mod_Window_State
    End Sub
    Private Sub bot_Minimizar_Click(sender As Object, e As EventArgs) Handles bot_Minimizar.Click
        Minimizar(Me) ' Mod_Window_State
    End Sub

    Private Sub txt_Usuário_MouseEnter(sender As Object, e As EventArgs) Handles txt_Usuário.MouseEnter
        txt_Usuário.BackColor = Color.FromArgb(0, 70, 70)
    End Sub

    Private Sub txt_Usuário_MouseLeave(sender As Object, e As EventArgs) Handles txt_Usuário.MouseLeave
        txt_Usuário.BackColor = Color.FromArgb(0, 51, 51)
    End Sub
    Private Sub txt_Senha_MouseEnter(sender As Object, e As EventArgs) Handles txt_Senha.MouseEnter
        txt_Senha.BackColor = Color.FromArgb(0, 70, 70)
    End Sub

    Private Sub txt_Senha_MouseLeave(sender As Object, e As EventArgs) Handles txt_Senha.MouseLeave
        txt_Senha.BackColor = Color.FromArgb(0, 51, 51)
    End Sub
    Private Sub bot_Entrar_Click(sender As Object, e As EventArgs) Handles bot_Entrar.Click

        Mod_ProgressBar.Show()
        form_progressBar_Instância1.ProgressBar.Maximum = 100
        Mod_ProgressBar.Menssagem("Conectando ao banco de dados e verificando credenciais")
        Mod_ProgressBar.Increment(20)
        If BancoDeDados_Login_Instância1.Login_Permitido(txt_Usuário.Text, txt_Senha.Text) Then
            Me.Hide()
            Mod_ProgressBar.Menssagem("Login bem sucedido")
            Mod_ProgressBar.Increment(20)
            form_Estoque_Instância1.Show()
        Else
            Mod_ProgressBar.Menssagem("Login mal sucedido")
            Mod_ProgressBar.Increment(20)
            Mod_ProgressBar.FecharForm()
            MessageBox.Show("Usuário ou senha incorretos")
        End If

    End Sub
    Private Sub txt_Senha_KeyDown(sender As Object, e As KeyEventArgs) Handles txt_Senha.KeyDown
        If e.KeyCode = Keys.Enter Then
            Mod_ProgressBar.Show()
            If BancoDeDados_Login_Instância1.Login_Permitido(txt_Usuário.Text, txt_Senha.Text) Then
                Me.Hide()
                Mod_ProgressBar.Menssagem("Login bem sucedido")
                Mod_ProgressBar.Increment(17)
                form_Estoque_Instância1.Show()
            Else
                Mod_ProgressBar.Menssagem("Login mal sucedido")
                Mod_ProgressBar.Increment(17)
                Mod_ProgressBar.FecharForm()
                MessageBox.Show("Usuário ou senha incorretos")
            End If
        End If
    End Sub

    Private Sub bot_senha_MouseDown(sender As Object, e As MouseEventArgs) Handles bot_senha.MouseDown
        txt_Senha.UseSystemPasswordChar = False
    End Sub

    Private Sub bot_senha_MouseUp(sender As Object, e As MouseEventArgs) Handles bot_senha.MouseUp
        txt_Senha.UseSystemPasswordChar = True
    End Sub
    Private Sub Me_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Barra_Login.MouseDown
        DraggableForm_Instância1.Mouse_Down(Me, Me.bot_Maximizar)
    End Sub
    Private Sub Me_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Barra_Login.MouseMove
        DraggableForm_Instância1.Mouse_Move(Me)
    End Sub
    Private Sub Me_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Barra_Login.MouseUp
        DraggableForm_Instância1.Mouse_Up()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class