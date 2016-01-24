Namespace astro
    ''' <summary>
    ''' 
    ''' Basisklasse aller Himmelskörper.
    ''' Aus dieser kann dank des Schlüsselwortes MustInherit 
    ''' kein Objekt erzeugt.
    ''' Die Eigenschaft Masse ist in Abgeleiteten Klassen überschreibbar
    ''' </summary>
    ''' <remarks></remarks>
    Public MustInherit Class Himmelskoerper

        Public Property Name As String

        Public Overridable Property Masse_in_Sonnenmassen As Double

    End Class
End Namespace