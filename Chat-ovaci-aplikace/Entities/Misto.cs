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
        public int IdTyp { get; set; }

        public Mistnost Mistnost { get; set; }
        public Ucastnik Ucastnik { get; set; }
        public Typ Typ { get; set; }

        public Misto(int idMisto, int idMistnosti, int idUcastnik, int idTyp, Mistnost mistnost, Ucastnik ucastnik, Typ typ)
        {
            IdMisto = idMisto;
            IdMistnosti = idMistnosti;
            IdUcastnik = idUcastnik;
            IdTyp = idTyp;
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
            Mistnost = new Mistnost();
            Ucastnik = new Ucastnik();
            Typ = new Typ();
        }
    }
}
