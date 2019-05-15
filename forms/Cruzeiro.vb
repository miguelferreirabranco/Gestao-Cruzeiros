Imports TrabalhoPCII

Public Class Cruzeiro
    Private _nome As String
    Private _diainicio As Date
    Private _diafim As Date
    Private _partida As String
    Private _destino As String
    Private _funcionarios As Funcionarios
    Private _viajantes As Viajantes
    Private _atividadesnavio As ClassAtividadeNavio
    Private _atividadesparagens As ClassAtividadeParagens
    Private _paragens As ClassParagens
    Private _ocupação As Integer
    Public Property Nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property

    Public Property Diainicio As Date
        Get
            Return _diainicio
        End Get
        Set(value As Date)
            _diainicio = value
        End Set
    End Property

    Public Property Diafim As Date
        Get
            Return _diafim
        End Get
        Set(value As Date)
            _diafim = value
        End Set
    End Property

    Public Property Partida As String
        Get
            Return _partida
        End Get
        Set(value As String)
            _partida = value
        End Set
    End Property

    Public Property Destino As String
        Get
            Return _destino
        End Get
        Set(value As String)
            _destino = value
        End Set
    End Property

    Public Property Funcionarios As Funcionarios
        Get
            Return _funcionarios
        End Get
        Set(value As Funcionarios)
            _funcionarios = value
        End Set
    End Property

    Public Property Viajantes As Viajantes
        Get
            Return _viajantes
        End Get
        Set(value As Viajantes)
            _viajantes = value
        End Set
    End Property

    Public Property Atividadesnavio As ClassAtividadeNavio
        Get
            Return _atividadesnavio
        End Get
        Set(value As ClassAtividadeNavio)
            _atividadesnavio = value
        End Set
    End Property

    Public Property Atividadesparagens As ClassAtividadeParagens
        Get
            Return _atividadesparagens
        End Get
        Set(value As ClassAtividadeParagens)
            _atividadesparagens = value
        End Set
    End Property

    Public Property Paragens As ClassParagens
        Get
            Return _paragens
        End Get
        Set(value As ClassParagens)
            _paragens = value
        End Set
    End Property

    Public Property Ocupação As Integer
        Get
            Return _ocupação
        End Get
        Set(value As Integer)
            _ocupação = value
        End Set
    End Property

    Sub New()

    End Sub

    Sub New(nome As String, diainicio As Date, diafim As Date, partida As String, destino As String)
        _nome = nome
        _diafim = diafim
        _diainicio = diainicio
        _partida = partida
        _destino = destino
        _funcionarios = New Funcionarios
        _viajantes = New Viajantes
        _atividadesnavio = New ClassAtividadeNavio
        _atividadesparagens = New ClassAtividadeParagens
        _paragens = New ClassParagens
        _ocupação = 400 'alterar valor
    End Sub

End Class
