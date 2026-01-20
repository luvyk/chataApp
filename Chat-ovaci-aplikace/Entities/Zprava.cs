using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chat_ovaci_aplikace.Entities
{
    [Table("Zprava")]
    public class Zprava
    {
        [Key]
        public int IdZpravy { get; set; }
        [ForeignKey(nameof(Ucastnik))]
        public int IdUcastnik { get; set; }
        [ForeignKey(nameof(Vlakno))]
        public int IdVlakno { get; set; }
        public string Content { get; set; }

        public virtual Ucastnik Ucastnik { get; set; }
        public virtual Vlakno Vlakno { get; set; }

        public Zprava(int idZpravy, int idUcastnik, int idVlakno, string content, Ucastnik ucastnik, Vlakno vlakno)
        {
            IdZpravy = idZpravy;
            IdUcastnik = idUcastnik;
            IdVlakno = idVlakno;
            Content = content;
            Ucastnik = ucastnik;
            Vlakno = vlakno;
        }
        public Zprava()
        {
            IdZpravy = 0;
            IdUcastnik = 0;
            IdVlakno = 0;
            Content = string.Empty;
            Ucastnik = new Ucastnik();
            Vlakno = new Vlakno();
        }
    }
}
