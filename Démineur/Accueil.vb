Public Class Accueil
    Private Sub Accueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LinkRegles.Links.Add(0, 6, "https://www.demineur-ligne.com/rules")
        LireScores.lire()
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkRegles.LinkClicked
        System.Diagnostics.Process.Start(e.Link.LinkData.ToString())
    End Sub

    Private Sub BtOptions_Click(sender As Object, e As EventArgs) Handles BtOptions.Click
        Me.Hide()
        Options.Show()
    End Sub

    Private Sub BtLancer_Click(sender As Object, e As EventArgs) Handles BtLancer.Click
        If CbPseudo.Text.Length > 2 Then
            Me.Hide()
            init()
            Jeu.Show()
        End If


    End Sub

    Private Sub BtTheme_Click(sender As Object, e As EventArgs) Handles BtTheme.Click
        Me.Hide()
        Theme.Show()
    End Sub

    Private Sub BtQuitter_Click(sender As Object, e As EventArgs) Handles BtQuitter.Click
        Dim answer = MsgBox("Voulez-vous quitter l'application ?", vbYesNo)
        If answer = vbYes Then
            LireScores.ecrire()
            Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtScores.Click
        Me.Hide()
        Score.Update()
        Score.Show()

    End Sub
End Class