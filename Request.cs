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
    
    public partial class Request
    {
        public int RequestId { get; set; }
        public System.DateTime RequestDate { get; set; }
        public string RequestUnit { get; set; }
        public int RequestReason { get; set; }
        public int RequestVisitor { get; set; }
        public System.DateTime RequestStartRange { get; set; }
        public System.DateTime RequestEndRange { get; set; }
        public int RequestStatusID { get; set; }
    
        public virtual Reason Reason { get; set; }
        public virtual Status Status { get; set; }
        public virtual Visitor Visitor { get; set; }
        public virtual Visit Visit { get; set; }
    }
}
