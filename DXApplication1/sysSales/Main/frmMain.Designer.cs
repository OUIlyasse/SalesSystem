namespace sysSales.Main
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barHeaderItem1 = new DevExpress.XtraBars.BarHeaderItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.barEditItem1 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barEditItem2 = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.txtDate = new DevExpress.XtraBars.BarStaticItem();
            this.txtTime = new DevExpress.XtraBars.BarStaticItem();
            this.txtStatus = new DevExpress.XtraBars.BarStaticItem();
            this.btnNewForm = new DevExpress.XtraBars.BarButtonItem();
            this.dtDate = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemDateEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            this.btnSSoftware = new DevExpress.XtraBars.BarButtonItem();
            this.btnUsersPermission = new DevExpress.XtraBars.BarButtonItem();
            this.btnEmployee = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem9 = new DevExpress.XtraBars.BarButtonItem();
            this.btnBackup = new DevExpress.XtraBars.BarButtonItem();
            this.btnConnectDB = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem6 = new DevExpress.XtraBars.BarButtonItem();
            this.btnEditInvoices = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.mdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.timerTimes = new System.Windows.Forms.Timer(this.components);
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup8 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup9 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdiManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barHeaderItem1,
            this.barStaticItem1,
            this.barEditItem1,
            this.barEditItem2,
            this.txtDate,
            this.txtTime,
            this.txtStatus,
            this.btnNewForm,
            this.dtDate,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barButtonItem3,
            this.barButtonItem4,
            this.barButtonItem5,
            this.btnSSoftware,
            this.btnUsersPermission,
            this.btnEmployee,
            this.barButtonItem9,
            this.btnBackup,
            this.btnConnectDB,
            this.barButtonItem6,
            this.btnEditInvoices});
            resources.ApplyResources(this.ribbon, "ribbon");
            this.ribbon.MaxItemId = 23;
            this.ribbon.Name = "ribbon";
            this.ribbon.PageHeaderItemLinks.Add(this.barHeaderItem1);
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage5,
            this.ribbonPage6});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemDateEdit1,
            this.repositoryItemDateEdit2,
            this.repositoryItemDateEdit3});
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barHeaderItem1
            // 
            resources.ApplyResources(this.barHeaderItem1, "barHeaderItem1");
            this.barHeaderItem1.Id = 1;
            this.barHeaderItem1.Name = "barHeaderItem1";
            this.barHeaderItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barStaticItem1
            // 
            resources.ApplyResources(this.barStaticItem1, "barStaticItem1");
            this.barStaticItem1.Id = 2;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // barEditItem1
            // 
            this.barEditItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barEditItem1.Edit = this.repositoryItemDateEdit1;
            this.barEditItem1.Id = 3;
            this.barEditItem1.Name = "barEditItem1";
            // 
            // repositoryItemDateEdit1
            // 
            resources.ApplyResources(this.repositoryItemDateEdit1, "repositoryItemDateEdit1");
            this.repositoryItemDateEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemDateEdit1.Buttons"))))});
            this.repositoryItemDateEdit1.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemDateEdit1.CalendarTimeProperties.Buttons"))))});
            this.repositoryItemDateEdit1.Mask.EditMask = resources.GetString("repositoryItemDateEdit1.Mask.EditMask");
            this.repositoryItemDateEdit1.Name = "repositoryItemDateEdit1";
            this.repositoryItemDateEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // barEditItem2
            // 
            this.barEditItem2.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barEditItem2.Edit = this.repositoryItemDateEdit2;
            this.barEditItem2.Id = 4;
            this.barEditItem2.Name = "barEditItem2";
            // 
            // repositoryItemDateEdit2
            // 
            resources.ApplyResources(this.repositoryItemDateEdit2, "repositoryItemDateEdit2");
            this.repositoryItemDateEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemDateEdit2.Buttons"))))});
            this.repositoryItemDateEdit2.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemDateEdit2.CalendarTimeProperties.Buttons"))))});
            this.repositoryItemDateEdit2.Name = "repositoryItemDateEdit2";
            // 
            // txtDate
            // 
            this.txtDate.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            resources.ApplyResources(this.txtDate, "txtDate");
            this.txtDate.Id = 5;
            this.txtDate.Name = "txtDate";
            // 
            // txtTime
            // 
            this.txtTime.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            resources.ApplyResources(this.txtTime, "txtTime");
            this.txtTime.Id = 6;
            this.txtTime.ItemAppearance.Normal.Font = ((System.Drawing.Font)(resources.GetObject("txtTime.ItemAppearance.Normal.Font")));
            this.txtTime.ItemAppearance.Normal.ForeColor = ((System.Drawing.Color)(resources.GetObject("txtTime.ItemAppearance.Normal.ForeColor")));
            this.txtTime.ItemAppearance.Normal.Options.UseFont = true;
            this.txtTime.ItemAppearance.Normal.Options.UseForeColor = true;
            this.txtTime.Name = "txtTime";
            this.txtTime.TextAlignment = System.Drawing.StringAlignment.Center;
            this.txtTime.Width = 100;
            // 
            // txtStatus
            // 
            resources.ApplyResources(this.txtStatus, "txtStatus");
            this.txtStatus.Id = 7;
            this.txtStatus.Name = "txtStatus";
            // 
            // btnNewForm
            // 
            resources.ApplyResources(this.btnNewForm, "btnNewForm");
            this.btnNewForm.Id = 8;
            this.btnNewForm.Name = "btnNewForm";
            this.btnNewForm.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnNewForm_ItemClick);
            // 
            // dtDate
            // 
            this.dtDate.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.dtDate.AutoHideEdit = false;
            this.dtDate.Edit = this.repositoryItemDateEdit3;
            this.dtDate.EditHeight = 180;
            resources.ApplyResources(this.dtDate, "dtDate");
            this.dtDate.Id = 9;
            this.dtDate.Name = "dtDate";
            // 
            // repositoryItemDateEdit3
            // 
            this.repositoryItemDateEdit3.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemDateEdit3.Buttons"))))});
            this.repositoryItemDateEdit3.CalendarDateEditing = false;
            this.repositoryItemDateEdit3.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.False;
            this.repositoryItemDateEdit3.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(((DevExpress.XtraEditors.Controls.ButtonPredefines)(resources.GetObject("repositoryItemDateEdit3.CalendarTimeProperties.Buttons"))))});
            this.repositoryItemDateEdit3.DisplayFormat.FormatString = "D";
            this.repositoryItemDateEdit3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit3.EditFormat.FormatString = "D";
            this.repositoryItemDateEdit3.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.repositoryItemDateEdit3.Mask.EditMask = resources.GetString("repositoryItemDateEdit3.Mask.EditMask");
            this.repositoryItemDateEdit3.Name = "repositoryItemDateEdit3";
            this.repositoryItemDateEdit3.ReadOnly = true;
            this.repositoryItemDateEdit3.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // barButtonItem1
            // 
            resources.ApplyResources(this.barButtonItem1, "barButtonItem1");
            this.barButtonItem1.Id = 10;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem2
            // 
            resources.ApplyResources(this.barButtonItem2, "barButtonItem2");
            this.barButtonItem2.Id = 11;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem3
            // 
            resources.ApplyResources(this.barButtonItem3, "barButtonItem3");
            this.barButtonItem3.Id = 12;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // barButtonItem4
            // 
            resources.ApplyResources(this.barButtonItem4, "barButtonItem4");
            this.barButtonItem4.Id = 13;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // barButtonItem5
            // 
            resources.ApplyResources(this.barButtonItem5, "barButtonItem5");
            this.barButtonItem5.Id = 14;
            this.barButtonItem5.Name = "barButtonItem5";
            // 
            // btnSSoftware
            // 
            resources.ApplyResources(this.btnSSoftware, "btnSSoftware");
            this.btnSSoftware.Id = 15;
            this.btnSSoftware.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSSoftware.ImageOptions.Image")));
            this.btnSSoftware.Name = "btnSSoftware";
            this.btnSSoftware.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnUsersPermission
            // 
            resources.ApplyResources(this.btnUsersPermission, "btnUsersPermission");
            this.btnUsersPermission.Id = 16;
            this.btnUsersPermission.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUsersPermission.ImageOptions.Image")));
            this.btnUsersPermission.Name = "btnUsersPermission";
            this.btnUsersPermission.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnEmployee
            // 
            resources.ApplyResources(this.btnEmployee, "btnEmployee");
            this.btnEmployee.Id = 17;
            this.btnEmployee.ImageOptions.Image = global::sysSales.Properties.Resources.Employee_32;
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem9
            // 
            resources.ApplyResources(this.barButtonItem9, "barButtonItem9");
            this.barButtonItem9.Id = 18;
            this.barButtonItem9.Name = "barButtonItem9";
            this.barButtonItem9.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnBackup
            // 
            resources.ApplyResources(this.btnBackup, "btnBackup");
            this.btnBackup.Id = 19;
            this.btnBackup.ImageOptions.Image = global::sysSales.Properties.Resources.Drive_Backup_32;
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnConnectDB
            // 
            resources.ApplyResources(this.btnConnectDB, "btnConnectDB");
            this.btnConnectDB.Id = 20;
            this.btnConnectDB.ImageOptions.Image = global::sysSales.Properties.Resources.database_connect_32;
            this.btnConnectDB.Name = "btnConnectDB";
            this.btnConnectDB.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barButtonItem6
            // 
            resources.ApplyResources(this.barButtonItem6, "barButtonItem6");
            this.barButtonItem6.Id = 21;
            this.barButtonItem6.ImageOptions.Image = global::sysSales.Properties.Resources.Notepad_32;
            this.barButtonItem6.Name = "barButtonItem6";
            this.barButtonItem6.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // btnEditInvoices
            // 
            resources.ApplyResources(this.btnEditInvoices, "btnEditInvoices");
            this.btnEditInvoices.Id = 22;
            this.btnEditInvoices.ImageOptions.Image = global::sysSales.Properties.Resources.invoice_32;
            this.btnEditInvoices.Name = "btnEditInvoices";
            this.btnEditInvoices.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Appearance.Options.UseFont = true;
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            resources.ApplyResources(this.ribbonPage1, "ribbonPage1");
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            resources.ApplyResources(this.ribbonPageGroup1, "ribbonPageGroup1");
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup3,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage2.Name = "ribbonPage2";
            resources.ApplyResources(this.ribbonPage2, "ribbonPage2");
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnSSoftware);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnUsersPermission);
            this.ribbonPageGroup2.ItemLinks.Add(this.btnEmployee);
            this.ribbonPageGroup2.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.ShowCaptionButton = false;
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnBackup);
            this.ribbonPageGroup3.ItemLinks.Add(this.btnConnectDB);
            this.ribbonPageGroup3.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.ShowCaptionButton = false;
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItem6);
            this.ribbonPageGroup4.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.ShowCaptionButton = false;
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnEditInvoices);
            this.ribbonPageGroup5.ItemsLayout = DevExpress.XtraBars.Ribbon.RibbonPageGroupItemsLayout.OneRow;
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.ShowCaptionButton = false;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.txtStatus);
            this.ribbonStatusBar.ItemLinks.Add(this.dtDate, true);
            this.ribbonStatusBar.ItemLinks.Add(this.txtTime);
            resources.ApplyResources(this.ribbonStatusBar, "ribbonStatusBar");
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            // 
            // mdiManager
            // 
            this.mdiManager.AppearancePage.HeaderActive.BackColor = ((System.Drawing.Color)(resources.GetObject("mdiManager.AppearancePage.HeaderActive.BackColor")));
            this.mdiManager.AppearancePage.HeaderActive.Font = ((System.Drawing.Font)(resources.GetObject("mdiManager.AppearancePage.HeaderActive.Font")));
            this.mdiManager.AppearancePage.HeaderActive.Options.UseBackColor = true;
            this.mdiManager.AppearancePage.HeaderActive.Options.UseFont = true;
            this.mdiManager.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.mdiManager.MdiParent = this;
            this.mdiManager.PinPageButtonShowMode = DevExpress.XtraTab.PinPageButtonShowMode.InAllTabPageHeaders;
            // 
            // timerTimes
            // 
            this.timerTimes.Interval = 1000;
            this.timerTimes.Tick += new System.EventHandler(this.timerTimes_Tick);
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage3.Name = "ribbonPage3";
            resources.ApplyResources(this.ribbonPage3, "ribbonPage3");
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            resources.ApplyResources(this.ribbonPageGroup6, "ribbonPageGroup6");
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup7});
            this.ribbonPage4.Name = "ribbonPage4";
            resources.ApplyResources(this.ribbonPage4, "ribbonPage4");
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            resources.ApplyResources(this.ribbonPageGroup7, "ribbonPageGroup7");
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup8});
            this.ribbonPage5.Name = "ribbonPage5";
            resources.ApplyResources(this.ribbonPage5, "ribbonPage5");
            // 
            // ribbonPageGroup8
            // 
            this.ribbonPageGroup8.Name = "ribbonPageGroup8";
            resources.ApplyResources(this.ribbonPageGroup8, "ribbonPageGroup8");
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup9});
            this.ribbonPage6.Name = "ribbonPage6";
            resources.ApplyResources(this.ribbonPage6, "ribbonPage6");
            // 
            // ribbonPageGroup9
            // 
            this.ribbonPageGroup9.Name = "ribbonPageGroup9";
            resources.ApplyResources(this.ribbonPageGroup9, "ribbonPageGroup9");
            // 
            // frmMain
            // 
            this.Appearance.Options.UseFont = true;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemDateEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mdiManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarHeaderItem barHeaderItem1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarEditItem barEditItem1;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit1;
        private DevExpress.XtraBars.BarEditItem barEditItem2;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit2;
        private DevExpress.XtraBars.BarStaticItem txtDate;
        private DevExpress.XtraBars.BarStaticItem txtTime;
        private DevExpress.XtraBars.BarStaticItem txtStatus;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager mdiManager;
        private DevExpress.XtraBars.BarButtonItem btnNewForm;
        private DevExpress.XtraBars.BarEditItem dtDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit repositoryItemDateEdit3;
        private System.Windows.Forms.Timer timerTimes;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
        private DevExpress.XtraBars.BarButtonItem btnSSoftware;
        private DevExpress.XtraBars.BarButtonItem btnUsersPermission;
        private DevExpress.XtraBars.BarButtonItem btnEmployee;
        private DevExpress.XtraBars.BarButtonItem barButtonItem9;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem btnBackup;
        private DevExpress.XtraBars.BarButtonItem btnConnectDB;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnEditInvoices;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup8;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup9;
    }
}