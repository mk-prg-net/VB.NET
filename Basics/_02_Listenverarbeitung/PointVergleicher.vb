Public Class PointVergleicher
    Implements IComparer(Of PointWithProperties)

    Public Function Compare(a As PointWithProperties, b As PointWithProperties) As Integer Implements IComparer(Of PointWithProperties).Compare
        ' Vergleich erfolgt über den euklidischen Abstand der Punkte vom Ursprung
        Dim dEuklid_a As Double = DEuklid(a)
        Dim dEuklid_b As Double = DEuklid(b)

        If dEuklid_a < dEuklid_b Then
            Return -1
        ElseIf dEuklid_a > dEuklid_b Then
            Return 1
        Else
            Return 0
        End If
    End Function

    Function DEuklid(p As PointVergleichbar)
        Return Math.Sqrt(p.X * p.X + p.Y * p.Y)
    End Function

End Class
