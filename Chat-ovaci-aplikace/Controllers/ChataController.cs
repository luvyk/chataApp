using Chat_ovaci_aplikace.Controllers;
using Chat_ovaci_aplikace.Database;
using Chat_ovaci_aplikace.Entities;
using Chat_ovaci_aplikace.Models.Chata;
using Eshop.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;

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
            Console.WriteLine($"moje ID chaty {idChaty + 1}");

            Console.WriteLine($"hledám detail chaty číslo {idChaty}");

            /*
            Chata detailChaty = _databaseContext.Chaty
                .Include(m => m.Mistnosti)
                .ThenInclude(m => m.Mista) 
                .Include(m => m.Dny)
                .FirstOrDefault(h => h.IdChaty == idChaty + 1)!;
            var idsDnu = detailChaty.Dny.Select(d => d.IdDen).ToList();
            List<ObsazeniMista> obsazeni = _databaseContext.Obsazeni
                .Include(s => s.ucastnik)
                .Where(s => idsDnu.Contains(s.IdDen))
                .ToList();
            */
            Chata chataDetail = _databaseContext.Chaty
        .Where(c => c.IdChaty == idChaty)

    .Include(c => c.Mistnosti)
        .ThenInclude(m => m.Mista)

    .Include(c => c.Dny)

    .Include(c => c.Ucastnici)
        .ThenInclude(u => u.ObsazeniMista)
            .ThenInclude(o => o.misto)

    .Include(c => c.Ucastnici)
        .ThenInclude(u => u.ObsazeniMista)
            .ThenInclude(o => o.den)

    .FirstOrDefault();

            

            return View(chataDetail);
        }
    }
}
