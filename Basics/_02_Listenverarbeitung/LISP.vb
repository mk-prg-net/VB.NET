Public Class LISP
    ''' <summary>
    ''' Erzeugt eine leere Liste
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <returns></returns>
    Public Shared Function L(Of T)() As IEnumerable(Of T)
        Return New T() {}
    End Function

    ''' <summary>
    ''' Erzeugt eine einelementige Liste
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="Element"></param>
    ''' <returns></returns>
    Public Shared Function L(Of T)(Element As T) As IEnumerable(Of T)
        Return New T() {Element}
    End Function

    Public Shared Function L(Of T)(ParamArray Elements As T()) As IEnumerable(Of T)
        Return Elements
    End Function

    ''' <summary>
    ''' Liefert das erste Element einer Liste
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="list"></param>
    ''' <returns></returns>
    Public Shared Function First(Of T)(list As IEnumerable(Of T)) As T
        Return list.First()
    End Function


    ''' <summary>
    ''' Liefert das Letzte Element einer Liste
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="list"></param>
    ''' <returns></returns>
    Public Shared Function Last(Of T)(list As IEnumerable(Of T)) As T
        Return list.Last()
    End Function

    ''' <summary>
    ''' Liefert den Rest einer Liste
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="list"></param>
    ''' <returns></returns>
    Public Shared Function Rest(Of T)(list As IEnumerable(Of T)) As IEnumerable(Of T)
        Return list.Skip(1)
    End Function

    ''' <summary>
    ''' Überspringt die ersten i- Elemente einer Liste und liefert den Rest.
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="list"></param>
    ''' <param name="i"></param>
    ''' <returns></returns>
    Public Shared Function Skip(Of T)(list As IEnumerable(Of T), i As Long) As IEnumerable(Of T)
        Return list.Skip(CInt(i))
    End Function

    ''' <summary>
    ''' Liefert die ersten i- Elemente einer Liste als Teilliste zurück
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="list"></param>
    ''' <param name="i"></param>
    ''' <returns></returns>
    Public Shared Function Take(Of T)(list As IEnumerable(Of T), i As Long) As IEnumerable(Of T)
        Return list.Take(CInt(i))
    End Function

    Public Shared Function [Get](Of T)(list As IEnumerable(Of T), index As Long) As T
        Return First(Take(Skip(list, index), 1))
    End Function

    Public Shared Function [Set](Of T)(list As IEnumerable(Of T), index As Long, newValue As T) As IEnumerable(Of T)
        Return Concat(Take(list, index), Concat(L(newValue), Skip(list, index + 1)))
    End Function


    ''' <summary>
    ''' Liefert eine Liste, in der alle Elemente in der umgekehrten Reihenfolge 
    ''' bezüglich der übergebenen Liste stehen.
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="list"></param>
    ''' <returns></returns>
    Public Shared Function Reverse(Of T)(list As IEnumerable(Of T)) As IEnumerable(Of T)
        Return list.Reverse()
    End Function

    ''' <summary>
    ''' Liefert eine Liste, die für jedes Element aus der übergebenen Liste das 
    ''' Abbild durch die Funktion f enthält.
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="list"></param>
    ''' <param name="f"></param>
    ''' <returns></returns>
    Public Shared Function ForEach(Of T)(list As IEnumerable(Of T), f As Func(Of T, T)) As IEnumerable(Of T)
        Return list.[Select](Function(r) f(r))
    End Function

    ''' <summary>
    ''' Zählt alle Einträge der übergebenen Liste
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="list"></param>
    ''' <returns></returns>
    Public Shared Function Count(Of T)(list As IEnumerable(Of T)) As Long
        Return list.Count()
    End Function

    ''' <summary>
    ''' Liefert True, wenn beide Listen den gleichen Inhalt haben, sonst false.
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="listA"></param>
    ''' <param name="listB"></param>
    ''' <returns></returns>
    Public Shared Function Equal(Of T)(listA As IEnumerable(Of T), listB As IEnumerable(Of T)) As Boolean
        Return listA.SequenceEqual(listB)
    End Function

    ' rein funktionale Implementierung von Equal
    Public Shared Function EqualPureFn(Of T)(listA As IEnumerable(Of T), listB As IEnumerable(Of T)) As Boolean
        If Count(listA) <> Count(listB) Then
            ' Ungleich lange Listen können nie gleich sein
            Return False
        ElseIf Count(listA) > 0 Then
            ' Rückführung auf die Prüfung, das der Anfang gleich ist, und der Rest auch
            Return First(listA).Equals(First(listB)) AndAlso EqualPureFn(Skip(listA, 1), Skip(listB, 1))
        Else
            ' zwei leere Listen sind immer gleich
            Return True
        End If
    End Function

    ''' <summary>
    ''' Liefert eine Liste, die am Anfang alle Elemente aus listA enthält,
    ''' und danach bis zum Ende mit allen Elementen aus listB fortsetzt.
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="listA"></param>
    ''' <param name="listB"></param>
    ''' <returns></returns>
    Public Shared Function Concat(Of T)(listA As IEnumerable(Of T), listB As IEnumerable(Of T)) As IEnumerable(Of T)
        Return listA.Concat(listB)
    End Function

    ''' <summary>
    ''' Liefert eine Kopie der Liste
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="list"></param>
    ''' <returns></returns>
    Public Shared Function Clone(Of T)(list As IEnumerable(Of T)) As IEnumerable(Of T)
        If list.Count() = 0 Then
            Return L(Of T)()
        Else
            Return Concat(L(First(list)), Clone(Rest(list)))
        End If

    End Function

    '-----------------------------------------------------------------------------------------
    ' Spezielle Algorithmen

    ''' <summary>
    ''' Vertausch in einer Liste die Inhalte der Plätze i und j.
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="list"></param>
    ''' <param name="i"></param>
    ''' <param name="j"></param>
    ''' <returns></returns>
    Public Shared Function SwapComplex(Of T)(list As IEnumerable(Of T), i As Long, j As Long) As IEnumerable(Of T)
        If i < j Then
            If i = 0 Then
                If j = Count(list) - 1 Then
                    Return Concat(L(Last(list)), Concat(Take(Skip(list, 1), Count(Skip(list, 1)) - 1), Take(list, 1)))
                Else
                    Return Concat(Take(Skip(list, j), 1), Concat(Concat(Take(Skip(list, 1), j - 1), Take(list, 1)), Skip(list, j + 1)))
                End If
            Else
                Return Concat(Take(list, i), Concat(Take(Skip(list, j), 1), Concat(Concat(Take(Skip(list, i + 1), j - i - 1), Take(Skip(list, i), 1)), Skip(list, j + 1))))
            End If
        ElseIf i > j Then
            ' wie oben, jedoch wird i durch j, und j durch i ersetzt
            If j = 0 Then
                If i = Count(list) - 1 Then
                    Return Concat(L(Last(list)), Concat(Take(Skip(list, 1), Count(Skip(list, 1)) - 1), Take(list, 1)))
                Else
                    Return Concat(Take(Skip(list, i), 1), Concat(Concat(Take(Skip(list, 1), i - 1), Take(list, 1)), Skip(list, i + 1)))
                End If
            Else
                Return Concat(Take(list, j), Concat(Take(Skip(list, i), 1), Concat(Concat(Take(Skip(list, j + 1), i - j - 1), Take(Skip(list, j), 1)), Skip(list, i + 1))))


            End If
        Else
            Return list
        End If
    End Function

    ''' <summary>
    ''' Optimierte Form von Swap. 
    ''' Die Optimierung erfolg durch Aufteilen in zwei Stufen
    ''' 1 Stufe: Alle benötigten Teillisten bilden
    ''' 2 Stufe: Teillisten in neuer Reihenfolge zusammenkleben und als eine Liste zurückgeben.
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="list"></param>
    ''' <param name="i"></param>
    ''' <param name="j"></param>
    ''' <returns></returns>
    Public Shared Function Swap(Of T)(list As IEnumerable(Of T), i As Long, j As Long) As IEnumerable(Of T)
        If i < j Then
            Return SwapOpt(Take(list, i), Take(Skip(list, i), 1), Take(Skip(list, i + 1), j - i - 1), Take(Skip(list, j), 1), Take(Skip(list, j + 1), 1))
        ElseIf i > j Then
            Return SwapOpt(Take(list, j), Take(Skip(list, j), 1), Take(Skip(list, j + 1), i - j - 1), Take(Skip(list, i), 1), Take(Skip(list, i + 1), 1))
        Else
            Return list
        End If

    End Function


    Private Shared Function SwapOpt(Of T)(header As IEnumerable(Of T), i As IEnumerable(Of T), body As IEnumerable(Of T), j As IEnumerable(Of T), [end] As IEnumerable(Of T)) As IEnumerable(Of T)
        Return Concat(header, Concat(j, Concat(body, Concat(i, [end]))))
    End Function

End Class

