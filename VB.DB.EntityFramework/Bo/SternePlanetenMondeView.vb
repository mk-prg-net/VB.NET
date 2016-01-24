''' <summary>
''' Allegmeine Eigenschaften eines Himmelskörpers werden aus einem HimmelskoerperTab- Entioty in
''' einer flachen Struktur präsentiert.
''' </summary>
''' <remarks></remarks>
Public Class SternePlanetenMondeView
    Inherits mko.VB.Db.BaseEntityView(Of VB.DB.EntityFramework.HimmelskoerperTab)

    Public Sub New()
        MyBase.New()
    End Sub

    ''' <summary>
    ''' Konstruktor. Nimmt das HimmelskoerperTab- Entity, das alle Daten für die Eigenschaften bereitstellt,
    ''' entgegen
    ''' </summary>
    ''' <param name="Entity"></param>
    ''' <remarks></remarks>
    Public Sub New(Entity As VB.DB.EntityFramework.HimmelskoerperTab)
        MyBase.New(Entity)
    End Sub

    ''' <summary>
    ''' Lisfert die Schlüssel des zugrundeliegenden HimmelskoerperTab- Entities
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overrides ReadOnly Property Keys As Object()
        Get
            Return New Object() {Entity.ID}
        End Get
    End Property




    ''' <summary>
    ''' Typ- Name des Himmelskoerpers (aus Tabelle HimmelskoerperTypenTab)
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Typ As String
        Get
            Return Entity.HimmelskoerperTypenTab.Name
        End Get
        Set(value As String)

        End Set
    End Property

    ''' <summary>
    ''' Name des Himmeslkoerpers
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Name As String
        Get
            Return Entity.Name
        End Get
        Set(value As String)
            SetProperty(value, Sub(v, e) e.Name = v)
        End Set
    End Property

    Const ErdmasseInKg As Double = 5.974E+24

    ''' <summary>
    ''' Gewicht des Himmelskoerpers in einer sinnvollen Masseangaben
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Masse As Double
        Get
            If New String() {"Planet"}.Any(Function(r) r = Entity.HimmelskoerperTypenTab.Name) Then
                ' Umrechnen in Erdmassen
                Return Entity.Masse_in_kg / mko.Newton.Mass.MassOfEarth.Value
            ElseIf New String() {"Stern", "Galaxie"}.Any(Function(r) r = Entity.HimmelskoerperTypenTab.Name) Then
                ' Umrechnen in Sonnenmassen
                Return Entity.Masse_in_kg / mko.Newton.Mass.MassOfSun.Value
            ElseIf New String() {"Mond", "Asteroid"}.Any(Function(r) r = Entity.HimmelskoerperTypenTab.Name) Then
                ' Umrechnen in Erdmondmassen
                Return Entity.Masse_in_kg / mko.Newton.Mass.MassOfEarthMoon.Value
            ElseIf "Komet" = Entity.HimmelskoerperTypenTab.Name Then
                ' Umrechnen in Bodenseemassen
                Return Entity.Masse_in_kg / mko.Newton.Mass.GesamtmasseBodenseewasser.Value
            Else
                Return Entity.Masse_in_kg

            End If
        End Get
        Set(value As Double)
            ' Setzen der Eigenschaft als Lambda- Ausdruck  aufzeichnen
            SetProperty(value, Sub(v, e)
                                   If New String() {"Planet"}.Any(Function(r) r = Entity.HimmelskoerperTypenTab.Name) Then
                                       ' Umrechnen in Erdmassen
                                       e.Masse_in_kg = v * mko.Newton.Mass.MassOfEarth.Value
                                   ElseIf New String() {"Stern", "Galaxie"}.Any(Function(r) r = Entity.HimmelskoerperTypenTab.Name) Then
                                       ' Umrechnen in Sonnenmassen
                                       e.Masse_in_kg = v * mko.Newton.Mass.MassOfSun.Value
                                   ElseIf New String() {"Mond", "Asteroid"}.Any(Function(r) r = Entity.HimmelskoerperTypenTab.Name) Then
                                       ' Umrechnen in Erdmondmassen
                                       e.Masse_in_kg = v * mko.Newton.Mass.MassOfEarthMoon.Value
                                   ElseIf "Komet" = Entity.HimmelskoerperTypenTab.Name Then
                                       ' Umrechnen in Bodenseemassen
                                       e.Masse_in_kg = v * mko.Newton.Mass.GesamtmasseBodenseewasser.Value
                                   Else
                                       e.Masse_in_kg = v

                                   End If
                               End Sub)

        End Set
    End Property

    Public ReadOnly Property MasseEinheit As String
        Get
            If New String() {"Planet"}.Any(Function(r) r = Entity.HimmelskoerperTypenTab.Name) Then
                ' Umrechnen in Erdmassen
                Return "Erdmassen"
            ElseIf New String() {"Stern", "Galaxie"}.Any(Function(r) r = Entity.HimmelskoerperTypenTab.Name) Then
                ' Umrechnen in Sonnenmassen
                Return "Sonnenmassen"
            ElseIf New String() {"Mond", "Asteroid"}.Any(Function(r) r = Entity.HimmelskoerperTypenTab.Name) Then
                ' Umrechnen in Erdmondmassen
                Return "Mondmassen"
            ElseIf "Komet" = Entity.HimmelskoerperTypenTab.Name Then
                ' Umrechnen in Bodenseemassen
                Return "Bodenseewassermassen"
            Else
                Return "kg"
            End If
        End Get
    End Property

    ''' <summary>
    ''' Abstand zum Zentralkoerper, d en dieser Himmelskörper umkreist
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property AbstandZentralkoerper As Double
        Get
            If Not Entity.Umlaufbahn Is Nothing Then
                Return Entity.Umlaufbahn.Laenge_grosse_Halbachse_in_km
            Else
                Return 0
            End If

        End Get
    End Property

End Class
