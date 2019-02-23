using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestApp.Models
{
    public class Bims2ViewModel
    {
        public Nullable<int> StatementNum { get; set; }
        public long APN { get; set; }
        public string StatementDate { get; set; }
        public string Property_Address { get; set; }
        public string Property_City_State_Zip { get; set; }
    }
}