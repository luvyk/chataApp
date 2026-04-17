using Chat_ovaci_aplikace.Controllers;
using Chat_ovaci_aplikace.Database;
using Chat_ovaci_aplikace.Entities;
using Chat_ovaci_aplikace.Models.Chata;
using Eshop.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System.Security.Principal;

namespace Chat_ovaci_aplikace.Controllers
{
    public class ChataController : SecuredController
    {
        private DatabaseContext _databaseContext;
        public ChataController(DatabaseContext context)
        {
            _databaseContext = context;
        }

        [Route("chata/index/{id}")]
        public IActionResult Index([FromRoute] int id)
        {
            int idUzivatele = HttpContext.Session.GetInt32("Id") ?? 0;

            ViewBag.username = HttpContext.Session.GetString("User");
            ViewBag.idChaty = id;


            List<Mistnost> mistnosti = _databaseContext.Mistnosti.Where(s => s.IdChaty == id)
                    .Include(s => s.Mista)
                    .Include(s => s.Chata)
                        .ThenInclude(s => s.Dny)
                .ToList();

            Console.WriteLine("mistnosti načteny");
            foreach(Mistnost m in mistnosti)
            {
                Console.WriteLine(m.IdChaty);
            }
            

            return View(mistnosti);
        }

        public IActionResult zapisNaMisto([FromQuery] int den,[FromQuery] int misto, [FromQuery] int idChaty)
        {
            ObsazeniMista obsazeni = new ObsazeniMista();
            obsazeni.IdDen = den;
            Uzivatel? uzivatel = _databaseContext.Uzivatele.SingleOrDefault(s => s.Username == HttpContext.Session.GetString("User"));
            obsazeni.IdUcastnik = uzivatel.IdUzivatel;
            obsazeni.IdMisto = misto;
            obsazeni.den = null;
            obsazeni.ucastnik = null;
            obsazeni.misto = null;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"zapisuji {obsazeni.IdDen} {obsazeni.IdUcastnik} {obsazeni.IdMisto}");

            _databaseContext.Obsazeni.Add(obsazeni);
            _databaseContext.SaveChanges();

            ViewBag.idChaty = idChaty;

            return RedirectToAction("index", new {id = idChaty});
        }

        public IActionResult odstranZMista([FromQuery] int den, [FromQuery] int misto, [FromQuery] int idChaty)
        {
            ObsazeniMista obsazeni = _databaseContext.Obsazeni.FirstOrDefault(s => s.IdDen == den && s.IdMisto == misto) ?? new ObsazeniMista();
            _databaseContext.Obsazeni.Remove(obsazeni);
            _databaseContext.SaveChanges();

            ViewBag.idChaty = idChaty;

            return RedirectToAction("index", new {id = idChaty});
        }

        [Route("chata/chataMainPage/{idChaty}")]
        public IActionResult chataMainPage(int idChaty)
        {
            Console.WriteLine(idChaty);

            int idUzivatele = HttpContext.Session.GetInt32("Id") ?? 0;
            Ucastnik? ucastnik = _databaseContext.Ucastnici.FirstOrDefault(s => s.IdUzivatel == idUzivatele && s.IdChaty == idChaty);
            ViewBag.idUcastnik = ucastnik.IdUcastnik;
            //ViewBag.idChaty = idChaty;

            int idUcastnik = HttpContext.Session.GetInt32("Id") ?? 0;
            List<Ukoly> ukoly = _databaseContext.Ukoly.Where(s => s.Den.IdChaty == idChaty && s.IdUcastnik == idUcastnik).ToList();

            List<ProgramChaty> programy = _databaseContext.Programy.Where(s => _databaseContext.Dny
                                        .Where(s => s.IdChaty == idChaty)
                                        .Select(s => s.IdDen).Contains(s.IdDen)).ToList();
            return View(idChaty);
        }
        [Route("chata/AkceAUkoly/{idChata}")]
        public IActionResult AkceAUkoly(int idChata, [FromQuery] int idUcastnik)
        {
            //int idUzivatel = HttpContext.Session.GetInt32("Id") ?? 0;
            ViewBag.idUcastnik = idUcastnik;

            List<Akce> akce = _databaseContext.Akces.Where(s => s.Den.IdChaty == idChata).ToList();
            List<Ukoly> ukoly = _databaseContext.Ukoly
                            .Where(s => s.IdUcastnik == idUcastnik).ToList();

            AkceAUkolyViewModel model = new AkceAUkolyViewModel(akce, ukoly);
            return View(model);
        }

        [Route("chata/PrihlasitSeNaAkci/{idUcastnik}/{idAkce}")]
        public IActionResult PrihlasitSeNaAkci(int idUcastnik, int idAkce)
        {
            UcastnikAkce? ucastAkc = _databaseContext.UcastnikAkces.FirstOrDefault(s => s.IdUcastnik == idUcastnik && s.IdAkce == idAkce) ?? null;
            if(ucastAkc == null)
            {
                UcastnikAkce newUcastni = new UcastnikAkce();
                newUcastni.IdUcastnik = idUcastnik;
                newUcastni.IdAkce = idAkce;
                newUcastni.Akce = null;
                newUcastni.Ucastnik = null;

                _databaseContext.Add(newUcastni);
                _databaseContext.SaveChanges();

                return RedirectToAction("AkceAUkoly", new { idChata = ucastAkc.Akce.Den.Chata.IdChaty, idUcastnik });
            }

            _databaseContext.Remove(ucastAkc);
            _databaseContext.SaveChanges();

            return RedirectToAction("AkceAUkoly", new {idChata = ucastAkc.Akce.Den.Chata.IdChaty, idUcastnik });
        }
    }
}
