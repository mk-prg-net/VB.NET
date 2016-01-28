Namespace States
    ''' <summary>
    ''' (c) Martin Korneffel 2016
    ''' Basisklasse der Workflow- Zustände
    ''' </summary>
    ''' <remarks></remarks>
    Public Class Base

        ' Name = Typname
        Public ReadOnly Property Name As String
            Get
                Dim t = Me.GetType()
                Dim n As String = t.Name.ToLower()
                Return n
            End Get
        End Property

    End Class
End Namespace

