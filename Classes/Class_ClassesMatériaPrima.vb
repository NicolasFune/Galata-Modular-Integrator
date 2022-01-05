Public Class Class_ModeloDeClasseParaCriaçãoDeNovasClassesDeMatériaPrima
    Private index As Integer = 0
    Public Atributos_CaracterísticasQuePopularãoComboBoxes As New ArrayList
    Public Atributos_CaracterísticasQuePopularãoTextBoxes As New ArrayList
    Public var_LabelDeDimensões_Dimensões As Boolean

    Sub New()
        Atributos_CaracterísticasQuePopularãoComboBoxes.Clear()
        Atributos_CaracterísticasQuePopularãoTextBoxes.Clear()
    End Sub
    Property LabelDeDimensões_Dimensões As Boolean
        Get
            Return var_LabelDeDimensões_Dimensões
        End Get
        Set(value As Boolean)
            var_LabelDeDimensões_Dimensões = value
        End Set
    End Property
    Property CaracterísticasQuePopularãoComboBoxes As ArrayList

        Get
            Return Atributos_CaracterísticasQuePopularãoComboBoxes
        End Get
        Set(value As ArrayList)

            Atributos_CaracterísticasQuePopularãoComboBoxes = value
        End Set
    End Property
    Property CaracterísticasQuePopularãoTextBoxes As ArrayList

        Get
            Return Atributos_CaracterísticasQuePopularãoTextBoxes
        End Get
        Set(value As ArrayList)

            Atributos_CaracterísticasQuePopularãoTextBoxes = value
        End Set
    End Property
    Public Sub CriarControlesDentroDoControle(groupbox As GroupBox)
        groupbox.Controls.Clear()
        index = 0
            For Each CaracterísticaComboBox In CaracterísticasQuePopularãoComboBoxes
                Dim Combobox As New ComboBox
                Dim Label_Asterisco As New Label
                Dim Label_Título As New Label
                Dim Font As Font
                Dim Color As New Color
                With Combobox
                    .Size = New Point(165, 30)
                    .Location = New Point(164, 37 + 49 * index)
                    .Name = "combobox_" & CaracterísticaComboBox
                .DataSource = BancoDeDados_Instância1.ColetarTodosOsDadosNãoNulosDeUmaColunaDeUmaTabela_RetornaArrayList("TB_CARACTERÍSTICAS", CaracterísticaComboBox)
            End With

            With Label_Título
                If LabelDeDimensões_Dimensões And Mid(CaracterísticaComboBox, 1, 9) = "Dimensões" Then
                    .Text = "Dimensões"
                Else
                    .Text = CaracterísticaComboBox
                End If

                .Location = New Point(5, Combobox.Location.Y)
                .Width = 140
            End With

            With Label_Asterisco
                    .Text = "*"
                    .Location = New Point(Label_Título.Location.X + Label_Título.Width, Label_Título.Location.Y)
                    .ForeColor = Color.Red
                End With
                groupbox.Controls.Add(Combobox)
                groupbox.Controls.Add(Label_Asterisco)
                groupbox.Controls.Add(Label_Título)
                index = index + 1
            Next
        For Each CaracterísticaTextBox In CaracterísticasQuePopularãoTextBoxes
            Dim TextBox As New TextBox
            Dim Label_Asterisco As New Label
            Dim Label_Título As New Label
            Dim Font As Font
            Dim Color As New Color

            With TextBox
                .Size = New Point(165, 30)
                .Location = New Point(164, 37 + 49 * index)
                .Name = "textbox_" & CaracterísticaTextBox
            End With
            With Label_Título
                .Text = CaracterísticaTextBox
                .Location = New Point(5, TextBox.Location.Y)
                .Width = 140
            End With

            With Label_Asterisco
                .Text = "*"
                .Location = New Point(Label_Título.Location.X + Label_Título.Width, Label_Título.Location.Y)
                .ForeColor = Color.Red
            End With
            groupbox.Controls.Add(TextBox)
            groupbox.Controls.Add(Label_Asterisco)
            groupbox.Controls.Add(Label_Título)
            index = index + 1
        Next
    End Sub
End Class

