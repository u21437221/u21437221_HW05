using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21437221_HW05.Models
{
    public class Books
    {
        public int bookID { get; set; }
        public string name { get; set; }
        public int pagecount { get; set; }
        public int point { get; set; }
        public int authorID { get; set; }
        public int typeID { get; set; }
    }
}