'------------------------------------------------------------------------------
' <auto-generated>
'     Der Code wurde von einer Vorlage generiert.
'
'     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
'     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class RaumschiffeTab
    Public Property Start_der_Mission As Date
    Public Property HimmelskoerperID As Integer
    Public Property Land_ID As Integer
    Public Property RaumschiffAufgaben_ID As Integer

    Public Overridable Property HimmelskoerperTab As HimmelskoerperTab
    Public Overridable Property LaenderTab As LaenderTab
    Public Overridable Property AufgabenTab As ICollection(Of AufgabenTab) = New HashSet(Of AufgabenTab)

End Class
