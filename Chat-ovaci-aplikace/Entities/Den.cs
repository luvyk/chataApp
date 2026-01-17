using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chat_ovaci_aplikace.Entities
{
    [Table("Den")]
    public class Den
    {
        [Key]
        public int IdDen { get; set; }
        [ForeignKey(nameof(Chata))]
        public int IdChaty { get; set; }
        public DateTime Datum { get; set; }

        public Chata Chata { get; set; }

        public List<Ukoly> Ukoly { get; set; }
        public List<Program> Programy { get; set; }

        public Den()
        {
            IdDen = 0;
            IdChaty = 0;
            Datum = DateTime.Now;
            Chata = new Chata();
            Ukoly = new List<Ukoly>();
            Programy = new List<Program>();
        }

        public Den(int idDen, int idChaty, DateTime datum, Chata chata, List<Ukoly> ukoly, List<Program> programy)
        {
            IdDen = idDen;
            IdChaty = idChaty;
            Datum = datum;
            Chata = chata;
            Ukoly = ukoly;
            Programy = programy;
        }
    }
}
