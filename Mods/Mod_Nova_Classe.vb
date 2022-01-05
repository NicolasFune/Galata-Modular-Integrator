Module Mod_Nova_Classe
    Private Atributo_Nome As String
    Private Atributo_Número_Caixas As String

    Public Property Nome As String
        Get
            Return Atributo_Nome
        End Get
        Set(value As String)
            Atributo_Nome = value
        End Set
    End Property
    Public Property Número_Caixas As String
        Get
            Return Atributo_Número_Caixas
        End Get
        Set(value As String)
            Atributo_Número_Caixas = value
        End Set
    End Property
    Public Sub GerarCaixas(Painel As Control)
        Dim Altura As Integer
        Dim i As Integer
        Painel.Controls.Clear()
        For i = 1 To Atributo_Número_Caixas
            'RichText_Conteudo_Dos_ComboBoxes----------------------------
            Dim RichTextBox As New RichTextBox
            Altura = 10 + 60 * i
            With RichTextBox
                .Size = New Size(125, 58)
                .Location = New Point(401, Altura)
                .Name = "rich_" & CStr(i)
            End With
            Painel.Controls.Add(RichTextBox)
            'TextBoxes_Titulos----------------------------------------------------
            Dim TextBox As New TextBox
            With TextBox
                .Size = New Size(125, 58)
                .Location = New Point(40, RichTextBox.Location.Y)
                .Name = "txt_" & CStr(i)
            End With
            Painel.Controls.Add(TextBox)
        Next
    End Sub
End Module
