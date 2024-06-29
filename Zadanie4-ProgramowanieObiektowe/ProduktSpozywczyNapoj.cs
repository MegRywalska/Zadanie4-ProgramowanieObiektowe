namespace Zadanie4_ProgramowanieObiektowe;


public class ProduktSpozywczyNapoj : ProduktSpozywczyPaczka
{
    private uint objetosc;

    public uint Objetosc
    {
        get => objetosc;
        set
        {
            if (value < 0) throw new ArgumentOutOfRangeException(nameof(Objetosc), "Objetosc nie moze byc ujemna.");
            objetosc = value;
        }
    }
}