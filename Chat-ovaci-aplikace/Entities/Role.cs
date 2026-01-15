namespace Chat_ovaci_aplikace.Entities
{
    public class Role
    {
        public int IdRole { get; set; }
        public string Nazev { get; set; }

        public ICollection<RoleUcastnik> RoleUcastnik { get; set; }
    }
}
