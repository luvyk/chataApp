namespace Chat_ovaci_aplikace.Entities
{
    public class Misto
    {
        public int IdMisto { get; set; }
        public int IdMistnosti { get; set; }
        public int IdUcastnik { get; set; }
        public int IdTyp { get; set; }

        public Mistnost Mistnost { get; set; }
        public Ucastnik Ucastnik { get; set; }
        public Typ Typ { get; set; }

        public Misto(int idMisto, int idMistnosti, int idUcastnik, int idTyp, Mistnost mistnost, Ucastnik ucastnik, Typ typ)
        {
            IdMisto = idMisto;
            IdMistnosti = idMistnosti;
            IdUcastnik = idUcastnik;
            IdTyp = idTyp;
            Mistnost = mistnost;
            Ucastnik = ucastnik;
            Typ = typ;
        }
        public Misto()
        {
            IdMisto = 0;
            IdMistnosti = 0;
            IdUcastnik = 0;
            IdTyp = 0;
            Mistnost = new Mistnost();
            Ucastnik = new Ucastnik();
            Typ = new Typ();
        }
    }
}
