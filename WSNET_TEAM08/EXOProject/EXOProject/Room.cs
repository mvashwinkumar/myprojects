//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EXOProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Room
    {
        public Room()
        {
            this.Orders = new HashSet<Order>();
        }
    
        public int RID { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public string Summary { get; set; }
        public string Amenities { get; set; }
        public double Price { get; set; }
        public string Type { get; set; }
        public string ImageURL { get; set; }
    
        public virtual ICollection<Order> Orders { get; set; }
    }
}
