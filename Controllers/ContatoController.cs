using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace form_scrum.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Criar(){
            return View();
        }
        public IActionResult Deletar(int id){
            return View();
        }
        public IActionResult Editar(int id){
            return View();
        }
    }
}