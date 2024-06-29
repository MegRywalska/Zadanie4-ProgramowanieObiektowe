using System;
using System.Collections.Generic;

namespace Zadanie4_ProgramowanieObiektowe
{
    public abstract class Produkt
    {
        private decimal cenaNetto;
        private static readonly Dictionary<string, decimal> KategorieVAT = new Dictionary<string, decimal>
        {
            { "A", 0.23m },
            { "B", 0.08m },
            { "C", 0.05m },
            { "D", 0.0m }
        };
        private static readonly HashSet<string> KrajePochodzenia = new HashSet<string>
        {
            "Polska", "Niemcy", "Francja", "Wlochy"
        };

        private string krajPochodzenia; // dodane pole prywatne

        public string Nazwa { get; set; }

        public decimal CenaNetto
        {
            get => cenaNetto;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(CenaNetto), "Cena netto nie moze byc ujemna.");
                cenaNetto = value;
            }
        }

        private string kategoriaVAT;
        public string KategoriaVAT
        {
            get => kategoriaVAT;
            set
            {
                if (!KategorieVAT.ContainsKey(value)) throw new ArgumentException("Niepoprawna kategoria VAT.");
                kategoriaVAT = value;
            }
        }

        public virtual decimal CenaBrutto => CenaNetto * (1 + StawkaVAT());

        public string KrajPochodzenia
        {
            get => krajPochodzenia;
            set
            {
                if (!KrajePochodzenia.Contains(value)) throw new ArgumentException("Niepoprawny kraj pochodzenia.");
                krajPochodzenia = value;
            }
        }

        public decimal StawkaVAT()
        {
            return KategorieVAT[KategoriaVAT];
        }
    }
}