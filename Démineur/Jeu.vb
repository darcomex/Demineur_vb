Imports System.Drawing
Imports System.Windows.Forms

Public Class Jeu
    Private countctrl As Integer = Options.TbTaille.Text * Options.TbTaille.Text
    Private Location_control As New Point(7 / (Options.TbTaille.Text / 10), 10 / (Options.TbTaille.Text / 10))
    Private pause As Boolean
    Private taille As Integer
    Private CoulMines As Color
    Private Sub create_buttons()
        For i = 1 To countctrl
            Dim b As New Button
            b.Width = 50 / (Options.TbTaille.Text / 10)
            b.Height = 50 / (Options.TbTaille.Text / 10)
            b.Text = ""
            b.Name = i
            b.BackColor = Color.DarkGray
            b.Location = New Point(Location_control.X + 7, Location_control.Y)
            AddHandler b.MouseDown, AddressOf Clickbt
            If i Mod Options.TbTaille.Text = 0 Then
                Location_control.Y += b.Height + 7 / (Options.TbTaille.Text / 10)
                Location_control.X = 7 / (Options.TbTaille.Text / 10)
            Else
                Location_control.X += b.Width + 7 / (Options.TbTaille.Text / 10)
            End If
            PnlBtns.Controls.Add(b)
        Next
    End Sub

    Public Sub Clickbt(sender As Object, e As MouseEventArgs) Handles PnlBtns.MouseDown
        Dim b As New Button
        Dim i As Integer
        If sender.ToString.Substring(0, 26).Equals(b.ToString.Substring(0, 26)) Then
            If e.Button = MouseButtons.Left Then
                i = sender.name
                Dim h As Integer = Math.Floor((i - 1) / taille)
                Dim v As Integer = (i - 1) Mod taille
                decouvrir(h, v)
                Module1.decouvrir_case(h, v)
            ElseIf e.Button = MouseButtons.Right Then
                If sender.text = "! ! !" Then
                    sender.text = ""
                    sender.backcolor = Color.DarkGray
                Else sender.text = "! ! !"
                    sender.backcolor = Color.Gray
                End If

            End If
        End If



    End Sub
    Sub decouvrir(h As Integer, v As Integer)
        Dim nbm As Integer
        Dim i As Integer = h * taille + v + 1
        nbm = Module1.compterMines(h, v)

        If Module1.estMine(h, v) Then
            PnlBtns.Controls(i).Text = "M"
            PnlBtns.Controls(i).BackColor = CoulMines
        ElseIf nbm = 0 Then
            PnlBtns.Controls(i).BackColor = Color.White
            PnlBtns.Controls(i).Enabled = False
        Else
            PnlBtns.Controls(i).Text = nbm
            PnlBtns.Controls(i).Enabled = False
        End If

    End Sub
    Private Sub Jeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        create_buttons()
        pause = False
        Panel1.Visible = False
        taille = Options.TbTaille.Text
        LbNom.Text = Accueil.CbPseudo.Text
        LbTmp.Text = Options.TbTmps.Text
        If Theme.RbDarkOr.Checked Then
            BackColor = Color.Black
            BtAband.BackColor = Color.DimGray
            BtPause.BackColor = Color.DimGray
            Panel1.BackColor = Color.Black
            BtAband.ForeColor = Color.DarkOrange
            BtPause.ForeColor = Color.DarkOrange
            LbTriche.BackColor = Color.DarkOrange
            LbNom.ForeColor = Color.DarkOrange
            LbTmp.ForeColor = Color.DarkOrange
            CoulMines = Color.DarkOrange
        ElseIf Theme.RbLight.Checked Then
            BackColor = Color.White
            BtAband.BackColor = Color.White
            BtPause.BackColor = Color.White
            Panel1.BackColor = Color.White
            BtAband.ForeColor = Color.Black
            BtPause.ForeColor = Color.Black
            LbTriche.BackColor = Color.White
            LbNom.ForeColor = Color.Black
            LbTmp.ForeColor = Color.Black
            CoulMines = Color.Red
        ElseIf Theme.RbDarkGr.Checked Then
            BackColor = Color.Black
            BtAband.BackColor = Color.DimGray
            BtPause.BackColor = Color.DimGray
            Panel1.BackColor = Color.Black
            BtAband.ForeColor = Color.LimeGreen
            BtPause.ForeColor = Color.LimeGreen
            LbTriche.BackColor = Color.LimeGreen
            LbNom.ForeColor = Color.LimeGreen
            LbTmp.ForeColor = Color.LimeGreen
            CoulMines = Color.LimeGreen
        ElseIf Theme.RbDarkPu.Checked Then
            BackColor = Color.Black
            BtAband.BackColor = Color.DimGray
            BtPause.BackColor = Color.DimGray
            Panel1.BackColor = Color.Black
            BtAband.ForeColor = Color.Purple
            BtPause.ForeColor = Color.Purple
            LbTriche.BackColor = Color.Purple
            LbNom.ForeColor = Color.Purple
            LbTmp.ForeColor = Color.Purple
            CoulMines = Color.Purple
        ElseIf Theme.RbDarkBl.Checked Then
            BackColor = Color.Black
            BtAband.BackColor = Color.DimGray
            BtPause.BackColor = Color.DimGray
            Panel1.BackColor = Color.Black
            BtAband.ForeColor = Color.RoyalBlue
            BtPause.ForeColor = Color.RoyalBlue
            LbTriche.BackColor = Color.RoyalBlue
            LbNom.ForeColor = Color.RoyalBlue
            LbTmp.ForeColor = Color.RoyalBlue
            CoulMines = Color.RoyalBlue
        End If

    End Sub

    Private Sub BtAband_Click(sender As Object, e As EventArgs) Handles BtAband.Click
        Dim answer = MsgBox("Voulez-vous vraiment abandonner ?", vbYesNo)
        If answer = vbYes Then
            Me.Close()
            Accueil.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LbTmp.Text = LbTmp.Text - 1
        If LbTmp.Text = 0 And Options.BtDesacTmp.Checked = False Then
            partiePerdue()
        End If
    End Sub

    Private Sub BtPause_Click(sender As Object, e As EventArgs) Handles BtPause.Click
        If pause = False Then
            Timer1.Stop()
            PnlBtns.Enabled = False
            pause = True
            Panel1.Visible = True
        Else
            Timer1.Start()
            PnlBtns.Enabled = True
            pause = False
            Panel1.Visible = False
        End If
    End Sub

    Sub enregistrerJoueur(win As Boolean, nb As Integer, score As Integer)
        Dim j As Joueurs
        j.Gagne = win
        j.Bombes = Options.TbMines.Text
        j.Cases = nb & "/" & taille * taille - Options.TbMines.Text
        Dim diff As String
        For i = 0 To Options.Panel1.Controls.Count - 1
            Dim chk As RadioButton = Options.Panel1.Controls(i)
            If chk.Checked Then
                diff = Options.Panel1.Controls(i).Text
            End If
        Next
        j.Difficulte = diff
        j.Nom = Accueil.CbPseudo.Text
        j.Temps = Options.TbTmps.Text - LbTmp.Text
        j.Points = score
        MsgBox(j.ToString())
        LireScores.AddJoueur(j)
    End Sub
End Class