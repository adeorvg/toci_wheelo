//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Toci.Driver.Dal.Invitation.Interfaces
{
    using System;
    using System.Collections.Generic;
    
    public partial class Car
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Car()
        {
            this.CarsUsers = new HashSet<CarsUser>();
        }
    
        public long Id { get; set; }
        public string LicensePlate { get; set; }
        public Nullable<long> IdCarTypeDictionary { get; set; }
        public Nullable<long> IdColour { get; set; }
    
        public virtual CarTypeDictionary CarTypeDictionary { get; set; }
        public virtual Colour Colour { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CarsUser> CarsUsers { get; set; }
    }
}