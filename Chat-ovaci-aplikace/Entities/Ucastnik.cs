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

        public List<Misto> Mista { get; set; }
        public List<UcastnikAkce> UcastiNaAkcich { get; set; }
        public List<RoleUcastnik> RoleUcastnik { get; set; }
        public List<Ukoly> Ukoly { get; set; }
        public List<Zprava> Zpravy { get; set; }

        public Ucastnik(int idUcastnik, int idUzivatel, int idChaty, bool zaplatil, Uzivatel uzivatel, Chata chata, List<Misto> mista, List<UcastnikAkce> ucastiNaAkcich, List<RoleUcastnik> roleUcastnik, List<Ukoly> ukoly, List<Zprava> zpravy)
        {
            IdUcastnik = idUcastnik;
            IdUzivatel = idUzivatel;
            IdChaty = idChaty;
            Zaplatil = zaplatil;
            Uzivatel = uzivatel;
            Chata = chata;
            Mista = mista;
            UcastiNaAkcich = ucastiNaAkcich;
            RoleUcastnik = roleUcastnik;
            Ukoly = ukoly;
            Zpravy = zpravy;
        }
        public Ucastnik()
        {
            IdUcastnik = 0;
            IdUzivatel = 0;
            IdChaty = 0;
            Zaplatil = false;
            Uzivatel = new Uzivatel();
            Chata = new Chata();
            Mista = new List<Misto>();
            UcastiNaAkcich = new List<UcastnikAkce>();
            RoleUcastnik = new List<RoleUcastnik>();
            Ukoly = new List<Ukoly>();
            Zpravy = new List<Zprava>();
        }
    }
}
