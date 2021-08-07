using Microsoft.AspNetCore.Mvc;
using Site1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site1.Controllers {
    public class HomeController : Controller {

        public ActionResult Index() {
            //return new ContentResult() { Content = "Olá Mundo", ContentType = "text/plain" };
            return View();
        }

        [HttpGet]
        public ActionResult Login() {
            return View();
        }

        [HttpPost]
        public ActionResult Login([FromForm] Usuario usuario) {

            if (ModelState.IsValid) {

                if (usuario.Email == "jonathanwscrok@gmail.com" && usuario.Senha == "1234") {

                    return Redirect("/contato");

                } else {

                    ViewBag.Mensagem = "Os dados informados são inválidos!";
                    return View();
                }
            } else {

                return View();
            }


        }
    }
}
