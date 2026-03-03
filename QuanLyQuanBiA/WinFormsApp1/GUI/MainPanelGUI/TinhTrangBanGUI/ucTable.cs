using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using WinFormsApp1.BLL;
using WinFormsApp1.DTO;
using WinFormsApp1.GUI.Ultils;

namespace WinFormsApp1.GUI.MainPanel.TinhTrangBanGUI
{
    public partial class ucTable : Form
    {
        public ucTable()
        {
            InitializeComponent();
        }

        private BilliardTable _BilliardTable;
        public event Action OnTableOpened;
        public event Action<int> OnShowBill;

        public void SetupData(BilliardTable BilliardTable)
        {
            _BilliardTable = BilliardTable;
            if (BilliardTable.status.Equals("Trống"))
            {
                pctTable.BackColor = Color.Green;
                btnOrderTable.Text = "Mở Bàn";
            }
            else
            {
                pctTable.BackColor = Color.Red;
                btnOrderTable.Text = "Xem Bàn";
            }
            lblName.Text = BilliardTable.name;
            lblPrice.Text = BilliardTable.Category.price.ToString("N0") + " VNĐ";
        }

        private void btnOrderTable_Click(object sender, EventArgs e)
        {
            if (_BilliardTable.status == "Trống")
            {
                DialogResult dialog = MessageBox.Show($"Bạn có muốn mở/bấm giờ cho {_BilliardTable.name} không?",
                                                      "Mở bàn", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialog == DialogResult.Yes)
                {
                    bool isSuccess = BillBLL.MoBanVaBamGio(_BilliardTable.id, SessionManager.CurrentUser.id);

                    if (isSuccess)
                    {
                        if (OnTableOpened != null)
                        {
                            OnTableOpened();
                        }
                    }
                }
            }
            else
            {
                if (OnShowBill != null)
                {
                    OnShowBill(_BilliardTable.id);
                }
            }
        }
    }
}
