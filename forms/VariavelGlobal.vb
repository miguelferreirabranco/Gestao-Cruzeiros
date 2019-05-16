Module VariavelGlobal
    Public EmpresaCruzeiros As ClassCruzeiros
    Public CruzeiroVisivel As Integer
    Public ViajanteVisivel As Integer
    Public FuncionarioVisivel As Integer

    Public username As String



    Public Sub InitVars()
        EmpresaCruzeiros = New ClassCruzeiros
        CruzeiroVisivel = 0
        ViajanteVisivel = 0
        username = ""
    End Sub

End Module
