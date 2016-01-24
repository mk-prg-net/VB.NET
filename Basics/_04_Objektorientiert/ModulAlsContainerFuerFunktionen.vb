Public Module ModulAlsContainerFuerFunktionen

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

End Module
