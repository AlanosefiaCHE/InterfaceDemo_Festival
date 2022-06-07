namespace MyApp
{
    public class Optreden
    {
        public string Artiest { get; set; }
        public string Podium { get; set; }
        public DateTime Start { get; set; }

        public Optreden(string artiest, string podium, DateTime start)
        {
            this.Artiest = artiest;
            this.Podium = podium;
            this.Start = start;
        }
    }
}