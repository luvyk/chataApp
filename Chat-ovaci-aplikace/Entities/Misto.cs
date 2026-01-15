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
    }
}
