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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnErzeugeFehler = New System.Windows.Forms.Button()
        Me.btnAddMessageBoxFehlerMeldung = New System.Windows.Forms.Button()
        Me.btnRemoveMEssageBoxFEhlerMeldung = New System.Windows.Forms.Button()
        Me.TabControlWinFormTemplate.SuspendLayout()
        Me.TabPageWTmpl_1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabPageWTmpl_1
        '
        Me.TabPageWTmpl_1.Controls.Add(Me.Panel1)
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gray
        Me.Panel1.Controls.Add(Me.btnRemoveMEssageBoxFEhlerMeldung)
        Me.Panel1.Controls.Add(Me.btnAddMessageBoxFehlerMeldung)
        Me.Panel1.Controls.Add(Me.btnErzeugeFehler)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(626, 70)
        Me.Panel1.TabIndex = 0
        '
        'btnErzeugeFehler
        '
        Me.btnErzeugeFehler.Location = New System.Drawing.Point(19, 23)
        Me.btnErzeugeFehler.Name = "btnErzeugeFehler"
        Me.btnErzeugeFehler.Size = New System.Drawing.Size(154, 23)
        Me.btnErzeugeFehler.TabIndex = 0
        Me.btnErzeugeFehler.Text = "Feherl erzeugen"
        Me.btnErzeugeFehler.UseVisualStyleBackColor = True
        '
        'btnAddMessageBoxFehlerMeldung
        '
        Me.btnAddMessageBoxFehlerMeldung.Location = New System.Drawing.Point(210, 22)
        Me.btnAddMessageBoxFehlerMeldung.Name = "btnAddMessageBoxFehlerMeldung"
        Me.btnAddMessageBoxFehlerMeldung.Size = New System.Drawing.Size(192, 23)
        Me.btnAddMessageBoxFehlerMeldung.TabIndex = 1
        Me.btnAddMessageBoxFehlerMeldung.Text = "Add MessageBox Fehlermeldung"
        Me.btnAddMessageBoxFehlerMeldung.UseVisualStyleBackColor = True
        '
        'btnRemoveMEssageBoxFEhlerMeldung
        '
        Me.btnRemoveMEssageBoxFEhlerMeldung.Location = New System.Drawing.Point(420, 22)
        Me.btnRemoveMEssageBoxFEhlerMeldung.Name = "btnRemoveMEssageBoxFEhlerMeldung"
        Me.btnRemoveMEssageBoxFEhlerMeldung.Size = New System.Drawing.Size(201, 23)
        Me.btnRemoveMEssageBoxFEhlerMeldung.TabIndex = 2
        Me.btnRemoveMEssageBoxFEhlerMeldung.Text = "Remove MessageBox Fehlermeldung"
        Me.btnRemoveMEssageBoxFEhlerMeldung.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(640, 350)
        Me.Name = "Form1"
        Me.TabControlWinFormTemplate.ResumeLayout(False)
        Me.TabPageWTmpl_1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnErzeugeFehler As System.Windows.Forms.Button
    Friend WithEvents btnRemoveMEssageBoxFEhlerMeldung As System.Windows.Forms.Button
    Friend WithEvents btnAddMessageBoxFehlerMeldung As System.Windows.Forms.Button

End Class
