using Microsoft.AspNetCore.Mvc;
using Movies.Entities;

namespace Movies.Controllers
{
    public class MovieController : Controller
    {
        private MovieDbContext _db;

        public MovieController(MovieDbContext movieDbContext) 
        {
            _db = movieDbContext;
        }

        public IActionResult List() 
        {
            List<Movie> movies = _db.Movies.ToList();
            return View(movies);
        }

        public IActionResult Create()
        {
            return View(new Movie());
        }

        [HttpPost]
        public IActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                _db.Movies.Add(movie);
                _db.SaveChanges();

                return RedirectToAction("List", "Movie");
            }

            return View(movie);
        }
    }
}
