using System;
using System.Collections.Generic;
using System.Text;

namespace GxTrans.Domain.Models
{
    public class Jscape_UserDetail
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LoginID { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Group { get; set; }
        public string CompanyName { get; set; }
        public string RealPath { get; set; }
        public string LastLoginDate { get; set; }
    }
}
