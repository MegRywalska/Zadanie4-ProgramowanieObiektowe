using System;
using System.Collections.Generic;

namespace Zadanie4_ProgramowanieObiektowe
{
    public abstract class ProduktSpozywczy : Produkt
    {
        private decimal kalorie;

        public decimal Kalorie
        {
            get => kalorie;
            set
            {
                if (value < 0) throw new ArgumentOutOfRangeException(nameof(Kalorie), "Kalorie nie moga byc ujemne.");
                kalorie = value;
            }
        }

        private static readonly HashSet<string> KategorieVATSpozywcze = new HashSet<string> { "A", "B", "C" };

        private static readonly HashSet<string> AlergenyPrzewidywane = new HashSet<string>
        {
            "Gluten", "Orzechy", "Laktoza", "Jajka"
        };

        private HashSet<string> alergeny;

        public new string KategoriaVAT
        {
            get => base.KategoriaVAT;
            set
            {
                if (!KategorieVATSpozywcze.Contains(value)) throw new ArgumentException("Niepoprawna kategoria VAT dla produktu spozywczego.");
                base.KategoriaVAT = value;
            }
        }

        public virtual HashSet<string> Alergeny
        {
            get => alergeny ?? new HashSet<string>();
            set
            {
                if (value == null) throw new ArgumentNullException(nameof(Alergeny));
                foreach (var alergen in value)
                {
                    if (!AlergenyPrzewidywane.Contains(alergen)) throw new ArgumentException("Niepoprawny alergen.");
                }
                alergeny = value;
            }
        }
    }
}
