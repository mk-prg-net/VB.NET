Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class _04_06_Polymorphismus_anwenden

    Private Shared Sub ProgressInfo(Info As DMS.DirTree.DirTreeProgressInfo)
        Debug.WriteLine("Anz.Verz: " + Info.DirCount + ", AnzDateien: " + Info.FileCount)
    End Sub


    <TestMethod()> Public Sub _04_06_Polymorphismus_anwenden_Test()
        ' Ein Objekt vom JpgCounter erzeugen
        Dim MyCounter = New JpegCounter()

        AddHandler MyCounter.EventProgress, AddressOf ProgressInfo

        ' das zu untersuchende Verzeichnis scannen
        MyCounter.scanDir("C:\Users\Schulung\Documents\Visual Studio 2012\Projects\Bildergalerie")

        ' Ergebnis ausgeben
        Debug.WriteLine("Anz. JPG- Dateien = " + MyCounter.Count)

    End Sub

End Class