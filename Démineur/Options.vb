Imports System.Windows.Forms

Public Class Options
    Private Sub BtConfirm_Click(sender As Object, e As EventArgs) Handles BtConfirm.Click
        If TbTaille.Text.Length > 0 And TbTaille.Text.Length < 3 And TbMines.Text < TbTaille.Text * TbTaille.Text Then
            Me.Hide()
            Accueil.Show()
        ElseIf TbMines.Text >= TbTaille.Text * TbTaille.Text Then
            MsgBox("Nombre de mines invalide !")
        Else
            MsgBox("Taille invalide !")
        End If
    End Sub

    Private Sub RbImpossible_CheckedChanged(sender As Object, e As EventArgs) Handles RbImpossible.CheckedChanged, RbFacile.CheckedChanged, RbMoyen.CheckedChanged, RbDifficile.CheckedChanged, RbPerso.CheckedChanged
        If RbFacile.Checked Then
            TbTaille.Enabled = False
            TbTaille.Text = 5
            TbMines.Enabled = False
            TbMines.Text = 4
            TbTmps.Enabled = False
            TbTmps.Text = 60
            BtDesacTmp.Enabled = False
            BtDesacTmp.Checked = False
        ElseIf RbMoyen.Checked Then
            TbTaille.Enabled = False
            TbTaille.Text = 8
            TbMines.Enabled = False
            TbMines.Text = 10
            TbTmps.Enabled = False
            TbTmps.Text = 60
            BtDesacTmp.Enabled = False
            BtDesacTmp.Checked = False
        ElseIf RbDifficile.Checked Then
            TbTaille.Enabled = False
            TbTaille.Text = 20
            TbMines.Enabled = False
            TbMines.Text = 63
            TbTmps.Enabled = False
            TbTmps.Text = 120
            BtDesacTmp.Enabled = False
            BtDesacTmp.Checked = False
        ElseIf RbImpossible.Checked Then
            TbTaille.Enabled = False
            TbTaille.Text = 40
            TbMines.Enabled = False
            TbMines.Text = 250
            TbTmps.Enabled = False
            TbTmps.Text = 180
            BtDesacTmp.Enabled = False
            BtDesacTmp.Checked = False
        ElseIf RbPerso.Checked Then
            TbTaille.Enabled = True
            TbMines.Enabled = True
            BtDesacTmp.Enabled = True
            TbTmps.Enabled = True
        End If
    End Sub

    Private Sub TbTaille_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TbTaille.KeyPress, TbMines.KeyPress
        If e.KeyChar = vbBack Then
            Exit Sub
        End If
        If IsNumeric(e.KeyChar) Then

        Else
            e.Handled = True
        End If
    End Sub

    Private Sub BtDesacTmp_CheckedChanged(sender As Object, e As EventArgs) Handles BtDesacTmp.CheckedChanged
        If BtDesacTmp.Checked Then
            TbTmps.Visible = False
            Lbtmp.Visible = False
            Jeu.LbTmp.Visible = False
        Else
            TbTmps.Visible = True
            Lbtmp.Visible = True
            Jeu.LbTmp.Visible = True
        End If
    End Sub

    Public Function ScoreMultiplier(score As Integer) As Integer
        If RbFacile.Checked Then
            Return score
        ElseIf RbMoyen.Checked Then
            Return score * 1.5
        ElseIf RbDifficile.Checked Then
            Return score * 2
        ElseIf RbImpossible.Checked Then
            Return score * 3
        Else
            Return 0
        End If
    End Function
End Class