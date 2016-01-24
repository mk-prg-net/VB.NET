<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbxVon = New System.Windows.Forms.TextBox()
        Me.tbxBis = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnStartScan = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCountPrim = New System.Windows.Forms.Label()
        Me.btnStartScanAsynchron = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.btnStatusAbrufen = New System.Windows.Forms.Button()
        Me.btnStartScanAsynchron2Threads = New System.Windows.Forms.Button()
        Me.dgrPrim1 = New System.Windows.Forms.DataGridView()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZahlDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.dgrPrim1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "von"
        '
        'tbxVon
        '
        Me.tbxVon.Location = New System.Drawing.Point(22, 51)
        Me.tbxVon.Name = "tbxVon"
        Me.tbxVon.Size = New System.Drawing.Size(100, 20)
        Me.tbxVon.TabIndex = 1
        '
        'tbxBis
        '
        Me.tbxBis.Location = New System.Drawing.Point(144, 51)
        Me.tbxBis.Name = "tbxBis"
        Me.tbxBis.Size = New System.Drawing.Size(100, 20)
        Me.tbxBis.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(141, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(20, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "bis"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(596, 24)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'BeeendenToolStripMenuItem
        '
        Me.BeeendenToolStripMenuItem.Name = "BeeendenToolStripMenuItem"
        Me.BeeendenToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.BeeendenToolStripMenuItem.Text = "beeenden"
        '
        'btnStartScan
        '
        Me.btnStartScan.Location = New System.Drawing.Point(269, 48)
        Me.btnStartScan.Name = "btnStartScan"
        Me.btnStartScan.Size = New System.Drawing.Size(139, 23)
        Me.btnStartScan.TabIndex = 5
        Me.btnStartScan.Text = "Primzahlsuche starten"
        Me.btnStartScan.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Anzahl gefundener Primzahlen:"
        '
        'lblCountPrim
        '
        Me.lblCountPrim.AutoSize = True
        Me.lblCountPrim.Location = New System.Drawing.Point(181, 91)
        Me.lblCountPrim.Name = "lblCountPrim"
        Me.lblCountPrim.Size = New System.Drawing.Size(13, 13)
        Me.lblCountPrim.TabIndex = 7
        Me.lblCountPrim.Text = "0"
        '
        'btnStartScanAsynchron
        '
        Me.btnStartScanAsynchron.Location = New System.Drawing.Point(269, 78)
        Me.btnStartScanAsynchron.Name = "btnStartScanAsynchron"
        Me.btnStartScanAsynchron.Size = New System.Drawing.Size(139, 23)
        Me.btnStartScanAsynchron.TabIndex = 8
        Me.btnStartScanAsynchron.Text = "Primzahlsuche asynchron"
        Me.btnStartScanAsynchron.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 516)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(596, 22)
        Me.StatusStrip1.TabIndex = 9
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(22, 17)
        Me.ToolStripStatusLabel1.Text = "---"
        '
        'btnStatusAbrufen
        '
        Me.btnStatusAbrufen.Location = New System.Drawing.Point(454, 77)
        Me.btnStatusAbrufen.Name = "btnStatusAbrufen"
        Me.btnStatusAbrufen.Size = New System.Drawing.Size(117, 23)
        Me.btnStatusAbrufen.TabIndex = 10
        Me.btnStatusAbrufen.Text = "Status abrufen"
        Me.btnStatusAbrufen.UseVisualStyleBackColor = True
        '
        'btnStartScanAsynchron2Threads
        '
        Me.btnStartScanAsynchron2Threads.Location = New System.Drawing.Point(269, 117)
        Me.btnStartScanAsynchron2Threads.Name = "btnStartScanAsynchron2Threads"
        Me.btnStartScanAsynchron2Threads.Size = New System.Drawing.Size(183, 23)
        Me.btnStartScanAsynchron2Threads.TabIndex = 11
        Me.btnStartScanAsynchron2Threads.Text = "Primzahlsuche asynchron 2 Thread"
        Me.btnStartScanAsynchron2Threads.UseVisualStyleBackColor = True
        '
        'dgrPrim1
        '
        Me.dgrPrim1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgrPrim1.AutoGenerateColumns = False
        Me.dgrPrim1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgrPrim1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NrDataGridViewTextBoxColumn, Me.ZahlDataGridViewTextBoxColumn})
        Me.dgrPrim1.DataSource = Me.BindingSource1
        Me.dgrPrim1.Location = New System.Drawing.Point(12, 169)
        Me.dgrPrim1.Name = "dgrPrim1"
        Me.dgrPrim1.Size = New System.Drawing.Size(248, 332)
        Me.dgrPrim1.TabIndex = 12
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = GetType(AMF.WinFom_mit_Methodenstart_im_Hintergrund.PrimZahl)
        '
        'NrDataGridViewTextBoxColumn
        '
        Me.NrDataGridViewTextBoxColumn.DataPropertyName = "Nr"
        Me.NrDataGridViewTextBoxColumn.HeaderText = "Nr"
        Me.NrDataGridViewTextBoxColumn.Name = "NrDataGridViewTextBoxColumn"
        '
        'ZahlDataGridViewTextBoxColumn
        '
        Me.ZahlDataGridViewTextBoxColumn.DataPropertyName = "Zahl"
        Me.ZahlDataGridViewTextBoxColumn.HeaderText = "Zahl"
        Me.ZahlDataGridViewTextBoxColumn.Name = "ZahlDataGridViewTextBoxColumn"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 538)
        Me.Controls.Add(Me.dgrPrim1)
        Me.Controls.Add(Me.btnStartScanAsynchron2Threads)
        Me.Controls.Add(Me.btnStatusAbrufen)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnStartScanAsynchron)
        Me.Controls.Add(Me.lblCountPrim)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnStartScan)
        Me.Controls.Add(Me.tbxBis)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbxVon)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.dgrPrim1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbxVon As System.Windows.Forms.TextBox
    Friend WithEvents tbxBis As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnStartScan As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCountPrim As System.Windows.Forms.Label
    Friend WithEvents btnStartScanAsynchron As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnStatusAbrufen As System.Windows.Forms.Button
    Friend WithEvents btnStartScanAsynchron2Threads As System.Windows.Forms.Button
    Friend WithEvents dgrPrim1 As System.Windows.Forms.DataGridView
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents NrDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ZahlDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
