Public Class PrimSet
    Implements IEnumerable(Of Long)


    Private _primz As Integer() = {2, 3, 5, 7, 11, 13, _
        17, 19, 23, 29, 31}

    ' Felder, die den BEreich definieren, aus dem die zu liefernden Primzahlen
    ' stammen
    Private _von As Long
    Private _bis As Long

    ' Konstruktor
    Public Sub New(von As Long, bis As Long)
        _von = von
        _bis = bis
    End Sub

    Public Function GetEnumerator() As IEnumerator(Of Long) Implements IEnumerable(Of Long).GetEnumerator
        Return New PrimEnumerator(_von, _bis)
    End Function

    Private Function System_Collections_IEnumerable_GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
        ' Die GetEnumerator aus .NET 1.0-1.1 liefert das, was die moderne GetEnumerator
        ' liefert.
        Return GetEnumerator()
    End Function

    ' Enumerator- Klasse
    Public Class PrimEnumerator
        Implements IEnumerator(Of Long)
        Private _von As Long
        Private _bis As Long
        Private _current As Long

        ' Konstruktor
        Public Sub New(von As Long, bis As Long)
            _von = von
            _bis = bis
            _current = von
        End Sub

        Public ReadOnly Property Current() As Long Implements IEnumerator(Of Long).Current
            Get
                Return _current
            End Get
        End Property

        Public Sub Dispose() Implements IDisposable.Dispose
            ' Hier könnte man externe Resourcen freigeben
        End Sub

        Private ReadOnly Property System_Collections_IEnumerator_Current() As Object Implements System.Collections.IEnumerator.Current
            Get
                Return Current
            End Get
        End Property

        Public Function MoveNext() As Boolean Implements IEnumerator(Of Long).MoveNext
            ' Die nächste, obere Primzahl bezüglich aktuellem _current bestimmen
            Dim prim As Long = mko.Algo.NumberTheory.PrimeFactors.NextUpperPrime(_current)

            If prim <= _bis Then
                _current = prim
                Return True
            Else
                Return False
            End If
        End Function

        Public Sub Reset() Implements IEnumerator(Of Long).Reset
            ' Wieder von vorne beginnen
            _current = _von
        End Sub
    End Class
End Class
