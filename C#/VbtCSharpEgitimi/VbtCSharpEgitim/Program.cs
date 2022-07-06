// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.WriteLine("Hello, World!");
int age = 29; // Sayısal ifadeleri tutar
string name = "Berkcan"; // Metinsel ifadeleri tutar.
decimal price = 15.40M;
bool isActive = false; //True false değerini tutar.
object test = "Berkcan";
// Atama ifadeleri = ile kullanılır. Sol taraf sağ tarafa eşitlenir.

int price2 = 15;
price2 += 10; //price2 = price2 + 10; Cevap : 25 olacaktır.
price2 -= 10; //price2 = price2 - 10; Cevap : 15
price2++; //price2 = price2 + 1   price2 değerini 1 artırır.
price2--; //price2 değerini 1 azaltır.

price2 *= 10; //price2 = price2 * 10;


if (price2 > 16)
{
    //Koşul doğruysa çalışacak kodlar 
}
else if (price2 < 15)
{
    //Koşul2 doğruysa çalışacak kodlar 
}
else if (price2 == 15)
{
    //Koşul3 doğruysa çalışacak kodlar 
}
else
{
    //Hiçbir koşul doğru değilse çalışır.
}

//Switch case ile değere göre veri getirme sağlanıyor.
Console.WriteLine("Lütfen bir sayı giriniz: ");
int sayi = Convert.ToInt32(Console.ReadLine()); //ekrandan veri almayı sağlar.
switch (sayi)
{
    case 1:
        Console.WriteLine("Pazartesi");
        break;
    case 2:
        Console.WriteLine("Salı");
        break;
    case 3:
        Console.WriteLine("Çarşamba");
        break;
    case 4:
        Console.WriteLine("Perşembe");
        break;
    case 5:
        Console.WriteLine("Cuma");
        break;
    case 6:
        Console.WriteLine("Cumartesi");
        break;
    case 7:
        Console.WriteLine("Pazar");
        break;
    default:
        Console.WriteLine("Girdiğiniz sayıya ait gün bulunamadı.");
        break;
}


//Döngüler 4 tiptir. Bunlar işlerimizi kolaylaştırı.
//For Döngüsü
// for(başlangıç; koşul; artış){}
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(i);
}

/*
 2 Tarih değerimiz var
 Başlangıç : 30.07.2022
 Bitiş : 05.08.2022 arası gün hesaplamak istiyoruz.
 */
DateTime dtStart = new DateTime(2022, 7, 30);
DateTime dtEnd = new DateTime(2022, 8, 5);
int totalDays = 0;
for (DateTime date = dtStart; date <= dtEnd; date = date.AddDays(1))
{
    if (date.DayOfWeek != DayOfWeek.Saturday && date.DayOfWeek != DayOfWeek.Sunday)
    {
        totalDays++;
        Console.WriteLine(date.Date + " Günü İzin Kullanabilirsiniz.");
    }
}
Console.WriteLine("Hafta Sonu Hariç İzinli Gün Sayısı: " + totalDays);


TimeSpan days = dtEnd - dtStart; //TimeSpan ile iki tarih arasındaki zaman aralığını bulmayı sağlar.
Console.WriteLine("İzinli Gün Sayısı: " + days.TotalDays);

char character = 'A';
for (char i = character; i < 'Z'; i++)
{
    if (i == 'K' || i == 'L')
    {
        continue; //continue ise sadece o değeri atlayarak devam eder. Ama breakte o değerden sonra çalışmaz.
    }
    Console.WriteLine(i);
}


//while döngüsü
//Koşul yanlış olursa while durur.
int x = 0;
while (x < 5)
{
    Console.WriteLine(x);
    x++;
}

//Do while döngüsü en az bir kez çalıştıktan sonra doğru ya da yanlış olmasına bakılmaksızın çalışır.
do
{

}while (x < 5);
//Performans açısınıdan iç içe while kullanmak performansı düşürür.

