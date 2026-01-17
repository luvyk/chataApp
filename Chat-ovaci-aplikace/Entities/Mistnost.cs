using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chat_ovaci_aplikace.Entities
{
    [Table("Mistnost")]
    public class Mistnost
    {
        [Key]
        public int IdMistnosti { get; set; }
        [ForeignKey(nameof(Chata))]
        public int IdChaty { get; set; }
        public string? NazevMistnosti { get; set; }
        public bool? ZatahujeNaNoc { get; set; }

        public Chata Chata { get; set; }

        public List<Misto> Mista { get; set; }

        public Mistnost(int idMistnosti, int idChaty, string nazevMistnosti, bool zatahujeNaNoc, Chata chata, List<Misto> mista)
        {
            IdMistnosti = idMistnosti;
            IdChaty = idChaty;
            NazevMistnosti = nazevMistnosti;
            ZatahujeNaNoc = zatahujeNaNoc;
            Chata = chata;
            Mista = mista;
        }
        public Mistnost()
        {
            IdMistnosti = 0;
            IdChaty = 0;
            NazevMistnosti = string.Empty;
            ZatahujeNaNoc = true;
            Chata = new Chata();
            Mista = new List<Misto>();
        }
    }
}
