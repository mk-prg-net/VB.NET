Imports Defs = mko.VB.Db.BaseEntityViewDefs
Public MustInherit Class EntitiesAdapter(Of TContext As {System.Data.Entity.DbContext, New}, TEntity As {Class, New})

    Public Property Context As TContext

    Public Sub New(Context As TContext)
        Me.Context = Context
    End Sub

    Protected MustOverride ReadOnly Property Entities As System.Data.Entity.DbSet(Of TEntity)


    Public Sub UpdateDataBaseWith(Of TEntityView As {BaseEntityView(Of TEntity)})(EntityViewCollection As ObservableEntityViewCollection(Of TEntity, TEntityView))
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

            Context.SaveChanges()

            For Each View In EntityViewCollection.Where(Function(v) v.State <> Defs.ViewState.Unchanged)
                View.State = Defs.ViewState.Unchanged
            Next

            EntityViewCollection.AddedViews.Clear()
            EntityViewCollection.DeletedViews.Clear()

        Catch ex As Exception
            Throw New Exception("mko.VB.Db.EntitiesAdapter.Update", ex)
        End Try

    End Sub

End Class
