namespace MyApp
{
    public class Optreden : IPlannable
    {
        public string Artiest { get; set; }
        public string Podium { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }

        public Optreden(string artiest, string podium, DateTime start)
        {
            this.Artiest = artiest;
            this.Podium = podium;
            this.Begin = start;
            this.End = start.Add(TimeSpan.FromHours(2)); // hardcoded niet echt heel netjes...
        }

        void IPlannable.Start()
        {
            Console.WriteLine($"{DateTime.Now.ToShortDateString()} om {DateTime.Now.ToShortTimeString()}, gepland {Begin.ToShortDateString()} om {Begin.ToShortTimeString()}: {Artiest} start nu met zijn/haar optreden op podium '{Podium}'");
        }

        public void Stop()
        {
            Console.WriteLine($"{DateTime.Now.ToShortDateString()} om {DateTime.Now.ToShortTimeString()}, gepland {End.ToShortDateString()} om {End.ToShortTimeString()}: {Artiest} stopt nu met zijn/haar optreden op podium '{Podium}'");
        }
    }
}