Public Class ListesFournisseurs

    Private Sub ListesFournisseurs(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)
        Call AfficherFournisseurs()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGrid_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Visible = False
        FormMenuGeneral.Visible = True
    End Sub
End Class