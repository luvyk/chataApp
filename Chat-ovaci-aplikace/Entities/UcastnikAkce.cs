using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chat_ovaci_aplikace.Entities
{
    [Table("UcastnikAkce")]
    public class UcastnikAkce
    {
        [Key]
        public int IdUcastnik { get; set; }
        [ForeignKey(nameof(Akce))]
        public int IdAkce { get; set; }

        public Ucastnik Ucastnik { get; set; }
        public Akce Akce { get; set; }

        public UcastnikAkce(int idUcastnik, int idAkce, Ucastnik ucastnik, Akce akce)
        {
            IdUcastnik = idUcastnik;
            IdAkce = idAkce;
            Ucastnik = ucastnik;
            Akce = akce;
        }
        public UcastnikAkce()
        {
            IdUcastnik = 0;
            IdAkce = 0;
            Ucastnik = new Ucastnik();
            Akce = new Akce();
        }
    }
}
