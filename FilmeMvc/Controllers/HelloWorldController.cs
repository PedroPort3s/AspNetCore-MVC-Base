using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FilmeMvc.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // 
        // GET: /HelloWorld/Welcome/ 
        // Requer biblioteca System.Text.Encodings.Web;
        //public string Welcome(string nome, int ID = 1)
        //{
        //    ViewData["Mensagem"] = $"Olá {nome}";
        //    ViewData["NumVezes"] = ID;
        //        return HtmlEncoder.Default.Encode($"Olá {nome}, ID: {ID}");
        //}
        public IActionResult Welcome(string nome, int numVezes = 1)
        {
            ViewData["Mensagem"] = $"Olá {nome}";
            ViewData["NumVezes"] = numVezes;
            return View();
        }
    }
}
