//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AspMvcEf.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Test_Result
    {
        public int Id { get; set; }
        public int Test_Schedule_Id { get; set; }
        public int Test_Group_Id { get; set; }
        public int Test_Id { get; set; }
        public Nullable<int> Flag_Ok { get; set; }
        public string Result { get; set; }
        public Nullable<System.DateTime> Time_Start { get; set; }
        public Nullable<System.DateTime> Time_Stop { get; set; }
        public int Test_User_Id { get; set; }
    
        public virtual Test Test { get; set; }
        public virtual Test_Group Test_Group { get; set; }
        public virtual Test_Schedule Test_Schedule { get; set; }
        public virtual Test_User Test_User { get; set; }
    }
}
