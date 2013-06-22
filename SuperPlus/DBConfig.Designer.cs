namespace SuperPlus
{
    partial class DBConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DBConfig));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBtnItmOK = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnItemCancel = new DevExpress.XtraBars.BarButtonItem();
            this.homeribbonPage = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.homeribbonPageGroup = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.RDBMSgrpCtrl = new DevExpress.XtraEditors.GroupControl();
            this.RDBMSradioGroup = new DevExpress.XtraEditors.RadioGroup();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage4 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage5 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RDBMSgrpCtrl)).BeginInit();
            this.RDBMSgrpCtrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RDBMSradioGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ApplicationIcon = ((System.Drawing.Bitmap)(resources.GetObject("ribbon.ApplicationIcon")));
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barBtnItmOK,
            this.barBtnItemCancel});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 4;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.homeribbonPage});
            this.ribbon.Size = new System.Drawing.Size(916, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barBtnItmOK
            // 
            this.barBtnItmOK.Caption = "OK";
            this.barBtnItmOK.Id = 2;
            this.barBtnItmOK.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnItmOK.LargeGlyph")));
            this.barBtnItmOK.Name = "barBtnItmOK";
            this.barBtnItmOK.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // barBtnItemCancel
            // 
            this.barBtnItemCancel.Caption = "Cancel";
            this.barBtnItemCancel.Id = 3;
            this.barBtnItemCancel.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnItemCancel.LargeGlyph")));
            this.barBtnItemCancel.Name = "barBtnItemCancel";
            // 
            // homeribbonPage
            // 
            this.homeribbonPage.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.homeribbonPageGroup});
            this.homeribbonPage.Name = "homeribbonPage";
            this.homeribbonPage.Text = "Home";
            // 
            // homeribbonPageGroup
            // 
            this.homeribbonPageGroup.ItemLinks.Add(this.barBtnItmOK);
            this.homeribbonPageGroup.ItemLinks.Add(this.barBtnItemCancel);
            this.homeribbonPageGroup.Name = "homeribbonPageGroup";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 443);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(916, 31);
            // 
            // RDBMSgrpCtrl
            // 
            this.RDBMSgrpCtrl.Controls.Add(this.RDBMSradioGroup);
            this.RDBMSgrpCtrl.Location = new System.Drawing.Point(25, 169);
            this.RDBMSgrpCtrl.Name = "RDBMSgrpCtrl";
            this.RDBMSgrpCtrl.Size = new System.Drawing.Size(170, 224);
            this.RDBMSgrpCtrl.TabIndex = 8;
            this.RDBMSgrpCtrl.Text = "RDBMS Options";
            // 
            // RDBMSradioGroup
            // 
            this.RDBMSradioGroup.Location = new System.Drawing.Point(5, 24);
            this.RDBMSradioGroup.MenuManager = this.ribbon;
            this.RDBMSradioGroup.Name = "RDBMSradioGroup";
            this.RDBMSradioGroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.RDBMSradioGroup.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(1)), "MySQL Local"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(2)), "MySQL Server"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(3)), "MySQL ODBC DSN"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(4)), "SQL Server Local"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(5)), "SQL Server"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(6)), "SQL Server ODBC DSN"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(7)), "PostgreSQL Local"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(8)), "PostgreSQL Server"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(9)), "PostgreSQL ODBC DSN"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(10)), "SQLite"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(((short)(11)), "MS Access OLEDB")});
            this.RDBMSradioGroup.Size = new System.Drawing.Size(158, 195);
            this.RDBMSradioGroup.TabIndex = 3;
            this.RDBMSradioGroup.ToolTip = "Select RDBMS option";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.xtraTabControl1);
            this.groupControl1.Location = new System.Drawing.Point(232, 169);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(662, 268);
            this.groupControl1.TabIndex = 11;
            this.groupControl1.Text = "groupControl1";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(15, 34);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage4;
            this.xtraTabControl1.Size = new System.Drawing.Size(628, 220);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage4,
            this.xtraTabPage5});
            // 
            // xtraTabPage4
            // 
            this.xtraTabPage4.Name = "xtraTabPage4";
            this.xtraTabPage4.Size = new System.Drawing.Size(622, 192);
            this.xtraTabPage4.Text = "xtraTabPage4";
            // 
            // xtraTabPage5
            // 
            this.xtraTabPage5.Name = "xtraTabPage5";
            this.xtraTabPage5.Size = new System.Drawing.Size(622, 192);
            this.xtraTabPage5.Text = "xtraTabPage5";
            // 
            // DBConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 474);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.RDBMSgrpCtrl);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "DBConfig";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Database Configuration Setup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DBConfig_FormClosing);
            this.Load += new System.EventHandler(this.DBConfig_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RDBMSgrpCtrl)).EndInit();
            this.RDBMSgrpCtrl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RDBMSradioGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage homeribbonPage;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup homeribbonPageGroup;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barBtnItmOK;
        private DevExpress.XtraBars.BarButtonItem barBtnItemCancel;
        private DevExpress.XtraEditors.GroupControl RDBMSgrpCtrl;
        private DevExpress.XtraEditors.RadioGroup RDBMSradioGroup;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage4;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage5;
    }
}