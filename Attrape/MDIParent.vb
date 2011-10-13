Imports System.Windows.Forms

Public Class MDIParent

    Private Sub MDIParent_Load(ByVal sender As Object, _
                               ByVal e As System.EventArgs) _
                               Handles Me.Load
        ComboVitesse.SelectedIndex = 1
        NouveauFormToolStripMenuItem.PerformClick()
    End Sub

    Private Sub QuitterToolStripMenuItem_Click(ByVal sender As System.Object, _
                                               ByVal e As System.EventArgs) _
                                               Handles QuitterToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub FacileToolStripMenuItem_CheckStateChanged(ByVal sender As Object, _
                                                          ByVal e As System.EventArgs) _
                                                          Handles FacileToolStripMenuItem.CheckStateChanged
        If FacileToolStripMenuItem.Checked Then
            DifficileToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub FacileToolStripMenuItem_Click(ByVal sender As System.Object, _
                                              ByVal e As System.EventArgs) _
                                              Handles FacileToolStripMenuItem.Click
        FacileToolStripMenuItem.Checked = True
    End Sub

    Private Sub DifficileToolStripMenuItem_CheckStateChanged(ByVal sender As Object, _
                                                             ByVal e As System.EventArgs) _
                                                             Handles DifficileToolStripMenuItem.CheckStateChanged
        If DifficileToolStripMenuItem.Checked Then
            FacileToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub DifficileToolStripMenuItem_Click(ByVal sender As System.Object, _
                                                 ByVal e As System.EventArgs) _
                                                 Handles DifficileToolStripMenuItem.Click
        DifficileToolStripMenuItem.Checked = True
        NouveauFormToolStripMenuItem.PerformClick()
    End Sub

    Private Sub NouveauFormToolStripMenuItem_Click(ByVal sender As Object, _
                                                   ByVal e As System.EventArgs) _
                                                   Handles NouveauFormToolStripMenuItem.Click
        ' Créez une nouvelle instance du formulaire enfant.
        Dim ChildForm As New AttrapeForm
        ' Configurez-la en tant qu'enfant de ce formulaire MDI avant de l'afficher.
        ChildForm.MdiParent = Me
        ChildForm.Show()
    End Sub

End Class