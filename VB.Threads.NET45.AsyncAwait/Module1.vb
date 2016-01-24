Module Module1

    Sub Main()

        Dim res = Worker()
        While Not res.IsCompleted
            ' Warten, bis die Asynchrone Methode beendet wurde
            Debug.Write(".")
        End While

    End Sub


    Async Function Worker() As Task
        ' Hier beginnt die Asynchrone Arbeit. Es werden gleich mehrere Teilaufgaben gestartet
        Dim listePrim1 = Await Task.Run(Function() Primzahl.findenIn(1, 50000))
        Dim listePrim2 = Await Task.Run(Function() Primzahl.findenIn(50001, 100000))
        ' Es wird solange gewartet, bis alle mittels Await gestartete Teilaufgaben erledigt sind
    End Function

End Module
