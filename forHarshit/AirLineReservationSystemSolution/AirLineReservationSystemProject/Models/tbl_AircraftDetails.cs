//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirLineReservationSystemProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_AircraftDetails
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_AircraftDetails()
        {
            this.tblSeats = new HashSet<tblSeat>();
            this.tblTrips = new HashSet<tblTrip>();
        }
    
        public string Airplane_no { get; set; }
        public int Capacity { get; set; }
        public string CabinType { get; set; }
        public int Column_no { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblSeat> tblSeats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTrip> tblTrips { get; set; }
    }
}
