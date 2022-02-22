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
    public class FilmTurController : Controller
    {
        private IBaseRepository<FilmTur> repo;
        FilmModel fm = new FilmModel();

        public FilmTurController(IBaseRepository<FilmTur> _rep)
        {
            repo = _rep;
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
                FilmTur t = new FilmTur();
                t.TurAd = fmm.FilmTur.TurAd;

                repo.ekle(t);
                repo.Guncel();
                return RedirectToAction("Index");
            }
            return View();

        }

        public IActionResult Detay(int id)
        {
            fm.FilmTur = repo.Bul(id);
            return View(fm);
        }

        public IActionResult Guncel(int id)
        {
            fm.FilmTur = repo.Bul(id);
            return View(fm);
        }
        [HttpPost]
        public IActionResult Guncelle(int id,FilmModel filmModel)
        {
            FilmTur f = repo.Bul(id);
            f.TurAd = fm.FilmTur.TurAd;
            repo.Guncel();
            return View();
        }

        public IActionResult Sil(int id)
        {
            FilmTur f = repo.Bul(id);
            repo.Sil(f);
            repo.Guncel();
            return RedirectToAction("Index");
        }


    }
}
