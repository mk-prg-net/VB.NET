Imports TPL = System.Threading.Tasks
Public Class Primzahl

    ''' <summary>
    ''' Asynchrone Methode
    ''' </summary>
    ''' <param name="von"></param>
    ''' <param name="bis"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function findenIn(ByVal von As Long, ByVal bis As Long) As List(Of Long)

        ' Ab hier wird ein Tas
        Dim primzahlen As New List(Of Long)

        For kandidat As Long = von To bis Step 1
            Dim kandidatCopy = kandidat
            Dim ogTeiler As Integer = CInt(Math.Sqrt(CDbl(kandidat)))

            Dim istPrimzahl As Boolean = Test(kandidatCopy)

            If istPrimzahl Then
                primzahlen.Add(kandidat)
            End If
        Next
        Return primzahlen
    End Function

    Public Shared Function Test(Prüfling As Long) As Boolean

        ' 1 als Primzahl ausschließen, da neutrales Element bezüglich Multiplikation
        If Prüfling = 1 Or Prüfling = 2 Then
            Return False
        End If

        Dim Teiler As Long = 2

        '  Wiederhole bis Teiler = Prüfling \ 2 + 1
        Dim Grenze As Long = (Prüfling \ 2 + 1)
        Do Until Teiler = Grenze

            ' Wenn Prüfling Mod Teiler = 0 dann 
            If Prüfling Mod Teiler = 0 Then
                'Debug.WriteLine("Teiler von " & Prüfling & " ist " & Teiler)
                Return False
                '    Sonst
            Else
                Teiler += 1
                ' Ende Wenn, dann, sonst
            End If

            '  Ende Wiederholung
        Loop

        Return True

        ' Ende Primzahltest

    End Function

End Class
