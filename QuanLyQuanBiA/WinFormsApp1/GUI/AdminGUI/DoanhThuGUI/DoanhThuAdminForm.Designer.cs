namespace WinFormsApp1.GUI.AdminGUI.DoanhThuGUI
{
    partial class DoanhThuAdminForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            pnlBieuDo = new Panel();
            chartThang = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lbBieuDo = new Label();
            pnlDoanhThu = new Panel();
            dgvDoanhThu = new DataGridView();
            btnBaoCao = new Button();
            lbTuNgay = new Label();
            lbDenNgay = new Label();
            dtpdenNgay = new DateTimePicker();
            dtptuNgay = new DateTimePicker();
            pnlSPBanChay = new Panel();
            lbSPBanChay = new Label();
            pnlChoose = new Panel();
            pnlThongKe = new Panel();
            pnlDoanhThuNgay = new Panel();
            chartNgay = new System.Windows.Forms.DataVisualization.Charting.Chart();
            lbDoanhThuThang = new Label();
            pnlBieuDo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartThang).BeginInit();
            pnlDoanhThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).BeginInit();
            pnlSPBanChay.SuspendLayout();
            pnlChoose.SuspendLayout();
            pnlThongKe.SuspendLayout();
            pnlDoanhThuNgay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartNgay).BeginInit();
            SuspendLayout();
            // 
            // pnlBieuDo
            // 
            pnlBieuDo.BackColor = Color.FromArgb(0, 0, 64);
            pnlBieuDo.Controls.Add(chartThang);
            pnlBieuDo.Controls.Add(lbBieuDo);
            pnlBieuDo.Location = new Point(3, 0);
            pnlBieuDo.Name = "pnlBieuDo";
            pnlBieuDo.Size = new Size(235, 238);
            pnlBieuDo.TabIndex = 14;
            // 
            // chartThang
            // 
            chartArea1.Name = "ChartArea1";
            chartThang.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartThang.Legends.Add(legend1);
            chartThang.Location = new Point(0, 26);
            chartThang.Name = "chartThang";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartThang.Series.Add(series1);
            chartThang.Size = new Size(235, 211);
            chartThang.TabIndex = 1;
            chartThang.Text = "chart1";
            // 
            // lbBieuDo
            // 
            lbBieuDo.AutoSize = true;
            lbBieuDo.BackColor = Color.White;
            lbBieuDo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbBieuDo.Location = new Point(19, 6);
            lbBieuDo.Name = "lbBieuDo";
            lbBieuDo.Size = new Size(195, 17);
            lbBieuDo.TabIndex = 0;
            lbBieuDo.Text = "Biểu đồ doanh thu theo tháng";
            lbBieuDo.TextAlign = ContentAlignment.MiddleCenter;
            lbBieuDo.Click += lbBieuDo_Click;
            // 
            // pnlDoanhThu
            // 
            pnlDoanhThu.BackColor = SystemColors.AppWorkspace;
            pnlDoanhThu.Controls.Add(dgvDoanhThu);
            pnlDoanhThu.Dock = DockStyle.Bottom;
            pnlDoanhThu.Location = new Point(0, 254);
            pnlDoanhThu.Name = "pnlDoanhThu";
            pnlDoanhThu.Size = new Size(1024, 327);
            pnlDoanhThu.TabIndex = 13;
            // 
            // dgvDoanhThu
            // 
            dgvDoanhThu.AllowUserToAddRows = false;
            dgvDoanhThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDoanhThu.BackgroundColor = Color.White;
            dgvDoanhThu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDoanhThu.Location = new Point(3, -3);
            dgvDoanhThu.Name = "dgvDoanhThu";
            dgvDoanhThu.Size = new Size(1021, 324);
            dgvDoanhThu.TabIndex = 0;
            // 
            // btnBaoCao
            // 
            btnBaoCao.BackColor = Color.FromArgb(0, 192, 192);
            btnBaoCao.Dock = DockStyle.Bottom;
            btnBaoCao.Font = new Font("Times New Roman", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBaoCao.Location = new Point(0, 208);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Size = new Size(263, 30);
            btnBaoCao.TabIndex = 12;
            btnBaoCao.Text = "Báo Cáo";
            btnBaoCao.UseVisualStyleBackColor = false;
            btnBaoCao.Click += btnBaoCao_Click;
            // 
            // lbTuNgay
            // 
            lbTuNgay.BackColor = SystemColors.ActiveCaption;
            lbTuNgay.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTuNgay.Location = new Point(80, 12);
            lbTuNgay.Name = "lbTuNgay";
            lbTuNgay.Size = new Size(78, 19);
            lbTuNgay.TabIndex = 11;
            lbTuNgay.Text = "Từ ngày: ";
            lbTuNgay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lbDenNgay
            // 
            lbDenNgay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbDenNgay.AutoSize = true;
            lbDenNgay.BackColor = SystemColors.ActiveCaption;
            lbDenNgay.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDenNgay.Location = new Point(80, 88);
            lbDenNgay.Name = "lbDenNgay";
            lbDenNgay.Size = new Size(78, 19);
            lbDenNgay.TabIndex = 10;
            lbDenNgay.Text = "Đến ngày:";
            lbDenNgay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dtpdenNgay
            // 
            dtpdenNgay.Location = new Point(30, 133);
            dtpdenNgay.Name = "dtpdenNgay";
            dtpdenNgay.Size = new Size(200, 23);
            dtpdenNgay.TabIndex = 9;
            // 
            // dtptuNgay
            // 
            dtptuNgay.Location = new Point(30, 48);
            dtptuNgay.Name = "dtptuNgay";
            dtptuNgay.Size = new Size(200, 23);
            dtptuNgay.TabIndex = 8;
            // 
            // pnlSPBanChay
            // 
            pnlSPBanChay.BackColor = Color.LightCyan;
            pnlSPBanChay.BorderStyle = BorderStyle.FixedSingle;
            pnlSPBanChay.Controls.Add(lbSPBanChay);
            pnlSPBanChay.Location = new Point(507, 0);
            pnlSPBanChay.Name = "pnlSPBanChay";
            pnlSPBanChay.Size = new Size(240, 238);
            pnlSPBanChay.TabIndex = 15;
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
            // 
            // pnlChoose
            // 
            pnlChoose.Controls.Add(btnBaoCao);
            pnlChoose.Controls.Add(dtpdenNgay);
            pnlChoose.Controls.Add(dtptuNgay);
            pnlChoose.Controls.Add(lbDenNgay);
            pnlChoose.Controls.Add(lbTuNgay);
            pnlChoose.Location = new Point(2, 10);
            pnlChoose.Name = "pnlChoose";
            pnlChoose.Size = new Size(263, 238);
            pnlChoose.TabIndex = 14;
            // 
            // pnlThongKe
            // 
            pnlThongKe.Controls.Add(pnlBieuDo);
            pnlThongKe.Controls.Add(pnlDoanhThuNgay);
            pnlThongKe.Controls.Add(pnlSPBanChay);
            pnlThongKe.Location = new Point(271, 10);
            pnlThongKe.Name = "pnlThongKe";
            pnlThongKe.Size = new Size(747, 238);
            pnlThongKe.TabIndex = 15;
            // 
            // pnlDoanhThuNgay
            // 
            pnlDoanhThuNgay.BackColor = SystemColors.ActiveCaption;
            pnlDoanhThuNgay.Controls.Add(chartNgay);
            pnlDoanhThuNgay.Controls.Add(lbDoanhThuThang);
            pnlDoanhThuNgay.Location = new Point(244, 2);
            pnlDoanhThuNgay.Name = "pnlDoanhThuNgay";
            pnlDoanhThuNgay.Size = new Size(257, 238);
            pnlDoanhThuNgay.TabIndex = 16;
            // 
            // chartNgay
            // 
            chartArea2.Name = "ChartArea1";
            chartNgay.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            chartNgay.Legends.Add(legend2);
            chartNgay.Location = new Point(3, 34);
            chartNgay.Name = "chartNgay";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            chartNgay.Series.Add(series2);
            chartNgay.Size = new Size(257, 202);
            chartNgay.TabIndex = 1;
            chartNgay.Text = "chart2";
            // 
            // lbDoanhThuThang
            // 
            lbDoanhThuThang.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lbDoanhThuThang.BackColor = SystemColors.ButtonFace;
            lbDoanhThuThang.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbDoanhThuThang.Location = new Point(31, 4);
            lbDoanhThuThang.Name = "lbDoanhThuThang";
            lbDoanhThuThang.Size = new Size(203, 27);
            lbDoanhThuThang.TabIndex = 0;
            lbDoanhThuThang.Text = "Biểu đồ doanh thu theo ngày";
            // 
            // DoanhThuAdminForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(1024, 581);
            Controls.Add(pnlDoanhThu);
            Controls.Add(pnlThongKe);
            Controls.Add(pnlChoose);
            Name = "DoanhThuAdminForm";
            Text = "DoanhThuForm";
            Load += DoanhThuAdminForm_Load;
            pnlBieuDo.ResumeLayout(false);
            pnlBieuDo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartThang).EndInit();
            pnlDoanhThu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDoanhThu).EndInit();
            pnlSPBanChay.ResumeLayout(false);
            pnlSPBanChay.PerformLayout();
            pnlChoose.ResumeLayout(false);
            pnlChoose.PerformLayout();
            pnlThongKe.ResumeLayout(false);
            pnlDoanhThuNgay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartNgay).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlBieuDo;
        private Label lbBieuDo;
        private Panel pnlDoanhThu;
        private Button btnBaoCao;
        private Label lbTuNgay;
        private Label lbDenNgay;
        private DateTimePicker dtpdenNgay;
        private DateTimePicker dtptuNgay;
        private Panel pnlSPBanChay;
        private Label lbSPBanChay;
        private Panel pnlChoose;
        private Panel pnlThongKe;
        private Panel pnlDoanhThuNgay;
        private Label lbDoanhThuThang;
        private DataGridView dgvDoanhThu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartThang;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNgay;
    }
}