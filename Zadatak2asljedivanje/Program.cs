internal class Program
{
    class Radnik
    {
        public string Ime { get; set; }
        public int GodinaRodjenja { get; set; }
        public Radnik(string ime, int godina)
        {
            Ime = ime;
            GodinaRodjenja = godina;
        }

        public void IspisiPodatke()
        {
            Console.WriteLine("Ime {0}, Godina {1}", Ime, GodinaRodjenja);
        }
    }

    class Menadzer:Radnik
    {
        public string Odjel { get; set; }
        public Menadzer(string ime, int godina, string odjel) : base(ime,godina)
        {
            Odjel = odjel;
        }
        public void IspisiPodatke()
        {
            base.IspisiPodatke();
            Console.WriteLine("Odjel {0}", Odjel);
        }

    }
    private static void Main(string[] args)
    {
        //Kreiraj baznu klasu Radnik sa konstruktorom koji iniijalizuje Ime i GodinuRodjenja
        //Kreiraj izvedenu klasu Menadzer koja najljeduje Radnik, ali dodaje atribut Odjel(string)
        //U obje klase, koristiti konstruktor bazne klase. U glavnom programu kreirati obje klase i ispisati atribute
        
        Radnik r = new Radnik("Ime1", 1999);
        Menadzer m = new Menadzer("Ime2", 1987,"HR");
        r.IspisiPodatke();
        m.IspisiPodatke();
    }
}