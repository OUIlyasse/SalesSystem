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
    
    public partial class Bon_Sortie
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Bon_Sortie()
        {
            this.Bon_Sortie_Produit = new HashSet<Bon_Sortie_Produit>();
        }
    
        public decimal bon_S_ID { get; set; }
        public Nullable<decimal> bon_S_Code { get; set; }
        public Nullable<System.DateTime> bon_S_Date { get; set; }
        public Nullable<System.TimeSpan> bon_S_Temps { get; set; }
        public string bon_S_Text { get; set; }
        public Nullable<bool> bon_S_Status { get; set; }
        public string bon_S_Note { get; set; }
        public Nullable<decimal> fact_V_ID { get; set; }
        public Nullable<decimal> bon_T_ID { get; set; }
    
        public virtual Bon_Type Bon_Type { get; set; }
        public virtual Facture_Vente Facture_Vente { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bon_Sortie_Produit> Bon_Sortie_Produit { get; set; }
    }
}
