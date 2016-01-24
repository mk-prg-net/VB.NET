<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits VB.Winform.Template.WTmplForm

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Sie kann mit dem Windows Form-Designer geändert werden.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.PlanetenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgrSPM = New System.Windows.Forms.DataGridView()
        Me.TypDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Masse = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MasseEinheit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbstandZentralkoerper = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.img = New System.Windows.Forms.DataGridViewImageColumn()
        Me.SPMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tpPaging = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CBTypeImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.tpReport = New System.Windows.Forms.TabPage()
        Me.PlanetenReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.PagingBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tpDiagramm = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.PlanetenmassenSäulenChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.PlanetenmassenKuchenChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.cbxPlanetsOnly = New System.Windows.Forms.CheckBox()
        Me.tpMonde = New System.Windows.Forms.TabPage()
        Me.MondeReportViewer = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.MondeViewBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControlWinFormTemplate.SuspendLayout()
        Me.TabPageWTmpl_1.SuspendLayout()
        CType(Me.PlanetenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgrSPM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpPaging.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpReport.SuspendLayout()
        CType(Me.PagingBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpDiagramm.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.PlanetenmassenSäulenChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PlanetenmassenKuchenChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpMonde.SuspendLayout()
        CType(Me.MondeViewBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControlWinFormTemplate
        '
        Me.TabControlWinFormTemplate.Controls.Add(Me.tpPaging)
        Me.TabControlWinFormTemplate.Controls.Add(Me.tpReport)
        Me.TabControlWinFormTemplate.Controls.Add(Me.tpDiagramm)
        Me.TabControlWinFormTemplate.Controls.Add(Me.tpMonde)
        Me.TabControlWinFormTemplate.Controls.SetChildIndex(Me.tpMonde, 0)
        Me.TabControlWinFormTemplate.Controls.SetChildIndex(Me.tpDiagramm, 0)
        Me.TabControlWinFormTemplate.Controls.SetChildIndex(Me.tpReport, 0)
        Me.TabControlWinFormTemplate.Controls.SetChildIndex(Me.tpPaging, 0)
        Me.TabControlWinFormTemplate.Controls.SetChildIndex(Me.TabPageWTmpl_1, 0)
        '
        'TabPageWTmpl_1
        '
        Me.TabPageWTmpl_1.Controls.Add(Me.dgrSPM)
        Me.TabPageWTmpl_1.Controls.Add(Me.Panel1)
        Me.TabPageWTmpl_1.Text = "Sterne Planeten Monde"
        '
        'PlanetenBindingSource
        '
        Me.PlanetenBindingSource.DataSource = GetType(VB.DB.EntityFramework.SternePlanetenMondeView)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbxPlanetsOnly)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(626, 57)
        Me.Panel1.TabIndex = 0
        '
        'dgrSPM
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.dgrSPM.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgrSPM.AutoGenerateColumns = False
        Me.dgrSPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrSPM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TypDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.Masse, Me.MasseEinheit, Me.AbstandZentralkoerper, Me.img})
        Me.dgrSPM.DataSource = Me.SPMBindingSource
        Me.dgrSPM.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgrSPM.Location = New System.Drawing.Point(3, 60)
        Me.dgrSPM.Name = "dgrSPM"
        Me.dgrSPM.Size = New System.Drawing.Size(626, 215)
        Me.dgrSPM.TabIndex = 1
        '
        'TypDataGridViewTextBoxColumn
        '
        Me.TypDataGridViewTextBoxColumn.DataPropertyName = "Typ"
        Me.TypDataGridViewTextBoxColumn.HeaderText = "Typ"
        Me.TypDataGridViewTextBoxColumn.Name = "TypDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.Width = 200
        '
        'Masse
        '
        Me.Masse.DataPropertyName = "Masse"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N3"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Masse.DefaultCellStyle = DataGridViewCellStyle2
        Me.Masse.HeaderText = "Masse"
        Me.Masse.Name = "Masse"
        '
        'MasseEinheit
        '
        Me.MasseEinheit.DataPropertyName = "MasseEinheit"
        Me.MasseEinheit.HeaderText = "MasseEinheit"
        Me.MasseEinheit.Name = "MasseEinheit"
        Me.MasseEinheit.ReadOnly = True
        '
        'AbstandZentralkoerper
        '
        Me.AbstandZentralkoerper.DataPropertyName = "AbstandZentralkoerper"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.Format = "N0"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.AbstandZentralkoerper.DefaultCellStyle = DataGridViewCellStyle3
        Me.AbstandZentralkoerper.HeaderText = "r Umlaufbahn [km]"
        Me.AbstandZentralkoerper.Name = "AbstandZentralkoerper"
        Me.AbstandZentralkoerper.ReadOnly = True
        '
        'img
        '
        Me.img.HeaderText = "bild"
        Me.img.Name = "img"
        Me.img.ReadOnly = True
        '
        'SPMBindingSource
        '
        Me.SPMBindingSource.DataSource = GetType(VB.DB.EntityFramework.SternePlanetenMondeView)
        '
        'tpPaging
        '
        Me.tpPaging.Controls.Add(Me.SplitContainer1)
        Me.tpPaging.Location = New System.Drawing.Point(4, 22)
        Me.tpPaging.Name = "tpPaging"
        Me.tpPaging.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPaging.Size = New System.Drawing.Size(632, 278)
        Me.tpPaging.TabIndex = 2
        Me.tpPaging.Text = "Seitenweise Ausgabe"
        Me.tpPaging.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(626, 272)
        Me.SplitContainer1.SplitterDistance = 208
        Me.SplitContainer1.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(414, 272)
        Me.DataGridView1.TabIndex = 0
        '
        'CBTypeImageList
        '
        Me.CBTypeImageList.ImageStream = CType(resources.GetObject("CBTypeImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.CBTypeImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.CBTypeImageList.Images.SetKeyName(0, "Urknall")
        Me.CBTypeImageList.Images.SetKeyName(1, "Galaxie")
        Me.CBTypeImageList.Images.SetKeyName(2, "Schwarzes-Loch")
        Me.CBTypeImageList.Images.SetKeyName(3, "Stern")
        Me.CBTypeImageList.Images.SetKeyName(4, "Planet")
        Me.CBTypeImageList.Images.SetKeyName(5, "Mond")
        Me.CBTypeImageList.Images.SetKeyName(6, "Asteroid")
        Me.CBTypeImageList.Images.SetKeyName(7, "Komet")
        Me.CBTypeImageList.Images.SetKeyName(8, "Raumschiff")
        '
        'tpReport
        '
        Me.tpReport.Controls.Add(Me.PlanetenReportViewer)
        Me.tpReport.Location = New System.Drawing.Point(4, 22)
        Me.tpReport.Name = "tpReport"
        Me.tpReport.Padding = New System.Windows.Forms.Padding(3)
        Me.tpReport.Size = New System.Drawing.Size(632, 278)
        Me.tpReport.TabIndex = 3
        Me.tpReport.Text = "Reports"
        Me.tpReport.UseVisualStyleBackColor = True
        '
        'PlanetenReportViewer
        '
        Me.PlanetenReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "PlanetenDataSet"
        ReportDataSource1.Value = Me.PlanetenBindingSource
        Me.PlanetenReportViewer.LocalReport.DataSources.Add(ReportDataSource1)
        Me.PlanetenReportViewer.LocalReport.ReportEmbeddedResource = "VB.DB.WinFormClient.Planeten.rdlc"
        Me.PlanetenReportViewer.Location = New System.Drawing.Point(3, 3)
        Me.PlanetenReportViewer.Name = "PlanetenReportViewer"
        Me.PlanetenReportViewer.Size = New System.Drawing.Size(626, 272)
        Me.PlanetenReportViewer.TabIndex = 0
        '
        'PagingBindingSource
        '
        Me.PagingBindingSource.DataSource = GetType(VB.DB.EntityFramework.SternePlanetenMondeView)
        '
        'tpDiagramm
        '
        Me.tpDiagramm.Controls.Add(Me.TableLayoutPanel1)
        Me.tpDiagramm.Location = New System.Drawing.Point(4, 22)
        Me.tpDiagramm.Name = "tpDiagramm"
        Me.tpDiagramm.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDiagramm.Size = New System.Drawing.Size(632, 278)
        Me.tpDiagramm.TabIndex = 4
        Me.tpDiagramm.Text = "Diagramm"
        Me.tpDiagramm.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.PlanetenmassenSäulenChart, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PlanetenmassenKuchenChart, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Chart1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(626, 272)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'PlanetenmassenSäulenChart
        '
        ChartArea1.Area3DStyle.Enable3D = True
        ChartArea1.Name = "ChartArea1"
        Me.PlanetenmassenSäulenChart.ChartAreas.Add(ChartArea1)
        Me.PlanetenmassenSäulenChart.DataSource = Me.PlanetenBindingSource
        Me.PlanetenmassenSäulenChart.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.PlanetenmassenSäulenChart.Legends.Add(Legend1)
        Me.PlanetenmassenSäulenChart.Location = New System.Drawing.Point(3, 3)
        Me.PlanetenmassenSäulenChart.Name = "PlanetenmassenSäulenChart"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Planetenmassen"
        Series1.XValueMember = "Name"
        Series1.YValueMembers = "Masse"
        Me.PlanetenmassenSäulenChart.Series.Add(Series1)
        Me.PlanetenmassenSäulenChart.Size = New System.Drawing.Size(307, 130)
        Me.PlanetenmassenSäulenChart.TabIndex = 0
        Me.PlanetenmassenSäulenChart.Text = "Chart1"
        '
        'PlanetenmassenKuchenChart
        '
        ChartArea2.Area3DStyle.Enable3D = True
        ChartArea2.Name = "ChartArea1"
        Me.PlanetenmassenKuchenChart.ChartAreas.Add(ChartArea2)
        Me.PlanetenmassenKuchenChart.DataSource = Me.PlanetenBindingSource
        Me.PlanetenmassenKuchenChart.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.PlanetenmassenKuchenChart.Legends.Add(Legend2)
        Me.PlanetenmassenKuchenChart.Location = New System.Drawing.Point(316, 3)
        Me.PlanetenmassenKuchenChart.Name = "PlanetenmassenKuchenChart"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Series2.XValueMember = "Name"
        Series2.YValueMembers = "Masse"
        Me.PlanetenmassenKuchenChart.Series.Add(Series2)
        Me.PlanetenmassenKuchenChart.Size = New System.Drawing.Size(307, 130)
        Me.PlanetenmassenKuchenChart.TabIndex = 1
        Me.PlanetenmassenKuchenChart.Text = "Chart1"
        '
        'Chart1
        '
        ChartArea3.Area3DStyle.Enable3D = True
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Me.Chart1.DataSource = Me.PlanetenBindingSource
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(3, 139)
        Me.Chart1.Name = "Chart1"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend1"
        Series3.Name = "Series1"
        Series3.XValueMember = "Name"
        Series3.YValueMembers = "AbstandZentralkoerper"
        Me.Chart1.Series.Add(Series3)
        Me.Chart1.Size = New System.Drawing.Size(300, 130)
        Me.Chart1.TabIndex = 2
        Me.Chart1.Text = "Chart1"
        '
        'cbxPlanetsOnly
        '
        Me.cbxPlanetsOnly.AutoSize = True
        Me.cbxPlanetsOnly.Location = New System.Drawing.Point(58, 18)
        Me.cbxPlanetsOnly.Name = "cbxPlanetsOnly"
        Me.cbxPlanetsOnly.Size = New System.Drawing.Size(132, 17)
        Me.cbxPlanetsOnly.TabIndex = 0
        Me.cbxPlanetsOnly.Text = "nur Planeten anzeigen"
        Me.cbxPlanetsOnly.UseVisualStyleBackColor = True
        '
        'tpMonde
        '
        Me.tpMonde.Controls.Add(Me.MondeReportViewer)
        Me.tpMonde.Location = New System.Drawing.Point(4, 22)
        Me.tpMonde.Name = "tpMonde"
        Me.tpMonde.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMonde.Size = New System.Drawing.Size(632, 278)
        Me.tpMonde.TabIndex = 5
        Me.tpMonde.Text = "Report Monde"
        Me.tpMonde.UseVisualStyleBackColor = True
        '
        'MondeReportViewer
        '
        Me.MondeReportViewer.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource2.Name = "MondeDataSet"
        ReportDataSource2.Value = Me.MondeViewBindingSource
        Me.MondeReportViewer.LocalReport.DataSources.Add(ReportDataSource2)
        Me.MondeReportViewer.LocalReport.ReportEmbeddedResource = "VB.DB.WinFormClient.Monde.rdlc"
        Me.MondeReportViewer.Location = New System.Drawing.Point(3, 3)
        Me.MondeReportViewer.Name = "MondeReportViewer"
        Me.MondeReportViewer.Size = New System.Drawing.Size(626, 272)
        Me.MondeReportViewer.TabIndex = 0
        '
        'MondeViewBindingSource
        '
        Me.MondeViewBindingSource.DataSource = GetType(VB.DB.EntityFramework.SternePlanetenMondeView)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(640, 350)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.TabControlWinFormTemplate.ResumeLayout(False)
        Me.TabPageWTmpl_1.ResumeLayout(False)
        CType(Me.PlanetenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgrSPM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpPaging.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpReport.ResumeLayout(False)
        CType(Me.PagingBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpDiagramm.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.PlanetenmassenSäulenChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PlanetenmassenKuchenChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpMonde.ResumeLayout(False)
        CType(Me.MondeViewBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents SPMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents dgrSPM As System.Windows.Forms.DataGridView
    Friend WithEvents tpPaging As System.Windows.Forms.TabPage
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents CBTypeImageList As System.Windows.Forms.ImageList
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PagingBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TypDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Masse As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MasseEinheit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AbstandZentralkoerper As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents img As System.Windows.Forms.DataGridViewImageColumn
    Friend WithEvents tpReport As System.Windows.Forms.TabPage
    Friend WithEvents PlanetenReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents PlanetenBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tpDiagramm As System.Windows.Forms.TabPage
    Friend WithEvents PlanetenmassenSäulenChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents PlanetenmassenKuchenChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents cbxPlanetsOnly As System.Windows.Forms.CheckBox
    Friend WithEvents tpMonde As System.Windows.Forms.TabPage
    Friend WithEvents MondeReportViewer As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents MondeViewBindingSource As System.Windows.Forms.BindingSource

End Class
