<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormConnection
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
        Me.Lbllogin = New System.Windows.Forms.Label()
        Me.Lblmdp = New System.Windows.Forms.Label()
        Me.Txtlogin = New System.Windows.Forms.TextBox()
        Me.Txtmdp = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LblReessayer = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Lbllogin
        '
        Me.Lbllogin.AutoSize = True
        Me.Lbllogin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbllogin.Location = New System.Drawing.Point(61, 89)
        Me.Lbllogin.Name = "Lbllogin"
        Me.Lbllogin.Size = New System.Drawing.Size(50, 19)
        Me.Lbllogin.TabIndex = 0
        Me.Lbllogin.Text = "Login :"
        '
        'Lblmdp
        '
        Me.Lblmdp.AutoSize = True
        Me.Lblmdp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lblmdp.Location = New System.Drawing.Point(12, 135)
        Me.Lblmdp.Name = "Lblmdp"
        Me.Lblmdp.Size = New System.Drawing.Size(99, 19)
        Me.Lblmdp.TabIndex = 1
        Me.Lblmdp.Text = "Mot de passe :"
        '
        'Txtlogin
        '
        Me.Txtlogin.Location = New System.Drawing.Point(128, 88)
        Me.Txtlogin.Name = "Txtlogin"
        Me.Txtlogin.Size = New System.Drawing.Size(208, 20)
        Me.Txtlogin.TabIndex = 2
        '
        'Txtmdp
        '
        Me.Txtmdp.Location = New System.Drawing.Point(128, 136)
        Me.Txtmdp.Name = "Txtmdp"
        Me.Txtmdp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.Txtmdp.Size = New System.Drawing.Size(208, 20)
        Me.Txtmdp.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Green
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(128, 181)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(82, 31)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(233, 181)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(103, 31)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Annuler"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'LblReessayer
        '
        Me.LblReessayer.AutoSize = True
        Me.LblReessayer.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblReessayer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LblReessayer.Location = New System.Drawing.Point(12, 27)
        Me.LblReessayer.Name = "LblReessayer"
        Me.LblReessayer.Size = New System.Drawing.Size(230, 18)
        Me.LblReessayer.TabIndex = 6
        Me.LblReessayer.Text = "Entrer votre login et mot de passe"
        '
        'FormConnection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(444, 282)
        Me.Controls.Add(Me.LblReessayer)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Txtmdp)
        Me.Controls.Add(Me.Txtlogin)
        Me.Controls.Add(Me.Lblmdp)
        Me.Controls.Add(Me.Lbllogin)
        Me.Name = "FormConnection"
        Me.Text = "Identifiez-vous SVP"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbllogin As System.Windows.Forms.Label
    Friend WithEvents Lblmdp As System.Windows.Forms.Label
    Friend WithEvents Txtlogin As System.Windows.Forms.TextBox
    Friend WithEvents Txtmdp As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents LblReessayer As System.Windows.Forms.Label
End Class
