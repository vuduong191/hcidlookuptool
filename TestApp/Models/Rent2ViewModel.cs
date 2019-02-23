using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApp.Models
{
    public class Rent2ViewModel
    {
        public long APN { get; set; }
        public string Property_Address { get; set; }
        public string Service_Date { get; set; }
        public string Land_Use_Code { get; set; }
        public Nullable<int> Unit_Count { get; set; }
    }
}