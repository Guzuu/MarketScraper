
namespace MarketScraper
{
    /// <summary>
    /// Client class containing personal data template
    /// </summary>
    public class Client
    {
        public Client()
        {

        }

        public Client(string imie, string nazwisko, string miasto, string ulica, string KP, int tel)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.miasto = miasto;
            this.ulica = ulica;
            this.KP = KP;
            this.tel = tel;
        }

            public string imie { get; private set; }
            public string nazwisko { get; private set; }
            public string miasto { get; private set; }
            public string ulica { get; private set; }
            public string KP { get; private set; }
            public int tel { get; private set; }
    }
}
