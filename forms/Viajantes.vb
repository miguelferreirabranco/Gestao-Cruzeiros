Public Class Viajantes
    Inherits Collections.CollectionBase

    Public Sub Add(ByVal NewViajante As Viajante)
        Me.List.Add(NewViajante)
    End Sub

    Public Sub Remove(ByVal oldViajante As Viajante)
        Me.List.Remove(oldViajante)
    End Sub

    Default Public Property item(ByVal index As Integer) As Viajante
        Get
            Return Me.List.Item(index)
        End Get
        Set(ByVal value As Viajante)
            Me.List.Item(index) = value
        End Set
    End Property

    Public Shadows Sub clear()
        MyBase.Clear()
    End Sub

    Public Shadows Sub RemoveAt(ByVal index As Integer)
        Remove(item(index))
    End Sub

    Public Sub InsertAt(ByVal index As Integer, ByVal NewViajante As Viajante)
        Me.List.Insert(index, NewViajante)
    End Sub


End Class
