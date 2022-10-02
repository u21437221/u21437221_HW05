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
        public static string bookFilter = "";
        public static string typeFilter = "";
        public static string authorFilter = "";
        public static string studentNameFilter = "";
        public static string classFilter = "";
        private Service dataService = new Service();
        public ActionResult Index()
        {
            BookRecords bookRecord = null;
            //if (HomeController.bookFilter != null && HomeController.typeFilter != null && HomeController.authorFilter != null)
            //{
            //    bookRecord = new BookRecords
            //    {
            //        Book = dataService.GetAllBooksByNameAndTypeAndAuthor(bookFilter,typeFilter,authorFilter),
            //        Author = dataService.GetAllAuthors(),
            //        Type = dataService.GetAllTypes()
            //    };
            //}
            //else if(HomeController.bookFilter != null && HomeController.typeFilter != null)
            //{
            //    bookRecord = new BookRecords
            //    {
            //        Book = dataService.GetAllBooksByNameAndType(bookFilter,typeFilter),
            //        Author = dataService.GetAllAuthors(),
            //        Type = dataService.GetAllTypes()
            //    };
            //}
            //else if(HomeController.bookFilter != null)
            //{
            //    bookRecord = new BookRecords
            //    {
            //        Book = dataService.GetAllBooksByName(bookFilter),
            //        Author = dataService.GetAllAuthors(),
            //        Type = dataService.GetAllTypes()
            //    };
            //}
            bookRecord = new BookRecords
            {
                Book = dataService.GetAllBooks(),
                Author = dataService.GetAllAuthors(),
                Type = dataService.GetAllTypes()
            };
            return View(bookRecord);
        }

        public ActionResult SetBookNameFilter(string bookName)
        {
            HomeController.bookFilter = bookName;
            return RedirectToAction("Index");
        }

        public ActionResult SetTypeFilter(string dropdownMenu1)
        {
            HomeController.typeFilter = dropdownMenu1;
            return RedirectToAction("Index");
        }

        public ActionResult SetAuthorFilter(string dropdownMenu2)
        {
            HomeController.authorFilter = dropdownMenu2;
            return RedirectToAction("Index");
        }

        public ActionResult FilterBooks(string bookName, string dropdownMenu1, string dropdownMenu2)
        {
            HomeController.bookFilter = bookName;
            HomeController.typeFilter = dropdownMenu1;
            HomeController.authorFilter = dropdownMenu2;
            //BookRecords bookRecord = null;
            //if (HomeController.bookFilter != null && HomeController.typeFilter != null && HomeController.authorFilter != null)
            //{
            //    bookRecord = new BookRecords
            //    {
            //        Book = dataService.GetAllBooksByNameAndTypeAndAuthor(bookFilter,typeFilter,authorFilter),
            //        Author = dataService.GetAllAuthors(),
            //        Type = dataService.GetAllTypes()
            //    };
            //}
            //else if(HomeController.bookFilter != null && HomeController.typeFilter != null)
            //{
            //    bookRecord = new BookRecords
            //    {
            //        Book = dataService.GetAllBooksByNameAndType(bookFilter,typeFilter),
            //        Author = dataService.GetAllAuthors(),
            //        Type = dataService.GetAllTypes()
            //    };
            //}
            //else if(HomeController.bookFilter != null)
            //{
            //    bookRecord = new BookRecords
            //    {
            //        Book = dataService.GetAllBooksByName(bookFilter),
            //        Author = dataService.GetAllAuthors(),
            //        Type = dataService.GetAllTypes()
            //    };
            //}
            return RedirectToAction("Index");
        }

        public ActionResult ClearFilter()
        {
            BookRecords bookRecord = null;
            bookRecord = new BookRecords
            {
                Book = dataService.GetAllBooks(),
                Author = dataService.GetAllAuthors(),
                Type = dataService.GetAllTypes()
            };
            return RedirectToAction("Index");
        }

        public ActionResult GoToBookView()
        {
            return RedirectToAction("BookDetails");
        }

        public ActionResult BookDetails()
        {
            BookRecords borrows = null;
            borrows = new BookRecords
            {
                Borrow = dataService.GetAllBorrows(),
                Student = dataService.GetAllStudents()
            };
            return View(borrows);
        }

        public ActionResult GoToStudentsView()
        {
            return RedirectToAction("ViewStudents");
        }

        public ActionResult ViewStudents()
        {
            BookRecords student = null;
            //if(HomeController.studentNameFilter != null && HomeController.classFilter != null)
            //{
            //    student = new BookRecords
            //    {
            //        Student = dataService.GetAllStudentsByNameAndClass(studentNameFilter, classFilter)
            //    };
            //}
            //else if(HomeController.studentNameFilter != null)
            //{
            //    student = new BookRecords
            //    {
            //        Student = dataService.GetAllStudentsByName(studentNameFilter)
            //    };
            //}
            //else if(HomeController.classFilter != null)
            //{
            //    student = new BookRecords
            //    {
            //        Student = dataService.GetAllStudentsByClass(classFilter)
            //    };
            //}
            //else
            //{
            //    student = new BookRecords
            //    {
            //        Student = dataService.GetAllStudents()
            //    };
            //}
            student = new BookRecords
            {
                Student = dataService.GetAllStudents()
            };
            return View(student);
        }

        public ActionResult SetStudentNameFilter(string studentNameFilter)
        {
            HomeController.studentNameFilter = studentNameFilter;
            return RedirectToAction("ViewStudents");
        }

        public ActionResult SetClassFilter(string classFilter)
        {
            HomeController.classFilter = classFilter;
            return RedirectToAction("ViewStudents");
        }

        public ActionResult ReturnBook()
        {
            string message = dataService.ReturnBook();
            return RedirectToAction("ViewStudents",message);
        }
    }
}