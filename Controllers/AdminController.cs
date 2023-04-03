using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Patililer.Data;
using Patililer.Models.Siniflar;

namespace Patililer.Controllers
{

    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly PatililerDBContext _context;

        public AdminController(PatililerDBContext context)
        {
            _context = context;
        }

        [Authorize]
        public IActionResult Index()
        {
            List<Ilanlar> c = _context.Ilanlars.ToList();
            return View(c);
        }
        [HttpGet]
        public IActionResult YeniIlan()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult YeniIlan(Ilanlar p)
        {
            _context.Ilanlars.Add(p);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult IlanSil(int id)
        {
            var b = _context.Ilanlars.Find(id);
            _context.Ilanlars.Remove(b);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult IlanGetir(int id)
        {
            var b1 = _context.Ilanlars.Find(id);
            return View("IlanGetir", b1);
        }
        public IActionResult IlanGuncelle(Ilanlar b)
        {
            var blg = _context.Ilanlars.Find(b.ID);
            blg.Baslik = b.Baslik;
            blg.Tarih = b.Tarih;
            blg.Yas = b.Yas;
            blg.Cinsiyet = b.Cinsiyet;
            blg.Aciklama = b.Aciklama;
            blg.IlanImage = b.IlanImage;
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
