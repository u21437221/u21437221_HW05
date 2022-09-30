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
        public List<Types> Type { get; set; }
        public List<Borrows> Borrow { get; set; }

        public string GetAuthorOf(int authorID)
        {
            List<Authors> result = Author.Where(author => author.authorID == authorID).ToList();
            return result.ToString();
        }

        public string GetTypeOf(int typeID)
        {
            List<Types> result = Type.Where(type => type.typeID == typeID).ToList();
            return result.ToString();
        }
    }
}