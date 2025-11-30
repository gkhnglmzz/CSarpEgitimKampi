using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel dizi Örnekleri

            //2,4,6,8
            //sarı,kırmızı,mavi,turuncu,beyaz
            //adana,ankara, istanbul,bursa
            //DeğişkenTürü [] DiziAdı = new DeğişkenTürü[ElamanSayısı]

            //string[] colors = new string[4];

            //colors[0] = "Kırmızı";
            //colors[1] = "Sarı";
            //colors[2] = "Beyaz";
            //colors[3] = "Mavi";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];

            //cities[0] = "Milano";
            //cities[1] = "Budapeşte";
            //cities[2] = "Lyon";
            //cities[3] = "Kahire";
            //cities[4] = "Üsküp";

            //Console.WriteLine(cities[4]);

            //int[] numbers = new int[10];
            //numbers[0] = 50;
            //numbers[1] = 48;
            //numbers[2] = 698;
            //numbers[3] = 24;
            //numbers[7] = 748;

            //Console.WriteLine(numbers[5]);

            //string[] cities = { "Prag", "Roma", "Atina", "Ankara", "Bursa" };

            //Console.WriteLine(cities[4]);

            #endregion

            #region Dizideki Tüm elamanları Listeleme

            //string[] colors = { "Sarı", "Kırmızı", "Beyaz", "Mavi", "Yeşil", "Turuncu", "Pembe" };

            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] number = { 1, 2, 33, 4, 5, 56, 75, 88, 90 };

            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i] % 3 == 0)
            //    {
            //        Console.WriteLine(number[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h' };

            //for (int i = 0; i < symbols.Length; i++)
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 47, 85, 95, 41, 25, 635, 789, 86, 100 };
            //int maxNumber = myArray[0];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }

            //}
            //Console.WriteLine(maxNumber);

            //string[] persons = { "ali", "ayşe", "akif", "mehmet", "suzan", "gökhan", "yusuf" };

            //Console.WriteLine(persons.Length);

            //int[] numbers = { 31, 22, 333, 42, 5, 63, 72, 8, 39, 10, 121 };
            //Array.Sort(numbers);

            //for(int i = 0;i< numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 31, 22, 333, 42, 5, 63, 72, 8, 39, 10, 121 };
            //Array.Reverse(numbers);

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            #endregion

            #region Dizi Metotları

            //string[] customers = { "ali", "ayşe", "akif", "mehmet", "suzan", "gökhan", "yusuf" };

            //int index = Array.IndexOf(customers, "akif");
            //Console.WriteLine(index);

            //int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Console.WriteLine("Dizinin En Büyük Elamanı: " + numbers.Max() + "Dizinin en küçük elamanı: " + numbers.Min());



            #endregion


            #region Kullanıcıdan değer alma

            //string[] cities = new string[5];

            //for(int i = 0;i< cities.Length; i++)
            //{
            //    Console.Write($"Lütfen{i + 1}. Şehri Giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}

            //Console.WriteLine();
            //Console.WriteLine("------------");

            //for(int i = 0; i< cities.Length; i++)
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = {10, 20, 30,40,50};
            //int sum = 0;

            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    sum += numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 21, 23, 32, 34, 45, 65, 47, 68, 89, 70 };
            //Console.WriteLine("Çift Sayılar");
            //Console.WriteLine();


            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if(numbers[i] % 2 == 0)
            //    {
            //            Console.WriteLine(numbers[i]);
            //    }
            //}

            //Console.WriteLine("------------------");
            //Console.WriteLine("Tek Sayılar");
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}



            #endregion



            Console.Read();
        }
    }
}
