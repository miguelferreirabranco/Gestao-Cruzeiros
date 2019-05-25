

Public Class ClassAtividadeBase
    Private _nome As String
    Private _datainicio As Date
    Private _dataFim As Date
    Private _tipo As String


    Public Property Nome As String
        Get
            Return _nome
        End Get
        Set(value As String)
            _nome = value
        End Set
    End Property



    Public Property Tipo As String
        Get
            Return _tipo
        End Get
        Set(value As String)
            _tipo = value
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


    Public Sub New(ByVal Nome As String, ByVal DataInicio As Date, ByVal DataFim As Date, ByVal Tipo As String)
        Me.Nome = Nome
        Me.DataInicio = DataInicio
        Me.DataFim = DataFim

        Me.Tipo = Tipo

    End Sub

    'Public Overridable Function AtividadeParaString() As String
    '    Return Me.Nome & vbTab & Me.Tipo & vbTab & Me.DataInicio.ToShortDateString & vbTab & Me.DataInicio.Hour & ":" & Me.DataInicio.Minute & vbTab & Me.DataFim.Hour & ":" & Me.DataFim.Minute
    'End Function

End Class
