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

Partial Public Class LaenderTab
    Public Property ID As Integer
    Public Property Name As String
    Public Property Laenderkennzeichen As String

    Public Overridable Property RaumschiffeTab As ICollection(Of RaumschiffeTab) = New HashSet(Of RaumschiffeTab)

End Class
