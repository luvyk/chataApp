namespace Chat_ovaci_aplikace.Entities
{
    public class UcastnikAkce
    {
        public int IdUcastnik { get; set; }
        public int IdAkce { get; set; }

        public Ucastnik Ucastnik { get; set; }
        public Akce Akce { get; set; }

        public UcastnikAkce(int idUcastnik, int idAkce, Ucastnik ucastnik, Akce akce)
        {
            IdUcastnik = idUcastnik;
            IdAkce = idAkce;
            Ucastnik = ucastnik;
            Akce = akce;
        }
        public UcastnikAkce()
        {
            IdUcastnik = 0;
            IdAkce = 0;
            Ucastnik = new Ucastnik();
            Akce = new Akce();
        }
    }
}
