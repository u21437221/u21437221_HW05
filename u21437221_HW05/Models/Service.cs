using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;
using System.Data.SqlClient;

namespace u21437221_HW05.Models
{
    public class Service
    {
        public List<Books> GetAllBooks()
        {
            List<Books> books = new List<Books>();
            try
            {
                SqlConnection myConnection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
                myConnection.Open();
                SqlCommand newCmd = new SqlCommand("SELECT * FROM books",myConnection);
                using(SqlDataReader myReader = newCmd.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        Books book = new Books();
                        book.bookID = Convert.ToInt32(myReader["bookID"]);
                        book.name = myReader["name"].ToString();
                        book.pagecount = Convert.ToInt32(myReader["pagecount"]);
                        book.point = Convert.ToInt32(myReader["point"]);
                        books.Add(book);
                    }
                }
                myConnection.Close();
            }
            catch
            {
            }
            return books;
        }

        public List<Authors> GetAllAuthors()
        {
            List<Authors> authors = new List<Authors>();
            try
            {
                SqlConnection myConnection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
                myConnection.Open();
                SqlCommand newCmd = new SqlCommand("SELECT * FROM authors", myConnection);
                using(SqlDataReader myReader = newCmd.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        Authors author = new Authors();
                        author.authorID = Convert.ToInt32(myReader["authorID"]);
                        author.name = myReader["name"].ToString();
                        authors.Add(author);
                    }
                }
                myConnection.Close();
            }
            catch
            {
            }
            return authors;
        }

        public List<Types> GetAllTypes()
        {
            List<Types> types = new List<Types>();
            try
            {
                SqlConnection myConnection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
                myConnection.Open();
                SqlCommand newCmd = new SqlCommand("SELECT * FROM types", myConnection);
                using (SqlDataReader myReader = newCmd.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        Types type = new Types();
                        type.typeID = Convert.ToInt32(myReader["typeID"]);
                        type.name = myReader["name"].ToString();
                        types.Add(type);
                    }
                }
                myConnection.Close();
            }
            catch
            {
            }
            return types;
        }

        public List<Borrows> GetAllBorrows()
        {
            List<Borrows> borrows = new List<Borrows>();
            try
            {
                SqlConnection myConnection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
                myConnection.Open();
                SqlCommand newCmd = new SqlCommand("SELECT * FROM borrows", myConnection);
                using (SqlDataReader myReader = newCmd.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        Borrows borrow = new Borrows();
                        borrow.borrowID = Convert.ToInt32(myReader["borrowID"]);
                        borrow.bookID = Convert.ToInt32(myReader["bookID"]);
                        borrow.studentID = Convert.ToInt32(myReader["studentID"]);
                        borrow.takenDate = Convert.ToDateTime(myReader["takenDate"]);
                        borrow.broughtDate = Convert.ToDateTime(myReader["broughtDate"]);
                        borrows.Add(borrow);
                    }
                }
                myConnection.Close();
            }
            catch
            {
            }
            return borrows;
        }

        public List<Students> GetAllStudents()
        {
            List<Students> students = new List<Students>();
            try
            {
                SqlConnection myConnection = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True");
                myConnection.Open();
                SqlCommand newCmd = new SqlCommand("SELECT * FROM students", myConnection);
                using (SqlDataReader myReader = newCmd.ExecuteReader())
                {
                    while (myReader.Read())
                    {
                        Students student = new Students();
                        student.studentID = Convert.ToInt32(myReader["studentID"]);
                        student.name = myReader["name"].ToString();
                        student.surname = myReader["surname"].ToString();
                        student.birthdate = Convert.ToDateTime(myReader["birthdate"]);
                        student.gender = myReader["gender"].ToString();
                        student.Class = myReader["class"].ToString();
                        student.point = Convert.ToInt32(myReader["point"]);
                        students.Add(student);
                    }
                }
            }
            catch
            {
            }
            return students;
        }
    }
}