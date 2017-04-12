using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Music_Store.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            return Content("Hello from Store.Index()");
        }
        //public ActionResult Browse()
        //{
        //    return Content("Hello from Store.Browse()");
        //}
        public ActionResult Browse(string genre)
        {
            string message = HttpUtility.HtmlEncode("Store.Browse, Genre = " + genre);
            return Content(message);
        }
        public ActionResult Details(int id = 0)
        {
            return Content("Store.Details, ID = " + id);
        }
    }
}