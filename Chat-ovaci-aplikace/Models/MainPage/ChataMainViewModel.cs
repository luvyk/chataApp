using System.Security.Cryptography.X509Certificates;

namespace Chat_ovaci_aplikace.Models.MainPage
{
    public class ChataMainViewModel
    {
        public int IdChaty {  get; set; }
        public string JmenoChaty { get; set; }
        public string Organizator { get; set; }
        public string Zeme { get; set; }
        public string Mesto { get; set; }
        public string? Cast { get; set; }
        public string Ulice { get; set; }
        public string PSC { get; set; }
        public DateTime Zacatek { get; set; }
        public bool Zaplatil { get; set; }
        public bool UcastniSe { get; set; }
        public string volnaLuzka { get; set; }

        public ChataMainViewModel()
        {
            IdChaty = 0;
            JmenoChaty = "";
            Organizator = "";
            Zeme = "";
            Mesto = "";
            Cast = "";
            Ulice = "";
            PSC = "";
            Zacatek = new DateTime();
            Zaplatil = false;
            UcastniSe = true;
            this.volnaLuzka = null;
        }
    }
}
