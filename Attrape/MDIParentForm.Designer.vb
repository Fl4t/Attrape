<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParentForm
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
        Me.components = New System.ComponentModel.Container()
        Me.AttrapeMenuStrip = New System.Windows.Forms.MenuStrip()
        Me.MenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouvellePartieToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TempToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.JeuTimer = New System.Windows.Forms.Timer(Me.components)
        Me.AttrapeMenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'AttrapeMenuStrip
        '
        Me.AttrapeMenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuToolStripMenuItem, Me.TempToolStripTextBox})
        Me.AttrapeMenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.AttrapeMenuStrip.Name = "AttrapeMenuStrip"
        Me.AttrapeMenuStrip.Size = New System.Drawing.Size(632, 24)
        Me.AttrapeMenuStrip.TabIndex = 2
        Me.AttrapeMenuStrip.Text = "AttrapeMenuStrip"
        '
        'MenuToolStripMenuItem
        '
        Me.MenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouvellePartieToolStripMenuItem, Me.ToolStripSeparator1, Me.QuitterToolStripMenuItem})
        Me.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem"
        Me.MenuToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.MenuToolStripMenuItem.Text = "Menu"
        '
        'NouvellePartieToolStripMenuItem
        '
        Me.NouvellePartieToolStripMenuItem.Name = "NouvellePartieToolStripMenuItem"
        Me.NouvellePartieToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NouvellePartieToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.NouvellePartieToolStripMenuItem.Text = "Nouvelle partie"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(194, 6)
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Q), System.Windows.Forms.Keys)
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(197, 22)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'TempToolStripTextBox
        '
        Me.TempToolStripTextBox.BackColor = System.Drawing.SystemColors.MenuBar
        Me.TempToolStripTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TempToolStripTextBox.Name = "TempToolStripTextBox"
        Me.TempToolStripTextBox.ReadOnly = True
        Me.TempToolStripTextBox.Size = New System.Drawing.Size(100, 20)
        '
        'JeuTimer
        '
        Me.JeuTimer.Interval = 1000
        '
        'MDIParentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(632, 453)
        Me.ControlBox = False
        Me.Controls.Add(Me.AttrapeMenuStrip)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.AttrapeMenuStrip
        Me.Name = "MDIParentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Attrape"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.AttrapeMenuStrip.ResumeLayout(False)
        Me.AttrapeMenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AttrapeMenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents MenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouvellePartieToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents JeuTimer As System.Windows.Forms.Timer
    Friend WithEvents TempToolStripTextBox As System.Windows.Forms.ToolStripTextBox

End Class
