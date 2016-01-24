Namespace astro
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Galaxie
        Inherits Himmelskoerper

        Public Overrides Property Masse_in_Sonnenmassen As Double
            ' Compiler erweitert zu
            ' Function GetMasse_in_Sonnenmassen() as Double ...
            Get
                Dim summeMassen As Double
                For Each Stern In Sterne
                    summeMassen += Stern.Masse_in_Sonnenmassen
                Next
                Return summeMassen
            End Get

            ' Compiler erweitert zu
            ' Sub SetMasse_in_Sonnenmassen(value as Double) ...
            Set(value As Double)
                ' Implementierung hier nicht sinnvoll
                Throw New NotImplementedException
            End Set
        End Property

        ''' <summary>
        ''' Liste aller Sterne, die in der Galaxie umherschwirren
        ''' </summary>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Public Property Sterne As Stern()

    End Class
End Namespace