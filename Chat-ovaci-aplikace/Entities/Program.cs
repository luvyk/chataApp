namespace Chat_ovaci_aplikace.Entities
{
    public class Program
    {
        public int IdProgramu { get; set; }
        public int IdDen { get; set; }
        public string Nazev { get; set; }
        public DateTime CasZacatku { get; set; }
        public DateTime CasKonce { get; set; }

        public Den Den { get; set; }
    }
}
