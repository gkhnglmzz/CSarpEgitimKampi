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

            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.WriteLine("***** Yemek Kategorileri ******");
            //Console.WriteLine();
            //Console.WriteLine("1-Çorbalar");
            //Console.WriteLine("2-Ana Yemekler");
            //Console.WriteLine("3-Soğuk Başlangıçlar");
            //Console.WriteLine("4-Tatlılar");
            //Console.WriteLine("5-İçecekler");
            //Console.WriteLine("6-Salatalar");
            //Console.WriteLine();
            //Console.WriteLine("***** Yemek Kategorileri ******");


            #endregion


            #region StringDeğişkenler

            //string
            //Değişken_türü  değişken_adı;

            //string name;
            //name = "Gökhan";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Gökhann";
            //customerSurname = "Gülmez";
            //customerPhone = "5358965050";
            //customerEmail = "denedik@gmail.com";
            //district = "Keçiören";
            //city = "Ankara";

            //Console.WriteLine("*****Rezervasyon Kartı******");
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone );
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres:" + district + " / " +city);
            //Console.WriteLine("------------------------------------");

            //Console.WriteLine();

            //customerName = "Mehmet";
            //customerSurname = "Gevrek";
            //customerPhone = "5369587542";
            //customerEmail = "test@gmail.com";
            //district = "Polatlı";
            //city = "Ankara";


            //Console.WriteLine("------------------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres:" + district + " / " + city);
            //Console.WriteLine("------------------------------------");


            #endregion

            #region Int Değişkenler

            ////int
            //int number = 24;
            //Console.WriteLine(number);

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("***** Restoran Menü Fiyatları *********");
            Console.WriteLine();
            Console.WriteLine("------Hamburger :" + hamburgerPrice + " TL ");
            Console.WriteLine("------Pizza:" + pizzaPrice + " TL");
            Console.WriteLine("------kola :" + cokePrice + " TL ");
            Console.WriteLine("------limonata :" + lemonadePrice + " TL ");
            Console.WriteLine("------kızartma :" + friesPrice + " TL ");
            Console.WriteLine("------kola :" + waterPrice + " TL ");
            Console.WriteLine();
            Console.WriteLine("***** Restoran Menü Fiyatları *********");

            Console.WriteLine();

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;
            totalPizzaPrice= pizzaCount * pizzaPrice;
            totalWaterPrice= waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;

            Console.WriteLine("---------------");
            Console.WriteLine("Hamburger tutarı :" + totalHamburgerPrice + " TL");
            Console.WriteLine("Pizza tutarı :" + totalPizzaPrice + " TL");
            Console.WriteLine("kızartma tutarı :" + totalFriesPrice + " TL");
            Console.WriteLine("kola  tutarı :" + totalCokePrice + " TL");
            Console.WriteLine("limonata tutarı :" + totalLemonadePrice + " TL");
            Console.WriteLine("Su tutarı :" + totalWaterPrice + " TL");


            Console.WriteLine();

            int totalPrice= totalCokePrice+totalLemonadePrice+totalWaterPrice+totalHamburgerPrice+totalPizzaPrice+totalFriesPrice;
            Console.WriteLine("Toplam ödenecek tutar:" + totalPrice + "TL");
            #endregion


            Console.Read();
        }
    }
}




// acıklama yapmaya yarar  Yazdırma komutları
