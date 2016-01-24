Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class _04_03_Objektinitialisierer_anonyme_Typen

    Class Filedesccriptor
        Public filename As String
        Public filetype As String
        Public sizeInBytes As Long
    End Class



    <TestMethod()> Public Sub _04_03_Objektinitialisierer_anonyme_Typen_Test()
        ' Neu: Objektinitialisierer anstelle Konstruktors
        Dim fd2 As New Filedesccriptor() With { _
             .filename = "boot.ini", _
             .filetype = ".ini", _
             .sizeInBytes = 999 _
        }

        ' Typinferenz
        Dim i As Integer = 99

        ' var wurde aus JavaScript entlehnt
        Dim j = 199

        ' Typinferenz bedeutet keine Aufweichung der strengen Typisierung
        'j = "299"; // Fehler. In JavaScript wäre es kein Fehler, da JavaScript nicht typisiert ist

        ' Anonyme Typen
        Dim fdAnonym = New With { _
             .filename = "boot.ini", _
             .filetype = ".ini", _
             .sizeInBytes = 999 _
        }

        ' Auch für anonyme Typen gelten strenge Typisierung
        'fdAnonym.sizeInBytes = "Hallo Welt"; // Fehler            



    End Sub

End Class