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
    }
}