using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chat_ovaci_aplikace.Entities
{
    [Table("Uzivatel")]
    public class Uzivatel
    {
        [Key]
        public int IdUzivatel { get; set; }
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public string Heslo { get; set; }

        public List<Ucastnik> Ucastnici { get; set; }
        public List<PrihlasenyUZ> Prihlaseni { get; set; }

        public Uzivatel(int idUzivatel, string jmeno, string prijmeni, string heslo, List<Ucastnik> ucastnici, List<PrihlasenyUZ> prihlaseni)
        {
            IdUzivatel = idUzivatel;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Heslo = heslo;
            Ucastnici = ucastnici;
            Prihlaseni = prihlaseni;
        }
        public Uzivatel()
        {
            IdUzivatel = 0;
            Jmeno = string.Empty;
            Prijmeni = string.Empty;
            Heslo = string.Empty;
            Ucastnici = new List<Ucastnik>();
            Prihlaseni = new List<PrihlasenyUZ>();
        }
    }
}
