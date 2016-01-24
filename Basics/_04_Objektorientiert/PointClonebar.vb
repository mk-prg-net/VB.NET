Public Class PointClonbar
    Implements ICloneable

    Public Sub New()
        X = 0
        Y = 0
    End Sub


    Public Sub New(X As Double, Y As Double)
        Me.X = X
        Me.Y = Y
    End Sub


    Public X As Double
    Public Y As Double

    Public Function Clone() As Object Implements ICloneable.Clone
        ' Ein neues Objekt
        Return New PointClonbar(X, Y)
    End Function

End Class
