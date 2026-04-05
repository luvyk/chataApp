using Microsoft.AspNetCore.Mvc;
using Chat_ovaci_aplikace.Database;
using Chat_ovaci_aplikace.Entities;
using Chat_ovaci_aplikace.Helpers;
using Chat_ovaci_aplikace.Models.Auth;
using Chat_ovaci_aplikace.Entities;

namespace Eshop.Controllers
{
    public class AuthController : BaseController
    {
        private DatabaseContext _context;

        public AuthController(DatabaseContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(loginViewModel);
            }

            Uzivatel? account = _context.Uzivatele.SingleOrDefault(a => a.Username == loginViewModel.Username);
            if (account == null || account.Heslo != loginViewModel.Password)//SHA256Helper.HashPassword(loginViewModel.Password)) // DOČASNÉ ŘEŠENÍ!!!!! musí být změněno ASAP
            {
                TempData["Message"] = "Wrong username or password!";
                TempData["MessageType"] = "danger";
                return View(loginViewModel);
            }

            HttpContext.Session.SetString("User", account.Username);
            //HttpContext.Session.SetString("Role", account.Role);
            HttpContext.Session.SetInt32("Id", account.IdUzivatel);

            /*
            Uzivatel u = _context.Uzivatele.FirstOrDefault(x => x.Username == account.Username);
            if (u == null)
            {
                Uzivatel ucet = new Uzivatel();
                ucet.Username = account.Username;
                //ucet.Role = account.Role;
                ucet.Heslo = "8d969eef6ecad3c29a3a629280e686cf0c3f5d5a86aff3ca12020c923adc6c92";

                _context.Uzivatele.Add(ucet); 
                _context.SaveChanges();
            }
            */

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("User");
            HttpContext.Session.Remove("Role");

            return RedirectToAction("Index", "Home");
        }
    }
}
