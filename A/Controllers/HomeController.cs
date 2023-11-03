using A.Data;
using A.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace A.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index(int? id)
        {
            var movies = MovieRepository.Movies;

            if (id != null)
            {
                movies = movies.Where(x => x.CategoryId == id).ToList();
            }


            return View(movies);
        }

        public IActionResult Details(int id)
        {
            return View(MovieRepository.GetById(id));
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
    }
}