internal class Program
{
    abstract class Zaposlenik
    {
        public string name = "";
        public abstract double Plata();
        public abstract void PrikazInformacija();
        public void ObracunajPorez()
        {
            Console.WriteLine("Porez je {0}", Plata()*0.15);
        }
    }

    class Radnik : Zaposlenik
    {
        public Radnik(string name)
        {
            this.name = name;
        }
        public override double Plata()
        {
            return 1500;
        }

        public override void PrikazInformacija()
        {
            Console.WriteLine($"Ime: {name}, pozicija: Radnik, plata: {Plata()}");
        }
    }

    class Direktor : Zaposlenik
    {
        public double Bonus { get; set; }
        public Direktor(string name, double Bonus)
        {
            this.name=name;
            this.Bonus = Bonus;
        }
        public override double Plata()
        {
            return 5000 + Bonus;
        }
        public override void PrikazInformacija()
        {
            Console.WriteLine($"Ime: {name}, pozicija: Direktor, plata: {Plata()}, bonus: {Bonus}");
        }
    }
    private static void Main(string[] args)
    {
      //Kreirati apstraktnu klasu Zaposleni sa metodama Plata(), PrikazInformacija() i ObracunajPorez(). Klase Direktor i Radnik koje implementiraju metodu plata
      //porez je plata*0.15
      //Direktor Bonus, plata je plata +bonus
      //Zaposleni ima atribut ime
      //Plata default zaposlenik 1500, direktor 5000

        Radnik radnik = new Radnik("DobarRadnik");
        Direktor direktor = new Direktor("DirektorSamoTakav", 20);

        radnik.PrikazInformacija();
        radnik.ObracunajPorez();

        direktor.PrikazInformacija();
        direktor.ObracunajPorez();
    }
}