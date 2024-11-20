internal class Program
{
    public abstract class Zivotinja
    {
        public string Ime { get; set; } = "Miki";
        public int Starost { get; set; } = 0;

        protected Zivotinja()
        {
            
        }
        public Zivotinja(string ime, int starost)
        {
            Ime = ime;
            Starost = starost;
        }
        public abstract void Zvuk();
    }

    class Pas : Zivotinja
    {
        public Pas():base()
        {
            
        }
        public Pas(string ime, int starost): base(ime, starost) { }
        public override void Zvuk()
        {
            Console.WriteLine("Woof!");
        }
    }

    class Macka : Zivotinja
    {
        public Macka(string ime, int starost):base(ime, starost){ 
        }

        public override void Zvuk()
        {
            Console.WriteLine("Meow!");
        }
    }

    private static void Main(string[] args)
    {
        Pas pas = new Pas("Rex",3);
        pas.Ime = "Bleki";
        pas.Zvuk();
        Console.WriteLine(pas.Ime);

        Macka macka = new Macka("Boby", 2);
        macka.Zvuk();
    }
}