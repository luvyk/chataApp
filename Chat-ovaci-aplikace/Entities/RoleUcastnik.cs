namespace Chat_ovaci_aplikace.Entities
{
    public class RoleUcastnik
    {
        public int IdUcastnik { get; set; }
        public int IdRole { get; set; }

        public Ucastnik Ucastnik { get; set; }
        public Role Role { get; set; }

        public RoleUcastnik(int idUcastnik, int idRole, Ucastnik ucastnik, Role role)
        {
            IdUcastnik = idUcastnik;
            IdRole = idRole;
            Ucastnik = ucastnik;
            Role = role;
        }
        public RoleUcastnik()
        {
            IdUcastnik = 0;
            IdRole = 0;
            Ucastnik = new Ucastnik();
            Role = new Role();
        }
    }
}
