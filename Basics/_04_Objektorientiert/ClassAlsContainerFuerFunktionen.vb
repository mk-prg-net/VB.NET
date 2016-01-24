Public Class ClassAlsContainerFuerFunktionen

    Dim _Faktor As Double

    Public Property Faktor As Double
        Get
            Return _Faktor
        End Get
        Set(value As Double)
            _Faktor = value
        End Set
    End Property

    Public Function Add(a As Double, b As Double) As Double
        Return (a + b) * Faktor
    End Function


    ' Faktor, der für alle Objekte der Klasse gilt
    Shared _FaktorAll As Double

    Public Shared Property FaktorAll As Double
        Get
            Return _FaktorAll
        End Get
        Set(value As Double)
            _FaktorAll = value
        End Set
    End Property


End Class
