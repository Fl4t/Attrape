<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AttrapeForm
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
        Me.AttrapeButton = New System.Windows.Forms.Button()
        Me.AttrapeLabel = New System.Windows.Forms.Label()
        Me.AttrapeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'AttrapeButton
        '
        Me.AttrapeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AttrapeButton.Location = New System.Drawing.Point(36, 91)
        Me.AttrapeButton.Name = "AttrapeButton"
        Me.AttrapeButton.Size = New System.Drawing.Size(75, 23)
        Me.AttrapeButton.TabIndex = 0
        Me.AttrapeButton.Text = "ICI"
        Me.AttrapeButton.UseVisualStyleBackColor = True
        '
        'AttrapeLabel
        '
        Me.AttrapeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AttrapeLabel.Cursor = System.Windows.Forms.Cursors.Cross
        Me.AttrapeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AttrapeLabel.Location = New System.Drawing.Point(14, 33)
        Me.AttrapeLabel.Name = "AttrapeLabel"
        Me.AttrapeLabel.Size = New System.Drawing.Size(118, 23)
        Me.AttrapeLabel.TabIndex = 1
        Me.AttrapeLabel.Text = "ATTRAPE-MOI !!!"
        Me.AttrapeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AttrapeTimer
        '
        Me.AttrapeTimer.Enabled = True
        Me.AttrapeTimer.Interval = 800
        '
        'AttrapeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(146, 146)
        Me.ControlBox = False
        Me.Controls.Add(Me.AttrapeLabel)
        Me.Controls.Add(Me.AttrapeButton)
        Me.Cursor = System.Windows.Forms.Cursors.Cross
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "AttrapeForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attrape"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AttrapeButton As System.Windows.Forms.Button
    Friend WithEvents AttrapeLabel As System.Windows.Forms.Label
    Friend WithEvents AttrapeTimer As System.Windows.Forms.Timer

End Class
