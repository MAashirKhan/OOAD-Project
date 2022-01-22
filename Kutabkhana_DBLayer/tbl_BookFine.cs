//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Kutabkhana_DBLayer
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class tbl_BookFine
    {
        public int BookFineID { get; set; }
        [Required(ErrorMessage = "Please Select Employee!")]
        public int EmployeeID { get; set; }
        [Required(ErrorMessage = "Please Select Book!")]
        public int BookID { get; set; }
        [Required(ErrorMessage = "Please Select User!")]
        public int UserID { get; set; }

        [DataType(DataType.Date)]
        public System.DateTime FineDate { get; set; }
        public double FineAmount { get; set; }
        public Nullable<double> ReceiveAmount { get; set; }
        public int NoOfDays { get; set; }
    
        public virtual tbl_Book tbl_Book { get; set; }
        public virtual tbl_Employee tbl_Employee { get; set; }
    }
}
