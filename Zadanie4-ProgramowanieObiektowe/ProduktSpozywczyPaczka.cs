namespace Zadanie4_ProgramowanieObiektowe;

public class ProduktSpozywczyPaczka : ProduktSpozywczy
{
    private decimal waga;

    public decimal Waga
    {
        get => waga;
        set
        {
            if (value < 0) throw new ArgumentOutOfRangeException(nameof(Waga), "Waga nie moze byc ujemna.");
            waga = value;
        }
    }
}