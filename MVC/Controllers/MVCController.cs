using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC.Models;
using System.Net;
using System.Data.Entity;


namespace MVC.Controllers
{
    
        public class MoviesController : Controller
        {
            // GET: Movies
            private MoviesDBEntities md = new MoviesDBEntities();
            public ActionResult Index()
            {
                List<Movie3> movies = md.Movie3.ToList(); // or any other method that returns a list of movies
                return View(movies);
            }
            public ActionResult Create()
            {
                return View();
            }

            //for insert new movies details
            [HttpPost, ActionName("Create")]
            [ValidateAntiForgeryToken]
            public ActionResult InsertMovie([Bind(Include = "Mid, Moviename, DateofRelease")] Movie3 movie)
            {
                if (ModelState.IsValid)
                {
                    md.Movie3.Add(movie);
                    md.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(movie);
            }
            public ActionResult Edit(int? id)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Movie3 movie = md.Movie3.Find(id);
                if (movie == null)
                {
                    return HttpNotFound();
                }
                return View(movie);
            }
            [HttpPost]
            [ValidateAntiForgeryToken]
            public ActionResult Edit([Bind(Include = "Mid, Moviename, DateofRelease")] Movie3 movie)
            {
                if (ModelState.IsValid)
                {
                    md.Entry(movie).State = EntityState.Modified;
                    md.SaveChanges();
                    return RedirectToAction("Index");
                }
                return View(movie);
            }
            public ActionResult Delete(int? id)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                Movie3 movie = md.Movie3.Find(id);
                if (movie == null)
                {
                    return HttpNotFound();
                }
                return View(movie);
            }
            [HttpPost]
            [ValidateAntiForgeryToken, ActionName("Delete")]
            public ActionResult DeleteConfirm(int? id)
            {
                Movie3 movie = md.Movie3.Find(id);
                md.Movie3.Remove(movie);
                md.SaveChanges();
                return RedirectToAction("Index");
            }
            [HttpGet]
            public ActionResult FindMoviesByYear(DateTime? dateTime)
            {
                if (dateTime.HasValue)
                {


                    int n = Convert.ToInt32(dateTime);
                    IEnumerable<Movie3> movies = from m in md.Movie3
                                                    where m.DateofRelease.Equals(n)
                                                    select m;
                    return View(movies);
                }
                else
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }



            }
        }
    }