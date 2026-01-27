using System.Diagnostics;
using Chat_ovaci_aplikace.Database;
using Chat_ovaci_aplikace.Entities;
using Chat_ovaci_aplikace.Models;
using Chat_ovaci_aplikace.Models.MainPage;
using Microsoft.AspNetCore.Mvc;

namespace Chat_ovaci_aplikace.Controllers
{
    public class HomeController : Controller
    {
        private DatabaseContext _databaseContext;

        public HomeController(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public IActionResult Index()
        {
            MainPageViewModel viewModel = new MainPageViewModel();
            if(HttpContext.Session.GetString("User") != null)
            {
                viewModel = Login();
            }
            else
            {
                viewModel = NotLogin();
            }
            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public MainPageViewModel NotLogin()
        {
            MainPageViewModel model = new MainPageViewModel();
            model.IDUzivatele = -1;
            model.Name = "Login";
            model.zpravas = new List<Entities.Zprava> { };
            model.vlakno = new List<Entities.Vlakno> { };
            model.chatas = new List<Models.MainPage.ChataMainViewModel> { };

            return model;
        }
        public MainPageViewModel Login()
        {
            MainPageViewModel model = new MainPageViewModel();
            Uzivatel? uzivatel = _databaseContext.Uzivatele.SingleOrDefault(s => s.Username == HttpContext.Session.GetString("User"));
            model.IDUzivatele = Int32.Parse(uzivatel.IdUzivatel.ToString() ?? "0");
            model.Name = HttpContext.Session.GetString("User");

            model.vlakno = _databaseContext.Vlakna
                         .Where(v => _databaseContext.Ucastnici
                        .Where(u => u.IdUzivatel == model.IDUzivatele)
                        .Select(u => u.IdChaty)
                        .Contains(v.IdChaty)).ToList();

            model.zpravas = _databaseContext.Zpravy
                .Where(x => _databaseContext.Vlakna
                .Select(y => y.IdVlakno)
                .Contains(x.IdVlakno)).ToList();

            List<Chata> tempChaty = _databaseContext.Chaty
                        .Where(x => _databaseContext.Ucastnici
                        .Where(z => z.IdUzivatel == model.IDUzivatele)
                        .Select(y => y.IdChaty)
                        .Contains(x.IdChaty)).ToList();

            string organizator = "";
            int realnaObsazenost = 0;
            foreach(Chata ch in tempChaty)
            {
                foreach(Ucastnik uc in ch.Ucastnici)
                {

                    foreach(RoleUcastnik ru in uc.RoleUcastnik)
                    {
                        if(ru.Role.Nazev == "MainOrg")
                        {
                            organizator = uc.Uzivatel.Username;
                        }
                    }
                }
                foreach(Mistnost mi in ch.Mistnosti)
                {
                    foreach(ObsazeniMista mis in _databaseContext.Obsazeni.Where(s => s.id mi.)
                    {
                        realnaObsazenost++;
                    }
                }
            }
            Console.WriteLine(tempChaty[1].Ucastnici[0].Zaplatil);
            for(int i = 0; i < tempChaty.Count; i++)
            {
                model.chatas.Add(new ChataMainViewModel());
                model.chatas[i].JmenoChaty = tempChaty[i].Jmeno;
                model.chatas[i].Organizator = organizator;
                model.chatas[i].Zeme = tempChaty[i].Zeme;
                model.chatas[i].Mesto = tempChaty[i].Mesto;
                model.chatas[i].Cast = tempChaty[i].CastMesta;
                model.chatas[i].Ulice = tempChaty[i].Ulice;
                model.chatas[i].PSC = tempChaty[i].PSC;
                model.chatas[i].Zacatek = tempChaty[i].Zacatek;
                model.chatas[i].Zaplatil = tempChaty[i].Ucastnici.SingleOrDefault(s => s.IdUzivatel == model.IDUzivatele).Zaplatil;
                model.chatas[i].UcastniSe = tempChaty[i].Ucastnici.SingleOrDefault(s => s.IdUzivatel == model.IDUzivatele).ZucastniSe;
                if(realnaObsazenost < tempChaty[i].Kapacita)
                {
                    model.chatas[i].volnaLuzka = "Volna Mista";
                }
                else
                {
                    model.chatas[i].volnaLuzka = "Plno";
                }
                
            }


            Console.WriteLine($"Našel jsem {model.chatas.Count} chat");
            return model;
        }
    }
}
