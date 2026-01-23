using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chat_ovaci_aplikace.Entities
{
    [Table("Rezim")]
    public class Rezim
    {
        [Key]
        public int IdRezim { get; set; }
        [ForeignKey(nameof(Den))]
        public int IdDen { get; set; }
        [ForeignKey(nameof(Ucastnik))]
        public int IdUcastnik { get; set; }
        public string Nazev { get; set; }
        public string Popis { get; set; }
        public decimal Cena { get; set; }

        public virtual Den Den { get; set; }
        public virtual Ucastnik Ucastnik { get; set; }

        public Rezim(int idRezim, int idDen, int idUcastnik, string nazev, string popis, decimal cena, Den den, Ucastnik ucastnik)
        {
            IdRezim = idRezim;
            IdDen = idDen;
            IdUcastnik = idUcastnik;
            Nazev = nazev;
            Popis = popis;
            Cena = cena;
            Den = den;
            Ucastnik = ucastnik;
        }

        public Rezim()
        {
            IdRezim = 0;
            IdDen = 0;
            IdUcastnik = 0;
            Nazev = string.Empty;
            Popis = string.Empty;
            Cena = 0;
            Den = new Den();
            Ucastnik = new Ucastnik();
        }
    }
}
