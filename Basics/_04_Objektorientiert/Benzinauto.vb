Public Class Benzinauto
    Inherits Auto
    ''' <summary>
    ''' Konstruktoren einer Abgeleiteten Klasse müssen einen Konstruktor der Basisklasse in der sog. 
    ''' Initialisierungsliste ( nach dem Doppelpunkt) aufrufen
    ''' </summary>
    ''' <param name="Marke"></param>
    ''' <param name="Modell"></param>
    Public Sub New(Marke As String, Modell As String)
        MyBase.New(Marke, Modell)
    End Sub

    ''' <summary>
    ''' Allgemeine Methode zum betanken eines Fahrzeuges
    ''' </summary>
    ''' <param name="mengeInLiter"></param>
    ''' <returns></returns>
    Public Shadows Function tanken(mengeInLiter As Double) As Double
        Debug.WriteLine("Benzinauto" + Marke + " " + Modell + " wurde betankt mit " + mengeInLiter + " Liter Benzin")
        Return mengeInLiter
    End Function

    Public Overrides Function tankenPolymorph(mengeInLiter As Double) As Double
        Return tanken(mengeInLiter)
    End Function

    'public override double tankenPolymorphAbstract(double mengeInLiter)
    '{
    '    Debug.Write("Abstrakte Mehode/ ");
    '    tanken(mengeInLiter);
    '    return mengeInLiter;
    '}

    Public Function parken(von As DateTime, bis As DateTime, ort As String) As TimeSpan
        Throw New System.NotImplementedException()
    End Function

    Public Sub überholen(überholter As Auto)
        Throw New System.NotImplementedException()
    End Sub

End Class
