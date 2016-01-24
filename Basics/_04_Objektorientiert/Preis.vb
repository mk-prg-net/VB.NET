Public Class Preis
    Implements IComparable


    ' Speichert einen PReis als Festkommabetrag
    ' z.B. 4,99 Euro -> 499 (*100)
    Private _Preis As Integer

    Public ReadOnly Property Preis_as_Dbl As Double
        Get
            Return _Preis / 100.0
        End Get
    End Property

    Public Sub New(PreisFestkomma As Integer)
        _Preis = PreisFestkomma
    End Sub

    Public Sub New()
        _Preis = 0
    End Sub

    Public Sub New(Euro As Integer, Cent As Integer)
        _Preis = Euro * 100 + Cent
    End Sub

    ''' <summary>
    ''' Liefert den ganzen Euroanteil eines Preises
    ''' </summary>
    ''' <returns></returns>
    Public Function GetEuro() As Integer
        Return _Preis / 100
    End Function

    ''' <summary>
    ''' Liefert den Cent- Anteil eines Preise
    ''' </summary>
    ''' <returns></returns>
    Public Function GetCent() As Integer
        Return _Preis - GetEuro() * 100
    End Function


    Public Sub SetPreis(Preis As Double)
        _Preis = CInt(Preis * 100)
    End Sub

    Public Shared Function Add(a As Preis, b As Preis) As Preis
        Return New Preis(a._Preis + b._Preis)
    End Function

    Public Overrides Function ToString() As String
        Return "" + GetEuro() + "," + GetCent() + " €"
    End Function


    Public ReadOnly Property FixpointValue As Integer
        Get
            Return _Preis
        End Get
    End Property


    Private Function IComparable_CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        ' Downcasten von obj in ein Preisobjekt
        Dim derAnderePreis As Preis = CType(obj, Preis)

        If _Preis < derAnderePreis._Preis Then
            Return -1
        ElseIf _Preis > derAnderePreis._Preis Then
            Return 1
        Else
            Return 0
        End If

    End Function



    
End Class
