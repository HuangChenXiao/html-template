//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Custom.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class TZ_Customized
    {
        public int Id { get; set; }
        public Nullable<int> ProjectId { get; set; }
        public Nullable<int> ProjectTypeId { get; set; }
        public string BeginTime { get; set; }
        public string Days { get; set; }
        public string ChildrenNum { get; set; }
        public string AdultNum { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Phone { get; set; }
        public string MailBox { get; set; }
        public string Remarks { get; set; }
        public Nullable<int> Type { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> AddTime { get; set; }
        public string HandleUser { get; set; }
        public Nullable<System.DateTime> HandleTime { get; set; }
        public string Reason { get; set; }
    }
}
