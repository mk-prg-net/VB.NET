Partial Public Class PrimList
    Implements IList(Of Long)



    ' Felder, die den BEreich definieren, aus dem die zu liefernden Primzahlen
    ' stammen
    Private _von As Long
    Private _bis As Long

    Private _PN As List(Of Long)

    ' Konstruktor
    Public Sub New(von As Long, bis As Long)
        _von = von
        _bis = bis

        '_PN = new List<long>((int)Math.Min(_bis - _von, 10000) / 2);
        _PN = mko.Algo.NumberTheory.PrimeFactors.scan(von, bis).ToList()
    End Sub


    Public Function IndexOf(item As Long) As Integer Implements IList(Of Long).IndexOf
        Throw New NotImplementedException()
    End Function

    Public Sub Insert(index As Integer, item As Long) Implements IList(Of Long).Insert
        Throw New NotImplementedException()
    End Sub

    Public Sub RemoveAt(index As Integer) Implements IList(Of Long).RemoveAt
        Throw New NotImplementedException()
    End Sub

    ''' <summary>
    ''' Indexer- Eigenschaft, der beim Abruf ein Indize übergeben wird
    ''' </summary>
    ''' <param name="index"></param>
    ''' <returns></returns>
    Default Public Property Item(index As Integer) As Long Implements IList(Of Long).Item
        Get
            If index < 0 OrElse index >= _PN.Count Then
                Throw New IndexOutOfRangeException("PrimList hat nur " + _PN.Count + " Elemente")
            End If
            Return _PN(index)
        End Get
        Set(value As Long)
            If index < 0 OrElse index >= _PN.Count Then
                Throw New IndexOutOfRangeException("PrimList hat nur " + _PN.Count + " Elemente")
            End If

            _PN(index) = value
        End Set
    End Property

    Public Sub Add(item As Long) Implements IList(Of Long).Add
        _PN.Add(item)
    End Sub

    Public Sub Clear() Implements IList(Of Long).Clear
        Throw New NotImplementedException()
    End Sub

    Public Function Contains(item As Long) As Boolean Implements IList(Of Long).Contains
        Return _PN.Contains(item)
    End Function

    Public Sub CopyTo(array As Long(), arrayIndex As Integer) Implements ICollection(Of Long).CopyTo
        _PN.CopyTo(array, arrayIndex)
    End Sub

    Public ReadOnly Property Count() As Integer Implements IList(Of Long).Count
        Get
            Return _PN.Count
        End Get
    End Property

    Public ReadOnly Property IsReadOnly() As Boolean Implements IList(Of Long).IsReadOnly
        Get
            Return False
        End Get
    End Property

    Public Function Remove(item As Long) As Boolean Implements IList(Of Long).Remove
        Return _PN.Remove(item)
    End Function

    Public Function GetEnumerator() As IEnumerator(Of Long) Implements IEnumerable(Of Long).GetEnumerator
        ' Die ausführliche Form verwendet einen selbstdefinierten Enumerator ...
        Return New PrimEnumerator(_PN.GetEnumerator())

        ' ... aber man kann auch einen bereits existierenden verwenden.
        'return _PN.GetEnumerator();    
    End Function

    Private Function System_Collections_IEnumerable_GetEnumerator() As System.Collections.IEnumerator Implements System.Collections.IEnumerable.GetEnumerator
        Return GetEnumerator()
    End Function

End Class
