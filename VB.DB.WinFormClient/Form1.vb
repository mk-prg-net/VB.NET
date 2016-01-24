Imports System.Data.Entity
Public Class Form1

    Dim SPMs As New VB.DB.EntityFramework.SternePlanetenMondeViewCollection()
    Dim ctx As New VB.DB.EntityFramework.KeplerDBEntities

    Dim Query As IOrderedQueryable(Of VB.DB.EntityFramework.HimmelskoerperTab)

    Public Sub New()

        ' Dieser Aufruf ist für den Designer erforderlich.
        InitializeComponent()

        ' Fügen Sie Initialisierungen nach dem InitializeComponent()-Aufruf hinzu.

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '' Zugriff auf die Datenbank mittels Entity- Framework
        'Using ctx As New VB.DB.EntityFramework.KeplerDBEntities

        '    ctx.Configuration.LazyLoadingEnabled = False
        '    ctx.Configuration.ProxyCreationEnabled = True

        'Dim query = ctx.HimmelskoerperTab.Include(Function(r) r.HimmelskoerperTypenTab).Include(Function(r) r.Umlaufbahn) _
        '                                 .OrderBy(Function(r) r.Umlaufbahn.Laenge_grosse_Halbachse_in_km)

        Query = ctx.HimmelskoerperTab.OrderBy(Function(r) r.Umlaufbahn.Laenge_grosse_Halbachse_in_km)

        'SPMs.LoadEntites(query)
        'SPMBindingSource.DataSource = SPMs

        SPMBindingSource.DataSource = Query.ToArray().Select(Function(r) New VB.DB.EntityFramework.SternePlanetenMondeView(r))

        'End Using

        Dim Planeten = ctx.HimmelskoerperTab.Where(Function(r) r.HimmelskoerperTypenTab.Name = "Planet").ToArray().Select(Function(r) New VB.DB.EntityFramework.SternePlanetenMondeView(r))
        'Dim RepSrc = New Microsoft.Reporting.WinForms.ReportDataSource("VBDBEntityFramework", Planeten.ToArray())

        'PlanetenReportViewer.LocalReport.DataSources.Clear()
        'PlanetenReportViewer.LocalReport.DataSources.Add(RepSrc)

        PlanetenBindingSource.DataSource = Planeten.ToArray()
        Me.PlanetenReportViewer.RefreshReport()


        Dim Monde = ctx.HimmelskoerperTab.Where(Function(r) r.HimmelskoerperTypenTab.Name = "Mond").ToArray().Select(Function(r) New VB.DB.EntityFramework.SternePlanetenMondeView(r))
        MondeViewBindingSource.DataSource = Monde.ToArray()
        Me.MondeReportViewer.RefreshReport()

    End Sub


    ''' <summary>
    ''' Folgender Eventhandler dient zum Berechnen der zusätzlichen Spalte "Bild" in der DataGridView
    ''' SternePlanetenMonde. Das Bild wir aus einer ImageList- Komponente entnmommen (CBTypeImageList)
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub dgrSPM_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgrSPM.CellFormatting

        ' statische Variable überlebt das Ende dieses Eventhandlers, und stellt beim erneuten Aufruf
        ' den Inhalt aus dem vorausgegangenen wieder bereit. Hier wird der Name des Himmelskörpertyps
        ' aus Spalte 0 einer Tabellenzeile abgelegt
        Static NameHKTyp As String

        If e.ColumnIndex = 0 Then
            ' In Spalte 0 steht der Typname
            NameHKTyp = CType(e.Value, String)
        ElseIf e.DesiredType = GetType(Image) Then
            ' In der Bildspalte wir ein Bild aus der imagelist geladen. Als Zugriffsschlüssel
            ' dient der Typname aus Spalte 0
            e.Value = CBTypeImageList.Images(NameHKTyp)
        End If

        If TypeOf (sender) Is DataGridViewImageCell Then
            Debug.WriteLine(e)
        End If
    End Sub

    Private Sub SPMBindingSource_CurrentItemChanged(sender As Object, e As EventArgs) Handles SPMBindingSource.CurrentItemChanged



    End Sub

    Private Sub SPMBindingSource_BindingComplete(sender As Object, e As BindingCompleteEventArgs) Handles SPMBindingSource.BindingComplete

    End Sub

    Private Sub SPMBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles SPMBindingSource.CurrentChanged

        Dim bs = CType(sender, System.Windows.Forms.BindingSource)

        Dim View = CType(SPMBindingSource.Current, VB.DB.EntityFramework.SternePlanetenMondeView)

        If View.HasUpdates Then
            Dim EntityOri = ctx.HimmelskoerperTab.Find(View.Entity.ID)

            View.UpdateExternalEntity(EntityOri)
            ctx.SaveChanges()

            bs.DataSource = Query.ToArray().Select(Function(r) New VB.DB.EntityFramework.SternePlanetenMondeView(r))
            bs.ResetBindings(False)

        End If



    End Sub

    Private Sub cbxPlanetsOnly_CheckedChanged(sender As Object, e As EventArgs) Handles cbxPlanetsOnly.CheckedChanged

        If cbxPlanetsOnly.Checked Then
            SPMBindingSource.DataSource = Query.Where(Function(r) r.HimmelskoerperTypenTab.Name = "Planet") _
                                                .ToArray() _
                                                .Select(Function(r) New VB.DB.EntityFramework.SternePlanetenMondeView(r))
        Else

            SPMBindingSource.DataSource = Query.ToArray().Select(Function(r) New VB.DB.EntityFramework.SternePlanetenMondeView(r))
        End If

        SPMBindingSource.ResetBindings(False)


    End Sub
End Class
