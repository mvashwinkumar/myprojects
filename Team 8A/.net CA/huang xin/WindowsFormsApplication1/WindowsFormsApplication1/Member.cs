//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryTeam8A
{
    using System;
    using System.Collections.Generic;
    
    public partial class Member
    {
        public Member()
        {
            this.Transactions = new HashSet<Transaction>();
        }
    
        public string MemberID { get; set; }
        public string MemberName { get; set; }
        public string PhoneNumber { get; set; }
        public string Country { get; set; }
    
        public virtual ICollection<Transaction> Transactions { get; set; }
    }
}