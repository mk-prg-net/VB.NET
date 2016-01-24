Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class _04_05_Vererbung_und_Polymorphismus

    <TestMethod()> Public Sub _04_05_Vererbung_und_Polymorphismus_Test()

        Dim FredVollgas As New Benzinauto("Ferrari", "F4")
        Dim RudiNormalo As New Dieselauto("VW", "Passat TDI")
        'Autobahn.Auto allgAuto = new Autobahn.Auto();

        Dim txt As String = FredVollgas.ToString()
        txt = RudiNormalo.ToString()

        'allgAuto.tankenPolymorph(100);

        ' as Cast fürht bei Typinkompatibilität zur Rückgabe eines null- Wertes
        Dim RudiNormaloAlsAuto As Auto = RudiNormalo
        ' as Autobahn.Auto;
        RudiNormalo.tanken(20)
        FredVollgas.tanken(30)

        RudiNormaloAlsAuto.tanken(30)

        RudiNormaloAlsAuto.tankenPolymorph(40)

        RudiNormalo.tankenPolymorph(45)

        DirectCast(RudiNormaloAlsAuto, IDisposable).Dispose()

        RudiNormalo.Dispose()

        FredVollgas.tanken(100)
        RudiNormalo.tanken(50)

        Dim einAuto As Auto = FredVollgas
        einAuto.tanken(33)
        einAuto.tankenPolymorph(33)

        einAuto = RudiNormalo
        einAuto.tanken(22)
        einAuto.tankenPolymorph(22)

        Dim flotte As Auto() = {FredVollgas, RudiNormalo}

        For i As Integer = 0 To flotte.Length - 1
            Debug.WriteLine("Auftanken für " + flotte(i).ToString() + " beginnt")
            flotte(i).tanken(10)

            flotte(i).tankenPolymorph(15)
        Next

    End Sub

End Class