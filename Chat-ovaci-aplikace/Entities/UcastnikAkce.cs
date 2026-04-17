using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chat_ovaci_aplikace.Entities
{
    [Table("UcastnikAkce")]
    [PrimaryKey(nameof(IdUcastnik), nameof(IdAkce))]
    public class UcastnikAkce
    {
        [Key]
        [ForeignKey(nameof(Ucastnik))]
        public int IdUcastnik { get; set; }
        [Key]
        [ForeignKey(nameof(Akce))]
        public int IdAkce { get; set; }

        public virtual Ucastnik Ucastnik { get; set; }
        public virtual Akce Akce { get; set; }

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
