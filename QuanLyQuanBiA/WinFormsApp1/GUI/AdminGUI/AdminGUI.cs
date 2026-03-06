using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.GUI.AdminGUI.DoanhThuGUI;
using WinFormsApp1.GUI.AdminGUI.FoodGUI;
using WinFormsApp1.GUI.AdminGUI.NhanVienGUI;
using WinFormsApp1.GUI.AdminGUI.TableGUI;

namespace WinFormsApp1.GUI.AdminGUI
{
    public partial class AdminGUI : Form
    {
        public AdminGUI()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnContent.Controls.Add(childForm);
            pnContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DoanhThuAdminForm());
        }

        private void btnTableBilliard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TableAdminForm());
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhanVienAdminForm());
        }

        private void btnFood_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FoodAdminForm());
        }
    }
}
