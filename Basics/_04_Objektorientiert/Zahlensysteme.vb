Public Class Zahlensysteme
    ''' <summary>
    ''' Wandelt einen Integer oder Long in eine Romzal um
    ''' </summary>
    ''' <param name="Value"></param>
    ''' <returns></returns>
    Public Shared Function ConvertToRom(Value As Long) As String
        If Value >= 1000 Then
            Return Convert.ToString("M") & ConvertToRom(Value - 1000)
        ElseIf Value >= 500 Then
            Return Convert.ToString("D") & ConvertToRom(Value - 500)
        ElseIf Value >= 100 Then
            Return Convert.ToString("C") & ConvertToRom(Value - 100)
        ElseIf Value >= 50 Then
            Return Convert.ToString("L") & ConvertToRom(Value - 50)
        ElseIf Value >= 10 Then
            Return Convert.ToString("X") & ConvertToRom(Value - 10)
        ElseIf Value >= 5 Then
            Return Convert.ToString("V") & ConvertToRom(Value - 5)
        ElseIf Value >= 1 Then
            Return Convert.ToString("I") & ConvertToRom(Value - 1)
        Else
            Return ""
        End If
    End Function

    Private Shared Function RomZiffToLong(c As Char) As Long
        Return ValueOfRomanNumeral(c)
    End Function

    ''' <summary>
    ''' Wandelt eine Romzahl in einen long- Wert um. 
    ''' Konvertierung wird durch einen Linq- Ausdruck realisiert
    ''' </summary>
    ''' <param name="RomNumber"></param>
    ''' <returns></returns>
    Public Shared Function ConvertToInt(RomNumber As String) As Long
#If (DEBUG) Then
        ' "MDCLXVI" => Array von Char: 'M', 'D', ..., 'I'
        'var listDez = RomNumber.Select(c => ValueOfRomanNumeral(c));
        Dim listDez = RomNumber.[Select](New Func(Of Char, Long)(AddressOf RomZiffToLong))
        Dim sum As Long = listDez.Sum()
        Return sum

#Else

		Return RomNumber.[Select](Function(c) ValueOfRomanNumeral(c)).Sum()
#End If

    End Function

    ''' <summary>
    ''' Bestimmt den Wert einer römischen Ziffer
    ''' </summary>
    ''' <param name="a"></param>
    ''' <returns></returns>
    Public Shared Function ValueOfRomanNumeral(a As Char) As Integer
        Select Case a
            Case "M"c
                Return 1000
            Case "D"c
                Return 500
            Case "C"c
                Return 100
            Case "L"c
                Return 50
            Case "X"c
                Return 10
            Case "V"c
                Return 5
            Case "I"c
                Return 1
            Case Else
                Throw New Exception()
        End Select
    End Function

End Class
