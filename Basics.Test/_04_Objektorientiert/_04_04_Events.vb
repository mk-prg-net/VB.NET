Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class _04_04_Events

    <TestMethod()> Public Sub _04_04_Events_Test()
        Dim FredVollgas = New Auto("Ferrari", "F4", 100)
        Dim RudiNormalo = New Auto("VW", "Passat", 103)
        Dim Susi = New Auto("Citroen", "Ente", 105)

        ' Eventhandler registrieren
        AddHandler FredVollgas.Hupen, AddressOf RudiNormalo.HöreHupe
        AddHandler FredVollgas.Hupen, AddressOf Susi.HöreHupe

        ' Events sind im Sinne des Aufrufes privat, bezüglich des Zugriffs öffentlich
        'FredVollgas.Hupen(99)

        FredVollgas.HupsignalAuslösen(1)


        For i As Integer = 0 To 999
            FredVollgas.fahre(100, 1)
            RudiNormalo.fahre(30, 1)
            Susi.fahre(20, 1)

            ' Situation bewerten
            FredVollgas.SituationBewerten(RudiNormalo, Susi)
        Next


    End Sub

End Class