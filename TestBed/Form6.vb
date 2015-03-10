Public Class Form6

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'TextBox1.Text = "7"

        Dim frm As frm_orta_kuran = TryCast(Application.OpenForms("frm_orta_kuran"), frm_orta_kuran)
        frm.TextBox1.Text = TextBox1.Text


    End Sub
End Class