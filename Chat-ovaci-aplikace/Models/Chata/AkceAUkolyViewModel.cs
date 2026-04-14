using Chat_ovaci_aplikace.Entities;

namespace Chat_ovaci_aplikace.Models.Chata
{
    public class AkceAUkolyViewModel
    {
        public List<Akce> Akce { get; set; }
        public List<Ukoly> Ukoly { get; set; }

        public AkceAUkolyViewModel(List<Akce> a, List<Ukoly> u)
        {
            Akce = a;
            Ukoly = u;
        }
    }
}
