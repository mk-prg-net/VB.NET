Public Structure SPoint

    ' Achtung: Strukturen dürfen den eingebauten Defaultkonstruktor nicht überschreiben
    'Public Sub New()
    '    X = 0
    '    Y = 0
    'End Sub

    ''' <summary>
    ''' Konstrutor mit 2 Parametern. 
    ''' </summary>
    ''' <param name="X"></param>
    ''' <param name="Y"></param>
    Public Sub New(X As Double, Y As Double)
        Me.X = X
        Me.Y = Y
    End Sub

    Public Property X As Double
    Public Property Y As Double


End Structure
