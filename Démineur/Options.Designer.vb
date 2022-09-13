<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Me.BtConfirm = New System.Windows.Forms.Button()
        Me.LbDiff = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RbPerso = New System.Windows.Forms.RadioButton()
        Me.RbDifficile = New System.Windows.Forms.RadioButton()
        Me.RbImpossible = New System.Windows.Forms.RadioButton()
        Me.RbMoyen = New System.Windows.Forms.RadioButton()
        Me.RbFacile = New System.Windows.Forms.RadioButton()
        Me.TbTaille = New System.Windows.Forms.TextBox()
        Me.LbTailleG = New System.Windows.Forms.Label()
        Me.LbMines = New System.Windows.Forms.Label()
        Me.TbMines = New System.Windows.Forms.TextBox()
        Me.Lbtmp = New System.Windows.Forms.Label()
        Me.TbTmps = New System.Windows.Forms.TextBox()
        Me.BtDesacTmp = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtConfirm
        '
        Me.BtConfirm.Location = New System.Drawing.Point(131, 358)
        Me.BtConfirm.Name = "BtConfirm"
        Me.BtConfirm.Size = New System.Drawing.Size(149, 48)
        Me.BtConfirm.TabIndex = 0
        Me.BtConfirm.Text = "CONFIRMER"
        Me.BtConfirm.UseVisualStyleBackColor = True
        '
        'LbDiff
        '
        Me.LbDiff.AutoSize = True
        Me.LbDiff.Font = New System.Drawing.Font("Microsoft YaHei", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbDiff.Location = New System.Drawing.Point(42, 18)
        Me.LbDiff.Name = "LbDiff"
        Me.LbDiff.Size = New System.Drawing.Size(86, 21)
        Me.LbDiff.TabIndex = 1
        Me.LbDiff.Text = "Difficultés"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RbPerso)
        Me.Panel1.Controls.Add(Me.RbDifficile)
        Me.Panel1.Controls.Add(Me.RbImpossible)
        Me.Panel1.Controls.Add(Me.RbMoyen)
        Me.Panel1.Controls.Add(Me.RbFacile)
        Me.Panel1.Location = New System.Drawing.Point(36, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(111, 213)
        Me.Panel1.TabIndex = 2
        '
        'RbPerso
        '
        Me.RbPerso.AutoSize = True
        Me.RbPerso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RbPerso.Location = New System.Drawing.Point(7, 177)
        Me.RbPerso.Name = "RbPerso"
        Me.RbPerso.Size = New System.Drawing.Size(85, 17)
        Me.RbPerso.TabIndex = 6
        Me.RbPerso.Text = "Personnalisé"
        Me.RbPerso.UseVisualStyleBackColor = True
        '
        'RbDifficile
        '
        Me.RbDifficile.AutoSize = True
        Me.RbDifficile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RbDifficile.Location = New System.Drawing.Point(7, 95)
        Me.RbDifficile.Name = "RbDifficile"
        Me.RbDifficile.Size = New System.Drawing.Size(59, 17)
        Me.RbDifficile.TabIndex = 5
        Me.RbDifficile.Text = "Difficile"
        Me.RbDifficile.UseVisualStyleBackColor = True
        '
        'RbImpossible
        '
        Me.RbImpossible.AutoSize = True
        Me.RbImpossible.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RbImpossible.Location = New System.Drawing.Point(7, 138)
        Me.RbImpossible.Name = "RbImpossible"
        Me.RbImpossible.Size = New System.Drawing.Size(95, 17)
        Me.RbImpossible.TabIndex = 4
        Me.RbImpossible.Text = "IMPOSSIBLE !"
        Me.RbImpossible.UseVisualStyleBackColor = True
        '
        'RbMoyen
        '
        Me.RbMoyen.AutoSize = True
        Me.RbMoyen.Checked = True
        Me.RbMoyen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RbMoyen.Location = New System.Drawing.Point(7, 52)
        Me.RbMoyen.Name = "RbMoyen"
        Me.RbMoyen.Size = New System.Drawing.Size(57, 17)
        Me.RbMoyen.TabIndex = 3
        Me.RbMoyen.TabStop = True
        Me.RbMoyen.Text = "Moyen"
        Me.RbMoyen.UseVisualStyleBackColor = True
        '
        'RbFacile
        '
        Me.RbFacile.AutoSize = True
        Me.RbFacile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.RbFacile.Location = New System.Drawing.Point(7, 17)
        Me.RbFacile.Name = "RbFacile"
        Me.RbFacile.Size = New System.Drawing.Size(53, 17)
        Me.RbFacile.TabIndex = 2
        Me.RbFacile.Text = "Facile"
        Me.RbFacile.UseVisualStyleBackColor = True
        '
        'TbTaille
        '
        Me.TbTaille.Enabled = False
        Me.TbTaille.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbTaille.Location = New System.Drawing.Point(320, 222)
        Me.TbTaille.Name = "TbTaille"
        Me.TbTaille.Size = New System.Drawing.Size(100, 22)
        Me.TbTaille.TabIndex = 3
        '
        'LbTailleG
        '
        Me.LbTailleG.AutoSize = True
        Me.LbTailleG.Location = New System.Drawing.Point(246, 228)
        Me.LbTailleG.Name = "LbTailleG"
        Me.LbTailleG.Size = New System.Drawing.Size(56, 13)
        Me.LbTailleG.TabIndex = 4
        Me.LbTailleG.Text = "Taille grille"
        '
        'LbMines
        '
        Me.LbMines.AutoSize = True
        Me.LbMines.Location = New System.Drawing.Point(246, 186)
        Me.LbMines.Name = "LbMines"
        Me.LbMines.Size = New System.Drawing.Size(35, 13)
        Me.LbMines.TabIndex = 5
        Me.LbMines.Text = "Mines"
        '
        'TbMines
        '
        Me.TbMines.Enabled = False
        Me.TbMines.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbMines.Location = New System.Drawing.Point(320, 179)
        Me.TbMines.Name = "TbMines"
        Me.TbMines.Size = New System.Drawing.Size(100, 22)
        Me.TbMines.TabIndex = 6
        '
        'Lbtmp
        '
        Me.Lbtmp.AutoSize = True
        Me.Lbtmp.Location = New System.Drawing.Point(246, 144)
        Me.Lbtmp.Name = "Lbtmp"
        Me.Lbtmp.Size = New System.Drawing.Size(39, 13)
        Me.Lbtmp.TabIndex = 7
        Me.Lbtmp.Text = "Temps"
        '
        'TbTmps
        '
        Me.TbTmps.Enabled = False
        Me.TbTmps.Font = New System.Drawing.Font("Microsoft YaHei", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TbTmps.Location = New System.Drawing.Point(320, 141)
        Me.TbTmps.Name = "TbTmps"
        Me.TbTmps.Size = New System.Drawing.Size(100, 22)
        Me.TbTmps.TabIndex = 8
        '
        'BtDesacTmp
        '
        Me.BtDesacTmp.AutoSize = True
        Me.BtDesacTmp.Location = New System.Drawing.Point(320, 118)
        Me.BtDesacTmp.Name = "BtDesacTmp"
        Me.BtDesacTmp.Size = New System.Drawing.Size(108, 17)
        Me.BtDesacTmp.TabIndex = 9
        Me.BtDesacTmp.Text = "Désactiver temps"
        Me.BtDesacTmp.UseVisualStyleBackColor = True
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(452, 450)
        Me.Controls.Add(Me.BtDesacTmp)
        Me.Controls.Add(Me.TbTmps)
        Me.Controls.Add(Me.Lbtmp)
        Me.Controls.Add(Me.TbMines)
        Me.Controls.Add(Me.LbMines)
        Me.Controls.Add(Me.LbDiff)
        Me.Controls.Add(Me.LbTailleG)
        Me.Controls.Add(Me.TbTaille)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BtConfirm)
        Me.Name = "Options"
        Me.Text = "Options"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtConfirm As Windows.Forms.Button
    Friend WithEvents LbDiff As Windows.Forms.Label
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents RbDifficile As Windows.Forms.RadioButton
    Friend WithEvents RbImpossible As Windows.Forms.RadioButton
    Friend WithEvents RbMoyen As Windows.Forms.RadioButton
    Friend WithEvents RbFacile As Windows.Forms.RadioButton
    Friend WithEvents RbPerso As Windows.Forms.RadioButton
    Friend WithEvents TbTaille As Windows.Forms.TextBox
    Friend WithEvents LbTailleG As Windows.Forms.Label
    Friend WithEvents LbMines As Windows.Forms.Label
    Friend WithEvents TbMines As Windows.Forms.TextBox
    Friend WithEvents Lbtmp As Windows.Forms.Label
    Friend WithEvents TbTmps As Windows.Forms.TextBox
    Friend WithEvents BtDesacTmp As Windows.Forms.CheckBox
End Class
