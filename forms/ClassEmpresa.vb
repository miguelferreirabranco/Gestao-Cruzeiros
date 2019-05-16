

Public Class ClassEmpresa
    Private _Cruzeiros As ClassCruzeiros

    Public Property Cruzeiros As ClassCruzeiros
        Get
            Return _Cruzeiros
        End Get
        Set(value As ClassCruzeiros)
            _Cruzeiros = value
        End Set
    End Property

    Public Sub New()
        Me.Cruzeiros = New ClassCruzeiros
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
