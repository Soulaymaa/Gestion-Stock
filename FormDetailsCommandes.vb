Public Class FormDetailsCommandes

    Private Sub LblClient_Click(sender As System.Object, e As System.EventArgs) Handles LblClient.Click

    End Sub

    Private Sub LblPort_Click(sender As System.Object, e As System.EventArgs) Handles LblPort.Click

    End Sub

    Private Sub LblTVA_Click(sender As System.Object, e As System.EventArgs) Handles LblTVA.Click

    End Sub

    Private Sub LblF3_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub LblF2_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub LblPU_Click(sender As System.Object, e As System.EventArgs) Handles LblPU.Click

    End Sub

    Private Sub TextBox9_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtQuantite.TextChanged

    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click
        Close()
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click
        If TxtCommande.Text = "" Or TxtAdresse.Text = "" Or TxtClient.Text = "" Or TxtPort.Text = "" Or TxtRemise.Text = "" Or TxtQuantite.Text = "" Or TxtTVA.Text = "" Then
            MsgBox("Veuillez renseigner tous les champs", vbYesNo, "Error")
        Else
            Call Ajouter()
            Call Vider()
        End If
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click
        Call Vider()
    End Sub

    Private Sub FormDetailsCommandes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call ChargerProduit()
        Call afficherVente()
        TxtTVA.Text = "0.18"
        TxtTVA.Enabled = False

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        Me.Visible = False
        FormMenuGeneral.Visible = True
    End Sub

    Private Sub DataGrid_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellContentClick
        Call chargerTotalBrutNet()
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        Call Vider()
    End Sub

    Private Sub CboProduit_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CboProduit.SelectedIndexChanged
        Call ChargerPrixUnitaire()
    End Sub

    Private Sub TxtPU_TextChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TxtNet_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtNet.TextChanged

    End Sub

    Private Sub TxtTotalBrut_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtTotalBrut.TextChanged

    End Sub

    Private Sub CboPU_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CboPU.SelectedIndexChanged

    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TxtClient_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtClient.TextChanged

    End Sub

    Private Sub DateTime_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTime.ValueChanged

    End Sub

    Private Sub LblF7_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class