//var lstStajyerler = new List<string>() { "Hikmet","Ferhat","Şeymanur","Oruçhan"};
//string name2 = "Berkcan";
//for (int i = 0; i < name2.Length; i++) 
//{
//    for(int j = 0; j <= i; j++)
//    {
//        string ilkStajer = lstStajyerler.Where(p => p != "Hikmet" && p ! =="Ferhat").FirstOrDefault();
//        Console.WriteLine(name2[j]);    
//    }
//    Console.WriteLine();
//}


//Foreach döngüsü dizilerde işlem yapılır.
//var lstStajyerler = new List<string>() { "Hikmet", "Ferhat", "Şeymanur", "Oruçhan" };
int[] sayilar = new int[4] { 1, 2, 3, 4 };//sabit uzunluktaki dizilerde eleman sayısı belirtiriz. 
string[] lstStajyerler = { "Hikmet", "Ferhat", "Şeymanur", "Oruçhan" };
foreach (var item in lstStajyerler)
{
    Console.WriteLine(item);
    if (item == "Ferhat")
    {
        break; 
        //continue;
    }
    
}


//KOLEKSİYONLAR
// Koleksiyon kullanmak bir adım öne geçirir.
List<int> lstAge = new List<int>();
lstAge.Add(23);
lstAge.Add(30);
lstAge.Add(40);
lstAge.Add(50); //.add metodu listeye eleman eklemeyi sağlar.
lstAge.Remove(50); //Remove metoduyla listeden eleman silmeyi sağlar.
List<Student> lstStudents = new List<Student>();
Student objStudent = new Student();
objStudent.Name = "Berkcan";
objStudent.Surname = "Gümüşışık";
objStudent.Number = 404;
objStudent.IdentityNumber = "121212";
lstStudents.Add(objStudent);

Student clsStudent = new Student();
clsStudent.Name = "Ahmet";
clsStudent.Surname = "Kaplan";
clsStudent.Number = 405;
clsStudent.IdentityNumber = "121212";
lstStudents.Add(clsStudent);
if(lstStudents.Count > 0) 
{
    string nameSurname = lstStudents[0].Name;
}

var student = lstStudents.Where(p => p.Number == 405).FirstOrDefault();

if(student != null)
{
    Console.WriteLine(student.Name + " " + student.Surname + " hoşgeldiniz.");
}
else
{
    Console.WriteLine("Öğrenci kaydınız bulunamadı!");
}


List<string> lstCity = new List<string>();
lstCity.Add("İstanbul");
lstCity.Add("Ankara");
lstCity.Add("İzmir");

List<string> lstCountry = new List<string>();
lstCountry.Add("Türkiye");
lstCountry.Add("Almanya");
lstCountry.Add("Fransa");
lstCity.AddRange(lstCountry); //City listesinin üzerine ülkeyi ekler.
if (lstCity.Contains("İstanbul"))
{
    Console.WriteLine("Mevcut");
}
else
{
    Console.WriteLine("Mevcut Değil");
}//Contains liste içerisinde girilen verinin olup olmadığını kontrol etmeyi sağlar.
foreach (string value in lstCity)
{
    Console.WriteLine(value);
}
lstCity.Remove("İstanbul");
lstCity.RemoveAt(0); //Listeden eleman silme

lstCity.Clear(); //Liste içerisini boşaltır.

//ArrayList
// List ile veri tipi belirtirken ArrayList içerisinde belirtilmez. ArrayList çok tercih edilmez.
ArrayList dynamicList = new ArrayList();
dynamicList.Add("Ankara");
dynamicList.Add("İstanbul");
dynamicList.Add("İzmir");
if (dynamicList.Contains("İstanbul"))
{
    Console.WriteLine("Mevcut");
}
else
{
    Console.WriteLine("Mevcut Değil");
}//Contains array içerisinde girilen verinin olup olmadığını kontrol etmeyi sağlar.
foreach(var item in dynamicList)
{
    Console.WriteLine(item);
}

