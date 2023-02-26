using System;

// Podsystem pierwszy
class PodSystemPierwszy
{
    public void MetodaPierwsza()
    {
        Console.WriteLine("Jestem z podsystemu pierwszego.");
    }
}

// Podsystem drugi
class PodSystemDrugi
{
    public void MetodaDruga()
    {
        Console.WriteLine("Jestem z podsystemu drugiego.");
    }
}

// Podsystem trzeci
class PodSystemTrzeci
{
    public void MetodaTrzecia()
    {
        Console.WriteLine("Jestem z podsystemu trzeciego.");
    }
}

// Podsystem czwarty
class PodSystemCzwarty
{
    public void MetodaCzwarta()
    {
        Console.WriteLine("Jestem z podsystemu czwartego.");
    }
}

// Fasada
class Fasada
{
    private PodSystemPierwszy _jeden;
    private PodSystemDrugi _dwa;
    private PodSystemTrzeci _trzy;
    private PodSystemCzwarty _cztery;

    public Fasada()
    {
        _jeden = new PodSystemPierwszy();
        _dwa = new PodSystemDrugi();
        _trzy = new PodSystemTrzeci();
        _cztery = new PodSystemCzwarty();
    }

    public void MetodaA()
    {
        Console.WriteLine("Wywołuję metodę A w fasadzie.");
        _jeden.MetodaPierwsza();
        _dwa.MetodaDruga();
        _cztery.MetodaCzwarta();
    }

    public void MetodaB()
    {
        Console.WriteLine("Wywołuję metodę B w fasadzie.");
        _dwa.MetodaDruga();
        _trzy.MetodaTrzecia();
    }
}

// Program
class Program
{
    static void Main(string[] args)
    {
        Fasada fasada = new Fasada();
        fasada.MetodaA();
        Console.WriteLine();
        fasada.MetodaB();
    }
}
