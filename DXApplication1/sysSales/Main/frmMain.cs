using sysSales.IForms;
using System;
using static Tools.myTools;

namespace sysSales.Main
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnNewForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ifrm f = new Ifrm();
            OpenForm(this, f, mdiManager);
        }
    }
}