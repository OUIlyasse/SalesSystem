using SalesDB.DB;
using sysSales.IForms;
using System;

namespace sysSales.Sub
{
    public partial class frmInfoCompany : Ifrm
    {
        #region Varibales
        private SalesSystemEntities db = new SalesSystemEntities();
        private Entreprise_Info ent;
        #endregion Varibales

        #region myCodes
        private string getMaxID()
        {
            return "";
        }
        private string getCode()
        {
            return "";
        }
        #endregion myCodes

        #region Override
        public override void Data_Add(SalesSystemEntities T)
        {
            ent = new Entreprise_Info();
            ent.entr_ID = Convert.ToDecimal(getMaxID());
            ent.entr_Code = getCode();
            ent.entr_Nom = getCode();
            ent.entr_Adresse1 = getCode();
            ent.entr_Adresse2 = getCode();
            ent.entr_Mobile1 = getCode();
            ent.entr_Mobile2 = getCode();
            ent.entr_Fixe1 = getCode();
            ent.entr_fixe2 = getCode();
            ent.entr_Fax1 = getCode();
            ent.entr_Fax2 = getCode();
            ent.entr_Email = getCode();
            ent.entr_Image = getCode();
            ent.entr_Note = getCode();
            base.Data_Add(T);
        }
        #endregion Override
        public frmInfoCompany()
        {
            InitializeComponent();
        }
    }
}