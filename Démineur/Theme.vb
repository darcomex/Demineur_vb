Imports System.Drawing

Public Class Theme
    Private Sub BtConfirm_Click(sender As Object, e As EventArgs) Handles BtConfirm.Click
        Me.Hide()
        Accueil.Show()

    End Sub

    Private Sub RbClair_CheckedChanged(sender As Object, e As EventArgs) Handles RbLight.CheckedChanged, RbDarkGr.CheckedChanged, RbDarkOr.CheckedChanged, RbDarkPu.CheckedChanged, RbDarkBl.CheckedChanged
        If RbLight.Checked Then
            Accueil.BackColor = Color.White
            Accueil.lbDem.ForeColor = Color.Black
            Accueil.LbPseudo.ForeColor = Color.Black
            Accueil.BtLancer.BackColor = Color.White
            Accueil.BtOptions.BackColor = Color.White
            Accueil.BtQuitter.BackColor = Color.White
            Accueil.BtTheme.BackColor = Color.White
            Accueil.BtTheme.ForeColor = Color.Black
            Accueil.BtQuitter.ForeColor = Color.Black
            Accueil.BtOptions.ForeColor = Color.Black
            Accueil.BtLancer.ForeColor = Color.Black
            Accueil.LinkRegles.LinkColor = Color.Blue
            Accueil.LinkRegles.ActiveLinkColor = Color.Blue
            Accueil.CbPseudo.BackColor = Color.White
            Accueil.CbPseudo.BackColor = Color.White
            Accueil.CbPseudo.ForeColor = Color.Black
            Accueil.BtScores.ForeColor = Color.Black
            Accueil.BtScores.BackColor = Color.White

            Me.BackColor = Color.White
            RbLight.ForeColor = Color.Black
            RbDarkOr.ForeColor = Color.Black
            RbDarkGr.ForeColor = Color.Black
            RbDarkPu.ForeColor = Color.Black
            RbDarkBl.ForeColor = Color.Black
            BtConfirm.BackColor = Color.White
            BtConfirm.ForeColor = Color.Black


            Options.BackColor = Color.White
            Options.RbFacile.ForeColor = Color.Black
            Options.RbMoyen.ForeColor = Color.Black
            Options.RbDifficile.ForeColor = Color.Black
            Options.RbImpossible.ForeColor = Color.Black
            Options.RbPerso.ForeColor = Color.Black
            Options.BtConfirm.BackColor = Color.White
            Options.BtConfirm.ForeColor = Color.Black
            Options.TbMines.ForeColor = Color.Black
            Options.TbTaille.ForeColor = Color.Black
            Options.TbTmps.ForeColor = Color.Black
            Options.LbDiff.ForeColor = Color.Black
            Options.Lbtmp.ForeColor = Color.Black
            Options.LbMines.ForeColor = Color.Black
            Options.LbTailleG.ForeColor = Color.Black
            Options.BtDesacTmp.ForeColor = Color.Black

            Score.BackColor = Color.White
            Score.BtRetour.ForeColor = Color.Black
            Score.BtRetour.BackColor = Color.White

        ElseIf RbDarkOr.Checked Then
            Accueil.BackColor = Color.Black
            Accueil.BtTheme.ForeColor = Color.DarkOrange
            Accueil.BtQuitter.ForeColor = Color.DarkOrange
            Accueil.BtOptions.ForeColor = Color.DarkOrange
            Accueil.BtLancer.ForeColor = Color.DarkOrange
            Accueil.lbDem.ForeColor = Color.DarkOrange
            Accueil.LbPseudo.ForeColor = Color.DarkOrange
            Accueil.BtLancer.BackColor = Color.DimGray
            Accueil.BtOptions.BackColor = Color.DimGray
            Accueil.BtQuitter.BackColor = Color.DimGray
            Accueil.BtTheme.BackColor = Color.DimGray
            Accueil.LinkRegles.ActiveLinkColor = Color.DarkOrange
            Accueil.LinkRegles.LinkColor = Color.DarkOrange
            Accueil.CbPseudo.BackColor = Color.DimGray
            Accueil.CbPseudo.ForeColor = Color.DarkOrange
            Accueil.BtScores.ForeColor = Color.DarkOrange
            Accueil.BtScores.BackColor = Color.DimGray

            Me.BackColor = Color.Black
            RbLight.ForeColor = Color.DarkOrange
            RbDarkOr.ForeColor = Color.DarkOrange
            RbDarkGr.ForeColor = Color.DarkOrange
            RbDarkPu.ForeColor = Color.DarkOrange
            RbDarkBl.ForeColor = Color.DarkOrange
            BtConfirm.BackColor = Color.DimGray
            BtConfirm.ForeColor = Color.DarkOrange

            Options.BackColor = Color.Black
            Options.RbFacile.ForeColor = Color.DarkOrange
            Options.RbMoyen.ForeColor = Color.DarkOrange
            Options.RbDifficile.ForeColor = Color.DarkOrange
            Options.RbImpossible.ForeColor = Color.DarkOrange
            Options.RbPerso.ForeColor = Color.DarkOrange
            Options.BtConfirm.BackColor = Color.DimGray
            Options.BtConfirm.ForeColor = Color.DarkOrange
            Options.TbMines.ForeColor = Color.DarkOrange
            Options.TbTaille.ForeColor = Color.DarkOrange
            Options.TbTmps.ForeColor = Color.DarkOrange
            Options.LbDiff.ForeColor = Color.DarkOrange
            Options.Lbtmp.ForeColor = Color.DarkOrange
            Options.LbMines.ForeColor = Color.DarkOrange
            Options.LbTailleG.ForeColor = Color.DarkOrange
            Options.BtDesacTmp.ForeColor = Color.DarkOrange

            Score.BackColor = Color.Black
            Score.BtRetour.ForeColor = Color.DarkOrange
            Score.BtRetour.BackColor = Color.DimGray

        ElseIf RbDarkGr.Checked Then
            Accueil.BackColor = Color.Black
            Accueil.BtTheme.ForeColor = Color.LimeGreen
            Accueil.BtQuitter.ForeColor = Color.LimeGreen
            Accueil.BtOptions.ForeColor = Color.LimeGreen
            Accueil.BtLancer.ForeColor = Color.LimeGreen
            Accueil.lbDem.ForeColor = Color.LimeGreen
            Accueil.LbPseudo.ForeColor = Color.LimeGreen
            Accueil.BtLancer.BackColor = Color.DimGray
            Accueil.BtOptions.BackColor = Color.DimGray
            Accueil.BtQuitter.BackColor = Color.DimGray
            Accueil.BtTheme.BackColor = Color.DimGray
            Accueil.LinkRegles.ActiveLinkColor = Color.LimeGreen
            Accueil.LinkRegles.LinkColor = Color.LimeGreen
            Accueil.CbPseudo.BackColor = Color.DimGray
            Accueil.CbPseudo.ForeColor = Color.LimeGreen
            Accueil.BtScores.ForeColor = Color.LimeGreen
            Accueil.BtScores.BackColor = Color.DimGray

            Me.BackColor = Color.Black
            RbLight.ForeColor = Color.LimeGreen
            RbDarkOr.ForeColor = Color.LimeGreen
            RbDarkGr.ForeColor = Color.LimeGreen
            RbDarkPu.ForeColor = Color.LimeGreen
            RbDarkBl.ForeColor = Color.LimeGreen
            BtConfirm.BackColor = Color.DimGray
            BtConfirm.ForeColor = Color.LimeGreen

            Options.BackColor = Color.Black
            Options.RbFacile.ForeColor = Color.LimeGreen
            Options.RbMoyen.ForeColor = Color.LimeGreen
            Options.RbDifficile.ForeColor = Color.LimeGreen
            Options.RbImpossible.ForeColor = Color.LimeGreen
            Options.RbPerso.ForeColor = Color.LimeGreen
            Options.BtConfirm.BackColor = Color.DimGray
            Options.BtConfirm.ForeColor = Color.LimeGreen
            Options.TbMines.ForeColor = Color.LimeGreen
            Options.TbTaille.ForeColor = Color.LimeGreen
            Options.TbTmps.ForeColor = Color.LimeGreen
            Options.LbDiff.ForeColor = Color.LimeGreen
            Options.Lbtmp.ForeColor = Color.LimeGreen
            Options.LbMines.ForeColor = Color.LimeGreen
            Options.LbTailleG.ForeColor = Color.LimeGreen
            Options.BtDesacTmp.ForeColor = Color.LimeGreen

            Score.BackColor = Color.Black
            Score.BtRetour.ForeColor = Color.LimeGreen
            Score.BtRetour.BackColor = Color.DimGray

        ElseIf RbDarkPu.Checked Then
            Accueil.BackColor = Color.Black
            Accueil.BtTheme.ForeColor = Color.Purple
            Accueil.BtQuitter.ForeColor = Color.Purple
            Accueil.BtOptions.ForeColor = Color.Purple
            Accueil.BtLancer.ForeColor = Color.Purple
            Accueil.lbDem.ForeColor = Color.Purple
            Accueil.LbPseudo.ForeColor = Color.Purple
            Accueil.BtLancer.BackColor = Color.DimGray
            Accueil.BtOptions.BackColor = Color.DimGray
            Accueil.BtQuitter.BackColor = Color.DimGray
            Accueil.BtTheme.BackColor = Color.DimGray
            Accueil.LinkRegles.ActiveLinkColor = Color.Purple
            Accueil.LinkRegles.LinkColor = Color.Purple
            Accueil.CbPseudo.BackColor = Color.DimGray
            Accueil.CbPseudo.ForeColor = Color.Purple
            Accueil.BtScores.ForeColor = Color.Purple
            Accueil.BtScores.BackColor = Color.DimGray

            Me.BackColor = Color.Black
            RbLight.ForeColor = Color.Purple
            RbDarkOr.ForeColor = Color.Purple
            RbDarkGr.ForeColor = Color.Purple
            RbDarkPu.ForeColor = Color.Purple
            RbDarkBl.ForeColor = Color.Purple
            BtConfirm.BackColor = Color.DimGray
            BtConfirm.ForeColor = Color.Purple

            Options.BackColor = Color.Black
            Options.RbFacile.ForeColor = Color.Purple
            Options.RbMoyen.ForeColor = Color.Purple
            Options.RbDifficile.ForeColor = Color.Purple
            Options.RbImpossible.ForeColor = Color.Purple
            Options.RbPerso.ForeColor = Color.Purple
            Options.BtConfirm.BackColor = Color.DimGray
            Options.BtConfirm.ForeColor = Color.Purple
            Options.TbMines.ForeColor = Color.Purple
            Options.TbTaille.ForeColor = Color.Purple
            Options.TbTmps.ForeColor = Color.Purple
            Options.LbDiff.ForeColor = Color.Purple
            Options.Lbtmp.ForeColor = Color.Purple
            Options.LbMines.ForeColor = Color.Purple
            Options.LbTailleG.ForeColor = Color.Purple
            Options.BtDesacTmp.ForeColor = Color.Purple

            Score.BackColor = Color.Black
            Score.BtRetour.ForeColor = Color.Purple
            Score.BtRetour.BackColor = Color.DimGray

        ElseIf RbDarkBl.Checked Then
            Accueil.BackColor = Color.Black
            Accueil.BtTheme.ForeColor = Color.RoyalBlue
            Accueil.BtQuitter.ForeColor = Color.RoyalBlue
            Accueil.BtOptions.ForeColor = Color.RoyalBlue
            Accueil.BtLancer.ForeColor = Color.RoyalBlue
            Accueil.lbDem.ForeColor = Color.RoyalBlue
            Accueil.LbPseudo.ForeColor = Color.RoyalBlue
            Accueil.BtLancer.BackColor = Color.DimGray
            Accueil.BtOptions.BackColor = Color.DimGray
            Accueil.BtQuitter.BackColor = Color.DimGray
            Accueil.BtTheme.BackColor = Color.DimGray
            Accueil.LinkRegles.ActiveLinkColor = Color.RoyalBlue
            Accueil.LinkRegles.LinkColor = Color.RoyalBlue
            Accueil.CbPseudo.BackColor = Color.DimGray
            Accueil.CbPseudo.ForeColor = Color.RoyalBlue
            Accueil.BtScores.ForeColor = Color.RoyalBlue
            Accueil.BtScores.BackColor = Color.DimGray

            Me.BackColor = Color.Black
            RbLight.ForeColor = Color.RoyalBlue
            RbDarkOr.ForeColor = Color.RoyalBlue
            RbDarkGr.ForeColor = Color.RoyalBlue
            RbDarkPu.ForeColor = Color.RoyalBlue
            RbDarkBl.ForeColor = Color.RoyalBlue
            BtConfirm.BackColor = Color.DimGray
            BtConfirm.ForeColor = Color.RoyalBlue

            Options.BackColor = Color.Black
            Options.RbFacile.ForeColor = Color.RoyalBlue
            Options.RbMoyen.ForeColor = Color.RoyalBlue
            Options.RbDifficile.ForeColor = Color.RoyalBlue
            Options.RbImpossible.ForeColor = Color.RoyalBlue
            Options.RbPerso.ForeColor = Color.RoyalBlue
            Options.BtConfirm.BackColor = Color.DimGray
            Options.BtConfirm.ForeColor = Color.RoyalBlue
            Options.TbMines.ForeColor = Color.RoyalBlue
            Options.TbTaille.ForeColor = Color.RoyalBlue
            Options.TbTmps.ForeColor = Color.RoyalBlue
            Options.LbDiff.ForeColor = Color.RoyalBlue
            Options.Lbtmp.ForeColor = Color.RoyalBlue
            Options.LbMines.ForeColor = Color.RoyalBlue
            Options.LbTailleG.ForeColor = Color.RoyalBlue
            Options.BtDesacTmp.ForeColor = Color.RoyalBlue

            Score.BackColor = Color.Black
            Score.BtRetour.ForeColor = Color.RoyalBlue
            Score.BtRetour.BackColor = Color.DimGray
        End If

    End Sub
End Class