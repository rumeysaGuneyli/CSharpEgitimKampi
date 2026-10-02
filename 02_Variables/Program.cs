using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region   Double Değişkenler          
            //double number;
            //number = 4.86;  //kodda nokta olarak yazılan ayırma ya da basamak belirtme sembolünü konsol ekranında virgül olarak görürüz.

            //Console.WriteLine(number);

            //Console.WriteLine("*** Fiyat Listesi ***");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 8.97;

            //Console.WriteLine("---- Elma Birim Fiyatı" + applePrice + " TL" );
            //Console.WriteLine("---- Portakal Birim Fiyatı" + orangePrice + " TL" );
            //Console.WriteLine("---- Çilek Birim Fiyatı" + strawberryPrice + " TL" );
            //Console.WriteLine("---- Patates Birim Fiyatı" + potatoPrice + " TL" );
            //Console.WriteLine("---- Domates Birim Fiyatı" + tomatoPrice + " TL" );

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Elma - " + "Birim Fiyat: " + applePrice + " - Gramaj: " + appleGram + " - Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Portakal - " + "Birim Fiyat: " + orangePrice + " - Gramaj: " + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: çilek - " + "Birim Fiyat: " + strawberryPrice + " - Gramaj: " + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates - " + "Birim Fiyat: " + potatoPrice + " - Gramaj: " + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates - " + "Birim Fiyat: " + tomatoPrice + " - Gramaj: " + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar: " + shoppingTotalPrice + " TL") ;




            #endregion

            #region Char Değişkenler

            // Tek bir karakter tutabilir.
            // '' tek tırnak ile tanımlanır.

            //char symbol;
            //symbol = 'a';

            //Console.WriteLine(symbol);


            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** CSharp Hava Yolları Yolcu Bilgisi *****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı:  ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu Kimlik Numarası: ");
            //passengerIdentityNumber = Console.ReadLine();    

            //Console.WriteLine();

            //Console.WriteLine("-----------------");
            //Console.WriteLine("Yolcu Kimlik Numarası: " + passengerIdentityNumber + " - Yolcu Adı Soyadı: " + passengerName + " " + passengerSurname + " - Yolcunun Yaşı: " + passengerAge + " - Yolcunun Konum Bilgileri: " + passengerDistrict + " / " + passengerCity);


            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Aldığınız ayakkabı sayısını giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());   // Parse dönüşüm methodu = string ifadeyi int e dönüştürdü.

            //Console.Write("Aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız sandalye sayısını giriniz: ");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPricce = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;

            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPricce);




            #endregion

            #region Klavueden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("1. Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine()); // string ifadeyi double a dönüştürdü.

            //Console.Write("2. Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("3. Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //// Konsol ekranından double ifade girerken virgül işareti ile girmeliyiz.

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Not Ortalamanız: " + result);


            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;

            //Console.Write("Cinsiyeet Seçiniz [K / E]: ");
            //gender = char.Parse(Console.ReadLine());  // string değeri char a dönüştürüyor.

            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);


            #endregion


            Console.Read();



        }
    }
}
