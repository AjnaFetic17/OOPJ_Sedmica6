internal class Program
{
    class Vozilo
    {
        public string Marka { get; set; }
        public int GodinaProizvodnje { get; set; }

        public virtual void Pokreni()
        {
            Console.WriteLine("Vozilo marke {0} iz {1} je pokrenuto.", Marka, GodinaProizvodnje);
        }

        public void Zaustavi()
        {
            Console.WriteLine("Vozilo marke {0} je zaustavljeno", Marka);
        }
    }

    class Automobil : Vozilo
    {
        public int BrojVrata { get; set; }

        public override void Pokreni()
        {
            Console.WriteLine("Automobil marke {0} iz {1} godine, s brojem vrata {2} je pokrenuto.", Marka, GodinaProizvodnje, BrojVrata);
        }
        public void Sviraj()
        {
            Console.WriteLine("Automobil marke {0}, s brojem vrata {1} svira.", Marka, BrojVrata);
        }
    }

    class Bicikl : Vozilo
    {
        public bool ImaKorpu { get; set; }

        public void Zvoni()
        {
            Console.WriteLine("Bicikl marke {0} zvoni.", Marka);
        }
    }

    private static void Main(string[] args)
    {
        Automobil automobil = new Automobil();
        automobil.Marka = "Toyota";
        automobil.GodinaProizvodnje = 2020;
        automobil.BrojVrata = 5;

        automobil.Pokreni();
        automobil.Sviraj();
        automobil.Zaustavi();

        Bicikl bicikl = new Bicikl();
        bicikl.Marka = "Trek";
        bicikl.GodinaProizvodnje = 2021;
        bicikl.ImaKorpu = true;

        bicikl.Pokreni();
        bicikl.Zvoni();
        bicikl.Zaustavi();
    }
}