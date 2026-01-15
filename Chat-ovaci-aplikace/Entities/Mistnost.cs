using System.Collections.Generic;

namespace Chat_ovaci_aplikace.Entities
{
    public class Mistnost
    {
        public int IdMistnosti { get; set; }
        public int IdChaty { get; set; }
        public string NazevMistnosti { get; set; }
        public bool ZatahujeNaNoc { get; set; }

        public Chata Chata { get; set; }

        public ICollection<Misto> Mista { get; set; }
    }
}
