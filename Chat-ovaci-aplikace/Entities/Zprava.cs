namespace Chat_ovaci_aplikace.Entities
{
    public class Zprava
    {
        public int IdZpravy { get; set; }
        public int IdUcastnik { get; set; }
        public int IdVlakno { get; set; }
        public string Content { get; set; }

        public Ucastnik Ucastnik { get; set; }
        public Vlakno Vlakno { get; set; }

        public Zprava(int idZpravy, int idUcastnik, int idVlakno, string content, Ucastnik ucastnik, Vlakno vlakno)
        {
            IdZpravy = idZpravy;
            IdUcastnik = idUcastnik;
            IdVlakno = idVlakno;
            Content = content;
            Ucastnik = ucastnik;
            Vlakno = vlakno;
        }
        public Zprava()
        {
            IdZpravy = 0;
            IdUcastnik = 0;
            IdVlakno = 0;
            Content = string.Empty;
            Ucastnik = new Ucastnik();
            Vlakno = new Vlakno();
        }
    }
}
