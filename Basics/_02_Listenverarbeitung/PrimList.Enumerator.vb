Partial Public Class PrimList
    ' Enumerator- Klasse
    Public Class PrimEnumerator
        Implements IEnumerator(Of Long)

        Private _PN As IEnumerator(Of Long)


        ' Konstruktor
        Public Sub New(PN As IEnumerator(Of Long))
            _PN = PN
        End Sub

        Public ReadOnly Property Current() As Long Implements IEnumerator(Of Long).Current
            Get
                Return _PN.Current
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
            Return _PN.MoveNext()
        End Function

        Public Sub Reset() Implements IEnumerator(Of Long).Reset
            _PN.Reset()
        End Sub
    End Class




End Class
