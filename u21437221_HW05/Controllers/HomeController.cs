using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u21437221_HW05.Models;

namespace u21437221_HW05.Controllers
{
    public class HomeController : Controller
    {
        private Service dataService = new Service();
        public ActionResult Index()
        {
            BookRecords bookRecord = null;
            bookRecord = new BookRecords
            {
                Book = dataService.GetAllBooks(),
                Author = dataService.GetAllAuthors()
            };
            return View(bookRecord);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}