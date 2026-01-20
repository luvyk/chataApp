using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chat_ovaci_aplikace.Entities
{
    [Table("Vlakno")]
    public class Vlakno
    {
        [Key]
        public int IdVlakno { get; set; }
        public string Nazev { get; set; }
        [ForeignKey(nameof(Chata))]
        public int IdChaty { get; set; }

        public virtual Chata Chata { get; set; }

        public virtual List<Zprava> Zpravy { get; set; }

        public Vlakno(int idVlakno, string nazev, int idChaty, Chata chata, List<Zprava> zpravy)
        {
            IdVlakno = idVlakno;
            Nazev = nazev;
            IdChaty = idChaty;
            Chata = chata;
            Zpravy = zpravy;
        }
        public Vlakno()
        {
            IdVlakno = 0;
            Nazev = string.Empty;
            IdChaty = 0;
            Chata = new Chata();
            Zpravy = new List<Zprava>();
        }
    }
}
