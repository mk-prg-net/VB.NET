Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

' Moderne Lösung: Erweiterungsmethoden für versiegelte Klassen
Public Module SchlachtschiffExtensions
    ' C# ist kein Attribut notwendig. Stattdessen 1 Parameter hat Schlüsselwort this
    ' static void schiesstAuf(this Schlachtschiff feuernder, Schlachtschiff befeuernter) {...}
    <System.Runtime.CompilerServices.Extension> _
    Public Sub schiesstAuf(feuernde As Schlachtschiff, befeuerte As Schlachtschiff)
        befeuerte.AnzLeben -= feuernde.Feuerkraft
    End Sub
End Module

<TestClass()> Public Class _02_03_Erweiterungsmethoden

    ' Klassische Lösung, einen Vorgegebene Klasse um Funktionen zu erweitern
    Private Shared Sub schiessen(feuernde As Schlachtschiff, befeuerte As Schlachtschiff)
        befeuerte.AnzLeben -= feuernde.Feuerkraft
    End Sub

    <TestMethod> _
    Public Sub _02_03_ErweiterungsmethodenTest()
        Dim l1 As Long = 13

        ' Klassisch
        Assert.IsTrue(LongExtensions.IsOdd(l1))

        ' Dank Erweiterungsmethode syntaktisch möglich
        Assert.IsTrue(l1.IsOdd())
        Assert.IsFalse(l1.IsEven())
        Assert.IsTrue(l1.IsPrime())

        Dim bismarck = New Schlachtschiff() With { _
            .AnzLeben = 100, _
            .Feuerkraft = 10 _
        }
        Dim hood = New Schlachtschiff() With { _
            .AnzLeben = 70, _
            .Feuerkraft = 10 _
        }

        schiessen(bismarck, hood)

        bismarck.schiesstAuf(hood)

        ' Kompiler übersetzt den vorausgegangenen Ausdruck in folgenden
        SchlachtschiffExtensions.schiesstAuf(bismarck, hood)

    End Sub

End Class