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

            #region If Statement

            //Console.WriteLine("Şifre Giriniz: ");
            //string password;
            //password = Console.ReadLine();
            //if (password == "abcd")
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //     Console.WriteLine("Şifre Yanlış");
            //}

            #endregion
            string capital, country;
            Console.WriteLine("Başkent Adını Giriniz: ");
            capital = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Ülke Adını Giriniz: ");
            country = Console.ReadLine();
            Console.WriteLine();

            //if (capital == "Ankara" && country == "Türkiye")
            //{
            //    Console.WriteLine("Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış");
            //}

            if (string.Equals(capital, "Ankara", StringComparison.OrdinalIgnoreCase) &&
                string.Equals(country, "Türkiye", StringComparison.OrdinalIgnoreCase)) //büyük harf küçük harf duyarsız kod
            {
                Console.WriteLine("Doğru");
            }
            else
            {
                Console.WriteLine("Yanlış");


            }
    }
}
