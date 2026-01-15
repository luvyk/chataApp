namespace Chat_ovaci_aplikace.Entities
{
    public class PrihlasenyUZ
    {
        public int IdPrihlaseni { get; set; }
        public DateTime DateTimePrihlaseni { get; set; }
        public string Token { get; set; }
        public int IdUzivatel { get; set; }

        public Uzivatel Uzivatel { get; set; }
    }
}
