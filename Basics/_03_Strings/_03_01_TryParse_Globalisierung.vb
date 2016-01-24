Public Module _03_01_TryParse_Globalisierung

    ''' <summary>
    ''' Einlesen einer Gleitkommazahl in der Kultr des Systems
    ''' </summary>
    ''' <param name="valTxt"></param>
    ''' <returns></returns>
    Public Function ReadDouble(valTxt As String) As Double
        ' dank out kann auf die Initialisierung von val verzichtetwerden
        'double val = 0.0;
        Dim val As Double
        If Double.TryParse(valTxt, val) Then
            Return val
        Else
            Return Double.NaN
        End If

    End Function

    ''' <summary>
    ''' Einlesen der Gleitkommazahl in CH- Kultur
    ''' </summary>
    ''' <param name="valTxt"></param>
    ''' <returns></returns>
    Public Function ReadDouble_ch(valTxt As String) As Double
        ' Aktuelle Kultur des Threads wird ausgelesen

        Dim cult = System.Threading.Thread.CurrentThread.CurrentCulture

        Dim ch = New System.Globalization.CultureInfo("de-CH")


        ' dank out kann auf die Initialisierung von val verzichtetwerden
        'double val = 0.0;
        Dim val As Double
        If Double.TryParse(valTxt, System.Globalization.NumberStyles.Any, ch, val) Then
            Return val
        Else
            Return Double.NaN
        End If
    End Function

End Module
