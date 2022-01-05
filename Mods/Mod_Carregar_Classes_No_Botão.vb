Module Mod_Carregar_Classes_No_Botão
    Public Sub Carregar_Classes_No_Botão()
        Dim Nomes_Das_Tabelas_Array As New ArrayList
        Dim index As Integer
        Dim DropDownItem As ToolStripMenuItem
        Nomes_Das_Tabelas_Array = BancoDeDados_Instância1.ColetarOsNomesDasTabelasDoBD_RetornaArray()
        index = 0
        form_Estoque_Instância1.downButton_Classes.DropDownItems.Clear()

        For Each Item In Nomes_Das_Tabelas_Array
            If Mid(Nomes_Das_Tabelas_Array(index), 1, 6) = "CLASSE" Then
                DropDownItem = New ToolStripMenuItem
                With DropDownItem
                    .Text = Nomes_Das_Tabelas_Array(index)
                    .Text = DropDownItem.Text.Replace("CLASSE_", "")
                    .Name = "bot_" & .Text
                End With

                form_Estoque_Instância1.downButton_Classes.DropDownItems.Add(DropDownItem)
            End If
            index = index + 1
        Next
    End Sub
End Module
