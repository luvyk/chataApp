namespace Chat_ovaci_aplikace.Entities
{
    public class Chata
    {
        public int IdChaty { get; set; }
        public string Jmeno { get; set; }
        public decimal Cena { get; set; }
        public DateTime Zacatek { get; set; }
        public DateTime Konec { get; set; }
        public int Kapacita { get; set; }

        public ICollection<Ucastnik> Ucastnici { get; set; }
        public ICollection<Den> Dny { get; set; }
        public ICollection<Mistnost> Mistnosti { get; set; }
        public ICollection<Vlakno> Vlakna { get; set; }
    }
}
