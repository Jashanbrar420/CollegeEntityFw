//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Enrollment
    {
        public int EnrollmentID { get; set; }
        public Nullable<decimal> Salary { get; set; }
        public int Dept_ID { get; set; }
        public int TEACHERID { get; set; }
        public int StateID { get; set; }
    
        public virtual DepMst DepMst { get; set; }
        public virtual StateMst StateMst { get; set; }
        public virtual TeacherMst TeacherMst { get; set; }
    }
}
