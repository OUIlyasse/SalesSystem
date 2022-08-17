using sysSales.IForms;
using System;
using System.Threading;
using static Tools.myTools;

namespace sysSales.Main
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        #region Codes
        private void ShowDate()
        {
            dtDate.EditValue = GetDateTime();
        }
        private void ShowTime()
        {
            timerTimes.Start();
        }
        #endregion Codes
        public frmMain()
        {
            InitializeComponent();
            ShowDate();
            ShowTime();
        }

        private void btnNewForm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Ifrm f = new Ifrm();
            OpenForm(this, f, mdiManager);
        }

        private void timerTimes_Tick(object sender, EventArgs e)
        {
            txtTime.Caption = GetDateTime().ToString("T");
        }
    }
}