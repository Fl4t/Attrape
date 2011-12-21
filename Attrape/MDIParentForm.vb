Imports System.Windows.Forms

Public Class MDIParentForm

    Public Sub nouveauFormulaire()
        JeuTimer.Start()
        ' Créez une nouvelle instance du formulaire enfant.
        Dim ChildForm As New AttrapeForm
        ' Configurez-la en tant qu'enfant de ce formulaire MDI avant de l'afficher.
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(ByVal sender As System.Object,
                                               ByVal e As System.EventArgs) _
                                               Handles QuitterToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub NouvellePartieToolStripMenuItem_Click(ByVal sender As Object,
                                                   ByVal e As System.EventArgs) _
                                                   Handles NouvellePartieToolStripMenuItem.Click
        JeuForm.Show()
    End Sub

    Private Sub TimerJeu_Tick(ByVal sender As System.Object,
                              ByVal e As System.EventArgs) _
                              Handles JeuTimer.Tick
        TempToolStripTextBox.Text -= 1
        If TempToolStripTextBox.Text = 0 Then
            JeuTimer.Stop()
            TempToolStripTextBox.Text = "Perdu !"
            ' fermeture des formulaires enfants
            Dim enfants() As Form = Me.MdiChildren
            For Each formulaire In enfants
                formulaire.Close()
            Next
            MessageBox.Show("Vous avez perdu !", "Attrape", MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button1)
        End If
    End Sub

End Class