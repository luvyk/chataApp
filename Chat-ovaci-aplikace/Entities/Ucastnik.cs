using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chat_ovaci_aplikace.Entities
{
    [Table("Ucastnik")]
    public class Ucastnik
    {
        [Key]
        public int IdUcastnik { get; set; }
        [ForeignKey(nameof(Uzivatel))]
        public int IdUzivatel { get; set; }
        [ForeignKey(nameof(Chata))]
        public int IdChaty { get; set; }
        public bool Zaplatil { get; set; }
        public bool ZucastniSe { get; set; }
        public decimal sumaCeny { get; set; }

        public virtual Uzivatel Uzivatel { get; set; }
        public virtual Chata Chata { get; set; }

        public virtual List<ObsazeniMista> Mista { get; set; }
        public virtual List<UcastnikAkce> UcastiNaAkcich { get; set; }
        public virtual List<RoleUcastnik> RoleUcastnik { get; set; }
        public virtual List<Ukoly> Ukoly { get; set; }
        public virtual List<Zprava> Zpravy { get; set; }
        //public virtual List<ObsazeniMista> ObsazeniMista {  get; set; }

        public Ucastnik(int idUcastnik, int idUzivatel, int idChaty, bool zaplatil, Uzivatel uzivatel, Chata chata, List<ObsazeniMista> mista, List<UcastnikAkce> ucastiNaAkcich, List<RoleUcastnik> roleUcastnik, List<Ukoly> ukoly, List<Zprava> zpravy, decimal sumaCeny, bool zucastniSe)
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
            this.sumaCeny = sumaCeny;
            ZucastniSe = zucastniSe;
        }
        public Ucastnik()
        {
            IdUcastnik = 0;
            IdUzivatel = 0;
            IdChaty = 0;
            Zaplatil = false;
            ZucastniSe = false;
            Uzivatel = new Uzivatel();
            Chata = new Chata();
            Mista = new List<ObsazeniMista>();
            UcastiNaAkcich = new List<UcastnikAkce>();
            RoleUcastnik = new List<RoleUcastnik>();
            Ukoly = new List<Ukoly>();
            Zpravy = new List<Zprava>();
            sumaCeny = 0;
        }
    }
}
