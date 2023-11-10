using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace q2.Controllers
{
    public class MoviesController : Controller
    {
        private readonly MoviesDbContext _context = new MoviesDbContext();

        public ActionResult Index()
        {
            var movies = _context.Movies.ToList();
            return View(movies);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Movies.Add(movie);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            var movie = _context.Movies.Find(id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(movie).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(movie);
        }

        public ActionResult Delete(int id)
        {
            var movie = _context.Movies.Find(id);
            _context.Movies.Remove(movie);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}