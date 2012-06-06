<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class JeuForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MonoRadioButton = New System.Windows.Forms.RadioButton()
        Me.ModeDeJeuGroupBox = New System.Windows.Forms.GroupBox()
        Me.MultiRadioButton = New System.Windows.Forms.RadioButton()
        Me.VitesseGroupBox = New System.Windows.Forms.GroupBox()
        Me.FacileLabel = New System.Windows.Forms.Label()
        Me.NormalLabel = New System.Windows.Forms.Label()
        Me.DifficileLabel = New System.Windows.Forms.Label()
        Me.DementLabel = New System.Windows.Forms.Label()
        Me.VitesseTrackBar = New System.Windows.Forms.TrackBar()
        Me.PresentationLabel = New System.Windows.Forms.Label()
        Me.CommencerButton = New System.Windows.Forms.Button()
        Me.ModeDeJeuGroupBox.SuspendLayout()
        Me.VitesseGroupBox.SuspendLayout()
        CType(Me.VitesseTrackBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonoRadioButton
        '
        Me.MonoRadioButton.AutoSize = True
        Me.MonoRadioButton.Checked = True
        Me.MonoRadioButton.Location = New System.Drawing.Point(20, 28)
        Me.MonoRadioButton.Name = "MonoRadioButton"
        Me.MonoRadioButton.Size = New System.Drawing.Size(100, 17)
        Me.MonoRadioButton.TabIndex = 0
        Me.MonoRadioButton.TabStop = True
        Me.MonoRadioButton.Text = "Mono-formulaire"
        Me.MonoRadioButton.UseVisualStyleBackColor = True
        '
        'ModeDeJeuGroupBox
        '
        Me.ModeDeJeuGroupBox.Controls.Add(Me.MultiRadioButton)
        Me.ModeDeJeuGroupBox.Controls.Add(Me.MonoRadioButton)
        Me.ModeDeJeuGroupBox.Location = New System.Drawing.Point(13, 33)
        Me.ModeDeJeuGroupBox.Name = "ModeDeJeuGroupBox"
        Me.ModeDeJeuGroupBox.Size = New System.Drawing.Size(132, 100)
        Me.ModeDeJeuGroupBox.TabIndex = 3
        Me.ModeDeJeuGroupBox.TabStop = False
        Me.ModeDeJeuGroupBox.Text = "Mode de jeu :"
        '
        'MultiRadioButton
        '
        Me.MultiRadioButton.AutoSize = True
        Me.MultiRadioButton.Location = New System.Drawing.Point(20, 64)
        Me.MultiRadioButton.Name = "MultiRadioButton"
        Me.MultiRadioButton.Size = New System.Drawing.Size(95, 17)
        Me.MultiRadioButton.TabIndex = 1
        Me.MultiRadioButton.TabStop = True
        Me.MultiRadioButton.Text = "Multi-formulaire"
        Me.MultiRadioButton.UseVisualStyleBackColor = True
        '
        'VitesseGroupBox
        '
        Me.VitesseGroupBox.Controls.Add(Me.FacileLabel)
        Me.VitesseGroupBox.Controls.Add(Me.NormalLabel)
        Me.VitesseGroupBox.Controls.Add(Me.DifficileLabel)
        Me.VitesseGroupBox.Controls.Add(Me.DementLabel)
        Me.VitesseGroupBox.Controls.Add(Me.VitesseTrackBar)
        Me.VitesseGroupBox.Location = New System.Drawing.Point(151, 33)
        Me.VitesseGroupBox.Name = "VitesseGroupBox"
        Me.VitesseGroupBox.Size = New System.Drawing.Size(132, 100)
        Me.VitesseGroupBox.TabIndex = 4
        Me.VitesseGroupBox.TabStop = False
        Me.VitesseGroupBox.Text = "Vitesse :"
        '
        'FacileLabel
        '
        Me.FacileLabel.AutoSize = True
        Me.FacileLabel.Location = New System.Drawing.Point(63, 73)
        Me.FacileLabel.Name = "FacileLabel"
        Me.FacileLabel.Size = New System.Drawing.Size(35, 13)
        Me.FacileLabel.TabIndex = 8
        Me.FacileLabel.Text = "Facile"
        '
        'NormalLabel
        '
        Me.NormalLabel.AutoSize = True
        Me.NormalLabel.Location = New System.Drawing.Point(63, 57)
        Me.NormalLabel.Name = "NormalLabel"
        Me.NormalLabel.Size = New System.Drawing.Size(40, 13)
        Me.NormalLabel.TabIndex = 7
        Me.NormalLabel.Text = "Normal"
        '
        'DifficileLabel
        '
        Me.DifficileLabel.AutoSize = True
        Me.DifficileLabel.Location = New System.Drawing.Point(63, 40)
        Me.DifficileLabel.Name = "DifficileLabel"
        Me.DifficileLabel.Size = New System.Drawing.Size(41, 13)
        Me.DifficileLabel.TabIndex = 6
        Me.DifficileLabel.Text = "Difficile"
        '
        'DementLabel
        '
        Me.DementLabel.AutoSize = True
        Me.DementLabel.Location = New System.Drawing.Point(63, 23)
        Me.DementLabel.Name = "DementLabel"
        Me.DementLabel.Size = New System.Drawing.Size(44, 13)
        Me.DementLabel.TabIndex = 5
        Me.DementLabel.Text = "Dément"
        '
        'VitesseTrackBar
        '
        Me.VitesseTrackBar.Location = New System.Drawing.Point(22, 18)
        Me.VitesseTrackBar.Maximum = 4
        Me.VitesseTrackBar.Minimum = 1
        Me.VitesseTrackBar.Name = "VitesseTrackBar"
        Me.VitesseTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.VitesseTrackBar.Size = New System.Drawing.Size(42, 76)
        Me.VitesseTrackBar.TabIndex = 4
        Me.VitesseTrackBar.Value = 2
        '
        'PresentationLabel
        '
        Me.PresentationLabel.AutoSize = True
        Me.PresentationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PresentationLabel.Location = New System.Drawing.Point(10, 9)
        Me.PresentationLabel.Name = "PresentationLabel"
        Me.PresentationLabel.Size = New System.Drawing.Size(273, 15)
        Me.PresentationLabel.TabIndex = 5
        Me.PresentationLabel.Text = "Choisissez votre mode de jeu ainsi que la vitesse"
        '
        'CommencerButton
        '
        Me.CommencerButton.Location = New System.Drawing.Point(208, 139)
        Me.CommencerButton.Name = "CommencerButton"
        Me.CommencerButton.Size = New System.Drawing.Size(75, 23)
        Me.CommencerButton.TabIndex = 6
        Me.CommencerButton.Text = "Commencer"
        Me.CommencerButton.UseVisualStyleBackColor = True
        '
        'JeuForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(294, 171)
        Me.ControlBox = False
        Me.Controls.Add(Me.CommencerButton)
        Me.Controls.Add(Me.PresentationLabel)
        Me.Controls.Add(Me.VitesseGroupBox)
        Me.Controls.Add(Me.ModeDeJeuGroupBox)
        Me.Name = "JeuForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Attrape"
        Me.TopMost = True
        Me.ModeDeJeuGroupBox.ResumeLayout(False)
        Me.ModeDeJeuGroupBox.PerformLayout()
        Me.VitesseGroupBox.ResumeLayout(False)
        Me.VitesseGroupBox.PerformLayout()
        CType(Me.VitesseTrackBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MonoRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents ModeDeJeuGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents VitesseGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents MultiRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents VitesseTrackBar As System.Windows.Forms.TrackBar
    Friend WithEvents FacileLabel As System.Windows.Forms.Label
    Friend WithEvents NormalLabel As System.Windows.Forms.Label
    Friend WithEvents DifficileLabel As System.Windows.Forms.Label
    Friend WithEvents DementLabel As System.Windows.Forms.Label
    Friend WithEvents PresentationLabel As System.Windows.Forms.Label
    Friend WithEvents CommencerButton As System.Windows.Forms.Button
End Class
