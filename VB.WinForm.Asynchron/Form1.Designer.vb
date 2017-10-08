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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStartAsyncAwait = New System.Windows.Forms.Button()
        Me.tbxDisplay = New System.Windows.Forms.TextBox()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MeinProgressBar = New System.Windows.Forms.ToolStripProgressBar()
        Me.btnStartAsyncMitDelegate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(28, 13)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(154, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start synchron"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStartAsyncAwait
        '
        Me.btnStartAsyncAwait.Location = New System.Drawing.Point(28, 71)
        Me.btnStartAsyncAwait.Name = "btnStartAsyncAwait"
        Me.btnStartAsyncAwait.Size = New System.Drawing.Size(154, 23)
        Me.btnStartAsyncAwait.TabIndex = 1
        Me.btnStartAsyncAwait.Text = "Start mit Async Await"
        Me.btnStartAsyncAwait.UseVisualStyleBackColor = True
        '
        'tbxDisplay
        '
        Me.tbxDisplay.Location = New System.Drawing.Point(28, 111)
        Me.tbxDisplay.Name = "tbxDisplay"
        Me.tbxDisplay.Size = New System.Drawing.Size(420, 20)
        Me.tbxDisplay.TabIndex = 2
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.MeinProgressBar})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 145)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(472, 22)
        Me.StatusStrip1.TabIndex = 3
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'MeinProgressBar
        '
        Me.MeinProgressBar.Name = "MeinProgressBar"
        Me.MeinProgressBar.Size = New System.Drawing.Size(100, 16)
        Me.MeinProgressBar.Step = 1
        '
        'btnStartAsyncMitDelegate
        '
        Me.btnStartAsyncMitDelegate.Location = New System.Drawing.Point(28, 42)
        Me.btnStartAsyncMitDelegate.Name = "btnStartAsyncMitDelegate"
        Me.btnStartAsyncMitDelegate.Size = New System.Drawing.Size(154, 23)
        Me.btnStartAsyncMitDelegate.TabIndex = 4
        Me.btnStartAsyncMitDelegate.Text = "Start async mit Delegate"
        Me.btnStartAsyncMitDelegate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(188, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Aktualisierung dank Application.DoEvent(). ""hakelig"""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(188, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(182, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "flüssig bedienbar dank Multithreading"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(188, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(234, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "vereinfachte Implementierung des Multithradings"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 167)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnStartAsyncMitDelegate)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tbxDisplay)
        Me.Controls.Add(Me.btnStartAsyncAwait)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents btnStartAsyncAwait As System.Windows.Forms.Button
    Friend WithEvents tbxDisplay As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents MeinProgressBar As System.Windows.Forms.ToolStripProgressBar
    Friend WithEvents btnStartAsyncMitDelegate As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
