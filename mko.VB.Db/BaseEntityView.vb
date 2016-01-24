Imports mkoAlgorithm
Imports System.Runtime.CompilerServices
Public MustInherit Class BaseEntityView(Of TEntity As {New})

    ''' <summary>
    ''' Lokales Entity, das die darzustellenden und zu verarbeitenden Eigenschaften anbietet
    ''' </summary>
    ''' <remarks></remarks>
    Public Entity As TEntity

    ''' <summary>
    ''' Bearbeitungszustand einer View
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property State As ViewState = ViewState.Detached

    Protected Sub New()
        Entity = New TEntity()
    End Sub

    Protected Sub New(Entity As TEntity)
        Me.Entity = Entity
    End Sub

    ''' <summary>
    ''' Liefert alle Schlüsselkomponenten zum aktuellen Entity
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public MustOverride ReadOnly Property Keys As Object()



    ''' <summary>
    ''' Alle Aktualisierungen, die am Entity vorzunehen sind, werden hier zwischengespeichert
    ''' </summary>
    ''' <remarks></remarks>
    Protected QueuedJobsForPropertiesUpdate As New Queue(Of Action(Of TEntity))

    ''' <summary>
    ''' True, wenn Eigenschaften der View aktualisiert wurden
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public ReadOnly Property HasUpdates As Boolean
        Get
            Return QueuedJobsForPropertiesUpdate.Count > 0
        End Get
    End Property


    Protected Sub SetProperty(Of TProp)(Value As TProp, PropertySetter As Action(Of TProp, TEntity))
        ' View als Modifiziert kennzeichnen
        State = ViewState.Modified

        ' Ausgewählte Eigenschaft im lokalen Entity der View setzen
        PropertySetter(Value, Entity)

        ' Aktualisierungsauftrag für externes Entity aufgeben
        Dim job As Action(Of TEntity) = PropertySetter.Curry(Value)
        QueuedJobsForPropertiesUpdate.Enqueue(job)
    End Sub

    ''' <summary>
    ''' Alle auf am lokalen Entity durchgeführten Änderungen an einem externen Entity ebenfalls durchfürhen
    ''' Das externe Entity kann z.B. aus Teil einer Datenbank sein.
    ''' </summary>
    ''' <param name="Entity">externes Entity</param>
    ''' <remarks></remarks>
    Public Sub UpdateExternalEntity(Entity As TEntity)

        For Each JobForPropertyUpdate In QueuedJobsForPropertiesUpdate
            ' Aktualisierungen einer Eigenschaft auf dem externen Entity ausführen
            JobForPropertyUpdate(Entity)
        Next

    End Sub


End Class
