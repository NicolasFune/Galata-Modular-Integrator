Imports System.Data.SQLite
Module Mod_Codificação

    Public ConexãoSQL As New SQLiteConnection(String_Conexão)
    Public ComandoSQL As SQLiteCommand
    Public DataReader As SQLiteDataReader
    Public StringComandoSQL As String
    Public Function CriarNovoCódigoDeOrigemParaEsteCodDeClasse_RetornaString(CódigoDeClasseCompleto As String)
        Dim Origem As String
        Dim Letras As String
        Dim Numero2 As Integer
        Dim Numero_Read_Atual As Integer
        Dim Numero_Final As Integer
        Dim Letra1 As Integer
        Dim Letra2 As Integer
        Dim Tipo As String
        Origem = "AA.000.000.0"
        '===================================================================================================
        Try
            Using ConexãoSQL As New SQLiteConnection(String_Conexão)
                ConexãoSQL.Open()
                StringComandoSQL = "select * from TB_MAT_PRI"
                Using ComandoSQL As New SQLiteCommand(StringComandoSQL, ConexãoSQL)
                    DataReader = ComandoSQL.ExecuteReader
                    Numero2 = 0
                    Letras = "AA"
                    'Serve para guardar o ultimo numero em Número2 e as ultimas letras em Letras
                    While DataReader.Read = True
                        Numero_Read_Atual = Int(Mid(DataReader("COD_ORIGEM"), 8, 3))
                        Origem = DataReader("COD_ORIGEM")
                        Letra1 = Asc(Mid(DataReader("COD_ORIGEM"), 1, 1))
                        Letra2 = Asc(Mid(DataReader("COD_ORIGEM"), 2, 1))
                        'Definição do tipo----------------------------------
                        If Mid(Origem, 12, 1) = "0" Then
                            Tipo = "Matéria Prima Virgem"
                        ElseIf Mid(Origem, 12, 1) = "1" Then
                            Tipo = "Matéria Prima Devolvida"
                        End If
                        '----------------------------------------------------
                        If Numero_Read_Atual >= Numero2 Then
                            Numero2 = Numero_Read_Atual
                            Letras = Mid(DataReader("COD_ORIGEM"), 1, 2)
                        Else
                            If Tipo = "Matéria Prima Devolvida" Then
                                Exit While
                            ElseIf Tipo = "Matéria Prima Virgem" Then
                                Numero2 = Numero_Read_Atual
                                Letras = Mid(DataReader("COD_ORIGEM"), 1, 2)
                            End If
                        End If
                    End While
                    DataReader.Close()
                End Using
            End Using
            '----------------------------------------------------------------------------------
            Mid(Origem, 1, 2) = Letras
            Mid(Origem, 4, 3) = Mid(CódigoDeClasseCompleto, 2, 3)
            Numero_Final = CInt(Numero2) + 1
            Mid(Origem, 12, 1) = "0"
            If Numero_Final > 999 Then
                If Asc(Mid(Origem, 2, 1)) + 1 > 90 Then
                    Mid(Origem, 1, 1) = Chr(Asc(Mid(Origem, 1, 1)) + 1)
                    Mid(Origem, 2, 1) = Chr(65)
                    Mid(Origem, 8, 3) = "000"
                Else
                    Mid(Origem, 2, 1) = Chr(Asc(Mid(Origem, 2, 1)) + 1)
                    Mid(Origem, 8, 3) = "000"
                End If
            Else
                Select Case Len(CStr(Numero_Final))
                    Case 1
                        Mid(Origem, 8, 3) = "0" & "0" & CStr(Numero_Final)
                    Case 2
                        Mid(Origem, 8, 3) = "0" & CStr(Numero_Final)
                    Case 3
                        Mid(Origem, 8, 3) = CStr(Numero_Final)
                End Select
            End If
            Return Origem
        Catch ex As Exception
            MessageBox.Show(ex.Message, "")
        End Try
    End Function
    Public Function CriarNovoCódigoDeRastreioParaEstaEntradaDeConsumível()
        Dim Rastreio As String
        Dim Letras As String
        Dim Numero2 As Integer
        Dim Numero_Read_Atual As Integer
        Dim Numero_Final As Integer
        Dim Letra1 As Integer
        Dim Letra2 As Integer
        Dim Letra3 As Integer
        Dim Tipo As String
        Rastreio = "CON.AAA.0000.0"
        '===================================================================================================
        Try
            Using ConexãoSQL As New SQLiteConnection(String_Conexão)
                ConexãoSQL.Open()
                StringComandoSQL = "select * from TB_CONSUMÍVEIS"
                Using ComandoSQL As New SQLiteCommand(StringComandoSQL, ConexãoSQL)
                    DataReader = ComandoSQL.ExecuteReader
                    Numero2 = 0
                    Letras = "AAA"
                    'Serve para guardar o ultimo numero em Número2 e as ultimas letras em Letras
                    While DataReader.Read = True
                        Numero_Read_Atual = Int(Mid(DataReader("COD_RASTREIO"), 9, 4))
                        Rastreio = DataReader("COD_RASTREIO")
                        Letra1 = Asc(Mid(DataReader("COD_RASTREIO"), 5, 1))
                        Letra2 = Asc(Mid(DataReader("COD_RASTREIO"), 6, 1))
                        Letra3 = Asc(Mid(DataReader("COD_RASTREIO"), 7, 1))
                        'Definição do tipo----------------------------------
                        If Mid(Rastreio, 14, 1) = "0" Then
                            Tipo = "Consumível Virgem"
                        ElseIf Mid(Rastreio, 14, 1) = "1" Then
                            Tipo = "Consumível Devolvido"
                        End If
                        '----------------------------------------------------
                        If Numero_Read_Atual >= Numero2 Then
                            Numero2 = Numero_Read_Atual
                            Letras = Mid(DataReader("COD_RASTREIO"), 5, 3)
                        Else
                            If Tipo = "Consumível Devolvido" Then
                                Exit While
                            ElseIf Tipo = "Consumível Virgem" Then
                                Numero2 = Numero_Read_Atual
                                Letras = Mid(DataReader("COD_RASTREIO"), 5, 3)
                            End If
                        End If
                    End While
                    DataReader.Close()
                End Using
            End Using
            '----------------------------------------------------------------------------------
            Mid(Rastreio, 5, 3) = Letras
            Numero_Final = CInt(Numero2) + 1
            Mid(Rastreio, 14, 1) = "0"
            If Numero_Final > 9999 Then
                If Asc(Mid(Rastreio, 7, 1)) + 1 > 90 Then
                    Mid(Rastreio, 6, 1) = Chr(Asc(Mid(Rastreio, 6, 1)) + 1)
                    If Asc(Mid(Rastreio, 6, 1)) > 90 Then
                        Mid(Rastreio, 5, 1) = Chr(Asc(Mid(Rastreio, 5, 1)) + 1)
                        Mid(Rastreio, 7, 1) = Chr(65)
                        Mid(Rastreio, 6, 1) = Chr(65)
                        Mid(Rastreio, 9, 4) = "0000"
                    End If
                    Mid(Rastreio, 7, 1) = Chr(65)
                    Mid(Rastreio, 9, 4) = "0000"
                Else
                    Mid(Rastreio, 7, 1) = Chr(Asc(Mid(Rastreio, 7, 1)) + 1)
                    Mid(Rastreio, 9, 4) = "0000"
                End If
            Else
                Select Case Len(CStr(Numero_Final))
                    Case 1
                        Mid(Rastreio, 9, 4) = "0" & "0" & "0" & CStr(Numero_Final)
                    Case 2
                        Mid(Rastreio, 9, 4) = "0" & "0" & CStr(Numero_Final)
                    Case 3
                        Mid(Rastreio, 9, 4) = "0" & CStr(Numero_Final)
                    Case 4
                        Mid(Rastreio, 9, 4) = CStr(Numero_Final)

                End Select
            End If
            Return Rastreio
        Catch ex As Exception
            MessageBox.Show(ex.Message, "")
        End Try
    End Function
    Public Function CriarNovoCódigoDeCadastro(Tabela_de_Cadastro As String)
        Dim UltimoCódigoDaColuna As String
        Dim NovoCódigo As Integer
        Dim CódigoQueIráRetornar As String = "0000"
        Try
            Using ConexãoSQL As New SQLiteConnection(String_Conexão)
                ConexãoSQL.Open()
                StringComandoSQL = "SELECT CODIGO FROM " & Tabela_de_Cadastro
                Using ComandoSQL As New SQLiteCommand(StringComandoSQL, ConexãoSQL)
                    DataReader = ComandoSQL.ExecuteReader
                    While DataReader.Read
                        If IsDBNull(DataReader.Item("CODIGO")) Then
                        Else
                            If DataReader.Item("CODIGO") <> "" Then
                                UltimoCódigoDaColuna = DataReader.Item("CODIGO")
                            End If
                        End If
                    End While
                    NovoCódigo = CInt(UltimoCódigoDaColuna) + 1
                    Select Case Len(CStr(NovoCódigo))
                        Case 1
                            Mid(CódigoQueIráRetornar, 1, 4) = "0" & "0" & "0" & CStr(NovoCódigo)
                        Case 2
                            Mid(CódigoQueIráRetornar, 1, 4) = "0" & "0" & CStr(NovoCódigo)
                        Case 3
                            Mid(CódigoQueIráRetornar, 1, 4) = "0" & CStr(NovoCódigo)
                        Case 4
                            Mid(CódigoQueIráRetornar, 1, 4) = CStr(NovoCódigo)
                    End Select
                    Return CódigoQueIráRetornar
                    ComandoSQL.Dispose()
                End Using
                ConexãoSQL.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Function

End Module
