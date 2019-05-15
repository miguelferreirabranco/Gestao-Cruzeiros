Public Class ClassCruzeiros
    Inherits Collections.CollectionBase

<<<<<<< HEAD
<<<<<<< HEAD
    Public Sub Add(ByVal NewFuncionario As ClassCruzeiro)
        Me.List.Add(NewFuncionario)
    End Sub

    Public Sub Remove(ByVal oldFuncionario As ClassCruzeiro)
        Me.List.Remove(oldFuncionario)
=======
=======
>>>>>>> 6592d1b4dfacf26c6e3b1c680d8ca55a82e4032a
    Public Sub Add(ByVal NewClassCruzeiro As ClassCruzeiro)
        Me.List.Add(NewClassCruzeiro)
    End Sub

    Public Sub Remove(ByVal oldClassCruzeiro As ClassCruzeiro)
        Me.List.Remove(oldClassCruzeiro)
<<<<<<< HEAD
>>>>>>> 6592d1b4dfacf26c6e3b1c680d8ca55a82e4032a
=======
>>>>>>> 6592d1b4dfacf26c6e3b1c680d8ca55a82e4032a
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
<<<<<<< HEAD
<<<<<<< HEAD

    Public Sub InsertAt(ByVal index As Integer, ByVal NewFuncionario As ClassFuncionario)
        Me.List.Insert(index, NewFuncionario)
    End Sub

=======
    Public Sub InsertAt(ByVal index As Integer, ByVal NewClassCruzeiro As ClassCruzeiro)
        Me.List.Insert(index, NewClassCruzeiro)
    End Sub
>>>>>>> 6592d1b4dfacf26c6e3b1c680d8ca55a82e4032a
=======
    Public Sub InsertAt(ByVal index As Integer, ByVal NewClassCruzeiro As ClassCruzeiro)
        Me.List.Insert(index, NewClassCruzeiro)
    End Sub
>>>>>>> 6592d1b4dfacf26c6e3b1c680d8ca55a82e4032a
End Class
