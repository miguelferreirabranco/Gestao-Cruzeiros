Public Class ClassQuartos
    Inherits Collections.CollectionBase

    Public Sub Add(ByVal NewQuarto As ClassQuarto)
        Me.List.Add(NewQuarto)
    End Sub

    Public Sub Remove(ByVal Quarto As ClassQuarto)
        Me.List.Remove(Quarto)
    End Sub

    Default Public Property item(ByVal index As Integer) As ClassQuarto
        Get
            Return Me.List.Item(index)
        End Get
        Set(ByVal value As ClassQuarto)
            Me.List.Item(index) = value
        End Set
    End Property

    Public Shadows Sub clear()
        MyBase.Clear()
    End Sub

    Public Shadows Sub RemoveAt(ByVal index As Integer)
        Remove(item(index))
    End Sub
    Public Sub InsertAt(ByVal index As Integer, ByVal NewQuarto As ClassQuarto)
        Me.List.Insert(index, NewQuarto)
    End Sub

End Class
