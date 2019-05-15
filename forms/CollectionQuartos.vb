Public Class CollectionQuartos
    Inherits Collections.CollectionBase

    Public Sub Add(ByVal NewQuarto As Quarto)
        Me.List.Add(NewQuarto)
    End Sub

    Public Sub Remove(ByVal Quarto As Quarto)
        Me.List.Remove(Quarto)
    End Sub

    Default Public Property item(ByVal index As Integer) As Quarto
        Get
            Return Me.List.Item(index)
        End Get
        Set(ByVal value As Quarto)
            Me.List.Item(index) = value
        End Set
    End Property

    Public Shadows Sub clear()
        MyBase.Clear()
    End Sub

    Public Shadows Sub RemoveAt(ByVal index As Integer)
        Remove(item(index))
    End Sub
    Public Sub InsertAt(ByVal index As Integer, ByVal NewQuarto As Quarto)
        Me.List.Insert(index, NewQuarto)
    End Sub

End Class
