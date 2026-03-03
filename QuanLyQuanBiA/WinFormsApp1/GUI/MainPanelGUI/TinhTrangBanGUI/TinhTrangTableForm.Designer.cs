namespace WinFormsApp1.GUI
{
    partial class TinhTrangTableForm
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
            panel1 = new Panel();
            panel2 = new Panel();
            panel8 = new Panel();
            lsvBill = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            lblTongTienFood = new Label();
            panel5 = new Panel();
            lblTongTien = new Label();
            btnThanhToan = new Button();
            panel4 = new Panel();
            cbChuyenBan = new ComboBox();
            btnChuyenBan = new Button();
            lblGioChoi = new Label();
            lblTongTienTable = new Label();
            btnDong = new Button();
            lblDateCheckIn = new Label();
            lblDateCheckOut = new Label();
            label5 = new Label();
            label4 = new Label();
            lblNameTable = new Label();
            panel7 = new Panel();
            flpTable = new FlowLayoutPanel();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel8.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel7.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(panel7);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1024, 581);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(panel8);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(504, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(518, 579);
            panel2.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Controls.Add(lsvBill);
            panel8.Controls.Add(lblTongTienFood);
            panel8.Location = new Point(0, 145);
            panel8.Name = "panel8";
            panel8.Size = new Size(515, 344);
            panel8.TabIndex = 3;
            // 
            // lsvBill
            // 
            lsvBill.BorderStyle = BorderStyle.FixedSingle;
            lsvBill.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvBill.Dock = DockStyle.Top;
            lsvBill.Font = new Font("Times New Roman", 12.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lsvBill.Location = new Point(0, 0);
            lsvBill.Name = "lsvBill";
            lsvBill.Size = new Size(515, 293);
            lsvBill.TabIndex = 0;
            lsvBill.UseCompatibleStateImageBehavior = false;
            lsvBill.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Tên Món";
            columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Số Lượng";
            columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Đơn Giá";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Thành Tiền";
            columnHeader4.Width = 103;
            // 
            // lblTongTienFood
            // 
            lblTongTienFood.Anchor = AnchorStyles.Top;
            lblTongTienFood.AutoSize = true;
            lblTongTienFood.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTienFood.Location = new Point(218, 296);
            lblTongTienFood.Name = "lblTongTienFood";
            lblTongTienFood.Size = new Size(42, 15);
            lblTongTienFood.TabIndex = 0;
            lblTongTienFood.Text = "0 VNĐ";
            // 
            // panel5
            // 
            panel5.BackColor = Color.DarkCyan;
            panel5.BorderStyle = BorderStyle.Fixed3D;
            panel5.Controls.Add(lblTongTien);
            panel5.Controls.Add(btnThanhToan);
            panel5.Dock = DockStyle.Bottom;
            panel5.ForeColor = SystemColors.ControlLightLight;
            panel5.Location = new Point(0, 495);
            panel5.Name = "panel5";
            panel5.Size = new Size(516, 82);
            panel5.TabIndex = 2;
            // 
            // lblTongTien
            // 
            lblTongTien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(151, 0);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(105, 22);
            lblTongTien.TabIndex = 1;
            lblTongTien.Text = "Tổng Tiền: ";
            // 
            // btnThanhToan
            // 
            btnThanhToan.BackColor = Color.Red;
            btnThanhToan.FlatAppearance.BorderColor = Color.Teal;
            btnThanhToan.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThanhToan.Location = new Point(151, 40);
            btnThanhToan.Name = "btnThanhToan";
            btnThanhToan.Size = new Size(203, 35);
            btnThanhToan.TabIndex = 0;
            btnThanhToan.Text = "Thanh Toán";
            btnThanhToan.UseVisualStyleBackColor = false;
            btnThanhToan.Click += btnThanhToan_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.DarkCyan;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(cbChuyenBan);
            panel4.Controls.Add(btnChuyenBan);
            panel4.Controls.Add(lblGioChoi);
            panel4.Controls.Add(lblTongTienTable);
            panel4.Controls.Add(btnDong);
            panel4.Controls.Add(lblDateCheckIn);
            panel4.Controls.Add(lblDateCheckOut);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(lblNameTable);
            panel4.Dock = DockStyle.Top;
            panel4.ForeColor = SystemColors.ControlLightLight;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(516, 139);
            panel4.TabIndex = 1;
            // 
            // cbChuyenBan
            // 
            cbChuyenBan.FormattingEnabled = true;
            cbChuyenBan.Location = new Point(216, 5);
            cbChuyenBan.Name = "cbChuyenBan";
            cbChuyenBan.Size = new Size(80, 23);
            cbChuyenBan.TabIndex = 8;
            // 
            // btnChuyenBan
            // 
            btnChuyenBan.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnChuyenBan.BackColor = Color.SteelBlue;
            btnChuyenBan.Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChuyenBan.Location = new Point(302, 3);
            btnChuyenBan.Name = "btnChuyenBan";
            btnChuyenBan.Size = new Size(102, 35);
            btnChuyenBan.TabIndex = 5;
            btnChuyenBan.Text = "Chuyển Bàn";
            btnChuyenBan.UseVisualStyleBackColor = false;
            btnChuyenBan.Click += btnChuyenBan_Click;
            // 
            // lblGioChoi
            // 
            lblGioChoi.AutoSize = true;
            lblGioChoi.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGioChoi.Location = new Point(318, 97);
            lblGioChoi.Name = "lblGioChoi";
            lblGioChoi.Size = new Size(61, 15);
            lblGioChoi.TabIndex = 7;
            lblGioChoi.Text = "Giờ Chơi:";
            // 
            // lblTongTienTable
            // 
            lblTongTienTable.AutoSize = true;
            lblTongTienTable.Font = new Font("Times New Roman", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTongTienTable.Location = new Point(318, 116);
            lblTongTienTable.Name = "lblTongTienTable";
            lblTongTienTable.Size = new Size(79, 15);
            lblTongTienTable.TabIndex = 6;
            lblTongTienTable.Text = "Tổng: 0 VNĐ";
            // 
            // btnDong
            // 
            btnDong.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnDong.BackColor = Color.Teal;
            btnDong.FlatAppearance.BorderSize = 0;
            btnDong.Font = new Font("Times New Roman", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDong.ForeColor = SystemColors.ControlLightLight;
            btnDong.Location = new Point(411, 3);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(98, 35);
            btnDong.TabIndex = 5;
            btnDong.Text = "Đóng Bàn";
            btnDong.UseVisualStyleBackColor = false;
            btnDong.Click += btnDong_Click;
            // 
            // lblDateCheckIn
            // 
            lblDateCheckIn.AutoSize = true;
            lblDateCheckIn.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateCheckIn.Location = new Point(151, 41);
            lblDateCheckIn.Name = "lblDateCheckIn";
            lblDateCheckIn.Size = new Size(67, 16);
            lblDateCheckIn.TabIndex = 4;
            lblDateCheckIn.Text = "------------";
            // 
            // lblDateCheckOut
            // 
            lblDateCheckOut.AutoSize = true;
            lblDateCheckOut.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateCheckOut.Location = new Point(151, 73);
            lblDateCheckOut.Name = "lblDateCheckOut";
            lblDateCheckOut.Size = new Size(67, 16);
            lblDateCheckOut.TabIndex = 3;
            lblDateCheckOut.Text = "------------";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(1, 72);
            label5.Name = "label5";
            label5.Size = new Size(124, 17);
            label5.TabIndex = 2;
            label5.Text = "Thời gian đóng bàn:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 41);
            label4.Name = "label4";
            label4.Size = new Size(114, 17);
            label4.TabIndex = 1;
            label4.Text = "Thời gian mở bàn:";
            // 
            // lblNameTable
            // 
            lblNameTable.AutoSize = true;
            lblNameTable.Font = new Font("Times New Roman", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNameTable.Location = new Point(3, 3);
            lblNameTable.Name = "lblNameTable";
            lblNameTable.Size = new Size(61, 26);
            lblNameTable.TabIndex = 0;
            lblNameTable.Text = "Bàn:";
            // 
            // panel7
            // 
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(flpTable);
            panel7.Controls.Add(panel3);
            panel7.Dock = DockStyle.Left;
            panel7.Location = new Point(0, 0);
            panel7.Name = "panel7";
            panel7.Size = new Size(493, 579);
            panel7.TabIndex = 0;
            // 
            // flpTable
            // 
            flpTable.AutoScroll = true;
            flpTable.BackColor = SystemColors.ControlLightLight;
            flpTable.BorderStyle = BorderStyle.Fixed3D;
            flpTable.Dock = DockStyle.Bottom;
            flpTable.Location = new Point(0, 103);
            flpTable.Name = "flpTable";
            flpTable.Size = new Size(491, 474);
            flpTable.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(pictureBox2);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(491, 91);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Green;
            pictureBox1.Location = new Point(102, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Red;
            pictureBox2.Location = new Point(281, 8);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 50);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(275, 61);
            label2.Name = "label2";
            label2.Size = new Size(113, 19);
            label2.TabIndex = 1;
            label2.Text = "Đang Sử Dụng";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(126, 61);
            label1.Name = "label1";
            label1.Size = new Size(53, 19);
            label1.TabIndex = 0;
            label1.Text = "Trống";
            // 
            // TinhTrangTableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1024, 581);
            ControlBox = false;
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "TinhTrangTableForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "TinhTrangTableForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel7.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel8;
        private ListView lsvBill;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label lblTongTienFood;
        private Panel panel5;
        private Label lblTongTien;
        private Button btnThanhToan;
        private Panel panel4;
        private ComboBox cbChuyenBan;
        private Button btnChuyenBan;
        private Label lblGioChoi;
        private Label lblTongTienTable;
        private Button btnDong;
        private Label lblDateCheckIn;
        private Label lblDateCheckOut;
        private Label label5;
        private Label label4;
        private Label lblNameTable;
        private Panel panel7;
        private FlowLayoutPanel flpTable;
        private Panel panel3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private Label label1;
    }
}