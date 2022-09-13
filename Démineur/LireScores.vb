Imports System.IO

Structure Joueurs
    Dim Nom As String
    Dim Gagne As Boolean
    Dim Points As Integer
    Dim Difficulte As String
    Dim Cases As String
    Dim Bombes As Integer
    Dim Temps As Integer



    Public Overrides Function ToString() As String
        Dim win As String = "N"
        If Gagne = True Then
            win = "O"
        End If
        Return win & "," & Points & "," & Nom & "," & Difficulte & "," & Cases & "," & Bombes & "," & Temps
    End Function

End Structure

Module LireScores
    Private jo(0) As Joueurs

    Sub lire()
        Dim rd As New StreamReader("Joueurs.txt")

        Dim i As Integer = 0
        Do While rd.Peek() >= 0
            If i = jo.Length Then
                ReDim Preserve jo(jo.Length + 1)
            End If
            Dim s As String() = rd.ReadLine().Split(",")
            Dim j As New Joueurs
            If s(0) = "O" Then
                j.Gagne = True
            Else
                j.Gagne = False
            End If
            j.Points = s(1)
            j.Nom = s(2)
            j.Difficulte = s(3)
            j.Cases = s(4)
            j.Bombes = s(5)
            j.Temps = s(6)
            jo(i) = j
            i += 1
            Accueil.CbPseudo.Items.Add(j.Nom)
            AddJoueur(j)
        Loop
        rd.Close()

    End Sub

    Function getJoueurs() As Joueurs()
        Return jo
    End Function
    Sub AddJoueur(joueur As Joueurs)
        Dim i As Integer = 0
        If jo.Count() = 1 Then
            jo(0) = joueur
            ReDim Preserve jo(jo.Count())
            Return
        End If

        For Each j As Joueurs In jo

            If String.Equals(joueur.Nom, j.Nom) Then

                If joueur.Gagne = True And j.Gagne = False Then
                    jo(i) = joueur
                    Return
                End If
                If j.Gagne = True And joueur.Gagne = False Then
                    jo(i) = joueur
                    Return
                End If
                If joueur.Points >= j.Points Then
                    jo(i) = joueur
                    Return
                Else

                    Return
                End If
            End If
            i += 1
        Next
        jo(jo.Count() - 1) = joueur
        ReDim Preserve jo(jo.Count())


    End Sub

    Sub ecrire()
        Dim rd As New StreamWriter("Joueurs.txt")

        For i = 0 To jo.Count() - 2
            rd.WriteLine(jo(i).ToString())
        Next
        rd.Close()
    End Sub
End Module
