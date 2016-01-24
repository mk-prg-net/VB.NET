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


        Trace.WriteLine(mko.TraceHlp.FormatErrMsg(Me, "_01_00_PreprozessorTest", "Beispiel einer struturierten Fehlermeldung"))

        Trace.WriteLine(mko.TraceHlp.FormatInfoMsg(Me, "_01_00_PreprozessorTest", "Beispiel einer struturierten Infomeldung"))


    End Sub

End Class