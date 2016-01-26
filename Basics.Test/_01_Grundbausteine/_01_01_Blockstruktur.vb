Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Basics._01_02_Namespaces.Universum.Andromeda.Spiralarme.Sterne.Neutronensterne
Imports Milchneutron = Basics._01_02_Namespaces.Universum.Milchstrasse.Spiralarme.Sterne.Neutronensterne
'Imports Basics._01_02_Namespaces.Universum.Milchstrasse.Spiralarme.Sterne.Neutronensterne
'Imports Basics._01_02_Namespaces.Universum.Milchstrasse.Spiralarme.Sterne.Neutronensterne

' Aliasbezeichner für einen langen Namenspfad
Imports Milcharm = Basics._01_02_Namespaces.Universum.Milchstrasse.Spiralarme

' Aliasbezeichner für einen Datentyp
Imports Milchkern = Basics._01_02_Namespaces.Universum.Milchstrasse.Galaxiekern.Schwarzes_Loch



<TestClass()> Public Class _01_01_Blockstruktur

    <TestMethod()> Public Sub _00_01_Blockstruktur()
        Basics._01_01_Blockstruktur.Klassenblock.Unterprogrammblock()
        Basics._01_01_Blockstruktur.Klassenblock2.Unterprogrammblock()
        Basics._01_01_Blockstruktur.Modulblock.Klassenblock.Unterprogrammblock()
        Basics._01_01_Blockstruktur.Modulblock2.Unterprogrammblock()
        Basics._00_01_Blockstruktur_2.Modulblock.Unterprogrammblock()
    End Sub

    <TestMethod()> Public Sub _00_02_Namespaces()

        ' Zugriff über voll qualifizierten Namen
        Dim blackHole = New Basics._01_02_Namespaces.Universum.Andromeda.Galaxiekern.Schwarzes_Loch()

        Dim blackHole2 = New Basics._01_02_Namespaces.Universum.Milchstrasse.Galaxiekern.Schwarzes_Loch()

        Dim Andorpuls = New Pulsare()
        Dim Milchpuls = New Milchneutron.Pulsare()

        ' Zugriff über kurzen Aliasnamen für Datentyp
        Dim blackHole3 = New Milchkern()
        Assert.IsInstanceOfType(blackHole3, GetType(Basics._01_02_Namespaces.Universum.Milchstrasse.Galaxiekern.Schwarzes_Loch))

        ' Zugriff über kurzen Aliasnamen für Namensraum
        Dim sonne = New Milcharm.Sterne.Sonnenähnliche()
        Assert.IsInstanceOfType(sonne, GetType(Basics._01_02_Namespaces.Universum.Milchstrasse.Spiralarme.Sterne.Sonnenähnliche))

        If TypeOf sonne Is Basics._01_02_Namespaces.Universum.Milchstrasse.Spiralarme.Sterne.Sonnenähnliche Then
            Assert.IsTrue(True)
        End If

        Dim typSonne As Type = sonne.[GetType]()
        Dim typSonnenähnlich As Type = GetType(Basics._01_02_Namespaces.Universum.Milchstrasse.Spiralarme.Sterne.Sonnenähnliche)

        If [Object].ReferenceEquals(typSonne, typSonnenähnlich) Then
            Assert.IsTrue(True)
        End If

        ' Das typSonne und typSonnenähnlich Referenztypen sind, ist
        ' folgender Vergleich auf Identität gleichwertig mit Objekt.ReferenceEquals
        If typSonne = typSonnenähnlich Then
            Assert.IsTrue(True)
        End If

        ' Zugriff über using
        Dim supermagnet = New Magnetare()
        Assert.IsInstanceOfType(supermagnet, GetType(Basics._01_02_Namespaces.Universum.Milchstrasse.Spiralarme.Sterne.Neutronensterne.Magnetare))



    End Sub
End Class