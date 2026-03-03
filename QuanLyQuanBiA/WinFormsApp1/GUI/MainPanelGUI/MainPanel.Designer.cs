namespace WinFormsApp1.GUI
{
    partial class MainPanel1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel1));
            pnContent = new Panel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            btnTrangChu = new Button();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btnMenu = new Button();
            btnTinhTrangBan = new Button();
            btnLichSuThanhToan = new Button();
            btnLogout = new Button();
            panel3 = new Panel();
            lblDisplayName = new Label();
            label2 = new Label();
            panel1 = new Panel();
            pnContent.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnContent
            // 
            pnContent.BackColor = SystemColors.ControlLightLight;
            pnContent.BorderStyle = BorderStyle.Fixed3D;
            pnContent.Controls.Add(label1);
            resources.ApplyResources(pnContent, "pnContent");
            pnContent.ForeColor = SystemColors.ControlText;
            pnContent.Name = "pnContent";
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Green;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(btnLogout);
            resources.ApplyResources(flowLayoutPanel1, "flowLayoutPanel1");
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnTrangChu);
            resources.ApplyResources(panel2, "panel2");
            panel2.Name = "panel2";
            // 
            // btnTrangChu
            // 
            btnTrangChu.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnTrangChu.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnTrangChu, "btnTrangChu");
            btnTrangChu.ForeColor = SystemColors.ButtonHighlight;
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.UseVisualStyleBackColor = true;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.BackColor = Color.Green;
            flowLayoutPanel2.Controls.Add(btnMenu);
            flowLayoutPanel2.Controls.Add(btnTinhTrangBan);
            flowLayoutPanel2.Controls.Add(btnLichSuThanhToan);
            resources.ApplyResources(flowLayoutPanel2, "flowLayoutPanel2");
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // btnMenu
            // 
            btnMenu.FlatAppearance.BorderColor = Color.FromArgb(0, 0, 0, 0);
            btnMenu.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnMenu, "btnMenu");
            btnMenu.ForeColor = SystemColors.ButtonHighlight;
            btnMenu.Name = "btnMenu";
            btnMenu.UseVisualStyleBackColor = true;
            btnMenu.Click += btnMenu_Click;
            // 
            // btnTinhTrangBan
            // 
            btnTinhTrangBan.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnTinhTrangBan, "btnTinhTrangBan");
            btnTinhTrangBan.ForeColor = SystemColors.ButtonHighlight;
            btnTinhTrangBan.Name = "btnTinhTrangBan";
            btnTinhTrangBan.UseVisualStyleBackColor = true;
            btnTinhTrangBan.Click += btnTinhTrangBan_Click;
            // 
            // btnLichSuThanhToan
            // 
            btnLichSuThanhToan.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnLichSuThanhToan, "btnLichSuThanhToan");
            btnLichSuThanhToan.ForeColor = SystemColors.ButtonHighlight;
            btnLichSuThanhToan.Name = "btnLichSuThanhToan";
            btnLichSuThanhToan.UseVisualStyleBackColor = true;
            btnLichSuThanhToan.Click += btnLichSuThanhToan_Click;
            // 
            // btnLogout
            // 
            btnLogout.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(btnLogout, "btnLogout");
            btnLogout.ForeColor = SystemColors.ButtonHighlight;
            btnLogout.Name = "btnLogout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ControlLightLight;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(lblDisplayName);
            panel3.Controls.Add(label2);
            resources.ApplyResources(panel3, "panel3");
            panel3.Name = "panel3";
            // 
            // lblDisplayName
            // 
            resources.ApplyResources(lblDisplayName, "lblDisplayName");
            lblDisplayName.Name = "lblDisplayName";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // panel1
            // 
            panel1.Controls.Add(pnContent);
            resources.ApplyResources(panel1, "panel1");
            panel1.Name = "panel1";
            // 
            // MainPanel1
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            CancelButton = btnLogout;
            Controls.Add(panel1);
            Controls.Add(panel3);
            Controls.Add(flowLayoutPanel1);
            Name = "MainPanel1";
            pnContent.ResumeLayout(false);
            pnContent.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel pnContent;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btnLogout;
        private Button btnMenu;
        private Button btnTinhTrangBan;
        private Button btnLichSuThanhToan;
        private Label label1;
        private Panel panel3;
        private Label lblDisplayName;
        private Label label2;
        private Button btnTrangChu;
        private Panel panel1;
    }
}