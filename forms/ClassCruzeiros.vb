Public Class ClassCruzeiros
    Inherits Collections.CollectionBase

    Public Sub Add(ByVal NewClassCruzeiro As ClassCruzeiro)
        Me.List.Add(NewClassCruzeiro)
    End Sub

    Public Sub Remove(ByVal oldClassCruzeiro As ClassCruzeiro)
        Me.List.Remove(oldClassCruzeiro)
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
    Public Sub InsertAt(ByVal index As Integer, ByVal NewClassCruzeiro As ClassCruzeiro)
        Me.List.Insert(index, NewClassCruzeiro)
    End Sub
End Class
