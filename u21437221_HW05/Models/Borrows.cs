using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21437221_HW05.Models
{
    public class Borrows
    {
        public int borrowID { get; set; }
        public int studentID { get; set; }
        public int bookID { get; set; }
        public DateTime takenDate { get; set; }
        public DateTime broughtDate { get; set; }
    }
}