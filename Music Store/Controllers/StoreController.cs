using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Music_Store.Models;

namespace Music_Store.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            var genres = new List<Genre>
            {
                new Genre { Name = "RnB"},
                new Genre { Name = "Blues"},
                new Genre { Name = "Hip Hop"}
            };
            return View(genres);
        }
        //public ActionResult Browse()
        //{
        //    return Content("Hello from Store.Browse()");
        //}
        public ActionResult Browse(string genre)
        {
            //string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            var genreModel = new Genre { Name = genre };
            return View(genreModel);
        }
        public ActionResult Details(int id = 0)
        {
            var album = new Album { Title = "Album " + id };
            return View(album);
        }
    }
}