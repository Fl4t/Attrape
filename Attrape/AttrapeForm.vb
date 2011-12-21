Public Class AttrapeForm

    ' On crée un objet qui servira pour plusieurs choses
    Private mobjAleatoire As New Random

    Private Sub AttrapeForm_Click(ByVal sender As Object,
                                  ByVal e As System.EventArgs) _
                                  Handles Me.Click
        'On agrandi le formulaire vu que visiblement, l'utilisateur peine :)
        If Me.Width < 400 And Me.Height < 400 Then
            Me.Width += 10
            Me.Height += 10
            AttrapeButton.Width += 1
            AttrapeButton.Height += 1
            AttrapeLabel.Width += 1
            AttrapeLabel.Height += 1
            AttrapeLabel.Text = "AHAH !!!"
        End If

        If JeuForm.MultiRadioButton.Checked Then
            MDIParentForm.nouveauFormulaire()
        End If
    End Sub

    Private Sub AttrapeForm_Load(ByVal sender As System.Object,
                                 ByVal e As System.EventArgs) _
                                 Handles MyBase.Load
        ' On déclare MDIParentForm comme parent
        MDIParentForm = MdiParent

        ' on lance le timer avec l'intervale choisi
        If JeuForm.VitesseTrackBar.Value = 1 Then
            AttrapeTimer.Interval = 900
        ElseIf JeuForm.VitesseTrackBar.Value = 2 Then
            AttrapeTimer.Interval = 700
        ElseIf JeuForm.VitesseTrackBar.Value = 3 Then
            AttrapeTimer.Interval = 600
        Else
            AttrapeTimer.Interval = 500
        End If
        AttrapeTimer.Start()

        'couleur du formulaire
        Dim intCouleurRouge, intCouleurVert, intCouleurBleu As Integer
        intCouleurRouge = mobjAleatoire.Next(1, 256)
        intCouleurVert = mobjAleatoire.Next(1, 256)
        intCouleurBleu = mobjAleatoire.Next(1, 256)
        Me.BackColor = Color.FromArgb(intCouleurRouge, intCouleurVert, intCouleurBleu)

        ' On modifie le label à l'aide de l'instruction width
        With AttrapeLabel
            .Text = "ATTRAPE-MOI !!!"
            .Font = New Font("Comic Sans Ms", 8, FontStyle.Bold)
            .Location = New Point(22, 30)
        End With

        ' De même pour le boutton
        With AttrapeButton
            .Font = New Font("Comic Sans Ms", 8, FontStyle.Bold)
            .Location = New Point(44, 88)
            .FlatStyle = FlatStyle.Flat
        End With
    End Sub

    Private Sub AttrapeTimer_Tick(ByVal sender As System.Object, _
                                  ByVal e As System.EventArgs) _
                                  Handles AttrapeTimer.Tick
        'déplacement du formulaire 
        '(- la largeur et - la hauteur du formulaire car sinon il dépasse de l'écran - marge du MDI)
        Dim intHauteurEcran As Integer = MDIParentForm.Height - Me.Height - 40
        Dim intLargeurEcran As Integer = MDIParentForm.Width - Me.Width - 10
        Dim intPositionX, intPositionY As Integer
        intPositionX = mobjAleatoire.Next(0, intLargeurEcran)
        intPositionY = mobjAleatoire.Next(0, intHauteurEcran)
        Me.Location = New Point(intPositionX, intPositionY)
    End Sub

    Private Sub AttrapeForm_LocationChanged(ByVal sender As Object,
                                            ByVal e As System.EventArgs) _
                                            Handles Me.LocationChanged
        ' Re-initialise le label à chaque changement de position
        With AttrapeLabel
            .Text = "ATTRAPE-MOI !!!"
            .Font = New Font("Comic Sans Ms", 8, FontStyle.Bold)
        End With

        ' Re-initialise aussi le boutton
        With AttrapeButton
            .Font = New Font("Comic Sans Ms", 8, FontStyle.Bold)
            .FlatStyle = FlatStyle.Standard
        End With
    End Sub

    Private Sub AttrapeForm_SizeChanged(ByVal sender As Object,
                                        ByVal e As System.EventArgs) _
                                        Handles Me.SizeChanged
        'Repositionne correctement le label 
        Dim intPositionLabelX As Integer = CInt((Me.Width - AttrapeLabel.Width) / 2)
        Dim intPositionLabelY As Integer = CInt((Me.Height - (AttrapeLabel.Height + AttrapeButton.Height)) / 3)
        AttrapeLabel.Location = New Point(intPositionLabelX, intPositionLabelY)

        'Repositionne correctement le boutton au centre du formulaire
        Dim intPositionBouttonX As Integer = CInt((Me.Width - AttrapeButton.Width) / 2)
        Dim intPositionBouttonY As Integer = CInt(intPositionLabelY + AttrapeLabel.Height + intPositionLabelY)
        AttrapeButton.Location = New Point(intPositionBouttonX, intPositionBouttonY)
    End Sub

    Private Sub AttrapeForm_MouseHover(ByVal sender As Object,
                                       ByVal e As System.EventArgs) _
                                       Handles Me.MouseHover
        ' On génère les couleurs RVB
        Dim intCouleurRouge, intCouleurVert, intCouleurBleu As Integer
        intCouleurRouge = mobjAleatoire.Next(1, 256)
        intCouleurVert = mobjAleatoire.Next(1, 256)
        intCouleurBleu = mobjAleatoire.Next(1, 256)

        With AttrapeLabel
            'couleur de l'arrière plan du label
            .BackColor = Color.FromArgb(intCouleurRouge, intCouleurVert, intCouleurBleu)
            ' Pour avoir la police avec la couleur négatif à l'arrière plan du label
            .ForeColor = Color.FromArgb(255 - intCouleurRouge, 255 - intCouleurVert, 255 - intCouleurBleu)
        End With

        With AttrapeButton
            'couleur de l'arrière plan du boutton
            .BackColor = Color.FromArgb(intCouleurRouge, intCouleurVert, intCouleurBleu)
            ' Pour avoir la police avec la couleur négatif à l'arrière plan du boutton
            .ForeColor = Color.FromArgb(255 - intCouleurRouge, 255 - intCouleurVert, 255 - intCouleurBleu)
        End With
    End Sub

    Private Sub AttrapeLabel_TextChanged(ByVal sender As Object,
                                         ByVal e As System.EventArgs) _
                                         Handles AttrapeLabel.TextChanged
        AttrapeLabel.Font = New Font("Segoe", 8, FontStyle.Bold)
        AttrapeButton.Font = New Font("Segoe", 8, FontStyle.Bold)
    End Sub

    Private Sub AttrapeButton_MouseDown(ByVal sender As Object,
                                        ByVal e As System.Windows.Forms.MouseEventArgs) _
                                        Handles AttrapeButton.MouseDown
        Me.Close()
        If MDIParentForm.MdiChildren.Length = 0 Then
            MDIParentForm.JeuTimer.Stop()
            MDIParentForm.TempToolStripTextBox.Text = "Gagné !"
            MessageBox.Show("Vous avez gagné !", "Attrape", MessageBoxButtons.OK,
                            MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        End If
    End Sub

    Private Sub AttrapeButton_ForeColorChanged(ByVal sender As Object,
                                               ByVal e As System.EventArgs) _
                                               Handles AttrapeButton.ForeColorChanged
        Select Case AttrapeButton.FlatStyle
            Case FlatStyle.Standard
                AttrapeButton.FlatStyle = FlatStyle.Flat
            Case FlatStyle.Flat
                AttrapeButton.FlatStyle = FlatStyle.Popup
            Case FlatStyle.Popup
                AttrapeButton.FlatStyle = FlatStyle.System
            Case FlatStyle.System
                AttrapeButton.FlatStyle = FlatStyle.Standard
        End Select
    End Sub

End Class