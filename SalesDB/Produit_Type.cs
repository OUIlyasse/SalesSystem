//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SalesDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produit_Type
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produit_Type()
        {
            this.Produits = new HashSet<Produit>();
        }
    
        public decimal typ_ID { get; set; }
        public Nullable<decimal> typ_Code { get; set; }
        public string typ_Type { get; set; }
        public Nullable<bool> typ_Status { get; set; }
        public string typ_Note { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produit> Produits { get; set; }
    }
}