using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Site1CursoASPNET.Controllers {
    public class HomeController : Controller {

        public ActionResult Index() {

            return new ContentResult() { Content = "Olá Mundo!", ContentType = "text/plain" };
        }

    }
}
