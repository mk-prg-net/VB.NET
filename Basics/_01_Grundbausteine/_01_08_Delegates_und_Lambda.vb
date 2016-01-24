Public Module _01_08_Delegates_und_Lambda

    Public Function Add(a As Double, b As Double) As Double
        Return a + b
    End Function

    Public Function Mul(a As Double, b As Double) As Double
        Return a * b
    End Function

    ''' <summary>
    ''' Ein Delegate von System.Delegate ableiten, der zu den Mul und Add- MEthoden passt
    ''' </summary>
    ''' <param name="a"></param>
    ''' <param name="b"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Delegate Function DGBinOp(a As Double, b As Double) As Double

    ''' <summary>
    ''' Delegates einsetzen, um Rückrufmethoden an Unterprogramme zu übergeben.
    ''' Callback Designpattern (op ist der Callback).
    ''' </summary>
    ''' <param name="a"></param>
    ''' <param name="b"></param>
    ''' <param name="op"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Calculator(a As Double, b As Double, op As DGBinOp) As Double
        Return op.Invoke(a, b)
    End Function

    ''' <summary>
    ''' Verallgemeinerte Akkumulation.
    ''' Operationen der Art r = binOp(oN, binOp(oN-1, .... binOp(o0, Init))...)) werden berechnet
    ''' Wenn binOp = (a, b) => a+b, dann ist Akku die Summenbildung über alle Operanden.
    ''' Wenn binOp = (a, b) => a*b, dann ist Akku die Produktbildung über alle Operanden.
    ''' </summary>
    ''' <param name="InitVal"></param>
    ''' <param name="binOp"></param>
    ''' <param name="Operands"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function Akku(InitVal As Double, binOp As DGBinOp, ParamArray Operands() As Double) As Double
        Dim sum As Double = InitVal
        For Each operand As Double In Operands
            sum = binOp(sum, operand)
        Next

        Return sum
    End Function



End Module
