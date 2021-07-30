using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Java";
            string kurs2 = "c#";
            string kurs3 = "c";
            string kurs4 = "React";
            string kurs5 = "Bootstrap";
            string kurs6 = "Angular";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);
            Console.WriteLine(kurs5);
            Console.WriteLine(kurs6);

            string[] kurslar = new string[]
            {
                kurs6,kurs5,kurs4,kurs3,kurs2,kurs1
            };
            foreach (var item in kurslar)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("******************************");
            for(int i=0;i<kurslar.Length;i++)
            {
                Console.WriteLine(kurslar[i]);
            }
        }
    }
}
