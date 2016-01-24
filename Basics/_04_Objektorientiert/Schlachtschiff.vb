' Versigelte Klassen können nicht als Basisklassen herhalten, um sie durch
' Vererbung zu erweitern
Public NotInheritable Class Schlachtschiff
    ' Vereinfachte Property, die lediglich den Wert in einem anonymen, 
    ' internen Feld speichert
    Public Property Name() As String
    Public Property AnzLeben() As Integer
    Public Property Feuerkraft() As Integer
End Class

