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

        public IActionResult Index([FromRoute] int idChaty)
        {
            ViewBag.username = HttpContext.Session.GetString("User");

            Chata chataDetail = _databaseContext.Chaty
        .Where(c => c.IdChaty == idChaty + 1)

    .Include(c => c.Mistnosti)
        .ThenInclude(m => m.Mista)

    .Include(c => c.Dny)

    .Include(c => c.Ucastnici)
        .ThenInclude(u => u.Mista)
            .ThenInclude(o => o.misto)

    .Include(c => c.Ucastnici)
        .ThenInclude(u => u.Mista)
            .ThenInclude(o => o.den)

    .FirstOrDefault();

            

            return View(chataDetail);
        }

        public IActionResult zapisNaMisto([FromQuery] int den,[FromQuery] int misto)
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

            return RedirectToAction("index");
        }

        public IActionResult odstranZMista([FromQuery] int den, [FromQuery] int misto)
        {
            ObsazeniMista obsazeni = _databaseContext.Obsazeni.FirstOrDefault(s => s.IdDen == den && s.IdMisto == misto) ?? new ObsazeniMista();
            _databaseContext.Obsazeni.Remove(obsazeni);
            _databaseContext.SaveChanges();

            return RedirectToAction("index");
        }
        public IActionResult chataMainPage(int idchata)
        {
            int idUcastnik = HttpContext.Session.GetInt32("Id") ?? 0;
            List<Ukoly> ukoly = _databaseContext.Ukoly.Where(s => s.Den.IdChaty == idchata && s.IdUcastnik == idUcastnik).ToList();

            List<Program> programy = _databaseContext.Programy.Where(s => _databaseContext.)
            return View(idchata);
        }
    }
}
