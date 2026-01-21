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

            var zprava = _databaseContext.Zpravy
                .Where(x => _databaseContext.Vlakna
                .Select(y => y.IdVlakno)
                .Contains(x.IdVlakno)).ToList();

            return model;
        }
    }
}
