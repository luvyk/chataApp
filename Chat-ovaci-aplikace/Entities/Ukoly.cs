namespace Chat_ovaci_aplikace.Entities
{
    public class Ukoly
    {
        public int IdUkolu { get; set; }
        public string Nazev { get; set; }
        public int IdUcastnik { get; set; }
        public int IdDen { get; set; }
        public bool Splneno { get; set; }

        public Ucastnik Ucastnik { get; set; }
        public Den Den { get; set; }
    }
}
