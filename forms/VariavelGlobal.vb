Module VariavelGlobal
    Public EmpresaCruzeiros As ClassEmpresa
    Public CruzeiroVisivel As Integer
    Public ViajanteVisivel As Integer
    Public FuncionarioVisivel As Integer
    Public NivelVisivel As String



    Public Sub InitVars()
        EmpresaCruzeiros = New ClassEmpresa
        CruzeiroVisivel = 0
        ViajanteVisivel = 0
        FuncionarioVisivel = 0
        NivelVisivel = ""
        ler()


    End Sub
    Public Sub gravar()
        Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(ClassEmpresa))

        Dim file As New System.IO.StreamWriter("DadosEmpresaCruzeiros.xml")

        writer.Serialize(file, EmpresaCruzeiros)

        file.Close()
    End Sub

    Public Sub ler()
        Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(ClassEmpresa))

        If System.IO.File.Exists("DadosEmpresaCruzeiros.xml") Then
            Dim file As New System.IO.StreamReader("DadosEmpresaCruzeiros.xml")

            EmpresaCruzeiros = CType(reader.Deserialize(file), ClassEmpresa)

            file.Close()
        End If
    End Sub

End Module
