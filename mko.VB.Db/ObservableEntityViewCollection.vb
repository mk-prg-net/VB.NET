Imports Defs = mko.VB.Db.BaseEntityViewDefs
Public MustInherit Class ObservableEntityViewCollection(Of TEntity As {New}, TEntityView As {BaseEntityView(Of TEntity)})
    Inherits System.Collections.ObjectModel.ObservableCollection(Of TEntityView)

    Public AddedViews As New Dictionary(Of TEntityView, TEntityView)
    Public DeletedViews As New Dictionary(Of TEntityView, TEntityView)

    ''' <summary>
    ''' Klassenfabrik für EntityViews
    ''' </summary>
    ''' <param name="Entity"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Protected MustOverride Function CreateEntityView(Entity As TEntity) As TEntityView

    Private IsLoading As Boolean = False

    ''' <summary>
    ''' Entites aus einer Datenquelle in die Collection kopieren
    ''' </summary>
    ''' <param name="EntitySet"></param>
    ''' <remarks></remarks>
    Public Sub LoadEntites(EntitySet As IEnumerable(Of TEntity))

        Try
            IsLoading = True

            For Each MyEntity In EntitySet
                Add(CreateEntityView(MyEntity))
            Next

            For Each EntityView In Me
                EntityView.State = Defs.ViewState.Unchanged
            Next

        Catch ex As Exception
            Throw New Exception("Load Entities", ex)
        Finally
            IsLoading = False
        End Try

    End Sub


    Public Shadows Sub Clear()
        MyBase.Clear()
        AddedViews.Clear()
        DeletedViews.Clear()
    End Sub



    Protected Overrides Sub OnCollectionChanged(e As Specialized.NotifyCollectionChangedEventArgs)
        MyBase.OnCollectionChanged(e)

        ' Nur Änderungen behandeln, wenn sie nicht von der LoadEntites- Funktion verursacht wurden
        If Not IsLoading Then
            Select Case (e.Action)
                Case Specialized.NotifyCollectionChangedAction.Add
                    For Each EntityView As TEntityView In e.NewItems
                        EntityView.State = Defs.ViewState.Added
                        AddedViews(EntityView) = EntityView
                    Next
                Case Specialized.NotifyCollectionChangedAction.Remove
                    For Each EntityView As TEntityView In e.OldItems
                        EntityView.State = Defs.ViewState.Deleted
                        If AddedViews.ContainsKey(EntityView) Then
                            AddedViews.Remove(EntityView)
                        Else
                            DeletedViews(EntityView) = EntityView
                        End If
                    Next
                Case Specialized.NotifyCollectionChangedAction.Replace
                    Debug.WriteLine("Replace")
                Case Specialized.NotifyCollectionChangedAction.Reset
                    Debug.WriteLine("Reset")
            End Select
        End If


    End Sub


End Class
