//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebRole1.Content
{
    using System;
    using System.Collections.Generic;
    
    public partial class Memberships
    {
        public int MemberId { get; set; }
        public string PersonId { get; set; }
        public string Saved { get; set; }
        public string SalvationDate { get; set; }
        public string Baptized { get; set; }
        public string BaptizedDate { get; set; }
        public string DateJoined { get; set; }
        public string MethodOfEntry { get; set; }
        public string TransferedFrom { get; set; }
        public string CopyOfLetter { get; set; }
    
        public virtual Adults Adult { get; set; }
        public virtual Children Child { get; set; }
    }
}