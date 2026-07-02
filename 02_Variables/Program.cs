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
            #region Double Değişkinler

            //double number = 3.14;

            //Console.WriteLine(number);


            //Double domatesPrice = 25.85, biberPrice = 20.75, patlicanPrice = 60.15;

            //Console.WriteLine("******* Fiyat Listesi *******");
            //Console.WriteLine();
            //Console.WriteLine("Domates: " + domatesPrice );
            //Console.WriteLine("Biber: " + biberPrice);
            //Console.WriteLine("Patlıcan: " + patlicanPrice);
            //Console.WriteLine();
            //Console.WriteLine("******* Fiyat Listesi *******");

            //double domatesGram = 1245, biberGram = 2356, patlicanGram = 1793;

            //double domatesTotalPrice = (domatesPrice * domatesGram) / 1000; //kilo hesabından ötürü
            //double biberTotalPrice = (biberPrice * biberGram) / 1000;
            //double patlicanTotalPrice = (patlicanPrice * patlicanGram) / 1000;

            //domatesTotalPrice = Math.Round(domatesTotalPrice, 2);// virgülden sonra 2 basamak al demek.
            //biberTotalPrice = Math.Round(biberTotalPrice, 2); //2 yi kaç yaparsan o kadar basamak gelir.
            //patlicanTotalPrice = Math.Round(patlicanTotalPrice, 2);//Math library içindeki Round methodu 

            //Console.WriteLine();
            //Console.WriteLine("******* Toplam Fiyat Listesi *******");
            //Console.WriteLine();
            //Console.WriteLine("Domates: " + domatesTotalPrice);
            //Console.WriteLine("Biber: " + biberTotalPrice);
            //Console.WriteLine("Patlıcan: " + patlicanTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine("Alışveriş Toplam Tutarı: " + (domatesTotalPrice+biberTotalPrice+patlicanTotalPrice) + " TL");
            //Console.WriteLine("******* Toplam Fiyat Listesi *******");

            #endregion

            #region Char Değişkenler






            #endregion Klavye Veri Girişleri

            #region Klavye Veri Girişleri

            //Console.WriteLine("******** Yolcu Bilgisi Alımı ********");
            //Console.WriteLine();

            //string yolcuAdi, yolcuSoyadi, yolcuCinsiyet;
            //int yolcuDogumYili, yolcuYasi; 
            //string secim;

            //Console.WriteLine("Yolcu Adı: ");
            //yolcuAdi = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("Yolcu Soyadı: ");
            //yolcuSoyadi = Console.ReadLine();
            //Console.WriteLine();
            //Console.WriteLine("Yolcu Cinsiyeti (K/E): ");
            //secim = Console.ReadLine().ToUpper();
            //switch (secim)
            //{
            //    case "K":
            //        yolcuCinsiyet = "Kadın";
            //        break;
            //    case "E":
            //        yolcuCinsiyet = "Erkek";
            //        break;
            //    default:
            //        yolcuCinsiyet = "Belirtilmedi";
            //        break;
            //}
            //Console.WriteLine();
            //Console.WriteLine("Yolcu Doğum Yılı:" );
            //yolcuDogumYili = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine();
            //yolcuYasi = DateTime.Now.Year - yolcuDogumYili;

            //Console.WriteLine("******** Yolcu Bilgisi Alımı ********");

            //Console.WriteLine("--------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine("Yolcu Adı Soyadı: " + yolcuAdi + " " + yolcuSoyadi);
            //Console.WriteLine("Yolcu Cinsiyeti:" + yolcuCinsiyet);
            //Console.WriteLine("Yolcu Doğum Yaşı: " + yolcuYasi);
            //Console.WriteLine("--------------------------------------");

            #endregion

            #region Klavye İnt Girişleri ve Dönüşümler
            //int shoePrice = 500, computerPrice = 20000, tvPrice = 12000;
            //int shoeCount, computerCount, tvCount;

            //Console.WriteLine("Aldığınız ayakkabı sayısını giriniz: ");
            //shoeCount = Convert.ToInt32(Console.ReadLine());//string ifadeyi int tipine dönüştürdü
            //Console.WriteLine();
            //Console.WriteLine("Aldığınız bilgisayar sayısını giriniz: ");
            //computerCount = int.Parse(Console.ReadLine());//string ifadeyi int tipine dönüştürdü
            //Console.WriteLine();
            //Console.WriteLine("Aldığınız televizyon sayısını giriniz: ");
            //tvCount = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            //int totalPrice = (shoePrice * shoeCount) + (computerPrice * computerCount) + (tvPrice * tvCount);
            //Console.WriteLine("****************************************");
            //Console.WriteLine();
            //Console.WriteLine("Toplam Tutar: " + totalPrice);

            #endregion

            #region Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;
            //Console.WriteLine("1. Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("2. Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());
            //Console.WriteLine();
            //Console.WriteLine("3. Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());
            //Console.WriteLine();
            //result = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınav Ortalaması: " + result);

            #endregion

            Console.Read();



        }
    }
}
