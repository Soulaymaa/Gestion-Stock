Public Class FormCommandeAchat

    Private Sub DateTime_ValueChanged(sender As System.Object, e As System.EventArgs) Handles DateTime.ValueChanged

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click
        If TxtCommande.Text = "" Or TxtFrs.Text = "" Or TxtPort.Text = "" Or TxtRemise.Text = "" Or TxtQuantite.Text = "" Or TxtTVA.Text = "" Then
            MsgBox("Veuillez renseigner tous les champs", vbYesNo, "Error")
        Else
            Call Commander()
            Call Vid()
        End If
    End Sub

    Private Sub CboProduit_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub TxtQuantite_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtQuantite.TextChanged

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click
        Call Vid()
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click
        Call Vid()
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click
        Call Vid()
        Me.Visible = False
        FormMenuGeneral.Visible = True
    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click
        Close()
    End Sub

    Private Sub LblEsc_Click(sender As System.Object, e As System.EventArgs)

    End Sub
End Class