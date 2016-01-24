''' Klasse zum Darstellen und Rechnen mit römischen Zahlen. Es wird bei der 
''' Implementierung auf Funktionen aus der Bibliothek mko.Algo zurückgegriffen.
''' </summary>
Public Class Romzahl
    Public Sub New(Rom As String)
        Value = Rom
    End Sub

    Public Sub New(intRom As Long)
        Value = Zahlensysteme.ConvertToRom(intRom)
    End Sub

    Public Property Value() As String
        Get
            Return m_Value
        End Get
        Set(value As String)
            m_Value = Value
        End Set
    End Property
    Private m_Value As String

    Public Overrides Function ToString() As String
        Return Value
    End Function

    ''' <summary>
    ''' Konvertierungsoperator: berechnet den Wert, der durch eine Romzahl dargestellt
    ''' wird, und gibt ihn als long zurück
    ''' </summary>
    ''' <param name="a"></param>
    ''' <returns></returns>
    Public Shared Narrowing Operator CType(a As Romzahl) As Long
        Return Zahlensysteme.ConvertToInt(a.Value)
    End Operator

    ''' <summary>
    ''' Additionsoperator: Wandelt zunächst beide Summanden (Romzahlen) in longs um,
    ''' summiert diese und wandelt die Summe in eine Romzahl zurück
    ''' </summary>
    ''' <param name="a"></param>
    ''' <param name="b"></param>
    ''' <returns></returns>
    Public Shared Operator +(a As Romzahl, b As Romzahl) As Romzahl
        Return New Romzahl(CLng(a) + CLng(b))
    End Operator

End Class


