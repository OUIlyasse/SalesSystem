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
    
    public partial class Facture_Achat_Retour
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Facture_Achat_Retour()
        {
            this.Facture_Achat_Produit_Retour = new HashSet<Facture_Achat_Produit_Retour>();
            this.Operation_Facture_Achat_Retour = new HashSet<Operation_Facture_Achat_Retour>();
        }
    
        public decimal fact_A_R_ID { get; set; }
        public Nullable<decimal> fact_A_R_Code { get; set; }
        public Nullable<System.DateTime> fact_A_R_Date { get; set; }
        public Nullable<System.TimeSpan> fact_A_R_Temps { get; set; }
        public Nullable<System.DateTime> fact_A_R_Ech_Date { get; set; }
        public string fact_A_R_Text { get; set; }
        public Nullable<decimal> frns_ID { get; set; }
        public Nullable<decimal> fact_A_R_Montatnt { get; set; }
        public Nullable<decimal> fact_A_R_Tax_Pourc { get; set; }
        public Nullable<decimal> fact_A_R_Tax_Montant { get; set; }
        public Nullable<decimal> fact_A_R_Tax_Montant_Apres { get; set; }
        public Nullable<decimal> fact_A_R_Escompte { get; set; }
        public Nullable<decimal> fact_A_R_Escompte_Type { get; set; }
        public Nullable<decimal> fact_A_R_Total { get; set; }
        public Nullable<decimal> fact_A_R_Net { get; set; }
        public string fact_A_R_Adresse { get; set; }
        public Nullable<decimal> pay_ID { get; set; }
        public Nullable<decimal> fact_T_ID { get; set; }
        public Nullable<bool> fact_A_R_Status { get; set; }
        public string fact_A_R_Note { get; set; }
        public Nullable<decimal> fact_A_ID { get; set; }
    
        public virtual Facture_Achat Facture_Achat { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Facture_Achat_Produit_Retour> Facture_Achat_Produit_Retour { get; set; }
        public virtual Facture_Paiement_Type Facture_Paiement_Type { get; set; }
        public virtual Facture_Type Facture_Type { get; set; }
        public virtual Fournisseur Fournisseur { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Operation_Facture_Achat_Retour> Operation_Facture_Achat_Retour { get; set; }
    }
}
