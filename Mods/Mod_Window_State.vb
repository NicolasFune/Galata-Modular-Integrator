Module Mod_Window_State
    Public Sub Maximizar(Form As System.Windows.Forms.Form, Me_BotãoMaximizar As PictureBox)
        If Form.WindowState = FormWindowState.Normal Then
            Form.WindowState = FormWindowState.Maximized
            Me_BotãoMaximizar.Image = My.Resources.minimizar_24px
        Else
            Form.WindowState = FormWindowState.Normal
            Me_BotãoMaximizar.Image = My.Resources.maximizar_24px
            MaximizarNoLoadEvent(Form)
        End If
    End Sub
    Public Sub Minimizar(Form As System.Windows.Forms.Form)
        Form.WindowState = FormWindowState.Minimized
    End Sub
    Public Sub Fechar(Form As System.Windows.Forms.Form)
        Form.Close()
    End Sub
    Public Sub MaximizarNoLoadEvent(Form As Form)
        Form.Left = 0
        Form.Top = 0
        Form.Width = Screen.PrimaryScreen.WorkingArea.Width
        Form.Height = Screen.PrimaryScreen.WorkingArea.Height


    End Sub
End Module
