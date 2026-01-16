using System.Collections.Generic;

namespace Chat_ovaci_aplikace.Entities
{
    public class Mistnost
    {
        public int IdMistnosti { get; set; }
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
