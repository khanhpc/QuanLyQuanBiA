using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.BLL;
using WinFormsApp1.DTO;

namespace WinFormsApp1.GUI
{
    public partial class MenuForm : Form
    {
        private int currentIdBan = -1;
        public MenuForm()
        {
            InitializeComponent();
            load_FormMenu();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tìm Kiếm Đồ Ăn");
        }

        void load_FormMenu()
        {
            LoadMenu();
            LoadCbTables();
        }

        void LoadMenu()
        {
            flpMenu.Controls.Clear();

            List<Food> listFood = FoodBLL.GetListFood();

            foreach (Food item in listFood)
            {
                ucFoodItem ucItem = new ucFoodItem();
                ucItem.SetupData(item);

                ucItem.TopLevel = false;
                ucItem.Show();
                ucItem.OnOrder += UcItem_OnOrder;
                flpMenu.Controls.Add(ucItem);

            }
            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void UcItem_OnOrder(Food food, int soLuong)
        {
            if (cbTables.SelectedValue == null) return;
            int idBan = Convert.ToInt32(cbTables.SelectedValue);

            int idBill = BillBLL.GetUncheckBillIDByTableID(idBan);
            if (idBill == -1)
            {
                MessageBox.Show("Bàn này chưa được mở! Vui lòng mở bàn trước khi gọi đồ uống.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                DialogResult dialog = MessageBox.Show($"Bạn có muốn đặt đồ không?",
                                                          "Đặt Đồ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.Yes)
                {
                    bool isSuccess = FoodBLL.ThemMonVaoBill(idBill, food.id, soLuong);

                    if (isSuccess)
                    {
                        MessageBox.Show($"Bàn số {idBan} vừa gọi {soLuong} x {food.name}");
                        ShowBillCuaBan(currentIdBan);
                    }
                }
            }
        }

        void LoadCbTables()
        {
            List<BilliardTable> listTable = BilliardTableBLL.LoadListTableBLL();
            cbTables.Items.Clear();
            cbTables.DataSource = listTable;
            cbTables.DisplayMember = "name";
            cbTables.ValueMember = "id";

        }

        private void ShowBillCuaBan(int idBan)
        {
            if (cbTables.SelectedValue == null) return;

            List<MenuDTO> listBill = BillBLL.GetListMenuTable(idBan);

            dgvBill.Rows.Clear();

            double tongTien = 0;

            foreach (MenuDTO item in listBill)
            {
                dgvBill.Rows.Add(
                    item.FoodName,
                    item.Count,
                    item.Price.ToString("N0"),
                    item.TotalPrice.ToString("N0")
                );

                tongTien += item.TotalPrice;
            }
            lblTotalPrice.Text = tongTien.ToString("N0")+ " VNĐ";

        }

        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            BilliardTable table = (BilliardTable)cbTables.SelectedItem;
            currentIdBan = table.id;
            ShowBillCuaBan(currentIdBan);
        }
    }
}
