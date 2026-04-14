using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chat_ovaci_aplikace.Entities
{
    [Table("Ukoly")]
    public class Ukoly
    {
        [Key]
        public int IdUkolu { get; set; }
        public string Nazev { get; set; }
        public string? Popis { get; set; }
        [ForeignKey(nameof(Ucastnik))]
        public int IdUcastnik { get; set; }
        [ForeignKey(nameof(Den))]
        public int IdDen { get; set; }
        public bool Splneno { get; set; }

        public virtual Ucastnik Ucastnik { get; set; }
        public virtual Den Den { get; set; }

        public Ukoly(int idUkolu, string nazev, string popis, int idUcastnik, int idDen, bool splneno, Ucastnik ucastnik, Den den)
        {
            IdUkolu = idUkolu;
            Nazev = nazev;
            Popis = popis;
            IdUcastnik = idUcastnik;
            IdDen = idDen;
            Splneno = splneno;
            Ucastnik = ucastnik;
            Den = den;
        }
        public Ukoly()
        {
            IdUkolu = 0;
            Nazev = string.Empty;
            Popis = string.Empty;
            IdUcastnik = 0;
            IdDen = 0;
            Splneno = false;
            Ucastnik = new Ucastnik();
            Den = new Den();
        }
    }
}
