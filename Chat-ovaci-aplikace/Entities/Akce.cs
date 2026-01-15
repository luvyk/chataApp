namespace Chat_ovaci_aplikace.Entities
{
    public class Akce
    {
        public int IdAkce { get; set; }
        public string Nazev { get; set; }
        public DateTime CasOd { get; set; }
        public DateTime CasDo { get; set; }
        public decimal CenaNavic { get; set; }

        public List<UcastnikAkce> Ucastnici { get; set; }

        public Akce(int idAkce, string nazev, DateTime casOd, DateTime casDo, decimal cenaNavic, List<UcastnikAkce> ucastnici)
        {
            IdAkce = idAkce;
            Nazev = nazev;
            CasOd = casOd;
            CasDo = casDo;
            CenaNavic = cenaNavic;
            Ucastnici = ucastnici;
        }
        public Akce()
        {
            IdAkce = 0;
            Nazev = string.Empty;
            CasOd = DateTime.Now;
            CasDo = DateTime.Now;
            CenaNavic = 0;
            Ucastnici = new List<UcastnikAkce>();
        }
    }
}
