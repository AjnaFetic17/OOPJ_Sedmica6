internal class Program
{
    public interface IVozilo
    {
        public string Marka { get; set; }
        public int GodinaProizvodnje { get; set; }

        void Pokreni();
        void Zaustavi();
    }

    class Automobil : IVozilo
    {
        public string Marka { get ; set; } = "BMW";
        public int GodinaProizvodnje { get; set; }

        public void Pokreni()
        {
            Console.WriteLine("Automobil je pokrenut");
        }

        public void Zaustavi()
        {
            Console.WriteLine("Automobil je zaustavljen");
        }
    }

    class Bicikl : IVozilo
    {
        public string Marka { get ; set; }
        public int GodinaProizvodnje { get; set; }

        public void Pokreni()
        {
            Console.WriteLine("Bicikl je pokrenut");
        }

        public void Zaustavi()
        {
            Console.WriteLine("Bicikl je zaustavljen");
        }
    }

    private static void Main(string[] args)
    {
        IVozilo vozilo = new Automobil();
        IVozilo vozilo2 = new Bicikl();

        vozilo.Pokreni();

        Console.WriteLine(vozilo.Marka);
        vozilo2.Pokreni();

        vozilo.Zaustavi();
        vozilo2.Zaustavi();
    }
}