//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SalesDB.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class Produit_Section
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Produit_Section()
        {
            this.Produits = new HashSet<Produit>();
        }
    
        public decimal sub_ID { get; set; }
        public string sub_Code { get; set; }
        public string sub_Nom { get; set; }
        public string sub_Type { get; set; }
        public Nullable<bool> sub_Status { get; set; }
        public string sub_Note { get; set; }
        public Nullable<decimal> catg_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Produit> Produits { get; set; }
        public virtual Produit_Categorie Produit_Categorie { get; set; }
    }
}
