//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Providers.entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class Persons
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Persons()
        {
            this.Deals = new HashSet<Deals>();
        }
    
        public int Person_id { get; set; }
        public int Person_provider { get; set; }
        public string Person_name { get; set; }
        public string Person_lastName { get; set; }
        public string Person_phone { get; set; }
        public string Person_email { get; set; }
        public Nullable<int> Person_status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Deals> Deals { get; set; }
        public virtual PersonStatuses PersonStatuses { get; set; }
        public virtual Providers Providers { get; set; }
    }
}
