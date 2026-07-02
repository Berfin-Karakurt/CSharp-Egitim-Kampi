using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region YazdırmaKomutları

            //Console.WriteLine("Hello World!");
            //Console.Write("Selamm");

            //Console.WriteLine("*** Yemek Menüsü ***");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar:");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Tatlılar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine();
            //Console.WriteLine("*** Yemek Menüsü ***");

            #endregion

            #region StringDeğişkenler

            string customerName;
            string customerSurname;
            string customerCity;
            string customerPhoneNo;

            customerName = "Berf";
            customerSurname = "Kara";
            customerCity = "İstanbul";
            customerPhoneNo = "05555555555";

            Console.WriteLine("*** Rezervasyon Kartı ***");
            Console.WriteLine();
            Console.WriteLine("Müşteri: " + customerName+" "+customerSurname);
            Console.WriteLine("Müşteri Numarası: " + customerPhoneNo);
            Console.WriteLine("Müşterinin Geleceği Şehir: " + customerCity);
            Console.WriteLine();
            Console.WriteLine(customerName+"/"+customerSurname+"/"+customerCity+"/"+customerPhoneNo );
            Console.WriteLine();
            Console.WriteLine("*** Rezervasyon Kartı ***");

            #endregion

            #region IntDeğişkenler

            int pizzaPrice = 100;
            int pastaPrice = 80;
            int saladPrice = 50;
            int cokePrice = 20;
            int frenchFriesPrice = 30;
            int waterPrice = 10;

            Console.WriteLine(customerName+" Hanım salata ve su aldı. Total fiyat: "+(saladPrice+waterPrice) );

            #endregion

            Console.Read();
        }
    }
}
