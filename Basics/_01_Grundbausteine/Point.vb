Public Class Point

    Public Sub New()
        ' Hier könnte der Wert des Punktes aus einer z.B. DB geladen werden
    End Sub


    Public Sub New(XStart As Double, YStart As Double)
        X = XStart
        Y = YStart
    End Sub

    ' Die X und Y- Koordinaten werden über Felder
    ' angesprochen. Problem: Der Zugriff auf den 
    ' inneren Zustand und die Implementierung des 
    ' Zustandes sind nicht voneineander getrennt
    Public Property X As Double
    Public Property Y As Double



End Class
