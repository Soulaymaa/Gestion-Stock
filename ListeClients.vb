Public Class ListeClients

    Private Sub ListeClients_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call AfficherClients()
    End Sub

    Private Sub OK_Click(sender As System.Object, e As System.EventArgs) Handles OK.Click
        Me.Visible = False
        FormMenuGeneral.Visible = True
    End Sub

    Private Sub DataGrid_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellContentClick

    End Sub
End Class