using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControledeContatos.Controllers
{
    public class ContatoController : Controller
    { 
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult criar()
        {
            return View();
        }
        public IActionResult editar()
        {
            return View();
        }
        public IActionResult apagarConf()
        {
            return View();
        }
        
    }
}