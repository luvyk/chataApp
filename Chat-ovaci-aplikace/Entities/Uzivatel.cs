namespace Chat_ovaci_aplikace.Entities
{
    public class Uzivatel
    {
        public int IdUzivatel { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Heslo { get; set; }

        public ICollection<Ucastnik> Ucastnici { get; set; }
        public ICollection<PrihlasenyUZ> Prihlaseni { get; set; }
    }
}
