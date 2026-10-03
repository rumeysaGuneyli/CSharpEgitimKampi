using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü

            // Döngüler

            // For (x;y;z)  // üç parametreden oluşuyor.
            // x: başlangıç değerini tutar.
            // y: bitiş değerini tutar.
            // z: artıl-azalış değerini tutar.




            //int i;

            //for (i = 1; i <= 5; i++) 
            //{
            //    Console.WriteLine("CSharp Eğitim Kampı");
            //}




            //for (int i = 1; i<= 20; i++) // i değişkenini döngünün içindeyken de tanımlayabiliyoruz.
            //{
            //    Console.WriteLine("i");
            //}




            //for (int i = 3; i <= 50; i += 3) // i 3 ten başlayıp 3 artarak 50 ye eşit ya da az olana kadar devam edecek demek istiyor şair.
            //{
            //    Console.WriteLine(i);
            //}
            // Aslında 51 i de döngüye dahil ediyor lakin i <= 50 kısmında false döndüğü için ekrana yazılmıyor.




            //Console.Write("Lütfen Ekrana Yazılmasını İstediğiniz Adedi Giriniz: ");
            //int finishValue = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= finishValue; i++)
            //{
            //    Console.WriteLine("Yaşasın Cumhuriyet");
            //}

            #endregion

            #region For Döngüsü ile Karar Yapıları

            //for(int i = 1; i <= 100; i++)
            //{
            //    if(i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}




            // 1'den 10'a Kadar Olan Sayıların Toplamını Bulan Algoritma
            //int totalValue = 0;

            //for(int i = 1; i <= 10; i++)
            //{
            //    totalValue += i;
            //}

            //Console.WriteLine(totalValue);




            //1' den 20' ye Kadar Olan Çift Sayıların Yazdırılması ve Toplam Sonucunun Gösterilmesi
            //int totalValue = 0;

            //for (int i = 1; i <=  20; i++)
            //{
            //    if (i % 2 == 0)
            //    {
            //        totalValue += i;
            //        Console.WriteLine(i);
            //    }
            //}

            //Console.WriteLine("---------------");
            //Console.WriteLine(totalValue);




            //1'den 50'ye Kadar Olan 7 ye Bölünebilen Sayıların Sayısının Bulunması
            //int count = 0;

            //for(int i = 1; i <= 50; i++)
            //{
            //    if(i % 7 == 0)
            //    {
            //        count++; // count değerini bir artır demek istiyor.
            //    }
            //}

            //Console.WriteLine(count);
            #endregion

            #region For Döngüsü; Sürekli Çoğalan Bakteri Örneği

            // Her Saatin Sonunda Kendini Bölerek 1-2-4-8-16-... şeklinde çoğalıyor.

            //int bacterium = 1;

            //for(int i = 1; i <= 24; i++)
            //{
            //    bacterium *= 2;
            //    Console.WriteLine( i + ". Saatin Sonunda: " + bacterium);
            //}


            #endregion

            #region While Döngüsü

            // Şart sağlandığı sürece anlamı taşımaktadır.

            // While(şart)
            //{
            //İşlemler
            //}

            //int i = 1;
            //while(i <= 10)
            //{
            //    Console.WriteLine("Merhaba Döngüler");
            //    i++;
            //}





            //int i = 1;
            //while(i <= 10)
            //{
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}




            // 1'le 10' Arasında ki Sayıların While Döngüsü ile Toplamı
            //int i = 1;
            //int sum = 0;

            //while (i <= 10)
            //{
            //    sum += i;
            //    i++;
            //}

            //Console.WriteLine(sum);

            #endregion

            #region Örnek Sınav Sorusu

            //Klavyeden girilen 3 basamaklı sayının basamakları toplamını hesaplayan kodu yazınız.
            //456

            //Console.Write("Sayınızı Giriniz: ");
            //int number = int.Parse(Console.ReadLine());
            //int ones, tens, hundreds;
            //int sum;

            //ones = number % 10; //Sayının 10 a bölümünden kalan birler basamağını verir.
            //tens = (number % 100) / 10; //Sayının 100 ile bölümünden kalanın 10 ile bölümü 10 lar basamağını verir.
            //hundreds = number / 100; // Sayının 100 e bölümü yüzler basamağını verir.
            //// hundreds = 4,56 olması gerekirdi ama biz int dediğimiz için virgülden sonra ki kısmı almayıp bize sadece 4 ü verecek

            //Console.Write(hundreds + " + " + tens + " + " + ones + " = ");
            
            //sum = ones + tens + hundreds;

            //Console.WriteLine(sum);

            #endregion


            Console.Read();











        }
    }
}
