Public Class Form2


    Private Sub MusteriBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MusteriBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MusteriBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DerDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satırı 'DerDataSet.Musteri' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
        Me.MusteriTableAdapter.Fill(Me.DerDataSet.Musteri)

    End Sub
End Class