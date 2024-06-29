using System;
using System.Collections.Generic;

namespace Zadanie4_ProgramowanieObiektowe
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ProduktSpozywczyPaczka paczka = new ProduktSpozywczyPaczka
                {
                    Nazwa = "Ciastka",
                    CenaNetto = 10.0m,
                    KategoriaVAT = "A",
                    KrajPochodzenia = "Polska",
                    Kalorie = 450,
                    Waga = 0.5m,
                    Alergeny = new HashSet<string> { "Gluten", "Jajka" }
                };

                Console.WriteLine($"Produkt: {paczka.Nazwa}");
                Console.WriteLine($"Cena netto: {paczka.CenaNetto}");
                Console.WriteLine($"Cena brutto: {paczka.CenaBrutto}");
                Console.WriteLine($"Kategoria VAT: {paczka.KategoriaVAT}");
                Console.WriteLine($"Kraj pochodzenia: {paczka.KrajPochodzenia}");
                Console.WriteLine($"Kalorie: {paczka.Kalorie}");
                Console.WriteLine($"Waga: {paczka.Waga}");
                Console.WriteLine($"Alergeny: {string.Join(", ", paczka.Alergeny)}");

                Wielopak wielopak = new Wielopak
                {
                    Produkt = paczka,
                    Ilosc = 10,
                    CenaNetto = 95.0m
                };

                Console.WriteLine("\nWielopak:");
                Console.WriteLine($"Produkt: {wielopak.Produkt.Nazwa}");
                Console.WriteLine($"Ilosc: {wielopak.Ilosc}");
                Console.WriteLine($"Cena netto: {wielopak.CenaNetto}");
                Console.WriteLine($"Cena brutto: {wielopak.CenaBrutto}");
                Console.WriteLine($"Kategoria VAT: {wielopak.KategoriaVAT}");
                Console.WriteLine($"Kraj pochodzenia: {wielopak.KrajPochodzenia}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Blad: {ex.Message}");
            }
        }
    }
}
