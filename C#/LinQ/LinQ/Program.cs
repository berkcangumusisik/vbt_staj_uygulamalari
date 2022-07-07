using LinQ;
using System.Linq;

var sayilar = new int[] { 1, 2, 3, 11, 12, 13 };
//Linq kullanmadan çözüm


var sayilarTemp = new List<int>();
foreach (var item in sayilar)
{

    if (item < 10)
    {
        sayilarTemp.Add(item);
    }
}
foreach (var say in sayilarTemp)
{
    Console.WriteLine(say);
}

//Linq kullanarak çözüm
var sonuc = from x in sayilar
            where x < 10
            select x;

foreach (var say in sonuc)
{
    Console.WriteLine(say);
}

//Linq lambda expression şeklinde kullanım
var sonuc2 = sayilar.Where(x => x < 10);

foreach (var say in sonuc2)
{
    Console.WriteLine(say);
}

var personeller = new List<Personel>{ new Personel() { Name="Test Ad 1", Surname = "Test Soyad 1" ,PersonelID = 1},
  new Personel() { Name = "Test Ad 1", Surname = "Test Soyad 2", PersonelID = 2 },
  new Personel() { Name="Test Ad 3", Surname = "Test Soyad 3" ,PersonelID = 3},
  new Personel() { Name = "Test Ad 2", Surname = "Test Soyad 2", PersonelID = 2 },
};


var projeler = new List<Proje>{ new Proje() { ProjectName="Proje Ad 1", ProjectID=1},
  new Proje() { ProjectName="Proje Ad 2", ProjectID=2},
  new Proje() { ProjectName="Proje Ad 3", ProjectID=3},
  new Proje() { ProjectName="Proje Ad 4", ProjectID=4},
};

var sonuc3 = from x in personeller select x.Name;


foreach (var personel in sonuc3)
{
    Console.WriteLine(personel);
}

var sonuc4 = personeller.Select(c => c.Name);

foreach (var personel in sonuc4)
{
    Console.WriteLine(personel);
}

var sonuc5 = from x in personeller where x.PersonelID == 1 && x.Surname == "Test Soyad 1" select x;
foreach (var personel in sonuc5)
{
    Console.WriteLine(personel.Name);
}

var sonuc6 = personeller.Where(c => c.PersonelID == 1 && c.Surname == "Test Soyad 1").Select(x => x.Name);
foreach (var personel in sonuc6)
{
    Console.WriteLine(personel);
}

var sonuc7 = from x in personeller orderby x.Name select x.Name;
foreach (var personel in sonuc7)
{
    Console.WriteLine(personel);
}
var sonuc8 = personeller.OrderBy(x => x.Name).Select(x => x.Name);

foreach (var personel in sonuc8)
{
    Console.WriteLine(personel);
}

var sonuc9 = from x in personeller orderby x.Name, x.Surname descending select x.Name; //Tersten sıralar
foreach (var personel in sonuc9)
{
    Console.WriteLine(personel);
}
var sonuc10 = personeller.OrderByDescending(x => x.Name).ThenBy(x => x.Surname).Select(x => x.Name);

foreach (var personel in sonuc10)
{
    Console.WriteLine(personel);
}

var sonuc11 = personeller.Select(x => x.Name).Reverse(); //Reverse listeyi tersine çevirir.
foreach (var personel in sonuc11)
{
    Console.WriteLine(personel);
}

var sonuc12 = personeller.OrderBy(x => x, new ComparePersonel()).Select(x => x.Name);
foreach (var personel in sonuc12)
{
    Console.WriteLine(personel);
}

var sonuc13 = from x in personeller group x by x.Name into nameGroup select nameGroup.Key;
foreach (var personel in sonuc13)
{
    Console.WriteLine(personel);
}
//foreach (var personel in sonuc13)
//{
//    Console.WriteLine(personel.Key);
//    foreach (var y in personel)
//    {
//        Console.WriteLine(y.Name + " " + y.Surname);
//    } 
//}
var sonuc14 = personeller.GroupBy(x => x.Name);
foreach (var personel in sonuc14)
{
    Console.WriteLine(personel.Key);
    foreach (var y in personel)
    {
        Console.WriteLine(y.Name + " " + y.Surname);
    }
}

var sonuc15 = from x in personeller group x by x.PersonelID == 1;
foreach (var personel in sonuc15)
{
    Console.WriteLine(personel.Key == true ? "Evet" : "Hayır");
    foreach (var y in personel)
    {
        Console.WriteLine(y.Name + " " + y.Surname);
    }
}

var sonuc16 = personeller.GroupBy(x => x, new CompareEqualityPersonel());
foreach (var personel in sonuc16)
{
    Console.WriteLine(personel.Key.Name);
    foreach (var y in personel)
    {
        Console.WriteLine(y.Name + " " + y.Surname);
    }
}

var sonuc17 = from x in personeller
              join y in projeler on x.ProjectID equals y.ProjectID
              select new { Adı = x.Name + " " + x.Surname, ProjeAdı = y.ProjectName };
foreach (var personel in sonuc17)
{
    Console.WriteLine(personel);
}

var sonuc18 = personeller.Join(projeler, x => x.ProjectID, y => y.ProjectID, (x, y) => new { Adı = x.Name + " " + x.Surname, ProjeAdı = y.ProjectName });


foreach (var personel in sonuc18)
{
    Console.WriteLine(personel);
}

var sonuc19 = from x in personeller
              from y in projeler
              where x.ProjectID == y.ProjectID
              select new { Adı = x.Name + " " + x.Surname, ProjeAdı = y.ProjectName };
foreach (var personel in sonuc19)
{
    Console.WriteLine(personel);
}

var sonuc20 = personeller.SelectMany(x => projeler.Where(y => y.ProjectID == x.ProjectID), (x, y) => new { Adı = x.Name + " " + x.Surname, ProjeAdı = y.ProjectName });
foreach (var personel in sonuc20)
{
    Console.WriteLine(personel);
}


var sonuc21 = (from x in sayilar where x < 10 select x).ToList();
for (int i = 0; i < sayilar.Length; i++)
{
    sayilar[i] = sayilar[i] - 10;
}
foreach (var item in sonuc21)
{
    Console.WriteLine(item);
}

var sonuc22 = (from x in personeller select x).Take(2);
foreach (var item in sonuc22)
{
    Console.WriteLine(item);
}

var sonuc23 = personeller.Take(2).Select(x => x.Name);// İlk 2 veriyi getirir.
foreach (var item in sonuc23)
{
    Console.WriteLine(item);
}

var sonuc24 = personeller.Skip(2).Select(x => x.Name); // 2 tane atla kalanları ekrana getir.
foreach (var item in sonuc24)
{
    Console.WriteLine(item);
}

var sonuc25= (from x in personeller select x).TakeWhile(x => x.PersonelID < 4);
foreach (var item in sonuc23)
{
    Console.WriteLine(item);
}

//And  &&
// Or ||