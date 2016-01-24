Public Class LieferantenViewCollection
    Inherits mko.VB.Db.ObservableEntityViewCollection(Of VB.Func.EntityFramework.Lieferanten, LieferantenView)

    Protected Overrides Function CreateEntityView(Entity As Func.EntityFramework.Lieferanten) As LieferantenView
        Return New LieferantenView(Entity)
    End Function

End Class
