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
    
    public partial class EmergencyContacts
    {
        public int Id { get; set; }
        public string ContactId { get; set; }
        public string EContactFirstName { get; set; }
        public string EContactLastName { get; set; }
        public string EContactSuffix { get; set; }
        public string EContactPhone { get; set; }
        public string EContactAddress { get; set; }
        public string EContactCity { get; set; }
        public string EContactState { get; set; }
        public string EContactZip { get; set; }
        public string NonHouseHoldFirstName { get; set; }
        public string NonHouseHoldLastName { get; set; }
        public string NonHouseHoldSuffix { get; set; }
        public string NonHouseHoldPhone { get; set; }
        public string NonHouseHoldAddress { get; set; }
        public string NonHouseHoldCity { get; set; }
        public string NonHouseHoldState { get; set; }
        public string NonHouseHoldZip { get; set; }
    
        public virtual Adults Adult { get; set; }
        public virtual Children Child { get; set; }
    }
}