Public Class form_ProgressBar
    Private Sub form_ProgressBar_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        DraggableForm_Instância1.Mouse_Down(Me, Me.bot_maximizar_progressBar)
    End Sub

    Private Sub form_ProgressBar_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        DraggableForm_Instância1.Mouse_Move(Me)
    End Sub

    Private Sub form_ProgressBar_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        DraggableForm_Instância1.Mouse_Up()
    End Sub

    Private Sub form_ProgressBar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class