﻿using System;

namespace donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam = 0;
            while (sayac <= sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);

            char character = 'a';
            while (character < 'z')
            {
                Console.Write(character);
                character++;
            }

            //foreach
            string[] arabalar = { "BMV", "Volvo", "Toyota", "Nissan", "Ford" };
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
