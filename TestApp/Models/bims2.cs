//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class bims2
    {
        public int id { get; set; }
        public Nullable<int> StatementNum { get; set; }
        public string StatementDate { get; set; }
        public long APN { get; set; }
        public string Property_Address { get; set; }
        public string Property_City_State_Zip { get; set; }
        public Nullable<int> RSO_Exemptions { get; set; }
        public Nullable<int> SCEP_Exmpetions { get; set; }
        public string IS_RSO { get; set; }
        public string IS_SCEP { get; set; }
        public string RSO_Invoice_Num { get; set; }
        public string SCEP_Invoice_Num { get; set; }
        public Nullable<int> Total_Units { get; set; }
        public Nullable<int> RSO_Units_Billed { get; set; }
        public Nullable<int> SCEP_Units_Billed { get; set; }
        public string is_active { get; set; }
        public Nullable<int> AddressMasterId { get; set; }
    }
}