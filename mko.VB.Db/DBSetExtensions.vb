Imports System.Runtime.CompilerServices
Imports Defs = mko.VB.Db.BaseEntityViewDefs

Public Module DBSetExtensions

    <Extension>
    Public Sub UpdateWithObservableViewCollection(Of TEntity As {New, Class}, TEntityView As {BaseEntityView(Of TEntity)})(Entities As System.Data.Entity.DbSet(Of TEntity), EntityViewCollection As ObservableEntityViewCollection(Of TEntity, TEntityView))

        Try
            ' 
            For Each AddedView In EntityViewCollection.AddedViews
                Entities.Add(AddedView.Value.Entity)
            Next

            For Each RemovedView In EntityViewCollection.DeletedViews
                Dim Entity = Entities.Find(RemovedView.Value.Keys)
                Entities.Remove(Entity)
            Next

            ' Modifizieren
            For Each View In EntityViewCollection.Where(Function(v) v.State = Defs.ViewState.Modified)
                Dim Entity = Entities.Find(View.Keys)
                View.UpdateExternalEntity(Entity)
            Next

            'Context.SaveChanges()

            For Each View In EntityViewCollection.Where(Function(v) v.State <> Defs.ViewState.Unchanged)
                View.State = Defs.ViewState.Unchanged
            Next

            EntityViewCollection.AddedViews.Clear()
            EntityViewCollection.DeletedViews.Clear()

        Catch ex As Exception
            Throw New Exception("mko.VB.Db.DBSetExtensions.UpdateWithObservableViewCollection", ex)
        End Try


    End Sub


End Module

