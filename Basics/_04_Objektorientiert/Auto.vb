Public Class Auto
    Implements IDisposable

    ' Events

    ' 1) Delegate für Hupsignal definieren

    Public Delegate Sub DGHupen(ANzHupsignale As Integer)


    ' 2) Mittels Delegate einen Member deklarieren, an dem andere 
    ' Verkehrsteilnehmer ihre HupeHören Eventhandler registrieren können

    Public Event Hupen As DGHupen


    ' 3) Methode zum Auslösden des Events bereitstellen
    Public Sub HupsignalAuslösen(AnzHupsignale As Integer)
        RaiseEvent Hupen(AnzHupsignale)
    End Sub


    ' 4) Reaktion auf Hupsignal

    Public Sub HöreHupe(AnzHupsignal As Integer)
        If AnzHupsignal < 3 Then
            Debug.WriteLine((Convert.ToString(Marke & Convert.ToString("\")) & Modell) & "Enternung: " & EntfernungVonStuttgartInKm & " Grummel ....")
        Else
            Debug.WriteLine((Convert.ToString(Marke & Convert.ToString("\")) & Modell) & "Enternung: " & EntfernungVonStuttgartInKm & " Hilfe !!!")
        End If
    End Sub


    Public Sub SituationBewerten(ParamArray andereVerkehrsteilnehmer As Auto())
        Dim bitteHupen As Boolean = False
        For Each Teilnehmer In andereVerkehrsteilnehmer
            Dim Abstand As Double = Teilnehmer.EntfernungVonStuttgartInKm - EntfernungVonStuttgartInKm
            If Abstand < 0.050000000000000003 AndAlso Abstand > 0.0 Then
                bitteHupen = True
            End If
        Next

        If bitteHupen Then
            HupsignalAuslösen(3)
        End If

    End Sub


    ' Nur lesbare Eigenschaften Marke und Modell
    Private _Marke As String
    Public ReadOnly Property Marke() As String
        Get
            Return _Marke
        End Get
    End Property

    Private _Modell As String
    Public ReadOnly Property Modell() As String
        Get
            Return _Modell
        End Get
    End Property

    ''' <summary>
    '''  Bsp. einer nur lesbaren Eigenschaft
    ''' </summary>
    Public Property VolleFahrzeugbezeichnung() As String
        Get
            Return Convert.ToString(Marke & Convert.ToString("/")) & Modell
        End Get

        Private Set(value As String)
        End Set
    End Property


    ' Liste der Konstruktoren

    Private Sub MeldeGeburt(Marke As String, Modell As String)
        Debug.WriteLine(Convert.ToString((Convert.ToString("Geburt Marke: ") & Marke) & " Modell: ") & Modell)
    End Sub

    ''' <summary>
    ''' Default- Konstruktor. Wird z.B. vom Objektinitialisierer new Auto(){....} benötigt
    ''' </summary>
    Public Sub New()
        _Marke = "unbekannt"
        _Modell = "unbekannt"

        MeldeGeburt(_Marke, _Modell)
    End Sub

    ''' <summary>
    ''' Konstruktoren
    ''' </summary>
    ''' <param name="Marke">Automarke</param>
    ''' <param name="Modell">Modell der Marke</param>
    ''' 
    Public Sub New(Marke As String, Modell As String)
        _Marke = Marke
        _Modell = Modell

#If (Debug) Then
#End If
        MeldeGeburt(_Marke, _Modell)
    End Sub

    ''' <summary>
    ''' Konstruktor 2
    ''' </summary>
    ''' <param name="Marke"></param>
    ''' <param name="Modell"></param>
    ''' <param name="EntfernungVonStuttgartInKm">Startpunkt des Autos, gemessen von Stuttgart aus</param>
    Public Sub New(Marke As String, Modell As String, EntfernungVonStuttgartInKm As Double)
        _Marke = Marke
        _Modell = Modell
        Me.EntfernungVonStuttgartInKm = EntfernungVonStuttgartInKm

#If (Debug) Then
#End If
        MeldeGeburt(_Marke, _Modell)
    End Sub

    Public Sub New(Marke As String, Modell As String, EntfernungVonStuttgartInKm As Double, vStart As Double)
        _Marke = Marke
        _Modell = Modell
        Me.EntfernungVonStuttgartInKm = EntfernungVonStuttgartInKm
#If (Debug) Then
#End If
        MeldeGeburt(_Marke, _Modell)
    End Sub

    ' Destruktor: Wird Aufgerufen, wenn das Objekt durch den Garbage Collector im Speicher gelöscht wird
    Protected Overrides Sub Finalize()
        Try
            System.Diagnostics.Debug.WriteLine((Convert.ToString(Marke & Convert.ToString(" Modell: ")) & Modell) & " wird nach " & EntfernungVonStuttgartInKm & "km verschrottet")
        Finally
            MyBase.Finalize()
        End Try
    End Sub

    Private _EntfernungVonStuttgartInKm As Double
    Public Property EntfernungVonStuttgartInKm() As Double
        Get
            Return _EntfernungVonStuttgartInKm
        End Get

        Set(value As Double)
            _EntfernungVonStuttgartInKm = value
        End Set
    End Property


    Public Function fahre(vInMProSek As Double, fahrzeitInSek As Double) As Double
        _EntfernungVonStuttgartInKm += (vInMProSek * fahrzeitInSek) / 1000.0
        Return _EntfernungVonStuttgartInKm
    End Function


    ''' <summary>
    ''' Allgemeine Methode zum betanken eines Fahrzeuges
    ''' </summary>
    ''' <param name="mengeInLiter"></param>
    ''' <returns></returns>
    Public Function tanken(mengeInLiter As Double) As Double
        Debug.WriteLine((Convert.ToString(Marke & Convert.ToString(" ")) & Modell) & " wurde betankt mit " & mengeInLiter & " Liter Treibstoff")
        Return mengeInLiter
    End Function

    ' Polymorphe Methode werden in der Basisklasse mit virtual gekennzeichnet
    Public Overridable Function tankenPolymorph(mengeInLiter As Double) As Double
        Debug.WriteLine((Convert.ToString(Marke & Convert.ToString(" ")) & Modell) & " wurde betankt mit " & mengeInLiter & " Liter Treibstoff")
        Return mengeInLiter
    End Function


    ' Implementierung der Dispose- Methode
    'public void Dispose()
    '{
    '    throw new NotImplementedException();
    '}

    ' public void Dispose()     // implizit implementiert
    Private Sub IDisposable_Dispose() Implements IDisposable.Dispose
        ' explizit implementiert
        System.Diagnostics.Debug.WriteLine((Convert.ToString(Marke & Convert.ToString(" Modell: ")) & Modell) & " wird nach " & EntfernungVonStuttgartInKm & "km mit Dispose verschrottet")

        ' Explizit den Aufruf des Dstruktors durch den Garbage Collector abschalten (um eine doppelte Ressourcenfreigabe zu verhindern)
        GC.SuppressFinalize(Me)

    End Sub

    ' Primitive Eigenschaft 
    Public Property Schadensfreiheitklasse() As Integer
        Get
            Return _Schadensfreiheitklasse
        End Get
        Set(value As Integer)
            _Schadensfreiheitklasse = value
        End Set
    End Property
    Private _Schadensfreiheitklasse As Integer

    '
    Public Property SchadensfreiheitklasseSimpel() As Integer
        Get
            Return m_SchadensfreiheitklasseSimpel
        End Get
        Set(value As Integer)
            m_SchadensfreiheitklasseSimpel = value
        End Set
    End Property
    Private m_SchadensfreiheitklasseSimpel As Integer


End Class
