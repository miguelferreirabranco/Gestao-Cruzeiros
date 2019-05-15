Public Class ClassCruzeiros
    Inherits Collections.CollectionBase

    Public Sub Add(ByVal NewMyObject As ClassCruzeiro)
        Me.List.Add(NewMyObject)
    End Sub

    Public Sub Remove(ByVal oldMyObject As ClassCruzeiro)
        Me.List.Remove(oldMyObject)
    End Sub

    Default Public Property item(ByVal index As Integer) As ClassCruzeiro
        Get
            Return Me.List.Item(index)
        End Get
        Set(ByVal value As ClassCruzeiro)
            Me.List.Item(index) = value
        End Set
    End Property

    Public Shadows Sub clear()
        MyBase.Clear()
    End Sub

    Public Shadows Sub RemoveAt(ByVal index As Integer)
        Remove(item(index))
    End Sub
    Public Sub InsertAt(ByVal index As Integer, ByVal NewMyObject As ClassParagem)
        Me.List.Insert(index, NewMyObject)
    End Sub
End Class
