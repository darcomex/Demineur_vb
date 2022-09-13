Imports System.Windows.Forms

Module Module1
    Private cases(,) As Integer
    Private nbMines As Integer
    Private taille As Integer
    Private count As Integer
    Private score As Integer
    Sub init()
        score = 0
        count = 0
        taille = Options.TbTaille.Text
        ReDim cases(taille - 1, taille - 1)
        For i = 0 To taille - 1
            For j = 0 To taille - 1
                cases(i, j) = 0
            Next
        Next
        nbMines = Options.TbMines.Text
        Randomize()
        For i = 0 To nbMines - 1
            Dim nb As Integer = Int((taille * taille - 1) * Rnd())
            Dim h As Integer = Math.Floor(nb / taille)
            Dim v As Integer = nb Mod taille
            If cases(h, v) = 1 Then
                i -= 1
            Else
                cases(h, v) = 1
            End If

        Next
        Jeu.Timer1.Start()
        Jeu.Timer1.Interval = 1000
    End Sub


    Public Function compterMines(h As Integer, v As Integer)
        Dim cpt As Integer = 0

        If h < taille - 1 Then

            If cases(h + 1, v) = 1 Then
                cpt += 1
            End If
        End If

        If h > 0 Then
            If cases(h - 1, v) = 1 Then
                cpt += 1
            End If
        End If

        If v < taille - 1 Then
            If cases(h, v + 1) = 1 Then
                cpt += 1
            End If
        End If

        If v > 0 Then
            If cases(h, v - 1) = 1 Then
                cpt += 1
            End If
        End If

        If v > 0 And h > 0 Then
            If cases(h - 1, v - 1) = 1 Then
                cpt += 1
            End If
        End If

        If v < taille - 1 And h < taille - 1 Then
            If cases(h + 1, v + 1) = 1 Then
                cpt += 1
            End If
        End If

        If v > 0 And h < taille - 1 Then
            If cases(h + 1, v - 1) = 1 Then
                cpt += 1
            End If
        End If

        If v < taille - 1 And h > 0 Then
            If cases(h - 1, v + 1) = 1 Then
                cpt += 1
            End If
        End If
        Return cpt
    End Function

    Public Function estMine(h As Integer, v As Integer) As Boolean

        If cases(h, v) = 1 Then
            Return True
        Else
            Return False
        End If
    End Function
    Sub decouvrir_case(h As Integer, v As Integer)
        If cases(h, v) = 0 Then
            cases(h, v) = -1
            count += 1
            If count = taille * taille - nbMines Then
                partieGagnee()
            End If

            If compterMines(h, v) = 0 Then
                If v < taille - 1 Then
                    If Not estMine(h, v + 1) And cases(h, v + 1) = 0 Then
                        Jeu.decouvrir(h, v + 1)
                        decouvrir_case(h, v + 1)
                    End If
                End If

                If h < taille - 1 Then
                    If Not estMine(h + 1, v) And cases(h + 1, v) = 0 Then
                        Jeu.decouvrir(h + 1, v)
                        decouvrir_case(h + 1, v)
                    End If

                End If

                If h > 0 Then
                    If Not estMine(h - 1, v) And cases(h - 1, v) = 0 Then
                        Jeu.decouvrir(h - 1, v)
                        decouvrir_case(h - 1, v)
                    End If
                End If

                If v > 0 Then
                    If Not estMine(h, v - 1) And cases(h, v - 1) = 0 Then
                        Jeu.decouvrir(h, v - 1)
                        decouvrir_case(h, v - 1)
                    End If
                End If

                If v < taille - 1 And h > 0 Then
                    If Not estMine(h - 1, v + 1) And cases(h - 1, v + 1) = 0 Then
                        Jeu.decouvrir(h - 1, v + 1)
                        decouvrir_case(h - 1, v + 1)
                    End If
                End If

                If v < taille - 1 And h < taille - 1 Then
                    If Not estMine(h + 1, v + 1) And cases(h + 1, v + 1) = 0 Then
                        Jeu.decouvrir(h + 1, v + 1)
                        decouvrir_case(h + 1, v + 1)
                    End If
                End If

                If v > 0 And h < taille - 1 Then
                    If Not estMine(h + 1, v - 1) And cases(h + 1, v - 1) = 0 Then
                        Jeu.decouvrir(h + 1, v - 1)
                        decouvrir_case(h + 1, v - 1)
                    End If
                End If

                If v > 0 And h > 0 Then
                    If Not estMine(h - 1, v - 1) And cases(h - 1, v - 1) = 0 Then
                        Jeu.decouvrir(h - 1, v - 1)
                        decouvrir_case(h - 1, v - 1)
                    End If
                End If

            End If

        ElseIf estMine(h, v) Then
            For i = 0 To taille - 1
                For j = 0 To taille - 1
                    If cases(i, j) = 1 Then
                        Jeu.decouvrir(i, j)
                    End If
                Next
            Next

            partiePerdue()
        End If

    End Sub

    Sub partieGagnee()
        Jeu.Timer1.Stop()
        MsgBox("Gagné ! Vous avez révélé les " & taille * taille - nbMines & " cases en " & Options.TbTmps.Text - Jeu.LbTmp.Text & " secondes")
        score = (taille * taille - nbMines) + (Options.TbTmps.Text - Jeu.LbTmp.Text) * 100
        score = Options.ScoreMultiplier(score)
        Jeu.enregistrerJoueur(True, count, score)
        Jeu.Close()
        Accueil.Show()
    End Sub



    Sub partiePerdue()
        Jeu.Timer1.Stop()
        MsgBox("Perdu ! Vous avez révélé " & count & " cases sur " & taille * taille - nbMines & " en " & Options.TbTmps.Text - Jeu.LbTmp.Text & " secondes")
        score = count * 10
        score = Options.ScoreMultiplier(score)
        Jeu.enregistrerJoueur(False, count, score)
        Jeu.Close()
        Accueil.Show()
    End Sub
End Module
