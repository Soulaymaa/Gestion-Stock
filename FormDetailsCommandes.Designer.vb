<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetailsCommandes
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
        Me.LblDate = New System.Windows.Forms.Label()
        Me.LblCommande = New System.Windows.Forms.Label()
        Me.LblClient = New System.Windows.Forms.Label()
        Me.LblAdresse = New System.Windows.Forms.Label()
        Me.LblTVA = New System.Windows.Forms.Label()
        Me.LblRemise = New System.Windows.Forms.Label()
        Me.LblPort = New System.Windows.Forms.Label()
        Me.DataGrid = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblProduit = New System.Windows.Forms.Label()
        Me.LblQuantite = New System.Windows.Forms.Label()
        Me.LblPU = New System.Windows.Forms.Label()
        Me.TxtCommande = New System.Windows.Forms.TextBox()
        Me.TxtClient = New System.Windows.Forms.TextBox()
        Me.TxtAdresse = New System.Windows.Forms.TextBox()
        Me.TxtTVA = New System.Windows.Forms.TextBox()
        Me.TxtRemise = New System.Windows.Forms.TextBox()
        Me.TxtPort = New System.Windows.Forms.TextBox()
        Me.DateTime = New System.Windows.Forms.DateTimePicker()
        Me.LblTotalBrut = New System.Windows.Forms.Label()
        Me.LblNet = New System.Windows.Forms.Label()
        Me.CboProduit = New System.Windows.Forms.ComboBox()
        Me.TxtTotalBrut = New System.Windows.Forms.TextBox()
        Me.TxtNet = New System.Windows.Forms.TextBox()
        Me.TxtQuantite = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CboPU = New System.Windows.Forms.ComboBox()
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblDate
        '
        Me.LblDate.AutoSize = True
        Me.LblDate.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDate.Location = New System.Drawing.Point(172, 17)
        Me.LblDate.Name = "LblDate"
        Me.LblDate.Size = New System.Drawing.Size(44, 17)
        Me.LblDate.TabIndex = 0
        Me.LblDate.Text = "Date :"
        '
        'LblCommande
        '
        Me.LblCommande.AutoSize = True
        Me.LblCommande.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCommande.Location = New System.Drawing.Point(117, 47)
        Me.LblCommande.Name = "LblCommande"
        Me.LblCommande.Size = New System.Drawing.Size(103, 17)
        Me.LblCommande.TabIndex = 1
        Me.LblCommande.Text = "Commande n ° :"
        '
        'LblClient
        '
        Me.LblClient.AutoSize = True
        Me.LblClient.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblClient.Location = New System.Drawing.Point(129, 95)
        Me.LblClient.Name = "LblClient"
        Me.LblClient.Size = New System.Drawing.Size(49, 17)
        Me.LblClient.TabIndex = 2
        Me.LblClient.Text = "Client :"
        '
        'LblAdresse
        '
        Me.LblAdresse.AutoSize = True
        Me.LblAdresse.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAdresse.Location = New System.Drawing.Point(77, 143)
        Me.LblAdresse.Name = "LblAdresse"
        Me.LblAdresse.Size = New System.Drawing.Size(140, 17)
        Me.LblAdresse.TabIndex = 3
        Me.LblAdresse.Text = "Adresse de Livraison :"
        '
        'LblTVA
        '
        Me.LblTVA.AutoSize = True
        Me.LblTVA.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTVA.Location = New System.Drawing.Point(172, 185)
        Me.LblTVA.Name = "LblTVA"
        Me.LblTVA.Size = New System.Drawing.Size(43, 17)
        Me.LblTVA.TabIndex = 4
        Me.LblTVA.Text = "TVA :"
        '
        'LblRemise
        '
        Me.LblRemise.AutoSize = True
        Me.LblRemise.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRemise.Location = New System.Drawing.Point(327, 185)
        Me.LblRemise.Name = "LblRemise"
        Me.LblRemise.Size = New System.Drawing.Size(59, 17)
        Me.LblRemise.TabIndex = 5
        Me.LblRemise.Text = "Remise :"
        '
        'LblPort
        '
        Me.LblPort.AutoSize = True
        Me.LblPort.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPort.Location = New System.Drawing.Point(542, 185)
        Me.LblPort.Name = "LblPort"
        Me.LblPort.Size = New System.Drawing.Size(40, 17)
        Me.LblPort.TabIndex = 6
        Me.LblPort.Text = "Port :"
        '
        'DataGrid
        '
        Me.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.DataGrid.Location = New System.Drawing.Point(136, 223)
        Me.DataGrid.Name = "DataGrid"
        Me.DataGrid.Size = New System.Drawing.Size(642, 117)
        Me.DataGrid.TabIndex = 7
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
        'LblProduit
        '
        Me.LblProduit.AutoSize = True
        Me.LblProduit.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblProduit.Location = New System.Drawing.Point(121, 396)
        Me.LblProduit.Name = "LblProduit"
        Me.LblProduit.Size = New System.Drawing.Size(57, 17)
        Me.LblProduit.TabIndex = 8
        Me.LblProduit.Text = "Produit :"
        '
        'LblQuantite
        '
        Me.LblQuantite.AutoSize = True
        Me.LblQuantite.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblQuantite.Location = New System.Drawing.Point(117, 436)
        Me.LblQuantite.Name = "LblQuantite"
        Me.LblQuantite.Size = New System.Drawing.Size(65, 17)
        Me.LblQuantite.TabIndex = 9
        Me.LblQuantite.Text = "Quantité :"
        '
        'LblPU
        '
        Me.LblPU.AutoSize = True
        Me.LblPU.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPU.Location = New System.Drawing.Point(104, 470)
        Me.LblPU.Name = "LblPU"
        Me.LblPU.Size = New System.Drawing.Size(90, 17)
        Me.LblPU.TabIndex = 10
        Me.LblPU.Text = "Prix Unitaire :"
        '
        'TxtCommande
        '
        Me.TxtCommande.Location = New System.Drawing.Point(222, 47)
        Me.TxtCommande.Name = "TxtCommande"
        Me.TxtCommande.Size = New System.Drawing.Size(99, 20)
        Me.TxtCommande.TabIndex = 15
        '
        'TxtClient
        '
        Me.TxtClient.Location = New System.Drawing.Point(222, 94)
        Me.TxtClient.Name = "TxtClient"
        Me.TxtClient.Size = New System.Drawing.Size(191, 20)
        Me.TxtClient.TabIndex = 16
        '
        'TxtAdresse
        '
        Me.TxtAdresse.Location = New System.Drawing.Point(222, 143)
        Me.TxtAdresse.Name = "TxtAdresse"
        Me.TxtAdresse.Size = New System.Drawing.Size(401, 20)
        Me.TxtAdresse.TabIndex = 17
        '
        'TxtTVA
        '
        Me.TxtTVA.Location = New System.Drawing.Point(222, 182)
        Me.TxtTVA.Name = "TxtTVA"
        Me.TxtTVA.Size = New System.Drawing.Size(50, 20)
        Me.TxtTVA.TabIndex = 18
        '
        'TxtRemise
        '
        Me.TxtRemise.Location = New System.Drawing.Point(408, 182)
        Me.TxtRemise.Name = "TxtRemise"
        Me.TxtRemise.Size = New System.Drawing.Size(68, 20)
        Me.TxtRemise.TabIndex = 19
        '
        'TxtPort
        '
        Me.TxtPort.Location = New System.Drawing.Point(601, 182)
        Me.TxtPort.Name = "TxtPort"
        Me.TxtPort.Size = New System.Drawing.Size(56, 20)
        Me.TxtPort.TabIndex = 20
        '
        'DateTime
        '
        Me.DateTime.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTime.Location = New System.Drawing.Point(222, 13)
        Me.DateTime.Name = "DateTime"
        Me.DateTime.Size = New System.Drawing.Size(78, 20)
        Me.DateTime.TabIndex = 21
        '
        'LblTotalBrut
        '
        Me.LblTotalBrut.AutoSize = True
        Me.LblTotalBrut.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTotalBrut.Location = New System.Drawing.Point(577, 422)
        Me.LblTotalBrut.Name = "LblTotalBrut"
        Me.LblTotalBrut.Size = New System.Drawing.Size(71, 16)
        Me.LblTotalBrut.TabIndex = 22
        Me.LblTotalBrut.Text = "Total Brut :"
        '
        'LblNet
        '
        Me.LblNet.AutoSize = True
        Me.LblNet.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNet.Location = New System.Drawing.Point(598, 473)
        Me.LblNet.Name = "LblNet"
        Me.LblNet.Size = New System.Drawing.Size(35, 16)
        Me.LblNet.TabIndex = 23
        Me.LblNet.Text = "Net :"
        '
        'CboProduit
        '
        Me.CboProduit.FormattingEnabled = True
        Me.CboProduit.Location = New System.Drawing.Point(200, 392)
        Me.CboProduit.Name = "CboProduit"
        Me.CboProduit.Size = New System.Drawing.Size(236, 21)
        Me.CboProduit.TabIndex = 24
        '
        'TxtTotalBrut
        '
        Me.TxtTotalBrut.Location = New System.Drawing.Point(678, 422)
        Me.TxtTotalBrut.Name = "TxtTotalBrut"
        Me.TxtTotalBrut.Size = New System.Drawing.Size(100, 20)
        Me.TxtTotalBrut.TabIndex = 25
        '
        'TxtNet
        '
        Me.TxtNet.Location = New System.Drawing.Point(678, 471)
        Me.TxtNet.Name = "TxtNet"
        Me.TxtNet.Size = New System.Drawing.Size(100, 20)
        Me.TxtNet.TabIndex = 26
        '
        'TxtQuantite
        '
        Me.TxtQuantite.Location = New System.Drawing.Point(200, 433)
        Me.TxtQuantite.Name = "TxtQuantite"
        Me.TxtQuantite.Size = New System.Drawing.Size(100, 20)
        Me.TxtQuantite.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(132, 525)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 20)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Enreg cmde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(268, 525)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 20)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "Annuler cmde"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(419, 525)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(123, 20)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Nouvelle cmde"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(681, 525)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Quitter"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(585, 525)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Retour"
        '
        'CboPU
        '
        Me.CboPU.FormattingEnabled = True
        Me.CboPU.Location = New System.Drawing.Point(200, 470)
        Me.CboPU.Name = "CboPU"
        Me.CboPU.Size = New System.Drawing.Size(99, 21)
        Me.CboPU.TabIndex = 34
        '
        'FormDetailsCommandes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(891, 571)
        Me.Controls.Add(Me.CboPU)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtQuantite)
        Me.Controls.Add(Me.TxtNet)
        Me.Controls.Add(Me.TxtTotalBrut)
        Me.Controls.Add(Me.CboProduit)
        Me.Controls.Add(Me.LblNet)
        Me.Controls.Add(Me.LblTotalBrut)
        Me.Controls.Add(Me.DateTime)
        Me.Controls.Add(Me.TxtPort)
        Me.Controls.Add(Me.TxtRemise)
        Me.Controls.Add(Me.TxtTVA)
        Me.Controls.Add(Me.TxtAdresse)
        Me.Controls.Add(Me.TxtClient)
        Me.Controls.Add(Me.TxtCommande)
        Me.Controls.Add(Me.LblPU)
        Me.Controls.Add(Me.LblQuantite)
        Me.Controls.Add(Me.LblProduit)
        Me.Controls.Add(Me.DataGrid)
        Me.Controls.Add(Me.LblPort)
        Me.Controls.Add(Me.LblRemise)
        Me.Controls.Add(Me.LblTVA)
        Me.Controls.Add(Me.LblAdresse)
        Me.Controls.Add(Me.LblClient)
        Me.Controls.Add(Me.LblCommande)
        Me.Controls.Add(Me.LblDate)
        Me.Name = "FormDetailsCommandes"
        Me.Text = "Ecran: DETAIL DES COMMANDES D'UN CLIENT"
        CType(Me.DataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblDate As System.Windows.Forms.Label
    Friend WithEvents LblCommande As System.Windows.Forms.Label
    Friend WithEvents LblClient As System.Windows.Forms.Label
    Friend WithEvents LblAdresse As System.Windows.Forms.Label
    Friend WithEvents LblTVA As System.Windows.Forms.Label
    Friend WithEvents LblRemise As System.Windows.Forms.Label
    Friend WithEvents LblPort As System.Windows.Forms.Label
    Friend WithEvents DataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents LblProduit As System.Windows.Forms.Label
    Friend WithEvents LblQuantite As System.Windows.Forms.Label
    Friend WithEvents LblPU As System.Windows.Forms.Label
    Friend WithEvents TxtCommande As System.Windows.Forms.TextBox
    Friend WithEvents TxtClient As System.Windows.Forms.TextBox
    Friend WithEvents TxtAdresse As System.Windows.Forms.TextBox
    Friend WithEvents TxtTVA As System.Windows.Forms.TextBox
    Friend WithEvents TxtRemise As System.Windows.Forms.TextBox
    Friend WithEvents TxtPort As System.Windows.Forms.TextBox
    Friend WithEvents DateTime As System.Windows.Forms.DateTimePicker
    Friend WithEvents LblTotalBrut As System.Windows.Forms.Label
    Friend WithEvents LblNet As System.Windows.Forms.Label
    Friend WithEvents CboProduit As System.Windows.Forms.ComboBox
    Friend WithEvents TxtTotalBrut As System.Windows.Forms.TextBox
    Friend WithEvents TxtNet As System.Windows.Forms.TextBox
    Friend WithEvents TxtQuantite As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CboPU As System.Windows.Forms.ComboBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
