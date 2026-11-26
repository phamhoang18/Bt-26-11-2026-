using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmAtmReconciliation : Form
    {
        private readonly ReconciliationBUS _bus = new ReconciliationBUS();
        private CancellationTokenSource _cts;

        public frmAtmReconciliation()
        {
            InitializeComponent();
        }

        private async void btnStartReconcile_Click(object sender, EventArgs e)
        {
            btnStartReconcile.Enabled = false;
            btnStopReconcile.Enabled = true;
            prgLocal.Value = 0;
            lstLogs.Items.Clear();
            lstLogs.Items.Add($"[{DateTime.Now:HH:mm:ss}] Bắt đầu phiên đối soát tự động...");

            _cts = new CancellationTokenSource();
            var mainForm = this.MdiParent as frmBankAtmMain;

            var progress = new Progress<(int percent, string message)>(report =>
            {
                prgLocal.Value = report.percent;
                lblStatus.Text = $"Trạng thái: {report.message} ({report.percent}%)";

                if (report.percent % 20 == 0)
                    lstLogs.Items.Add($"[{DateTime.Now:HH:mm:ss}] {report.message} - {report.percent}%");

                mainForm?.UpdateGlobalProgress(report.percent, report.message, true);
            });

            try
            {
                ReconciliationResultDTO result = await _bus.RunAutoReconciliationAsync(progress, _cts.Token);

                lblStatus.Text = $"Hoàn tất đối soát! ({result.Status})";
                lstLogs.Items.Add("--------------------------------------------------");
                lstLogs.Items.Add($"[{DateTime.Now:HH:mm:ss}] KẾT QUẢ ĐỐI SOÁT CUỐI NGÀY:");
                lstLogs.Items.Add($" - Tổng số giao dịch : {result.TotalTransactions:N0}");
                lstLogs.Items.Add($" - Giao dịch khớp    : {result.MatchedCount:N0}");
                lstLogs.Items.Add($" - Giao dịch sai lệch: {result.DiscrepancyCount:N0}");
                lstLogs.Items.Add($" - Kết luận          : {result.Status}");

                mainForm?.UpdateGlobalProgress(100, "Đối soát hoàn tất", false);
            }
            catch (OperationCanceledException)
            {
                lblStatus.Text = "Trạng thái: Đã hủy tiến trình đối soát theo yêu cầu!";
                lstLogs.Items.Add($"[{DateTime.Now:HH:mm:ss}] CẢNH BÁO: Tiến trình đã bị dừng bởi người dùng.");
                mainForm?.UpdateGlobalProgress(0, "Đã hủy đối soát", false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đối soát: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                mainForm?.UpdateGlobalProgress(0, "Lỗi đối soát", false);
            }
            finally
            {
                btnStartReconcile.Enabled = true;
                btnStopReconcile.Enabled = false;
                _cts?.Dispose();
                _cts = null;
            }
        }

        private void btnStopReconcile_Click(object sender, EventArgs e)
        {
            if (_cts != null && !_cts.IsCancellationRequested)
            {
                btnStopReconcile.Enabled = false;
                lblStatus.Text = "Đang gửi tín hiệu dừng an toàn...";
                _cts.Cancel();
            }
        }

        private void frmAtmReconciliation_FormClosing(object sender, FormClosingEventArgs e)
        {
            _cts?.Cancel();
        }
    }
}
