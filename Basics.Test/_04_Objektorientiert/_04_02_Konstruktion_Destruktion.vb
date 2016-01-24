Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class _04_02_Konstruktion_Destruktion

    <TestMethod()> Public Sub _04_02_Konstruktion_Destruktion_Test()
        Dim HugosSchrottkiste As New Auto()

        HugosSchrottkiste.EntfernungVonStuttgartInKm = 200

        'HugosSchrottkiste.Dispose()

        ' Um die explizit implementierte Dispose- Methode aus IDisposable aufzurufen, muß zuvor ein Schnittstellenzeiger gezogen werden
        Dim ptrIDsp As IDisposable = HugosSchrottkiste
        ptrIDsp.Dispose()

        DirectCast(HugosSchrottkiste, IDisposable).Dispose()

        ' Simmulation von 'Scope' in C++
        Using Silberpfeil = New Auto("Mercedes", "Rennauto")
            Debug.WriteLine(Silberpfeil.Marke)
        End Using
        ' Hier wird automatisch Dispose aufgerufen
        Try
            Dim Silberpfeil2 = New Auto("Mercedes", "Rennauto2")
            'using(var heute = DateTime.Now)
            Using fredVollgas__1 = New Auto("Ferrari", "Testarossa")
                Debug.WriteLine(Silberpfeil2.Marke)
                ' Plötzlich passiert ein Fehler
                Throw New Exception()
                Debug.WriteLine("Nach dem Fehler")
            End Using
            ' Überschreiten der using- Blockgrenze fürht automat. zum Aufruf von 
            ' Dispose
            DirectCast(Silberpfeil2, IDisposable).Dispose()
        Catch generatedExceptionName As Exception
            Debug.WriteLine("Fehler aus using- Block wurde behandelt")
        End Try






        ' Die bessere Lösung wäre wohl nur explizite Implementierung zuzulassen, wobei der Zugriff auf die Schnittstellenelemente 
        ' von c# unterstützt wird wie folgt
        ' HugosSchrottkiste.IDisposable.Dispose();


        For k As Integer = 0 To 99
            Dim FredVollgas__2 As New Auto("Ferrari", "Nr " & k, 0, 80)

            Do
                Dim v As Double() = {20, 30, 10, 40, 50, 60, _
                    30, 10}
                Dim t As Double() = {40, 20, 30, 5, 3, 7, _
                    10, 15}

                ' Simulation: Vorankommen auf dem hat umkämpften linken Fahrstreifen
                For i As Integer = 0 To v.Length - 1
                    'Debug.WriteLine("Aktuelle Position von Fred Vollgas: {0:N3}", FredVollgas.EntfernungVonStuttgartInKm);
                    FredVollgas__2.fahre(v(i), t(i))
                Next
            Loop While FredVollgas__2.EntfernungVonStuttgartInKm < 50.0
        Next

        For k As Integer = 0 To 99
            Dim FredVollgas__2 As New Auto("VW", "Nr " & k, 0, 90)
            Using FredVollgas2 As New Auto("VW", "Nr " & k, 0, 80)
                Do
                    Dim v As Double() = {20, 30, 10, 40, 50, 60, _
                        30, 10}
                    Dim t As Double() = {40, 20, 30, 5, 3, 7, _
                        10, 15}

                    If k = 50 Then
                        GoTo Sprungmarke
                    End If

                    ' Simulation: Vorankommen auf dem hat umkämpften linken Fahrstreifen
                    For i As Integer = 0 To v.Length - 1
                        'Debug.WriteLine("Aktuelle Position von Fred Vollgas: {0:N3}", FredVollgas2.EntfernungVonStuttgartInKm);
                        FredVollgas2.fahre(v(i), t(i))
                    Next

                Loop While FredVollgas2.EntfernungVonStuttgartInKm < 50.0
                ' Ende using- Block
                'Einen "Schnittstellenzeiger ziehen", um auf die explizit definierte Dispose- Methode zuzugreifen
                'IDisposable dsp = FredVollgas;
                'dsp.Dispose();
            End Using
        Next
Sprungmarke:
    End Sub

End Class