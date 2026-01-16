namespace Chat_ovaci_aplikace.Entities
{
    public class Vlakno
    {
        public int IdVlakno { get; set; }
        public string Nazev { get; set; }
        public int IdChaty { get; set; }

        public Chata Chata { get; set; }

        public List<Zprava> Zpravy { get; set; }

        public Vlakno(int idVlakno, string nazev, int idChaty, Chata chata, List<Zprava> zpravy)
        {
            IdVlakno = idVlakno;
            Nazev = nazev;
            IdChaty = idChaty;
            Chata = chata;
            Zpravy = zpravy;
        }
        public Vlakno()
        {
            IdVlakno = 0;
            Nazev = string.Empty;
            IdChaty = 0;
            Chata = new Chata();
            Zpravy = new List<Zprava>();
        }
    }
}
