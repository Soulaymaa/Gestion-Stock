﻿Public Class ReglementCommandes

    Private Sub ReglementCommandes_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call AfficherDetailsVente()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Visible = False
        FormMenuGeneral.Visible = True
    End Sub

    Private Sub DataGrid_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGrid.CellContentClick

    End Sub
End Class