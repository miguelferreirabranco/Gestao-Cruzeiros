Public Class ClassViajantes
    Inherits Collections.CollectionBase

    Public Sub Add(ByVal NewViajante As ClassViajante)
        Me.List.Add(NewViajante)
    End Sub

    Public Sub Remove(ByVal oldViajante As ClassViajante)
        Me.List.Remove(oldViajante)
    End Sub

    Default Public Property item(ByVal index As Integer) As ClassViajante
        Get
            Return Me.List.Item(index)
        End Get
        Set(ByVal value As ClassViajante)
            Me.List.Item(index) = value
        End Set
    End Property

    Public Shadows Sub clear()
        MyBase.Clear()
    End Sub

    Public Shadows Sub RemoveAt(ByVal index As Integer)
        Remove(item(index))
    End Sub

    Public Sub InsertAt(ByVal index As Integer, ByVal NewViajante As ClassViajante)
        Me.List.Insert(index, NewViajante)
    End Sub


End Class
