Public Class EuklidischerRaum

    ''' <summary>
    ''' Ein Tupel kwird durch ein eindim. Array dargestellt
    ''' </summary>
    ''' <param name="components"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CreateTupel(ParamArray components() As Double) As Double()
        Return components
    End Function

    Public Shared Function Distance(ParamArray vector() As Double) As Double

        Dim sqrSum As Double = 0
        For Each comp In vector
            sqrSum += comp * comp
        Next

        Return Math.Sqrt(sqrSum)

    End Function

End Class
