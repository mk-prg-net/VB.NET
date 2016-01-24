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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.tbxA = New System.Windows.Forms.TextBox()
        Me.lblA = New System.Windows.Forms.Label()
        Me.tbxB = New System.Windows.Forms.TextBox()
        Me.lblB = New System.Windows.Forms.Label()
        Me.cmbxOpSelection = New System.Windows.Forms.ComboBox()
        Me.OpSelectionListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnExe = New System.Windows.Forms.Button()
        Me.tbxResult = New System.Windows.Forms.TextBox()
        Me.gridProtocol = New System.Windows.Forms.DataGridView()
        Me.OpDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OpBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ResDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProtocolBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.OpSelectionListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridProtocol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProtocolBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(736, 24)
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
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.BeendenToolStripMenuItem.Text = "&beenden"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 240)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(736, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gridProtocol)
        Me.SplitContainer1.Size = New System.Drawing.Size(736, 216)
        Me.SplitContainer1.SplitterDistance = 273
        Me.SplitContainer1.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.90909!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.09091!))
        Me.TableLayoutPanel1.Controls.Add(Me.tbxA, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblA, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.tbxB, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblB, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.cmbxOpSelection, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btnExe, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.tbxResult, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(273, 216)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'tbxA
        '
        Me.tbxA.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbxA.Location = New System.Drawing.Point(3, 3)
        Me.tbxA.Name = "tbxA"
        Me.tbxA.Size = New System.Drawing.Size(187, 20)
        Me.tbxA.TabIndex = 0
        Me.tbxA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(196, 0)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(29, 13)
        Me.lblA.TabIndex = 1
        Me.lblA.Text = "<= A"
        '
        'tbxB
        '
        Me.tbxB.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbxB.Location = New System.Drawing.Point(3, 32)
        Me.tbxB.Name = "tbxB"
        Me.tbxB.Size = New System.Drawing.Size(187, 20)
        Me.tbxB.TabIndex = 2
        Me.tbxB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Location = New System.Drawing.Point(196, 29)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(29, 13)
        Me.lblB.TabIndex = 3
        Me.lblB.Text = "<= B"
        '
        'cmbxOpSelection
        '
        Me.cmbxOpSelection.DataSource = Me.OpSelectionListBindingSource
        Me.cmbxOpSelection.DisplayMember = "OpTxt"
        Me.cmbxOpSelection.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cmbxOpSelection.FormattingEnabled = True
        Me.cmbxOpSelection.Location = New System.Drawing.Point(3, 61)
        Me.cmbxOpSelection.Name = "cmbxOpSelection"
        Me.cmbxOpSelection.Size = New System.Drawing.Size(187, 21)
        Me.cmbxOpSelection.TabIndex = 4
        Me.cmbxOpSelection.ValueMember = "Op"
        '
        'OpSelectionListBindingSource
        '
        Me.OpSelectionListBindingSource.DataSource = GetType(VB.WinForm.Intro.Calculator.OpSelection)
        '
        'btnExe
        '
        Me.btnExe.Location = New System.Drawing.Point(196, 61)
        Me.btnExe.Name = "btnExe"
        Me.btnExe.Size = New System.Drawing.Size(74, 23)
        Me.btnExe.TabIndex = 5
        Me.btnExe.Text = "Exe"
        Me.btnExe.UseVisualStyleBackColor = True
        '
        'tbxResult
        '
        Me.tbxResult.BackColor = System.Drawing.Color.Gainsboro
        Me.tbxResult.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tbxResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbxResult.ForeColor = System.Drawing.Color.Green
        Me.tbxResult.Location = New System.Drawing.Point(3, 90)
        Me.tbxResult.Name = "tbxResult"
        Me.tbxResult.Size = New System.Drawing.Size(187, 20)
        Me.tbxResult.TabIndex = 6
        Me.tbxResult.Text = "0"
        Me.tbxResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'gridProtocol
        '
        Me.gridProtocol.AutoGenerateColumns = False
        Me.gridProtocol.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.gridProtocol.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.OpDataGridViewTextBoxColumn, Me.OpADataGridViewTextBoxColumn, Me.OpBDataGridViewTextBoxColumn, Me.ResDataGridViewTextBoxColumn})
        Me.gridProtocol.DataSource = Me.ProtocolBindingSource
        Me.gridProtocol.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gridProtocol.Location = New System.Drawing.Point(0, 0)
        Me.gridProtocol.Name = "gridProtocol"
        Me.gridProtocol.Size = New System.Drawing.Size(459, 216)
        Me.gridProtocol.TabIndex = 0
        '
        'OpDataGridViewTextBoxColumn
        '
        Me.OpDataGridViewTextBoxColumn.DataPropertyName = "Op"
        Me.OpDataGridViewTextBoxColumn.HeaderText = "Op"
        Me.OpDataGridViewTextBoxColumn.Name = "OpDataGridViewTextBoxColumn"
        '
        'OpADataGridViewTextBoxColumn
        '
        Me.OpADataGridViewTextBoxColumn.DataPropertyName = "OpA"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.OpADataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.OpADataGridViewTextBoxColumn.HeaderText = "OpA"
        Me.OpADataGridViewTextBoxColumn.Name = "OpADataGridViewTextBoxColumn"
        '
        'OpBDataGridViewTextBoxColumn
        '
        Me.OpBDataGridViewTextBoxColumn.DataPropertyName = "OpB"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.OpBDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.OpBDataGridViewTextBoxColumn.HeaderText = "OpB"
        Me.OpBDataGridViewTextBoxColumn.Name = "OpBDataGridViewTextBoxColumn"
        '
        'ResDataGridViewTextBoxColumn
        '
        Me.ResDataGridViewTextBoxColumn.DataPropertyName = "Res"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ResDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.ResDataGridViewTextBoxColumn.HeaderText = "Res"
        Me.ResDataGridViewTextBoxColumn.Name = "ResDataGridViewTextBoxColumn"
        '
        'ProtocolBindingSource
        '
        Me.ProtocolBindingSource.DataSource = GetType(VB.WinForm.Intro.Calculator.ProtocolEntry)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 262)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "WinForm.Intro.Calculator"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.OpSelectionListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridProtocol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProtocolBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents tbxA As System.Windows.Forms.TextBox
    Friend WithEvents lblA As System.Windows.Forms.Label
    Friend WithEvents tbxB As System.Windows.Forms.TextBox
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents cmbxOpSelection As System.Windows.Forms.ComboBox
    Friend WithEvents OpSelectionListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnExe As System.Windows.Forms.Button
    Friend WithEvents tbxResult As System.Windows.Forms.TextBox
    Friend WithEvents gridProtocol As System.Windows.Forms.DataGridView
    Friend WithEvents ProtocolBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents OpDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OpADataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OpBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ResDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
