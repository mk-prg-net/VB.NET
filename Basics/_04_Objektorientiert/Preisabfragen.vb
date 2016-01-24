Option Strict On
Public Module Preisabfragen

    Public Function AufsteigendSortiert(liste As IEnumerable(Of Preis)) As IEnumerable(Of Preis)
        Return liste.OrderBy(Function(p) p)
    End Function

    Public Function PreiseGrößerXEuro(liste As IEnumerable(Of Preis), unteresPreislimit As Preis) As IEnumerable(Of Preis)
        'Return liste.Where(Function(p) CType(p, IComparable(Of Preis)).CompareTo(unteresPreislimit) > 0)
        Return liste.Where(Function(p) p.GetEuro() > unteresPreislimit.GetEuro())
    End Function


End Module
