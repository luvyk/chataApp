namespace Chat_ovaci_aplikace.Entities
{
    public class UcastnikAkce
    {
        public int IdUcastnik { get; set; }
        public int IdAkce { get; set; }

        public Ucastnik Ucastnik { get; set; }
        public Akce Akce { get; set; }
    }
}
