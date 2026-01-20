using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chat_ovaci_aplikace.Entities
{
    [Table("Typ")]
    public class Typ
    {
        [Key]
        public int IdTyp { get; set; }
        public string Jmeno { get; set; }

        public virtual List<Misto> Mista { get; set; }

        public Typ(int idTyp, string jmeno, List<Misto> mista)
        {
            IdTyp = idTyp;
            Jmeno = jmeno;
            Mista = mista;
        }
        public Typ()
        {
            IdTyp = 0;
            Jmeno = string.Empty;
            Mista = new List<Misto>();
        }
    }
}
