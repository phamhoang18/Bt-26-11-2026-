using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frmAtmStations : Form
    {
        private readonly AtmStationBUS _bus = new AtmStationBUS();
        private string _currentImagePath = null;
        public frmAtmStations()
        {
            InitializeComponent();
        }
        private void frmAtmStations_Load(object sender, EventArgs e)
        {
            cboStatus.SelectedIndex = 0;
            LoadStationList();
        }

        private void LoadStationList()
        {
            try
            {
                dgvStations.DataSource = _bus.GetAll();
            }
            catch
            {
                // Fallback dữ liệu mẫu trong bộ nhớ nếu máy chưa cài SQL Server
                dgvStations.DataSource = new List<AtmStationDTO>
                {
                    new AtmStationDTO { StationCode = "ATM-HN01", Address = "198 Trần Quang Khải, Hà Nội", CurrentBalance = 1250000000, Status = "Hoạt động" },
                    new AtmStationDTO { StationCode = "ATM-HN02", Address = "54 Liễu Giai, Hà Nội", CurrentBalance = 450000000, Status = "Hoạt động" },
                    new AtmStationDTO { StationCode = "ATM-HCM01", Address = "115 Nguyễn Huệ, TP.HCM", CurrentBalance = 50000000, Status = "Sắp hết tiền" }
                };
            }
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn ảnh chụp hiện trường trạm ATM";
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _currentImagePath = ofd.FileName;
                    picScene.ImageLocation = _currentImagePath;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var dto = new AtmStationDTO
            {
                StationCode = txtCode.Text.Trim(),
                Address = txtAddress.Text.Trim(),
                CurrentBalance = numBalance.Value,
                Status = cboStatus.SelectedItem?.ToString() ?? "Hoạt động",
                ImagePath = _currentImagePath
            };

            try
            {
                if (_bus.SaveStation(dto, out string err))
                {
                    MessageBox.Show("Lưu thông tin trạm ATM thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadStationList();
                }
                else
                {
                    MessageBox.Show(err, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối CSDL: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtCode.Clear();
            txtAddress.Clear();
            numBalance.Value = 0;
            cboStatus.SelectedIndex = 0;
            picScene.Image = null;
            _currentImagePath = null;
            LoadStationList();
        }

        private void dgvStations_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvStations.Rows[e.RowIndex].DataBoundItem is AtmStationDTO item)
            {
                txtCode.Text = item.StationCode;
                txtAddress.Text = item.Address;
                numBalance.Value = item.CurrentBalance;
                cboStatus.SelectedItem = item.Status;
                _currentImagePath = item.ImagePath;

                if (!string.IsNullOrEmpty(_currentImagePath) && File.Exists(_currentImagePath))
                    picScene.ImageLocation = _currentImagePath;
                else
                    picScene.Image = null;
            }
        }
    }
}
