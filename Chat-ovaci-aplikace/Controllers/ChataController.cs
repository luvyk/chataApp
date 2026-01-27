using Chat_ovaci_aplikace.Controllers;
using Chat_ovaci_aplikace.Database;
using Chat_ovaci_aplikace.Entities;
using Eshop.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace Chat_ovaci_aplikace.Controllers
{
    public class ChataController : SecuredController
    {
        private DatabaseContext _databaseContext;
        public ChataController(DatabaseContext context)
        {
            _databaseContext = context;
        }

        public IActionResult Index(int idChaty)
        {
            List<Mistnost> mista = _databaseContext.Mistnosti
                .Where(s => _databaseContext.Chaty
                .Where(x => x.IdChaty == idChaty)
                .Select(x => x.IdChaty)
                .Contains(s.IdChaty)).ToList();

            return View(mista);
        }
    }
}
