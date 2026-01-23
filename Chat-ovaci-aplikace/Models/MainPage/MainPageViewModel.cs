using Chat_ovaci_aplikace.Entities;

namespace Chat_ovaci_aplikace.Models.MainPage
{
    public class MainPageViewModel
    {
        public int IDUzivatele { get; set; }
        public string Name { get; set; }
        public List<Zprava> zpravas { get; set; }
        public List<Vlakno> vlakno { get; set; }
        public List<ChataMainViewModel> chatas { get; set; }

        public MainPageViewModel(int iDUzivatele, string name, List<Zprava> zpravas, List<Vlakno> vlakno, List<ChataMainViewModel> chatas)
        {
            IDUzivatele = iDUzivatele;
            Name = name;
            this.zpravas = zpravas;
            this.vlakno = vlakno;
            this.chatas = chatas;
        }
        public MainPageViewModel()
        {
            IDUzivatele = 0;
            Name = string.Empty;
            this.zpravas = new List<Zprava>();
            this.vlakno = new List<Vlakno>();
            this.chatas = new List<ChataMainViewModel>();
        }
    }
}
