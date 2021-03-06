//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TouristAttractions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TouristAttractions()
        {
            this.AttractionsToGuidesTrips = new HashSet<AttractionsToGuidesTrips>();
            this.AttractionsToUsersTrips = new HashSet<AttractionsToUsersTrips>();
        }
    
        public int id { get; set; }
        public string attractionName { get; set; }
        public string address { get; set; }
        public string area { get; set; }
        public string phoneNumber { get; set; }
        public Nullable<bool> payment { get; set; }
        public string seasson { get; set; }
        public string openningHour { get; set; }
        public string closingHour { get; set; }
        public string accessibility { get; set; }
        public string hardnessLevel { get; set; }
        public string link { get; set; }
        public string notes { get; set; }
        public Nullable<bool> entranceToWater { get; set; }
        public Nullable<bool> isMatchGroups { get; set; }
        public Nullable<bool> isMatchChildren { get; set; }
        public Nullable<bool> isMatchFamilies { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string estimatedTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttractionsToGuidesTrips> AttractionsToGuidesTrips { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttractionsToUsersTrips> AttractionsToUsersTrips { get; set; }
    }
}
