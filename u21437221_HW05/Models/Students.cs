﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace u21437221_HW05.Models
{
    public class Students
    {
        public int studentID { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public DateTime birthdate { get; set; }
        public string gender { get; set; }
        public string Class { get; set; }
        public int point { get; set; }
    }
}