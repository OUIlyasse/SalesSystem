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
    
    public partial class Produit_Detail
    {
        public decimal dtl_ID { get; set; }
        public Nullable<decimal> dtl_Code { get; set; }
        public string dtl_Pays_Orig { get; set; }
        public Nullable<System.DateTime> dtl_Date_Production { get; set; }
        public Nullable<System.DateTime> dtl_Date_Expiration { get; set; }
        public string dtl_Serie { get; set; }
        public string dtl_Entreprise { get; set; }
        public string dtl_Periode_Garantie { get; set; }
        public Nullable<decimal> prd_ID { get; set; }
    
        public virtual Produit Produit { get; set; }
    }
}
