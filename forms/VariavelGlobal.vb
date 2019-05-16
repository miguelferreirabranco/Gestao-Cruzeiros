Module VariavelGlobal
    Public EmpresaCruzeiros As ClassEmpresa
    Public CruzeiroVisivel As Integer
    Public ViajanteVisivel As Integer
    Public FuncionarioVisivel As Integer
    Public username As String

    Public Sub InitVars()
        EmpresaCruzeiros = New ClassEmpresa
        CruzeiroVisivel = 0
        ViajanteVisivel = 0
        FuncionarioVisivel = 0
        username = ""

        EmpresaCruzeiros.ler()

    End Sub


End Module
