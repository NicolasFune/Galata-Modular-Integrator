Module Mod_FunçõesVariadas
    Public Function GerarVetoresDeClausulasWHERE(ColunaSelecionada As String, TermoBuscado As String)
        Dim Clausula As String
        Clausula = "WHERE " & ColunaSelecionada & " LIKE " & "'%" & TermoBuscado & "%' "
        Return Clausula
    End Function
End Module
