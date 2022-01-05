Public Class Class_DraggableForm
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Public Sub Mouse_Down(Form As Form, Me_BotãoMaximizar As PictureBox)
        drag = True
        Form.WindowState = FormWindowState.Normal
        Me_BotãoMaximizar.Image = My.Resources.maximizar_24px
        mousex = Windows.Forms.Cursor.Position.X - Form.Left
        mousey = Windows.Forms.Cursor.Position.Y - Form.Top
    End Sub
    Public Sub Mouse_Move(Form As Form)
        If drag Then
            Form.Top = Windows.Forms.Cursor.Position.Y - mousey
            Form.Left = Windows.Forms.Cursor.Position.X - mousex
        End If
    End Sub
    Public Sub Mouse_Up()
        drag = False
    End Sub
End Class
