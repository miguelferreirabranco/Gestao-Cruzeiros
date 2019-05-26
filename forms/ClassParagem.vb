Public Class ClassParagem
    Private _localParagem As String
    Private _datainicio As Date
    Private _dataFim As Date

    Public Property LocalParagem As String
        Get
            Return _localParagem
        End Get
        Set(value As String)
            _localParagem = value
        End Set
    End Property

    Public Property DataInicio As Date
        Get
            Return _datainicio
        End Get
        Set(value As Date)
            _datainicio = value
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

    Public Sub New()

    End Sub

    Public Sub New(ByVal localparagem As String, ByVal datainicio As Date, ByVal datafim As Date)
        Me.LocalParagem = localparagem
        Me.DataInicio = datainicio

        Me.DataFim = datafim

    End Sub



End Class
