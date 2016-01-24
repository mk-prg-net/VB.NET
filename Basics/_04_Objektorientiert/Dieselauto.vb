Public Class Dieselauto
    Inherits Auto
    Implements IComparable
    Implements IDisposable
    ''' <summary>
    ''' Konstruktoren einer Abgeleiteten Klasse müssen einen Konstruktor der Basisklasse in der sog. 
    ''' Initialisierungsliste ( nach dem Doppelpunkt) aufrufen
    ''' </summary>
    ''' <param name="Marke"></param>
    ''' <param name="Modell"></param>
    Public Sub New(Marke As String, Modell As String)


        MyBase.New(Marke, Modell, 100)
    End Sub

    ''' <summary>
    ''' Spezielle Methode zum betanken eines Dieselfahrzeuges. Diese überdeckt die Implementierung aus der Basisklasse. Das Schlüsselwort new dokumentiert dies
    ''' </summary>
    ''' <param name="mengeInLiter"></param>
    ''' <returns></returns>
    Public Shadows Function tanken(mengeInLiter As Double) As Double
        Debug.WriteLine("Dieselauto" + Marke + " " + Modell + " wurde betankt mit " + mengeInLiter + " Liter Diesel")
        Return mengeInLiter
    End Function

    Public Overrides Function tankenPolymorph(mengeInLiter As Double) As Double
        Debug.WriteLine("Dieselauto" + Marke + " " + Modell + " wurde polymorph betankt mit " + mengeInLiter + " Liter Diesel")
        Return mengeInLiter
    End Function

    'public override double tankenPolymorphAbstract(double mengeInLiter)
    '{
    '    Debug.Write("Abstrakte Mehode/ ");
    '    tanken(mengeInLiter);
    '    return mengeInLiter;
    '}

    'public override string ToString()
    '{
    '    return Marke + " " + Modell;
    '}

    Public Sub Dispose()
        'IDisposable ptrDsp = (IDisposable)(Auto)this;
        'ptrDsp.Dispose();


        System.Diagnostics.Debug.WriteLine(Marke + " Dieselauto: " + Modell + " wird nach " + EntfernungVonStuttgartInKm + "km mit Dispose verschrottet")

    End Sub

    Public Function CompareTo(obj As Object) As Integer Implements IComparable.CompareTo
        Dim anderesAuto = DirectCast(obj, Dieselauto)
        If anderesAuto.EntfernungVonStuttgartInKm > Me.EntfernungVonStuttgartInKm Then
            Return -1
        ElseIf anderesAuto.EntfernungVonStuttgartInKm < Me.EntfernungVonStuttgartInKm Then
            Return 1
        Else
            Return 0
        End If
    End Function
End Class

