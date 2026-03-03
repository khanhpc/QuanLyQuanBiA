using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using WinFormsApp1.DTO;

namespace WinFormsApp1.GUI
{
    public partial class ucFoodItem : Form
    {
        private Food _food;
        public ucFoodItem()
        {
            InitializeComponent();
        }
        public void SetupData(Food food)
        {
            _food = food;
            lblName.Text = food.name;
            lblPrice.Text = food.price.ToString("N0") + " VNĐ";

            string imagePath = food.url.ToString().TrimStart('\\', '/');

            string fullPath = System.IO.Path.Combine(Application.StartupPath, imagePath);

            if (File.Exists(fullPath))
            {
                ptbImage.Image = Image.FromFile(fullPath);
            }
            else
            {
                ptbImage.BackColor = Color.LightGray;
                MessageBox.Show("Phần mềm đang cố tìm ảnh tại đường dẫn này nhưng không thấy:\n\n" + fullPath);
            }
        }
        public event Action<Food, int> OnOrder;

        private void btnOrder_Click(object sender, EventArgs e)
        {
            int soLuong = (int)nudSoLuong.Value;
            if (OnOrder != null)
            {
                OnOrder(_food, soLuong);
            }
            nudSoLuong.Value = 1;
        }

    }
}
