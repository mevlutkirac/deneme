Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frm_orta_kuran


    Private Sub MusteriBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MusteriBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MusteriBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DerDataSet)

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Bu kod satýrý 'DerDataSet.Musteri' tablosuna veri yükler. Bunu gerektiði þekilde taþýyabilir, veya kaldýrabilirsiniz.
        Me.MusteriTableAdapter.Fill(Me.DerDataSet.Musteri)

    End Sub

    'ExecuteReader()
    'Uygulamalarimizda bazen veri kaynaklarindan veri kümeleri çekmemiz gerekir. 
    'Böyle bir durumda, ExecuteReader metodunu kullanabiliriz. 
    'ExecuteReader metodu, çalistirilan komut sonucu elde edilen 
    'sonuç kümesinden bir SqlDataReader nesnesi için veri akisini saglar.

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim strCN As String = "Data Source=MEVLÜT\SQLEXPRESS;Initial Catalog=der;Integrated Security=True"
        Dim CN As New SqlConnection
        CN.ConnectionString = strCN



        Dim strQ As String = "SELECT * FROM Musteri WHERE MusteriId='1'"
        Dim CMD As New SqlCommand(strQ, CN)

        CN.Open()
        Dim Reader As SqlDataReader = CMD.ExecuteReader()
        Dim sonuc As String = String.Empty
        Do While Reader.Read
            MessageBox.Show(Reader(1).ToString & " " & Reader(2).ToString) 'ikinci ve üçüncü kolondaki bilgiler
        Loop
        CN.Close()


    End Sub
    'ExecuteNonQuery()
    'Bu metot bize, SqlCommand ile verdigimiz komuttan etkilenen kayitlarin adedini verir. 
    'Sonuç integer tipindedir.

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim strCN As String = "Data Source=MEVLÜT\SQLEXPRESS;Initial Catalog=der;Integrated Security=True"
        Dim CN As New SqlConnection
        CN.ConnectionString = strCN



        Dim strQ As String = "SELECT * FROM Musteri WHERE MusteriId='1'"
        Dim CMD As New SqlCommand(strQ, CN)

        CN.Open()
        Dim Toplam As Integer = CMD.ExecuteNonQuery
        MessageBox.Show("Güncellenen kayýt toplamý: " & Toplam + 1)
        CN.Close()
    End Sub

    'ExecuteScalar()
    'ExecuteReader() metodundan bahsederken sonuç kümesi ibaresini kullanmistik. 
    'ExecuteScalar() tek alanlik veri döndüren sql komutlari için kullanilir.
    'Bu yüzden ExecuteReader() 'den daha performanslidir.

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim strCN As String = "Data Source=MEVLÜT\SQLEXPRESS;Initial Catalog=der;Integrated Security=True"
        Dim CN As New SqlConnection
        CN.ConnectionString = strCN



        Dim strQ As String = "Select COUNT(AdSoyad) from Musteri"
        Dim CMD As New SqlCommand(strQ, CN)



        CN.Open()
        Dim ToplamKayit As Integer = CMD.ExecuteScalar
        MessageBox.Show("Toplam kayit: " & ToplamKayit)
        CN.Close()
    End Sub
End Class