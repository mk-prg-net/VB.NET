﻿Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Imports Ctx = Basics._01_03_Ausdruecke


''' <summary>
''' 
''' </summary>
''' <remarks></remarks>
<TestClass()> Public Class _01_03_Ausdruecke
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    <TestMethod()> Public Sub _01_03_AusdrueckeTests()


        ' Aufruf einer Funktion, die Pi liefert
        Dim pi_k As Double = Ctx.F_Pi_Kettenbruch()
        Assert.IsTrue(3.141 < pi_k AndAlso pi_k < 3.142)

        pi_k = Ctx.F_Pi_Kettenbruch2()

        ' Scheitert, da iif immer alle beide Fälle auswertet
        'Dim ggt0 As Integer = Ctx.GGT(18, 12)

        Dim ggt1 As Integer = Ctx.GGT2(18, 12)

        ' Aufruf einer Funktion, die den größten gemeinsamen Teiler aus zwei ganzen Zahlen berechnet
        Dim ggt As Integer = Ctx.GGT2(41 * 17 * 13 * 11, 19 * 13 * 7 * 5 * 3)
        Assert.AreEqual(ggt, 13)


        Dim a, b, c As Integer

        a = 1
        b = 2
        ' In einem logischen Kontext/innerhalb von Ausdrücken bedeutet = den Vergleichsoperator
        If c = a = b Then
            Assert.Fail()
        End If
        Assert.AreEqual(0, c)




    End Sub

End Class