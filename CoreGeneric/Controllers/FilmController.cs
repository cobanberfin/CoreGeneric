using CoreGeneric.Controllers.Repository;
using CoreGeneric.Models;
using CoreGeneric.Models.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreGeneric.Controllers
{
    public class FilmController : Controller
    {
        private IBaseRepository<Film> repo;
        //private IBaseRepository<FilmTur> krepo;
        FilmModel fm = new FilmModel();

        public FilmController(IBaseRepository<Film> _repo)
        {
            repo = _repo;
           
        }
        public IActionResult Index()
        {
            return View(repo.Listele());

        }
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(FilmModel fmm)
        {
            if (ModelState.IsValid)
            {
                Film f = new Film();
                f.Ad = fmm.Film.Ad;
                f.Ad = fmm.Film.Açıklama;
                f.Resim = fmm.Film.Resim;
                f.FilmTurID = fmm.Film.FilmTurID;
                repo.ekle(f);
                repo.Guncel();


                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Detay(int id)
        {
            fm.Film = repo.Bul(id);
            return View(fm);
        }
        public IActionResult Guncel(int id)
        {
            fm.Film = repo.Bul(id);
           
            return View(fm);
        }
        [HttpPost]
        public IActionResult Guncelle(int id, FilmModel fmm)
        {
            Film f = repo.Bul(id);
            f.Ad = fmm.Film.Ad;
            f.Açıklama = fmm.Film.Açıklama;
            repo.Guncel();
            return View();
        }

        public IActionResult Sil(int id)
        {
            fm.Film = repo.Bul(id);
            repo.Sil(fm.Film);
            repo.Guncel();
            return RedirectToAction("Index");



           

        }
    }
}
