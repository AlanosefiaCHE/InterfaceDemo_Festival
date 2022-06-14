using System;

namespace MyApp 
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var festival = new Festival(new DateTime(2022, 6, 17, 15, 0, 0), new DateTime(2022, 6, 19, 15, 0, 0));

            DateTime dinsdagVan8 = new DateTime(2022, 6, 14, 8, 0, 0);
            DateTime dinsdagTot12 = new DateTime(2022, 6, 14, 23, 59, 59);

            var snackbar = new Cafe() { Locatie = "A1", Omschrijving = "Patat", Begin = dinsdagVan8, End = dinsdagTot12 };
            var hamburgerTent = new HamburgerTent() { Locatie = "B4", Omschrijving = "Bens Burgers", Begin = dinsdagVan8, End = dinsdagTot12 };
            var sushiTent = new SushiTest() { Locatie = "F1", Omschrijving = "Sans sushi", Begin = dinsdagVan8, End = dinsdagTot12 };
            var ijsTent = new IjsTent() { Locatie = "F4", Omschrijving = "Ijs van Thijs", Begin = dinsdagVan8, End = dinsdagTot12 };
            festival.Map.Add(snackbar);
            festival.Map.Add(hamburgerTent);
            festival.Map.Add(sushiTent);
            festival.Map.Add(ijsTent);

            festival.Manager.Add(snackbar);
            festival.Manager.Add(hamburgerTent);
            festival.Manager.Add(sushiTent);
            festival.Manager.Add(ijsTent);

            festival.Book("Armin van Buuren", "Mainstage", new DateTime(2022, 6, 17, 20, 0, 0));
            festival.Book("Gordon", "Mainstage", new DateTime(2022, 6, 18, 20, 0, 0));
            festival.Book("Ben en Ruurd", "Mainstage", new DateTime(2022, 6, 19, 20, 0, 0));

            var map = festival.GetMap();
            Console.WriteLine(map);

            await festival.Start();
        }
    }
}