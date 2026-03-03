using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.BLL;
using WinFormsApp1.DTO;
using WinFormsApp1.GUI.MainPanel.TinhTrangBanGUI;

namespace WinFormsApp1.GUI
{
    public partial class TinhTrangTableForm : Form
    {
        private int currentTableId = -1;
        private double tongTienBan = 0;
        public TinhTrangTableForm()
        {
            InitializeComponent();
            ReLoadGiaoDien();
        }

        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<BilliardTable> list = BilliardTableBLL.LoadListTableBLL();
            List<TableCategory> list1 = TableCategoryBLL.GetTableCategory();
            foreach (BilliardTable b in list)
            {
                ucTable ucTable = new ucTable();
                ucTable.SetupData(b);

                ucTable.TopLevel = false;
                ucTable.Show();

                ucTable.OnTableOpened += ReLoadGiaoDien;
                ucTable.OnShowBill += ShowBillCuaBan;
                flpTable.Controls.Add(ucTable);
            }
        }

        private void ReLoadGiaoDien()
        {
            LoadTable();
            LoadCbTables();
        }

        private void ShowBillCuaBan(int idBan)
        {
            currentTableId = idBan;
            tongTienBan = 0;
            List<MenuDTO> listBill = BillBLL.GetListMenuTable(idBan);

            lsvBill.Items.Clear();
            double tongTien = 0;

            foreach (MenuDTO item in listBill)
            {
                ListViewItem lsvItem = new ListViewItem(item.FoodName);
                lsvItem.SubItems.Add(item.Count.ToString());
                lsvItem.SubItems.Add(item.Price.ToString("N0"));
                lsvItem.SubItems.Add(item.TotalPrice.ToString("N0"));

                lsvBill.Items.Add(lsvItem);
                tongTien += item.TotalPrice;

            }
            lblTongTienFood.Text = "Đồ Ăn: " + tongTien.ToString("N0") + " VNĐ";
            tongTienBan += tongTien;
            ShowDateIn_DateOut(idBan);
        }

        private void ShowDateIn_DateOut(int idBan)
        {
            List<Bill> listBill = BillBLL.GetDateIn_DateOut(idBan);
            lblDateCheckIn.Text = listBill[0].dateCheckIn.ToString();
            lblDateCheckOut.Text = listBill[0].dateCheckOut.ToString();
            lblNameTable.Text = listBill[0].Table.name.ToString();
            if (listBill[0].dateCheckOut != null)
            {

                DateTime checkIn = listBill[0].dateCheckIn;
                DateTime checkOut = listBill[0].dateCheckOut.Value;

                double totalHours = (checkOut - checkIn).TotalHours;

                float tong = (float)(totalHours * listBill[0].Table.Category.price);
                lblTongTienTable.Text = "Tiền Bàn: " + tong.ToString("N0") + " VNĐ";
                lblGioChoi.Text = "Giờ Chơi: " + totalHours.ToString("N5") + "h";
                Math.Round(tongTienBan += tong);
                lblTongTien.Text = "Tổng Tiền: " + tongTienBan.ToString("N0") + " VNĐ";
            }
            else
            {
                lblTongTienTable.Text = "Tiền Bàn: 0 VNĐ";
                lblGioChoi.Text = "Giờ Chơi: 0h";
                lblTongTien.Text = "Tổng Tiền: 0 VNĐ";
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (btnDong.Enabled)
            {
                DialogResult dialog = MessageBox.Show($"Bạn có muốn Đóng Bàn này không?",
                                                          "Đóng Bàn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    if (currentTableId != -1)
                    {
                        List<Bill> listBill = BillBLL.GetDateIn_DateOut(currentTableId);
                        if (listBill[0].dateCheckOut != null)
                        {
                            MessageBox.Show("Bạn đã đóng bàn này rồi!");
                        }
                        else
                        {
                            if (BillBLL.DongBan(currentTableId))
                            {
                                ShowDateIn_DateOut(currentTableId);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn Chưa Chọn Bàn!");
                    }
                }
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if (currentTableId != -1)
            {
                DialogResult dialog = MessageBox.Show($"Bạn có muốn Thanh Toán Bàn này không?",
                                                         "Thanh Toán Bàn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    List<Bill> listBill = BillBLL.GetDateIn_DateOut(currentTableId);
                    if (listBill[0].dateCheckOut != null)
                    {
                        bool success = BillBLL.ThanhToanBill(currentTableId, tongTienBan);
                        MessageBox.Show("Thanh Toán Thành Công!");
                        LoadTable();
                        lblGioChoi.ResetText();
                        lblTongTienTable.ResetText();
                        lblTongTienFood.ResetText();
                        lblTongTien.ResetText();
                        lblDateCheckIn.ResetText();
                        lblDateCheckOut.ResetText();
                        lsvBill.Items.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Vui Lòng Đóng Bàn trước khi thanh toán!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn bàn để thanh toán!");
            }
        }

        void LoadCbTables()
        {
            List<BilliardTable> listTable = BilliardTableBLL.LoadListTableChuyenBanDAL();
            cbChuyenBan.DataSource = null;
            cbChuyenBan.Items.Clear();
            cbChuyenBan.DataSource = listTable;
            cbChuyenBan.DisplayMember = "name";
            cbChuyenBan.ValueMember = "id";

        }

        private void btnChuyenBan_Click(object sender, EventArgs e)
        {
            if (currentTableId == -1)
            {
                MessageBox.Show("Vui lòng chọn một bàn đang sử dụng để chuyển!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cbChuyenBan.SelectedValue == null) return;
            int idBanMoi = Convert.ToInt32(cbChuyenBan.SelectedValue);

            DialogResult = MessageBox.Show($"Bạn có muốn Chuyển Bàn này không?",
                                                         "Chuyển Bàn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (DialogResult == DialogResult.Yes)
            {
                List<Bill> listBill = BillBLL.GetDateIn_DateOut(currentTableId);
                if (listBill[0].dateCheckOut != null)
                {
                    bool success = BillBLL.ChuyenBan(currentTableId, idBanMoi);
                    if (success)
                    {
                        MessageBox.Show("Chuyển bàn thành công!");
                        ReLoadGiaoDien();
                    }
                }
            }
        }
    }
}
