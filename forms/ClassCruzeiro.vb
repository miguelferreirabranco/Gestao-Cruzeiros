<<<<<<< HEAD
﻿Public Class ClassCruzeiro
    Private _nome As String
    Private _diainicio As Date
    Private _diafim As Date
    Private _partida As String
    Private _destino As String
    Private _funcionarios As ClassFuncionarios
    Private _viagantes As ClassViajantes
    Private _atividadesnavio As ClassAtividadesNavio
    Private _atividadesparagens As ClassAtividadesParagens
    Private _paragens As ClassParagens

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

    Public Property Funcionarios As ClassFuncionarios
        Get
            Return _funcionarios
        End Get
        Set(value As ClassFuncionarios)
            _funcionarios = value
        End Set
    End Property

    Public Property Viagantes As ClassViajantes
        Get
            Return _viagantes
        End Get
        Set(value As ClassViajantes)
            _viagantes = value
        End Set
    End Property

    Public Property Atividadesnavio As ClassAtividadesNavio
        Get
            Return _atividadesnavio
        End Get
        Set(value As ClassAtividadesNavio)
            _atividadesnavio = value
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

    Public Property Atividadesparagens As ClassAtividadeParagens
        Get
            Return _atividadesparagens
        End Get
        Set(value As ClassAtividadeParagens)
            _atividadesparagens = value
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
        _funcionarios = New ClassFuncionarios
        _viagantes = New ClassViajantes
        _atividadesparagens = New ClassAtividadesParagens
        _paragens = New ClassParagens
        _atividadesnavio = New ClassAtividadesNavio
    End Sub
=======
﻿Imports forms

Public Class ClassCruzeiro
    Private _funcionarios As ClassFuncionarios
    Private _viajantes As ClassViajantes
    Private _quartos As ClassQuartos
    Private _atividadesNavio As ClassAtividadesNavio
    Private _atividadesParagens As ClassAtividadesParagens
    Private _paragens As ClassParagens

    Private _nome As String
    Private _dataInicio As Date
    Private _dataFim As Date
    Private _localInicio As String
    Private _localFim As String

    Public Property Funcionarios As ClassFuncionarios
        Get
            Return _funcionarios
        End Get
        Set(value As ClassFuncionarios)
            _funcionarios = value
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

    Public Property Quartos As ClassQuartos
        Get
            Return _quartos
        End Get
        Set(value As ClassQuartos)
            _quartos = value
        End Set
    End Property

    Public Property AtividadesNavio As ClassAtividadesNavio
        Get
            Return _atividadesNavio
        End Get
        Set(value As ClassAtividadesNavio)
            _atividadesNavio = value
        End Set
    End Property

    Public Property AtividadesParagens As ClassAtividadesParagens
        Get
            Return _atividadesParagens
        End Get
        Set(value As ClassAtividadesParagens)
            _atividadesParagens = value
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

    Public Property Nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property

    Public Property DataInicio As Date
        Get
            Return _dataInicio
        End Get
        Set(value As Date)
            _dataInicio = value
        End Set
    End Property

    Public Property DataFim As Date
        Get
            Return _dataFim
        End Get
        Set(value As Date)
            _dataFim = value
        End Set
    End Property

    Public Property LocalInicio As String
        Get
            Return _localInicio
        End Get
        Set(value As String)
            _localInicio = value
        End Set
    End Property

    Public Property LocalFim As String
        Get
            Return _localFim
        End Get
        Set(value As String)
            _localFim = value
        End Set
    End Property

    Public Sub New()

    End Sub
    Public Sub New(ByVal Nome As String, ByVal datainicio As Date, ByVal datafim As Date, ByVal localInicio As String, ByVal LocalFim As String)
        Me.Nome = Nome
        Me.DataInicio = datainicio
        Me.DataFim = datafim
        Me.LocalInicio = localInicio
        Me.LocalFim = LocalFim

        Me.AtividadesNavio = New ClassAtividadesNavio
        Me.AtividadesParagens = New ClassAtividadesParagens
        Me.Funcionarios = New ClassFuncionarios
        Me.Viajantes = New ClassViajantes
        Me.Quartos = New ClassQuartos
        Me.Paragens = New ClassParagens


    End Sub

    Public Sub modificar(ByVal Nome As String, ByVal datainicio As Date, ByVal datafim As Date, ByVal localInicio As String, ByVal LocalFim As String)

        Me.Nome = Nome
        Me.DataInicio = datainicio
        Me.DataFim = datafim
        Me.LocalInicio = localInicio
        Me.LocalFim = LocalFim
    End Sub



>>>>>>> 6592d1b4dfacf26c6e3b1c680d8ca55a82e4032a
End Class
