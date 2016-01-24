Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Ctx = Basics._03_01_TryParse_Globalisierung


<TestClass()> Public Class _03_01_TryParse_Globalisierung

    <TestMethod> _
    Public Sub _03_01_TryParseTest()
        Dim wert = Ctx.ReadDouble("1234,567")
        Assert.AreEqual(1234.567, wert)

        wert = Ctx.ReadDouble("1,234567e3")
        Assert.AreEqual(1234.567, wert)

        wert = Ctx.ReadDouble_ch("1234.567")
        Assert.AreEqual(1234.567, wert)

        wert = Ctx.ReadDouble_ch("1.234567e3")
        Assert.AreEqual(1234.567, wert)

        wert = Ctx.ReadDouble_ch("1'234.567")
        Assert.AreEqual(1234.567, wert)


        ' Gesamten Kulturkontext temporär umschalten

        Dim bak = System.Threading.Thread.CurrentThread.CurrentCulture

        System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("de-CH")

        wert = Ctx.ReadDouble("Fr. 1'234.567")
        Assert.AreEqual(1234.567, wert)

        Dim strWert As String = wert.ToString("C")
        Assert.AreEqual("Fr. 1'234.57", strWert)

        strWert = wert.ToString("N")
        Assert.AreEqual("Fr. 1'234.57", strWert)

        System.Threading.Thread.CurrentThread.CurrentCulture = bak

    End Sub
End Class