
Imports System.Data.SQLite

Public Class Class_BancoDeDados


    Shared String_Comando_SQL As String
    Shared Comando_SQL As SQLiteCommand
    Shared Data_Adapter As SQLiteDataAdapter
    Shared Data_Reader As SQLiteDataReader
    Shared Atributo_Data_Table As DataTable
    Shared Conexão_Sql As SQLiteConnection
    Sub New()
        String_Comando_SQL = ""
        Comando_SQL = Nothing
        Data_Adapter = Nothing
        Data_Reader = Nothing
        Atributo_Data_Table = Nothing
        Conexão_Sql = Nothing
    End Sub
    Public Function ConverterTabelaSQLEmDataTable_RetornaDataTable(Tabela As String, NomesDasColunas_String As String, ClausulaWHERE_LIKE As String)
        Try
            Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                Conexão_Sql.Open()
                String_Comando_SQL = "SELECT " & NomesDasColunas_String & " FROM " & Tabela & " " & ClausulaWHERE_LIKE
                Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                    Using Data_Adapter As New SQLiteDataAdapter(Comando_SQL)
                        Atributo_Data_Table = New DataTable
                        Data_Adapter.Fill(Atributo_Data_Table)
                    End Using
                End Using
            End Using
            Return Atributo_Data_Table
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function
    Public Function VerificarSeATabelaEstaVazia(Tabela As String)

        Try
            Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                Conexão_Sql.Open()
                String_Comando_SQL = "Select * FROM " & Tabela
                Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                    Data_Reader = Comando_SQL.ExecuteReader
                    While Data_Reader.Read
                        Data_Reader.Close()
                        Conexão_Sql.Close()
                        Return False
                    End While
                    Data_Reader.Close()
                    Conexão_Sql.Close()
                    Return True
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Public Sub ColetarEAdicionarOsDadosNãoDuplicadosDeUmaColunaDeUmaTabelaEAdicionarEmOutraColunaDeOutraTabela(TabelaQueIráSerColetada As String, ColunaDaTabelaColetada As String, TabelaQeuIráReceber As String, ColunaQueIráReceber As String)
        Dim Dado As String
        Dim Dado2 As String
        Dim NumeroDeRegistrosAtuais As Integer = 0
        Dim index As Integer = 1
        Dim DescriçõesDeEntradas As New ArrayList
        Dim IDsDeItensDuplicados As New ArrayList
        IDsDeItensDuplicados.Clear()
        DescriçõesDeEntradas.Clear()

        Try
            Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                Conexão_Sql.Open()
                'Adiciona os dados na tabelas
                String_Comando_SQL = "INSERT INTO " & TabelaQeuIráReceber & " (" & ColunaQueIráReceber & ") SELECT Distinct " & ColunaDaTabelaColetada & " FROM " & TabelaQueIráSerColetada
                Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                    Comando_SQL.ExecuteNonQuery()
                    Comando_SQL.Dispose()
                End Using
                Conexão_Sql.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            RealizarBackupDoBancoDeDados()
        End Try

    End Sub
    Shared Function NúmeroDeDadosNestaTabela(Tabela As String)
        Dim Registros As Integer = 0
        Try
            Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                Conexão_Sql.Open()
                String_Comando_SQL = "select * from " & Tabela
                Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                    Data_Reader = Comando_SQL.ExecuteReader
                    While Data_Reader.Read
                        Registros = Registros + 1
                    End While
                    Return Registros * Data_Reader.FieldCount
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Sub VerificaQuantosItensEstãoEmBrancoEGeraUmDisplayDeRegistro()
        Dim ItensFaltantes As Integer = 0
        Dim CódigoDeOrigem As New ArrayList
        Dim NomeDoCampo As New ArrayList
        Dim Número_de_Registros As Integer
        Try

            Mod_ProgressBar.Max = NúmeroDeDadosNestaTabela("TB_MAT_PRI") + NúmeroDeDadosNestaTabela("TB_CONSUMÍVEIS")
            Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                Mod_ProgressBar.Menssagem("Limpando Display")
                Conexão_Sql.Open()
                String_Comando_SQL = "DELETE FROM Display_DadosFaltantes"
                Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                    Comando_SQL.ExecuteNonQuery()
                End Using
                Conexão_Sql.Close()
            End Using
            Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                Conexão_Sql.Open()
                String_Comando_SQL = "select * from TB_MAT_PRI"
                Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                    Data_Reader = Comando_SQL.ExecuteReader
                    CódigoDeOrigem.Clear()
                    NomeDoCampo.Clear()

                    While Data_Reader.Read
                        For i = 0 To Data_Reader.FieldCount - 1
                            Mod_ProgressBar.Menssagem(CStr(i) & "/" & CStr(Data_Reader.FieldCount - 1))
                            Mod_ProgressBar.Increment(1)

                            If Data_Reader.Item(i).ToString = "" Then
                                ItensFaltantes = ItensFaltantes + 1
                                CódigoDeOrigem.Add(Data_Reader.Item(6).ToString)
                                NomeDoCampo.Add(Data_Reader.GetName(i))
                            End If
                        Next
                    End While
                    Data_Reader.Close()
                End Using
                Conexão_Sql.Close()
            End Using
            For i = 0 To CódigoDeOrigem.Count - 1
                Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                    Conexão_Sql.Open()
                    String_Comando_SQL = "INSERT INTO Display_DadosFaltantes(ITEM,CAMPO_VAZIO) VALUES ('" & CódigoDeOrigem(i) & "','" & NomeDoCampo(i) & "')"
                    Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                        Comando_SQL.ExecuteNonQuery()
                        Mod_ProgressBar.Increment(1)
                    End Using
                    Conexão_Sql.Close()
                End Using
            Next
            '====================================================================================
            Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                Conexão_Sql.Open()
                String_Comando_SQL = "select * from TB_CONSUMÍVEIS"
                Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                    Data_Reader = Comando_SQL.ExecuteReader
                    CódigoDeOrigem.Clear()
                    NomeDoCampo.Clear()
                    While Data_Reader.Read

                        For i = 0 To Data_Reader.FieldCount - 1
                            If Data_Reader.Item(i).ToString = "" Then
                                Mod_ProgressBar.Menssagem(CStr(i) & "/" & CStr(Data_Reader.FieldCount - 1))
                                Mod_ProgressBar.Increment(1)
                                ItensFaltantes = ItensFaltantes + 1
                                CódigoDeOrigem.Add(Data_Reader.Item(6).ToString)
                                NomeDoCampo.Add(Data_Reader.GetName(i))
                            End If
                        Next
                    End While
                    Data_Reader.Close()
                End Using
                Conexão_Sql.Close()
            End Using

            For i = 0 To CódigoDeOrigem.Count - 1
                Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                    Conexão_Sql.Open()
                    String_Comando_SQL = "INSERT INTO Display_DadosFaltantes(ITEM,CAMPO_VAZIO) VALUES ('" & CódigoDeOrigem(i) & "','" & NomeDoCampo(i) & "')"
                    Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                        Comando_SQL.ExecuteNonQuery()
                        Mod_ProgressBar.Increment(1)
                    End Using
                    Conexão_Sql.Close()
                End Using

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try
    End Sub
    Public Function ColetarOsNomesDasTabelasDoBD_RetornaArray()
        Try
            Dim Nomes_Das_Tabelas As New ArrayList
            Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                Conexão_Sql.Open()
                String_Comando_SQL = "SELECT name FROM sqlite_master WHERE type='table'"
                Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                    Data_Reader = Comando_SQL.ExecuteReader
                    While Data_Reader.Read
                        Nomes_Das_Tabelas.Add(Data_Reader("name").ToString)
                    End While
                    Data_Reader.Close()
                End Using
                Conexão_Sql.Close()
            End Using
            Return Nomes_Das_Tabelas
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Public Function ColetarNúmeroDeRegistrosExistentesNestaTabela(Tabela As String)
        Dim NúmeroDeRegistros As Integer = 0
        Try

            Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                Conexão_Sql.Open()
                String_Comando_SQL = "SELECT * from " & Tabela
                Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                    Data_Reader = Comando_SQL.ExecuteReader
                    While Data_Reader.Read
                        NúmeroDeRegistros = NúmeroDeRegistros + 1
                    End While
                End Using
            End Using
            Return NúmeroDeRegistros
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Public Function ColetarTodosOsDadosNãoNulosDeUmaColunaDeUmaTabela_RetornaArrayList(Tabela As String, Coluna As String)
        Try
            Dim ArrayList As New ArrayList
            Dim NúmeroDeRegistrosNaColuna As Integer
            Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                Conexão_Sql.Open()
                String_Comando_SQL = "select * from " & Tabela
                Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                    Data_Reader = Comando_SQL.ExecuteReader
                    While Data_Reader.Read
                        If IsDBNull(Data_Reader(Coluna)) Then
                        Else
                            ArrayList.Add(Data_Reader(Coluna))
                        End If
                    End While
                    Data_Reader.Close()
                End Using
                Conexão_Sql.Close()
            End Using
            Return ArrayList
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Public Function ColetarUmDadoEmUmaColunaEmUmaTabela_RetornaString(Tabela As String, ColunaDoDado As String, ColunaWhere As String, ParametroWhere As String)
        Try
            Dim Dado As String
            Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                Conexão_Sql.Open()
                String_Comando_SQL = "select * from " & Tabela & " WHERE " & ColunaWhere & " = '" & ParametroWhere & "' "
                Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                    Data_Reader = Comando_SQL.ExecuteReader
                    While Data_Reader.Read
                        Dado = Data_Reader(ColunaDoDado)
                    End While
                    Data_Reader.Close()
                End Using
                Conexão_Sql.Close()
            End Using
            Return Dado
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Public Function ColetarOsNomesDeTodasAsColunasDestaTabela_RetornaArrayDeCheckBoxes(NomeDaTabela As String)
        Dim NomesDasColunas(29) As CheckBox
        Dim CheckBox As CheckBox
        Try
            Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                Conexão_Sql.Open()
                String_Comando_SQL = "SELECT * FROM " & NomeDaTabela
                Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                    Data_Reader = Comando_SQL.ExecuteReader
                    ReDim NomesDasColunas(Data_Reader.FieldCount - 1)
                    While Data_Reader.Read
                        For i = 0 To Data_Reader.FieldCount - 1
                            CheckBox = New CheckBox
                            NomesDasColunas(i) = CheckBox
                            NomesDasColunas(i).Text = Data_Reader.GetName(i)
                        Next
                        Exit While
                    End While
                    Data_Reader.Close()
                End Using
                Conexão_Sql.Close()
            End Using
            Return NomesDasColunas
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Public Function ColetarOsNomesDasColunasDeterminadasDestaTabela_RetornaArrayDeStrings(NomeDaTabela As String, Colunas_String As String)
        Dim NomesDasColunas(30) As String
        Try
            Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                Conexão_Sql.Open()
                String_Comando_SQL = "SELECT " & Colunas_String & " FROM " & NomeDaTabela
                Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                    Data_Reader = Comando_SQL.ExecuteReader
                    ReDim NomesDasColunas(Data_Reader.FieldCount - 1)
                    For i = 0 To Data_Reader.FieldCount - 1
                        NomesDasColunas(i) = Data_Reader.GetName(i)
                    Next
                    Data_Reader.Close()
                End Using
                Conexão_Sql.Close()
            End Using
            Return NomesDasColunas
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Public Sub DeletarEsteIDDestaTabela(ID As String, Tabela As String)
        Try
            Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                Conexão_Sql.Open()
                String_Comando_SQL = "Delete from " & Tabela & " Where ID = " & ID & " "
                Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                    Comando_SQL.ExecuteNonQuery()
                End Using
                Conexão_Sql.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            RealizarBackupDoBancoDeDados()
        End Try
    End Sub
    Public Sub DeletarTodosOsDadosDestaTabela(Tabela As String)
        Try
            Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                Conexão_Sql.Open()
                String_Comando_SQL = "Delete from " & Tabela
                Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                    Comando_SQL.ExecuteNonQuery()
                End Using
                Conexão_Sql.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            RealizarBackupDoBancoDeDados()
        End Try
    End Sub
    Public Sub DeletarTodosOsDadosDestaTabelaMenosAPrimeiraLinhaCore(Tabela As String)
        Try
            Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                Conexão_Sql.Open()
                String_Comando_SQL = "Delete from " & Tabela & " WHERE NOT ID = 1"
                Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                    Comando_SQL.ExecuteNonQuery()
                End Using
                Conexão_Sql.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            RealizarBackupDoBancoDeDados()
        End Try
    End Sub
    Public Sub InserirUmDadoEmUmaColunaDaTabelaEspecíficada(Tabela As String, Coluna As String, Dado As String)
        Try
            Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                Conexão_Sql.Open()
                String_Comando_SQL = "INSERT INTO " & Tabela & "(" & Coluna & ") VALUES ('" & Dado & "')"
                Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                    Comando_SQL.ExecuteNonQuery()
                End Using
                Conexão_Sql.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            RealizarBackupDoBancoDeDados()
        End Try
    End Sub
    Public Sub InserirDoisDadosEmDuasColunasDaTabelaEspecíficada(Tabela As String, Coluna1 As String, Dado1 As String, Coluna2 As String, Dado2 As String)
        Try
            Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                Conexão_Sql.Open()
                String_Comando_SQL = "INSERT INTO " & Tabela & "(" & Coluna1 & "," & Coluna2 & ") VALUES ('" & Dado1 & "','" & Dado2 & "')"
                Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                    Comando_SQL.ExecuteNonQuery()
                End Using
                Conexão_Sql.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            RealizarBackupDoBancoDeDados()
        End Try
    End Sub
    Public Sub InserirVariosDadosEmUmaColunaDaTabelaEColunaEspecífica(Tabela As String, Coluna As String, Dados As ArrayList)
        Try
            Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                Conexão_Sql.Open()
                For Each Dado In Dados
                    String_Comando_SQL = "INSERT INTO " & Tabela & " (" & Coluna & ") VALUES ('" & Dado & "')"
                    Using Comando_SQL3 As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                        Comando_SQL3.ExecuteNonQuery()
                    End Using
                Next
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            RealizarBackupDoBancoDeDados()
        End Try
    End Sub

    Public Sub Atualizar(Tabela As String, Nome_Coluna_Para_Atualizar As String, Dado_Atualizado As String, Index_ID_Da_Linha_Selecionada As String)
        Try
            Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                Conexão_Sql.Open()
                String_Comando_SQL = "Update " & Tabela & " Set " & Nome_Coluna_Para_Atualizar & " = '" & Dado_Atualizado & "' where ID = " & Index_ID_Da_Linha_Selecionada
                Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                    Comando_SQL.ExecuteNonQuery()
                End Using
                Conexão_Sql.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            RealizarBackupDoBancoDeDados()
        End Try
    End Sub
    Shared Sub RealizarBackupDoBancoDeDados()
        Dim DataDeAgoraFormatada = Replace(Now, "/", "-")
        DataDeAgoraFormatada = Replace(DataDeAgoraFormatada, " ", "-")
        DataDeAgoraFormatada = Replace(DataDeAgoraFormatada, ":", "-")
        'FileCopy(Environment.CurrentDirectory & "\BD_GALATA_SQLITE.db", "X:\.Sistema Gálata\.Backups BancoDeDados\Backup_BD_GALATA_SQLITE_" & DataDeAgoraFormatada & ".db")


    End Sub
    Public Class Login
        Public Function Login_Permitido(Usuário As String, Senha As String)
            Try
                Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                    Conexão_Sql.Open()
                    String_Comando_SQL = "Select * from Usuários_Senhas"
                    Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                        Data_Reader = Comando_SQL.ExecuteReader
                        While Data_Reader.Read
                            If Data_Reader("Usuário") = Usuário Then
                                If Data_Reader("Senha") = Senha Then
                                    UsuárioLogado = Usuário
                                    Data_Reader.Close()
                                    Return True
                                Else
                                    Data_Reader.Close()
                                    Return False
                                End If
                            End If
                        End While
                        Return False
                    End Using
                End Using

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Function
    End Class

    Public Class Matéria_Prima
        Public Sub InserirNovaMatériaPrima(Tabela As String)

            'Específicas====================================================
            Dim Material As String = ColetarTextDaComboboxReferenteAUmaLabel("Material")
            Dim Diametro As String = ColetarTextDaComboboxReferenteAUmaLabel("Diâmetro (mm)")
            Dim Revestimento As String = ColetarTextDaComboboxReferenteAUmaLabel("Revestimento")
            Dim Dureza As String = ColetarTextDaComboboxReferenteAUmaLabel("Dureza")
            Dim Norma As String = ColetarTextDaComboboxReferenteAUmaLabel("Norma")
            Dim Comprimento As String = ColetarTextDaComboboxReferenteAUmaLabel("Comprimento (mm)")
            Dim Largura As String = ColetarTextDaComboboxReferenteAUmaLabel("Largura (mm)")
            Dim Espessura As String = ColetarTextDaComboboxReferenteAUmaLabel("Espessura")
            Dim Peso As String = ColetarTextDaComboboxReferenteAUmaLabel("Peso (Kg)")
            Dim Tamanho_Aba As String = ColetarTextDaComboboxReferenteAUmaLabel("Tamanho da Aba (mm)")
            Dim Dimensões As String = ColetarTextDaComboboxReferenteAUmaLabel("Dimensões")
            'Gerais===============================================================
            Dim Os As String = form_Nova_Entrada_Instância1.box_os.Text
            Dim Lote As String = form_Nova_Entrada_Instância1.box_lot.Text
            Dim Corrida As String = form_Nova_Entrada_Instância1.box_cor.Text
            Dim Certificado As String = form_Nova_Entrada_Instância1.box_cer.Text
            Dim Fabricante As String = form_Nova_Entrada_Instância1.box_fab.Text
            Dim Fornecedor As String = form_Nova_Entrada_Instância1.box_for.Text
            Dim Ordem As String = form_Nova_Entrada_Instância1.box_ord.Text
            Dim Nota As String = form_Nova_Entrada_Instância1.box_not.Text
            Dim Origem As String = form_Nova_Entrada_Instância1.cod_origem.Text
            Dim Usuário As String = "Administrador"
            Dim Descrição As String
            Dim Classe As String = form_Nova_Entrada_Instância1.TituloDaClasse.Text
            Dim CodClasse As String = form_Nova_Entrada_Instância1.cod_classe.Text
            Dim DataAlteração As String = "n/a"
            Dim DataUltimaSaida As String = "n/a"
            Dim DataChegada As String = form_Nova_Entrada_Instância1.box_datachegada.Text
            'Quantificação===========================================================
            Dim Custo As String = form_Nova_Entrada_Instância1.box_cus.Text
            Dim Quantidade As String = form_Nova_Entrada_Instância1.box_qua.Text
            'Tratamento de Dados das Variáveis=======================================
            If Espessura <> "n/a" Then
                Dim TamanhoDoDadoQueIráSerColetado As Integer
                For index = 0 To Espessura.Length
                    If Espessura.Chars(index) = "m" Then
                        Exit For
                    End If
                    TamanhoDoDadoQueIráSerColetado = TamanhoDoDadoQueIráSerColetado + 1
                Next
                Espessura = Mid(Espessura, 1, TamanhoDoDadoQueIráSerColetado)
                Espessura = Espessura.Replace(" ", "")
            End If
            'Construindo Descrição===================================================
            Select Case Classe
                Case "ARRUELA"
                    Descrição = Classe & " " & Revestimento & " - " & Dureza & " - " & Norma & " Ø " & Diametro
                Case "BARRA CHATA"
                    Descrição = Classe & " " & Espessura & "X" & Largura & "X" & Comprimento
                Case "BARRA REDONDA"
                    Descrição = Classe & " " & "Ø" & Diametro & "X" & Comprimento
                Case "CANTONEIRA"
                    Descrição = Classe & " " & Tamanho_Aba & "X" & Espessura & "X" & Comprimento
                Case "CHAPA"
                    Descrição = Classe & " " & Espessura & "X" & Largura & "X" & Comprimento
                Case "CONTRA PINO"
                    Descrição = Classe & " " & "Ø" & Diametro & "X" & Comprimento
                Case "PARAFUSO"
                    Descrição = Classe & " " & Revestimento & " - " & Dureza & " - " & Norma & " M" & Diametro & "X" & Comprimento
                Case "PORCA"
                    Descrição = Classe & " " & Revestimento & " - " & Dureza & " - " & Norma & " M" & Diametro
                Case "TUBO"
                    Descrição = Classe & " " & Norma & " " & "Ø" & Diametro & "X" & Espessura & "X" & Comprimento
                Case "VIGA H"
                    Descrição = Classe & " " & Dimensões & "X" & Comprimento
                Case "VIGA HP"
                    Descrição = Classe & " " & Dimensões & "X" & Comprimento
                Case "VIGA I"
                    Descrição = Classe & " " & Dimensões & "X" & Comprimento
                Case "VIGA U"
                    Descrição = Classe & " " & Dimensões & "X" & Comprimento
                Case "VIGA W"
                    Descrição = Classe & " " & Dimensões & "X" & Comprimento
                Case "PERSONALIZADA"
                    Descrição = ColetarTextDaComboboxReferenteAUmaLabel("Descrição")
            End Select
            Try
                Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                    Conexão_Sql.Open()
                    String_Comando_SQL = "INSERT INTO " & Tabela & " " &
                        "(USUÁRIO,DATA_REGISTRO,DATA_ALTERAÇÃO,DATA_ULTIMA_SAÍDA,DATA_CHEGADA,COD_ORIGEM,COD_CLASSE,OS,CLASSE,MATERIAL,DESCRIÇÃO,QUANTIDADE,COMPRIMENTO,LARGURA,ESPESSURA,PESO,LOTE,CORRIDA,Nº_CERTIFICADO,FABRICANTE,FORNECEDOR,ORDEM_DE_COMPRA,NOTA_FISCAL,CUSTO,TAMANHO_DA_ABA,REVESTIMENTO,DIAMETRO,DUREZA,NORMA,DIMENSOES)" &
                        "VALUES " &
                        "('" & UsuárioLogado & "','" & Now & "','" & DataAlteração & "','" & DataUltimaSaida & "','" & DataChegada & "','" & Origem & "','" & CodClasse & "','" & Os & "','" & Classe & "','" & Material & "','" & Descrição & "','" & Quantidade & "','" & Comprimento & "','" & Largura & "','" & Espessura & "','" & Peso & "','" & Lote & "','" & Corrida & "','" & Certificado & "','" & Fabricante & "','" & Fornecedor & "','" & Ordem & "','" & Nota & "','" & Custo & "','" & Tamanho_Aba & "','" & Revestimento & "','" & Diametro & "','" & Dureza & "','" & Norma & "','" & Dimensões & "')"
                    Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                        Comando_SQL.ExecuteNonQuery()
                    End Using
                    Conexão_Sql.Close()
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                RealizarBackupDoBancoDeDados()
            End Try
        End Sub
        Public Function ColetarTextDaComboboxReferenteAUmaLabel(TextDaLabel As String)
            Dim TextBox As New TextBox
            Dim ComboBox As New ComboBox
            Dim Label As New Label
            Dim Y As Integer
            For Each controle In form_Nova_Entrada_Instância1.groupbox_Características_Específicas.Controls
                If controle.GetType Is Label.GetType And controle.Text = TextDaLabel Then
                    Label = controle
                    Y = Label.Location.Y
                    Exit For
                End If
            Next
            For Each controle In form_Nova_Entrada_Instância1.groupbox_Características_Específicas.Controls
                If controle.GetType Is ComboBox.GetType Then
                    ComboBox = controle
                    If ComboBox.Location.Y = Y Then
                        Return ComboBox.Text
                        Exit For
                    End If
                ElseIf controle.GetType Is TextBox.GetType Then
                    TextBox = controle
                    If TextBox.Location.Y = Y Then
                        Return TextBox.Text
                        Exit For
                    End If
                End If
            Next
            Return "n/a"
        End Function
        Public Class NovaClasse
            Private Atributo_Nome As String
            Sub New()
                Atributo_Nome = ""
            End Sub
            Public Property Nome As String
                Get
                    Return Atributo_Nome
                End Get
                Set(value As String)
                    Atributo_Nome = "CLASSE_" & value
                    Atributo_Nome = Atributo_Nome.Replace(" ", "_")
                End Set
            End Property
            Public Sub Criar()
                If Atributo_Nome <> "" Then
                    Try
                        Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                            Conexão_Sql.Open()
                            String_Comando_SQL = "CREATE TABLE " & Atributo_Nome & "" &
                                "(ID INT IDENTITY(1,1) NOT NULL PRIMARY KEY ," &
                                " Título VARCHAR(MAX) NULL," &
                                " Dados_Boxes VARCHAR(MAX) NULL)"
                            Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                                Comando_SQL.ExecuteNonQuery()
                            End Using
                            Conexão_Sql.Close()
                        End Using
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                    Finally
                        RealizarBackupDoBancoDeDados()
                    End Try
                Else
                    MessageBox.Show("Atributo_Nome de BancoDeDados.MatériaPrima.NovaClasse esta vazio")
                End If

            End Sub
            Public Sub InserirDadosNaClasse(Título As String, Dado As String)
                Try
                    Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                        Conexão_Sql.Open()
                        String_Comando_SQL = "INSERT INTO " & Atributo_Nome & "(Título,Dados_Boxes) VALUES ('" & Título & "','" & Dado & "')"
                        Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                            Comando_SQL.ExecuteNonQuery()
                        End Using
                        Conexão_Sql.Close()
                    End Using
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                Finally
                    RealizarBackupDoBancoDeDados()
                End Try
            End Sub
        End Class

    End Class
    Public Class Consumíveis
        Public Sub InserirDadosNaTabelaDeConsumíveis(Tabela As String)
            Dim Cod_Rastreio As String = form_NovaEntrada_Consumível_Instância1.cod_rastreio.Text
            Dim Descrição As String = form_NovaEntrada_Consumível_Instância1.box_des.Text
            Dim Fornecedor As String = form_NovaEntrada_Consumível_Instância1.box_for.Text
            Dim Data_Chegada As String = form_NovaEntrada_Consumível_Instância1.box_dataChegada.Text
            Dim Data_Registro As String = Now
            Dim Usuário As String = UsuárioLogado
            Dim Quantidade As String = form_NovaEntrada_Consumível_Instância1.box_qua.Text
            Dim Custo As String = form_NovaEntrada_Consumível_Instância1.box_cus.Text
            Dim Nota_Fiscal As String = form_NovaEntrada_Consumível_Instância1.box_nota.Text
            Dim Marca As String = form_NovaEntrada_Consumível_Instância1.box_mar.Text

            Try
                Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                    Conexão_Sql.Open()
                    String_Comando_SQL = "INSERT INTO " & Tabela & " (COD_RASTREIO, DESCRIÇÃO, FORNECEDOR, DATA_CHEGADA, DATA_REGISTRO, USUÁRIO, QUANTIDADE, CUSTO, NOTA_FISCAL, MARCA) VALUES " &
                    "('" & Cod_Rastreio & "','" & Descrição & "','" & Fornecedor & "','" & Data_Chegada & "','" & Data_Registro & "','" & Usuário & "','" & Quantidade & "','" & Custo & "','" & Nota_Fiscal & "','" & Marca & "')"
                    Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                        Comando_SQL.ExecuteNonQuery()
                    End Using
                    Conexão_Sql.Close()
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                RealizarBackupDoBancoDeDados()
            End Try
        End Sub
        Public Sub EditarDadosNaTabelaConsumíveis()
            DescriçãoDaLinha = form_NovaEntrada_Consumível_Instância1.box_des.Text
            FornecedorDaLinha = form_NovaEntrada_Consumível_Instância1.box_for.Text
            MarcaDaLinha = form_NovaEntrada_Consumível_Instância1.box_mar.Text
            DataDeChegadaDaLinha = form_NovaEntrada_Consumível_Instância1.box_dataChegada.Text
            QuantidadeDaLinha = CStr(form_NovaEntrada_Consumível_Instância1.box_qua.Value)
            CustoPorUniDaLinha = CStr(form_NovaEntrada_Consumível_Instância1.box_cus.Value)
            NumeroDaNotaDaLinha = form_NovaEntrada_Consumível_Instância1.box_nota.Text

            Try
                Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                    Conexão_Sql.Open()
                    String_Comando_SQL = "UPDATE TB_CONSUMÍVEIS SET DATA_ALTERAÇÃO = '" & Now & "' ,DESCRIÇÃO = '" & DescriçãoDaLinha & "'  , FORNECEDOR = '" & FornecedorDaLinha & "' , MARCA = '" & MarcaDaLinha & "' , DATA_CHEGADA = '" & DataDeChegadaDaLinha & "'  , QUANTIDADE = '" & QuantidadeDaLinha & "' , CUSTO = '" & CustoPorUniDaLinha & "' , NOTA_FISCAL = '" & NumeroDaNotaDaLinha & "' WHERE ID = " & IDdaLinha & ""
                    Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                        Comando_SQL.ExecuteNonQuery()
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                RealizarBackupDoBancoDeDados()
            End Try
        End Sub
        Public Sub AtualizarDisplayConsumiveis()
            Dim index As Integer = 0
            Dim ArrayDeCadastros As New ArrayList
            ArrayDeCadastros.Clear()
            Dim ArraydeQuantidades As New ArrayList
            ArraydeQuantidades.Clear()
            Mod_ProgressBar.Show()

            Try
                Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                    Conexão_Sql.Open()
                    String_Comando_SQL = "SELECT NOME FROM CADASTRO_CONSUMIVEIS"
                    Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                        Data_Reader = Comando_SQL.ExecuteReader
                        While Data_Reader.Read
                            ArrayDeCadastros.Add(Data_Reader("NOME").ToString)
                        End While
                        Data_Reader.Close()
                    End Using
                    Conexão_Sql.Close()
                End Using

                For Each Item In ArrayDeCadastros

                    Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                        Conexão_Sql.Open()
                        String_Comando_SQL = "SELECT SUM(QUANTIDADE) FROM TB_CONSUMÍVEIS WHERE DESCRIÇÃO = @Descrição "
                        Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                            Comando_SQL.Parameters.Add(New SQLiteParameter("@Descrição", Item))
                            Data_Reader = Comando_SQL.ExecuteReader
                            While Data_Reader.Read
                                ArraydeQuantidades.Add(Data_Reader("SUM(QUANTIDADE)"))
                            End While
                            Data_Reader.Close()
                        End Using
                        Conexão_Sql.Close()
                    End Using
                Next

                Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                    Conexão_Sql.Open()
                    String_Comando_SQL = "DELETE FROM Display_Consumiveis "
                    Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                        Comando_SQL.ExecuteNonQuery()
                    End Using
                    Conexão_Sql.Close()
                End Using
                Mod_ProgressBar.Max = ArrayDeCadastros.Count

                For Each Dado In ArrayDeCadastros

                    Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                        Conexão_Sql.Open()
                        String_Comando_SQL = "INSERT INTO Display_Consumiveis(DESCRIÇÃO,QUANTIDADE) VALUES (@Descrição," & ArraydeQuantidades.Item(index) & ") "
                        Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                            Comando_SQL.Parameters.Add(New SQLiteParameter("@Descrição", Dado))
                            Comando_SQL.ExecuteNonQuery()
                        End Using
                        Conexão_Sql.Close()
                    End Using
                    index = index + 1
                    Mod_ProgressBar.Increment(1)
                Next

                Mod_ProgressBar.FecharForm()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
    End Class
    Public Class Saídas
        Private val_Origem As String
        Private val_Descrição As String
        Private val_Usuário As String
        Private val_OS As String
        Private val_QuantUni As String
        Private val_QuantKilo As String
        Private val_Valor As String
        Private val_Rastreio As String
        Private val_Equipe As String
        Private val_Requisição As String
        Private val_DataDaSaída As String
        Sub New()
            val_Origem = Nothing
            val_Descrição = Nothing
            val_Usuário = Nothing
            val_OS = Nothing
            val_QuantUni = Nothing
            val_QuantKilo = Nothing
            val_Valor = Nothing
            val_Rastreio = Nothing
            val_Equipe = Nothing
            val_Requisição = Nothing
            val_DataDaSaída = Nothing
        End Sub
        Public Property Origem As String
            Get
                Return val_Origem
            End Get
            Set(value As String)
                val_Origem = value
            End Set
        End Property
        Public Property Descrição As String
            Get
                Return val_Descrição
            End Get
            Set(value As String)
                val_Descrição = value
            End Set
        End Property
        Public Property Usuário As String
            Get
                Return val_Usuário
            End Get
            Set(value As String)
                val_Usuário = value
            End Set
        End Property
        Public Property OS As String
            Get
                Return val_OS
            End Get
            Set(value As String)
                val_OS = value
            End Set
        End Property
        Public Property QuantUni As String
            Get
                Return val_QuantUni
            End Get
            Set(value As String)
                val_QuantUni = value
            End Set
        End Property
        Public Property QuantKilo As String
            Get
                Return val_QuantKilo
            End Get
            Set(value As String)
                val_QuantKilo = value
            End Set
        End Property
        Public Property Valor As String
            Get
                Return val_Valor
            End Get
            Set(value As String)
                val_Valor = value
            End Set
        End Property
        Public Property Rastreio As String
            Get
                Return val_Rastreio
            End Get
            Set(value As String)
                val_Rastreio = value
            End Set
        End Property
        Public Property Equipe As String
            Get
                Return val_Equipe
            End Get
            Set(value As String)
                val_Equipe = value
            End Set
        End Property
        Public Property Requisição As String
            Get
                Return val_Requisição
            End Get
            Set(value As String)
                val_Requisição = value
            End Set
        End Property
        Public Property DataDaSaída As String
            Get
                Return val_DataDaSaída
            End Get
            Set(value As String)
                val_DataDaSaída = value
            End Set
        End Property


        Public Sub InserirRegistroDeNovaSaída_MatériaPrima()
            Try
                Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                    Conexão_Sql.Open()
                    String_Comando_SQL = "INSERT INTO TB_REGISTROS_SAÍDAS_MATPRI(COD_ORIGEM,DESCRIÇÃO,USUÁRIO,OS,QUANTIDADE_UNI,QUANTIDADE_PESO,VALOR_DA_SAÍDA,DATA_DA_SAÍDA) VALUES" &
                    "('" & Origem & "','" & Descrição & "','" & Usuário & "','" & OS & "','" & QuantUni & "','" & QuantKilo & "','" & Valor & "','" & DataDaSaída & "')"
                    Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                        Comando_SQL.ExecuteNonQuery()
                    End Using
                    Conexão_Sql.Close()
                End Using
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                RealizarBackupDoBancoDeDados()
            End Try
        End Sub
        Public Sub InserirRegistroDeNovaSaída_Consumível()
            Try
                Using Conexão_Sql As New SQLiteConnection(String_Conexão)
                    Conexão_Sql.Open()
                    String_Comando_SQL = "INSERT INTO TB_REGISTROS_SAÍDAS_CON(COD_RASTREIO,DESCRIÇÃO,USUÁRIO,OS,EQUIPE,QUANTIDADE,VALOR_DA_SAÍDA,DATA_DA_SAÍDA,REQUISIÇÃO) VALUES" &
                    "('" & Rastreio & "','" & Descrição & "','" & Usuário & "','" & OS & "','" & Equipe & "','" & QuantUni & "','" & Valor & "','" & DataDaSaída & "','" & Requisição & "')"
                    Using Comando_SQL As New SQLiteCommand(String_Comando_SQL, Conexão_Sql)
                        Comando_SQL.ExecuteNonQuery()
                    End Using
                    Conexão_Sql.Close()
                End Using

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            Finally
                RealizarBackupDoBancoDeDados()
            End Try
        End Sub
    End Class



End Class
