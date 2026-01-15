using System.Collections.Generic;

namespace Chat_ovaci_aplikace.Entities
{
    public class Ucastnik
    {
        public int IdUcastnik { get; set; }
        public int IdUzivatel { get; set; }
        public int IdChaty { get; set; }
        public bool Zaplatil { get; set; }

        public Uzivatel Uzivatel { get; set; }
        public Chata Chata { get; set; }

        public ICollection<Misto> Mista { get; set; }
        public ICollection<UcastnikAkce> UcastiNaAkcich { get; set; }
        public ICollection<RoleUcastnik> RoleUcastnik { get; set; }
        public ICollection<Ukoly> Ukoly { get; set; }
        public ICollection<Zprava> Zpravy { get; set; }
    }
}
