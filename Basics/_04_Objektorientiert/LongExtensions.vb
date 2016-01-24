Imports System.Runtime.CompilerServices

Public Module LongExtensions

    ''' <summary>
    ''' Liefert true, wenn z ungerade
    ''' </summary>
    ''' <param name="z"></param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension> _
    Public Function IsOdd(z As Long) As Boolean
        Return z Mod 2 = 1
    End Function

    ''' <summary>
    ''' Liefert true, wenn z gerade
    ''' </summary>
    ''' <param name="z"></param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension> _
    Public Function IsEven(z As Long) As Boolean
        Return z Mod 2 = 0
    End Function

    ''' <summary>
    ''' Liefert den Absoluten Betrag von z
    ''' </summary>
    ''' <param name="z"></param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension> _
    Public Function ABS(z As Long) As Long
        If z < 0 Then
            Return -z
        ElseIf z > 0 Then
            Return z
        Else
            Return 0
        End If
    End Function

    ''' <summary>
    ''' Liefert true, wenn z eine Primzahl ist
    ''' </summary>
    ''' <param name="z"></param>
    ''' <returns></returns>
    <System.Runtime.CompilerServices.Extension> _
    Public Function IsPrime(z As Long) As Boolean
        Return NumberTheory.IsPrime(z)
    End Function
End Module



