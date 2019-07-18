Public Class FormMenuGeneral

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint
        

    End Sub

    Private Sub lblCmd_Click(sender As System.Object, e As System.EventArgs) Handles lblCmd.Click

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        Me.Visible = False
        CommandesClients.Visible = True
    End Sub

    Private Sub Panel3_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles Label7.Click
        Close()
    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click
        Me.Visible() = False
        FormConnection.Visible() = True
    End Sub

    Private Sub FormMenuGeneral_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Lbl1.Enabled = False
        Label1.Enabled = False
        Label2.Enabled = False
        Label3.Enabled = False
        Label4.Enabled = False
        Label5.Enabled = False
        Label8.Enabled = False
        Label9.Enabled = False
        Label10.Enabled = False

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click
        Me.Visible = False
        FormDetailsCommandes.Visible = True
    End Sub

    Private Sub Lbl1_Click(sender As System.Object, e As System.EventArgs) Handles Lbl1.Click
        Me.Visible = False
        ListeClients.Visible = True
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        Me.Visible = False
        Listes_Produits.Visible = True
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click
        Me.Visible = False
        ReglementCommandes.Visible = True
    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs)
        Me.Visible = False
        ReglementCommandes.Visible = True
    End Sub

    Private Sub Label8_Click(sender As System.Object, e As System.EventArgs) Handles Label8.Click
        Me.Visible = False
        ListesFournisseurs.Visible = True
    End Sub

    Private Sub Label5_Click_1(sender As System.Object, e As System.EventArgs) Handles Label5.Click
        Me.Visible = False
        ReglementCmdFrs.Visible = True
    End Sub

    Private Sub Label10_Click(sender As System.Object, e As System.EventArgs) Handles Label10.Click
        Me.Visible = False
        CommandeFournisseur.Visible = True
    End Sub

    Private Sub Label9_Click(sender As System.Object, e As System.EventArgs) Handles Label9.Click
        Me.Visible = False
        FormCommandeAchat.Visible = True
    End Sub
End Class
