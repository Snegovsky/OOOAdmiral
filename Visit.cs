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
    
    public partial class Visit
    {
        public int VisitID { get; set; }
        public int VisitEmployeeID { get; set; }
        public System.DateTime VisitDate { get; set; }
        public System.TimeSpan VisitTime { get; set; }
        public string VisitDuration { get; set; }
        public int VisitResult { get; set; }
        public string VisitComments { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Request Request { get; set; }
        public virtual Result Result { get; set; }
    }
}