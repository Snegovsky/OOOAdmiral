//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OOOAdmiral
{
    using System;
    using System.Collections.Generic;
    
    public partial class Report
    {
        public int ReportID { get; set; }
        public int ReportEmployeeID { get; set; }
        public string ReportVisitNumber { get; set; }
        public Nullable<System.TimeSpan> ReportTime { get; set; }
        public string ReportVisitors { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}
