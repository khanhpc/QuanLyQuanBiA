using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.GUI.MainPanelGUI.LichSuThanhToanGUI;
using WinFormsApp1.GUI.Ultils;

namespace WinFormsApp1.GUI
{
    public partial class MainPanel1 : Form
    {
        public MainPanel1()
        {
            InitializeComponent();
            LoadForm();
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

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                currentFormChild = null;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show($"Bạn có muốn Đăng xuất tài khoản không?",
                                                           "Đăng Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                SessionManager.Logout();
                Close();
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new MenuForm());
        }

        private void btnTinhTrangBan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TinhTrangTableForm());
        }

        void LoadForm()
        {
            lblDisplayName.Text = SessionManager.CurrentUser.displayName;
        }

        private void btnLichSuThanhToan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new LichSuThanhToanForm());
        }
    }
}
