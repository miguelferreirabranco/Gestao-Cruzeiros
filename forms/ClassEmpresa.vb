

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



End Class
