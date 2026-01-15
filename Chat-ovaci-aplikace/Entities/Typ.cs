using System.Collections.Generic;

namespace Chat_ovaci_aplikace.Entities
{
    public class Typ
    {
        public int IdTyp { get; set; }
        public string Jmeno { get; set; }

        public ICollection<Misto> Mista { get; set; }
    }
}
