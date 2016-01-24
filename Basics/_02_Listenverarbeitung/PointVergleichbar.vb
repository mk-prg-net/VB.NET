Public Class PointVergleichbar
    Inherits PointWithProperties
    Implements IComparable(Of PointVergleichbar)

    Public Function CompareTo(other As PointVergleichbar) As Integer Implements IComparable(Of PointVergleichbar).CompareTo

        If DEuklid(Me) < DEuklid(other) Then
            Return -1
        ElseIf DEuklid(Me) > DEuklid(other) Then
            Return 1
        Else
            Return 0
        End If

    End Function

    Function DEuklid(p As PointVergleichbar)
        Return Math.Sqrt(p.X * p.X + p.Y * p.Y)
    End Function

End Class
