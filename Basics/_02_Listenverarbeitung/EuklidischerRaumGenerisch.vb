Public Class EuklidischerRaumGenerisch

    ''' <summary>
    ''' Ein Tupel kwird durch ein eindim. Array dargestellt
    ''' </summary>
    ''' <param name="components"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function CreateTupel(Of T)(ParamArray components() As T) As T()
        Return components
    End Function

    ''' <summary>
    ''' Eine generische Funktion, deren Parameter Einschränkungen 
    ''' genügen müssen
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="vector"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function Distance(Of T As INummeric(Of T))(ParamArray vector() As T) As T
        '                                +-> Einschränkung für gen. Parameter

        Dim sqrSum As T = Nothing
        For Each comp In vector
            sqrSum = sqrSum.Add(comp.Mul(comp))
        Next

        Return sqrSum.Sqrt()

    End Function


End Class
