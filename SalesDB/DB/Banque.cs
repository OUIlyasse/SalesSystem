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
    
    public partial class Banque
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Banque()
        {
            this.Compte_Bancaire = new HashSet<Compte_Bancaire>();
            this.Devise_Banque = new HashSet<Devise_Banque>();
        }
    
        public decimal ban_ID { get; set; }
        public Nullable<decimal> ban_Code { get; set; }
        public string ban_Nom { get; set; }
        public string ban_Adresse { get; set; }
        public string ban_Tele { get; set; }
        public string ban_Branche { get; set; }
        public string ban_Nationalite { get; set; }
        public Nullable<int> ban_Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Compte_Bancaire> Compte_Bancaire { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Devise_Banque> Devise_Banque { get; set; }
    }
}