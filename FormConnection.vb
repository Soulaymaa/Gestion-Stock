Public Class FormConnection

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles Txtmdp.TextChanged

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        FormMenuGeneral.Visible() = True
        Me.Visible = False
    End Sub

    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call etabliconection()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim login As String
        Dim mdp As String
        Dim i As Integer
        login = Txtlogin.Text
        mdp = Txtmdp.Text
        sql = " select * from users where login='" & login & "' and password='" & mdp & "' "
        cmd.Connection = cn
        cmd.CommandText = sql
        data = cmd.ExecuteReader
        For i = 0 To 2
            If data.Read = True Then
                Me.Visible = False
                FormMenuGeneral.Lbl1.Enabled = True
                FormMenuGeneral.Label1.Enabled = True
                FormMenuGeneral.Label2.Enabled = True
                FormMenuGeneral.Label3.Enabled = True
                FormMenuGeneral.Label4.Enabled = True
                FormMenuGeneral.Label5.Enabled = True
                FormMenuGeneral.Label8.Enabled = True
                FormMenuGeneral.Label9.Enabled = True
                FormMenuGeneral.Label10.Enabled = True
                FormMenuGeneral.Visible = True
                Txtlogin.Text = ""
                Txtmdp.Text = ""
                Exit For
            Else
                LblReessayer.ForeColor = Color.Red
                LblReessayer.Text = " Login ou mot de passe incorrect veuillez Reessayer"
                Txtlogin.Text = ""
                Txtmdp.Text = ""
                End If

        Next
        data.Close()

    End Sub

    Private Sub LblReessayer_Click(sender As System.Object, e As System.EventArgs) Handles LblReessayer.Click

    End Sub
End Class