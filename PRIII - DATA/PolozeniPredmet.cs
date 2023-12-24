namespace PRIII___DATA
{
    public class PolozeniPredmet
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int PredmetId { get; set; }
        public int Ocjena {get; set; }
        public DateTime DatumPolaganja { get; set; }

        public Student Student { get; set; }
        public Predmet Predmet { get; set; }
        public string Napomena { get; set; }

    }
}
