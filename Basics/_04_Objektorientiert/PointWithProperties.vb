Public Class PointWithProperties

    ''' <summary>
    ''' Defaultkonstruktor (leere PArameterliste!)
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()
    End Sub

    ''' Spezifischer Konstruktor
    ''' </summary>
    ''' <param name="X"></param>
    ''' <param name="Y"></param>
    Public Sub New(X As Double, Y As Double)
        ' Namenskonflikt zwischen Eigenschafts- und Parametername wird gelöst,
        ' indem die Eigenschaft mittels Me- Zeiger von dem PArameter unterschieden wird

        ' Die Zuweisung an die Eigenschaft X wird vom Compiler übersetzt in eine 
        ' Aufruf des setters: this.X = X; -> this.X.set(X);
        Me.X = X
        Me.Y = Y
    End Sub


    ' Implementierung des internen Zustandes
    Private _X As Double
    Private _Y As Double

    ' Zugriffsschicht auf den internen Zustand

    ''' <summary>
    ''' X- Koordinate
    ''' </summary>
    Public Property X() As Double
        ' Kompiler formt aus get-> double get() ...
        Get
            Return _X
        End Get

        Set(value As Double)
            ' value ist der implizit der set- MEthode übergeben PArameter
            ' void set(double value) ...
            _X = value
        End Set
    End Property

    ''' <summary>
    ''' X- Koordinate
    ''' </summary>
    Public Property Y() As Double
        ' Kompiler formt aus get-> double get() ...
        Get
            Return _Y
        End Get

        Set(value As Double)
            ' value ist der implizit der set- MEthode übergeben PArameter
            ' void set(double value) ...
            _Y = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return "(" + X + ", " + Y + ") dEuklid= " + Math.Round(Math.Sqrt(X * X + Y * Y), 2)
    End Function


End Class
