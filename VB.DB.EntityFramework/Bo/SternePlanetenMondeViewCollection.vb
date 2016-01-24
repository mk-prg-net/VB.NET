Public Class SternePlanetenMondeViewCollection
    Inherits mko.VB.Db.ObservableEntityViewCollection(Of VB.DB.EntityFramework.HimmelskoerperTab, SternePlanetenMondeView)


    Protected Overrides Function CreateEntityView(Entity As EntityFramework.HimmelskoerperTab) As SternePlanetenMondeView
        Return New SternePlanetenMondeView(Entity)
    End Function

End Class
