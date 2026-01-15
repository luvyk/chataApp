namespace Chat_ovaci_aplikace.Entities
{
    public class RoleUcastnik
    {
        public int IdUcastnik { get; set; }
        public int IdRole { get; set; }

        public Ucastnik Ucastnik { get; set; }
        public Role Role { get; set; }
    }
}
