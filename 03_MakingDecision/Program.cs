using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF ELSE

            //Console.Write("Lütfen Şİfreyi Giriniz: ");
            //string password;
            //password = Console.ReadLine();

            //if (password == "abcd")   // = atama operatörü, == eşit mi? 
            //{
            //    Console.WriteLine("Şifre Doğru!");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz Şifre Hatalı!");
            //}




            //string capital, country;
            //Console.Write("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if(capital == "Ankara" & country == "Türkiye Cumhuriyeti")  // & = ve
            //{
            //    Console.Write("Veriler Doğrulandı!");
            //}
            //else
            //{
            //    Console.Write("Girdiğiniz Veriler Hatalı!");
            //}

            // Tırnak içinde verdiğimiz değerleri konsolda birebir aynı formatta girmemiz gerekir yoksa hata mesajını alırız.




            //int number;
            //Console.Write("Sayınızı Giriniz: ");
            //number = int.Parse(Console.ReadLine());

            //if (number == 5)
            //{
            //    Console.WriteLine("Tebrikler Doğru Sayıyı Girdiniz!");
            //}
            //else
            //{
            //    Console.WriteLine("Girdiğiniz Sayı Hatalı!");
            //}




            //int exam1, exam2, exam3, average;
            //string result; // Eğer result a başlangıç değer ataması yapacak olsaydık bu satır =>  string result = "Hatalı Not Bilgileri Girildi!"; şeklinde olacaktı.

            //Console.Write("1.Sınav Notunuzu Giriniz: ");
            //exam1 = int.Parse(Console.ReadLine());

            //Console.Write("2.Sınav Notunuzu Giriniz: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.Write("3.Sınav Notunuzu Giriniz: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavlarınızın Not Ortalaması: " + average);

            //if(average > 0 & average <= 50)
            //{
            //    result = "Kaldınız!";
            //}
            //else if (average > 50 & average <= 70)
            //{
            //    result = "Ortalama Seviye Not Ortalaması ile Geçtiniz!";
            //}
            //else if (average > 70 & average <= 84)
            //{
            //    result = "İyi Seviye Not Ortalaması ile Geçtiniz!";
            //}
            //else if (average > 84)
            //{
            //    result = "Çok İyi Seviye Not Ortalaması ile Geçtiniz!";
            //}
            //else
            //{
            //    result = "Hatalı Not Bilgileri Girildi!";
            //}

            //Console.WriteLine(result);

            // result a başlangıç değer ataması ya da else değeri verilmezse hata verir. ben else değeri vermeyi tercih edeceğim.




            //string city;
            //Console.Write("Lütfen Şehir Girişi Yapınız: ");
            //city = Console.ReadLine();

            //if(city == "İstanbul" | city == "Ankara" | city == "Samsun" ) // | = veya operatörü
            //{
            //    Console.WriteLine("Şehir Mevcut!");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil!");
            //}

            #endregion

            #region Mod İşlemleri

            //int number;
            //number = 55;
            //int result = number % 2; // 2 ye bölümünden kalan
            //Console.WriteLine(result);




            //Console.Write("Lütfen 1.Sayınızı Giriniz: ");
            //int number1 = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sayınızı Giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());

            //int result = number1 % number2;

            //Console.WriteLine("1. Sayının 2.Sayıya Bölümünden Kalan Değer: " + result);




            //Console.Write("Sayınızı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //string result;

            //if (number %2 == 0)
            //{
            //    result = "Sayınız, Çift Sayıdır.";
            //}
            //else
            //{
            //    result = "Sayınız, Tek Sayıdır.";
            //}

            //Console.WriteLine(result);

            // result eklemeden direkt Console.WriteLine() ile de yapılabilir. ben havalı olsun diye böyle yaptım.

            #endregion

            #region Char Değişkenler ile Karar Yapıları

            //char team;
            //Console.Write("Lütfen Takımınzın Sembolünü Giriniz: ");
            //team = char.Parse(Console.ReadLine());

            //if(team == 'f' | team == 'F' ) // char ifadeler '' içerisine yazılır.
            //{
            //    Console.WriteLine("FENERBAHÇE");
            //}
            //else if (team == 'b' | team == 'B')
            //{
            //    Console.WriteLine("Beşiktaş");
            //}
            //else if (team == 's' | team == 'S')
            //{
            //    Console.WriteLine("Samsunspor");
            //}
            //else
            //{
            //    Console.WriteLine("Hatalı Giriş Yaptınız!)";
            //}


            #endregion

            #region Örnek Proje Uygulaması

            //Console.WriteLine("*** CSharp Eğitim Kampı Restoran ***");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("----------------------------");

            //string menuItem;

            //Console.Write("Detayını Görmek İstediğiniz Menüyü Seçiniz: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ANA YEMEKLER------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1) Köri Soslu Tavuk");
            //    Console.WriteLine("2) Kızartma Tabağı");
            //    Console.WriteLine("3) Fasulye Pilav");
            //    Console.WriteLine("4) Fırında Somon");
            //    Console.WriteLine("5) patlıcan Musakka");
            //    Console.WriteLine("------------------------------------");

            //    Console.WriteLine();

            //}
            //else if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------ÇORBALAR------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1) Mercimek");
            //    Console.WriteLine("2) Ezogelin");
            //    Console.WriteLine("------------------------------------");

            //    Console.WriteLine();

            //}
            //else if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------PİZZALAR------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1) Ak Deniz Pizza");
            //    Console.WriteLine("2) Margaritha Pizza");
            //    Console.WriteLine("3) Karışık Pizza");
            //    Console.WriteLine("------------------------------------");

            //    Console.WriteLine();

            //}
            //else if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------İÇECEKLER------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1) Fuse Tea");
            //    Console.WriteLine("2) Limonata");
            //    Console.WriteLine("3) Cola");
            //    Console.WriteLine("4) Su");
            //    Console.WriteLine("------------------------------------");

            //    Console.WriteLine();

            //}
            //else if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------TATLILAR------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1) Triliçe");
            //    Console.WriteLine("2) Kazandibi");
            //    Console.WriteLine("3) Sütlaç");
            //    Console.WriteLine("------------------------------------");

            //    Console.WriteLine();

            //}
            //else
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("Hatalı Seçim Yaptınız.");
            //}
            #endregion

            #region SWİTCH CASE

            //Console.Write("Ay Girişi Yapınız: ");
            //int monthNumber = int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1: Console.Write("Ocak"); break;  // 1 istendiğinde bana cw içindeki değeri ver ve break ile bu işlemi bitir.
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.WriteLine("Hatalı Veri Girişi!"); break; 
            //}

            #endregion

            #region Switch Case Hesap Makinası

            //int number1, number2, result;
            //char symbol;

            //Console.WriteLine("1.Sayınızı Giriniz: "); 
            //number1 = int.Parse(Console.ReadLine());

            //Console.WriteLine("2.Sayınızı Giriniz: ");
            //number2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Hangi İşlemi Yapmak İstediğinizi Seçiniz: [+/-/ / /*]");
            //symbol = char.Parse(Console.ReadLine());

            //switch (symbol)
            //{
            //    case '+' :
            //        result = number1 + number2;
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '/':
            //        result = number2 / number1;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;

            //    case '*':
            //        result = number2 * number1;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
                             
            //    default: Console.WriteLine("Hatalı Giriş Yaptınız!"); break;
            //}

            #endregion

            


            Console.Read();
        }
    }
}
