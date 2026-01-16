namespace Chat_ovaci_aplikace.Entities
{
    public class Role
    {
        public int IdRole { get; set; }
        public string Nazev { get; set; }

        public List<RoleUcastnik> RoleUcastnik { get; set; }

        public Role(int idRole, string nazev, List<RoleUcastnik> roleUcastnik)
        {
            IdRole = idRole;
            Nazev = nazev;
            RoleUcastnik = roleUcastnik;
        }
        public Role()
        {
            IdRole = 0;
            Nazev = string.Empty;
            RoleUcastnik = new List<RoleUcastnik>();
        }
    }
}
