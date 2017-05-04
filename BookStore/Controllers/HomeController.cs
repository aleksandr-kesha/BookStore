using System.Linq;
using System.Web.Mvc;
using BookStore.Models;

namespace BookStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly BookContext _db = new BookContext();

        public ActionResult Index()
        {
            var books = _db.Books.ToList();

            ViewBag.Books = books;

            return View();
        }    
    }
}