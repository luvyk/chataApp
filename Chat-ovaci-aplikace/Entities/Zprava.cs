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
    }
}
