using Microsoft.AspNetCore.Mvc;
using Patililer.Data;
using Patililer.Models;
using Patililer.Models.Siniflar;
using System.Diagnostics;
namespace Patililer.Controllers
{
    public class HomeController : Controller
    {
        private readonly PatililerDBContext _context;

        public HomeController(PatililerDBContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        public IActionResult Hakkimizda()
        {
            List<Hakkimizda> HakkimizdaList = _context.Hakkimizdas.ToList();
            return View(HakkimizdaList);
        }
        
        public IActionResult Ilanlar()
        {
            List<Ilanlar> IlanListesi = _context.Ilanlars.ToList();
            return View(IlanListesi);
        }
        public IActionResult IlanDetay(int id)
        {
            return View();
        }
        
        public IActionResult Iletisim()
        {
            return View();
        }
       
    }
}