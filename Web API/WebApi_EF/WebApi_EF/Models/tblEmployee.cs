//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApi_EF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblEmployee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Gender { get; set; }
        public Nullable<double> Salary { get; set; }
        public Nullable<int> DeptId { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
    
        public virtual tblDepartment tblDepartment { get; set; }
    }
}
