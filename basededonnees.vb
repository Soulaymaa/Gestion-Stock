Imports MySql.Data.MySqlClient
Module basededonnees
    Sub Ajouter()
        'sql = " select * from clients where nomClient = '" & FormDetailsCommandes.TxtClient.Text '" "
        slt = FormDetailsCommandes.CboProduit.Text
        Call etabliconection()
        sql = " select * from produit where designation = '" & slt & "'"
        cmd.Connection = cn
        cmd.CommandText = sql
        data = cmd.ExecuteReader
        If data.Read = True Then
            slt = data(1)
            'MsgBox(slt)
        End If
        data.Close()

        ' If data.Read = True Then
        sql = " insert into commandesVente values ('" & FormDetailsCommandes.TxtCommande.Text & "','" & FormDetailsCommandes.DateTime.Text & "','" & FormDetailsCommandes.TxtClient.Text & "')"
        cmd.CommandText = sql
        data = cmd.ExecuteReader
        data.Close()
        sql = " insert into detailsVente values ('" & FormDetailsCommandes.TxtCommande.Text & "','" & slt & "','" & FormDetailsCommandes.TxtQuantite.Text & "', '" & FormDetailsCommandes.CboPU.Text & "', '" & FormDetailsCommandes.DateTime.Text & "','" & FormDetailsCommandes.TxtTVA.Text & "','" & FormDetailsCommandes.TxtRemise.Text & "','" & FormDetailsCommandes.TxtPort.Text & "','" & FormDetailsCommandes.TxtClient.Text & "', '" & FormDetailsCommandes.TxtAdresse.Text & "','" & FormDetailsCommandes.CboPU.Text & "')"
        cmd.CommandText = sql
        data = cmd.ExecuteReader
        data.Close()
        MsgBox("Insertion reussie!!!")
        'End If
        data.Close()
        FormDetailsCommandes.DataGrid.Rows.Clear()
        Call afficherVente()
        FormDetailsCommandes.TxtTVA.Text = "0.18"
        FormDetailsCommandes.TxtTVA.Enabled = False


    End Sub
    Sub Vider()
        FormDetailsCommandes.TxtCommande.Text = ""
        FormDetailsCommandes.DateTime.Text = ""
        FormDetailsCommandes.CboProduit.Text = ""
        FormDetailsCommandes.CboPU.Text = ""
        FormDetailsCommandes.TxtQuantite.Text = ""
        FormDetailsCommandes.TxtRemise.Text = ""
        FormDetailsCommandes.TxtClient.Text = ""
        FormDetailsCommandes.TxtAdresse.Text = ""
        FormDetailsCommandes.TxtPort.Text = ""


    End Sub
    Sub Vid()
        FormCommandeAchat.TxtCommande.Text = ""
        FormCommandeAchat.DateTime.Text = ""
        FormCommandeAchat.TxtPu.Text = ""
        FormCommandeAchat.TxtPrd.Text = ""
        FormCommandeAchat.TxtQuantite.Text = ""
        FormCommandeAchat.TxtRemise.Text = ""
        FormDetailsCommandes.TxtClient.Text = ""
        FormCommandeAchat.TxtPort.Text = ""


    End Sub

    Sub afficherVente()
        Call etabliconection()
        sql = " select * from detailsVente"
        cmd.Connection = cn
        cmd.CommandText = sql
        data = cmd.ExecuteReader
        While data.Read
            FormDetailsCommandes.DataGrid.Rows.Add(data(1), data.GetFloat(2), data.GetFloat(3), data.GetFloat(2) * data.GetFloat(3), data(0), data(10))
        End While
        data.Close()

    End Sub
    Sub afficherAchat()
        Call etabliconection()
        sql = " select * from detailsAchat"
        cmd.Connection = cn
        cmd.CommandText = sql
        data = cmd.ExecuteReader
        While data.Read
            FormCommandeAchat.DataGrid.Rows.Add(data(1), data.GetFloat(2), data.GetFloat(3), data.GetFloat(2) * data.GetFloat(3), data(0), data(10))
        End While
        data.Close()

    End Sub
    Sub AfficherClients()
        Call etabliconection()
        sql = " select * from clients"
        cmd.Connection = cn
        cmd.CommandText = sql
        data = cmd.ExecuteReader
        While data.Read
            ListeClients.DataGrid.Rows.Add(data(0), data(1))
        End While
        data.Close()

    End Sub
    Sub AfficherProduit()
        Call etabliconection()
        sql = " select * from produit"
        cmd.Connection = cn
        cmd.CommandText = sql
        data = cmd.ExecuteReader
        While data.Read
            Listes_Produits.DataGrid.Rows.Add(data(0), data(1), data(2))
        End While
        data.Close()
    End Sub
    Sub ChargerProduit()
        Call etabliconection()
        sql = " select * from produit"
        cmd.Connection = cn
        cmd.CommandText = sql
        data = cmd.ExecuteReader
        While data.Read
            FormDetailsCommandes.CboProduit.Items.Add(data(0))
        End While
        data.Close()
    End Sub
    Sub ChargerPrixUnitaire()
        Call etabliconection()
        sql = " select PU from produit where designation='" & FormDetailsCommandes.CboProduit.Text & "'"
        cmd.Connection = cn
        cmd.CommandText = sql
        data = cmd.ExecuteReader
        While data.Read
            FormDetailsCommandes.CboPU.Text = data(0)
        End While
        data.Close()
    End Sub
    Sub chargerTotalBrutNet()
        Dim idcm As Integer
        Dim brut As Double
        Dim Net As Double
        brut = FormDetailsCommandes.DataGrid.Item(3, FormDetailsCommandes.DataGrid.CurrentRow.Index).Value
        'MsgBox(ch)
        FormDetailsCommandes.TxtTotalBrut.Text = brut
        idcm = FormDetailsCommandes.DataGrid.Item(4, FormDetailsCommandes.DataGrid.CurrentRow.Index).Value
        Call etabliconection()
        sql = " select TVA, remise,port from detailsVente where numCMV='" & idcm & "'"
        cmd.Connection = cn
        cmd.CommandText = sql
        data = cmd.ExecuteReader
        While data.Read
            Net = brut * (1 - data.GetFloat(1) + data.GetFloat(0)) + data.GetFloat(2)
            FormDetailsCommandes.TxtNet.Text = Net
        End While
        data.Close()
    End Sub
    Sub AfficherDetailsVente()
        Call etabliconection()
        sql = " select * from detailsVente"
        cmd.Connection = cn
        cmd.CommandText = sql
        data = cmd.ExecuteReader
        While data.Read
            ReglementCommandes.DataGrid.Rows.Add(data(0), data(1), data(2), data(3), data(4), data(5), data(6), data(7), data(8), data(9))
        End While
        data.Close()
    End Sub

    Sub AfficherDetailsAchat()
        Call etabliconection()
        sql = " select * from detailsAchat"
        cmd.Connection = cn
        cmd.CommandText = sql
        data = cmd.ExecuteReader
        While data.Read
            ReglementCmdFrs.DataGrid.Rows.Add(data(0), data(1), data(2), data(3), data(4), data(5), data(6), data(7), data(8), data(9))
        End While
        data.Close()
    End Sub

    Sub AfficherCommandesClients()
        Call etabliconection()
        sql = " select nomCli,numCMV,refProd,qte,PU,date,adrDeLivr,client,codeCli from detailsVente,clients where client=codeCli "
        cmd.Connection = cn
        cmd.CommandText = sql
        data = cmd.ExecuteReader
        While data.Read
            CommandesClients.DataGrid.Rows.Add(data(0), data(1), data(2), data.GetFloat(3) * data.GetFloat(4), data(5), data(6), data(7))
        End While
        data.Close()
    End Sub

    Sub AfficherCommandesFournisseurs()
        Call etabliconection()
        sql = " select nomFrs,codeFrs,date,refProd,numCMA,qte,PU from fournisseurs,detailsAchat where fournisseur=codeFrs "
        cmd.Connection = cn
        cmd.CommandText = sql
        data = cmd.ExecuteReader
        While data.Read
            CommandeFournisseur.DataGrid.Rows.Add(data(0), data(1), data(2), data.GetFloat(3) * data.GetFloat(4), data(5), data(6), data(7))
        End While
        data.Close()
    End Sub

    Sub AfficherFournisseurs()
        Call etabliconection()
        sql = " select * from fournisseurs"
        cmd.Connection = cn
        cmd.CommandText = sql
        data = cmd.ExecuteReader
        While data.Read
            ListesFournisseurs.DataGrid.Rows.Add(data(0), data(1))
        End While
        data.Close()
    End Sub
    Sub Commander()
        Call etabliconection()

        sql = " insert into commandesAchat values ('" & FormCommandeAchat.TxtCommande.Text & "','" & FormCommandeAchat.DateTime.Text & "','" & FormCommandeAchat.TxtFrs.Text & "')"
        cmd.CommandText = sql
        data = cmd.ExecuteReader
        data.Close()
        sql = " insert into detailsAchat values ('" & FormCommandeAchat.TxtCommande.Text & "','" & FormCommandeAchat.TxtPrd.Text & "','" & FormCommandeAchat.TxtQuantite.Text & "', '" & FormCommandeAchat.TxtPu.Text & "', '" & FormCommandeAchat.DateTime.Text & "','" & FormCommandeAchat.TxtTVA.Text & "','" & FormCommandeAchat.TxtRemise.Text & "','" & FormCommandeAchat.TxtPort.Text & "','" & FormCommandeAchat.TxtFrs.Text & "')"
        cmd.CommandText = sql
        data = cmd.ExecuteReader
        data.Close()
        MsgBox("Insertion reussie!!!")

        data.Close()
        FormCommandeAchat.DataGrid.Rows.Clear()
        Call afficherAchat()
        FormCommandeAchat.TxtTVA.Text = "0.18"


    End Sub
End Module
