//try içerisinde normal çalışacak kodu veriyoruz. Catch yardımıyla da oluşacak hataya karşı çözüm üretiyoruz.
//Catch ile hata türlerine göre mesaj döndürmeyi sağlıyor. Bu sayede hata özelleştirmesi yapılır.
//Catch sayısını istediğimiz kadar arttırabiliriz.
//Finally bloğuna her ihtimale karşı girer.
//Try ve finally bloğuna her türlü girer. Eğer hata varsa catche girer. Hata yoksa yalnızca try ve finally bloğu girer.
// when ile düşürülmek istenen metoda gitmesini sağlıyor.

using System.Data.SqlClient;

try
{
    var deneme = "test";
    int deneme2 = Convert.ToInt32(deneme);
}
catch (FormatException ex)
{
    Console.WriteLine("Format Hatası : " + ex.ToString());
}
catch (Exception ex) when (LogException(ex))
{
    Console.WriteLine("Hata : " + ex.ToString());
}
finally
{
    Console.WriteLine("İşlem Bitti");
}

static bool LogException(Exception ex)
{
    return false;
}
string connectionString = @"data source =LAPTOP-4UM0D685\SQLEXPRESS; initial catalog =StajApp; integrated security =true;";

SqlTransaction transaction = null;
//Transaction işlemiyle birlikte bir hata alındığı zaman işlemi başa almayı sağlar.

using(SqlConnection contex = new SqlConnection(connectionString))
{
    try
    {
        contex.Open();
        transaction = contex.BeginTransaction();
        SqlCommand com1 = new SqlCommand("Insert into Personel (IdPersonel,PersonelName,PersonelSurname values (1,'Test1','Test2')",contex,transaction);
        SqlCommand com2 = new SqlCommand("Insert into Personel (IdPersonel,PersonelName,PersonelSurname values (2,'Test1','Test2')", contex, transaction);

        com1.ExecuteNonQuery();
        com2.ExecuteNonQuery();
        transaction.Commit();
    }

    catch (Exception)
    {
        transaction.Rollback();
      
    }
    finally
    {
        contex.Close();
    }
}

Console.ReadLine();