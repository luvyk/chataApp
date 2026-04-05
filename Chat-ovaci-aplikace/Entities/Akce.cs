using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chat_ovaci_aplikace.Entities
{
    [Table("Akce")]
    public class Akce
    {
        [Key]
        public int IdAkce { get; set; }
        public int IdDen { get; set; }
        public string Nazev { get; set; }
        public string? Popis { get; set; }
        public DateTime CasOd { get; set; }
        public DateTime? CasDo { get; set; }
        public decimal? CenaNavic { get; set; }

        public virtual Den Den { get; set; }

        public virtual List<UcastnikAkce> Ucastnici { get; set; }

        public Akce(int idAkce, string nazev, string popis,DateTime casOd, DateTime casDo, decimal cenaNavic, List<UcastnikAkce> ucastnici, int idDen, Den den)
        {
            IdAkce = idAkce;
            Nazev = nazev;
            Popis = popis;
            CasOd = casOd;
            CasDo = casDo;
            CenaNavic = cenaNavic;
            Ucastnici = ucastnici;
            IdDen = idDen;
            Den = den;
        }
        public Akce()
        {
            IdAkce = 0;
            IdDen = 0;
            Nazev = string.Empty;
            Popis = string.Empty;
            CasOd = DateTime.Now;
            CasDo = DateTime.Now;
            CenaNavic = 0;
            Ucastnici = new List<UcastnikAkce>();
            Den = new Den();
        }
    }
}
