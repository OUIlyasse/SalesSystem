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
    
    public partial class Compte_Client
    {
        public decimal clt_C_ID { get; set; }
        public string clt_C_Code { get; set; }
        public string clt_C_Nom { get; set; }
        public Nullable<System.DateTime> clt_C_Date { get; set; }
        public Nullable<decimal> clt_C_Limit_Montant { get; set; }
        public Nullable<decimal> trait_ID { get; set; }
        public Nullable<int> clt_C_Status { get; set; }
        public string clt_C_Note { get; set; }
        public Nullable<decimal> clt_ID { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Traitement Traitement { get; set; }
    }
}