//Hashtable ile birlikte key value değeri tutmayı sağlar.
Hashtable cityList = new Hashtable();
cityList.Add(34, "İstanbul");
cityList.Add(6, "Ankara");
Console.WriteLine("İl kodu giriniz: ");
int ilKodu = Convert.ToInt32(Console.ReadLine());
if (cityList.Contains(ilKodu))
{
    Console.WriteLine("İl Kodu Mevcut");
}
else
{
    Console.WriteLine("İl Kodu Mevcut Değil");
}

Hashtable lstcities = new Hashtable();
City city = new City();
city.CityCode = 34;
city.CityName = "İstanbul";

City cityAnk = new City();
cityAnk.CityCode = 6;
cityAnk.CityName = "Ankara";

lstcities.Add(city.CityCode, city.CityName);
lstcities.Add(cityAnk.CityCode, cityAnk.CityName);

Console.WriteLine("İl kodu giriniz: ");
int plaka = Convert.ToInt32(Console.ReadLine());
if (cityList.Contains(plaka))
{
    Console.WriteLine("İl Kodu Mevcut");
}
else
{
    Console.WriteLine("İl Kodu Mevcut Değil");
}

List<City> lstcities1 = new List<City>();
City cityIst = new City();
cityIst.CityCode = 34;
cityIst.CityName = "İstanbul";
lstcities1.Add(cityIst);

City cityAnkara = new City();
cityAnkara.CityCode = 6;
cityAnkara.CityName = "Ankara";
lstcities1.Add(cityAnkara);
Console.WriteLine("İl kodu giriniz: ");
int plaka1 = Convert.ToInt32(Console.ReadLine());
City c  = lstcities1.Where(x => x.CityCode == plaka1).FirstOrDefault();
if (c != null)
{
    Console.WriteLine("İl Kodu Mevcut");
}
else
{
    Console.WriteLine("İl Kodu Mevcut Değil");
}

//BitArray içerisinde bool değerler tutar.
bool[] bit = { true, false, true, false };
BitArray bitArray = new BitArray(bit);

//Queue Sınıfı => İlk giren ilk çıkar ilkesiyle çalışır.
//Enqueue(): Kuyruğun sonuna eleman ekler.
//Dequeue(): Kuyruğun başındaki elemanı çıkartır.
Queue<string> lstQueue = new Queue<string>();
lstQueue.Enqueue("Berkcan Gümüşışık");
lstQueue.Enqueue("Ahmet Kaplan");
lstQueue.Enqueue("Ali Ak");
try
{
    string nameSurname = lstQueue.Dequeue();
    Console.WriteLine("Müşteri : ", nameSurname);
}
catch (Exception)
{
    Console.WriteLine("Bekleyen müşteri kalmadı");
}
//Dictionary ile hashtable farkı dictionaryde  hem key hem de value değerini belirtiyoruz. Ama hashtable da belirtmiyoruz. Hashtable da performans kaybı yaşanabilir.
Dictionary<int, string> dicCity = new Dictionary<int, string>();
dicCity.Add(6, "Ankara");
dicCity.Add(34, "İstanbul");

int ilKod = 0;
if (dicCity.ContainsKey(ilKod))
{
    Console.WriteLine("İl Kodu Mevcut");
}
else
{
    Console.WriteLine("İl Kodu Mevcut Değil");
}

//Stackte son giren ilk çıkar
Stack<string> lstStack = new Stack<string>();
lstStack.Push("İstanbul");
lstStack.Push("Ankara");
lstStack.Push("İzmir");

try
{
    string cityN = lstStack.Pop();
    
}
catch (Exception)
{
    Console.WriteLine("İl kalmadı");
}
Console.ReadLine();

public class Student
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Number { get; set; }
    public string IdentityNumber { get; set; }
}

public class City
{
    public int CityCode { get; set; }
    public string CityName { get; set; }
  
}
