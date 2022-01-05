Public Class form_Nova_Classe
    Public BancoDeDados_MatériaPrima_NovaClasse As Class_BancoDeDados.Matéria_Prima.NovaClasse
    Private Sub bot_proximo1_Click(sender As Object, e As EventArgs) Handles bot_proximo1.Click
        If txt_nome.Text <> "" And txt_numero_caixas.Text <> "" Then
            If CInt(txt_numero_caixas.Text) > 5 Then
                MessageBox.Show("O máximo de caracteristicas permitidas é 5")
            Else
                txt_nome.Enabled = False
                txt_numero_caixas.Enabled = False
                Mod_Nova_Classe.Nome = txt_nome.Text
                Mod_Nova_Classe.Número_Caixas = txt_numero_caixas.Text
                Mod_Nova_Classe.GerarCaixas(Me.Painel)
            End If

        Else
            MessageBox.Show("Campo Vazio encontrado")
        End If


    End Sub

    Private Sub bot_Gerar_Click(sender As Object, e As EventArgs) Handles bot_Gerar.Click

        BancoDeDados_MatériaPrima_NovaClasse.Nome = txt_nome.Text
        BancoDeDados_MatériaPrima_NovaClasse.Criar()
        Dim TextBox_Array(Painel.Controls.Count / 3) As TextBox
        Dim RichBox_Array(Painel.Controls.Count / 3) As RichTextBox
        Dim TextBox As TextBox
        Dim RichTextBox As RichTextBox
        Dim Control As Control
        Dim index As Integer
        index = 0
        Dim index2 As Integer
        index2 = 0

        For Each Control In Painel.Controls
            TextBox = New TextBox
            RichTextBox = New RichTextBox
            If Control.GetType Is TextBox.GetType Then
                TextBox_Array(index) = Control
                index = index + 1
            ElseIf Control.GetType Is RichTextBox.GetType Then
                RichBox_Array(index2) = Control
                index2 = index2 + 1
            End If
        Next

        For Item = 0 To TextBox_Array.Length - 1
            BancoDeDados_MatériaPrima_NovaClasse.InserirDadosNaClasse(TextBox_Array(Item).Text, RichBox_Array(Item).Text)
        Next
        Me.Close()

    End Sub

    Private Sub form_Nova_Classe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_nome.Enabled = True
        txt_numero_caixas.Enabled = True
    End Sub
End Class