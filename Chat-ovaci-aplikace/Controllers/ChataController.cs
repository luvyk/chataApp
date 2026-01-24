using Microsoft.AspNetCore.Mvc;
using Chat_ovaci_aplikace.Controllers;
using Eshop.Controllers;

namespace Chat_ovaci_aplikace.Controllers
{
    public class ChataController : SecuredController
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
