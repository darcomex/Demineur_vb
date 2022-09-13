<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Jeu
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
        Me.components = New System.ComponentModel.Container()
        Me.PnlBtns = New System.Windows.Forms.Panel()
        Me.LbNom = New System.Windows.Forms.Label()
        Me.BtAband = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LbTmp = New System.Windows.Forms.Label()
        Me.BtPause = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LbTriche = New System.Windows.Forms.Label()
        Me.PnlBtns.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnlBtns
        '
        Me.PnlBtns.Controls.Add(Me.Panel1)
        Me.PnlBtns.Location = New System.Drawing.Point(13, 25)
        Me.PnlBtns.Name = "PnlBtns"
        Me.PnlBtns.Size = New System.Drawing.Size(605, 600)
        Me.PnlBtns.TabIndex = 0
        '
        'LbNom
        '
        Me.LbNom.AutoSize = True
        Me.LbNom.Location = New System.Drawing.Point(12, 9)
        Me.LbNom.Name = "LbNom"
        Me.LbNom.Size = New System.Drawing.Size(39, 13)
        Me.LbNom.TabIndex = 1
        Me.LbNom.Text = "Label1"
        '
        'BtAband
        '
        Me.BtAband.Location = New System.Drawing.Point(725, 588)
        Me.BtAband.Name = "BtAband"
        Me.BtAband.Size = New System.Drawing.Size(114, 37)
        Me.BtAband.TabIndex = 2
        Me.BtAband.Text = "Abandonner"
        Me.BtAband.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'LbTmp
        '
        Me.LbTmp.AutoSize = True
        Me.LbTmp.Location = New System.Drawing.Point(159, 9)
        Me.LbTmp.Name = "LbTmp"
        Me.LbTmp.Size = New System.Drawing.Size(39, 13)
        Me.LbTmp.TabIndex = 3
        Me.LbTmp.Text = "Label1"
        '
        'BtPause
        '
        Me.BtPause.Location = New System.Drawing.Point(716, 25)
        Me.BtPause.Name = "BtPause"
        Me.BtPause.Size = New System.Drawing.Size(134, 50)
        Me.BtPause.TabIndex = 4
        Me.BtPause.Text = "Pause"
        Me.BtPause.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LbTriche)
        Me.Panel1.Location = New System.Drawing.Point(-1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(619, 619)
        Me.Panel1.TabIndex = 0
        '
        'LbTriche
        '
        Me.LbTriche.AutoSize = True
        Me.LbTriche.Font = New System.Drawing.Font("Microsoft YaHei", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbTriche.Location = New System.Drawing.Point(110, 280)
        Me.LbTriche.Name = "LbTriche"
        Me.LbTriche.Size = New System.Drawing.Size(388, 26)
        Me.LbTriche.TabIndex = 0
        Me.LbTriche.Text = "NON ON TRICHE PAS AVEC LA PAUSE !"
        '
        'Jeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 656)
        Me.Controls.Add(Me.BtPause)
        Me.Controls.Add(Me.LbTmp)
        Me.Controls.Add(Me.BtAband)
        Me.Controls.Add(Me.LbNom)
        Me.Controls.Add(Me.PnlBtns)
        Me.Name = "Jeu"
        Me.Text = "Jeu"
        Me.PnlBtns.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PnlBtns As Windows.Forms.Panel
    Friend WithEvents LbNom As Windows.Forms.Label
    Friend WithEvents BtAband As Windows.Forms.Button
    Friend WithEvents Timer1 As Windows.Forms.Timer
    Friend WithEvents LbTmp As Windows.Forms.Label
    Friend WithEvents BtPause As Windows.Forms.Button
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents LbTriche As Windows.Forms.Label
End Class
