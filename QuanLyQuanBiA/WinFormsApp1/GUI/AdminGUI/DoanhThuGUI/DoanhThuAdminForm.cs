using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using WinFormsApp1.BLL;

namespace WinFormsApp1.GUI.AdminGUI.DoanhThuGUI
{
    public partial class DoanhThuAdminForm : Form
    {
        public DoanhThuAdminForm()
        {
            InitializeComponent();
        }

        private void DoanhThuAdminForm_Load(object sender, EventArgs e)
        {
            DateTime today = DateTime.Now;
            dtptuNgay.Value = new DateTime(today.Year, today.Month, 1);
            dtpdenNgay.Value = today;
            LoadDanhSachDoanhThu(dtptuNgay.Value.Date, dtpdenNgay.Value.Date);

        }
       


        private void lbBieuDo_Click(object sender, EventArgs e)
        {

        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            if (dtptuNgay.Value > dtpdenNgay.Value)
            {
                MessageBox.Show("Lỗi: 'Từ ngày' phải nhỏ hơn hoặc bằng 'Đến ngày'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            MessageBox.Show("Lấy dữ liệu thành công!!");

            LoadDanhSachDoanhThu(dtptuNgay.Value.Date, dtpdenNgay.Value.Date);
        }

        private void LoadDanhSachDoanhThu(DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                DataTable dt = BillBLL.GetDoanhThuBLL(tuNgay, denNgay);
                dgvDoanhThu.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hiển thị dữu liệu: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBieuDo(DateTime tuNgay, DateTime denNgay)
        {
            try
            {
                DataTable dtNgay = BillBLL.GetDoanhThuTheoNgayBLL(tuNgay, denNgay);
                chartNgay.DataSource = dtNgay;

               
                chartNgay.Series[0].XValueMember = "Ngay";
                chartNgay.Series[0].YValueMembers = "TongTien";

               
                chartNgay.Series[0].Name = "Doanh thu (VNĐ)";
                chartNgay.DataBind(); 

               
                DataTable dtThang = BillBLL.GetDoanhThuTheoThangBLL(tuNgay, denNgay);
                chartThang.DataSource = dtThang;

                chartThang.Series[0].XValueMember = "Thang";
                chartThang.Series[0].YValueMembers = "TongTien";

                chartThang.Series[0].Name = "Doanh thu (VNĐ)";
                chartThang.DataBind();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi vẽ biểu đồ: " + ex.Message);
            }
        }
    }
}
