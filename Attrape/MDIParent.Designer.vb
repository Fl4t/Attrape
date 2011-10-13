<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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


    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AttrapeMenuStrip = New System.Windows.Forms.MenuStrip
        Me.FichierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NouveauFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ModeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FacileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DifficileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VitesseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ComboVitesse = New System.Windows.Forms.ToolStripComboBox
        Me.AttrapeMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'AttrapeMenuStrip
        '
        Me.AttrapeMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FichierToolStripMenuItem, Me.VitesseToolStripMenuItem})
        Me.AttrapeMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.AttrapeMenuStrip.Name = "AttrapeMenuStrip"
        Me.AttrapeMenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.AttrapeMenuStrip.TabIndex = 2
        Me.AttrapeMenuStrip.Text = "AttrapeMenuStrip"
        '
        'FichierToolStripMenuItem
        '
        Me.FichierToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouveauFormToolStripMenuItem, Me.ModeToolStripMenuItem, Me.ToolStripSeparator1, Me.QuitterToolStripMenuItem})
        Me.FichierToolStripMenuItem.Name = "FichierToolStripMenuItem"
        Me.FichierToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.FichierToolStripMenuItem.Text = "Menu"
        '
        'NouveauFormToolStripMenuItem
        '
        Me.NouveauFormToolStripMenuItem.Name = "NouveauFormToolStripMenuItem"
        Me.NouveauFormToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NouveauFormToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.NouveauFormToolStripMenuItem.Text = "Nouveau formulaire"
        '
        'ModeToolStripMenuItem
        '
        Me.ModeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FacileToolStripMenuItem, Me.DifficileToolStripMenuItem})
        Me.ModeToolStripMenuItem.Name = "ModeToolStripMenuItem"
        Me.ModeToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.ModeToolStripMenuItem.Text = "Mode"
        '
        'FacileToolStripMenuItem
        '
        Me.FacileToolStripMenuItem.Checked = True
        Me.FacileToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked
        Me.FacileToolStripMenuItem.Name = "FacileToolStripMenuItem"
        Me.FacileToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.FacileToolStripMenuItem.Text = "Facile"
        '
        'DifficileToolStripMenuItem
        '
        Me.DifficileToolStripMenuItem.Name = "DifficileToolStripMenuItem"
        Me.DifficileToolStripMenuItem.Size = New System.Drawing.Size(114, 22)
        Me.DifficileToolStripMenuItem.Text = "Difficile"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(220, 6)
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(223, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'VitesseToolStripMenuItem
        '
        Me.VitesseToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComboVitesse})
        Me.VitesseToolStripMenuItem.Name = "VitesseToolStripMenuItem"
        Me.VitesseToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.VitesseToolStripMenuItem.Text = "Vitesse"
        '
        'ComboVitesse
        '
        Me.ComboVitesse.AutoSize = False
        Me.ComboVitesse.Items.AddRange(New Object() {"Lent", "Normal", "Rapide", "Dément"})
        Me.ComboVitesse.Name = "ComboVitesse"
        Me.ComboVitesse.Size = New System.Drawing.Size(75, 23)
        '
        'MDIParent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.ControlBox = False
        Me.Controls.Add(Me.AttrapeMenuStrip)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.AttrapeMenuStrip
        Me.Name = "MDIParent"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Attrape"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.AttrapeMenuStrip.ResumeLayout(False)
        Me.AttrapeMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AttrapeMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents FichierToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FacileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DifficileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouveauFormToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VitesseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComboVitesse As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator

End Class
