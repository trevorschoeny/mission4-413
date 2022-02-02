using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using JoelFilms.Models;
using Microsoft.EntityFrameworkCore;

namespace JoelFilms.Controllers
{
    public class HomeController : Controller
    {
        private NewMovieContext _movieContext { get; set; }

        public HomeController(NewMovieContext context)
        {
            _movieContext = context;
        }

        public IActionResult Index()
        {
            var movies = _movieContext.Movie.Include(x => x.Category)
                .OrderBy(x => x.Category.CategoryName)
                .ToList();
            return View(movies);
        }

        [HttpGet]
        public IActionResult NewMovie()
        {
            ViewBag.Categories = _movieContext.Category.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult NewMovie(NewMovieModel nmm)
        {
            if (ModelState.IsValid)
            {
                _movieContext.Add(nmm);
                _movieContext.SaveChanges();
                return View("Confirmation", nmm);
            }
            else
            {
                ViewBag.Categories = _movieContext.Category.ToList();
                return View("NewMovie");
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Podcasts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Edit(int movieid)
        {
            ViewBag.Categories = _movieContext.Category.ToList();
            var movie = _movieContext.Movie.Single(x => x.MovieID == movieid);
            return View("NewMovie", movie);
        }

        [HttpPost]
        public IActionResult Edit(NewMovieModel m)
        {
            _movieContext.Update(m);
            _movieContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int movieid)
        {
            var movie = _movieContext.Movie.Single(x => x.MovieID == movieid);
            return View(movie);
        }

        [HttpPost]
        public IActionResult Delete(NewMovieModel movie)
        {
            _movieContext.Remove(movie);
            _movieContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
