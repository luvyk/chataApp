using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chat_ovaci_aplikace.Entities
{
    [Table("Misto")]
    public class Misto
    {
        [Key]
        public int IdMisto { get; set; }
        [ForeignKey(nameof(Mistnost))]
        public int IdMistnosti { get; set; }
        [ForeignKey(nameof(Ucastnik))]
        public int IdUcastnik { get; set; }
        [ForeignKey(nameof(Typ))]
        public int IdTyp { get; set; }
        public decimal CenaMista { get; set; }

        public virtual Mistnost Mistnost { get; set; }
        public virtual Ucastnik Ucastnik { get; set; }
        public virtual Typ Typ { get; set; }

        public Misto(int idMisto, int idMistnosti, int idUcastnik, int idTyp, decimal cenaMista, Mistnost mistnost, Ucastnik ucastnik, Typ typ)
        {
            IdMisto = idMisto;
            IdMistnosti = idMistnosti;
            IdUcastnik = idUcastnik;
            IdTyp = idTyp;
            CenaMista = cenaMista;
            Mistnost = mistnost;
            Ucastnik = ucastnik;
            Typ = typ;
        }
        public Misto()
        {
            IdMisto = 0;
            IdMistnosti = 0;
            IdUcastnik = 0;
            IdTyp = 0;
            CenaMista = 0;
            Mistnost = new Mistnost();
            Ucastnik = new Ucastnik();
            Typ = new Typ();
        }
    }
}
