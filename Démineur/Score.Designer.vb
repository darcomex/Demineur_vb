<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Score
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LbScore = New System.Windows.Forms.Label()
        Me.CbNom = New System.Windows.Forms.ListBox()
        Me.CbBombes = New System.Windows.Forms.ListBox()
        Me.CbTemps = New System.Windows.Forms.ListBox()
        Me.CbNbCases = New System.Windows.Forms.ListBox()
        Me.CbGagnee = New System.Windows.Forms.ListBox()
        Me.CbDifficulté = New System.Windows.Forms.ListBox()
        Me.BtRetour = New System.Windows.Forms.Button()
        Me.LbGagne = New System.Windows.Forms.Label()
        Me.LbDiff = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LbNbCasesD = New System.Windows.Forms.Label()
        Me.LbBombes = New System.Windows.Forms.Label()
        Me.LbTemps = New System.Windows.Forms.Label()
        Me.CbPoints = New System.Windows.Forms.ListBox()
        Me.LbPoints = New System.Windows.Forms.Label()
        Me.CbRecherche = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'LbScore
        '
        Me.LbScore.AutoSize = True
        Me.LbScore.Font = New System.Drawing.Font("Microsoft YaHei", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbScore.Location = New System.Drawing.Point(383, 9)
        Me.LbScore.Name = "LbScore"
        Me.LbScore.Size = New System.Drawing.Size(92, 31)
        Me.LbScore.TabIndex = 3
        Me.LbScore.Text = "Scores"
        '
        'CbNom
        '
        Me.CbNom.FormattingEnabled = True
        Me.CbNom.Location = New System.Drawing.Point(365, 140)
        Me.CbNom.Name = "CbNom"
        Me.CbNom.Size = New System.Drawing.Size(171, 225)
        Me.CbNom.TabIndex = 4
        '
        'CbBombes
        '
        Me.CbBombes.FormattingEnabled = True
        Me.CbBombes.Location = New System.Drawing.Point(699, 140)
        Me.CbBombes.Name = "CbBombes"
        Me.CbBombes.Size = New System.Drawing.Size(96, 225)
        Me.CbBombes.TabIndex = 5
        '
        'CbTemps
        '
        Me.CbTemps.FormattingEnabled = True
        Me.CbTemps.Location = New System.Drawing.Point(801, 140)
        Me.CbTemps.Name = "CbTemps"
        Me.CbTemps.Size = New System.Drawing.Size(109, 225)
        Me.CbTemps.TabIndex = 6
        '
        'CbNbCases
        '
        Me.CbNbCases.FormattingEnabled = True
        Me.CbNbCases.Location = New System.Drawing.Point(542, 140)
        Me.CbNbCases.Name = "CbNbCases"
        Me.CbNbCases.Size = New System.Drawing.Size(151, 225)
        Me.CbNbCases.TabIndex = 7
        '
        'CbGagnee
        '
        Me.CbGagnee.FormattingEnabled = True
        Me.CbGagnee.Location = New System.Drawing.Point(12, 140)
        Me.CbGagnee.Name = "CbGagnee"
        Me.CbGagnee.Size = New System.Drawing.Size(74, 225)
        Me.CbGagnee.TabIndex = 8
        '
        'CbDifficulté
        '
        Me.CbDifficulté.FormattingEnabled = True
        Me.CbDifficulté.Location = New System.Drawing.Point(215, 140)
        Me.CbDifficulté.Name = "CbDifficulté"
        Me.CbDifficulté.Size = New System.Drawing.Size(144, 225)
        Me.CbDifficulté.TabIndex = 9
        '
        'BtRetour
        '
        Me.BtRetour.Location = New System.Drawing.Point(778, 392)
        Me.BtRetour.Name = "BtRetour"
        Me.BtRetour.Size = New System.Drawing.Size(132, 47)
        Me.BtRetour.TabIndex = 10
        Me.BtRetour.Text = "RETOUR"
        Me.BtRetour.UseVisualStyleBackColor = True
        '
        'LbGagne
        '
        Me.LbGagne.AutoSize = True
        Me.LbGagne.Location = New System.Drawing.Point(24, 114)
        Me.LbGagne.Name = "LbGagne"
        Me.LbGagne.Size = New System.Drawing.Size(39, 13)
        Me.LbGagne.TabIndex = 13
        Me.LbGagne.Text = "Gagné"
        '
        'LbDiff
        '
        Me.LbDiff.AutoSize = True
        Me.LbDiff.Location = New System.Drawing.Point(257, 114)
        Me.LbDiff.Name = "LbDiff"
        Me.LbDiff.Size = New System.Drawing.Size(46, 13)
        Me.LbDiff.TabIndex = 14
        Me.LbDiff.Text = "Diffculté"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(425, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Nom"
        '
        'LbNbCasesD
        '
        Me.LbNbCasesD.AutoSize = True
        Me.LbNbCasesD.Location = New System.Drawing.Point(530, 114)
        Me.LbNbCasesD.Name = "LbNbCasesD"
        Me.LbNbCasesD.Size = New System.Drawing.Size(172, 13)
        Me.LbNbCasesD.TabIndex = 16
        Me.LbNbCasesD.Text = "Cases découvertes / Cases totales"
        '
        'LbBombes
        '
        Me.LbBombes.AutoSize = True
        Me.LbBombes.Location = New System.Drawing.Point(719, 114)
        Me.LbBombes.Name = "LbBombes"
        Me.LbBombes.Size = New System.Drawing.Size(45, 13)
        Me.LbBombes.TabIndex = 17
        Me.LbBombes.Text = "Bombes"
        '
        'LbTemps
        '
        Me.LbTemps.AutoSize = True
        Me.LbTemps.Location = New System.Drawing.Point(833, 114)
        Me.LbTemps.Name = "LbTemps"
        Me.LbTemps.Size = New System.Drawing.Size(39, 13)
        Me.LbTemps.TabIndex = 18
        Me.LbTemps.Text = "Temps"
        '
        'CbPoints
        '
        Me.CbPoints.FormattingEnabled = True
        Me.CbPoints.Location = New System.Drawing.Point(93, 140)
        Me.CbPoints.Name = "CbPoints"
        Me.CbPoints.Size = New System.Drawing.Size(116, 225)
        Me.CbPoints.TabIndex = 0
        '
        'LbPoints
        '
        Me.LbPoints.AutoSize = True
        Me.LbPoints.Location = New System.Drawing.Point(131, 114)
        Me.LbPoints.Name = "LbPoints"
        Me.LbPoints.Size = New System.Drawing.Size(36, 13)
        Me.LbPoints.TabIndex = 20
        Me.LbPoints.Text = "Points"
        '
        'CbRecherche
        '
        Me.CbRecherche.FormattingEnabled = True
        Me.CbRecherche.Location = New System.Drawing.Point(247, 406)
        Me.CbRecherche.Name = "CbRecherche"
        Me.CbRecherche.Size = New System.Drawing.Size(219, 21)
        Me.CbRecherche.TabIndex = 21
        '
        'Score
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 450)
        Me.Controls.Add(Me.CbRecherche)
        Me.Controls.Add(Me.LbPoints)
        Me.Controls.Add(Me.CbPoints)
        Me.Controls.Add(Me.LbTemps)
        Me.Controls.Add(Me.LbBombes)
        Me.Controls.Add(Me.LbNbCasesD)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LbDiff)
        Me.Controls.Add(Me.LbGagne)
        Me.Controls.Add(Me.BtRetour)
        Me.Controls.Add(Me.CbDifficulté)
        Me.Controls.Add(Me.CbGagnee)
        Me.Controls.Add(Me.CbNbCases)
        Me.Controls.Add(Me.CbTemps)
        Me.Controls.Add(Me.CbBombes)
        Me.Controls.Add(Me.CbNom)
        Me.Controls.Add(Me.LbScore)
        Me.Name = "Score"
        Me.Text = "Score"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LbScore As Windows.Forms.Label
    Friend WithEvents CbNom As Windows.Forms.ListBox
    Friend WithEvents CbBombes As Windows.Forms.ListBox
    Friend WithEvents CbTemps As Windows.Forms.ListBox
    Friend WithEvents CbNbCases As Windows.Forms.ListBox
    Friend WithEvents CbGagnee As Windows.Forms.ListBox
    Friend WithEvents CbDifficulté As Windows.Forms.ListBox
    Friend WithEvents BtRetour As Windows.Forms.Button
    Friend WithEvents LbGagne As Windows.Forms.Label
    Friend WithEvents LbDiff As Windows.Forms.Label
    Friend WithEvents Label3 As Windows.Forms.Label
    Friend WithEvents LbNbCasesD As Windows.Forms.Label
    Friend WithEvents LbBombes As Windows.Forms.Label
    Friend WithEvents LbTemps As Windows.Forms.Label
    Friend WithEvents CbPoints As Windows.Forms.ListBox
    Friend WithEvents LbPoints As Windows.Forms.Label
    Friend WithEvents CbRecherche As Windows.Forms.ComboBox
End Class
