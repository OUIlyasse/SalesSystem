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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SalesSystemEntities : DbContext
    {
        public SalesSystemEntities()
            : base("name=SalesSystemEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Banque> Banques { get; set; }
        public virtual DbSet<Bon_Destruction> Bon_Destruction { get; set; }
        public virtual DbSet<Bon_Destruction_Produit> Bon_Destruction_Produit { get; set; }
        public virtual DbSet<Bon_Entree> Bon_Entree { get; set; }
        public virtual DbSet<Bon_Entree_Produit> Bon_Entree_Produit { get; set; }
        public virtual DbSet<Bon_Sortie> Bon_Sortie { get; set; }
        public virtual DbSet<Bon_Sortie_Produit> Bon_Sortie_Produit { get; set; }
        public virtual DbSet<Bon_Type> Bon_Type { get; set; }
        public virtual DbSet<Branche> Branches { get; set; }
        public virtual DbSet<Charge> Charges { get; set; }
        public virtual DbSet<Charge_Type> Charge_Type { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Compte_Bancaire> Compte_Bancaire { get; set; }
        public virtual DbSet<Compte_Charge> Compte_Charge { get; set; }
        public virtual DbSet<Compte_Client> Compte_Client { get; set; }
        public virtual DbSet<Compte_Employee> Compte_Employee { get; set; }
        public virtual DbSet<Compte_Espece> Compte_Espece { get; set; }
        public virtual DbSet<Compte_Fournisseur> Compte_Fournisseur { get; set; }
        public virtual DbSet<Compte_Local> Compte_Local { get; set; }
        public virtual DbSet<Compte_Local_Type> Compte_Local_Type { get; set; }
        public virtual DbSet<Devise> Devises { get; set; }
        public virtual DbSet<Devise_Banque> Devise_Banque { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<Employee_Salaire> Employee_Salaire { get; set; }
        public virtual DbSet<Entreprise_Info> Entreprise_Info { get; set; }
        public virtual DbSet<Facture_Achat> Facture_Achat { get; set; }
        public virtual DbSet<Facture_Achat_Bonus> Facture_Achat_Bonus { get; set; }
        public virtual DbSet<Facture_Achat_Produit> Facture_Achat_Produit { get; set; }
        public virtual DbSet<Facture_Achat_Produit_Retour> Facture_Achat_Produit_Retour { get; set; }
        public virtual DbSet<Facture_Achat_Retour> Facture_Achat_Retour { get; set; }
        public virtual DbSet<Facture_Paiement_Type> Facture_Paiement_Type { get; set; }
        public virtual DbSet<Facture_Type> Facture_Type { get; set; }
        public virtual DbSet<Facture_Vente> Facture_Vente { get; set; }
        public virtual DbSet<Facture_Vente_Bonus> Facture_Vente_Bonus { get; set; }
        public virtual DbSet<Facture_Vente_Produit> Facture_Vente_Produit { get; set; }
        public virtual DbSet<Facture_Vente_Produit_Retour> Facture_Vente_Produit_Retour { get; set; }
        public virtual DbSet<Facture_Vente_Retour> Facture_Vente_Retour { get; set; }
        public virtual DbSet<Fournisseur> Fournisseurs { get; set; }
        public virtual DbSet<Impot> Impots { get; set; }
        public virtual DbSet<Magasin> Magasins { get; set; }
        public virtual DbSet<Magasin_Branche> Magasin_Branche { get; set; }
        public virtual DbSet<Main_Caisse> Main_Caisse { get; set; }
        public virtual DbSet<Operation_Bon_Entree_Magasin> Operation_Bon_Entree_Magasin { get; set; }
        public virtual DbSet<Operation_Bon_Sortie_Magasin> Operation_Bon_Sortie_Magasin { get; set; }
        public virtual DbSet<Operation_Caisse> Operation_Caisse { get; set; }
        public virtual DbSet<Operation_Facture_Achat> Operation_Facture_Achat { get; set; }
        public virtual DbSet<Operation_Facture_Achat_Retour> Operation_Facture_Achat_Retour { get; set; }
        public virtual DbSet<Operation_Facture_Vente> Operation_Facture_Vente { get; set; }
        public virtual DbSet<Operation_Facture_Vente_Retour> Operation_Facture_Vente_Retour { get; set; }
        public virtual DbSet<Operation_Impot> Operation_Impot { get; set; }
        public virtual DbSet<Operation_Recu_Achat> Operation_Recu_Achat { get; set; }
        public virtual DbSet<Operation_Recu_Vente> Operation_Recu_Vente { get; set; }
        public virtual DbSet<Produit> Produits { get; set; }
        public virtual DbSet<Produit_Barcode> Produit_Barcode { get; set; }
        public virtual DbSet<Produit_Boxe> Produit_Boxe { get; set; }
        public virtual DbSet<Produit_Categorie> Produit_Categorie { get; set; }
        public virtual DbSet<Produit_Detail> Produit_Detail { get; set; }
        public virtual DbSet<Produit_Emplacement> Produit_Emplacement { get; set; }
        public virtual DbSet<Produit_Image> Produit_Image { get; set; }
        public virtual DbSet<Produit_Section> Produit_Section { get; set; }
        public virtual DbSet<Produit_Type> Produit_Type { get; set; }
        public virtual DbSet<Recu_Achat> Recu_Achat { get; set; }
        public virtual DbSet<Recu_Type> Recu_Type { get; set; }
        public virtual DbSet<Recu_Vente> Recu_Vente { get; set; }
        public virtual DbSet<Traitement> Traitements { get; set; }
        public virtual DbSet<Unite_Mesure> Unite_Mesure { get; set; }
        public virtual DbSet<Unite_Type> Unite_Type { get; set; }
    }
}
