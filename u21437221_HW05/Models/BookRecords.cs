using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21437221_HW05.Models
{
    public class BookRecords
    {
        public List<Books> Book { get; set; }
        public List<Authors> Author { get; set; }

        public string GetAuthorOf(int authorID)
        {
            List<Authors> result = Author.Where(author => author.authorID == authorID).ToList();
            return result.ToString();
        }
    }
}