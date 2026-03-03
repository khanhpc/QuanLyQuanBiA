namespace WinFormsApp1.GUI.AdminGUI
{
    partial class BaoCaoDoanhThuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDTPK1 = new DateTimePicker();
            btnDTPK2 = new DateTimePicker();
            lbDenNgay = new Label();
            lbTuNgay = new Label();
            btnBaoCao = new Button();
            pnlDoanhThu = new Panel();
            pnlBieuDo = new Panel();
            pnlSPBanChay = new Panel();
            lbBieuDo = new Label();
            lbSPBanChay = new Label();
            pnlBieuDo.SuspendLayout();
            pnlSPBanChay.SuspendLayout();
            SuspendLayout();
            // 
            // btnDTPK1
            // 
            btnDTPK1.Location = new Point(12, 46);
            btnDTPK1.Name = "btnDTPK1";
            btnDTPK1.Size = new Size(200, 23);
            btnDTPK1.TabIndex = 0;
            // 
            // btnDTPK2
            // 
            btnDTPK2.Location = new Point(12, 110);
            btnDTPK2.Name = "btnDTPK2";
            btnDTPK2.Size = new Size(200, 23);
            btnDTPK2.TabIndex = 1;
            // 
            // lbDenNgay
            // 
            lbDenNgay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbDenNgay.AutoSize = true;
            lbDenNgay.BackColor = SystemColors.ActiveCaption;
            lbDenNgay.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDenNgay.Location = new Point(80, 82);
            lbDenNgay.Name = "lbDenNgay";
            lbDenNgay.Size = new Size(78, 19);
            lbDenNgay.TabIndex = 2;
            lbDenNgay.Text = "Đến ngày:";
            lbDenNgay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbTuNgay
            // 
            lbTuNgay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbTuNgay.BackColor = SystemColors.ActiveCaption;
            lbTuNgay.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTuNgay.Location = new Point(85, 18);
            lbTuNgay.Name = "lbTuNgay";
            lbTuNgay.Size = new Size(75, 25);
            lbTuNgay.TabIndex = 3;
            lbTuNgay.Text = "Từ ngày: ";
            lbTuNgay.TextAlign = ContentAlignment.MiddleCenter;
            lbTuNgay.Click += lbTuNgay_Click;
            // 
            // btnBaoCao
            // 
            btnBaoCao.BackColor = Color.FromArgb(0, 192, 192);
            btnBaoCao.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBaoCao.Location = new Point(64, 139);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Size = new Size(111, 30);
            btnBaoCao.TabIndex = 4;
            btnBaoCao.Text = "Báo Cáo";
            btnBaoCao.UseVisualStyleBackColor = false;
            // 
            // pnlDoanhThu
            // 
            pnlDoanhThu.BackColor = SystemColors.AppWorkspace;
            pnlDoanhThu.Location = new Point(3, 175);
            pnlDoanhThu.Name = "pnlDoanhThu";
            pnlDoanhThu.Size = new Size(792, 270);
            pnlDoanhThu.TabIndex = 5;
            // 
            // pnlBieuDo
            // 
            pnlBieuDo.BackColor = Color.FromArgb(0, 0, 64);
            pnlBieuDo.Controls.Add(lbBieuDo);
            pnlBieuDo.Location = new Point(263, 1);
            pnlBieuDo.Name = "pnlBieuDo";
            pnlBieuDo.Size = new Size(328, 168);
            pnlBieuDo.TabIndex = 6;
            // 
            // pnlSPBanChay
            // 
            pnlSPBanChay.BackColor = Color.LightCyan;
            pnlSPBanChay.BorderStyle = BorderStyle.FixedSingle;
            pnlSPBanChay.Controls.Add(lbSPBanChay);
            pnlSPBanChay.Location = new Point(617, 1);
            pnlSPBanChay.Name = "pnlSPBanChay";
            pnlSPBanChay.Size = new Size(178, 168);
            pnlSPBanChay.TabIndex = 7;
            // 
            // lbBieuDo
            // 
            lbBieuDo.AutoSize = true;
            lbBieuDo.BackColor = Color.White;
            lbBieuDo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbBieuDo.Location = new Point(33, 8);
            lbBieuDo.Name = "lbBieuDo";
            lbBieuDo.Size = new Size(195, 17);
            lbBieuDo.TabIndex = 0;
            lbBieuDo.Text = "Biểu đồ doanh thu theo tháng";
            lbBieuDo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbSPBanChay
            // 
            lbSPBanChay.AutoSize = true;
            lbSPBanChay.BackColor = Color.White;
            lbSPBanChay.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSPBanChay.Location = new Point(27, 9);
            lbSPBanChay.Name = "lbSPBanChay";
            lbSPBanChay.Size = new Size(132, 17);
            lbSPBanChay.TabIndex = 0;
            lbSPBanChay.Text = "Sản phẩm bán chạy:";
            lbSPBanChay.TextAlign = ContentAlignment.MiddleCenter;
            lbSPBanChay.Click += label1_Click;
            // 
            // BaoCaoDoanhThuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlSPBanChay);
            Controls.Add(pnlBieuDo);
            Controls.Add(pnlDoanhThu);
            Controls.Add(btnBaoCao);
            Controls.Add(lbTuNgay);
            Controls.Add(lbDenNgay);
            Controls.Add(btnDTPK2);
            Controls.Add(btnDTPK1);
            Name = "BaoCaoDoanhThuForm";
            Text = "BaoCaoDoanhThuForm";
            pnlBieuDo.ResumeLayout(false);
            pnlBieuDo.PerformLayout();
            pnlSPBanChay.ResumeLayout(false);
            pnlSPBanChay.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker btnDTPK1;
        private DateTimePicker btnDTPK2;
        private Label lbDenNgay;
        private Label lbTuNgay;
        private Button btnBaoCao;
        private Panel pnlDoanhThu;
        private Panel pnlBieuDo;
        private Panel pnlSPBanChay;
        private Label lbBieuDo;
        private Label lbSPBanChay;
    }
}