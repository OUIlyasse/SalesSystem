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
    
    public partial class Bon_Entree_Produit
    {
        public decimal prd_B_E_ID { get; set; }
        public Nullable<decimal> prd_B_E_Code { get; set; }
        public Nullable<System.DateTime> prd_B_E_Date { get; set; }
        public Nullable<System.TimeSpan> prd_B_E_Temps { get; set; }
        public Nullable<int> prd_B_E_Quantite { get; set; }
        public string prd_B_E_Text { get; set; }
        public Nullable<bool> prd_B_E_Status { get; set; }
        public string prd_B_E_Note { get; set; }
        public Nullable<decimal> prd_ID { get; set; }
        public Nullable<decimal> bon_E_ID { get; set; }
    
        public virtual Bon_Entree Bon_Entree { get; set; }
        public virtual Produit Produit { get; set; }
    }
}