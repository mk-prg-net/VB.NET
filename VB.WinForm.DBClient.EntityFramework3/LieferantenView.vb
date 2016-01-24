Public Class LieferantenView
    Inherits mko.VB.Db.BaseEntityView(Of VB.Func.EntityFramework.Lieferanten)

    Public Sub New()
        MyBase.New()
    End Sub

    Public Sub New(Entity As VB.Func.EntityFramework.Lieferanten)
        MyBase.New(Entity)
    End Sub

    Public Overrides ReadOnly Property Keys As Object()
        Get
            Return New Object() {Entity.lfnr}
        End Get
    End Property

    ' Für alle Eigenschaften des Lieferantenentity jeweils eine Eigenschaft in der View implementieren

    Public Property lnfr As Integer
        Get
            Return Entity.lfnr
        End Get
        Set(value As Integer)
            SetProperty(value, Sub(v, e) e.lfnr = v)
        End Set
    End Property

    Public Property name As String
        Get
            Return Entity.name
        End Get
        Set(value As String)
            SetProperty(value, Sub(v, e) e.name = v)
        End Set
    End Property

    Public Property email As String
        Get
            Return Entity.email
        End Get
        Set(value As String)
            SetProperty(value, Sub(v, e) e.email = v)
        End Set
    End Property

    Public Property plz As String
        Get
            Return Entity.plz
        End Get
        Set(value As String)
            SetProperty(value, Sub(v, e) e.plz = v)
        End Set
    End Property

End Class
