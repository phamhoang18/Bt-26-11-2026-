namespace GUI
{
    partial class frmAtmReconciliation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnStartReconcile;
        private System.Windows.Forms.Button btnStopReconcile;
        private System.Windows.Forms.ProgressBar prgLocal;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.ListBox lstLogs;

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
            this.btnStartReconcile = new System.Windows.Forms.Button();
            this.btnStopReconcile = new System.Windows.Forms.Button();
            this.prgLocal = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lstLogs = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            this.btnStartReconcile.BackColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnStartReconcile.ForeColor = System.Drawing.Color.White;
            this.btnStartReconcile.Location = new System.Drawing.Point(20, 20);
            this.btnStartReconcile.Size = new System.Drawing.Size(200, 38);
            this.btnStartReconcile.Text = "Chạy Đối Soát Tự Động";
            this.btnStartReconcile.UseVisualStyleBackColor = false;
            this.btnStartReconcile.Click += new System.EventHandler(this.btnStartReconcile_Click);

            this.btnStopReconcile.BackColor = System.Drawing.Color.Crimson;
            this.btnStopReconcile.Enabled = false;
            this.btnStopReconcile.ForeColor = System.Drawing.Color.White;
            this.btnStopReconcile.Location = new System.Drawing.Point(235, 20);
            this.btnStopReconcile.Size = new System.Drawing.Size(160, 38);
            this.btnStopReconcile.Text = "Dừng Đối Soát";
            this.btnStopReconcile.UseVisualStyleBackColor = false;
            this.btnStopReconcile.Click += new System.EventHandler(this.btnStopReconcile_Click);

            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(20, 75);
            this.lblStatus.Text = "Trạng thái: Sẵn sàng đối soát dữ liệu cuối ngày";

            this.prgLocal.Location = new System.Drawing.Point(20, 102);
            this.prgLocal.Size = new System.Drawing.Size(640, 25);

            this.lstLogs.Font = new System.Drawing.Font("Consolas", 9.5F);
            this.lstLogs.Location = new System.Drawing.Point(20, 142);
            this.lstLogs.Size = new System.Drawing.Size(640, 250);

            this.ClientSize = new System.Drawing.Size(680, 415);
            this.Controls.Add(this.lstLogs);
            this.Controls.Add(this.prgLocal);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnStopReconcile);
            this.Controls.Add(this.btnStartReconcile);
            this.Name = "frmAtmReconciliation";
            this.Text = "Đối soát Sao kê Giao dịch ATM Cuối ngày (Async)";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAtmReconciliation_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        #endregion
    }
}