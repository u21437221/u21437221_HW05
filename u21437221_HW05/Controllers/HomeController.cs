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
                Author = dataService.GetAllAuthors(),
                Type = dataService.GetAllTypes()
            };
            return View(bookRecord);
        }

        public ActionResult BookDetails()
        {
            BookRecords borrows = null;
            borrows = new BookRecords
            {
                Borrow = dataService.GetAllBorrows()
            };
            return View(borrows);
        }
    }
}