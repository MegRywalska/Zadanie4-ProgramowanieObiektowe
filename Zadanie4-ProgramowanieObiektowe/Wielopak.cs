namespace Zadanie4_ProgramowanieObiektowe;

public class Wielopak
{
    public Produkt Produkt { get; set; }
    public ushort Ilosc { get; set; }
    public decimal CenaNetto { get; set; }
    public decimal CenaBrutto => CenaNetto * (1 + Produkt.StawkaVAT());

    public string KategoriaVAT => Produkt.KategoriaVAT;
    public string KrajPochodzenia => Produkt.KrajPochodzenia;
}