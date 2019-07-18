Public Class ReglementCmdFrs
    Private Sub ReglementCmdFrs_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call AfficherDetailsAchat()
    End Sub
    Private Sub DataGrid_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellContentClick

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Visible = False
        FormMenuGeneral.Visible = True
    End Sub
End Class