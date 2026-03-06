namespace WinFormsApp1.GUI.AdminGUI
{
    partial class AdminGUI
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
            panel3 = new Panel();
            panel8 = new Panel();
            label2 = new Label();
            pnContent = new Panel();
            label3 = new Label();
            panel2 = new Panel();
            panel5 = new Panel();
            button1 = new Button();
            panel4 = new Panel();
            panel6 = new Panel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnTableBilliard = new Button();
            btnNhanVien = new Button();
            btnFood = new Button();
            btnDoanhThu = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel8.SuspendLayout();
            pnContent.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1384, 761);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(panel8);
            panel3.Controls.Add(pnContent);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(336, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1048, 761);
            panel3.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.BorderStyle = BorderStyle.Fixed3D;
            panel8.Controls.Add(label2);
            panel8.Dock = DockStyle.Top;
            panel8.Location = new Point(0, 0);
            panel8.Name = "panel8";
            panel8.Size = new Size(1048, 132);
            panel8.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 41);
            label2.Name = "label2";
            label2.Size = new Size(101, 27);
            label2.TabIndex = 0;
            label2.Text = "Hello AE";
            // 
            // pnContent
            // 
            pnContent.BorderStyle = BorderStyle.Fixed3D;
            pnContent.Controls.Add(label3);
            pnContent.Location = new Point(3, 138);
            pnContent.Name = "pnContent";
            pnContent.Size = new Size(1040, 620);
            pnContent.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(311, 266);
            label3.Name = "label3";
            label3.Size = new Size(436, 55);
            label3.TabIndex = 0;
            label3.Text = "WellCome To Billiard";
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightSlateGray;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(330, 761);
            panel2.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.LightSlateGray;
            panel5.Controls.Add(button1);
            panel5.Location = new Point(3, 603);
            panel5.Name = "panel5";
            panel5.Size = new Size(343, 119);
            panel5.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(88, 89);
            button1.Name = "button1";
            button1.Size = new Size(173, 27);
            button1.TabIndex = 0;
            button1.Text = "Đăng Xuất";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.BackColor = Color.LightSlateGray;
            panel4.Controls.Add(panel6);
            panel4.Controls.Add(flowLayoutPanel1);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(326, 585);
            panel4.TabIndex = 1;
            // 
            // panel6
            // 
            panel6.Controls.Add(label1);
            panel6.Dock = DockStyle.Top;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(326, 151);
            panel6.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 29);
            label1.Name = "label1";
            label1.Size = new Size(101, 27);
            label1.TabIndex = 0;
            label1.Text = "BiLLiard";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.LightSlateGray;
            flowLayoutPanel1.Controls.Add(btnTableBilliard);
            flowLayoutPanel1.Controls.Add(btnNhanVien);
            flowLayoutPanel1.Controls.Add(btnFood);
            flowLayoutPanel1.Controls.Add(btnDoanhThu);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Location = new Point(0, 253);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(326, 332);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnTableBilliard
            // 
            btnTableBilliard.Anchor = AnchorStyles.Top;
            btnTableBilliard.BackColor = Color.LightSlateGray;
            btnTableBilliard.FlatAppearance.BorderColor = Color.White;
            btnTableBilliard.FlatAppearance.BorderSize = 0;
            btnTableBilliard.FlatStyle = FlatStyle.Flat;
            btnTableBilliard.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnTableBilliard.ForeColor = SystemColors.ControlLightLight;
            btnTableBilliard.Location = new Point(3, 3);
            btnTableBilliard.Name = "btnTableBilliard";
            btnTableBilliard.Size = new Size(320, 37);
            btnTableBilliard.TabIndex = 2;
            btnTableBilliard.Text = "Bàn Billiard";
            btnTableBilliard.UseVisualStyleBackColor = false;
            btnTableBilliard.Click += btnTableBilliard_Click;
            // 
            // btnNhanVien
            // 
            btnNhanVien.Anchor = AnchorStyles.Top;
            btnNhanVien.BackColor = Color.LightSlateGray;
            btnNhanVien.FlatAppearance.BorderColor = Color.White;
            btnNhanVien.FlatAppearance.BorderSize = 0;
            btnNhanVien.FlatStyle = FlatStyle.Flat;
            btnNhanVien.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnNhanVien.ForeColor = SystemColors.ControlLightLight;
            btnNhanVien.Location = new Point(3, 46);
            btnNhanVien.Name = "btnNhanVien";
            btnNhanVien.Size = new Size(320, 37);
            btnNhanVien.TabIndex = 3;
            btnNhanVien.Text = "Nhân Viên";
            btnNhanVien.UseVisualStyleBackColor = false;
            btnNhanVien.Click += btnNhanVien_Click;
            // 
            // btnFood
            // 
            btnFood.Anchor = AnchorStyles.Top;
            btnFood.BackColor = Color.LightSlateGray;
            btnFood.FlatAppearance.BorderColor = Color.White;
            btnFood.FlatAppearance.BorderSize = 0;
            btnFood.FlatStyle = FlatStyle.Flat;
            btnFood.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnFood.ForeColor = SystemColors.ControlLightLight;
            btnFood.Location = new Point(3, 89);
            btnFood.Name = "btnFood";
            btnFood.Size = new Size(320, 37);
            btnFood.TabIndex = 1;
            btnFood.Text = "Đồ Ăn Thức Uống";
            btnFood.UseVisualStyleBackColor = false;
            btnFood.Click += btnFood_Click;
            // 
            // btnDoanhThu
            // 
            btnDoanhThu.Anchor = AnchorStyles.Top;
            btnDoanhThu.BackColor = Color.LightSlateGray;
            btnDoanhThu.FlatAppearance.BorderColor = Color.White;
            btnDoanhThu.FlatAppearance.BorderSize = 0;
            btnDoanhThu.FlatStyle = FlatStyle.Flat;
            btnDoanhThu.Font = new Font("Times New Roman", 18F, FontStyle.Bold);
            btnDoanhThu.ForeColor = SystemColors.ControlLightLight;
            btnDoanhThu.Location = new Point(3, 132);
            btnDoanhThu.Name = "btnDoanhThu";
            btnDoanhThu.Size = new Size(320, 37);
            btnDoanhThu.TabIndex = 0;
            btnDoanhThu.Text = "Doanh Thu";
            btnDoanhThu.UseVisualStyleBackColor = false;
            btnDoanhThu.Click += btnDoanhThu_Click;
            // 
            // AdminGUI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(1384, 761);
            Controls.Add(panel1);
            Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name = "AdminGUI";
            Text = "AdminGUI";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            pnContent.ResumeLayout(false);
            pnContent.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private Button button1;
        private Panel panel4;
        private Panel panel6;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnDoanhThu;
        private Button btnFood;
        private Button btnTableBilliard;
        private Button btnNhanVien;
        private Panel pnContent;
        private Panel panel8;
        private Label label2;
        private Label label3;
    }
}