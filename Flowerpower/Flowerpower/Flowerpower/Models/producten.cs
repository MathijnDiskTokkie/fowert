//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Flowerpower.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class producten
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public producten()
        {
            this.winkelmand = new HashSet<winkelmand>();
        }
    
        public int productid { get; set; }
        public string productnaam { get; set; }
        public Nullable<decimal> prijs { get; set; }
        public string productomschrijving { get; set; }
        public Nullable<bool> gearchiveerd { get; set; }
        public string url { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<winkelmand> winkelmand { get; set; }
    }
}
