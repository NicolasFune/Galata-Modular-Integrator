Module Mod_DeclaraçõesPúblicas

    'DECLARAÇÕES DE CLASSES------------------------------------------------------------------------------
    Public BancoDeDados_Instância1 As New Class_BancoDeDados
    Public BancoDeDados_MatériaPrima_Instância1 As New Class_BancoDeDados.Matéria_Prima
    Public BancoDeDados_Login_Instância1 As New Class_BancoDeDados.Login
    Public BancoDeDados_Consumíveis_Instância1 As New Class_BancoDeDados.Consumíveis
    Public NovaSaída As New Class_BancoDeDados.Saídas
    Public DraggableForm_Instância1 As New Class_DraggableForm
    Public NovaMatériaPrima As New Class_ModeloDeClasseParaCriaçãoDeNovasClassesDeMatériaPrima
    Public Excel As New Class_Excel

    '-----------------------------------------------------------------------------------------------------


    'DECLARAÇÕES DE CONSTANTES++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    Public Const String_Conexão As String = "Data Source=C:\Users\nicol\Desktop\Criações\VB.NET\Projetos\Gálata Estoque\Gálata\BD_GALATA_SQLITE.db;Version=3;MultipleActiveResultSets=True;"
    'Public Const String_Conexão As String = "Data Source=X:\.Sistema Gálata\BD_GALATA_SQLITE.db;Version=3;MultipleActiveResultSets=True;"
    '+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++


    'DECLARAÇÕES DE VARIÁVEIS=============================================================================
    Public TítuloDaClasseDaNovaEntrada As String
    Public CódigoDaClasse_Completo As String

    Public IDdaLinha As Integer
    Public NomeDaLinha As String
    Public DescriçãoDaLinha As String
    Public OrigemDaLinha As String
    Public QuantidadeDaLinha As String
    Public CustoPorUniDaLinha As String
    Public CustoPorKiloDaLinha As String
    Public PesoDaLinha As String
    Public RastreioDaLinha As String
    Public FornecedorDaLinha As String
    Public MarcaDaLinha As String
    Public DataDeChegadaDaLinha As String
    Public NumeroDaNotaDaLinha As String
    Public IndexDaLinha As Integer

    Public UsuárioLogado As String = "Administrador" 'Muda o valor no processo de login
    Public KiloporUni As String
    Public MassaQueIráSair As String
    Public MassaDaSaída As String
    Public QuantidadeApósSaída As String
    Public PesoApósSaída As String
    Public TabelaCarregadaNoDisplay As String
    Public TabelaCarregadaNoDisplayRegistrosDeSaídas As String
    Public TipoDeSaída As String

    Public TabelaSQLQueIráSerFiltardaNoDisplay As String
    Public DisplayQueIráSerFiltrado_Control As DataGridView
    Public NomesDasAtuaisColunasNoFiltro() As String
    Public ColunasQueIrãoAparecerNoDsiplay_String As String = "*"
    Public StringPesquisada As String
    Public String_ClausulaWHEREDoFiltro As String
    Public ColunasAtivasNoDisplay() As String
    Public ValorAtualDaCélulaQuandoEntraNela As String
    Public ColunaSelecionadaNoFiltro As String
    Public AtualLinhaÉALinhaCore As Boolean
    Public OformEstaSendoChamadoParaEditarDados As Boolean
    '=====================================================================================================


    'DECLARAÇÕES DE FORMS/////////////////////////////////////////////////////////////////////////////////
    Public form_manut_Instância1 As New form_ManutençãoDoBancoDeDados
    Public form_Nova_Classe_Instância1 As New form_Nova_Classe
    Public form_Estoque_Instância1 As New form_Estoque
    Public form_Nova_Entrada_Instância1 As New form_Nova_Entrada
    Public form_NovaSaída_Instância1 As New form_NovaSaída
    Public form_RegistrosSaídas_Instância1 As New form_RegistrosSaídas
    Public form_NovaEntrada_Consumível_Instância1 As New form_NovaEntrada_Consumível
    Public form_DadosFaltantes_Instância1 As New form_DadosFaltantes
    Public form_RegistrosEntradas_Instância1 As New form_RegistrosEntradas
    Public form_progressBar_Instância1 As New form_ProgressBar
    Public form_Cadastrar_Instância1 As New form_Cadastrar
    '/////////////////////////////////////////////////////////////////////////////////////////////////////
End Module
