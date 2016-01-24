''' <summary>
''' Aus ArrayGenerisch wird jetzt der generische Typ ArrayGenerisch2, indem 
''' der Datentyp für das interne Array zu einem Typparameter gemacht wird.
''' </summary>
Public Class ArrayGenerisch(Of T)
    Private _array As T()

    Public Sub New(AnzElemente As Integer)
        _array = New T(AnzElemente - 1) {}
    End Sub

    ''' <summary>
    ''' Indexer: Eine Eigenschaft, die über den INdexzugriffsoperator
    ''' [ix] angesprochen wird
    ''' </summary>
    ''' <param name="ix"></param>
    ''' <returns></returns>
    Default Public Property Item(ix As Integer) As T

        Get
            Return _array(ix)
        End Get

        Set(value As T)
            _array(ix) = value
        End Set
    End Property


    Public ReadOnly Property Length() As Integer
        Get
            Return _array.Length
        End Get
    End Property

End Class
