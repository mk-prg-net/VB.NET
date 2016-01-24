Public Class _01_05_05_Variablen_Sichtbarkeiten


    ' i als Member einer Klasse
    Dim i As Integer

    Public Sub Exe(i As Integer)

        Dim ii As Integer = i

        ' Namenskonflikt zw. Parameter und Member: auflösen mittels Me
        Me.i = i

        Up(i)

        Debug.Assert(i = ii)
        Debug.Assert(Me.i = i + 5)

    End Sub

    Sub Up(j As Integer)
        Dim i As Integer = 5

        ' Nur das lokale i wird geändert
        ' i += j wird vom Kompiler zu i = i + j
        i += j

        ' Zugriff auf den Member der Klasse
        Me.i = i
    End Sub

    Shared Function MakeID() As Long
        ' Static wird bei Programmstart angelegt und nie gelöscht. Ist aber nur in dieser Funktion sichbar
        Static id As Long = 0
        id += 1
        Return id

    End Function



End Class
