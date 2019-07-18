<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCommandeAchat
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtQuantite = New System.Windows.Forms.TextBox()
        Me.TxtNet = New System.Windows.Forms.TextBox()
        Me.TxtTotalBrut = New System.Windows.Forms.TextBox()
        Me.LblNet = New System.Windows.Forms.Label()
        Me.LblTotalBrut = New System.Windows.Forms.Label()
        Me.DateTime = New System.Windows.Forms.DateTimePicker()
        Me.TxtPort = New System.Windows.Forms.TextBox()
        Me.TxtRemise = New System.Windows.Forms.TextBox()
        Me.TxtTVA = New System.Windows.Forms.TextBox()
        Me.TxtFrs = New System.Windows.Forms.TextBox()
        Me.TxtCommande = New System.Windows.Forms.TextBox()
        Me.LblPU = New System.Windows.Forms.Label()
        Me.LblQuantite = New System.Windows.Forms.Label()
        Me.LblProduit = New System.Windows.Forms.Label()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblPort = New System.Windows.Forms.Label()
        Me.LblRemise = New System.Windows.Forms.Label()
        Me.LblTVA = New System.Windows.Forms.Label()
        Me.LblClient = New System.Windows.Forms.Label()
        Me.LblCommande = New System.Windows.Forms.Label()
        Me.LblDate = New System.Windows.Forms.Label()
        Me.TxtPrd = New System.Windows.Forms.TextBox()
        Me.TxtPu = New System.Windows.Forms.TextBox()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(676, 530)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Retour"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(813, 530)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "Quitter"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(434, 530)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 20)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Nouvelle cmde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(235, 530)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 20)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Annuler cmde"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(58, 530)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Enreg cmde"
        '
        'TxtQuantite
        '
        Me.TxtQuantite.Location = New System.Drawing.Point(215, 454)
        Me.TxtQuantite.Name = "TxtQuantite"
        Me.TxtQuantite.Size = New System.Drawing.Size(100, 20)
        Me.TxtQuantite.TabIndex = 62
        '
        'TxtNet
        '
        Me.TxtNet.Location = New System.Drawing.Point(591, 454)
        Me.TxtNet.Name = "TxtNet"
        Me.TxtNet.Size = New System.Drawing.Size(100, 20)
        Me.TxtNet.TabIndex = 61
        '
        'TxtTotalBrut
        '
        Me.TxtTotalBrut.Location = New System.Drawing.Point(591, 402)
        Me.TxtTotalBrut.Name = "TxtTotalBrut"
        Me.TxtTotalBrut.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotalBrut.TabIndex = 60
        '
        'LblNet
        '
        Me.LblNet.AutoSize = True
        Me.LblNet.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNet.Location = New System.Drawing.Point(522, 458)
        Me.LblNet.Name = "LblNet"
        Me.LblNet.Size = New System.Drawing.Size(35, 16)
        Me.LblNet.TabIndex = 58
        Me.LblNet.Text = "Net :"
        '
        'LblTotalBrut
        '
        Me.LblTotalBrut.AutoSize = True
        Me.LblTotalBrut.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalBrut.Location = New System.Drawing.Point(496, 406)
        Me.LblTotalBrut.Name = "LblTotalBrut"
        Me.LblTotalBrut.Size = New System.Drawing.Size(71, 16)
        Me.LblTotalBrut.TabIndex = 57
        Me.LblTotalBrut.Text = "Total Brut :"
        '
        'DateTime
        '
        Me.DateTime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTime.Location = New System.Drawing.Point(254, 22)
        Me.DateTime.Name = "DateTime"
        Me.DateTime.Size = New System.Drawing.Size(78, 20)
        Me.DateTime.TabIndex = 56
        '
        'TxtPort
        '
        Me.TxtPort.Location = New System.Drawing.Point(616, 178)
        Me.TxtPort.Name = "TxtPort"
        Me.TxtPort.Size = New System.Drawing.Size(56, 20)
        Me.TxtPort.TabIndex = 55
        '
        'TxtRemise
        '
        Me.TxtRemise.Location = New System.Drawing.Point(423, 178)
        Me.TxtRemise.Name = "TxtRemise"
        Me.TxtRemise.Size = New System.Drawing.Size(68, 20)
        Me.TxtRemise.TabIndex = 54
        '
        'TxtTVA
        '
        Me.TxtTVA.Location = New System.Drawing.Point(254, 174)
        Me.TxtTVA.Name = "TxtTVA"
        Me.TxtTVA.Size = New System.Drawing.Size(50, 20)
        Me.TxtTVA.TabIndex = 53
        '
        'TxtFrs
        '
        Me.TxtFrs.Location = New System.Drawing.Point(254, 118)
        Me.TxtFrs.Name = "TxtFrs"
        Me.TxtFrs.Size = New System.Drawing.Size(191, 20)
        Me.TxtFrs.TabIndex = 51
        '
        'TxtCommande
        '
        Me.TxtCommande.Location = New System.Drawing.Point(254, 72)
        Me.TxtCommande.Name = "TxtCommande"
        Me.TxtCommande.Size = New System.Drawing.Size(99, 20)
        Me.TxtCommande.TabIndex = 50
        '
        'LblPU
        '
        Me.LblPU.AutoSize = True
        Me.LblPU.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPU.Location = New System.Drawing.Point(119, 495)
        Me.LblPU.Name = "LblPU"
        Me.LblPU.Size = New System.Drawing.Size(90, 17)
        Me.LblPU.TabIndex = 45
        Me.LblPU.Text = "Prix Unitaire :"
        '
        'LblQuantite
        '
        Me.LblQuantite.AutoSize = True
        Me.LblQuantite.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuantite.Location = New System.Drawing.Point(136, 453)
        Me.LblQuantite.Name = "LblQuantite"
        Me.LblQuantite.Size = New System.Drawing.Size(65, 17)
        Me.LblQuantite.TabIndex = 44
        Me.LblQuantite.Text = "Quantité :"
        '
        'LblProduit
        '
        Me.LblProduit.AutoSize = True
        Me.LblProduit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProduit.Location = New System.Drawing.Point(144, 409)
        Me.LblProduit.Name = "LblProduit"
        Me.LblProduit.Size = New System.Drawing.Size(57, 17)
        Me.LblProduit.TabIndex = 43
        Me.LblProduit.Text = "Produit :"
        '
        'DataGrid
        '
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGrid.Location = New System.Drawing.Point(151, 228)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.Size = New System.Drawing.Size(642, 117)
        Me.DataGrid.TabIndex = 42
        '
        'Column1
        '
        Me.Column1.HeaderText = "Produit"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Quantité"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Prix Unitaire"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Montant"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Numero Commande"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Designation"
        Me.Column6.Name = "Column6"
        '
        'LblPort
        '
        Me.LblPort.AutoSize = True
        Me.LblPort.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPort.Location = New System.Drawing.Point(557, 181)
        Me.LblPort.Name = "LblPort"
        Me.LblPort.Size = New System.Drawing.Size(40, 17)
        Me.LblPort.TabIndex = 41
        Me.LblPort.Text = "Port :"
        '
        'LblRemise
        '
        Me.LblRemise.AutoSize = True
        Me.LblRemise.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRemise.Location = New System.Drawing.Point(342, 178)
        Me.LblRemise.Name = "LblRemise"
        Me.LblRemise.Size = New System.Drawing.Size(59, 17)
        Me.LblRemise.TabIndex = 40
        Me.LblRemise.Text = "Remise :"
        '
        'LblTVA
        '
        Me.LblTVA.AutoSize = True
        Me.LblTVA.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTVA.Location = New System.Drawing.Point(144, 175)
        Me.LblTVA.Name = "LblTVA"
        Me.LblTVA.Size = New System.Drawing.Size(43, 17)
        Me.LblTVA.TabIndex = 39
        Me.LblTVA.Text = "TVA :"
        '
        'LblClient
        '
        Me.LblClient.AutoSize = True
        Me.LblClient.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClient.Location = New System.Drawing.Point(144, 119)
        Me.LblClient.Name = "LblClient"
        Me.LblClient.Size = New System.Drawing.Size(83, 17)
        Me.LblClient.TabIndex = 37
        Me.LblClient.Text = "Fournisseur :"
        '
        'LblCommande
        '
        Me.LblCommande.AutoSize = True
        Me.LblCommande.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCommande.Location = New System.Drawing.Point(144, 75)
        Me.LblCommande.Name = "LblCommande"
        Me.LblCommande.Size = New System.Drawing.Size(103, 17)
        Me.LblCommande.TabIndex = 36
        Me.LblCommande.Text = "Commande n ° :"
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDate.Location = New System.Drawing.Point(148, 22)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(44, 17)
        Me.LblDate.TabIndex = 35
        Me.LblDate.Text = "Date :"
        '
        'TxtPrd
        '
        Me.TxtPrd.Location = New System.Drawing.Point(215, 406)
        Me.TxtPrd.Name = "TxtPrd"
        Me.TxtPrd.Size = New System.Drawing.Size(100, 20)
        Me.TxtPrd.TabIndex = 68
        '
        'TxtPu
        '
        Me.TxtPu.Location = New System.Drawing.Point(215, 492)
        Me.TxtPu.Name = "TxtPu"
        Me.TxtPu.Size = New System.Drawing.Size(100, 20)
        Me.TxtPu.TabIndex = 69
        '
        'FormCommandeAchat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 569)
        Me.Controls.Add(Me.TxtPu)
        Me.Controls.Add(Me.TxtPrd)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtQuantite)
        Me.Controls.Add(Me.TxtNet)
        Me.Controls.Add(Me.TxtTotalBrut)
        Me.Controls.Add(Me.LblNet)
        Me.Controls.Add(Me.LblTotalBrut)
        Me.Controls.Add(Me.DateTime)
        Me.Controls.Add(Me.TxtPort)
        Me.Controls.Add(Me.TxtRemise)
        Me.Controls.Add(Me.TxtTVA)
        Me.Controls.Add(Me.TxtFrs)
        Me.Controls.Add(Me.TxtCommande)
        Me.Controls.Add(Me.LblPU)
        Me.Controls.Add(Me.LblQuantite)
        Me.Controls.Add(Me.LblProduit)
        Me.Controls.Add(Me.DataGrid)
        Me.Controls.Add(Me.LblPort)
        Me.Controls.Add(Me.LblRemise)
        Me.Controls.Add(Me.LblTVA)
        Me.Controls.Add(Me.LblClient)
        Me.Controls.Add(Me.LblCommande)
        Me.Controls.Add(Me.LblDate)
        Me.Name = "FormCommandeAchat"
        Me.Text = "ecran : DETAILS DES COMMANDES AUPRES D'UN FORUNISSEUR"
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtQuantite As System.Windows.Forms.TextBox
    Friend WithEvents TxtNet As System.Windows.Forms.TextBox
    Friend WithEvents TxtTotalBrut As System.Windows.Forms.TextBox
    Friend WithEvents LblNet As System.Windows.Forms.Label
    Friend WithEvents LblTotalBrut As System.Windows.Forms.Label
    Friend WithEvents DateTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents TxtPort As System.Windows.Forms.TextBox
    Friend WithEvents TxtRemise As System.Windows.Forms.TextBox
    Friend WithEvents TxtTVA As System.Windows.Forms.TextBox
    Friend WithEvents TxtFrs As System.Windows.Forms.TextBox
    Friend WithEvents TxtCommande As System.Windows.Forms.TextBox
    Friend WithEvents LblPU As System.Windows.Forms.Label
    Friend WithEvents LblQuantite As System.Windows.Forms.Label
    Friend WithEvents LblProduit As System.Windows.Forms.Label
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LblPort As System.Windows.Forms.Label
    Friend WithEvents LblRemise As System.Windows.Forms.Label
    Friend WithEvents LblTVA As System.Windows.Forms.Label
    Friend WithEvents LblClient As System.Windows.Forms.Label
    Friend WithEvents LblCommande As System.Windows.Forms.Label
    Friend WithEvents LblDate As System.Windows.Forms.Label
    Friend WithEvents TxtPrd As System.Windows.Forms.TextBox
    Friend WithEvents TxtPu As System.Windows.Forms.TextBox
End Class
