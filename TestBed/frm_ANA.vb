Public Class frm_ANA


    Private Sub frm_ANA_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim f0 As New frm_orta_kuran
        f0.TopLevel = False
        f0.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        f0.Dock = DockStyle.Fill
        Me.Panel1.Controls.Add(f0)
        f0.Show()


        Dim f1 As New Form6
        f1.TopLevel = False
        f1.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        f1.Dock = DockStyle.Fill
        Me.TabPage1.Controls.Add(f1)
        f1.Show()



        'Tabpageleri show yapmadýðýmýzda frm_orta_kuran da Sureler_DataGridView_CellDoubleClick1 de hata alýrýz. Bunun için tüm tabpageleri show etmek gerekmekte.
        TabPage1.Show()
        TabPage2.Show()
        TabPage3.Show()
        TabPage4.Show()
        'TabPageOncekiIndirilenler.Show()
        'TabPageTefsirler.Show()


    End Sub
End Class
