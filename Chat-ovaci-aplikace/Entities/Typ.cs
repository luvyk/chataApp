using System.Collections.Generic;

namespace Chat_ovaci_aplikace.Entities
{
    public class Typ
    {
        public int IdTyp { get; set; }
        public string Jmeno { get; set; }

        public List<Misto> Mista { get; set; }

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
