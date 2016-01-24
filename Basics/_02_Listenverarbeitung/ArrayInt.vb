Public Class ArrayInt
    Private _array As Integer()

    Public Sub New(AnzElemente As Integer)
        _array = New Integer(AnzElemente - 1) {}
    End Sub

    ''' <summary>
    ''' Indexer: Eine Eigenschaft, die über den INdexzugriffsoperator
    ''' [ix] angesprochen wird
    ''' </summary>
    ''' <param name="ix"></param>
    ''' <returns></returns>
    Default Public Property Item(ix As Integer) As Integer

        Get
            Return _array(ix)
        End Get

        Set(value As Integer)
            _array(ix) = value
        End Set
    End Property

    ' Eine gewöhnliche, nur lesbare Eigenschaft
    Public ReadOnly Property Length() As Integer
        Get
            Return _array.Length
        End Get
    End Property



End Class
