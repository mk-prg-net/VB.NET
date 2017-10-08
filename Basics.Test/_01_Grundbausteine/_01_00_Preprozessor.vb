#Const MyConst = True
'#Const MyConst = False
Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class _01_00_Preprozessor

    <TestMethod()> Public Sub _01_00_PreprozessorTest()



#If Debug Or Trace Then

        ' Ausgabe von Meldungen der Klasse Debug und Trace umleiten in eine Tesxtdatei
        Dim txtWriter As New System.Diagnostics.TextWriterTraceListener("Trace.txt")
        Debug.Listeners.Add(txtWriter)
        Trace.Listeners.Add(txtWriter)

        Debug.AutoFlush = True
        Trace.AutoFlush = True


        Dim MySwitch As New System.Diagnostics.TraceSwitch("MySwitch", "Steuer des Tracings")
        'MySwitch.Level = TraceLevel.Info

#End If


#If MyConst Then
        Trace.WriteLine("Myconst ist gesetzt")
#Else
        Trace.WriteLine("Myconst ist nicht gesetzt")
#End If

#If DEBUG Then
        Trace.WriteLine("DEBUG ist gesetzt")
#Else
        Trace.WriteLine("DEBUG ist nicht gesetzt")
#End If

        Debug.WriteLine("Ausgabe erfolgte mit Debug- Klasse")
        Trace.WriteLine("Ausgabe erfolgte mit Trace- Klasse")

        Trace.WriteLineIf(MySwitch.TraceError, "Eine bedingte Fehlermeldung")
        Trace.WriteLineIf(MySwitch.TraceWarning, "Eine bedingte Warnung")
        Trace.WriteLineIf(MySwitch.TraceInfo, "Eine bedingte Info")
        Trace.WriteLineIf(MySwitch.TraceVerbose, "Eine bedingte ausführliche Meldung")


        Dim zähler As Double = 1
        Dim nenner As Double

        nenner = 0

        Debug.Assert(nenner <> 0.0, "Achtung, eine Division durch 0 droht")
        Dim quotient = zähler / nenner


        Trace.WriteLine(mko.TraceHlp.FormatErrMsg(Me, "_01_00_PreprozessorTest", "Beispiel einer struturierten Fehlermeldung"))

        Trace.WriteLine(mko.TraceHlp.FormatInfoMsg(Me, "_01_00_PreprozessorTest", "Beispiel einer struturierten Infomeldung"))

    End Sub

End Class