'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class HimmelskoerperTab
    Public Property ID As Integer
    Public Property Name As String
    Public Property Masse_in_kg As Double
    Public Property HimmelskoerperTyp_ID As Integer
    Public Property SpektralklasseId As Nullable(Of Integer)

    Public Overridable Property BildTab As ICollection(Of BildTab) = New HashSet(Of BildTab)
    Public Overridable Property RaumschiffeTab As RaumschiffeTab
    Public Overridable Property Sterne_Planeten_MondeTab As Sterne_Planeten_MondeTab
    Public Overridable Property HimmelskoerperTypenTab As HimmelskoerperTypenTab
    Public Overridable Property SpektralklasseTab As SpektralklasseTab
    Public Overridable Property Umlaufbahn As UmlaufbahnenTab
    Public Overridable Property TrabantenUmlaufbahnen As ICollection(Of UmlaufbahnenTab) = New HashSet(Of UmlaufbahnenTab)

End Class
