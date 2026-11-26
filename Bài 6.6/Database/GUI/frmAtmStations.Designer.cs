namespace GUI
{
    partial class frmAtmStations
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvStations;
        private System.Windows.Forms.GroupBox grpDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.NumericUpDown numBalance;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.PictureBox picScene;
        private System.Windows.Forms.Button btnChooseImage;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnRefresh;

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
            this.dgvStations = new System.Windows.Forms.DataGridView();
            this.grpDetail = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.numBalance = new System.Windows.Forms.NumericUpDown();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.picScene = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dgvStations)).BeginInit();
            this.grpDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScene)).BeginInit();
            this.SuspendLayout();

            this.dgvStations.AllowUserToAddRows = false;
            this.dgvStations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStations.Location = new System.Drawing.Point(15, 15);
            this.dgvStations.ReadOnly = true;
            this.dgvStations.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStations.Size = new System.Drawing.Size(560, 420);
            this.dgvStations.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStations_CellClick);

            this.grpDetail.Controls.Add(this.btnRefresh);
            this.grpDetail.Controls.Add(this.btnSave);
            this.grpDetail.Controls.Add(this.btnChooseImage);
            this.grpDetail.Controls.Add(this.picScene);
            this.grpDetail.Controls.Add(this.cboStatus);
            this.grpDetail.Controls.Add(this.numBalance);
            this.grpDetail.Controls.Add(this.txtAddress);
            this.grpDetail.Controls.Add(this.txtCode);
            this.grpDetail.Controls.Add(this.label4);
            this.grpDetail.Controls.Add(this.label3);
            this.grpDetail.Controls.Add(this.label2);
            this.grpDetail.Controls.Add(this.label1);
            this.grpDetail.Location = new System.Drawing.Point(590, 15);
            this.grpDetail.Size = new System.Drawing.Size(340, 420);
            this.grpDetail.Text = "Thông tin chi tiết Trạm ATM";

            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Text = "Mã trạm:";
            this.txtCode.Location = new System.Drawing.Point(115, 27);
            this.txtCode.Size = new System.Drawing.Size(205, 23);

            this.label2.Location = new System.Drawing.Point(15, 65);
            this.label2.Text = "Địa chỉ đặt:";
            this.txtAddress.Location = new System.Drawing.Point(115, 62);
            this.txtAddress.Size = new System.Drawing.Size(205, 23);

            this.label3.Location = new System.Drawing.Point(15, 100);
            this.label3.Text = "Tồn quỹ (VNĐ):";
            this.numBalance.Location = new System.Drawing.Point(115, 97);
            this.numBalance.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 }); // ~10 tỷ
            this.numBalance.ThousandsSeparator = true;
            this.numBalance.Size = new System.Drawing.Size(205, 23);

            this.label4.Location = new System.Drawing.Point(15, 135);
            this.label4.Text = "Trạng thái:";
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.Items.AddRange(new object[] { "Hoạt động", "Sắp hết tiền", "Bảo trì", "Ngừng hoạt động" });
            this.cboStatus.Location = new System.Drawing.Point(115, 132);
            this.cboStatus.Size = new System.Drawing.Size(205, 23);

            this.picScene.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picScene.Location = new System.Drawing.Point(15, 170);
            this.picScene.Size = new System.Drawing.Size(305, 155);
            this.picScene.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;

            this.btnChooseImage.Location = new System.Drawing.Point(15, 335);
            this.btnChooseImage.Size = new System.Drawing.Size(305, 30);
            this.btnChooseImage.Text = "Đính kèm ảnh hiện trường (OpenFileDialog)...";
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);

            this.btnSave.Location = new System.Drawing.Point(15, 375);
            this.btnSave.Size = new System.Drawing.Size(145, 32);
            this.btnSave.Text = "Lưu thông tin";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            this.btnRefresh.Location = new System.Drawing.Point(175, 375);
            this.btnRefresh.Size = new System.Drawing.Size(145, 32);
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);

            this.ClientSize = new System.Drawing.Size(945, 450);
            this.Controls.Add(this.grpDetail);
            this.Controls.Add(this.dgvStations);
            this.Name = "frmAtmStations";
            this.Text = "Quản lý Danh sách Trạm ATM & Tồn quỹ";
            this.Load += new System.EventHandler(this.frmAtmStations_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dgvStations)).EndInit();
            this.grpDetail.ResumeLayout(false);
            this.grpDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBalance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picScene)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion
    }
}