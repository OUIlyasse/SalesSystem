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
    
    public partial class Compte_Espece
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Compte_Espece()
        {
            this.Operation_Caisse = new HashSet<Operation_Caisse>();
            this.Recu_Achat = new HashSet<Recu_Achat>();
            this.Recu_Vente = new HashSet<Recu_Vente>();
        }
    
        public decimal esp_C_ID { get; set; }
        public string esp_C_Code { get; set; }
        public string esp_C_Nom { get; set; }
        public Nullable<System.DateTime> esp_C_Date_Creation { get; set; }
        public Nullable<decimal> esp_C_D_Solde { get; set; }
        public Nullable<decimal> esp_C_Z_Solde { get; set; }
        public Nullable<decimal> esp_C_Solde { get; set; }
        public Nullable<int> esp_C_Status { get; set; }
        public Nullable<decimal> cais_ID { get; set; }
    
        public virtual Main_Caisse Main_Caisse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operation_Caisse> Operation_Caisse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recu_Achat> Recu_Achat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Recu_Vente> Recu_Vente { get; set; }
    }
}
