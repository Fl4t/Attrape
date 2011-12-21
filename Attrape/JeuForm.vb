Public Class JeuForm

    Private Sub CommencerButton_Click(ByVal sender As System.Object,
                                      ByVal e As System.EventArgs) _
                                      Handles CommencerButton.Click
        Me.Hide()
        MDIParentForm.TempToolStripTextBox.Text = 30
        MDIParentForm.nouveauFormulaire()
    End Sub

    Private Sub MonoRadioButton_Click(ByVal sender As Object,
                                      ByVal e As System.EventArgs) _
                                      Handles MonoRadioButton.Click
        MonoRadioButton.Checked = True
        MultiRadioButton.Checked = False
    End Sub

    Private Sub MultiRadioButton_Click(ByVal sender As Object,
                                       ByVal e As System.EventArgs) _
                                       Handles MultiRadioButton.Click
        MultiRadioButton.Checked = True
        MonoRadioButton.Checked = False
    End Sub

End Class