namespace Chat_ovaci_aplikace.Entities
{
    public class Vlakno
    {
        public int IdVlakno { get; set; }
        public string Nazev { get; set; }
        public int IdChaty { get; set; }

        public Chata Chata { get; set; }

        public ICollection<Zprava> Zpravy { get; set; }
    }
}
