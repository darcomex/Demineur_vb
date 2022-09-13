<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Accueil
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lbDem = New System.Windows.Forms.Label()
        Me.LbPseudo = New System.Windows.Forms.Label()
        Me.BtOptions = New System.Windows.Forms.Button()
        Me.LinkRegles = New System.Windows.Forms.LinkLabel()
        Me.BtLancer = New System.Windows.Forms.Button()
        Me.BtTheme = New System.Windows.Forms.Button()
        Me.BtQuitter = New System.Windows.Forms.Button()
        Me.CbPseudo = New System.Windows.Forms.ComboBox()
        Me.BtScores = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbDem
        '
        Me.lbDem.AutoSize = True
        Me.lbDem.Font = New System.Drawing.Font("Microsoft YaHei", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDem.Location = New System.Drawing.Point(283, 9)
        Me.lbDem.Name = "lbDem"
        Me.lbDem.Size = New System.Drawing.Size(177, 42)
        Me.lbDem.TabIndex = 0
        Me.lbDem.Text = "Démineur"
        '
        'LbPseudo
        '
        Me.LbPseudo.AutoSize = True
        Me.LbPseudo.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbPseudo.Location = New System.Drawing.Point(478, 154)
        Me.LbPseudo.Name = "LbPseudo"
        Me.LbPseudo.Size = New System.Drawing.Size(66, 21)
        Me.LbPseudo.TabIndex = 2
        Me.LbPseudo.Text = "Pseudo"
        '
        'BtOptions
        '
        Me.BtOptions.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtOptions.Location = New System.Drawing.Point(12, 155)
        Me.BtOptions.Name = "BtOptions"
        Me.BtOptions.Size = New System.Drawing.Size(132, 37)
        Me.BtOptions.TabIndex = 4
        Me.BtOptions.Text = "OPTIONS"
        Me.BtOptions.UseVisualStyleBackColor = True
        '
        'LinkRegles
        '
        Me.LinkRegles.AutoSize = True
        Me.LinkRegles.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkRegles.Location = New System.Drawing.Point(12, 98)
        Me.LinkRegles.Name = "LinkRegles"
        Me.LinkRegles.Size = New System.Drawing.Size(59, 21)
        Me.LinkRegles.TabIndex = 5
        Me.LinkRegles.TabStop = True
        Me.LinkRegles.Text = "Règles"
        '
        'BtLancer
        '
        Me.BtLancer.Location = New System.Drawing.Point(315, 381)
        Me.BtLancer.Name = "BtLancer"
        Me.BtLancer.Size = New System.Drawing.Size(129, 57)
        Me.BtLancer.TabIndex = 6
        Me.BtLancer.Text = "LANCER"
        Me.BtLancer.UseVisualStyleBackColor = True
        '
        'BtTheme
        '
        Me.BtTheme.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtTheme.Location = New System.Drawing.Point(12, 212)
        Me.BtTheme.Name = "BtTheme"
        Me.BtTheme.Size = New System.Drawing.Size(132, 38)
        Me.BtTheme.TabIndex = 7
        Me.BtTheme.Text = "THEME"
        Me.BtTheme.UseVisualStyleBackColor = True
        '
        'BtQuitter
        '
        Me.BtQuitter.Location = New System.Drawing.Point(614, 381)
        Me.BtQuitter.Name = "BtQuitter"
        Me.BtQuitter.Size = New System.Drawing.Size(133, 57)
        Me.BtQuitter.TabIndex = 8
        Me.BtQuitter.Text = "QUITTER"
        Me.BtQuitter.UseVisualStyleBackColor = True
        '
        'CbPseudo
        '
        Me.CbPseudo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CbPseudo.FormattingEnabled = True
        Me.CbPseudo.Location = New System.Drawing.Point(605, 154)
        Me.CbPseudo.Name = "CbPseudo"
        Me.CbPseudo.Size = New System.Drawing.Size(121, 24)
        Me.CbPseudo.TabIndex = 9
        Me.CbPseudo.Text = "frewf"
        '
        'BtScores
        '
        Me.BtScores.Location = New System.Drawing.Point(68, 398)
        Me.BtScores.Name = "BtScores"
        Me.BtScores.Size = New System.Drawing.Size(75, 23)
        Me.BtScores.TabIndex = 10
        Me.BtScores.Text = "Scores"
        Me.BtScores.UseVisualStyleBackColor = True
        '
        'Accueil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(769, 450)
        Me.Controls.Add(Me.BtScores)
        Me.Controls.Add(Me.CbPseudo)
        Me.Controls.Add(Me.BtQuitter)
        Me.Controls.Add(Me.BtTheme)
        Me.Controls.Add(Me.BtLancer)
        Me.Controls.Add(Me.LinkRegles)
        Me.Controls.Add(Me.BtOptions)
        Me.Controls.Add(Me.LbPseudo)
        Me.Controls.Add(Me.lbDem)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Name = "Accueil"
        Me.Text = "Accueil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbDem As Windows.Forms.Label
    Friend WithEvents LbPseudo As Windows.Forms.Label
    Friend WithEvents BtOptions As Windows.Forms.Button
    Friend WithEvents LinkRegles As Windows.Forms.LinkLabel
    Friend WithEvents BtLancer As Windows.Forms.Button
    Friend WithEvents BtTheme As Windows.Forms.Button
    Friend WithEvents BtQuitter As Windows.Forms.Button
    Friend WithEvents CbPseudo As Windows.Forms.ComboBox
    Friend WithEvents BtScores As Windows.Forms.Button
End Class
