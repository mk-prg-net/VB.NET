<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WTmplForm
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.TabControlWinFormTemplate = New System.Windows.Forms.TabControl()
        Me.TabPageWTmplLog = New System.Windows.Forms.TabPage()
        Me.TabPageWTmpl_1 = New System.Windows.Forms.TabPage()
        Me.PanWTmplLog = New System.Windows.Forms.Panel()
        Me.LbxWTmplLog = New System.Windows.Forms.ListBox()
        Me.btnWTmplLogClear = New System.Windows.Forms.Button()
        Me.btnWTmplLogTest = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControlWinFormTemplate.SuspendLayout()
        Me.TabPageWTmplLog.SuspendLayout()
        Me.PanWTmplLog.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(640, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BeendenToolStripMenuItem.Text = "beenden"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 328)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(640, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        '
        'TabControlWinFormTemplate
        '
        Me.TabControlWinFormTemplate.Controls.Add(Me.TabPageWTmplLog)
        Me.TabControlWinFormTemplate.Controls.Add(Me.TabPageWTmpl_1)
        Me.TabControlWinFormTemplate.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlWinFormTemplate.Location = New System.Drawing.Point(0, 24)
        Me.TabControlWinFormTemplate.Name = "TabControlWinFormTemplate"
        Me.TabControlWinFormTemplate.SelectedIndex = 0
        Me.TabControlWinFormTemplate.Size = New System.Drawing.Size(640, 304)
        Me.TabControlWinFormTemplate.TabIndex = 2
        '
        'TabPageWTmplLog
        '
        Me.TabPageWTmplLog.Controls.Add(Me.LbxWTmplLog)
        Me.TabPageWTmplLog.Controls.Add(Me.PanWTmplLog)
        Me.TabPageWTmplLog.Location = New System.Drawing.Point(4, 22)
        Me.TabPageWTmplLog.Name = "TabPageWTmplLog"
        Me.TabPageWTmplLog.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageWTmplLog.Size = New System.Drawing.Size(632, 278)
        Me.TabPageWTmplLog.TabIndex = 0
        Me.TabPageWTmplLog.Text = "Log"
        Me.TabPageWTmplLog.UseVisualStyleBackColor = True
        '
        'TabPageWTmpl_1
        '
        Me.TabPageWTmpl_1.Location = New System.Drawing.Point(4, 22)
        Me.TabPageWTmpl_1.Name = "TabPageWTmpl_1"
        Me.TabPageWTmpl_1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPageWTmpl_1.Size = New System.Drawing.Size(632, 278)
        Me.TabPageWTmpl_1.TabIndex = 1
        Me.TabPageWTmpl_1.Text = "1"
        Me.TabPageWTmpl_1.UseVisualStyleBackColor = True
        '
        'PanWTmplLog
        '
        Me.PanWTmplLog.Controls.Add(Me.btnWTmplLogTest)
        Me.PanWTmplLog.Controls.Add(Me.btnWTmplLogClear)
        Me.PanWTmplLog.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanWTmplLog.Location = New System.Drawing.Point(3, 3)
        Me.PanWTmplLog.Name = "PanWTmplLog"
        Me.PanWTmplLog.Size = New System.Drawing.Size(626, 51)
        Me.PanWTmplLog.TabIndex = 0
        '
        'LbxWTmplLog
        '
        Me.LbxWTmplLog.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LbxWTmplLog.FormattingEnabled = True
        Me.LbxWTmplLog.Location = New System.Drawing.Point(3, 54)
        Me.LbxWTmplLog.Name = "LbxWTmplLog"
        Me.LbxWTmplLog.Size = New System.Drawing.Size(626, 221)
        Me.LbxWTmplLog.TabIndex = 1
        '
        'btnWTmplLogClear
        '
        Me.btnWTmplLogClear.Location = New System.Drawing.Point(5, 3)
        Me.btnWTmplLogClear.Name = "btnWTmplLogClear"
        Me.btnWTmplLogClear.Size = New System.Drawing.Size(118, 23)
        Me.btnWTmplLogClear.TabIndex = 0
        Me.btnWTmplLogClear.Text = "Alle Logs löschen"
        Me.btnWTmplLogClear.UseVisualStyleBackColor = True
        '
        'btnWTmplLogTest
        '
        Me.btnWTmplLogTest.Location = New System.Drawing.Point(129, 3)
        Me.btnWTmplLogTest.Name = "btnWTmplLogTest"
        Me.btnWTmplLogTest.Size = New System.Drawing.Size(75, 23)
        Me.btnWTmplLogTest.TabIndex = 1
        Me.btnWTmplLogTest.Text = "Test"
        Me.btnWTmplLogTest.UseVisualStyleBackColor = True
        '
        'WTmplForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(640, 350)
        Me.Controls.Add(Me.TabControlWinFormTemplate)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "WTmplForm"
        Me.Text = "WinFormTemplate"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControlWinFormTemplate.ResumeLayout(False)
        Me.TabPageWTmplLog.ResumeLayout(False)
        Me.PanWTmplLog.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents TabPageWTmplLog As System.Windows.Forms.TabPage
    Friend WithEvents LbxWTmplLog As System.Windows.Forms.ListBox
    Friend WithEvents PanWTmplLog As System.Windows.Forms.Panel
    Friend WithEvents btnWTmplLogClear As System.Windows.Forms.Button
    Protected WithEvents TabControlWinFormTemplate As System.Windows.Forms.TabControl
    Protected WithEvents TabPageWTmpl_1 As System.Windows.Forms.TabPage
    Friend WithEvents btnWTmplLogTest As System.Windows.Forms.Button

End Class
