Public Class Calculator

    ''' <summary>
    ''' Aufzählung aller möglichen Operatoren
    ''' </summary>
    ''' <remarks></remarks>
    Public Enum Operatoren
        Add
        Subtract
        Mul
        Div
    End Enum

    ''' <summary>
    ''' Struktur eines DropDown- Listenelements zur oAuswahl eines Operators
    ''' </summary>
    ''' <remarks></remarks>
    Public Class OpSelection
        Public Property Op As Operatoren
        Public Property OpTxt As String
    End Class

    ''' <summary>
    ''' Liste für DropDown mit allen zur Verfügung stehenden Operationen
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared OpSelectionList() As OpSelection = { _
        New OpSelection() With {.Op = Operatoren.Add, .OpTxt = "+: ADD"}, _
        New OpSelection() With {.Op = Operatoren.Subtract, .OpTxt = "-: Sub"}, _
        New OpSelection() With {.Op = Operatoren.Mul, .OpTxt = "*: Mul"}, _
        New OpSelection() With {.Op = Operatoren.Div, .OpTxt = "/: Div"} _
    }


    ''' <summary>
    ''' Struktur der Protokolleinträge
    ''' </summary>
    ''' <remarks></remarks>
    Public Class ProtocolEntry
        Public Property Op As Operatoren

        Public Property OpA As Decimal
        Public Property OpB As Decimal
        Public Property Res As Decimal
    End Class

    ''' <summary>
    ''' Protokoll als Liste
    ''' </summary>
    ''' <remarks></remarks>
    Public Shared Protocol As New List(Of ProtocolEntry)


    Public Shared Function ADD(a As Decimal, b As Decimal) As Decimal
        Dim res = a + b
        Protocol.Add(New ProtocolEntry() With {.Op = Operatoren.Add, .OpA = a, .OpB = b, .Res = res})
        Return res
    End Function

    Public Shared Function Subtract(a As Decimal, b As Decimal) As Decimal
        Dim res = a - b
        Protocol.Add(New ProtocolEntry() With {.Op = Operatoren.Subtract, .OpA = a, .OpB = b, .Res = res})
        Return res
    End Function

    Public Shared Function Mul(a As Decimal, b As Decimal) As Decimal
        Dim res = a * b
        Protocol.Add(New ProtocolEntry() With {.Op = Operatoren.Mul, .OpA = a, .OpB = b, .Res = res})
        Return res
    End Function

    Public Shared Function Div(a As Decimal, b As Decimal) As Decimal
        Dim res = a / b
        Protocol.Add(New ProtocolEntry() With {.Op = Operatoren.Div, .OpA = a, .OpB = b, .Res = res})
        Return res
    End Function



End Class
