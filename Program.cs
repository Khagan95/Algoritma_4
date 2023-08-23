using System;
using System.Collections.Generic;

namespace ToplamHesaplamaUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("n tane integer ikilileri girin:");
            string[] input = Console.ReadLine().Split(' ');

            ToplamHesaplayici toplamHesaplayici = new ToplamHesaplayici();
            List<int> sonuclar = toplamHesaplayici.ToplamlariHesapla(input);

            foreach (int sonuc in sonuclar)
            {
                Console.Write(sonuc + " ");
            }
        }
    }

    class ToplamHesaplayici
    {
        public List<int> ToplamlariHesapla(string[] input)
        {
            List<int> sonuclar = new List<int>();

            for (int i = 0; i < input.Length; i += 2)
            {
                int sayi1 = Convert.ToInt32(input[i]);
                int sayi2 = Convert.ToInt32(input[i + 1]);

                if (sayi1 != sayi2)
                {
                    sonuclar.Add(sayi1 + sayi2);
                }
                else
                {
                    sonuclar.Add(sayi1 * sayi2);
                }
            }

            return sonuclar;
        }
    }
}
