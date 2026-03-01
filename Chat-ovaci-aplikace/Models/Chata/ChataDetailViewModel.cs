using Chat_ovaci_aplikace.Entities;

namespace Chat_ovaci_aplikace.Models.Chata
{
    public class ChataDetailViewModel
    {
        public Entities.Chata chata { get; set; }
        public List<Entities.ObsazeniMista> obsazeni {  get; set; }

        public ChataDetailViewModel(Mistnost mista, List<ObsazeniMista> obsazeni)
        {
            this.chata = chata;
            this.obsazeni = obsazeni;
        }
        public ChataDetailViewModel()
        {
            this.chata = new Entities.Chata();
            this.obsazeni = new List<ObsazeniMista>();
        }
    }
}
