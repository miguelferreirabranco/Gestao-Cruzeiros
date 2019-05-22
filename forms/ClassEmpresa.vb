

Public Class ClassEmpresa
    Private _Cruzeiros As ClassCruzeiros
    Private _viajantes As ClassViajantes
    Private _funcionarios As ClassFuncionarios

    Public Property Cruzeiros As ClassCruzeiros
        Get
            Return _Cruzeiros
        End Get
        Set(value As ClassCruzeiros)
            _Cruzeiros = value
        End Set
    End Property

    Public Property Viajantes As ClassViajantes
        Get
            Return _viajantes
        End Get
        Set(value As ClassViajantes)
            _viajantes = value
        End Set
    End Property

    Public Property Funcionarios As ClassFuncionarios
        Get
            Return _funcionarios
        End Get
        Set(value As ClassFuncionarios)
            _funcionarios = value
        End Set
    End Property

    Public Sub New()
        Me.Cruzeiros = New ClassCruzeiros
        Me.Viajantes = New ClassViajantes
        Me.Funcionarios = New ClassFuncionarios
    End Sub

    Public Sub gravar()
        Dim writer As New System.Xml.Serialization.XmlSerializer(GetType(ClassCruzeiros))

        Dim file As New System.IO.StreamWriter("DadosdaEmpresaCruzeiros.xml")

        writer.Serialize(file, Cruzeiros)

        file.Close()
    End Sub

    Public Sub ler()
        Dim reader As New System.Xml.Serialization.XmlSerializer(GetType(ClassCruzeiros))

        If System.IO.File.Exists("DadosdaEmpresaCruzeiros.xml") Then
            Dim file As New System.IO.StreamReader("DadosdaEmpresaCruzeiros.xml")

            Cruzeiros = CType(reader.Deserialize(file), ClassCruzeiros)

            file.Close()
        End If
    End Sub

End Class
