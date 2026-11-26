namespace GUI
{
    partial class frmBankAtmMain
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem mnuSystem;
        private System.Windows.Forms.ToolStripMenuItem mnuLogout;
        private System.Windows.Forms.ToolStripMenuItem mnuLock;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuAtmManagement;
        private System.Windows.Forms.ToolStripMenuItem mnuAtmStations;
        private System.Windows.Forms.ToolStripMenuItem mnuAtmReconciliation;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
        private System.Windows.Forms.ToolStripMenuItem mnuCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuTileHorizontal;
        private System.Windows.Forms.ToolStripMenuItem mnuTileVertical;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuCloseAll;
        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel lblTellerName;
        private System.Windows.Forms.ToolStripStatusLabel lblCoreStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblProgressText;
        private System.Windows.Forms.ToolStripProgressBar prgMainTask;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.mnuSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLock = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAtmManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAtmStations = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAtmReconciliation = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileHorizontal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTileVertical = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCloseAll = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStripMain = new System.Windows.Forms.StatusStrip();
            this.lblTellerName = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCoreStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblProgressText = new System.Windows.Forms.ToolStripStatusLabel();
            this.prgMainTask = new System.Windows.Forms.ToolStripProgressBar();

            this.menuStripMain.SuspendLayout();
            this.statusStripMain.SuspendLayout();
            this.SuspendLayout();

            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuSystem, this.mnuAtmManagement, this.mnuWindow
            });
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1184, 28);

            this.mnuSystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuLogout, this.mnuLock, this.toolStripSeparator1, this.mnuExit
            });
            this.mnuSystem.Text = "&Hệ thống";
            this.mnuLogout.Text = "Đăng xuất";
            this.mnuLogout.Click += new System.EventHandler(this.mnuLogout_Click);
            this.mnuLock.Text = "Khóa màn hình";
            this.mnuLock.Click += new System.EventHandler(this.mnuLock_Click);
            this.mnuExit.Text = "Thoát";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);

            this.mnuAtmManagement.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuAtmStations, this.mnuAtmReconciliation
            });
            this.mnuAtmManagement.Text = "&Quản lý ATM";
            this.mnuAtmStations.Text = "Danh sách Trạm ATM && Tồn quỹ";
            this.mnuAtmStations.Click += new System.EventHandler(this.mnuAtmStations_Click);
            this.mnuAtmReconciliation.Text = "Đối soát Giao dịch Cuối ngày";
            this.mnuAtmReconciliation.Click += new System.EventHandler(this.mnuAtmReconciliation_Click);

            this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.mnuCascade, this.mnuTileHorizontal, this.mnuTileVertical, this.toolStripSeparator2, this.mnuCloseAll
            });
            this.mnuWindow.Text = "&Cửa sổ";
            this.mnuCascade.Text = "Xếp tầng (Cascade)";
            this.mnuCascade.Click += (s, e) => this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
            this.mnuTileHorizontal.Text = "Xếp ngang (Tile Horizontal)";
            this.mnuTileHorizontal.Click += (s, e) => this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
            this.mnuTileVertical.Text = "Xếp dọc (Tile Vertical)";
            this.mnuTileVertical.Click += (s, e) => this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
            this.mnuCloseAll.Text = "Đóng tất cả";
            this.mnuCloseAll.Click += new System.EventHandler(this.mnuCloseAll_Click);

            this.statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.lblTellerName, this.lblCoreStatus, this.lblProgressText, this.prgMainTask
            });
            this.statusStripMain.Location = new System.Drawing.Point(0, 635);
            this.statusStripMain.Name = "statusStripMain";
            this.statusStripMain.Size = new System.Drawing.Size(1184, 26);

            this.lblTellerName.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblTellerName.Text = "GDV: Nguyễn Văn A (ID: TV089)  ";

            this.lblCoreStatus.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.lblCoreStatus.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblCoreStatus.Text = "  Core Banking: Đã kết nối (Online)  ";

            this.lblProgressText.Spring = true;
            this.lblProgressText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblProgressText.Text = "Sẵn sàng";

            this.prgMainTask.Size = new System.Drawing.Size(200, 20);
            this.prgMainTask.Visible = false;

            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.statusStripMain);
            this.Controls.Add(this.menuStripMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "frmBankAtmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HỆ THỐNG ĐIỀU HÀNH MẠNG LƯỚI CÂY ATM NGÂN HÀNG (MDI)";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusStripMain.ResumeLayout(false);
            this.statusStripMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
