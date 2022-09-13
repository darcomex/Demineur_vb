<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Theme
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RbDarkGr = New System.Windows.Forms.RadioButton()
        Me.RbDarkOr = New System.Windows.Forms.RadioButton()
        Me.RbLight = New System.Windows.Forms.RadioButton()
        Me.BtConfirm = New System.Windows.Forms.Button()
        Me.RbDarkPu = New System.Windows.Forms.RadioButton()
        Me.RbDarkBl = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.RbDarkBl)
        Me.Panel1.Controls.Add(Me.RbDarkPu)
        Me.Panel1.Controls.Add(Me.RbDarkGr)
        Me.Panel1.Controls.Add(Me.RbDarkOr)
        Me.Panel1.Controls.Add(Me.RbLight)
        Me.Panel1.Location = New System.Drawing.Point(66, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(122, 190)
        Me.Panel1.TabIndex = 0
        '
        'RbDarkGr
        '
        Me.RbDarkGr.AutoSize = True
        Me.RbDarkGr.Location = New System.Drawing.Point(27, 91)
        Me.RbDarkGr.Name = "RbDarkGr"
        Me.RbDarkGr.Size = New System.Drawing.Size(77, 17)
        Me.RbDarkGr.TabIndex = 2
        Me.RbDarkGr.Text = "DarkGreen"
        Me.RbDarkGr.UseVisualStyleBackColor = True
        '
        'RbDarkOr
        '
        Me.RbDarkOr.AutoSize = True
        Me.RbDarkOr.Location = New System.Drawing.Point(27, 54)
        Me.RbDarkOr.Name = "RbDarkOr"
        Me.RbDarkOr.Size = New System.Drawing.Size(83, 17)
        Me.RbDarkOr.TabIndex = 1
        Me.RbDarkOr.Text = "DarkOrange"
        Me.RbDarkOr.UseVisualStyleBackColor = True
        '
        'RbLight
        '
        Me.RbLight.AutoSize = True
        Me.RbLight.Checked = True
        Me.RbLight.Location = New System.Drawing.Point(27, 18)
        Me.RbLight.Name = "RbLight"
        Me.RbLight.Size = New System.Drawing.Size(48, 17)
        Me.RbLight.TabIndex = 0
        Me.RbLight.TabStop = True
        Me.RbLight.Text = "Light"
        Me.RbLight.UseVisualStyleBackColor = True
        '
        'BtConfirm
        '
        Me.BtConfirm.Location = New System.Drawing.Point(80, 248)
        Me.BtConfirm.Name = "BtConfirm"
        Me.BtConfirm.Size = New System.Drawing.Size(108, 28)
        Me.BtConfirm.TabIndex = 1
        Me.BtConfirm.Text = "CONFIRMER"
        Me.BtConfirm.UseVisualStyleBackColor = True
        '
        'RbDarkPu
        '
        Me.RbDarkPu.AutoSize = True
        Me.RbDarkPu.Location = New System.Drawing.Point(27, 129)
        Me.RbDarkPu.Name = "RbDarkPu"
        Me.RbDarkPu.Size = New System.Drawing.Size(78, 17)
        Me.RbDarkPu.TabIndex = 3
        Me.RbDarkPu.Text = "DarkPurple"
        Me.RbDarkPu.UseVisualStyleBackColor = True
        '
        'RbDarkBl
        '
        Me.RbDarkBl.AutoSize = True
        Me.RbDarkBl.Location = New System.Drawing.Point(26, 166)
        Me.RbDarkBl.Name = "RbDarkBl"
        Me.RbDarkBl.Size = New System.Drawing.Size(69, 17)
        Me.RbDarkBl.TabIndex = 4
        Me.RbDarkBl.Text = "DarkBlue"
        Me.RbDarkBl.UseVisualStyleBackColor = True
        '
        'Theme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(268, 358)
        Me.Controls.Add(Me.BtConfirm)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Theme"
        Me.Text = "Theme"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents RbDarkGr As Windows.Forms.RadioButton
    Friend WithEvents RbDarkOr As Windows.Forms.RadioButton
    Friend WithEvents RbLight As Windows.Forms.RadioButton
    Friend WithEvents BtConfirm As Windows.Forms.Button
    Friend WithEvents RbDarkPu As Windows.Forms.RadioButton
    Friend WithEvents RbDarkBl As Windows.Forms.RadioButton
End Class
