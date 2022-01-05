Module Mod_ProgressBar
    Public val_Max As Integer
    Sub New()
    End Sub
    Public Property Max As Integer
        Get
            Return val_Max
        End Get
        Set(value As Integer)
            val_Max = value
            form_progressBar_Instância1.ProgressBar.Maximum = value
        End Set
    End Property
    Public Sub Show()
        form_progressBar_Instância1 = New form_ProgressBar
        form_progressBar_Instância1.Show()
    End Sub
    Public Sub Increment(Incremento As Integer)

        form_progressBar_Instância1.ProgressBar.Increment(Incremento)
        If form_progressBar_Instância1.ProgressBar.Value >= Mod_ProgressBar.Max Then
            form_progressBar_Instância1.Close()
        End If
    End Sub
    Public Sub Menssagem(Menssagem As String)
    End Sub
    Public Sub FecharForm()
        form_progressBar_Instância1.Close()
    End Sub
End Module
