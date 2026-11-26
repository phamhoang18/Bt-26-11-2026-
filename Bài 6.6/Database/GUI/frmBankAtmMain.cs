using System;
using System.Windows.Forms;
namespace GUI
{
    public partial class frmBankAtmMain : Form
    {
        public frmBankAtmMain()
        {
            InitializeComponent();
        }
        private void OpenChildForm<T>() where T : Form, new()
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child is T)
                {
                    if (child.WindowState == FormWindowState.Minimized)
                        child.WindowState = FormWindowState.Normal;
                    child.Activate();
                    return;
                }
            }

            T newForm = new T();
            newForm.MdiParent = this;
            newForm.Show();
        }
        public void UpdateGlobalProgress(int percent, string statusMessage, bool isRunning)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => UpdateGlobalProgress(percent, statusMessage, isRunning)));
                return;
            }

            prgMainTask.Visible = isRunning;
            prgMainTask.Value = Math.Min(Math.Max(percent, 0), 100);
            lblProgressText.Text = isRunning ? $"{statusMessage} ({percent}%)" : statusMessage;
        }

        private void mnuAtmStations_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmAtmStations>();
        }

        private void mnuAtmReconciliation_Click(object sender, EventArgs e)
        {
            OpenChildForm<frmAtmReconciliation>();
        }

        private void mnuCloseAll_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }
        }

        private void mnuLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn đăng xuất phiên làm việc?", "Xác nhận",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                mnuCloseAll_Click(sender, e);
                lblTellerName.Text = "GDV: Chưa đăng nhập  ";
                lblCoreStatus.Text = "  Core Banking: Ngắt kết nối  ";
                lblCoreStatus.ForeColor = System.Drawing.Color.Red;
            }
        }

        private void mnuLock_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Màn hình đã khóa! Nhấn OK để mở khóa phiên làm việc.", "Khóa màn hình",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
