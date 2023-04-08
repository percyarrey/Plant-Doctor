using System;
using System.Collections.Generic;
using System.Text;

namespace Plant_Doctor.Tables
{
    internal class reguserdata
    {
        public Guid Userid { get; set; }
        public string fname { get; set; }
        public string lname { get; set; }
        public string email { get; set; }
        public string pwd { get; set; }
        public bool check { get; set; }
    }
}
