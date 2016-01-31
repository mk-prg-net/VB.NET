Public Interface INummeric(Of T)


    Function Add(B As T) As T

    ''' <summary>
    ''' Multiplikation auf T
    ''' </summary>
    ''' <param name="A"></param>
    ''' <param name="B"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Mul(B As T) As T

    ''' <summary>
    ''' Wurzelziehen von T
    ''' </summary>
    ''' <param name="A"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Function Sqrt() As T



End Interface
