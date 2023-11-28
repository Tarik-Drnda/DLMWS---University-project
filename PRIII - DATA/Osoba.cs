namespace PRIII___DATA
{
    public abstract class Osoba
    {
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }
        public virtual void PredstaviSe()
        {
            Console.WriteLine("Predstavlja se ");
        }
        public abstract void info();

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }


}