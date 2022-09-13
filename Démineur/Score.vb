Imports System.Drawing

Public Class Score

    Private Sub Score_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim jo() As Joueurs = LireScores.getJoueurs()


        For i = 0 To jo.Count() - 2

            CbBombes.Items.Add(jo(i).Bombes)
            CbDifficulté.Items.Add(jo(i).Difficulte)
            CbNbCases.Items.Add(jo(i).Cases)
            CbPoints.Items.Add(jo(i).Points)
            CbTemps.Items.Add(jo(i).Temps)
            CbNom.Items.Add(jo(i).Nom)
            If jo(i).Gagne = True Then
                CbGagnee.Items.Add("O")
            Else
                CbGagnee.Items.Add("N")
            End If

        Next

        For i = 0 To CbNom.Items.Count() - 1
            CbRecherche.Items.Add(CbNom.Items(i))
        Next

        If Theme.RbLight.Checked Then
            CbGagnee.ForeColor = Color.Black
            CbBombes.ForeColor = Color.Black
            CbDifficulté.ForeColor = Color.Black
            CbNbCases.ForeColor = Color.Black
            CbNom.ForeColor = Color.Black
            CbPoints.ForeColor = Color.Black
            CbTemps.ForeColor = Color.Black

            CbGagnee.BackColor = Color.White
            CbBombes.BackColor = Color.White
            CbDifficulté.BackColor = Color.White
            CbNbCases.BackColor = Color.White
            CbNom.BackColor = Color.White
            CbPoints.BackColor = Color.White
            CbTemps.BackColor = Color.White

            LbScore.ForeColor = Color.Black
            LbBombes.ForeColor = Color.Black
            LbDiff.ForeColor = Color.Black
            LbGagne.ForeColor = Color.Black
            LbNbCasesD.ForeColor = Color.Black
            LbPoints.ForeColor = Color.Black
            LbScore.ForeColor = Color.Black
            LbTemps.ForeColor = Color.Black
            BackColor = Color.White
            BtRetour.ForeColor = Color.Black
            BtRetour.BackColor = Color.White
            CbRecherche.BackColor = Color.White
            CbRecherche.ForeColor = Color.Black

        ElseIf Theme.RbDarkOr.Checked Then
            CbGagnee.ForeColor = Color.DarkOrange
            CbBombes.ForeColor = Color.DarkOrange
            CbDifficulté.ForeColor = Color.DarkOrange
            CbNbCases.ForeColor = Color.DarkOrange
            CbNom.ForeColor = Color.DarkOrange
            CbPoints.ForeColor = Color.DarkOrange
            CbTemps.ForeColor = Color.DarkOrange

            CbGagnee.BackColor = Color.DimGray
            CbBombes.BackColor = Color.DimGray
            CbDifficulté.BackColor = Color.DimGray
            CbNbCases.BackColor = Color.DimGray
            CbNom.BackColor = Color.DimGray
            CbPoints.BackColor = Color.DimGray
            CbTemps.BackColor = Color.DimGray

            LbScore.ForeColor = Color.DarkOrange
            LbBombes.ForeColor = Color.DarkOrange
            LbDiff.ForeColor = Color.DarkOrange
            LbGagne.ForeColor = Color.DarkOrange
            LbNbCasesD.ForeColor = Color.DarkOrange
            LbPoints.ForeColor = Color.DarkOrange
            LbScore.ForeColor = Color.DarkOrange
            LbTemps.ForeColor = Color.DarkOrange
            LbScore.ForeColor = Color.DarkOrange
            BackColor = Color.Black
            BtRetour.ForeColor = Color.DarkOrange
            BtRetour.BackColor = Color.DimGray
            CbRecherche.BackColor = Color.DimGray
            CbRecherche.ForeColor = Color.DarkOrange

        ElseIf Theme.RbDarkGr.Checked Then
            CbGagnee.ForeColor = Color.LimeGreen
            CbBombes.ForeColor = Color.LimeGreen
            CbDifficulté.ForeColor = Color.LimeGreen
            CbNbCases.ForeColor = Color.LimeGreen
            CbNom.ForeColor = Color.LimeGreen
            CbPoints.ForeColor = Color.LimeGreen
            CbTemps.ForeColor = Color.LimeGreen

            CbGagnee.BackColor = Color.DimGray
            CbBombes.BackColor = Color.DimGray
            CbDifficulté.BackColor = Color.DimGray
            CbNbCases.BackColor = Color.DimGray
            CbNom.BackColor = Color.DimGray
            CbPoints.BackColor = Color.DimGray
            CbTemps.BackColor = Color.DimGray

            LbScore.ForeColor = Color.LimeGreen
            LbBombes.ForeColor = Color.LimeGreen
            LbDiff.ForeColor = Color.LimeGreen
            LbGagne.ForeColor = Color.LimeGreen
            LbNbCasesD.ForeColor = Color.LimeGreen
            LbPoints.ForeColor = Color.LimeGreen
            LbScore.ForeColor = Color.LimeGreen
            LbTemps.ForeColor = Color.LimeGreen
            LbScore.ForeColor = Color.LimeGreen
            BackColor = Color.Black
            BtRetour.ForeColor = Color.LimeGreen
            BtRetour.BackColor = Color.DimGray
            CbRecherche.BackColor = Color.DimGray
            CbRecherche.ForeColor = Color.LimeGreen

        ElseIf Theme.RbDarkPu.Checked Then
            CbGagnee.ForeColor = Color.Purple
            CbBombes.ForeColor = Color.Purple
            CbDifficulté.ForeColor = Color.Purple
            CbNbCases.ForeColor = Color.Purple
            CbNom.ForeColor = Color.Purple
            CbPoints.ForeColor = Color.Purple
            CbTemps.ForeColor = Color.Purple

            CbGagnee.BackColor = Color.DimGray
            CbBombes.BackColor = Color.DimGray
            CbDifficulté.BackColor = Color.DimGray
            CbNbCases.BackColor = Color.DimGray
            CbNom.BackColor = Color.DimGray
            CbPoints.BackColor = Color.DimGray
            CbTemps.BackColor = Color.DimGray

            LbScore.ForeColor = Color.Purple
            LbBombes.ForeColor = Color.Purple
            LbDiff.ForeColor = Color.Purple
            LbGagne.ForeColor = Color.Purple
            LbNbCasesD.ForeColor = Color.Purple
            LbPoints.ForeColor = Color.Purple
            LbScore.ForeColor = Color.Purple
            LbTemps.ForeColor = Color.Purple
            LbScore.ForeColor = Color.Purple
            BackColor = Color.Black
            BtRetour.ForeColor = Color.Purple
            BtRetour.BackColor = Color.DimGray
            CbRecherche.BackColor = Color.DimGray
            CbRecherche.ForeColor = Color.Purple

        ElseIf Theme.RbDarkBl.Checked Then
            CbGagnee.ForeColor = Color.RoyalBlue
            CbBombes.ForeColor = Color.RoyalBlue
            CbDifficulté.ForeColor = Color.RoyalBlue
            CbNbCases.ForeColor = Color.RoyalBlue
            CbNom.ForeColor = Color.RoyalBlue
            CbPoints.ForeColor = Color.RoyalBlue
            CbTemps.ForeColor = Color.RoyalBlue

            CbGagnee.BackColor = Color.DimGray
            CbBombes.BackColor = Color.DimGray
            CbDifficulté.BackColor = Color.DimGray
            CbNbCases.BackColor = Color.DimGray
            CbNom.BackColor = Color.DimGray
            CbPoints.BackColor = Color.DimGray
            CbTemps.BackColor = Color.DimGray


            LbScore.ForeColor = Color.RoyalBlue
            LbBombes.ForeColor = Color.RoyalBlue
            LbDiff.ForeColor = Color.RoyalBlue
            LbGagne.ForeColor = Color.RoyalBlue
            LbNbCasesD.ForeColor = Color.RoyalBlue
            LbPoints.ForeColor = Color.RoyalBlue
            LbScore.ForeColor = Color.RoyalBlue
            LbTemps.ForeColor = Color.RoyalBlue
            LbScore.ForeColor = Color.RoyalBlue
            BackColor = Color.Black
            BtRetour.ForeColor = Color.RoyalBlue
            BtRetour.BackColor = Color.DimGray
            CbRecherche.BackColor = Color.DimGray
            CbRecherche.ForeColor = Color.RoyalBlue
        End If
    End Sub

    Private Sub BtRetour_Click(sender As Object, e As EventArgs) Handles BtRetour.Click
        Accueil.Show()
        Me.Close()
    End Sub

    Private Sub CbGagnee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbGagnee.SelectedIndexChanged, CbBombes.SelectedIndexChanged, CbDifficulté.SelectedIndexChanged, CbNbCases.SelectedIndexChanged, CbNom.SelectedIndexChanged, CbPoints.SelectedIndexChanged, CbTemps.SelectedIndexChanged
        Dim num = sender.SelectedIndex
        CbGagnee.SelectedIndex = num
        CbBombes.SelectedIndex = num
        CbDifficulté.SelectedIndex = num
        CbNbCases.SelectedIndex = num
        CbNom.SelectedIndex = num
        CbPoints.SelectedIndex = num
        CbTemps.SelectedIndex = num
    End Sub

    Private Sub CbRecherche_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbRecherche.SelectedIndexChanged
        For i = 0 To CbNom.Items.Count() - 1
            If CbRecherche.Text.Equals(CbNom.Items(i)) Then
                CbNom.SelectedIndex = i
            End If
        Next
    End Sub
End Class